using System;
using UnityEngine;

// Token: 0x02000044 RID: 68
public class VoiceChangeScript : MonoBehaviour
{
	// Token: 0x06000135 RID: 309 RVA: 0x00002F5D File Offset: 0x0000115D
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.Repaint();
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00002F7A File Offset: 0x0000117A
	private void Repaint()
	{
		if (this.global1.bitss == this.i)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.on;
		}
	}

	// Token: 0x06000137 RID: 311 RVA: 0x00002FA0 File Offset: 0x000011A0
	private void OnMouseEnter()
	{
		base.GetComponent<SpriteRenderer>().sprite = this.on;
	}

	// Token: 0x06000138 RID: 312 RVA: 0x00002FB3 File Offset: 0x000011B3
	private void OnMouseExit()
	{
		if (this.global1.bitss != this.i)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.off;
		}
	}

	// Token: 0x06000139 RID: 313 RVA: 0x00002FD9 File Offset: 0x000011D9
	private void OnMouseDown()
	{
		this.global1.bitss = this.i;
		this.global1.MusicReset();
		this.Repaint();
	}

	// Token: 0x040001DB RID: 475
	public Sprite on;

	// Token: 0x040001DC RID: 476
	public Sprite off;

	// Token: 0x040001DD RID: 477
	private GlobalScript global1;

	// Token: 0x040001DE RID: 478
	public int i;
}
