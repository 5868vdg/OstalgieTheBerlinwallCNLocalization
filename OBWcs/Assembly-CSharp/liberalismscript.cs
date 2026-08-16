using System;
using UnityEngine;

// Token: 0x02000058 RID: 88
public class liberalismscript : MonoBehaviour
{
	// Token: 0x060001AF RID: 431 RVA: 0x001F15D8 File Offset: 0x001EF7D8
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.text.text = this.global1.data[this.this_num].ToString() + "/10";
		if (this.this_num == 38 && this.global1.data[0] >= 49 && this.global1.data[0] <= 51 && !this.global1.event_done[271] && !this.global1.event_done[322] && !this.global1.event_done[344])
		{
			this.Repaint2();
			return;
		}
		if (this.this_num == 39 && this.global1.data[0] >= 49 && this.global1.data[0] <= 51 && !this.global1.event_done[287])
		{
			this.Repaint2();
			return;
		}
		if ((this.this_num != 39 && this.this_num != 38) || (this.this_num == 38 && !this.right) || (this.this_num == 38 && (this.global1.data[0] != 12 || this.global1.event_done[228])))
		{
			this.Repaint();
			return;
		}
		if (this.this_num == 39)
		{
			this.Repaint1();
			return;
		}
		if (this.this_num == 38 && this.right)
		{
			this.Repaint2();
		}
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x001F1760 File Offset: 0x001EF960
	private void OnMouseDown()
	{
		if (this.right && !this.global1.is_liber)
		{
			this.global1.data[this.this_num]++;
			if (this.global1.is_konst_max)
			{
				this.global1.data[8] -= 5;
				this.global1.data[1] += 10;
				this.global1.data[2] += 25;
				this.global1.data[22] -= 2;
				this.global1.data[10]--;
				this.global1.data[6] -= 8;
				this.global1.data[33] -= 2;
				this.global1.data[3] += 15;
				this.global1.data[4] += 5;
				if (this.global1.data[0] == 10)
				{
					this.global1.data[22] -= 2;
					this.global1.data[33] -= 2;
					this.global1.data[4] += 5;
				}
			}
			else
			{
				this.global1.data[8] -= 10;
				this.global1.data[1] += 10;
				this.global1.data[2] += 25;
				this.global1.data[22] -= 2;
				this.global1.data[10]--;
				this.global1.data[6] -= 8;
				this.global1.data[33] -= 2;
				this.global1.data[3] += 15;
				this.global1.data[4] += 20;
				if (this.global1.data[0] == 10)
				{
					this.global1.data[22] -= 2;
					this.global1.data[33] -= 2;
					this.global1.data[4] += 5;
				}
			}
			this.global1.is_liber = true;
			for (int i = 0; i < 8; i++)
			{
				GameObject.Find("Text (" + i + ")").GetComponent<Politic_Data_Show_Script>().Update_This();
			}
			this.text.text = this.global1.data[this.this_num].ToString() + "/10";
			this.Repaint();
			return;
		}
		if (!this.right && !this.global1.is_liber)
		{
			if (this.global1.is_konst_max)
			{
				this.global1.data[1] += 10;
				this.global1.data[2] -= 10;
				this.global1.data[8] -= 5;
				this.global1.data[1] += 15;
				this.global1.data[2] -= 10;
				this.global1.data[22] += 2;
				this.global1.data[6] += 4;
				this.global1.data[33] += 2;
				this.global1.data[3] -= 15;
				this.global1.data[4] += 5;
			}
			else
			{
				this.global1.data[1] += 10;
				this.global1.data[2] -= 10;
				this.global1.data[8] -= 10;
				this.global1.data[1] += 15;
				this.global1.data[2] -= 10;
				this.global1.data[22] += 2;
				this.global1.data[6] += 4;
				this.global1.data[33] += 2;
				this.global1.data[3] -= 30;
				this.global1.data[4] += 5;
			}
			this.global1.data[this.this_num]--;
			this.global1.is_liber = true;
			for (int j = 0; j < 8; j++)
			{
				GameObject.Find("Text (" + j + ")").GetComponent<Politic_Data_Show_Script>().Update_This();
			}
			this.text.text = this.global1.data[this.this_num].ToString() + "/10";
			this.Repaint();
		}
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x0000334B File Offset: 0x0000154B
	private void OnMouseEnter()
	{
		base.GetComponent<SpriteRenderer>().sprite = this.on;
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x001F1CF8 File Offset: 0x001EFEF8
	private void OnMouseExit()
	{
		if (!this.global1.is_liber && (this.global1.data[0] != 12 || this.this_num != 38 || this.global1.event_done[228]))
		{
			base.GetComponent<SpriteRenderer>().sprite = this.off;
		}
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x0000335E File Offset: 0x0000155E
	private void Repaint()
	{
		if (this.global1.is_liber)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.on;
			return;
		}
		base.GetComponent<SpriteRenderer>().sprite = this.off;
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x001F1D54 File Offset: 0x001EFF54
	private void Repaint1()
	{
		if ((this.global1.data[0] != 2 && this.global1.data[0] != 4) || (this.global1.data[113] == 0 && this.global1.data[0] == 2) || (this.global1.event_done[149] && this.global1.data[0] == 4))
		{
			this.Repaint();
			return;
		}
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x00003390 File Offset: 0x00001590
	private void Repaint2()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x04000276 RID: 630
	private GlobalScript global1;

	// Token: 0x04000277 RID: 631
	public Sprite on;

	// Token: 0x04000278 RID: 632
	public Sprite off;

	// Token: 0x04000279 RID: 633
	public TextMesh text;

	// Token: 0x0400027A RID: 634
	public int this_num;

	// Token: 0x0400027B RID: 635
	public bool right;
}
