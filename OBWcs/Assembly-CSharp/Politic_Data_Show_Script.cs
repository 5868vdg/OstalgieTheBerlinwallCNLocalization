using System;
using UnityEngine;

// Token: 0x0200002D RID: 45
public class Politic_Data_Show_Script : MonoBehaviour
{
	// Token: 0x060000CB RID: 203 RVA: 0x00002AA9 File Offset: 0x00000CA9
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.Update_This();
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00035BA4 File Offset: 0x00033DA4
	public void Update_This()
	{
		base.GetComponent<TextMesh>().text = (((this.global1.data[this.num] < 0) ? "-" : "") + Mathf.Abs(this.global1.data[this.num] / 10)).ToString() + "." + Mathf.Abs(this.global1.data[this.num] % 10).ToString();
	}

	// Token: 0x04000155 RID: 341
	private GlobalScript global1;

	// Token: 0x04000156 RID: 342
	public int num;
}
