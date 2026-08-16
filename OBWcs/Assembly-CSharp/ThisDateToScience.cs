using System;
using UnityEngine;

// Token: 0x0200003C RID: 60
public class ThisDateToScience : MonoBehaviour
{
	// Token: 0x06000107 RID: 263 RVA: 0x0015ABC8 File Offset: 0x00158DC8
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		if (this.global1.data[216] >= 50)
		{
			this.this_year = 3232;
		}
		if (this.global1.data[21] < this.this_year)
		{
			base.GetComponent<OkoshkoScript>().text = "Стоимость возрастёт\nиз-за несоответствия времени:\n" + ((this.this_year - this.global1.data[21]) * 2).ToString() + " из бюджета";
			base.GetComponent<OkoshkoScript>().text_en = " 由 于 年 份 不 对 应\n 价 格 将 上 涨:\n" + ((this.this_year - this.global1.data[21]) * 2).ToString() + "  预 算";
			return;
		}
		base.GetComponent<OkoshkoScript>().text = "Стоимость:\n1 из бюджета";
		base.GetComponent<OkoshkoScript>().text_en = " 价 格:\n1  预 算";
	}

	// Token: 0x0400019D RID: 413
	private GlobalScript global1;

	// Token: 0x0400019E RID: 414
	public int this_year = 1989;
}
