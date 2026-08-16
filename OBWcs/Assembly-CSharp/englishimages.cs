using System;
using UnityEngine;

// Token: 0x02000054 RID: 84
public class englishimages : MonoBehaviour
{
	// Token: 0x0600019C RID: 412 RVA: 0x001EF214 File Offset: 0x001ED414
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.global1.turn_on = true;
		if (!PlayerPrefs.HasKey("language"))
		{
			PlayerPrefs.SetInt("language", 0);
		}
		if (PlayerPrefs.HasKey("language") && PlayerPrefs.GetInt("language") == 0)
		{
			GameObject.Find("NG1").GetComponent<SpriteRenderer>().sprite = this.new_game_nenavel;
			GameObject.Find("ZAG1").GetComponent<SpriteRenderer>().sprite = this.load_nenavel;
			GameObject.Find("VYH1").GetComponent<SpriteRenderer>().sprite = this.exit_nenavel;
			GameObject.Find("AVT1").GetComponent<SpriteRenderer>().sprite = this.authores_nenavel;
		}
		this.kometa_int = PlayerPrefs.GetInt("kometa");
		if (this.kometa_int >= 12)
		{
			this.kometa.text = "Pax\nRomana";
			this.load1.new_scene = "Roma";
		}
	}

	// Token: 0x0400025A RID: 602
	public string this_scene;

	// Token: 0x0400025B RID: 603
	public Sprite new_game_nenavel;

	// Token: 0x0400025C RID: 604
	public Sprite load_nenavel;

	// Token: 0x0400025D RID: 605
	public Sprite exit_nenavel;

	// Token: 0x0400025E RID: 606
	public Sprite authores_nenavel;

	// Token: 0x0400025F RID: 607
	private GlobalScript global1;

	// Token: 0x04000260 RID: 608
	public TextMesh kometa;

	// Token: 0x04000261 RID: 609
	private int kometa_int;

	// Token: 0x04000262 RID: 610
	public LoadScript load1;
}
