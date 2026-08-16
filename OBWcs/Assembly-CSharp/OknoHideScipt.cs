using System;
using UnityEngine;

// Token: 0x02000027 RID: 39
public class OknoHideScipt : MonoBehaviour
{
	// Token: 0x060000AE RID: 174 RVA: 0x0000290C File Offset: 0x00000B0C
	private void OnMouseEnter()
	{
		base.GetComponent<SpriteRenderer>().sprite = this.on;
	}

	// Token: 0x060000AF RID: 175 RVA: 0x0000291F File Offset: 0x00000B1F
	private void OnMouseExit()
	{
		base.GetComponent<SpriteRenderer>().sprite = this.off;
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00002932 File Offset: 0x00000B32
	private void OnMouseDown()
	{
		this.map1.ShowHideOcno(false);
		base.GetComponent<SpriteRenderer>().sprite = this.off;
	}

	// Token: 0x04000138 RID: 312
	public Sprite on;

	// Token: 0x04000139 RID: 313
	public Sprite off;

	// Token: 0x0400013A RID: 314
	public MapChangesScript map1;
}
