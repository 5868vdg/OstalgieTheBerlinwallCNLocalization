using System;
using UnityEngine;

// Token: 0x0200004F RID: 79
public class at_war_script : MonoBehaviour
{
	// Token: 0x0600017E RID: 382 RVA: 0x0019EC10 File Offset: 0x0019CE10
	public void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
		{
			this.yug1 = GameObject.Find("Yugoglobal(Clone)").GetComponent<Yugoglobal>();
		}
	}

	// Token: 0x0600017F RID: 383 RVA: 0x0019EC6C File Offset: 0x0019CE6C
	public void Repaint()
	{
		if (this.global1 == null)
		{
			this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		}
		if (this.this_num == 15)
		{
			if (this.global1.event_done[48])
			{
				base.GetComponent<SpriteRenderer>().sprite = this.war;
			}
			if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
			{
				for (int i = 0; i < 12; i++)
				{
					for (int j = 0; j < 12; j++)
					{
						if (!this.yug1.gameState.yugcountries[i].peace_with[j] && this.yug1.gameState.yugregions[i].owner == i && this.yug1.gameState.yugregions[j].owner == j)
						{
							base.GetComponent<SpriteRenderer>().sprite = this.war;
						}
					}
				}
				return;
			}
		}
		else
		{
			if (this.this_num == 19 && this.global1.allcountries[19].Stasi)
			{
				base.GetComponent<SpriteRenderer>().sprite = this.war;
				return;
			}
			if (this.this_num == 14 && this.global1.event_done[53] && !this.global1.event_done[81] && !this.global1.allcountries[36].Vyshi)
			{
				base.GetComponent<SpriteRenderer>().sprite = this.war;
				return;
			}
			if (this.this_num == 23)
			{
				base.GetComponent<SpriteRenderer>().sprite = this.war;
				return;
			}
			if (this.this_num == 12 && this.global1.data[0] != 12)
			{
				base.GetComponent<SpriteRenderer>().sprite = this.war;
				return;
			}
			if (this.this_num == 12 && this.global1.data[0] == 12 && this.global1.data[88] > 0)
			{
				base.GetComponent<SpriteRenderer>().sprite = this.war;
				return;
			}
			if (this.this_num == 40 && this.global1.allcountries[40].Westalgie <= 800 && this.global1.allcountries[40].Westalgie > 0)
			{
				base.GetComponent<SpriteRenderer>().sprite = this.war;
				return;
			}
			if (this.this_num == 41 && this.global1.allcountries[40].Westalgie > 0 && this.global1.allcountries[41].Westalgie <= 950)
			{
				base.GetComponent<SpriteRenderer>().sprite = this.war;
				return;
			}
			if (this.this_num == 42 && this.global1.allcountries[42].Westalgie > 0 && this.global1.allcountries[42].Westalgie <= 950)
			{
				base.GetComponent<SpriteRenderer>().sprite = this.war;
				return;
			}
			if (this.this_num == 43 && this.global1.allcountries[43].Westalgie >= 200 && this.global1.allcountries[43].Westalgie <= 950)
			{
				base.GetComponent<SpriteRenderer>().sprite = this.war;
				return;
			}
			if (base.GetComponent<SpriteRenderer>().sprite != null)
			{
				base.GetComponent<SpriteRenderer>().sprite = null;
			}
		}
	}

	// Token: 0x0400021E RID: 542
	private GlobalScript global1;

	// Token: 0x0400021F RID: 543
	private Yugoglobal yug1;

	// Token: 0x04000220 RID: 544
	public Sprite war;

	// Token: 0x04000221 RID: 545
	public int this_num;
}
