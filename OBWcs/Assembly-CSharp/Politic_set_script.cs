using System;
using UnityEngine;

// Token: 0x02000031 RID: 49
public class Politic_set_script : MonoBehaviour
{
	// Token: 0x060000D5 RID: 213 RVA: 0x00002B0B File Offset: 0x00000D0B
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00035ECC File Offset: 0x000340CC
	private void OnMouseDown()
	{
		if (this.global1.data[this.dolshnost] != this.candidat)
		{
			this.global1.data[this.dolshnost] = this.candidat;
			if (this.global1.is_konst_max)
			{
				this.global1.data[1] -= 50;
				this.global1.data[4] += 10;
				this.global1.data[8]--;
			}
			else
			{
				this.global1.data[1] -= 50;
				this.global1.data[4] += 25;
				this.global1.data[8] -= 10;
			}
			for (int i = 0; i < 8; i++)
			{
				GameObject.Find("Text (" + i + ")").GetComponent<Politic_Data_Show_Script>().Update_This();
			}
			GameObject.Find("politiRealise2").transform.Find("Erich1").GetComponent<Min_show_script>().Repaint();
			GameObject.Find("politiRealise2").transform.Find("Erich2").GetComponent<Min_show_script>().Repaint();
			GameObject.Find("politiRealise2").transform.Find("Erich3").GetComponent<Min_show_script>().Repaint();
		}
	}

	// Token: 0x0400015D RID: 349
	public int dolshnost;

	// Token: 0x0400015E RID: 350
	public int candidat;

	// Token: 0x0400015F RID: 351
	private GlobalScript global1;
}
