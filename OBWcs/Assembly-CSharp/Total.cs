using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200003F RID: 63
public class Total : MonoBehaviour
{
	// Token: 0x0600011E RID: 286 RVA: 0x00002DF6 File Offset: 0x00000FF6
	private void Awake()
	{
		this.audio_now = base.GetComponent<AudioSource>();
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00191D00 File Offset: 0x0018FF00
	private bool isInQue(int number)
	{
		for (int i = 0; i < this.toPlay.Count; i++)
		{
			if (number == this.toPlay[i])
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00002E04 File Offset: 0x00001004
	public void Play(int number)
	{
		if (this.isInQue(number))
		{
			return;
		}
		this.toPlay.Add(number);
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00191D38 File Offset: 0x0018FF38
	private void Update()
	{
		if (!this.audio_now.isPlaying && this.toPlay.Count > 0)
		{
			this.audio_now.PlayOneShot(this.all[this.toPlay[0]]);
			this.toPlay.RemoveAt(0);
		}
	}

	// Token: 0x040001C1 RID: 449
	public AudioClip[] all = new AudioClip[10];

	// Token: 0x040001C2 RID: 450
	private List<int> toPlay = new List<int>();

	// Token: 0x040001C3 RID: 451
	private AudioSource audio_now;
}
