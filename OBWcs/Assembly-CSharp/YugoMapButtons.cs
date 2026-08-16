using System;
using UnityEngine;

// Token: 0x02000048 RID: 72
public class YugoMapButtons : MonoBehaviour, IButton
{
	// Token: 0x06000146 RID: 326 RVA: 0x00003023 File Offset: 0x00001223
	void IButton.OnButtonDown()
	{
		this.OnMouseDown();
	}

	// Token: 0x06000147 RID: 327 RVA: 0x0000302B File Offset: 0x0000122B
	void IButton.OnButtonEnter()
	{
		this.OnMouseEnter();
	}

	// Token: 0x06000148 RID: 328 RVA: 0x00003033 File Offset: 0x00001233
	void IButton.OnButtonExit()
	{
		this.OnMouseExit();
	}

	// Token: 0x06000149 RID: 329 RVA: 0x0000303B File Offset: 0x0000123B
	void IButton.OnButtonStay()
	{
		this.OnMouseOver();
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00003043 File Offset: 0x00001243
	private void OnMouseDown()
	{
		((IButtonPressReceiver)this.controller).OnButtonDown(this.num);
	}

	// Token: 0x0600014B RID: 331 RVA: 0x0000305B File Offset: 0x0000125B
	private void OnMouseEnter()
	{
		((IButtonPressReceiver)this.controller).OnButtonEnter(this.num, base.GetComponent<SpriteRenderer>());
	}

	// Token: 0x0600014C RID: 332 RVA: 0x00003079 File Offset: 0x00001279
	private void OnMouseExit()
	{
		((IButtonPressReceiver)this.controller).OnButtonExit(this.num, base.GetComponent<SpriteRenderer>());
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00003097 File Offset: 0x00001297
	private void OnMouseOver()
	{
		((IButtonPressReceiver)this.controller).OnButtonStay(this.num);
	}

	// Token: 0x040001E2 RID: 482
	public MonoBehaviour controller;

	// Token: 0x040001E3 RID: 483
	public int num;
}
