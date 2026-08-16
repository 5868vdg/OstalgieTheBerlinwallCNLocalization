using System;
using EventsForDLC;
using UnityEngine;

// Token: 0x02000002 RID: 2
public class Event1110 : EventsSecond
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002080 File Offset: 0x00000280
	public override void TextOfEvents(ref string name, ref string text, ref GlobalScript global1)
	{
		name = global1.new_texts[0];
		text = global1.new_texts[0];
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00003530 File Offset: 0x00001730
	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button, ref GlobalScript global1)
	{
		kolvo_variant = 4;
		button_text[0] = global1.new_texts[0];
		if (global1.data[9] >= 250 && global1.data[8] + global1.data[36] >= 250)
		{
			button_text[1] = global1.new_texts[0];
		}
		else
		{
			global::UnityEngine.Object.Destroy(button[1]);
			button_text[1] = string.Format(global1.new_texts[0], 25);
		}
		button_text[2] = global1.new_texts[0];
		if (global1.data[9] >= 50)
		{
			button_text[3] = global1.new_texts[0];
			return;
		}
		global::UnityEngine.Object.Destroy(button[3]);
		button_text[3] = string.Format(global1.new_texts[0], 5);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00003600 File Offset: 0x00001800
	public override void ResultsOfEvents(ref string name, ref string text, int result_num, ref GlobalScript global1)
	{
		name = global1.new_texts[0];
		if (result_num == 0)
		{
			text = global1.new_texts[0];
			return;
		}
		if (result_num == 1)
		{
			text = global1.new_texts[0];
			global1.data[9] -= 250;
			global1.data[8] -= 250;
			global1.data[7] += 5;
			return;
		}
		if (result_num == 2)
		{
			text = global1.new_texts[0];
			global1.data[6] += 50;
			return;
		}
		if (result_num == 3)
		{
			text = global1.new_texts[0];
			global1.data[6] -= 50;
			global1.data[9] -= 50;
		}
	}
}
