using System;
using UnityEngine;

// Token: 0x02000028 RID: 40
public class OkoshkoScript : MonoBehaviour
{
	// Token: 0x060000B2 RID: 178 RVA: 0x00002951 File Offset: 0x00000B51
	private void Start()
	{
		this.Cam = GameObject.Find("Main Camera").GetComponent<Camera>();
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00034C44 File Offset: 0x00032E44
	private void OnMouseEnter()
	{
		if (!this.nonono)
		{
			if (this.Cam == null)
			{
				this.Cam = GameObject.Find("Main Camera").GetComponent<Camera>();
			}
			this.pidor = global::UnityEngine.Object.Instantiate<GameObject>(this.okno, new Vector3(this.Cam.ScreenToWorldPoint(Input.mousePosition).x, this.Cam.ScreenToWorldPoint(Input.mousePosition).y, -9.5f), new Quaternion(0f, 0f, 0f, 0f));
			if (PlayerPrefs.GetInt("language") == 0)
			{
				this.text_en = this.text_en.Replace("|", "\n");
				this.pidor.transform.Find("Text").GetComponent<TextMesh>().text = this.text_en;
				return;
			}
			this.text = this.text.Replace("|", "\n");
			this.pidor.transform.Find("Text").GetComponent<TextMesh>().text = this.text;
		}
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00002968 File Offset: 0x00000B68
	public void OnMouseExit()
	{
		if (!this.nonono)
		{
			global::UnityEngine.Object.Destroy(this.pidor);
		}
	}

	// Token: 0x0400013B RID: 315
	private GameObject pidor;

	// Token: 0x0400013C RID: 316
	public string text;

	// Token: 0x0400013D RID: 317
	public string text_en;

	// Token: 0x0400013E RID: 318
	public GameObject okno;

	// Token: 0x0400013F RID: 319
	public Camera Cam;

	// Token: 0x04000140 RID: 320
	public bool nonono;
}
