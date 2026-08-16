using System;
using UnityEngine;

// Token: 0x02000035 RID: 53
public class ScienceHappenedScript : MonoBehaviour
{
	// Token: 0x060000F0 RID: 240 RVA: 0x00002BF4 File Offset: 0x00000DF4
	public void IsHappened()
	{
		base.GetComponent<SpriteRenderer>().sprite = this.science[this.this_num];
	}

	// Token: 0x04000181 RID: 385
	public Sprite[] science = new Sprite[22];

	// Token: 0x04000182 RID: 386
	public int this_num = -1;
}
