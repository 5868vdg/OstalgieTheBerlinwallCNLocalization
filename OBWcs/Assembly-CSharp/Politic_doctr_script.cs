using System;
using UnityEngine;

// Token: 0x0200002F RID: 47
public class Politic_doctr_script : MonoBehaviour
{
	// Token: 0x060000D1 RID: 209 RVA: 0x00035C34 File Offset: 0x00033E34
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		string text = this.global1.doctr[this.global1.data[this.doctr]];
		text = text.Replace("|", "\n");
		base.GetComponent<TextMesh>().text = text;
	}

	// Token: 0x04000159 RID: 345
	private GlobalScript global1;

	// Token: 0x0400015A RID: 346
	public int doctr;
}
