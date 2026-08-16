using System;
using UnityEngine;

// Token: 0x02000016 RID: 22
public class EnterScript : MonoBehaviour
{
	// Token: 0x06000062 RID: 98 RVA: 0x00002541 File Offset: 0x00000741
	private void OnMouseEnter()
	{
		base.GetComponent<SpriteRenderer>().sprite = this.on;
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00002554 File Offset: 0x00000754
	private void OnMouseExit()
	{
		base.GetComponent<SpriteRenderer>().sprite = this.off;
	}

	// Token: 0x04000090 RID: 144
	public Sprite on;

	// Token: 0x04000091 RID: 145
	public Sprite off;
}
