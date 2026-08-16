using System;
using UnityEngine;

// Token: 0x02000045 RID: 69
public class VoiceSciptr : MonoBehaviour
{
	// Token: 0x0600013B RID: 315 RVA: 0x00002FFD File Offset: 0x000011FD
	private void Awake()
	{
		this.text.text = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>().voice.ToString();
	}

	// Token: 0x0600013C RID: 316 RVA: 0x001921D4 File Offset: 0x001903D4
	private void OnMouseDown()
	{
		if (!this.is_right)
		{
			if (GameObject.Find("Global(Clone)").GetComponent<GlobalScript>().voice == 0)
			{
				GameObject.Find("Global(Clone)").GetComponent<GlobalScript>().voice = 100;
			}
			else if (this.ten)
			{
				if (GameObject.Find("Global(Clone)").GetComponent<GlobalScript>().voice >= 10)
				{
					GameObject.Find("Global(Clone)").GetComponent<GlobalScript>().voice -= 10;
				}
				else
				{
					GameObject.Find("Global(Clone)").GetComponent<GlobalScript>().voice = 0;
				}
			}
			else
			{
				GameObject.Find("Global(Clone)").GetComponent<GlobalScript>().voice--;
			}
		}
		else if (GameObject.Find("Global(Clone)").GetComponent<GlobalScript>().voice == 100)
		{
			GameObject.Find("Global(Clone)").GetComponent<GlobalScript>().voice = 0;
		}
		else if (this.ten)
		{
			if (GameObject.Find("Global(Clone)").GetComponent<GlobalScript>().voice <= 90)
			{
				GameObject.Find("Global(Clone)").GetComponent<GlobalScript>().voice += 10;
			}
			else
			{
				GameObject.Find("Global(Clone)").GetComponent<GlobalScript>().voice = 100;
			}
		}
		else
		{
			GameObject.Find("Global(Clone)").GetComponent<GlobalScript>().voice++;
		}
		this.text.text = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>().voice.ToString();
		PlayerPrefs.SetInt("voice_ost", GameObject.Find("Global(Clone)").GetComponent<GlobalScript>().voice);
	}

	// Token: 0x040001DF RID: 479
	public bool is_right;

	// Token: 0x040001E0 RID: 480
	public TextMesh text;

	// Token: 0x040001E1 RID: 481
	public bool ten;
}
