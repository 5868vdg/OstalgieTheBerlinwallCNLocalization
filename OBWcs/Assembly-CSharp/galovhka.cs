using System;
using UnityEngine;

// Token: 0x02000055 RID: 85
public class galovhka : MonoBehaviour
{
	// Token: 0x0600019E RID: 414 RVA: 0x001EF314 File Offset: 0x001ED514
	private void OnMouseDown()
	{
		if (this.this_num != this.Done1.this_otvet)
		{
			this.Done1.this_otvet = this.this_num;
			for (int i = 0; i < this.Done1.kolvo_variant; i++)
			{
				if (this.otveti[i] != null)
				{
					this.otveti[i].sprite = this.nenavel;
				}
			}
			base.GetComponent<SpriteRenderer>().sprite = this.navel;
		}
	}

	// Token: 0x0600019F RID: 415 RVA: 0x0000325B File Offset: 0x0000145B
	private void OnMouseEnter()
	{
		if (this.this_num != this.Done1.this_otvet)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.navel;
		}
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x00003281 File Offset: 0x00001481
	private void OnMouseExit()
	{
		if (this.this_num != this.Done1.this_otvet)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.nenavel;
		}
	}

	// Token: 0x04000263 RID: 611
	public doneventscript Done1;

	// Token: 0x04000264 RID: 612
	public Sprite navel;

	// Token: 0x04000265 RID: 613
	public Sprite nenavel;

	// Token: 0x04000266 RID: 614
	public int this_num;

	// Token: 0x04000267 RID: 615
	public SpriteRenderer[] otveti = new SpriteRenderer[6];
}
