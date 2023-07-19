---
category: Components
subtitle: ˮӡ
type: ����
title: Watermark
cover: https://mdn.alipayobjects.com/huamei_7uahnr/afts/img/A*wr1ISY50SyYAAAAAAAAAAAAADrJ8AQ/original
cols: 1
---

��ҳ���ĳ���������ˮӡ��

## ��ʱʹ��

- ҳ����Ҫ���ˮӡ��ʶ��Ȩʱʹ�á�
- �����ڷ�ֹ��Ϣ���á�


## API

### Watermark

| ���� | ˵�� | ���� | Ĭ��ֵ | �汾 |
| --- | --- | --- | --- | --- |
| width | ˮӡ�Ŀ�ȣ�`content` ��Ĭ��ֵΪ����Ŀ�� | number | 120 |  |
| height | ˮӡ�ĸ߶ȣ�`content` ��Ĭ��ֵΪ����ĸ߶� | number | 64 |  |
| rotate | ˮӡ����ʱ����ת�ĽǶȣ���λ `��` | number | -22 |  |
| zIndex | ׷�ӵ�ˮӡԪ�ص� z-index | number | 9 |  |
| image | ͼƬԴ�����鵼�� 2 ���� 3 ��ͼ�����ȼ��� (֧�� base64 ��ʽ) | string | - |  |
| content | ˮӡ�������� | string \| string[] | - |  |
| font | ������ʽ | [Font](#font) | [Font](#font) |  |
| gap | ˮӡ֮��ļ�� | \[number, number\] | \[100, 100\] |  |
| offset | ˮӡ�����������Ͻǵ�ƫ������Ĭ��Ϊ `gap/2` | \[number, number\] | \[gap\[0\]/2, gap\[1\]/2\] |  |

### Font

<!-- prettier-ignore -->
| ���� | ˵�� | ���� | Ĭ��ֵ | �汾 |
| --- | --- | --- | --- | --- |
| color | ������ɫ | string | rgba(0,0,0,.15) |  |
| fontSize | �����С | number | 16 |  |
| fontWeight | �����ϸ | `normal` \| `light` \| `weight` \| number | normal |  |
| fontFamily | �������� | string | sans-serif |  |
| fontStyle | ������ʽ | `none` \| `normal` \| `italic` \| `oblique` | normal |  |

## FAQ

### �����쳣ͼƬˮӡ

��ʹ��ͼƬˮӡ��ͼƬ�����쳣ʱ������ͬʱ��� `content` ��ֹˮӡʧЧ���� 5.2.3 ��ʼ֧�֣���

```typescript jsx
<Watermark
  height={30}
  width={130}
  content="Ant Design"
  image="https://mdn.alipayobjects.com/huamei_7uahnr/afts/img/A*lkAoRbywo0oAAAAAAAAAAAAADrJ8AQ/original"
>
  <div style={{ height: 500 }} />
</Watermark>
```