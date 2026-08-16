using System;
using UnityEngine;

// Token: 0x0200005C RID: 92
public class sizescript : MonoBehaviour
{
	// Token: 0x060001C9 RID: 457 RVA: 0x001FCC80 File Offset: 0x001FAE80
	private void Awake()
	{
		this.a43[0] = 640f;
		this.a431[0] = 480f;
		this.a43[1] = 800f;
		this.a431[1] = 600f;
		this.a43[2] = 1024f;
		this.a431[2] = 768f;
		this.a43[3] = 1152f;
		this.a431[3] = 864f;
		this.a43[4] = 1280f;
		this.a431[4] = 960f;
		this.a54[0] = 720f;
		this.a541[0] = 576f;
		this.a54[1] = 1280f;
		this.a541[1] = 1024f;
		this.a1610[0] = 1280f;
		this.a16101[0] = 800f;
		this.a1610[1] = 1600f;
		this.a16101[1] = 1024f;
		this.a1610[2] = 1680f;
		this.a16101[2] = 1050f;
		this.a169[0] = 1024f;
		this.a1691[0] = 576f;
		this.a169[1] = 1380f;
		this.a1691[1] = 720f;
		this.a169[2] = 1360f;
		this.a1691[2] = 768f;
		this.a169[3] = 1366f;
		this.a1691[3] = 768f;
		this.a169[4] = 1600f;
		this.a1691[4] = 900f;
		this.a169[4] = 1920f;
		this.a1691[4] = 1080f;
		this.a169[5] = 2715f;
		this.a1691[5] = 1527f;
		this.newx = (float)Screen.width;
		this.newy = (float)Screen.height;
		for (int i = 0; i < 5; i++)
		{
			if (this.newx == this.a43[i] && this.newy == this.a431[i])
			{
				this.newx = 4f;
				this.newy = 3f;
			}
		}
		for (int j = 0; j < 2; j++)
		{
			if (this.newx == this.a54[j] && this.newy == this.a541[j])
			{
				this.newx = 5f;
				this.newy = 4f;
			}
		}
		for (int k = 0; k < 3; k++)
		{
			if (this.newx == this.a1610[k] && this.newy == this.a16101[k])
			{
				this.newx = 16f;
				this.newy = 10f;
			}
		}
		for (int l = 0; l < 7; l++)
		{
			if (this.newx == this.a169[l] && this.newy == this.a1691[l])
			{
				this.newx = 16f;
				this.newy = 9f;
			}
		}
		this.newx /= this.newy / this.oldy;
		this.newy /= this.newy / this.oldy;
		this.totalx = this.newx / this.oldx;
		base.transform.localScale = new Vector3(base.transform.localScale.x * this.totalx, base.transform.localScale.y, base.transform.localScale.z);
		if (!this.isBackground)
		{
			base.transform.position = new Vector3(this.parent.transform.position.x + (base.transform.position.x - this.parent.transform.position.x) * this.totalx, base.transform.position.y, base.transform.position.z);
		}
		global::UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0400029D RID: 669
	public GameObject parent;

	// Token: 0x0400029E RID: 670
	public bool isBackground;

	// Token: 0x0400029F RID: 671
	public float totalx;

	// Token: 0x040002A0 RID: 672
	public float oldx = 16f;

	// Token: 0x040002A1 RID: 673
	public float oldy = 9f;

	// Token: 0x040002A2 RID: 674
	public float newx;

	// Token: 0x040002A3 RID: 675
	public float newy;

	// Token: 0x040002A4 RID: 676
	public float[] a43 = new float[5];

	// Token: 0x040002A5 RID: 677
	public float[] a431 = new float[5];

	// Token: 0x040002A6 RID: 678
	public float[] a54 = new float[2];

	// Token: 0x040002A7 RID: 679
	public float[] a541 = new float[2];

	// Token: 0x040002A8 RID: 680
	public float[] a1610 = new float[3];

	// Token: 0x040002A9 RID: 681
	public float[] a16101 = new float[3];

	// Token: 0x040002AA RID: 682
	public float[] a169 = new float[7];

	// Token: 0x040002AB RID: 683
	public float[] a1691 = new float[7];
}
