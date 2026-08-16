using System;

// Token: 0x0200004B RID: 75
[Serializable]
public class YugoCountry
{
	// Token: 0x040001F7 RID: 503
	public string name;

	// Token: 0x040001F8 RID: 504
	public bool is_exist;

	// Token: 0x040001F9 RID: 505
	public bool is_player;

	// Token: 0x040001FA RID: 506
	public int army;

	// Token: 0x040001FB RID: 507
	public int money;

	// Token: 0x040001FC RID: 508
	public int[] build = new int[9];

	// Token: 0x040001FD RID: 509
	public bool[] peace_with = new bool[12];

	// Token: 0x040001FE RID: 510
	public bool is_independent;

	// Token: 0x040001FF RID: 511
	public int Gosstroy = -1;

	// Token: 0x04000200 RID: 512
	public bool last;

	// Token: 0x04000201 RID: 513
	public int have_regions;

	// Token: 0x04000202 RID: 514
	public bool temp_peace;

	// Token: 0x04000203 RID: 515
	public int temp_peace_time;

	// Token: 0x04000204 RID: 516
	public int temp_peace_count;

	// Token: 0x04000205 RID: 517
	public bool is_ally;

	// Token: 0x04000206 RID: 518
	public bool traded;
}
