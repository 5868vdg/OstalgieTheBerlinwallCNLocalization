using System;
using UnityEngine;

// Token: 0x0200005A RID: 90
public class perehodscript : MonoBehaviour
{
	// Token: 0x060001BE RID: 446 RVA: 0x000026A0 File Offset: 0x000008A0
	private void Start()
	{
	}

	// Token: 0x060001BF RID: 447 RVA: 0x000033C3 File Offset: 0x000015C3
	private void OnMouseDown()
	{
		GameObject.Find("Main Camera").transform.position = new Vector3(this.x, this.y, -10f);
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x000033EF File Offset: 0x000015EF
	private void OnMouseEnter()
	{
		if (base.gameObject.GetComponent<SpriteRenderer>() != null)
		{
			base.gameObject.GetComponent<SpriteRenderer>().sprite = this.navel;
		}
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x0000341A File Offset: 0x0000161A
	private void OnMouseExit()
	{
		if (base.gameObject.GetComponent<SpriteRenderer>() != null)
		{
			base.gameObject.GetComponent<SpriteRenderer>().sprite = this.nenavel;
		}
	}

	// Token: 0x04000288 RID: 648
	public Sprite nenavel;

	// Token: 0x04000289 RID: 649
	public Sprite navel;

	// Token: 0x0400028A RID: 650
	public float x;

	// Token: 0x0400028B RID: 651
	public float y;
}
