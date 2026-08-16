using System;
using UnityEngine;

// Token: 0x02000025 RID: 37
public class Min_show_script : MonoBehaviour
{
	// Token: 0x060000A5 RID: 165 RVA: 0x00034808 File Offset: 0x00032A08
	private void OnMouseEnter()
	{
		if (this.Cam == null)
		{
			this.Cam = GameObject.Find("Main Camera").GetComponent<Camera>();
		}
		this.pidor = global::UnityEngine.Object.Instantiate<GameObject>(this.okno, new Vector3(this.Cam.ScreenToWorldPoint(Input.mousePosition).x, this.Cam.ScreenToWorldPoint(Input.mousePosition).y, -6f), new Quaternion(0f, 0f, 0f, 0f));
		this.pidor.transform.Find("Text").GetComponent<TextMesh>().text = this.global1.politics_charact[this.global1.data[this.dolshnost]];
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x000028E2 File Offset: 0x00000AE2
	private void OnMouseExit()
	{
		global::UnityEngine.Object.Destroy(this.pidor);
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x000348D4 File Offset: 0x00032AD4
	private void Awake()
	{
		this.Cam = GameObject.Find("Main Camera").GetComponent<Camera>();
		this.elect1 = GameObject.Find("KrasnayaNEnazhataya 6").GetComponent<ElectScript>();
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.Repaint();
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00034928 File Offset: 0x00032B28
	public void Repaint()
	{
		if (this.global1.data[0] == 32)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.elect1.politics[this.global1.data[0] * 10 + this.global1.data[this.dolshnost]];
		}
		else if (this.global1.data[0] < 49 || this.global1.data[0] > 51)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.elect1.politics[(this.global1.data[0] - 1) * 10 + this.global1.data[this.dolshnost]];
		}
		else if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51 && this.global1.data[114] == 100)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.elect1.politics[this.global1.data[0] * 10 + this.global1.data[this.dolshnost]];
		}
		else if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51 && this.global1.data[114] != 100)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.elect1.politics[150 + this.global1.data[this.dolshnost]];
		}
		this.text.text = this.global1.politics_name[this.global1.data[this.dolshnost]];
	}

	// Token: 0x0400012E RID: 302
	private GlobalScript global1;

	// Token: 0x0400012F RID: 303
	public int dolshnost;

	// Token: 0x04000130 RID: 304
	public TextMesh text;

	// Token: 0x04000131 RID: 305
	private ElectScript elect1;

	// Token: 0x04000132 RID: 306
	private GameObject pidor;

	// Token: 0x04000133 RID: 307
	public GameObject okno;

	// Token: 0x04000134 RID: 308
	public Camera Cam;
}
