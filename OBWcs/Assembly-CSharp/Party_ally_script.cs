using System;
using UnityEngine;

// Token: 0x0200002A RID: 42
public class Party_ally_script : MonoBehaviour
{
	// Token: 0x060000BB RID: 187 RVA: 0x000029D6 File Offset: 0x00000BD6
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.Repaint();
	}

	// Token: 0x060000BC RID: 188 RVA: 0x000029F3 File Offset: 0x00000BF3
	public void Repaint()
	{
		if (this.global1.is_party_ally[this.this_number])
		{
			base.GetComponent<SpriteRenderer>().sprite = this.on;
			return;
		}
		base.GetComponent<SpriteRenderer>().sprite = this.off;
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00034F6C File Offset: 0x0003316C
	private void OnMouseDown()
	{
		if (!this.global1.is_party_ally[this.this_number] && this.global1.data[9] >= 30 && this.global1.is_party_enabled[this.this_number] && ((this.global1.party_ideology[this.this_number] == 10 && this.global1.data[18] <= 18) || (this.global1.party_ideology[this.this_number] == 1 && this.global1.data[18] >= 21 && this.global1.data[18] <= 22) || (this.global1.party_ideology[this.this_number] == 2 && this.global1.data[18] >= 22) || (this.global1.party_ideology[this.this_number] == 3 && (this.global1.data[18] <= 18 || this.global1.data[18] >= 23))))
		{
			this.global1.is_party_ally[this.this_number] = true;
			if (this.global1.party_number[this.this_number] > 50)
			{
				this.global1.data[1] -= this.global1.party_number[this.this_number] / 3 * 5;
				this.global1.data[3] -= 50;
				this.global1.data[6] -= 10;
				this.global1.data[8] -= this.global1.party_number[this.this_number] / 5;
				this.global1.data[9] -= this.global1.party_number[this.this_number] / 2;
				this.global1.data[4] -= this.global1.party_number[this.this_number] / 5;
			}
			else
			{
				this.global1.data[1] -= 100;
				this.global1.data[3] -= 50;
				this.global1.data[6] -= 10;
				this.global1.data[8] -= 10;
				this.global1.data[9] -= 30;
				this.global1.data[4] -= 10;
			}
			for (int i = 0; i < 8; i++)
			{
				GameObject.Find("Text (" + i + ")").GetComponent<Politic_Data_Show_Script>().Update_This();
			}
			this.Repaint();
		}
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00035250 File Offset: 0x00033450
	private void OnMouseEnter()
	{
		if (!this.global1.is_party_ally[this.this_number] && this.global1.data[9] >= 30 && this.global1.is_party_enabled[this.this_number] && ((this.global1.party_ideology[this.this_number] == 10 && this.global1.data[18] <= 18) || (this.global1.party_ideology[this.this_number] == 1 && this.global1.data[18] >= 21 && this.global1.data[18] <= 22) || (this.global1.party_ideology[this.this_number] == 2 && this.global1.data[18] >= 22) || (this.global1.party_ideology[this.this_number] == 3 && (this.global1.data[18] <= 18 || this.global1.data[18] >= 23))))
		{
			base.GetComponent<SpriteRenderer>().sprite = this.on;
		}
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00002A2C File Offset: 0x00000C2C
	private void OnMouseExit()
	{
		if (!this.global1.is_party_ally[this.this_number])
		{
			base.GetComponent<SpriteRenderer>().sprite = this.off;
		}
	}

	// Token: 0x04000146 RID: 326
	private GlobalScript global1;

	// Token: 0x04000147 RID: 327
	public int this_number;

	// Token: 0x04000148 RID: 328
	public Sprite on;

	// Token: 0x04000149 RID: 329
	public Sprite off;
}
