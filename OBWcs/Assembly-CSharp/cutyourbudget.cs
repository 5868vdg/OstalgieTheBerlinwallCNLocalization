using System;
using UnityEngine;

// Token: 0x02000051 RID: 81
public class cutyourbudget : MonoBehaviour
{
	// Token: 0x06000183 RID: 387 RVA: 0x0019F068 File Offset: 0x0019D268
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		if (this.auto)
		{
			if (this.global1.automat)
			{
				base.GetComponent<SpriteRenderer>().sprite = this.on;
				return;
			}
			base.GetComponent<SpriteRenderer>().sprite = this.off;
		}
	}

	// Token: 0x06000184 RID: 388 RVA: 0x0019F0C4 File Offset: 0x0019D2C4
	private void OnMouseDown()
	{
		if (this.auto)
		{
			this.global1.automat = !this.global1.automat;
			return;
		}
		if (this.global1.data[8] < 0)
		{
			this.global1.data[1] += this.global1.data[8] * 10;
			this.global1.data[3] += this.global1.data[8] * 10;
			this.global1.data[5] += this.global1.data[8] * 5;
			this.global1.data[8] = 1;
		}
	}

	// Token: 0x06000185 RID: 389 RVA: 0x0019F180 File Offset: 0x0019D380
	private void OnMouseExit()
	{
		if (!this.auto)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.off;
			return;
		}
		if (this.global1.automat)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.on;
			return;
		}
		base.GetComponent<SpriteRenderer>().sprite = this.off;
	}

	// Token: 0x06000186 RID: 390 RVA: 0x0019F1D8 File Offset: 0x0019D3D8
	private void OnMouseEnter()
	{
		if (!this.auto)
		{
			if (this.global1.data[8] < 0)
			{
				base.GetComponent<SpriteRenderer>().sprite = this.on;
			}
			return;
		}
		if (this.global1.automat)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.off;
			return;
		}
		base.GetComponent<SpriteRenderer>().sprite = this.on;
	}

	// Token: 0x04000226 RID: 550
	public Sprite on;

	// Token: 0x04000227 RID: 551
	public Sprite off;

	// Token: 0x04000228 RID: 552
	private GlobalScript global1;

	// Token: 0x04000229 RID: 553
	public bool auto;
}
