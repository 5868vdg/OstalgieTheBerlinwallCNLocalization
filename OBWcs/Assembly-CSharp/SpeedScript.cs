using System;
using UnityEngine;

// Token: 0x02000038 RID: 56
public class SpeedScript : MonoBehaviour
{
	// Token: 0x060000F8 RID: 248 RVA: 0x00159174 File Offset: 0x00157374
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.goto_economy = GameObject.Find("Button (2)").GetComponent<EvetnnashScript>();
		this.map1 = GameObject.Find("MapChanges").GetComponent<MapChangesScript>();
		this.Repaint();
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x001591C8 File Offset: 0x001573C8
	public void Probel()
	{
		if (this.this_number == 0)
		{
			if (this.global1.speed != 0)
			{
				this.save_speed = this.global1.speed;
				this.global1.speed = 0;
			}
			else if (this.save_speed != 0 && (this.global1.data[8] >= 0 || this.global1.automat))
			{
				this.global1.speed = this.save_speed;
			}
			else if (this.global1.data[8] >= 0 || this.global1.automat)
			{
				this.global1.speed = 4;
			}
			this.Repaint();
			this.other[0].Repaint();
			this.other[1].Repaint();
			this.other[2].Repaint();
		}
	}

	// Token: 0x060000FA RID: 250 RVA: 0x0015929C File Offset: 0x0015749C
	public void Repaint()
	{
		if (this.this_number == 0)
		{
			if (this.global1.speed != 0)
			{
				base.GetComponent<SpriteRenderer>().sprite = this.off;
				return;
			}
			base.GetComponent<SpriteRenderer>().sprite = this.on;
			return;
		}
		else
		{
			if (this.this_number <= this.global1.speed)
			{
				base.GetComponent<SpriteRenderer>().sprite = this.on;
				return;
			}
			base.GetComponent<SpriteRenderer>().sprite = this.off;
			return;
		}
	}

	// Token: 0x060000FB RID: 251 RVA: 0x00159318 File Offset: 0x00157518
	public void OnMouseDown()
	{
		if (!this.map1.okno.active && !this.minus && !this.plus)
		{
			if (this.this_number != 0 && (this.global1.data[8] >= 0 || this.global1.automat))
			{
				this.global1.speed = this.this_number;
				this.Repaint();
				this.other[0].Repaint();
				this.other[1].Repaint();
				this.other[2].Repaint();
				return;
			}
			if (this.this_number == 0 && this.global1.speed != 0)
			{
				this.save_speed = this.global1.speed;
				this.global1.speed = this.this_number;
				this.Repaint();
				this.other[0].Repaint();
				this.other[1].Repaint();
				this.other[2].Repaint();
				return;
			}
			if (this.this_number == 0 && this.global1.speed == 0 && (this.global1.data[8] >= 0 || this.global1.automat))
			{
				if (this.save_speed != 0)
				{
					this.global1.speed = this.save_speed;
				}
				else
				{
					this.global1.speed = 4;
				}
				this.Repaint();
				this.other[0].Repaint();
				this.other[1].Repaint();
				this.other[2].Repaint();
				return;
			}
			this.global1.speed = 0;
			this.goto_economy.OnMouseDown();
			return;
		}
		else
		{
			if (!this.map1.okno.active && this.minus)
			{
				this.global1.speed -= 10;
				this.Repaint();
				this.other[0].Repaint();
				this.other[1].Repaint();
				this.other[2].Repaint();
				return;
			}
			if (!this.map1.okno.active && this.plus && (this.global1.data[8] >= 0 || this.global1.automat))
			{
				this.global1.speed += 10;
				this.Repaint();
				this.other[0].Repaint();
				this.other[1].Repaint();
				this.other[2].Repaint();
			}
			return;
		}
	}

	// Token: 0x060000FC RID: 252 RVA: 0x0015958C File Offset: 0x0015778C
	private void OnMouseEnter()
	{
		if (!this.map1.okno.active)
		{
			if (base.GetComponent<SpriteRenderer>().sprite == this.on)
			{
				base.GetComponent<SpriteRenderer>().sprite = this.off;
				return;
			}
			base.GetComponent<SpriteRenderer>().sprite = this.on;
		}
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00002C6B File Offset: 0x00000E6B
	private void OnMouseExit()
	{
		if (!this.map1.okno.active)
		{
			this.Repaint();
		}
	}

	// Token: 0x0400018B RID: 395
	public Sprite on;

	// Token: 0x0400018C RID: 396
	public Sprite off;

	// Token: 0x0400018D RID: 397
	public int this_number;

	// Token: 0x0400018E RID: 398
	private GlobalScript global1;

	// Token: 0x0400018F RID: 399
	public SpeedScript[] other;

	// Token: 0x04000190 RID: 400
	private EvetnnashScript goto_economy;

	// Token: 0x04000191 RID: 401
	private int save_speed;

	// Token: 0x04000192 RID: 402
	public bool minus;

	// Token: 0x04000193 RID: 403
	public bool plus;

	// Token: 0x04000194 RID: 404
	private MapChangesScript map1;
}
