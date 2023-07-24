// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using Microsoft.AspNetCore.Components;

namespace AntDesign
{
    public partial class Watermark : AntDomComponentBase
    {
        [Parameter] public string Width { get; set; } = "120px";

        [Parameter] public string Height { get; set; } = "64px";

        [Parameter] public int Rotate { get; set; } = -22;

        [Parameter] public float Opacity { get; set; } = 0.5f;

        [Parameter] public string FontSize { get; set; } = "14px";

        [Parameter] public string FontColor { get; set; } = "rgba(0,0,0,.15)";

        [Parameter] public string FontFamily { get; set; } = "sans-serif";

        [Parameter] public string FontWeight { get; set; } = "normal";

        [Parameter] public string FontStyle { get; set; } = "normal";

        [Parameter] public string Content { get; set; }

        [Parameter] public string[] Contents { get; set; }

        [Parameter] public int ZIndex { get; set; } = 9;

        [Parameter] public (int X, int Y) Gap { get; set; } = (100, 100);

        [Parameter] public string Image { get; set; }

        [Parameter] public (int X, int Y) Offset { get; set; }
 
        [Parameter] public RenderFragment ChildContent { get; set; }


        public string GetSvg()
        {
            var content = Image != null ?
                $"""
                <image xlink:href="{Image}" width="{Width}" height="{Height}" />
                """
                :
                $"""
                <text x="50%" y="50%" dy="12px" width="{Width}" height="{Height}"
                   text-anchor="middle"
                   stroke="#000000"
                   stroke-width="1"
                   fill="none"
                   font-weight="{FontWeight}"
                   font-style="{FontStyle}"
                   font-family="{FontFamily}"
                   font-size="{FontSize}"
                   style="
                      transform: rotate({Rotate}deg);
                      stroke: {FontColor};
                   ">
                   {HttpUtility.HtmlEncode(Content)}
                </text>
                """;

            var svgStr = $"""
                  <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink">
                    {content}
                  </svg>
                  """;

            var base64Url = $"data:image/svg+xml;base64,{Convert.ToBase64String(Encoding.Default.GetBytes(svgStr))}";

            var styleStr = $"""
                    position: absolute;
                    top: 0;
                    height: 100%;
                    width: 100%;
                    z-index: {ZIndex};
                    pointer-events:none;
                    background-repeat:repeat;
                    background-image:url('{base64Url}');
                    """;

            return styleStr;
        }
    }
}
