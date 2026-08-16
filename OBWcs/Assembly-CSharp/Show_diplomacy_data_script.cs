using System;
using UnityEngine;

// Token: 0x02000037 RID: 55
public class Show_diplomacy_data_script : MonoBehaviour
{
	// Token: 0x060000F4 RID: 244 RVA: 0x00158BFC File Offset: 0x00156DFC
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.text = base.GetComponent<TextMesh>();
		this.okno = base.GetComponent<OkoshkoScript>();
		this.name_ru = this.okno.text;
		this.name_en = this.okno.text_en;
		this.Repaint();
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00002C63 File Offset: 0x00000E63
	private void Update()
	{
		this.Repaint();
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x00158C60 File Offset: 0x00156E60
	public void Repaint()
	{
		this.text.text = (((this.global1.data[this.num] < 0) ? "-" : "") + Mathf.Abs(this.global1.data[this.num] / 10).ToString()).ToString() + "." + Mathf.Abs(this.global1.data[this.num] % 10).ToString();
		if (PlayerPrefs.GetInt("language") == 0)
		{
			string text = string.Concat(new string[]
			{
				this.name_en,
				": ",
				(((this.global1.data_old[this.num] < 0) ? "-" : "+") + Mathf.Abs(this.global1.data_old[this.num] / 10).ToString()).ToString(),
				".",
				Mathf.Abs(this.global1.data_old[this.num] % 10).ToString()
			});
			if (this.okno.text_en != text)
			{
				this.okno.text_en = text;
			}
		}
		else
		{
			string text2 = string.Concat(new string[]
			{
				this.name_ru,
				": ",
				(((this.global1.data_old[this.num] < 0) ? "-" : "+") + Mathf.Abs(this.global1.data_old[this.num] / 10).ToString()).ToString(),
				".",
				Mathf.Abs(this.global1.data_old[this.num] % 10).ToString()
			});
			if (this.okno.text != text2)
			{
				this.okno.text = text2;
			}
		}
		if (this.num == 6)
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				if (this.global1.data[6] > 900)
				{
					OkoshkoScript okoshkoScript = this.okno;
					okoshkoScript.text_en += "\n<color=red> 威 权 主 义</color>";
					return;
				}
				if (this.global1.data[6] > 790)
				{
					OkoshkoScript okoshkoScript2 = this.okno;
					okoshkoScript2.text_en += "\n<color=red> 保 守 主 义</color>";
					return;
				}
				if (this.global1.data[6] > 690 && (this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51))
				{
					OkoshkoScript okoshkoScript3 = this.okno;
					okoshkoScript3.text += "\n<color=magenta> 铁 托 主 义</color>";
					return;
				}
				if (this.global1.data[6] > 590)
				{
					OkoshkoScript okoshkoScript4 = this.okno;
					okoshkoScript4.text_en += "\n<color=green> 温 和 派</color>";
					return;
				}
				if (this.global1.data[6] > 390)
				{
					OkoshkoScript okoshkoScript5 = this.okno;
					okoshkoScript5.text_en += "\n<color=green> 改 革 派</color>";
					return;
				}
				if (this.global1.data[6] > 190)
				{
					OkoshkoScript okoshkoScript6 = this.okno;
					okoshkoScript6.text_en += "\n<color=yellow> 自 由 派</color>";
					return;
				}
				OkoshkoScript okoshkoScript7 = this.okno;
				okoshkoScript7.text_en += "\n<color=yellow> 西 渐 派</color>";
				return;
			}
			else
			{
				if (this.global1.data[6] > 900)
				{
					OkoshkoScript okoshkoScript8 = this.okno;
					okoshkoScript8.text += "\n<color=red>Авторитарист</color>";
					return;
				}
				if (this.global1.data[6] > 790)
				{
					OkoshkoScript okoshkoScript9 = this.okno;
					okoshkoScript9.text += "\n<color=red>Консерватор</color>";
					return;
				}
				if (this.global1.data[6] > 690 && (this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51))
				{
					OkoshkoScript okoshkoScript10 = this.okno;
					okoshkoScript10.text += "\n<color=magenta>Титоист</color>";
					return;
				}
				if (this.global1.data[6] > 590)
				{
					OkoshkoScript okoshkoScript11 = this.okno;
					okoshkoScript11.text += "\n<color=green>Умеренный</color>";
					return;
				}
				if (this.global1.data[6] > 390)
				{
					OkoshkoScript okoshkoScript12 = this.okno;
					okoshkoScript12.text += "\n<color=green>Реформист</color>";
					return;
				}
				if (this.global1.data[6] > 190)
				{
					OkoshkoScript okoshkoScript13 = this.okno;
					okoshkoScript13.text += "\n<color=yellow>Либерал</color>";
					return;
				}
				OkoshkoScript okoshkoScript14 = this.okno;
				okoshkoScript14.text += "\n<color=yellow>Западник</color>";
			}
		}
	}

	// Token: 0x04000185 RID: 389
	private GlobalScript global1;

	// Token: 0x04000186 RID: 390
	public int num;

	// Token: 0x04000187 RID: 391
	private TextMesh text;

	// Token: 0x04000188 RID: 392
	private OkoshkoScript okno;

	// Token: 0x04000189 RID: 393
	private string name_ru;

	// Token: 0x0400018A RID: 394
	private string name_en;
}
