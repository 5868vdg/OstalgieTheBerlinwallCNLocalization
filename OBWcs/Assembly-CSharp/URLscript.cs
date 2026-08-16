using System;
using UnityEngine;

// Token: 0x02000041 RID: 65
public class URLscript : MonoBehaviour
{
	// Token: 0x06000126 RID: 294 RVA: 0x00002E44 File Offset: 0x00001044
	private void OnMouseDown()
	{
		Application.OpenURL(this.url);
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00002E51 File Offset: 0x00001051
	private void OnMouseEnter()
	{
		if (this.needSprite)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.downed;
		}
	}

	// Token: 0x06000128 RID: 296 RVA: 0x00002E6C File Offset: 0x0000106C
	private void OnMouseExit()
	{
		if (this.needSprite)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.started;
		}
	}

	// Token: 0x040001C9 RID: 457
	public string url;

	// Token: 0x040001CA RID: 458
	public bool needSprite;

	// Token: 0x040001CB RID: 459
	public Sprite started;

	// Token: 0x040001CC RID: 460
	public Sprite downed;
}
