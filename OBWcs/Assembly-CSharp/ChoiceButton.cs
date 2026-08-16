using System;
using UnityEngine;

// Token: 0x0200000A RID: 10
public class ChoiceButton : MonoBehaviour
{
	// Token: 0x0600002C RID: 44 RVA: 0x00002234 File Offset: 0x00000434
	public void ChangeSelected(bool isSelected)
	{
		if (isSelected)
		{
			this.state = ChoiceButton.ChoiceButtonState.Selected;
		}
		else if (this.state == ChoiceButton.ChoiceButtonState.Selected)
		{
			this.state = ChoiceButton.ChoiceButtonState.Idle;
		}
		this.Repaint();
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002258 File Offset: 0x00000458
	private void OnMouseEnter()
	{
		if (this.state == ChoiceButton.ChoiceButtonState.Idle)
		{
			this.state = ChoiceButton.ChoiceButtonState.MouseEntered;
		}
		this.Repaint();
	}

	// Token: 0x0600002E RID: 46 RVA: 0x0000226F File Offset: 0x0000046F
	private void OnMouseExit()
	{
		if (this.state == ChoiceButton.ChoiceButtonState.MouseEntered)
		{
			this.state = ChoiceButton.ChoiceButtonState.Idle;
		}
		this.Repaint();
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002287 File Offset: 0x00000487
	public void ChangeText(string text)
	{
		this.textMesh.text = text;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x0000C028 File Offset: 0x0000A228
	private void Repaint()
	{
		this.textMesh.color = ((this.state == ChoiceButton.ChoiceButtonState.Idle) ? this.defaultColor : this.selectedColor);
		this.spriteRenderer.color = ((this.state == ChoiceButton.ChoiceButtonState.Idle) ? Color.white : new Color(0.8627451f, 0.7882353f, 0.73333335f));
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002295 File Offset: 0x00000495
	private void OnMouseDown()
	{
		this.controller.ReceiveButtonPress(this.num);
	}

	// Token: 0x04000036 RID: 54
	public int num;

	// Token: 0x04000037 RID: 55
	public ChoiceSystemController controller;

	// Token: 0x04000038 RID: 56
	[SerializeField]
	private TextMesh textMesh;

	// Token: 0x04000039 RID: 57
	public SpriteRenderer spriteRenderer;

	// Token: 0x0400003A RID: 58
	public Color defaultColor;

	// Token: 0x0400003B RID: 59
	public Color selectedColor;

	// Token: 0x0400003C RID: 60
	private ChoiceButton.ChoiceButtonState state;

	// Token: 0x0200000B RID: 11
	public enum ChoiceButtonState
	{
		// Token: 0x0400003E RID: 62
		Idle,
		// Token: 0x0400003F RID: 63
		Selected,
		// Token: 0x04000040 RID: 64
		MouseEntered
	}
}
