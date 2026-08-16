using System;
using UnityEngine;

namespace EventsForDLC
{
	// Token: 0x0200005F RID: 95
	public abstract class EventsSecond : MonoBehaviour
	{
		// Token: 0x060001D4 RID: 468
		public abstract void TextOfEvents(ref string name, ref string text, ref GlobalScript global1);

		// Token: 0x060001D5 RID: 469
		public abstract void VariantsOfEvents(ref int kolvo_variant, ref string[] fake_text, ref GameObject[] button, ref GlobalScript global1);

		// Token: 0x060001D6 RID: 470
		public abstract void ResultsOfEvents(ref string name, ref string text, int result_num, ref GlobalScript global1);
	}
}
