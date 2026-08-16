using System;
using UnityEngine;

// Token: 0x02000011 RID: 17
public class Crushok_politic : MonoBehaviour
{
	// Token: 0x0600004D RID: 77 RVA: 0x000023F7 File Offset: 0x000005F7
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.Repaint();
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00013B8C File Offset: 0x00011D8C
	public void Repaint()
	{
		float[] array = new float[5];
		float num = (float)(this.global1.party_number[0] + this.global1.party_number[1] + this.global1.party_number[2] + this.global1.party_number[3] + this.global1.party_number[4]);
		for (int i = 0; i < 5; i++)
		{
			array[i] = 360f * (float)this.global1.party_number[i] / num;
		}
		this.parts_obj.GetComponent<SpriteRenderer>().material.SetFloat("_M1", array[0]);
		this.parts_obj.GetComponent<SpriteRenderer>().material.SetFloat("_M2", array[0] + array[1]);
		this.parts_obj.GetComponent<SpriteRenderer>().material.SetFloat("_M3", array[0] + array[1] + array[2]);
		this.parts_obj.GetComponent<SpriteRenderer>().material.SetFloat("_M4", array[0] + array[1] + array[2] + array[3]);
	}

	// Token: 0x04000072 RID: 114
	public GameObject parts_obj;

	// Token: 0x04000073 RID: 115
	private GlobalScript global1;
}
