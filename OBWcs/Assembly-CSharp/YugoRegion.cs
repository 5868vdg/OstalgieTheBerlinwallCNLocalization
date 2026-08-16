using System;

// Token: 0x0200004A RID: 74
[Serializable]
public class YugoRegion
{
	// Token: 0x040001EF RID: 495
	public string name;

	// Token: 0x040001F0 RID: 496
	public int owner = -1;

	// Token: 0x040001F1 RID: 497
	public int population = -1;

	// Token: 0x040001F2 RID: 498
	public int control = 100;

	// Token: 0x040001F3 RID: 499
	public int inreg = -1;

	// Token: 0x040001F4 RID: 500
	public int level = -1;

	// Token: 0x040001F5 RID: 501
	public int defence = -1;

	// Token: 0x040001F6 RID: 502
	public int[] borders;
}
