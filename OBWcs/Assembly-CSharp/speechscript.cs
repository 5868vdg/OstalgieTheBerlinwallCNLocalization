using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200005D RID: 93
public class speechscript : MonoBehaviour
{
	// Token: 0x060001CB RID: 459 RVA: 0x00003471 File Offset: 0x00001671
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.Repaint();
	}

	// Token: 0x060001CC RID: 460 RVA: 0x001FD104 File Offset: 0x001FB304
	private void OnMouseDown()
	{
		if (!this.global1.is_speech)
		{
			this.global1.is_speech = true;
			this.Repaint();
			this.global1.number_event = 1;
			this.global1.event_done[1] = true;
			SceneManager.LoadScene("Event");
		}
	}

	// Token: 0x060001CD RID: 461 RVA: 0x0000348E File Offset: 0x0000168E
	private void OnMouseEnter()
	{
		base.GetComponent<SpriteRenderer>().sprite = this.on;
	}

	// Token: 0x060001CE RID: 462 RVA: 0x000034A1 File Offset: 0x000016A1
	private void OnMouseExit()
	{
		if (!this.global1.is_speech)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.off;
		}
	}

	// Token: 0x060001CF RID: 463 RVA: 0x000034C1 File Offset: 0x000016C1
	private void Repaint()
	{
		if (this.global1.is_speech)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.on;
			return;
		}
		base.GetComponent<SpriteRenderer>().sprite = this.off;
	}

	// Token: 0x040002AC RID: 684
	private GlobalScript global1;

	// Token: 0x040002AD RID: 685
	public Sprite on;

	// Token: 0x040002AE RID: 686
	public Sprite off;
}
