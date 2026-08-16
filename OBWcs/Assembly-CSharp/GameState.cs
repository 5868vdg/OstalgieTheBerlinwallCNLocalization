using System;

// Token: 0x0200004C RID: 76
[Serializable]
public class GameState
{
	// Token: 0x04000207 RID: 519
	public YugoCountry[] yugcountries = new YugoCountry[12];

	// Token: 0x04000208 RID: 520
	public YugoRegion[] yugregions = new YugoRegion[12];

	// Token: 0x04000209 RID: 521
	public int[] modifies = new int[40];

	// Token: 0x0400020A RID: 522
	public int[] modifies_time = new int[40];

	// Token: 0x0400020B RID: 523
	public int regionUnderAttack = -1;

	// Token: 0x0400020C RID: 524
	public int who_attack = -1;

	// Token: 0x0400020D RID: 525
	public int[] regionsAttacked = new int[]
	{
		-1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
		-1, -1
	};

	// Token: 0x0400020E RID: 526
	public int[] whoAttacked = new int[]
	{
		-1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
		-1, -1
	};

	// Token: 0x0400020F RID: 527
	public int player;

	// Token: 0x04000210 RID: 528
	public bool battle_royal;

	// Token: 0x04000211 RID: 529
	public bool has_ally;

	// Token: 0x04000212 RID: 530
	public bool done;
}
