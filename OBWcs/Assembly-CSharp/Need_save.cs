using System;
using UnityEngine;

// Token: 0x02000026 RID: 38
public class Need_save : MonoBehaviour
{
	// Token: 0x060000AA RID: 170 RVA: 0x000028EF File Offset: 0x00000AEF
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.Textotext();
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00034AE4 File Offset: 0x00032CE4
	private void Textotext()
	{
		if (PlayerPrefs.GetInt("language") == 0)
		{
			if (this.global1.autosave == 0)
			{
				this.text.text = " 无";
				return;
			}
			if (this.global1.autosave == 1)
			{
				this.text.text = " 每 月";
				return;
			}
			if (this.global1.autosave == 2)
			{
				this.text.text = " 每 半 年";
				return;
			}
		}
		else
		{
			if (this.global1.autosave == 0)
			{
				this.text.text = "Нет";
				return;
			}
			if (this.global1.autosave == 1)
			{
				this.text.text = "Ежемес.";
				return;
			}
			if (this.global1.autosave == 2)
			{
				this.text.text = "Полгода";
			}
		}
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00034BB4 File Offset: 0x00032DB4
	private void OnMouseDown()
	{
		if (this.is_right)
		{
			if (this.global1.autosave < 2)
			{
				this.global1.autosave++;
			}
			else
			{
				this.global1.autosave = 0;
			}
		}
		else if (this.global1.autosave > 0)
		{
			this.global1.autosave--;
		}
		else
		{
			this.global1.autosave = 2;
		}
		PlayerPrefs.SetInt("autosave_check", this.global1.autosave);
		this.Textotext();
	}

	// Token: 0x04000135 RID: 309
	public bool is_right;

	// Token: 0x04000136 RID: 310
	public TextMesh text;

	// Token: 0x04000137 RID: 311
	private GlobalScript global1;
}
