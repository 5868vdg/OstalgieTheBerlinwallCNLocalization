using System;
using UnityEngine;

// Token: 0x02000029 RID: 41
public class OnButtonEndingScript : MonoBehaviour
{
	// Token: 0x060000B6 RID: 182 RVA: 0x00034D6C File Offset: 0x00032F6C
	private void OnMouseDown()
	{
		if (this.is_left)
		{
			if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51 && this.end1.this_okno >= 0 && this.end1.this_okno <= 2)
			{
				if (this.end1.this_vrem > 0)
				{
					this.end1.this_vrem--;
				}
				else
				{
					this.end1.this_okno = -1;
				}
			}
			else if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51 && this.end1.this_okno == 3)
			{
				this.end1.this_vrem = 11 + this.global1.data[222];
				this.end1.this_okno = 0;
			}
			else
			{
				this.end1.this_okno--;
				if (this.end1.this_okno == 2 && this.global1.data[0] == 12)
				{
					this.end1.this_okno--;
				}
			}
		}
		else if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51 && this.end1.this_okno == 0)
		{
			if (this.end1.this_vrem < 11 + this.global1.data[222])
			{
				this.end1.this_vrem++;
			}
			else
			{
				this.end1.this_okno = 3;
			}
		}
		else
		{
			this.end1.this_okno++;
			if (this.end1.this_okno == 2 && this.global1.data[0] == 12)
			{
				this.end1.this_okno++;
			}
		}
		this.end1.ChangeOkno();
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x0000297D File Offset: 0x00000B7D
	private void OnMouseEnter()
	{
		if (this.global1.data[46] == 0)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.navel;
		}
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x000029A0 File Offset: 0x00000BA0
	private void OnMouseExit()
	{
		if (this.global1.data[46] == 0)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.nenavel;
		}
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x000029C3 File Offset: 0x00000BC3
	private void Awake()
	{
		this.global1 = this.end1.global1;
	}

	// Token: 0x04000141 RID: 321
	public ending_script end1;

	// Token: 0x04000142 RID: 322
	private GlobalScript global1;

	// Token: 0x04000143 RID: 323
	public bool is_left;

	// Token: 0x04000144 RID: 324
	public Sprite navel;

	// Token: 0x04000145 RID: 325
	public Sprite nenavel;
}
