using System;
using UnityEngine;

// Token: 0x02000009 RID: 9
public class CascadScrupt : MonoBehaviour
{
	// Token: 0x06000027 RID: 39 RVA: 0x000021F7 File Offset: 0x000003F7
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
	}

	// Token: 0x06000028 RID: 40 RVA: 0x0000BF94 File Offset: 0x0000A194
	private void OnMouseDown()
	{
		if (!this.turn_on)
		{
			this.Cascad.SetActive(true);
		}
		else
		{
			this.Cascad.SetActive(false);
		}
		if (this.global1.data[21] > 1991 && !this.turn_on)
		{
			this.PostExit.SetActive(true);
		}
		else if (this.global1.data[21] > 1991 && this.turn_on)
		{
			this.PostExit.SetActive(false);
		}
		this.turn_on = !this.turn_on;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x0000220E File Offset: 0x0000040E
	private void OnMouseEnter()
	{
		base.GetComponent<SpriteRenderer>().sprite = this.on;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002221 File Offset: 0x00000421
	private void OnMouseExit()
	{
		base.GetComponent<SpriteRenderer>().sprite = this.off;
	}

	// Token: 0x04000030 RID: 48
	public Sprite on;

	// Token: 0x04000031 RID: 49
	public Sprite off;

	// Token: 0x04000032 RID: 50
	private bool turn_on;

	// Token: 0x04000033 RID: 51
	public GameObject Cascad;

	// Token: 0x04000034 RID: 52
	public GameObject PostExit;

	// Token: 0x04000035 RID: 53
	public GlobalScript global1;
}
