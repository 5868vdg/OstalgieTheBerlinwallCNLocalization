using System;

namespace ReqEventsDLC
{
	// Token: 0x0200005E RID: 94
	public class ReqEventForDLC
	{
		// Token: 0x060001D1 RID: 465 RVA: 0x000034F3 File Offset: 0x000016F3
		public static bool RequrementsDLC04(ref int this_num_event, ref int this_num_place, ref GlobalScript global1)
		{
			if (global1.allcountries[0].isOVD)
			{
				this_num_event = 300;
				this_num_place = 0;
				return true;
			}
			if (global1.allcountries[0].isOVD)
			{
				this_num_event = 301;
				this_num_place = 1;
				return true;
			}
			return false;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000034F3 File Offset: 0x000016F3
		public static bool RequrementsDLC05(ref int this_num_event, ref int this_num_place, ref GlobalScript global1)
		{
			if (global1.allcountries[0].isOVD)
			{
				this_num_event = 300;
				this_num_place = 0;
				return true;
			}
			if (global1.allcountries[0].isOVD)
			{
				this_num_event = 301;
				this_num_place = 1;
				return true;
			}
			return false;
		}
	}
}
