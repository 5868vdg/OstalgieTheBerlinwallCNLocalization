using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000020 RID: 32
public class LanguageScript : MonoBehaviour
{
	// Token: 0x06000089 RID: 137 RVA: 0x00032120 File Offset: 0x00030320
	private void Awake()
	{
		if (this.number != 0 || this.start)
		{
			if (this.number == 0 && PlayerPrefs.HasKey("language"))
			{
				SceneManager.LoadScene("Main");
			}
			return;
		}
		if (PlayerPrefs.GetInt("language") == 0)
		{
			this.language_now.text = " 中 文";
			return;
		}
		this.language_now.text = "Русский";
	}

	// Token: 0x0600008A RID: 138 RVA: 0x0003218C File Offset: 0x0003038C
	private void OnMouseDown()
	{
		PlayerPrefs.SetInt("language", this.number);
		if (this.start)
		{
			SceneManager.LoadScene("Main");
			return;
		}
		if (PlayerPrefs.GetInt("language") == 0)
		{
			this.language_now.text = " 中 文";
			return;
		}
		this.language_now.text = "Русский";
	}

	// Token: 0x0600008B RID: 139 RVA: 0x000027CA File Offset: 0x000009CA
	private void OnMouseEnter()
	{
		if (this.start)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.on;
		}
	}

	// Token: 0x0600008C RID: 140 RVA: 0x000027E5 File Offset: 0x000009E5
	private void OnMouseExit()
	{
		if (this.start)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.off;
		}
	}

	// Token: 0x04000109 RID: 265
	public int number;

	// Token: 0x0400010A RID: 266
	public bool start;

	// Token: 0x0400010B RID: 267
	public TextMesh language_now;

	// Token: 0x0400010C RID: 268
	public Sprite on;

	// Token: 0x0400010D RID: 269
	public Sprite off;
}
