using System;
using UnityEngine;

// Token: 0x02000012 RID: 18
public class DLCEndingScript : MonoBehaviour
{
	// Token: 0x06000050 RID: 80 RVA: 0x00013C98 File Offset: 0x00011E98
	public void Init()
	{
		string text = "en";
		if (PlayerPrefs.GetInt("language") == 0)
		{
			this.language = SystemLanguage.English;
		}
		else
		{
			text = "ru";
			this.language = SystemLanguage.Russian;
		}
		TextAsset textAsset = Resources.Load(string.Format("{0}_text/dlcending_text", text)) as TextAsset;
		this.credits_text = textAsset.text.Split(new char[] { '\n' });
		Resources.UnloadAsset(textAsset);
	}

	// Token: 0x04000074 RID: 116
	public SystemLanguage language = SystemLanguage.English;

	// Token: 0x04000075 RID: 117
	public static DLCEndingScript inst;

	// Token: 0x04000076 RID: 118
	public string[] credits_text;
}
