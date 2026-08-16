using System;
using UnityEngine;

// Token: 0x02000003 RID: 3
public class TutorialButtonScript : MonoBehaviour
{
	// Token: 0x06000005 RID: 5 RVA: 0x000020A0 File Offset: 0x000002A0
	public void Show(bool a)
	{
		if (a)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.sp;
		}
		else
		{
			base.GetComponent<SpriteRenderer>().sprite = null;
		}
		this.enabled = a;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000020CB File Offset: 0x000002CB
	private void OnMouseEnter()
	{
		if (this.enabled)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.navel;
		}
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000020E6 File Offset: 0x000002E6
	private void OnMouseExit()
	{
		if (this.enabled)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.sp;
		}
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002101 File Offset: 0x00000301
	private void OnMouseDown()
	{
		if (this.enabled)
		{
			this.total.OnDown(this.is_left);
		}
	}

	// Token: 0x04000001 RID: 1
	public new bool enabled;

	// Token: 0x04000002 RID: 2
	public bool is_left;

	// Token: 0x04000003 RID: 3
	public TutorialScript total;

	// Token: 0x04000004 RID: 4
	public Sprite sp;

	// Token: 0x04000005 RID: 5
	public Sprite navel;
}
