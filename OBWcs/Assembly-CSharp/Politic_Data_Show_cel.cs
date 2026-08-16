using System;
using UnityEngine;

// Token: 0x0200002E RID: 46
public class Politic_Data_Show_cel : MonoBehaviour
{
	// Token: 0x060000CE RID: 206 RVA: 0x00002AC6 File Offset: 0x00000CC6
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.Update_This();
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00002AE3 File Offset: 0x00000CE3
	private void Update_This()
	{
		base.GetComponent<TextMesh>().text = this.global1.data[this.num].ToString();
	}

	// Token: 0x04000157 RID: 343
	private GlobalScript global1;

	// Token: 0x04000158 RID: 344
	public int num;
}
