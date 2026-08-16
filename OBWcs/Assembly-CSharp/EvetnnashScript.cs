using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000018 RID: 24
public class EvetnnashScript : MonoBehaviour
{
	// Token: 0x0600006D RID: 109 RVA: 0x000025E6 File Offset: 0x000007E6
	private void Awake()
	{
		this.map1 = GameObject.Find("MapChanges").GetComponent<MapChangesScript>();
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00002612 File Offset: 0x00000812
	public void OnMouseDown()
	{
		this.global1.speed = 0;
		this.map1.EventRead();
		SceneManager.LoadSceneAsync(this.new_scene);
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00002637 File Offset: 0x00000837
	private void OnMouseEnter()
	{
		if (base.gameObject.GetComponent<SpriteRenderer>() != null)
		{
			base.gameObject.GetComponent<SpriteRenderer>().sprite = this.navel;
		}
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002662 File Offset: 0x00000862
	private void OnMouseExit()
	{
		if (base.gameObject.GetComponent<SpriteRenderer>() != null)
		{
			base.gameObject.GetComponent<SpriteRenderer>().sprite = this.nenavel;
		}
	}

	// Token: 0x0400009A RID: 154
	private MapChangesScript map1;

	// Token: 0x0400009B RID: 155
	public string new_scene = "";

	// Token: 0x0400009C RID: 156
	public Sprite navel;

	// Token: 0x0400009D RID: 157
	public Sprite nenavel;

	// Token: 0x0400009E RID: 158
	private GlobalScript global1;
}
