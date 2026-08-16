using System;
using UnityEngine;

// Token: 0x02000040 RID: 64
public class TranslateScript : MonoBehaviour
{
	// Token: 0x06000123 RID: 291 RVA: 0x00002E3C File Offset: 0x0000103C
	private void Awake()
	{
		this.Repaint();
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00191D8C File Offset: 0x0018FF8C
	public void Repaint()
	{
		if (PlayerPrefs.GetInt("language") == 0)
		{
			for (int i = 0; i < this.meshes.Length; i++)
			{
				this.meshes[i].text = this.english_text[i];
				if (this.english_text2[i].Length > 1)
				{
					TextMesh textMesh = this.meshes[i];
					textMesh.text = textMesh.text + "\n" + this.english_text2[i];
				}
			}
			return;
		}
		for (int j = 0; j < this.meshes.Length; j++)
		{
			this.meshes[j].text = this.russian_text[j];
			if (this.russian_text2[j].Length > 1)
			{
				TextMesh textMesh2 = this.meshes[j];
				textMesh2.text = textMesh2.text + "\n" + this.russian_text2[j];
			}
		}
	}

	// Token: 0x040001C4 RID: 452
	public string[] english_text = new string[20];

	// Token: 0x040001C5 RID: 453
	public string[] russian_text = new string[20];

	// Token: 0x040001C6 RID: 454
	public TextMesh[] meshes = new TextMesh[20];

	// Token: 0x040001C7 RID: 455
	public string[] english_text2 = new string[20];

	// Token: 0x040001C8 RID: 456
	public string[] russian_text2 = new string[20];
}
