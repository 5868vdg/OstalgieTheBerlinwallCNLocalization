using System;
using UnityEngine;

// Token: 0x02000030 RID: 48
public class Politic_party_name_show : MonoBehaviour
{
	// Token: 0x060000D3 RID: 211 RVA: 0x00035C94 File Offset: 0x00033E94
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		base.GetComponent<TextMesh>().text = this.global1.party_name[this.this_number];
		if (this.global1.party_ideology[this.this_number] == 1)
		{
			base.GetComponent<OkoshkoScript>().text = "Социал-демократы";
			base.GetComponent<OkoshkoScript>().text_en = " 社 会 民 主 党";
			OkoshkoScript component = base.GetComponent<OkoshkoScript>();
			component.text += "\n(Линия Партии:\nРеформизм/Центризм)";
			OkoshkoScript component2 = base.GetComponent<OkoshkoScript>();
			component2.text_en += "\n( 党 内 路 线:\n 改 良 主 义/ 中 间 主 义)";
			return;
		}
		if (this.global1.party_ideology[this.this_number] == 2)
		{
			base.GetComponent<OkoshkoScript>().text = "Центристы";
			base.GetComponent<OkoshkoScript>().text_en = " 中 间 党";
			OkoshkoScript component3 = base.GetComponent<OkoshkoScript>();
			component3.text += "\n(Линия Партии:\nЦентризм/Правость)";
			OkoshkoScript component4 = base.GetComponent<OkoshkoScript>();
			component4.text_en += "\n( 党 内 路 线:\n 中 间 主 义/ 右 翼)";
			return;
		}
		if (this.global1.party_ideology[this.this_number] == 3)
		{
			base.GetComponent<OkoshkoScript>().text = "Правые";
			base.GetComponent<OkoshkoScript>().text_en = " 右 翼 党";
			OkoshkoScript component5 = base.GetComponent<OkoshkoScript>();
			component5.text += "\n(Линия Партии:\nЭтатизм/Правость)";
			OkoshkoScript component6 = base.GetComponent<OkoshkoScript>();
			component6.text_en += "\n( 党 内 路 线:\n 国 家 主 义/ 右 翼)";
			return;
		}
		if (this.global1.party_ideology[this.this_number] == 10)
		{
			if (this.global1.data[0] != 2 || this.global1.data[0] != 38)
			{
				base.GetComponent<OkoshkoScript>().text = "Леворадикалы";
				base.GetComponent<OkoshkoScript>().text_en = " 左 翼 激 进 党";
			}
			else
			{
				base.GetComponent<OkoshkoScript>().text = "Праворадикалы";
				base.GetComponent<OkoshkoScript>().text_en = " 右 翼 激 进 党";
			}
			OkoshkoScript component7 = base.GetComponent<OkoshkoScript>();
			component7.text += "\n(Линия Партии:\nЭтатизм)";
			OkoshkoScript component8 = base.GetComponent<OkoshkoScript>();
			component8.text_en += "\n( 党 内 路 线:\n 国 家 主 义)";
		}
	}

	// Token: 0x0400015B RID: 347
	private GlobalScript global1;

	// Token: 0x0400015C RID: 348
	public int this_number;
}
