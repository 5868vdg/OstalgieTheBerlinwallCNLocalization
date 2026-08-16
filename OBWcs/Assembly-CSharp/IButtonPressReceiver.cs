using System;
using UnityEngine;

// Token: 0x02000046 RID: 70
public interface IButtonPressReceiver
{
	// Token: 0x0600013E RID: 318
	void OnButtonDown(int num);

	// Token: 0x0600013F RID: 319
	void OnButtonEnter(int num, SpriteRenderer spr);

	// Token: 0x06000140 RID: 320
	void OnButtonExit(int num, SpriteRenderer spr);

	// Token: 0x06000141 RID: 321
	void OnButtonStay(int num);
}
