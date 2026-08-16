using System;
using UnityEngine;

// Token: 0x0200002B RID: 43
public class Party_zapret : MonoBehaviour
{
	// Token: 0x060000C1 RID: 193 RVA: 0x00002A53 File Offset: 0x00000C53
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.Repaint();
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00002A70 File Offset: 0x00000C70
	private void Repaint()
	{
		if (this.global1.is_party_enabled[this.this_number])
		{
			base.GetComponent<SpriteRenderer>().sprite = this.on;
			return;
		}
		base.GetComponent<SpriteRenderer>().sprite = this.off;
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00035378 File Offset: 0x00033578
	private void OnMouseEnter()
	{
		if (this.global1.is_party_enabled[this.this_number])
		{
			base.GetComponent<OkoshkoScript>().text = "Агентов нужно: " + (this.global1.data[15] - 5).ToString();
			base.GetComponent<OkoshkoScript>().text_en = " 需 要 " + (this.global1.data[15] - 5).ToString() + " 间 谍";
		}
		else
		{
			base.GetComponent<OkoshkoScript>().text = "Денег нужно: " + (this.global1.data[15] - 6).ToString();
			base.GetComponent<OkoshkoScript>().text_en = " 需 要 " + (this.global1.data[15] - 6).ToString() + " 资 金";
		}
		if (this.global1.is_party_enabled[this.this_number])
		{
			if (this.global1.data[15] != 9 && ((this.global1.party_ideology[this.this_number] == 10 && (this.global1.data[18] < 21 || this.global1.data[18] > 22)) || (this.global1.party_ideology[this.this_number] == 1 && this.global1.data[18] < 20) || (this.global1.party_ideology[this.this_number] == 2 && this.global1.data[18] < 21) || (this.global1.party_ideology[this.this_number] == 3 && this.global1.data[18] < 22)))
			{
				base.GetComponent<SpriteRenderer>().sprite = this.off;
				return;
			}
		}
		else if (this.global1.data[15] != 6 && ((this.global1.party_ideology[this.this_number] == 1 && this.global1.data[18] > 19) || (this.global1.party_ideology[this.this_number] == 2 && this.global1.data[18] > 20) || (this.global1.party_ideology[this.this_number] == 3 && this.global1.data[18] >= 21)))
		{
			base.GetComponent<SpriteRenderer>().sprite = this.on;
		}
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00002A70 File Offset: 0x00000C70
	private void OnMouseExit()
	{
		if (this.global1.is_party_enabled[this.this_number])
		{
			base.GetComponent<SpriteRenderer>().sprite = this.on;
			return;
		}
		base.GetComponent<SpriteRenderer>().sprite = this.off;
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x000355EC File Offset: 0x000337EC
	private void OnMouseDown()
	{
		if (this.global1.is_party_enabled[this.this_number] && this.global1.data[9] >= (this.global1.data[15] - 5) * 10)
		{
			if (this.global1.data[15] != 9 && ((this.global1.party_ideology[this.this_number] == 10 && (this.global1.data[18] < 21 || this.global1.data[18] > 22)) || (this.global1.party_ideology[this.this_number] == 1 && this.global1.data[18] < 20) || (this.global1.party_ideology[this.this_number] == 2 && this.global1.data[18] < 21) || (this.global1.party_ideology[this.this_number] == 3 && this.global1.data[18] < 22)))
			{
				this.global1.data[9] -= (this.global1.data[15] - 5) * 10;
				if (this.global1.is_party_ally[this.this_number])
				{
					this.global1.data[1] -= 250;
					this.global1.data[6] += 30;
				}
				else
				{
					this.global1.data[6] += 10;
				}
				this.global1.data[2] -= 200;
				this.global1.data[3] -= this.global1.party_number[this.this_number] * 5;
				this.global1.data[4] += this.global1.party_number[this.this_number] * 5;
				for (int i = 0; i < 8; i++)
				{
					GameObject.Find("Text (" + i.ToString() + ")").GetComponent<Politic_Data_Show_Script>().Update_This();
				}
				this.global1.is_party_enabled[this.this_number] = false;
				this.global1.party_number[this.this_number] = 0;
				this.global1.is_party_ally[this.this_number] = false;
				GameObject.Find("KrasnayaNEnazhataya (" + this.this_number.ToString() + ")").GetComponent<Party_ally_script>().Repaint();
				this.Repaint();
			}
		}
		else if (this.global1.data[8] >= (this.global1.data[15] - 6) * 10 && !this.global1.is_party_enabled[this.this_number] && this.global1.data[15] != 6 && ((this.global1.party_ideology[this.this_number] == 1 && this.global1.data[18] > 19) || (this.global1.party_ideology[this.this_number] == 2 && this.global1.data[18] > 20) || (this.global1.party_ideology[this.this_number] == 3 && this.global1.data[18] >= 21)))
		{
			this.global1.data[8] -= (this.global1.data[15] - 6) * 10;
			this.global1.data[1] -= 10;
			this.global1.data[2] += 50;
			this.global1.data[3] += 10;
			this.global1.data[4] += 25;
			this.global1.data[6] -= 15;
			for (int j = 0; j < 8; j++)
			{
				GameObject.Find("Text (" + j.ToString() + ")").GetComponent<Politic_Data_Show_Script>().Update_This();
			}
			this.global1.is_party_enabled[this.this_number] = true;
			this.global1.party_number[this.this_number] = 0;
			this.Repaint();
		}
		GameObject.Find("Kr").GetComponent<Crushok_politic>().Repaint();
	}

	// Token: 0x0400014A RID: 330
	private GlobalScript global1;

	// Token: 0x0400014B RID: 331
	public int this_number;

	// Token: 0x0400014C RID: 332
	public Sprite on;

	// Token: 0x0400014D RID: 333
	public Sprite off;
}
