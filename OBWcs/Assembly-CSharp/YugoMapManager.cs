using System;
using UnityEngine;

// Token: 0x02000049 RID: 73
public class YugoMapManager : MonoBehaviour, IButtonPressReceiver
{
	// Token: 0x0600014F RID: 335 RVA: 0x00192380 File Offset: 0x00190580
	public void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
		{
			this.yug1 = GameObject.Find("Yugoglobal(Clone)").GetComponent<Yugoglobal>();
		}
		else
		{
			global::UnityEngine.Object.Destroy(this);
		}
		if (this.is_separate)
		{
			this.Repaint();
		}
	}

	// Token: 0x06000150 RID: 336 RVA: 0x001923F0 File Offset: 0x001905F0
	public void AddButtons(bool yes_man = true)
	{
		for (int i = 0; i < this.buttons.Length; i++)
		{
			this.buttons[i].SetActive(yes_man);
		}
		if (!yes_man)
		{
			this.description.text = "";
			return;
		}
		if (!this.yug1.gameState.battle_royal && this.is_separate)
		{
			this.buttons[5].SetActive(false);
			if (this.global1.data[0] == 51)
			{
				if (this.global1.party_name[1] != this.yug1.science_text[118])
				{
					this.buttons[4].SetActive(false);
					return;
				}
			}
			else if (this.global1.data[0] == 50)
			{
				if (this.global1.party_name[1] != this.yug1.science_text[125])
				{
					this.buttons[4].SetActive(false);
					return;
				}
			}
			else if (this.global1.data[0] == 49 && this.global1.party_name[1] != this.yug1.science_text[132])
			{
				this.buttons[4].SetActive(false);
			}
		}
	}

	// Token: 0x06000151 RID: 337 RVA: 0x0019252C File Offset: 0x0019072C
	public void Repaint()
	{
		int num = this.yug1.gameState.yugregions.Length;
		for (int i = 0; i < this.countries.Length; i++)
		{
			int owner = this.yug1.gameState.yugregions[this.countries[i].GetComponent<YugoMapButtons>().num].owner;
			this.countries[i].GetComponent<SpriteRenderer>().color = new Color(1f / (float)(owner + 1), (owner >= num / 2) ? (1f / (float)(owner - num / 2 + 1)) : (1f / (float)(num / 2 - owner)), (owner < num / 2) ? (1f / (float)(num / 2 - owner)) : (1f / (float)(num - owner)));
		}
	}

	// Token: 0x06000152 RID: 338 RVA: 0x001925F0 File Offset: 0x001907F0
	private void ReRepaint()
	{
		this.requirements.text = this.yug1.science_text[61];
		int num = (((this.global1.science[1] > false) + (this.global1.science[5] > false) + (this.global1.science[9] > false)) ? 1 : 0);
		int num2 = this.yug1.gameState.yugcountries[this.country].army;
		this.yug1.ArmyAutoGrowth(this.country, ref num2);
		num2 -= this.yug1.gameState.yugcountries[this.country].army;
		if (this.country == this.yug1.gameState.player)
		{
			if (this.is_separate)
			{
				this.description.text = string.Format(this.yug1.science_text[52], new object[]
				{
					'\n',
					this.yug1.gameState.yugcountries[this.country].name,
					this.yug1.gameState.yugregions[this.region].name,
					this.yug1.gameState.yugregions[this.region].defence,
					this.yug1.gameState.yugregions[this.region].control,
					this.yug1.gameState.yugcountries[this.country].army,
					this.yug1.gameState.yugregions[this.region].population,
					num2
				});
				return;
			}
			this.description.text = string.Format(this.yug1.science_text[62], new object[]
			{
				'\n',
				this.yug1.gameState.yugcountries[this.country].name,
				this.yug1.gameState.yugregions[this.region].name,
				this.yug1.gameState.yugregions[this.region].defence,
				this.yug1.gameState.yugregions[this.region].control,
				this.yug1.gameState.yugcountries[this.country].army,
				this.yug1.gameState.yugregions[this.region].population,
				num2
			});
			return;
		}
		else
		{
			int num3 = num2 - num2 / 30 * (this.global1.data[21] - 1988);
			int num4 = num2 / 10 * (3 - num) + num2;
			int num5 = this.yug1.gameState.yugcountries[this.country].army - this.yug1.gameState.yugcountries[this.country].army / 30 * (this.global1.data[21] - 1988);
			int num6 = this.yug1.gameState.yugcountries[this.country].army / 10 * (3 - num) + this.yug1.gameState.yugcountries[this.country].army;
			if (num5 < 0)
			{
				num5 = 0;
			}
			int num7 = (this.yug1.gameState.yugregions[this.region].defence - this.yug1.gameState.yugregions[this.region].defence / 50 * (this.global1.data[21] - 1988)) * ((num > 0) ? 1 : 0);
			int num8 = (this.yug1.gameState.yugregions[this.region].defence / 25 * (3 - num) + this.yug1.gameState.yugregions[this.region].defence) * ((num <= 0) ? 13 : 1);
			if (this.yug1.gameState.yugregions[this.region].defence <= 0)
			{
				num7 = (num8 = this.yug1.gameState.yugregions[this.region].defence);
			}
			else if (num7 <= 0)
			{
				num7 = 1;
			}
			if (this.is_separate)
			{
				this.description.text = string.Format(this.yug1.science_text[53], new object[]
				{
					'\n',
					this.yug1.gameState.yugcountries[this.country].name,
					this.yug1.gameState.yugregions[this.region].name,
					num7,
					num5,
					(num3 + num4) / 2,
					this.yug1.gameState.yugregions[this.region].population,
					num,
					(num4 - num3) / 2,
					num6,
					num8
				});
				return;
			}
			this.description.text = string.Format(this.yug1.science_text[63], new object[]
			{
				'\n',
				this.yug1.gameState.yugcountries[this.country].name,
				this.yug1.gameState.yugregions[this.region].name,
				num7,
				num5,
				(num3 + num4) / 2,
				this.yug1.gameState.yugregions[this.region].population,
				num,
				(num4 - num3) / 2,
				num6,
				num8
			});
			return;
		}
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00192C48 File Offset: 0x00190E48
	void IButtonPressReceiver.OnButtonDown(int num)
	{
		if (num < this.yug1.gameState.yugregions.Length && num >= 0)
		{
			this.country = this.yug1.gameState.yugregions[num].owner;
			this.region = num;
			this.AddButtons(true);
			int num2 = (((this.global1.science[1] > false) + (this.global1.science[5] > false) + (this.global1.science[9] > false)) ? 1 : 0);
			int num3 = this.yug1.gameState.yugcountries[this.country].army;
			this.yug1.ArmyAutoGrowth(this.country, ref num3);
			num3 -= this.yug1.gameState.yugcountries[this.country].army;
			if (this.country == this.yug1.gameState.player)
			{
				if (this.is_separate)
				{
					this.description.text = string.Format(this.yug1.science_text[52], new object[]
					{
						'\n',
						this.yug1.gameState.yugcountries[this.country].name,
						this.yug1.gameState.yugregions[this.region].name,
						this.yug1.gameState.yugregions[this.region].defence,
						this.yug1.gameState.yugregions[this.region].control,
						this.yug1.gameState.yugcountries[this.country].army,
						this.yug1.gameState.yugregions[this.region].population,
						num3
					});
				}
				else
				{
					this.description.text = string.Format(this.yug1.science_text[62], new object[]
					{
						'\n',
						this.yug1.gameState.yugcountries[this.country].name,
						this.yug1.gameState.yugregions[this.region].name,
						this.yug1.gameState.yugregions[this.region].defence,
						this.yug1.gameState.yugregions[this.region].control,
						this.yug1.gameState.yugcountries[this.country].army,
						this.yug1.gameState.yugregions[this.region].population,
						num3
					});
				}
			}
			else
			{
				int num4 = num3 - num3 / 30 * (this.global1.data[21] - 1988);
				int num5 = num3 / 10 * (3 - num2) + num3;
				int num6 = this.yug1.gameState.yugcountries[this.country].army - this.yug1.gameState.yugcountries[this.country].army / 30 * (this.global1.data[21] - 1988);
				int num7 = this.yug1.gameState.yugcountries[this.country].army / 10 * (3 - num2) + this.yug1.gameState.yugcountries[this.country].army;
				if (num6 < 0)
				{
					num6 = 0;
				}
				int num8 = (this.yug1.gameState.yugregions[num].defence - this.yug1.gameState.yugregions[num].defence / 50 * (this.global1.data[21] - 1988)) * ((num2 > 0) ? 1 : 0);
				int num9 = (this.yug1.gameState.yugregions[num].defence / 25 * (3 - num2) + this.yug1.gameState.yugregions[num].defence) * ((num2 <= 0) ? 13 : 1);
				if (this.yug1.gameState.yugregions[num].defence <= 0)
				{
					num8 = (num9 = this.yug1.gameState.yugregions[num].defence);
				}
				else if (num8 <= 0)
				{
					num8 = 1;
				}
				if (this.is_separate)
				{
					if (this.yug1.gameState.yugcountries[this.country].is_independent || this.country == this.yug1.gameState.player)
					{
						this.description.text = string.Format(this.yug1.science_text[53], new object[]
						{
							'\n',
							this.yug1.gameState.yugcountries[this.country].name,
							this.yug1.gameState.yugregions[this.region].name,
							num8,
							num6,
							(num4 + num5) / 2,
							this.yug1.gameState.yugregions[this.region].population,
							num2,
							(num5 - num4) / 2,
							num7,
							num9
						});
					}
					else
					{
						this.description.text = string.Format(this.yug1.science_text[110], new object[]
						{
							'\n',
							this.yug1.gameState.yugcountries[this.country].name,
							this.yug1.gameState.yugregions[this.region].name,
							num8,
							num6,
							(num4 + num5) / 2,
							this.yug1.gameState.yugregions[this.region].population,
							num2,
							(num5 - num4) / 2,
							num7,
							num9
						});
					}
				}
				else if (this.country == this.yug1.gameState.player)
				{
					this.description.text = string.Format(this.yug1.science_text[62], new object[]
					{
						'\n',
						this.yug1.gameState.yugcountries[this.country].name,
						this.yug1.gameState.yugregions[this.region].name,
						num8,
						num6,
						(num4 + num5) / 2,
						this.yug1.gameState.yugregions[this.region].population,
						num2,
						(num5 - num4) / 2,
						num7,
						num9
					});
				}
				else
				{
					this.description.text = string.Format(this.yug1.science_text[63], new object[]
					{
						'\n',
						this.yug1.gameState.yugcountries[this.country].name,
						this.yug1.gameState.yugregions[this.region].name,
						num8,
						num6,
						(num4 + num5) / 2,
						this.yug1.gameState.yugregions[this.region].population,
						num2,
						(num5 - num4) / 2,
						num7,
						num9
					});
				}
			}
			this.leaderShow.text = this.ShowLeaders(this.country, this.region);
		}
		else if (num == -1)
		{
			if (!this.yug1.gameState.yugcountries[this.country].peace_with[this.yug1.gameState.player] && !this.yug1.gameState.yugcountries[this.yug1.gameState.player].peace_with[this.country] && !this.yug1.gameState.yugcountries[this.country].temp_peace && this.yug1.gameState.yugcountries[this.yug1.gameState.player].army >= 50 && this.country != this.yug1.gameState.player && this.yug1.IsBorderedreion(this.region, this.yug1.gameState.player, false))
			{
				this.yug1.AttackAgainstBot(this.region, this.yug1.gameState.player);
				this.ReRepaint();
			}
		}
		else if (num == -7)
		{
			if (!this.yug1.gameState.yugcountries[this.country].peace_with[this.yug1.gameState.player] && !this.yug1.gameState.yugcountries[this.yug1.gameState.player].peace_with[this.country] && !this.yug1.gameState.yugcountries[this.country].temp_peace && this.yug1.gameState.yugcountries[this.yug1.gameState.player].army >= 150 && this.country != this.yug1.gameState.player && this.yug1.IsBorderedreion(this.region, this.yug1.gameState.player, false))
			{
				this.yug1.AttackAgainstBotx3(this.region, this.yug1.gameState.player);
				this.ReRepaint();
			}
		}
		else if (num == -2)
		{
			if (this.yug1.gameState.yugregions[this.region].control < 100 && this.yug1.gameState.yugcountries[this.yug1.gameState.player].army >= 50)
			{
				this.yug1.RegionDefence(this.region, this.yug1.gameState.player);
				this.ReRepaint();
			}
		}
		else if (num == -3)
		{
			if (!this.yug1.gameState.yugcountries[this.country].temp_peace && !this.yug1.gameState.yugcountries[this.country].peace_with[this.yug1.gameState.player] && !this.yug1.gameState.yugcountries[this.yug1.gameState.player].peace_with[this.country] && this.yug1.gameState.yugcountries[this.yug1.gameState.player].army >= this.yug1.gameState.yugcountries[this.country].army * 2 && this.global1.data[9] >= 30 && this.country != this.yug1.gameState.player)
			{
				this.global1.data[9] -= 30;
				this.yug1.MakeTempPeace(this.country);
				this.ReRepaint();
			}
		}
		else if (num == -4)
		{
			if (this.global1.science[7] && (this.yug1.gameState.yugcountries[this.country].temp_peace || (this.yug1.gameState.yugcountries[this.country].peace_with[this.yug1.gameState.player] && this.yug1.gameState.yugcountries[this.yug1.gameState.player].peace_with[this.country])) && this.global1.data[8] >= 30 && this.country != this.yug1.gameState.player && this.yug1.gameState.yugcountries[this.country].army > 0)
			{
				this.global1.data[8] -= 30;
				this.yug1.gameState.yugcountries[this.country].army -= 30;
				if (this.yug1.gameState.yugcountries[this.country].army < 0)
				{
					this.yug1.gameState.yugcountries[this.country].army = 0;
				}
				this.yug1.gameState.yugcountries[this.country].money += 30;
				this.yug1.gameState.yugcountries[this.yug1.gameState.player].army += 30;
				if (this.yug1.gameState.yugcountries[this.country].last)
				{
					this.yug1.gameState.yugregions[this.region].defence = this.yug1.DefenceRegionalPower(this.region);
				}
				this.ReRepaint();
			}
		}
		else if (num == -5)
		{
			if (this.global1.science[1] && (this.yug1.gameState.yugcountries[this.country].temp_peace || (this.yug1.gameState.yugcountries[this.country].peace_with[this.yug1.gameState.player] && this.yug1.gameState.yugcountries[this.yug1.gameState.player].peace_with[this.country])))
			{
				if (this.yug1.gameState.yugcountries[this.country].money >= 15)
				{
					if (this.yug1.gameState.yugcountries[this.yug1.gameState.player].army >= 30 && this.country != this.yug1.gameState.player && this.yug1.IsBorderedreion(this.region, this.yug1.gameState.player, true) && (!this.yug1.gameState.yugcountries[this.country].traded || this.yug1.gameState.battle_royal))
					{
						this.yug1.gameState.yugcountries[this.yug1.gameState.player].army -= 30;
						this.yug1.gameState.yugcountries[this.country].army += 30;
						this.global1.data[8] += 15;
						this.yug1.gameState.yugcountries[this.country].money -= 15;
						this.yug1.gameState.yugcountries[this.country].traded = true;
						if (this.yug1.gameState.yugcountries[this.country].last)
						{
							this.yug1.gameState.yugregions[this.region].defence = this.yug1.DefenceRegionalPower(this.region);
						}
						this.ReRepaint();
					}
				}
				else if (this.yug1.gameState.yugcountries[this.yug1.gameState.player].army >= 30 && this.country != this.yug1.gameState.player)
				{
					this.yug1.gameState.yugcountries[this.yug1.gameState.player].army -= 30;
					this.yug1.gameState.yugcountries[this.country].army += 30;
					if (this.yug1.gameState.yugcountries[this.country].last)
					{
						this.yug1.gameState.yugregions[this.region].defence = this.yug1.DefenceRegionalPower(this.region);
					}
					this.ReRepaint();
				}
			}
		}
		else if (num == -8)
		{
			if (this.global1.science[1] && (this.yug1.gameState.yugcountries[this.country].temp_peace || (this.yug1.gameState.yugcountries[this.country].peace_with[this.yug1.gameState.player] && this.yug1.gameState.yugcountries[this.yug1.gameState.player].peace_with[this.country])) && this.yug1.gameState.yugcountries[this.yug1.gameState.player].army >= 30 && this.country != this.yug1.gameState.player)
			{
				this.yug1.gameState.yugcountries[this.yug1.gameState.player].army -= 30;
				this.yug1.gameState.yugcountries[this.country].army += 30;
				if (this.yug1.gameState.yugcountries[this.country].last)
				{
					this.yug1.gameState.yugregions[this.region].defence = this.yug1.DefenceRegionalPower(this.region);
				}
				this.ReRepaint();
			}
		}
		else if (num == -6 && this.yug1.gameState.yugcountries[this.country].temp_peace_count >= 2 && this.yug1.gameState.yugcountries[this.country].temp_peace && this.global1.data[9] >= 30 && !this.yug1.gameState.has_ally)
		{
			this.global1.data[9] -= 30;
			this.yug1.gameState.has_ally = true;
			this.yug1.gameState.yugcountries[this.country].is_ally = true;
			this.yug1.gameState.yugcountries[this.country].peace_with[this.yug1.gameState.player] = true;
			this.yug1.gameState.yugcountries[this.yug1.gameState.player].peace_with[this.country] = true;
			this.ReRepaint();
		}
		this.Repaint();
	}

	// Token: 0x06000154 RID: 340 RVA: 0x0019411C File Offset: 0x0019231C
	void IButtonPressReceiver.OnButtonEnter(int num, SpriteRenderer spr)
	{
		if (num < 0)
		{
			spr.color = new Color(1f, 0.74f, 0f);
		}
		if (num < this.yug1.gameState.yugregions.Length && num >= 0)
		{
			spr.color = new Color(spr.color.r, spr.color.g, spr.color.b, 0f);
			return;
		}
		if (num == -1)
		{
			this.requirements.text = string.Format(this.yug1.science_text[56], new object[]
			{
				'\n',
				(!this.yug1.gameState.yugcountries[this.country].temp_peace && !this.yug1.gameState.yugcountries[this.country].peace_with[this.yug1.gameState.player] && !this.yug1.gameState.yugcountries[this.yug1.gameState.player].peace_with[this.country]) ? this.yug1.science_text[54] : this.yug1.science_text[55],
				(this.yug1.gameState.yugcountries[this.yug1.gameState.player].army >= 50 * (1 + this.global1.data[215] / 2) - 1) ? this.yug1.science_text[54] : this.yug1.science_text[55],
				this.yug1.IsBorderedreion(this.region, this.yug1.gameState.player, false) ? this.yug1.science_text[54] : this.yug1.science_text[55],
				50 * (1 + this.global1.data[215] / 2) - 1
			});
			return;
		}
		if (num == -7)
		{
			this.requirements.text = string.Format(this.yug1.science_text[56], new object[]
			{
				'\n',
				(!this.yug1.gameState.yugcountries[this.country].temp_peace && !this.yug1.gameState.yugcountries[this.country].peace_with[this.yug1.gameState.player] && !this.yug1.gameState.yugcountries[this.yug1.gameState.player].peace_with[this.country]) ? this.yug1.science_text[54] : this.yug1.science_text[55],
				(this.yug1.gameState.yugcountries[this.yug1.gameState.player].army >= 150 * (1 + this.global1.data[215] / 2) - 1) ? this.yug1.science_text[54] : this.yug1.science_text[55],
				this.yug1.IsBorderedreion(this.region, this.yug1.gameState.player, false) ? this.yug1.science_text[54] : this.yug1.science_text[55],
				150 * (1 + this.global1.data[215] / 2) - 1
			});
			return;
		}
		if (num == -2)
		{
			this.requirements.text = string.Format(this.yug1.science_text[57], '\n', (this.yug1.gameState.yugregions[this.region].control < 100) ? this.yug1.science_text[54] : this.yug1.science_text[55], (this.yug1.gameState.yugcountries[this.yug1.gameState.player].army >= 50) ? this.yug1.science_text[54] : this.yug1.science_text[55]);
			return;
		}
		if (num == -3)
		{
			this.requirements.text = string.Format(this.yug1.science_text[58], new object[]
			{
				'\n',
				(!this.yug1.gameState.yugcountries[this.country].temp_peace && !this.yug1.gameState.yugcountries[this.country].peace_with[this.yug1.gameState.player] && !this.yug1.gameState.yugcountries[this.yug1.gameState.player].peace_with[this.country]) ? this.yug1.science_text[54] : this.yug1.science_text[55],
				(this.yug1.gameState.yugcountries[this.yug1.gameState.player].army >= this.yug1.gameState.yugcountries[this.country].army * 2) ? this.yug1.science_text[54] : this.yug1.science_text[55],
				(this.global1.data[9] >= 30) ? this.yug1.science_text[54] : this.yug1.science_text[55],
				this.yug1.gameState.yugcountries[this.country].temp_peace_time
			});
			return;
		}
		if (num == -4)
		{
			this.requirements.text = string.Format(this.yug1.science_text[59], new object[]
			{
				'\n',
				(this.yug1.gameState.yugcountries[this.country].temp_peace || (this.yug1.gameState.yugcountries[this.country].peace_with[this.yug1.gameState.player] && this.yug1.gameState.yugcountries[this.yug1.gameState.player].peace_with[this.country])) ? this.yug1.science_text[54] : this.yug1.science_text[55],
				(this.global1.data[8] >= 30) ? this.yug1.science_text[54] : this.yug1.science_text[55],
				this.global1.science[7] ? this.yug1.science_text[54] : this.yug1.science_text[55],
				(this.yug1.gameState.yugcountries[this.country].army > 0) ? this.yug1.science_text[54] : this.yug1.science_text[55]
			});
			return;
		}
		if (num == -5)
		{
			if (!this.yug1.gameState.battle_royal && this.yug1.gameState.yugcountries[this.country].money >= 15)
			{
				this.requirements.text = string.Format(this.yug1.science_text[179], new object[]
				{
					'\n',
					(this.yug1.gameState.yugcountries[this.country].temp_peace || (this.yug1.gameState.yugcountries[this.country].peace_with[this.yug1.gameState.player] && this.yug1.gameState.yugcountries[this.yug1.gameState.player].peace_with[this.country])) ? this.yug1.science_text[54] : this.yug1.science_text[55],
					(this.yug1.gameState.yugcountries[this.country].money >= 15) ? this.yug1.science_text[54] : this.yug1.science_text[55],
					(this.yug1.gameState.yugcountries[this.yug1.gameState.player].army >= 30) ? this.yug1.science_text[54] : this.yug1.science_text[55],
					this.global1.science[1] ? this.yug1.science_text[54] : this.yug1.science_text[55],
					this.yug1.IsBorderedreion(this.region, this.yug1.gameState.player, true) ? this.yug1.science_text[54] : this.yug1.science_text[55],
					(!this.yug1.gameState.yugcountries[this.country].traded) ? this.yug1.science_text[54] : this.yug1.science_text[55]
				});
				return;
			}
			if (this.yug1.gameState.yugcountries[this.country].money >= 15)
			{
				this.requirements.text = string.Format(this.yug1.science_text[113], new object[]
				{
					'\n',
					(this.yug1.gameState.yugcountries[this.country].temp_peace || (this.yug1.gameState.yugcountries[this.country].peace_with[this.yug1.gameState.player] && this.yug1.gameState.yugcountries[this.yug1.gameState.player].peace_with[this.country])) ? this.yug1.science_text[54] : this.yug1.science_text[55],
					(this.yug1.gameState.yugcountries[this.country].money >= 15) ? this.yug1.science_text[54] : this.yug1.science_text[55],
					(this.yug1.gameState.yugcountries[this.yug1.gameState.player].army >= 30) ? this.yug1.science_text[54] : this.yug1.science_text[55],
					this.global1.science[1] ? this.yug1.science_text[54] : this.yug1.science_text[55],
					this.yug1.IsBorderedreion(this.region, this.yug1.gameState.player, true) ? this.yug1.science_text[54] : this.yug1.science_text[55]
				});
				return;
			}
			this.requirements.text = string.Format(this.yug1.science_text[108], new object[]
			{
				'\n',
				(this.yug1.gameState.yugcountries[this.country].temp_peace || (this.yug1.gameState.yugcountries[this.country].peace_with[this.yug1.gameState.player] && this.yug1.gameState.yugcountries[this.yug1.gameState.player].peace_with[this.country])) ? this.yug1.science_text[54] : this.yug1.science_text[55],
				(this.yug1.gameState.yugcountries[this.country].money < 50) ? this.yug1.science_text[54] : this.yug1.science_text[55],
				(this.yug1.gameState.yugcountries[this.yug1.gameState.player].army >= 30) ? this.yug1.science_text[54] : this.yug1.science_text[55],
				this.global1.science[1] ? this.yug1.science_text[54] : this.yug1.science_text[55]
			});
			return;
		}
		else
		{
			if (num == -8)
			{
				this.requirements.text = string.Format(this.yug1.science_text[108], new object[]
				{
					'\n',
					(this.yug1.gameState.yugcountries[this.country].temp_peace || (this.yug1.gameState.yugcountries[this.country].peace_with[this.yug1.gameState.player] && this.yug1.gameState.yugcountries[this.yug1.gameState.player].peace_with[this.country])) ? this.yug1.science_text[54] : this.yug1.science_text[55],
					(this.yug1.gameState.yugcountries[this.country].money < 50) ? this.yug1.science_text[54] : this.yug1.science_text[55],
					(this.yug1.gameState.yugcountries[this.yug1.gameState.player].army >= 30) ? this.yug1.science_text[54] : this.yug1.science_text[55],
					this.global1.science[1] ? this.yug1.science_text[54] : this.yug1.science_text[55]
				});
				return;
			}
			if (num == -6)
			{
				this.requirements.text = string.Format(this.yug1.science_text[64], new object[]
				{
					'\n',
					(this.yug1.gameState.yugcountries[this.country].temp_peace_count >= 2) ? this.yug1.science_text[54] : this.yug1.science_text[55],
					(!this.yug1.gameState.has_ally) ? this.yug1.science_text[54] : this.yug1.science_text[55],
					(this.global1.data[9] >= 30) ? this.yug1.science_text[54] : this.yug1.science_text[55],
					this.yug1.gameState.yugcountries[this.country].temp_peace_count
				});
			}
			return;
		}
	}

	// Token: 0x06000155 RID: 341 RVA: 0x001950E8 File Offset: 0x001932E8
	void IButtonPressReceiver.OnButtonExit(int num, SpriteRenderer spr)
	{
		if (num < 0)
		{
			spr.color = new Color(1f, 1f, 1f);
		}
		if (num < this.yug1.gameState.yugregions.Length && num >= 0)
		{
			spr.color = new Color(spr.color.r, spr.color.g, spr.color.b, 1f);
			return;
		}
		this.requirements.text = "";
	}

	// Token: 0x06000156 RID: 342 RVA: 0x000026A0 File Offset: 0x000008A0
	void IButtonPressReceiver.OnButtonStay(int num)
	{
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00195170 File Offset: 0x00193370
	private string ShowLeaders(int country, int region)
	{
		string text;
		if (PlayerPrefs.GetInt("language") == 0)
		{
			text = " 共 和 国 的 实 权 领 导 人:\n";
		}
		else
		{
			text = "Фактический глава республики:\n";
		}
		if (region == 0)
		{
			if ((this.yug1.gameState.yugregions[0].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[0].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[0].owner == 1 && this.global1.data[0] == 51) || (this.yug1.gameState.yugregions[0].owner == 0 && this.global1.event_done[1106]))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 军 事 管 制</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Военная администрация</color>");
				}
			}
			else if (this.global1.data[170] == 1 || this.global1.data[199] == 2)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=purple> 罗 伯 托 · 巴 泰 利</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=purple>Роберто Баттели</color>");
				}
			}
			else if (this.global1.data[157] == 2 && this.global1.data[199] != 2)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 米 兰 · 库 昌</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>Милан Кучан</color>");
				}
			}
			else if (this.global1.data[157] == 1 && this.global1.data[223] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 米 兰 · 库 昌</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Милан Кучан</color>");
				}
			}
			else if (this.global1.data[157] == 1 && this.global1.event_done[298])
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 斯 拉 沃 热 · 齐 泽 克</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Славой Жижек</color>");
				}
			}
			else if (this.global1.data[121] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 马 尔 科 · 布 尔 茨</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>Марко Булц</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=maroon> 弗 兰 茨 · 波 皮 特</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=maroon>Франце Попит</color>");
			}
		}
		else if (region == 1)
		{
			if ((this.yug1.gameState.yugregions[1].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[1].owner == 3 && this.global1.data[0] == 50))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 军 事 管 制</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Военная администрация</color>");
				}
			}
			else if (this.global1.data[169] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=purple> 勃 朗 科 · 霍 尔 瓦 特</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=purple>Бранко Хорват</color>");
				}
			}
			else if (this.global1.data[117] == 2 && this.global1.data[118] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=orange> 伊 维 察 · 拉 灿</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=orange>Ивица Рачан</color>");
				}
			}
			else if (this.global1.data[117] == 1 && this.global1.data[118] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=magenta> 伊 维 察 · 拉 灿</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=magenta>Ивица Рачан</color>");
				}
			}
			else if (this.global1.data[195] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 斯 捷 潘 · 梅 西 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>Стипе Месич</color>");
				}
			}
			else if (this.global1.data[116] == 1 && this.global1.data[118] == 1 && this.global1.data[199] != 2)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 弗 拉 尼 奥 · 图 季 曼</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>Франьо Туджман</color>");
				}
			}
			else if ((this.global1.data[116] == 2 && this.global1.data[118] == 1) || this.global1.data[199] == 2)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 弗 拉 尼 奥 · 格 雷 古 里 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Франьо Грегурич</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=maroon> 斯 坦 科 · 斯 托 伊 切 维 奇</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=maroon>Станко Стойчевич</color>");
			}
		}
		else if (region == 2)
		{
			if (!this.yug1.gameState.yugcountries[2].is_exist && this.global1.event_done[274] && this.yug1.gameState.yugregions[2].owner == 2)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 伊 万 · 切 尔 马 克</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>Иван Чермак</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[2].owner == 1 && !this.global1.event_done[275])
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 没 有 明 确 的 领 导 人</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>Нет ярко выраженных лидеров</color>");
				}
			}
			else if (this.yug1.gameState.yugcountries[2].is_independent && this.yug1.gameState.yugregions[2].owner == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 佩 塔 尔 · 帕 希 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>Пётр Пасич</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[2].owner == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 约 万 · 拉 什 科 维 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Йован Рашкович</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[0].owner == 3 && this.global1.data[0] == 50)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 军 事 管 制</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Военная администрация</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[0].owner == 8 && this.global1.data[0] == 49)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 约 万 · 拉 什 科 维 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Йован Рашкович</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=maroon> 约 万 · 拉 什 科 维 奇</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=maroon>Йован Рашкович</color>");
			}
		}
		else if (region == 3)
		{
			if ((this.yug1.gameState.yugregions[3].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[3].owner == 1 && this.global1.data[0] == 51))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 军 事 管 制</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Военная администрация</color>");
				}
			}
			else if (this.global1.data[172] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=purple> 内 纳 德 · 凯 茨 曼 诺 维 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=purple>Ненад Кечманович</color>");
				}
			}
			else if (this.global1.data[136] == 0 && this.global1.data[138] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=magenta> 尼 亚 兹 · 杜 拉 科 维 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=magenta>Нияз Дюракович</color>");
				}
			}
			else if (this.global1.data[136] == 1 && this.global1.data[137] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 阿 利 雅 · 伊 泽 特 贝 戈 维 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>Алия Изетбегович</color>");
				}
			}
			else if (this.global1.data[136] == 1 && this.global1.data[137] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 阿 迪 勒 · 佐 勒 菲 卡 尔 帕 希 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Адил Зулфикарпашич</color>");
				}
			}
			else if (this.global1.data[20] < 7 && this.global1.data[21] == 1989)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 阿 卜 杜 拉 · 穆 塔 普 契 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>Абдула Мутапчич</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=maroon> 拉 伊 夫 · 迪 兹 达 雷 维 奇</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=maroon>Раиф Диздаревич</color>");
			}
		}
		else if (region == 4)
		{
			if (this.yug1.gameState.yugregions[4].owner == 3 && !this.yug1.gameState.yugcountries[4].is_independent)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 没 有 明 确 的 领 导 人</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>Нет ярко выраженных лидеров</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[4].owner == 3 && this.yug1.gameState.yugcountries[4].is_independent && this.global1.data[136] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 萨 费 特 · 奥 鲁 切 维 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>Сафет Оручевич</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[4].owner == 3 && this.yug1.gameState.yugcountries[4].is_independent && this.global1.data[136] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 约 沃 · 波 帕 拉</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>Джово Попара</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[4].owner == 3)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 马 特 · 博 班</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Мате Бобан</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[0].owner == 8 && this.global1.data[0] == 49)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 军 事 管 制</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Военная администрация</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=olive> 马 特 · 博 班</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=olive>Мате Бобан</color>");
			}
		}
		else if (region == 5)
		{
			if (this.yug1.gameState.yugregions[5].owner == 8 || (this.yug1.gameState.yugregions[5].owner == 3 && this.yug1.gameState.yugcountries[5].is_independent) || this.yug1.gameState.yugregions[5].owner == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 军 事 管 制</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Военная администрация</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[5].owner == 3 && !this.yug1.gameState.yugcountries[5].is_independent && this.global1.data[137] == 0 && this.global1.data[136] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 菲 克 雷 特 · 阿 布 迪 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>Фикрет Абдич</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=olive> 菲 克 雷 特 · 阿 布 迪 奇</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=olive>Фикрет Абдич</color>");
			}
		}
		else if (region == 6)
		{
			if (this.yug1.gameState.yugregions[6].owner == 3 && !this.yug1.gameState.yugcountries[6].is_independent)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 没 有 明 确 的 领 导 人</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>Нет ярко выраженных лидеров</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[6].owner == 3 && this.yug1.gameState.yugcountries[6].is_independent && this.global1.data[136] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 苏 莱 曼 · 蒂 希 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>Сулейман Тихич</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[6].owner == 3 && this.yug1.gameState.yugcountries[4].is_independent && this.global1.data[136] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 博 日 达 尔 ·马 蒂 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>Бозидар Матич</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[0].owner == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 军 事 管 制</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Военная администрация</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=olive> 拉 多 万 · 卡 拉 季 奇</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=olive>Радован Караджич</color>");
			}
		}
		else if (region == 7)
		{
			if ((this.yug1.gameState.yugregions[7].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[7].owner == 1 && this.global1.data[0] == 51))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 军 事 管 制</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Военная администрация</color>");
				}
			}
			else if ((this.yug1.gameState.yugregions[7].owner == 8 && this.global1.data[0] == 49) || (this.global1.data[156] == 2 && (this.global1.data[192] == 0 || this.global1.data[131] == 1)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 莫 米 尔 · 布 拉 托 维 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Момир Булатович</color>");
				}
			}
			else if (this.global1.data[156] == 2 && this.global1.data[192] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 莫 米 尔 · 布 拉 托 维 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Момир Булатович</color>");
				}
			}
			else if (this.global1.data[156] == 2 && this.global1.data[192] == 2)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 米 洛 · 久 卡 诺 维 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Мило Джуканович</color>");
				}
			}
			else if (this.global1.data[156] == 1 && this.global1.data[192] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 柳 比 沙 · 斯 坦 科 维 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Любиша Станкович</color>");
				}
			}
			else if (this.global1.data[156] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 柳 比 沙 · 斯 坦 科 维 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>Любиша Станкович</color>");
				}
			}
			else if (this.global1.data[156] == 3)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 德 拉 吉 莎 · 布 尔 赞</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Драгиша Вурзан</color>");
				}
			}
			else if (this.global1.data[156] == 4)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 斯 拉 夫 科 · 佩 罗 维 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>Славко Перович</color>");
				}
			}
			else if (this.global1.event_done[383] && this.yug1.gameState.yugcountries[7].is_independent && this.yug1.gameState.yugregions[7].owner == 7)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 军 事 管 制</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Военная администрация</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=magenta> 博 日 纳 · 伊 万 诺 维 奇</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=magenta>Божина Иванович</color>");
			}
		}
		else if (region == 8)
		{
			if ((this.yug1.gameState.yugregions[8].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[8].owner == 1 && this.global1.data[0] == 51))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 军 事 管 制</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Военная администрация</color>");
				}
			}
			else if (this.global1.data[171] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=purple> 伊 万 · 斯 坦 博 利 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=purple>Иван Стамболич</color>");
				}
			}
			else if (this.global1.data[150] == 0 && this.global1.data[148] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=magenta> 佩 塔 尔 · 格 拉 查 宁</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=magenta>Петар Грачанин</color>");
				}
			}
			else if (this.global1.data[150] == 0 && this.global1.data[148] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 沃 伊 斯 拉 夫 · 科 什 图 尼 察</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Воислав Коштуница</color>");
				}
			}
			else if (this.global1.data[150] == 1 && this.global1.data[148] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 武 克 · 德 拉 什 科 维 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>Вук Драшкович</color>");
				}
			}
			else if (this.global1.data[148] == 2 && this.global1.data[20] <= 5 && this.global1.data[21] == 1989)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 柳 比 沙 · 伊 吉 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>Любиша Игич</color>");
				}
			}
			else if (this.global1.data[200] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=magenta> 德 拉 古 京 · 泽 莱 诺 维 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=magenta>Драгутин Зеленович</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=maroon> 斯 洛 博 丹 · 米 洛 舍 维 奇</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=maroon>Слободан Милошевич</color>");
			}
		}
		else if (region == 9)
		{
			if (this.yug1.gameState.yugregions[9].owner == 8 && !this.yug1.gameState.yugcountries[4].is_independent && this.global1.data[179] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 约 万 · 拉 迪 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Йован Радич</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[9].owner == 9 && (this.yug1.gameState.yugcountries[9].name == "Румынская Воеводина" || this.yug1.gameState.yugcountries[9].name == " 罗 马 尼 亚 属 伏 伊 伏 丁 那"))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 伏 伊 伏 丁 那 人 民 委 员 会</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Народный комитет Воеводины</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[9].owner == 8 && !this.yug1.gameState.yugcountries[4].is_independent && this.global1.data[179] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 约 万 · 拉 迪 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>Йован Радич</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[9].owner == 9 && this.global1.data[149] == 2)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=purple> 德 拉 古 京 · 泽 莱 诺 维 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=purple>Драгослав Петрович</color>");
				}
			}
			else if ((this.yug1.gameState.yugregions[9].owner == 9 && (this.global1.event_done[1106] || this.global1.event_done[39])) || (this.yug1.gameState.yugregions[9].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[9].owner == 1 && this.global1.data[0] == 51))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 军 事 管 制</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Военная администрация</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[9].owner == 9 && this.global1.event_done[353])
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 约 瑟 夫 · 考 绍</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Йожеф Каса</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=maroon> 约 恩 · 斯 尔 博 万</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=maroon>Ион Србован</color>");
			}
		}
		else if (region == 10)
		{
			if ((this.yug1.gameState.yugregions[10].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[10].owner == 1 && this.global1.data[0] == 51))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 军 事 管 制</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Военная администрация</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[10].owner == 10 && this.global1.event_done[1103])
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 哈 希 姆 · 萨 奇</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>Хашим Тачи</color>");
				}
			}
			else if (this.global1.data[155] == 0 || this.global1.data[176] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=magenta> 雷 姆 济 · 科 利 盖 齐</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=magenta>Ремзи Колгеци</color>");
				}
			}
			else if (this.global1.data[155] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 维 利 · 德 瓦</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>Вели Дева</color>");
				}
			}
			else if (this.global1.data[155] == 2)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 拉 赫 曼 · 莫 里 纳</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Рахман Морина</color>");
				}
			}
			else if (this.global1.data[176] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=magenta> 阿 泽 姆 · 弗 拉 西</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=magenta>Азем Власи</color>");
				}
			}
			else if (this.global1.data[176] == 2)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 易 卜 拉 欣 · 鲁 戈 瓦</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Ибрагим Ругова</color>");
				}
			}
			else if (this.global1.data[176] == 3)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 阿 利 · 舒 克 里 亚</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>Али Шукрия</color>");
				}
			}
			else if (this.global1.data[176] == 4)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 法 迪 利 · 霍 扎</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Фадиль Ходжа</color>");
				}
			}
			else if (this.global1.data[176] == 5)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 巴 尔 聚 尔 · 马 哈 茂 蒂</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Бардхил Махмути</color>");
				}
			}
			else if (this.global1.data[176] == 6 && this.yug1.gameState.yugregions[10].owner == 8)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 拉 赫 曼 · 莫 里 纳</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>Рахман Морина</color>");
				}
			}
			else if (this.global1.data[176] == 7)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 雷 杰 普 · 科 斯 亚</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>Реджеп Кося</color>");
				}
			}
			else if (this.global1.data[176] == 8)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 乌 克 欣 · 霍 蒂</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>Укшин Хоти</color>");
				}
			}
			else if (this.global1.data[176] == 9)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=purple> 锡 南 · 哈 萨 尼</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=purple>Синан Хасани</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=navy> 哈 希 姆 · 萨 奇</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=navy>Хашим Тачи</color>");
			}
		}
		else if (region == 11)
		{
			if ((this.yug1.gameState.yugregions[11].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[11].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[11].owner == 1 && this.global1.data[0] == 51))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 军 事 管 制</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Военная администрация</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[11].owner == 11 && (this.global1.event_done[313] || (this.global1.event_done[315] && this.yug1.gameState.yugcountries[11].is_independent)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 军 事 管 制</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Военная администрация</color>");
				}
			}
			else if (this.global1.data[20] < 12 && this.global1.data[21] == 1989)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=magenta> 雅 科 夫 · 拉 扎 罗 斯 基</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=magenta>Яков Лазароски</color>");
				}
			}
			else if (this.global1.data[130] == 0 || this.global1.data[130] == 1 || this.global1.data[130] == 9)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=magenta> 佩 塔 尔 · 戈 舍 夫</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=magenta>Петар Гошев</color>");
				}
			}
			else if ((this.global1.data[130] == 2 && this.yug1.gameState.yugcountries[11].is_independent) || this.global1.data[130] == 3)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 基 罗 · 格 利 戈 罗 夫</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>Киро Глигоров</color>");
				}
			}
			else if (this.global1.data[130] == 4 && this.global1.data[224] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 格 利 戈 里 耶 · 戈 戈 夫 斯 基</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>Глигорие Гоговски</color>");
				}
			}
			else if (this.global1.data[130] == 4)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 斯 托 扬 · 安 多 夫</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>Стоян Андов</color>");
				}
			}
			else if (this.global1.data[130] == 5)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=purple> 基 罗 · 波 波 夫 斯 基</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=purple>Киро Поповски</color>");
				}
			}
			else if (this.global1.data[130] == 6)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 伊 利 亚 兹 · 哈 利 米</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Илияз Халими</color>");
				}
			}
			else if (this.global1.data[130] == 7)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 斯 托 扬 · 安 多 夫</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Стоян Андов</color>");
				}
			}
			else if (this.global1.data[130] == 8)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 佩 塔 尔 · 戈 舍 夫</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Петар Гошев</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=navy> 基 罗 · 格 利 戈 罗 夫</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=navy>Киро Глигоров</color>");
			}
		}
		if (PlayerPrefs.GetInt("language") == 0)
		{
			text = string.Format("{0}\n{1}", text, " 执 政 党:\n");
		}
		else
		{
			text = string.Format("{0}\n{1}", text, "Правящая партия:\n");
		}
		if (region == 0)
		{
			if (this.global1.data[126] > 0 && this.global1.data[131] >= 1 && ((this.yug1.gameState.yugregions[0].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[0].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[0].owner == 1 && this.global1.data[0] == 51)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 南 共 盟 在 人 民 军 的 基 层 组 织</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Ячейка СКЮ в ЮНА</color>");
				}
			}
			else if (this.global1.data[131] >= 1 && ((this.yug1.gameState.yugregions[0].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[0].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[0].owner == 1 && this.global1.data[0] == 51)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 共 产 主 义 者 联 盟 — 维 护 南 斯 拉 夫 运 动</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СК — ПЮ</color>");
				}
			}
			else if ((this.yug1.gameState.yugregions[0].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[0].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[0].owner == 1 && this.global1.data[0] == 51))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 塞 尔 维 亚 共 产 主 义 者 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СКС</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[0].owner == 0 && this.global1.event_done[1106])
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 斯 洛 文 尼 亚 基 督 教 民 主 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>ХДП</color>");
				}
			}
			else if (this.global1.data[170] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=purple> 南 斯 拉 夫 改 革 力 量 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=purple>СРСЮ</color>");
				}
			}
			else if (this.global1.data[157] == 2)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 斯 洛 文 尼 亚 民 主 反 对 派</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>ДЕМОС</color>");
				}
			}
			else if (this.global1.data[157] == 1 && this.global1.event_done[298])
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 左 翼 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Левая коалиция</color>");
				}
			}
			else if (!this.global1.event_done[289])
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 斯 洛 文 尼 亚 共 产 主 义 者 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>СКС</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=magenta> 斯 洛 文 尼 亚 共 产 主 义 者 联 盟 — 社 会 民 主 党</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=magenta>СКС-ПДО</color>");
			}
		}
		if (region == 1)
		{
			if (this.global1.data[126] > 0 && this.global1.data[131] >= 1 && ((this.yug1.gameState.yugregions[1].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[1].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[1].owner == 1 && this.global1.data[0] == 51)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 南 共 盟 在 人 民 军 的 基 层 组 织</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Ячейка СКЮ в ЮНА</color>");
				}
			}
			else if (this.global1.data[131] >= 1 && ((this.yug1.gameState.yugregions[1].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[1].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[1].owner == 1 && this.global1.data[0] == 51)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 共 产 主 义 者 联 盟 — 维 护 南 斯 拉 夫 运 动</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СК — ПЮ</color>");
				}
			}
			else if ((this.yug1.gameState.yugregions[1].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[1].owner == 3 && this.global1.data[0] == 50))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 克 罗 地 亚 共 产 主 义 者 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СКХ</color>");
				}
			}
			else if (this.global1.data[169] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=purple> 南 斯 拉 夫 改 革 力 量 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=purple>СРСЮ</color>");
				}
			}
			else if (this.global1.data[117] == 2 && this.global1.data[118] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=orange> 库 库 里 库 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=orange>Коалиция Кукурику</color>");
				}
			}
			else if (this.global1.data[117] == 1 && this.global1.data[118] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=magenta> 克 罗 地 亚 共 产 主 义 者 联 盟 — 社 会 民 主 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=magenta>СКХ-ПДП</color>");
				}
			}
			else if (this.global1.data[116] == 1 && this.global1.data[118] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 克 罗 地 亚 民 主 共 同 体</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>ХДС</color>");
				}
			}
			else if (this.global1.data[195] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 克 罗 地 亚 独 立 民 主 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>ХНД</color>");
				}
			}
			else if (this.global1.data[116] == 2 && this.global1.data[118] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 克 罗 地 亚 民 主 共 同 体</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>ХДС</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=maroon> 克 罗 地 亚 共 产 主 义 者 联 盟</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=maroon>СКХ</color>");
			}
		}
		else if (region == 2)
		{
			if (this.global1.data[126] > 0 && this.global1.data[131] >= 1 && ((this.yug1.gameState.yugregions[2].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[2].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[2].owner == 1 && this.global1.data[0] == 51)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 南 共 盟 在 人 民 军 的 基 层 组 织</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Ячейка СКЮ в ЮНА</color>");
				}
			}
			else if (this.global1.data[131] >= 1 && ((this.yug1.gameState.yugregions[2].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[2].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[2].owner == 1 && this.global1.data[0] == 51)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 共 产 主 义 者 联 盟 — 维 护 南 斯 拉 夫 运 动</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СК — ПЮ</color>");
				}
			}
			else if (!this.yug1.gameState.yugcountries[2].is_exist && this.global1.event_done[274])
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 克 罗 地 亚 民 主 共 同 体</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>ХДС</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[2].owner == 1 && !this.global1.event_done[275])
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 克 罗 地 亚 共 产 主 义 者 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>СКХ</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[2].owner == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 塞 族 民 主 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>СДС</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[0].owner == 3 && this.global1.data[0] == 50)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 克 罗 地 亚 共 产 主 义 者 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СКХ</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[0].owner == 8 && this.global1.data[0] == 49)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 塞 族 民 主 党 </color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>СДС</color>");
				}
			}
			else if (this.yug1.gameState.yugcountries[2].is_independent && this.yug1.gameState.yugregions[2].owner == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 克 罗 地 亚 共 产 主 义 者 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>ХДС</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=maroon> 塞 族 民 主 党</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=maroon>СДС</color>");
			}
		}
		else if (region == 3)
		{
			if ((this.yug1.gameState.yugregions[3].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[3].owner == 1 && this.global1.data[0] == 51))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 波 斯 尼 亚 和 黑 塞 哥 维 那 共 产 主 义 者 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СК БиГ</color>");
				}
			}
			else if (this.global1.data[172] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=purple> 南 斯 拉 夫 改 革 力 量 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=purple>СРСЮ</color>");
				}
			}
			else if (this.global1.data[136] == 0 && this.global1.data[138] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=magenta> 波 斯 尼 亚 和 黑 塞 哥 维 那 共 产 主 义 者 联 盟 — 社 会 民 主 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=magenta>СК БиГ-СДП</color>");
				}
			}
			else if (this.global1.data[136] == 1 && this.global1.data[137] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 民 主 行 动 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>ПДД</color>");
				}
			}
			else if (this.global1.data[136] == 1 && this.global1.data[137] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 民 主 行 动 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>ПДД</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=maroon> 波 斯 尼 亚 和 黑 塞 哥 维 那 共 产 主 义 者 联 盟</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=maroon>СК БиГ</color>");
			}
		}
		else if (region == 4)
		{
			if (this.global1.data[126] > 0 && this.global1.data[131] >= 1 && ((this.yug1.gameState.yugregions[4].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[4].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[4].owner == 1 && this.global1.data[0] == 51)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 南 共 盟 在 人 民 军 的 基 层 组 织</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Ячейка СКЮ в ЮНА</color>");
				}
			}
			else if (this.global1.data[131] >= 1 && ((this.yug1.gameState.yugregions[4].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[4].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[4].owner == 1 && this.global1.data[0] == 51)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 共 产 主 义 者 联 盟 — 维 护 南 斯 拉 夫 运 动</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СК — ПЮ</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[4].owner == 3 && !this.yug1.gameState.yugcountries[4].is_independent)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 波 斯 尼 亚 和 黑 塞 哥 维 那 共 产 主 义 者 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>СК БиГ</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[4].owner == 3 && (this.yug1.gameState.yugcountries[5].is_independent || (this.global1.data[136] == 1 && this.global1.data[137] == 0)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 民 主 行 动 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>ПДД</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[4].owner == 3 && this.yug1.gameState.yugcountries[4].is_independent && this.global1.data[136] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 波 斯 尼 亚 和 黑 塞 哥 维 那 共 产 主 义 者 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>СК БиГ</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[4].owner == 3)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 波 斯 尼 亚 和 黑 塞 哥 维 那 克 族 民 主 共 同 体</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>ХДС БиГ</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[0].owner == 8 && this.global1.data[0] == 49)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 波 斯 尼 亚 和 黑 塞 哥 维 那 共 产 主 义 者 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СК БиГ</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=olive> 波 斯 尼 亚 和 黑 塞 哥 维 那 克 族 民 主 共 同 体</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=olive>ХДС БиГ</color>");
			}
		}
		else if (region == 5)
		{
			if (this.global1.data[126] > 0 && this.global1.data[131] >= 1 && ((this.yug1.gameState.yugregions[5].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[5].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[5].owner == 1 && this.global1.data[0] == 51)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 南 共 盟 在 人 民 军 的 基 层 组 织</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Ячейка СКЮ в ЮНА</color>");
				}
			}
			else if (this.global1.data[131] >= 1 && ((this.yug1.gameState.yugregions[5].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[5].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[5].owner == 1 && this.global1.data[0] == 51)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 共 产 主 义 者 联 盟 — 维 护 南 斯 拉 夫 运 动</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СК — ПЮ</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[5].owner == 8 || (!this.yug1.gameState.yugcountries[5].is_independent && this.global1.data[136] == 0))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 波 斯 尼 亚 和 黑 塞 哥 维 那 共 产 主 义 者 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>СК БиГ</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[5].owner == 3 && (this.yug1.gameState.yugcountries[5].is_independent || (this.global1.data[136] == 1 && this.global1.data[137] == 0)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 民 主 行 动 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>ПДД</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[5].owner == 3 && (this.yug1.gameState.yugcountries[5].is_independent || (this.global1.data[136] == 1 && this.global1.data[137] == 1)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 民 主 行 动 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>ПДД</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[5].owner == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 波 斯 尼 亚 和 黑 塞 哥 维 那 克 族 民 主 共 同 体</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>ХДС БиГ</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=olive> 民 主 人 民 联 盟</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=olive>ДНС</color>");
			}
		}
		else if (region == 6)
		{
			if (this.global1.data[126] > 0 && this.global1.data[131] >= 1 && ((this.yug1.gameState.yugregions[6].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[6].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[6].owner == 1 && this.global1.data[0] == 51)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 南 共 盟 在 人 民 军 的 基 层 组 织</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Ячейка СКЮ в ЮНА</color>");
				}
			}
			else if (this.global1.data[131] >= 1 && ((this.yug1.gameState.yugregions[6].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[6].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[6].owner == 1 && this.global1.data[0] == 51)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 共 产 主 义 者 联 盟 — 维 护 南 斯 拉 夫 运 动</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СК — ПЮ</color>");
				}
			}
			else if (((this.yug1.gameState.yugregions[6].owner == 3 && !this.yug1.gameState.yugcountries[6].is_independent) || (this.yug1.gameState.yugregions[6].owner == 3 && this.yug1.gameState.yugcountries[4].is_independent && this.global1.data[136] == 0)) && this.global1.data[136] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 波 斯 尼 亚 和 黑 塞 哥 维 那 共 产 主 义 者 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>СК БиГ</color>");
				}
			}
			else if (((this.yug1.gameState.yugregions[6].owner == 3 && !this.yug1.gameState.yugcountries[6].is_independent) || (this.yug1.gameState.yugregions[6].owner == 3 && this.yug1.gameState.yugcountries[4].is_independent && this.global1.data[136] == 0)) && this.global1.data[136] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 波 斯 尼 亚 和 黑 塞 哥 维 那 共 产 主 义 者 联 盟 — 社 会 民 主 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=magenta>СК БиГ-СДП</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[6].owner == 3 && this.yug1.gameState.yugcountries[6].is_independent && this.global1.data[136] == 1 && this.global1.data[137] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 民 主 行 动 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>ПДД</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[6].owner == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 波 斯 尼 亚 和 黑 塞 哥 维 那 克 族 民 主 共 同 体</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>ХДС БиГ</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=olive> 塞 族 民 主 党</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=olive>СДС</color>");
			}
		}
		if (region == 7)
		{
			if (this.global1.data[126] > 0 && this.global1.data[131] >= 1 && ((this.yug1.gameState.yugregions[7].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[7].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[7].owner == 1 && this.global1.data[0] == 51)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 南 共 盟 在 人 民 军 的 基 层 组 织</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Ячейка СКЮ в ЮНА</color>");
				}
			}
			else if (this.global1.data[131] >= 1 && ((this.yug1.gameState.yugregions[7].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[7].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[7].owner == 1 && this.global1.data[0] == 51)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 共 产 主 义 者 联 盟 — 维 护 南 斯 拉 夫 运 动</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СК — ПЮ</color>");
				}
			}
			else if ((this.yug1.gameState.yugregions[7].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[7].owner == 1 && this.global1.data[0] == 51))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 黑 山 共 产 主 义 者 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СКЧ</color>");
				}
			}
			else if ((this.yug1.gameState.yugregions[7].owner == 8 && this.global1.data[0] == 49) || (this.global1.data[156] == 2 && this.global1.data[21] >= 1991))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 黑 山 社 会 主 义 者 民 主 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>ДПС</color>");
				}
			}
			else if (this.global1.event_done[383] && this.yug1.gameState.yugcountries[7].is_independent && this.yug1.gameState.yugregions[7].owner == 7)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 黑 山 民 主 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>ДП</color>");
				}
			}
			else if (this.global1.data[156] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=purple> 南 斯 拉 夫 改 革 力 量 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=purple>СРСЮ</color>");
				}
			}
			else if (this.global1.data[156] == 3)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive>\" 反 米 洛 舍 维 奇\" 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Коалиция \"Антимилошевич\"</color>");
				}
			}
			else if (this.global1.data[156] == 4)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy>\" 反 米 洛 舍 维 奇\" 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>Коалиция \"Антимилошевич\"</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=magenta> 黑 山 共 产 主 义 者 联 盟</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=magenta>СКЧ</color>");
			}
		}
		if (region == 8)
		{
			if ((this.yug1.gameState.yugregions[8].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[8].owner == 1 && this.global1.data[0] == 51))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=purple> 塞 尔 维 亚 共 产 主 义 者 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СКС</color>");
				}
			}
			else if (this.global1.data[171] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=purple> 南 斯 拉 夫 改 革 力 量 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=purple>СРСЮ</color>");
				}
			}
			else if (this.global1.party_name[0] == "СПС")
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=magenta> 塞 尔 维 亚 社 会 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=magenta>СПС</color>");
				}
			}
			else if (this.global1.party_name[0] == "СДПС")
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=magenta> 塞 尔 维 亚 社 会 民 主 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=magenta>СДПС</color>");
				}
			}
			else if ((this.global1.data[154] == 2 || this.global1.data[154] == 3) && (this.global1.data[148] == 1 || this.global1.data[148] == 2))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=magenta>塞 尔 维 亚 复 兴 运 动 和 南 斯 拉 夫 左 翼 的 联 合</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=magenta>Коалиция СДО и ЮЛ</color>");
				}
			}
			else if (this.global1.data[150] == 0 && this.global1.data[148] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=magenta> 塞 尔 维 亚 共 产 主 义 者 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>СКС</color>");
				}
			}
			else if (this.global1.data[150] == 0 && this.global1.data[148] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 塞 尔 维 亚 复 兴 运 动</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>СДО</color>");
				}
			}
			else if (this.global1.data[150] == 1 && this.global1.data[148] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 塞 尔 维 亚 复 兴 运 动</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>СДО</color>");
				}
			}
			else if (this.global1.data[0] == 49 && this.global1.data[148] == 2)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 塞 尔 维 亚 共 产 主 义 者 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>СКС</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=maroon> 塞 尔 维 亚 社 会 党</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=maroon>СПС</color>");
			}
		}
		else if (region == 9)
		{
			if (this.global1.data[126] > 0 && this.global1.data[131] >= 1 && ((this.yug1.gameState.yugregions[9].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[9].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[9].owner == 1 && this.global1.data[0] == 51)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 南 共 盟 在 人 民 军 的 基 层 组 织</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Ячейка СКЮ в ЮНА</color>");
				}
			}
			else if (this.global1.data[131] >= 1 && ((this.yug1.gameState.yugregions[9].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[9].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[9].owner == 1 && this.global1.data[0] == 51)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 共 产 主 义 者 联 盟 — 维 护 南 斯 拉 夫 运 动</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СК — ПЮ</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[9].owner == 9 && (this.yug1.gameState.yugcountries[9].name == "Румынская Воеводина" || this.yug1.gameState.yugcountries[9].name == " 罗 马 尼 亚 属 伏 伊 伏 丁 那"))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 罗 马 尼 亚 友 谊 运 动</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Ассоциация дружбы с Румынией</color>");
				}
			}
			else if ((this.global1.data[148] == 2 && this.global1.data[150] == 1 && ((this.global1.data[20] >= 7 && this.global1.data[21] == 1990) || this.global1.data[21] >= 1991) && this.global1.data[0] != 49) || (this.global1.event_done[341] && (this.global1.party_name[0] == "СПС" || this.global1.party_name[0] == "SPS")))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 塞 尔 维 亚 社 会 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СПС</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[9].owner == 8 && !this.yug1.gameState.yugcountries[4].is_independent && this.global1.data[179] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 伏 伊 伏 丁 那 共 产 主 义 者 联 \u200b\u200b盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СКВ</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[9].owner == 8 && !this.yug1.gameState.yugcountries[4].is_independent && this.global1.data[179] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 伏 伊 伏 丁 那 共 产 主 义 者 联 \u200b\u200b盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>СКВ</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[9].owner == 9 && this.global1.data[149] == 2)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=magenta> 泛 左 翼 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=magenta>Широкая левая коалиция</color>");
				}
			}
			else if ((this.yug1.gameState.yugregions[9].owner == 9 && (this.global1.event_done[1106] || this.global1.event_done[39])) || (this.yug1.gameState.yugregions[9].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[9].owner == 1 && this.global1.data[0] == 51))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 伏 伊 伏 丁 那 社 会 民 主 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>ЛСДВ</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[9].owner == 9 && this.global1.event_done[353])
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 伏 伊 伏 丁 那 匈 牙 利 人 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>ДЗВМ</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=maroon> 伏 伊 伏 丁 那 共 产 主 义 者 联 \u200b\u200b盟</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=maroon>СКВ</color>");
			}
		}
		else if (region == 10)
		{
			if (this.global1.data[126] > 0 && this.global1.data[131] >= 1 && ((this.yug1.gameState.yugregions[10].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[10].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[10].owner == 1 && this.global1.data[0] == 51)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 南 共 盟 在 人 民 军 的 基 层 组 织</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Ячейка СКЮ в ЮНА</color>");
				}
			}
			else if (this.global1.data[131] >= 1 && ((this.yug1.gameState.yugregions[10].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[10].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[10].owner == 1 && this.global1.data[0] == 51)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 共 产 主 义 者 联 盟 — 维 护 南 斯 拉 夫 运 动</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СК — ПЮ</color>");
				}
			}
			else if ((this.yug1.gameState.yugregions[10].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[10].owner == 1 && this.global1.data[0] == 51))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 科 索 沃 共 产 主 义 者 联 \u200b\u200b盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СКК</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[10].owner == 10 && this.global1.event_done[1103])
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 科 索 沃 民 主 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>ДПК</color>");
				}
			}
			else if (this.global1.data[155] == 0 || this.global1.data[176] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=magenta> 科 索 沃 共 产 主 义 者 联 \u200b\u200b盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=magenta>СКК</color>");
				}
			}
			else if (this.global1.data[155] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 科 索 沃 共 产 主 义 者 联 \u200b\u200b盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>СКК</color>");
				}
			}
			else if ((this.global1.data[155] == 2 && this.global1.data[148] == 2 && this.global1.data[150] == 1 && ((this.global1.data[20] >= 7 && this.global1.data[21] == 1990) || this.global1.data[21] >= 1991) && this.global1.data[0] != 49) || (this.global1.event_done[341] && (this.global1.party_name[0] == "СПС" || this.global1.party_name[0] == " 塞 尔 维 亚 社 会 党")))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 塞 尔 维 亚 社 会 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СПС</color>");
				}
			}
			else if (this.global1.event_done[341] && (this.global1.party_name[0] == "СДПС" || this.global1.party_name[0] == " 塞 尔 维 亚 社 会 民 主 党"))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 塞 尔 维 亚 社 会 民 主 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СДПС</color>");
				}
			}
			else if (this.global1.data[155] == 2)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 科 索 沃 共 产 主 义 者 联 \u200b\u200b盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СКК</color>");
				}
			}
			else if (this.global1.data[176] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=magenta> 科 索 沃 共 产 主 义 者 联 \u200b\u200b盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=magenta>СКК</color>");
				}
			}
			else if (this.global1.data[176] == 2 && this.global1.data[183] == 0)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 科 索 沃 共 产 主 义 者 联 \u200b\u200b盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>CКК</color>");
				}
			}
			else if (this.global1.data[176] == 2 && this.global1.data[183] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 科 索 沃 民 主 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>ДЛК</color>");
				}
			}
			else if (this.global1.data[176] == 3)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 科 索 沃 共 产 主 义 者 联 \u200b\u200b盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>СКК</color>");
				}
			}
			else if (this.global1.data[176] == 4)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 科 索 沃 民 主 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>ДЛК</color>");
				}
			}
			else if (this.global1.data[176] == 5)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 科 索 沃 国 防 委 员 会 中 的 南 斯 拉 夫 派</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Югославское крыло НДК</color>");
				}
			}
			else if (this.global1.data[176] == 6 && this.yug1.gameState.yugregions[10].owner == 8)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 科 索 沃 共 产 主 义 者 联 \u200b\u200b盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>СКК</color>");
				}
			}
			else if (this.global1.data[176] == 7)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 科 索 沃 国 防 委 员 会 中 的 霍 查 派</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>Ходжаистское крыло НДК</color>");
				}
			}
			else if (this.global1.data[176] == 8)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 科 索 沃 国 防 委 员 会 中 的 阿 尔 巴 尼 亚 派</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>Албанское крыло НДК</color>");
				}
			}
			else if (this.global1.data[176] == 9)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=purple> 南 斯 拉 夫 改 革 力 量 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=purple>СРСЮ</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=navy> 科 索 沃 民 主 党</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=navy>ДПК</color>");
			}
		}
		else if (region == 11)
		{
			if (this.global1.data[126] > 0 && this.global1.data[131] >= 1 && ((this.yug1.gameState.yugregions[11].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[11].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[11].owner == 1 && this.global1.data[0] == 51)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 南 共 盟 在 人 民 军 的 基 层 组 织</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Ячейка СКЮ в ЮНА</color>");
				}
			}
			else if (this.global1.data[131] >= 1 && ((this.yug1.gameState.yugregions[11].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[11].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[11].owner == 1 && this.global1.data[0] == 51)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 共 产 主 义 者 联 盟 — 维 护 南 斯 拉 夫 运 动</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СК — ПЮ</color>");
				}
			}
			else if ((this.yug1.gameState.yugregions[11].owner == 8 && this.global1.data[0] == 49) || (this.yug1.gameState.yugregions[11].owner == 3 && this.global1.data[0] == 50) || (this.yug1.gameState.yugregions[11].owner == 1 && this.global1.data[0] == 51))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 马 其 顿 共 产 主 义 者 联 \u200b\u200b盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>СКМ</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[11].owner == 11 && (this.global1.event_done[313] || (this.global1.event_done[361] && this.yug1.gameState.yugcountries[11].is_independent)))
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 与 保 加 利 亚</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Организация дружбы с Болгарией</color>");
				}
			}
			else if (this.yug1.gameState.yugregions[11].owner == 11 && this.global1.event_done[315] && this.yug1.gameState.yugcountries[11].is_independent)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=grey> 由 民 主 繁 荣 党 领 导 的 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=grey>Коалиция во главе с ПДП</color>");
				}
			}
			else if (this.global1.data[130] == 0 || this.global1.data[130] == 9)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 马 其 顿 共 产 主 义 者 联 \u200b\u200b盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>СКМ</color>");
				}
			}
			else if (this.global1.data[130] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=magenta> 马 其 顿 共 产 主 义 者 联 \u200b\u200b盟 — 民 主 繁 荣 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=magenta>СКМ-ПДП</color>");
				}
			}
			else if ((this.global1.data[130] == 2 && this.yug1.gameState.yugcountries[11].is_independent) || this.global1.data[130] == 3)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=navy> 马 其 顿 社 会 民 主 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=navy>СДСМ</color>");
				}
			}
			else if (this.global1.data[130] == 4 && this.global1.data[224] == 1)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 马 其 顿 共 产 主 义 者 联 \u200b\u200b盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>СКМ</color>");
				}
			}
			else if (this.global1.data[130] == 4)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=maroon> 马 其 顿 共 产 主 义 者 联 \u200b\u200b盟 — 民 主 繁 荣 党</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=maroon>СКМ-ПДП</color>");
				}
			}
			else if (this.global1.data[130] == 5)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=purple> 南 斯 拉 夫 改 革 力 量 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=purple>СРСЮ</color>");
				}
			}
			else if (this.global1.data[130] == 6)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 由 民 主 繁 荣 党 领 导 的 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Коалиция во главе с ПДП</color>");
				}
			}
			else if (this.global1.data[130] == 7)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 马 其 顿 改 革 力 量 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>СРСМ</color>");
				}
			}
			else if (this.global1.data[130] == 8)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					text = string.Format("{0} {1}", text, "<color=olive> 由 马 其 顿 共 产 主 义 者 联 \u200b\u200b盟 — 马 其 顿 民 族 统 一 民 主 党 领 导 的 联 盟</color>");
				}
				else
				{
					text = string.Format("{0} {1}", text, "<color=olive>Коалиция СКМ-ФМНЕ</color>");
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				text = string.Format("{0} {1}", text, "<color=navy> 马 其 顿 社 会 民 主 联 盟</color>");
			}
			else
			{
				text = string.Format("{0} {1}", text, "<color=navy>СДСМ</color>");
			}
		}
		return text;
	}

	// Token: 0x040001E4 RID: 484
	public bool is_separate = true;

	// Token: 0x040001E5 RID: 485
	public TextMesh description;

	// Token: 0x040001E6 RID: 486
	public TextMesh requirements;

	// Token: 0x040001E7 RID: 487
	public TextMesh leaderShow;

	// Token: 0x040001E8 RID: 488
	public Yugoglobal yug1;

	// Token: 0x040001E9 RID: 489
	private GlobalScript global1;

	// Token: 0x040001EA RID: 490
	public GameObject[] countries = new GameObject[12];

	// Token: 0x040001EB RID: 491
	public GameObject[] buttons = new GameObject[6];

	// Token: 0x040001EC RID: 492
	private int country = -1;

	// Token: 0x040001ED RID: 493
	private int region = -1;

	// Token: 0x040001EE RID: 494
	private Color a;
}
