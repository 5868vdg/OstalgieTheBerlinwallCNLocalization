using System;
using UnityEngine;

// Token: 0x02000032 RID: 50
public class RegionChangeScript : MonoBehaviour
{
	// Token: 0x060000D8 RID: 216 RVA: 0x00002B22 File Offset: 0x00000D22
	public void Repaint()
	{
		if (this.bl1.now_region == this.this_number)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.on;
			return;
		}
		base.GetComponent<SpriteRenderer>().sprite = this.off;
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00036040 File Offset: 0x00034240
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		if (this.bl1.now_region == this.this_number)
		{
			this.Regione.text = this.Regiont.text;
		}
		if (this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51)
		{
			this.yug1 = GameObject.Find("Yugoglobal(Clone)").GetComponent<Yugoglobal>();
		}
	}

	// Token: 0x060000DA RID: 218 RVA: 0x000360D4 File Offset: 0x000342D4
	private void OnMouseEnter()
	{
		if (this.global1.data[0] != 12 || this.this_number == 2 || (this.this_number == 0 && this.global1.data[93] == 1) || (this.this_number == 1 && this.global1.data[92] == 1) || (this.this_number == 3 && this.global1.data[90] == 1) || (this.this_number == 4 && this.global1.data[94] == 1))
		{
			base.GetComponent<SpriteRenderer>().sprite = this.on;
			return;
		}
		base.GetComponent<SpriteRenderer>().sprite = this.off;
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00036188 File Offset: 0x00034388
	private void OnMouseExit()
	{
		if (this.global1.data[0] != 12)
		{
			this.Repaint();
			return;
		}
		if (this.this_number == 2 || (this.this_number == 0 && this.global1.data[93] == 1) || (this.this_number == 1 && this.global1.data[92] == 1) || (this.this_number == 3 && this.global1.data[90] == 1) || (this.this_number == 4 && this.global1.data[94] == 1))
		{
			this.Repaint();
			return;
		}
		base.GetComponent<SpriteRenderer>().sprite = this.off;
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00036238 File Offset: 0x00034438
	private void OnMouseDown()
	{
		if (this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51)
		{
			this.bl1.yugreg[0] = -1;
			this.bl1.yugreg[1] = -1;
			this.bl1.yugreg[2] = -1;
			this.bl1.yugown[0] = false;
			this.bl1.yugown[1] = false;
			this.bl1.yugown[2] = false;
			for (int i = 0; i < this.yug1.gameState.yugregions.Length; i++)
			{
				if (this.yug1.gameState.yugregions[i].inreg == this.this_number)
				{
					if (this.bl1.yugreg[0] == -1)
					{
						this.bl1.yugreg[0] = i;
						if (this.yug1.gameState.yugcountries[this.yug1.gameState.yugregions[i].owner].is_player)
						{
							this.bl1.yugown[0] = true;
						}
					}
					else if (this.bl1.yugreg[1] == -1)
					{
						this.bl1.yugreg[1] = i;
						if (this.yug1.gameState.yugcountries[this.yug1.gameState.yugregions[i].owner].is_player)
						{
							this.bl1.yugown[1] = true;
						}
					}
					else if (this.bl1.yugreg[2] == -1)
					{
						this.bl1.yugreg[2] = i;
						if (this.yug1.gameState.yugcountries[this.yug1.gameState.yugregions[i].owner].is_player)
						{
							this.bl1.yugown[2] = true;
						}
					}
				}
			}
		}
		if (this.global1.data[0] != 12 || this.this_number == 2 || (this.this_number == 0 && this.global1.data[93] == 1) || (this.this_number == 1 && this.global1.data[92] == 1) || (this.this_number == 3 && this.global1.data[90] == 1) || (this.this_number == 4 && this.global1.data[94] == 1))
		{
			this.bl1.now_region = this.this_number;
			this.bl1.HideSelects();
			this.bl1.Repaint();
			this.Vyzov.text = "";
			this.Regione.text = this.Regiont.text;
		}
	}

	// Token: 0x04000160 RID: 352
	public int this_number;

	// Token: 0x04000161 RID: 353
	public BuildingManager bl1;

	// Token: 0x04000162 RID: 354
	public GlobalScript global1;

	// Token: 0x04000163 RID: 355
	public TextMesh Vyzov;

	// Token: 0x04000164 RID: 356
	public TextMesh Regiont;

	// Token: 0x04000165 RID: 357
	public TextMesh Regione;

	// Token: 0x04000166 RID: 358
	public Sprite on;

	// Token: 0x04000167 RID: 359
	public Sprite off;

	// Token: 0x04000168 RID: 360
	private Yugoglobal yug1;
}
