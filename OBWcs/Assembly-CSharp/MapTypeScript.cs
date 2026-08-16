using System;
using UnityEngine;

// Token: 0x02000024 RID: 36
public class MapTypeScript : MonoBehaviour
{
	// Token: 0x0600009F RID: 159 RVA: 0x00002855 File Offset: 0x00000A55
	private void Awake()
	{
		this.map1 = GameObject.Find("MapChanges").GetComponent<MapChangesScript>();
		this.sp = base.GetComponent<SpriteRenderer>();
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.Repaint();
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00002893 File Offset: 0x00000A93
	private void OnMouseDown()
	{
		this.global1.map_type = this.this_type;
		this.map1.UpdateMap();
		this.oth1.Repaint();
		this.oth2.Repaint();
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00034780 File Offset: 0x00032980
	public void Repaint()
	{
		if (this.global1.map_type == this.this_type && this.sp.sprite != this.on)
		{
			this.sp.sprite = this.on;
			return;
		}
		if (this.global1.map_type != this.this_type && this.sp.sprite != this.off)
		{
			this.sp.sprite = this.off;
		}
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x000028C7 File Offset: 0x00000AC7
	private void OnMouseEnter()
	{
		this.sp.sprite = this.on;
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x000028DA File Offset: 0x00000ADA
	private void OnMouseExit()
	{
		this.Repaint();
	}

	// Token: 0x04000126 RID: 294
	public MapTypeScript oth1;

	// Token: 0x04000127 RID: 295
	public MapTypeScript oth2;

	// Token: 0x04000128 RID: 296
	public Sprite on;

	// Token: 0x04000129 RID: 297
	public Sprite off;

	// Token: 0x0400012A RID: 298
	public int this_type;

	// Token: 0x0400012B RID: 299
	private MapChangesScript map1;

	// Token: 0x0400012C RID: 300
	private SpriteRenderer sp;

	// Token: 0x0400012D RID: 301
	private GlobalScript global1;
}
