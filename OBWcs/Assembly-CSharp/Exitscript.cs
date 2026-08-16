using System;
using UnityEngine;

// Token: 0x02000019 RID: 25
public class Exitscript : MonoBehaviour
{
	// Token: 0x06000072 RID: 114 RVA: 0x000026A0 File Offset: 0x000008A0
	private void Start()
	{
	}

	// Token: 0x06000073 RID: 115 RVA: 0x000026A2 File Offset: 0x000008A2
	private void OnMouseDown()
	{
		Application.Quit();
	}

	// Token: 0x06000074 RID: 116 RVA: 0x000026A9 File Offset: 0x000008A9
	private void OnMouseEnter()
	{
		if (PlayerPrefs.GetInt("language") == 0)
		{
			base.gameObject.GetComponent<SpriteRenderer>().sprite = this.eng_navel;
			return;
		}
		base.gameObject.GetComponent<SpriteRenderer>().sprite = this.navel;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x000026E4 File Offset: 0x000008E4
	private void OnMouseExit()
	{
		if (PlayerPrefs.GetInt("language") == 0)
		{
			base.gameObject.GetComponent<SpriteRenderer>().sprite = this.eng_nenavel;
			return;
		}
		base.gameObject.GetComponent<SpriteRenderer>().sprite = this.nenavel;
	}

	// Token: 0x0400009F RID: 159
	public Sprite nenavel;

	// Token: 0x040000A0 RID: 160
	public Sprite navel;

	// Token: 0x040000A1 RID: 161
	public Sprite eng_nenavel;

	// Token: 0x040000A2 RID: 162
	public Sprite eng_navel;
}
