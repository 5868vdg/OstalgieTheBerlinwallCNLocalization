using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000022 RID: 34
public class LoadScript : MonoBehaviour
{
	// Token: 0x06000095 RID: 149 RVA: 0x00002847 File Offset: 0x00000A47
	public void OnMouseDown()
	{
		SceneManager.LoadSceneAsync(this.new_scene);
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00034074 File Offset: 0x00032274
	private void OnMouseEnter()
	{
		if (base.gameObject.GetComponent<SpriteRenderer>() != null)
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				base.gameObject.GetComponent<SpriteRenderer>().sprite = this.eng_navel;
				return;
			}
			base.gameObject.GetComponent<SpriteRenderer>().sprite = this.navel;
		}
	}

	// Token: 0x06000097 RID: 151 RVA: 0x000340D0 File Offset: 0x000322D0
	private void OnMouseExit()
	{
		if (base.gameObject.GetComponent<SpriteRenderer>() != null)
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				base.gameObject.GetComponent<SpriteRenderer>().sprite = this.eng_nenavel;
				return;
			}
			base.gameObject.GetComponent<SpriteRenderer>().sprite = this.nenavel;
		}
	}

	// Token: 0x04000115 RID: 277
	public string new_scene;

	// Token: 0x04000116 RID: 278
	public Sprite nenavel;

	// Token: 0x04000117 RID: 279
	public Sprite navel;

	// Token: 0x04000118 RID: 280
	public Sprite eng_nenavel;

	// Token: 0x04000119 RID: 281
	public Sprite eng_navel;
}
