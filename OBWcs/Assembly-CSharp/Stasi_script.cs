using System;
using UnityEngine;

// Token: 0x0200003A RID: 58
public class Stasi_script : MonoBehaviour
{
	// Token: 0x06000101 RID: 257 RVA: 0x00002C91 File Offset: 0x00000E91
	private void Start()
	{
		this.Cam = GameObject.Find("Main Camera").GetComponent<Camera>();
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
	}

	// Token: 0x06000102 RID: 258 RVA: 0x001595E8 File Offset: 0x001577E8
	private void OnMouseEnter()
	{
		if (this.Cam == null)
		{
			this.Cam = GameObject.Find("Main Camera").GetComponent<Camera>();
		}
		this.pidor = global::UnityEngine.Object.Instantiate<GameObject>(this.okno, new Vector3(this.Cam.ScreenToWorldPoint(Input.mousePosition).x, this.Cam.ScreenToWorldPoint(Input.mousePosition).y, -9.6f), new Quaternion(0f, 0f, 0f, 0f));
		if (PlayerPrefs.GetInt("language") == 0)
		{
			this.pidor.transform.Find("Text").GetComponent<TextMesh>().text = string.Concat(new string[]
			{
				this.text_en,
				": ",
				(((this.global1.data[9] < 0) ? "-" : "") + Mathf.Abs(this.global1.data[9] / 10)).ToString(),
				".",
				Mathf.Abs(this.global1.data[9] % 10).ToString()
			});
			return;
		}
		this.pidor.transform.Find("Text").GetComponent<TextMesh>().text = string.Concat(new string[]
		{
			this.text,
			": ",
			(((this.global1.data[9] < 0) ? "-" : "") + Mathf.Abs(this.global1.data[9] / 10)).ToString(),
			".",
			Mathf.Abs(this.global1.data[9] % 10).ToString()
		});
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00002CBD File Offset: 0x00000EBD
	public void OnMouseExit()
	{
		global::UnityEngine.Object.Destroy(this.pidor);
	}

	// Token: 0x04000195 RID: 405
	private GameObject pidor;

	// Token: 0x04000196 RID: 406
	private GlobalScript global1;

	// Token: 0x04000197 RID: 407
	public string text;

	// Token: 0x04000198 RID: 408
	public string text_en;

	// Token: 0x04000199 RID: 409
	public GameObject okno;

	// Token: 0x0400019A RID: 410
	public Camera Cam;
}
