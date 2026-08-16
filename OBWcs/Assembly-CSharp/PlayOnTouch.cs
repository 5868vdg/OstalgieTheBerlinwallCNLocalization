using System;
using UnityEngine;

// Token: 0x0200002C RID: 44
public class PlayOnTouch : MonoBehaviour
{
	// Token: 0x060000C7 RID: 199 RVA: 0x00035A6C File Offset: 0x00033C6C
	private void OnMouseDown()
	{
		if (this.needtouch)
		{
			if (this.total1 == null)
			{
				this.total1 = GameObject.Find("Global(Clone)").transform.Find("AudioSource").GetComponent<Total>();
				if (this.total1 == null)
				{
					return;
				}
			}
			this.total1.Play(this.ontocuh);
		}
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00035AD4 File Offset: 0x00033CD4
	private void OnMouseEnter()
	{
		if (this.needenter)
		{
			if (this.total1 == null)
			{
				this.total1 = GameObject.Find("Global(Clone)").transform.Find("AudioSource").GetComponent<Total>();
				if (this.total1 == null)
				{
					return;
				}
			}
			this.total1.Play(this.onenter);
		}
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00035B3C File Offset: 0x00033D3C
	private void OnMouseExit()
	{
		if (this.needexit)
		{
			if (this.total1 == null)
			{
				this.total1 = GameObject.Find("Global(Clone)").transform.Find("AudioSource").GetComponent<Total>();
				if (this.total1 == null)
				{
					return;
				}
			}
			this.total1.Play(this.onexit);
		}
	}

	// Token: 0x0400014E RID: 334
	private Total total1;

	// Token: 0x0400014F RID: 335
	public int ontocuh;

	// Token: 0x04000150 RID: 336
	public int onenter;

	// Token: 0x04000151 RID: 337
	public int onexit;

	// Token: 0x04000152 RID: 338
	public bool needtouch;

	// Token: 0x04000153 RID: 339
	public bool needenter;

	// Token: 0x04000154 RID: 340
	public bool needexit;
}
