using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000053 RID: 83
public class ending_script : MonoBehaviour
{
	// Token: 0x06000193 RID: 403
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.achieves = GameObject.Find("Ach(Clone)");
		if (this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51)
		{
			this.yug1 = GameObject.Find("Yugoglobal(Clone)").GetComponent<Yugoglobal>();
		}
		this.dlce1.Init();
		if (this.global1.data[46] == 0)
		{
			for (int i = 40; i < 44; i++)
			{
				if (this.global1.allcountries[i] != null && this.global1.allcountries[i].Westalgie >= 1000)
				{
					this.guevara++;
				}
			}
			if (this.guevara >= 4 && this.global1.iron_and_blood)
			{
				this.achieves.GetComponent<achievements>().Set(43);
			}
			if (this.global1.data[0] == 1 && this.global1.allcountries[7].Gosstroy == 2 && this.global1.allcountries[1].isSEV && this.global1.allcountries[1].isOVD && this.global1.allcountries[1].Gosstroy == 2 && this.global1.allcountries[2].isSEV && this.global1.allcountries[2].isOVD && this.global1.allcountries[2].Gosstroy == 2 && this.global1.allcountries[3].isSEV && this.global1.allcountries[3].isOVD && this.global1.allcountries[3].Gosstroy == 2 && this.global1.allcountries[4].isSEV && this.global1.allcountries[4].isOVD && this.global1.allcountries[4].Gosstroy == 2 && this.global1.allcountries[5].isSEV && this.global1.allcountries[5].isOVD && this.global1.allcountries[5].Gosstroy == 2 && this.global1.allcountries[6].isSEV && this.global1.allcountries[6].isOVD && this.global1.allcountries[6].Gosstroy == 2 && this.global1.allcountries[20].isSEV && this.global1.allcountries[20].isOVD && this.global1.allcountries[20].Gosstroy == 2 && this.global1.iron_and_blood)
			{
				this.achieves.GetComponent<achievements>().Set(137);
			}
			if (this.global1.data[0] == 2)
			{
				for (int j = 0; j < this.global1.allcountries.Length; j++)
				{
					if (this.global1.allcountries[j] != null && this.global1.allcountries[j].Gosstroy == 1)
					{
						this.greenf++;
					}
				}
				if (this.global1.data[11] == 3 && this.greenf == 0 && this.global1.allcountries[7].Gosstroy == 0 && this.global1.is_gkchp && this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(139);
				}
			}
			if (this.global1.data[0] == 10)
			{
				for (int k = 0; k < this.global1.allcountries.Length; k++)
				{
					if (this.global1.allcountries[k] != null && k != 10 && this.global1.allcountries[k].Gosstroy == 0)
					{
						this.redA++;
					}
				}
				if (this.redA <= 1 && this.global1.allcountries[10].Gosstroy == 0 && this.global1.science[9] && this.global1.data[5] > 850 && this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(145);
				}
			}
			if (this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51)
			{
				for (int l = 0; l < this.global1.allcountries.Length; l++)
				{
					if (this.global1.allcountries[l] != null && this.global1.allcountries[l].Gosstroy == 1 && l != 49 && l != 50 && l != 51 && l != 15)
					{
						this.greenf++;
					}
				}
				if (this.global1.allcountries[24].Gosstroy == this.global1.allcountries[25].Gosstroy && this.global1.allcountries[24].Gosstroy == 1)
				{
					this.greenf--;
				}
				if (this.global1.data[112] == 7 && this.greenf >= 26 && this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(138);
				}
				if (this.global1.data[235] == 9 && this.global1.data[177] == 3 && this.global1.data[164] == 8 && this.yug1.gameState.modifies[5] == 0 && this.global1.data[157] != 2 && this.global1.data[158] != 2 && this.global1.data[128] != 2 && this.global1.data[10] <= 400 && this.global1.allcountries[6].paths == 4)
				{
					this.achieves.GetComponent<achievements>().Set(140);
				}
				if (this.global1.allcountries[4].name == " 大 伏 伊 伏 丁 那" && this.global1.allcountries[4].name == "Большая\nВоеводина")
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.allcountries[4].name = " 伏 伊 伏 丁 那";
					}
					else
					{
						this.global1.allcountries[4].name = "Воеводина";
					}
				}
				if (this.global1.allcountries[20].name == " 南 斯 拉 夫 属\n 阿 尔 巴 尼 亚" || this.global1.allcountries[20].name == "Югославская\nАлбания")
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.allcountries[20].name = " 阿 尔 巴 尼 亚";
					}
					else
					{
						this.global1.allcountries[20].name = "Албания";
					}
				}
				if (this.global1.allcountries[6].name == " 南 斯 拉 夫 属\n 保 加 利 亚" || this.global1.allcountries[6].name == "Югославская\nБолгария")
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.allcountries[6].name = " 保 加 利 亚";
					}
					else
					{
						this.global1.allcountries[6].name = "Болгария";
					}
				}
			}
			for (int m = 0; m < this.global1.allcountries.Length; m++)
			{
				if (this.global1.allcountries[m] != null)
				{
					if (this.global1.allcountries[m].isOVD && !this.global1.allcountries[7].isOVD && m != this.global1.data[0])
					{
						this.military_ally++;
					}
					if (this.global1.allcountries[m].isSEV && !this.global1.allcountries[7].isSEV && m != this.global1.data[0])
					{
						this.economy_ally++;
						this.greece_ally++;
					}
					else if (this.global1.allcountries[m].isSEV && m != this.global1.data[0])
					{
						this.greece_ally++;
					}
				}
				if (((m >= 1 && m <= 6) || m == 20) && this.global1.allcountries[m].Vyshi)
				{
					this.liberalEaEu++;
					this.namelibEaEu = this.namelibEaEu + this.global1.allcountries[this.global1.data[0]].name + ", ";
				}
			}
			if (this.military_ally > 5)
			{
				this.yeye++;
			}
			if (this.economy_ally > 7)
			{
				this.yeye++;
			}
			if (this.yeye > 1 && this.global1.iron_and_blood)
			{
				this.achieves.GetComponent<achievements>().Set(35);
			}
			if (this.global1.data[0] == 5)
			{
				if (this.global1.data[11] == 0 && this.global1.data[50] == 3)
				{
					this.sinochek = true;
					this.global1.data[5] -= 100;
				}
				else if (this.global1.data[11] == 0 && this.global1.data[50] == 4)
				{
					this.sinochek = true;
					this.global1.data[1] -= 100;
					this.global1.data[5] += 50;
				}
				if (this.global1.data[58] == 1)
				{
					this.global1.data[1] += 100;
					this.global1.data[3] += 100;
					this.global1.data[4] -= 100;
					this.global1.data[5] += 50;
				}
				else
				{
					this.global1.data[3] -= 50;
					this.global1.data[4] += 50;
					this.global1.data[5] -= 50;
				}
			}
			int num = this.global1.data[5] - (18 - this.global1.data[17]) * 100;
			int num2 = this.global1.data[4] + this.global1.data[10] / 3;
			GameObject.Find("Back").GetComponent<SpriteRenderer>().sprite = this.winfon;
			GameObject.Find("plane").GetComponent<SpriteRenderer>().sprite = this.winplan;
			if (this.global1.iron_and_blood)
			{
				if (this.global1.data[0] == 4 && this.global1.data[11] == 2)
				{
					this.achieves.GetComponent<achievements>().Set(50);
				}
				if (this.global1.data[0] == 20 && this.global1.data[11] == 2 && this.global1.data[15] == 6 && this.global1.data[16] == 10 && this.global1.data[17] == 14 && !this.global1.allcountries[this.global1.data[0]].isOVD && !this.global1.allcountries[this.global1.data[0]].isSEV && !this.global1.allcountries[this.global1.data[0]].Vyshi)
				{
					this.achieves.GetComponent<achievements>().Set(53);
				}
			}
			if (this.global1.data[14] <= 2 && this.global1.data[31] > 700 && this.global1.data[16] <= 12 && this.global1.data[18] <= 20)
			{
				this.global1.data[42] = 9;
				this.global1.data[5] -= 50;
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(20);
				}
			}
			else if (this.global1.data[14] <= 3 && this.global1.data[31] > 700 && this.global1.data[16] >= 12 && (this.global1.data[18] >= 23 || this.global1.data[18] <= 18))
			{
				this.global1.data[42] = 10;
				this.global1.data[5] -= 50;
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(21);
				}
			}
			else if (this.global1.data[14] <= 0 && (this.global1.data[1] < 500 || this.global1.data[22] < 500 || this.global1.data[31] < 300))
			{
				this.global1.data[42] = 1;
				this.sinochek = false;
				this.otstavnoysinochek = true;
			}
			else if (this.global1.data[14] <= 0 && this.global1.data[31] <= 700)
			{
				this.global1.data[42] = 2;
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(15);
				}
				this.global1.data[5] -= 50;
			}
			else if (this.global1.data[14] <= 1 && this.global1.data[31] > 700 && this.global1.data[16] <= 11)
			{
				this.global1.data[42] = 9;
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(20);
				}
			}
			else if (this.global1.data[14] <= 2 && this.global1.data[15] <= 7 && num < num2)
			{
				this.global1.data[42] = 3;
				this.sinochek = false;
				this.otstavnoysinochek = true;
			}
			else if (this.global1.data[14] <= 2 && this.global1.data[15] <= 7)
			{
				this.global1.data[42] = 4;
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(16);
				}
			}
			else if (this.global1.data[14] <= 3 && ((this.global1.data[15] <= 8 && this.global1.data[17] <= 16) || this.global1.data[15] <= 7) && (this.global1.data[1] < 700 || this.global1.data[3] < 500 || this.global1.data[4] > 500))
			{
				this.global1.data[42] = 5;
				this.sinochek = false;
				this.otstavnoysinochek = true;
			}
			else if (this.global1.data[14] <= 3 && ((this.global1.data[15] <= 8 && this.global1.data[17] <= 16) || this.global1.data[15] <= 7))
			{
				this.global1.data[42] = 6;
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(17);
				}
			}
			else if (this.global1.data[14] >= 4 && this.global1.data[16] >= 13 && this.global1.data[17] >= 16)
			{
				this.global1.data[42] = 7;
				this.sinochek = false;
			}
			else if (this.global1.data[14] >= 3)
			{
				this.global1.data[42] = 8;
				this.global1.data[5] += 50;
				this.sinochek = false;
				if (this.global1.iron_and_blood && this.global1.data[16] != 11)
				{
					this.achieves.GetComponent<achievements>().Set(19);
				}
			}
			else
			{
				this.global1.data[42] = 5;
				this.sinochek = false;
				this.otstavnoysinochek = true;
			}
			if (this.global1.data[0] == 20 && this.global1.data[56] >= 100 && this.global1.data[11] == 2 && this.global1.data[31] > 700)
			{
				this.global1.data[42] = 10;
			}
			else if (this.global1.data[0] == 20 && this.global1.data[56] >= 100 && this.global1.data[11] == 2)
			{
				this.global1.data[42] = 6;
			}
			if ((this.global1.allcountries[this.global1.data[0]].Vyshi || this.global1.data[42] == 10 || (this.global1.data[42] == 8 && (!this.global1.allcountries[this.global1.data[0]].isOVD || (this.global1.allcountries[this.global1.data[0]].isOVD && this.global1.data[16] <= 10)))) && this.global1.data[16] <= 11)
			{
				this.global1.data[43] = 5;
				this.global1.data[5] += 50;
				if (this.global1.iron_and_blood && this.global1.data[42] == 8)
				{
					this.achieves.GetComponent<achievements>().Set(19);
				}
			}
			else if (this.global1.data[16] == 10)
			{
				this.global1.data[43] = 1;
				if (this.global1.science[5] && this.global1.data[43] == 1 && this.global1.data[18] <= 21 && this.global1.data[0] != 10 && this.global1.data[0] != 12 && this.global1.data[0] != 18)
				{
					this.global1.data[43] = 2;
					this.global1.data[5] += 100;
					if (this.global1.iron_and_blood && this.global1.data[42] == 8)
					{
						this.achieves.GetComponent<achievements>().Set(18);
					}
				}
				else
				{
					this.global1.data[5] -= 50;
					this.global1.data[43] = 1;
				}
			}
			else if (this.global1.data[16] == 11)
			{
				this.global1.data[43] = 2;
				this.global1.data[5] += 200;
				if (this.global1.iron_and_blood && this.global1.data[42] == 8)
				{
					this.achieves.GetComponent<achievements>().Set(18);
				}
			}
			else if (this.global1.data[16] == 12)
			{
				this.global1.data[43] = 3;
			}
			else if (this.global1.data[16] == 13)
			{
				this.global1.data[43] = 4;
				this.global1.data[5] += 50;
			}
			else
			{
				this.global1.data[43] = 5;
			}
			if (this.global1.allcountries[24].Stasi && this.global1.data[55] >= 3)
			{
				this.global1.data[5] += 50;
			}
			if (this.global1.data[5] >= 990)
			{
				this.global1.data[44] = 1;
			}
			else if (this.global1.data[5] >= 750)
			{
				this.global1.data[44] = 2;
			}
			else if (this.global1.data[5] >= 500)
			{
				this.global1.data[44] = 3;
			}
			else
			{
				this.global1.data[44] = 4;
			}
			if (this.global1.data[44] == 1 && this.global1.data[43] == 2 && this.global1.data[42] == 3)
			{
				this.global1.data[42] = 4;
			}
			if (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy == 0 && !this.global1.allcountries[7].Vyshi)
			{
				this.global1.data[45] = 7;
			}
			else if (this.global1.allcountries[7].isOVD && this.global1.allcountries[7].isOVD && !this.global1.is_gkchp && !this.global1.allcountries[7].Vyshi)
			{
				this.global1.data[45] = 1;
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(30);
				}
			}
			else if ((this.global1.allcountries[7].isSEV || this.global1.allcountries[7].isOVD) && this.global1.data[7] >= 250 && !this.global1.is_gkchp && !this.global1.allcountries[7].Vyshi)
			{
				this.global1.data[45] = 2;
			}
			else if ((this.global1.allcountries[7].isSEV && !this.global1.is_gkchp) || (this.global1.allcountries[7].isOVD && !this.global1.is_gkchp && !this.global1.allcountries[7].Vyshi) || (this.global1.data[7] >= 600 && !this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD && !this.global1.is_gkchp && !this.global1.allcountries[7].Vyshi) || this.global1.event_done[426])
			{
				this.global1.data[45] = 3;
			}
			else if (this.global1.data[0] <= 51 && this.global1.data[0] >= 49 && !this.global1.allcountries[7].Vyshi && this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy >= 2 && this.global1.data[7] + this.global1.allcountries[17].Westalgie / 20 >= 550 && (this.global1.data[204] == 3 || this.global1.data[51] + this.global1.data[52] * 3 > 10))
			{
				this.global1.data[45] = 8;
			}
			else if (this.global1.data[0] <= 51 && this.global1.data[0] >= 49 && !this.global1.allcountries[7].Vyshi && this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy >= 2 && this.global1.data[7] + this.global1.allcountries[17].Westalgie / 20 >= 350 && this.global1.data[51] + this.global1.data[52] * 3 > 7 && this.global1.data[221] == 0)
			{
				this.global1.data[45] = 9;
			}
			else if (this.global1.data[0] <= 51 && this.global1.data[0] >= 49 && !this.global1.allcountries[7].Vyshi && this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy >= 2 && this.global1.data[204] == 1)
			{
				this.global1.data[45] = 10;
			}
			else if (this.global1.data[0] <= 51 && this.global1.data[0] >= 49 && !this.global1.allcountries[7].Vyshi && this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy == 2 && this.global1.data[205] == 1)
			{
				this.global1.data[45] = 11;
			}
			else if ((!this.global1.allcountries[7].Vyshi && this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy >= 2) || (!this.global1.is_gkchp && this.global1.data[7] <= 600 && !this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD && !this.global1.allcountries[7].Vyshi))
			{
				this.global1.data[45] = 4;
			}
			else if (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy == 1 && !this.global1.allcountries[7].Vyshi)
			{
				this.global1.data[45] = 6;
			}
			else
			{
				this.global1.data[45] = 5;
			}
			if (this.global1.data[0] == 1)
			{
				if (this.global1.data[11] == 0 && this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(3);
				}
				else if (this.global1.data[11] == 1 && this.global1.iron_and_blood && ((this.global1.data[15] <= 6 && this.global1.data[16] >= 13 && this.global1.data[17] <= 14 && this.global1.data[18] <= 18) || (this.global1.data[14] <= 0 && this.global1.data[16] >= 13)))
				{
					this.achieves.GetComponent<achievements>().Set(4);
				}
				else if (this.global1.data[11] == 3 && this.global1.iron_and_blood && this.global1.data[42] == 9)
				{
					this.achieves.GetComponent<achievements>().Set(13);
				}
			}
			if (this.global1.iron_and_blood)
			{
				if (!this.global1.is_save_bylo)
				{
					this.achieves.GetComponent<achievements>().Set(12);
				}
				if (this.global1.data[11] == 2 && this.global1.data[0] == 6 && this.global1.data[14] <= 0 && this.global1.allcountries[this.global1.data[0]].isOVD && this.global1.allcountries[7].isOVD && this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy <= 1)
				{
					this.achieves.GetComponent<achievements>().Set(42);
				}
				int num3 = 0;
				for (int n = 0; n < 12; n++)
				{
					if (this.global1.allcountries[n] != null)
					{
						if (n != 4 && n != 7 && n != 8 && n != 10 && n != 11 && n != this.global1.data[0])
						{
							if (this.global1.allcountries[n].Gosstroy < 1)
							{
								num3++;
							}
						}
						else if ((n == 4 || n == 11) && this.global1.allcountries[n].Gosstroy <= 1)
						{
							num3++;
						}
					}
				}
				if (num3 >= 7)
				{
					this.achieves.GetComponent<achievements>().Set(14);
				}
			}
			if (this.global1.data[0] != 1 && this.global1.data[14] < 4 && this.global1.data[16] < 13 && (this.global1.iron_and_blood & this.global1.diff[4]))
			{
				this.achieves.GetComponent<achievements>().Set(48);
			}
			if (this.global1.iron_and_blood)
			{
				int num4 = 0;
				int num5 = 0;
				for (int num6 = 0; num6 < this.global1.allcountries.Length; num6++)
				{
					if (this.global1.allcountries[num6].Gosstroy == 0 && num6 != 7 && num6 != this.global1.data[0])
					{
						num4++;
					}
					else if (this.global1.allcountries[num6].Gosstroy == 1 && num6 != 7 && num6 != this.global1.data[0])
					{
						num5++;
					}
				}
				if (this.global1.allcountries[4].Gosstroy == 0)
				{
					num5++;
					num4--;
				}
				else if (this.global1.data[0] == 4)
				{
					num5++;
					num4--;
				}
				if (num4 >= 17 && num5 >= 7)
				{
					this.achieves.GetComponent<achievements>().Set(49);
				}
			}
		}
		if (PlayerPrefs.GetInt("language") == 0)
		{
			if (this.global1.data[46] == 1 && this.global1.data[0] != 12)
			{
				this.Name.text = " 被 革 命 推 翻";
				if (this.global1.data[14] > 0 && this.global1.data[14] < 3)
				{
					this.text_fake = " 由 于 你 的 保 守 政 策";
				}
				else if (this.global1.data[14] < 1 || this.global1.data[14] > 4)
				{
					this.text_fake = " 由 于 你 极 端 激 进 且 草 率 的 政 策";
					if (this.global1.data[14] > 4 && this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(6);
					}
				}
				else
				{
					this.text_fake = " 由 于 你 反 复 无 常 且 不 稳 定 的 政 策";
				}
				if (this.global1.data[5] < 400)
				{
					this.text_fake += "  以 及 广 泛 的 社 会 问 题";
				}
				this.text_fake += " ， 渴 望 更 多 变 革 的 人 民 对 你 们 愤 怒 了 ， 他 们 对 你 推 行 的 改 革 完 全 不 满 意 ， 国 内 的 局 势 变 得 更 加 紧 张 。 愤 怒 的 群 众 走 上 街 头 ， 要 求 领 导 人 辞 职 ， 然 而 ， 当 警 察 抵 达 以 保 障 集 会 的 安 全 时 ， 人 们 认 为 这 是 政 府 企 图 驱 散 人 民 游 行 的 行 动( 尽 管 可 能 有 外 国 挑 衅 者 参 与 其 中) ， 最 终 ， 街 头 对 抗 开 始 了 。 警 察 拒 绝 向 人 民 开 枪 并 且 撤 退 ， 群 众 开 始 暴 动 并 占 领 了 特 勤 局 的 行 政 大 楼 和 档 案 室 。 士 兵 们 拒 绝 离 开 兵 营 ， 特 勤 人 员 和 个 别 警 察 的 抵 抗 很 快 就 被 镇 压 。";
				if (this.global1.allcountries[19].Help)
				{
					this.text_fake += "| 然 而 ， 党 的 部 分 高 层 设 法 通 过 已 有 渠 道 从 该 国 逃 离 ， 并 获 得 印 度 的 政 治 庇 护 。";
					if (this.global1.allcountries[19].Gosstroy <= 1 && this.global1.data[21] > 1989)
					{
						this.text_fake = this.text_fake + " 尽 管 国 际 施 压 ， 但 印 度 国 大 党 政 府 为 了 回 报 曾 经 的 支 持 ， 没 有 引 渡 任 何 人 ， 并 把 这 些 “ 难 民 ” 安 置 在 政 府 大 楼 里 。 后 来 ，  " + this.global1.politics_name[this.global1.data[11]] + " 写 了 回 忆 录 和 自 传 ， 他 声 称 自 己 失 去 了 拯 救 自 己 国 家 的 最 后 机 会 。";
					}
					else
					{
						this.text_fake += " 然 而 在 国 际 压 力 下 ， 新 的 印 度 政 府 宣 布 将 引 渡 即 将 到 来 的 党 员 们 。 因 此 你 们 全 部 到 阿 根 廷 大 使 馆 避 难 ， 然 后 通 过 秘 密 渠 道 转 移 到 拉 丁 美 洲 各 国 ， 伪 造 了 假 身 份 。 ";
					}
				}
				else
				{
					this.text_fake = string.Concat(new object[]
					{
						this.text_fake,
						"|",
						this.global1.politics_name[this.global1.data[11]],
						" 以 及 党 的 一 些 高 级 领 导 人 在 企 图 逃 跑 时 被 仓 促 组 织 起 来 的 革 命 法 庭 未 经 任 何 审 判 和 调 查 就 被 逮 捕 并 处 决 。 其 余 的 人 被 判 处 了 不 同 刑 期 的 有 期 徒 刑 ， 但 是 到 了",
						this.global1.data[21] + 5,
						" 年 ， 他 们 因 健 康 原 因 而 被 赦 免 。"
					});
				}
				if (this.global1.data[0] == 1)
				{
					if (this.global1.data[16] <= 12)
					{
						this.text_fake += "| 统 一 社 会 党 被 查 禁 ， 一 个 中 右 翼 的 联 盟 赢 得 了 选 举 ， 并 决 定 加 入 联 邦 德 国 。 工 业 被 不 同 的 所 有 者 私 有 化 ， 结 果 ， 前 民 主 德 国 经 济 的 集 中 统 一 管 理 被 破 坏 了 ， 在 那 之 后 ， 大 部 分 的 企 业 都 因 亏 损 而 倒 闭 ， 所 以 德 国 的 中 央 政 府 不 得 不 征 收 特 别 税 来 帮 助 前 东 德 地 区 的 发 展 。";
					}
					else
					{
						this.text_fake += "| 统 一 社 会 党 被 查 禁 ， 一 个 中 右 翼 的 联 盟 赢 得 了 选 举 ， 并 决 定 加 入 联 邦 德 国 。 工 业 被 不 同 的 所 有 者 私 有 化 ， 但 民 主 德 国 政 府 先 前 的 改 革 使 其 更 容 易 撑 过 与 联 邦 德 国 市 场 经 济 的 融 合 。";
					}
				}
				else
				{
					this.text_fake = string.Concat(new object[]
					{
						this.text_fake,
						"| 据 西 方 记 者 称 ， 在 第 一 次 自 由 选 举 中 ， 中 右 翼 联 盟 赢 得 了 最 自 由 的 选 举 ， 结 果 ， 该 国 于",
						this.global1.data[21] + 8,
						" 年 被 接 纳 为 北 约 成 员 。"
					});
				}
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 1)
			{
				this.Name.text = " 被 革 命 推 翻";
				this.text_fake = " 由 于 你 反 复 无 常 且 不 稳 定 的 政 策 ，那 些 对 阿 富 汗 人 民 民 主 党 政 权 失 去 希 望 的 人 开 始 站 到 反 对 派 一 边 ， 军 队 中 倒 戈 的 情 况 也 并 不 少 见 ，阿 富 汗 民 主 共 和 国 最 后 的 几 次 军 事 失 败 成 了 最 后 一 根 稻 草 ， 在 四 月 革 命 的 摇 篮 — — 喀 布 尔 ， 爆 发 了 大 规 模 抗 议 ， 并 很 快 演 变 成 叛 乱 。 驱 散 示 威 的 尝 试 未 能 成 功 ，叛 军 冲 进 政 府 办 公 室 ， 开 始 对 管 理 者 和 党 务 工 作 者 进 行 私 刑 。 结 果 ， 喀 布 尔 陷 入 了 无 政 府 状 态 ， 恐 怖 分 子 趁 机 成 功 发 动 攻 势 ， 占 领 了 首 都 ， 并 宣 告 阿 富 汗 成 为 一 个 伊 斯 兰 共 和 国 。";
			}
			else if (this.global1.data[46] == 2 && this.global1.data[0] != 12)
			{
				this.Name.text = " 人 民 暴 动";
				if (this.global1.data[14] > 0 && this.global1.data[14] < 3)
				{
					this.text_fake = " 由 于 你 的 保 守 政 策";
				}
				else if (this.global1.data[14] < 1 || this.global1.data[14] > 4)
				{
					this.text_fake = " 由 于 你 极 端 激 进 且 草 率 的 政 策";
				}
				else
				{
					this.text_fake = " 由 于 你 反 复 无 常 且 不 稳 定 的 政 策";
				}
				if (this.global1.data[5] < 400)
				{
					this.text_fake += "  以 及 广 泛 的 社 会 问 题";
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(7);
					}
				}
				this.text_fake = string.Concat(new string[]
				{
					this.text_fake,
					"  ， 失 去 耐 心 的 人 民 开 始 组 织 大 规 模 的 罢 工 和 集 会 ， 这 持 续 了 几 个 星 期 ， 最 终 城 市 被 罢 工 者 的 帐 篷 挤 满 了 。 与 此 同 时 ， 党 组 织 开 始 怀 疑 其 领 导 人 ， 一 些 代 表 秘 密 组 织 了 一 场 阴 谋 ， 结 果 便 是",
					this.global1.politics_name[this.global1.data[11]],
					" 被 推 翻 ， 随 后 是 和 他 类 似 的 人 物。 然 而 集 会 并 没 有 停 止 ， 最 终 在 他 们 和 党 内 年 轻 干 部 的 压 力 下 ， 党 内 的 温 和 派 代 表 也 下 台 了 。 其 结 果 是",
					this.global1.party_name[0],
					" 领 导 层 的 大 规 模 更 新 ， 最 终 政 权 全 面 自 由 化 。 执 政 党 被 重 新 命 名 ， 并 且 还 提 起 了 对 前 领 导 人 的 刑 事 诉 讼 。"
				});
				if (this.global1.allcountries[19].Help)
				{
					this.text_fake += "| 然 而 ， 党 的 部 分 高 层 设 法 通 过 已 有 渠 道 从 该 国 逃 离 ， 并 获 得 印 度 的 政 治 庇 护 。";
					if (this.global1.allcountries[19].Gosstroy <= 1)
					{
						this.text_fake = this.text_fake + " 尽 管 国 际 施 压 ， 但 印 度 国 大 党 政 府 为 了 回 报 曾 经 的 支 持 ， 没 有 引 渡 任 何 人 ， 并 把 这 些 “ 难 民 ” 安 置 在 政 府 大 楼 里 。 后 来 ， " + this.global1.politics_name[this.global1.data[11]] + " 写 了 回 忆 录 和 自 传 ， 他 声 称 自 己 失 去 了 拯 救 自 己 国 家 的 最 后 机 会 。";
					}
					else
					{
						this.text_fake += " 然 而 在 国 际 压 力 下 ， 新 的 印 度 政 府 宣 布 将 引 渡 即 将 到 来 的 党 员 们 。 因 此 你 们 全 部 到 阿 根 廷 大 使 馆 避 难 ， 然 后 通 过 秘 密 渠 道 转 移 到 拉 丁 美 洲 各 国 ， 伪 造 了 假 身 份 。 ";
					}
				}
				else
				{
					this.text_fake = string.Concat(new object[]
					{
						this.text_fake,
						"|",
						this.global1.politics_name[this.global1.data[11]],
						" 在 试 图 逃 跑 时 ， 被 抓 住 并 单 独 关 押 。 其 余 的 人 被 判 处 了 不 同 刑 期 的 有 期 徒 刑 ， 但 到 了",
						this.global1.data[21] + 5,
						" 年 ， 他 们 因 健 康 原 因 而 被 赦 免 。"
					});
				}
				if (this.global1.data[0] == 1)
				{
					if (this.global1.data[16] <= 12)
					{
						this.text_fake += "| 通 过 加 入 反 对 派 的 联 盟 ， 统 一 社 会 党 转 变 为 了 民 主 社 会 主 义 政 党 ， 一 个 中 右 翼 的 联 盟 赢 得 了 选 举 ， 并 决 定 加 入 联 邦 德 国 。 工 业 被 不 同 的 所 有 者 私 有 化 ， 结 果 ， 前 民 主 德 国 经 济 的 集 中 统 一 管 理 被 破 坏 了 ， 在 那 之 后 ， 大 部 分 的 企 业 都 因 亏 损 而 倒 闭 ， 所 以 德 国 的 中 央 政 府 不 得 不 征 收 特 别 税 来 帮 助 前 东 德 地 区 的 发 展 。";
					}
					else
					{
						this.text_fake += "| 通 过 加 入 反 对 派 的 联 盟 ， 统 一 社 会 党 转 变 为 了 民 主 社 会 主 义 政 党 ， 一 个 中 右 翼 的 联 盟 赢 得 了 选 举 ， 并 决 定 加 入 联 邦 德 国 。 工 业 被 不 同 的 所 有 者 私 有 化 ， 但 民 主 德 国 政 府 先 前 的 改 革 使 其 更 容 易 撑 过 与 联 邦 德 国 市 场 经 济 的 融 合 。";
					}
				}
				else
				{
					this.text_fake = string.Concat(new object[]
					{
						this.text_fake,
						"| 据 西 方 记 者 称 ， 在 第 一 次 自 由 选 举 中 ， 中 右 翼 联 盟 赢 得 了 最 自 由 的 选 举 ， 结 果 ， 该 国 于",
						this.global1.data[21] + 8,
						" 年 被 接 纳 为 北 约 成 员 。"
					});
				}
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 2)
			{
				this.Name.text = " 人 民 暴 动";
				this.text_fake = " 由 于 你 反 复 无 常 且 不 稳 定 的 政 策 ，那 些 对 阿 富 汗 人 民 民 主 党 政 权 失 去 希 望 的 人 开 始 站 到 反 对 派 一 边 ， 军 队 中 倒 戈 的 情 况 也 并 不 少 见 ，阿 富 汗 民 主 共 和 国 最 后 的 几 次 军 事 失 败 成 了 最 后 一 根 稻 草 ， 在 四 月 革 命 的 摇 篮 — — 喀 布 尔 ， 不 满 你 的 软 弱 和 无 作 为 ， 将 军 们 试 图 组 织 一 场 军 事 政 变 来 在 首 都 建 立 秩 序 ， 但 军 队 不 仅 拒 绝 向 市 民 开 火 ， 反 而 站 到 了 他 们 一 边 。 结 果 ， 喀 布 尔 陷 入 了 无 政 府 状 态 ， 恐 怖 分 子 趁 机 成 功 发 动 攻 势 ， 占 领 了 首 都 ， 并 宣 告 阿 富 汗 成 为 一 个 伊 斯 兰 共 和 国 。";
			}
			else if (this.global1.data[46] == 3 && this.global1.data[0] != 12)
			{
				bool flag = false;
				this.Name.text = " 党 内 政 变";
				this.text_fake = " 你 的 政 治 举 措 使 党 组 织 越 来 越 生 气 ， 他 们 的 耐 心 走 到 了 尽 头 。 一 些" + this.global1.party_name[0] + " 的 高 级 干 部 ， 甚 至 包 括 ";
				int num7 = global::UnityEngine.Random.Range(0, 3);
				if (num7 == 0)
				{
					this.text_fake += " 内 务 部 长";
				}
				else if (num7 == 1)
				{
					this.text_fake += " 国 防 部 长";
				}
				else if (num7 == 2)
				{
					this.text_fake += " 特 勤 部 长";
				}
				if (this.global1.data[0] == 1)
				{
					this.global1.data[10] += 250;
				}
				this.text_fake = this.text_fake + " 在 政 治 局 会 议 上 组 织 了 夺 权 阴 谋 后 ， 第 二 天 ， 一 群 阴 谋 者 对" + this.global1.politics_name[this.global1.data[11]] + " 提 出 了 严 厉 的 指 控 。 在 此 期 间 ， 甚 至 连 第 二 书 记 都 决 定 不 为 他 辩 护 ， 在 政 治 局 其 他 成 员 的 沉 默 下 ， 我 们 的 领 导 人 因 健 康 原 因 辞 职 。";
				if (this.global1.data[22] >= 700 && this.global1.data[31] >= 700 && (this.global1.data[14] > 2 || !this.global1.allcountries[10].Help) && this.global1.data[10] < 500)
				{
					this.text_fake = this.text_fake + " In the course of the party reshuffles, a coalition of supporters of sovereignty and previously raised up nationalists came to power, having formed an updated people's government: " + this.global1.party_name[0] + " was renamed into the People's Rebirth Party, the government signed a concordat with the church, and the state became the largest shareholder in the the domestic market, which, together with the opening of free trade and the legalization of all kinds of entrepreneurship, led to the formation of the state capitalism. The new leadership began to lead the country in the mainstream of the national way of building a society of class solidarity.";
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(9);
					}
					flag = true;
				}
				else if (this.global1.data[22] >= 500 && this.global1.data[31] >= 700 && this.global1.data[14] <= 2 && this.global1.allcountries[10].Help && this.global1.data[10] < 500)
				{
					this.text_fake = string.Concat(new object[]
					{
						this.text_fake,
						" In the course of the party reshuffles, a coalition of supporters of socialism with reliance on internal force came to power, having formed a national-people's government. ",
						this.global1.party_name[0],
						" condemned the revisionism of other left-wing parties, adopting an updated program: \"a world view centered on a person, and revolutionary ideas aimed at exercising the independence of the masses.\" ",
						this.global1.allcountries[this.global1.data[0]].name,
						" became a closed country, with brutal authoritarian power and militaristic centralized control, by ",
						this.global1.data[21] + 21,
						" year announcing the creation of its own nuclear weapons, however, despite the massive sanctions, the country continues to exist..."
					});
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(8);
					}
					flag = true;
				}
				else if (this.global1.data[22] >= 500 && this.global1.data[31] >= 700 && this.global1.data[10] >= 500)
				{
					this.text_fake = string.Concat(new object[]
					{
						this.text_fake,
						" In the course of the party reshuffles, a coalition of supporters of sovereignty, socialism with reliance on internal forces and previously raised up nationalists came to power, which led to serious hysteria in the West. In the end, public opinion was expressed by the American side at a meeting of the UN Security Council, during which unanimously a decision was made to introduce a no-flight zone, to recognize the coup as illegitimate, and to approve mass sanctions. As a consequence, the opposition financed by Western special services launched an armed uprising in the country. Bombers and aviation of NATO joined it. The ruling regime fell and the country returned to democratic positions, by ",
						this.global1.data[21] + 8,
						" year having entered NATO."
					});
				}
				else
				{
					this.text_fake += " In the course of the party reshuffles, a coalition of supporters of reform - democratic socialists, democratic communists and left-wing Social Democrats, came to power, beginning a complete withdrawal of state control over the army and other institutions, substantially cutting down the rights of special services and liberalized the regime.";
				}
				if (this.global1.allcountries[19].Help)
				{
					this.text_fake += "|However, the higher ranks of the party managed to escape in time from the country through established channels and obtain political asylum in India.";
					if (this.global1.allcountries[19].Gosstroy <= 1)
					{
						this.text_fake = this.text_fake + " And despite the international pressure, the INC government, to reward for supporting them, did not extradit anyone, having settled the 'refugees' in goverment buildings, where, afterwards, " + this.global1.politics_name[this.global1.data[11]] + " wrote memoirs and autobiography in which he declared himself the last and missed chance of his country to save.";
					}
					else
					{
						this.text_fake += " However, under international pressure, the new Indian government was forced to begin the process of extradition of the incoming party members, as a result of which you all took refuge in the Argentine embassy and, through secret channels, were taken to various countries of Latin America, having changed passport data. ";
					}
				}
				else
				{
					this.text_fake = string.Concat(new object[]
					{
						this.text_fake,
						"|",
						this.global1.politics_name[this.global1.data[11]],
						", while attempting to escape, was seized and isolated in solitary confinement. The rest were imprisoned for different periods, but by ",
						this.global1.data[21] + 5,
						" they received an amnesty for health reasons."
					});
				}
				if (this.global1.data[0] == 1 && (this.global1.data[22] < 700 || this.global1.data[31] < 700))
				{
					if (this.global1.data[16] <= 12)
					{
						this.text_fake += "|The SED was transformed into the Party of Democratic Socialism by joining the coalition with the opposition, and a single center-right alliance won the election, which decided to join the FRG. The industry was privatized by different owners, as a result  the centralized unified management of the economy of the former GDR was violated, after which most of the enterprises were found to be unprofitable and closed, so the central government of Germany had to impose a special tax to redirect finance to the development of the territories of the former GDR.";
					}
					else
					{
						this.text_fake += "|The SED was transformed into the Party of Democratic Socialism by joining the coalition with the opposition, and a single center-right alliance won the election, which decided to join the FRG. The industry was privatized by different owners, but earlier reforms of the East German government made it easier to survive integration into the market economy of West Germany.";
					}
				}
				else if ((this.global1.data[22] < 700 || this.global1.data[31] < 700) && !flag)
				{
					this.text_fake = this.text_fake + "In the first elections, the renewed Socialist Party won out confidently, taking up most of the seats in the parliament, but their celebration did not last long: among the people was found a compromising evidence on the first secretary of the renewed Party, who mentioned that it would be better to introduce Soviet tanks than to indulge the right opposition, as a result of which new mass rallies were held all over the country and the entire leadership of the Party resigned, and the center-right coalition came to power. The country became a permanent member of NATO by " + (this.global1.data[21] + 8).ToString();
				}
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 3)
			{
				this.Name.text = "PARTY COUP";
				if (this.global1.data[11] == 2)
				{
					this.text_fake = "The thoughtless and inconsistent policy of Najibullah began to anger the Parchamists, who decided to enter into a conspiracy against the president, with the support of the USSR. The day after the conspiracy was organized at a meeting of the Politburo, a group of conspirators made sharp accusations against Najibullah, and he, under the pressure of party members, was forced to resign due to health reasons. The government of the next country's leader, in an attempt to start negotiations with the opposition, more and more making concessions to terrorists, failed. As a result, after the collapse of the USSR, the DRA government lost its support, and the opposition entered Kabul without a fight, establishing an Islamic republic in Afghanistan.";
				}
				else if (this.global1.data[11] == 1)
				{
					this.text_fake = "The thoughtless and inconsistent policy of Tanai began to anger the Khalqists, who decided to enter into a conspiracy against the president, with the support of the generals. The day after the conspiracy was organized at a meeting of the Politburo, a group of conspirators made sharp accusations against Tanai, and he, under the pressure of party members, was forced to resign due to health reasons. The tough policies of the next leader and his multiple failed attacks on terrorists lead to large-scale desertion from the Afghan army and the transition to the side of the opposition. As a result, after the collapse of the USSR, the DRA government lost its support, and the opposition entered Kabul without a fight, establishing an Islamic republic in Afghanistan.";
				}
				else if (this.global1.data[11] == 3)
				{
					this.text_fake = "The thoughtless and inconsistent policy of Dostum began to anger more and more representatives of the government, who decided to enter into a conspiracy against the president, with the support of the generals. The day after the conspiracy was organized at a meeting of the Politburo, a group of conspirators made sharp accusations against Dostum, and he, under the pressure of party members, was forced to resign due to health reasons. The tough policies of the next leader and his multiple failed attacks on terrorists lead to large-scale desertion from the Afghan army and the transition to the side of the opposition. As a result, after the collapse of the USSR, the DRA government lost its support, and the opposition entered Kabul without a fight, establishing an Islamic republic in Afghanistan.";
				}
				else if (this.global1.data[11] == 0)
				{
					this.text_fake = "The thoughtless and inconsistent policy began to anger more and more representatives of the government, who decided to enter into a conspiracy against the president, with the support of the generals. The day after the conspiracy was organized at a meeting of the Politburo, a group of conspirators made sharp accusations against the President, and he, under the pressure of party members, was forced to resign due to health reasons. The tough policies of the next leader and his multiple failed attacks on terrorists lead to large-scale desertion from the Afghan army and the transition to the side of the opposition. As a result, after the collapse of the USSR, the DRA government lost its support, and the opposition entered Kabul without a fight, establishing an Islamic republic in Afghanistan.";
				}
			}
			else if (this.global1.data[46] == 4 && this.global1.data[0] == 10)
			{
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(59);
				}
				this.Name.text = "Washington - Moscow - Beijing";
				this.text_fake = "Your unfriendly and overly militaristic foreign policy has begun to anger nearby countries, which were afraid of strengthening the military-strategic independence of the DPRK. As a result, in June 1992, Washington, Beijing and Moscow put forward a proposal to the UN Security Council for a «Settlement of the Korean Question». The leading countries of the world accuse North Korea of actively developing nuclear weapons, brutal and repressive domestic policies, as well as of numerous provocations near the demilitarized zone. As a result, most countries of the world, with few exceptions, adopt a UN resolution that prohibits the maintenance of any trade and economic ties with the blockade, and sanctions are imposed on the DPRK top leadership. Despite this, the North managed to resist political and economic pressure for some time, however, soon a UN peacekeeping contingent was sent to the country to eliminate the «Korean threat». UN forces quickly occupy strategic military points in the country and launch an attack on Pyongyang. Despite the abundant propaganda in the spirit of the Korean War, the Koreans themselves are enthusiastic about peacekeepers, calling them «saviors». In the end, the leadership of the DPRK was isolated in the Kumsusan Palace. After a successful assault, they were all sent to the Hague for «crimes against peace and humanity». By decision of the UN Security Council, a temporary unlimited demilitarized zone was established in North Korea, and the Transitional Administration was established, headed by the son of Kim Jong Il, Kim Jong Nam, who is actually a UN puppet. After all this, agreements were reached between the PRC and the USA, according to which the US undertake not to deploy troops in the territory of the former DPRK, and the PRC, in turn, vows not to interfere in the affairs of New Korea.";
			}
			else if (this.global1.data[46] == 4)
			{
				this.Name.text = "NATO INVASION";
				if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
				{
					this.text_fake = "Systematic violations of human rights, mass deportations of peoples and the liquidation of any democratic institutions on the territory of Yugoslavia have long attracted the attention of the international community and forced it to intervene. NATO countries decided to organize a full-scale military invasion of Yugoslavia in order to “bring it democracy.” Sanctions The UN did not receive permission for this, but it was not needed - exhausted from the fight against internal enemies, the JNA could not withstand several months of bombing, during which a significant part of the military and economic potential of Yugoslavia was destroyed. The air operation was followed by a ground operation, as a result of which the territory of the country was destroyed. occupied and dismembered along administrative boundaries (however, they decided to keep Vojvodina as part of Serbia in order to maintain its conflict with Hungary). Most of the former leadership by " + (this.global1.data[21] + 8).ToString() + " was captured and brought before the International Criminal Tribunal for the Former Yugoslavia established in The Hague. 10 years after the operation, all post-Yugoslav republics became part of NATO, and then the EU.";
				}
				else
				{
					if (this.global1.data[14] > 0 && this.global1.data[14] < 3)
					{
						this.text_fake = "Your authoritarian and brutal rule, along with active intervention in international events, led to serious hysteria in the West.";
					}
					else if (this.global1.data[14] < 1)
					{
						this.text_fake = "Your brutal and bloody rule, along with active intervention in international events, led to serious hysteria in the West.";
					}
					else if (this.global1.data[14] > 3 && this.global1.data[22] >= 700 && this.global1.data[31] >= 700)
					{
						this.text_fake = "Your brutal and nationalist rule, along with active intervention in international events, led to serious hysteria in the West.";
					}
					else
					{
						this.text_fake = "Your independent and sovereign rule and your attempts to actively intervene in international events in an attempt to become a new leading force in the world have led to widespread discontent in the West.";
					}
					this.text_fake += " The Americans called an urgent meeting of the UN Security Council, where they announced the infringement of national minorities in our country, the active production of chemical weapons, the active development of nuclear weapons and the existence of an authoritarian mafia government with massive repressions of unwanted.";
					if (this.global1.data[14] < 3 || (this.global1.data[14] > 4 && this.global1.data[22] >= 700 && this.global1.data[31] >= 700))
					{
						this.text_fake = string.Concat(new object[]
						{
							this.text_fake,
							"At this meeting unanimously a decision was made to introduce a no-flight zone and to approve mass sanctions. As a consequence, the opposition financed by Western special services launched an armed uprising in the country. Bombers and aviation of NATO joined it. The ruling regime fell and the country returned to democratic positions, by ",
							this.global1.data[21] + 8,
							" year having entered NATO."
						});
					}
					else if (this.global1.data[14] < 4)
					{
						this.text_fake = string.Concat(new object[]
						{
							this.text_fake,
							"At this meeting, only NATO members supported American initiatives, and China and Russia abstained from voting, as a result of which a decision was made to introduce a no-flight zone and to approve mass sanctions. As a consequence, the opposition financed by Western special services launched an armed uprising in the country. Bombers and aviation of NATO joined it. The ruling regime fell and the country returned to democratic positions, by ",
							this.global1.data[21] + 8,
							" year having entered NATO."
						});
					}
					else
					{
						this.text_fake = string.Concat(new object[]
						{
							this.text_fake,
							"At this meeting, China and Russia sharply opposed the US initiative, because even NATO members, with the exception of Great Britain, abstained from voting, as a result of which a joint decision was not adopted to introduce a no-fly zone and to approve mass sanctions. However, despite the UN decision, the Americans announced the introduction of a no-fly zone, all kinds of sanctions and blockade, and then the opposition financed by Western special services launched an armed uprising in the country. It was joined by bombers, marines and aviation of US. The ruling regime fell and the country returned to democratic positions, by ",
							this.global1.data[21] + 8,
							" year having entered NATO."
						});
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(10);
						}
					}
				}
				if (this.global1.allcountries[19].Help)
				{
					this.text_fake += "|However, the higher ranks of the party managed to escape in time from the country through established channels and obtain political asylum in India.";
					if (this.global1.allcountries[19].Gosstroy <= 1)
					{
						this.text_fake = this.text_fake + " And despite the international pressure, the INC government, to reward for supporting them, did not extradit anyone, having settled the 'refugees' in goverment buildings, where, afterwards, " + this.global1.politics_name[this.global1.data[11]] + " wrote memoirs and autobiography in which he declared himself the last and missed chance of his country to save.";
					}
					else
					{
						this.text_fake += " However, under international pressure, the new Indian government was forced to begin the process of extradition of the incoming party members, as a result of which you all took refuge in the Argentine embassy and, through secret channels, were taken to various countries of Latin America, having changed passport data. ";
					}
				}
				else
				{
					this.text_fake = string.Concat(new object[]
					{
						this.text_fake,
						"|",
						this.global1.politics_name[this.global1.data[11]],
						", while attempting to escape, was seized and isolated in solitary confinement, and then hanged by the people's tribunal. The rest were imprisoned for different periods, but by ",
						this.global1.data[21] + 5,
						" they received an amnesty for health reasons."
					});
				}
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 5)
			{
				this.Name.text = "INVASION OF THE USSR";
				if (this.global1.allcountries[7].Gosstroy == 0)
				{
					this.text_fake = "Your overly independent and revisionist rule has infuriated the new Soviet leaders. And since you could not provide due support of the people, nor a strong army, nor external diplomatic protection, the Soviet Union was able to re-establish its control over your territory with joy.|After that, the USSR regained control over most of its international sphere. Under the leadership of the new President of the USSR, Comrade Alksnis, the Soviet Union, led by a mixed economy, once again became a world power.";
				}
				else
				{
					this.text_fake = "Your overly independent and revisionist rule has infuriated the new Soviet leaders. And since you could not provide due support of the people, nor a strong army, nor external diplomatic protection, the Soviet Union was able to re-establish its control over your territory with joy.|After that, the USSR regained control over most of its international sphere. Under the leadership of the new President of the USSR, Comrade Pugo, the Soviet Union, led by a mixed economy, once again became a world power.|A couple of years later, in perfect secrecy, Gorbachev was retired for health reasons and began to live quietly under the supervision of the KGB.";
				}
				this.text_fake = string.Concat(new string[]
				{
					this.text_fake,
					"|",
					this.global1.politics_name[this.global1.data[11]],
					" was expelled from the ruling party with shame and sent into exile, and the ",
					this.global1.party_name[0],
					" was renamed the Communist Party."
				});
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(11);
				}
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 6 && this.global1.data[0] != 12)
			{
				this.Name.text = "YOUR LAST ELECTIONS";
				this.text_fake = "You lost the election. And losers aren't needed by anyone.";
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 6)
			{
				this.Name.text = "LAST ELECTIONS";
				this.text_fake = "Despite our peacekeeping goals, we were not able to win the first free elections, and as a result, the absolute majority in the parliament was occupied by Islamic fundamentalists, who, after the formation of the government, repealed all the PDPA decrees, having previously banned it and started arresting its leaders. As a result, due to the reactionary policies of the new leadership, in the traditionally pro-socialist regions, unrest begins, transiently turning into pogroms and bloody uprisings. It seems that a new civil war cannot be avoided.";
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 7)
			{
				this.Name.text = "Afterglow of Hoxhaism";
				this.text_fake = "Albania is transforming into theocracy. There are not very many dissatisfied with these changes, but women's rights are already declining, the burqa has become mandatory, the introduction of Sharia law has begun, and the imams are gaining more power. Nexhmije Hoxha, the first and only female ruler, became nothing more than a puppet of the clergy of her own free will. ";
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 8)
			{
				this.Name.text = "Fall of Juche's Sun";
				this.text_fake = "Because of the increased militarization and the aggressive foreign policy of North Korea, The United States of America, with the support of their allies, managed to get their resolution approved by the UN Security Council - to immediately intervene militarily into DPRK, to put an end to the North's  very much independent and unpredictable political course and to prevent a massive military conflict with the South. And even our former ally China betrayed us, not having said anything in our support. After the imperialist invasion into North Korea, and the first great catastrophical defeats of the North Korean Army, the Army commanders decide to not use nuclear weapons, and conspiring together with the USA, do a coup d'etat against the country's leader O Jin-u and then give him up to the UN military contingent. There is essentially a \"new Nuremberg Trial\" which occurs with the Generalissimus of the DPRK, as a result of which he is executed together with some of his closest conspirators. After the massive defeat of the DPRK, the process of integration of it into the Republic of Korea began, and now after so many casualties, the Korean people are united gain and many troubles await them in the future.";
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 9)
			{
				this.Name.text = "THIRD KOREAN WAR";
				this.text_fake = string.Concat(new string[]
				{
					"In early December 1991, North Korea began full militarization. The divisions and armaments of the Korean People’s Army were transported in complete secret from the outside world and the public to the 38th parallel. December 31, on the eve of the new 1992, the DPRK leader ",
					this.global1.politics_name[this.global1.data[11]],
					" announced that «American puppet - South Korea launched a missile attack on North Korean positions, thereby violating the demilitarized zone between the two countries». After that, the North Korean troops, under the guise of artillery, attacked the positions of South Korea, and soon the tank divisions in the reserve joined them. The effect of surprise and lightning blitzkrieg was able to ensure the DPRK's successful offensive in the early days of the new Korean War. North Korean propaganda during this time has already begun to agitate «For the war to the victory end» and «Liberation of the Homeland from Colonial Slavery of the USA». Head of the DPRK ",
					this.global1.politics_name[this.global1.data[11]],
					" was equated with the rank of the great Korean military commanders, standing on a par with Li Songsin and Jong Bon-soo. Nevertheless, the Korean offensive was quickly drowned, and the mobilized forces of the US military base in Korea with renewed vigor began the operation to liberate the South. Exalted by official propaganda «the victorious workers' army of Korea» fell apart under the blows of the Americans and did not hold the front, after which a stampede began, the war quickly moved to the territory of the North. Contrary to the expectations of the leadership, the PRC did not intercede for the North, and, as a result, the high command disobeyed the order of the incumbent president to launch a nuclear attack on South Korea, deciding to extradite the DPRK president to America in exchange for preserving his own skins. A few days later, Pyongyang fell almost without resistance. Korea has become united, and a new tribunal is convening in The Hague to sentence leaders to the DPRK."
				});
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(59);
				}
			}
			else if (this.global1.data[46] == 10)
			{
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(64);
				}
				this.Name.text = "Islamic State of\nAfghanistan";
				this.text_fake = "|||After the withdrawal of Soviet troops, the situation in Afghanistan began to deteriorate rapidly - the inconsistent PDPA policy, together with disagreements in it and in the army leadership, led the people to turn their backs on the Afghan government, and the army hardly restrained the onslaught of terrorists. Caught in international isolation, Afghanistan could not get outside support, and Pakistan continued to send more and more Islamist groups with impunity. Terrorists managed to take Kabul, proclaiming Afghanistan an Islamic state. All the gains of Soviet power in social, economic and legal fields were destroyed. And after 4 years, " + this.global1.politics_name[this.global1.data[11]] + " himself was brutally murdered without trial.";
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 11)
			{
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(64);
				}
				this.Name.text = "Islamic State of\nAfghanistan";
				this.text_fake = "|||After the withdrawal of soviet army, situation in Afghanistan began to deteriorate rapidly - inconsistent policy of PDPA together with disagreements inside it and among military leadership resulted in that the people became more opposed to the government and army could hardly resist mujahadeen's onslaught. Afghanistan appeared in international isolation, could not get any external support, while Pakistan continued to send more and more islamists without any negative consequences for itself. Mujahadeen managed to capture Kabul and proclaim Afghanistan an islamic state. All socialist achievments in social, economical and legal areas were destroyed. 4 years later " + this.global1.politics_name[this.global1.data[11]] + " himself was brutally murdered without trial.";
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 12)
			{
				this.Name.text = "Hungarian Romania";
				this.text_fake = this.dlce1.credits_text[29];
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 23)
			{
				this.Name.text = this.dlce1.credits_text[240];
				this.text_fake = this.dlce1.credits_text[202];
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 23)
			{
				this.Name.text = this.dlce1.credits_text[240];
				this.text_fake = this.dlce1.credits_text[202];
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 24)
			{
				this.Name.text = this.dlce1.credits_text[246];
				this.text_fake = this.dlce1.credits_text[247];
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 25)
			{
				this.Name.text = this.dlce1.credits_text[248];
				this.text_fake = this.dlce1.credits_text[249];
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 26)
			{
				this.Name.text = this.dlce1.credits_text[248];
				this.text_fake = this.dlce1.credits_text[250];
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 27)
			{
				this.Name.text = "Ops over";
				this.text_fake = "||January 11, 1992 at 11:30 a.m. YNA receives an anonymous message about an upcoming terrorist attack. Unfortunately, the Yugoslav army underestimated the scale of the attack. So, during the grand opening of the bust of Arso Jovanovic in Belgrade, a powerful explosion occurred, followed by an attack by a group of about 50 militants of the People's Movement of Kosovo. There were losses. Result: during the terrorist attack,  " + this.global1.politics_name[this.global1.data[11]] + " and almost the entire leadership of Yugoslavia were killed. The country has fallen into a severe political crisis.";
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 28)
			{
				this.Name.text = this.dlce1.credits_text[263];
				this.text_fake = this.dlce1.credits_text[264];
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 29)
			{
				this.Name.text = this.dlce1.credits_text[272];
				this.text_fake = this.dlce1.credits_text[273];
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 30)
			{
				this.Name.text = this.dlce1.credits_text[312];
				this.text_fake = this.dlce1.credits_text[313];
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 31)
			{
				this.Name.text = this.dlce1.credits_text[319];
				this.text_fake = this.dlce1.credits_text[320];
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 32)
			{
				this.Name.text = "Correction Report Number " + this.global1.Num1;
				this.text_fake = string.Concat(new string[]
				{
					"||Today, another sad case has been registered in the Department for the Supervision of the Trustworthiness of Citizens of the Bureau of Guardians.| Number ",
					this.global1.Num1,
					", the day before, detained by the staff of the Bureau of Guardians on suspicion of unreliability and anti-state activities, during interrogation and subsequent verification, he demonstrated serious deviations from the norms of behavior and thinking prescribed by the Code of Builders of a Single State.| In particular, ",
					this.global1.Num1,
					" repeatedly expressed absurd doubts about the reality of the world around him and demonstrated progressive aspirations for serious manifestations of autoaggression. Despite all the efforts of the staff of the Bureau of Guardians to conduct intensive therapeutic procedures and worldview correction ",
					this.global1.Num1,
					", He has never been able to overcome his deeply ingrained irrational urges.| As a result, in order to alleviate the difficult situation of the patient, in accordance with the instructions of the Benefactor's order, ",
					this.global1.Num1,
					"  was subjected to a Great Operation, which was successful.| The next day, numer was discharged from the supervision of doctors and returned to his duties after a short time."
				});
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 33)
			{
				this.Name.text = "Unsuccessful acquaintance";
				this.text_fake = string.Concat(new string[]
				{
					this.global1.Num1,
					" decided not to give in to the old-fashioned impulse that was sounding the alarm about the current situation, and began to behave strictly according to the instructions, which stated that each number was a loyal comrade to each other. Approaching them, the foreman noticed that they were a baggy T-351 in a uniform that was not his size, an elongated and deliberately starched B-404 and a pretty A-270. The latter began to actively wave ",
					this.global1.Num1,
					". \"What friendly numbers,\" the foreman thought and waved back. At that moment, there was a small clap and only at that moment ",
					this.global1.Num1,
					" realized that their faces were filled with fear, and now also horror. \"Smiles suit them much better ...\" the foreman thought before his vision was obscured by darkness. Only the measured knock of hammers echoed in his head, with which he continued to live One state."
				});
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 34)
			{
				this.Name.text = "Surprise attack";
				this.text_fake = string.Concat(new string[]
				{
					"After ",
					this.global1.Num1,
					" came out of hiding and opened his mouth to introduce himself to the Numbers, A-270 pulled a short oblong object out of her pocket, and at that moment a small pop was heard. Something struck the foreman through and through, after which a verbal altercation began between the visibly frightened group, the end of which ",
					this.global1.Num1,
					" never heard. The last thing that was imprinted in his head was the measured knocking of hammers, symbolizing the heartbeat of the One State."
				});
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 35)
			{
				this.Name.text = "Threat on the other side of the mirror";
				this.text_fake = "Having returned to examining the body, " + this.global1.Num1 + " decided to continue examining the pockets of O-213's uniform. The front pockets were empty, but one of the lower pockets clearly contained some round object. Having brought it to the surface, the number found a white pocket mirror. Having opened it, the foreman's well-groomed face stared at him. Before he had time to enjoy his portrait, a glare appeared in the mirror, after which the number's body fell onto the already cold corpse of O-213.";
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 36)
			{
				this.Name.text = "Stab in the back";
				this.text_fake = string.Concat(new string[]
				{
					"Overcoming the urge to flee the scene of the crime, ",
					this.global1.Num1,
					" resolutely headed towards the source of the strange noise behind the distant machines. |Making his way along the row of workstations, he tried to listen to the silence, trying to understand its source. Everything was quiet. Finally, ",
					this.global1.Num1,
					" reached the place where he thought the sound was coming from. \"It must have seemed that way\", the foreman thought. |After he turned his back to the machine, something stabbed him in the back. Suddenly, at that moment, a sharp, burning pain ran down his back, causing ",
					this.global1.Num1,
					" to fall to his knees, and a minute later he was already lying unconscious. The last thing he heard was the mysterious grin of a passing number. \"Help...\" the foreman croaked, after which he fell silent."
				});
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 37)
			{
				this.Name.text = "Numerous repentance";
				this.text_fake = "After admitting his guilt, the Keeper stopped listening to the number. For his former merits in the work of " + this.global1.Num1 + " he was subjected to the Great Operation, following which he returned to society as a corrected individual who would not put the public below his momentary thoughts. The life of the United State continued its turn, and only the wind of distant shores could disturb the algebraically constructed life according to Taylor.";
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 38)
			{
				this.Name.text = "Successful re-education";
				this.text_fake = "The Guardian reported that it was precisely because the number began to put his opinion above the instructions entrusted to him that he should undergo a certain procedure that would cure him of this vice. As a result of the Great Operation, " + this.global1.Num1 + " returned to society as a corrected individual who would not put the public below his momentary thoughts. The life of the United State continued its turn, and only the wind from distant shores could disturb the algebraically constructed life according to Taylor.";
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 39)
			{
				this.Name.text = "Successful re-education";
				this.text_fake = "The Guardian reported that thanks to this, the number would be able to get rid of his actions with the Great Operation, which would allow him to continue serving the One State. As a result of it, " + this.global1.Num1 + " returned to society as a corrected individual who would not put the public above his momentary thoughts. The life of the One State continued its turn, and only the wind from distant shores could disturb the algebraically constructed life according to Taylor.";
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 40)
			{
				this.Name.text = "Successful re-education";
				this.text_fake = "The Guardian merely brushed aside the offer of assistance from yet another number, stating that such a corrupted number could not provide any assistance in the investigation that would not violate the instructions created for this purpose. For his former merits in the work, " + this.global1.Num1 + " was subjected to the Great Operation, following which he returned to society as a corrected individual who would not put the public below his momentary thoughts. The life of the United State continued its turn, and only the wind from distant shores could disturb the algebraically constructed life according to Taylor.";
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 41)
			{
				this.Name.text = "Quiet cotton";
				this.text_fake = string.Concat(new string[]
				{
					"After much internal tossing and turning, ",
					this.global1.Num1,
					" decided that further investigation would be too dangerous and could jeopardize his existence. And what was the probability that he had interpreted the message correctly and that there really would be something there? There was no point in contacting the Bureau of Guardians either, since no one would believe him, and the threat could well be far-fetched. |The next day, as if nothing had happened, he returned to work and followed all the instructions that were sent to him from above. They were probably calculated with truly algebraic precision, since there had been no suspicious incidents for months. Every day, number ",
					this.global1.Num1,
					" came to work, did it, and returned home. No burning smell could stop him from doing this. Smell? Wha…"
				});
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 42)
			{
				this.Name.text = "Moving to a new position";
				this.text_fake = "Taking up his new position, " + this.global1.Num1 + " completely immersed himself in work and meticulously approached the fulfillment of his duties both to his superiors and to his subordinates. Very soon his actions paid off and a year later he was promoted, which imposed new concerns and responsibilities on him. |At the same time, a series of strange deaths and disappearances of Numbers at the HRT-39829 factorium continued for several more months, after which it stopped as suddenly as it began. Most likely, the valiant guardians were able to once again protect the United State from the encroachments of enemies. |Life goes on and the measured sound of machines and the hum of pipes symbolize the pulse of a giant machine called the society of Numbers.";
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 43)
			{
				this.Name.text = "Secret death";
				this.text_fake = "The next morning he went to work at the factorium as usual, but he never got there. Halfway there he fell unconscious, to the general surprise of the other numbers, who had always considered him a physically fit citizen who never complained of health problems. A subsequent examination of the body would show only a small injection mark on his arm. Subsequently, the death files of numbers T-351, A-270, O-213, " + this.global1.Num1 + " were classified and hidden from their colleagues at the factorium.";
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 44)
			{
				this.Name.text = "Who is " + this.global1.Num1 + "?";
				this.text_fake = string.Concat(new string[]
				{
					"After much internal tossing and turning, ",
					this.global1.Num1,
					" decided that he clearly couldn't do anything alone, and that such dangerous activities should be entrusted to the appropriate bodies that should deal with them, namely the Bureau of Guardians. The next day, he discreetly left a small note at one of the Bureau's branches, and then began to wait. |At this point, the records of the further existence of the number ",
					this.global1.Num1,
					" are interrupted. No one saw him again, no one knew about him, and only the monotonous sound of the hammers of the machine tool faithful to the number measured the pulse of the One State."
				});
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 45)
			{
				this.Name.text = "Hero of the United State";
				this.text_fake = "The Guardian nodded his head understandingly and said that due to the disclosure of confidential information and the need for the foreman's personal participation in the operation, his refusal would not be accepted. To give him confidence, the number was subjected to the Great Operation, which allowed him to forget about various personal fears and concerns. On the appointed day, " + this.global1.Num1 + " behaved like a hero and was remembered by all his subordinates as a true Taylorist. This is where his story ends, but the life of the United State, which survived another assassination attempt, does not end. Only a mathematically verified calculation once again showed the superiority of a modern number over betrayal.";
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 46)
			{
				this.Name.text = "Incapacitated";
				this.text_fake = "After Foreman " + this.global1.Num1 + " gave his instructions to his subordinates and disappeared into the lower floors of the Factorium, no one saw him again. A few days later, after a thorough search by the Bureau of Guardians, he was declared permanently incapacitated, and his position was filled by one of his deputies. In doing so, he merely continued the chain of mysterious disappearances and murders that have plagued Factorium HRT-39829.";
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 47)
			{
				this.Name.text = "Death in the line of duty";
				this.text_fake = string.Concat(new string[]
				{
					"A strong wind blew, forcing ",
					this.global1.Num1,
					" to take a step to the side. Continuing to wave his hand, he suddenly realized that his strength was leaving him. In just a few seconds, he was falling forward face down, wondering what was happening. The Number tried to stay on his feet, but his body, which had faithfully folded him for many years, treacherously failed him. He only managed to turn around before he quickly collapsed forward, unable to understand what was happening. The picture before his eyes began to blur. The cries of unfamiliar Numbers and the sound of some kind of fuss behind his back interrupted the measured knocking of the chisel, which echoed in the ears of ",
					this.global1.Num1,
					", symbolizing the eternal work of the heart of the United State. \"I hope that my Numbers will be safer than me\" - with such thoughts, the cycle of the foreman of the factorium HRT-39829 ",
					this.global1.Num1,
					"went to reboot."
				});
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 48)
			{
				this.Name.text = "Conspiracy at the cost of life";
				this.text_fake = string.Concat(new string[]
				{
					"As the figures approached him, ",
					this.global1.Num1,
					" panicked and couldn't decide what to do - resist, surrender, run, as a result of which several strong hands immediately grabbed him, not giving him a chance to escape. | Several more people, dressed just as strangely as the first ones, burst into the room. ",
					this.global1.Num1,
					" saw how they were quickly discussing something, throwing angry glances at him. | Suddenly, something rumbled overhead, ",
					this.global1.Num1,
					" and the room filled with acrid smoke. One of the attackers shouted something, and in response, a strange grinding sound sounded in the air and flames burst into flames in the place where the foreman had been standing. | The smoke, mixed with bright flashes of fire, instantly covered everything around. ",
					this.global1.Num1,
					" quickly lost consciousness, choking on the acrid suffocating air. They held him tightly, not allowing him to escape.|Through the veil of smoke, ",
					this.global1.Num1,
					" saw that a scuffle had broken out between the figures, the results of which remained unknown to the foreman, due to his gradual loss of consciousness. Closing his eyes, ",
					this.global1.Num1,
					" waited for the inevitable. The tongues of flame were getting closer and closer to him, burning his skin. But even in this terrible moment, he did not regret his decision to enter this door. At least he knew that he had been able to prevent something more terrible that the shadows were preparing for the One State."
				});
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 49)
			{
				this.Name.text = "Disposal of Number " + this.global1.Num1;
				this.text_fake = string.Concat(new string[]
				{
					"|||Today, another sad case was registered in the Department for Supervision of Citizens' Reliability of the Bureau of Guardians.| Number ",
					this.global1.Num1,
					", in violation of the instructions, was alternately pressing buttons on the terminal keyboard with an aimless look, watching the icons of departments and divisions change on the screen. When attempts were made to distract the number from this pastime, he grabbed the engineering block and continued pressing buttons. After the introduction of a tranquilizer and delivery of number ",
					this.global1.Num1,
					" to the Medical Bureau for examination, he continued to repeat incoherent phrases about the \"influence of modifiers\", \"support of the party\", \"change of ministries\". He did not regain consciousness.| Due to the secrecy of the old-regime terms voiced, it was decided to subject the brain of number ",
					this.global1.Num1,
					" to a more thorough study to scan the information spoken. The residual body underwent a procedure of processing and disassembly in in accordance with instruction SD-90456."
				});
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 50)
			{
				this.Name.text = this.dlce1.credits_text[240];
				this.text_fake = this.dlce1.credits_text[339];
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 51)
			{
				this.Name.text = this.dlce1.credits_text[56];
				this.text_fake = this.dlce1.credits_text[344];
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] >= 13 && this.global1.data[46] <= 22)
			{
				this.Name.text = this.dlce1.credits_text[51 + this.global1.data[46] - 13];
				this.text_fake = this.dlce1.credits_text[61 + this.global1.data[46] - 13];
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == -1)
			{
				this.Name.text = this.dlce1.credits_text[114];
				this.text_fake = this.dlce1.credits_text[112];
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == -2)
			{
				this.Name.text = this.dlce1.credits_text[115];
				this.text_fake = this.dlce1.credits_text[113];
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
				GameObject.Find("Back").GetComponent<SpriteRenderer>().sprite = this.winfon;
				GameObject.Find("plane").GetComponent<SpriteRenderer>().sprite = this.winplan;
			}
			else if (this.global1.data[46] <= -3 && this.global1.data[46] >= -6 && this.global1.data[131] == 0)
			{
				this.Name.text = this.dlce1.credits_text[119 - this.global1.data[46] - 3];
				this.text_fake = this.dlce1.credits_text[123 - this.global1.data[46] - 3];
				global::UnityEngine.Object.Destroy(this.button_l);
				global::UnityEngine.Object.Destroy(this.button_r);
			}
			else if (this.global1.data[46] == 0)
			{
				if (this.global1.data[128] == 2)
				{
					this.yug1.gameState.yugregions[1].owner = 1;
				}
				if (this.global1.data[136] == 1 && this.global1.data[137] == 1)
				{
					this.yug1.gameState.yugregions[3].owner = 3;
				}
				this.ThisEndingWindow(null, 0);
			}
		}
		else if (this.global1.data[46] == 1 && this.global1.data[0] != 12)
		{
			this.Name.text = "СВЕРЖЕНИЕ РЕВОЛЮЦИЕЙ";
			if (this.global1.data[14] > 0 && this.global1.data[14] < 3)
			{
				this.text_fake = "Из-за вашей консервативной политики";
			}
			else if (this.global1.data[14] < 1 || this.global1.data[14] > 4)
			{
				this.text_fake = "Из-за вашей чрезмерно радикальной и поспешной политики";
				if (this.global1.data[14] > 4 && this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(6);
				}
			}
			else
			{
				this.text_fake = "Из-за вашей неуверенной и неустойчивой политики";
			}
			if (this.global1.data[5] < 400)
			{
				this.text_fake += " и широких социальных проблем";
			}
			this.text_fake += " народ, ожидавший куда большего, пришел в ярость. Его абсолютно не удовлетворили проводимые вами реформы и ситуация в стране накалилась еще больше. Разъяренные толпы вышли на улицы с требованиями отставки руководства, однако, когда полиция подоспела к митингам для обеспечения безопасности, это было воспринято как попытка разогнать народные шествия (хотя, может быть, здесь постарались и иностранные провокаторы), вследствие чего началось противостояние. Полиция отступила, отказываясь стрелять в народ, и толпы начали погромы и захват административных зданий и архивов спецслужб. Солдаты отказались выходить из казарм, и сопротивление сотрудников спецслужб и отдельных полицейских вскоре было подавлено.";
			if (this.global1.allcountries[19].Help)
			{
				this.text_fake += "|Однако, высшие чины партаппарата сумели вовремя сбежать из страны по налаженным каналам и получить политическое убежище в Индии.";
				if (this.global1.allcountries[19].Gosstroy <= 1 && this.global1.data[21] > 1989)
				{
					this.text_fake = this.text_fake + " И, несмотря на международное давление, благодарное нам за поддержку правительство ИНК никого не выдало, поселив 'беженцев' в казённых помещениях, где, впоследствии, " + this.global1.politics_name[this.global1.data[11]] + " написал мемуары и автобиографию, в которых объявил себя последним и упущенным шансом своей страны на спасение.";
				}
				else
				{
					this.text_fake += " Впрочем, под международным давлением, новое индийское правительство вынуждено было начать процесс экстрадиции прибывших партаппаратчиков, следствием чего вы все укрылись в аргентинском посольстве и по тайным каналам были вывезены в разные страны Латинской Америки, сменив паспортные данные. ";
				}
			}
			else
			{
				this.text_fake = string.Concat(new object[]
				{
					this.text_fake,
					"|",
					this.global1.politics_name[this.global1.data[11]],
					", при попытке бегства, был схвачен и казнен без суда и следствия наспех организованным революционным трибуналом, вместе с некоторыми высшими партийными деятелями. Остальные были посажены в тюрьму на разные сроки, но к ",
					this.global1.data[21] + 5,
					" году получили амнистию по состоянию здоровья."
				});
			}
			if (this.global1.data[0] == 1)
			{
				if (this.global1.data[16] <= 12)
				{
					this.text_fake += "|СЕПГ была запрещена, а на выборах победила единая правоцентристская коалиция, принявшая решение войти в состав ФРГ. Промышленность была приватизирована разными владельцами, вследствие этого было нарушено централизованное единое управление экономикой бывшей ГДР, после чего большая часть предприятий были признаны убыточными и закрыты, поэтому центральному правительству ФРГ пришлось вводить специальный налог для перенаправления финансов в развитие территорий бывшей ГДР.";
				}
				else
				{
					this.text_fake += "|СЕПГ была запрещена, а на выборах победила единая правоцентристская коалиция, принявшая решение войти в состав ФРГ. Промышленность была приватизирована разными владельцами, однако ранее проведенные реформы восточногерманского правительства позволили более легко пережить интеграцию в рыночную экономику Западной Германии.";
				}
			}
			else
			{
				this.text_fake = string.Concat(new object[]
				{
					this.text_fake,
					"|На первых, по словам западных журналистов, самых свободных выборах победила правоцентристская коалиция, вследствие чего к ",
					this.global1.data[21] + 8,
					" году страна стала постоянным членом НАТО."
				});
			}
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 2 && this.global1.data[0] != 12)
		{
			this.Name.text = "НАРОДНЫЕ ВОЛНЕНИЯ";
			if (this.global1.data[14] > 0 && this.global1.data[14] < 3)
			{
				this.text_fake = "Из-за вашей консервативной политики";
			}
			else if (this.global1.data[14] < 1 || this.global1.data[14] > 4)
			{
				this.text_fake = "Из-за вашей чрезмерно радикальной и поспешной политики";
			}
			else
			{
				this.text_fake = "Из-за вашей неуверенной и неустойчивой политики";
			}
			if (this.global1.data[5] < 400)
			{
				this.text_fake += " и широких социальных проблем";
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(7);
				}
			}
			this.text_fake = string.Concat(new string[]
			{
				this.text_fake,
				" народ, потерявший терпение, начал организацию массовых стачек и митингов, которые продолжались несколько недель и превратились в целые палаточные городки. За это время партаппарат стал сомневаться в своем лидере и отдельные его представители тайно организовали заговор, вследствие чего ",
				this.global1.politics_name[this.global1.data[11]],
				" был смещен, а затем и другие его приближенные деятели. Но митинги не прекращались и под их давлением и давлением молодых кадров в отставку ушли и умеренные представители. Следствием этого стало масштабное обновление руководящих рядов ",
				this.global1.party_name[0],
				" и окончательная либерализация режима. Лидирующая партия была переименована, а на бывших руководителей открыли уголовное дело."
			});
			if (this.global1.allcountries[19].Help)
			{
				this.text_fake += "|Однако, высшие чины партаппарата сумели вовремя сбежать из страны по налаженным каналам и получить политическое убежище в Индии.";
				if (this.global1.allcountries[19].Gosstroy <= 1)
				{
					this.text_fake = this.text_fake + " И, несмотря на международное давление, благодарное нам за поддержку правительство ИНК никого не выдало, поселив 'беженцев' в казённых помещениях, где, впоследствии, " + this.global1.politics_name[this.global1.data[11]] + " написал мемуары и автобиографию, в которых объявил себя последним и упущенным шансом своей страны на спасение.";
				}
				else
				{
					this.text_fake += " Впрочем, под международным давлением, новое индийское правительство вынуждено было начать процесс экстрадиции прибывших партаппаратчиков, следствием чего вы все укрылись в аргентинском посольстве и по тайным каналам были вывезены в разные страны Латинской Америки, сменив паспортные данные. ";
				}
			}
			else
			{
				this.text_fake = string.Concat(new object[]
				{
					this.text_fake,
					"|",
					this.global1.politics_name[this.global1.data[11]],
					", при попытке бегства, был схвачен и изолирован в одиночной камере. Остальные были посажены в тюрьму на разные сроки, но к ",
					this.global1.data[21] + 5,
					" году получили амнистию по состоянию здоровья."
				});
			}
			if (this.global1.data[0] == 1)
			{
				if (this.global1.data[16] <= 12)
				{
					this.text_fake += "|СЕПГ была преобразована в Партию Демократического Социализма, вступив в коалицию с оппозицией, а на выборах победил единый правоцентристский альянс, принявший решение войти в состав ФРГ. Промышленность была приватизирована разными владельцами, вследствие этого было нарушено централизованное единое управление экономикой бывшей ГДР, после чего большая часть предприятий были признаны убыточными и закрыты, поэтому центральному правительству ФРГ пришлось вводить специальный налог для перенаправления финансов в развитие территорий бывшей ГДР.";
				}
				else
				{
					this.text_fake += "|СЕПГ была преобразована в Партию Демократического Социализма, вступив в коалицию с оппозицией, а на выборах победил единый правоцентристский альянс, принявший решение войти в состав ФРГ. Промышленность была приватизирована разными владельцами, однако ранее проведенные реформы восточногерманского правительства позволили более легко пережить интеграцию в рыночную экономику Западной Германии.";
				}
			}
			else
			{
				this.text_fake = string.Concat(new object[]
				{
					this.text_fake,
					"|На первых, по словам западных журналистов, самых свободных выборах победила правоцентристская коалиция, вследствие чего к ",
					this.global1.data[21] + 8,
					" году страна стала постоянным членом НАТО."
				});
			}
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 1)
		{
			this.Name.text = "СВЕРЖЕНИЕ РЕВОЛЮЦИЕЙ";
			this.text_fake = "Из-за вашей неуверенной и неустойчивой политики, народ, потерявший надежду в режиме НДПА, начал переходить на сторону оппозиции, в армии стали нередки случае дезертирства, и последние военные поражения ДРА стали последней каплей в чаше терпения народа, и в колыбели Апрельской революции – Кабуле разразились массовые протесты, которые скоротечно перетекли в мятеж. Попытки разогнать демонстрацию не увенчались успехом, и мятежники ворвались в правительственные учреждения, начав самосуд против управленцев и партийных работников. В итоге, в Кабуле разразилась анархия, на фоне которой террористы смогли успешно начать наступление и взять столицу, провозгласив Афганистан исламской республикой.";
		}
		else if (this.global1.data[46] == 2)
		{
			this.Name.text = "НАРОДНЫЕ ВОЛНЕНИЯ";
			this.text_fake = "Из-за вашей неуверенной и неустойчивой политики, народ, потерявший надежду в режиме НДПА, начал переходить на сторону оппозиции, в армии стали нередки случае дезертирства, и последние военные поражения ДРА стали последней каплей в чаше терпения народа, и в колыбели Апрельской революции – Кабуле разразились протесты против действующего правительства. Недовольный вашей слабостью и бездействием генералитет попытался организовать военный переворот, чтобы установить в столице порядок, однако армия отказалась стрелять в горожан и перешла на их сторону. В итоге, в Кабуле разразилась анархия, на фоне которой террористы смогли успешно начать наступление и взять столицу, провозгласив Афганистан исламской республикой.";
		}
		else if (this.global1.data[46] == 3 && this.global1.data[0] != 12)
		{
			bool flag2 = false;
			this.Name.text = "ПАРТИЙНЫЙ ПЕРЕВОРОТ";
			this.text_fake = "Ваши политические шаги стали всё больше и больше злить партаппарат и их терпению пришёл конец. Некоторые высокопоставленные деятели " + this.global1.party_name[0] + " вступили в сговор, в который был вовлечен даже ";
			int num8 = global::UnityEngine.Random.Range(0, 3);
			if (num8 == 0)
			{
				this.text_fake += "Министр Внутренних Дел. ";
			}
			else if (num8 == 1)
			{
				this.text_fake += "Министр Обороны. ";
			}
			else if (num8 == 2)
			{
				this.text_fake += "Начальник спецслужб. ";
			}
			if (this.global1.data[0] == 1)
			{
				this.global1.data[10] += 250;
			}
			this.text_fake = this.text_fake + "На следующий день после организации заговора на собрании Политбюро группа заговорщиков выступила с резкими обвинениями в адрес " + this.global1.politics_name[this.global1.data[11]] + ", в ходе которых даже 2 секретарь принял решение не встревать в спор и, под молчанием других членов Политбюро, наш лидер ушел в отставку по состоянию здоровья.";
			if (this.global1.data[22] >= 700 && this.global1.data[31] >= 700 && (this.global1.data[14] > 2 || !this.global1.allcountries[10].Help) && this.global1.data[10] < 500)
			{
				this.text_fake = this.text_fake + "В ходе партийных перестановок к власти пришла коалиция сторонников суверенитета и ранее поднявших голову националистов, сформировав обновленное народное правительство: " + this.global1.party_name[0] + " была переименована в Партию Народного Возрождения, правительство подписало конкордат с церковью, а государство стало крупнейшим акционером на внутреннем рынке, что вкупе с открытием свободной торговли и легализацией всех родов предпринимательства привело к формированию государственного капитализма. Новое руководство стало вести страну в русле национального пути построения общества классовой солидарности.";
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(9);
				}
				flag2 = true;
			}
			else if (this.global1.data[22] >= 500 && this.global1.data[31] >= 700 && this.global1.data[14] <= 2 && this.global1.allcountries[10].Help && this.global1.data[10] < 500)
			{
				this.text_fake = string.Concat(new object[]
				{
					this.text_fake,
					"В ходе партийных перестановок к власти пришла коалиция сторонников социализма с опорой на внутренние силы, сформировав национально-народное правительство. ",
					this.global1.party_name[0],
					" осудило ревизионизм других левых партий, приняв обновленную программу: «мировоззрение, в центре которого — человек, и революционные идеи, нацеленные на осуществление самостоятельности народных масс». ",
					this.global1.allcountries[this.global1.data[0]].name,
					" стала закрытой страной с жестокой авторитарной властью и милитаристическим централизованным управлением, к ",
					this.global1.data[21] + 21,
					" году объявив о создании собственного ядерного оружия, впрочем, несмотря на массовые санкции, страна продолжает существовать..."
				});
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(8);
				}
				flag2 = true;
			}
			else if (this.global1.data[22] >= 500 && this.global1.data[31] >= 700 && this.global1.data[10] >= 800)
			{
				this.text_fake = string.Concat(new object[]
				{
					this.text_fake,
					"В ходе партийных перестановок к власти пришла коалиция сторонников суверенитета, социализма с опорой на внутренние силы и ранее поднявших голову националистов, что привело к нешуточной истерии на Западе. В конечном итоге общественное мнение было выражено американской стороной на заседании Совбеза ООН, в ходе которого единогласно было принято решение о вводе бесполётной зоны, признании переворота нелегитимным, утверждении массовых санкций. Как следствие этого, профинансированная западными спецслужбами оппозиция начала вооруженное восстание в стране. К ней присоединились бомбардировщики и авиация НАТО. Правящий режим пал и страна вернулась на демократические позиции, к ",
					this.global1.data[21] + 8,
					" году выступив в НАТО."
				});
			}
			else
			{
				this.text_fake += "В ходе партийных перестановок к власти пришла коалиция сторонников реформ - демократических социалистов, демократических коммунистов и левых социал-демократов, начав полный вывод государственного контроля над армией и другими учреждениями, существенно урезав права спецслужб и проведя либерализацию режима.";
			}
			if (this.global1.allcountries[19].Help)
			{
				this.text_fake += "|Однако, высшие чины партаппарата сумели вовремя сбежать из страны по налаженным каналам и получить политическое убежище в Индии.";
				if (this.global1.allcountries[19].Gosstroy <= 1)
				{
					this.text_fake = this.text_fake + " И, несмотря на международное давление, благодарное нам за поддержку правительство ИНК никого не выдало, поселив 'беженцев' в казённых помещениях, где, впоследствии, " + this.global1.politics_name[this.global1.data[11]] + " написал мемуары и автобиографию, в которых объявил себя последним и упущенным шансом своей страны на спасение.";
				}
				else
				{
					this.text_fake += " Впрочем, под международным давлением, новое индийское правительство вынуждено было начать процесс экстрадиции прибывших партаппаратчиков, следствием чего вы все укрылись в аргентинском посольстве и по тайным каналам были вывезены в разные страны Латинской Америки, сменив паспортные данные. ";
				}
			}
			else
			{
				this.text_fake = string.Concat(new object[]
				{
					this.text_fake,
					"|",
					this.global1.politics_name[this.global1.data[11]],
					", при попытке бегства, был схвачен и изолирован в одиночной камере. Остальные были посажены в тюрьму на разные сроки, но к ",
					this.global1.data[21] + 5,
					" году получили амнистию по состоянию здоровья."
				});
			}
			if (this.global1.data[0] == 1 && (this.global1.data[22] < 700 || this.global1.data[31] < 700))
			{
				if (this.global1.data[16] <= 12)
				{
					this.text_fake += "|СЕПГ была преобразована в Партию Демократического Социализма, вступив в коалицию с оппозицией, а на выборах победил единый правоцентристский альянс, принявший решение войти в состав ФРГ. Промышленность была приватизирована разными владельцами, вследствие этого было нарушено централизованное единое управление экономикой бывшей ГДР, после чего большая часть предприятий были признаны убыточными и закрыты, поэтому центральному правительству ФРГ пришлось вводить специальный налог для перенаправления финансов в развитие территорий бывшей ГДР.";
				}
				else
				{
					this.text_fake += "|СЕПГ была преобразована в Партию Демократического Социализма, вступив в коалицию с оппозицией, а на выборах победил единый правоцентристский альянс, принявший решение войти в состав ФРГ. Промышленность была приватизирована разными владельцами, однако ранее проведенные реформы восточногерманского правительства позволили более легко пережить интеграцию в рыночную экономику Западной Германии.";
				}
			}
			else if ((this.global1.data[22] < 700 || this.global1.data[31] < 700) && !flag2)
			{
				this.text_fake = string.Concat(new object[]
				{
					this.text_fake,
					"На первых выборах обновлённая Социалистическая Партия уверенно победила, заняв большую часть мест в парламенте, однако их торжество продлилось недолго: среди народа всплыл компромат на 1 секретаря обновлённой Партии, который упоминал, что лучше бы были бы введены советские танки, чем потакать правой оппозиции, вследствие чего по стране прошли новые массовые митинги и всё руководство Партии подало в отставку, а на перевыборах к власти пришла правоцентристская коалиция. К ",
					this.global1.data[21] + 8,
					" году страна стала постоянным членом НАТО."
				});
			}
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 3)
		{
			this.Name.text = "ПАРТИЙНЫЙ ПЕРЕВОРОТ";
			if (this.global1.data[11] == 2)
			{
				this.text_fake = "Необдуманная и непоследовательная политика Наджибуллы стала всё больше и больше злить парчамистов, которые решились вступить в заговор против президента, заручившись поддержкой СССР. На следующий день после организации заговора на собрании Политбюро группа заговорщиков выступила с резкими обвинениями в адрес Наджибуллы, и тот, под давлением партийцев был вынужден уйти в отставку по состоянию здоровья. Правительство следующего лидера страны, в попытках начать переговоры с оппозицией, всё больше и больше идя на уступки террористам, потерпело фиаско. В итоге, после распада СССР, правительство ДРА лишилось своей поддержки, и оппозиция без боя вошла в Кабул, установив в Афганистане исламскую республику.";
			}
			else if (this.global1.data[11] == 1)
			{
				this.text_fake = "Необдуманная и непоследовательная политика Таная стала всё больше и больше злить халькистов, которые решились вступить заговор против президента, заручившись поддержкой генералитета. На следующий день после организации заговора на собрании Политбюро группа заговорщиков выступила с резкими обвинениями в адрес Таная, и тот, под давлением партийцев был вынужден уйти в отставку по состоянию здоровья. Жёсткая политика следующего лидера и его множественные провальные наступления на террористов приведи к масштабному дезертирству из афганской армии и переходу на сторону оппозиции. В итоге, после распада СССР, правительство ДРА лишилось своей поддержки, и оппозиция без боя вошла в Кабул, установив в Афганистане исламскую республику.";
			}
			else if (this.global1.data[11] == 3)
			{
				this.text_fake = "Необдуманная и непоследовательная политика Дустума стала всё больше и больше злить представителей правительства, которые решились вступить заговор против президента, заручившись поддержкой генералитета. На следующий день после организации заговора на собрании правительства группа заговорщиков выступила с резкими обвинениями в адрес Дустума, и тот, под давлением партийцев был вынужден уйти в отставку по состоянию здоровья. Жёсткая политика следующего лидера и его множественные провальные наступления на террористов приведи к масштабному дезертирству из афганской армии и переходу на сторону оппозиции. В итоге, после распада СССР, правительство ДРА лишилось своей поддержки, и оппозиция без боя вошла в Кабул, установив в Афганистане исламскую республику.";
			}
			else if (this.global1.data[11] == 0)
			{
				this.text_fake = "Необдуманная и непоследовательная политика стала всё больше и больше злить представителей правительства, которые решились вступить заговор против президента, заручившись поддержкой генералитета. На следующий день после организации заговора на собрании правительства группа заговорщиков выступила с резкими обвинениями в адрес Президента, и тот, под давлением партийцев был вынужден уйти в отставку по состоянию здоровья. Жёсткая политика следующего лидера и его множественные провальные наступления на террористов приведи к масштабному дезертирству из афганской армии и переходу на сторону оппозиции. В итоге, после распада СССР, правительство ДРА лишилось своей поддержки, и оппозиция без боя вошла в Кабул, установив в Афганистане исламскую республику.";
			}
		}
		else if (this.global1.data[46] == 4 && this.global1.data[0] == 10)
		{
			if (this.global1.iron_and_blood)
			{
				this.achieves.GetComponent<achievements>().Set(59);
			}
			this.Name.text = "Вашингтон - Москва - Пекин";
			this.text_fake = "Ваша недружелюбная и чрезмерно милитаристская внешняя политика стала злить близлежащие страны, которые опасались усиления военно-стратегической независимости КНДР. Вследствие этого, в июне 1992 года Вашингтон, Пекин и Москва выносят предложение в Совете Безопасности ООН о «Решении Корейского вопроса». Ведущие страны мира обвиняют Северную Корею в ведении активных разработок ядерного вооружения, жестокой и репрессивной внутренней политике, а также в многочисленных провокациях близ демилитаризованной зоны. В итоге большинство стран мира, за малым исключением, принимают резолюцию ООН, по которой воспрещается поддержание любых торгово-экономических связей с блокадой, а на высшее руководство КНДР накладываются санкции. Несмотря на это, Северу некоторое время удавалось сопротивляться политическому и экономическому давлению, однако, вскоре в страну был отправлен миротворческий контингент ООН для ликвидации «корейской угрозы». Силы ООН быстро занимают стратегические военные точки в стране и начинают наступление на Пхеньян. Несмотря, на обильную пропаганду в духе Корейской войны, сами корейцы с воодушевлением относятся к военнослужащим-миротворцам, именуя их «спасителями». В конце концов, руководство КНДР оказалось изолировано в Кымсусанском дворце. После его успешного штурма все они были переправлены на суд в Гаагу «за преступления против мира и человечности». Решением Совбеза ООН установилась временная бессрочная демилитаризованная зона в Северной Корее, а также утвердилась Переходная администрация во главе с сыном Ким Чен Ира Ким Чен Намом, который на деле является марионеткой ООН. После всего этого, между КНР и США были достигнуты соглашения, по которым Штаты обязуются не размещать войска на территории бывшей КНДР, а КНР, в свою очередь, клянётся не вмешиваться в дела Новой Кореи.";
		}
		else if (this.global1.data[46] == 4)
		{
			this.Name.text = "ВТОРЖЕНИЕ НАТО";
			if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
			{
				this.text_fake = "Систематические нарушения прав человека, массовые депортации народов и ликвидация каких-либо демократических институтов на территории Югославии долго привлекали внимание международного сообщества и вынудили его вмешаться. Страны НАТО приняли решение организовать полномасштабное военное вторжение в Югославию, чтобы «принести ей демократию». Санкции ООН на это получено не было, но она и не потребовалась – измотанная борьбой с внутренними врагами ЮНА не выдержала нескольких месяцев бомбардировок, в ходе которых была уничтожена значительная часть военного и экономического потенциала Югославии. После авиационной последовала наземная операция, в результате которой территория страны была оккупирована и расчленена по административным границам (впрочем, Воеводину решили сохранить в составе Сербии, чтобы поддерживать её конфликт с Венгрией). Большая часть бывшего руководство к " + (this.global1.data[21] + 8).ToString() + " году было схвачено и предстало перед созданным в Гааге Международным трибуналом по бывшей Югославии. Через 10 лет после операции все постюгославские республики стали частью НАТО, а затем и ЕС.";
			}
			else
			{
				if (this.global1.data[14] > 0 && this.global1.data[14] < 3)
				{
					this.text_fake = "Ваше авторитарное и жестокое правление, наряду с активным вмешательством в международные события, привели к нешуточной истерии на Западе.";
				}
				else if (this.global1.data[14] < 1)
				{
					this.text_fake = "Ваше жестокое и кровавое правление, наряду с активным вмешательством в международные события, привели к нешуточной истерии на Западе.";
				}
				else if (this.global1.data[14] > 3 && this.global1.data[22] >= 700 && this.global1.data[31] >= 700)
				{
					this.text_fake = "Ваше жестокое и националистическое правление, наряду с активным вмешательством в международные события, привели к нешуточной истерии на Западе.";
				}
				else
				{
					this.text_fake = "Ваше независимое и суверенное правление и ваши попытки активно вмешиваться в международные события в попытке стать новой ведущей силой в мире привели к широкому недовольству на Западе.";
				}
				this.text_fake += " Американцы созвали срочное заседание Совбеза ООН, где объявили об ущемлении нацменьшинств в нашей стране, активном производстве химического оружия, активной разработке ядерного оружия и существовании авторитарного мафиозного правления с массовыми репрессиями неугодных.";
				if (this.global1.data[14] < 3 || (this.global1.data[14] > 4 && this.global1.data[22] >= 700 && this.global1.data[31] >= 700))
				{
					this.text_fake = string.Concat(new object[]
					{
						this.text_fake,
						"На данном заседании единогласно было принято решение о вводе бесполётной зоны и утверждении массовых санкций. Как следствие этого, профинансированная западными спецслужбами оппозиция начала вооруженное восстание в стране. К ней присоединились бомбардировщики и авиация НАТО. Правящий режим пал и страна вернулась на демократические позиции, к ",
						this.global1.data[21] + 8,
						" году выступив в НАТО."
					});
				}
				else if (this.global1.data[14] < 4)
				{
					this.text_fake = string.Concat(new object[]
					{
						this.text_fake,
						"На данном заседании лишь члены НАТО поддержали американские инициативы, а Китай и Россия воздержались от голосования, вследствие чего было принято решение о вводе бесполётной зоны и утверждении массовых санкций. Как следствие этого, профинансированная западными спецслужбами оппозиция начала вооруженное восстание в стране. К ней присоединились бомбардировщики и авиация НАТО. Правящий режим пал и страна вернулась на демократические позиции, к ",
						this.global1.data[21] + 8,
						" году выступив в НАТО."
					});
				}
				else
				{
					this.text_fake = string.Concat(new object[]
					{
						this.text_fake,
						"На данном заседании Китай и Россия резко выступили против американской инициативы, ведь даже члены НАТО, кроме Великобритании, воздержались от голосования, вследствие чего не было принято совместного решения о вводе бесполётной зоны и утверждении массовых санкций. Однако, американцы, несмотря на решение ООН, объявили о вводе бесполетной зоны, всевозможных санкциях и блокаде, а затем профинансированная западными спецслужбами оппозиция начала вооруженное восстание в стране. К ней присоединились бомбардировщики, морпехи и авиация США. Правящий режим пал и страна вернулась на демократические позиции, к ",
						this.global1.data[21] + 8,
						" году выступив в НАТО."
					});
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(10);
					}
				}
			}
			if (this.global1.allcountries[19].Help)
			{
				this.text_fake += "|Однако, высшие чины партаппарата сумели вовремя сбежать из страны по налаженным каналам и получить политическое убежище в Индии.";
				if (this.global1.allcountries[19].Gosstroy <= 1)
				{
					this.text_fake = this.text_fake + " И, несмотря на международное давление, благодарное нам за поддержку правительство ИНК никого не выдало, поселив 'беженцев' в казённых помещениях, где, впоследствии, " + this.global1.politics_name[this.global1.data[11]] + " написал мемуары и автобиографию, в которых объявил себя последним и упущенным шансом своей страны на спасение.";
				}
				else
				{
					this.text_fake += " Впрочем, под международным давлением, новое индийское правительство вынуждено было начать процесс экстрадиции прибывших партаппаратчиков, следствием чего вы все укрылись в аргентинском посольстве и по тайным каналам были вывезены в разные страны Латинской Америки, сменив паспортные данные. ";
				}
			}
			else
			{
				this.text_fake = string.Concat(new object[]
				{
					this.text_fake,
					"|",
					this.global1.politics_name[this.global1.data[11]],
					", при попытке бегства, был схвачен и изолирован в одиночной камере, а затем повешен народным трибуналом. Остальные были посажены в тюрьму на разные сроки, но к ",
					this.global1.data[21] + 5,
					" году получили амнистию по состоянию здоровья."
				});
			}
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 5)
		{
			this.Name.text = "ВТОРЖЕНИЕ СССР";
			if (this.global1.allcountries[7].Gosstroy == 0)
			{
				this.text_fake = "Ваше чересчур независимое и ревизионистское правление привело в ярость новых советских лидеров. А так как вы не смогли обеспечить ни должной поддержки народа, ни сильной укрепленной армии, ни внешней дипломатической защиты, то Советский Союз смог с радостью восстановить свой контроль над вашей территорией.|Вслед за этим СССР вернул контроль и над большей частью своей международной сферы. Под лидерством нового Президента СССР товарища Алкснис Советский Союз, руководимый смешанной экономикой, вновь стал мировой державой.";
			}
			else
			{
				this.text_fake = "Ваше чересчур независимое и ревизионистское правление привело в ярость новых советских лидеров. А так как вы не смогли обеспечить ни должной поддержки народа, ни сильной укрепленной армии, ни внешней дипломатической защиты, то Советский Союз смог с радостью восстановить свой контроль над вашей территорией.|Вслед за этим СССР вернул контроль и над большей частью своей международной сферы. Под лидерством нового Президента СССР товарища Пуго Советский Союз, руководимый смешанной экономикой, вновь стал мировой державой.|А через пару лет в совершенной секретности Горбачёв был отправлен на пенсию по состоянию здоровья и стал тихо жить под присмотром КГБ.";
			}
			this.text_fake = string.Concat(new string[]
			{
				this.text_fake,
				"|",
				this.global1.politics_name[this.global1.data[11]],
				" был исключен из правящей Партии с позором и отправлен в ссылку, а ",
				this.global1.party_name[0],
				" была переименована в Коммунистическую Партию."
			});
			if (this.global1.iron_and_blood)
			{
				this.achieves.GetComponent<achievements>().Set(11);
			}
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 6 && this.global1.data[0] != 12)
		{
			this.Name.text = "ПОСЛЕДНИЕ ВЫБОРЫ";
			this.text_fake = "Вы проиграли на выборах. А проигравшие никому не нужны!";
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 6)
		{
			this.Name.text = "ПОСЛЕДНИЕ ВЫБОРЫ";
			this.text_fake = "Несмотря на наши миротворческие цели, нам не удалось победить на первых свободных выборах, и в итоге, абсолютное большинство в парламенте заняли исламские фундаменталисты, которые после сформирования правительства отменили все декреты НДПА, предварительно запретив её и начав аресты её лидеров. В итоге, из-за реакционной политики нового руководства, в традиционно просоциалистических регионах начинаются волнения, скоротечно переходящие в погромы и кровопролитные восстания. Похоже, что новой гражданской войны не избежать.";
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 7)
		{
			this.Name.text = "ЗАКАТ ХОДЖАИЗМА";
			this.text_fake = "Албания преображается в теократию. Недовольных этими переменами не очень много, но права женщин уже сокращаются, паранджа стала обязательной к ношению, началось внедрение законов Шариата, а имамы получают все больше власти. Неджимие Ходжа, первый и единственный правитель-женщина, стала не более чем марионеткой духовенства по собственному желанию. ";
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 8)
		{
			this.Name.text = "ЗАКАТ СОЛНЦА ЧУЧХЕ";
			this.text_fake = "Из-за чрезмерной милитаризации и агрессивной внешней политики Северной Кореи, Соединенные штаты, при поддержке своих союзников, смогли протолкнуть в Совет безопасности ООН резолюцию о необходимости военного вмешательства в КНДР, чтобы пресечь враждебную политику севера и не допустить масштабного конфликта с Югом. И даже наш бывший союзник Китай не заступился за нас, нанеся нам очередной подлый удар в спину. После вторжения империалистов в КНДР и первых крупномасштабных поражений северокорейской армии, генералитет отказывается от применения ядерного оружие, и сговорившись с Соединёнными штатами, производит мятеж против лидера страны О Джин У, а затем выдаёт его военному контингенту ООН. Над генералиссимусом КНДР фактически разворачивается «новый Нюрнбергский процесс», в результате которого он, и несколько его подельников, был приговорены к смертной казни. После сокрушительного поражения КНДР начался процесс интеграции севера в Республику Корею, и теперь, после стольких жертв и потерь, корейский народ един и ему придётся пережить ещё очень много трудностей.";
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 9)
		{
			this.Name.text = "ТРЕТЬЯ КОРЕЙСКАЯ ВОЙНА";
			this.text_fake = string.Concat(new string[]
			{
				"В начале декабря 1991 в Северной Корее началась полная милитаризация. В полном секрете от внешнего мира и общественности к 38-й параллели перевозились дивизии и вооружение Корейской Народной Армии. 31 декабря,  в канун нового 1992 года, лидер КНДР ",
				this.global1.politics_name[this.global1.data[11]],
				" заявил, что «американская марионетка Южная Корея совершила ракетный удар по позициям Северной Кореи, тем самым нарушив демилитаризованную зону между двумя странами» . После этого, северокорейские войска под прикрытием артиллерии, атаковали позиции Южной Кореи, вскоре к ним присоединились и имеющиеся в резерве танковые дивизии. Эффект неожиданности и молниеносный блицкриг смог обеспечить КНДР успешное наступление в первые дни новой Корейской войны. Северокорейская пропаганда за это время уже начала во всю агитировать «За войну до победного конца» и «Освобождение Родины от колониального рабства США». Руководитель КНДР  ",
				this.global1.politics_name[this.global1.data[11]],
				" был приравнен к рангу великих корейские военачальников, встав в один ряд с Ли Сунсином и Чоном Бон Су. Тем не менее, корейское наступление быстро захлебнулось, а мобилизованные силы военной базы США в Корее с новой силой начали операцию по освобождению Юга. Возвеличенная официальной пропагандой «победоносная рабочая армия Кореи» развалилась под ударами американцев и не удержала фронт, после чего началось паническое бегство, война быстро перешла на территорию Севера. Вопреки ожиданиям руководства, КНР никак не заступилась за Север, и, вследствие этого, высшее командование ослушалось приказа действующего президента о нанесении ядерного удара по Южной Корее, приняв решение выдать Америке президента КНДР, в обмен на сохранение собственных шкур. Через несколько Пхеньян, практически без сопротивления, пал. Корея стала единой, а в Гааге собирается новый трибунал для вынесения приговора лидерам КНДР."
			});
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
			if (this.global1.iron_and_blood)
			{
				this.achieves.GetComponent<achievements>().Set(59);
			}
		}
		else if (this.global1.data[46] == 10)
		{
			if (this.global1.iron_and_blood)
			{
				this.achieves.GetComponent<achievements>().Set(64);
			}
			this.Name.text = "Исламское Государство\nАфганистан";
			this.text_fake = "|||После вывода советских войск положение Афганистана начало стремительно ухудшаться - непоследовательная политика НДПА вместе с разногласиями в ней и в армейском руководстве привели к тому, что народ стал отворачиваться от Афганского правительства, а армия с трудом сдерживала натиск террористов. Оказавшись в международной изоляции, Афганистан не мог получить поддержку извне, а Пакистан продолжал безнаказанно отправлять всё новые отряды исламистов. террористам удалось взять Кабул, провозгласив Афганистан исламским государством. Все завоевания советской власти в социальных, экономических и правовых областях оказались уничтожены. А через 4 года и сам " + this.global1.politics_name[this.global1.data[11]] + " был зверски убит без суда и следствия.";
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 11)
		{
			if (this.global1.iron_and_blood)
			{
				this.achieves.GetComponent<achievements>().Set(64);
			}
			this.Name.text = "Исламское Государство\nАфганистан";
			this.text_fake = "|||После вывода советских войск положение Афганистана начало стремительно ухудшаться - непоследовательная политика НДПА вместе с разногласиями в ней и в армейском руководстве привели к тому, что народ стал отворачиваться от Афганского правительства, а армия с трудом сдерживала натиск моджахедов. Оказавшись в международной изоляции, Афганистан не мог получить поддержку извне, а Пакистан продолжал безнаказанно отправлять всё новые отряды исламистов. Моджахедам удалось взять Кабул, провозгласив Афганистан исламским государством. Все завоевания советской власти в социальных, экономических и правовых областях оказались уничтожены. А через 4 года и сам " + this.global1.politics_name[this.global1.data[11]] + " был зверски убит без суда и следствия.";
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 12)
		{
			this.Name.text = "Венгерская Румыния";
			this.text_fake = this.dlce1.credits_text[29];
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 23)
		{
			this.Name.text = this.dlce1.credits_text[240];
			this.text_fake = this.dlce1.credits_text[202];
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 24)
		{
			this.Name.text = this.dlce1.credits_text[246];
			this.text_fake = this.dlce1.credits_text[247];
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 25)
		{
			this.Name.text = this.dlce1.credits_text[248];
			this.text_fake = this.dlce1.credits_text[249];
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 26)
		{
			this.Name.text = this.dlce1.credits_text[248];
			this.text_fake = this.dlce1.credits_text[250];
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 27)
		{
			this.Name.text = "Ops over";
			this.text_fake = "||11 января 1992 года в 11:30 утра. ЮНА получает анонимное сообщение о грядущем нападении террористов. К сожалению, югославская армия недооценила масштаб атаки. Так, во время торжественного открытия бюста Арсо Йовановича в Белграде – произошел мощный взрыв, за которым последовало нападение группы из около 50 боевиков «Народного движения Косова». Были потери. Результат: в ходе теракта погиб " + this.global1.politics_name[this.global1.data[11]] + " и почти всё руководство Югославии. Страна впала в тяжёлый политический кризис.";
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 28)
		{
			this.Name.text = this.dlce1.credits_text[263];
			this.text_fake = this.dlce1.credits_text[264];
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 29)
		{
			this.Name.text = this.dlce1.credits_text[272];
			this.text_fake = this.dlce1.credits_text[273];
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 30)
		{
			this.Name.text = this.dlce1.credits_text[312];
			this.text_fake = this.dlce1.credits_text[313];
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 31)
		{
			this.Name.text = this.dlce1.credits_text[319];
			this.text_fake = this.dlce1.credits_text[320];
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 32)
		{
			this.Name.text = "Отчет об исправлении \nНумера " + this.global1.Num1;
			this.text_fake = string.Concat(new string[]
			{
				"|||Сегодня в Департаменте по надзору за благонадежностью граждан Бюро Хранителей зарегистрирован очередной печальный случай.| Нумер ",
				this.global1.Num1,
				", накануне задержанный сотрудниками Бюро Хранителей по подозрению в неблагонадежности и антигосударственной деятельности, в ходе допроса и последующей проверки продемонстрировал серьёзные отклонения от норм поведения и мышления, предписанных Кодексом Строителей Единого Государства.| В частности, ",
				this.global1.Num1,
				" неоднократно высказывал абсурдные сомнения в реальности окружающего мира и демонстрировал прогрессирующие стремления к серьёзным проявлениям аутоагрессии. Несмотря на все усилия сотрудников Бюро Хранителей по проведению интенсивных терапевтических процедур и коррекции мировоззрения ",
				this.global1.Num1,
				", ему так и не удалось преодолеть глубоко укоренившиеся иррациональные побуждения.| В результате, для облегчения тяжёлого положения больного, в соответствии с предписаниями распоряжения Благодетеля, ",
				this.global1.Num1,
				"  был подвергнут Великой Операции, прошедшей успешно.| На следующий день нумер был выписан из-под наблюдения врачей и спустя непродолжительное время вернулся к исполнению своих обязанностей."
			});
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 33)
		{
			this.Name.text = "Неудачное знакомство";
			this.text_fake = string.Concat(new string[]
			{
				this.global1.Num1,
				" решил не поддаваться старорежимному порыву, который бил тревогу от сложившейся ситуации, и стал вести себя строго по инструкции, которая гласила, что каждый нумер друг другу верный товарищ. Подходя к ним, бригадир заметил, что это были мешковатый в форме не по размеру T-351, вытянутый и нарочито накрахмаленный B-404 и миловидная A-270. Последняя стала активно махать ",
				this.global1.Num1,
				". «Какие приветливые нумеры» - подумал бригадир и помахал в ответ. В этот момент раздался небольшой хлопок и только в этот момент ",
				this.global1.Num1,
				" понял, что лица их были наполнены страхом, а сейчас ещё и ужасом. «Улыбки идут им куда больше…» - подумал бригадир перед тем, как его взор стала застилать тьма. Лишь мерный стук молотков отзывался в его голове, с которым продолжало жить Единое государство."
			});
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 34)
		{
			this.Name.text = "Неожиданная атака";
			this.text_fake = string.Concat(new string[]
			{
				"После того, как ",
				this.global1.Num1,
				" вышел из укрытия и открыл рот для представления нумерам, A-270 выхватила из кармана короткий продолговатый предмет, и в этот момент раздался небольшой хлопок. Что-то поразило бригадира насквозь, после чего между заметно перепугавшейся группой началась словесная перепалка, окончание которой ",
				this.global1.Num1,
				" так и не услышал. Последнее, что отпечаталось в его голове – мерный стук молотков, символизировавших сердцебиение Единого государства."
			});
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 35)
		{
			this.Name.text = "Угроза по ту сторону зеркала";
			this.text_fake = "Вернувшись к осмотру тела, " + this.global1.Num1 + " решил продолжить обследование карманов униформы O-213. Передние карманы оказались пусты, но в одним из нижних карманов явно находился некоторый круглый предмет. Достав его на поверхность, нумер обнаружил белое карманное зеркальце. Открыв его, на бригадира уставилась его ухоженная физиономия. Не успев насладиться своим портретом, в зеркале появился блик, после чего тело нумера упало на уже охладевший труп O-213.";
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 36)
		{
			this.Name.text = "Удар в спину";
			this.text_fake = string.Concat(new string[]
			{
				"Преодолевая желание бежать с места преступления, ",
				this.global1.Num1,
				" решительно направился к источнику странного шума за дальними станками.|Пробираясь вдоль ряда рабочих мест, он пытался вслушиваться в тишину, пытаясь понять её источник. Всё было тихо. Наконец, ",
				this.global1.Num1,
				" достиг места, откуда, как ему казалось, доносился звук. «Наверное, показалось» - подумал бригадир. |После того, как он повернулся спиной к станку, что-то кольнуло его в спину. Вдруг в этот момент по спине прошла острая обжигающая боль, из-за которой ",
				this.global1.Num1,
				" упал на колени, а через минуту уже лежал без чувств. Последнее, что он слышал, таинственную ухмылку проходящего мимо нумера. «Помо-оги-т…» - хрипом вырвалось из уст бригадира, после чего он замолчал."
			});
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 37)
		{
			this.Name.text = "Нумерское покаяние";
			this.text_fake = "После признания вины Хранитель перестал слушать нумера. За бывшие заслуги в работе " + this.global1.Num1 + " был подвергнут Великой Операции по итогам которой вернулся в общество исправленным индивидом, что не будет ставить общественное ниже своих сиюминутных мыслей. Жизнь Единого государства продолжила свой черёд, и лишь ветер дальних берегов мог потревожить алгебраически выстроенную жизнь по Тейлору.";
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 38)
		{
			this.Name.text = "Успешное перевоспитание";
			this.text_fake = "Хранитель сообщил, что именно из-за того, что нумер стал ставить своё мнение выше вверенных ему инструкций, ему следует пройти определённую процедуру, которая излечит его от этого порока. По итогам Великой Операции " + this.global1.Num1 + " вернулся в общество исправленным индивидом, что не будет ставить общественное ниже своих сиюминутных мыслей. Жизнь Единого государства продолжила свой черёд, и лишь ветер дальних берегов мог потревожить алгебраически выстроенную жизнь по Тейлору.";
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 39)
		{
			this.Name.text = "Успешное перевоспитание";
			this.text_fake = "Хранитель сообщил, что благодаря этому нумер сможет отделаться за свои действия Великой Операцией, которая позволит ему и дальше служить Единому Государству. По её итогам " + this.global1.Num1 + " вернулся в общество исправленным индивидом, что не будет ставить общественное выше своих сиюминутных мыслей. Жизнь Единого государства продолжила свой черёд, и лишь ветер дальних берегов мог потревожить алгебраически выстроенную жизнь по Тейлору.";
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 40)
		{
			this.Name.text = "Успешное перевоспитание";
			this.text_fake = "Хранитель лишь отмахнулся от предложения очередного нумера в оказании помощи, заявив, что подобный испорченный нумер не может оказать какую-либо помощь в расследовании, которая не нарушала бы созданные для этого инструкции. За бывшие заслуги в работе " + this.global1.Num1 + " был подвергнут Великой Операции по итогам которой вернулся в общество исправленным индивидом, что не будет ставить общественное ниже своих сиюминутных мыслей. Жизнь Единого государства продолжила свой черёд, и лишь ветер дальних берегов мог потревожить алгебраически выстроенную жизнь по Тейлору.";
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 41)
		{
			this.Name.text = "Тихий хлопок";
			this.text_fake = string.Concat(new string[]
			{
				"После долгих внутренних метаний, ",
				this.global1.Num1,
				" решил, что дальнейшее проведение расследования будет слишком опасным и может поставить под угрозу его существование. Да и какая вероятность того, что он правильно истолковал послание и там действительно что-то будет? Обращаться в Бюро Хранителей также не было смысла, т.к. никто ему не поверит, а угроза вполне может оказаться надуманной. |На следующий день он как ни в чём ни бывало вернулся к работе и держался всех инструкций, что ему высылали свыше. Вероятно, они были высчитаны с поистине алгебраической точностью, так как в течение месяцев не было каких-либо подозрительных происшествий. Каждый день нумер ",
				this.global1.Num1,
				" приходил на работу, выполнял её и возвращался домой. Никакой запах гари не мог ему в этом помешать. Запах? Чт…"
			});
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 42)
		{
			this.Name.text = "Переезд на новую должность";
			this.text_fake = "Заступая на новую должность, " + this.global1.Num1 + " полностью погрузился в работу и тщательно подходил к выполнению своих обязанностей как перед начальством, так и перед своими подчинёнными. Скоро его действия окупились, и через год он пошёл на повышение, что наложило на него новые заботы и обязанности. |В это же время череда странных смертей и исчезновений нумеров на факториуме HRT-39829 продолжалась ещё несколько месяцев, после чего остановилась также внезапно, как и началась. Скорее всего, доблестные хранители смогли в очередной раз защитить Единое государство от посягательств врагов. |Жизнь продолжается и мерный звук станков и гул труб символизируют пульс гигантской машины, именуемой обществом нумеров.";
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 43)
		{
			this.Name.text = "Засекреченная смерть";
			this.text_fake = string.Concat(new string[]
			{
				"На следующее утро он привычным образом отправился на работу в факториум, однако до него ",
				this.global1.Num1,
				" так и не дошёл. На полпути он упал без чувств к всеобщему удивлению других нумеров, что считали всегда его физически развитым гражданином, не жалующимся на проблемы со здоровьем. Последующий осмотр тела покажет лишь небольшой след от укола на руке. В последствии дела смертей нумеров T-351, A-270, O-213, ",
				this.global1.Num1,
				" оказались засекречены и скрыты от их коллег по факториуму."
			});
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 44)
		{
			this.Name.text = "Кто такой " + this.global1.Num1 + "?";
			this.text_fake = string.Concat(new string[]
			{
				"После долгих внутренних метаний, ",
				this.global1.Num1,
				" решил, что в одиночку он явно не сможет ничего сделать, а подобные опасные мероприятия следует поручить соответствующим органам, которые должны ими заниматься, а именно Бюро Хранителей. На следующий день он незаметно оставил небольшую записку у одного из филиалов Бюро, после чего принялся ждать. |На этом записи о дальнейшем существовании нумера ",
				this.global1.Num1,
				", прерываются. Никто больше его не видел, никто про него не знал, и лишь монотонный звук молотков верного нумеру станка мерно отмерял пульс Единого государства. "
			});
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 45)
		{
			this.Name.text = "Герой Единого Государства";
			this.text_fake = "Хранитель понимающе кивнул головой и сообщил, что из-за разглашения конфиденциальной информации и необходимости личного участия бригадира в операции его отказ не принимается. Для придания уверенности нумер был подвергнут Великой Операции, которая позволила забыть ему о различных личных страхах и опасениях. В назначенный день " + this.global1.Num1 + " повёл себя как герой и запомнился всем своим подчинённым как истинный тейлорист. На этом его история обрывается, но не кончается жизнь Единого государства, пережившего очередное покушение в свой адрес. Лишь математически выверенный расчёт в очередной раз показал превосходство современного нумера над предательством.";
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 46)
		{
			this.Name.text = "Утративший работоспособность";
			this.text_fake = "После того, как бригадир " + this.global1.Num1 + " отдал инструкции своим подчинённым и скрылся на нижних этажах факториума, никто больше его не видел. Спустя несколько дней, после тщательных поисков Бюро Хранителей он был признан окончательно утратившим трудоспособность, а его должность была занята одним из его заместителей. Тем самым он лишь продолжил цепочку непонятных исчезновений и убийств, что поразили факториум HRT-39829.";
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 47)
		{
			this.Name.text = "Смерть при исполнении";
			this.text_fake = string.Concat(new string[]
			{
				"Подул сильный ветер, заставивший ",
				this.global1.Num1,
				" сделать шаг в сторону. Продолжая махать рукой, он вдруг понял, что силы начали его покидать. Уже через несколько секунд он падал вперёд лицом, недоумевая о том, что происходит. Нумер попытался было задержаться на ногах, но тело, верой и правдой сложившее ему долгие года, предательски подвело. Он успел лишь обернуться, как стремительно рухнул вперед, не в силах понять, что происходит. Картинка перед глазами стала мутнеть. Появившиеся крики незнакомых нумеров и звук какой-то возни за спиной нарушал мерный стук долота, который эхом отдавался в ушах ",
				this.global1.Num1,
				", символизируя вечную работу сердца Единого государства. «Надеюсь, что мои нумеры будут в большей безопасности, чем я» - с такими мыслями цикл бригадира факториума HRT-39829 ",
				this.global1.Num1,
				" ушёл на перезагрузку."
			});
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 48)
		{
			this.Name.text = "Заговор ценою в жизнь";
			this.text_fake = string.Concat(new string[]
			{
				"Когда фигуры направились к нему, ",
				this.global1.Num1,
				" запаниковал и не мог решить, что ему делать – оказывать сопротивление, сдаваться, бежать, в результате чего несколько крепких рук сразу же схватили его, не давая ни шанса на побег.|В комнату ворвались еще несколько человек, одетых так же странно, как и первые. ",
				this.global1.Num1,
				" видел, как они что-то быстро обсуждали, бросая на него гневные взгляды.|Внезапно над головой ",
				this.global1.Num1,
				" что-то загрохотало, и помещение наполнилось едким дымом. Кто-то из нападавших что-то крикнул, и в ответ в воздухе прозвучал странный скрежет и на том месте, где до этого стоял бригадир, полыхнуло пламя. |Дым, смешанный с яркими вспышками огня, мгновенно заволок все вокруг. ",
				this.global1.Num1,
				" быстро потерял сознание, задыхаясь от едкого удушливого воздуха. Его крепко держали, не позволяя вырваться.|Сквозь пелену дыма ",
				this.global1.Num1,
				" разглядел, что между фигурами возникла потасовка, итоги которой для бригадира остались неизвестны, из-за постепенной потери сознания. Закрыв глаза, ",
				this.global1.Num1,
				" ждал неизбежного. Языки пламени все ближе подбирались к нему, обжигая кожу. Но даже в этот страшный момент он не сожалел о своем решении войти в эту дверь. По крайней мере, он знал, что смог помешать чему-то более страшному, что готовили тени Единому государству."
			});
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 49)
		{
			this.Name.text = "Утилизация Нумера " + this.global1.Num1;
			this.text_fake = string.Concat(new string[]
			{
				"|||Сегодня в Департаменте по надзору за благонадежностью граждан Бюро Хранителей зарегистрирован очередной печальный случай.| Нумер ",
				this.global1.Num1,
				", в нарушение инструкций занимался попеременным нажатием кнопок на клавиатуре терминала с бесцельным видом, наблюдая, как меняются иконки департаментов и отделов на экране. При попытках отвлечения нумера от данного времяпрепровождения, он вцепился в инженерный блок и продолжил нажимать на кнопки. После введения транквилизатора и доставки нумера ",
				this.global1.Num1,
				" в Медицинское бюро на обследование, он продолжил повторять несвязные фразы про «влияние модификаторов», «поддержку партии», «смену министерств». В сознание не приходил.| Из-за секретности озвучиваемых старорежимных терминов, было принято решение подвергнуть мозг нумера ",
				this.global1.Num1,
				" более тщательному изучению для сканирования изрекаемой информации. Остаточное тело прошло процедуру переработки и разборки в соответствии с инструкцией SD-90456."
			});
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 50)
		{
			this.Name.text = this.dlce1.credits_text[240];
			this.text_fake = this.dlce1.credits_text[339];
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 51)
		{
			this.Name.text = this.dlce1.credits_text[56];
			this.text_fake = this.dlce1.credits_text[344];
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 52)
		{
			this.Name.text = this.dlce1.credits_text[51];
			this.text_fake = this.dlce1.credits_text[348];
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] >= 13 && this.global1.data[46] <= 22)
		{
			this.Name.text = this.dlce1.credits_text[51 + this.global1.data[46] - 13];
			this.text_fake = this.dlce1.credits_text[61 + this.global1.data[46] - 13];
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == -1)
		{
			this.Name.text = this.dlce1.credits_text[114];
			this.text_fake = this.dlce1.credits_text[112];
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == -2)
		{
			this.Name.text = this.dlce1.credits_text[115];
			this.text_fake = this.dlce1.credits_text[113];
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
			GameObject.Find("Back").GetComponent<SpriteRenderer>().sprite = this.winfon;
			GameObject.Find("plane").GetComponent<SpriteRenderer>().sprite = this.winplan;
		}
		else if (this.global1.data[46] == -10)
		{
			this.Name.text = this.dlce1.credits_text[228];
			this.text_fake = this.dlce1.credits_text[237];
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] <= -3 && this.global1.data[46] >= -6)
		{
			this.Name.text = this.dlce1.credits_text[119 - this.global1.data[46] - 3];
			this.text_fake = this.dlce1.credits_text[123 - this.global1.data[46] - 3];
			global::UnityEngine.Object.Destroy(this.button_l);
			global::UnityEngine.Object.Destroy(this.button_r);
		}
		else if (this.global1.data[46] == 0)
		{
			if (this.global1.data[128] == 2)
			{
				this.yug1.gameState.yugregions[1].owner = 1;
			}
			if (this.global1.data[136] == 1 && this.global1.data[137] == 1)
			{
				this.yug1.gameState.yugregions[3].owner = 3;
			}
			this.ThisEndingWindow(null, 0);
		}
		this.text.text = this.Text(this.text_fake, 72);
	}

	// Token: 0x06000194 RID: 404
	public void ChangeOkno()
	{
		if (this.global1.data[46] == 0)
		{
			int num = 0;
			List<int> list = new List<int>();
			for (int i = 1; i < 7; i++)
			{
				if (this.global1.allcountries[i].paths > 1)
				{
					num++;
					list.Add(i);
				}
			}
			if (this.global1.data[0] == 1 && this.global1.data[242] == 2)
			{
				if ((this.this_okno > 18 + num && this.global1.data[21] <= 1991) || (this.this_okno > 18 + num && this.global1.data[19] <= 1 && this.global1.data[20] <= 1 && this.global1.data[21] >= 1991) || (this.this_okno > 19 + num && this.global1.data[21] >= 1992))
				{
					this.this_okno = 0;
					this.this_vrem = 0;
				}
				else if ((this.this_okno < 0 && this.global1.data[21] <= 1991) || (this.this_okno < 0 && this.global1.data[19] <= 1 && this.global1.data[20] <= 1 && this.global1.data[21] >= 1991))
				{
					this.this_okno = 18 + num;
					if (num == 0)
					{
						this.this_okno = 18;
					}
				}
				else if (this.this_okno < 0 && ((this.global1.data[19] > 1 && this.global1.data[20] > 1 && this.global1.data[21] >= 1992) || this.global1.data[21] >= 1993))
				{
					this.this_okno = 19 + num;
					if (num == 0)
					{
						this.this_okno = 19;
					}
				}
				this.ThisEndingWindow(list, num);
				return;
			}
			if ((this.this_okno > 16 + num && this.global1.data[21] <= 1991) || (this.this_okno > 16 + num && this.global1.data[19] <= 1 && this.global1.data[20] <= 1 && this.global1.data[21] >= 1991) || (this.this_okno > 17 + num && this.global1.data[21] >= 1992))
			{
				this.this_okno = 0;
				this.this_vrem = 0;
			}
			else if ((this.this_okno < 0 && this.global1.data[21] <= 1991) || (this.this_okno < 0 && this.global1.data[19] <= 1 && this.global1.data[20] <= 1 && this.global1.data[21] >= 1991))
			{
				this.this_okno = 16 + num;
				if (num == 0)
				{
					this.this_okno = 16;
				}
			}
			else if (this.this_okno < 0 && ((this.global1.data[19] > 1 && this.global1.data[20] > 1 && this.global1.data[21] >= 1992) || this.global1.data[21] >= 1993))
			{
				this.this_okno = 17 + num;
				if (num == 0)
				{
					this.this_okno = 17;
				}
			}
			this.ThisEndingWindow(list, num);
		}
	}

	// Token: 0x06000195 RID: 405
	private void YugoAchievement()
	{
		if (this.global1.iron_and_blood)
		{
			if (((this.global1.data[118] == 1 && this.global1.data[116] == 2 && this.global1.data[0] == 51) || (this.global1.data[136] == 1 && this.global1.data[137] == 1 && this.global1.data[0] == 50) || (this.global1.data[148] == 1 && this.global1.data[0] == 49 && this.global1.data[150] == 0)) && (this.global1.allcountries[49].Gosstroy == 0 || this.global1.allcountries[15].Gosstroy == 0 || this.global1.allcountries[51].Gosstroy == 0 || this.global1.allcountries[50].Gosstroy == 0))
			{
				this.achieves.GetComponent<achievements>().Set(114);
			}
			if (this.global1.data[46] == 22)
			{
				this.achieves.GetComponent<achievements>().Set(115);
			}
			if (this.yug1.gameState.modifies[10] == 1 && this.yug1.gameState.modifies[9] == 1)
			{
				this.achieves.GetComponent<achievements>().Set(116);
			}
			if (((this.global1.data[118] == 0 && this.global1.data[0] == 51 && (this.global1.allcountries[51].Gosstroy == 2 || this.global1.allcountries[15].Gosstroy == 2)) || (this.global1.data[136] == 0 && this.global1.data[0] == 50 && (this.global1.allcountries[50].Gosstroy == 2 || this.global1.allcountries[15].Gosstroy == 2)) || (this.global1.data[148] != 1 && this.global1.data[0] == 49 && (this.global1.allcountries[49].Gosstroy == 2 || this.global1.allcountries[15].Gosstroy == 2))) && this.global1.allcountries[20].Gosstroy == 2 && this.global1.allcountries[4].Gosstroy == 2 && this.global1.allcountries[6].Gosstroy == 2 && this.global1.allcountries[5].Gosstroy == 2 && this.global1.allcountries[45].Gosstroy == 2 && this.global1.allcountries[20].Gosstroy == 2 && this.global1.allcountries[54].Gosstroy == 2 && ((this.global1.data[0] == 49 && this.global1.allcountries[49].Vyshi) || (this.global1.data[0] == 50 && this.global1.allcountries[50].Vyshi) || (this.global1.data[0] == 51 && this.global1.allcountries[51].Vyshi)))
			{
				this.achieves.GetComponent<achievements>().Set(119);
			}
			if (this.yug1.gameState.yugcountries[7].is_independent && this.yug1.gameState.yugregions[7].owner == 7 && this.global1.data[9] <= 300)
			{
				this.achieves.GetComponent<achievements>().Set(112);
			}
			else if (this.yug1.gameState.yugcountries[7].is_independent && this.yug1.gameState.yugregions[7].owner == 7 && this.global1.data[9] >= 301)
			{
				this.achieves.GetComponent<achievements>().Set(113);
			}
			if (!this.yug1.gameState.battle_royal && this.global1.data[0] == 49 && this.yug1.gameState.yugregions[0].owner == 8 && this.yug1.gameState.yugregions[1].owner == 8 && this.yug1.gameState.yugregions[2].owner == 8 && this.yug1.gameState.yugregions[3].owner == 8 && this.yug1.gameState.yugregions[4].owner == 8 && this.yug1.gameState.yugregions[5].owner == 8 && this.yug1.gameState.yugregions[6].owner == 8 && this.yug1.gameState.yugregions[7].owner == 8 && this.yug1.gameState.yugregions[8].owner == 8 && this.yug1.gameState.yugregions[9].owner == 8 && this.yug1.gameState.yugregions[10].owner == 8 && this.yug1.gameState.yugregions[11].owner == 8 && this.global1.data[162] != 3)
			{
				this.achieves.GetComponent<achievements>().Set(120);
			}
			if (this.yug1.gameState.yugregions[10].owner != 10 && (this.global1.eventVariantChosen[335] == 3 || this.global1.eventVariantChosen[399] == 0))
			{
				this.achieves.GetComponent<achievements>().Set(121);
			}
			if (this.global1.data[112] == 10)
			{
				this.achieves.GetComponent<achievements>().Set(122);
			}
			if (this.global1.data[177] == 3)
			{
				this.achieves.GetComponent<achievements>().Set(123);
			}
			if (this.yug1.gameState.yugcountries[10].is_exist)
			{
				if (this.global1.data[118] == 1 && this.global1.data[116] == 1 && this.global1.data[137] == 0 && this.global1.data[136] == 1 && this.global1.data[130] == 3 && this.global1.data[148] == 1 && this.global1.data[150] == 1 && this.global1.data[156] == 4 && this.global1.data[157] == 2 && (this.global1.data[176] == 2 || this.global1.data[176] == 7 || this.global1.data[176] == 8))
				{
					this.achieves.GetComponent<achievements>().Set(124);
				}
			}
			else if (this.global1.data[118] == 1 && this.global1.data[116] == 1 && this.global1.data[137] == 0 && this.global1.data[136] == 1 && this.global1.data[130] == 3 && this.global1.data[148] == 1 && this.global1.data[150] == 1 && this.global1.data[156] == 4 && this.global1.data[157] == 2)
			{
				this.achieves.GetComponent<achievements>().Set(124);
			}
			if (this.global1.event_done[395])
			{
				this.achieves.GetComponent<achievements>().Set(125);
			}
			if (this.global1.data[168] == 2)
			{
				this.achieves.GetComponent<achievements>().Set(126);
			}
			if (this.global1.data[46] == 21)
			{
				this.achieves.GetComponent<achievements>().Set(127);
			}
			if (this.global1.data[176] == 9 && this.global1.data[148] == 2 && this.yug1.gameState.yugregions[10].owner == 10)
			{
				this.achieves.GetComponent<achievements>().Set(130);
			}
			bool flag = true;
			for (int i = 0; i < this.global1.regions.Length; i++)
			{
				for (int j = 0; j < 15; j++)
				{
					if (this.global1.regions[i].buildings[j].type >= 25 && this.global1.regions[i].buildings[j].type <= 36 && this.global1.regions[i].buildings[j].is_builded)
					{
						flag = false;
						break;
					}
				}
			}
			if (flag)
			{
				this.achieves.GetComponent<achievements>().Set(118);
			}
			flag = true;
			for (int k = 0; k < this.yug1.gameState.yugregions.Length; k++)
			{
				if (this.yug1.gameState.yugregions[k].owner == this.yug1.gameState.player && k != 8)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				this.achieves.GetComponent<achievements>().Set(128);
			}
		}
	}

	// Token: 0x06000196 RID: 406
	private void YugoEndings()
	{
		if (!this.yug1.gameState.battle_royal)
		{
			this.YugoAchievement();
			int num = 0;
			foreach (YugoRegion yugoRegion in this.yug1.gameState.yugregions)
			{
				if (yugoRegion.owner == this.yug1.gameState.player || this.yug1.gameState.yugcountries[yugoRegion.owner].is_ally || this.yug1.gameState.yugcountries[yugoRegion.owner].peace_with[this.yug1.gameState.player])
				{
					num++;
				}
			}
			bool flag = false;
			if (this.global1.data[114] == 100 && this.global1.data[162] == 3 && this.global1.data[131] != 1)
			{
				if (num >= this.yug1.gameState.yugregions.Length - 1)
				{
					if (this.global1.data[0] == 49)
					{
						if (this.global1.data[14] == 1 || this.global1.data[14] == 2 || this.global1.data[16] <= 11)
						{
							this.Name.text = this.dlce1.credits_text[133];
							this.text_fake = this.dlce1.credits_text[134];
							if (this.global1.iron_and_blood)
							{
								this.achieves.GetComponent<achievements>().Set(89);
							}
						}
						else
						{
							this.Name.text = this.dlce1.credits_text[127];
							this.text_fake = this.dlce1.credits_text[130];
							if (this.global1.iron_and_blood)
							{
								this.achieves.GetComponent<achievements>().Set(86);
							}
						}
					}
					else if (this.global1.data[0] == 50)
					{
						if (this.global1.data[14] == 1 || this.global1.data[14] == 2 || this.global1.data[16] <= 11)
						{
							this.Name.text = this.dlce1.credits_text[133];
							this.text_fake = this.dlce1.credits_text[134];
							if (this.global1.iron_and_blood)
							{
								this.achieves.GetComponent<achievements>().Set(89);
							}
						}
						else if (this.global1.allcountries[50].isSEV && this.global1.allcountries[8].isSEV && !this.global1.allcountries[7].isSEV)
						{
							this.Name.text = this.dlce1.credits_text[129];
							this.text_fake = this.dlce1.credits_text[254];
							if (this.global1.iron_and_blood)
							{
								this.achieves.GetComponent<achievements>().Set(88);
							}
						}
						else
						{
							this.Name.text = this.dlce1.credits_text[129];
							this.text_fake = this.dlce1.credits_text[132];
							if (this.global1.iron_and_blood)
							{
								this.achieves.GetComponent<achievements>().Set(88);
							}
						}
					}
					else if (this.global1.data[14] == 1 || this.global1.data[14] == 2 || this.global1.data[16] <= 11)
					{
						this.Name.text = this.dlce1.credits_text[133];
						this.text_fake = this.dlce1.credits_text[134];
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(89);
						}
					}
					else
					{
						this.Name.text = this.dlce1.credits_text[128];
						this.text_fake = this.dlce1.credits_text[131];
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(87);
						}
					}
					if (this.this_okno == 2)
					{
						this.this_okno = 0;
						this.this_vrem = 0;
						return;
					}
					if (this.this_okno == 0)
					{
						this.this_okno = 2;
						this.this_vrem = 9;
						return;
					}
				}
				else
				{
					this.Name.text = this.dlce1.credits_text[135];
					if (this.global1.data[0] == 49)
					{
						this.text_fake = this.dlce1.credits_text[136];
					}
					else if (this.global1.data[0] == 50)
					{
						this.text_fake = this.dlce1.credits_text[138];
					}
					else
					{
						this.text_fake = this.dlce1.credits_text[137];
					}
					if (this.this_okno == 2)
					{
						this.this_okno = 0;
						this.this_vrem = 0;
						return;
					}
					if (this.this_okno == 0)
					{
						this.this_okno = 2;
						this.this_vrem = 9;
						return;
					}
				}
			}
			else
			{
				this.Name.text = this.dlce1.credits_text[71 + this.this_vrem];
				if (this.global1.iron_and_blood)
				{
					if (this.global1.data[138] == 0 && this.global1.data[136] == 0 && this.global1.data[118] == 0 && this.global1.data[117] == 0 && this.global1.data[157] == 0 && this.global1.data[148] == 0)
					{
						this.achieves.GetComponent<achievements>().Set(100);
					}
					if (this.yug1.gameState.modifies[2] > 1)
					{
						this.achieves.GetComponent<achievements>().Set(103);
					}
					if (this.global1.data[160] == 1 && this.global1.data[15] == 7 && this.global1.data[16] == 12 && this.global1.data[17] == 16 && this.global1.data[18] == 21)
					{
						this.achieves.GetComponent<achievements>().Set(104);
					}
				}
				if (this.this_vrem == 0)
				{
					if (this.yug1.gameState.modifies[5] == 0 && this.global1.data[10] <= 400 && this.global1.data[158] != 2 && this.global1.data[157] == 1 && this.global1.data[121] == 0 && this.global1.data[164] == 8)
					{
						this.text_fake = this.dlce1.credits_text[189];
						return;
					}
					if (this.global1.data[118] == 1 && this.global1.data[116] == 1 && this.global1.data[137] == 0 && this.global1.data[136] == 1 && this.global1.data[130] == 3 && this.global1.data[148] == 1 && this.global1.data[150] == 1 && this.global1.data[156] == 4 && this.global1.data[157] == 2)
					{
						this.text_fake = this.dlce1.credits_text[315];
						return;
					}
					if (this.global1.data[234] == 1)
					{
						this.text_fake = this.dlce1.credits_text[345];
						return;
					}
					if (this.global1.data[168] >= 1)
					{
						this.text_fake = this.dlce1.credits_text[315];
						return;
					}
					if (this.global1.data[157] == 2 && this.global1.data[131] >= 1 && !this.yug1.gameState.yugcountries[0].is_independent)
					{
						this.text_fake = this.dlce1.credits_text[316];
						return;
					}
					if (this.global1.data[209] == 1)
					{
						this.text_fake = this.dlce1.credits_text[251];
						return;
					}
					if (this.global1.data[170] == 1)
					{
						this.text_fake = this.dlce1.credits_text[205];
						return;
					}
					if (this.global1.data[157] == 1 && this.global1.data[223] == 1 && this.yug1.gameState.modifies[4] == 0)
					{
						this.text_fake = this.dlce1.credits_text[335];
						return;
					}
					if (this.global1.data[157] == 1 && this.global1.data[223] == 1)
					{
						this.text_fake = this.dlce1.credits_text[336];
						if (this.global1.data[121] == 0)
						{
							if (PlayerPrefs.GetInt("language") == 0)
							{
								this.text_fake += "He was replaced by Janez Drnovšek, who stated that he would definitely be able to reach an agreement with Belgrade.";
								return;
							}
							this.text_fake += "Ему на смену пришёл Янез Дрновшек, с заявлениями, что ему точно удастся договориться с Белградом.";
							return;
						}
						else
						{
							if (PlayerPrefs.GetInt("language") == 0)
							{
								this.text_fake += "He was replaced by Janez Drnovšek, who spoke of the need to continue the policy of fighting with Belgrade for greater concessions.";
								return;
							}
							this.text_fake += "Ему на смену пришёл Янез Дрновшек, с заявлениями о необходимости дальнейшей политики сражения с Белградом за получение больших уступок.";
							return;
						}
					}
					else
					{
						if (this.global1.data[157] == 1 && this.global1.data[121] == 0)
						{
							this.text_fake = this.dlce1.credits_text[190];
							return;
						}
						if (this.yug1.gameState.yugregions[0].owner == this.yug1.gameState.player)
						{
							this.text_fake = this.dlce1.credits_text[146];
							return;
						}
						this.text_fake = this.dlce1.credits_text[79 + this.global1.data[157]];
						return;
					}
				}
				else if (this.this_vrem == 1)
				{
					if (((!this.yug1.gameState.yugcountries[1].is_independent && !this.yug1.gameState.yugcountries[1].is_exist) || this.yug1.gameState.yugregions[1].owner == this.yug1.gameState.player) && this.yug1.gameState.player != 1)
					{
						this.text_fake = this.dlce1.credits_text[147];
						return;
					}
					if (this.global1.data[131] >= 1 && this.global1.data[118] == 1 && !this.yug1.gameState.yugcountries[1].is_independent && this.global1.data[199] == 2)
					{
						this.text_fake = this.dlce1.credits_text[318];
						return;
					}
					if (this.global1.data[131] >= 1 && this.global1.data[118] == 1 && !this.yug1.gameState.yugcountries[1].is_independent)
					{
						this.text_fake = this.dlce1.credits_text[317];
						return;
					}
					if (this.global1.data[195] == 1 && this.global1.data[18] >= 21)
					{
						this.text_fake = this.dlce1.credits_text[252];
						return;
					}
					if (this.global1.data[195] == 1)
					{
						this.text_fake = this.dlce1.credits_text[253];
						return;
					}
					if (this.global1.data[169] == 1)
					{
						this.text_fake = this.dlce1.credits_text[206];
						return;
					}
					if (!this.yug1.gameState.yugcountries[1].is_independent && !this.global1.event_done[277] && this.global1.data[118] == 1 && this.global1.data[116] == 1)
					{
						this.text_fake = this.dlce1.credits_text[201];
						return;
					}
					if (this.global1.data[3] + this.global1.data[9] < 550 && this.global1.data[166] == 3)
					{
						this.text_fake = this.dlce1.credits_text[176];
						return;
					}
					if (this.yug1.gameState.modifies[2] == 4 && this.yug1.gameState.modifies[4] == 1)
					{
						this.text_fake = this.dlce1.credits_text[170];
						return;
					}
					if (this.yug1.gameState.modifies[2] == 4 && this.yug1.gameState.modifies[4] == 0 && this.yug1.gameState.modifies[5] == 0)
					{
						this.text_fake = this.dlce1.credits_text[171];
						return;
					}
					if (this.yug1.gameState.modifies[2] == 4 && this.global1.data[166] == 1)
					{
						this.text_fake = this.dlce1.credits_text[172];
						return;
					}
					if (this.global1.data[166] == 2)
					{
						this.text_fake = this.dlce1.credits_text[173];
						return;
					}
					if (this.yug1.gameState.modifies[16] == 1)
					{
						this.text_fake = this.dlce1.credits_text[174];
						return;
					}
					this.text_fake = this.dlce1.credits_text[82 + this.global1.data[128]];
					if (this.yug1.gameState.yugcountries[2].is_exist)
					{
						this.text_fake += this.dlce1.credits_text[85];
						return;
					}
				}
				else if (this.this_vrem == 2)
				{
					if (this.global1.data[136] == 1 && this.global1.data[137] == 0 && (this.global1.data[115] >= 10 || this.global1.data[168] == 2) && !this.yug1.gameState.yugcountries[1].is_independent)
					{
						this.text_fake = this.dlce1.credits_text[188];
						return;
					}
					if (this.global1.data[131] >= 1 && this.global1.data[136] == 1 && this.global1.data[137] == 0 && !this.yug1.gameState.yugcountries[3].is_independent)
					{
						this.text_fake = this.dlce1.credits_text[188];
						return;
					}
					if (this.global1.data[131] >= 1 && this.global1.data[136] == 1 && this.global1.data[137] == 1 && !this.yug1.gameState.yugcountries[3].is_independent)
					{
						this.text_fake = this.dlce1.credits_text[327];
						return;
					}
					if (this.global1.data[172] == 1)
					{
						this.text_fake = this.dlce1.credits_text[207];
						return;
					}
					if (this.yug1.gameState.yugregions[3].owner == this.yug1.gameState.player && this.yug1.gameState.player != 3)
					{
						this.text_fake = this.dlce1.credits_text[151];
						return;
					}
					this.text_fake = this.dlce1.credits_text[86 + this.global1.data[158]];
					if (this.yug1.gameState.yugcountries[4].is_exist)
					{
						this.text_fake += this.dlce1.credits_text[89];
					}
					if (this.yug1.gameState.yugcountries[5].is_exist)
					{
						this.text_fake += this.dlce1.credits_text[90];
					}
					if (this.global1.data[46] == 23)
					{
						this.text_fake += this.dlce1.credits_text[202];
						return;
					}
				}
				else if (this.this_vrem == 3)
				{
					if (this.yug1.gameState.yugregions[8].owner == this.yug1.gameState.player && this.yug1.gameState.player != 8)
					{
						this.global1.data[148] = 0;
					}
					if (this.global1.data[148] == 2 && this.yug1.gameState.yugregions[2].owner == 8 && this.yug1.gameState.yugregions[6].owner == 8 && this.yug1.gameState.yugregions[8].owner == 8 && this.yug1.gameState.yugregions[9].owner == 8 && this.yug1.gameState.yugregions[10].owner == 8)
					{
						this.text_fake = this.dlce1.credits_text[355];
						return;
					}
					if (this.global1.data[179] == 0 && (this.global1.data[154] == 3 || this.global1.data[154] == 2) && this.global1.data[148] == 2 && this.global1.data[192] != 1)
					{
						this.text_fake = this.dlce1.credits_text[203];
						return;
					}
					if (this.global1.data[171] == 1)
					{
						this.text_fake = this.dlce1.credits_text[208];
						return;
					}
					if (this.global1.data[179] >= 1 && (this.global1.data[154] == 3 || this.global1.data[154] == 2) && this.global1.data[148] == 2)
					{
						this.text_fake = this.dlce1.credits_text[204];
						return;
					}
					if (this.global1.data[154] == 2 && this.global1.data[148] == 1)
					{
						this.text_fake = this.dlce1.credits_text[93];
						return;
					}
					this.text_fake = this.dlce1.credits_text[92 + this.global1.data[148]];
					return;
				}
				else if (this.this_vrem == 4)
				{
					if (this.yug1.gameState.yugregions[7].owner == 1 && this.global1.data[0] == 51 && this.global1.data[118] == 1)
					{
						this.text_fake = this.dlce1.credits_text[308];
						return;
					}
					if (this.yug1.gameState.yugregions[7].owner == 3 && this.global1.data[0] == 50 && this.global1.data[136] == 1)
					{
						this.text_fake = this.dlce1.credits_text[310];
						return;
					}
					if ((this.yug1.gameState.yugregions[7].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[7].owner == 1 && this.global1.data[0] == 51))
					{
						this.text_fake = this.dlce1.credits_text[311];
						return;
					}
					if (this.yug1.gameState.yugregions[7].owner == 8 && this.global1.data[0] == 49)
					{
						this.text_fake = this.dlce1.credits_text[309];
						return;
					}
					if (this.yug1.gameState.yugcountries[7].is_independent && this.yug1.gameState.yugregions[7].owner == 7 && this.global1.data[9] >= 301)
					{
						this.text_fake = this.dlce1.credits_text[239];
						if (this.global1.data[112] == 6)
						{
							this.achieves.GetComponent<achievements>().Set(113);
							return;
						}
					}
					else if (this.yug1.gameState.yugcountries[7].is_independent && this.yug1.gameState.yugregions[7].owner == 7 && this.global1.data[9] <= 300)
					{
						this.text_fake = this.dlce1.credits_text[238];
						if (this.global1.data[112] == 6)
						{
							this.achieves.GetComponent<achievements>().Set(112);
							return;
						}
					}
					else
					{
						if (this.global1.data[156] == 3)
						{
							this.text_fake = this.dlce1.credits_text[181];
							return;
						}
						if (this.global1.data[156] == 4)
						{
							this.text_fake = this.dlce1.credits_text[242];
							return;
						}
						if (this.global1.data[156] == 2 && this.global1.data[192] == 1)
						{
							this.text_fake = this.dlce1.credits_text[353];
							return;
						}
						if (this.global1.data[156] == 1 && this.global1.data[192] == 1)
						{
							this.text_fake = this.dlce1.credits_text[354];
							return;
						}
						this.text_fake = this.dlce1.credits_text[96 + this.global1.data[156]];
						return;
					}
				}
				else if (this.this_vrem == 5)
				{
					if ((this.yug1.gameState.yugcountries[11].name == "Захвачено Болгарией" || this.yug1.gameState.yugcountries[11].name == " 被 保 加 利 亚 占 领") && this.yug1.gameState.yugcountries[11].is_independent && this.yug1.gameState.yugregions[11].owner != this.yug1.gameState.player && (this.global1.event_done[361] || (this.global1.event_done[313] && this.global1.allcountries[6].Gosstroy == 9)))
					{
						this.text_fake = this.dlce1.credits_text[150];
						return;
					}
					if (this.global1.event_done[361])
					{
						this.text_fake = this.dlce1.credits_text[149];
						return;
					}
					if (this.yug1.gameState.yugregions[11].owner == this.yug1.gameState.player)
					{
						this.text_fake = this.dlce1.credits_text[148];
						return;
					}
					if (this.global1.data[224] == 1 && this.global1.data[130] == 4)
					{
						this.text_fake = this.dlce1.credits_text[340];
						return;
					}
					if (this.global1.data[130] == 4)
					{
						this.text_fake = this.dlce1.credits_text[192];
						return;
					}
					if (this.global1.data[130] == 5)
					{
						this.text_fake = this.dlce1.credits_text[193];
						return;
					}
					if (this.global1.data[130] == 6 && this.global1.data[235] == 9)
					{
						this.text_fake = this.dlce1.credits_text[346];
						return;
					}
					if (this.global1.data[130] == 6 && this.yug1.gameState.modifies[5] == 1)
					{
						this.text_fake = this.dlce1.credits_text[194];
						return;
					}
					if (this.global1.data[130] == 6 && this.yug1.gameState.modifies[5] == 0)
					{
						this.text_fake = this.dlce1.credits_text[195];
						return;
					}
					if (this.global1.data[130] == 7)
					{
						this.text_fake = this.dlce1.credits_text[321];
						return;
					}
					if (this.yug1.gameState.yugcountries[11].is_independent)
					{
						this.text_fake = this.dlce1.credits_text[101];
						return;
					}
					if (this.yug1.gameState.yugregions[11].owner == 11 && this.global1.data[131] >= 1)
					{
						this.text_fake = this.dlce1.credits_text[322];
						return;
					}
					if (this.global1.data[130] == 3)
					{
						this.text_fake = this.dlce1.credits_text[338];
						return;
					}
					if (this.global1.data[130] == 1)
					{
						this.text_fake = this.dlce1.credits_text[337];
						return;
					}
					this.text_fake = this.dlce1.credits_text[99];
					return;
				}
				else if (this.this_vrem == 6 && this.yug1.gameState.yugcountries[10].is_exist)
				{
					this.Name.text = this.dlce1.credits_text[333];
					if (this.global1.data[177] == 2)
					{
						this.text_fake = this.dlce1.credits_text[218];
						return;
					}
					if (this.yug1.gameState.yugcountries[10].is_independent && this.yug1.gameState.yugregions[10].owner != 10)
					{
						this.text_fake = this.dlce1.credits_text[241];
						return;
					}
					if (this.global1.data[176] == 3)
					{
						this.text_fake = this.dlce1.credits_text[209];
						return;
					}
					if (this.global1.data[176] == 9 && this.global1.data[148] == 2)
					{
						this.text_fake = this.dlce1.credits_text[244];
						return;
					}
					if (this.global1.data[176] == 9)
					{
						this.text_fake = this.dlce1.credits_text[243];
						return;
					}
					if (this.global1.data[176] == 1)
					{
						this.text_fake = this.dlce1.credits_text[210];
						return;
					}
					if (this.global1.data[176] == 2 && !this.yug1.gameState.yugcountries[10].is_independent)
					{
						this.text_fake = this.dlce1.credits_text[211];
						return;
					}
					if (this.global1.data[176] == 2 && this.yug1.gameState.yugcountries[10].is_independent)
					{
						this.text_fake = this.dlce1.credits_text[212];
						return;
					}
					if ((this.global1.data[176] == 8 || this.global1.data[176] == 7) && this.global1.data[131] == 1)
					{
						this.text_fake = this.dlce1.credits_text[326];
						return;
					}
					if (this.global1.data[176] == 8)
					{
						this.text_fake = this.dlce1.credits_text[213];
						return;
					}
					if (this.global1.data[176] == 7)
					{
						this.text_fake = this.dlce1.credits_text[214];
						return;
					}
					if (this.global1.data[176] == 5)
					{
						this.text_fake = this.dlce1.credits_text[215];
						return;
					}
					if (this.global1.data[176] == 6 && (this.yug1.gameState.yugregions[1].owner == 10 || this.yug1.gameState.yugregions[3].owner == 10 || this.yug1.gameState.yugregions[8].owner == 10))
					{
						this.text_fake = this.dlce1.credits_text[216];
						return;
					}
					if (this.global1.data[176] == 6)
					{
						this.text_fake = this.dlce1.credits_text[271];
						return;
					}
					if (this.global1.data[176] == 4)
					{
						this.text_fake = this.dlce1.credits_text[217];
						return;
					}
					if (this.global1.data[155] == 3)
					{
						this.text_fake = this.dlce1.credits_text[95];
						return;
					}
					if (this.yug1.gameState.yugcountries[6].is_exist)
					{
						this.text_fake = this.dlce1.credits_text[91];
						return;
					}
				}
				else if (this.this_vrem == 6 && this.yug1.gameState.yugcountries[9].is_exist && !this.yug1.gameState.yugcountries[10].is_exist)
				{
					this.Name.text = this.dlce1.credits_text[334];
					if (this.global1.data[149] == 2)
					{
						this.text_fake = this.dlce1.credits_text[325];
						return;
					}
					if (this.global1.data[149] == 3)
					{
						this.text_fake = this.dlce1.credits_text[314];
						return;
					}
					if (this.yug1.gameState.yugregions[9].owner == 9 && (this.yug1.gameState.yugcountries[9].name == "Венгерская Воеводина" || this.yug1.gameState.yugcountries[9].name == "Hungarian Vojvodina"))
					{
						this.text_fake = this.dlce1.credits_text[341];
						return;
					}
					if (this.yug1.gameState.yugregions[9].owner == 9 && (this.yug1.gameState.yugcountries[9].name == "Румынская Воеводина" || this.yug1.gameState.yugcountries[9].name == "Romanian Vojvodina"))
					{
						this.text_fake = this.dlce1.credits_text[342];
						return;
					}
					if (this.yug1.gameState.yugregions[9].owner == 1 || this.yug1.gameState.yugregions[9].owner == 3 || this.yug1.gameState.yugregions[9].owner == 8)
					{
						this.text_fake = this.dlce1.credits_text[343];
						return;
					}
				}
				else if (this.this_vrem == 7 && this.yug1.gameState.yugcountries[9].is_exist && this.global1.data[222] == 2)
				{
					this.Name.text = this.dlce1.credits_text[334];
					if (this.global1.data[149] == 2)
					{
						this.text_fake = this.dlce1.credits_text[325];
						return;
					}
					if (this.global1.data[149] == 3)
					{
						this.text_fake = this.dlce1.credits_text[314];
						return;
					}
					if (this.yug1.gameState.yugregions[9].owner == 9 && (this.yug1.gameState.yugcountries[9].name == "Венгерская Воеводина" || this.yug1.gameState.yugcountries[9].name == "Hungarian Vojvodina"))
					{
						this.text_fake = this.dlce1.credits_text[341];
						return;
					}
					if (this.yug1.gameState.yugregions[9].owner == 9 && (this.yug1.gameState.yugcountries[9].name == "Румынская Воеводина" || this.yug1.gameState.yugcountries[9].name == "Romanian Vojvodina"))
					{
						this.text_fake = this.dlce1.credits_text[342];
						return;
					}
					if (this.yug1.gameState.yugregions[9].owner == 1 || this.yug1.gameState.yugregions[9].owner == 3 || this.yug1.gameState.yugregions[9].owner == 8)
					{
						this.text_fake = this.dlce1.credits_text[343];
						return;
					}
				}
				else if (this.this_vrem == 6 + this.global1.data[222])
				{
					this.Name.text = this.dlce1.credits_text[77];
					if (this.global1.iron_and_blood && this.global1.data[146] == 1 && this.yug1.gameState.modifies[4] != 1 && this.yug1.gameState.modifies[5] != 1)
					{
						this.achieves.GetComponent<achievements>().Set(90);
					}
					if (this.global1.data[168] == 2 && this.global1.data[115] >= 12)
					{
						this.text_fake = this.dlce1.credits_text[196];
						return;
					}
					if (this.global1.data[168] == 2 && this.global1.data[115] < 12)
					{
						this.text_fake = this.dlce1.credits_text[197];
						return;
					}
					if (this.global1.data[131] >= 1 && this.global1.data[191] == 1 && this.global1.data[219] == 1 && this.yug1.gameState.yugregions[1].owner == 1 && !this.yug1.gameState.yugcountries[1].is_independent)
					{
						this.text_fake = this.dlce1.credits_text[323];
						if (PlayerPrefs.GetInt("language") == 0)
						{
							this.text_fake = this.text_fake + "After a series of adoptions of the basic documents for the functioning of the state, its acting head was - " + this.global1.politics_name[this.global1.data[11]] + ", right up until the presidential elections in 1993.";
						}
						else
						{
							this.text_fake = this.text_fake + "После череды принятия базовых документов функционирования государства его и.о. был – " + this.global1.politics_name[this.global1.data[11]] + ", вплоть до прошедших президентских выборов в 1993 году.";
						}
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(136);
							this.achieves.GetComponent<achievements>().Set(93);
							return;
						}
					}
					else if (this.global1.data[208] == 2 || (this.global1.data[131] >= 1 && this.global1.data[180] > this.global1.data[182] && this.global1.data[18] >= 21 && this.global1.data[214] < 10))
					{
						this.text_fake = this.dlce1.credits_text[255];
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(93);
							return;
						}
					}
					else if (this.global1.data[208] == 1 || (this.global1.data[131] >= 1 && this.global1.data[180] <= this.global1.data[182] && this.global1.data[18] >= 21 && this.global1.data[214] < 10))
					{
						this.text_fake = this.dlce1.credits_text[256];
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(93);
							return;
						}
					}
					else if (this.global1.data[131] >= 1 && this.global1.data[180] > this.global1.data[182] && this.global1.data[18] < 21 && this.global1.data[214] < 10)
					{
						this.text_fake = this.dlce1.credits_text[257];
						if ((!this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy <= 1) || ((this.global1.allcountries[49].isOVD || this.global1.allcountries[50].isOVD || this.global1.allcountries[51].isOVD) && this.global1.allcountries[7].isOVD))
						{
							this.text_fake += this.dlce1.credits_text[258];
						}
						else if (this.global1.allcountries[49].isOVD || this.global1.allcountries[50].isOVD || this.global1.allcountries[51].isOVD)
						{
							this.text_fake += this.dlce1.credits_text[259];
						}
						else
						{
							this.text_fake += this.dlce1.credits_text[260];
						}
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(93);
							return;
						}
					}
					else if (this.global1.data[131] >= 1 && this.global1.data[180] <= this.global1.data[182] && this.global1.data[18] < 21 && this.global1.data[214] < 10)
					{
						this.text_fake = this.dlce1.credits_text[261];
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(93);
							return;
						}
					}
					else if (this.global1.data[208] == 1 || (this.global1.data[131] >= 1 && this.global1.data[180] <= this.global1.data[182] && this.global1.data[18] >= 21 && this.global1.data[214] < 10))
					{
						this.text_fake = this.dlce1.credits_text[256];
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(93);
							return;
						}
					}
					else if (this.global1.data[131] >= 1 && this.global1.data[214] < 25)
					{
						this.text_fake = this.dlce1.credits_text[105];
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(93);
							return;
						}
					}
					else if (this.global1.data[131] >= 1 && this.global1.data[214] < 60)
					{
						this.text_fake = this.dlce1.credits_text[262];
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(93);
							return;
						}
					}
					else if (this.global1.data[131] >= 1 && this.global1.data[135] < 7)
					{
						this.text_fake = this.dlce1.credits_text[265];
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(93);
							return;
						}
					}
					else
					{
						if (this.global1.data[118] == 1 && this.global1.data[116] == 1 && this.global1.data[137] == 0 && this.global1.data[136] == 1 && this.global1.data[130] == 3 && this.global1.data[148] == 1 && this.global1.data[150] == 1 && this.global1.data[156] == 4 && this.global1.data[157] == 2)
						{
							this.text_fake = this.dlce1.credits_text[198];
							return;
						}
						if (this.global1.data[112] == 10)
						{
							this.text_fake = this.dlce1.credits_text[199];
							return;
						}
						if (this.global1.data[135] <= 5)
						{
							this.text_fake = this.dlce1.credits_text[106];
							return;
						}
						if ((this.global1.data[155] == 3 && this.global1.data[128] == 1 && this.global1.data[157] == 1 && this.global1.data[158] == 1 && this.global1.data[156] == 3 && this.global1.data[148] == 1 && (this.global1.data[130] == 7 || this.global1.data[130] == 6) && (this.global1.allcountries[49].Vyshi || this.global1.allcountries[50].Vyshi || this.global1.allcountries[51].Vyshi) && (this.global1.data[176] == 3 || this.global1.data[176] == 5 || this.global1.data[176] == 9)) || (this.global1.data[128] == 1 && this.global1.data[157] == 1 && this.global1.data[158] == 1 && this.global1.data[156] == 3 && this.global1.data[148] == 1 && (this.global1.data[130] == 7 || this.global1.data[130] == 6) && (this.global1.allcountries[49].Vyshi || this.global1.allcountries[50].Vyshi || this.global1.allcountries[51].Vyshi) && this.global1.data[155] != 3))
						{
							this.text_fake = this.dlce1.credits_text[182];
							if (this.global1.iron_and_blood)
							{
								this.achieves.GetComponent<achievements>().Set(111);
								return;
							}
						}
						else
						{
							if ((this.yug1.gameState.yugcountries[8].is_player && ((this.yug1.gameState.yugcountries[0].is_independent && this.yug1.gameState.yugregions[0].owner == 0 && !this.yug1.gameState.yugcountries[8].peace_with[0]) || (this.yug1.gameState.yugcountries[1].is_independent && this.yug1.gameState.yugregions[1].owner == 1 && !this.yug1.gameState.yugcountries[8].peace_with[1]))) || (this.yug1.gameState.yugcountries[3].is_independent && this.yug1.gameState.yugregions[3].owner == 3 && !this.yug1.gameState.yugcountries[8].peace_with[3]))
							{
								this.text_fake = this.dlce1.credits_text[357];
								return;
							}
							if (this.yug1.gameState.yugcountries[3].is_player && ((this.yug1.gameState.yugcountries[0].is_independent && this.yug1.gameState.yugregions[0].owner == 0 && !this.yug1.gameState.yugcountries[3].peace_with[0]) || (this.yug1.gameState.yugcountries[1].is_independent && this.yug1.gameState.yugregions[1].owner == 1 && !this.yug1.gameState.yugcountries[3].peace_with[1])))
							{
								this.text_fake = this.dlce1.credits_text[357];
								return;
							}
							if (this.yug1.gameState.modifies[5] > 0)
							{
								this.text_fake = this.dlce1.credits_text[104];
								if (this.global1.iron_and_blood)
								{
									this.achieves.GetComponent<achievements>().Set(92);
									return;
								}
							}
							else if (this.yug1.gameState.modifies[4] > 0)
							{
								this.text_fake = this.dlce1.credits_text[103];
								if (this.global1.iron_and_blood)
								{
									this.achieves.GetComponent<achievements>().Set(91);
									return;
								}
							}
							else
							{
								if (this.global1.data[126] == 0 && this.global1.data[115] <= 4)
								{
									this.Name.text = this.dlce1.credits_text[119];
									this.text_fake = this.dlce1.credits_text[123];
									return;
								}
								if (this.global1.data[126] != 0)
								{
									this.text_fake = this.dlce1.credits_text[102];
									return;
								}
								if (this.global1.data[126] == 0 && this.global1.data[115] >= 16)
								{
									this.Name.text = this.dlce1.credits_text[121];
									this.text_fake = this.dlce1.credits_text[125];
									if (this.global1.iron_and_blood)
									{
										this.achieves.GetComponent<achievements>().Set(91);
										return;
									}
								}
								else
								{
									this.Name.text = this.dlce1.credits_text[120];
									this.text_fake = this.dlce1.credits_text[124];
									if (this.global1.iron_and_blood)
									{
										this.achieves.GetComponent<achievements>().Set(94);
										return;
									}
								}
							}
						}
					}
				}
				else if (this.this_vrem == 7 + this.global1.data[222])
				{
					this.Name.text = this.dlce1.credits_text[78];
					if ((this.global1.data[155] == 3 && this.global1.data[128] == 1 && this.global1.data[157] == 1 && this.global1.data[158] == 1 && this.global1.data[156] == 3 && this.global1.data[148] == 1 && (this.global1.data[130] == 7 || this.global1.data[130] == 6) && (this.global1.allcountries[49].Vyshi || this.global1.allcountries[50].Vyshi || this.global1.allcountries[51].Vyshi) && (this.global1.data[176] == 3 || this.global1.data[176] == 5 || this.global1.data[176] == 9)) || (this.global1.data[128] == 1 && this.global1.data[157] == 1 && this.global1.data[158] == 1 && this.global1.data[156] == 3 && this.global1.data[148] == 1 && (this.global1.data[130] == 7 || this.global1.data[130] == 6) && (this.global1.allcountries[49].Vyshi || this.global1.allcountries[50].Vyshi || this.global1.allcountries[51].Vyshi) && this.global1.data[155] != 3))
					{
						this.text_fake = this.dlce1.credits_text[183];
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(111);
						}
					}
					else if (this.global1.data[131] >= 1 && this.global1.data[191] == 1 && this.global1.data[219] == 1)
					{
						this.text_fake = this.dlce1.credits_text[324];
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(136);
						}
					}
					else if (this.global1.data[131] >= 1 && this.global1.data[148] == 2 && this.global1.data[200] == 0 && this.global1.data[214] <= 40)
					{
						this.text_fake = this.dlce1.credits_text[266];
					}
					else if (this.global1.data[131] >= 1 && this.global1.data[148] == 2 && this.global1.data[200] == 0)
					{
						this.text_fake = this.dlce1.credits_text[267];
					}
					else if (this.global1.data[131] >= 1 && this.global1.data[112] == 12)
					{
						this.text_fake = this.dlce1.credits_text[268];
					}
					else if (this.global1.data[131] >= 1 && this.global1.allcountries[7].isSEV && (this.global1.allcountries[49].isSEV || this.global1.allcountries[50].isSEV || this.global1.allcountries[51].isSEV) && this.global1.data[160] == 2)
					{
						this.text_fake = this.dlce1.credits_text[269];
					}
					else if (this.global1.data[131] >= 1 && this.global1.data[18] >= 22 && this.global1.data[155] != 3)
					{
						this.text_fake = this.dlce1.credits_text[270];
					}
					else if (this.global1.data[131] >= 1)
					{
						if (this.global1.data[45] == 5)
						{
							this.text_fake = this.dlce1.credits_text[107];
						}
						else
						{
							this.text_fake = this.dlce1.credits_text[144];
						}
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(97);
						}
					}
					else if (this.global1.data[112] == 10)
					{
						this.text_fake = this.dlce1.credits_text[200];
					}
					else if (this.global1.data[112] == 11)
					{
						this.text_fake = this.dlce1.credits_text[245];
					}
					else if (this.global1.data[112] == 9)
					{
						this.text_fake = this.dlce1.credits_text[191];
					}
					else if (this.global1.data[112] == 3)
					{
						this.text_fake = this.dlce1.credits_text[108];
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(95);
							if (this.global1.data[160] == 2 && this.yug1.gameState.modifies[5] > 0 && this.global1.data[16] <= 11 && (this.global1.data[14] == 1 || this.global1.data[14] == 2))
							{
								this.achieves.GetComponent<achievements>().Set(99);
							}
						}
					}
					else if (this.global1.data[112] == 4)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(96);
						}
						this.text_fake = this.dlce1.credits_text[109];
					}
					else if (this.global1.data[112] == 6)
					{
						if (this.yug1.gameState.yugcountries[7].is_independent && this.yug1.gameState.yugregions[7].owner == 7 && this.global1.data[9] <= 300)
						{
							this.text_fake = this.dlce1.credits_text[184];
						}
						else if (this.yug1.gameState.yugcountries[7].is_independent && this.yug1.gameState.yugregions[7].owner == 7 && this.global1.data[9] >= 301)
						{
							this.text_fake = this.dlce1.credits_text[185];
						}
						else
						{
							this.text_fake = this.dlce1.credits_text[110];
						}
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(97);
						}
					}
					else if (this.global1.data[112] == 7)
					{
						this.text_fake = this.dlce1.credits_text[116];
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(98);
						}
					}
					else if (this.global1.data[112] == 8)
					{
						this.text_fake = this.dlce1.credits_text[168];
					}
					else if (this.global1.data[112] == 5 && !flag && !this.yug1.gameState.yugcountries[1].is_independent && this.yug1.gameState.yugcountries[1].is_exist && this.yug1.gameState.yugregions[1].owner == 1)
					{
						this.text_fake = this.dlce1.credits_text[178];
					}
					else
					{
						this.text_fake = this.dlce1.credits_text[179];
					}
					if (this.global1.data[113] == 1)
					{
						this.text_fake += this.dlce1.credits_text[139];
						return;
					}
				}
				else if (this.this_vrem == 8 + this.global1.data[222])
				{
					this.Name.text = this.dlce1.credits_text[140];
					this.text_fake = this.dlce1.credits_text[142];
					if (this.global1.data[177] == 3)
					{
						this.text_fake = this.dlce1.credits_text[219];
						return;
					}
					if (this.global1.data[153] == 1 && this.global1.data[131] == 0)
					{
						this.text_fake = this.dlce1.credits_text[141];
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(102);
							return;
						}
					}
					else if (this.global1.data[166] == 3 && this.global1.data[3] + this.global1.data[9] >= 550)
					{
						this.text_fake = this.dlce1.credits_text[175];
						return;
					}
				}
				else if (this.this_vrem == 9 + this.global1.data[222])
				{
					this.Name.text = this.dlce1.credits_text[145];
					this.text_fake = this.dlce1.credits_text[142];
					if (this.yug1.gameState.yugcountries[6].is_exist)
					{
						this.text_fake = this.dlce1.credits_text[91];
						if (this.global1.event_done[395] && this.global1.data[200] == 1 && this.global1.data[131] >= 1)
						{
							this.text_fake = this.dlce1.credits_text[332];
							if (PlayerPrefs.GetInt("language") == 0)
							{
								this.text_fake = this.text_fake + this.global1.politics_name[this.global1.data[11]] + " called for \"continuing to build a new Yugoslavia as honestly as General Gracanin did\" and \"maintaining vigilance against unfriendly states that use dirty methods of terror.\"";
								return;
							}
							this.text_fake = this.text_fake + this.global1.politics_name[this.global1.data[11]] + " призвал «продолжить строить новую Югославию так же честно, как это делал генерал Грачанин» и «сохранять бдительность против недружественных государств, использующих грязные приёмы террора»..";
							return;
						}
						else
						{
							if (this.global1.event_done[395] && this.global1.data[171] == 1)
							{
								this.text_fake = this.dlce1.credits_text[331];
								return;
							}
							if (this.global1.event_done[395] && this.global1.data[150] == 0 && this.global1.data[148] == 1)
							{
								this.text_fake = this.dlce1.credits_text[330];
								return;
							}
							if (this.global1.event_done[395] && this.global1.data[150] == 1 && this.global1.data[148] == 1)
							{
								this.text_fake = this.dlce1.credits_text[329];
								return;
							}
							if (this.global1.event_done[395] && this.global1.data[148] == 2)
							{
								this.text_fake = this.dlce1.credits_text[328];
								return;
							}
						}
					}
					else if (this.global1.event_done[395] && this.global1.data[200] == 1 && this.global1.data[131] >= 1)
					{
						this.text_fake = this.dlce1.credits_text[332];
						if (PlayerPrefs.GetInt("language") == 0)
						{
							this.text_fake = this.text_fake + this.global1.politics_name[this.global1.data[11]] + " called for \"continuing to build a new Yugoslavia as honestly as General Gracanin did\" and \"maintaining vigilance against unfriendly states that use dirty methods of terror.\"";
							return;
						}
						this.text_fake = this.text_fake + this.global1.politics_name[this.global1.data[11]] + " призвал «продолжить строить новую Югославию так же честно, как это делал генерал Грачанин» и «сохранять бдительность против недружественных государств, использующих грязные приёмы террора»..";
						return;
					}
					else
					{
						if (this.global1.event_done[395] && this.global1.data[171] == 1)
						{
							this.text_fake = this.dlce1.credits_text[331];
							return;
						}
						if (this.global1.event_done[395] && this.global1.data[150] == 0 && this.global1.data[148] == 1)
						{
							this.text_fake = this.dlce1.credits_text[330];
							return;
						}
						if (this.global1.event_done[395] && this.global1.data[150] == 1 && this.global1.data[148] == 1)
						{
							this.text_fake = this.dlce1.credits_text[329];
							return;
						}
						if (this.global1.event_done[395] && this.global1.data[148] == 2)
						{
							this.text_fake = this.dlce1.credits_text[328];
							return;
						}
					}
				}
				else if (this.this_vrem == 10 + this.global1.data[222])
				{
					if (this.global1.data[164] == 8 && this.yug1.gameState.modifies[5] == 0 && this.global1.data[157] != 2 && this.global1.data[158] != 2 && this.global1.data[128] != 2 && this.global1.data[10] <= 400)
					{
						this.Name.text = this.dlce1.credits_text[152];
						this.text_fake = this.dlce1.credits_text[155];
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(106);
							return;
						}
					}
					else
					{
						if (this.global1.data[164] == 8 && this.global1.data[10] <= 400)
						{
							this.Name.text = this.dlce1.credits_text[153];
							this.text_fake = this.dlce1.credits_text[156];
							return;
						}
						if (this.global1.data[164] == 8 && this.global1.data[10] >= 401)
						{
							this.Name.text = this.dlce1.credits_text[154];
							this.text_fake = this.dlce1.credits_text[157];
							return;
						}
						this.Name.text = this.dlce1.credits_text[169];
						this.text_fake = this.dlce1.credits_text[180];
						return;
					}
				}
				else if (this.this_vrem == 11 + this.global1.data[222])
				{
					if (!this.global1.event_done[371] && this.global1.data[164] <= 5)
					{
						this.Name.text = this.dlce1.credits_text[158];
						this.text_fake = this.dlce1.credits_text[177];
						return;
					}
					if (this.global1.data[164] == 8)
					{
						this.Name.text = this.dlce1.credits_text[162];
						this.text_fake = this.dlce1.credits_text[167];
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(110);
							return;
						}
					}
					else
					{
						if (this.global1.event_done[372] && this.global1.data[164] <= 5)
						{
							this.Name.text = this.dlce1.credits_text[158];
							this.text_fake = this.dlce1.credits_text[163];
							return;
						}
						if (this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 + this.global1.data[6] / 10 + this.global1.data[8] / 20 >= 1350)
						{
							this.Name.text = this.dlce1.credits_text[160];
							this.text_fake = this.dlce1.credits_text[165];
							if (this.global1.iron_and_blood)
							{
								this.achieves.GetComponent<achievements>().Set(108);
								return;
							}
						}
						else
						{
							if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 >= 1000)
							{
								this.Name.text = this.dlce1.credits_text[186];
								this.text_fake = this.dlce1.credits_text[187];
								return;
							}
							if (this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie >= 300)
							{
								this.Name.text = this.dlce1.credits_text[161];
								this.text_fake = this.dlce1.credits_text[166];
								if (this.global1.iron_and_blood)
								{
									this.achieves.GetComponent<achievements>().Set(109);
									return;
								}
							}
							else
							{
								this.Name.text = this.dlce1.credits_text[159];
								this.text_fake = this.dlce1.credits_text[164];
								if (this.global1.iron_and_blood)
								{
									this.achieves.GetComponent<achievements>().Set(107);
									return;
								}
							}
						}
					}
				}
			}
		}
		else
		{
			if (this.this_okno == 2)
			{
				this.this_okno = 0;
				this.this_vrem = 0;
			}
			else if (this.this_okno == 0)
			{
				this.this_okno = 2;
				this.this_vrem = 9;
			}
			this.Name.text = this.dlce1.credits_text[115];
			this.text_fake = this.dlce1.credits_text[113];
			if (this.global1.iron_and_blood)
			{
				if (this.yug1.gameState.player == 5 && this.yug1.gameState.yugcountries[8].is_ally)
				{
					this.achieves.GetComponent<achievements>().Set(81);
				}
				else if (this.yug1.gameState.player == 7 && this.yug1.gameState.yugcountries[3].is_ally)
				{
					this.achieves.GetComponent<achievements>().Set(82);
				}
				else if (this.yug1.gameState.player == 10 && this.yug1.gameState.yugcountries[1].is_ally)
				{
					this.achieves.GetComponent<achievements>().Set(83);
				}
				else if (this.yug1.gameState.player == 1 || this.yug1.gameState.player == 3 || this.yug1.gameState.player == 8)
				{
					this.achieves.GetComponent<achievements>().Set(84);
				}
				if (this.global1.event_done[1102] && this.global1.event_done[1103] && this.global1.event_done[1105] && this.global1.event_done[1106])
				{
					this.achieves.GetComponent<achievements>().Set(85);
				}
			}
		}
	}

	// Token: 0x06000197 RID: 407
	private void ThisEndingWindow(List<int> havepaths, int plus_max)
	{
		if (PlayerPrefs.GetInt("language") == 0)
		{
			if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51 && this.this_okno >= 0 && this.this_okno <= 2)
			{
				this.YugoEndings();
				this.SovToRus(this.text_fake);
			}
			else if (this.this_okno == 0 && this.global1.data[0] != 12)
			{
				this.Name.text = "POLITICAL STANCE";
				this.text_fake = "";
				if (this.global1.data[42] == 1)
				{
					if (this.global1.data[0] != 10 && this.global1.data[0] != 18 && this.global1.data[0] != 12)
					{
						this.text_fake = string.Concat(new string[]
						{
							"Thanks to decisive actions,  ",
							this.global1.politics_name[this.global1.data[11]],
							" was able to defeat his opponents and preserve the socialist system. And after our analogue of the Cultural Revolution, even at the cost of some victims, ",
							this.global1.politics_name[this.global1.data[11]],
							" finally consolidated his power. |Unfortunately, after his death, in ",
							this.global1.party_name[0],
							" began a strife for the place of the head of state, as a result of which, at the party congress, the personality cult of the past ruler was refuted, and he himself was posthumously convicted. Was that the reason for personal dislike or was it a necessity for keeping power - who knows?... And it does not matter, because the stories of previous leader's bloody crimes are passed down from generation to generation. |In the country there was a thaw. The establishment of more friendly relations with the West began, as well as relaxations in the sphere of pluralism, culture and censorship. Party bureaucrats received protection from special services and all the power, trying to maintain the current conservative position of government. Perhaps this is even for the best..."
						});
					}
					else
					{
						this.text_fake = string.Concat(new string[]
						{
							"Thanks to decisive actions, ",
							this.global1.politics_name[this.global1.data[11]],
							" was able to defeat its opponents and preserve the socialist order. And after our equivalent of the Cultural Revolution, albeit at the cost of some sacrifices, ",
							this.global1.politics_name[this.global1.data[11]],
							" finally consolidated his power.|After the death of the great leader, a pre-selected successor continued the work of his patron, the Leader of the Nation. However, his attempts to change anything in the country were thwarted by the top party leadership, and he began to gradually cool to politics, and even to the management of the country, putting it in the hands of the Politburo. Thus, his tenure became more and more nominal. Although the word \"republic\" appears in the name of the state, the people are less and less involved in the government."
						});
					}
				}
				else if (this.global1.data[42] == 2)
				{
					this.text_fake = "Thanks to your decisive actions, you were able to defeat your opponents, and to preserve the socialist system. And after the Cultural Revolution, even at the cost of some victims, you finally strengthened your power. Without wishing to repeat the fate of Stalin, you began to build your own personality cult, putting yourself in the same place with Marx, Engels and other theorists of communism, gradually forming your ideology. Your child was the Party. Completely renewed and completely devoted to you. |Unfortunately, your life was interrupted by an unknown disease. And was it disease?..|You, as alive and real person, no longer needed for the Party, the child who absorb it's creator. You shouldn't be just a human any more. You had to become an icon, an \"eternal leader\". |Freedom of thought and freedom of speech were significantly curtailed, and control over citizens was greatly enhanced. But this has yield results: now our citizens are selflessly loyal to the Party, and the Party is the state.";
					if (this.global1.data[0] != 10 && this.global1.data[0] != 18 && this.global1.data[0] != 12)
					{
						this.text_fake += "|Unfortunately, our country is increasingly called the \"European DPRK\" - Western imperialists can't stand us, however, like the ideals of socialism . Or... Maybe it's still we went somewhere wrong?";
					}
					this.text_fake += "|As it were, our country continues to exist, like your cult. You are our eternal and only posthumous president! Ave for you!|And yet, where did we go, and where do we go next? The question is, perhaps, rhetorical...";
				}
				else if (this.global1.data[42] == 3)
				{
					this.text_fake = this.global1.politics_name[this.global1.data[11]] + " determinedly established a one-party democracy headed by " + this.global1.party_name[0] + ",whose idea was to sweep away all counter-revolutionary ideas, moving towards to build of Marxism-Leninism and assert the leading role of democratic centralism and collective government. However, the people took it as an affront, that the current government mired in the bureaucracy, \"eating\" honest people. Citizens are trading tales and making fun of the Party.";
				}
				else if (this.global1.data[42] == 4)
				{
					this.text_fake = this.global1.politics_name[this.global1.data[11]] + " and " + this.global1.party_name[0] + " determinedly established a one-party democracy in the country, allowing all counter-revolutionary ideas to be swept aside and moving towards to build of Marxism-Leninism. Despite some miscalculations by the ruler, the people have reacted with understanding to the policy pursued and are ready to support him and the Party further. Thus, the leading role of democratic centralism and collective government has been established in the country.";
				}
				else if (this.global1.data[42] == 5)
				{
					this.text_fake = string.Concat(new string[]
					{
						"Thanks to decisive actions,  ",
						this.global1.politics_name[this.global1.data[11]],
						"was able to defeat his opponents and retain power. Unfortunately, over time, his vigilance weakened. ",
						this.global1.politics_name[this.global1.data[11]],
						" did not notice when in the parliament formed groups dissatisfied with his rule...|And now, after another polemic in parliament, the secretary of our esteemed leader brought him tea, with strange smell of almonds. ",
						this.global1.politics_name[this.global1.data[11]],
						" did not even have time to realize that it was potassium cyanide....|After the \"untimely death\" of the Great Leader, the power passed to other people who began to slowly curtail attempt to introduce his cult of personality in the country, and then simply erase the previous ruler from memory and history.|However, as such, there have been no significant changes, and the state still dominates the economy. Is it good or bad - who knows?.."
					});
				}
				else if (this.global1.data[42] == 6)
				{
					this.text_fake = string.Concat(new string[]
					{
						"During the fall of the socialist regimes around the world, ",
						this.global1.politics_name[this.global1.data[11]],
						", fearing for his own power, began feverishly looking for compromises with representatives of the opposition and political opponents, while simultaneously trying to please the power structures. Unfortunately, in order to preserve power, he also had to bow to the Western powers ...|As a result, by ",
						(this.global1.data[21] + 3).ToString(),
						" , the country had changed beyond recognition. Being driven into a corner, ",
						this.global1.politics_name[this.global1.data[11]],
						" rejected the ideals of Marxism-Leninism. In a fit of feverish struggle for the preservation of power, he conducted an ultra-rapid liberalization of the diplomatic, political and social spheres. As a result - globalization, dependence on foreign powers and the emergence of a corrupt bureaucratic system.|Managed democracy has been established in the country. All the parties represented in the parliament are, in fact, only puppets. And the power is now quite strong and ",
						this.global1.politics_name[this.global1.data[11]],
						" can calmly rule further. But the question arises - is it necessary at all?.. "
					});
				}
				else if (this.global1.data[42] == 7)
				{
					this.text_fake = string.Concat(new string[]
					{
						this.global1.politics_name[this.global1.data[11]],
						" was a controversial figure, for some he will forever remain the \"winner of communism\", and for others only a traitor. The share of the ",
						this.global1.party_name[0],
						" had the difficult mission of winning over the past system, democratization of the country according to the Western standards. The time of our president will forever be remembered as an era of liberalism, however, conservative right-wing and more radical left-wing oppositionists still sharply criticize the reforms of those times. Eventually came the presidential elections, which won the legal opposition, and the leader went to rest. The oppositionists took advantage of the population's discontent with economic policy to come to power, but the economy was exposed only to cosmetic reforms. This led to the fact that the ",
						this.global1.party_name[0],
						", still not lost in weight, returned to power in the next election.|"
					});
					if (this.global1.data[0] == 1)
					{
						this.text_fake += "When the GDR and the FRG became so similar to each other as the twin brothers, the question arose about unification. However, complete unification did not happen: Ossi and Wessi, although they were Germans, but the years of life under different regimes did their job. Therefore, the union of the west and the east took place in the form of a confederation: Germany became formally united, the customs borders disappeared, and the army became a single Bundeswehr, but all the same in the rest of the east the changes were minimal, and the autonomies of all other structures are quite significant. Nothing shook the new order of things. ";
					}
					this.text_fake = this.text_fake + "But " + this.global1.politics_name[this.global1.data[11]] + " was later accused of being a freelance agent of the special services of the old communist regime, before coming to power. This is the only thing that disturbed the former president, who was disappointed with what his successors had done with the country, but it was no longer possible to return to politics: the times had changed. And the Supreme Court acquitted him.";
				}
				else if (this.global1.data[42] == 8 && this.global1.data[43] == 2)
				{
					this.text_fake = this.global1.politics_name[this.global1.data[11]] + " was a controversial figure, for some he will forever remain the \"perfect communist\", and for others only a traitor. The share of the " + this.global1.party_name[0] + " had the difficult mission of winning over the past system, democratization of the country according to the Western standards. The time of our president will forever be remembered as an era of prosperity of our country's economy, although some radicals will dare to say that it was better before. The policy pursued by the national leader was supported by all classes so much that he held the post of president until his death. There were no sensible opponents in the country, and the media is still comparing our all-respected president with Roosevelt himself!|";
					if (this.global1.data[0] == 1)
					{
						this.text_fake = this.text_fake + "And " + this.global1.politics_name[this.global1.data[11]] + " was later immortalized in a monument on one of the specially preserved sections of the Berlin Wall.";
					}
				}
				else if (this.global1.data[42] == 8)
				{
					this.text_fake = this.global1.politics_name[this.global1.data[11]] + " was a controversial figure, for some he will forever remain the \"winner of communism\", and for others only a traitor. The share of the " + this.global1.party_name[0] + " had the difficult mission of winning over the past system, democratization of the country according to the Western standards. The time of our president will forever be remembered as an era of prosperity of our country's economy, although some radicals will dare to say that it was better before. The policy pursued by the national leader was supported by all classes so much that he held the post of president until his death. There were no sensible opponents in the country, and the media is still comparing our all-respected president with Roosevelt himself!|";
					if (this.global1.data[0] == 1)
					{
						this.text_fake = this.text_fake + "When the GDR and the FRG became so similar to each other as the twin brothers, the question arose about unification. However, complete unification did not happen: Ossi and Wessi, although they were Germans, but the years of life under different regimes did their job. Yes, and " + this.global1.politics_name[this.global1.data[11]] + " himself during his life delayed this issue to the last. Therefore, the union of the west and the east took place in the form of a confederation: Germany became formally united, the customs borders disappeared, and the army became a single Bundeswehr, but all the same in the rest of the east the changes were minimal, and the autonomies of all other structures are quite significant. In the East, even its own Parliament and the decorative People's Guard remained. Nothing shook the new order of things.|";
					}
					this.text_fake = this.text_fake + "And " + this.global1.politics_name[this.global1.data[11]] + " was later immortalized in a monument on one of the specially preserved sections of the Berlin Wall.";
				}
				else if (this.global1.data[42] == 9)
				{
					this.text_fake = "Against the backdrop of ongoing reforms in the socialist camp, you, fearing for your own power and securing the support of the Intelligence agents and the military, began to feverishly eradicate any dissent in your country. After a wave of repressions, our country was hit by the first wave of sanctions from the UN, after which it finally retreated into isolation, cutting trade and diplomatic ties with the outside world and erecting an even more iron curtain. Now in your state, ideology has been elevated to the status of religion, and any dissenter is immediately eliminated by physical means. The ideology itself has completely separated from Marxism-Leninism, forming a new structure based on folk traditions and national strengths. After your death, numerous mystical legends arose around you, making you almost a god in the new ideological-religious pantheon, opening a mausoleum, and starting a new calendar from your birth. And the country came to be ruled by a loyal successor you appointed, who continued your work.";
					if (this.global1.data[0] == 1 && this.global1.allcountries[this.global1.data[0]].subideology == 1 && this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(142);
					}
				}
				else if (this.global1.data[42] == 10)
				{
					this.text_fake = string.Concat(new string[]
					{
						"Because of the wise policy of our leader, the country has withstood in troubled years. ",
						this.global1.politics_name[this.global1.data[11]],
						" will always be remembered as the savior of the country, at least so will be written in history textbooks. Despite the screams of individual \"derelicts\", the special forces, the police and the army restored their orders: all opposition media and parties were banned, the country was mired in xenophobia and militarism, and the censorship committees worked without stopping. The Church also rose its head, having concluded an unspoken concordat with the government ... However, no one dared to speak out loud about it. Occasionally, accusations of \"fascization\" were coming from abroad, but they were repeatedly declared as false propaganda, the conflict was cover up, and diplomatic and economic relations continued. So the leader of the ",
						this.global1.party_name[0],
						" rule until his sudden death from a stroke. After that, the country was headed by his closest associates, who immediately began the struggle for power. Probably, someday this corrupt military-bureaucratic system will fall under its own weight, but it will not be very soon."
					});
				}
				if (this.global1.data[0] == 1 && this.global1.data[42] != 8 && this.global1.data[42] != 7 && this.global1.allcountries[this.global1.data[0]].Vyshi && !this.global1.allcountries[7].isOVD)
				{
					this.text_fake = this.text_fake + "When the GDR and the FRG became so similar to each other as the twin brothers, the question arose about unification. However, complete unification did not happen: Ossi and Wessi, although they were Germans, but the years of life under different regimes did their job. Yes, and " + this.global1.politics_name[this.global1.data[11]] + " himself during his life delayed this issue to the last. Therefore, the union of the west and the east took place in the form of a confederation: Germany became formally united, the customs borders disappeared, and the army became a single Bundeswehr, but all the same in the rest of the east the changes were minimal, and the autonomies of all other structures are quite significant. In the East, even its own Parliament and the decorative People's Guard remained. Nothing shook the new order of things.|";
				}
				else if (this.global1.data[0] == 1 && this.global1.eventVariantChosen[1098] == 2)
				{
					if (this.global1.eventVariantChosen[29] == 4 && this.global1.data[14] != 0 && this.global1.data[16] != 13)
					{
						this.text_fake = "Several years after the reforms, the transformed GDR—now the German Republic—emerged from the crisis of the past like a phoenix rising from the ashes. Retaining the centralized control and socialist orientation of the old system, it managed to reorganize itself into a showcase of alternative modernization. The Jakob Kaiser Constitution, ideologically adjusted to the realities of the 21st century, established managed democracy without undermining the foundation of control.|The newly formed CSU/CDU-GR and FDP-GR became not just functional parties but symbols of a new ideology: social Christian paternalism. These structures openly engaged in media and ideological disputes with their West German namesakes, accusing them of betraying ideals, embracing moral relativism, and shirking responsibility toward the people. Now Europe has two CDU parties and two FDPs—and only one path appears coherent and people-oriented.|The roles of Mahler and Ortleb proved decisive: their programs, speeches, and initiatives caused bewilderment in the West but earned respect from millions. The nation’s schools teach \"healthy patriotism,\" television broadcasts \"The German Way,\" the streets are no longer loud with protest, and the parliament functions… predictably.|The FRG finds itself in a difficult position: young people are increasingly looking East, where ideas of order, social justice, and spiritual grounding are taking on a new face. The liberal and neoliberal concepts have reached a crossroads. Polls show that up to " + ((float)this.global1.allcountries[17].Westalgie / 20f).ToString() + "% of West German citizens \"view the GR’s course with interest\"|The world watches with growing astonishment: what was once an \"occupied territory\" has become an alternative center of German statehood. The German Republic does not attempt to storm the FRG, but quietly suggests: \"Look at what a true Germany could be.\" It marches not to anger or arrogance—but to confidence and order. And that speaks louder than slogans.";
					}
					else if (this.global1.data[16] < 12 && this.global1.data[14] < 3)
					{
						this.text_fake += "|First the SED, CDU and NDPG were merged into the CSU/CDU bloc with a formally new official ideology, followed by the introduction of a purely nominal office of President, elected by Parliament, and the final step was a return to the 1949 Constitution with the introduction of formal federalism and German acronyms. But despite the expectations of certain individuals and organisations, East Germany did not succumb to Western influence, nor was it Westernised or liberalised: portraits of Marx and Engels continued to hang in the streets, Marxist works and dialectic were taught in schools, and the planned economy and socialist regime were still in place.";
					}
					else
					{
						this.text_fake += "|Many believed in the best, but expected the transformation of the GDR to remain a mere formality. Their fears did not materialise: although East Germany continued to oppose Western liberalism, the GDR underwent serious reforms, and a regime jokingly referred to as a \"mirror of the FRG\" was established within the country. And even the East German government does not hide its \"mirror\" status and proudly calls itself \"better version of West Germany\" in its propaganda.";
					}
				}
				else if (this.global1.eventVariantChosen[58] == 1 && this.global1.event_done[58])
				{
					this.text_fake += "|Remaining in power, adopting the ideas of Austro-Marxism and Eurocommunism, our party changed the vector of the class struggle to the struggle for tolerance, acceptance of any difference and social individualism. By implementing a new political program by 2020, our country has successfully managed to become an example for many Western opposition social movements despite all our new social problems, such as a low level of collectivism and a high level of depression and aggression among the population.";
				}
				else if (this.global1.eventVariantChosen[58] == 0 && this.global1.event_done[58])
				{
					if (this.global1.data[16] < 12)
					{
						this.text_fake += "|Remaining in power, adopting the ideas of the old National Bolshevism and Nikisch, our party changed the vector of the class struggle to the struggle for national welfare and a nationwide state, the struggle against the West and for unity with the East. By implementing a new political program by 2020, our country has successfully managed to become an example for many world socialist organizations, which, seeing our successful course, adopted and popularized the National Bolshevik movement. Let's hope that the eclectic system of uniting peasants, workers, the petty bourgeoisie and the intelligentsia will continue to hold on, and will not go over to the classic \"union of a swan, pike and crawfish.\"";
					}
					else
					{
						this.text_fake += "|Remaining in power, adopting the ideas of the old National Bolshevism and Nikisch, our party changed the vector of the class struggle to the struggle for national welfare and a nationwide state, the struggle against the West and for unity with the East. Implementing a new political program for 2020, our country also moved away from the original ideas of Nikisch, inspired by the Strasser brothers, but managed to become an example for many world nationalist parties and organizations, showing an example of building a national-corporatist state without ethnic cleansing and imperial ambitions. Let's hope that the solidarity of workers and corporations, mediated by the state, will work longer than in all past historical examples.";
					}
				}
				if (this.global1.data[0] == 5 && !this.global1.allcountries[5].isSEV && !this.global1.allcountries[5].isOVD && !this.global1.allcountries[5].Vyshi && this.global1.data[11] == 0 && this.global1.allcountries[this.global1.data[0]].subideology == 0 && this.global1.science[9] && this.global1.data[56] == 2 && this.global1.eventVariantChosen[70] == 4 && this.global1.eventVariantChosen[96] == 1 && this.global1.eventVariantChosen[110] == 3 && this.global1.data[59] == 1)
				{
					this.text_fake = "The swift transformation of the social camp led to a dramatic shift in the political landscape of Eastern Europe. Romania was no exception. Led by the authoritarian hand of Nicolae Ceaușescu, the country was compelled to adapt to the sharp democratization at its borders, in order to prevent, as the Romanian leader aptly put it, the Danube from flowing backward. Taking advantage of the political turmoil in the post-Soviet space, following the historic reunification with Moldova and the nearly forced migration of the Hungarian population, Romania gained, on one hand, nearly complete ethnic homogeneity, while on the other, additional fuel to stoke the nationalist policies of the authoritarian regime. The socialist veneer of political life remained largely unchanged, while the surveillance and control by the Securitate over the population increased exponentially. After the recent unseen disappearances of Ceaușescu's last opponents within the party (as no one from outside dared to publicly oppose the decisions of the \"Father of the Nation\"), a new constitution was adopted, allowing the Romanian president to continually lead his people into an ideologically correct future, where there was no place for the false light of bourgeois half-democracy. He elaborated on this in his books and articles, as well as during speeches broadcast on radio and television. However, as the years passed, Ceaușescu appeared less frequently in public, and rumors began to spread among the people about a fog that had thickened around the House of the Republic, where the ghosts of missing political opponents were said to be seen. Was it pleasant to see clouds racing across the sky, with the flicker of moonlight shining through the gaps?";
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(146);
					}
				}
				if (this.global1.iron_and_blood)
				{
					if (this.global1.eventVariantChosen[1098] == 2 && this.global1.eventVariantChosen[57] == 4 && this.global1.eventVariantChosen[34] == 0 && this.global1.data[14] <= 0)
					{
						this.achieves.GetComponent<achievements>().Set(131);
					}
					else if (this.global1.eventVariantChosen[1098] == 0 && this.global1.eventVariantChosen[58] == 1 && this.global1.data[16] > 12)
					{
						this.achieves.GetComponent<achievements>().Set(132);
					}
					else if (this.global1.eventVariantChosen[1098] == 1 && this.global1.eventVariantChosen[58] == 0 && this.global1.data[16] == 11)
					{
						this.achieves.GetComponent<achievements>().Set(133);
					}
					if (this.global1.eventVariantChosen[29] == 4 && this.global1.data[14] != 0 && this.global1.data[16] != 13)
					{
						this.achieves.GetComponent<achievements>().Set(141);
					}
				}
			}
			else if (this.this_okno == 0)
			{
				if (this.global1.iron_and_blood && !this.global1.allcountries[7].Vyshi && this.global1.data[90] == 0 && this.global1.data[92] == 0 && this.global1.data[93] == 0 && this.global1.data[94] == 0)
				{
					this.achieves.GetComponent<achievements>().Set(65);
				}
				this.Name.text = "POLITICAL POSITION";
				if (this.global1.data[103] == 1 && this.global1.data[80] >= 80)
				{
					this.text_fake = string.Concat(new string[]
					{
						"By decisive action, ",
						this.global1.politics_name[this.global1.data[11]],
						" and ",
						this.global1.party_name[0],
						" established one-party democracy in the country, which made it possible to sweep away all counter-revolutionary ideas and move towards building Marxism-Leninism. Despite some miscalculations of the ruler, the people treated the policy with understanding and were ready to support him and the Party further. Thus, the leading role of democratic centralism and collective governance has been established in the country.."
					});
				}
				else if (this.global1.data[104] == 1)
				{
					this.text_fake = "Tanai and the Khalqist wing of the party were able to deal with the opposition in the PDPA and establish the party’s official ideology as «Islamic Socialism», thereby combining the teachings of the Koran and the Prophet Muhammad with the progressive principles of social justice, freedom and equality. These measures helped the Afghan government enlist the support of the clergy and cause discord among the rebels, some of whom began to actively side with the PDPA. Despite some miscalculations by President Tanai, the Democratic Republic of Afghanistan continues to exist, and that's what counts.";
				}
				else if (this.global1.data[105] == 1 && this.global1.data[106] == 0)
				{
					this.text_fake = "Influenced by Soviet perestroika and the desire to implement a «policy of national reconciliation», the People's Democratic Party of Afghanistan changed its name to «Watan» (Fatherland), starting a retreat from Marxist-Leninist theory to democratic socialism with Islamic characteristics. The multi-party system was again legalized, however, only pro-democratic and government-loyal parties were able to take part in the subsequent elections, and as a result, the reformed PDPA received an absolute majority of votes. Due to the relative liberalization of the regime and the consolidation of the status of state religion for Islam, a small part of the opposition went to cooperate with the government, but there were still enough dissatisfied with half-hearted reforms.";
				}
				else if (this.global1.data[105] == 1 && this.global1.data[106] == 1)
				{
					this.text_fake = "Influenced by Soviet perestroika and the desire to implement a «policy of national reconciliation», the People's Democratic Party of Afghanistan changed its name to «Watan» (Fatherland), starting a retreat from Marxist-Leninist theory to democratic socialism with Islamic characteristics. The DRA government also cooperated with the «moderate part of the opposition», agreeing to hold free democratic elections and create a joint coalition government. Thanks to the relative liberalization of the regime and the proclamation of Islam as the state religion, a significant part of the opposition sided with the DRA, abandoning the guerrilla warfare. Over time, the country fully transformed into an analogue of liberal democracy with two leading parties - the Social Democratic Party «Watan» and the right-wing conservative «Jamiat-e Islami».";
				}
				else
				{
					this.text_fake = "The civil war caused serious damage to the political system of Afghanistan, so now it is very difficult to say what the country expects in the future. Nevertheless, the Democratic Republic of Afghanistan continues to exist, and that's what counts. ";
				}
			}
			else if (this.this_okno == 1 && this.global1.data[0] != 12)
			{
				this.Name.text = "ECONOMIC SYSTEM";
				this.text_fake = "";
				if (this.global1.data[43] == 1)
				{
					this.text_fake = "In spite of everything, we were able to maintain the classical planned economy with its advantages and disadvantages. Although the worldwide development of computerization and the gradual introduction of automated management systems and republican automated control system into our enterprises complicates corruption and forgery of officials,it is still too early to talk about the full computerization of the Gosplan. So forgery and corruption in Gosplan are still common, because of what certain goods are sometimes not enough, but handicraftsmen and cooperatives are gradually compensating for this deficit. State control over foreign trade provides us with independence from the external market. The economy is developing steadily, money is coming to the budget, and we have proved to the whole world that there is a real alternative to capitalism.";
				}
				else if (this.global1.data[43] == 2)
				{
					this.text_fake = "Despite the demands to reform the economy, we successfully built OGAS and implemented it in our Gosplan. Thanks to this, we were able to almost completely overcome the forgeries and corruption within it, which gave a sharp push to the development of our economy, allowing us to accomplish our economic miracle. Now our economy is impartially managed by a single automated system, so that it develops rapidly, and goods are produced enough for everyone. The people are happy, the budget is filled with money, and automated communism seems to the people more and more real.";
				}
				else if (this.global1.data[43] == 3)
				{
					this.text_fake = "Realizing the need to reform our economy, but not seeing the future in capitalism, we carried out reforms based on the Hungarian Kadar's system. Refusal to centralize planning in favor of expanding the independence of enterprises, while preserving state property on them, gave impetus to the development of our economy. The competitiveness and quality of our goods have increased, even new products have appeared for our country, and foreign trade is flourishing. However, at the same time, corruption and shadow schemes developed, dependence on the external market increased, and \"unprofitable\" enterprises either get subsidized from the budget or fall apart. However, we showed that the market can be organized under socialism and ensure the welfare of the country.";
				}
				else if (this.global1.data[43] == 4)
				{
					this.text_fake = "Obeying the wind of change, we made the transition to a free market economy. State enterprises were privatized, and control over prices and foreign trade was a thing of the past. This allowed enterprising and skilful leaders to rise and now they are moving our economy, and the people received long-awaited jeans and cola and the opportunity to organize their business. However, at the same time people looking for ways to earn money are not shy in methods, which contributes to the flowering of shadow schemes and corruption, many workers have become unemployed, and many beginning businessmen are very quickly bankrupted. Now you will have to face the problems of capitalism - growing inequality, corruption and unemployment, but the problems of the planned economy will now definitely not disturb us.";
				}
				else if (this.global1.data[43] == 5)
				{
					this.text_fake = "While public organizations began to call for more freedom for the people in the production of their own goods, in the " + this.global1.party_name[0] + ", on the wave of liberalization, the supporters of fraction of liberalization of the economy came to leadership: first, were allowed collective forms of entrepreneurship - artels, cooperatives, proprietorships, family farms instead of kolkhozes, which were given multiple freedom. The next step was the transition of state-owned enterprises to self-financing, under the guise of fighting bureaucracy. Then foreign investments were allowed inward and the opening of joint ventures with foreign companies began, as a form of using foreign capital for the benefit of our people. Gradually, the entire planned economy came to naught, and in the country, state capitalism reigned with all the working mechanisms of a market economy.";
				}
				if (this.global1.data[243] >= 3)
				{
					this.text_fake = this.text_fake + "\n" + this.dlce1.credits_text[48];
				}
			}
			else if (this.this_okno == 1)
			{
				this.Name.text = "ECONOMIC SYSTEM";
				this.text_fake = "";
				if (this.global1.data[16] == 10 && !this.global1.allcountries[7].Vyshi)
				{
					this.text_fake = "The gradual stabilization of the situation made it possible to launch full-fledged socialist reforms in the country with the subsequent installation of economic planning in the country. Small business and handicraft have been fully legalized, and in agriculture, uniting into family contracts and cooperatives is encouraged. Along with this, the government is carrying out large-scale social transformations: the construction of apartments, schools, hospitals, kindergartens. Peaceful situation and support for the USSR enabled the Afghan economy to develop stably.";
				}
				else if (this.global1.data[16] == 12 && !this.global1.allcountries[7].Vyshi)
				{
					this.text_fake = "The gradual stabilization of the situation enabled the government to launch economic reforms within the framework of socialism. Large enterprises are still in state ownership, but the production of light industry and consumer goods was completely transferred to the management of work collectives. Campaigns to support the sole peasantry are being carried out in agricultural regions, and the government is actively providing loans and incentives to rural workers to purchase equipment. The massive construction of schools, hospitals and housing complexes were able to significantly raise the standard of living of the population, and thanks to Soviet help and specialists, Afghanistan is developing more and more knowledge-intensive sectors in the national economy every year.";
				}
				else if (this.global1.data[16] == 13 && !this.global1.allcountries[7].Vyshi)
				{
					this.text_fake = "The gradual stabilization of the situation enabled the government to launch economic reforms. Most medium-sized enterprises, as well as some large enterprises built by the USSR, were privatized and transferred into the hands of entrepreneurs. In agriculture, campaigns have been launched to encourage farmers to whom the government grants loans to buy equipment. Thanks to Soviet support, mass construction of schools, hospitals and housing complexes began, the standard of living of the population is growing steadily, and the economy of Afghanistan is gradually recovering from the consequences of the civil war.";
				}
				else if (this.global1.allcountries[7].Vyshi)
				{
					this.text_fake = "The collapse of the socialist camp and the USSR seriously hit our already weak economy. The government’s post-war attempt to introduce any economic reforms led only to resistance from the opposition, which to this day considers private property a «divine gift», demanding respect for its inviolability and protection from the state. As a result, even though the state still had a regulatory role, small and medium-sized enterprises were transferred under the control of entrepreneurs, and among the peasants there was growing discontent due to low land and poor mechanization of agriculture. Despite this, our economy shows a small but steady growth, although feudal survivals still dominate in some regions.";
				}
				else if (!this.global1.allcountries[7].Vyshi)
				{
					this.text_fake = "Transformations in the socialist camp seriously hit our already weak economy. The government’s post-war attempt to introduce any economic reforms led only to resistance from the opposition, which to this day defends tribal property with a «divine gift», demanding respect for its inviolability and protection from the state. As a result, even though the state still had a regulatory role, small and medium-sized enterprises were transferred under the control of entrepreneurs, and among the peasants there was growing discontent due to low land and poor mechanization of agriculture. Despite this, our economy shows a small but steady growth, although feudal survivals still dominate the country.";
				}
			}
			else if (this.this_okno == 2)
			{
				this.Name.text = "WELFARE OF THE PEOPLE";
				this.text_fake = "";
				if (this.global1.data[44] == 1)
				{
					this.text_fake = string.Concat(new string[]
					{
						"Our leader, ",
						this.global1.politics_name[this.global1.data[11]],
						" and his brilliant rule made it possible to create a thriving economy and excellent social security, whereby all our people live in luxury and prosperity. Our country ranks first in the world in terms of living standards, even ahead of the Scandinavian countries. ",
						this.global1.politics_name[this.global1.data[11]],
						" will go down in history as one of the most successful rulers, and our citizens are happy to prosper under his wise leadership."
					});
					if (this.global1.data[58] == 1)
					{
						this.text_fake += "|The decision to modernize the oil production allowed us to significantly increase the level of imports and carry out in-depth social reforms, thanks to which the people are now very pleased.";
					}
				}
				else if (this.global1.data[44] == 2)
				{
					this.text_fake = "Our leader, " + this.global1.politics_name[this.global1.data[11]] + " and his able leadership created a developed economy and social sphere and were able to provide all people with a comfortable and stable life. Our country is proud of quality of life same with Europe, and many people from less successful countries, most of whom, dream of leaving for us. Our people are happy to have such a worthy life and the ruler who provided it.";
					if (this.global1.data[58] == 1)
					{
						this.text_fake += "|The decision to modernize the oil production allowed us to significantly increase the level of imports and carry out in-depth social reforms, thanks to which the people are now very pleased.";
					}
				}
				else if (this.global1.data[44] == 3 && this.global1.allcountries[7].isSEV)
				{
					this.text_fake = "Our leader, " + this.global1.politics_name[this.global1.data[11]] + " and his rule created an economy that allowed the people to live a more or less dignified life. And although we are lagging behind Europe, our people have food, housing, education and some luxury. The Soviet Union was able to recover from the social crisis and reach our level only by the 2010s, and our citizens at least do not have to worry about hunger and a roof over their heads.";
					if (this.global1.data[58] == 1)
					{
						this.text_fake += "|The decision to modernize the oil production allowed us to significantly increase the level of imports and carry out in-depth social reforms, thanks to which the people are now pleased.";
					}
				}
				else if (this.global1.data[44] == 3)
				{
					this.text_fake = "Our leader, " + this.global1.politics_name[this.global1.data[11]] + " and his rule created an economy that allowed the people to live a more or less dignified life. And although we are lagging behind Europe, our people have food, housing, education and some luxury. The countries of the former USSR were able to reach our level only by the 2010s, and our citizens at least do not have to worry about hunger and a roof over their heads.";
					if (this.global1.data[58] == 1)
					{
						this.text_fake += "|The decision to modernize the oil production allowed us to significantly increase the level of imports and carry out in-depth social reforms, thanks to which the people are now pleased.";
					}
				}
				else if (this.global1.data[44] == 4)
				{
					this.text_fake = "Our leader, " + this.global1.politics_name[this.global1.data[11]] + " and his rule led to the collapse of the social sphere, plunging the population into poverty. Unemployment, homelessness and periodic malnutrition have become commonplace for our citizens, and our country is forced to accept humanitarian aid from international organizations. There is no need to talk about comfort, and our citizens will forever remember these difficult times.";
				}
			}
			else if (this.this_okno == 3)
			{
				this.Name.text = "SOVIET UNION";
				this.text_fake = "";
				if (this.global1.allcountries[7].paths == 2)
				{
					this.text_fake = "Despite the reforms that have taken place in the USSR and the countries of the socialist camp, the world is still multi-polar, and renewed communism is still a decisive international force.";
				}
				else if (this.global1.allcountries[7].paths == 3)
				{
					this.text_fake = "Despite the reforms that have taken place in the USSR and the countries of the socialist camp, the Soviet Union has remained one of the undisputed hegemons in the world, and renewed communism is still a decisive international force. |Stabilizing the external situation and remaining as a powerful force, with the active support of the newly formed Security Council, consisting of pragmatic reformists, the Soviet government was able to stop internal strife and direct the people's views from the ideas of disengagement to the ideas of deep economic reforms.";
				}
				else if (this.global1.data[45] == 1)
				{
					this.text_fake = "Despite the reforms that have taken place in the USSR and the countries of the socialist camp, the Soviet Union has remained one of the undisputed hegemons in the world, and renewed communism is still a decisive international force. |Stabilizing the external situation and remaining as a powerful force, with the active support of the newly formed Security Council, consisting of pragmatic reformists, the Soviet government was able to stop internal strife and direct the people's views from the ideas of disengagement to the ideas of deep economic reforms. |Taking a cue from China and having established relations with them, President Gorbachev ruled the country for two presidential terms, himself having introduced a board limit. After the second term, he resigned his post and promised not to run for more, remaining the General Secretary of the CPSU Central Committee. However, Gorbachev's reforms, although they gave more freedom to the country and helped to rise for certain enterprising organizers, but, on the whole, the social situation continues to deteriorate year after year. |And people with great hope expects qualitative changes, linking them with the new presidential elections.";
				}
				else if (this.global1.data[45] == 2)
				{
					this.text_fake = "Despite the reforms that have taken place in the USSR and the countries of the socialist camp, the Soviet Union has remained one of the undisputed leaders in the world, and renewed communism is still a decisive international force. |All attempts made by the right-liberal opposition to carry out reforms aimed at dismantling of the Union quickly collapsed when, in spite of Yeltsin's promises to give more sovereignty to Russia and not feed other nations, the candidate from the CPSU, Nikolai Ryzhkov, won the first presidential election in the RSFSR. |With the active support of the newly formed Security Council, consisting of pragmatic reformists, the Soviet government directed the people's views to the ideas of deep economic reforms. |Taking a cue from China and having established relations with them, President Gorbachev ruled the country for two presidential terms, himself having introduced a board limit. After the second term, he resigned his post and promised not to run for more, remaining the General Secretary of the CPSU Central Committee. However, Gorbachev's reforms, although they gave more freedom to the country and helped to rise for certain enterprising organizers, but, on the whole, the social situation continues to deteriorate year after year. |And people with great hope expects qualitative changes, linking them with the new presidential elections.";
				}
				else if (this.global1.data[45] == 3)
				{
					this.text_fake = "Despite the reforms that have taken place in the USSR and the countries of the socialist camp, the world is still multi-polar, and renewed communism is still a decisive international force. |And although, under the pressure of the right-liberal public, the treaty on the transformation of the USSR into the Union of Soviet Sovereign Republics entered into force, in spite of Yeltsin's promises to give more sovereignty to Russia and not feed other nations, the candidate from the CPSU, Nikolai Ryzhkov, won the first presidential election in the RSFSR, and the new union treaty, even though it expanded the rights of the republics, but, at the same time, confirmed and consolidated the unity of the Soviet people and the inviolability of the Union. |With the active support of the newly formed Security Council, consisting of pragmatic reformists, the Soviet government directed the people's views to the ideas of deep economic reforms. |Taking a cue from China and having established relations with them, President Gorbachev ruled the country for two presidential terms, himself having introduced a board limit. After the second term, he resigned his post and promised not to run for more, remaining the General Secretary of the CPSU Central Committee. However, Gorbachev's reforms, although they gave more freedom to the country and helped to rise for certain enterprising organizers, but, on the whole, the social situation continues to deteriorate year after year, and nationalistic and traditionalist associations are increasingly raising their heads in the union republics. |And people with great hope expects qualitative changes, linking them with the new presidential elections.";
				}
				else if (this.global1.data[45] == 4)
				{
					if (!this.global1.event_done[74])
					{
						this.text_fake = "The GKChP failed, largely due to the fact that on the last day of its existence, Defense Minister Yazov decided to listen to Shaposhnikov and personally dispersed the Emergency Committee, arresting its members. Thanks to this, Gorbachev's cleansings were directed only against the members of the State Emergency Committee and their prominent supporters, but other sympathizers remained unaffected, including the Chairman of the Supreme Soviet of the USSR, Anatoly Lukyanov.| As a consequence of this, the 5th Congress of People's Deputies of the USSR adopted a decision to transform the USSR into a Union of Sovereign States, which was ratified by other republics and thwarted the plans of the Belovezhskaya conspiracy. Mikhail Gorbachev became president of the SSG.| The confrontation between the Center and the supporters of complete disengagement came to an end in October 1993, when the Supreme Soviet of the RSFSR lawfully sent President Yeltsin to retirement, and when he attempted to organize a military coup, he received no support from either the Center or the military and was forced to flee abroad . Since that moment, the political situation in the SSG has stabilized.| However, Gorbachev's reforms, although they gave more freedom to the country and helped to rise for certain enterprising organizers, but, on the whole, the social situation continues to deteriorate year after year, and nationalistic and traditionalist associations are increasingly raising their heads in the union republics, which have well hidden benevolence from the representatives of the governing bodies of some of the member states of the SSG. |And people with great hope expects qualitative changes, linking them with the new presidential elections.";
					}
					else
					{
						this.text_fake = "The GKChP failed, largely due to the fact that on the last day of its existence, Defense Minister Yazov decided to listen to Shaposhnikov and personally dispersed the Emergency Committee, arresting its members. Thanks to this, Gorbachev's cleansings were directed only against the members of the State Emergency Committee and their prominent supporters, but other sympathizers remained unaffected, including the Chairman of the Supreme Soviet of the USSR, Anatoly Lukyanov. The confrontation between the Center and the supporters of complete disengagement came to an end in October 1993, when the Supreme Soviet of the RSFSR lawfully sent President Yeltsin to retirement, and when he attempted to organize a military coup, he received no support from either the Center or the military and was forced to flee abroad . Since that moment, the political situation in the SSG has stabilized.| However, Gorbachev's reforms, although they gave more freedom to the country and helped to rise for certain enterprising organizers, but, on the whole, the social situation continues to deteriorate year after year, and nationalistic and traditionalist associations are increasingly raising their heads in the union republics, which have well hidden benevolence from the representatives of the governing bodies of some of the member states of the SSG. |And people with great hope expects qualitative changes, linking them with the new presidential elections.";
					}
				}
				else if (this.global1.data[45] == 5)
				{
					this.text_fake = "The GKChP failed and the punishing hand of Gorbachev befell on all active supporters and simply sympathizing with socialist ideas and the State Emergency Committee. Mikhail Sergeyevich, destroyed the undermined confidence in the Soviet regime, liquidated the remnants of at least some influential Soviet government, and without any kind of reaction accepted the Belovezhskaya conspiracy as an accomplished affair.| The organizers of the Belovezhskaya conspiracy prepared for the escape and were surprised by this outcome gladly deceive their peoples and declare the continuity of the Soviet Union by the Commonwealth of Independent States, which, as a treaty, is only a nominal stroke of the pen, which put a fat point on the outcome of the referendum on the preservation and transformation of the USSR.| The multiple decline in the economy and in the standard of living, the unsuccessful reforms and the sharp increase in corruption and crime will now remain in the memory of the former Soviet people forever, just like the illegal coup carried out by Yeltsin in October 1993...";
				}
				else if (this.global1.data[45] == 6)
				{
					this.text_fake = string.Concat(new object[]
					{
						"The State Emergency Committee was able to take control of all TV and radio stations and prevent radical journalists from speaking out, even arresting them. Boris Yeltsin died during a shootout between his guard and the KGB detachment, who arrived for his arrest, since he did not want to surrender. Headed by General Lebed, the storming of the opposition's stronghold - the building of the Supreme Council - led to the final stabilization of the power of the Emergency Committee.|In his speeches, the leader of the State Emergency Committee Yanayev declared his adherence to the ideals of Perestroika, announcing to the whole world that Gorbachev was ill and could no longer rule the country, and in the future the first nation-wide presidential elections will be held. At the same time, the State Emergency Committee condemned the attempt to disengage the Soviet Union, calling it an attempt to go against the will of the people, who supported the unity of the USSR at the March referendum|During the whole 1992-",
						this.global1.data[21] + 1,
						", major criminal cases of the state level were held to condemn corrupt officials, scammers and state embezzlers, and with the help of brute force and well-coordinated work of the special services, all the rebel's hotbeds were finally suppressed.|And only in August ",
						this.global1.data[21] + 1,
						" the promised presidential elections began..."
					});
				}
				else if (this.global1.data[45] == 7)
				{
					this.text_fake = string.Concat(new object[]
					{
						"The State Emergency Committee was able to take control of all TV and radio stations and prevent radical journalists from speaking out, even arresting them. Boris Yeltsin died during a shootout between his guard and the KGB detachment, who arrived for his arrest, since he did not want to surrender. Headed by General Lebed, the storming of the opposition's stronghold - the building of the Supreme Council of RSFSR - led to the final stabilization of the power of the Emergency Committee.|In his speeches, the leader of the State Emergency Committee Alksnis declared that Gorbachev himself has betrayed the ideals of Perestroika, announcing to the whole world that after the funeral of Gorbachev the first presidential elections will be held, but he will be elected by members of the Supreme Soviet. At the same time, the State Emergency Committee condemned the attempt to disengage the Soviet Union, calling it an attempt to go against the will of the people.|During the whole 1992-",
						this.global1.data[21] + 1,
						", major criminal cases of the state level were held to condemn corrupt officials, scammers and state embezzlers, and with the help of brute force and well-coordinated work of the special services, all the rebel's hotbeds were finally suppressed.|And only in August ",
						this.global1.data[21] + 1,
						" the promised presidential elections began..."
					});
				}
				else if (this.global1.data[45] == 8)
				{
					if (this.global1.data[221] == 1)
					{
						this.text_fake = "After the failure of the State Emergency Committee and the arrest of key conspirators, the fate of the new Union Treaty seemed vague. However, Mikhail Gorbachev managed to enlist the support of some Russian reformers and republican elites, agree on a draft agreement with the leadership of 9 republics and convince them to sign it. On December 31, 1991, the Soviet Union officially ceased to exist, and its legal successor was the confederate Union of Sovereign States (USS) consisting of Russia, Ukraine (forced to accept remaining within the USS), Belarus, Azerbaijan, Kazakhstan, Uzbekistan, Kyrgyzstan, Tajikistan and Turkmenistan. The Center retained powers in the region. defense (including the management of the nuclear arsenal), security, tax and customs policy, everything else was either transferred to the joint jurisdiction of Moscow and the republics, or went into place. Immediately after its creation, the new Union found itself embroiled in conflicts with the outgoing republics, causing economic chaos. “wars of sovereignty” and confrontation with the Russian leadership, which considered the concessions made by Gorbachev insufficient. However, since 1996, the situation began to gradually stabilize: Transnistria, South Ossetia and Abkhazia became part of the GCC, the threat from Nagorno-Karabakh (which lost ¾ of its territory) was neutralized, the country’s economy confidently moved towards a socially oriented market, fortunately, the main troublemakers of the former Union - Boris Yeltsin and Leonid Kravchuk - died in a tragic plane crash, and their successors turned out to be more willing to negotiate. However, even 10 years later, the GCC economy cannot return to the level of 1990, the country continues to feel the consequences of wars and ethnic conflicts, bureaucracy, corruption and economic inequality have increased many times, and enterprising people complain about “excessive pressure on private initiative.” |And the population of the still huge country expects qualitative changes with great hope, linking them with Mikhail Gorbachev’s departure from politics and the results of the new presidential elections.";
					}
					else
					{
						this.text_fake = "After the failure of the State Emergency Committee and the arrest of key conspirators, the fate of the new Union Treaty seemed vague. However, Mikhail Gorbachev managed to enlist the support of some Russian reformers and republican elites, agree on a draft agreement with the leadership of 9 republics and convince them to sign it. On December 31, 1991, the Soviet Union officially ceased to exist, and its legal successor was the confederate Union of Sovereign States (USS) consisting of Russia, Ukraine (forced to accept remaining within the USS), Belarus, Azerbaijan, Kazakhstan, Uzbekistan, Kyrgyzstan, Tajikistan and Turkmenistan. The Center retained powers in the region. defense (including the management of the nuclear arsenal), security, tax and customs policy, everything else was either transferred to the joint jurisdiction of Moscow and the republics, or went into place. Immediately after its creation, the new Union found itself embroiled in conflicts with the outgoing republics, causing economic chaos. “wars of sovereignty” and confrontation with the Russian leadership, which considered the concessions made by Gorbachev insufficient. However, since 1996, the situation began to gradually stabilize: Transnistria, South Ossetia and Abkhazia became part of the GCC, the threat from Nagorno-Karabakh (which lost ¾ of its territory) was neutralized, the country’s economy confidently moved towards a socially oriented market, and the main troublemakers in the new Union - Boris Yeltsin and Leonid Kravchuk - left the stage, having lost elections in their republics (a few months later, Yeltsin died suddenly from a sudden heart attack). However, even 10 years later, the GCC economy cannot return to the level of 1990, the country continues to feel the consequences of wars and ethnic conflicts, bureaucracy, corruption and economic inequality have increased many times, and enterprising people complain about “excessive pressure on private initiative.” |And the population of the still huge country expects qualitative changes with great hope, linking them with Mikhail Gorbachev’s departure from politics and the results of the new presidential elections.";
					}
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(134);
					}
				}
				else if (this.global1.data[45] == 9)
				{
					this.text_fake = "After the failure of the State Emergency Committee and the arrest of key conspirators, the fate of the new Union Treaty seemed vague. Mikhail Gorbachev managed to enlist the support of some Russian reformers and republican elites, agree on a draft agreement with the leadership of 9 republics and convince them to sign it... however, already on the day of the ceremony in the Kremlin, Leonid Kravchuk and Azerbaijani President Ayaz Mutalibov refused to initial the agreement and demanded that all powers remaining with Moscow (except for the management of the nuclear arsenal) be transferred to the joint jurisdiction of the Center and the republics. In order to prevent the collapse of the entire Novo-Ogarevo process, Gorbachev accepted this condition and on January 10. In 1992, in Almaty, a new Union Treaty was finally signed. The Soviet Union officially ceased to exist, and its legal successor was the confederate Union of Sovereign States (USS). New Union found itself embroiled in conflicts with the outgoing republics, economic chaos from the “war of sovereignties” and confrontation with the Russian leadership, which, against the background of the total weakening of the Center in 1993, entered the forceful phase - the Ministry of Internal Affairs and the Ministry of Bank of the Russian Federation blocked administrative buildings in Moscow and provoked clashes with units of the Internal Troops sent by Gorbachev to relieve the blockade. Yeltsin, who had practically won, suddenly died from alcohol poisoning, which allowed Gorbachev to come to an agreement with the more moderate Vice President of Russia, Rutsky. 5 years later, the GCC is a patchwork quilt torn by contradictions - all republics have created their own central banks and introduced their own currencies, the Russian language has lost its status as a state language everywhere except Russia and Belarus, even scientific and cultural contacts are on the decline. From Kyiv and Baku, voices of supporters of transforming the GCC into a “commonwealth of independent states”, they are restrained by the ongoing conflict between Azerbaijan and Western-backed Armenia and the active attempts of the Crimean authorities to withdraw from Ukrainian jurisdiction.";
				}
				else if (this.global1.data[45] == 10)
				{
					this.text_fake = "On 10 January 1992, a meeting took place in Novo-Ogaryovo between Mikhail Gorbachev and the leaders of Russia, Belarus, Azerbaijan, and the Central Asian republics, during which the last agreed draft of the new Union Treaty was signed. This treaty transformed the USSR into an amorphous confederation of sovereign republics known as the Union of Sovereign States. On the same day, Ukrainian President Leonid Kravchuk announced the transfer of all army, Ministry of Internal Affairs, and State Security Committee units located in the territory of his republic under the jurisdiction of Kyiv, and by his decree, he established the Armed Forces and National Guard of Ukraine. Attempts by loyalist Chekists to seize control of the nuclear weapons located in the territory of the seceding republic began, with plans to shift its command from Moscow to Kyiv. On the night of 21-22 February, Kravchuk issued an ultimatum to President Gorbachev and the leaders of the countries of the Union of Sovereign States, demanding an end to the blockade of Ukraine, threatening “consequences that you have never faced in your history”. A few hours later, an emergency meeting was convened at the UN, where the permanent representative of the Union, Yuli Vorontsov, provided evidence of the dangerous policies of the Ukrainian authorities, which included mass attempts to crack the secret codes of the nuclear weapons located in the now former Soviet republic, and called for the urgent establishment of a peacekeeping mission in Ukraine and its denuclearisation. Remarkably, the resolution was supported by three permanent members of the Security Council and was adopted in record time. A few days later, after the Ukrainian authorities refused to surrender the weapons, an international peacekeeping force, which included soldiers from the USA and Germany, was deployed to its territory. A new war in Europe had begun, but no one could have imagined that it would unfold in such a manner.";
				}
				else if (this.global1.data[45] == 11)
				{
					this.text_fake = "On January 10, 1992, in Novo-Ogarevo, Mikhail Gorbachev met with the leaders of Russia, Belarus, Azerbaijan and the Central Asian republics, at which the last agreed draft of the new Union Treaty was signed, which transformed the USSR into an amorphous confederation of sovereign republics - the Union of Sovereign States. However, Ukrainian President Leonid Kravchuk refused to join the agreement and conditioned the membership of the republic he headed in the new Union on the elimination of all central bodies and the consultative nature of such a union, which would not interfere with the course towards European integration. Boris Yeltsin and Stanislav Shushkevich supported the Ukrainian leader, which, ultimately, ultimately led to the collapse of the Novo-Ogarevo process - on January 24, Mikhail Gorbachev resigned as president of the GCC and left the Kremlin, transferring his powers to Yeltsin. On February 8, Russia, Ukraine and Belarus unilaterally announced the denunciation of the Union Treaty and the creation of the Commonwealth of Independent States. , which is formal in nature. By the end of 1992, the republics of Central Asia, Azerbaijan, as well as Armenia, Moldova and Georgia joined it. Gorbachev’s policy of constant concessions did not save the Union, but only prolonged its agony for a year.";
				}
			}
			else if (this.this_okno == 4)
			{
				this.Name.text = "SOVIET UNION";
				this.text_fake = "";
				if (this.global1.allcountries[7].paths == 2)
				{
					this.text_fake = this.dlce1.credits_text[46];
				}
				else if (this.global1.allcountries[7].paths == 3)
				{
					this.text_fake = this.dlce1.credits_text[47];
				}
				else if (this.global1.data[45] == 1)
				{
					if (this.global1.data[51] + this.global1.data[52] * 3 > 10)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(24);
						}
						this.text_fake = "|<color=red>CALCULATING...|</color>";
						this.text_fake += "<color=blue>Boris Pugo</color>|";
						this.text_fake += "In the new presidential election, Boris Pugo, the former Minister of Internal Affairs, came to power and immediately launched a huge campaign against corruption and market machinations, as well as mass persecution of nationalists, including the Baltic nationalists, being himself a Latvian by nationality. The next step was to force the shift of the vector of market reforms to the Chinese analogue of the bird-cage reforms, with the multiple strengthening of state intervention. Disagreed with this, Gorbachev resigned for health reasons.| The sharp drop in the level of corruption and speculation, the purging of state structures and the transition to more effective methods of economic reforms are already yielding multiple benefits in the form of a rise in the social, economic and spiritual spheres.";
					}
					else
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(26);
						}
						this.text_fake = "|<color=red>CALCULATING...|</color>";
						this.text_fake += "<color=blue>Vladimir Zhirinovsky</color>|";
						this.text_fake += "In the new presidential election, Vladimir Zhirinovsky, the first non-member of the CPSU since Perestroika, came to power. His promises were populist: the honest privatization of unprofitable state-owned enterprises after the restructuring of the economy and the increase in social expenses due to this, the widespread fight against corruption and bureaucracy, and the return of the former greatness of the Soviet Union on the international arena.| However, having come to power, Zhirinovsky did not make huge reassignments in the governing apparatus and the CPSU representatives still remain in the majority.| His rule Zhirinovsky began with an inaugural speech, in which he loudly and rudely attacked the supporters of the disengagement and external enemies. This already gave rise to a large-scale campaign against local nationalism and an avalanche of Russophile propaganda, which aroused negative criticism from Gorbachev and marked the beginning of an official split in the Soviet leadership...";
					}
				}
				else if (this.global1.data[45] == 2)
				{
					if (this.global1.data[51] + this.global1.data[52] * 3 > 10)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(24);
						}
						this.text_fake = "|<color=red>CALCULATING...|</color>";
						this.text_fake += "<color=blue>Boris Pugo</color>|";
						this.text_fake += "In the new presidential election, Boris Pugo, the former Minister of Internal Affairs, came to power and immediately launched a huge campaign against corruption and market machinations, as well as mass persecution of nationalists, including the Baltic nationalists, being himself a Latvian by nationality. The next step was to force the shift of the vector of market reforms to the Chinese analogue of the bird-cage reforms, with the multiple strengthening of state intervention. Disagreed with this, Gorbachev resigned for health reasons.| The sharp drop in the level of corruption and speculation, the purging of state structures and the transition to more effective methods of economic reforms are already yielding multiple benefits in the form of a rise in the social, economic and spiritual spheres.";
					}
					else
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(25);
						}
						this.text_fake = "|<color=red>CALCULATING...|</color>";
						this.text_fake += "<color=blue>Gennady Zyuganov</color>|";
						this.text_fake += "In the new presidential election, Gennady Zyuganov came to power. His promises were: support of religious freedom, in particular Orthodoxy, honest privatization of unprofitable state-owned enterprises after economic restructuring and increase of social expenses due to this, which should lead to improvement of the people's financial situation.| And he started with the opening of many SEZ in the country, inviting of foreign investors and selling of cheap labour force to them. The next step is the fulfillment of the requirements for the USSR membership in the WTO...";
					}
				}
				else if (this.global1.data[45] == 3)
				{
					if (this.global1.data[51] + this.global1.data[52] * 3 > 10)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(25);
						}
						this.text_fake = "|<color=red>CALCULATING...|</color>";
						this.text_fake += "<color=blue>Gennady Zyuganov</color>|";
						this.text_fake += "In the new presidential election, Gennady Zyuganov came to power. His promises were: support of religious freedom, in particular Orthodoxy, honest privatization of unprofitable state-owned enterprises after economic restructuring and increase of social expenses due to this, which should lead to improvement of the people's financial situation.| And he started with the opening of many SEZ in the country, inviting of foreign investors and selling of cheap labour force to them. The next step is the fulfillment of the requirements for the USSR membership in the WTO...";
					}
					else
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(26);
						}
						this.text_fake = "|<color=red>CALCULATING...|</color>";
						this.text_fake += "<color=blue>Vladimir Zhirinovsky</color>|";
						this.text_fake += "In the new presidential election, Vladimir Zhirinovsky, the first non-member of the CPSU since Perestroika, came to power. His promises were populist: the honest privatization of unprofitable state-owned enterprises after the restructuring of the economy and the increase in social expenses due to this, the widespread fight against corruption and bureaucracy, and the return of the former greatness of the Soviet Union on the international arena.| However, having come to power, Zhirinovsky did not make huge reassignments in the governing apparatus and the CPSU representatives still remain in the majority.| His rule Zhirinovsky began with an inaugural speech, in which he loudly and rudely attacked the supporters of the disengagement and external enemies. This already gave rise to a large-scale campaign against local nationalism and an avalanche of Russophile propaganda, which aroused negative criticism from Gorbachev and marked the beginning of an official split in the Soviet leadership...";
					}
				}
				else if (this.global1.data[45] == 4)
				{
					if (this.global1.data[51] + this.global1.data[52] * 3 > 10)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(27);
						}
						this.text_fake = "|<color=red>CALCULATING...|</color>";
						this.text_fake += "<color=blue>Alexander Lebed</color>|";
						this.text_fake += "In the new presidential election, Alexander Lebed, the first non-member of the CPSU since Perestroika, came to power, supported by mostly Russian-speaking population, who heads his own nationalist Russophile party. His promises were populist: the honest privatization of unprofitable state-owned enterprises after the restructuring of the economy and the increase in social expenses due to this, the widespread fight against corruption and bureaucracy, and the return of the former greatness of the country on the international arena.| Having come to power, Alexander completely retired the entire old composition of the country's top governing bodies and replaced them with his supporters. At the same time, using popularity and having huge connections among the officers of the Soviet army, he began training and conducting military operations against the disgruntled regional leaders who raised their heads.| His rule Lebed began with an inaugural speech, in which he loudly and rudely attacked the supporters of the disengagement and external enemies. This already gave rise to a large-scale campaign against local nationalism and an avalanche of Russophile propaganda...";
					}
					else
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(28);
						}
						this.text_fake = "|<color=red>CALCULATING...|</color>";
						this.text_fake += "<color=blue>Grigory Yavlinsky</color>|";
						this.text_fake += "In the new presidential election, Grigory Yavlinsky, a former member of the CPSU and leader of his own left-liberal \"Yabloko\" Party, as well as the current deputy chairman of the Council of Ministers of the SSG, came to power.|Having come to power in the wake of promises to implement the program of reforming the SSG in 500 days, abandoned by the Communists, with the integration of the Union as a whole into the international economy, Yavlinsky considers it important to strengthen market ties between the member states of the SSG and sees his rule as a lever to transform the SSG into a treaty, similar to the European Union, which definitely does not appeal to regional leaders who do not want to share economic autonomies and embezzlement rights from their budgets. | With the coming to power, under the leadership of Yavlinsky the formation of the Committee for Economic Reforms begins, the old composition of the governing bodies of the USSR is being retired, open hearings and loud persecution of corrupt people begin.|The people are eagerly awaiting the introduction of a real socially-oriented market economy...";
					}
				}
				else if (this.global1.data[45] == 5)
				{
					this.text_fake = "<color=blue>REAL HISTORY</color>|";
				}
				else if (this.global1.data[45] == 6)
				{
					if (this.global1.data[51] + this.global1.data[52] * 3 > 10)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(24);
						}
						this.text_fake = "|<color=red>CALCULATING...|</color>";
						this.text_fake += "<color=blue>Boris Pugo</color>|";
						this.text_fake += "In the new presidential election, Boris Pugo, the former Minister of Internal Affairs, came to power and immediately launched a huge campaign against corruption and market machinations, as well as mass persecution of nationalists, including the Baltic nationalists, being himself a Latvian by nationality. The next step was to force the shift of the vector of market reforms to the Chinese analogue of the bird-cage reforms, with the multiple strengthening of state intervention. And exactly after six months Gorbachev died tragically on the operating table...| The sharp drop in the level of corruption and speculation, the purging of state structures and the transition to more effective methods of economic reforms are already yielding multiple benefits in the form of a rise in the social, economic and spiritual spheres.";
					}
					else
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(25);
						}
						this.text_fake = "|<color=red>CALCULATING...|</color>";
						this.text_fake += "<color=blue>Gennady Zyuganov</color>|";
						this.text_fake += "In the new presidential election, Gennady Zyuganov came to power. His promises were: support of religious freedom, in particular Orthodoxy, honest privatization of unprofitable state-owned enterprises after economic restructuring and increase of social expenses due to this, which should lead to improvement of the people's financial situation.| And he started with the opening of many SEZ in the country, inviting of foreign investors and selling of cheap labour force to them. His reforms also imply the strengthening of market integration of the SSG member states and support for the free movement of capital and labor force across the entire territory of the SSG, and hence the strengthening of ties within the Union. |The next step is the fulfillment of the requirements for the USSR membership in the WTO...|Gorbachev, who after the dissolution of the Emergency Committee again had the opportunity to speak and publish freely, supported Zyuganov's actions and, soon, was even appointed his personal adviser.";
					}
				}
				else if (this.global1.data[45] == 7)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(29);
					}
					this.text_fake = "<color=blue>Viktor Alksnis</color>|";
					this.text_fake += "The Supreme Soviet elected Viktor Alksnis as the new President, as expected, and after he had come to power, he immediately launched a huge campaign against corruption and market machinations, as well as mass persecution of nationalists, including the Baltic nationalists, being himself a Latvian by nationality. The next step was to force the shift of the vector of market reforms to the Chinese analogue of the bird-cage reforms, with the multiple strengthening of state intervention.| The sharp drop in the level of corruption and speculation, the purging of state structures and the transition to more effective methods of economic reforms are already yielding multiple benefits in the form of a rise in the social, economic and spiritual spheres.";
				}
				else if (this.global1.data[45] == 8)
				{
					if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[52] * 50 >= 1200)
					{
						bool iron_and_blood = this.global1.iron_and_blood;
						this.text_fake = "|<color=red>CALCULATING...|</color>";
						this.text_fake = "<color=blue>Victor Tyulkin</color>|";
						this.text_fake += "The presidential election was won by a single candidate from the left opposition - Viktor Tyulkin, a member of the CPSU and the Communist Party of the RSFSR, who had previously sharply criticized Gorbachev. Having come to power with promises of repeatedly strengthening social policy and strengthening relations between the republics, Tyulkin first of all began to put pressure on the local elites, using against them the “anti-bureaucratic” and “yogurt” technologies spied on by Slobodan Milosevic, as a result of which he managed to replace the leadership of Russia, Ukraine, Kazakhstan and Kyrgyzstan with his own people. Restoring cooperative ties between enterprises, putting things in order. logistics and regulatory documents, the full implementation of the principle of “four freedoms” made it possible to more or less restore a single economic space and by 2008 bring the GCC to 4th place in Europe in terms of GDP growth. In foreign policy, a gradual rapprochement with the PRC began, while maintaining (to what extent. this is possible) trusting relations with Western countries, thanks to which it was possible to obtain guarantees from NATO of its non-expansion into the post-Soviet space. Under Tyulkin, Armenia became part of the GCC, which made it possible to resolve the Nagorno-Karabakh problem and significantly defuse the situation in Transcaucasia. Thanks to contacts with China, the Union keeps up with scientific and technological progress and begins to introduce its own Internet, which contributed to the democratization of public life. \nHowever, over the years, Tyulkin’s policy becomes less and less “red” and more and more conservative-Russophile, which begins to cause deep discontent in Ukraine and Central Asia.";
					}
					else if ((double)this.global1.allcountries[17].Westalgie + (double)this.global1.data[7] * 0.9 + (double)(this.global1.data[52] * 50) >= 800.0)
					{
						bool iron_and_blood2 = this.global1.iron_and_blood;
						this.text_fake = "|<color=red>CALCULATING...|</color>";
						this.text_fake = "<color=blue>Boris Gromov</color>|";
						this.text_fake += "Former Soviet general Boris Gromov became the new president of the SSG, supported by a broad national-patriotic coalition and promising “law and order.” Under the pretext of fighting organized crime, the powers of the police and SMEs were sharply expanded, which provoked a conflict between Gromov and the republican elites, however, he managed to gradually eliminate the most influential figures of his opponents from politics and replace them with security forces loyal to him. Every year, the state’s offensive against the opposition increased, as a result of which the entire political field was virtually cleared, and almost all opposition leaders were either killed or arrested. or forced to emigrate. Economic policy was characterized by the creation of “nationally-oriented” capital through the privatization of assets by officials close to the president, usually of Slavic origin, with formal state control over new corporations. In foreign policy, Gromov began a line of non-recognition of the results of the Cold War and maintaining destabilization. within the EU by financing any anti-globalist forces in its countries (from the far right to the remnants of the old communist parties). By the mid-2000s, the SSG had actually turned into a large military camp, which began to forcefully revise the borders of the post-Soviet space: Georgia was occupied in 2008, Moldova was occupied a year later, Armenia was annexed in 2014, and in 2018 as a result of a “special operation” Mongolia is captured. \nThe aggressive expansion of the GCC provoked the entry of all its western neighbors into NATO, a significant cooling of relations with China and the introduction of numerous economic sanctions against the Union, however, Gromov’s regime feels quite confident - unlike the population becoming impoverished every year, intimidated by repressions and expecting in the near future the beginning of the Third World War. In turn, official propaganda is already calling for a “Russian campaign” in the Baltic states and the final restoration of the 1985 borders...";
					}
					else
					{
						bool iron_and_blood3 = this.global1.iron_and_blood;
						this.text_fake = "|<color=red>CALCULATING...|</color>";
						this.text_fake = "<color=blue>Anatoly Sobchak</color>|";
						this.text_fake += "Contrary to forecasts indicating the victory of General Boris Gromov, the new leader of the SSG was Leningrad State University professor and ex-mayor of Leningrad Anatoly Sobchak, who promised to integrate the Union into Western civilization and make a transition to a democratic society and a free market. However, the new president’s policy with from the very beginning met resistance from the republican elites and conservative forces, which led to the half-hearted nature of the reforms carried out: despite the large-scale privatization of 1995-1999, the state retained key enterprises of the military-industrial complex and fuel and energy complex, the multi-party system was significantly limited by complicated requirements for the registration of new parties, legislation on The media, rallies and strikes have remained virtually unchanged since Perestroika. In foreign policy, Sobchak set a course for continuing the New Political Thinking, however, the GCC's applications for membership in NATO and the EU were rejected, and for membership in the WTO, it was stipulated by a large number of requirements, the fulfillment of which. opposed by nationalist and neo-communist forces. By the mid-2000s, the USG remained a state with a hybrid regime and a semi-market economy, and the opposition criticized the increasingly authoritarian president for exorbitant corruption, nepotism, and the growing neoliberal social policy (for example, in 2005, Sobchak, in compliance with WTO requirements, began implementing pension reform, which caused mass protests in the Slavic republics) and ignoring the shocking behavior of his daughter Ksenia, surrounded by a trail of scandals. \nAgainst the backdrop of the 2008 economic crisis, mass protests began in Kyiv under the slogans of Ukraine’s withdrawal from the GCC, during which Sobchak unexpectedly died of heart failure. His closest ally, Vladimir Putin, became acting president, declaring his intention to protect the “Russian world” from the encroachments of “internal liberals and real fascists”.";
					}
				}
				else if (this.global1.data[45] == 9)
				{
					bool iron_and_blood4 = this.global1.iron_and_blood;
					this.text_fake = "|<color=red>CALCULATING...|</color>";
					this.text_fake = "<color=blue>Gavriil Popov</color>|";
					this.text_fake += "At the last presidential election, the former mayor of Moscow, Gavriil Popov, unexpectedly won - largely due to the fact that the opponents Yuri Belov (Communist Party of the Russian Federation) and Oleg Malyshkin (LDPSS) were not known to voters at all. Popov presented a centrist program «evolutionary transition», which began with a significant expansion of the bureaucratic apparatus and the gradual neutralization with its help of the republican elites. In the economy, a course was taken to unite the remnants of allied enterprises into state corporations and large conglomerates, whose representatives became closely associated with officials and security forces, while maintaining the minimum possible level of social spending. In foreign policy, Popov, as an adherent of the course towards European integration, pursued a pro-European line and welcomed it. accession of the Baltic countries to the EU. At the same time, in the cultural sphere, a course was pursued towards maximum liberalization - so much so that the GCC became one of the first European countries to legalize same-sex marriage and the use of soft drugs (at the same time, Popov’s sensational initiative to decriminalize prostitution did not meet with understanding even among liberals and was rejected). Thanks to the stabilization of the economy and high prices for hydrocarbons, the standard of living of the vast majority of the population of the Union even exceeded the Soviet level, but the price for this was the country being entangled in an octopus of bureaucracy (the number of officials was 13 times higher than in the USSR, with a smaller territory) and corruption. Starting from the mid-2000s, the Slavic republics of the GCC began to be rocked by large rallies under anti-corruption and anti-bureaucratic slogans, and in the republics of Central Asia, dissatisfied with the nationalist rhetoric of the president, the transition to the Latin alphabet began and “language patrols” appeared. It seems that the Union cannot avoid a large-scale crisis again...";
				}
				else if (this.global1.data[45] == 10)
				{
					bool iron_and_blood5 = this.global1.iron_and_blood;
					this.text_fake = "<color=red>DAWN OF A NEW EUROPEAN WAR</color>|";
				}
				else if (this.global1.data[45] == 11)
				{
					bool iron_and_blood6 = this.global1.iron_and_blood;
					this.text_fake = "<color=blue>A TRUE STORY FROM A YEAR AGO</color>|";
				}
			}
			else if (this.this_okno == 5)
			{
				this.Name.text = "SCIENTIFIC ACHIEVEMENTS";
				this.text_fake = "";
				if (this.global1.data[0] != 10 && this.global1.data[0] != 12 && this.global1.data[0] != 18 && (this.global1.data[0] < 49 || this.global1.data[0] > 51))
				{
					if (((this.global1.data[42] == 2 && this.global1.science[1]) || (this.global1.science[2] && this.global1.data[42] != 7 && this.global1.data[17] != 17)) && !this.global1.allcountries[this.global1.data[0]].Vyshi)
					{
						this.text_fake = "We successfully researched and implemented new methods of surveillance of the citizens in order to protect our state. Surveillance cameras, wiretaps and electronic databases for every citizen allow us to know almost everything about people of interest to us. And, although sometimes these measures create inconvenience to the people and some do not like the idea that they are being watched, we would still have to fight against internal and external enemies. Thanks to our system, we can do this as quickly and efficiently as possible without affecting on the innocent.|";
					}
					else if ((this.global1.science[1] && (this.global1.data[14] >= 3 || this.global1.allcountries[this.global1.data[0]].Vyshi)) || this.global1.science[2])
					{
						this.text_fake = "Despite certain progress in the development of methods of surveillance of the population, our further moves towards liberalization forced us to abandon the project. The ideological liberals and reformers, whose values became one of the most important for us, did not want to endure such a violation of human rights, no matter what their goals were. We will have to use other methods of protecting our state from internal and external enemies.|";
					}
					else
					{
						this.text_fake = "|There is no progress in establishing total surveillance.|";
					}
					if ((this.global1.data[43] == 2 && this.global1.science[4]) || (this.global1.science[5] && this.global1.data[43] == 1 && this.global1.data[18] <= 20))
					{
						if (this.global1.data[44] <= 2)
						{
							this.text_fake += "|Based on the research of Glushkov and Kitov, we successfully developed and built OGAS, introducing it into our Gosplan. This centralized system, taking into account our production capabilities, resources and the dynamics of needs, now manages all our enterprises, eradicating the forgery, despite the protests of some conservatives. This allows our economy to rapidly increase its growth rates, and some are already confidently predicting the onset of the future of automated communism.|";
						}
						else
						{
							this.text_fake += "|Based on the research of Glushkov and Kitov, we successfully developed and built OGAS, introducing it into our Gosplan. This centralized system, taking into account our production capabilities, resources and the dynamics of needs, now manages all our enterprises, eradicating the forgery, despite the protests of some conservatives. This allows our economy to rapidly increase its growth rates and keep up with the times in the world military race.|";
						}
					}
					else if ((this.global1.science[4] || this.global1.science[5]) && this.global1.data[43] <= 2)
					{
						this.text_fake += "|Despite some progress in the development of computerization and its introduction into our economy, before the development of OGAS, we have not get around to it . As a result (including those taken under the pressure of conservatives) it was decided to limit the introduction of automated control systems and republican automated control system, which, of course, increased the growth of our economy and helped fight corruption. However, the dreams of cybernetics in the 1950s about building a single centralized automated system capable of eradicating the forgery and ensuring the most effective production still remain a dream.|";
					}
					else if ((this.global1.science[4] || this.global1.science[5]) && this.global1.data[43] > 2)
					{
						this.text_fake += "|Despite the development of computerization and its introduction into our economy, further economic reforms towards the free market have put an end to the construction of OGAS. Separate private companies competing for profit did not need a single centralized system that takes into account our production capabilities, resources and the dynamics of needs. Work on OGAS was curtailed, and it remained a bold dream from the past.|";
					}
					else
					{
						this.text_fake += "|There is no progress in implementation of automation.|";
					}
					if ((this.global1.data[42] != 9 && this.global1.data[42] != 10 && this.global1.data[42] != 6 && this.global1.data[42] != 5 && this.global1.data[42] != 2 && this.global1.science[5] && this.global1.science[7]) || (this.global1.science[8] && this.global1.data[42] != 5 && this.global1.data[42] != 6 && this.global1.data[42] != 2 && ((this.global1.data[42] != 9 && this.global1.data[14] <= 0) || this.global1.data[42] == 9) && this.global1.data[42] != 10))
					{
						this.text_fake += "|We have successfully developed and introduced advanced genetics into our agriculture and medicine. This allowed us to obtain much more harvests, improving the taste and persistence of cultivated products to environmental influences, and fighting more effectively with diseases, helping to determine their origin. Our scientists have endless perspectives, up to the cultivation of artificial organs and products.|";
					}
					else if ((this.global1.science[7] || this.global1.science[8]) && (this.global1.data[42] == 9 || this.global1.data[42] == 2))
					{
						this.text_fake += "|The development of genetics has caused disagreements and fierce arguments in our scientific and party communities. As a result, under the pressure of some scientists, along with conservative public and party figures, new methods of genetics were recognized as pseudoscientific, contradictory to materialism and propagandizing racism and eugenics. New research in genetics soon stalled, some scientists deprived of their degrees, some moved to other areas or were forced to abandon their views on genetics.|";
					}
					else if (this.global1.science[7] || this.global1.science[8])
					{
						this.text_fake += "|The development of genetics has caused great concern among conservative social and political figures and the clergy. As a result, under their pressure, genetics was recognized as contradictory to human nature, tradition and divine plan and was forbidden, as unethical pseudoscience. Studies in this area have been curtailed, forcing scientists to hide their views and reorganize into other areas of science.|";
					}
					else
					{
						this.text_fake += "|There is no progress in development of genetics.|";
					}
				}
				else if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
				{
					if (this.global1.science[0] && this.global1.science[1] && this.global1.science[7] && (this.global1.data[42] == 2 || (this.global1.data[42] != 7 && this.global1.data[17] != 17)) && !this.global1.allcountries[this.global1.data[0]].Vyshi)
					{
						this.text_fake = this.yug1.science_text[41];
					}
					else if (this.global1.science[0] && this.global1.science[1] && this.global1.science[7])
					{
						this.text_fake = this.yug1.science_text[42];
					}
					else
					{
						this.text_fake = this.yug1.science_text[43];
					}
					bool flag = false;
					for (int i = 0; i < this.yug1.gameState.yugcountries.Length; i++)
					{
						if (this.yug1.gameState.yugcountries[i].is_exist && i != this.yug1.gameState.player)
						{
							flag = true;
							break;
						}
					}
					if (this.global1.science[6] && this.global1.science[8] && (this.global1.data[135] > 7 || !flag || this.global1.data[114] != 100))
					{
						this.text_fake += this.yug1.science_text[44];
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(79);
						}
					}
					else if (this.global1.science[6] && this.global1.science[8])
					{
						this.text_fake += this.yug1.science_text[45];
					}
					else
					{
						this.text_fake += this.yug1.science_text[46];
					}
				}
				else
				{
					if ((this.global1.data[42] == 2 && this.global1.science[1]) || this.global1.science[2])
					{
						this.text_fake = "Thanks to the pragmatic leadership of the government, the Ministry of Internal Affairs of our country underwent serious reforms, as a result of which it was possible to create a workable police system, which in turn guaranteed the safety and quiet life of our citizens. And successful reforms in the field of intelligence and foreign agents have allowed us to strengthen the influence of our special services on the world stage.|";
					}
					else
					{
						this.text_fake = "|There is no progress.|";
					}
					if (this.global1.science[5])
					{
						this.text_fake += "Over the past few years, our country has been able to increase the pace of economic growth and begin the course towards industrialization. Conducting forced construction of factories allowed us to increase the potential of our economy and markedly strengthened our role in the global world economy. As a result of this, we were able to bridge the gap with more developed countries by starting a rapid movement towards building an industrial society.|";
					}
					else
					{
						this.text_fake += "|There is no progress.|";
					}
					if ((this.global1.data[42] != 9 && this.global1.data[42] != 10 && this.global1.data[42] != 6 && this.global1.data[42] != 5 && this.global1.data[42] != 2 && this.global1.science[5] && this.global1.science[7]) || this.global1.science[8])
					{
						this.text_fake += "|The government of our country managed to carry out successful agrarian reform, which significantly improved agricultural productivity and the technical equipment of agricultural enterprises. The logical result of this was an increase in the production and consumption of food per capita, which had a very positive effect on the standard of living and health of our citizens.|";
					}
					else
					{
						this.text_fake += "|There is no progress.|";
					}
				}
			}
			else if (this.this_okno == 6 && this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
			{
				this.Name.text = this.yug1.science_text[47];
				bool flag2 = false;
				for (int j = 0; j < this.yug1.gameState.yugcountries.Length; j++)
				{
					if (this.yug1.gameState.yugcountries[j].is_exist && j != this.yug1.gameState.player)
					{
						flag2 = true;
						break;
					}
				}
				if (this.global1.science[9] && (this.global1.data[135] > 7 || !flag2 || this.global1.data[114] != 100))
				{
					this.text_fake = this.yug1.science_text[48];
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(78);
					}
				}
				else if (this.global1.science[9])
				{
					this.text_fake = this.yug1.science_text[49];
				}
				else
				{
					this.text_fake = this.yug1.science_text[50];
				}
			}
			else if (this.this_okno == 6)
			{
				this.Name.text = "NUCLEAR ACHIEVEMENTS";
				this.text_fake = "";
				if (this.global1.science[9] && !this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.data[22] > 500)
				{
					this.text_fake = "Seeing how easy it is to reshape the world and understanding the need to protect our sovereignty on our own, we have decided to develop nuclear weapons. Having received technology and raw materials, we successfully completed the development by creating our nuclear weapons, and proudly declared this to the world. This caused quite a stir, but no one could do anything about it. Now any country will reckon with us, and the enemy will think twice before attacking us.|";
				}
				else if (this.global1.science[9] && this.global1.allcountries[this.global1.data[0]].Vyshi)
				{
					this.text_fake = "Seeing how easy it is to reshape the world and understanding the need to protect our sovereignty on our own, we have decided to develop nuclear weapons. We received technology and raw materials, but the West, guessing about our plans, did not want to have a competitor. The IAEA commission was sent to us, which discovered our developments. Under world pressure, the pressure of the party apparatus and the dissident movement that raised its head, we had to abandon the military nuclear program, and all our peaceful nuclear facilities are now tightly controlled by the IAEA.|";
				}
				else if (this.global1.science[9])
				{
					this.text_fake = "Seeing how easy it is to reshape the world and understanding the need to protect our sovereignty on our own, we have decided to develop nuclear weapons. We received technology and raw materials, but the West, whose values we so diligently adopted, guessing about our plans, did not want to have a competitor. The IAEA commission was sent to us, which discovered our developments. Under world pressure, unable to resist it because of the freedom we created, we had to abandon the military nuclear program, and all our peaceful nuclear facilities are now tightly controlled by the IAEA.|";
				}
				else
				{
					this.text_fake = "|There is no progress in development of nuclear weapons.";
				}
				if (this.global1.allcountries[10].Stasi)
				{
					if (this.global1.iron_and_blood && !this.global1.science[9] && this.global1.science_time[9] <= 0)
					{
						this.achieves.GetComponent<achievements>().Set(23);
					}
					this.text_fake += "||According to our latest information, the news that the DPRK not only possesses nuclear weapons but actively builds up and tests it, produces longer-range missiles (bragging about the fact that they will soon be able to reach all cities of the world), and also working on the development of hydrogen weapons, plunged the whole world into shock and horror. US President George H.W. Bush has already declared North Korea a global threat, and in South Korea, South Korean-Japanese-American exercises are now being constantly held. The UN demands that the DPRK stop the development of hydrogen weapons and freeze all military nuclear development. North Korea, however, demands the cessation of provocations on the borders and the withdrawal of US military institutions, missiles and missile defense, from the territory of South Korea.|After the denunciation of the peace treaty on the Korean Peninsula, a new tension began again ... But everyone seems to want to avoid a new war.";
				}
			}
			else if (this.this_okno == 7)
			{
				this.Name.text = "WORLD SITUATION";
				this.text.text = "";
				for (int k = 2; k < this.global1.allcountries.Length; k++)
				{
					if (this.global1.allcountries[k] != null && k != this.global1.data[0] && k != 8 && k != 7 && k != 21 && k != 12 && k != 15 && k != 37 && k != 31 && k != 45 && k != 48 && k != 49 && k != 50 && k != 51 && k != 17 && k != 39 && k != 24 && k != 32 && k != 25 && (k < 40 || k > 43))
					{
						TextMesh textMesh = this.text;
						textMesh.text = textMesh.text + "<color=brown>" + this.global1.allcountries[k].name + ":</color>";
						if (this.global1.allcountries[k].subideology == 0)
						{
							if (PlayerPrefs.GetInt("language") == 0)
							{
								TextMesh textMesh2 = this.text;
								textMesh2.text += "<color=black> 左 翼 民 族 主 义,</color>";
							}
							else
							{
								TextMesh textMesh3 = this.text;
								textMesh3.text += "<color=black> Левый национализм,</color>";
							}
						}
						else if (this.global1.allcountries[k].subideology == 1)
						{
							if (PlayerPrefs.GetInt("language") == 0)
							{
								TextMesh textMesh4 = this.text;
								textMesh4.text += "<color=black> 民 族 布 尔 什 维 主 义,</color>";
							}
							else
							{
								TextMesh textMesh5 = this.text;
								textMesh5.text += "<color=black> Национал-большевизм,</color>";
							}
						}
						else if (this.global1.allcountries[k].subideology == 2)
						{
							if (PlayerPrefs.GetInt("language") == 0)
							{
								TextMesh textMesh6 = this.text;
								textMesh6.text += "<color=black> 亲 市 场 独 裁 体 制,</color>";
							}
							else
							{
								TextMesh textMesh7 = this.text;
								textMesh7.text += "<color=black> Рыночная диктатура,</color>";
							}
						}
						else if (this.global1.allcountries[k].subideology == 3)
						{
							if (PlayerPrefs.GetInt("language") == 0)
							{
								TextMesh textMesh8 = this.text;
								textMesh8.text += "<color=black> 第 三 道 路,</color>";
							}
							else
							{
								TextMesh textMesh9 = this.text;
								textMesh9.text += "<color=black> Третий путь,</color>";
							}
						}
						else if (this.global1.allcountries[k].subideology == 4)
						{
							if (PlayerPrefs.GetInt("language") == 0)
							{
								TextMesh textMesh10 = this.text;
								textMesh10.text += "<color=purple> 保 守 社 会 主 义,</color>";
							}
							else
							{
								TextMesh textMesh11 = this.text;
								textMesh11.text += "<color=purple> Консервативный социализм,</color>";
							}
						}
						else if (this.global1.allcountries[k].subideology == 5)
						{
							if (PlayerPrefs.GetInt("language") == 0)
							{
								TextMesh textMesh12 = this.text;
								textMesh12.text += "<color=purple> 托 洛 茨 基 主 义,</color>";
							}
							else
							{
								TextMesh textMesh13 = this.text;
								textMesh13.text += "<color=purple> Троцкизм,</color>";
							}
						}
						else if (this.global1.allcountries[k].subideology == 6)
						{
							if (PlayerPrefs.GetInt("language") == 0)
							{
								TextMesh textMesh14 = this.text;
								textMesh14.text += "<color=purple> 毛 主 义,</color>";
							}
							else
							{
								TextMesh textMesh15 = this.text;
								textMesh15.text += "<color=purple> Маоизм,</color>";
							}
						}
						else if (this.global1.allcountries[k].subideology == 7)
						{
							if (PlayerPrefs.GetInt("language") == 0)
							{
								TextMesh textMesh16 = this.text;
								textMesh16.text += "<color=purple> 反 修 正 主 义,</color>";
							}
							else
							{
								TextMesh textMesh17 = this.text;
								textMesh17.text += "<color=purple> Антиревизионизм,</color>";
							}
						}
						else if (this.global1.allcountries[k].subideology == 8)
						{
							if (PlayerPrefs.GetInt("language") == 0)
							{
								TextMesh textMesh18 = this.text;
								textMesh18.text += "<color=green> 民 主 社 会 主 义,</color>";
							}
							else
							{
								TextMesh textMesh19 = this.text;
								textMesh19.text += "<color=green> Демократический социализм,</color>";
							}
						}
						else if (this.global1.allcountries[k].subideology == 9)
						{
							if (PlayerPrefs.GetInt("language") == 0)
							{
								TextMesh textMesh20 = this.text;
								textMesh20.text += "<color=green> 左 翼 社 会 民 主 主 义,</color>";
							}
							else
							{
								TextMesh textMesh21 = this.text;
								textMesh21.text += "<color=green> Левая социал-демократия,</color>";
							}
						}
						else if (this.global1.allcountries[k].subideology == 10)
						{
							if (PlayerPrefs.GetInt("language") == 0)
							{
								TextMesh textMesh22 = this.text;
								textMesh22.text += "<color=green> 红 色 保 守 主 义,</color>";
							}
							else
							{
								TextMesh textMesh23 = this.text;
								textMesh23.text += "<color=green> Красный торизм,</color>";
							}
						}
						else if (this.global1.allcountries[k].subideology == 11)
						{
							if (PlayerPrefs.GetInt("language") == 0)
							{
								TextMesh textMesh24 = this.text;
								textMesh24.text += "<color=green> 政 治 实 用 主 义,</color>";
							}
							else
							{
								TextMesh textMesh25 = this.text;
								textMesh25.text += "<color=green> Политический прагматизм,</color>";
							}
						}
						else if (this.global1.allcountries[k].subideology == 12)
						{
							if (PlayerPrefs.GetInt("language") == 0)
							{
								TextMesh textMesh26 = this.text;
								textMesh26.text += "<color=blue> 中 间 主 义,</color>";
							}
							else
							{
								TextMesh textMesh27 = this.text;
								textMesh27.text += "<color=blue> Центризм,</color>";
							}
						}
						else if (this.global1.allcountries[k].subideology == 13)
						{
							if (PlayerPrefs.GetInt("language") == 0)
							{
								TextMesh textMesh28 = this.text;
								textMesh28.text += "<color=blue> 右 翼 社 会 民 主 主 义,</color>";
							}
							else
							{
								TextMesh textMesh29 = this.text;
								textMesh29.text += "<color=blue> Правая социал-демократия,</color>";
							}
						}
						else if (this.global1.allcountries[k].subideology == 14)
						{
							if (PlayerPrefs.GetInt("language") == 0)
							{
								TextMesh textMesh30 = this.text;
								textMesh30.text += "<color=blue> 自 由 保 守 主 义,</color>";
							}
							else
							{
								TextMesh textMesh31 = this.text;
								textMesh31.text += "<color=blue> Либерал-консерватизм,</color>";
							}
						}
						else if (this.global1.allcountries[k].subideology == 15)
						{
							if (PlayerPrefs.GetInt("language") == 0)
							{
								TextMesh textMesh32 = this.text;
								textMesh32.text += "<color=blue> 欧 洲 大 西 洋 主 义,</color>";
							}
							else
							{
								TextMesh textMesh33 = this.text;
								textMesh33.text += "<color=blue> Евроатлантизм,</color>";
							}
						}
						if (this.global1.allcountries[k].Vyshi && !this.global1.allcountries[this.global1.data[0]].Vyshi)
						{
							TextMesh textMesh34 = this.text;
							textMesh34.text += "<color=blue> 亲 美.</color>\n";
						}
						else if (this.global1.allcountries[k].Vyshi && this.global1.allcountries[this.global1.data[0]].Vyshi)
						{
							TextMesh textMesh35 = this.text;
							textMesh35.text += "<color=blue> 北 约 成 员.</color>\n";
						}
						else if (this.global1.allcountries[k].isOVD && this.global1.allcountries[k].Torg)
						{
							TextMesh textMesh36 = this.text;
							textMesh36.text += "<color=magenta> 亲 密 盟 友.</color>\n";
						}
						else if (this.global1.allcountries[k].isOVD)
						{
							TextMesh textMesh37 = this.text;
							textMesh37.text += "<color=purple> 友 好.</color>\n";
						}
						else if (this.global1.allcountries[k].isSEV)
						{
							TextMesh textMesh38 = this.text;
							textMesh38.text += "<color=teal> 经 济 伙 伴.</color>\n";
						}
						else if (this.global1.allcountries[k].Torg)
						{
							TextMesh textMesh39 = this.text;
							textMesh39.text += "<color=olive> 商 业 伙 伴.</color>\n";
						}
						else if ((k == 4 && this.global1.data[149] == 3) || (k == 6 && this.global1.data[235] == 9) || (k == 20 && this.global1.data[177] == 3))
						{
							TextMesh textMesh40 = this.text;
							textMesh40.text += "<color=purple> 南 斯 拉 夫 共 和 国.</color>\n";
						}
						else
						{
							TextMesh textMesh41 = this.text;
							textMesh41.text += "<color=black> 保 持 中 立.</color>\n";
						}
					}
				}
				this.this_done_done = true;
			}
			else if (this.this_okno == 8)
			{
				this.Name.text = "REPORTS ON THE WORLD";
				this.text_fake = "|";
				if (this.global1.event_done[1079] && (this.global1.allcountries[17].Gosstroy == 1 || this.global1.allcountries[7].paths == 3))
				{
					if (this.global1.allcountries[17].Gosstroy == 1)
					{
						this.text_fake += "<color=purple>Sovereign Federal Republic of Germany</color>";
						this.text_fake += "|The bloc of left-wing parties was able to successfully hold power in Germany throughout the entire 90s. Successful social policies, coupled with the introduction of elements of \"Swedish socialism\", the expansion of trade union rights and support for production in the eastern lands, required large financial investments. In terms of foreign policy, a united Germany began to distance itself from NATO by withdrawing from its political structures. However, tax increases and additional loans hit the middle and upper class seriously, so in the 2000 elections the CDU won 35% of the vote and, together with the liberals, formed a new center-right government headed by Volker Kauder, who promised \"to fight not only left-wing economic ideas, but also left-wing societal ideas\" and also promised \"to defend the sovereignty of Germany \"and called on the United States \"to abandon the behavior of global domination\".";
					}
					else if (this.global1.allcountries[7].paths == 3)
					{
						this.text_fake += "<color=purple>Vorotnikov's strike on the FRG</color>";
						this.text_fake += "|After the reunification of Germany, the Soviet Union insisted on the revision of a number of treaties, including \"Two plus four\". Soviet Foreign Minister Yuli Vorontsov put forward a note to the Western powers, accusing the FRG of sabotaging the withdrawal of Soviet troops from its territory. At a new international conference, the USSR demanded that the Soviet commission be given control over the withdrawal of troops and put forward a number of the following demands: the FRG leaves NATO and fixes the status of a neutral power in the constitution, all debts are written off to the Soviet Union. In case of failure to comply with these notes, the USSR will cease the withdrawal of troops from the territory of East Germany and transfer control of the area to its administration. In the Western press, a campaign was launched against the USSR with accusations of aggression, but Germany had to retreat and fulfill the requirements in order to remain a whole and sovereign state.";
					}
				}
				else if (this.global1.allcountries[1].Gosstroy != 2 && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy >= 2)) && ((this.global1.allcountries[17].Westalgie >= 300 && this.global1.allcountries[this.global1.data[0]].isOVD && this.global1.allcountries[7].isOVD) || (((this.global1.allcountries[17].Westalgie >= 350 && this.global1.allcountries[16].Gosstroy == 0) || this.global1.allcountries[17].Westalgie >= 400) && this.global1.allcountries[this.global1.data[0]].isSEV && (this.global1.allcountries[17].Westalgie >= 550 || this.global1.allcountries[7].isSEV))))
				{
					if (this.global1.data[0] != 1 || (this.global1.data[0] == 1 && this.global1.science[9]) || (this.global1.data[0] == 1 && (this.global1.data[14] < 2 || this.global1.data[14] > 4 || (this.global1.data[14] == 2 && this.global1.data[15] < 8 && this.global1.data[17] < 16) || (this.global1.data[14] == 4 && this.global1.data[16] > 12))))
					{
						this.text_fake += "<color=purple>Renewed Federal Republic of Germany</color>";
						this.text_fake += "|<color=purple>In Germany </color>, during the reformation of the socialist world, the fall of the veil of the red scare and the flourishing of the idea of world friendship, the coalition of the left forces, which advocated pacifism, social reforms, friendship and peace, won the next election. The result of its victory was not simply the establishment of relations with the GDR and the recognition of West Berlin as a demilitarized zone: the Federal Republic announced its withdrawal from the military structures of NATO, remaining only in the political, and, together with the GDR, withdrew foreign military bases from its territories, signing agreements on the non-presence of troops or missiles on the territory of both Germanies, and on the non-nuclear status of the territories of FRG. This was supported by both the USSR and France, which also approved the speeches of the new German leadership for strengthening economic integration in Western Europe, which, in spite of the dissatisfaction with the new policies of the United Kingdom and the United States, is the formation of the European Union.";
					}
				}
				else if (this.global1.allcountries[1].Gosstroy != 2 && !this.global1.allcountries[7].Vyshi)
				{
					this.text_fake += "<color=purple>Federal Republic of Germany</color>";
					this.text_fake += "|After an unsuccessful attempt to <color=purple>unify Germany</color> , Helmut Kohl lost in FRG for the Chancellor's post in 1994. A coalition of Social Democrats and Green headed by Gerhard Schroeder came to power with promises of economic modernization, support of entrepreneurship, preservation of the social protection system and provision of more sovereign foreign policy. The consequence of this was the establishment of more friendly relations with the USSR and a new stage of detente in relations with the GDR.";
				}
				else if (this.global1.allcountries[1].Gosstroy != 2)
				{
					this.text_fake += "<color=purple>Federal Republic of Germany</color>";
					this.text_fake += "|After an unsuccessful attempt to <color=purple>unify Germany</color> , Helmut Kohl lost in FRG for the Chancellor's post in 1994. A coalition of Social Democrats and Green headed by Gerhard Schroeder came to power with promises of economic modernization, support of entrepreneurship, preservation of the social protection system and provision of more sovereign foreign policy. The consequence of this was the establishment of more friendly relations with the Russia and a new stage of detente in relations with the GDR.";
				}
				else
				{
					this.text_fake += "<color=purple>United Federal Republic of Germany</color>";
					this.text_fake += "|East Germany collapsed and now <color=purple>the German people became united</color>. However, this did not solve a lot of problems that were as in the GDR, and <color=purple>in FRG</color>. Germany still has a lot to go through.";
				}
				if (this.global1.allcountries[27].Donat)
				{
					this.text_fake += "||<color=purple>Austria</color>|";
					if (this.global1.allcountries[27].Westalgie >= 2)
					{
						this.text_fake += this.dlce1.credits_text[365];
					}
					else if (this.global1.allcountries[27].Westalgie >= 1)
					{
						this.text_fake += this.dlce1.credits_text[366];
					}
					else
					{
						this.text_fake += this.dlce1.credits_text[367];
					}
				}
				else if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
				{
					this.text_fake += "||<color=purple>Austria</color>|";
					if (this.yug1.gameState.yugregions[0].owner == 0 && !this.yug1.gameState.yugcountries[0].is_independent)
					{
						this.text_fake += this.dlce1.credits_text[368];
					}
					else if (this.yug1.gameState.yugregions[0].owner != 0)
					{
						this.text_fake += this.dlce1.credits_text[369];
					}
					else
					{
						this.text_fake += this.dlce1.credits_text[370];
					}
				}
				else
				{
					this.text_fake += "||<color=purple>Austria</color>|";
					if (this.global1.data[7] >= 800 && this.global1.allcountries[27].Torg)
					{
						this.text_fake += this.dlce1.credits_text[385];
					}
					else
					{
						this.text_fake += this.dlce1.credits_text[386];
					}
				}
			}
			else if (this.this_okno == 9)
			{
				this.Name.text = "REPORTS ON THE WORLD";
				this.text_fake = "|";
				this.text_fake = "<color=purple>Greece</color>|";
				if (this.global1.allcountries[45].Gosstroy <= 1 && this.global1.allcountries[45].isSEV && this.global1.allcountries[45].Torg && !this.global1.allcountries[7].isOVD && this.greece_ally > 6)
				{
					this.text_fake += "The ruling Greek coalition of socialists and communists was able to successfully survive the problems of the socialist camp of the late twentieth century and, with our full support, finally take the country out of NATO, announcing its neutrality and the rejection of the deployment of nuclear weapons. Keeping economic contacts with us, Greece continues to be a member of our Economic Alliance, despite proposals to join the newly-formed European Union.";
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(44);
					}
				}
				else if (this.global1.allcountries[45].Gosstroy <= 1 && this.global1.allcountries[45].isSEV && this.global1.allcountries[45].Torg && !this.global1.allcountries[7].isOVD && this.greece_ally <= 5)
				{
					this.text_fake += "The ruling Greek coalition of socialists and communists was able to successfully survive the problems of the socialist camp of the late twentieth century and, with our full support, finally take the country out of NATO, announcing its neutrality and the rejection of the deployment of nuclear weapons. Despite economic contacts with us, Greece decides to join the European Union under the slogan of an intermediary between East and West. They do not lost connection with us, but still...";
				}
				else if (this.global1.allcountries[45].Gosstroy <= 1)
				{
					this.text_fake += "In the next elections, the Greek coalition of socialists and communists, after a scandal, collapsed, and power in the socialist party passed to the centre-right wing. Despite economic contacts with us, Greece decides to join the European Union under the slogan of an intermediary between East and West. They do not lost connection with us, but still...";
				}
				else
				{
					this.text_fake += "Greece continues to be a member of NATO and begins to take part in the formation of the European Union.";
				}
				this.text_fake += "|";
				if (this.global1.data[0] < 49 || this.global1.data[0] > 51)
				{
					if (this.global1.data[59] != 2 && this.global1.allcountries[this.global1.data[0]].isOVD && (this.global1.allcountries[5].isOVD || this.global1.allcountries[6].isOVD) && (this.global1.data[54] >= 7 || (this.global1.allcountries[15].isOVD && this.global1.data[54] >= 5)) && !this.global1.allcountries[15].Help)
					{
						this.text_fake += "|<color=purple>Socialist Federal Republic of Yugoslavia</color>|";
						this.text_fake += "The American proposal to intervene in the civil war in <color=purple>Yugoslavia</color> was blocked by some UN Security Council member countries, as a result of which, thanks to our support and support from our military alliance, Milosevic and the Serbian states were able to win in a long and bloody confrontation. Yugoslavia remained unharmed, although finally passing to state capitalism and bourgeois democracy, led by the Socialist Party and Milosevic.";
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(31);
						}
					}
					else if (this.global1.data[54] >= 2 && !this.global1.allcountries[15].Help)
					{
						this.text_fake += "|<color=purple>Federal Republic of Yugoslavia</color>|";
						this.text_fake += "During the civil war in <color=purple>Yugoslavia</color> , Milosevic still had to part with the separatists and stop helping the Serbian fighters for sovereignty. However, while maintaining contact with us and other friend countries of the renovated Yugoslavia, the new state received a lot of assistance, including military assistance, while Milosevic personally received support from our special services during the Bulldozer Revolution and was able to hold on to power, and the Americans did not decided to conduct a deeper intervention . And the war for Kosovo never happened, as well as the NATO bombing - the conflict was suppressed as soon as possible.";
					}
					else
					{
						this.text_fake += "|<color=purple>Breakup of Yugoslavia</color>|";
						this.text_fake += "During the civil war, <color=purple>Yugoslavia</color>  still had to part with its republics and stop provide assistance to Serbian fighters for sovereignty. And then to experience  the terrible bombing of NATO aviation because of the problems in Kosovo, which led to numerous deaths among the civilian population. The next step was the Bulldozer revolution and the fall of the Milosevic regime, and with it the gradual collapse of the rest of Yugoslavia.";
					}
				}
			}
			else if (this.this_okno == 10)
			{
				this.Name.text = "REPORTS ON THE WORLD";
				this.text_fake = "|";
				if (((this.global1.data[37] >= 6 && this.global1.allcountries[31].Help) || this.global1.data[37] >= 7) && this.global1.data[0] != 12 && !this.global1.allcountries[7].Vyshi && (this.global1.allcountries[7].isSEV || this.global1.allcountries[16].isSEV || this.global1.allcountries[19].Gosstroy <= 1) && this.global1.allcountries[12].Gosstroy == 9)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(22);
					}
					this.text_fake += "<color=purple>Democratic Republic of Afghanistan</color>";
					this.text_fake += "|After launching a decisive offensive against the radical Islamic opposition, with large army and humanitarian supplies from outside, <color=purple>the new regime of Tanay</color> managed to control almost the entire border with Pakistan and systematically mop up much of the resistance inside the country. The reforms in the spirit of Islamic socialism, the beginning of open work of mosques, shopkeepers, artisans and the rejection of atheism, allowed the government in Kabul to find common ground with the majority of the rural population of Pashtun Afghanistan, who had stopped providing aid to the mujahideen, many of whom preferred to fall under the amnesty and go home. A key phase of the civil war can be said to be over, and the few remaining militant groups will be caught or destroyed in the coming years.";
				}
				else if (((this.global1.data[37] >= 8 && this.global1.allcountries[31].Help) || this.global1.data[37] >= 9) && this.global1.data[0] != 12 && !this.global1.allcountries[7].Vyshi && (this.global1.allcountries[7].isSEV || this.global1.allcountries[16].isSEV || this.global1.allcountries[19].Gosstroy <= 1))
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(22);
					}
					this.text_fake += "<color=purple>Democratic Republic of Afghanistan</color>";
					this.text_fake += "|Constantly provided by us and the entire socialist bloc, assistance to <color=purple>the Najibullah regime</color>, together with the imposition of harsh sanctions against Pakistan and the condemnation of Pakistani terrorists, even by France and China (after they carried out a series of terrorist attacks around the world) - have become the final turning point in the history of Afghanistan. And Najibullah's reforms, legalizing small private traders, shops and handicrafts, along with the integration of Afghan traditions and religion into state ideology, consolidated the power of socialists in the country. The Civil War is over.";
				}
				else if (this.global1.allcountries[12].Gosstroy == 9 && this.global1.data[0] != 12)
				{
					this.text_fake += "<color=purple>Civil War in Afghanistan</color>";
					this.text_fake += "|The Tanai rebellion significantly changed the balance of power within the PDPA, which had virtually no effect on the combat effectiveness of the DRA, as almost all the military supported it. Thanks to this, the new government still manages to control most of the country. Some countries, fearing the expansion of Islamic terrorists, have started pressurizing Pakistan, making it harder for it to help the terrorists. Some informal agreements are reported between Kabul and Islamabad to stop the latter's active support of the radical opposition, in exchange for the start of Islamic reforms in Afghanistan and the opening of the local market for Pakistani entrepreneurs. China was able to reach an agreement and develop a common position on ending support for the mujahideen. Nevertheless, the excessive radicalism of the Afghan military has not yet allowed the Islamic reforms to win over the entire rural population of Afghanistan, which is why the civil war in Afghanistan continues.";
				}
				else if (this.global1.allcountries[7].Gosstroy <= 1 && this.global1.data[0] != 12)
				{
					this.text_fake += "<color=purple>Civil War in Afghanistan</color>";
					this.text_fake += "|The Soviet Union continued to exist, providing humanitarian and military support to <color=purple>Afghanistan</color>, which helped alleviate its situation. Some countries, fearing the expansion of Islamic terrorists, began to exert pressure on Pakistan, making it more difficult for the Mujahideen. And with China, the USSR managed to agree and develop a unified position on stopping the support of the Mujahideen. And although disagreements in the PDPA and the DRA army were not settled to the end, and Najibullah's policy had its flaws, the mujahideen succeeded in suppressing the offensive, and the DRA controls enough territories to exist further. There was not a decisive advantage for either side, so the civil war in Afghanistan continues.";
				}
				else if (this.global1.data[0] != 12)
				{
					this.text_fake += "<color=purple>Islamic State of Afghanistan</color>";
					this.text_fake += "|After the withdrawal of the Soviet troops, the situation of <color=purple>Afghanistan</color> began to deteriorate rapidly - the inconsistent policy of the PDPA, together with disagreements in it and in army leadership, led to the fact that the people began to turn away from the Afghan government, and the army with difficulty restrain the onslaught of the mujahideen. Almost in international isolation, Afghanistan could not get support from outside, and Pakistan continued to send more and more groups of Islamists with impunity. In April 1992, the Mujahideen entered Kabul without a fight, declaring Afghanistan an Islamic state. All the achievements of the Soviet government in the social, economic and legal fields have been destroyed. And four years later Najibullah himself was brutally murdered without trial and investigation.";
				}
				this.text_fake += "||";
				if (this.global1.allcountries[24].Stasi && this.global1.allcountries[24].Gosstroy != this.global1.allcountries[25].Gosstroy && this.global1.data[55] >= 3)
				{
					this.text_fake += "<color=purple>Socialist Republic of Yemen</color>";
					this.text_fake += "|During the massive and rapid development of oil production <color=purple>in the PDRY</color>, the country became a new major player in the arena of oil exporters, which resulted in an increase in both our profits and substantial diplomatic, political and economic assistance to allied states that have the same interests with us and PDRY. The world has become stronger. For us.";
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(33);
					}
				}
				else if ((this.global1.allcountries[24].Gosstroy == 0 || this.global1.allcountries[24].Gosstroy == 1) && this.global1.allcountries[24].Stasi)
				{
					this.text_fake += "<color=purple>People's Democratic Republic of Yemen</color>";
					if (this.global1.data[55] == 2 && this.global1.allcountries[24].isSEV)
					{
						this.text_fake += "|In the course of mass purges <color=purple>the NDRY</color> retained a conservative traditional government, which significantly increased interaction with its foreign partners. Thanks to investments from our country, the development of oil fields discovered with Soviet help by the end of the 80s has begun. Although the enterprises are not yet operating at full capacity, the first oil revenues have allowed the YSP to consolidate its power and implement moderate reforms within the framework of socialism in the country. Still, analysts predict that unless new changes are made, petrodollars may not be enough to stabilize the country, amid increased terrorism in rural areas on the border with the North.";
					}
					else if (this.global1.allcountries[24].Gosstroy == 1)
					{
						this.text_fake += "|The initial period of minor economic reforms <color=purple>in the NDRY</color> allowed the balance between the conservative and reformist factions within the YSP to be maintained. Thus, not only small businesses but also medium-sized businesses were allowed, and foreign capital was given additional incentives in exchange for investment. As a result, the country was able to launch the development of oil fields discovered with Soviet help by the end of the 80s, the profits from which keep the economy of <color=purple>the NDRY</color> afloat, and deprive the proponents of unification with the North of additional arguments for the necessity of reunification.";
					}
					else
					{
						this.text_fake += "|In the course of mass purges <color=purple>the PDRY</color> has retained a conservative traditional government, which has nevertheless been forced to introduce minor market reforms, such as allowing sole proprietorships, cooperatives and small private entrepreneurs in the service sector, along with the opening of several FEZs. The PDRY remains one of our main allies in the Middle East, and the country is trying to start developing oil production, based on fields discovered with Soviet assistance by the late 80s but not developed due to lack of funds and reduced Soviet aid.";
					}
				}
				else if (this.global1.data[55] >= 3 && this.global1.data[226] >= 2 && this.global1.allcountries[25].Stasi)
				{
					this.text_fake += "<color=purple>Democratic Republic of Yemen</color>";
					this.text_fake += "|<color=purple>The two Yemens</color> became one in exchange for the transfer of important and major government posts to the figures of the socialist Yemen regime and the leading posts to the figures of the bourgeois Yemen. After long negotiations on the future of the republic and prolonged political conflicts, various leftist organizations managed to consolidate their more privileged political position, and the YSP became the leading party in the country. Thanks to the development of oil fields, the standard of living in the republic began to grow at a serious pace, thanks to the additional taxes introduced. However, if catastrophic problems such as hunger and thirst were dealt with, corruption came to the forefront, which does not allow for qualitative improvement in isolated areas of the mountainous republic. Islamic fundamentalism, receiving support from other Arab states, is also raising its head.";
				}
				else if (this.global1.data[55] >= 3 && this.global1.allcountries[25].Stasi)
				{
					this.text_fake += "<color=purple>Republic of Yemen</color>";
					this.text_fake += "|<color=purple>The two Yemens</color> became one in exchange for the transfer of important and major government posts to the figures of the socialist Yemeni regime and leading posts to the figures of the bourgeois regime. After lengthy negotiations on the future of the republic, the northerners managed to secure a more privileged political position for themselves in many ways, and the Leading People's Congress became the leading party in the country. After the start of the development of oil fields, the country managed to maintain a course towards improving the standard of living, eradicating hunger, thirst and illiteracy among all residents of the new republic. A special role is played by the \"tax on the south\", thanks to which the dire situation of the former residents of the PDRY began to improve. Nevertheless, having lost the political struggle, the YSP broke up into several smaller parties, occupying a semi-marginal position in Yemeni politics.";
				}
				else if (this.global1.data[226] >= 2 && this.global1.allcountries[25].Stasi)
				{
					this.text_fake += "<color=purple>The Democratic Republic of Yemen</color>";
					this.text_fake += "|<color=purple>The two Yemens</color> became one in exchange for the transfer of important and major government posts to the figures of the socialist Yemen regime and leading posts to the figures of the bourgeois regime. After long negotiations on the future of the republic, it became clear that it would be impossible to reach a compromise that would suit everyone. After the armed uprisings of YSP supporters led by Ali Salim al-Beidh began in South Yemen, the country was again divided, and the ideas of unification sank into oblivion. Nevertheless, the DRY has not yet received official international recognition, with the exception of the support of a number of countries in the Arab region.";
				}
				else
				{
					this.text_fake += "<color=purple>United Republic of Yemen</color>";
					this.text_fake += "|<color=purple>Two Yemen</color> became united in exchange for the allocation of important and major government posts to the leaders of the socialist Yemen regime and the supreme posts of the bourgeois leaders. However, such a shaky coalition did not last long and, after the final loss of the socialist world's influence on this territory, the politics of the former PDRY were kicked out of their posts, and when they tried to start the uprising because of their disappointment, they were persecuted. ";
				}
			}
			else if (this.this_okno == 11)
			{
				this.Name.text = "REPORTS ON THE WORLD";
				this.text_fake = "";
				if (this.global1.allcountries[21].Gosstroy != 1)
				{
					for (int l = 40; l < 44; l++)
					{
						if (this.global1.allcountries[l].Westalgie >= 1000)
						{
							this.text_fake = this.text_fake + "<color=purple>" + this.global1.allcountries[l].name + "</color>: In the country there was a stabilization. The Left Coalition finally approved its authority throughout the country, forming a socialist government and a socialist republic. The triumph of socialism has come.|";
						}
						else if (this.global1.allcountries[l].Westalgie >= 600)
						{
							this.text_fake = this.text_fake + "<color=purple>" + this.global1.allcountries[l].name + "</color>: There was partial stabilization. The Left coalition was able to take power in the country, having formed the regime of People's Democracy, while the opposition still exists and sows troubles, and its radicalized wing continues to partisan.|";
						}
						else if (this.global1.allcountries[l].Westalgie > 0)
						{
							this.text_fake = this.text_fake + "<color=purple>" + this.global1.allcountries[l].name + "</color>: There was partial stabilization. The Right coalition was able to take power in the country, having formed the regime of the Right Imitation Democracy, while the opposition still exists and sows troubles, and its radicalized wing continues to partisan.|";
						}
						else if (this.global1.allcountries[l].Westalgie <= 0 && l == 40)
						{
							this.text_fake = this.text_fake + "<color=purple>" + this.global1.allcountries[l].name + "</color>: The country has stabilized. The right-wing coalition led by the Islamic Salvation Front has finally established its power throughout the country, forming a new Islamist regime that advocates further Arabization of the republic, the eradication of French influence, and the triumph of Sharia. The country has liberalized its economy, abandoning the plan in favor of supporting small private owners. The triumph of Islamic democracy has arrived.|";
						}
						else if (this.global1.allcountries[l].Westalgie <= 0)
						{
							this.text_fake = this.text_fake + "<color=purple>" + this.global1.allcountries[l].name + "</color>: In the country there was a stabilization. The Right coalition finally established its authority throughout the country, forming a liberal-democratic government and a capitalist republic. The triumph of bourgeois democracy has come.|";
						}
					}
				}
				else
				{
					this.text_fake += "The democratic government managed to curb Islamic fundamentalism and prevent a looming crisis. As a result, in <color=purple>Algeria</color> a bipartisan system similar to the Western one has developed, where socialists and democrats play a dominant role. Nevertheless, despite the internal political stabilization, Algeria is becoming more and more dependent on France, which is gradually taking over the country's domestic market with its goods, with which local production cannot compete.|";
					for (int m = 41; m < 44; m++)
					{
						if (this.global1.allcountries[m].Westalgie >= 1000)
						{
							this.text_fake = this.text_fake + "<color=purple>" + this.global1.allcountries[m].name + "</color>: In the country there was a stabilization. The Left Coalition finally approved its authority throughout the country, forming a socialist government and a socialist republic. The triumph of socialism has come.|";
						}
						else if (this.global1.allcountries[m].Westalgie >= 600)
						{
							this.text_fake = this.text_fake + "<color=purple>" + this.global1.allcountries[m].name + "</color>: There was partial stabilization. The Left coalition was able to take power in the country, having formed the regime of People's Democracy, while the opposition still exists and sows troubles, and its radicalized wing continues to partisan.|";
						}
						else if (this.global1.allcountries[m].Westalgie > 0)
						{
							this.text_fake = this.text_fake + "<color=purple>" + this.global1.allcountries[m].name + "</color>: There was partial stabilization. The Right coalition was able to take power in the country, having formed the regime of the Right Imitation Democracy, while the opposition still exists and sows troubles, and its radicalized wing continues to partisan.|";
						}
						else if (this.global1.allcountries[m].Westalgie <= 0)
						{
							this.text_fake = this.text_fake + "<color=purple>" + this.global1.allcountries[m].name + "</color>: In the country there was a stabilization. The Right coalition finally established its authority throughout the country, forming a liberal-democratic government and a capitalist republic. The triumph of bourgeois democracy has come.|";
						}
					}
				}
			}
			else if (this.this_okno == 12)
			{
				this.Name.text = "COMMONWEALTH";
				this.text_fake = "";
				if (this.global1.allcountries[7].isSEV && this.global1.allcountries[7].isOVD)
				{
					this.text_fake = "|<color=purple>Soviet leadership</color>";
					this.text_fake += "|The Soviet Union continues to be the informal leader of a more reformed socialist camp, leading all its members to a brighter future.";
				}
				else if (!this.global1.allcountries[7].isOVD && this.global1.allcountries[this.global1.data[0]].Vyshi)
				{
					this.text_fake = "|<color=purple>New Neighbors</color>";
					this.text_fake += "|After the Soviet Union renounced the Brezhnev doctrine and allowed us to make our choice, our government decided to integrate with western neighbors. And now we are a new member of the NATO family and the European Union.";
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(34);
					}
				}
				else
				{
					if (!this.global1.allcountries[7].isOVD)
					{
						this.text_fake = "|<color=purple>Military agreement</color>";
						this.text_fake = this.text_fake + "|Total: " + this.military_ally.ToString();
						if (this.military_ally <= 2)
						{
							this.text_fake += " (small)|With the fall of the Warsaw Pact, we became more defenseless, and although we tried to put together our own military alliance, we should admit that it turned out badly. Our influence in the world remained about as small as it was before the Warsaw Pact was broken.";
						}
						else if (this.military_ally <= 5)
						{
							this.text_fake += " (medium)|With the fall of the Warsaw Pact, we became more defenseless, and although we tried to put together our own military alliance, we should admit that it was much better than it could be. Our influence in the world has greatly expanded after the break of the Warsaw Pact and a new, albeit small, but strong bloc of countries is ready to defend us and each other.";
						}
						else
						{
							this.text_fake += " (large)|With the fall of the Warsaw Pact, we have become more defenseless, but our attempts to put together our own military alliance, it is worth acknowledging, exceeded the expectations of even the most optimistic of our party members. Thanks to our actions, we were able to become one of the new powerful world powers with which other countries begin to reckon.";
						}
					}
					else
					{
						this.text_fake = "|<color=purple>Military agreement</color>";
						this.text_fake += "|The Soviet Union continues to be the informal leader of a more reformed socialist camp, leading all its members to a brighter future.";
					}
					if (!this.global1.allcountries[7].isSEV)
					{
						this.text_fake += "|<color=purple>Economic alliance</color>";
						this.text_fake = this.text_fake + "|Total: " + this.economy_ally.ToString();
						if (this.economy_ally <= 4)
						{
							this.text_fake += " (small)|With the dissolution of the Council for Mutual Economic Assistance, we lost many trading partners, and, unfortunately, our trade was never able to recover from such a vile blow from the Soviet Union, and from CMEA remained only its pale shadow.";
						}
						else if (this.economy_ally <= 7)
						{
							this.text_fake += " (medium)|With the dissolution of the Council for Mutual Economic Assistance we lost many trading partners, however, we managed to recover from such a vile blow from the Soviet Union and restore our trade ties, forming a strong alternative to the CMEA.";
						}
						else
						{
							this.text_fake += " (large)|With the dissolution of the Council for Mutual Economic Assistance we lost many trading partners, however, we managed not only to recover from such a vile blow from the Soviet Union, but also to expand our trade ties, gaining more and more economic partners, forming an equally broad and strong alternative to CMEA.";
						}
					}
					else
					{
						this.text_fake += "|<color=purple>Economic alliance</color>";
						this.text_fake += "|The Council for Mutual Economic Assistance, despite stopping the provision of benefits and assistance from the Soviet Union, thanks to decades of strong economic ties, was able to reform and retain its niche in the global economic system, remaining the same alternative to the Western commonwealth.";
					}
				}
				if (this.global1.data[59] == 1 && this.global1.data[0] == 5 && !this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.data[42] != 7)
				{
					this.text_fake += "||The Soviet Union collapsed, after which Transnistria solidified its own sovereignty and declared itself to be a real Moldavia. An armed conflict broke out, in which we hastened to intervene - after striking the unsuspecting Moldovans in the rear, we quickly seized the key cities and coordinated our actions with the Gagauz, Transnistrians and Russian volunteers. Under the close supervision of Securitate, the referendum in Moldova approved by an overwhelming majority of votes the entry of Moldova into Romania, Transnistria was recognized as a true Moldova, Gagauzia gained independence and they became our friends, and former Moldovans were declared Bessarabian Romanians. Soon all our allies recognized this, despite protests from the West, while Russia did not care.";
					if (this.global1.iron_and_blood && this.global1.data[60] == 6)
					{
						this.achieves.GetComponent<achievements>().Set(39);
					}
				}
				else if (this.global1.data[59] == 1 && this.global1.data[0] == 5)
				{
					this.text_fake += "||The Soviet Union collapsed, after which Transnistria solidified its own sovereignty and declared itself to be a real Moldavia. An armed conflict broke out, in which we hastened to intervene - after striking the unsuspecting Moldovans in the rear, we quickly seized the key cities and coordinated our actions with the Gagauz, Transnistrians and Russian volunteers. However, soon, under pressure from the international community, we were forced to withdraw troops from Moldova, guaranteeing its sovereignty. Well, at least Gagauzia and Transnistria have gained independence and become our loyal friends-allies.";
				}
				if (this.global1.data[7] >= 1001)
				{
					this.text_fake += "||By skillful diplomacy and defense of the gains of the revolutionary fighters, the socialist countries managed, despite all fears, not only not to reduce, but also to increase the authority of the international labor movement and the integrity of the world system of socialism. In 1992, political scientist Francis Fukuyama released his book, “The World at a Crossroads,” in which he declared his essay “The End of History?” premature and the ideological struggle between liberal democracy and renewed socialism to continue.";
				}
			}
			else if (this.this_okno == 13)
			{
				this.Name.text = "NATO";
				this.text_fake = "";
				if (!this.global1.allcountries[7].isOVD && this.global1.allcountries[54].Gosstroy != 0 && this.global1.allcountries[1].Gosstroy != 2 && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy >= 2)) && ((this.global1.allcountries[17].Westalgie >= 300 && this.global1.allcountries[this.global1.data[0]].isOVD && this.global1.allcountries[7].isOVD) || (((this.global1.allcountries[17].Westalgie >= 350 && this.global1.allcountries[16].Gosstroy == 0) || this.global1.allcountries[17].Westalgie >= 400) && this.global1.allcountries[this.global1.data[0]].isSEV && (this.global1.allcountries[17].Westalgie >= 550 || this.global1.allcountries[7].isSEV))) && (this.global1.data[0] != 1 || (this.global1.data[0] == 1 && this.global1.science[9]) || (this.global1.data[0] == 1 && (this.global1.data[14] < 2 || this.global1.data[14] > 4 || (this.global1.data[14] == 2 && this.global1.data[15] < 8 && this.global1.data[17] < 16) || (this.global1.data[14] == 4 && this.global1.data[16] > 12)))) && this.global1.allcountries[21].Gosstroy == 1 && this.global1.allcountries[21].subideology == 10 && ((this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 + this.global1.data[6] / 10 + this.global1.data[8] / 20 >= 1350) || ((this.global1.event_done[371] || this.global1.data[164] > 5) && this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[10] <= 1600 && (!this.global1.event_done[382] || this.global1.data[164] > 5) && this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 < 1000 && this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie >= 300)) && ((this.global1.allcountries[45].Gosstroy <= 1 && this.global1.allcountries[45].isSEV && !this.global1.allcountries[7].isOVD && this.greece_ally > 6) || (this.global1.allcountries[45].Gosstroy <= 1 && this.global1.allcountries[45].isSEV && !this.global1.allcountries[7].isOVD && this.greece_ally <= 5) || this.global1.data[161] == 1 || this.global1.data[161] == 3) && this.global1.data[242] == 2 && this.global1.allcountries[17].Westalgie >= 300 && this.global1.data[7] >= 850 && this.global1.allcountries[29].Gosstroy == 1 && this.global1.allcountries[44].Gosstroy == 1)
				{
					this.text_fake += this.dlce1.credits_text[371];
					this.achieves.GetComponent<achievements>().Set(147);
				}
				else if (this.global1.allcountries[1].Gosstroy != 2 && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy >= 2)) && ((this.global1.allcountries[17].Westalgie >= 300 && this.global1.allcountries[this.global1.data[0]].isOVD && this.global1.allcountries[7].isOVD) || (((this.global1.allcountries[17].Westalgie >= 350 && this.global1.allcountries[16].Gosstroy == 0) || this.global1.allcountries[17].Westalgie >= 400) && this.global1.allcountries[this.global1.data[0]].isSEV && (this.global1.allcountries[17].Westalgie >= 550 || this.global1.allcountries[7].isSEV))) && (this.global1.data[0] != 1 || (this.global1.data[0] == 1 && this.global1.science[9]) || (this.global1.data[0] == 1 && (this.global1.data[14] < 2 || this.global1.data[14] > 4 || (this.global1.data[14] == 2 && this.global1.data[15] < 8 && this.global1.data[17] < 16) || (this.global1.data[14] == 4 && this.global1.data[16] > 12)))) && this.global1.allcountries[21].Gosstroy == 1 && this.global1.allcountries[21].subideology == 10 && ((this.global1.allcountries[45].Gosstroy <= 1 && this.global1.allcountries[45].isSEV && !this.global1.allcountries[7].isOVD && this.greece_ally > 6) || (this.global1.allcountries[45].Gosstroy <= 1 && this.global1.allcountries[45].isSEV && !this.global1.allcountries[7].isOVD && this.greece_ally <= 5) || this.global1.data[161] == 1 || this.global1.data[161] == 3) && this.global1.data[242] == 2 && this.global1.allcountries[17].Westalgie >= 300 && this.global1.data[7] >= 850 && this.global1.allcountries[29].Gosstroy == 1 && !this.global1.allcountries[44].Vyshi)
				{
					this.text_fake += this.dlce1.credits_text[372];
				}
				else if (this.global1.allcountries[1].Gosstroy != 2 && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy >= 2)) && ((this.global1.allcountries[17].Westalgie >= 300 && this.global1.allcountries[this.global1.data[0]].isOVD && this.global1.allcountries[7].isOVD) || (((this.global1.allcountries[17].Westalgie >= 350 && this.global1.allcountries[16].Gosstroy == 0) || this.global1.allcountries[17].Westalgie >= 400) && this.global1.allcountries[this.global1.data[0]].isSEV && (this.global1.allcountries[17].Westalgie >= 550 || this.global1.allcountries[7].isSEV))) && (this.global1.data[0] != 1 || (this.global1.data[0] == 1 && this.global1.science[9]) || (this.global1.data[0] == 1 && (this.global1.data[14] < 2 || this.global1.data[14] > 4 || (this.global1.data[14] == 2 && this.global1.data[15] < 8 && this.global1.data[17] < 16) || (this.global1.data[14] == 4 && this.global1.data[16] > 12)))) && this.global1.allcountries[21].Gosstroy == 1 && this.global1.allcountries[21].subideology == 10 && ((this.global1.allcountries[45].Gosstroy <= 1 && this.global1.allcountries[45].isSEV && !this.global1.allcountries[7].isOVD && this.greece_ally > 6) || (this.global1.allcountries[45].Gosstroy <= 1 && this.global1.allcountries[45].isSEV && !this.global1.allcountries[7].isOVD && this.greece_ally <= 5) || this.global1.data[161] == 1 || this.global1.data[161] == 3) && this.global1.allcountries[29].Gosstroy == 1)
				{
					this.text_fake += this.dlce1.credits_text[373];
				}
				else if ((this.global1.data[0] >= 49 && this.global1.data[0] <= 51 && this.global1.data[161] == 4 && this.global1.data[114] != 100 && ((this.global1.allcountries[15].Gosstroy == 9 && this.global1.allcountries[6].Gosstroy != 2 && this.global1.allcountries[5].Gosstroy != 2 && this.global1.allcountries[4].Gosstroy != 2 && this.global1.allcountries[3].Gosstroy != 2 && this.global1.allcountries[2].Gosstroy != 2 && this.global1.allcountries[7].Gosstroy == 2 && this.global1.data[148] == 1 && this.global1.data[0] == 49) || (this.global1.data[136] == 1 && this.global1.data[0] == 50) || (this.global1.data[118] == 1 && this.global1.data[0] == 51))) || (this.global1.allcountries[15].Gosstroy == 2 && this.global1.allcountries[6].Gosstroy != 0 && this.global1.allcountries[5].Gosstroy != 0 && this.global1.allcountries[4].Gosstroy != 0 && this.global1.allcountries[3].Gosstroy != 0 && this.global1.allcountries[2].Gosstroy != 0 && this.global1.allcountries[6].isSEV && this.global1.allcountries[5].isSEV && this.global1.allcountries[4].isSEV && this.global1.allcountries[3].isSEV && this.global1.allcountries[2].isSEV && this.global1.allcountries[7].Gosstroy == 2 && !this.global1.allcountries[7].isSEV))
				{
					this.text_fake += this.dlce1.credits_text[374];
				}
				else if (this.global1.allcountries[7].paths == 3 && this.global1.event_done[1079])
				{
					this.text_fake += this.dlce1.credits_text[375];
				}
				else if (this.global1.allcountries[7].paths == 2)
				{
					this.text_fake += this.dlce1.credits_text[376];
					if (this.global1.allcountries[2].Vyshi && this.global1.allcountries[5].Vyshi)
					{
						this.text_fake += " Special attention was given to strengthening the new members of the treaty – the Baltic states, Poland, Romania, and Finland, who were frightened by the revanchism of the new authorities in Moscow. Peacekeeping contingents from the alliance countries were deployed to the territories of Ruthenia and Moldova with the approval of local governments. There were even skirmishes along the Moldova-Transnistria border, but the local peacekeeping corps of the RDR managed to prevent the crisis from escalating into a more active phase.";
					}
					else if (this.global1.allcountries[2].Vyshi)
					{
						this.text_fake += " Special attention was given to strengthening the new members of the treaty – the Baltic states, Poland, and Finland, who were frightened by the revanchism of the new authorities in Moscow. Peacekeeping contingents from the alliance countries were introduced into the territory of Ruthenia with the approval of the local government.";
					}
					else
					{
						this.text_fake += " The program was aimed at strengthening the new members of the alliance – Lithuania, Latvia, Estonia, and Finland, who were frightened by the revanchism of the new authorities in Moscow. Special attention was also given to enhancing the defense capabilities of Ruthenia, which the U.S. and their European allies hesitated to fully integrate into NATO.";
					}
					this.text_fake += " Concerns continue to mount over the nuclear legacy of the USSR: the nuclear blackmail by the authorities of the RDR has prevented the countries of the North Atlantic Alliance from providing more substantial assistance to those republics that have fallen under the control of national Bolshevism. By the end of the 1990s, it becomes evident that Europe, after several years of calm, is once again treading the path of bloc confrontation, leading to an impending crisis of international tension.";
				}
				else if (this.global1.data[45] == 8)
				{
					if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[52] * 50 >= 1200)
					{
						this.text_fake += this.dlce1.credits_text[377];
						if (this.liberalEaEu > 1)
						{
							this.text_fake += this.namelibEaEu;
							this.text_fake = this.text_fake.Remove(this.text_fake.Length - 2);
							this.text_fake += " - joined NATO after the new wave of expansion that took place in 2005.";
						}
						else if (this.liberalEaEu == 1)
						{
							this.text_fake += this.namelibEaEu;
							this.text_fake = this.text_fake.Remove(this.text_fake.Length - 2);
							this.text_fake += " - joined NATO after the new wave of expansion that took place in 2005. ";
						}
						else
						{
							this.text_fake += this.namelibEaEu;
							this.text_fake = this.text_fake.Remove(this.text_fake.Length - 2);
							this.text_fake += " Thanks to the successes of Soviet diplomacy, Moscow managed to conclude a series of agreements with former members of the Warsaw Pact, who renounced their aspirations to join the North Atlantic Alliance while maintaining a common neutral status. ";
						}
						this.text_fake += "This led to a cooling of relations between Moscow and Brussels, particularly in light of the escalating conflict in the Caucasus between Georgia and the allied republics. Nevertheless, de facto both sides have accepted the new rules and currently have no plans to violate them.";
					}
					else if ((double)this.global1.allcountries[17].Westalgie + (double)this.global1.data[7] * 0.9 + (double)(this.global1.data[52] * 50) >= 800.0)
					{
						this.text_fake += this.dlce1.credits_text[378];
						for (int n = 2; n < 5; n++)
						{
							if (this.global1.allcountries[n].Gosstroy == 1 || this.global1.allcountries[n].Gosstroy == 2)
							{
								this.auth++;
								this.text_fake = this.text_fake + this.global1.allcountries[this.global1.data[0]].name + ", ";
								this.text_fake = this.text_fake.Remove(this.text_fake.Length - 1);
								this.text_fake += "and, ";
							}
						}
						this.text_fake = this.text_fake.Remove(this.text_fake.Length - 2);
						if (this.auth == 1)
						{
							this.text_fake += "Nevertheless, Gromov's efforts to stir up instability in Europe did not go unnoticed, and within this barrier of Eastern European countries, there is a breach in the form of ";
						}
						else if (this.auth > 1)
						{
							this.text_fake += "Nevertheless, Gromov's efforts to stir up instability in Europe did not go unnoticed, and within this barrier of Eastern European countries, there are breaches in the form of ";
						}
						for (int num = 2; num < 5; num++)
						{
							if (this.global1.allcountries[num].Gosstroy == 0 || this.global1.allcountries[num].Gosstroy == 9)
							{
								this.text_fake = this.text_fake + this.global1.allcountries[this.global1.data[0]].name + ", ";
								this.text_fake = this.text_fake.Remove(this.text_fake.Length - 1);
								this.text_fake += "and, ";
							}
						}
						if (this.auth >= 1)
						{
							this.text_fake = this.text_fake.Remove(this.text_fake.Length - 2);
						}
						if (this.auth == 1)
						{
							this.text_fake += " , occupying a position of benevolent neutrality towards Moscow.";
						}
						else if (this.auth > 1)
						{
							this.text_fake += " , occupying a position of benevolent neutrality towards Moscow.";
						}
						this.text_fake += " By the end of the 2010s, NATO had returned to viewing the Union as its primary adversary, fueled by various analysts' forecasts of an impending invasion of the Baltics by Moscow. To counter this, rapid response strike groups are being amassed along the entire border with the USSR, while military analysts predict that in the coming years, the first full-scale military conflict involving both the Union and NATO will unfold...";
					}
					else
					{
						this.text_fake += this.dlce1.credits_text[379];
					}
				}
				else if (this.global1.data[45] == 10)
				{
					this.text_fake += this.dlce1.credits_text[380];
				}
				else if (this.global1.allcountries[7].Gosstroy == 0 && this.global1.event_done[62])
				{
					this.text_fake += this.dlce1.credits_text[381];
				}
				else if (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy != 2)
				{
					this.text_fake += this.dlce1.credits_text[382];
					if (this.global1.allcountries[1].Vyshi)
					{
						this.text_fake += " Thus, on the territory of Germany, large-scale exercises titled \"Steadfast Warrior\" took place, aimed at implementing a whole range of operations – from counterinsurgency to amphibious landings (to which Soviet observers were also invited).";
					}
					else
					{
						this.text_fake += " Thus, full-scale exercises titled \"Fateful Glory\" took place in Turkey and the Aegean Sea, aimed at enhancing the defensive capabilities of alliance forces in the southern region.";
					}
					this.text_fake += " In 1993, the \"Doctrine of Limited Deterrence\" was approved, envisioning the strengthening of the southern and southeastern flanks of the alliance, albeit without the direct deployment of troops at the borders of the new Soviet sphere. However, a couple of years later, the idea of a new détente began to linger in the air, though it remains unclear whether it can materialize into something more concrete.";
				}
				else if (this.global1.allcountries[7].Gosstroy == 2 && !this.global1.allcountries[7].Vyshi)
				{
					this.text_fake += this.dlce1.credits_text[383];
				}
				else if (this.global1.allcountries[7].isOVD)
				{
					this.text_fake += this.dlce1.credits_text[384];
					if ((((this.global1.data[37] < 6 || !this.global1.allcountries[31].Help) && this.global1.data[37] < 7) || (this.global1.data[0] == 12 || this.global1.allcountries[7].Vyshi || (!this.global1.allcountries[7].isSEV && !this.global1.allcountries[16].isSEV && this.global1.allcountries[19].Gosstroy > 1)) || this.global1.allcountries[12].Gosstroy != 9) && (((this.global1.data[37] < 8 || !this.global1.allcountries[31].Help) && this.global1.data[37] < 9) || this.global1.data[0] == 12 || this.global1.allcountries[7].Vyshi || (!this.global1.allcountries[7].isSEV && !this.global1.allcountries[16].isSEV && this.global1.allcountries[19].Gosstroy > 1)))
					{
						this.text_fake += " With the loss of the old threat, the alliance began to seek a new target, one that could unite the treaty members, and ultimately, following the terrorist attacks of September 11 2001, international terrorism emerged as that enemy, finding refuge in the Taliban-controlled parts of Afghanistan, as well as in several other Islamic states. The Collective Security Treaty Organization also resolutely condemned the actions of the terrorists and supported NATO's new strategy to combat manifestations of Islamic radicalism and banditry. Both old foes are uniting their forces in a common struggle, but will they succeed in overcoming their challenges, considering that the civil war in Afghanistan is soon to enter its second decade, with no end in sight?";
					}
					else if (this.global1.allcountries[14].subideology == 3)
					{
						this.text_fake += " With the loss of the old threat, the alliance began to seek a new target, the opposition to which could unite the members of the treaty, and ultimately, following the terrorist attacks of September 11, 2001, international terrorism emerged as that enemy, having found refuge, according to American intelligence, in the territory of Iraq. The CSTO also resolutely condemned the actions of the terrorists; however, it approached the anti-Iraqi statements with caution.";
						if (this.global1.data[51] + this.global1.data[52] * 3 > 10)
						{
							this.text_fake += " Despite expectations or fears, Boris Pugo did not dare to sacrifice the normalized relations with NATO countries and provide assistance to the increasingly despotic and Islamizing regime of Saddam Hussein. A new military operation is being prepared against Baghdad, and it seems that this time he will find himself utterly alone.";
						}
						else
						{
							this.text_fake += " At the same time, Vladimir Zhirinovsky launched a sharp critique of the threats to Iraq. \"George, your soldiers will be torn to shreds here. 250,000 elite soldiers of Iraq! They will tear everything apart. They will cross the entire desert in just one hour!\" He also warned that if the U.S. sought to invade Iraq, the USSR would not stand idly by. Ultimately, Washington had to cancel the planned operation, and a new UN mission was introduced into Iraq, tasked with destroying all the weapons of mass destruction stockpiled by Hussein. Unofficially, under pressure from Moscow, Baghdad began its fight against Islamic terrorism within its borders, which it had previously de facto turned a blind eye to.";
						}
					}
					else
					{
						this.text_fake += " With the loss of the old threat, the alliance began to seek a new target, one that could unite the treaty participants, and ultimately, following the terrorist attacks of September 11, 2001, international terrorism emerged as that enemy, having found refuge, according to American intelligence, on Iranian soil. The Collective Security Treaty Organization also resolutely condemned the actions of the terrorists; however, it approached the anti-Iranian statements with caution. The planned operation against Tehran lacks support both within the alliance and beyond. It is quite likely that the United States will carry it out alone...";
					}
				}
				else if (!this.global1.allcountries[7].isOVD && this.global1.allcountries[this.global1.data[0]].isOVD)
				{
					this.text_fake += " After the Soviet Union left the Warsaw Pact, the North Atlantic Council issued an official statement welcoming the \"liberation of Eastern Europe from Soviet military presence\" and the \"sovereign right of states to choose their own security paths\". However, the alliance was wary of the uncertainty surrounding the states that remained in the military treaty, which was no longer under Moscow's control. ";
					this.auth = 1000;
					for (int num2 = 0; num2 < this.global1.allcountries.Length; num2++)
					{
						if (this.global1.allcountries[num2].Gosstroy == 0)
						{
							this.auth++;
						}
						else if (this.global1.allcountries[num2].Gosstroy == 1)
						{
							this.auth += 10;
						}
						else if (this.global1.allcountries[num2].Gosstroy == 2 || this.global1.allcountries[num2].subideology == 2)
						{
							this.auth += 100;
						}
						else if (this.global1.allcountries[num2].Gosstroy == 9)
						{
							this.auth += 1000;
						}
					}
					if (this.global1.data[10] > 400)
					{
						this.text_fake += " The policies pursued by certain countries of the new alliance, aimed at countering democratization and undermining the influence of the Western world, along with the identified human rights violations, have led to the perception that this new military bloc in the heart of Europe is even more dangerous and deserving of opposition than the former Warsaw Pact. Thus, construction of new military infrastructure has begun along the border with Eastern European countries, and in 1995, large-scale exercises called \"Determined Resolve\" took place in Bavaria, involving representatives from most of the countries within the alliance. There is also a certain advantage for the alliance in all of this—the sentiments that began to spread at the turn of this decade regarding the advisability of NATO's continued existence quickly subsided, and the North Atlantic Treaty found a new perilous threat to counter.";
					}
					else if (this.auth % 10 >= this.auth % 100 / 10 && this.auth % 10 >= this.auth / 1000 - 1 && this.auth % 10 >= this.auth % 1000 / 100)
					{
						this.text_fake += " Due to the conservatism of the majority of participants in the Eastern European alliance and the stability of the neosocialist regimes, NATO harbors concerns that the North Atlantic Treaty will face a more serious threat from this socialist organization in the future. There is also unease regarding the remaining direct contacts and ties of the successor to the Warsaw Pact with Moscow, which, according to analysts, manages him like a shadow cardinal. As a result, a significant portion of the agreements made with the Soviet government regarding common limitations in Europe is quietly being sabotaged or delayed in its implementation.";
					}
					else if (this.auth % 100 / 10 >= this.auth % 10 && this.auth % 100 / 10 >= this.auth / 1000 - 1 && this.auth % 100 / 10 >= this.auth % 1000 / 100)
					{
						this.text_fake += " The pragmatism and reformism of most participants in the Eastern European alliance led Brussels to view it as a weaker threat than the former Warsaw Pact. NATO remains hopeful of changing the current status quo in the future and, if not directly incorporating Eastern European countries into the alliance, to establish mutually beneficial cooperation agreements.";
					}
					else if (this.auth % 1000 / 100 >= this.auth % 100 / 10 && this.auth % 1000 / 100 >= this.auth / 1000 - 1 && this.auth % 1000 / 100 >= this.auth % 10)
					{
						this.text_fake += " The newly formed economic alliance in place of the Warsaw Pact initially viewed NATO not as a threat, but as a steadfast friend and ally in the possible desire of Moscow to return to Eastern Europe. To this end, since 1991, active cooperation began, and Eastern European countries started transitioning to the standards of the North Atlantic Treaty. In 1997, a new wave of NATO expansion to the east took place, which provoked strong criticism from Moscow. And although the alliance justifies itself by claiming it no longer sees Russia as a threat, relations between the two powers have noticeably cooled.";
					}
					else
					{
						this.text_fake += " The existing closed nature and isolation of the majority of participants in the Eastern European alliance has sparked a massive wave of rumors and threats of varying degrees of credibility, which has seriously alarmed the North Atlantic Treaty. The work of various dissident organizations, portraying new countries as totalitarian and misanthropic, does not aid in the acceptance of a new structure. And although the North Atlantic Council at the highest level cautiously perceives the threat, making no serious statements, no one plans to disarm in the near future.";
					}
				}
				else
				{
					this.text_fake += "The recent political transformation in the countries of Eastern Europe could not but affect NATO's policy in the emerging new international relations and security policy in Europe. Already in 1990, at the London Summit, the Allies announced a new approach to security, moving away from nuclear deterrence and relying on political cooperation and crisis management. The central event that changed the policy of the alliance was the dismantling of its main antagonist, the Warsaw Pact Organization, whose countries to one degree or another embarked on the thorny path of democratization. ";
					if ((this.global1.data[0] < 49 || this.global1.data[0] > 51) && (this.global1.data[59] == 2 || !this.global1.allcountries[this.global1.data[0]].isOVD || (!this.global1.allcountries[5].isOVD && !this.global1.allcountries[6].isOVD) || (this.global1.data[54] < 7 && (!this.global1.allcountries[15].isOVD || this.global1.data[54] < 5)) || this.global1.allcountries[15].Help))
					{
						this.text_fake += "The series of conflicts that began almost immediately afterward in the territory of the former SFRY compelled the alliance to turn its gaze toward the Balkans. For the first time in its history, NATO stepped beyond a purely defensive doctrine, imposing an arms embargo in 1993 and initiating operations to secure \"safe zones\" in Bosnia and Herzegovina, as well as using force against Serbian militias.";
					}
					else if (this.global1.data[10] > 320 && this.global1.data[0] != 10 && this.global1.data[0] != 12 && this.global1.data[0] != 18)
					{
						this.text_fake = this.text_fake + "A significant threat to the alliance emerged in the form of - " + this.global1.allcountries[this.global1.data[0]].name + ", which effectively decided to challenge the Western world order and the evolving new security system in Europe, marking its opposition as one of the main objectives of the alliance in the 1990s. ";
					}
					else
					{
						this.text_fake += "The emerging instability in the post-Soviet space and the onset of democratization issues in several Eastern European countries compelled the alliance to carry out a limited demobilization of its forces, yet it continued to regard Russia as its competitor, albeit hypothetical, or even as a phantom threat. ";
					}
					this.text_fake += " Simultaneously, a process of expansion was underway: in 1994, the \"Partnership for Peace\" initiative was launched, aimed at integrating Eastern European countries into the Euro-Atlantic security system without immediate accession to the alliance, as there was still no consensus within NATO regarding expansion. ";
					if (this.liberalEaEu > 1)
					{
						this.text_fake += "However, by the end of the decade, despite Moscow's objections, in 1999, the following officially joined NATO - ";
						this.text_fake += this.namelibEaEu;
						this.text_fake = this.text_fake.Remove(this.text_fake.Length - 2);
						this.text_fake += ".";
					}
					else if (this.liberalEaEu == 1)
					{
						this.text_fake += "However, by the end of the decade, despite Moscow's objections, in 1999, it officially joined NATO - ";
						this.text_fake += this.namelibEaEu;
						this.text_fake = this.text_fake.Remove(this.text_fake.Length - 2);
						this.text_fake += ".";
					}
				}
			}
			else if (this.this_okno == 14 && this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
			{
				this.Name.text = "SPECIAL RESULT";
				this.text_fake = "";
				if (this.global1.data[135] <= 4)
				{
					this.global1.data[161] = 0;
				}
				else if (this.global1.data[131] != 1 && this.yug1.gameState.modifies[5] <= 0 && this.yug1.gameState.modifies[4] <= 0)
				{
					if (this.global1.data[126] == 0 && this.global1.data[115] <= 4)
					{
						this.global1.data[161] = 0;
					}
					else if (this.global1.data[126] == 0 && (this.global1.data[126] != 0 || this.global1.data[115] < 16))
					{
						this.global1.data[161] = 0;
					}
				}
				if (this.global1.data[161] == 4 && this.global1.data[114] != 100)
				{
					if (this.global1.allcountries[7].isOVD && this.global1.event_done[62])
					{
						this.text_fake = this.dlce1.credits_text[220];
						this.text_fake += this.dlce1.credits_text[229];
					}
					else if (((this.global1.allcountries[15].Gosstroy == 0 || this.global1.allcountries[51].Gosstroy == 0 || this.global1.allcountries[50].Gosstroy == 0 || this.global1.allcountries[49].Gosstroy == 0) && this.global1.allcountries[6].Gosstroy != 2 && this.global1.allcountries[5].Gosstroy != 2 && this.global1.allcountries[4].Gosstroy != 2 && this.global1.allcountries[3].Gosstroy != 2 && this.global1.allcountries[2].Gosstroy != 2 && this.global1.allcountries[7].Gosstroy == 2 && this.global1.data[148] != 1 && this.global1.data[0] == 49) || (this.global1.data[136] != 1 && this.global1.data[0] == 50) || (this.global1.data[118] != 1 && this.global1.data[0] == 51))
					{
						this.text_fake = this.dlce1.credits_text[221];
						this.text_fake += this.dlce1.credits_text[230];
					}
					else if (((this.global1.allcountries[15].Gosstroy == 9 || this.global1.allcountries[51].Gosstroy == 9 || this.global1.allcountries[50].Gosstroy == 9 || this.global1.allcountries[49].Gosstroy == 9) && this.global1.allcountries[6].Gosstroy != 2 && this.global1.allcountries[5].Gosstroy != 2 && this.global1.allcountries[4].Gosstroy != 2 && this.global1.allcountries[3].Gosstroy != 2 && this.global1.allcountries[2].Gosstroy != 2 && this.global1.allcountries[7].Gosstroy == 2 && this.global1.data[148] == 1 && this.global1.data[0] == 49) || (this.global1.data[136] == 1 && this.global1.data[0] == 50) || (this.global1.data[118] == 1 && this.global1.data[0] == 51))
					{
						this.text_fake = this.dlce1.credits_text[222];
						this.text_fake += this.dlce1.credits_text[231];
					}
					else if ((this.global1.allcountries[15].Gosstroy == 2 || this.global1.allcountries[51].Gosstroy == 2 || this.global1.allcountries[50].Gosstroy == 2 || this.global1.allcountries[49].Gosstroy == 2) && this.global1.allcountries[6].isSEV && this.global1.allcountries[5].isSEV && this.global1.allcountries[4].isSEV && this.global1.allcountries[3].isSEV && this.global1.allcountries[2].isSEV && this.global1.allcountries[7].Gosstroy == 2 && !this.global1.allcountries[7].isSEV)
					{
						this.text_fake = this.dlce1.credits_text[223];
						this.text_fake += this.dlce1.credits_text[232];
					}
					else if ((this.global1.allcountries[15].Gosstroy == 2 || this.global1.allcountries[51].Gosstroy == 2 || this.global1.allcountries[50].Gosstroy == 2 || this.global1.allcountries[49].Gosstroy == 2) && this.global1.allcountries[7].Gosstroy == 2)
					{
						this.text_fake = this.dlce1.credits_text[224];
						this.text_fake += this.dlce1.credits_text[233];
					}
					else if (this.global1.allcountries[6].isSEV && this.global1.allcountries[5].isSEV && this.global1.allcountries[4].isSEV && this.global1.allcountries[3].isSEV && this.global1.allcountries[2].isSEV && !this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD)
					{
						this.text_fake = this.dlce1.credits_text[225];
						this.text_fake += this.dlce1.credits_text[234];
					}
					else
					{
						this.text_fake = this.dlce1.credits_text[226];
						this.text_fake += this.dlce1.credits_text[235];
					}
				}
				else if (this.yug1.gameState.yugcountries[0].is_independent && this.yug1.gameState.yugcountries[1].is_independent && this.global1.data[161] == 1 && this.global1.allcountries[45].Gosstroy < 2)
				{
					this.text_fake = this.dlce1.credits_text[227];
					this.text_fake += this.dlce1.credits_text[236];
				}
				else if (this.global1.data[161] == 1)
				{
					this.text_fake = this.dlce1.credits_text[117];
					this.text_fake += this.dlce1.credits_text[118];
					if (this.global1.allcountries[27].Torg && !this.global1.event_done[441])
					{
						this.text_fake += "Austria has also shown special interest in the organization, which is going to become a full-fledged member by the year 2000.";
					}
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(80);
					}
				}
				else
				{
					this.text_fake = "Nothing special";
				}
			}
			else if (this.this_okno == 14)
			{
				this.Name.text = "SPECIAL RESULT";
				this.text_fake = "";
				if (this.global1.data[0] == 20 && this.global1.data[56] >= 100)
				{
					if (this.global1.data[11] == 0)
					{
						this.text_fake += "||<color=purple>Center of the Islamic Socialism";
						this.text_fake += "|</color>Nedzhmie Hoxha became the first woman leader of a religious state in history, vividly showing the entire progressiveness of Islamic socialism, which combines the best of the teachings of the founders of the Muslim religion and the achievements of the most humane and just of all possible systems that the world has ever seen - socialism. Religion and ideology united, ending their animosities and thereby proving that the desire for peace and prosperity is part of human nature. Imams and zealous preachers do not allow corruption to grow, and the people find solace in the religion or ideology of the party that has come close to its people. ";
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(52);
						}
					}
					else if (this.global1.data[11] == 2)
					{
						this.text_fake += "||<color=purple>Islamic Republic of Albania";
						this.text_fake += "|</color>Perestroika in Albania followed the path of Iran. The internal political consequences of the revolution were manifested in the establishment of the theocratic regime of the Muslim clergy in the country and the increasing role of Islam absolutely in all spheres of life. The country was headed by the President, bourgeois democracy was established and civil liberties were expanded, but religious leaders received special rights. For example, they can collectively veto any law of secular power or submit their own bill, which the secular authorities must adopt. Reliance on religion allowed the APT to reborn and survive a severe crisis, opening the country to the whole world. Warm relations were established with Turkey, Arab countries and Iran. Let life by the laws of Shari'ah restrict the rights of citizens and nations, but this is much better than complete isolation, and the new friends of Albania are glad to welcome it in the ranks of countries that carry the word of Islam to this world. ";
					}
					if (this.global1.iron_and_blood && this.global1.data[62] > 4)
					{
					}
				}
				else if (this.global1.data[0] == 18)
				{
					if (this.global1.iron_and_blood && this.global1.data[14] <= 3 && this.global1.data[11] == 2 && this.global1.allcountries[44].Torg && this.global1.allcountries[44].Gosstroy <= 1)
					{
						this.achieves.GetComponent<achievements>().Set(62);
					}
					if (this.global1.allcountries[7].Gosstroy == 0 && this.global1.data[10] >= 800 && this.global1.data[14] <= 1 && this.global1.regions[1].buildings[0].type == 23)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(61);
						}
						this.text_fake += "||<color=purple>Second Caribbean Crisis";
						this.text_fake += "|</color>Viktor Alksnis managed to crush separatism in the Soviet republics and prevent the collapse of the socialist camp. However, after the end of the arms race and the Cold War, relations between the two countries again escalated. Alksnis' tough policy towards the Eastern Bloc countries led to retaliatory measures from the United States, which, in turn, began a program of enhanced re-equipment of missile launchers in Western countries, which particularly affected Germany and Turkey. US President George H.W. Bush demanded that the Soviet Union immediately withdraw troops from the territory of the Warsaw Pact countries, and also threatened military intervention to \"restore democracy\". The response of the USSR came not long after: Soviet secret missiles arrived in Cuba under the guise of convoys with food aid. After some time, the American reconnaissance aircraft, despite the strict secrecy of the entire event, found military personnel who were installing these missiles near the Soviet military base. The new Caribbean crisis once again hung over the world, but this time the situation was much more serious. However, in the end, George H.W. Bush had to make concessions, stopping militarization and exercises in NATO countries, and the USSR again withdrew its missiles from Cuba. The start date of the Third World War was again postponed, but for how long?";
					}
					else if (!this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD && this.global1.data[77] > 0)
					{
						this.text_fake += "||<color=purple>Island of socialism";
						this.text_fake += "|</color>Cuba became a complete socialist orphan in Latin America after collapse of the Soviet Union. In 1992 the United States of America had become the hegemon of world politics, started pushing its ”democratic” policy and seriously tightened their sanctions against us. Cuba greatly suffered the loss of fraternal allied countries, but it managed to survive in hostile surroundings and continue to develop in the new XXI century, with support of the military officer Hugo Chavez, who won the venezuelan elections, and bolivian socialist Evo Morales, thus giving lots of problems to the USA.";
					}
					else if ((this.global1.allcountries[7].isSEV || this.global1.allcountries[7].isOVD) && (this.global1.data[77] > 0 || this.global1.is_gkchp))
					{
						this.text_fake += "||<color=purple>Front line";
						this.text_fake += "|</color>Socialist camp continues to exist and cooperate with Cuba, whereby the economic crisis passed in a lighter form and american attempts to tighten sanctions against Cuba were condemned by the eastern block and the United Nations. Cuban revolution continues. Viva Cuba!";
					}
					else if (!this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD && this.global1.data[77] == 0)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(60);
						}
						this.text_fake += "||<color=purple>Restoration";
						this.text_fake += "|</color>Due to worsening situation in the socialist camp we had to return to the idea of cooperation with those who we wanted to cooperate with before our friendship with Khruschev – the United States. Thanks to improved relations between our countries, the embargo was lifted and it saved our stagnating economy from complete crash. Now everything came back to its place – Cuba is again a patrimony of the USA, which is visited by crowds of american tourists. Under pressure of President Bush we had to allow american investors in our country. Now in Cuba there is again US monopoly on production of sugar and tabacco, as well as mass spread of brothels and gambling with which our police is having ”viscous struggle”. Some journalists, which we had to arrest due to false accusations against our government, call our leader ”new Batista” and ”traitor of Cuban revolution”, but they are so wrong!  ";
					}
					else if (this.global1.data[45] != 5 && this.global1.data[77] == 0)
					{
						this.text_fake += "||<color=purple>Renovation";
						this.text_fake += "|</color>Socialist camp continues to exist, but under Gorbachev’s pressure we still had to go to negotiations with the United States, in result of which the embargo was lifted. Now a new era has began for our economy - energy crisis eventually ended and development of tourism under tight control of the state allowed us to increase amount of tourists from the whole world, which is only good for us.";
					}
					if (this.global1.data[171] == 100)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(105);
						}
						this.text_fake += "|<color=purple>Caribbean Germany</color>";
						this.text_fake += "|In the future, the existence of the «second» GDR was recognized only by the friendly governments of Hugo Chavez in Venezuela and Evo Morales in Bolivia, as well as other unrecognized states: Eritrea, Western Sahara, Somaliland, Ambazonia, the Mexican Zapatista Autonomous Municipalities, the states of Shan, Kachin and Wa, and some microstates. Western countries are actively hindering our and North Korean attempts to restore the membership of the GDR in the UN. After the death of Erich Honecker, Erich Mielke became the Chairman of the People's Chamber, and after his death, power in micro-Germany passed into the hands of Sigmund Jähn. In 1998, Hurricane Mitch caused major damage to the island (including the bust of Ernst Thalmann), but Jähn was not only able to restore the destruction on his own, but also turned the island into a tourist center where everyone could purchase East German paraphernalia (coins , books, toys, badges, etc.), making it a self-sustaining tourist paradise by 2008. At the same time, East Germans remain faithful to the ideas of Marx and do not stop political activity - it is on the island of Ernst Thalmann that the headquarters of the IMCAWP is located, and its last conference was also held. At the beginning of 2022, the micro GDR managed to achieve observer status at the UN, but still remains a state with partial international legal recognition.";
					}
				}
				else if (this.global1.data[0] == 12)
				{
					if (this.global1.data[106] == 1 && this.global1.data[81] == 0 && !this.global1.allcountries[7].Vyshi)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(66);
						}
						this.text_fake += "||<color=purple>National Reconciliation Policy";
						this.text_fake += "|</color>The DRA government succeeded in negotiating with the «moderate» part of the opposition, and after the completion of the supply of Pakistani weapons, the remaining radical Islamist opposition was defeated and the government successfully entrenched throughout Afghanistan. In 1993, the first general presidential election was held, in which the current leader of the country successfully won. The situation in the country has finally stabilized - a constitution was adopted that enshrined the dominant position of Islam and allowed the use of Sharia, and representatives of the clergy and mujahiddins also entered the new single government. The long-awaited peace has come on Afghan soil.";
					}
					else if (this.global1.data[106] == 1 && this.global1.data[81] == 0 && this.global1.allcountries[7].Vyshi)
					{
						this.text_fake += "||<color=purple>New civil war";
						this.text_fake = this.text_fake + "|</color>The collapse of the socialist camp and the cessation of assistance from the USSR seriously hit our weak economy: in the cities there was a shortage of food and fuel, electricity was not supplied for months. And, despite successful negotiations with the opposition, which ended with the creation of a coalition government, a political crisis erupts in the country, amid the economic crisis. The radical Islamic opposition won the 1993 parliamentary elections, while " + this.global1.politics_name[this.global1.data[11]] + " continues to be president. Attempts by the country's leader to prevent new centers of separatism were unsuccessful, and opposition organizations are again forming in the regions, terrorizing local residents and robbing cities. The country's future is vague, but it seems that a new fratricidal war cannot be avoided.";
					}
					else if ((this.global1.data[80] == 100 && this.global1.data[106] == 0) || (this.global1.data[80] >= 80 && this.global1.data[81] == 0 && !this.global1.allcountries[7].Vyshi && this.global1.data[106] == 0))
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(63);
						}
						this.text_fake += "||<color=purple>Victory of the revolution";
						this.text_fake += "|</color>Thanks to the constant assistance of the socialist camp, as well as the stubborn struggle of the Afghan peoples for freedom and a brighter future for Afghanistan, the opposition was completely defeated and fled to the territory of Pakistan in panic. Peace has finally arrived on Afghan soil, and the power of the socialists in the country has finally stabilized. Civil war is over.";
					}
					else if (this.global1.data[80] >= 40 && this.global1.data[80] <= 80 && !this.global1.allcountries[7].Vyshi && this.global1.data[106] == 0)
					{
						this.text_fake += "||<color=purple>Civil war continues";
						this.text_fake += "|</color>The USSR continued to exist, providing humanitarian and military support to Afghanistan, which helped ease its situation. Some countries, fearing the expansion of Islamic terrorists, began to put pressure on Pakistan, complicating its assistance to terrorists. But we managed to come to an agreement with China and work out a unified position to stop supporting terrorists. And although the disagreements in the party and army of the DRA were not resolved to the end, and the presidentвЂ™s policy had its flaws, the attacks of the terrorists were stopped and the DRA controls enough territories to exist further. None of the parties found a decisive advantage, so the civil war in Afghanistan continues.";
					}
					else if (this.global1.data[80] >= 20 && !this.global1.allcountries[7].Vyshi)
					{
						this.text_fake += "||<color=purple>The last frontier of defense";
						this.text_fake += "|</color>With the withdrawal of Soviet troops from Afghanistan, the situation of the regime began to deteriorate sharply. Some successful government offensives were harshly suppressed by the terrorists who launched a massive counter-offensive. As a result, the opposition moved so deep into the country that it came close to Kabul, but as a result of the courageous feats of the DRA army, was knocked back. Repeated offensive operations were either grandiose victories or terrifying defeats. And, despite the fact that the DRA controls such a small territory, thanks to the support of the USSR, it continues to exist, and the civil war only intensifies over time.";
					}
					else
					{
						this.text_fake += "||<color=purple>Strange war";
						this.text_fake += "|</color>Despite the cessation of aid from the USSR, the Democratic Republic of Afghanistan owns enough territories to continue to exist and partially fend off attacks by the opposition. The forces of terrorists and the government are always approximately equal, which does not allow one of the parties to prevail in the conflict, so the civil war continues and it is not known when it will end. ";
					}
				}
				else if (this.global1.data[0] == 10)
				{
					if (this.global1.data[68] >= 4 && this.global1.data[11] == 3)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(56);
						}
						this.text_fake += "||<color=purple>United Korea";
						this.text_fake += "|</color>Comrade Kim Young Chun pursued a brilliant policy, achieving what his predecessor could not do. Carrying out a course on «De-Kiminization» and the introduction of large-scale economic transformations, he was able to drag the DPRK from the rank of the most closed and centralized states to one of the most influential forces in world politics. Special attention should be paid to his policy regarding South Korea, which recently had been branded as «American puppet» by state propaganda. Now, after a long process of negotiations, a large-scale detente has unfolded on the Korean peninsula: the North has stopped all nuclear weapons development, and American bases have been withdrawn from the South. And now, thanks to his brilliant rule, there is no longer a «shameful border» separating the Korean people, and Korea has become a single confederate state called «The Democratic Confederate Republic of Koryo». And in 2000, in recognition of merit in the cause of peace, the President of the Republic of Korea, Kim Dae-jung and the President of the DPRK, Kim Yong-jung, jointly received the Nobel Peace Prize. Korea is henceforth united and indivisible.";
					}
					else if ((this.global1.data[68] >= 4 && this.global1.data[11] != 3) || (this.global1.data[68] >= 0 && this.global1.data[68] < 4))
					{
						this.text_fake += "||<color=purple>Truce";
						this.text_fake = this.text_fake + "|</color>Comrade " + this.global1.politics_name[this.global1.data[11]] + " was a controversial leader in the history of our country. A bad start in the economy was combined with great breakthroughs in the reunification of the Korean people. On the Korean peninsula, a relaxation of tension was carried out, and the program of families separated during the Korean War was recreated. There have also been several joint teams in some sports competing under the flag of United Korea. Inter-Korean summits take place at some intervals, demonstrating the desire of the Korean people for unity, but the future of a united Korea is still vague.";
					}
					else if ((this.global1.data[68] <= -3 && this.global1.data[11] != 1) || (this.global1.data[68] > -3 && this.global1.data[68] <= -1))
					{
						this.text_fake += "||<color=purple>Cold confrontation";
						this.text_fake += "|</color>Despite our attempts to negotiate with our southern neighbor, it turned out very badly. Any of our joint endeavors was suppressed by the excessive militarization of the North and the excessively reactionary anti-communism of the South. Of course, there is no talk of any military clashes, but the Korean peninsula is still «blowing cold», despite the end of the confrontation between the USSR and the USA. Everything continues to remain, as it was, and even hard to imagine, when the Korean people will again become one, as before.";
					}
					else if (this.global1.data[68] <= -3 && this.global1.data[11] == 1 && this.global1.science[9] && this.global1.allcountries[16].Gosstroy == 0)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(58);
						}
						this.text_fake += "||<color=purple>Well forgotten old";
						this.text_fake += "|</color>Because of the increased militarization and the aggressive foreign policy of North Korea, The United States of America, with the support of their allies, managed to get their resolution approved by the UN Security Council - to immediately intervene militarily into DPRK, to put an end to the North's  very much independent and unpredictable political course and to prevent a massive military conflict with the South. However, our old ally China helped us again, and effectively saved us, by vetoing the resolution forced thorugh by the American Imperialists and their marionettes. Now after the end of the old Cold War, a new one is brewing, now between America and China. Fear Capitalists, your last hour is nigh!";
					}
					else
					{
						this.text_fake += "||<color=purple>BUG. PLS REPORT ABOUT IT TO DEVS.</color>";
					}
				}
				else if (this.global1.data[0] == 3)
				{
					if (this.global1.data[50] < -5)
					{
						this.text_fake += "||<color=purple>Velvet divorce|</color>";
						this.text_fake = string.Concat(new string[]
						{
							this.text_fake,
							"As the situation in Czechoslovakia destabilized, the question arose of the national self-determination of the its republics. In general, despite a clear change in the political and economic course of the country, the majority of the population, both Czechs and Slovaks, were not ready for national self-determination, which was confirmed by the results of a survey conducted at that time. However, the fate of the country was in the hands of politicians who thought otherwise. Individual residents of the border areas on both sides of the new border had a negative attitude towards the division of the country. July 17 of the year ",
							(this.global1.data[21] + 1 + (8 + this.global1.data[50])).ToString(),
							" the Slovak parliament adopted a declaration of independence. The Czechoslovak President, who opposed the division, resigned. On November 25, the Federal Assembly adopted a law on the division of the country on January 1 ",
							(this.global1.data[21] + 2 + (8 + this.global1.data[50])).ToString(),
							". Velvet divorce has occured."
						});
					}
					else if (this.global1.data[50] < -2)
					{
						this.text_fake += "||<color=purple>State Union of the Czech Republic and Slovakia|</color>";
						this.text_fake += "We have given enough freedoms to the Slovaks. Despite the increased nationalism throughout the socialist camp, we were able to maintain a delicate balance in our country. From now on Czechoslovakia is becoming a confederation. Bratislava and Prague divided the responsibilities of government, reconciling the nationalists of both countries. And let the evil tongues still call us the “Monster of Versailles”, we will do everything for the sake of the prosperity of the Czech and Slovak peoples by the will of fate united in one state.";
					}
					else if (this.global1.data[50] > 5 && this.global1.data[11] != 3)
					{
						this.text_fake += "||<color=purple>One people, one nation!|</color>";
						this.text_fake += "The developed new standart language, which we had to implant in places by force on occasion, gradually became the national language among the people of our country. Nationalists of all kinds were made into resignation and their supporters found themselves behind bars or abroad, where they could not harm us. The “Cultural Exchange” policy introduced over time has allowed the people of our country not only to feel, but also to become one people. And now the Czechoslovak people are indivisible! Forward to a bright future!";
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(54);
						}
					}
					else
					{
						this.text_fake += "||<color=purple>Everything goes as it went.</color>";
					}
					if (this.global1.data[60] == 10)
					{
						this.text_fake += "||<color=purple>Tseshin is one and indivisible!</color>";
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(55);
						}
					}
				}
				else if (this.global1.data[0] == 4)
				{
					if (this.global1.data[11] == 0 && !this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD && this.global1.allcountries[4].isOVD && this.global1.allcountries[4].isSEV && this.global1.data[14] == 0 && this.global1.is_gkchp && this.global1.allcountries[7].Vyshi && this.global1.allcountries[7].Gosstroy == 2 && this.global1.eventVariantChosen[153] >= 2 && this.global1.eventVariantChosen[157] == 3)
					{
						this.text_fake = this.dlce1.credits_text[28];
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(129);
						}
					}
					else if (this.global1.data[62] >= 4 && this.global1.allcountries[15].isOVD && (this.global1.allcountries[6].isOVD || this.global1.allcountries[6].Gosstroy == 0 || this.global1.allcountries[6].Gosstroy == 9) && !this.global1.allcountries[5].Vyshi)
					{
						this.text_fake += "||<color=purple>Confederate North Korea of Europe";
						this.text_fake += "|</color>Taking advantage of the instability in the socialist camp, we were not taken aback, we took control into our own hands. Having lost Transylvania, Romania plunged into anarchy and the valiant Hungarian troops, with the support of the Bulgarians, who took control of their former lands lost in the wars of this century, established a puppet government in Romania. The next step was the insurrection of the Hungarians in Transcarpathia, which, along with the pro-Polish uprisings in the rest of Western Ukraine, destabilized the situation of the Ukrainian government, it resigned, and we entered the State of Ruthenia with our boots, which declared the independence of their lands, which has been occupied by the Ukrainian authorities since 1945. Our help to Milosevic allowed us to keep NATO busy and prolong the conflict in Yugoslavia. Taking advantage of the captured and already available resourses and technologies, a coalition of four countries, including Bulgaria, Romania, Hungary and Yugoslavia has formed. This new confederation was bristled with nuclear weapons and became a kind of confederative North Korea of Europe. Under pressure from the world community, all countries trading with Hungary, except for the faithful three allies, imposed sanctions, but withdrawing into self-isolation with captured territories and several loyal allies allowed the Hungarian state to maintain economic stability and loads of nuclear weapons stopped Kuchma from threats of nuclear cudgel (which he, however, refused to hand over to his fellow Yeltsin). ";
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(51);
						}
					}
					else if (this.global1.data[62] >= 2 && this.global1.allcountries[7].Vyshi)
					{
						this.text_fake += "From the usual and unremarkable European country, Hungary has become a force that cannot be ignored in the region and our ruler has become a symbol of the greatness and power of the Hungarian people. Unfortunately, dizziness from success did not last long. The project to provoke dissatisfaction in Transylvania was crowned with success after a hastily held referendum under the control of our unmarked units. Autonomous region of Transylvania added to the list of our lands. However, NATO did not stand aside and immediately called us an aggressor, leading troops to our borders. Following NATO, Kuchma and Yeltsin, emboldened, joined forces and began to threaten us with their nuclear clubs. ";
						if (this.global1.data[16] > 11 || this.global1.allcountries[4].Vyshi)
						{
							this.text_fake += " We had to retreat and loose all our gains and only because we opened to foreign capitals and became a new market for Western partners, we were allowed to remain sovereign. Transylvania was declared a demilitarized zone, and among the Hungarians ultra-right views are growing in numbers and social-nationalist movements are being created and strengthened in our lands, eager for revenge.";
						}
						else
						{
							this.text_fake += " We had to retreat from our conquests, and only because we firmly held the power and fought off the first attempts of the offensive by international forces and found scapegoats for the international community, we were allowed to remain sovereign. The 30-kilometer borders with Transcarpathia and Transylvania from our territory were declared a demilitarized zone, and among the Hungarians ultra-right views are growing in numbers and social-nationalist movements are being created and strengthened in our lands, eager for revenge.";
						}
					}
					else if (this.global1.data[62] >= 2 && this.global1.regions[2].buildings[0].type == 19)
					{
						this.text_fake += "From the usual and unremarkable European country, Hungary has become a force that cannot be ignored in the region and our ruler has become a symbol of the greatness and power of the Hungarian people. Unfortunately, dizziness from success did not last long. The project to ingnite dissatisfaction in Transylvania was crowned with success after a hastily held referendum under the control of our unmarked units. Autonomous region of Transylvania added to the list of our lands. However, NATO did not stand aside and immediately called us an aggressor, leading troops to our borders. Following NATO, the Soviet Union, emboldened, began to threaten us with its nuclear cudgel. ";
						if (this.global1.data[16] > 11 || this.global1.allcountries[4].Vyshi)
						{
							this.text_fake += " We had to retreat and loose all our gains and only because we opened to foreign capitals and became a new market for Western partners, we were allowed to remain sovereign. Transylvania was declared a demilitarized zone, and among the Hungarians ultra-right views are growing in numbers and social-nationalist movements are being created and strengthened in our lands, eager for revenge.";
						}
						else
						{
							this.text_fake += " We had to retreat from our conquests, and only because we firmly held the power and fought off the first attempts of the offensive by international forces and found scapegoats for the international community, we were allowed to remain sovereign. The 30-kilometer borders with Transcarpathia and Transylvania from our territory were declared a demilitarized zone, and among the Hungarians ultra-right views are growing in numbers and social-nationalist movements are being created and strengthened in our lands, eager for revenge.";
						}
					}
					else
					{
						this.text_fake = "Nothing special";
					}
				}
				else if (!this.global1.science[9] && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy >= 2)) && this.global1.data[0] == 1 && (this.global1.data[14] == 3 || (this.global1.data[14] == 2 && this.global1.data[15] >= 8 && this.global1.data[17] >= 16) || (this.global1.data[14] == 4 && this.global1.data[16] <= 12)) && ((this.global1.allcountries[17].Westalgie >= 300 && this.global1.allcountries[this.global1.data[0]].isOVD && this.global1.allcountries[7].isOVD) || (((this.global1.allcountries[17].Westalgie >= 350 && this.global1.allcountries[16].Gosstroy == 0) || this.global1.allcountries[17].Westalgie >= 400) && this.global1.allcountries[this.global1.data[0]].isSEV && (this.global1.allcountries[17].Westalgie >= 550 || (this.global1.allcountries[7].isSEV && !this.global1.is_gkchp)))))
				{
					this.text_fake += "||<color=purple>Renewal United Germany</color>";
					this.text_fake += "|<color=purple>In the FRG</color>, in the course of the reformation of the socialist world, the fall of the veil of the red threat and the flourishing of the idea of world friendship, a coalition of left-wing forces, advocating pacifism, social reforms, friendship and peace, won the next elections. The consequence of their victory was not just an establishment of relations with the GDR and the recognition of West Berlin as a demilitarized zone: the Federal Republic announced its withdrawal from NATO military structures, remaining only in political ones, and, together with the GDR, withdrew foreign military bases from its territories, signing an agreement on not the presence on the territory of both Germany of someone's troops or missiles, and about the nuclear-free status of the FRG. This was supported by both the USSR and France, but what happened next turned out to be a complete surprise - a referendum was held in the FRG on the reunification of the FRG and the GDR into a single GDR with the preservation of non-aligned status and recognition of neutrality, after which the former left functionaries of the FRG entered the government of the GDR, and the Chancellor of the FRG became the Chairman of the Council of Ministers of the new Germany.";
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(32);
					}
					if (this.global1.allcountries[27].Donat)
					{
						if (this.global1.allcountries[27].Westalgie >= 2 && this.global1.allcountries[27].Help && this.global1.allcountries[27].Stasi)
						{
							this.text_fake += this.dlce1.credits_text[360];
						}
						else if (this.global1.allcountries[27].Westalgie >= 2 && this.global1.allcountries[27].Money && this.global1.allcountries[27].Stasi)
						{
							this.text_fake += this.dlce1.credits_text[361];
						}
						else if (this.global1.allcountries[27].Stasi)
						{
							this.text_fake += this.dlce1.credits_text[362];
						}
						else if (this.global1.allcountries[27].Westalgie >= 1)
						{
							this.text_fake += this.dlce1.credits_text[363];
						}
						else
						{
							this.text_fake += this.dlce1.credits_text[364];
						}
					}
				}
				else if (this.sinochek && this.global1.data[0] == 5)
				{
					if (this.otstavnoysinochek && this.global1.data[50] == 3)
					{
						this.text_fake += "|After Ceausescu's death, his son Nicu was pushed aside from the Party by the bureaucracy, and was confirmed as a professor of physics at the University of Bucharest. However, Nicu always approached to study with laziness and ridiculed education, so it is not surprising that he remained a professor for a short time and was transferred to position of an ordinary teacher to his native lyceum, and then died of cirrhosis due to alcoholism connected with the failures of recent years.";
					}
					else if (this.global1.data[50] == 3)
					{
						this.text_fake += "|After Ceausescu's death, his son Nicu was unanimously elected as the new leader of the Party and the state. However, despite this, he had no experience and for him it was shameful to learn from others. However, all his attempts to reform has failed, as a result of which he began to drink more and spend time at recreational activities, and the power gradually passed into the hands of the party apparatus, which now manages the country behind the screen of Nicu. However, it is in the interests of the party apparatus to continue not to impede the establishment of a monarchical line of continuity of government. More and more nominal every year...";
						if (this.global1.iron_and_blood && this.global1.data[14] <= 0 && this.global1.data[34] == 11)
						{
							this.achieves.GetComponent<achievements>().Set(36);
						}
					}
					else if (this.otstavnoysinochek && this.global1.data[50] == 4)
					{
						this.text_fake += "|After Ceausescu's death, his son Valentin was pushed aside from the Party by the bureaucracy, and was confirmed as director of the Institute of Atomic Physics in Bucharest, where he continues to work until now, without interfering in politics at all. He managed to get a divorce and get married for the second time, but few people care about his fate, and he is happy to work in his favorite field and in prosperity, while the country is ruled by partocrats.";
					}
					else if (this.global1.data[50] == 4)
					{
						this.text_fake += "|After Ceausescu's death, his son Valentin was unanimously elected as the new leader of the Party and the state. Despite the fact that earlier he had little interest in politics, when he came to power, he with zealously began to solve all the problems of the state, because of what he entered into many conflicts with the party functionaries. However, in general, he continued the line of his father Nicolae, relying on long-standing loyalists, but focusing on combating corruption and the development of science.";
						if (this.global1.iron_and_blood && this.global1.data[14] <= 0 && this.global1.data[26] <= 0)
						{
							this.achieves.GetComponent<achievements>().Set(37);
						}
					}
				}
				else if (this.global1.data[42] == 10 && this.global1.data[0] == 5)
				{
					if (this.global1.data[0] == 5 && this.global1.data[11] != 0 && this.global1.data[50] == 1)
					{
						this.text_fake = this.text_fake + "|Our wise leader " + this.global1.politics_name[this.global1.data[11]] + ", when his power was finally established in the country, made a truly wise decision, which pleased the hearts of all patriots: he did not just return the hero King Mihai to the country, he restored the monarchy! The monarch, in the person of the Mihai, became the personification of the unity of our nation, a symbol of our state and a guarantor of eternal stability and preservation of the centuries-old traditions! However, in spite of this, he is endowed with only ceremonial power...";
						if (this.global1.iron_and_blood && this.global1.data[11] == 3)
						{
							this.achieves.GetComponent<achievements>().Set(38);
						}
					}
				}
				else if (this.global1.data[59] == 2 && this.global1.data[0] == 6 && !this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.data[42] != 7)
				{
					this.text_fake += "||While civil war was in full swing in Yugoslavia, we successfully introduced troops to Macedonia, where they organized their own referendum and created the Autonomous Region of Vardar after the name of the former times of the Kingdom of the Vardar Banovina, and the existence of the Macedonians themselves was refuted. Separated by the western imperialists, the Bulgarians, who had previously lived in Macedonia, recognized in the very referendum in 76% of voices themselves to be Bulgarian and desired Bulgarian citizenship. The President of Croatia, Tudman, and then the President of Serbia, Milosevic, recognized our sovereignty over Macedonia, and our allies also followed. And although most of the world does not recognize our new territories, but we are established there. I hope that now once and for all.";
					if (this.global1.iron_and_blood && this.global1.data[11] == 1 && this.global1.data[42] == 9 && !this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD)
					{
						this.achieves.GetComponent<achievements>().Set(41);
					}
				}
				else if (this.global1.data[59] == 2 && this.global1.data[0] == 6)
				{
					this.text_fake += "||While civil war was in full swing in Yugoslavia, we successfully introduced troops to Macedonia, where they organized their own referendum and created the Autonomous Region of Vardar after the name of the former times of the Kingdom of the Vardar Banovina, and the existence of the Macedonians themselves was refuted. However, such a precedent, not recognized by the West, was the main reason for the refusal of EU and NATO cooperation with us, as a result of which, under the pressure of the world community, we were forced to hold a repeated referendum where 3/4 of the Macedonian population voted for their own independence, which they received. And we got our ticket to a civilized Europe.";
				}
				else if (this.global1.data[59] == 4 && this.global1.data[0] == 6)
				{
					this.text_fake += "||Milosevic provided substantial assistance with armament, food and finance, together with Albania, we were able to settle the Albanian question peacefully: some Albanians left for Albania, and some settled in the Republic of Kosovo, which became part of the federal Yugoslavia. Then, together with the Albanians, our special services and special forces secretly took part in the war on the side of Milosevic, our allies also joined in. And before the USA ultimatums reached the UN rostrum, the war in Yugoslavia was over - quickly and decisively. Separatists were brought to trial, and their leaders were executed on air. And then, once and for all, the three countries, Yugoslavia, Albania and Bulgaria, merged into a single federation.";
					if (this.global1.data[14] > 2)
					{
						this.text_fake = this.text_fake + "|The country was headed by the federal parliament and the federal government under the leadership of the All-Union Socialist Party of Balkans, although the republican socialist parties survived. The President and General Secretary of the VSPB of the new federation became " + this.global1.politics_name[this.global1.data[11]] + ", Milosevic became Prime Minister (with retaining the powers of Vice-President), and Ramiz Alia became SPieckr of the Parliament and 2 Secretary of the VSPB. Despite the principles of preserving the ideals of socialism, the new Balkan Union State allowed for pluralism of opinions and private business in the country, although the All-Balkan Socialist Party remains the leading force in governing the country, and the state is the leading force in the economy itself.";
					}
					else if (this.global1.data[16] > 11)
					{
						this.text_fake = this.text_fake + "|The country was headed by the federal Supreme Soviet and the federal government under the leadership of the All-Union Communist Party of Balkans, although the republican communist parties survived. The Chairman of the State Council and the General Secretary of the VKPB of the new federation became " + this.global1.politics_name[this.global1.data[11]] + ", Milosevic became Chairman of the Council of Ministers, and Ramiz Alia became the Chairman of the Supreme Council and the 2nd Secretary of the VKPB. Despite the principles of preserving the ideals of socialism, the new Balkan Union State allowed the operation of frequent business in the country and the leadership of the principles of economic accounting, although the state still remains the leading force in the economy itself.";
					}
					else
					{
						this.text_fake = this.text_fake + "|The country was headed by the federal Supreme Soviet and the federal government under the leadership of the All-Union Communist Party of Balkans, although the republican communist parties survived. The Chairman of the State Council and the General Secretary of the VKPB of the new federation became " + this.global1.politics_name[this.global1.data[11]] + ", Milosevic became Chairman of the Council of Ministers, and Ramiz Alia became the Chairman of the Presidium of the Supreme Council and the 2nd Secretary of the VKPB. Despite the old Milosevic and Alia attempts to reform in sovereign Yugoslavia and Albania, which took place several years ago, all the principles of Marxism-Leninism in the leadership of the country and in the management of the economy are preserved and absolutely guarded in the new Balkan Socialist Union State.";
						if (this.global1.iron_and_blood && this.global1.data[11] == 0 && this.global1.data[50] == 9)
						{
							this.achieves.GetComponent<achievements>().Set(40);
						}
					}
				}
				else if (this.global1.data[0] == 6 && this.global1.data[130] == 100)
				{
					if (this.global1.data[16] <= 11)
					{
						this.text_fake += "|The General Secretary managed to combine conflicting ideas into a single whole - monarchical socialism! The tsar, as before, is the symbol of the nation and the guarantor of the stability and prosperity of the country, and the well-being of the population is ensured by the people's socialist state. On the other hand, former allies condemn us for perverting Marxist teachings, while the West accuses us of chauvinism.";
					}
					else
					{
						this.text_fake += "|We have returned Bulgaria to its historical face. The tsar is again the guarantor of stability and prosperity in the country, and communism is out of the question. Simeon II proudly announced the creation of the Fourth Bulgarian Kingdom, in which the principles of the Constitutional Monarchy and People's Democracy are strictly guarded. And all this despite the fact that the former allies now do not want to have anything to do with us. But do we really need them?";
					}
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(68);
					}
				}
				else if (this.global1.data[0] == 2 && (this.global1.data[50] == 20 || this.global1.data[60] <= -10))
				{
					if (this.global1.data[50] == 20)
					{
						this.text_fake = string.Concat(new string[]
						{
							"In ",
							(this.global1.data[21] + 1).ToString(),
							", we proudly opened our cosmodrome and launched the first domestic satellite! After 5 years, in ",
							(this.global1.data[21] + 6).ToString(),
							", we successfully launched the animals into space and their return passed without problems. In ",
							(this.global1.data[21] + 8).ToString(),
							" our shuttles, based on Soviet models (including those bought from the USSR \"Buran\"), first entered the international market and for several years we became the leader of their supplies. Now we are already full members of the ISS project and own our own segment of the station. Now every Pole proudly can say that Poland can into space!|"
						});
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(46);
						}
					}
					if (this.global1.data[60] <= -10)
					{
						if (!this.global1.allcountries[7].Vyshi)
						{
							this.text_fake += "After the failure of the State Committee on the State of Emergency, we decided to organize the Prometheus Project, reworking an old version of the interwar period, which was aimed at dismembering the USSR by force. First, the renewed Prometheus seemed to be a successful project for us, but then, after Yeltsin's defeat, he dragged on: our networks and organizations for a long time on an equal footing fought with the Inter-republican Security Service of the USSR and local nationalists competitive with us. But it all ended with the coming to power of the new President of the Soviet Union: he paid special attention to the organizations and networks that we controlled, once and for all stoping our Project. And it's time to admit - Prometheus has failed.";
						}
						else if (this.global1.allcountries[7].Vyshi && (this.global1.allcountries[this.global1.data[0]].Vyshi || (!this.global1.science[9] && this.global1.data[50] != 20) || this.military_ally <= 2 || this.economy_ally <= 4))
						{
							this.text_fake += "After the failure of the State Committee on the State of Emergency, we decided to organize the Prometheus Project, reworking an old version of the interwar period, which was aimed at dismembering the USSR by force. We paid special attention to Ukraine, Belarus and Lithuania. In Belarus, everything started and went well: historical societies and nationalist organizations called for a centuries-old historical connection with Poland and soon an agreement was signed on the creation of the Union State of Poland and Belarus, a single economic space with military commitments. But the deepening did not go any further after the Ukrainian nationalists supported by us began to praise the OUN-UPA (responsible for the genocide of the Poles in cooperation with the Nazis during the Second World War), and then, after our outrage, opposed us together with the oligarchs , remembering to the Poles all minor and big grievances. With our help, in Ukraine, a nationalist oligarchic regime has been formed, which is very unfortunate. And all this put an end to our attempts in Lithuania.";
						}
						else if (this.global1.allcountries[7].Vyshi && (this.global1.science[9] || this.global1.data[50] == 20) && this.military_ally > 2 && this.economy_ally > 4)
						{
							if (this.global1.data[14] <= 3 && this.global1.data[16] <= 12)
							{
								this.text_fake += "After the failure of the State Committee on the State of Emergency, we decided to organize the Prometheus Project, reworking an old version of the interwar period, which was aimed at dismembering the USSR by force. We paid special attention to the left-nationalist organizations of Ukraine, Belarus and Lithuania. In Belarus, everything started and went well: historical societies and nationalist organizations called for a centuries-old historical connection with Poland. Everything went well in Ukraine, where people who were tired of oligarchs and yearly poverty, especially a lot of unemployed and young people, responded with joy to the ideas, that we promoted, and social party programs for members. The main supporters of our operation were the national-syndicalists, national-communists and the social-nationalists, who formed a coalition and, during mass rallies and the seizure of the administration buildings, eventually came to power. The next step was the possibility of creating a confederation of our three states in the form of the Socialist Union of Eastern Europe. And the victory of the left-nationalist coalition of Frontas in the elections in Lithuania (of course, with our support). Frontas, while denying the Soviet occupation, claims that Lithuanians were shot by Lithuanian snipers in 1991 (calling Gorbachev to be tried), but is preparing an application for Lithuania's accession to our SUEE, as the fourth member.";
								if (this.global1.iron_and_blood)
								{
									this.achieves.GetComponent<achievements>().Set(45);
								}
							}
							else
							{
								this.text_fake += "After the failure of the State Committee on the State of Emergency, we decided to organize the Prometheus Project, reworking an old version of the interwar period, which was aimed at dismembering the USSR by force. We paid special attention to the right-nationalist organizations of Ukraine, Belarus and Lithuania. In Belarus, everything started and went well: historical societies and nationalist organizations called for a centuries-old historical connection with Poland. Everything went well in Ukraine, where people who were tired of oligarchs and yearly poverty, especially a lot of unemployed and young people, responded with joy to the ideas, that we promoted, and social party programs for members. The main supporters of our operation were national-conservatives, neo-fascists and the social-nationalists who formed a coalition and, during mass rallies and the seizure of administration buildings, eventually came to power. The next step was the possibility of creating a Confederation of Eastern Europe from three of our states. And the victory of the right-nationalist coalition Young Lithuania in the elections in Lithuania (of course, with our support). Young Lithuania, although it tends to revise the sins of Hitler's times and praise the former legionaries of the Lithuanian SS battalions, but is preparing an application for Lithuania's entry into our CEE, as the fourth member.";
								if (this.global1.iron_and_blood)
								{
									this.achieves.GetComponent<achievements>().Set(45);
								}
							}
						}
						else
						{
							this.text_fake += "After the failure of the State Committee on the State of Emergency, we decided to organize the Prometheus Project, reworking an old version of the interwar period, which was aimed at dismembering the USSR by force. We paid special attention to Ukraine, Belarus and Lithuania. In Belarus, everything started and went well: historical societies and nationalist organizations called for a centuries-old historical connection with Poland, but current government started, with the support of Russia, to resist them and this confrontation resulted in the victory of the pro-Russian candidate Alexander Lukashenko. Belarus withdrew to the Russian sphere of influence, which affected badly to Ukraine, where Ukrainian nationalists supported by us began to praise the OUN-UPA (responsible for the genocide of the Poles in cooperation with the Nazis during the Second World War), and then, after our outrage, opposed us together with the oligarchs , remembering to the Poles all minor and big grievances. With our help, in Ukraine, a nationalist oligarchic regime has been formed, which is very unfortunate. And all this put an end to our attempts in Lithuania.";
						}
					}
				}
				else
				{
					this.text_fake = "Nothing special";
				}
				if (this.global1.data[0] == 6 && this.global1.data[50] == 9 && (this.global1.data[42] == 2 || this.global1.data[42] == 4 || this.global1.data[42] == 6 || this.global1.data[42] == 9 || (this.global1.data[42] == 8 && this.global1.data[43] == 2)))
				{
					this.text_fake = this.text_fake + "|After the great " + this.global1.politics_name[this.global1.data[11]] + " died, his body was laid in the Mausoleum, where he is at peace with Dimitrov and now became part of the school program - visiting the memorable places of Bulgarian history.";
				}
			}
			else if (this.this_okno == 15 && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51)
			{
				if (!this.global1.event_done[371] && this.global1.data[164] <= 5)
				{
					this.Name.text = this.dlce1.credits_text[158];
					this.text_fake = this.dlce1.credits_text[177];
				}
				else if (this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 + this.global1.data[6] / 10 + this.global1.data[8] / 20 >= 1350)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(108);
					}
					this.Name.text = this.dlce1.credits_text[160];
					this.text_fake = this.dlce1.credits_text[165];
				}
				else if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[10] > 1600)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(110);
					}
					this.Name.text = this.dlce1.credits_text[162];
					this.text_fake = this.dlce1.credits_text[167];
				}
				else if (this.global1.event_done[382] && this.global1.data[164] <= 5)
				{
					this.Name.text = this.dlce1.credits_text[158];
					this.text_fake = this.dlce1.credits_text[163];
				}
				else if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 >= 1000)
				{
					this.Name.text = this.dlce1.credits_text[186];
					this.text_fake = this.dlce1.credits_text[187];
				}
				else if (this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie >= 300)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(109);
					}
					this.Name.text = this.dlce1.credits_text[161];
					this.text_fake = this.dlce1.credits_text[166];
				}
				else
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(107);
					}
					this.Name.text = this.dlce1.credits_text[159];
					this.text_fake = this.dlce1.credits_text[164];
				}
			}
			else if (this.this_okno == 16 && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51)
			{
				if (this.global1.data[214] == 1 && this.global1.data[7] / 10 + this.global1.data[8] / 10 + this.global1.data[6] / 20 >= 130 && this.global1.data[10] <= 400)
				{
					if (this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 + this.global1.data[6] / 10 + this.global1.data[8] / 20 >= 1350)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(135);
						}
						this.Name.text = this.dlce1.credits_text[304];
						this.text_fake = this.dlce1.credits_text[305];
					}
					else if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[10] > 1600)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(135);
						}
						this.Name.text = this.dlce1.credits_text[280];
						this.text_fake = this.dlce1.credits_text[281];
					}
					else if (this.global1.event_done[382] && this.global1.data[164] <= 5)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(135);
						}
						this.Name.text = this.dlce1.credits_text[274];
						this.text_fake = this.dlce1.credits_text[275];
					}
					else if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 >= 1000)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(135);
						}
						this.Name.text = this.dlce1.credits_text[298];
						this.text_fake = this.dlce1.credits_text[299];
					}
					else if (this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie >= 300)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(135);
						}
						this.Name.text = this.dlce1.credits_text[292];
						this.text_fake = this.dlce1.credits_text[293];
					}
					else
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(135);
						}
						this.Name.text = this.dlce1.credits_text[286];
						this.text_fake = this.dlce1.credits_text[287];
					}
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(135);
					}
				}
				else if (this.global1.data[214] == 1 && this.global1.data[10] <= 400)
				{
					if (this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 + this.global1.data[6] / 10 + this.global1.data[8] / 20 >= 1350)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(135);
						}
						this.Name.text = this.dlce1.credits_text[304];
						this.text_fake = this.dlce1.credits_text[305];
					}
					else if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[10] > 1600)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(135);
						}
						this.Name.text = this.dlce1.credits_text[282];
						this.text_fake = this.dlce1.credits_text[283];
					}
					else if (this.global1.event_done[382] && this.global1.data[164] <= 5)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(135);
						}
						this.Name.text = this.dlce1.credits_text[276];
						this.text_fake = this.dlce1.credits_text[277];
					}
					else if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 >= 1000)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(135);
						}
						this.Name.text = this.dlce1.credits_text[300];
						this.text_fake = this.dlce1.credits_text[301];
					}
					else if (this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie >= 300)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(135);
						}
						this.Name.text = this.dlce1.credits_text[294];
						this.text_fake = this.dlce1.credits_text[295];
					}
					else
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(135);
						}
						this.Name.text = this.dlce1.credits_text[288];
						this.text_fake = this.dlce1.credits_text[289];
					}
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(135);
					}
				}
				else if (this.global1.data[214] == 1 && this.global1.data[10] >= 401)
				{
					if (this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 + this.global1.data[6] / 10 + this.global1.data[8] / 20 >= 1350)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(135);
						}
						this.Name.text = this.dlce1.credits_text[304];
						this.text_fake = this.dlce1.credits_text[305];
					}
					else if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[10] > 1600)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(135);
						}
						this.Name.text = this.dlce1.credits_text[284];
						this.text_fake = this.dlce1.credits_text[285];
					}
					else if (this.global1.event_done[382] && this.global1.data[164] <= 5)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(135);
						}
						this.Name.text = this.dlce1.credits_text[278];
						this.text_fake = this.dlce1.credits_text[279];
					}
					else if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 >= 1000)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(135);
						}
						this.Name.text = this.dlce1.credits_text[302];
						this.text_fake = this.dlce1.credits_text[303];
					}
					else if (this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie >= 300)
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(135);
						}
						this.Name.text = this.dlce1.credits_text[296];
						this.text_fake = this.dlce1.credits_text[297];
					}
					else
					{
						if (this.global1.iron_and_blood)
						{
							this.achieves.GetComponent<achievements>().Set(135);
						}
						this.Name.text = this.dlce1.credits_text[290];
						this.text_fake = this.dlce1.credits_text[291];
					}
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(135);
					}
				}
				else
				{
					this.Name.text = this.dlce1.credits_text[306];
					this.text_fake = this.dlce1.credits_text[307];
				}
			}
			else if (this.this_okno == 17 && this.global1.data[0] == 1 && this.global1.data[242] == 2)
			{
				this.Name.text = this.dlce1.credits_text[358];
				this.text_fake = this.dlce1.credits_text[359];
			}
			else if (this.this_okno == 18 && this.global1.data[0] == 1 && this.global1.data[242] == 2)
			{
				if (this.global1.allcountries[17].Westalgie >= 300 && (this.global1.data[7] >= 950 || (this.global1.allcountries[21].Gosstroy == 1 && this.global1.data[7] >= 850)))
				{
					this.Name.text = this.dlce1.credits_text[349];
					this.text_fake = this.dlce1.credits_text[351];
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(143);
					}
				}
				else
				{
					this.Name.text = this.dlce1.credits_text[350];
					this.text_fake = this.dlce1.credits_text[352];
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(144);
					}
				}
			}
			else if ((this.this_okno == 17 && (this.global1.data[0] != 1 || this.global1.data[242] != 2)) || this.this_okno == 19 + plus_max)
			{
				this.Name.text = "TOO LATE";
				this.text_fake = "";
				this.text_fake = "Year: " + this.global1.data[21].ToString() + "|";
				this.text_fake += "1991 year was over a long time ago, but you've decided to play next... And you win!|";
				this.text_fake += "Do you think this is the Greatest achievement? Then try to do the same until 1992 year!|";
			}
		}
		else if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51 && this.this_okno >= 0 && this.this_okno <= 2)
		{
			this.YugoEndings();
			this.SovToRus(this.text_fake);
		}
		else if (this.this_okno == 0 && this.global1.data[0] != 12)
		{
			this.text_fake = "";
			this.Name.text = "ПОЛИТИЧЕСКАЯ ПОЗИЦИЯ";
			if (this.global1.data[42] == 1)
			{
				if (this.global1.data[0] != 10 && this.global1.data[0] != 18 && this.global1.data[0] != 12)
				{
					this.text_fake = string.Concat(new string[]
					{
						"Благодаря решительным действиям, ",
						this.global1.politics_name[this.global1.data[11]],
						" смог разгромить своих противников и сохранить социалистический строй. А после нашего аналога Культурной революции, пусть и ценой некоторых жертв, ",
						this.global1.politics_name[this.global1.data[11]],
						" окончательно укрепил свою власть.|К сожалению, после его смерти, в ",
						this.global1.party_name[0],
						" начались распри за место главы государстве, в результате которой, на съезде партии, культ личности прошлого правителя был развенчан, а он сам был посмертно осуждён. Была ли тому причиной личная неприязнь или это было необходимостью для удержания власти - кто знает?... Да и это уже не важно, ведь рассказы о кровавых преступлениях предыдущего лидера передаются из поколения в поколение. |В стране произошла оттепель. Началось налаживание более дружественных отношений даже с Западом, а также были даны послабления в сфере плюрализма, культуры и цензуры. Партийные же бюрократы получили защиту от спецслужб и всю полноту власти, стремясь сохранить текущее консервативное положение правления. Возможно, это даже к лучшему..."
					});
				}
				else
				{
					this.text_fake = string.Concat(new string[]
					{
						"Благодаря решительным действиям, ",
						this.global1.politics_name[this.global1.data[11]],
						" смог разгромить своих противников и сохранить социалистический строй. А после нашего аналога Культурной революции, пусть и ценой некоторых жертв, ",
						this.global1.politics_name[this.global1.data[11]],
						" окончательно укрепил свою власть.|После смерти великого руководителя заранее выбранный преемник продолжил дело своего покровителя – Лидера нации. Однако его попытки что-либо видоизменить в стране были пресечены высшим партийным руководством, и он начал постепенно терять руководящее влияние в политике, которое окончательно перешло в руки Политбюро. Тем самым, его нахождение на должности становится всё более и более номинальным. Хоть в названии государства и фигурирует слово «республика», но народ принимает всё меньшее участие во власти."
					});
				}
			}
			else if (this.global1.data[42] == 2)
			{
				this.text_fake = "Благодаря вашим решительным действиям, вы смогли разгромить ваших противников, и сохранить социалистический строй. А после Культурной революции, пусть и ценой некоторых жертв, вы окончательно укрепили свою власть. Не захотев повторить судьбу Сталина, вы начали строить собственный культ личности, ставя себя на одно место с Марксом, Энгельсом и прочими теоретиками коммунизма, постепенно формируя свою идеологию. Вашим детищем стала Партия. Полностью обновленная и полностью преданная вам. |К сожалению, вашу жизнь оборвала неизвестная болезнь. Да и болезнь ли?..|Вы, как живая и настоящая личность, больше не нужны Партии, детищу, поглотившего своего создателя. Вы больше не должны были быть просто человеком. Вы должны стать иконой, \"вечным лидером\". |Были существенно урезаны свободомыслие и свобода слова, а также сильно расширен контроль над гражданами. Но это дало свои плоды: теперь наши граждане беззаветно верны Партии, а Партия и есть государство.";
				if (this.global1.data[0] != 10 && this.global1.data[0] != 18 && this.global1.data[0] != 12)
				{
					this.text_fake += "|К сожалению, нашу страну все чаще и чаще называют \"европейской КНДР\" - Западные империалисты терпеть не могут нас, впрочем, как и идеалы социализма. Или... Может это все же мы зашли куда-то не туда? ";
				}
				this.text_fake += "|Как бы-то ни было, наша страна продолжает существовать, как и ваш культ. Вы - наш вечный и единственный посмертный президент! Аве вам!|И все-таки, куда мы зашли, и куда нам идти дальше? Вопрос, пожалуй, риторический...";
			}
			else if (this.global1.data[42] == 3)
			{
				this.text_fake = this.global1.politics_name[this.global1.data[11]] + " решительными действиями установил однопартийную демократию во главе с " + this.global1.party_name[0] + ", идеей которой было отмести все контрреволюционные идеи, двигаться к построению марксизма-ленинизма и утвердить ведущую роль демократического централизма и коллективного правления. Однако народ воспринял в штыки текущее правительство погрязшее в бюрократии, «поедающей» честных людей. Граждане травят байки и высмеивает Партию.";
			}
			else if (this.global1.data[42] == 4)
			{
				this.text_fake = this.global1.politics_name[this.global1.data[11]] + " и " + this.global1.party_name[0] + " решительными действиями установили в стране однопартийную демократию, позволяющую отмести все контрреволюционные идеи и двигаться к построению марксизма-ленинизма. Несмотря на некоторые просчёты правителя, народ отнёсся с пониманием к проводимой политике и готов поддерживать и дальше его и Партию. Тем самым в стране утвердилась ведущая роль демократического централизма и коллективного правления.";
			}
			else if (this.global1.data[42] == 5)
			{
				this.text_fake = string.Concat(new string[]
				{
					"Благодаря решительным действиям, ",
					this.global1.politics_name[this.global1.data[11]],
					" смог разгромить своих противников и сохранить власть. К сожалению, со временем, его бдительность ослабла. ",
					this.global1.politics_name[this.global1.data[11]],
					" и не заметил, как в парламенте формируются группы, недовольные его правлением...|И вот, после очередной полемики в парламенте, секретарь нашего достопочтимого лидера принес ему чай, со странным запахом миндаля. ",
					this.global1.politics_name[this.global1.data[11]],
					" даже не успел понять, что это был цианистый калий....|После \"безвременной кончины\" Великого Вождя, власть перешла к другим людям, которые начали медленно сворачивать попытку введения его Культа Личности в стране, а затем просто стирать предыдущего правителя из памяти и истории.| Впрочем, как таковых существенных изменений не произошло, а в экономике же по-прежнему доминирует государство. Хорошо это или плохо - кто знает?.."
				});
			}
			else if (this.global1.data[42] == 6)
			{
				this.text_fake = string.Concat(new string[]
				{
					"Во время падения социалистических режимов по всему миру, ",
					this.global1.politics_name[this.global1.data[11]],
					", боясь за собственную власть, стал лихорадочно искать компромиссы с представителями оппозиции и политическими противниками, параллельно пытаясь угодить и силовым структурам. К сожалению, для сохранения власти, ему также пришлось пойти на поклон к Западным державам...|В итоге, к ",
					(this.global1.data[21] + 3).ToString(),
					" году, страна изменилась до неузнаваемости. Будучи загнанным в угол, ",
					this.global1.politics_name[this.global1.data[11]],
					" отбросил идеалы марксизма-ленинизма. В порыве лихорадочной борьбы за сохранение власти, он провел сверхбыструю либерализацию дипломатической, политической и социальной сферы. Как результат - глобализация, зависимость от иностранных держав и появление коррумпированной бюрократической системы.|В стране установилась мнимая демократия. Все партии, представленные в парламенте, по факту являются лишь марионетками. А власть сейчас вполне крепка и ",
					this.global1.politics_name[this.global1.data[11]],
					" может спокойно может править и дальше. Но возникает вопрос - А надо ли оно вообще?.. "
				});
			}
			else if (this.global1.data[42] == 7)
			{
				this.text_fake = string.Concat(new string[]
				{
					this.global1.politics_name[this.global1.data[11]],
					" был противоречивой фигурой, для одних он навсегда останется \"победителем коммунизма\", а для других всего лишь предателем. На долю ",
					this.global1.party_name[0],
					" выпала трудная миссия победы над прошлым строем, демократизация страны по западному образцу. Время нашего президента навсегда запомнится, как эпоха либерализма, впрочем и консерватиные правые и более радикальные левые оппозиционеры всё еще остро критикуют реформы тех времён. В конце концов пришли президентские выборы, которые выиграла легальная оппозиция, а лидер отправился на покой. Оппозиционеры воспользовались недовольством населения экономической политикой, что-бы прийти к власти, однако по приходу экономика подверглась лишь косметическим реформам. Что привело к тому, что всё еще не потерявшая веса ",
					this.global1.party_name[0],
					" вновь вернулась к власти на следующих выборах.|"
				});
				if (this.global1.data[0] == 1)
				{
					this.text_fake += "Когда ГДР и ФРГ стали так похожи друг на друга, как два брата близнеца, встал вопрос об объединении. Однако полного объединения так и не случилось: осси и весси хоть и были немцами, но годы жизни при разных режимах сделали своё дело. Поэтому объединение запада и востока прошло в виде конфедерации: Германия стала формально единой, таможенные границы исчезли, а армия стала единым бундесвером, но всё равно в остальном на востоке изменения были минимальны, а автономии всех остальных структур довольно значительны. Ничто не сотрясало нового порядка вещей.|";
				}
				this.text_fake = this.text_fake + "Только " + this.global1.politics_name[this.global1.data[11]] + " позже был обвинён в том, что он был внештатным агентом спецслужб старого коммунистического режима, до прихода к власти. Это единственное, что потревожило бывшего президента, который разочаровался в том, что сделали со страной его преемники, но вернуться в политику у него уже не было возможности: времена слишком переменились. А верховный суд его оправдал.";
			}
			else if (this.global1.data[42] == 8 && this.global1.data[43] == 2)
			{
				this.text_fake = this.global1.politics_name[this.global1.data[11]] + " был противоречивой фигурой, для одних он навсегда останется \"совершенным марксистом\", а для других всего лишь предателем. На долю " + this.global1.party_name[0] + " выпала трудная миссия победы над прошлым строем, демократизация страны по западному образцу. Время нашего президента навсегда запомнится, как эпоха расцвета экономики нашей страны, впрочем не многие радикалы будут сметь утверждать, что раньше было лучше. Политика проводимая национальным лидером была поддержана всеми классами на столько, что пост президента он занимал до самой смерти. Толковых противников в стране уже не было, а СМИ до сих пор сравнивают нашего всеми уважаемого президента с самим Рузвельтом!|";
				if (this.global1.data[0] == 1)
				{
					this.text_fake = this.text_fake + "Сам " + this.global1.politics_name[this.global1.data[11]] + " позже был увековечен в памятнике на одном из специально сохранённых участков Берлинской стены.";
				}
			}
			else if (this.global1.data[42] == 8)
			{
				this.text_fake = this.global1.politics_name[this.global1.data[11]] + " был противоречивой фигурой, для одних он навсегда останется \"победителем коммунизма\", а для других всего лишь предателем. На долю " + this.global1.party_name[0] + " выпала трудная миссия победы над прошлым строем, демократизация страны по западному образцу. Время нашего президента навсегда запомнится, как эпоха расцвета экономики нашей страны, впрочем не многие радикалы будут сметь утверждать, что раньше было лучше. Политика проводимая национальным лидером была поддержана всеми классами на столько, что пост президента он занимал до самой смерти. Толковых противников в стране уже не было, а СМИ до сих пор сравнивают нашего всеми уважаемого президента с самим Рузвельтом!|";
				if (this.global1.data[0] == 1)
				{
					this.text_fake = this.text_fake + "Когда ГДР и ФРГ стали так похожи друг на друга, как два брата близнеца, встал вопрос об объединении. Однако полного объединения так и не случилось: осси и весси хоть и были немцами, но годы жизни при разных режимах сделали своё дело. Да и сам " + this.global1.politics_name[this.global1.data[11]] + " при своей жизни оттягивал этот вопрос до последнего. Поэтому объединение запада и востока прошло в виде конфедерации: Германия стала формально единой, таможенные границы исчезли, а армия стала единым бундесвером, но всё равно в остальном на востоке изменения были минимальны, а автономии всех остальных структур довольно значительны. На Востоке даже остался свой собственный Парламент и декоративная Народная гвардия. Ничто не сотрясало нового порядка вещей.|";
				}
				this.text_fake = this.text_fake + "А " + this.global1.politics_name[this.global1.data[11]] + " позже был увековечен в памятнике на одном из специально сохранённых участков Берлинской стены.";
			}
			else if (this.global1.data[42] == 9)
			{
				this.text_fake = "На фоне проходящих реформ в соцлагере вы, боясь за собственную власть и заручившись поддержкой гэбистов и армии, начали лихорадочно уничтожать любое инакомыслие в своей стране. После волны репрессий на нашу страну накатилась первая волна санкций со стороны ООН, после которой она окончательно ушла в изоляцию и, сократив торговые и дипломатические связи с внешним миром, воздвигла свой еще более железный занавес. |Теперь в вашем государстве идеология возведена в ранг религии, а любой инакомыслящий немедленно уничтожается физическим путем. Сама же идеология окончательно отделилась от марксизма-ленинизма, сформировав новую структуру с опорой на народные традиции и национальные силы.| После вашей смерти вокруг вас сложили множество мистических легенд, сделав чуть ли не богом в новом идеологическо-религиозном Пантеоне, открыв мавзолей и начав отсчёт нового календаря с вашего рождения. А страной стал править назначенный верный преемник, продолживший ваше дело. ";
				if (this.global1.data[0] == 1 && this.global1.allcountries[this.global1.data[0]].subideology == 1 && this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(142);
				}
			}
			else if (this.global1.data[42] == 10)
			{
				this.text_fake = string.Concat(new string[]
				{
					"Из-за мудрой политики нашего вождя страна выстояла в неспокойные годы. ",
					this.global1.politics_name[this.global1.data[11]],
					" навсегда запомнится как спаситель страны, по крайней мере так напишут в учебниках истории. Несмотря на вопли отдельных \"отщепенцев\", жёсткой рукой спецслужбы, полиция и армия навели свои порядки: были запрещены все оппозиционные СМИ и партии, страна погрязла в ксенофобии и милитаризме, а цензорские комитеты работали без остановок. Голову подняла и Церковь, заключив негласный конкордат с правительством... Однако про это никто не осмеливался говорить вслух. Иногда из-за рубежа шли обвинения в \"фашизации\", впрочем они раз за разом объявлялись лживой пропагандой, конфликт заминался и дипломатические и экономические сношения продолжались. Так лидер ",
					this.global1.party_name[0],
					" правил вплоть до своей скоропостижной смерти от инсульта. После этого страну возглавили его ближайшие сподвижники, которые сразу начали борьбу за власть. Вероятно, когда-нибудь эта коррумпированная военно-бюрократическая система падёт под собственным весом, но будет это очень нескоро."
				});
			}
			if (this.global1.data[0] == 1 && this.global1.data[42] != 8 && this.global1.data[42] != 7 && this.global1.allcountries[this.global1.data[0]].Vyshi && !this.global1.allcountries[7].isOVD)
			{
				this.text_fake = this.text_fake + "Когда ГДР и ФРГ стали так похожи друг на друга, как два брата близнеца, встал вопрос об объединении. Однако полного объединения так и не случилось: осси и весси хоть и были немцами, но годы жизни при разных режимах сделали своё дело. Да и сам " + this.global1.politics_name[this.global1.data[11]] + " при своей жизни оттягивал этот вопрос до последнего. Поэтому объединение запада и востока прошло в виде конфедерации: Германия стала формально единой, таможенные границы исчезли, а армия стала единым бундесвером, но всё равно в остальном на востоке изменения были минимальны, а автономии всех остальных структур довольно значительны. На Востоке даже остался свой собственный Парламент и декоративная Народная гвардия. Ничто не сотрясало нового порядка вещей.";
			}
			else if (this.global1.data[0] == 1 && this.global1.eventVariantChosen[1098] == 2)
			{
				if (this.global1.eventVariantChosen[29] == 4 && this.global1.data[14] != 0 && this.global1.data[16] != 13)
				{
					this.text_fake = "Спустя несколько лет после реформ, преобразованная ГДР — теперь Германская Республика — вышла из кризиса прошлого как восставший из пепла феникс. Сохранив централизованную управляемость и социалистическую ориентацию старой системы, она сумела реорганизоваться, превратившись в витрину альтернативной модернизации. Конституция Якоба Кайзера, идеологически правильно скорректированная под реалии XXI века, обеспечила управляемую демократию, не нарушив фундамента контроля.|Новосозданные ХСС/ХДС ГР и СвДП ГР стали не просто функциональными партиями, а символами новой идеологии: социального христианского патернализма. Эти структуры открыто вступили в медийную и идеологическую полемику с западно-германскими одноимёнными партиями, обвиняя их в предательстве идеалов, моральном релятивизме и уклонении от ответственности перед народом. Теперь у Европы два ХДС и две СвДП — и только один путь выглядит стройным и народным.|Роль Малера и Ортлеба оказалась определяющей: их программы, выступления и инициативы вызвали недоумение на Западе, но уважение у миллионов. Школы страны учат «здоровому патриотизму», телевидение показывает «Германский путь», улицы больше не шумят от протестов, а парламент работает… предсказуемо.|ФРГ оказалась в сложной ситуации: молодёжь всё чаще заглядывается на Восток, где идеи порядка, социальной справедливости и духовной опоры обретают новое лицо. Либеральная и неолиберальная идея оказалась на перепутье. Опросы показывают: до " + ((float)this.global1.allcountries[17].Westalgie / 20f).ToString() + "% граждан Западной Германии «с интересом относятся» к курсу ГР.|Мир смотрит с растущим удивлением: некогда «оккупированная территория» превратилась в альтернативный центр немецкой государственности. Германская Республика не пытается штурмовать ФРГ, но молча предлагает: «Посмотрите, какой может быть настоящая Германия». Она идёт под марш, в котором нет ни злобы, ни высокомерия — только уверенность и порядок. И это звучит громче, чем лозунги.";
				}
				else if (this.global1.data[16] < 12 && this.global1.data[14] < 3)
				{
					this.text_fake += "|Сначала СЕПГ, ХДС и НДПГ были объединены в блок ХСС/ХДС с формально новой официальной идеологией, затем был введён чисто номинальный пост Президента, избираемого парламентом, а конечным шагом стал возврат к Конституции 1949 года с введением формального федерализма и немецкими наименованиями. Но несмотря на ожидания некоторых лиц и организаций Восточная Германия не поддалась на влияние Запада, не вестернизировалась и не либерализовалась: на улице продолжали висеть портреты Маркса и Энгельса, в школе - изучаться работы марксистов и диалектика, а в стране действовать плановая экономика и социалистический режим.";
				}
				else
				{
					this.text_fake += "|Многие верили в лучшее, но ожидали, что преобразования в ГДР останутся чистой формальностью. Их страхи не оправдались: несмотря на то, что Восточная Германия продолжила противостоять западному либерализму, ГДР претерпела серьёзные реформы, а внутри страны установился режим, который в шутку называют \"зеркалом ФРГ\". И даже восточнонемецкое правительство не скрывает свой статус \"зеркала\" и в пропаганде гордо именует себя \"лучшей версией Западной Германии\".";
				}
			}
			else if (this.global1.eventVariantChosen[58] == 1 && this.global1.event_done[58])
			{
				this.text_fake += "|Оставаясь у власти, переняв идеи австромарксизма и еврокоммунизма, наша партия сменила вектор классовой борьбы на борьбу за толерантность, принятие любого отличия и социальный индивидуализм. Реализовывая новую политическую программу к 2020 году наша страна успешно сумела стать примером для множества западных оппозиционных социальных движений несмотря на все наши новые общественные проблемы, как низкий уровень коллективизма и высокий уровень распространения депрессии и агрессии среди населения.";
			}
			else if (this.global1.eventVariantChosen[58] == 0 && this.global1.event_done[58])
			{
				if (this.global1.data[16] < 12)
				{
					this.text_fake += "|Оставаясь у власти, переняв идеи старого национал-большевизма и Никиша, наша партия сменила вектор классовой борьбы на борьбу за национальное благосостояние и общенародное государство, борьбу против Запада и за единство с Востоком. Реализовывая новую политическую программу к 2020 году наша страна успешно сумела стать примером для множества мировых социалистических организаций, которые, видя наш успешный курс, переняли и популяризировали национал-большевистское движение. Будем надеяться, что эклектическая система объединения крестьян, рабочих, мелкой буржуазии и интеллигенции будет держаться и дальше, а не перейдёт к классическому \"союзу лебедя, рака и щуки\".";
				}
				else
				{
					this.text_fake += "|Оставаясь у власти, переняв идеи старого национал-большевизма и Никиша, наша партия сменила вектор классовой борьбы на борьбу за национальное благосостояние и общенародное государство, борьбу против Запада и за единство с Востоком. Реализовывая новую политическую программу к 2020 году наша страна также отошла и от изначальных идей Никиша, вдохновившись братьями Штрассерами, но сумела стать примером для множества мировых националистических партий и организаций, показав пример построения национал-корпоративистского государства без этнических чисток и имперских амбиций. Будем надеяться, что солидаризм рабочих и корпораций при посредничестве государства будет работать дольше, чем во всех прошлых исторических примерах.";
				}
			}
			if (this.global1.data[0] == 5 && !this.global1.allcountries[5].isSEV && !this.global1.allcountries[5].isOVD && !this.global1.allcountries[5].Vyshi && this.global1.data[11] == 0 && this.global1.allcountries[this.global1.data[0]].subideology == 0 && this.global1.science[9] && this.global1.data[56] == 2 && this.global1.eventVariantChosen[70] == 4 && this.global1.eventVariantChosen[96] == 1 && this.global1.eventVariantChosen[110] == 3 && this.global1.data[59] == 1)
			{
				this.text_fake = "Стремительная трансформация соцлагеря привела к резкому изменению политического пространства Восточной Европы. Исключением не стала и Румыния. Ведомая авторитарной рукой Николае Чаушеску, страна была вынуждена адаптироваться к резкой демократизации на своих границах, чтобы не допустить, согласно меткому изречению румынского лидера, течения Дуная вспять. Воспользовавшись политической неурядицей на постсоветском пространстве, после исторического воссоединения с Молдавией и практически принудительной миграции венгерского населения, Румыния обрела, с одной стороны, практически полную этническую целостность, с другой – дополнительное топливо для подпитки националистической политики авторитарного режима. Социалистическая оболочка политической жизни сохранилась практически в неизменном виде, в то же время как слежка и контроль Секуритате за населением увеличились кратно. После прошедших незримых исчезновений последних оппонентов Чаушеску внутри партии (так как извне никто не мог и подумать выступить публично против решений «Отца Родины») была принята новая конституция, позволившая румынскому президенту вновь и вновь вести свой народ в идеологически верное будущее, в котором не было места ложному светочу буржуазной недодемократии. Об этом он подробно писал в своих книгах, статьях, а также говорил во время выступлений, распространяемых по радио и телевидению. Но с каждым годом Чаушеску стал всё реже появляться на публике, а в народе пошли слухи об участившемся вокруг Дома Республики тумане, в котором стали видеть призраки пропавших политических оппозиционеров. Приятно ли было видеть бегущие по небу облака, а в просветах – мерцание лунного света выходящим из него?";
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(146);
				}
			}
			if (this.global1.iron_and_blood)
			{
				if (this.global1.eventVariantChosen[1098] == 2 && this.global1.eventVariantChosen[57] == 4 && this.global1.eventVariantChosen[34] == 0 && this.global1.data[14] <= 0)
				{
					this.achieves.GetComponent<achievements>().Set(131);
				}
				else if (this.global1.eventVariantChosen[1098] == 0 && this.global1.eventVariantChosen[58] == 1 && this.global1.data[16] > 12)
				{
					this.achieves.GetComponent<achievements>().Set(132);
				}
				else if (this.global1.eventVariantChosen[1098] == 1 && this.global1.eventVariantChosen[58] == 0 && this.global1.data[16] == 11)
				{
					this.achieves.GetComponent<achievements>().Set(133);
				}
				if (this.global1.eventVariantChosen[29] == 4 && this.global1.data[14] != 0 && this.global1.data[16] != 13)
				{
					this.achieves.GetComponent<achievements>().Set(141);
				}
			}
		}
		else if (this.this_okno == 0)
		{
			if (this.global1.iron_and_blood && !this.global1.allcountries[7].Vyshi && this.global1.data[90] == 0 && this.global1.data[92] == 0 && this.global1.data[93] == 0 && this.global1.data[94] == 0)
			{
				this.achieves.GetComponent<achievements>().Set(65);
			}
			this.Name.text = "ПОЛИТИЧЕСКАЯ ПОЗИЦИЯ";
			if (this.global1.data[103] == 1 && this.global1.data[80] >= 80)
			{
				this.text_fake = this.global1.politics_name[this.global1.data[11]] + " и " + this.global1.party_name[0] + " решительными действиями установили в стране однопартийную демократию, позволяющую отмести все контрреволюционные идеи и двигаться к построению марксизма-ленинизма. Несмотря на некоторые просчёты правителя, народ отнёсся с пониманием к проводимой политике и готов поддерживать и дальше его и Партию. Тем самым в стране утвердилась ведущая роль демократического централизма и коллективного правления.";
			}
			else if (this.global1.data[104] == 1)
			{
				this.text_fake = "Танай и халькистское крыло партии смогли расправиться с оппозицией в НДПА и установить официальной идеологией партии – «исламский социализм», тем самым совместив учение Корана и пророка Мухаммеда с прогрессивными принципами социальной справедливости, свободы и равенства. Данные меры помогли афганскому правительству заручиться поддержкой духовенства и внести раздор среди мятежников, часть которых начала активно переходить на сторону НДПА. Несмотря на некоторые просчёты президента Таная, Демократическая Республика Афганистан продолжает существовать, а это главное.";
			}
			else if (this.global1.data[105] == 1 && this.global1.data[106] == 0)
			{
				this.text_fake = "Под влиянием советской перестройки и стремлением к осуществлению «политики национального примирения», Народно-демократическая партия Афганистана сменила своё название на «Ватан» (Отечество), начав отход от марксистско-ленинской теории к демократическому социализму с исламской спецификой. Была вновь легализована многопартийность, однако в последующих выборах смогли принять участие только продемократические и лояльные правительству партии, и в итоге реформированная НДПА получила абсолютное большинство голосов. Благодаря относительной либерализации режима и закреплением за Исламом статуса государственной религии, малая часть оппозиции пошла на сотрудничество с правительством, однако недовольных половинчатыми реформами было всё равно достаточно.";
			}
			else if (this.global1.data[105] == 1 && this.global1.data[106] == 1)
			{
				this.text_fake = "Под влиянием советской перестройки и стремлением к осуществлению «политики национального примирения», Народно-демократическая партия Афганистана сменила своё название на «Ватан» (Отечество), начав отход от марксистско-ленинской теории к демократическому социализму с исламской спецификой. Также, правительство ДРА пошло на сотрудничество с «умеренной частью оппозиции», договорившись о проведении свободных демократических выборов и создании совместного коалиционного правительства. Благодаря относительной либерализации режима и провозглашению Ислама государственной религии, значительная часть оппозиции перешла на сторону ДРА, отказавшись от партизанской непримиримой борьбы. Со временем страна полноценно преобразовалась в аналог либеральной демократии с двумя лидирующими партиями – социал-демократической партией «Ватан» и правоконсервативным «Исламским обществом Афганистана».";
			}
			else
			{
				this.text_fake = "Гражданская война нанесла серьёзный урон по политической системе Афганистана, поэтому сейчас весьма трудно сказать, что страну ждёт в будущем. Тем не менее, Демократическая республика Афганистан продолжает существовать и это главное. ";
			}
		}
		else if (this.this_okno == 1 && this.global1.data[0] != 12)
		{
			this.Name.text = "ЭКОНОМИЧЕСКАЯ СИСТЕМА";
			this.text_fake = "";
			if (this.global1.data[43] == 1)
			{
				this.text_fake = "Несмотря ни на что, мы смогли сохранить классическую плановую экономику с её преимуществами и недостатками. Хотя всемирное развитие компьютеризации и постепенное внедрение АСУ и РАСУ в наши предприятия осложняет чиновникам коррупцию и приписки, но о полной компьютеризации Госплана говорить не приходится. Так что припски и коррупция в Госплане всё ещё остаются обычным делом, из-за чего определённых товаров порой не хватает, однако кустари и кооперативы понемногу компенсируют этот дефицит. Госконтроль над внешней торговлей же обеспечивает нам независимость от внешнего рынка. Экономика стабильно развивается, в бюджет идут деньги, а мы доказали всему миру, что реальная альтернатива капитализму существует.";
			}
			else if (this.global1.data[43] == 2)
			{
				this.text_fake = "Несмотря на требования реформировать экономику, мы успешно построили ОГАС и внедрили её в наш Госплан. Благодаря этому, нам удалось почти полностью одолеть приписки и коррупцию внутри него, что дало резкий толчок к развитию нашей экономики, позволив нам совершить своё экономическое чудо. Теперь наша экономика беспристрастно управляется единой автоматизированной системой, благодаря чему она бурно развивается, а товаров производится достаточно для всех. Народ рад, бюджет наполняется деньгами, а автоматизированный коммунизм кажется народу всё более реальным.";
			}
			else if (this.global1.data[43] == 3)
			{
				this.text_fake = "Понимая необходимость реформирования нашей экономики, но не видя будущего в капитализме, мы провели реформы на основе венгерской системы Кадара. Отказ от централизованного планирования в пользу расширения самостоятельности предприятий, при сохранении на них госсобственности дали толчок к развитию нашей экономики. Конкурентоспособность и качество наших товаров повысились, появились даже новые для нашей страны товары, а внешняя торговля процветает. Однако вместе с тем произошло развитие коррупции и теневых схем, зависимость от внешнего рынка увеличилась, а \"нерентабельные\" предприятия либо дотируются из бюджета, либо разваливаются. Впрочем мы показали, что рынок можно организовать и при социализме и обеспечить благосостояние страны.";
			}
			else if (this.global1.data[43] == 4)
			{
				this.text_fake = "Повинуясь ветру перемен, мы совершили переход к свободной рыночной экономике. Государственные предприятия были приватизированы, а контроль за ценами и внешней торговлей ушли в прошлое. Это позволило предприимчивым и умелым руководителям возвыситься и теперь они двигают нашу экономику, а народ получил долгожданные джинсы и колу и возможность организовать свой бизнес. Однако вместе с тем люди, ища способы заработать, не стесняются в методах, что способствует расцвету теневых схем и коррупции, многие рабочие остались без работы, а многие начинающие бизнесмены очень быстро разоряются. Теперь вам придётся столкнуться уже с проблемами капитализма - растущим неравенством, коррупцией и безработицей, зато проблемы плановой экономики теперь точно нас не потревожат.";
			}
			else if (this.global1.data[43] == 5)
			{
				this.text_fake = "В то время как общественные организации стали призывать дать всё больше свободы народу в производстве собственных товаров, в " + this.global1.party_name[0] + " , на волне либерализации, к лидерству пришли сторонники фракции либерализации и самой экономики: сначала были разрешены коллективные формы предпринимательства - артели, кооперативы, ИП, семейные хозяйства вместе колхозов, которым дали множественную свободу. Следующим шагом стал переход государственных предприятий на хозрасчет, под видом борьбы с бюрократией и перегибами. Затем вовнутрь были допущены иностранные инвестиции и началось открытие совместных с иностранцами предприятий, как формы использования иностранного капитала во благо нашего народа. Постепенно вся плановая экономика сошла на нет, а в стране воцарился государственный капитализм со всеми работающими механизмами рыночной экономики. ";
			}
			if (this.global1.data[243] >= 3)
			{
				this.text_fake = this.text_fake + "\n" + this.dlce1.credits_text[48];
			}
		}
		else if (this.this_okno == 1)
		{
			this.Name.text = "ЭКОНОМИЧЕСКАЯ СИСТЕМА";
			this.text_fake = "";
			if (this.global1.data[16] == 10 && !this.global1.allcountries[7].Vyshi)
			{
				this.text_fake = "Постепенная стабилизация ситуации дала возможность развернуть в стране полноценные социалистические реформы с последующей установкой в стране экономического планирования. Малое предпринимательство и кустарщина были полностью легализованы, а в сельском хозяйстве поощряется объединение в семейные подряды и кооперативы. Вместе с этим правительство проводит масштабные социальные преобразования: строительство квартир, школ, больниц, детских садов. Мирная обстановка и поддержка СССР дали возможность афганской экономике стабильно развиваться.";
			}
			else if (this.global1.data[16] == 12 && !this.global1.allcountries[7].Vyshi)
			{
				this.text_fake = "Постепенная стабилизация ситуации дала возможность правительству развернуть экономические реформы в рамках социализма. Крупные предприятия по-прежнему находятся в государственном владении, однако производство лёгкой промышленности и ширпотреба было полностью передано в управление рабочих коллективов. В сельскохозяйственных регионах проходят кампании по поддержке единоличного крестьянства, а правительство активно выделяет сельским работникам ссуды и льготы на покупку оборудования. Массовое строительство школ, больниц и жилищных комплексов смогли значительно поднять уровень жизни населения, а благодаря советской помощи и специалистам, Афганистан с каждым годом осваивает всё более и более наукоёмкие отрасли в ведении народного хозяйства.";
			}
			else if (this.global1.data[16] == 13 && !this.global1.allcountries[7].Vyshi)
			{
				this.text_fake = "Постепенная стабилизация ситуации дала возможность правительству развернуть экономические реформы. Большинство средних, а также некоторые крупные предприятий, построенные СССР были приватизированы и переданы в руки предпринимателей. В сельском хозяйстве развернулись кампании по поощрению фермеров, которым правительство выдаёт ссуды для покупки оборудования. Благодаря советской поддержке развернулось массовое строительство школ, больниц и жилищных комплексов, уровень жизни населения стабильно растёт, а экономика Афганистана постепенно оправляется от последствий гражданской войны.";
			}
			else if (this.global1.allcountries[7].Vyshi)
			{
				this.text_fake = "Распад социалистического лагеря и СССР серьёзно ударили по нашей и без того слабой экономике. Послевоенная попытка правительства внедрить какие-либо экономические реформы привёл лишь к сопротивлению со стороны оппозиции, которая по сей день считает частную собственность «божественным даром», требуя соблюдения её неприкосновенности и защиты со стороны государства. В итоге хоть у государства и осталась регулирующая роль, малые и средние предприятия были переданы под управление предпринимателей, а среди крестьян растёт недовольство из-за малоземелья и плохой механизации сельского хозяйства. Несмотря на это, наша экономика показывает хоть и маленький, но стабильный рост, хотя в некоторых регионах всё ещё господствуют феодальные пережитки.";
			}
			else if (!this.global1.allcountries[7].Vyshi)
			{
				this.text_fake = "Преобразования в социалистическом лагере серьёзно ударили по нашей и без того слабой экономике. Послевоенная попытка правительства внедрить какие-либо экономические реформы привёл лишь к сопротивлению со стороны оппозиции, которая по сей день защищает племенную собственность  «божественным даром», требуя соблюдения её неприкосновенности и защиты со стороны государства. В итоге хоть у государства и осталась регулирующая роль, малые и средние предприятия были переданы под управление предпринимателей, а среди крестьян растёт недовольство из-за малоземелья и плохой механизации сельского хозяйства. Несмотря на это, наша экономика показывает хоть и маленький, но стабильный рост, хотя в стране всё ещё господствуют феодальные пережитки.";
			}
		}
		else if (this.this_okno == 2)
		{
			this.Name.text = "БЛАГОСОСТОЯНИЕ НАСЕЛЕНИЯ";
			this.text_fake = "";
			if (this.global1.data[44] == 1)
			{
				this.text_fake = string.Concat(new string[]
				{
					"Наш лидер, ",
					this.global1.politics_name[this.global1.data[11]],
					", и его гениальное правление позволили создать процветающую экономику и отличное социальное обеспечение, благодаря чему весь наш народ живёт в роскоши и процветании. Наша страна занимает первые строчки мировых рейтингов по уровню жизни, опережая даже страны Скандинавии. ",
					this.global1.politics_name[this.global1.data[11]],
					" войдёт в историю, как один из самых успешных правителей, а наши граждане счастливы процветать под его мудрым руководством."
				});
				if (this.global1.data[58] == 1)
				{
					this.text_fake += "|Решение о модернизации нефтедобычи позволило нам существенно нарастить уровень импорта и провести углубленные социальные реформы, благодаря чему народ сейчас очень доволен.";
				}
			}
			else if (this.global1.data[44] == 2)
			{
				this.text_fake = "Наш лидер, " + this.global1.politics_name[this.global1.data[11]] + ", и его умелое руководство создали развитую экономику и социальную сферу и смогли обеспечить всему народу комфортную и стабильную жизнь. Наша страна гордо стоит по уровню жизни вровень с Европой, а многие люди из менее успешных стран, коих большинство, мечтают уехать к нам. Наш народ рад иметь такую достойную жизнь и правителя, обеспечившего её.";
				if (this.global1.data[58] == 1)
				{
					this.text_fake += "|Решение о модернизации нефтедобычи позволило нам существенно нарастить уровень импорта и провести углубленные социальные реформы, благодаря чему народ сейчас очень доволен.";
				}
			}
			else if (this.global1.data[44] == 3 && this.global1.allcountries[7].isSEV)
			{
				this.text_fake = "Наш лидер, " + this.global1.politics_name[this.global1.data[11]] + ", и его правление создали экономику, позволившую обеспечить народу более-менее достойную жизнь. И, хотя, мы отстаём от Европы, у нашего народа есть еда, жильё, образование и некоторая роскошь. Советский Союз смог оправиться от социального кризиса и выйти на наш уровень лишь к 2010-м годам, а наши граждане по крайней мере не должны беспокоиться насчёт голода и крыши над головой.";
				if (this.global1.data[58] == 1)
				{
					this.text_fake += "|Решение о модернизации нефтедобычи позволило нам существенно нарастить уровень импорта и провести углубленные социальные реформы, благодаря чему народ сейчас доволен.";
				}
			}
			else if (this.global1.data[44] == 3)
			{
				this.text_fake = "Наш лидер, " + this.global1.politics_name[this.global1.data[11]] + ", и его правление создали экономику, позволившую обеспечить народу более-менее достойную жизнь. И, хотя, мы отстаём от Европы, у нашего народа есть еда, жильё, образование и некоторая роскошь. Страны бывшего СССР смогли выйти на наш уровень лишь к 2010-м годам, а наши граждане по крайней мере не должны беспокоиться насчёт голода и крыши над головой.";
				if (this.global1.data[58] == 1)
				{
					this.text_fake += "|Решение о модернизации нефтедобычи позволило нам существенно нарастить уровень импорта и провести углубленные социальные реформы, благодаря чему народ сейчас доволен.";
				}
			}
			else if (this.global1.data[44] == 4)
			{
				this.text_fake = "Наш лидер, " + this.global1.politics_name[this.global1.data[11]] + ", и его правление привели к развалу социальной сферы, ввергнув население в бедность. Безработица, бездомность и периодическое недоедание стали обычным делом для наших граждан, а наша страна вынуждена принимать гуманитарную помощь от международных организаций. Ни о каком комфорте говорить не приходится, а наши граждане навсегда запомнят эти трудные времена.";
			}
		}
		else if (this.this_okno == 3)
		{
			this.Name.text = "СОВЕТСКИЙ СОЮЗ";
			this.text_fake = "";
			if (this.global1.allcountries[7].paths == 2)
			{
				this.text_fake = "Несмотря на реформы, постигшие СССР и страны соцлагеря, мир всё еще остался многополярным, а обновленный коммунизм - всё еще решающей международной силой.";
			}
			else if (this.global1.allcountries[7].paths == 3)
			{
				this.text_fake = "Несмотря на реформы, постигшие СССР и страны соцлагеря, Советский Союз остался одним из бесспорных гегемонов в мире, а обновленный коммунизм - всё еще решающей международной силой. |Стабилизировав внешнее положение и оставшись всё еще весомой силой, при активной поддержке новообразованного Совета Безопасности, состоящего из прагматичных реформистов, советское правительство смогло пресечь внутренние распри и направить взгляды народа от идей размежевания в сторону идей углубления экономических реформ.";
			}
			else if (this.global1.data[45] == 1)
			{
				this.text_fake = "Несмотря на реформы, постигшие СССР и страны соцлагеря, Советский Союз остался одним из бесспорных гегемонов в мире, а обновленный коммунизм - всё еще решающей международной силой. |Стабилизировав внешнее положение и оставшись всё еще весомой силой, при активной поддержке новообразованного Совета Безопасности, состоящего из прагматичных реформистов, советское правительство смогло пресечь внутренние распри и направить взгляды народа от идей размежевания в сторону идей углубления экономических реформ. |Взяв пример с Китая, и наладив с ним отношения, Президент Горбачёв правил страной два президентских срока, сам же введя лимит на правление. После второго срока он оставил свой пост и обещал больше не баллотироваться, оставшись Генеральным Секретарем ЦК КПСС. Впрочем, реформы Горбачёва хоть и дали больше свободы стране и помогли возвыситься определенным предприимчивым организаторам, но, в целом, социальное положение продолжает ухудшаться год от года. |И население с огромной надеждой ожидает качественных изменений, связывая их с новыми президентскими выборами.";
			}
			else if (this.global1.data[45] == 2)
			{
				this.text_fake = "Несмотря на реформы, постигшие СССР и страны соцлагеря, Советский Союз остался одним из бесспорных лидеров в мире, а обновленный коммунизм - всё еще решающей международной силой. |Все попытки право-либеральной оппозиции провести реформы, нацеленные на размежевание Союза, быстро заглохли, когда на первых президентских выборах в РСФСР на обещания Ельцина дать больше суверенитета России и не кормить иные нации, победу одержал кандидат от КПСС - Николай Рыжков. |При активной поддержке новообразованного Совета Безопасности, состоящего из прагматичных реформистов, советское правительство направило взгляды народа в сторону углубления экономических реформ. |Взяв пример с Китая, и наладив с ним отношения, Президент Горбачёв правил страной два президентских срока, сам же введя лимит на правление. После второго срока он оставил свой пост и обещал больше не баллотироваться, оставшись Генеральным Секретарем ЦК КПСС. Впрочем, реформы Горбачёва хоть и дали больше свободы стране и помогли возвыситься определенным предприимчивым организаторам, но, в целом, социальное положение продолжает ухудшаться год от года. |И население с огромной надеждой ожидает качественных изменений, связывая их с новыми президентскими выборами.";
			}
			else if (this.global1.data[45] == 3)
			{
				this.text_fake = "Несмотря на реформы, постигшие СССР и страны соцлагеря, мир всё еще остался многополярным, а обновленный коммунизм - всё еще решающей международной силой. |И хотя, под давлением право-либеральной общественности, в силу вступил договор о преобразовании СССР в Союз Советских Суверенных Республик, на первых президентских выборах в РСФСР, несмотря на обещания Ельцина дать больше суверенитета России и не кормить иные нации, победу одержал кандидат от КПСС - Николай Рыжков, а сам новый союзный договор хоть и расширил права республик, но, в то же время, подтвердил и закрепил единство советского народа и нерушимость Союза. |При активной поддержке новообразованного Совета Безопасности, состоящего из прагматичных реформистов, советское правительство направило взгляды народа в сторону углубления экономических реформ. |Взяв пример с Китая, и наладив с ним отношения, Президент Горбачёв правил страной два президентских срока, сам же введя лимит на правление. После второго срока он оставил свой пост и обещал больше не баллотироваться, оставшись Генеральным Секретарем ЦК КПСС. Впрочем, реформы Горбачёва хоть и дали больше свободы стране и помогли возвыситься определенным предприимчивым организаторам, но, в целом, социальное положение продолжает ухудшаться год от года, а в союзных республиках всё больше подымают голову националистические и традиционалистические объединения. |Население с огромной надеждой ожидает качественных изменений, связывая их с новыми президентскими выборами.";
			}
			else if (this.global1.data[45] == 4)
			{
				if (!this.global1.event_done[74])
				{
					this.text_fake = "ГКЧП провалилось, но во многом за счёт того, что в последний день своего существования Министр Обороны Язов решил послушать Шапошникова и самолично разогнал ГКЧП, арестовав его состав. Благодаря этому под горбачёвские чистки попали лишь сами члены ГКЧП и ярко отличившиеся их сторонники, но другие сочуствующие остались не тронутыми, в том числе и Председатель Верховного Совета СССР Анатолий Лукьянов.| Следствием этого V Съезд народных депутатов СССР принял решение о преобразовании СССР в Союз Суверенных Государств, что было ратифицировано другими республиками и сорвало планы беловежского сговора. Президентом ССГ стал Михаил Горбачёв.| Противостояние Центра со сторонниками полного размежевания получило свой конец в октябре 1993 года, когда Верховный Совет РСФСР законно отправил Президента России Ельцина в отставку, а когда тот попытался организовать военный переворот - не получил поддержки ни из Центра ни от самих военных и был вынужден бежать за границу. С того момента политическое положение в ССГ стабилизировалось.| Впрочем, реформы Горбачёва хоть и дали больше свободы стране и помогли возвыситься определенным предприимичвым организаторам, но, в целом, социальное и экономическое положение продолжает ухудшаться год от года, а в союзных республиках всё больше подымают голову националистические и традиционалистические объединения, имеющие хорошо скрываемую благосклонность со стороны представителей руководящих органов некоторых республик-членов ССГ. |Население с огромной надеждой ожидает качественных изменений, связывая их с новыми президентскими выборами.";
				}
				else
				{
					this.text_fake = "ГКЧП провалилось, но во многом за счёт того, что в последний день своего существования Министр Обороны Язов решил послушать Шапошникова и самолично разогнал ГКЧП, арестовав его состав. Благодаря этому под горбачёвские чистки попали лишь сами члены ГКЧП и ярко отличившиеся их сторонники, но другие сочуствующие остались не тронутыми, в том числе и Председатель Верховного Совета СССР Анатолий Лукьянов.| Следствием этого V Съезд народных депутатов СССР принял решение о преобразовании СССР в Союз Суверенных Государств, что было ратифицировано другими республиками и сорвало планы беловежского сговора. Президентом ССГ стал Михаил Горбачёв. Впрочем, реформы Горбачёва хоть и дали больше свободы стране и помогли возвыситься определенным предприимичвым организаторам, но, в целом, социальное и экономическое положение продолжает ухудшаться год от года, а в союзных республиках всё больше подымают голову националистические и традиционалистические объединения, имеющие хорошо скрываемую благосклонность со стороны представителей руководящих органов некоторых республик-членов ССГ. |Население с огромной надеждой ожидает качественных изменений, связывая их с новыми президентскими выборами.";
				}
			}
			else if (this.global1.data[45] == 5)
			{
				this.text_fake = "ГКЧП провалилось и карающая длань Горбачёва обрушилась на всех активных сторонников и просто сочуствующих социалистическим идеям и ГКЧП. Михаил Сергеевич, разрушая и так подорванное доверие к советской власти, ликвидирует остатки хоть на что-то влияющих советских органов управления и без какой-либо внятной реакции принимает Беловежский сговор как совершившееся дело.| Готовившиеся к побегу и удивленные подобным исходом организаторы Беловежского сговора с радостью обманывают свои народы и заявляют о преемственности Советского Союза Содружеством Независимых Государств, который, как договор, является лишь номинальным росчерком пера, поставившим жирную точку на итоги референдума о сохранении и преобразовании СССР.| Многократное падение экономики и уровня жизни, неудачное проведение реформ и резкий рост коррупции и криминала теперь останутся в памяти бывшего советского народа навсегда, ровно как и незаконный переворот, осуществленный Ельциным в октября 1993 года...";
			}
			else if (this.global1.data[45] == 6)
			{
				this.text_fake = string.Concat(new object[]
				{
					"ГКЧП сумело взять под контроль все теле- и радиостанции и не допустить к показу радикальных журналистов, даже арестовав их. Борис Ельцин погиб по время перестрелки между его охраной и отрядом КГБ, прибывшим для его ареста, так как не пожелал сдаваться. Возглавленный генералом Лебедем штурм оплота оппозиции - здания Верховного Совета - привёл к окончательной стабилизации власти ГКЧП.|В своих выступлениях лидер ГКЧП Янаев заявил о приверженности идеалам Перестройки, огласив всему миру, что Горбачёв болен и более не сможет править страной, а в дальнейшем будущем будут проведены первые всенародные президентские выборы. В то же время ГКЧП осудило попытку размежевания Советского Союза, назвав это попыткой пойти против воли народа, который на мартовском референдуме поддержал единство СССР|В течении всего 1992-",
					this.global1.data[21] + 1,
					" годов шли крупные уголовные дела государственного уровня по осуждению коррупционеров, мошенников и расхитителей госсобственности, а с помощью грубой силы и слаженной работы спецслужб были окончательно подавлены все очаги мятежников.|И лишь в ",
					this.global1.data[21] + 1,
					" году, в августе, начались обещанные президентские выборы..."
				});
			}
			else if (this.global1.data[45] == 7)
			{
				this.text_fake = string.Concat(new object[]
				{
					"ГКЧП сумело взять под контроль все теле- и радиостанции и не допустить к показу радикальных журналистов, даже арестовав их. Борис Ельцин погиб по время перестрелки между его охраной и отрядом КГБ, прибывшим для его ареста, так как не пожелал сдаваться. Возглавленный генералом Лебедем штурм оплота оппозиции - здания Верховного Совета РСФСР - привёл к окончательной стабилизации власти ГКЧП.|В своих выступлениях лидер ГКЧП Алкснис заявил о том, что сам Горбачёв предал идеалы Перестройки, огласив всему миру, что после похорон Горбачёва в дальнейшем будущем будут проведены президентские выборы, но избирать его будет Верховный Совет. В то же время ГКЧП осудило попытку размежевания Советского Союза, назвав это попыткой пойти против воли народа.|В течении всего 1992-",
					this.global1.data[21] + 1,
					" годов шли крупные уголовные дела государственного уровня по осуждению коррупционеров, мошенников и расхитителей госсобственности, а с помощью грубой силы и слаженной работы спецслужб были окончательно подавлены все очаги мятежников.|И лишь в ",
					this.global1.data[21] + 1,
					" году, в августе, начались обещанные президентские выборы..."
				});
			}
			else if (this.global1.data[45] == 8)
			{
				if (this.global1.data[221] == 1)
				{
					this.text_fake = "После провала ГКЧП и ареста ключевых заговорщиков судьба нового Союзного договора казалась туманной. Однако Михаилу Горбачёву удалось заручиться поддержкой части российских реформаторов и республиканских элит, согласовать с руководством 9 республик проект соглашения и убедить их подписать его. 31 декабря 1991 года Советский Союз официально прекратил своё существование, а его правопреемником стал конфедеративный Союз Суверенных Государств (ССГ) в составе России, Украины (вынужденной смириться с сохранением в составе ССГ), Белоруссии, Азербайджана, Казахстана, Узбекистана, Киргизии, Таджикистана и Туркмении. За Центром остались полномочия в области обороны (включая управление ядерным арсеналом), безопасности, налоговой и таможенной политики, всё остальное было либо передано в совместное ведение Москвы и республик, либо ушло на места. Немедленно же после своего создания новый Союз оказался втянут в конфликты с уходящими республиками, экономический хаос от «войны суверенитетов» и противостояние с российским руководством, посчитавшим сделанные Горбачёвым уступки недостаточными. Однако с 1996 года ситуация начала постепенно стабилизироваться: в состав ССГ вошли Приднестровье, Южная Осетия и Абхазия, была нейтрализована угроза со стороны Нагорного Карабаха (лишившегося ¾ территории), экономика страны уверенно перешла на рельсы социально-ориентированного рынка, благо, что главные смутьяны бывшего Союза — Борис Ельцин и Леонид Кравчук — погибли в трагической авиакатастрофе, а их преемники оказались более договороспособными. Впрочем, и 10 лет спустя экономика ССГ не может вернуться к уровню 1990 года, страна продолжает ощущать последствия войн и межнациональных конфликтов, многократно возросли бюрократизм, коррупция и экономическое неравенство, а предприимчивые люди жалуются на «излишнее давление на частную инициативу». |И население по-прежнему огромной страны с большой надеждой ожидает качественных изменений, связывая их с уходом из политики Михаила Горбачёва и результатами новых президентских выборов.";
				}
				else
				{
					this.text_fake = "После провала ГКЧП и ареста ключевых заговорщиков судьба нового Союзного договора казалась туманной. Однако Михаилу Горбачёву удалось заручиться поддержкой части российских реформаторов и республиканских элит, согласовать с руководством 9 республик проект соглашения и убедить их подписать его. 31 декабря 1991 года Советский Союз официально прекратил своё существование, а его правопреемником стал конфедеративный Союз Суверенных Государств (ССГ) в составе России, Украины (вынужденной смириться с сохранением в составе ССГ), Белоруссии, Азербайджана, Казахстана, Узбекистана, Киргизии, Таджикистана и Туркмении. За Центром остались полномочия в области обороны (включая управление ядерным арсеналом), безопасности, налоговой и таможенной политики, всё остальное было либо передано в совместное ведение Москвы и республик, либо ушло на места. Немедленно же после своего создания новый Союз оказался втянут в конфликты с уходящими республиками, экономический хаос от «войны суверенитетов» и противостояние с российским руководством, посчитавшим сделанные Горбачёвым уступки недостаточными. Однако с 1996 года ситуация начала постепенно стабилизироваться: в состав ССГ вошли Приднестровье, Южная Осетия и Абхазия, была нейтрализована угроза со стороны Нагорного Карабаха (лишившегося ¾ территории), экономика страны уверенно перешла на рельсы социально-ориентированного рынка, а главные смутьяны в новом Союзе — Борис Ельцин и Леонид Кравчук — ушли со сцены, проиграв выборы в своих республиках (спустя несколько месяцев Ельцин скоропостижно скончался от внезапного инфаркта). Впрочем, и 10 лет спустя экономика ССГ не может вернуться к уровню 1990 года, страна продолжает ощущать последствия войн и межнациональных конфликтов, многократно возросли бюрократизм, коррупция и экономическое неравенство, а предприимчивые люди жалуются на «излишнее давление на частную инициативу». |И население по-прежнему огромной страны с большой надеждой ожидает качественных изменений, связывая их с уходом из политики Михаила Горбачёва и результатами новых президентских выборов.";
				}
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(134);
				}
			}
			else if (this.global1.data[45] == 9)
			{
				this.text_fake = "После провала ГКЧП и ареста ключевых заговорщиков судьба нового Союзного договора казалась туманной. Однако Михаилу Горбачёву удалось заручиться поддержкой части российских реформаторов и республиканских элит, согласовать с руководством 9 республик проект соглашения и убедить их подписать его… однако уже в день проведения торжественной церемонии в Кремле Леонид Кравчук и президент Азербайджана Аяз Муталибов отказались парафировать договор и потребовали передать в совместное ведение Центра и республик все остававшиеся за Москвой полномочия (кроме управления ядерным арсеналом). Чтобы не допустить краха всего Ново-Огаревского процесса, Горбачёв принял это условие и 10 января 1992 года в Алма-Ате новый Союзный договор всё-таки был подписан. Советский Союз официально прекратил своё существование, а его правопреемником стал конфедеративный Союз Суверенных Государств (ССГ) в составе России, Украины, Белоруссии, Азербайджана, Казахстана, Узбекистана, Киргизии, Таджикистана и Туркмении. Немедленно же после своего создания новый Союз оказался втянут в конфликты с уходящими республиками, экономический хаос от «войны суверенитетов» и противостояние с российским руководством, которое на фоне тотального ослабления Центра в 1993 году перешло в силовую фазу — МВД и МБ РФ блокировали административные здания в Москве и спровоцировали столкновения с направленными Горбачёвым на их деблокаду подразделениями Внутренних войск. Однако практически одержавший победу Ельцин внезапно скончался от отравления алкоголем, что позволило Горбачёву договориться с более умеренным вице-президентом России Руцким. 5 лет спустя ССГ представляет собой раздираемое противоречиями лоскутное одеяло — во всех республиках созданы собственные центральные банки и введена своя валюта, русский язык утратил статус государственного везде, кроме России и Белоруссии, на спад идут даже научные и культурные контакты. Из Киева и Баку всё чаще звучат голоса сторонников преобразования ССГ в «содружество независимых государств», которое не имело бы никакого практического воплощения, однако их сдерживает продолжающийся конфликт Азербайджана с поддерживаемой Западом Арменией и активные попытки властей Крыма выйти из украинской юрисдикции. |Жители распадающегося Союза ни на что не надеются, но ожидают исхода приближающихся президентских выборов.";
			}
			else if (this.global1.data[45] == 10)
			{
				this.text_fake = "10 января 1992 года в Ново-Огарево состоялась встреча Михаила Горбачёва с лидерами России, Белоруссии, Азербайджана и среднеазиатских республик, на которой состоялось подписание последнего согласованного проекта нового Союзного договора, преобразовавшего СССР в аморфную конфедерацию суверенных республик — Союз Суверенных Государств. В тот же день президент Украины Леонид Кравчук объявил о переходе под юрисдикцию Киева всех подразделений армии, МСБ и МВД, дислоцированных на территории возглавляемой им республики, и своим указом создал Вооружённые силы и Национальную гвардию Украины. Начались попытки лояльных республиканским властям чекистов захватить контроль над расположенным на территории отделяющейся республики атомным оружием и перенастроить его управление с Москвы на Киев. В ночь с 21 на 22 февраля Кравчук в ультимативном порядке потребовал от президента Горбачёва и лидеров стран ССГ прекратить блокаду Украины, в противном случае угрожая «последствиями, с которыми вы в своей истории ещё никогда не сталкивались». Спустя несколько часов в ООН было созвано срочное заседание, на котором постоянный представитель Союза Юлий Воронцов предоставил доказательства опасной политики украинских властей по массовым попыткам взлома секретных кодов ядерного оружия, находящегося в уже бывшей советской республике, и потребовал оперативного создания миссии по поддержанию мира на территории Украины и её денуклеаризации. Удивительно, но резолюция была поддержана тремя постоянными членами Совета Безопасности и принята в кратчайшие сроки. Спустя несколько дней, после отказа украинских властей от сдачи оружия, на её территорию был введён интернациональный миротворческий корпус, в котором приняли участие в том числе солдаты США и ФРГ. Новая война в Европе началась, но никто и не мог представить, что она будет протекать подобным образом.";
			}
			else if (this.global1.data[45] == 11)
			{
				this.text_fake = "10 января 1992 года в Ново-Огарево состоялась встреча Михаила Горбачёва с лидерами России, Белоруссии, Азербайджана и среднеазиатских республик, на которой состоялось подписание последнего согласованного проекта нового Союзного договора, преобразовавшего СССР в аморфную конфедерацию суверенных республик — Союз Суверенных Государств. Однако президент Украины Леонид Кравчук отказался присоединяться к соглашению и обусловил членство возглавляемой им республики в новом Союзе — ликвидацией всех центральных органов и консультативном характером такого союза, который не мешал бы курсу на европейскую интеграцию. Борис Ельцин и Станислав Шушкевич поддержали украинского лидера, что, в конечном итоге, привело к краху Ново-Огаревского процесса — 24 января Михаил Горбачёв ушел в отставку с поста президента ССГ и покинул Кремль, передав свои полномочия Ельцину. 8 февраля Россия, Украина и Белоруссия в одностороннем порядке объявили о денонсации Союзного договора и создании Содружества независимых государств, носящего формальный характер. До конца 1992 года к нему присоединились республики Средней Азии, Азербайджан, а также Армения, Молдавия и Грузия. Политика постоянных уступок Горбачёва не спасла Союз, а лишь продлила его агонию на год.";
			}
		}
		else if (this.this_okno == 4)
		{
			this.Name.text = "СОВЕТСКИЙ СОЮЗ";
			this.text_fake = "";
			if (this.global1.allcountries[7].paths == 2)
			{
				this.text_fake = this.dlce1.credits_text[46];
			}
			else if (this.global1.allcountries[7].paths == 3)
			{
				this.text_fake = this.dlce1.credits_text[47];
			}
			else if (this.global1.data[45] == 1)
			{
				if (this.global1.data[51] + this.global1.data[52] * 3 > 10)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(24);
					}
					this.text_fake = "|<color=red>РАСЧЁТ...|</color>";
					this.text_fake += "<color=blue>Борис Пуго</color>|";
					this.text_fake += "На новых президентских выборах к власти пришел Борис Пуго, бывший Министр Внутренних Дел, который сразу же начал огромную кампанию против коррупции и рыночных махинаций, а также массовое преследование националистов, в том числе и прибалтийских, сам будучи латышом по национальности. Дальнейшим шагом стало продавливание смены вектора рыночных реформ на китайский аналог реформ птичьей клетки, с многократным усилением государственного вмешательства. Не согласный с этим Горбачёв ушел в отставку по состоянию здоровья.| Резкое падение уровня коррупции и спекуляции, чистки государственных структур и переход к более эффективным методам проведения экономических реформ уже дают множественные плоды в виде подъема социального, экономического и духовного.";
				}
				else
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(26);
					}
					this.text_fake = "|<color=red>РАСЧЁТ...|</color>";
					this.text_fake += "<color=blue>Владимир Жириновский</color>|";
					this.text_fake += "На новых президентских выборах к власти пришел Владимир Жириновский, первый не член КПСС со времён Перестройки. Его обещания были популистическими: честная приватизация нерентабельных госпредприятий после реструктуризации экономики и увеличение социальных расходов за счёт этого, повсеместная борьба с коррупцией и бюрократией и возвращение былого величия Советского Союза на международной арене.| Впрочем, придя к власти Жириновский не провёл огромные переназначения в руководящем аппарате и представители КПСС всё еще остаются в большинстве.| Своё правление Жириновский начал с инаугурационной речи, на которой громко и грубо выразил нападки против сторонников размежевания и внешних врагов. Это уже породило начало масштабной кампании борьбы с местническим национализмом и лавину русофильской пропаганды, что вызвало негативную критику со стороны Горбачёва и стало началом официального раскола в советском руководстве...";
				}
			}
			else if (this.global1.data[45] == 2)
			{
				if (this.global1.data[51] + this.global1.data[52] * 3 > 10)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(24);
					}
					this.text_fake = "|<color=red>РАСЧЁТ...|</color>";
					this.text_fake += "<color=blue>Борис Пуго</color>|";
					this.text_fake += "На новых президентских выборах к власти пришел Борис Пуго, бывший Министр Внутренних Дел, который сразу же начал огромную кампанию против коррупции и рыночных махинаций, а также массовое преследование националистов, в том числе и прибалтийских, сам будучи латышом по национальности. Дальнейшим шагом стало продавливание смены вектора рыночных реформ на китайский аналог реформ птичьей клетки, с многократным усилением государственного вмешательства. Не согласный с этим Горбачёв ушел в отставку по состоянию здоровья.| Резкое падение уровня коррупции и спекуляции, чистки государственных структур и переход к более эффективным методам проведения экономических реформ уже дают множественные плоды в виде подъема социального, экономического и духовного.";
				}
				else
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(25);
					}
					this.text_fake = "|<color=red>РАСЧЁТ...|</color>";
					this.text_fake += "<color=blue>Геннадий Зюганов</color>|";
					this.text_fake += "На новых президентских выборах к власти пришел Геннадий Зюганов. Его обещаниями были: поддержка религиозной свободы, в частности Православия, честная приватизация нерентабельных госпредприятий после реструктуризации экономики и увеличение социальных расходов за счёт этого, что должно было привести к улучшению материального положения населения.|И своё правление он начал с открытием множества СЭЗ на территории страны, приглашением иностранных инвесторов и продаже дешёвой рабочей силы им. Следующим шагом он видит исполнение требований для членства СССР в ВТО...";
				}
			}
			else if (this.global1.data[45] == 3)
			{
				if (this.global1.data[51] + this.global1.data[52] * 3 > 10)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(25);
					}
					this.text_fake = "|<color=red>РАСЧЁТ...|</color>";
					this.text_fake += "<color=blue>Геннадий Зюганов</color>|";
					this.text_fake += "На новых президентских выборах к власти пришел Геннадий Зюганов. Его обещаниями были: поддержка религиозной свободы, в частности Православия, честная приватизация нерентабельных госпредприятий после реструктуризации экономики и увеличение социальных расходов за счёт этого, что должно было привести к улучшению материального положения населения.|И своё правление он начал с открытием множества СЭЗ на территории страны, приглашением иностранных инвесторов и продаже дешёвой рабочей силы им. Следующим шагом он видит исполнение требований для членства СССР в ВТО...";
				}
				else
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(26);
					}
					this.text_fake = "|<color=red>РАСЧЁТ...|</color>";
					this.text_fake += "<color=blue>Владимир Жириновский</color>|";
					this.text_fake += "На новых президентских выборах к власти пришел Владимир Жириновский, первый не член КПСС со времён Перестройки. Его обещания были популистическими: честная приватизация нерентабельных госпредприятий после реструктуризации экономики и увеличение социальных расходов за счёт этого, повсеместная борьба с коррупцией и бюрократией и возвращение былого величия Советского Союза на международной арене.| Впрочем, придя к власти Жириновский не провёл огромные переназначения в руководящем аппарате и представители КПСС всё еще остаются в большинстве.| Своё правление Жириновский начал с инаугурационной речи, на которой громко и грубо выразил нападки против сторонников размежевания и внешних врагов. Это уже породило начало масштабной кампании борьбы с местническим национализмом и лавину русофильской пропаганды, что вызвало негативную критику со стороны Горбачёва и стало началом официального раскола в советском руководстве...";
				}
			}
			else if (this.global1.data[45] == 4)
			{
				if (this.global1.data[51] + this.global1.data[52] * 3 > 10)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(27);
					}
					this.text_fake = "|<color=red>РАСЧЁТ...|</color>";
					this.text_fake += "<color=blue>Александр Лебедь</color>|";
					this.text_fake += "На новых президентских выборах к власти пришел поддержанный в основном русскоязычным населением Александр Лебедь, первый не-член КПСС со времён Перестройки, возглавляющий собственную правонационалистическую русофильскую партию. Его обещания были популистическими: честная приватизация нерентабельных госпредприятий после реструктуризации экономики и увеличение социальных расходов за счёт этого, повсеместная борьба с коррупцией и бюрократией и возвращение былого величия страны на международной арене.| Придя к власти Александр полностью отправил в отставку весь старый состав высших руководящих органов страны и заменил их своими сторонниками. В то же время, пользуясь популярностью и имея огромные связи среди офицерского состава советской армии, он начал подготовку и проведение военных операций против поднявших голову недовольных региональных лидеров.| Своё правление Лебедь начал с инаугурационной речи, на которой громко и грубо выразил нападки против сторонников размежевания и внешних врагов. Это уже породило начало масштабной кампании борьбы с местническим национализмом и лавину русофильской пропаганды...";
				}
				else
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(28);
					}
					this.text_fake = "|<color=red>РАСЧЁТ...|</color>";
					this.text_fake += "<color=blue>Григорий Явлинский</color>|";
					this.text_fake += "На новых президентских выборах к власти пришел Григорий Явлинский, бывший член КПСС и лидер собственной лево-либеральной Партии \"Яблоко\", а также действующий заместитель Председателя Совета Министров ССГ.|Придя к власти на волне обещаний реализовать заброшенную коммунистами программу реформирования ССГ за 500 дней вместе с интеграцией Союза как единого целого в международную экономику, Явлинский считает важным укрепление рыночных связей между республиками-членами ССГ и видит своё правление в качестве рычага для преобразования ССГ в договор, схожий с Европейским Союзом, что определенно не нравится местническим региональным лидерам, не желающим делиться экономическими автономиями и правами на казнокрадство из своих бюджетов. | С приходом к власти под руководством Явлинского начинается формирование Комитета реформ экономики, в отставку уходит старый состав руководящих органов СССР, начинаются открытые слушанья и громогласные преследования коррупционеров.|Народ с нетерпением ожидает внедрения реальной социально-ориентированной рыночной экономики...";
				}
			}
			else if (this.global1.data[45] == 5)
			{
				this.text_fake = "<color=blue>РЕАЛЬНАЯ ИСТОРИЯ</color>|";
			}
			else if (this.global1.data[45] == 6)
			{
				if (this.global1.data[51] + this.global1.data[52] * 3 > 10)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(24);
					}
					this.text_fake = "|<color=red>РАСЧЁТ...|</color>";
					this.text_fake += "<color=blue>Борис Пуго</color>|";
					this.text_fake += "На новых президентских выборах к власти пришел Борис Пуго, бывший Министр Внутренних Дел, который сразу же начал огромную кампанию против коррупции и рыночных махинаций, а также массовое преследование националистов, в том числе и прибалтийских, сам будучи латышом по национальности. Дальнейшим шагом стало продавливание смены вектора рыночных реформ на китайский аналог реформ птичьей клетки, с многократным усилением государственного вмешательства. А ровно через полгода трагично скончался Горбачёв на операционном столе...| Резкое падение уровня коррупции и спекуляции, чистки государственных структур и переход к более эффективным методам проведения экономических реформ уже дают множественные плоды в виде подъема социального, экономического и духовного.";
				}
				else
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(25);
					}
					this.text_fake = "|<color=red>РАСЧЁТ...|</color>";
					this.text_fake += "<color=blue>Геннадий Зюганов</color>|";
					this.text_fake += "На новых президентских выборах к власти пришел Геннадий Зюганов. Его обещаниями были: поддержка религиозной свободы, в частности Православия, честная приватизация нерентабельных госпредприятий после реструктуризации экономики и увеличение социальных расходов за счёт этого, что должно было привести к улучшению материального положения населения.|И своё правление он начал с открытием множества СЭЗ на территории страны, приглашением иностранных инвесторов и продаже дешёвой рабочей силы им. Следующим шагом он видит исполнение требований для членства СССР в ВТО...|Горбачёв, который после самороспуска ГКЧП вновь получил возможность свободно выступать и печататься, поддержал деяния Зюганова и, вскоре, даже был назначен его личным советником.";
				}
			}
			else if (this.global1.data[45] == 7)
			{
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(29);
				}
				this.text_fake = "<color=blue>Виктор Алкснис</color>|";
				this.text_fake += "Президентом был утверждён Виктор Алкснис, как и ожидалось, который сразу же начал огромную кампанию против коррупции и рыночных махинаций, а также массовое преследование националистов, в том числе и прибалтийских, сам будучи латышом по национальности. Дальнейшим шагом стало продавливание смены вектора рыночных реформ на китайский аналог реформ птичьей клетки, с многократным усилением государственного вмешательства.| Резкое падение уровня коррупции и спекуляции, чистки государственных структур и переход к более эффективным методам проведения экономических реформ уже дают множественные плоды в виде подъема социального, экономического и духовного.";
			}
			else if (this.global1.data[45] == 8)
			{
				if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[52] * 50 >= 1200)
				{
					bool iron_and_blood7 = this.global1.iron_and_blood;
					this.text_fake = "|<color=red>РАСЧЁТ...|</color>";
					this.text_fake = "<color=blue>Виктор Тюлькин</color>|";
					this.text_fake += "На президентских выборах одержал победу единый кандидат от левой оппозиции – Виктор Тюлькин, член КПСС и КП РСФСР, ранее выступавший с резкой критикой Горбачёва. Придя к власти с обещаниями многократного усиления социальной политики и укрепления взаимосвязей между республиками, Тюлькин в первую очередь начал оказывать давление на местные элиты, используя против них подсмотренные у Слободана Милошевича «антибюрократические» и «йогуртовые» технологии, в результате которых ему удалось сменить руководство России, Украины, Казахстана и Киргизии на своих людей. Восстановление кооперационных связей между предприятиями, наведение порядка в логистики и нормативных документах, полноценное внедрение принципа «четырех свобод» позволили более-менее восстановить единое экономическое пространство и к 2008 году вывести ССГ на 4-е место в Европе по уровню роста ВВП. Во внешней политике началось постепенное сближение с КНР при сохранении (насколько это возможно) доверительных отношений со странами Запада, благодаря чему удалось добиться от НАТО гарантий его нерасширения на постсоветское пространство. При Тюлькине в состав ССГ вошла Армения, что позволило урегулировать проблему Нагорного Карабаха и значительно разрядить обстановку в Закавказье. Благодаря контактам с Китаем, Союз не отстаёт от научно-технического прогресса и начинает внедрение собственного Интернета, что способствовало демократизации общественной жизни. \nВпрочем, с годами политика Тюлькина становится всё менее «красной» и всё более консервативно-русофильской, что начинает вызывать глухое недовольство на Украине и в Средней Азии.";
				}
				else if ((double)this.global1.allcountries[17].Westalgie + (double)this.global1.data[7] * 0.9 + (double)(this.global1.data[52] * 50) >= 800.0)
				{
					bool iron_and_blood8 = this.global1.iron_and_blood;
					this.text_fake = "|<color=red>РАСЧЁТ...|</color>";
					this.text_fake = "<color=blue>Борис Громов</color>|";
					this.text_fake += "Новым президентом ССГ стал бывший советский генерал Борис Громов, поддержанный широкой национал-патриотической коалицией и обещавший «закон и порядок». Под предлогом борьбы с организованной преступностью были резко расширены полномочия милиции и МСБ, что спровоцировало конфликт Громова с республиканскими элитами, однако ему удалось постепенно устранить из политики наиболее влиятельные фигуры своих противников и заменить их на лояльных ему силовиков. С каждым годом наступление государства на оппозицию возрастало, в результате чего всё политическое поле было фактически зачищено, а практически все лидеры оппозиции или убиты, или арестованы, или принуждены к эмиграции. Экономическая политика характеризовалась созданием «национально-ориентированного» капитала посредством приватизации активов близкими к президенту чиновниками, как правило славянского происхождения, при формальном контроле государства над новыми корпорациями. Во внешней политике Громов начал линию на непризнание итогов Холодной войны и поддержание дестабилизации внутри ЕС с помощью финансирования любых антиглобалистских сил в его странах (от ультраправых до остатков старых компартий). К середине 2000-х годов ССГ фактически превратился в большой военный лагерь, начавший силовым путем пересматривать границы постсоветского пространства: в 2008 году была оккупирована Грузия, годом спустя занята Молдавия, в 2014 году присоединена Армения, а в 2018 году в результате «специальной особой операции» захвачена Монголия. \nАгрессивное расширение ССГ спровоцировало вступление всех его западных соседей в НАТО, значительное похолодание отношений с Китаем и ввод против Союза многочисленных экономических санкций, однако режим Громова чувствует себя вполне уверенно — в отличие от нищающего с каждым годом населения, запуганного репрессиями и ожидающего в ближайшем будущем начала Третьей мировой войны. В свою очередь, официальная пропаганда уже призывает к «русскому походу» на Прибалтику и окончательному восстановлению границ 1985 года…";
				}
				else
				{
					bool iron_and_blood9 = this.global1.iron_and_blood;
					this.text_fake = "|<color=red>РАСЧЁТ...|</color>";
					this.text_fake = "<color=blue>Анатолий Собчак</color>|";
					this.text_fake += "Вопреки прогнозам, указывавшим на победу генерала Бориса Громова — новым лидером ССГ стал профессор ЛГУ и экс-мэр Ленинграда Анатолий Собчак, обещавший интегрировать Союз в западную цивилизацию и осуществить переход к демократическому обществу и свободному рынку. Впрочем, политика нового президента с самого начала встретила сопротивление республиканских элит и консервативных сил, что привело к половинчатому характеру проведённых реформ: несмотря на масштабную приватизацию 1995-1999 годов, за государством сохранились ключевые предприятия ВПК и ТЭК, многопартийная система была значительно ограничена усложнёнными требованиями к регистрации новых партий, законодательство о СМИ, митингах и забастовках практически не подверглось изменению со времён Перестройки. Во внешней политике Собчак взял курс на продолжение Нового политического мышления, однако заявки ССГ на вступление в НАТО и ЕС были отклонены, а на вступление в ВТО — оговорена большим количеством требований, исполнению которых противодействуют националистические и неокоммунистические силы. К середине 2000 годов ССГ остаётся государством с гибридным режимом и полурыночной экономикой, а оппозиция критикует становящегося всё более авторитарным президента за непомерную коррупцию, кумовство, набирающую обороты неолиберальную социальную политику (так, в 2005 году Собчак во исполнение требований ВТО начал проведение пенсионной реформы, вызвавшей массовые протесты в славянских республиках) и игнорирование эпатажного поведения его дочери Ксении, окруженной шлейфом скандалов. \nНа фоне экономического кризиса 2008 года в Киеве начались массовые протесты под лозунгами выхода Украины из состава ССГ, во время которых Собчак неожиданно скончался от сердечной недостаточности. Исполняющим обязанности президента стал его ближайший соратник — Владимир Путин, объявивший о намерении защитить «русский мир» от посягательств «внутренних либералов и настоящих фашистов».";
				}
			}
			else if (this.global1.data[45] == 9)
			{
				bool iron_and_blood10 = this.global1.iron_and_blood;
				this.text_fake = "|<color=red>РАСЧЁТ...|</color>";
				this.text_fake = "<color=blue>Гавриил Попов</color>|";
				this.text_fake += "На прошедших президентских выборах неожиданно победил экс-мэр Москвы Гавриил Попов — во-многом из-за того, что противостоящие ему Юрий Белов (КПРФ) и Олег Малышкин (ЛДПСС) вообще не были известны избирателям. Попов представил центристскую программу «эволюционного перехода», которая началась со значительного расширения бюрократического аппарата и постепенной нейтрализации с его помощью республиканских элит (так, бывший соратник Попова Борис Ельцин в 1993 году был вынужден \"уйти\" с поста президента России после неперижитого гипертонического криза (хотя по слухам его и так ждал импичмент, который поддержали даже депутаты от проельцинских партий). В экономике был взят курс на объединение остатков союзных предприятий в госкорпорации и крупные конгломераты, представители которых тесно срослись с чиновниками и силовиками, при поддержании минимально возможного уровня социальных расходов. Во внешней политике Попов, как приверженец курса на евроинтеграцию, проводил проевропейскую линию и приветствовал вступление в ЕС прибалтийских стран. При этом в сфере культуры проводился курс на максимальную либерализацию – настолько, что ССГ стал одной из первых стран Европы, легализовавших однополые браки и употребление легких наркотиков (при этом нашумевшая инициатива Попова о декриминализации проституции не встретила понимания даже среди либералов и была отклонена). Благодаря стабилизации экономики и высоким ценам на углеводороды, уровень жизни подавляющей части населения Союза даже превзошел советский уровень, однако платой за это стало опутывание страны спрутом бюрократии (количество чиновников в 13 раз превысило таковое в СССР при меньшей территории) и коррупции. \nНачиная с середины 2000-х годов славянские республики ССГ стали сотрясать крупные митинги под антикоррупционными и антибюрократическими лозунгами, а в республиках Средней Азии, недовольных националистической риторикой президента, начался переход на латинский алфавит и появились «языковые патрули». Похоже, Союзу вновь не избежать масштабного кризиса…";
			}
			else if (this.global1.data[45] == 10)
			{
				bool iron_and_blood11 = this.global1.iron_and_blood;
				this.text_fake = "<color=red>ЗАРЯ НОВОЙ ЕВРОПЕЙСКОЙ ВОЙНЫ</color>|";
			}
			else if (this.global1.data[45] == 11)
			{
				bool iron_and_blood12 = this.global1.iron_and_blood;
				this.text_fake = "<color=blue>РЕАЛЬНАЯ ИСТОРИЯ ГОД ТОМУ ВПЕРЁД</color>|";
			}
		}
		else if (this.this_okno == 5)
		{
			this.Name.text = "НАУЧНЫЕ ДОСТИЖЕНИЯ";
			this.text_fake = "";
			if (this.global1.data[0] != 10 && this.global1.data[0] != 12 && this.global1.data[0] != 18 && (this.global1.data[0] < 49 || this.global1.data[0] > 51))
			{
				if (((this.global1.data[42] == 2 && this.global1.science[1]) || (this.global1.science[2] && this.global1.data[42] != 7 && this.global1.data[17] != 17)) && !this.global1.allcountries[this.global1.data[0]].Vyshi)
				{
					this.text_fake = "Мы успешно исследовали и внедрили новые методы наблюдения за гражданами с целью защиты нашего государства. Камеры наблюдения, прослушки и электронные базы данных на каждого гражданина позволяют нам знать почти всё об интересующих нас людях. И, хотя иногда эти меры создают неудобства народу и некоторым не нравится мысль, что за ними наблюдают, нам бы всё равно пришлось бороться с внутренними и внешними врагами. Благодаря нашей системе, мы можем сделать это максимально быстро и эффективно, не затронув невиновных.|";
				}
				else if ((this.global1.science[1] && (this.global1.data[14] >= 3 || this.global1.allcountries[this.global1.data[0]].Vyshi)) || this.global1.science[2])
				{
					this.text_fake = "Несмотря на определённые подвижки в развитии методов слежки за населением, наши дальнейшие движения в сторону либерализации вынудили нас свернуть работы. Идейные либералы и реформаторы, чьи ценности стали для нас одними из основных, не захотели терпеть подобного нарушения прав человека, какие бы ни стояли за ними цели. Нам придётся использовать другие методы защиты государства от внутренних и внешних врагов.|";
				}
				else
				{
					this.text_fake = "Достижений в установлении тотальной слежки - нет.|";
				}
				if ((this.global1.data[43] == 2 && this.global1.science[4]) || (this.global1.science[5] && this.global1.data[43] == 1 && this.global1.data[18] <= 20))
				{
					if (this.global1.data[44] <= 2)
					{
						this.text_fake += "|На основе исследований Глушкова и Китова мы успешно разработали и построили ОГАС, внедрив её в наш Госплан. Эта централизованная система, учитывающая наши производственные возможности, ресурсы и динамику потребностей, теперь управляет всеми нашими предприятиями, искореняя приписки, несмотря на протесты некоторых консерваторов. Это позволяет нашей экономике быстро наращивать темпы роста, а некоторые уже уверенно предсказывают наступление будущего автоматизированного коммунизма.|";
					}
					else
					{
						this.text_fake += "|На основе исследований Глушкова и Китова мы успешно разработали и построили ОГАС, внедрив её в наш Госплан. Эта централизованная система, учитывающая наши производственные возможности, ресурсы и динамику потребностей, теперь управляет всеми нашими предприятиями, искореняя приписки, несмотря на протесты некоторых консерваторов. Это позволяет нашей экономике быстро наращивать темпы роста и идти в ногу со временем в мировой военной гонке.|";
					}
				}
				else if ((this.global1.science[4] || this.global1.science[5]) && this.global1.data[43] <= 2)
				{
					this.text_fake += "|Несмотря на определённые подвижки в развитии компьютеризации и внедрении её в нашу экономику, до разработки ОГАС наши руки и средства так и не дошли. В итоге (в том числе под давлением консерваторов) было решено ограничиться внедрением АСУ и РАСУ, что, конечно, увеличило рост нашей экономики и помогло бороться с коррупционерами. Однако мечты кибернетиков 50-х годов о построении единой централизованной автоматизированной системы, способной искоренить приписки и обеспечить максимально эффективное производство, так и остаются мечтами.|";
				}
				else if ((this.global1.science[4] || this.global1.science[5]) && this.global1.data[43] > 2)
				{
					this.text_fake += "|Несмотря на развитие компьютеризации и внедрение её в нашу экономику, дальнешйие экономические реформы в сторону свободного рынка поставили крест на построении ОГАС. Разрозненным частным компаниям, конкурирующим за прибыль, не нужна была единая централизованная система, учитывающая наши производственные возможности, ресурсы и динамику потребностей. Работы над ОГАС были свёрнуты, а сама она так и осталась смелой мечтой из прошлого.|";
				}
				else
				{
					this.text_fake += "|Достижений во внедрении автоматизации - нет.|";
				}
				if ((this.global1.data[42] != 9 && this.global1.data[42] != 10 && this.global1.data[42] != 6 && this.global1.data[42] != 5 && this.global1.data[42] != 2 && this.global1.science[5] && this.global1.science[7]) || (this.global1.science[8] && this.global1.data[42] != 5 && this.global1.data[42] != 6 && this.global1.data[42] != 2 && ((this.global1.data[42] != 9 && this.global1.data[14] <= 0) || this.global1.data[42] == 9) && this.global1.data[42] != 10))
				{
					this.text_fake += "|Мы успешно развили и внедрили передовую генетику в наше сельское хозяйство и медицину. Это позволило нам получать гораздо больше урожаев, улучшив вкус и стойкость выращиваемых продуктов к окружающим воздействиям, и эффективнее бороться с болезнями, помогая определять их происхождение. Перед нашими учёными простираются бесконечные перспективы вплоть до выращивания искусственных органов и продуктов.|";
				}
				else if ((this.global1.science[7] || this.global1.science[8]) && (this.global1.data[42] == 9 || this.global1.data[42] == 2))
				{
					this.text_fake += "|Развитие генетики вызвало в наших научных и партийных кругах разногласия и ожесточённые споры. В итоге под давлением части учёных вместе с консервативными общественными и партийными деятелями новые методы генетики были признаны лженаучными, противоречащими материализму и пропагандирующими расизм и евгенику. Новые исследования в генетике вскоре застопорились, часть учёных лишили своих степеней, часть перешли в другие области или вынуждены были отказаться от своих взглядов на генетику.|";
				}
				else if (this.global1.science[7] || this.global1.science[8])
				{
					this.text_fake += "|Развитие генетики вызвало большое беспокойство среди консервативных общественных и политических деятелей и духовенства. В итоге под их давлением, генетика была признана противоречащей человеческой природе, традициям и божественному замыслу и запрещена, как неэтичная лженаука. Исследования в этой области были свёрнуты, заставляя учёных скрывать свои взгляды и перестраиваться на другие области науки.|";
				}
				else
				{
					this.text_fake += "|Достижений в развитии генетики - нет.|";
				}
			}
			else if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
			{
				if (this.global1.science[0] && this.global1.science[1] && this.global1.science[7] && (this.global1.data[42] == 2 || (this.global1.data[42] != 7 && this.global1.data[17] != 17)) && !this.global1.allcountries[this.global1.data[0]].Vyshi)
				{
					this.text_fake = this.yug1.science_text[41];
				}
				else if (this.global1.science[0] && this.global1.science[1] && this.global1.science[7])
				{
					this.text_fake = this.yug1.science_text[42];
				}
				else
				{
					this.text_fake = this.yug1.science_text[43];
				}
				bool flag3 = false;
				for (int num3 = 0; num3 < this.yug1.gameState.yugcountries.Length; num3++)
				{
					if (this.yug1.gameState.yugcountries[num3].is_exist && num3 != this.yug1.gameState.player)
					{
						flag3 = true;
						break;
					}
				}
				if (this.global1.science[6] && this.global1.science[8] && (this.global1.data[135] > 7 || !flag3 || this.global1.data[114] != 100))
				{
					this.text_fake += this.yug1.science_text[44];
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(79);
					}
				}
				else if (this.global1.science[6] && this.global1.science[8])
				{
					this.text_fake += this.yug1.science_text[45];
				}
				else
				{
					this.text_fake += this.yug1.science_text[46];
				}
			}
			else
			{
				if ((this.global1.data[42] == 2 && this.global1.science[1]) || this.global1.science[2])
				{
					this.text_fake = "Благодаря прагматичному руководству правительства Министерство Внутренних дел нашей страны претерпело серьёзные реформы, в результате которых удалось создать работоспособную систему милиции, что, в свою очередь, гарантировало безопасность и спокойную жизнь нашим гражданам. А успешные реформы в области разведки и зарубежной агентуры позволили усилить влияние наших спецслужб на мировой арене.|";
				}
				else
				{
					this.text_fake = "|Достижений нет.|";
				}
				if (this.global1.science[5])
				{
					this.text_fake += "За последние несколько лет наша страна смогла нарастить темпы экономического роста и начать курс на промышленную индустриализацию. Проведение форсированного строительства фабрик позволило увеличить потенциал нашей экономики и заметно усилило нашу роль в глобальном мировом хозяйстве. Вследствие этого мы смогли преодолеть отставание от более развитых стран, начав стремительное движение к построению индустриального общества.|";
				}
				else
				{
					this.text_fake += "|Достижений нет.|";
				}
				if ((this.global1.data[42] != 9 && this.global1.data[42] != 10 && this.global1.data[42] != 6 && this.global1.data[42] != 5 && this.global1.data[42] != 2 && this.global1.science[5] && this.global1.science[7]) || this.global1.science[8])
				{
					this.text_fake += "|Правительству нашей страны удалось провести успешную аграрную реформу, которая значительно улучшила продуктивность сельского хозяйства и техническую оснащённость сельхоз-предприятий. Логическим результатом этого был рост производства и потребления продовольствия на душу населения, что весьма положительно повлияло на уровень жизни и здоровье наших граждан.|";
				}
				else
				{
					this.text_fake += "|Достижений нет.|";
				}
			}
		}
		else if (this.this_okno == 6 && this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
		{
			this.Name.text = this.yug1.science_text[47];
			bool flag4 = false;
			for (int num4 = 0; num4 < this.yug1.gameState.yugcountries.Length; num4++)
			{
				if (this.yug1.gameState.yugcountries[num4].is_exist && num4 != this.yug1.gameState.player)
				{
					flag4 = true;
					break;
				}
			}
			if (this.global1.science[9] && (this.global1.data[135] > 7 || !flag4 || this.global1.data[114] != 100))
			{
				this.text_fake = this.yug1.science_text[48];
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(78);
				}
			}
			else if (this.global1.science[9])
			{
				this.text_fake = this.yug1.science_text[49];
			}
			else
			{
				this.text_fake = this.yug1.science_text[50];
			}
		}
		else if (this.this_okno == 6)
		{
			this.Name.text = "ЯДЕРНЫЕ ДОСТИЖЕНИЯ";
			this.text_fake = "";
			if (this.global1.science[9] && !this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.data[22] > 500)
			{
				this.text_fake = "Видя, как легко можно перекроить мир и понимая необходимость защиты нашего суверенитета своими силами, мы приняли решение о разработке ядерного оружия. Получив технологии и сырьё, мы успешно завершили разработку, создав своё ядерное оружие, и гордо заявили об этом миру. Это вызвало немалый переполох, однако никто уже не мог ничего поделать. Теперь любая страна будет с нами считаться, а враг дважды подумает перед тем, как нападать на нас.|";
			}
			else if (this.global1.science[9] && this.global1.allcountries[this.global1.data[0]].Vyshi)
			{
				this.text_fake = "Видя, как легко можно перекроить мир и понимая необходимость защиты нашего суверенитета своими силами, мы приняли решение о разработке ядерного оружия. Мы получили технологии и сырьё, однако Запад, догадываясь о наших планах, не пожелал иметь конкурента. К нам была направлена комиссия МАГАТЭ, которая обнаружила наши разработки. Под мировым давлением, давлением партаппарата и поднявшего голову диссидентского движения, нам пришлось отказаться от военной ядерной программы, а все наши объекты мирного атома теперь жёстко контролируются МАГАТЭ.|";
			}
			else if (this.global1.science[9])
			{
				this.text_fake = "Видя, как легко можно перекроить мир и понимая необходимость защиты нашего суверенитета своими силами, мы приняли решение о разработке ядерного оружия. Мы получили технологии и сырьё, однако Запад, чьи ценности мы так старательно перенимали, догадываясь о наших планах, не пожелал иметь конкурента. К нам была направлена комиссия МАГАТЭ, которая обнаружила наши разработки. Под мировым давлением, не в силах противостоять ему из-за созданной нами свободы, нам пришлось отказаться от военной ядерной программы, а все наши объекты мирного атома теперь жёстко контролируются МАГАТЭ.|";
			}
			else
			{
				this.text_fake = "|Достижений в развитии ядерного оружия - нет.";
			}
			if (this.global1.allcountries[10].Stasi)
			{
				if (this.global1.iron_and_blood && !this.global1.science[9] && this.global1.science_time[9] <= 0)
				{
					this.achieves.GetComponent<achievements>().Set(23);
				}
				this.text_fake += "|По нашим новейшим сведениям известия о том, что КНДР не просто обладает ядерным оружием, а активно его наращивает и испытывает, производит ракеты большей дальности (бахвальствуя о том, что они скоро смогут долетать до всех городов мира), а также работает над разработкой водородного оружия, повергли весь мир в шок и ужас. Американский Президент Джордж Буш младший уже объявил Северную Корею мировой угрозой, а в Южной Корее теперь постоянно проходят южнокорейско-японско-американские учения. ООН требует от КНДР прекращения разработки водородного оружия и замораживания всех военных ядерных разработок. Северная Корея же требует прекращения провокаций на границах и вывода американских военных учреждений, ракет и ПРО, с территории Южной Кореи.|После денонсации мирного договора на Корейском полуострове вновь началось огромное напряжение... Но, кажется, новой войны хотят избежать все.";
			}
		}
		else if (this.this_okno == 7)
		{
			this.Name.text = "МИРОВАЯ ОБСТАНОВКА";
			this.text.text = "";
			for (int num5 = 2; num5 < this.global1.allcountries.Length; num5++)
			{
				if (this.global1.allcountries[num5] != null && num5 != this.global1.data[0] && num5 != 8 && num5 != 7 && num5 != 21 && num5 != 12 && num5 != 15 && num5 != 37 && num5 != 31 && num5 != 45 && num5 != 48 && num5 != 49 && num5 != 50 && num5 != 51 && num5 != 17 && num5 != 39 && num5 != 24 && num5 != 32 && num5 != 25 && (num5 < 40 || num5 > 43))
				{
					TextMesh textMesh42 = this.text;
					textMesh42.text = textMesh42.text + "<color=brown>" + this.global1.allcountries[num5].name + ":</color>";
					if (this.global1.allcountries[num5].subideology == 0)
					{
						if (PlayerPrefs.GetInt("language") == 0)
						{
							TextMesh textMesh43 = this.text;
							textMesh43.text += "<color=black> 左 翼 民 族 主 义,</color>";
						}
						else
						{
							TextMesh textMesh44 = this.text;
							textMesh44.text += "<color=black> Левый национализм,</color>";
						}
					}
					else if (this.global1.allcountries[num5].subideology == 1)
					{
						if (PlayerPrefs.GetInt("language") == 0)
						{
							TextMesh textMesh45 = this.text;
							textMesh45.text += "<color=black> 民 族 布 尔 什 维 主 义,</color>";
						}
						else
						{
							TextMesh textMesh46 = this.text;
							textMesh46.text += "<color=black> Национал-большевизм,</color>";
						}
					}
					else if (this.global1.allcountries[num5].subideology == 2)
					{
						if (PlayerPrefs.GetInt("language") == 0)
						{
							TextMesh textMesh47 = this.text;
							textMesh47.text += "<color=black> 亲 市 场 独 裁 体 制,</color>";
						}
						else
						{
							TextMesh textMesh48 = this.text;
							textMesh48.text += "<color=black> Рыночная диктатура,</color>";
						}
					}
					else if (this.global1.allcountries[num5].subideology == 3)
					{
						if (PlayerPrefs.GetInt("language") == 0)
						{
							TextMesh textMesh49 = this.text;
							textMesh49.text += "<color=black> 第 三 道 路,</color>";
						}
						else
						{
							TextMesh textMesh50 = this.text;
							textMesh50.text += "<color=black> Третий путь,</color>";
						}
					}
					else if (this.global1.allcountries[num5].subideology == 4)
					{
						if (PlayerPrefs.GetInt("language") == 0)
						{
							TextMesh textMesh51 = this.text;
							textMesh51.text += "<color=purple> 保 守 社 会 主 义,</color>";
						}
						else
						{
							TextMesh textMesh52 = this.text;
							textMesh52.text += "<color=purple> Консервативный социализм,</color>";
						}
					}
					else if (this.global1.allcountries[num5].subideology == 5)
					{
						if (PlayerPrefs.GetInt("language") == 0)
						{
							TextMesh textMesh53 = this.text;
							textMesh53.text += "<color=purple> 托 洛 茨 基 主 义,</color>";
						}
						else
						{
							TextMesh textMesh54 = this.text;
							textMesh54.text += "<color=purple> Троцкизм,</color>";
						}
					}
					else if (this.global1.allcountries[num5].subideology == 6)
					{
						if (PlayerPrefs.GetInt("language") == 0)
						{
							TextMesh textMesh55 = this.text;
							textMesh55.text += "<color=purple> 毛 主 义,</color>";
						}
						else
						{
							TextMesh textMesh56 = this.text;
							textMesh56.text += "<color=purple> Маоизм,</color>";
						}
					}
					else if (this.global1.allcountries[num5].subideology == 7)
					{
						if (PlayerPrefs.GetInt("language") == 0)
						{
							TextMesh textMesh57 = this.text;
							textMesh57.text += "<color=purple> 反 修 正 主 义,</color>";
						}
						else
						{
							TextMesh textMesh58 = this.text;
							textMesh58.text += "<color=purple> Антиревизионизм,</color>";
						}
					}
					else if (this.global1.allcountries[num5].subideology == 8)
					{
						if (PlayerPrefs.GetInt("language") == 0)
						{
							TextMesh textMesh59 = this.text;
							textMesh59.text += "<color=green> 民 主 社 会 主 义,</color>";
						}
						else
						{
							TextMesh textMesh60 = this.text;
							textMesh60.text += "<color=green> Демократический социализм,</color>";
						}
					}
					else if (this.global1.allcountries[num5].subideology == 9)
					{
						if (PlayerPrefs.GetInt("language") == 0)
						{
							TextMesh textMesh61 = this.text;
							textMesh61.text += "<color=green> 左 翼 社 会 民 主 主 义,</color>";
						}
						else
						{
							TextMesh textMesh62 = this.text;
							textMesh62.text += "<color=green> Левая социал-демократия,</color>";
						}
					}
					else if (this.global1.allcountries[num5].subideology == 10)
					{
						if (PlayerPrefs.GetInt("language") == 0)
						{
							TextMesh textMesh63 = this.text;
							textMesh63.text += "<color=green> 红 色 保 守 主 义,</color>";
						}
						else
						{
							TextMesh textMesh64 = this.text;
							textMesh64.text += "<color=green> Красный торизм,</color>";
						}
					}
					else if (this.global1.allcountries[num5].subideology == 11)
					{
						if (PlayerPrefs.GetInt("language") == 0)
						{
							TextMesh textMesh65 = this.text;
							textMesh65.text += "<color=green> 政 治 实 用 主 义,</color>";
						}
						else
						{
							TextMesh textMesh66 = this.text;
							textMesh66.text += "<color=green> Политический прагматизм,</color>";
						}
					}
					else if (this.global1.allcountries[num5].subideology == 12)
					{
						if (PlayerPrefs.GetInt("language") == 0)
						{
							TextMesh textMesh67 = this.text;
							textMesh67.text += "<color=blue> 中 间 主 义,</color>";
						}
						else
						{
							TextMesh textMesh68 = this.text;
							textMesh68.text += "<color=blue> Центризм,</color>";
						}
					}
					else if (this.global1.allcountries[num5].subideology == 13)
					{
						if (PlayerPrefs.GetInt("language") == 0)
						{
							TextMesh textMesh69 = this.text;
							textMesh69.text += "<color=blue> 右 翼 社 会 民 主 主 义,</color>";
						}
						else
						{
							TextMesh textMesh70 = this.text;
							textMesh70.text += "<color=blue> Правая социал-демократия,</color>";
						}
					}
					else if (this.global1.allcountries[num5].subideology == 14)
					{
						if (PlayerPrefs.GetInt("language") == 0)
						{
							TextMesh textMesh71 = this.text;
							textMesh71.text += "<color=blue> 自 由 保 守 主 义,</color>";
						}
						else
						{
							TextMesh textMesh72 = this.text;
							textMesh72.text += "<color=blue> Либерал-консерватизм,</color>";
						}
					}
					else if (this.global1.allcountries[num5].subideology == 15)
					{
						if (PlayerPrefs.GetInt("language") == 0)
						{
							TextMesh textMesh73 = this.text;
							textMesh73.text += "<color=blue> 欧 洲 大 西 洋 主 义,</color>";
						}
						else
						{
							TextMesh textMesh74 = this.text;
							textMesh74.text += "<color=blue> Евроатлантизм,</color>";
						}
					}
					if (this.global1.allcountries[num5].Vyshi && !this.global1.allcountries[this.global1.data[0]].Vyshi)
					{
						TextMesh textMesh75 = this.text;
						textMesh75.text += "<color=blue> проамериканизм.</color>\n";
					}
					else if (this.global1.allcountries[num5].Vyshi && this.global1.allcountries[this.global1.data[0]].Vyshi)
					{
						TextMesh textMesh76 = this.text;
						textMesh76.text += "<color=blue> партнёр по НАТО.</color>\n";
					}
					else if (this.global1.allcountries[num5].isOVD && this.global1.allcountries[num5].Torg)
					{
						TextMesh textMesh77 = this.text;
						textMesh77.text += "<color=magenta> близкий союзник.</color>\n";
					}
					else if (this.global1.allcountries[num5].isOVD)
					{
						TextMesh textMesh78 = this.text;
						textMesh78.text += "<color=purple> друг.</color>\n";
					}
					else if (this.global1.allcountries[num5].isSEV)
					{
						TextMesh textMesh79 = this.text;
						textMesh79.text += "<color=teal> экономический партнёр.</color>\n";
					}
					else if (this.global1.allcountries[num5].Torg)
					{
						TextMesh textMesh80 = this.text;
						textMesh80.text += "<color=olive> торговый партнёр.</color>\n";
					}
					else if ((num5 == 4 && this.global1.data[149] == 3) || (num5 == 6 && this.global1.data[235] == 9) || (num5 == 20 && this.global1.data[177] == 3))
					{
						TextMesh textMesh81 = this.text;
						textMesh81.text += "<color=purple> республика Югославии.</color>\n";
					}
					else
					{
						TextMesh textMesh82 = this.text;
						textMesh82.text += "<color=black> сохраняет нейтралитет.</color>\n";
					}
				}
			}
			this.this_done_done = true;
		}
		else if (this.this_okno == 8)
		{
			this.Name.text = "СВОДКИ ПО МИРУ";
			this.text_fake = "|";
			if (this.global1.event_done[1079] && (this.global1.allcountries[17].Gosstroy == 1 || this.global1.allcountries[7].paths == 3))
			{
				if (this.global1.allcountries[17].Gosstroy == 1)
				{
					this.text_fake += "<color=purple>Суверенная Федеративная Республика Германия</color>";
					this.text_fake += "|Блок левых партий смог успешно удерживать власть в Германии на протяжении всех 90-х годов. Успешная социальная политика, вкупе с введением элементов «шведского социализма», расширением прав профсоюзов и поддержкой производства в восточных землях, требовали больших финансовых вливаний. В плане внешней политики, объединенная Германия стала дистанцироваться от НАТО, выйдя из его политических структур. Однако повышение налогов и дополнительные кредиты серьёзно ударили по среднему и высшему классу, поэтому на выборах 2000 года ХДС набрала 35% голосов и вместе с либералами сформировала новое правоцентристское правительство во главе с Фолькером Каудером, который пообещал \"бороться не только с левыми экономическими идеями, но и левыми социально-общественными идеями\", а также пообещал \"защищать суверенитет ФРГ\" и призвал США \"отказаться от поведения глобальной доминации\".";
				}
				else if (this.global1.allcountries[7].paths == 3)
				{
					this.text_fake += "<color=purple>Удар Воротникова по ФРГ</color>";
					this.text_fake += "|После воссоединения Германии Советский Союз настоял на пересмотре ряда договоров, в том числе «Два плюс четыре». Советский министр иностранных дел Юлий Воронцов выдвинул ноту западным державам, обвинив ФРГ в саботаже вывода советских войск с её территории. На новой международной конференции СССР потребовал предоставить контроль советской комиссии за выводом войск и выдвинул ряд следующих требований: ФРГ выходит из НАТО и закрепляет в конституции статус нейтральной державы, Советскому Союзу списываются все долги. В случае невыполнения этих нот, СССР прекратит вывод войск с территории Восточной Германии и передаст управление районом своей администрации. В западной печати против СССР развернулась кампания с обвинениями в агрессии, однако Германии пришлось отступить и выполнить требования, чтобы остаться целым и суверенным государством.";
				}
			}
			else if (this.global1.allcountries[1].Gosstroy != 2 && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy >= 2)) && ((this.global1.allcountries[17].Westalgie >= 300 && this.global1.allcountries[this.global1.data[0]].isOVD && this.global1.allcountries[7].isOVD) || (((this.global1.allcountries[17].Westalgie >= 350 && this.global1.allcountries[16].Gosstroy == 0) || this.global1.allcountries[17].Westalgie >= 400) && this.global1.allcountries[this.global1.data[0]].isSEV && (this.global1.allcountries[17].Westalgie >= 550 || this.global1.allcountries[7].isSEV))))
			{
				if (this.global1.data[0] != 1 || (this.global1.data[0] == 1 && this.global1.science[9]) || (this.global1.data[0] == 1 && (this.global1.data[14] < 2 || this.global1.data[14] > 4 || (this.global1.data[14] == 2 && this.global1.data[15] < 8 && this.global1.data[17] < 16) || (this.global1.data[14] == 4 && this.global1.data[16] > 12))))
				{
					this.text_fake += "<color=purple>Обновлённая Федеративная Республика Германия</color>";
					this.text_fake += "|<color=purple>В ФРГ</color>, в ходе реформации социалистического мира, падения пелены красной угрозы и расцвета идеи всемирной дружбы на очередных выборах одержала победу коалиция левых сил, выступавшая за пацифизм, социальные реформы, дружбу и мир. Следствием её победы стало не простое налаживание отношений с ГДР и признание Западного Берлина демилитаризованной зоной: Федеративная Республика объявила о выходе из военных структур НАТО, оставшись лишь в политических, и, вместе с ГДР, вывела со своих территорий иностранные военные базы, подписав договоры о не нахождении на территории обеих Германий чьих-либо войск или ракет, и о безъядерном статусе ФРГ. Это было поддержано и СССР и Францией, которая также одобрила выступления нового германского руководства за усиление экономической интеграции в Западной Европе, итогом чего, несмотря на недовольство новой политикой со стороны Великобритании и США, становится формирование Европейского Союза.";
				}
			}
			else if (this.global1.allcountries[1].Gosstroy != 2 && !this.global1.allcountries[7].Vyshi)
			{
				this.text_fake += "<color=purple>Федеративная Республика Германия</color>";
				this.text_fake += "|После неудачной попытки <color=purple>объединения Германии</color> Гельмут Коль проиграл борьбу в ФРГ за канцлерский пост в 1994. К власти пришла коалиция социал-демократов и зелёных во главе с Герхардом Шрёдером с обещаниями модернизации экономики, поддержки предпринимательства, сохранения системы социальной защиты и обеспечения более суверенной внешней политики. Следствием этого стало налаживание более дружественных отношений с СССР и новый виток разрядки в отношениях с ГДР.";
			}
			else if (this.global1.allcountries[1].Gosstroy != 2)
			{
				this.text_fake += "<color=purple>Федеративная Республика Германия</color>";
				this.text_fake += "|После неудачной попытки <color=purple>объединения Германии</color> Гельмут Коль проиграл борьбу в ФРГ за канцлерский пост в 1994. К власти пришла коалиция социал-демократов и зелёных во главе с Герхардом Шрёдером с обещаниями модернизации экономики, поддержки предпринимательства, сохранения системы социальной защиты и обеспечения более суверенной внешней политики. Следствием этого стало налаживание более дружественных отношений с Россией и новый виток разрядки в отношениях с ГДР.";
			}
			else
			{
				this.text_fake += "<color=purple>Единая Федеративная Республика Германия</color>";
				this.text_fake += "|Восточная Германия пала и теперь <color=purple>немецкий народ стал един</color>. Однако, это не решило множество проблем, которые были как и в ГДР, так и <color=purple>в ФРГ</color>. Германии еще предстоит много чего пережить.";
			}
			if (this.global1.allcountries[27].Donat)
			{
				this.text_fake += "||<color=purple>Австрия</color>|";
				if (this.global1.allcountries[27].Westalgie >= 2)
				{
					this.text_fake += this.dlce1.credits_text[365];
				}
				else if (this.global1.allcountries[27].Westalgie >= 1)
				{
					this.text_fake += this.dlce1.credits_text[366];
				}
				else
				{
					this.text_fake += this.dlce1.credits_text[367];
				}
			}
			else if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
			{
				this.text_fake += "||<color=purple>Австрия</color>|";
				if (this.yug1.gameState.yugregions[0].owner == 0 && !this.yug1.gameState.yugcountries[0].is_independent)
				{
					this.text_fake += this.dlce1.credits_text[368];
				}
				else if (this.yug1.gameState.yugregions[0].owner != 0)
				{
					this.text_fake += this.dlce1.credits_text[369];
				}
				else
				{
					this.text_fake += this.dlce1.credits_text[370];
				}
			}
			else
			{
				this.text_fake += "||<color=purple>Австрия</color>|";
				if (this.global1.data[7] >= 800 && this.global1.allcountries[27].Torg)
				{
					this.text_fake += this.dlce1.credits_text[385];
				}
				else
				{
					this.text_fake += this.dlce1.credits_text[386];
				}
			}
		}
		else if (this.this_okno == 9)
		{
			this.Name.text = "СВОДКИ ПО МИРУ";
			this.text_fake = "|";
			this.text_fake = "<color=purple>Греция</color>|";
			if (this.global1.allcountries[45].Gosstroy <= 1 && this.global1.allcountries[45].isSEV && !this.global1.allcountries[7].isOVD && this.greece_ally > 6)
			{
				this.text_fake += "Правящая греческая коалиция социалистов и коммунистов смогла успешно пережить проблемы социалистического лагеря конца XX века и, при нашей всецелой поддержке, наконец-то вывести страну из НАТО, объявив о своём нейтралитете и отказе от размещения ядерного оружия.|Сохраняя с нами экономические контакты Греция продолжает быть членом нашего Экономического альянса, несмотря на предложения о вступлении Греции в новосформированный Европейский Союз.";
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(44);
				}
			}
			else if ((this.global1.allcountries[45].Gosstroy <= 1 && this.global1.allcountries[45].isSEV && !this.global1.allcountries[7].isOVD && this.greece_ally <= 5) || this.global1.data[161] == 1 || this.global1.data[161] == 3)
			{
				this.text_fake += "Правящая греческая коалиция социалистов и коммунистов смогла успешно пережить проблемы социалистического лагеря конца XX века и, при нашей всецелой поддержке, наконец-то вывести страну из НАТО, объявив о своём нейтралитете и отказе от размещения ядерного оружия.|Несмотря на имеющиеся с нами экономические контакты, Греция принимает решение о вступлении в Европейский Союз под лозунгом страны-посредника между Востоком и Западом. Связи с нами они не обрывают, но всё же...";
			}
			else if (this.global1.allcountries[45].Gosstroy <= 1)
			{
				this.text_fake += "На следующий выборах греческая коалиция социалистов и коммунистов, после громкого скандала, развалилась, а власть в социалистической партии перешла к правоцентристскому крылу.|Несмотря на имеющиеся с нами экономические контакты, Греция принимает решение о вступлении в Европейский Союз под лозунгом страны-посредника между Востоком и Западом. Связи с нами они не обрывают, но всё же... ";
			}
			else
			{
				this.text_fake += "Греция продолжает оставаться членом НАТО и начинает принимать участие в формировании Европейского Союза.";
			}
			this.text_fake += "|";
			if (this.global1.data[0] < 49 || this.global1.data[0] > 51)
			{
				if (this.global1.data[59] != 2 && this.global1.allcountries[this.global1.data[0]].isOVD && (this.global1.allcountries[5].isOVD || this.global1.allcountries[6].isOVD) && (this.global1.data[54] >= 7 || (this.global1.allcountries[15].isOVD && this.global1.data[54] >= 5)) && !this.global1.allcountries[15].Help)
				{
					this.text_fake += "|<color=purple>Социалистическая Федеративная Республика Югославия</color>|";
					this.text_fake += "Американское предложение о вмешательстве в гражданскую войну в <color=purple>Югославии</color> было заблокировано некоторыми странами-членами Совбеза ООН, вследствие чего, благодаря нашей поддержке и поддержке со стороны нашего военного альянса, Милошевич и сербские государства смогли одержать победу в долгом и кровопролитном противостоянии. Югославия осталась целой и невредимой, хоть и перейдя окончательно к государственному капитализму и буржуазной демократии, во главе с Социалистической Партией и Милошевичем.";
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(31);
					}
				}
				else if (this.global1.data[54] >= 2 && !this.global1.allcountries[15].Help)
				{
					this.text_fake += "|<color=purple>Союзная Республика Югославия</color>|";
					this.text_fake += "В ходе гражданской войны в <color=purple>Югославии</color>, Милошевичу все же пришлось растаться с сепаратистами и перестать оказывать помощь сербским борцам. Однако, поддерживая связь с нами и другими странами-друзьями обновленной Югославии, новое государство получало множество помощи, в том числе и военной, а Милошевич лично получил поддержку наших спецслужб во время Бульдозерной революции и смог удержать власть, а американцы не решились на более глубокое вмешательство. А войны за Косово так и не произошло, как и бомбардировок НАТО - конфликт был подавлен в максимально быстрые сроки.";
				}
				else
				{
					this.text_fake += "|<color=purple>Распад Югославии</color>|";
					this.text_fake += "В ходе гражданской войны, <color=purple>Югославии</color> все же пришлось растаться со своими республиками и перестать оказывать помощь сербским борцам за суверенитет. А затем и пережить страшные бомбардировки авиации НАТО из-за проблем в Косово, приведшие к многочисленной гибели среди гражданского населения. Следующим шагом стала Бульдозерная революция и падение режима Милошевича, а вместе с ним и постепенный развал остатка Югославии.";
				}
			}
		}
		else if (this.this_okno == 10)
		{
			this.Name.text = "СВОДКИ ПО МИРУ";
			this.text_fake = "|";
			if (((this.global1.data[37] >= 6 && this.global1.allcountries[31].Help) || this.global1.data[37] >= 7) && this.global1.data[0] != 12 && !this.global1.allcountries[7].Vyshi && (this.global1.allcountries[7].isSEV || this.global1.allcountries[16].isSEV || this.global1.allcountries[19].Gosstroy <= 1) && this.global1.allcountries[12].Gosstroy == 9)
			{
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(22);
				}
				this.text_fake += "<color=purple>Демократическая Республика Афганистан</color>";
				this.text_fake += "|После начавшегося решительного наступления на позиции радикальной исламской оппозиции, при больших армейских и гуманитарных поставках извне, <color=purple>новому режиму Таная</color> удалось поставить под контроль практически всю границу с Пакистаном и планомерно зачистить большую часть сопротивления внутри страны. Начавшиеся реформы в духе исламского социализма, начала открытой работы мечетей, лавочников, кустарей и отказа от атеизма, позволили правительству в Кабуле найти общий язык с большей частью сельского населения пуштунского Афганистана, переставшего оказывать помощь моджахедам, многие из которых предпочли попасть под амнистию и разойтись по домам. Можно сказать, что ключевой этап гражданской войны позади, а оставшиеся немногочисленные отряды боевиков будут пойманы или уничтожены в ближайшие годы.";
			}
			else if (((this.global1.data[37] >= 8 && this.global1.allcountries[31].Help) || this.global1.data[37] >= 9) && this.global1.data[0] != 12 && !this.global1.allcountries[7].Vyshi && (this.global1.allcountries[7].isSEV || this.global1.allcountries[16].isSEV || this.global1.allcountries[19].Gosstroy <= 1))
			{
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(22);
				}
				this.text_fake += "<color=purple>Демократическая Республика Афганистан</color>";
				this.text_fake += "|Постоянно оказываемая нами и всем социалистическим блоком помощь <color=purple>режиму Наджибуллы</color>, вместе с введением жестких санкций против Пакистана и осуждением пакистанских террористов даже со стороны Франции и Китая (после того как те совершили ряд терактов по всему миру) - стали окончательным поворотным моментом в истории Афганистана. А реформы Наджибуллы, легализовавшие мелких частников, лавочки и кустарщину, вместе с интеграцией афганских традиций и религии в государственную идеологию, закрепили власть социалистов в стране. Гражданская война окончена.";
			}
			else if (this.global1.allcountries[12].Gosstroy == 9 && this.global1.data[0] != 12)
			{
				this.text_fake += "<color=purple>Гражданская война в Афганистане</color>";
				this.text_fake += "|Произошедший мятеж Таная существенным образом изменил баланс сил внутри НДПА, что практически никак не отразилось на боеспособности ДРА, т.к. практически все военные поддержали его. Благодаря этому, уже новому правительству по-прежнему удаётся контролировать большую часть страны. Некоторые страны, опасаясь расширения исламских террористов, начали оказывать давление на Пакистан, усложняя ему помощь террористам. Сообщается, о некоторых неформальных договорённостях между Кабулом и Исламабадом о прекращении активной поддержки последним радикальной оппозиции, в обмен на начало проведения исламских реформ в Афганистане и открытия местного рынка для пакистанских предпринимателей. С Китаем удалось договориться и выработать единую позицию по прекращению поддержки моджахедов. Тем не менее, излишняя радикальность действий афганских военных пока не позволила начавшимся исламским реформам перетянуть на свою сторону всё сельское население Афганистана, из-за чего гражданская война в Афганистане продолжается.";
			}
			else if (this.global1.allcountries[7].Gosstroy <= 1 && this.global1.data[0] != 12)
			{
				this.text_fake += "<color=purple>Гражданская война в Афганистане</color>";
				this.text_fake += "|СССР продолжил существовать, оказывая гуманитарную и военную поддержку <color=purple>Афганистану</color>, что позволило облегчить его положение. Некоторые страны, опасаясь расширения исламских террористов начали оказывать давление на Пакистан, усложняя ему помощь террористам. А с Китаем удалось договориться и выработать единую позицию по прекращению поддержки террористов. И, хотя, разногласия в НДПА и армии ДРА не были улажены до конца, а политика Наджибуллы имела свои изъяны, наступления террористов удалось пресечь, а ДРА контролирует достаточно территорий, чтобы существовать дальше. Решающего перевеса не оказалось ни у одной из сторон, так что гражданская война в Афганистане продолжается.";
			}
			else if (this.global1.data[0] != 12)
			{
				this.text_fake += "<color=purple>Исламское Государство Афганистан</color>";
				this.text_fake += "|После вывода советских войск положение <color=purple>Афганистана</color> начало стремительно ухудшаться - непоследовательная политика НДПА вместе с разногласиями в ней и в армейском руководстве привели к тому, что народ стал отворачиваться от Афганского правительства, а армия с трудом сдерживала натиск террористов. Оказавшись почти что в международной изоляции, Афганистан не мог получить поддержку извне, а Пакистан продолжал безнаказанно отправлять всё новые отряды исламистов. В апреле 1992 года террористы без боя вошли в Кабул, провозгласив Афганистан исламским государством. Все завоевания советской власти в социальной, экономической и правовой областях оказались уничтожены. А через 4 года и сам Наджибулла был зверски убит без суда и следствия.";
			}
			this.text_fake += "||";
			if (this.global1.allcountries[24].Stasi && this.global1.allcountries[24].Gosstroy != this.global1.allcountries[25].Gosstroy && this.global1.data[55] >= 3)
			{
				this.text_fake += "<color=purple>Социалистическая Республика Йемен</color>";
				this.text_fake += "|В ходе массового и быстрого развития нефтедобычи <color=purple>в НДРЙ</color>, страна стала новым крупным игроком на арене экспортёров нефти, следствием чего стало и увеличение как и нашей прибыли, так и оказания существенной дипломатической, политической и экономической помощи государствам-союзникам, имеющим одинаковые с нами и НДРЙ интересы. Мир стал прочнее. Для нас.";
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(33);
				}
			}
			else if ((this.global1.allcountries[24].Gosstroy == 0 || this.global1.allcountries[24].Gosstroy == 1) && this.global1.allcountries[24].Stasi)
			{
				this.text_fake += "<color=purple>Народная Демократическая Республика Йемен</color>";
				if (this.global1.data[55] == 2 && this.global1.allcountries[24].isSEV)
				{
					this.text_fake += "|В ходе массовых чисток <color=purple>в НДРЙ</color> сохранилась консервативная традиционная власть, которая существенным образом нарастила взаимодействие со своими зарубежными партнёрами. Благодаря инвестициям из нашей страны, началась разработка нефтяных месторождений, обнаруженных с советской помощью к концу 80х годов. И хотя пока предприятия работают не на полную мощность, первые нефтяные доходы позволили ЙСП укрепить свою власть и провести умеренные реформы в рамках социализма в стране. Тем не менее, аналитики предсказывают, что если новых изменений не будет, нефтедолларов может не хватить для стабилизации положения в стране, на фоне усиления терроризма в сельских районах на границе с Севером.";
				}
				else if (this.global1.allcountries[24].Gosstroy == 1)
				{
					this.text_fake += "|Начавшийся период незначительных экономических реформ <color=purple>в НДРЙ</color> позволил сохранить баланс между консервативной и реформистской фракциями внутри ЙСП. Так, был разрешён не только мелкий бизнес, но и средний, зарубежному капиталу были предоставлены дополнительные льготы в обмен на инвестиции. Благодаря этому в стране удалось запустить разработку нефтяных месторождений, обнаруженных с советской помощью к концу 80х годов, прибыль с которых позволяет удерживать экономику <color=purple>в НДРЙ</color>  на плаву, а сторонников объединения с Севером лишает дополнительных аргументов в необходимости воссоединения.";
				}
				else
				{
					this.text_fake += "|В ходе массовых чисток <color=purple>в НДРЙ</color> сохранилась консервативная традиционная власть, которая, тем не менее, была вынуждена провести незначительные рыночные реформы, вроде разрешения ИП, кооперативов и мелких частников в сфере услуг, вместе с открытием нескольких СЭЗ. НДРЙ остается одним из наших основных союзников на Ближнем Востоке, вместе с этим страна пытается начать развитие нефтедобычи, на основе месторождений, обнаруженных с советской помощью к концу 80х годов, но не разрабатывавшихся из-за дефицита средств и сокращения советской помощи.";
				}
			}
			else if (this.global1.data[55] >= 3 && this.global1.data[226] >= 2 && this.global1.allcountries[25].Stasi)
			{
				this.text_fake += "<color=purple>Демократическая Республика Йемен</color>";
				this.text_fake += "|<color=purple>Два Йемена</color> стали единым в обмен на передачу важных и крупных постов в правительстве деятелям режима социалистического Йемена и главенствующих постов деятелям буржуазного. После долгих переговоров о будущем республики и продолжительным политическим конфликтам, различным левым организациям удалось закрепить своё более привилегированное политическое положение, а ЙСП стала ведущей партией в стране. Благодаря разработке нефтяных месторождений уровень жизни в республике стал расти серьёзными темпами, благодаря введённым дополнительным налогам. Тем не менее, если с катастрофическими бедами вроде голода и жажды удалось справиться, на первое место встала коррупция, которая не позволяет добиться качественного улучшения в отделённых районах горной республики. Голову поднимает также исламский фундаментализм, получающий поддержку от других арабских государств.";
			}
			else if (this.global1.data[55] >= 3 && this.global1.allcountries[25].Stasi)
			{
				this.text_fake += "<color=purple>Республика Йемен</color>";
				this.text_fake += "|<color=purple>Два Йемена</color> стали единым в обмен на передачу важных и крупных постов в правительстве деятелям режима социалистического Йемена и главенствующих постов деятелям буржуазного. После долгих переговоров о будущем республики северянам удалось во многом закрепить за собой более привилегированное политическое положение, а Всеобщий народный конгресс стал ведущей партией в стране. После начала разработки нефтяных месторождений стране удаётся поддерживать курс на повышение уровня жизни, искореняя голод, жажду и неграмотность среди всех жителей новой республики. Особую роль играет «налог на юг», благодаря которому бедственное положение бывших жителей НДРЙ начало выправляться. Тем не менее, проиграв в политической борьбе ЙСП распалась на несколько более мелких партий, занимающих полумаргинальное положение в йеменской политике.";
			}
			else if (this.global1.data[226] >= 2 && this.global1.allcountries[25].Stasi)
			{
				this.text_fake += "<color=purple>Демократическая Республика Йемен</color>";
				this.text_fake += "|<color=purple>Два Йемена</color> стали единым в обмен на передачу важных и крупных постов в правительстве деятелям режима социалистического Йемена и главенствующих постов деятелям буржуазного. После долгих переговоров о будущем республики стало понятно, что достичь компромисса, устраивающего всех – будет невозможно. После начавшихся на территории Южного Йемена вооружённых выступлений сторонников ЙСП во главе с Али Салим аль-Бейдом страна вновь оказалось разделённой, а идеи объединения – канули в небытие. Тем не менее ДРЙ пока не получил официального международного признания, за исключением поддержки ряда стран арабского региона.";
			}
			else
			{
				this.text_fake += "<color=purple>Единая Республика Йемен</color>";
				this.text_fake += "|<color=purple>Два Йемена</color> стали единым в обмен на передачу важных и крупных постов в правительстве деятелям режима социалистического Йемена и главенствующих постов деятелям буржуазного. Однако, такая шаткая коалиция продлилась недолго и, после окончательной потери влияния социалистического мира на эту территорию, политики бывшего НДРЙ были вышвырнуты со своих постов, а при попытке начать восстание из-за своего разочарования - подверглись преследованию. ";
			}
		}
		else if (this.this_okno == 11)
		{
			this.Name.text = "СВОДКИ ПО МИРУ";
			this.text_fake = "|";
			if (this.global1.allcountries[21].Gosstroy != 1)
			{
				for (int num6 = 40; num6 < 44; num6++)
				{
					if (this.global1.allcountries[num6].Westalgie >= 1000)
					{
						this.text_fake = this.text_fake + "<color=purple>" + this.global1.allcountries[num6].name + "</color>: В стране произошла стабилизация. Левая коалиция окончательно утвердила свою власть на всей территории страны, сформировав социалистическое правительство и социалистическую республику. Торжество социализма наступило.|";
					}
					else if (this.global1.allcountries[num6].Westalgie >= 600)
					{
						this.text_fake = this.text_fake + "<color=purple>" + this.global1.allcountries[num6].name + "</color>: Произошла частичная стабилизация. Левая коалиция смогла взять власть в стране, сформировав режим Народной демократии, в то время как оппозиция всё еще существует и сеет смуту, а её радикализированное крыло продолжаёт партизанствовать.|";
					}
					else if (this.global1.allcountries[num6].Westalgie > 0)
					{
						this.text_fake = this.text_fake + "<color=purple>" + this.global1.allcountries[num6].name + "</color>: Произошла частичная стабилизация. Правая коалиция смогла взять власть в стране, сформировав режим правой имитационной демократии, в то время как оппозиция всё еще существует и сеет смуту, а её радикализированное крыло продолжаёт партизанствовать.|";
					}
					else if (this.global1.allcountries[num6].Westalgie <= 0 && num6 == 40)
					{
						this.text_fake = this.text_fake + "<color=purple>" + this.global1.allcountries[num6].name + "</color>: В стране произошла стабилизация. Правая коалиция во главе с Исламским фронтом спасения окончательно утвердила свою власть на всей территории страны, сформировав новый исламистский режим, выступивший за дальнейшую арабизацию республики, искоренение французского влияния и торжество шариата. В экономике же страна либерализировалась, отказалась от плана в пользу поддержки мелких частных собственников. Торжество исламской демократии наступило.|";
					}
					else if (this.global1.allcountries[num6].Westalgie <= 0)
					{
						this.text_fake = this.text_fake + "<color=purple>" + this.global1.allcountries[num6].name + "</color>: В стране произошла стабилизация. Правая коалиция окончательно утвердила свою власть на всей территории страны, сформировав либерально-демократическое правительство и капиталистическую республику. Торжество буржуазной демократии наступило.|";
					}
				}
			}
			else
			{
				this.text_fake += "Демократическому правительству удалось обуздать исламский фундаментализм и предотвратить назревающий кризис. В итоге, в <color=purple>Алжире</color> сложилась двухпартийная система аналогичная западной, где главенствующую роль играют социалисты и демократы. Тем не менее, несмотря на внутриполитическую стабилизацию, Алжир становится всё более и более зависимым от Франции, которая постепенно захватывает внутренний рынок страны своими товарами, с которыми местное производство конкурировать не может.|";
				for (int num7 = 41; num7 < 44; num7++)
				{
					if (this.global1.allcountries[num7].Westalgie >= 1000)
					{
						this.text_fake = this.text_fake + "<color=purple>" + this.global1.allcountries[num7].name + "</color>: В стране произошла стабилизация. Левая коалиция окончательно утвердила свою власть на всей территории страны, сформировав социалистическое правительство и социалистическую республику. Торжество социализма наступило.|";
					}
					else if (this.global1.allcountries[num7].Westalgie >= 600)
					{
						this.text_fake = this.text_fake + "<color=purple>" + this.global1.allcountries[num7].name + "</color>: Произошла частичная стабилизация. Левая коалиция смогла взять власть в стране, сформировав режим Народной демократии, в то время как оппозиция всё еще существует и сеет смуту, а её радикализированное крыло продолжаёт партизанствовать.|";
					}
					else if (this.global1.allcountries[num7].Westalgie > 0)
					{
						this.text_fake = this.text_fake + "<color=purple>" + this.global1.allcountries[num7].name + "</color>: Произошла частичная стабилизация. Правая коалиция смогла взять власть в стране, сформировав режим правой имитационной демократии, в то время как оппозиция всё еще существует и сеет смуту, а её радикализированное крыло продолжаёт партизанствовать.|";
					}
					else if (this.global1.allcountries[num7].Westalgie <= 0)
					{
						this.text_fake = this.text_fake + "<color=purple>" + this.global1.allcountries[num7].name + "</color>: В стране произошла стабилизация. Правая коалиция окончательно утвердила свою власть на всей территории страны, сформировав либерально-демократическое правительство и капиталистическую республику. Торжество буржуазной демократии наступило.|";
					}
				}
			}
		}
		else if (this.this_okno == 12)
		{
			this.Name.text = "СОДРУЖЕСТВО";
			this.text_fake = "";
			if (this.global1.allcountries[7].isSEV && this.global1.allcountries[7].isOVD)
			{
				this.text_fake = "|<color=purple>Советское лидерство</color>";
				this.text_fake += "|Советский Союз продолжает оставаться неформальным лидером более реформированного социалистического лагеря, ведя за собой всех его членов к светлому будущему.";
			}
			else if (!this.global1.allcountries[7].isOVD && this.global1.allcountries[this.global1.data[0]].Vyshi)
			{
				this.text_fake = "|<color=purple>Новые соседи</color>";
				this.text_fake += "|После того, как Советский Союз отказался от доктрины Брежнева и позволил нам делать свой выбор, наше правительство решило интегрироваться к западным соседям. И теперь мы новый член семьи НАТО и Европейского Союза.";
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(34);
				}
			}
			else
			{
				if (!this.global1.allcountries[7].isOVD)
				{
					this.text_fake = "|<color=purple>Военный договор</color>";
					this.text_fake = this.text_fake + "|Всего: " + this.military_ally.ToString();
					if (this.military_ally <= 2)
					{
						this.text_fake += " (маленький)|С падением Варшавского Договора мы стали более беззащитны, И, хотя, мы и пытались сколотить свой собственный военный альянс, но стоит признать, что вышло это из рук вон плохо. Наше влияние в мире осталось примерно столь же малым, что и было до разрыва Варшавского договора.";
					}
					else if (this.military_ally <= 5)
					{
						this.text_fake += " (средний)|С падением Варшавского Договора мы стали более беззащитны, И, хотя, мы и пытались сколотить свой собственный военный альянс, но стоит признать, что вышло намного лучше, чем могло быть. Наше влияние в мире намного расширилось после разрыва Варшавского договора и новый, хоть и малый, но крепкий блок стран готов защищать нас и друг друга.";
					}
					else
					{
						this.text_fake += " (большой)|С падением Варшавского Договора мы стали более беззащитны, но наши попытки сколотить свой собственный военный альянс, стоит признать, превысили ожидания даже самых оптимистичных наших партийцев. Благодаря нашим действиям мы смогли стать одной из новых весомых мировых сил, с которой другие страны начинают считаться.";
					}
				}
				else
				{
					this.text_fake = "|<color=purple>Военный договор</color>";
					this.text_fake += "|Советский Союз продолжает оставаться неформальным лидером более реформированного социалистического лагеря, ведя за собой всех его членов к светлому будущему.";
				}
				if (!this.global1.allcountries[7].isSEV)
				{
					this.text_fake += "|<color=purple>Экономический альянс</color>";
					this.text_fake = this.text_fake + "|Всего: " + this.economy_ally.ToString();
					if (this.economy_ally <= 4)
					{
						this.text_fake += " (маленький)|С роспуском Совета Экономической Взаимопомощи мы растеряли множество торговых партнёров, и, к сожалению, наша торговля так и не смогла восстановиться от столь подлого удара со стороны Советского Союза, а от СЭВ осталась лишь его блеклая тень.";
					}
					else if (this.economy_ally <= 7)
					{
						this.text_fake += " (средний)|С роспуском Совета Экономической Взаимопомощи мы растеряли множество торговых партнёров, однако, мы умудрились оправиться от столь подлого удара со стороны Советского Союза и восстановить наши торговые связи, сформировав крепкую альтернативу СЭВ.";
					}
					else
					{
						this.text_fake += " (большой)|С роспуском Совета Экономической Взаимопомощи мы растеряли множество торговых партнёров, однако, мы умудрились не только оправиться от столь подлого удара со стороны Советского Союза, но и расширить наши торговые связи, приобретая всё новых и новых экономических партнёров, сформировав не менее широкую и крепкую альтернативу СЭВ.";
					}
				}
				else
				{
					this.text_fake += "|<color=purple>Экономический альянс</color>";
					this.text_fake += "|Совет Экономической Взаимопомощи, несмотря на прекращение оказания льгот и помощи Советского Союза, благодаря создаваемым десятилетиями крепким экономическим связям, смог реформироваться и удержать свою нишу в глобальной экономической системе, оставясь всё той же альтернативой западному содружеству.";
				}
			}
			if (this.global1.data[59] == 1 && this.global1.data[0] == 5 && !this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.data[42] != 7)
			{
				this.text_fake += "||Советский Союз распался, после чего Приднестровье увтердило собственный суверенитет и объявило себя настоящей Молдавией. Начался вооружённый конфликт, в который поспешили вмешаться мы - ударив ничего не подозревающим молдаванам в тыл, мы быстро овладели ключевыми городами и скоординировали свои действия с гагаузами, приднестровцами и русскими добровольцами. Под плотным надзором Секуритате референдум в Молдавии подавляющим большинством голосов утвердил вхождение Молдавии в состав Румынии, Приднестровье было признано настоящей Молдавией, Гагаузия получила независимость и они стали нашими друзьями, а бывшие молдаване были объявлены бессарабами-румынами. Вскоре и все наши союзники признали это, несмотря на протесты с Запада, тогда как России было плевать.";
				if (this.global1.iron_and_blood && this.global1.data[60] == 6)
				{
					this.achieves.GetComponent<achievements>().Set(39);
				}
			}
			else if (this.global1.data[59] == 1 && this.global1.data[0] == 5)
			{
				this.text_fake += "||Советский Союз распался, после чего Приднестровье увтердило собственный суверенитет и объявило себя настоящей Молдавией. Начался вооружённый конфликт, в который поспешили вмешаться мы - ударив ничего не подозревающим молдаванам в тыл, мы быстро овладели ключевыми городами и скоординировали свои действия с гагаузами, приднестровцами и русскими добровольцами. Однако вскоре, под давлением международной общественности, мы были вынуждены вывести войска из Молдавии, гарантировав её суверенитет. Ну хотя бы Гагаузия и Приднестровье получили независимость и стали нашими верными друзьями-союзниками.";
			}
			if (this.global1.data[7] >= 1001)
			{
				this.text_fake += "||Благодаря умелой дипломатии и защите завоеваний борцов революции социалистическим странам удалось, несмотря на все опасения, не только не уменьшить, но и увеличить авторитет международного рабочего движения и целостность мировой системы социализма. В 1992 году политолог Фрэнсис Фукуяма выпустил свою книгу \"Мир на перепутье\", в которой заявил о преждевременности своего эссе \"Конец истории?\" и продолжении идеологической борьбы либеральной демократии и обновлённого социализма.";
			}
		}
		else if (this.this_okno == 13)
		{
			this.Name.text = "НАТО";
			this.text_fake = "";
			if (!this.global1.allcountries[7].isOVD && this.global1.allcountries[54].Gosstroy != 0 && this.global1.allcountries[1].Gosstroy != 2 && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy >= 2)) && ((this.global1.allcountries[17].Westalgie >= 300 && this.global1.allcountries[this.global1.data[0]].isOVD && this.global1.allcountries[7].isOVD) || (((this.global1.allcountries[17].Westalgie >= 350 && this.global1.allcountries[16].Gosstroy == 0) || this.global1.allcountries[17].Westalgie >= 400) && this.global1.allcountries[this.global1.data[0]].isSEV && (this.global1.allcountries[17].Westalgie >= 550 || this.global1.allcountries[7].isSEV))) && (this.global1.data[0] != 1 || (this.global1.data[0] == 1 && this.global1.science[9]) || (this.global1.data[0] == 1 && (this.global1.data[14] < 2 || this.global1.data[14] > 4 || (this.global1.data[14] == 2 && this.global1.data[15] < 8 && this.global1.data[17] < 16) || (this.global1.data[14] == 4 && this.global1.data[16] > 12)))) && this.global1.allcountries[21].Gosstroy == 1 && this.global1.allcountries[21].subideology == 10 && ((this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 + this.global1.data[6] / 10 + this.global1.data[8] / 20 >= 1350) || ((this.global1.event_done[371] || this.global1.data[164] > 5) && this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[10] <= 1600 && (!this.global1.event_done[382] || this.global1.data[164] > 5) && this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 < 1000 && this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie >= 300)) && ((this.global1.allcountries[45].Gosstroy <= 1 && this.global1.allcountries[45].isSEV && !this.global1.allcountries[7].isOVD && this.greece_ally > 6) || (this.global1.allcountries[45].Gosstroy <= 1 && this.global1.allcountries[45].isSEV && !this.global1.allcountries[7].isOVD && this.greece_ally <= 5) || this.global1.data[161] == 1 || this.global1.data[161] == 3) && this.global1.data[242] == 2 && this.global1.allcountries[17].Westalgie >= 300 && this.global1.data[7] >= 850 && this.global1.allcountries[29].Gosstroy == 1 && this.global1.allcountries[44].Gosstroy == 1)
			{
				this.text_fake += this.dlce1.credits_text[371];
				this.achieves.GetComponent<achievements>().Set(147);
			}
			else if (this.global1.allcountries[1].Gosstroy != 2 && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy >= 2)) && ((this.global1.allcountries[17].Westalgie >= 300 && this.global1.allcountries[this.global1.data[0]].isOVD && this.global1.allcountries[7].isOVD) || (((this.global1.allcountries[17].Westalgie >= 350 && this.global1.allcountries[16].Gosstroy == 0) || this.global1.allcountries[17].Westalgie >= 400) && this.global1.allcountries[this.global1.data[0]].isSEV && (this.global1.allcountries[17].Westalgie >= 550 || this.global1.allcountries[7].isSEV))) && (this.global1.data[0] != 1 || (this.global1.data[0] == 1 && this.global1.science[9]) || (this.global1.data[0] == 1 && (this.global1.data[14] < 2 || this.global1.data[14] > 4 || (this.global1.data[14] == 2 && this.global1.data[15] < 8 && this.global1.data[17] < 16) || (this.global1.data[14] == 4 && this.global1.data[16] > 12)))) && this.global1.allcountries[21].Gosstroy == 1 && this.global1.allcountries[21].subideology == 10 && ((this.global1.allcountries[45].Gosstroy <= 1 && this.global1.allcountries[45].isSEV && !this.global1.allcountries[7].isOVD && this.greece_ally > 6) || (this.global1.allcountries[45].Gosstroy <= 1 && this.global1.allcountries[45].isSEV && !this.global1.allcountries[7].isOVD && this.greece_ally <= 5) || this.global1.data[161] == 1 || this.global1.data[161] == 3) && this.global1.data[242] == 2 && this.global1.allcountries[17].Westalgie >= 300 && this.global1.data[7] >= 850 && this.global1.allcountries[29].Gosstroy == 1 && !this.global1.allcountries[44].Vyshi)
			{
				this.text_fake += this.dlce1.credits_text[372];
			}
			else if (this.global1.allcountries[1].Gosstroy != 2 && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy >= 2)) && ((this.global1.allcountries[17].Westalgie >= 300 && this.global1.allcountries[this.global1.data[0]].isOVD && this.global1.allcountries[7].isOVD) || (((this.global1.allcountries[17].Westalgie >= 350 && this.global1.allcountries[16].Gosstroy == 0) || this.global1.allcountries[17].Westalgie >= 400) && this.global1.allcountries[this.global1.data[0]].isSEV && (this.global1.allcountries[17].Westalgie >= 550 || this.global1.allcountries[7].isSEV))) && (this.global1.data[0] != 1 || (this.global1.data[0] == 1 && this.global1.science[9]) || (this.global1.data[0] == 1 && (this.global1.data[14] < 2 || this.global1.data[14] > 4 || (this.global1.data[14] == 2 && this.global1.data[15] < 8 && this.global1.data[17] < 16) || (this.global1.data[14] == 4 && this.global1.data[16] > 12)))) && this.global1.allcountries[21].Gosstroy == 1 && this.global1.allcountries[21].subideology == 10 && ((this.global1.allcountries[45].Gosstroy <= 1 && this.global1.allcountries[45].isSEV && !this.global1.allcountries[7].isOVD && this.greece_ally > 6) || (this.global1.allcountries[45].Gosstroy <= 1 && this.global1.allcountries[45].isSEV && !this.global1.allcountries[7].isOVD && this.greece_ally <= 5) || this.global1.data[161] == 1 || this.global1.data[161] == 3) && this.global1.allcountries[29].Gosstroy == 1)
			{
				this.text_fake += this.dlce1.credits_text[373];
			}
			else if ((this.global1.data[0] >= 49 && this.global1.data[0] <= 51 && this.global1.data[161] == 4 && this.global1.data[114] != 100 && ((this.global1.allcountries[15].Gosstroy == 9 && this.global1.allcountries[6].Gosstroy != 2 && this.global1.allcountries[5].Gosstroy != 2 && this.global1.allcountries[4].Gosstroy != 2 && this.global1.allcountries[3].Gosstroy != 2 && this.global1.allcountries[2].Gosstroy != 2 && this.global1.allcountries[7].Gosstroy == 2 && this.global1.data[148] == 1 && this.global1.data[0] == 49) || (this.global1.data[136] == 1 && this.global1.data[0] == 50) || (this.global1.data[118] == 1 && this.global1.data[0] == 51))) || (this.global1.allcountries[15].Gosstroy == 2 && this.global1.allcountries[6].Gosstroy != 0 && this.global1.allcountries[5].Gosstroy != 0 && this.global1.allcountries[4].Gosstroy != 0 && this.global1.allcountries[3].Gosstroy != 0 && this.global1.allcountries[2].Gosstroy != 0 && this.global1.allcountries[6].isSEV && this.global1.allcountries[5].isSEV && this.global1.allcountries[4].isSEV && this.global1.allcountries[3].isSEV && this.global1.allcountries[2].isSEV && this.global1.allcountries[7].Gosstroy == 2 && !this.global1.allcountries[7].isSEV))
			{
				this.text_fake += this.dlce1.credits_text[374];
			}
			else if (this.global1.allcountries[7].paths == 3 && this.global1.event_done[1079])
			{
				this.text_fake += this.dlce1.credits_text[375];
			}
			else if (this.global1.allcountries[7].paths == 2)
			{
				this.text_fake += this.dlce1.credits_text[376];
				if (this.global1.allcountries[2].Vyshi && this.global1.allcountries[5].Vyshi)
				{
					this.text_fake += " Особое внимание уделялось укреплению новых членов договора – прибалтийским странам, Польше, Румынии и Финляндии, испугавшихся реваншизма со стороны новых властей в Москве. На территорию Рутении и Молдавии с одобрения местных правительств были введены миротворческие контингенты стран альянса. На молдавско-приднестровской границе даже прошли перестрелки, но местный миротворческий корпус РДР смог не допустить перерастания кризиса в более активную фазу.";
				}
				else if (this.global1.allcountries[2].Vyshi)
				{
					this.text_fake += " Особое внимание уделялось укреплению новых членов договора – прибалтийским странам, Польше и Финляндии, испугавшихся реваншизма со стороны новых властей в Москве. На территорию Рутении с одобрения местного правительства были введены миротворческие контингенты стран альянса.";
				}
				else
				{
					this.text_fake += " Программа была направлена на укрепление новых членов альянса – Литвы, Латвии, Эстонии и Финляндии, испугавшихся реваншизма со стороны новых властей в Москве. Особое внимание уделялось также повышению обороноспособности Рутении, принимать которую полноценно в состав НАТО США и их европейские союзники не решились.";
				}
				this.text_fake += " Озабоченность продолжает вызывать ядерное наследие СССР: ядерный шантаж властей РДР не позволил странам Североатлантического альянса оказать более существенную помощь тем республикам, что перешли под контроль национал-большевизма. К концу 1990-х становится очевидным, что Европа после нескольких лет затишья вновь вступает на тропу блокового противостояния, ведущую к грядущему кризису международной напряжённости.";
			}
			else if (this.global1.data[45] == 8)
			{
				if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[52] * 50 >= 1200)
				{
					this.text_fake += this.dlce1.credits_text[377];
					if (this.liberalEaEu > 1)
					{
						this.text_fake += this.namelibEaEu;
						this.text_fake = this.text_fake.Remove(this.text_fake.Length - 2);
						this.text_fake += " - вступили в НАТО после прошедшей в 2005 году новой волны расширения.";
					}
					else if (this.liberalEaEu == 1)
					{
						this.text_fake += this.namelibEaEu;
						this.text_fake = this.text_fake.Remove(this.text_fake.Length - 2);
						this.text_fake += " - вступила в НАТО после прошедшей в 2005 году новой волны расширения.";
					}
					else
					{
						this.text_fake += this.namelibEaEu;
						this.text_fake = this.text_fake.Remove(this.text_fake.Length - 2);
						this.text_fake += "Благодаря успехам советской дипломатии, Москве удалось заключить ряд договоров с бывшими членами ОВД, которые отказывались от стремления вступления в Североатлантический альянс при сохранении общего нейтрального статуса.";
					}
					this.text_fake += " Это привело к охлаждению отношений между Москвой и Брюсселем, особенно в связи с усилением конфликта на Кавказе между Грузией и союзными республиками. Тем не менее, де-факто обе стороны приняли новые правила и пока что не планируют их нарушать.";
				}
				else if ((double)this.global1.allcountries[17].Westalgie + (double)this.global1.data[7] * 0.9 + (double)(this.global1.data[52] * 50) >= 800.0)
				{
					this.text_fake += this.dlce1.credits_text[378];
					for (int num8 = 2; num8 < 5; num8++)
					{
						if (this.global1.allcountries[num8].Gosstroy == 1 || this.global1.allcountries[num8].Gosstroy == 2)
						{
							this.auth++;
							this.text_fake = this.text_fake + this.global1.allcountries[this.global1.data[0]].name + ", ";
							this.text_fake = this.text_fake.Remove(this.text_fake.Length - 1);
							this.text_fake += "и, ";
						}
					}
					this.text_fake = this.text_fake.Remove(this.text_fake.Length - 2);
					if (this.auth == 1)
					{
						this.text_fake += "Тем не менее, усилия Громова по раскачиванию нестабильности в Европе не прошли даром, и в этом заслоне из восточноевропейских стран есть брешь в лице ";
					}
					else if (this.auth > 1)
					{
						this.text_fake += "Тем не менее, усилия Громова по раскачиванию нестабильности в Европе не прошли даром, и в этом заслоне из восточноевропейских стран есть бреши в лице ";
					}
					for (int num9 = 2; num9 < 5; num9++)
					{
						if (this.global1.allcountries[num9].Gosstroy == 0 || this.global1.allcountries[num9].Gosstroy == 9)
						{
							this.text_fake = this.text_fake + this.global1.allcountries[this.global1.data[0]].name + ", ";
							this.text_fake = this.text_fake.Remove(this.text_fake.Length - 1);
							this.text_fake += "и, ";
						}
					}
					if (this.auth >= 1)
					{
						this.text_fake = this.text_fake.Remove(this.text_fake.Length - 2);
					}
					if (this.auth == 1)
					{
						this.text_fake += " , занимающую позицию благожелательного нейтралитета к Москве. ";
					}
					else if (this.auth > 1)
					{
						this.text_fake += " , занимающих позицию благожелательного нейтралитета к Москве. ";
					}
					this.text_fake += "К концу 2010-х годов НАТО вернулся к рассмотрению Союза в качестве своего ключевого противника, чему активно способствуют разные прогнозы аналитиков о грядущем начале вторжения Москвы в Прибалтику. Для пресечения этого вдоль всей границы с ССГ стягиваются ударные группы быстрого реагирования, а военные аналитики пророчат в ближайшие годы первый полноценный военный конфликт с прямым участием Союза и НАТО...";
				}
				else
				{
					this.text_fake += this.dlce1.credits_text[379];
				}
			}
			else if (this.global1.data[45] == 10)
			{
				this.text_fake += this.dlce1.credits_text[380];
			}
			else if (this.global1.allcountries[7].Gosstroy == 0 && this.global1.event_done[62])
			{
				this.text_fake += this.dlce1.credits_text[381];
			}
			else if (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy != 2)
			{
				this.text_fake += this.dlce1.credits_text[382];
				if (this.global1.allcountries[1].Vyshi)
				{
					this.text_fake += " Так, на территории Германии прошли полномасштабные учения «Стойкий воин», направленные на реализацию целого комплекса операций – от борьбы с повстанцами до морских высадок (на которые были приглашены в том числе советские наблюдатели).";
				}
				else
				{
					this.text_fake += " Так, на территории Турции и в Эгейском море прошли полномасштабные учения «Судьбоносная слава», направленные на повышение обороноспособности сил альянса в южном регионе.";
				}
				this.text_fake += " В 1993 году была утверждена «Доктрина ограниченного сдерживания», предполагавшая укрепление южного и юго-восточного флангов альянса, пусть и без прямого развёртывания новых войск у границ новой советской сферы. Тем не менее, спустя пару лет в воздухе начал витать образ новой разрядки, однако неясно, сможет ли он реализоваться во что-то более конкретное.";
			}
			else if (this.global1.allcountries[7].Gosstroy == 2 && !this.global1.allcountries[7].Vyshi)
			{
				this.text_fake += this.dlce1.credits_text[383];
			}
			else if (this.global1.allcountries[7].isOVD)
			{
				this.text_fake += this.dlce1.credits_text[384];
				if ((((this.global1.data[37] < 6 || !this.global1.allcountries[31].Help) && this.global1.data[37] < 7) || (this.global1.data[0] == 12 || this.global1.allcountries[7].Vyshi || (!this.global1.allcountries[7].isSEV && !this.global1.allcountries[16].isSEV && this.global1.allcountries[19].Gosstroy > 1)) || this.global1.allcountries[12].Gosstroy != 9) && (((this.global1.data[37] < 8 || !this.global1.allcountries[31].Help) && this.global1.data[37] < 9) || this.global1.data[0] == 12 || this.global1.allcountries[7].Vyshi || (!this.global1.allcountries[7].isSEV && !this.global1.allcountries[16].isSEV && this.global1.allcountries[19].Gosstroy > 1)))
				{
					this.text_fake += "С потерей старой угрозы альянс стал искать новую цель, противодействие которой могло сплотить участников договора, и в конечном итоге, после совершённых терактов 11 сентября 2001 года, в качестве такого врага стал выступать международный терроризм, нашедший своё убежище в захваченной талибами части Афганистана, а также ряде других исламских государств. ОВД также решительно осудила действия террористов и поддержал новую стратегию НАТО по борьбе с проявлением исламского радикализма и бандитизма. Оба старых врага объединяют свои силы в общей борьбе, но получится ли у них победить, учитывая, что гражданская война в Афганистане скоро разменяет второй десяток, а конца и края ей не видно?";
				}
				else if (this.global1.allcountries[14].subideology == 3)
				{
					this.text_fake += " С потерей старой угрозы альянс стал искать новую цель, противодействие которой могло сплотить участников договора, и в конечном итоге, после совершённых терактов 11 сентября 2001 года, в качестве такого врага стал выступать международный терроризм, нашедший своё убежище, по данным американской разведки, на территории Ирака. ОВД также решительно осудила действия террористов, тем не менее отнеслась с осторожностью к антииракским заявлениям.";
					if (this.global1.data[51] + this.global1.data[52] * 3 > 10)
					{
						this.text_fake += " Несмотря на ожидания или опасения, Борис Пуго не решился жертвовать нормализовавшимися отношениями со странами НАТО и оказывать помощь всё более деспотичному и исламизирующему режиму Саддама Хуссейна. Против Багдада готовится новая вооружённая операция, и кажется, в этот раз он окажется в полном одиночестве.";
					}
					else
					{
						this.text_fake += " В то же время Владимир Жириновский выступил с резкой критикой угроз Ираку. «Джордж, твоих солдат здесь порвут на части. 250 тысяч отборных солдат Ирака! Они все разнесут. Они всю пустыню пройдут за один час!». Также он пригрозил, что если США захотят вторгнуться в Ирак, то СССР не останется в стороне. В конечном итоге Вашингтону пришлось отменить готовившуюся операцию, а на территорию Ирака была введена новая миссия ООН, которая должна была уничтожить все хранившиеся у Хуссейна запасы оружия массового поражения. Неофициально же, под нажимом Москвы, Багдад начал борьбу против исламского терроризма внутри своей страны, на который до этого де-факто закрывал глаза.";
					}
				}
				else
				{
					this.text_fake += " С потерей старой угрозы альянс стал искать новую цель, противодействие которой могло сплотить участников договора, и в конечном итоге, после совершённых терактов 11 сентября 2001 года, в качестве такого врага стал выступать международный терроризм, нашедший своё убежище, по данным американской разведки, на территории Ирана. ОВД также решительно осудила действия террористов, тем не менее отнеслась с осторожностью к антииранским заявлениям. Планирующаяся операция против Тегерана не находит поддержки как внутри альянса, так и снаружи. Вполне вероятно, что США будут совершать её в одиночку…";
				}
			}
			else if (!this.global1.allcountries[7].isOVD && this.global1.allcountries[this.global1.data[0]].isOVD)
			{
				this.text_fake += "После того как Советский Союз покинул Организацию Варшавского договора, Североатлантический совет выпустил официальное заявление, в котором приветствовал «освобождение Восточной Европы от советского военного присутствия» и «суверенное право государств на выбор собственных путей безопасности». Тем не менее альянс опасался неопределённости, связанной с государствами, оставшимися в военном договоре, который перестал контролироваться Москвой.";
				this.auth = 1000;
				for (int num10 = 0; num10 < this.global1.allcountries.Length; num10++)
				{
					if (this.global1.allcountries[num10].Gosstroy == 0)
					{
						this.auth++;
					}
					else if (this.global1.allcountries[num10].Gosstroy == 1)
					{
						this.auth += 10;
					}
					else if (this.global1.allcountries[num10].Gosstroy == 2 || this.global1.allcountries[num10].subideology == 2)
					{
						this.auth += 100;
					}
					else if (this.global1.allcountries[num10].Gosstroy == 9)
					{
						this.auth += 1000;
					}
				}
				if (this.global1.data[10] > 400)
				{
					this.text_fake += " Политика, проводимая отдельными странами нового альянса и направленная на противодействие демократизации и подрыв влияния западного мира, вкупе с выявленными нарушениями прав человека, заставила считать новый военный блок в центре Европы даже более опасным и заслуживающим противодействия, чем существовавший ранее ОВД. Так, на границе с восточноевропейскими странами началось строительство новой военной инфраструктуры, а в 1995 году в Баварии прошли масштабные учения «Твёрдая решимость», в которых участвовали представители большей части стран, входящих в альянс. Во всём происходящем есть и определённый плюс для альянса – настроения, начавшие распространяться на рубеже этого десятилетия о целесообразности дальнейшего существования НАТО, быстро поутихли, и Североатлантический договор нашёл для себя новую опасную угрозу для противодействия. ";
				}
				else if (this.auth % 10 >= this.auth % 100 / 10 && this.auth % 10 >= this.auth / 1000 - 1 && this.auth % 10 >= this.auth % 1000 / 100)
				{
					this.text_fake += " Из-за консервативности большей части участников восточноевропейского альянса и стабильности неосоциалистических режимов, в НАТО существуют опасения, что Североатлантический договор в будущем будет испытывать более серьёзную угрозу от этой социалистической организации. Беспокойство также вызывают сохранившиеся прямые контакты и связи преемника ОВД с Москвой, которая, по мнению аналитиков, управляет им как теневой кардинал. Из-за этого большая часть программ, заключённых с советским правительством об общих ограничениях в Европе, тихим образом саботируется либо оттягивается по срокам своей реализации. ";
				}
				else if (this.auth % 100 / 10 >= this.auth % 10 && this.auth % 100 / 10 >= this.auth / 1000 - 1 && this.auth % 100 / 10 >= this.auth % 1000 / 100)
				{
					this.text_fake += " Прагматичность и реформизм большей части участников восточноевропейского альянса заставили Брюссель считать его более слабой угрозой, чем существовавшую ранее ОВД. НАТО не теряет надежды в будущем поменять складывающийся статус-кво и, если не включить восточноевропейские страны в альянс напрямую, то заключить взаимовыгодные договоры о сотрудничестве. ";
				}
				else if (this.auth % 1000 / 100 >= this.auth % 100 / 10 && this.auth % 1000 / 100 >= this.auth / 1000 - 1 && this.auth % 1000 / 100 >= this.auth % 10)
				{
					this.text_fake += " Создавшийся новый экономический альянс на месте ОВД изначально рассматривал НАТО не в как свою угрозу, а как верного друга и союзника в возможном желании Москвы вернуться в Восточную Европу. С этой целью с 1991 года началось активное взаимодействие и переход восточноевропейских стран под стандарты Североатлантического договора. В 1997 году прошла новая волна расширения НАТО на восток, которая вызвала решительную критику со стороны Москвы. И хотя альянс оправдывается тем, что больше не рассматривает её в качестве угрозы, отношения между двумя силами заметно охладились.";
				}
				else
				{
					this.text_fake += " Существующая закрытость и изоляция большей части участников восточноевропейского альянса породила массовую волну слухов и угроз разной степени адекватности, что серьёзным образом насторожило Североатлантический договор. Не помогает в принятии новой структуры и работа различных диссидентских организаций, рисующих новые страны в качестве тоталитарных и человеконенавистнических. И хотя Североатлантический совет на высшем уровне с осторожностью воспринимает угрозу, не делая сколько-нибудь серьёзных заявлений, разоружаться в ближайшей перспективе никто не планирует.";
				}
			}
			else
			{
				this.text_fake += " Прошедшая политическая трансформация в странах Восточной Европы не могла не затронуть политику НАТО в складывающихся новых международных отношениях и политике безопасности в Европе. Уже в 1990 году на Лондонской встрече на высшем уровне союзники заявили о новом подходе к безопасности, отойдя от ядерного сдерживания и сделав ставку на политическое сотрудничество и кризисное регулирование. Центральным событием, изменившим политику альянса, стал демонтаж его главного антагониста – Организации Варшавского Договора, страны которой в той или иной степени вступили на тернистый путь проведения демократизации. ";
				if ((this.global1.data[0] < 49 || this.global1.data[0] > 51) && (this.global1.data[59] == 2 || !this.global1.allcountries[this.global1.data[0]].isOVD || (!this.global1.allcountries[5].isOVD && !this.global1.allcountries[6].isOVD) || (this.global1.data[54] < 7 && (!this.global1.allcountries[15].isOVD || this.global1.data[54] < 5)) || this.global1.allcountries[15].Help))
				{
					this.text_fake += "Начавшаяся практически сразу же после этого череда конфликтов на территории бывшей СФРЮ заставила альянс обратить свой взор на Балканы. Впервые в своей истории НАТО вышло за рамки чисто оборонительной доктрины, введя в 1993 году эмбарго на поставки оружия и начав операции по обеспечению «безопасных зон» в Боснии и Герцеговине, а также применяя силу против сербских ополченцев.";
				}
				else if (this.global1.data[10] > 320 && this.global1.data[0] != 10 && this.global1.data[0] != 12 && this.global1.data[0] != 18)
				{
					this.text_fake = this.text_fake + "Значительную угрозу для альянса стала представлять - " + this.global1.allcountries[this.global1.data[0]].name + ", решившая фактически бросить вызов западному миропорядку и складывающейся новой системе безопасности в Европе, что определило противодействие ей в качестве одной из основных целей альянса в 90-ых годах. ";
				}
				else
				{
					this.text_fake += "Появившаяся нестабильность на постсоветском пространстве и начавшиеся проблемы с демократизацией в ряде стран Восточной Европы заставили альянс пусть и провести ограниченную демобилизацию своих сил, но продолжать рассматривать Россию в качестве своего пусть и гипотетического, но конкурента или даже мнимой угрозы. ";
				}
				this.text_fake += "Параллельно шёл процесс расширения: в 1994 году была запущена инициатива «Партнёрство ради мира», призванная интегрировать восточноевропейские страны в евроатлантическую систему безопасности без немедленного вступления в альянс, поскольку внутри НАТО ещё не существовало консенсуса по вопросу расширения. ";
				if (this.liberalEaEu > 1)
				{
					this.text_fake += "Однако к концу десятилетия, несмотря на возражения Москвы, в 1999 году в состав НАТО официально вошли - ";
					this.text_fake += this.namelibEaEu;
					this.text_fake = this.text_fake.Remove(this.text_fake.Length - 2);
					this.text_fake += ".";
				}
				else if (this.liberalEaEu == 1)
				{
					this.text_fake += "Однако к концу десятилетия, несмотря на возражения Москвы, в 1999 году в состав НАТО официально вошла - ";
					this.text_fake += this.namelibEaEu;
					this.text_fake = this.text_fake.Remove(this.text_fake.Length - 2);
					this.text_fake += ".";
				}
			}
		}
		else if (this.this_okno == 14 && this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
		{
			this.Name.text = "ОСОБЫЕ ИТОГИ";
			this.text_fake = "";
			if (this.global1.data[135] <= 4)
			{
				this.global1.data[161] = 0;
			}
			else if (this.global1.data[131] != 1 && this.yug1.gameState.modifies[5] <= 0 && this.yug1.gameState.modifies[4] <= 0)
			{
				if (this.global1.data[126] == 0 && this.global1.data[115] <= 4)
				{
					this.global1.data[161] = 0;
				}
				else if (this.global1.data[126] == 0 && (this.global1.data[126] != 0 || this.global1.data[115] < 16))
				{
					this.global1.data[161] = 0;
				}
			}
			if (this.global1.data[161] == 4 && this.global1.data[114] != 100)
			{
				if (this.global1.allcountries[7].isOVD && this.global1.event_done[62])
				{
					this.text_fake = this.dlce1.credits_text[220];
					this.text_fake += this.dlce1.credits_text[229];
				}
				else if ((this.global1.allcountries[15].Gosstroy == 0 && this.global1.allcountries[6].Gosstroy != 2 && this.global1.allcountries[5].Gosstroy != 2 && this.global1.allcountries[4].Gosstroy != 2 && this.global1.allcountries[3].Gosstroy != 2 && this.global1.allcountries[2].Gosstroy != 2 && this.global1.allcountries[7].Gosstroy == 2 && this.global1.data[148] != 1 && this.global1.data[0] == 49) || (this.global1.data[136] != 1 && this.global1.data[0] == 50) || (this.global1.data[118] != 1 && this.global1.data[0] == 51))
				{
					this.text_fake = this.dlce1.credits_text[221];
					this.text_fake += this.dlce1.credits_text[230];
				}
				else if ((this.global1.allcountries[15].Gosstroy == 9 && this.global1.allcountries[6].Gosstroy != 2 && this.global1.allcountries[5].Gosstroy != 2 && this.global1.allcountries[4].Gosstroy != 2 && this.global1.allcountries[3].Gosstroy != 2 && this.global1.allcountries[2].Gosstroy != 2 && this.global1.allcountries[7].Gosstroy == 2 && this.global1.data[148] == 1 && this.global1.data[0] == 49) || (this.global1.data[136] == 1 && this.global1.data[0] == 50) || (this.global1.data[118] == 1 && this.global1.data[0] == 51))
				{
					this.text_fake = this.dlce1.credits_text[222];
					this.text_fake += this.dlce1.credits_text[231];
				}
				else if (this.global1.allcountries[15].Gosstroy == 2 && this.global1.allcountries[6].Gosstroy != 0 && this.global1.allcountries[5].Gosstroy != 0 && this.global1.allcountries[4].Gosstroy != 0 && this.global1.allcountries[3].Gosstroy != 0 && this.global1.allcountries[2].Gosstroy != 0 && this.global1.allcountries[6].isSEV && this.global1.allcountries[5].isSEV && this.global1.allcountries[4].isSEV && this.global1.allcountries[3].isSEV && this.global1.allcountries[2].isSEV && this.global1.allcountries[7].Gosstroy == 2 && !this.global1.allcountries[7].isSEV)
				{
					this.text_fake = this.dlce1.credits_text[223];
					this.text_fake += this.dlce1.credits_text[232];
				}
				else if (this.global1.allcountries[15].Gosstroy == 2 && this.global1.allcountries[7].Gosstroy == 2)
				{
					this.text_fake = this.dlce1.credits_text[224];
					this.text_fake += this.dlce1.credits_text[233];
				}
				else if (this.global1.allcountries[6].isSEV && this.global1.allcountries[5].isSEV && this.global1.allcountries[4].isSEV && this.global1.allcountries[3].isSEV && this.global1.allcountries[2].isSEV && !this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD)
				{
					this.text_fake = this.dlce1.credits_text[225];
					this.text_fake += this.dlce1.credits_text[234];
				}
				else if (this.global1.allcountries[15].isSEV && !this.global1.allcountries[7].isSEV)
				{
					this.text_fake = this.dlce1.credits_text[226];
					this.text_fake += this.dlce1.credits_text[235];
				}
			}
			else if (this.yug1.gameState.yugcountries[0].is_independent && this.yug1.gameState.yugcountries[1].is_independent && this.global1.data[126] == 1 && this.global1.data[161] == 1 && this.global1.allcountries[45].Gosstroy < 2)
			{
				this.text_fake = this.dlce1.credits_text[227];
				this.text_fake += this.dlce1.credits_text[236];
			}
			else if (this.global1.data[161] == 1)
			{
				this.text_fake = this.dlce1.credits_text[117];
				if (this.yug1.gameState.yugcountries[0].is_independent && this.yug1.gameState.yugcountries[1].is_independent && this.yug1.gameState.yugregions[0].owner == 0 && this.yug1.gameState.yugregions[1].owner == 1)
				{
					this.text_fake += this.dlce1.credits_text[356];
				}
				else
				{
					this.text_fake += this.dlce1.credits_text[118];
					if (this.global1.allcountries[27].Torg && !this.global1.event_done[441])
					{
						this.text_fake += "Особый интерес к организации также проявила Австрия, собирающаяся стать полноценным её членом к 2000 году.";
					}
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(80);
					}
				}
			}
			else
			{
				this.text_fake = "Ничего особенного";
			}
		}
		else if (this.this_okno == 14)
		{
			this.Name.text = "ОСОБЫЕ ИТОГИ";
			this.text_fake = "";
			if (this.global1.data[0] == 20 && this.global1.data[56] >= 100)
			{
				if (this.global1.data[11] == 0)
				{
					this.text_fake += "||<color=purple>Центр исламского социализма";
					this.text_fake += "|</color>Неджмие Ходжа стала первой женщиной лидером религиозного государства в истории, наглядно показав тем самым всю прогрессивность исламского социализма, в котором соединяется лучшее из учений основоположников мусульманской религии и достижений самого человечного и справедливого из всех возможных строев, которые повидал мир, - социализма. Религия и идеология объединились, прекратив свою вражду и тем самым доказав, что стремление к миру и процветанию является частью природы человека. Имамы и рьяные проповедники не дают разрастаться коррупции, а народ находит свое утешение в религии или идеологии партии, сблизившейся со своим народом. ";
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(52);
					}
				}
				else if (this.global1.data[11] == 2)
				{
					this.text_fake += "||<color=purple>Исламская Республика Албания";
					this.text_fake += "|</color>Перестройка в Албании пошла по пути Ирана. Внутриполитические последствия революции проявились в установлении в стране теократического режима мусульманского духовенства, повышении роли ислама абсолютно во всех сферах жизни. Страну возглавил Президент, установились буржуазная демократия и расширились гражданские свободы, однако религиозные деятели получили особые права. Например, они коллективно могут наложить вето на любой закон светской власти или же представить свой законопроект, который светская власть обязана принять. Опора на религию позволила АПТ переродиться и пережить суровый кризис, открывшись всему миру. Были налажены теплые отношения с Турцией, Арабскими странами и Ираном. Пусть жизнь по законам Шариата и ограничивает права граждан и народов, но это куда лучше, чем полная самоизоляция, да и новые друзья Албании рады приветствовать ее в рядах стран, несущих слово ислама в этот мир.";
				}
				if (this.global1.iron_and_blood && this.global1.data[62] > 4)
				{
				}
			}
			else if (this.global1.data[0] == 18)
			{
				if (this.global1.iron_and_blood && this.global1.data[14] <= 3 && this.global1.data[11] == 2 && this.global1.allcountries[44].Torg && this.global1.allcountries[44].Gosstroy <= 1)
				{
					this.achieves.GetComponent<achievements>().Set(62);
				}
				if (this.global1.allcountries[7].Gosstroy == 0 && this.global1.data[10] >= 800 && this.global1.data[14] <= 1 && this.global1.regions[1].buildings[0].type == 23)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(61);
					}
					this.text_fake += "||<color=purple>Второй Карибский Кризис";
					this.text_fake += "|</color>Виктору Алкснису удалось уничтожить сепаратизм в советских республиках и предотвратить распад социалистического лагеря. Однако после окончания гонки вооружений и холодной войны, отношения между двумя странами вновь обострились. Жёсткая политика Алксниса по отношению к странам Восточного блока, привела к ответным мерам со стороны США, которые, в свою очередь, начали программу усиленного переоснащения ракетных установок в странах Запада, что в особенности коснулось ФРГ и Турцию. Президент США Джордж Буш потребовал от Советского Союза немедленного вывода войск с территории стран Варшавского Договора, а также пригрозил военной интервенцией для «восстановления демократии». Симметричный ответ СССР не заставил себя долго ждать: по секретным маршрутам, под видом конвоев с продовольственной помощью, на Кубу поступили советские новейшие ракеты. Через некоторое время, американские самолёты-разведчики, несмотря на строгую секретность всего мероприятия, обнаружили близ советской военной базы военных, которые занимались установкой этих самых ракет. Новый Карибский кризис вновь повис над миром, но на этот раз ситуация была гораздо серьёзней. Однако в итоге Джорджу Бушу пришлось пойти на уступки, прекратив милитаризацию и учения в странах НАТО, а СССР снова вывел свои ракеты с Кубы. Дата начала Третьей Мировой войны вновь перенеслась, но надолго ли?!";
				}
				else if (!this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD && this.global1.data[77] > 0)
				{
					this.text_fake += "||<color=purple>Остров социализма";
					this.text_fake += "|</color>После распада Советского союза Куба стала круглой социалистической  сиротой в Латинской Америке. В 1992 Соединённые штаты Америки, ставшие гегемоном мировой политики, начали проводить свою «демократическую» политику и серьёзно ужесточили санкции  против нас. Потерю братских стран-союзников Куба перенесла большими потерями, однако в окружении врагом смогла выстоять и в новом XXI продолжить развитие, при поддержке победившего на выборах в Венесуэле военного Уго Чавеса и боливийского социалиста Эво Моралес, доставив своим союзом немало хлопот США.";
				}
				else if ((this.global1.allcountries[7].isSEV || this.global1.allcountries[7].isOVD) && (this.global1.data[77] > 0 || this.global1.is_gkchp))
				{
					this.text_fake += "||<color=purple>Передний рубеж";
					this.text_fake += "|</color>Социалистический лагерь продолжил существовать и сотрудничать с Кубой, благодаря чему экономический кризис прошёл в более лёгкой форме, а попытки ужесточить американские санкции против Кубы были осуждены Восточным блоком и Организацией Объединенных наций. Кубинская революция продолжается. Вива Куба!";
				}
				else if (!this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD && this.global1.data[77] == 0)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(60);
					}
					this.text_fake += "||<color=purple>Реставрация";
					this.text_fake += "|</color>На фоне ухудшения положения в социалистическом лагере нам пришлось вернуться к идее сотрудничества с теми, с кем мы и собирались до дружбы с Хрущёвым, - Соединёнными Штатами Америки. Благодаря потеплению отношений между нашими странами, торговое эмбарго было снято, что спасло нашу стагнирующую экономику от полного краха. Теперь всё вернулось на свои места – Куба вновь вотчина США, которую толпами посещают американские туристы. Под давлением Президента Буша нам пришлось допустить американских инвесторов в нашу страну. Теперь на Кубе вновь появляется монополия США на производство сахара и табака, а также массовое распространение снова получили бордели и игорный бизнес, с которыми полиция острова ведёт «вязкую борьбу». Некоторые журналисты, которых пришлось арестовать из-за ложных обвинений в адрес правительства, называют лидера страны Очоа «Новым Батистой» и «предателем дел Кубинской революции», но как же они неправы!  ";
				}
				else if (this.global1.data[45] != 5 && this.global1.data[77] == 0)
				{
					this.text_fake += "||<color=purple>Реновация";
					this.text_fake += "|</color>Социалистический лагерь продолжил своё существование, однако под давлением Горбачёва нам всё же пришлось пойти на переговоры с Соединёнными штатами Америки, в результате которых эмбарго было снято. Теперь для нашей экономики наступила новая эпоха, энергетический кризис постепенно закончился, а развитие туристической отрасли, под бдительным контролем государства, смогло увеличить приток туристов со всего мира, что для нас только плюс.";
				}
				if (this.global1.data[171] == 100)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(105);
					}
					this.text_fake += "|<color=purple>Карибская Германия</color>";
					this.text_fake += "|В дальнейшем, существование «второй» ГДР признали только дружественные нам правительства Уго Чавеса в Венесуэле и Эво Моралеса в Боливии, а также другие непризнанные государства: Эритрея, Западная Сахара, Сомалиленд, Амбазония, Мексиканские Сапатистские Автономные Муниципалитеты, государства Шан, Качин и Ва, и некоторые микрогосударства. Страны Запада же активно препятствуют нашим и северокорейским попыткам добиться восстановления членства ГДР в ООН. После смерти Эриха Хонеккера, Председателем Народной палаты стал Эрих Мильке, а после его смерти власть в микрогермании перешла в руки Зигмунда Йена. В 1998 году ураган Митч нанёс крупный урон острову (в том числе был разбит бюст Эрнста Тельмана), но Йен не только смог преимущественно своими силами восстановить разрушения, но и превратил остров в туристический центр, где каждый мог по демократичным ценам приобрести восточногерманскую атрибутику (монеты, книги, игрушки, значки и т.д.), что к 2008 году превратило его в самоокупаемый туристический рай. Вместе с этим, восточные немцы остаются верны идеям Маркса и не прекращают политическую активность — именно на острове Эрнста Тельмана располагается штаб-квартира МВКРП, а также прошла её последняя конференция. В начале 2022 года микроГДР смогла-таки добиться статуса наблюдателя в ООН, но по-прежнему остаётся государством с частичным международно-правовым признанием.";
				}
			}
			else if (this.global1.data[0] == 12)
			{
				if (this.global1.data[106] == 1 && this.global1.data[81] == 0 && !this.global1.allcountries[7].Vyshi)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(66);
					}
					this.text_fake += "||<color=purple>Политика национального примирения";
					this.text_fake += "|</color>Правительству ДРА удалось провести успешные переговоры с «умеренной» частью оппозиции, и после окончания поставок пакистанского оружия добить остатки радикальной исламистской оппозиции были разбиты, и правительство успешно закрепилось на всей территории Афганистана. В 1993 году были проведены первые всеобщие президентские выборы, на которых успешно победил действующий лидер страны. Ситуация в стране окончательно стабилизировалась - была принята конституция, закрепившая главенствующее положение Ислама и допустила применение шариата, также, в новое единое правительство вошли представители духовенства и моджахедов. На афганской земле наступил долгожданный мир.";
				}
				else if (this.global1.data[106] == 1 && this.global1.data[81] == 0 && this.global1.allcountries[7].Vyshi)
				{
					this.text_fake += "||<color=purple>Новая гражданская война";
					this.text_fake = this.text_fake + "|</color>Развал социалистического лагеря и прекращение помощи со стороны СССР серьёзно ударили по нашей слабой экономике: в городах началась нехватка продовольствия и топлива, электроэнергия не подаётся месяцами. И, несмотря на успешные переговоры с оппозицией, окончившиеся созданием коалиционного правительства, в стране, на фоне экономического кризиса, разгорается кризис политический. На парламентских выборах 1993 года победила радикальная исламская оппозиция, в то время как президентом страны продолжает оставаться " + this.global1.politics_name[this.global1.data[11]] + ". Попытки лидера страны предотвратить новые очаги сепаратизма не увенчались успехом, и в регионах вновь формируются оппозиционные организации, терроризирующие местных жителей и грабящие города. Будущее страны туманно, но, похоже, новой братоубийственной войны не избежать.";
				}
				else if ((this.global1.data[80] == 100 && this.global1.data[106] == 0) || (this.global1.data[80] >= 80 && this.global1.data[81] == 0 && !this.global1.allcountries[7].Vyshi && this.global1.data[106] == 0))
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(63);
					}
					this.text_fake += "||<color=purple>Победа революции";
					this.text_fake += "|</color>Благодаря постоянно оказываемой помощи социалистического лагеря, а также упорной борьбе афганских народов за свободу и светлое будущее Афганистана, оппозиция была полностью разгромлена и в панике сбежала на территорию Пакистана. На афганской земле наконец-то наступил мир, и власть социалистов в стране окончательно стабилизировалась. Гражданская война окончена.";
				}
				else if (this.global1.data[80] >= 40 && this.global1.data[80] <= 80 && !this.global1.allcountries[7].Vyshi && this.global1.data[106] == 0)
				{
					this.text_fake += "||<color=purple>Гражданская война продолжается";
					this.text_fake += "|</color>СССР продолжил существовать, оказывая гуманитарную и военную поддержку Афганистану, что позволило облегчить его положение. Некоторые страны, опасаясь расширения исламских террористов, начали оказывать давление на Пакистан, усложняя ему помощь террористам. А с Китаем удалось договориться и выработать единую позицию по прекращению поддержки террористов. И, хотя, разногласия в партии и армии ДРА не были улажены до конца, а политика президента имела свои изъяны, наступления террористов удалось пресечь, а ДРА контролирует достаточно территорий, чтобы существовать дальше. Решающего перевеса не оказалось ни у одной из сторон, так что гражданская война в Афганистане продолжается.";
				}
				else if (this.global1.data[80] >= 20 && !this.global1.allcountries[7].Vyshi)
				{
					this.text_fake += "||<color=purple>Последний рубеж обороны";
					this.text_fake += "|</color>С выходом советских войск из Афганистана положение режима начало резко ухудшаться. Некоторые успешные наступления правительства были резко пресечены террористами, начавшие масштабное контрнаступление. В итоге оппозиция продвинулась настолько вглубь страны, что вплотную подошла к Кабулу, но в результате мужественных подвигов армии ДРА была отбита назад. Повторные наступательные операции были либо грандиозными победами, либо ужасающими поражениями. И, несмотря на то, что ДРА контролирует столь малую территорию, благодаря поддержке СССР она продолжает существовать, а гражданская война со временем только усиливается.";
				}
				else
				{
					this.text_fake += "||<color=purple>Странная война";
					this.text_fake += "|</color>Несмотря на прекращение помощи из СССР, Демократическая Республика Афганистан владеет достаточным количеством территорий, чтобы продолжать существовать и частично отбиваться от нападений оппозиции. Силы террористов и правительства всегда примерно равны, что не позволяет одной из сторон одержать верх в конфликте, поэтому гражданская война продолжается и неизвестно когда ей настанет конец. ";
				}
			}
			else if (this.global1.data[0] == 10)
			{
				if (this.global1.data[68] >= 4 && this.global1.data[11] == 3)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(56);
					}
					this.text_fake += "||<color=purple>Единая Корея";
					this.text_fake += "|</color>Товарищ Ким Ён Чхун проводил блестящую политику, добившись того, что не смог сделать его предшественник. Осуществляя курс на «декимирсенализацию» и внедрение масштабных экономических преобразований, он смог своими силами перетащить КНДР из ранга самых закрытых и централизованных государств в одну из самых влиятельных сил мировой политики. Отдельного внимания заслуживает его политика относительно Южной Кореи, которую совсем недавно государственная пропаганда клеймила «американской марионеткой», теперь после длительного процесса переговоров развернулся масштабная разрядка на Корейском полуострове: Север прекратил все разработки ядерного вооружения, а с Юга были выведены американские базы. И теперь, благодаря его гениальному правлению, больше не существует «позорной границы», разъединяющей корейский народ, а Корея стала единым конфедеративным государством под названием - «Демократическая Конфедеративная Республика Корё». А в 2000 году, в знак признания заслуг в дело мира, президент Республики Корея Ким Дэ Чжун и Председатель КНДР Ким Ён Чхун совместно получили Нобелевскую премию мира. Корея отныне едина и неделима.";
				}
				else if ((this.global1.data[68] >= 4 && this.global1.data[11] != 3) || (this.global1.data[68] >= 0 && this.global1.data[68] < 4))
				{
					this.text_fake += "||<color=purple>Перемирие";
					this.text_fake = this.text_fake + "|</color>Товарищ " + this.global1.politics_name[this.global1.data[11]] + " был спорным лидером в истории нашей страны. Неудачный старт в экономике совмещался с великими прорывами в деле воссоединения корейского народа. На Корейском полуострове была проведена разрядка напряжённости, воссоздана программа разлучённых за время Корейской войны семей. Также были созданы несколько совместных команд по некоторым видам спорта, выступающих под флагом единой Кореи. С некоторой периодичностью происходят межкорейские саммиты, демонстрирующие стремление корейского народа к единству, однако будущее объединенной Кореи всё ещё туманно.";
				}
				else if ((this.global1.data[68] <= -3 && this.global1.data[11] != 1) || (this.global1.data[68] > -3 && this.global1.data[68] <= -1))
				{
					this.text_fake += "||<color=purple>Холодное противостояние";
					this.text_fake += "|</color>Несмотря на наши попытки наладить переговоры с нашим южным соседом, получилось это из рук вон плохо. Любые наши совместные начинания пресекались чрезмерной милитаризации Севера и чересчур реакционным антикоммунизмом Юга. Конечно, о каких-либо военных столкновениях речи не идёт, но на Корейском полуострове всё ещё \"веет холодом\", невзирая на окончание противостояния СССР и США. Всё продолжает оставаться, как было и даже трудно предположить, когда корейский народ вновь станет един, как прежде.";
				}
				else if (this.global1.data[68] <= -3 && this.global1.data[11] == 1 && this.global1.science[9] && this.global1.allcountries[16].Gosstroy == 0)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(58);
					}
					this.text_fake += "||<color=purple>Хорошо забытое старое";
					this.text_fake += "|</color>Из-за чрезмерной милитаризации и агрессивной внешней политики Северной Кореи, Соединенные штаты, при поддержке своих союзников, смогли протолкнуть в Совет безопасности ООН резолюцию о необходимости военного вмешательства в КНДР, чтобы пресечь враждебную политику севера и не допустить масштабного конфликта с Югом. Однако наш старый союзник Китай вновь благородно пришёл на помощь и наложил вето на инициативу американских империалистов и их марионеток. Теперь после окончания старой холодной войны обороты стремительно набирает новая, в которой главенствующими силами будут США и КНР. Берегитесь, капиталисты, ваш конец близок!";
				}
				else
				{
					this.text_fake += "||<color=purple>БАГ: ТУТ ДОЛЖЕН БЫТЬ ИТОГ.</color>";
				}
			}
			else if (this.global1.data[0] == 3)
			{
				if (this.global1.data[50] < -5)
				{
					this.text_fake += "||<color=purple>Бархатный развод|</color>";
					this.text_fake = string.Concat(new string[]
					{
						this.text_fake,
						"По мере дестабилизации обстановки в Чехословакии, встал вопрос и о национальном самоопределении составляющих её республик. В целом, несмотря на явственную смену политико-экономического курса страны, большинство населения, и чехов, и словаков, было не готово к национальному самоопределению, что подтвердили результаты опроса, проведенного в то время. Тем не менее, судьба страны оказалась в руках политиков, которые распорядились иначе. Отдельные жители приграничных областей с обеих сторон новой границы негативно относились к разделу страны. 17 июля ",
						(this.global1.data[21] + 1 + (8 + this.global1.data[50])).ToString(),
						" года словацкий парламент принял декларацию о независимости. Чехословацкий Президент, который выступавший против разделения, ушёл в отставку. 25 ноября Федеральное собрание приняло закон о разделении страны с 1 января ",
						(this.global1.data[21] + 2 + (8 + this.global1.data[50])).ToString(),
						" года. Бархатный развод случился."
					});
				}
				else if (this.global1.data[50] < -2)
				{
					this.text_fake += "||<color=purple>Государственный Союз Чехии и Словакии|</color>";
					this.text_fake += "Мы дали достаточно свобод словакам. Несмотря на возросший национализм по всему соцлагерю, мы смогли сохранить хрупкий баланс в нашей стране. Отныне Чехословакия превращается в конфедерацию. Братислава и Прага разделили обязанности по управлению государством, примирив националистов обеих стран. И пусть злые языки по-прежнему называют нас «Чудовищем Версаля», мы сделаем все, ради процветания чешского и словацкого народов, волею судьбы объединенных в одном государстве.";
				}
				else if (this.global1.data[50] > 5 && this.global1.data[11] != 3)
				{
					this.text_fake += "||<color=purple>Один народ, одна нация!|</color>";
					this.text_fake += "Разработанный единый язык, который нам пришлось местами насадить силой, постепенно становится народным языком среди людей нашей страны. Националисты всех сортов и мастей были отлучены от власти, а их сторонники оказались за решеткой или за границей, где они не смогут причинить нам вреда. Введенная со временем политика «Культурного обмена» позволила людям нашей страны не только почувствовать, но и стать единым народом. И отныне чехословацкий народ неделим! Вперед, в светлое будущее";
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(54);
					}
				}
				else
				{
					this.text_fake += "||<color=purple>Всё идёт как и шло.</color>";
				}
				if (this.global1.data[60] == 10)
				{
					this.text_fake += "||<color=purple>Тешин един и неделим!</color>";
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(55);
					}
				}
			}
			else if (this.global1.data[0] == 4)
			{
				if (this.global1.data[11] == 0 && !this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD && this.global1.allcountries[4].isOVD && this.global1.allcountries[4].isSEV && this.global1.data[14] == 0 && this.global1.is_gkchp && this.global1.allcountries[7].Vyshi && this.global1.allcountries[7].Gosstroy == 2 && this.global1.eventVariantChosen[153] >= 2 && this.global1.eventVariantChosen[157] == 3)
				{
					this.text_fake = this.dlce1.credits_text[28];
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(129);
					}
				}
				else if (this.global1.data[62] >= 4 && this.global1.allcountries[15].isOVD && (this.global1.allcountries[6].isOVD || this.global1.allcountries[6].Gosstroy == 0 || this.global1.allcountries[6].Gosstroy == 9) && !this.global1.allcountries[5].Vyshi)
				{
					this.text_fake += "||<color=purple>Конфедеративная Северная Корея Европы";
					this.text_fake += "|</color>Воспользовавшись нестабильностью в соцлагере мы не растерялись взяли контроль в свои руки. Потеряв Трансильванию, Румыния погрузилась в анархию и доблестные венгерские войска при поддержке болгар, взявших под свой контроль утраченные в войнах этого века свои бывшие земли, установили марионеточное правительство в Румынии. Следующим шагом вспыхнуло восстания венгров в Закарпатье, которые наряду с пропольскими восстаниями в остальной Западной Украине дестабилизировали положение украинского правительства, оно ушло в отставку, а мы же вошли своими сапогами в Государство Рутения, которое провозгласило независимость и заявило о незаконной оккупации своих земель украинскими властями с 1945 года. Помощь Милошевичу позволила отвлечь НАТО и затянуть конфликт в Югославии. Воспользовавшись захваченными и уже имеющимися мощностями и технологиями, коалиция из четырех стран, включающая Болгарию, Румынию, Венгрию и Югославию, ощетинилась ядерным вооружением, и стала эдаким конфедеративным КНДР от Европы. Под давлением мировой общественности все страны, торговавшие с Венгрией, кроме самых верных трех союзников, наложили санкции, однако уход в самоизоляцию с захваченными территориями и несколькими верными союзниками позволил Венгерскому государству сохранить стабильность экономики, а обилие ядерного оружия остановило Кучму от угроз ядерной дубиной (которую, он, однако, отказался передавать своему сотоварищу Ельцину). ";
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(51);
					}
				}
				else if (this.global1.data[62] >= 2 && this.global1.allcountries[7].Vyshi)
				{
					this.text_fake += "Из обычной и непримечательной европейской страны Венгрия стала силой, с которой нельзя не считаться в регионе, а наш правитель стал символом величия и могущества венгерского народа. К сожалению, головокружение от успехов продлилось недолго. Проект по разжиганию недовольства в Трансильвании увенчался успехом после наскоро проведенного референдума под контролем наших частей без опознавательных знаков. Автономный регион Трансильвания пополнил список наших земель. Однако НАТО не стала стоять в стороне и тут же нарекла нас агрессором, подведя войска к нашим границам. Вслед за НАТО Кучма и Ельцин, осмелев, объединили усилия и начали угрожать нам своими ядерными дубинами. ";
					if (this.global1.data[16] > 11 || this.global1.allcountries[4].Vyshi)
					{
						this.text_fake += " Нам пришлось отступиться от наших завоеваний и лишь благодаря тому, что мы открылись иностранному капиталу и стали для западных партнеров новым рынком сбыта, нам позволили остаться суверенными. Трансильвания была объявлена демилитаризованной зоной, а среди венгров зреют ультраправые взгляды и социал-националистические движения создаются и крепнут на наших землях, жаждая реванша.";
					}
					else
					{
						this.text_fake += " Нам пришлось отступиться от наших завоеваний и лишь благодаря тому, что мы крепко держались за власть и отбили первые попытки наступления интернациональных сил, а затем нашли для международного сообщества козлов отпущения, нам позволили остаться суверенными. 30-километровые границы с Закарпатьем и Трансильванией от нашей территории были объявлены демилитаризованной зоной, а среди венгров зреют ультраправые взгляды и социал-националистические движения создаются и крепнут на наших землях, жаждая реванша.";
					}
				}
				else if (this.global1.data[62] >= 2 && this.global1.regions[2].buildings[0].type == 19)
				{
					this.text_fake += "Из обычной и непримечательной европейской страны Венгрия стала силой, с которой нельзя не считаться в регионе, а наш правитель стал символом величия и могущества венгерского народа. К сожалению, головокружение от успехов продлилось недолго. Проект по разжиганию недовольства в Трансильвании увенчался успехом после наскоро проведенного референдума под контролем наших частей без опознавательных знаков. Автономный регион Трансильвания пополнил список наших земель. Однако НАТО не стала стоять в стороне и тут же нарекла нас агрессором, подведя войска к нашим границам. Вслед за НАТО и Советский Союз, осмелев, начал угрожать нам своей ядерной дубиной. ";
					if (this.global1.data[16] > 11 || this.global1.allcountries[4].Vyshi)
					{
						this.text_fake += " Нам пришлось отступиться от наших завоеваний и лишь благодаря тому, что мы открылись иностранному капиталу и стали для западных партнеров новым рынком сбыта, нам позволили остаться суверенными. Трансильвания была объявлена демилитаризованной зоной, а среди венгров зреют ультраправые взгляды и социал-националистические движения создаются и крепнут на наших землях, жаждая реванша.";
					}
					else
					{
						this.text_fake += " Нам пришлось отступиться от наших завоеваний и лишь благодаря тому, что мы крепко держались за власть и отбили первые попытки наступления интернациональных сил, а затем нашли для международного сообщества козлов отпущения, нам позволили остаться суверенными. 30-километровые границы с Закарпатьем и Трансильванией от нашей территории были объявлены демилитаризованной зоной, а среди венгров зреют ультраправые взгляды и социал-националистические движения создаются и крепнут на наших землях, жаждая реванша.";
					}
				}
				else
				{
					this.text_fake = "Ничего особенного";
				}
			}
			else if (!this.global1.science[9] && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy >= 2)) && this.global1.data[0] == 1 && (this.global1.data[14] == 3 || (this.global1.data[14] == 2 && this.global1.data[15] >= 8 && this.global1.data[17] >= 16) || (this.global1.data[14] == 4 && this.global1.data[16] <= 12)) && ((this.global1.allcountries[17].Westalgie >= 300 && this.global1.allcountries[this.global1.data[0]].isOVD && this.global1.allcountries[7].isOVD) || (((this.global1.allcountries[17].Westalgie >= 350 && this.global1.allcountries[16].Gosstroy == 0) || this.global1.allcountries[17].Westalgie >= 400) && this.global1.allcountries[this.global1.data[0]].isSEV && (this.global1.allcountries[17].Westalgie >= 550 || (this.global1.allcountries[7].isSEV && !this.global1.is_gkchp)))))
			{
				this.text_fake += "||<color=purple>Обновлённая Единая Германия</color>";
				this.text_fake += "|<color=purple>В ФРГ</color>, в ходе реформации социалистического мира, падения пелены красной угрозы и расцвета идеи всемирной дружбы на очередных выборах одержала победу коалиция левых сил, выступавшая за пацифизм, социальные реформы, дружбу и мир. Следствием её победы стало не простое налаживание отношений с ГДР и признание Западного Берлина демилитаризованной зоной: Федеративная Республика объявила о выходе из военных структур НАТО, оставшись лишь в политических, и, вместе с ГДР, вывела со своих территорий иностранные военные базы, подписав договоры о не нахождении на территории обеих Германий чьих-либо войск или ракет, и о безъядерном статусе ФРГ. Это было поддержано и СССР и Францией, однако дальнейшее оказалось полной неожиданностью - в ФРГ прошёл референдум о воссоединении ФРГ и ГДР в единую ГДР с сохранением внеблокового статуса и признанием нейтралитета, после чего бывшие левые функционеры ФРГ вошли в правительство ГДР, а Канцлер ФРГ стал Председателем Совета Министров новой Германии.";
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(32);
				}
				if (this.global1.allcountries[27].Donat)
				{
					if (this.global1.allcountries[27].Westalgie >= 2 && this.global1.allcountries[27].Help && this.global1.allcountries[27].Stasi)
					{
						this.text_fake += this.dlce1.credits_text[360];
					}
					else if (this.global1.allcountries[27].Westalgie >= 2 && this.global1.allcountries[27].Money && this.global1.allcountries[27].Stasi)
					{
						this.text_fake += this.dlce1.credits_text[361];
					}
					else if (this.global1.allcountries[27].Stasi)
					{
						this.text_fake += this.dlce1.credits_text[362];
					}
					else if (this.global1.allcountries[27].Westalgie >= 1)
					{
						this.text_fake += this.dlce1.credits_text[363];
					}
					else
					{
						this.text_fake += this.dlce1.credits_text[364];
					}
				}
			}
			else if (this.sinochek && this.global1.data[0] == 5)
			{
				if (this.otstavnoysinochek && this.global1.data[50] == 3)
				{
					this.text_fake += "|После смерти Чаушеску его сын Нику был задвинут бюрократией на задворки сначала Партии, а потом и истории, и был утверждён на пост профессора физики в Универститете Бухареста. Впрочем, Нику всегда подходил к учёбе с ленью, а образованность высмеивал, так что неудивительно, что профессором он пробыл недолго и был переведён обычным учителем в свой родной лицей, а потом и вовсе скончался от цирроза печени из-за алкоголизма на фоне неудач последних годов.";
				}
				else if (this.global1.data[50] == 3)
				{
					this.text_fake += "|После смерти Чаушеску его сын Нику был единогласно избран новым руководителем Партии и государства. Впрочем, несмотря на это, опытом он не обладал, а обучаться у других ему было зазорно. Однако, все его попытки реформ кончались неудачей за неудачей, вследствие чего он стал больше пить и проводить время на развлекательных мероприятиях, а власть постепенно перешла в руки партаппарата, который теперь управляет страной за ширмой в лице Нику. Впрочем, в интересах того же самого партаппарата и дальше потворствовать утверждению монархической линии преемственности правления. Пусть и всё более номинального с каждым годом...";
					if (this.global1.iron_and_blood && this.global1.data[14] <= 0 && this.global1.data[34] == 11)
					{
						this.achieves.GetComponent<achievements>().Set(36);
					}
				}
				else if (this.otstavnoysinochek && this.global1.data[50] == 4)
				{
					this.text_fake += "|После смерти Чаушеску его сын Валентин был задвинут бюрократией на задворки сначала Партии, а потом и истории, и был утверждён на пост директора Института атомной физики в Бухаресте, где и продолжает работать до сих пор, не вмешиваясь в политику вовсе. Он успел развестись и жениться во второй раз, но его судьба мало кого волнует, а он счастлив работать на любимом поприще и в достатке, пока страной правят партократы.";
				}
				else if (this.global1.data[50] == 4)
				{
					this.text_fake += "|После смерти Чаушеску его сын Валентин был единогласно избран новым руководителем Партии и государства. Несмотря на то, что ранее он мало интересовался политикой, но придя к власти он с усердством стал разгребать все проблемы государства, из-за чего вступил в немало конфликтов с партаппаратчиками. Однако, в целом, он продолжал линию своего отца Николае, опираясь на давних лоялистов, но уделяя особое внимание борьбе с коррупцией и развитию науки.";
					if (this.global1.iron_and_blood && this.global1.data[14] <= 0 && this.global1.data[26] <= 0)
					{
						this.achieves.GetComponent<achievements>().Set(37);
					}
				}
			}
			else if (this.global1.data[42] == 10 && this.global1.data[0] == 5)
			{
				if (this.global1.data[11] != 0 && this.global1.data[50] == 1)
				{
					this.text_fake = this.text_fake + "|Наш мудрый лидер " + this.global1.politics_name[this.global1.data[11]] + ", когда его власть окончательно утвердилась в стране, сделал воистину мудрое решение, которое порадовало сердца всех патриотов: он не просто вернул Короля-героя Михая в страну, нет, он реставрировал монархию! Монарх, в лице того же самого Михая, стал олицетворением единства нашей нации, символом нашего государства и гарантом вечной стабильности и сохранения наших многовековых традиций! Впрочем, несмотря на это, властью он наделён лишь церемониальной...";
					if (this.global1.iron_and_blood && this.global1.data[11] == 3)
					{
						this.achieves.GetComponent<achievements>().Set(38);
					}
				}
			}
			else if (this.global1.data[59] == 2 && this.global1.data[0] == 6 && !this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.data[42] != 7)
			{
				this.text_fake += "||Пока в Югославии вовсю шла гражданская война, мы успешно ввели войска в Македонию, где организовали свой собственный референдум и создали Автономный Край Вардария по названию бывшей времён Королевства Вардарской бановины, а существование самих македонцев опровергли. Отделённые западными империалистами болгарцы, ранее жившие в Македонии, на том самом референдуме в 76% голосов признали себя болгарцами и возжелали гражданства болгарского. Президент Хорватии Туджман, а затем и Президент Сербии Милошевич признали наш суверенитет над Македонией, вслед за ними подтянулись и наши союзники. И, хотя, большая часть мира не признаёт наши новые территории, но мы там утвердились. Надеюсь, что теперь раз и навсегда.";
				if (this.global1.iron_and_blood && this.global1.data[11] == 1 && this.global1.data[42] == 9 && !this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD)
				{
					this.achieves.GetComponent<achievements>().Set(41);
				}
			}
			else if (this.global1.data[59] == 2 && this.global1.data[0] == 6)
			{
				this.text_fake += "||Пока в Югославии вовсю шла гражданская война, мы успешно ввели войска в Македонию, где организовали свой собственный референдум и создали Автономный Край Вардария по названию бывшей времён Королевства Вардарской бановины, а существование самих македонцев опровергли. Впрочем, подобный прецедент, не признанный Западом, был основной причиной отказа сотрудничества Евросоюза и НАТО с нами, вследствие чего под давлением мирового сообщества мы вынуждены были провести повторный референдум, где 3/4 населения Македонии высказались за собственную независимость, коию и получили. А мы получили свой билет в цивилизованную Европу.";
			}
			else if (this.global1.data[59] == 4 && this.global1.data[0] == 6)
			{
				this.text_fake += "||Оказав Милошевичу существенную помощь вооружением, продовольствием и финансами, мы вместе с Албанией смогли мирно урегулировать албанский вопрос: часть албанцев уехала в Албанию, а часть поселилась в Республике Косовский Край, которая стала частью федеративной Югославии. Затем, вместе с албанцами, наши спецслужбы и войска специального назначения негласно приняли участие в войне на стороне Милошевича, к помощи подключились и наши союзники. И ещё до того, как американские ультиматумы достигли трибуны ООН, война в Югославии была закончена - быстро и решительно. Сепаратистов предали суду, а их лидеров казнили в прямом эфире. А затем раз и навсегда три страны, Югославия, Албания и Болгария, соединились в единую федерацию.";
				if (this.global1.data[14] > 2)
				{
					this.text_fake = this.text_fake + "|Во главе страны встал федеральный парламент и федеральное правительство под лидерством Всесоюзной Социалистической Партии Балкан, хотя республиканские социалистические партии сохранились. Президентом и Генеральным секретарём ВСПБ новой федерации стал " + this.global1.politics_name[this.global1.data[11]] + ", Премьер-Министром (с сохранением полномочий Вице-Президента) стал Милошевич, а Спикером парламента и 2 секретарём ВСПБ стал Рамиз Алия. Несмотря на принципы сохранения идеалов социализма, новое Балканское Союзное Государство допустило плюрализм мнений и частный бизнес в стране, хотя Всесоюзная Социалистическая Партия Балкан остаётся ведущей силой в управлении страной, а государство - ведущей силой в самой экономике.";
				}
				else if (this.global1.data[16] > 11)
				{
					this.text_fake = this.text_fake + "|Во главе страны встал федеральный Верховный Совет и федеральное правительство под лидерством Всесоюзной Коммунистической Партии Балкан, хотя республиканские коммунистические партии сохранились. Председателем Государственного Совета и Генеральным секретарём ВКПБ новой федерации стал " + this.global1.politics_name[this.global1.data[11]] + ", Председателем Совета Министров стал Милошевич, а Председателем Верховного Совета и 2 секретарём ВКПБ стал Рамиз Алия. Несмотря на принципы сохранения идеалов социализма, новое Балканское Союзное Государство допустило действие частного бизнеса в стране и лидерство принципов хозрасчёта, хотя государство всё еще остаётся ведущей силой в самой экономике.";
				}
				else
				{
					this.text_fake = this.text_fake + "|Во главе страны встал федеральный Верховный Совет и федеральное правительство под лидерством Всесоюзной Коммунистической Партии Балкан, хотя республиканские коммунистические партии сохранились. Председателем Государственного Совета и Генеральным секретарём ВКПБ новой федерации стал " + this.global1.politics_name[this.global1.data[11]] + ", Председателем Совета Министров стал Милошевич, а Председателем Президиума Верховного Совета и 2 секретарём ВКПБ стал Рамиз Алия. Несмотря на старые попытки реформ Милошевича и Алии в ещё суверенных Югославии и Албании, которые шли несколько лет назад, в новом Балканском Социалистическом Союзном Государстве сохраняются и абсолютно оберегаются все принципы марксизма-ленинизма в руководстве страной и управлении экономикой.";
					if (this.global1.iron_and_blood && this.global1.data[11] == 0 && this.global1.data[50] == 9)
					{
						this.achieves.GetComponent<achievements>().Set(40);
					}
				}
			}
			else if (this.global1.data[0] == 6 && this.global1.data[130] == 100)
			{
				if (this.global1.data[16] <= 11)
				{
					this.text_fake += "|Генеральному Секретарю удалось совместить противоречащие друг другу идеи в единое целое - монархо-социализм! Царь, как и прежде, является символом нации и гарантом стабильности и процветания страны, а благосостояние населения обеспечивается народным социалистическом государством. С другой же стороны бывшие союзники осуждают нас за извращение марксистских учений, а Запад обвиняет нас в шовинизме.";
				}
				else
				{
					this.text_fake += "|Мы вернули Болгарии её историческое лицо. Царь вновь является гарантом стабильности и процветания в стране, а о коммунизме не может идти и речи. Симеон II гордо объявил о создании Четвёртого Болгарского Царства, в котором строго оберегаются принципы Конституционной монархии и Народной Демократии. И всё это несмотря на то, что бывшие союзники теперь не хотят иметь с нами никакого дела. Да и нужны ли они нам?";
				}
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(68);
				}
			}
			else if (this.global1.data[0] == 2 && (this.global1.data[50] == 20 || this.global1.data[60] <= -10))
			{
				if (this.global1.data[50] == 20)
				{
					this.text_fake = string.Concat(new string[]
					{
						"В ",
						(this.global1.data[21] + 1).ToString(),
						" году мы с гордостью открыли свой космодром и запустили первый отечественный спутник! Через 5 лет, в ",
						(this.global1.data[21] + 6).ToString(),
						", мы успешно запустили животных в космос и их возвращение прошло без проблем. В ",
						(this.global1.data[21] + 8).ToString(),
						" наши шаттлы, основанные на советских моделях (в т.ч. на выкупленном у СССР \"Буране\"), впервые вышли на международный рынок и за несколько лет мы стали лидером их поставок. Сейчас мы уже является полноправными членами проекта МКС и владеем собственным сегментом станции. Теперь каждый поляк с гордостью может сказать, что Польша может в космос!|"
					});
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(46);
					}
				}
				if (this.global1.data[60] <= -10)
				{
					if (!this.global1.allcountries[7].Vyshi)
					{
						this.text_fake += "После провала ГКЧП мы решились организовать Проект Прометей, переработав ещё старую давнишнюю версию межвоенного периода, которая была нацелена на расчленение СССР насильственным путём. Сначала обновленный Прометей казался успешным для нас проектом, но затем, после поражения Ельцина, он затянулся: наши сети и организации долгое время на равных боролись с Межреспубликанской Службой Безопасности СССР и местными конкурентными нам националистами. Но всё закончилось с приходом нового Президента Советского Союза: он уделил особое внимание подконтрольным нам организациям и сетям, раз и навсегда оборвав наш Проект. И пора признать - Прометей провалился.";
					}
					else if (this.global1.allcountries[7].Vyshi && (this.global1.allcountries[this.global1.data[0]].Vyshi || (!this.global1.science[9] && this.global1.data[50] != 20) || this.military_ally <= 2 || this.economy_ally <= 4))
					{
						this.text_fake += "После провала ГКЧП мы решились организовать Проект Прометей, переработав ещё старую давнишнюю версию межвоенного периода, которая была нацелена на расчленение СССР насильственным путём. Особое внимание мы уделили Украине, Беларуси и Литве. В Беларуси всё начиналось и проходило успешно: исторические общества и националистические организации взывали к многовековой исторической связи с Польшей и вскоре был подписан договор о создании Союзного государства Польши и Беларуси - единого экономического пространства с военными обязательствами. Правда углубление не зашло дальше, после того, как украинские националисты, поддерживаемые нами, начали восхвалять ОУН-УПА (ответственных за геноцид поляков в сотрудничестве с гитлеровцами во время Второй Мировой Войны), а затем, после наших возмущений, выступили против нас вместе с олигархами, припомнив полякам все малые и большие обиды. С нашей подачи в Украине образовался националистический олигархический режим, что очень прискорбно. И всё это положило конец нашим поползновениям в Литву.";
					}
					else if (this.global1.allcountries[7].Vyshi && (this.global1.science[9] || this.global1.data[50] == 20) && this.military_ally > 2 && this.economy_ally > 4)
					{
						if (this.global1.data[14] <= 3 && this.global1.data[16] <= 12)
						{
							this.text_fake += "После провала ГКЧП мы решились организовать Проект Прометей, переработав ещё старую давнишнюю версию межвоенного периода, которая была нацелена на расчленение СССР насильственным путём. Особое внимание мы уделили левонационалистическим организациям Украины, Беларуси и Литвы. В Беларуси всё начиналось и проходило успешно: исторические общества и националистические организации взывали к многовековой исторической связи с Польшей. Всё успешно проходило и в Украине, где люди, уставшие от олигархов и ежегодного обеднения, особенно множество безработных и молодёжь, с радостью откликнулись на прививаемые нами идеи и социальные партийные программы для своих членов. Основной опорой нашей операции стали национал-синдикалисты, национал-коммунисты и примкнувшие к ним Социал-националисты, образовавшие коалицию и, в ходе массовых митингов и захвата зданий администрации, в конце концов пришедшие к власти. Дальнейшими шагами стала возможность создания конфедерации трёх наших государств в виде Социалистического Союза Восточной Европы. И победа лево-националистической коалиции Фронтас на выборах в Литве (конечно, при нашей поддержке). Фронтас, хоть и отрицает советскую оккупацию и утверждает, что в литовцев стреляли литовские снайперы в 1991 (призывая судить Горбачёва), но готовит подачу заявки на вступление Литвы в состав нашего ССВЕ, четвёртым членом.";
							if (this.global1.iron_and_blood)
							{
								this.achieves.GetComponent<achievements>().Set(45);
							}
						}
						else
						{
							this.text_fake += "После провала ГКЧП мы решились организовать Проект Прометей, переработав ещё старую давнишнюю версию межвоенного периода, которая была нацелена на расчленение СССР насильственным путём. Особое внимание мы уделили правонационалистическим организациям Украины, Беларуси и Литвы. В Беларуси всё начиналось и проходило успешно: исторические общества и националистические организации взывали к многовековой исторической связи с Польшей. Всё успешно проходило и в Украине, где люди, уставшие от олигархов и ежегодного обеднения, особенно множество безработных и молодёжь, с радостью откликнулись на прививаемые нами идеи и социальные партийные программы для своих членов. Основной опорой нашей операции стали национал-консерваторы, неофашисты и примкнувшие к ним социал-националисты, образовавшие коалицию и, в ходе массовых митингов и захвата зданий администрации, в конце концов пришедшие к власти. Дальнейшими шагами стала возможность создания из трёх наших государств Конфедерации Восточной Европы. И победа право-националистической коалиции Молодая Литва на выборах в Литве (конечно, при нашей поддержке). Молодая Литва, хоть и имеет склонность к пересмотру грехов гитлеровских времён и восхвалению бывших легионеров литовских батальонов СС, но готовит подачу заявки на вступление Литвы в состав нашей КВЕ, четвёртым членом.";
							if (this.global1.iron_and_blood)
							{
								this.achieves.GetComponent<achievements>().Set(45);
							}
						}
					}
					else
					{
						this.text_fake += "После провала ГКЧП мы решились организовать Проект Прометей, переработав ещё старую давнишнюю версию межвоенного периода, которая была нацелена на расчленение СССР насильственным путём. Особое внимание мы уделили Украине, Беларуси и Литве. В Беларуси всё начиналось успешно: исторические общества и националистические организации взывали к многовековой исторической связи с Польшей, но им начало, при поддержке России, противостоять действующее правительство и это противостояние вылилось в победе пророссийского кандидата Александра Лукашенко. Беларусь ушла в российскую сферу влияния, что сказалось плохо и на Украине, где украинские националисты, поддерживаемые нами, начали восхвалять ОУН-УПА (ответственных за геноцид поляков в сотрудничестве с гитлеровцами во время Второй Мировой Войны), а затем, после наших возмущений, выступили против нас вместе с олигархами, припомнив полякам все малые и большие обиды. С нашей подачи в Украине образовался националистический олигархический режим, что очень прискорбно. И всё это положило конец нашим поползновениям в Литву.";
					}
				}
			}
			else
			{
				this.text_fake = "Ничего особенного";
			}
			if (this.global1.data[0] == 6 && this.global1.data[50] == 9 && (this.global1.data[42] == 2 || this.global1.data[42] == 4 || this.global1.data[42] == 6 || this.global1.data[42] == 9 || (this.global1.data[42] == 8 && this.global1.data[43] == 2)))
			{
				this.text_fake = this.text_fake + "|После того как великий " + this.global1.politics_name[this.global1.data[11]] + " скончался, его тело было положено в Мавзолей, где он упокоился вместе с Димитровым и теперь стал частью школьной программы по посещению памятных мест болгарской истории.";
			}
		}
		else if (this.this_okno == 15 && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51)
		{
			if (!this.global1.event_done[371] && this.global1.data[164] <= 5)
			{
				this.Name.text = this.dlce1.credits_text[158];
				this.text_fake = this.dlce1.credits_text[177];
			}
			else if (this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 + this.global1.data[6] / 10 + this.global1.data[8] / 20 >= 1350)
			{
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(108);
				}
				this.Name.text = this.dlce1.credits_text[160];
				this.text_fake = this.dlce1.credits_text[165];
			}
			else if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[10] > 1600)
			{
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(110);
				}
				this.Name.text = this.dlce1.credits_text[162];
				this.text_fake = this.dlce1.credits_text[167];
			}
			else if (this.global1.event_done[382] && this.global1.data[164] <= 5)
			{
				this.Name.text = this.dlce1.credits_text[158];
				this.text_fake = this.dlce1.credits_text[163];
			}
			else if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 >= 1000)
			{
				this.Name.text = this.dlce1.credits_text[186];
				this.text_fake = this.dlce1.credits_text[187];
			}
			else if (this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie >= 300)
			{
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(109);
				}
				this.Name.text = this.dlce1.credits_text[161];
				this.text_fake = this.dlce1.credits_text[166];
			}
			else
			{
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(107);
				}
				this.Name.text = this.dlce1.credits_text[159];
				this.text_fake = this.dlce1.credits_text[164];
			}
		}
		else if (this.this_okno == 16 && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51)
		{
			if (this.global1.data[214] == 1 && this.global1.data[7] / 10 + this.global1.data[8] / 10 + this.global1.data[6] / 20 >= 130 && this.global1.data[10] <= 400)
			{
				if (this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 + this.global1.data[6] / 10 + this.global1.data[8] / 20 >= 1350)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(135);
					}
					this.Name.text = this.dlce1.credits_text[304];
					this.text_fake = this.dlce1.credits_text[305];
				}
				else if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[10] > 1600)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(135);
					}
					this.Name.text = this.dlce1.credits_text[280];
					this.text_fake = this.dlce1.credits_text[281];
				}
				else if (this.global1.event_done[382] && this.global1.data[164] <= 5)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(135);
					}
					this.Name.text = this.dlce1.credits_text[274];
					this.text_fake = this.dlce1.credits_text[275];
				}
				else if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 >= 1000)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(135);
					}
					this.Name.text = this.dlce1.credits_text[298];
					this.text_fake = this.dlce1.credits_text[299];
				}
				else if (this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie >= 300)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(135);
					}
					this.Name.text = this.dlce1.credits_text[292];
					this.text_fake = this.dlce1.credits_text[293];
				}
				else
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(135);
					}
					this.Name.text = this.dlce1.credits_text[286];
					this.text_fake = this.dlce1.credits_text[287];
				}
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(135);
				}
			}
			else if (this.global1.data[214] == 1 && this.global1.data[10] <= 400)
			{
				if (this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 + this.global1.data[6] / 10 + this.global1.data[8] / 20 >= 1350)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(135);
					}
					this.Name.text = this.dlce1.credits_text[304];
					this.text_fake = this.dlce1.credits_text[305];
				}
				else if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[10] > 1600)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(135);
					}
					this.Name.text = this.dlce1.credits_text[282];
					this.text_fake = this.dlce1.credits_text[283];
				}
				else if (this.global1.event_done[382] && this.global1.data[164] <= 5)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(135);
					}
					this.Name.text = this.dlce1.credits_text[276];
					this.text_fake = this.dlce1.credits_text[277];
				}
				else if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 >= 1000)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(135);
					}
					this.Name.text = this.dlce1.credits_text[300];
					this.text_fake = this.dlce1.credits_text[301];
				}
				else if (this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie >= 300)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(135);
					}
					this.Name.text = this.dlce1.credits_text[294];
					this.text_fake = this.dlce1.credits_text[295];
				}
				else
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(135);
					}
					this.Name.text = this.dlce1.credits_text[288];
					this.text_fake = this.dlce1.credits_text[289];
				}
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(135);
				}
			}
			else if (this.global1.data[214] == 1 && this.global1.data[10] >= 401)
			{
				if (this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 + this.global1.data[6] / 10 + this.global1.data[8] / 20 >= 1350)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(135);
					}
					this.Name.text = this.dlce1.credits_text[304];
					this.text_fake = this.dlce1.credits_text[305];
				}
				else if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[10] > 1600)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(135);
					}
					this.Name.text = this.dlce1.credits_text[284];
					this.text_fake = this.dlce1.credits_text[285];
				}
				else if (this.global1.event_done[382] && this.global1.data[164] <= 5)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(135);
					}
					this.Name.text = this.dlce1.credits_text[278];
					this.text_fake = this.dlce1.credits_text[279];
				}
				else if (this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 >= 1000)
				{
					this.Name.text = this.dlce1.credits_text[302];
					this.text_fake = this.dlce1.credits_text[303];
				}
				else if (this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie >= 300)
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(135);
					}
					this.Name.text = this.dlce1.credits_text[296];
					this.text_fake = this.dlce1.credits_text[297];
				}
				else
				{
					if (this.global1.iron_and_blood)
					{
						this.achieves.GetComponent<achievements>().Set(135);
					}
					this.Name.text = this.dlce1.credits_text[290];
					this.text_fake = this.dlce1.credits_text[291];
				}
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(135);
				}
			}
			else
			{
				this.Name.text = this.dlce1.credits_text[306];
				this.text_fake = this.dlce1.credits_text[307];
			}
		}
		else if (this.this_okno == 17 && this.global1.data[0] == 1 && this.global1.data[242] == 2)
		{
			this.Name.text = this.dlce1.credits_text[358];
			this.text_fake = this.dlce1.credits_text[359];
		}
		else if (this.this_okno == 18 && this.global1.data[0] == 1 && this.global1.data[242] == 2)
		{
			if (this.global1.allcountries[17].Westalgie >= 300 && (this.global1.data[7] >= 950 || (this.global1.allcountries[21].Gosstroy == 1 && this.global1.data[7] >= 850)))
			{
				this.Name.text = this.dlce1.credits_text[349];
				this.text_fake = this.dlce1.credits_text[351];
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(143);
				}
			}
			else
			{
				this.Name.text = this.dlce1.credits_text[350];
				this.text_fake = this.dlce1.credits_text[352];
				if (this.global1.iron_and_blood)
				{
					this.achieves.GetComponent<achievements>().Set(144);
				}
			}
		}
		else if ((this.this_okno == 17 && (this.global1.data[0] != 1 || this.global1.data[242] != 2)) || this.this_okno == 19 + plus_max)
		{
			this.text_fake = "";
			this.Name.text = "СЛИШКОМ ПОЗДНО";
			this.text_fake = "Год: " + this.global1.data[21].ToString() + "|";
			this.text_fake += "1991 год давно закончился, но вы продолжили играть... И победили!|";
			this.text_fake += "Считаете это достижением? Тогда добейтесь того же самого до 1992 года!";
		}
		if ((this.this_okno == 17 && (this.global1.data[0] != 1 || this.global1.data[242] != 2)) || (this.this_okno == 19 && this.global1.data[0] == 1 && this.global1.data[242] == 2))
		{
			this.Name.text = "<color=purple>" + this.global1.allcountries[havepaths[0]].name + "</color>";
			this.text_fake = this.CheckDLCEnding(havepaths[0]);
			this.SovToRus(this.text_fake);
		}
		else if ((this.this_okno == 18 && (this.global1.data[0] != 1 || this.global1.data[242] != 2)) || (this.this_okno == 20 && this.global1.data[0] == 1 && this.global1.data[242] == 2))
		{
			this.Name.text = "<color=purple>" + this.global1.allcountries[havepaths[1]].name + "</color>";
			this.text_fake = this.CheckDLCEnding(havepaths[1]);
			this.SovToRus(this.text_fake);
		}
		else if ((this.this_okno == 19 && (this.global1.data[0] != 1 || this.global1.data[242] != 2)) || (this.this_okno == 21 && this.global1.data[0] == 1 && this.global1.data[242] == 2))
		{
			this.Name.text = "<color=purple>" + this.global1.allcountries[havepaths[2]].name + "</color>";
			this.text_fake = this.CheckDLCEnding(havepaths[2]);
			this.SovToRus(this.text_fake);
		}
		else if ((this.this_okno == 20 && (this.global1.data[0] != 1 || this.global1.data[242] != 2)) || (this.this_okno == 22 && this.global1.data[0] == 1 && this.global1.data[242] == 2))
		{
			this.Name.text = "<color=purple>" + this.global1.allcountries[havepaths[3]].name + "</color>";
			this.text_fake = this.CheckDLCEnding(havepaths[3]);
			this.SovToRus(this.text_fake);
		}
		else if ((this.this_okno == 21 && (this.global1.data[0] != 1 || this.global1.data[242] != 2)) || (this.this_okno == 23 && this.global1.data[0] == 1 && this.global1.data[242] == 2))
		{
			this.Name.text = "<color=purple>" + this.global1.allcountries[havepaths[4]].name + "</color>";
			this.text_fake = this.CheckDLCEnding(havepaths[4]);
			this.SovToRus(this.text_fake);
		}
		else if ((this.this_okno == 22 && (this.global1.data[0] != 1 || this.global1.data[242] != 2)) || (this.this_okno == 24 && this.global1.data[0] == 1 && this.global1.data[242] == 2))
		{
			this.Name.text = "<color=purple>" + this.global1.allcountries[havepaths[5]].name + "</color>";
			this.text_fake = this.CheckDLCEnding(havepaths[5]);
			this.SovToRus(this.text_fake);
		}
		if (this.global1.diff[0] && this.global1.diff[1] && this.global1.diff[2] && !this.global1.diff[3] && (this.global1.data[21] < 1992 || this.global1.data[20] == 1))
		{
			if (this.global1.data[195] == 1000)
			{
				this.achieves.GetComponent<achievements>().Set(69);
			}
			if (this.global1.allcountries[1].paths == 2 && this.global1.allcountries[4].paths == 3 && this.CheckDLCEnding(6) == this.dlce1.credits_text[41] && this.global1.allcountries[6].paths == 3 && this.global1.allcountries[5].paths == 5 && this.global1.data[198] != 1)
			{
				this.achieves.GetComponent<achievements>().Set(70);
			}
			if (this.CheckDLCEnding(2) == this.dlce1.credits_text[11] && this.CheckDLCEnding(3) == this.dlce1.credits_text[18] && this.CheckDLCEnding(6) == this.dlce1.credits_text[40])
			{
				this.achieves.GetComponent<achievements>().Set(71);
			}
			if (this.global1.allcountries[2].paths == 2 && this.global1.allcountries[3].paths == 5 && this.global1.event_done[99] && (this.global1.data[11] == 1 || this.global1.data[11] == 3) && this.global1.allcountries[4].paths == 4 && this.global1.data[125] != 1000 && this.global1.allcountries[7].Gosstroy < 2)
			{
				this.achieves.GetComponent<achievements>().Set(72);
			}
			else if (this.global1.allcountries[2].paths == 2 && this.global1.allcountries[3].paths == 5 && this.global1.allcountries[4].paths == 2 && this.global1.allcountries[5].paths == 4)
			{
				this.achieves.GetComponent<achievements>().Set(72);
			}
			if (this.global1.data[243] >= 3)
			{
				this.achieves.GetComponent<achievements>().Set(73);
			}
			if (this.CheckDLCEnding(4) == this.dlce1.credits_text[28] && this.CheckDLCEnding(6) == this.dlce1.credits_text[43] && this.global1.science[9] && this.global1.allcountries[10].Stasi)
			{
				this.achieves.GetComponent<achievements>().Set(75);
			}
			if (this.global1.allcountries[1].paths == 3 && this.global1.allcountries[3].isOVD && this.global1.allcountries[6].paths == 4 && this.global1.allcountries[7].Gosstroy < 2 && this.global1.allcountries[2].paths == 3 && this.global1.allcountries[2].isOVD && this.global1.allcountries[4].paths == 4 && this.global1.data[196] == 100)
			{
				this.achieves.GetComponent<achievements>().Set(76);
			}
		}
		if (this.this_okno != 7)
		{
			this.text.text = this.Text(this.text_fake, 72);
			return;
		}
		if (!this.this_done_done)
		{
			this.text.text = this.Text(this.text_fake, 72);
		}
	}

	// Token: 0x06000198 RID: 408
	private void SovToRus(string text)
	{
		if (this.global1.data[45] == 5)
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				this.text_fake = text.Replace(" 俄 罗 斯 联 邦", " 俄 罗 斯 联 邦").Replace(" 苏 联", " 俄 罗 斯").Replace(" 苏 联", " 俄 罗 斯");
				return;
			}
			this.text_fake = text.Replace("Советский Союз", "Российская Федерация").Replace("Советского Союза", "Российской Федерации").Replace("Советскому Союзу", "Российской Федерации")
				.Replace("Советским Союзом", "Российской Федерацией")
				.Replace("СССР", "РФ")
				.Replace("советский", "российский")
				.Replace("советского", "российского")
				.Replace("советскому", "российскому")
				.Replace("советским", "российским")
				.Replace("советском", "российском");
			return;
		}
		else
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				this.text_fake = text.Replace(" 俄 罗 斯 联 邦", " 苏 维 埃 联 盟").Replace(" 俄 罗 斯", " 苏 联").Replace(" 俄 罗 斯", " 苏 联")
					.Replace(" 俄 罗 斯", " 苏 联");
				return;
			}
			this.text_fake = text.Replace("Россия", "Советский Союз").Replace("России", "СССР").Replace("Россией", "Советским Союзом")
				.Replace("РФ", "СССР")
				.Replace("российский", "советский")
				.Replace("российского", "советского")
				.Replace("российскому", "советскому")
				.Replace("российским", "советским")
				.Replace("российском", "советском");
			return;
		}
	}

	// Token: 0x06000199 RID: 409
	private string CheckDLCEnding(int number)
	{
		if (number == 1)
		{
			if (this.global1.allcountries[number].paths == 2)
			{
				if (this.global1.allcountries[number].isSEV && this.global1.allcountries[number].isOVD)
				{
					return this.dlce1.credits_text[0];
				}
				return this.dlce1.credits_text[1];
			}
			else if (this.global1.allcountries[number].paths == 3)
			{
				if (this.global1.allcountries[number].isSEV && this.global1.allcountries[number].isOVD)
				{
					return this.dlce1.credits_text[2];
				}
				return this.dlce1.credits_text[3];
			}
			else if (this.global1.allcountries[number].paths == 4)
			{
				if (this.global1.allcountries[number].isSEV && this.global1.allcountries[number].isOVD)
				{
					return this.dlce1.credits_text[4];
				}
				return this.dlce1.credits_text[5];
			}
			else
			{
				if (this.global1.allcountries[number].paths != 5)
				{
					return this.dlce1.credits_text[8];
				}
				if (this.global1.allcountries[number].isSEV && this.global1.allcountries[number].isOVD)
				{
					return this.dlce1.credits_text[6];
				}
				return this.dlce1.credits_text[7];
			}
		}
		else if (number == 2)
		{
			if (this.global1.allcountries[number].paths == 2)
			{
				return this.dlce1.credits_text[9];
			}
			if (this.global1.allcountries[number].paths != 3)
			{
				return this.dlce1.credits_text[12];
			}
			if (this.global1.allcountries[number].isSEV && this.global1.allcountries[number].isOVD)
			{
				return this.dlce1.credits_text[10];
			}
			return this.dlce1.credits_text[11];
		}
		else if (number == 3)
		{
			if (this.global1.allcountries[number].paths == 2)
			{
				if (this.global1.allcountries[number].isSEV && this.global1.allcountries[number].isOVD)
				{
					return this.dlce1.credits_text[13];
				}
				return this.dlce1.credits_text[14];
			}
			else if (this.global1.allcountries[number].paths == 3)
			{
				if (this.global1.allcountries[number].isSEV && this.global1.allcountries[number].isOVD)
				{
					return this.dlce1.credits_text[15];
				}
				return this.dlce1.credits_text[16];
			}
			else
			{
				if (this.global1.allcountries[number].paths != 4)
				{
					return this.dlce1.credits_text[19];
				}
				if (this.global1.allcountries[number].isSEV && this.global1.allcountries[number].isOVD)
				{
					return this.dlce1.credits_text[17];
				}
				return this.dlce1.credits_text[18];
			}
		}
		else if (number == 4)
		{
			if (this.global1.allcountries[number].paths == 2)
			{
				return this.dlce1.credits_text[20];
			}
			if (this.global1.allcountries[number].paths == 3)
			{
				if (this.global1.allcountries[number].isSEV && this.global1.allcountries[number].isOVD)
				{
					return this.dlce1.credits_text[21];
				}
				return this.dlce1.credits_text[22];
			}
			else if (this.global1.allcountries[number].paths == 4)
			{
				if (this.global1.data[195] == 1000)
				{
					return this.dlce1.credits_text[49];
				}
				if (this.global1.data[196] > 0)
				{
					return this.dlce1.credits_text[23];
				}
				if (this.global1.allcountries[7].paths == 3 || this.global1.allcountries[7].Gosstroy == 0)
				{
					return this.dlce1.credits_text[24];
				}
				if (this.global1.allcountries[7].Gosstroy < 2)
				{
					return this.dlce1.credits_text[25];
				}
				return this.dlce1.credits_text[26];
			}
			else
			{
				if (this.global1.allcountries[number].isSEV && this.global1.allcountries[number].isOVD)
				{
					return this.dlce1.credits_text[27];
				}
				return this.dlce1.credits_text[28];
			}
		}
		else if (number == 5)
		{
			if (this.global1.data[196] > 0)
			{
				return this.dlce1.credits_text[29];
			}
			if (this.global1.allcountries[number].paths == 2)
			{
				if (this.global1.data[197] == 4)
				{
					return this.dlce1.credits_text[30];
				}
				return this.dlce1.credits_text[31];
			}
			else if (this.global1.allcountries[number].paths == 3)
			{
				if (this.global1.allcountries[number].isSEV && this.global1.allcountries[number].isOVD)
				{
					return this.dlce1.credits_text[32];
				}
				return this.dlce1.credits_text[33];
			}
			else
			{
				if (this.global1.allcountries[number].paths == 4)
				{
					return this.dlce1.credits_text[34];
				}
				if (this.global1.data[198] == 1)
				{
					return this.dlce1.credits_text[35];
				}
				return this.dlce1.credits_text[36];
			}
		}
		else
		{
			if (number != 6)
			{
				return "Баг";
			}
			if (this.global1.allcountries[number].paths == 2)
			{
				if ((this.global1.allcountries[number].isSEV && this.global1.allcountries[number].isOVD && this.global1.data[0] != 20) || this.global1.data[199] > 0)
				{
					return this.dlce1.credits_text[37];
				}
				return this.dlce1.credits_text[38];
			}
			else if (this.global1.allcountries[number].paths == 3)
			{
				if (this.global1.allcountries[number].isSEV && this.global1.allcountries[number].isOVD)
				{
					return this.dlce1.credits_text[39];
				}
				if (this.global1.allcountries[number].isSEV || this.global1.allcountries[7].Gosstroy < 2)
				{
					return this.dlce1.credits_text[40];
				}
				return this.dlce1.credits_text[41];
			}
			else if (this.global1.allcountries[number].paths == 4)
			{
				if (this.global1.data[235] == 9)
				{
					return this.dlce1.credits_text[347];
				}
				if (this.global1.allcountries[7].Gosstroy < 2)
				{
					return this.dlce1.credits_text[42];
				}
				return this.dlce1.credits_text[43];
			}
			else
			{
				if (this.global1.allcountries[number].isSEV && this.global1.allcountries[number].isOVD)
				{
					return this.dlce1.credits_text[44];
				}
				return this.dlce1.credits_text[45];
			}
		}
	}

	// Token: 0x0600019A RID: 410
	private string Text(string text, int col)
	{
		int num = 0;
		string text2 = "";
		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] == char.Parse("|"))
			{
				num = 0;
				text2 += "\n";
			}
			else if (num >= col)
			{
				if (text[i] == char.Parse(" "))
				{
					num = 0;
					text2 += "\n";
				}
				else
				{
					text2 += text[i].ToString();
					for (int j = i; j >= 0; j--)
					{
						if (text2[j] == char.Parse(" "))
						{
							text2 = text2.Substring(0, j) + "\n" + text2.Substring(j + 1, text2.Length - 1 - (j + 1) + 1);
							num = text2.Length - 1 - (j + 1) + 1;
							break;
						}
					}
				}
			}
			else
			{
				text2 += text[i].ToString();
				num++;
			}
		}
		return text2;
	}

	// Token: 0x0400023F RID: 575
	public GlobalScript global1;

	// Token: 0x04000240 RID: 576
	public DLCEndingScript dlce1;

	// Token: 0x04000241 RID: 577
	private Yugoglobal yug1;

	// Token: 0x04000242 RID: 578
	public TextMesh Name;

	// Token: 0x04000243 RID: 579
	public TextMesh text;

	// Token: 0x04000244 RID: 580
	private string text_fake;

	// Token: 0x04000245 RID: 581
	private string namelibEaEu;

	// Token: 0x04000246 RID: 582
	public int this_okno;

	// Token: 0x04000247 RID: 583
	public int this_vrem;

	// Token: 0x04000248 RID: 584
	public Sprite winfon;

	// Token: 0x04000249 RID: 585
	public Sprite winplan;

	// Token: 0x0400024A RID: 586
	public int ipolitic;

	// Token: 0x0400024B RID: 587
	public GameObject achieves;

	// Token: 0x0400024C RID: 588
	public GameObject button_l;

	// Token: 0x0400024D RID: 589
	public GameObject button_r;

	// Token: 0x0400024E RID: 590
	public bool sinochek;

	// Token: 0x0400024F RID: 591
	public bool otstavnoysinochek;

	// Token: 0x04000250 RID: 592
	public bool this_done_done;

	// Token: 0x04000251 RID: 593
	public int military_ally;

	// Token: 0x04000252 RID: 594
	public int economy_ally;

	// Token: 0x04000253 RID: 595
	public int greece_ally;

	// Token: 0x04000254 RID: 596
	public int liberalEaEu;

	// Token: 0x04000255 RID: 597
	public int auth;

	// Token: 0x04000256 RID: 598
	public int yeye;

	// Token: 0x04000257 RID: 599
	public int guevara;

	// Token: 0x04000258 RID: 600
	public int greenf;

	// Token: 0x04000259 RID: 601
	public int redA;
}
