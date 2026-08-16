using System;
using UnityEngine;

// Token: 0x0200005B RID: 91
public class sciencescript : MonoBehaviour
{
	// Token: 0x060001C3 RID: 451 RVA: 0x001FA078 File Offset: 0x001F8278
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		if (this.this_num == 9)
		{
			this.dates[0].text = this.global1.dates[0];
			this.dates[1].text = this.global1.dates[1];
			this.dates[2].text = this.global1.dates[2];
		}
		if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
		{
			this.yug1 = GameObject.Find("Yugoglobal(Clone)").GetComponent<Yugoglobal>();
			this.now_icon.sprite = this.new_icon;
		}
		else if ((this.global1.data[0] == 12 || this.global1.data[0] == 18) && this.this_num == 9)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
		if (!this.global1.science[this.this_num])
		{
			for (int i = 0; i < this.global1.regions.Length; i++)
			{
				for (int j = 0; j < 15; j++)
				{
					if ((this.global1.regions[i].buildings[j].type == 9 || this.global1.regions[i].buildings[j].type == 3 || this.global1.regions[i].buildings[j].type == 14) && this.global1.regions[i].buildings[j].is_builded && this.global1.regions[i].buildings[j].is_working)
					{
						this.nii++;
					}
				}
			}
			if ((this.global1.data[12] == 5 && this.global1.data[0] == 4) || (this.global1.data[12] == 5 && this.global1.data[0] == 12) || (this.global1.data[13] == 8 && this.global1.data[0] == 20) || (this.global1.data[13] == 9 && this.global1.data[0] == 18) || (this.global1.data[12] == 4 && this.global1.data[0] == 10))
			{
				this.nii++;
			}
			if (this.global1.allcountries[38].Money)
			{
				this.nii++;
			}
			this.itogo_izuchaem = 0;
			for (int k = 0; k < this.global1.science_time.Length; k++)
			{
				if (this.global1.science_time[k] > 0 && this.global1.science_time[k] < 360)
				{
					this.itogo_izuchaem++;
				}
			}
			this.itogo_izuchaem--;
			for (int l = 0; l < this.condition.Length; l++)
			{
				if (!this.global1.science[l] && this.global1.science_time[l] > 0 && this.global1.science_time[l] < 360)
				{
					if (this.nii - this.itogo_izuchaem > 0)
					{
						this.condition[l].text = ((360 - this.global1.science_time[l]) / (this.nii - this.itogo_izuchaem)).ToString();
					}
					else
					{
						this.condition[l].text = "-";
					}
					if (PlayerPrefs.GetInt("language") == 0)
					{
						TextMesh textMesh = this.condition[l];
						textMesh.text += "\n 天";
					}
					else
					{
						TextMesh textMesh2 = this.condition[l];
						textMesh2.text += "\nдней";
					}
				}
			}
			this.global1.issleduetsya = 0;
			for (int m = 0; m < this.global1.science_time.Length; m++)
			{
				if (!this.global1.science[m] && this.global1.science_time[m] > 0 && this.global1.science_time[m] < 360)
				{
					this.global1.issleduetsya++;
				}
			}
		}
		else
		{
			for (int n = 0; n < this.condition.Length; n++)
			{
				if (this.global1.science[n])
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.condition[n].text = " 完 成";
					}
					else
					{
						this.condition[n].text = "Введён";
					}
				}
			}
		}
		if (this.this_num != 9 && this.global1.science_time[this.this_num] <= 0 && !this.global1.science[this.this_num])
		{
			base.GetComponent<SpriteRenderer>().sprite = this.off;
		}
		else if (this.this_num != 9 && (this.global1.science_time[this.this_num] > 0 || this.global1.science[this.this_num]))
		{
			base.GetComponent<SpriteRenderer>().sprite = this.on;
			if (this.global1.science_time[this.this_num] > 0 && !this.global1.science[this.this_num])
			{
				base.GetComponent<OkoshkoScript>().text = "Отменить";
				base.GetComponent<OkoshkoScript>().text_en = " 取 消";
			}
			else
			{
				base.GetComponent<OkoshkoScript>().text = "Готово";
				base.GetComponent<OkoshkoScript>().text_en = " 完 成";
			}
		}
		else if (this.this_num == 9 && (this.global1.science_time[this.this_num] > 0 || this.global1.science[this.this_num]) && this.global1.povod)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.on;
			if (this.global1.science_time[this.this_num] > 0 && !this.global1.science[this.this_num])
			{
				base.GetComponent<OkoshkoScript>().text = "Отменить";
				base.GetComponent<OkoshkoScript>().text_en = " 取 消";
			}
			else
			{
				base.GetComponent<OkoshkoScript>().text = "Готово";
				base.GetComponent<OkoshkoScript>().text_en = " 完 成";
			}
		}
		else if (this.this_num != 9 && this.global1.science_time[this.this_num] < 1)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.stop;
		}
		else if (this.this_num == 9 && (this.global1.data[0] < 49 || this.global1.data[0] > 51) && !this.global1.povod && !this.global1.science[this.this_num] && this.global1.science_time[this.this_num] < 1)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.stop;
		}
		else if (this.this_num == 9 && this.global1.data[0] >= 49 && this.global1.data[0] <= 51 && (!this.global1.science[2] || !this.global1.science[5] || !this.global1.science[8]))
		{
			base.GetComponent<SpriteRenderer>().sprite = this.stop;
		}
		else if (this.this_num == 9 && this.global1.science_time[this.this_num] <= 0 && !this.global1.science[this.this_num])
		{
			base.GetComponent<SpriteRenderer>().sprite = this.off;
		}
		if (this.global1.science_time[this.this_num] > 0 && !this.global1.science[this.this_num])
		{
			this.progress.GetComponent<SpriteRenderer>().material.SetFloat("_M", (float)this.global1.science_time[this.this_num] / 360f);
			return;
		}
		if (this.global1.science[this.this_num])
		{
			this.progress.GetComponent<SpriteRenderer>().material.SetFloat("_M", 1f);
			return;
		}
		this.progress.GetComponent<SpriteRenderer>().material.SetFloat("_M", 0f);
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x001FA938 File Offset: 0x001F8B38
	private void OnMouseDown()
	{
		if (this.global1.science_time[this.this_num] <= 0 && !this.global1.science[this.this_num])
		{
			this.global1.neizucheno = false;
			if (this.this_num != 9)
			{
				if (this.this_num < 3 && this.this_num > 0)
				{
					if (this.global1.science[this.this_num - 1])
					{
						if (this.global1.data[21] < this.this_year)
						{
							this.global1.data[8] -= (this.this_year - this.global1.data[21]) * 20;
						}
						else
						{
							this.global1.data[8] -= 10;
						}
						this.global1.science_time[this.this_num] = 1;
						base.GetComponent<SpriteRenderer>().sprite = this.on;
					}
				}
				else if (this.this_num < 6 && this.this_num > 3)
				{
					if (this.global1.science[this.this_num - 1])
					{
						if (this.global1.data[21] < this.this_year)
						{
							this.global1.data[8] -= (this.this_year - this.global1.data[21]) * 20;
						}
						else
						{
							this.global1.data[8] -= 10;
						}
						this.global1.science_time[this.this_num] = 1;
						base.GetComponent<SpriteRenderer>().sprite = this.on;
					}
				}
				else if (this.this_num < 9 && this.this_num > 6)
				{
					if (this.global1.science[this.this_num - 1])
					{
						if (this.global1.data[21] < this.this_year)
						{
							this.global1.data[8] -= (this.this_year - this.global1.data[21]) * 20;
						}
						else
						{
							this.global1.data[8] -= 10;
						}
						this.global1.science_time[this.this_num] = 1;
						base.GetComponent<SpriteRenderer>().sprite = this.on;
					}
				}
				else if (this.this_num == 0 || this.this_num == 3 || this.this_num == 6)
				{
					if (this.global1.data[21] < this.this_year)
					{
						this.global1.data[8] -= (this.this_year - this.global1.data[21]) * 20;
					}
					else
					{
						this.global1.data[8] -= 10;
					}
					this.global1.science_time[this.this_num] = 1;
					base.GetComponent<SpriteRenderer>().sprite = this.on;
				}
			}
			else if ((this.this_num == 9 && this.global1.povod) || (this.this_num == 9 && this.global1.data[0] >= 49 && this.global1.data[0] <= 51 && this.global1.science[2] && this.global1.science[5] && this.global1.science[8]))
			{
				bool flag = false;
				for (int i = 0; i < 15; i++)
				{
					if (this.global1.regions[0].buildings[i].type == 7 && this.global1.regions[0].buildings[i].is_builded && this.global1.regions[0].buildings[i].is_working)
					{
						flag = true;
					}
					else if (this.global1.regions[1].buildings[i].type == 7 && this.global1.regions[1].buildings[i].is_builded && this.global1.regions[1].buildings[i].is_working)
					{
						flag = true;
					}
					else if (this.global1.regions[2].buildings[i].type == 7 && this.global1.regions[2].buildings[i].is_builded && this.global1.regions[2].buildings[i].is_working)
					{
						flag = true;
					}
					else if (this.global1.regions[3].buildings[i].type == 7 && this.global1.regions[3].buildings[i].is_builded && this.global1.regions[3].buildings[i].is_working)
					{
						flag = true;
					}
					else if (this.global1.regions[4].buildings[i].type == 7 && this.global1.regions[4].buildings[i].is_builded && this.global1.regions[4].buildings[i].is_working)
					{
						flag = true;
					}
				}
				if (flag || (this.global1.data[0] >= 49 && this.global1.data[0] <= 51 && this.global1.science[2] && this.global1.science[5] && this.global1.science[8]))
				{
					if (this.global1.data[21] < this.this_year)
					{
						this.global1.data[8] -= (this.this_year - this.global1.data[21]) * 20;
					}
					else
					{
						this.global1.data[8] -= 10;
					}
					this.global1.science_time[this.this_num] = 1;
					base.GetComponent<SpriteRenderer>().sprite = this.on;
				}
				else
				{
					base.GetComponent<SpriteRenderer>().sprite = this.stop;
				}
			}
			this.itogo_izuchaem = -1;
			for (int j = 0; j < this.global1.science_time.Length; j++)
			{
				if (this.global1.science_time[j] > 0 && this.global1.science_time[j] < 360)
				{
					this.itogo_izuchaem++;
				}
			}
			for (int k = 0; k < this.condition.Length; k++)
			{
				if (!this.global1.science[k] && this.global1.science_time[k] > 0 && this.global1.science_time[k] < 360)
				{
					if (this.nii - this.itogo_izuchaem > 0)
					{
						this.condition[k].text = ((360 - this.global1.science_time[k]) / (this.nii - this.itogo_izuchaem)).ToString();
					}
					else
					{
						this.condition[k].text = "-";
					}
					if (PlayerPrefs.GetInt("language") == 0)
					{
						TextMesh textMesh = this.condition[k];
						textMesh.text += "\n 天";
					}
					else
					{
						TextMesh textMesh2 = this.condition[k];
						textMesh2.text += "\nдней";
					}
				}
			}
			if (this.global1.science_time[this.this_num] > 0 && !this.global1.science[this.this_num])
			{
				this.progress.GetComponent<SpriteRenderer>().material.SetFloat("_M", (float)this.global1.science_time[this.this_num] / 360f);
			}
			else if (this.global1.science[this.this_num])
			{
				this.progress.GetComponent<SpriteRenderer>().material.SetFloat("_M", 1f);
			}
			else
			{
				this.progress.GetComponent<SpriteRenderer>().material.SetFloat("_M", 0f);
			}
			this.global1.issleduetsya = 0;
			for (int l = 0; l < this.global1.science_time.Length; l++)
			{
				if (!this.global1.science[l] && this.global1.science_time[l] > 0 && this.global1.science_time[l] < 360)
				{
					this.global1.issleduetsya++;
				}
			}
			if (this.global1.science_time[this.this_num] > 0 && !this.global1.science[this.this_num])
			{
				base.GetComponent<OkoshkoScript>().text = "Отменить";
				base.GetComponent<OkoshkoScript>().text_en = " 取 消";
				return;
			}
		}
		else if (this.global1.science_time[this.this_num] > 0 && !this.global1.science[this.this_num])
		{
			if (this.global1.science_time[this.this_num] < 2)
			{
				this.global1.data[8] += 10;
			}
			this.global1.science_time[this.this_num] = 0;
			this.global1.science[this.this_num] = false;
			base.GetComponent<SpriteRenderer>().sprite = this.off;
			base.GetComponent<OkoshkoScript>().text = "Начать";
			base.GetComponent<OkoshkoScript>().text_en = " 开 始";
			this.itogo_izuchaem = -1;
			for (int m = 0; m < this.global1.science_time.Length; m++)
			{
				if (this.global1.science_time[m] > 0 && this.global1.science_time[m] < 360)
				{
					this.itogo_izuchaem++;
				}
			}
			for (int n = 0; n < this.condition.Length; n++)
			{
				if (!this.global1.science[n] && this.global1.science_time[n] > 0 && this.global1.science_time[n] < 360)
				{
					if (this.nii - this.itogo_izuchaem > 0)
					{
						this.condition[n].text = ((360 - this.global1.science_time[n]) / (this.nii - this.itogo_izuchaem)).ToString();
					}
					else
					{
						this.condition[n].text = "-";
					}
					if (PlayerPrefs.GetInt("language") == 0)
					{
						TextMesh textMesh3 = this.condition[n];
						textMesh3.text += "\n 天";
					}
					else
					{
						TextMesh textMesh4 = this.condition[n];
						textMesh4.text += "\nдней";
					}
				}
				else
				{
					this.condition[n].text = "";
				}
			}
			if (this.global1.science_time[this.this_num] > 0 && !this.global1.science[this.this_num])
			{
				this.progress.GetComponent<SpriteRenderer>().material.SetFloat("_M", (float)this.global1.science_time[this.this_num] / 360f);
			}
			else if (this.global1.science[this.this_num])
			{
				this.progress.GetComponent<SpriteRenderer>().material.SetFloat("_M", 1f);
			}
			else
			{
				this.progress.GetComponent<SpriteRenderer>().material.SetFloat("_M", 0f);
			}
			this.global1.issleduetsya = 0;
			for (int num = 0; num < this.global1.science_time.Length; num++)
			{
				if (!this.global1.science[num] && this.global1.science_time[num] > 0 && this.global1.science_time[num] < 360)
				{
					this.global1.issleduetsya++;
				}
			}
		}
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x001FB594 File Offset: 0x001F9794
	private void OnMouseEnter()
	{
		if (this.this_num == 9 && (this.global1.data[0] < 49 || this.global1.data[0] > 51) && !this.global1.povod && !this.global1.science[this.this_num] && this.global1.science_time[this.this_num] < 1)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.stop;
		}
		else if (this.this_num == 9 && this.global1.data[0] >= 49 && this.global1.data[0] <= 51 && (!this.global1.science[2] || !this.global1.science[5] || !this.global1.science[8]))
		{
			base.GetComponent<SpriteRenderer>().sprite = this.stop;
		}
		else if (this.global1.science_time[this.this_num] <= 0 && !this.global1.science[this.this_num])
		{
			base.GetComponent<SpriteRenderer>().sprite = this.on;
		}
		else if (this.global1.science_time[this.this_num] > 0 && !this.global1.science[this.this_num])
		{
			base.GetComponent<SpriteRenderer>().sprite = this.off;
		}
		if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
		{
			this.Name.text = this.yug1.science_text[this.this_num];
			this.text_fake = string.Format("{0}", this.yug1.science_text[23 + 2 * (this.this_num - 1)]);
			this.text_fake += string.Format("|{0}", this.yug1.science_text[24 + 2 * (this.this_num - 1)]);
			this.text_fake += string.Format("|{0} {1}", this.yug1.science_text[10], this.yug1.science_text[11 + this.this_num]);
		}
		else if (PlayerPrefs.GetInt("language") == 0)
		{
			if (this.global1.data[0] == 10 || this.global1.data[0] == 12 || this.global1.data[0] == 18 || this.global1.data[0] == 32)
			{
				if (this.this_num == 0)
				{
					if (this.global1.data[216] > 49)
					{
						this.Name.text = "Promotion of civic awareness";
					}
					else
					{
						this.Name.text = "Development of militia reform";
					}
					this.text_fake = "<color=red>Influence on (weekly):</color> Westalgia -0.2, Support of the people +0.2, Standard of living +0.1";
					if (this.global1.data[216] > 49)
					{
						this.text_fake += "\n<color=red>Description:</color> Modern realities force us to include in propaganda elements related to encouraging citizens to be conscious in the search for enemies inside our country.";
					}
					else
					{
						this.text_fake += "\n<color=red>Description:</color> Modern realities force us to reform the security agencies in order to once and for all deal with crime in our country. ";
					}
				}
				else if (this.this_num == 1)
				{
					this.Name.text = "Reinforcement of\nthe Ministry of state security";
					this.text_fake = "\n\n<color=red>Influence on (weekly):</color> Unity of the party +0.2, Agent networks +0.2, Westalgia -0.2";
					this.text_fake += "\n<color=red>Description:</color> The world is on the threshold of global changes, the internal enemies of the Motherland and the \"fifth column\" can not wait to make their dastardly blow to our statehood. Let's not let them do it! ";
				}
				else if (this.this_num == 2)
				{
					if (this.global1.data[216] > 49)
					{
						this.Name.text = "The development of agents behind the Green Wall";
					}
					else
					{
						this.Name.text = "Advancement of foreign Agent networks";
					}
					if (this.global1.data[216] > 49)
					{
						this.text_fake = "<color=red>Influence on (weekly):</color> +0.4 to Unity of the party";
					}
					else
					{
						this.text_fake = "<color=red>Influence on (weekly):</color> +0.4 to Support of the USSR, +0.4 to Unity of the party, -0.3 to NATO invasion";
					}
					if (this.global1.data[216] > 49)
					{
						this.text_fake += "\n<color=red>Description:</color>The enemies of progress continue to hide in the impassable areas of our country, and no one can be trusted anymore! It is necessary to strengthen the influence of our agent networks in the detachments of these savages in order to protect us from the vile blow of ill-wishers.";
					}
					else
					{
						this.text_fake += "\n<color=red>Description:</color> Enemies surround our country everywhere, and no one can be trusted! It is necessary to strengthen the influence of our intelligence networks abroad to protect us from the dastardly blow of detractors. ";
					}
				}
				else if (this.this_num == 3)
				{
					this.Name.text = "Construction of industry";
					this.text_fake = "<color=red>Influence on (weekly):</color> Budget +0.2, Standard of living +0.2";
					if (this.global1.data[216] < 50)
					{
						this.text_fake += "\n<color=red>Influence on (once):</color> You can build common factories.";
					}
					if (this.global1.data[216] > 49)
					{
						this.text_fake += "\n<color=red>Description:</color> Despite all our social successes, our country still has a lot to strive for in terms of economic development, so increased industrial construction will not be superfluous for us.";
					}
					else
					{
						this.text_fake += "\n<color=red>Description:</color> Despite all our social successes, our country still continues to lag behind the advanced states in terms of economy, so the strengthened construction of industry will not be superfluous for us. ";
					}
				}
				else if (this.this_num == 4)
				{
					if (this.global1.data[216] > 49)
					{
						this.Name.text = "The course on technologization";
					}
					else
					{
						this.Name.text = "The course on industrialization";
					}
					this.text_fake = "<color=red>Influence on (weekly):</color> +0.1 to Unity of the people, +0.1 to Standard of living";
					this.text_fake += "\n<color=red>Influence on (once):</color> -1 need for import; 1 new factory";
					if (this.global1.data[216] > 49)
					{
						this.text_fake += "\n<color=red>Description:</color> The course towards the introduction of the industry is what our country needs, aspiring to the stars! ";
					}
					else
					{
						this.text_fake += "\n<color=red>Description:</color> The course on the introduction of the industry - that's what our country needs, we will overcome the backlog of developed countries!";
					}
				}
				else if (this.this_num == 5)
				{
					if (this.global1.data[216] > 49)
					{
						this.Name.text = "A new type of society";
					}
					else
					{
						this.Name.text = "Industrial society";
					}
					this.text_fake = "<color=red>Influence on (weekly):</color> Budget +0.2, Standard of living +0.3, Sovereignty";
					this.text_fake += "\n<color=red>Influence on (once):</color> -2 need for import; You can built Factories of electronics";
					if (this.global1.data[216] > 49)
					{
						this.text_fake += "\n<color=red>Description:</color> The efforts were not in vain, and now we can say with confidence that our country has finally been able to reject old prejudices and create a new type of number!";
					}
					else
					{
						this.text_fake += "\n<color=red>Description:</color> The efforts were not in vain, and now we can say with confidence that our country has finally entered the list of industrialized ones. Forward, to a distant and bright future!";
					}
				}
				else if (this.this_num == 6)
				{
					this.Name.text = "Continue agrarian reform";
					this.text_fake = "<color=red>Influence on (weekly):</color> Standard of living +0.2, Unity of the party +0.2, Sovereignty + 0.1";
					this.text_fake += "\n<color=red>Influence on (once):</color> You can bult farms.";
					if (this.global1.data[216] > 49)
					{
						this.text_fake += "\n<color=red>Description:</color> Our agriculture continues to be underdeveloped and poorly automated, so the continuation of agricultural reform should put an end to the agrarian issue forever.";
					}
					else
					{
						this.text_fake += "\n<color=red>Description:</color> Our agriculture continues to remain unprofitable and poorly mechanized, so the continuation of agricultural reform should forever end the agrarian question.";
					}
				}
				else if (this.this_num == 7)
				{
					this.Name.text = "Agricultural development";
					this.text_fake = "<color=red>Influence on (weekly):</color> Support of the people + 0.1, Sovereignty +0.2";
					this.text_fake += "\n<color=red>Influence on (once):</color> -1 need for import; 1 new farm";
					if (this.global1.data[216] > 49)
					{
						this.text_fake += "\n<color=red>Description:</color> Thanks to advances in the gene industry, it has become possible to saturate all numbers with the necessary amount of provisions. By introducing these achievements into the economy, hunger will be completely defeated!";
					}
					else
					{
						this.text_fake += "\n<color=red>Description:</color> In the West, the influence of large agricultural agro-holdings, which are much more productive than individual farms, is growing stronger. Perhaps we should borrow their experience and begin enlargement in agriculture? ";
					}
				}
				else if (this.this_num == 8)
				{
					if (this.global1.data[216] > 49)
					{
						this.Name.text = "Automation implementation";
					}
					else
					{
						this.Name.text = "The introduction of mechanization";
					}
					this.text_fake = "<color=red>Influence on (weekly):</color> Westalgia : -0.1, Sovereignty +0.1, Standard of living + 0.2";
					this.text_fake += "\n<color=red>Influence on (once):</color>\n-2 need for import";
					if (this.global1.data[216] > 49)
					{
						this.text_fake += "\n<color=red>Description:</color> Some number-scientists propose to put forward a new plan for the development of agriculture, to fully automate the cultivation of products without human intervention, thereby achieving the final stabilization of agricultural output.";
					}
					else
					{
						this.text_fake += "\n<color=red>Description:</color> World has long ago abandoned obsolete farming methods in favor of more productive tractors and other agro-machines, why not join this trend?";
					}
				}
				else if (this.this_num == 9)
				{
					if (this.global1.data[216] > 49)
					{
						this.Name.text = "Development of the \"ITEGRAL\"";
					}
					else
					{
						this.Name.text = "Study of the nuclear weapons project";
					}
					this.text_fake = "<color=red>Requires:</color> There are blueprints and technology and Nuclear Test Site\n";
					if (this.global1.data[216] > 49)
					{
						this.text_fake += "<color=red>Influence on (weekly):</color> Sovereignty +0.6, Unity of the Party +0.6";
					}
					else
					{
						this.text_fake += "<color=red>Influence on (weekly):</color> Approval from the USSR -0.2, Dissatisfaction of NATO +0.2, Sovereignty +0.6, Unity of the Party +0.6";
					}
					if (this.global1.data[216] > 49)
					{
						this.text_fake += "\n<color=red>Description:</color> The \"INTEGRAL\" spacecraft project is the crowning achievement of our entire history of stabilizing life on Earth, which will allow us to convey our style and rules of life to other planets. Its launch will allow us to move into the society of the future in the truest sense of the word!";
					}
					else
					{
						this.text_fake += "\n<color=red>Description:</color> Really?! This project will cost us a lot of money and also we will have to hide it from prying eyes! But, if things work out, we will not be afraid of neither the USA nor the USSR. I hope you know what you are doing...";
					}
				}
			}
			else if (this.this_num == 0)
			{
				this.Name.text = "Re-equipment of special services";
				this.text_fake = "<color=red>Influence on (weekly):</color> Westalgia -0.2, Agent networks +0.2, Unity of the Party +0.2";
				this.text_fake += "\n<color=red>Description:</color> Our special services should be equipped, according to the latest technology, to ensure the internal and external security of our state!";
			}
			else if (this.this_num == 1)
			{
				this.Name.text = "Mass introduction of video surveillance";
				this.text_fake = "<color=red>Influence on (weekly):</color> Westalgia -0.2, Support of the people +0.2, Unity of the Party +0.2";
				this.text_fake += "\n<color=red>Description:</color> Video surveillance system will help us maintain order in the streets and fight crime more efficiently.";
			}
			else if (this.this_num == 2)
			{
				this.Name.text = "SORM (SOIA)";
				this.text_fake = "<color=red>Influence on (weekly):</color> Support of the people +0.2, Unity of the Party +0.6";
				this.text_fake += "\n<color=red>Description:</color> - the system for Operative Investigative Activities will be a good help both for the special services and for the police, also relieve us of unnecessary bureaucratic delays. ";
			}
			else if (this.this_num == 3)
			{
				this.Name.text = "Technological society";
				this.text_fake = "<color=red>Influence on (weekly):</color> The budget +0.2, Standard of living +0.2";
				this.text_fake += "\n<color=red>Influence on (once):</color> Need for import -3    ";
				this.text_fake += "<color=red>Description:</color> The XXth century is coming to an end, which means another change in the economic model. Many are moving from the industrial to the technological society, focusing on science, automation and informatics. Our country needs to keep up with them. ";
			}
			else if (this.this_num == 4)
			{
				this.Name.text = "Mass introduction of DPC and MACC";
				this.text_fake = "<color=red>Influence on (weekly):</color> The budget +0.4, Standard of living +0.2";
				this.text_fake += "\n<color=red>Influence on (once):</color> Need for import -3   ";
				this.text_fake += "<color=red>Description:</color> Mass introduction of the data-processing centers and multiple-access computing centers - automation and access to large computing capacities, will initiate computerization and significantly increase our capabilities in all areas of activity. And also, it will finally save us and our citizens from annoying bureaucratic delays.";
			}
			else if (this.this_num == 5)
			{
				this.Name.text = "Develop an analog of Cybersyn";
				this.text_fake = "<color=red>Influence on (weekly):</color> The budget +0.2, Standard of living +0.2, Sovereignty +0.2";
				this.text_fake += "\n<color=red>Influence on (once):</color> Need for import -3";
				this.text_fake += "\n<color=red>Description:</color> Chilean Cybersyn proved itself as an effective and progressive system. Maybe we should consider this idea more closely?..";
			}
			else if (this.this_num == 6)
			{
				this.Name.text = "Think about genetics";
				this.text_fake = "<color=red>Influence on (weekly):</color> Sovereignty +0.2, Standard of living +0.2";
				this.text_fake += "\n<color=red>Influence on (once):</color> Need for import -2";
				this.text_fake += "\n<color=red>Description:</color> Now that we're cornered by circumstances, it's time to take advantage of everything we have. Genetics is only a modern analogue of selection, which, moreover, can bring us good harvest in the field of agriculture. Let's try?";
			}
			else if (this.this_num == 7)
			{
				this.Name.text = "Priority importance of genetics";
				this.text_fake = "<color=red>Influence on (weekly):</color> The budget +0.2, Sovereignty +0.2, Standard of living +0.2";
				this.text_fake += "\n<color=red>Influence on (once):</color> Need for import -2";
				this.text_fake += "\n<color=red>Description:</color> As practice has shown, genetics is applicable not only in agriculture, but also in other areas, especially in medicine. It is necessary to conduct further research in this area as soon as possible. ";
			}
			else if (this.this_num == 8)
			{
				this.Name.text = "Genetics for the people's satisfaction";
				this.text_fake = "<color=red>Influence on (weekly):</color> Westalgia -0.2, Standard of living +0.3, Support of the people +0.2";
				this.text_fake += "\n<color=red>Influence on (once):</color> Need for import -5";
				this.text_fake += "\n<color=red>Description:</color> Now, after careful research in the area of genetics, we are faced with truly limitless possibilities. GMO, the cure of many diseases, is not one tenth of those prospects that open up before us ... ";
			}
			else if (this.this_num == 9)
			{
				this.Name.text = "Study of the nuclear weapons project";
				this.text_fake = "<color=red>Requires:</color> There are blueprints and technology and Nuclear Test Site\n";
				this.text_fake += "<color=red>Influence on (weekly):</color> Approval from the USSR -0.2, Dissatisfaction of NATO +0.2, Sovereignty +0.6, Unity of the Party +0.6";
				this.text_fake += "\n<color=red>Description:</color> Really?! This project will cost us a lot of money and also we will have to hide it from prying eyes! But, if things work out, we will not be afraid of neither the USA nor the USSR. I hope you know what you are doing...";
			}
		}
		else if (this.global1.data[0] == 10 || this.global1.data[0] == 12 || this.global1.data[0] == 18 || this.global1.data[0] == 32)
		{
			if (this.this_num == 0)
			{
				if (this.global1.data[216] > 49)
				{
					this.Name.text = "Пропаганда гражданской сознательности";
				}
				else
				{
					this.Name.text = "Разработка реформы милиции";
				}
				this.text_fake = "<color=red>Влияние (еженедельно):</color> Вестальгия -0.2, Поддержка народа +0.2, Уровень жизни +0.1";
				if (this.global1.data[216] > 49)
				{
					this.text_fake += "\n<color=red>Описание:</color> Современные реалии вынуждают нас включить в пропаганду элементы, связанные с поощрением сознательности граждан в поиске врагов внутри нашей страны.";
				}
				else
				{
					this.text_fake += "\n<color=red>Описание:</color> Современные реалии вынуждают нас провести реформу органов безопасности, чтобы раз и навсегда расправиться с преступностью внутри нашей страны. ";
				}
			}
			else if (this.this_num == 1)
			{
				this.Name.text = "Усиление министерства госбезопасности";
				this.text_fake = "<color=red>Влияние (еженедельно):</color> Единство Партии +0.2, Агентурные сети + 0.2, Вестальгия -0.2";
				this.text_fake += "\n<color=red>Описание:</color> Мир на пороге глобальных изменений, внутренние враги Родины и «пятая колонна» не могут дождаться момента, чтобы совершить свой подлый удар по нашей государственности. Не дадим же им этого сделать! ";
			}
			else if (this.this_num == 2)
			{
				if (this.global1.data[216] > 49)
				{
					this.Name.text = "Развитие агентуры за Зелёной Стеной";
				}
				else
				{
					this.Name.text = "Развитие зарубежной агентуры";
				}
				if (this.global1.data[216] > 49)
				{
					this.text_fake = "<color=red>Влияние (еженедельно):</color> Единство Партии +0.4";
				}
				else
				{
					this.text_fake = "<color=red>Влияние (еженедельно):</color> Отношения с СССР +0.4, Единство Партии +0.4, Угроза НАТО -0.3";
				}
				if (this.global1.data[216] > 49)
				{
					this.text_fake += "\n<color=red>Описание:</color>Враги прогресса продолжают скрываться в труднопроходимых районах нашей страны, и доверять уже никому нельзя! Необходимо усилить влияние наших агентурных сетей в отрядах этих дикарей, чтобы обезопасить нас от подлого удара недоброжелателей. ";
				}
				else
				{
					this.text_fake += "\n<color=red>Описание:</color>Враги окружают нашу страну повсюду, и доверять уже никому нельзя! Необходимо усилить влияние наших агентурных сетей за рубежом, чтобы обезопасить нас от подлого удара недоброжелателей. ";
				}
			}
			else if (this.this_num == 3)
			{
				this.Name.text = "Строительство промышленности";
				this.text_fake = "<color=red>Влияние (еженедельно):</color> Бюджет +0.2, Уровень жизни +0.2";
				if (this.global1.data[216] < 50)
				{
					this.text_fake += "\n<color=red>Влияние (один раз):</color> Можно строить обычные заводы";
				}
				if (this.global1.data[216] > 49)
				{
					this.text_fake += "\n<color=red>Описание:</color> Несмотря на все наши социальные успехи, нашей стране есть ещё куда стремиться в плане развития экономики, поэтому усиленное строительство промышленности не будет лишним для нас. ";
				}
				else
				{
					this.text_fake += "\n<color=red>Описание:</color> Несмотря на все наши социальные успехи, наша страна всё ещё продолжает отставать от передовых государств в плане экономики, поэтому усиленное строительство промышленности не будет лишним для нас. ";
				}
			}
			else if (this.this_num == 4)
			{
				if (this.global1.data[216] > 49)
				{
					this.Name.text = "Курс на технологизацию";
				}
				else
				{
					this.Name.text = "Курс на индустриализацию";
				}
				this.text_fake = "<color=red>Влияние (еженедельно):</color> +0.1 к Единству партии, +0.1 к Уровню жизни";
				this.text_fake += "\n<color=red>Влияние (один раз):</color> Нужда в импорте -1; 1 новый завод";
				if (this.global1.data[216] > 49)
				{
					this.text_fake += "\n<color=red>Описание:</color> Курс на внедрение индустрии – вот что нужно нашей стране, стремящейся к звёздам! ";
				}
				else
				{
					this.text_fake += "\n<color=red>Описание:</color> Курс на внедрение индустрии – вот что нужно нашей стране, преодолеем отставание от развитых стран! ";
				}
			}
			else if (this.this_num == 5)
			{
				if (this.global1.data[216] > 49)
				{
					this.Name.text = "Общество нового типа";
				}
				else
				{
					this.Name.text = "Индустриальное общество";
				}
				this.text_fake = "<color=red>Влияние (еженедельно):</color> Бюджет +0.2, Уровень жизни +0.3, Cуверенитет +0.3";
				this.text_fake += "\n<color=red>Влияние (один раз):</color> Нужда в импорте -2; Можно строить заводы электроники";
				if (this.global1.data[216] > 49)
				{
					this.text_fake += "\n<color=red>Описание:</color> Старания не прошли даром, и теперь с уверенностью можно сказать, что наша страна, наконец, смогла отринуть старые предрассудки и создать нумера нового типа!";
				}
				else
				{
					this.text_fake += "\n<color=red>Описание:</color> Старания не прошли даром, и теперь с уверенностью можно сказать, что наша страна, наконец, вошла в список индустриально-развитых. Вперёд в далёкое и светлое будущее!";
				}
			}
			else if (this.this_num == 6)
			{
				this.Name.text = "Продолжить аграрную реформу";
				this.text_fake = "<color=red>Влияние (еженедельно):</color> Уровень жизни +0.2, Единство партии +0.2, Cуверенитет + 0.1";
				this.text_fake += "\n<color=red>Влияние (один раз):</color> Можно строить фермы";
				if (this.global1.data[216] > 49)
				{
					this.text_fake += "\n<color=red>Описание:</color> Наше сельское хозяйство продолжает оставаться слаборазвитым и малоавтоматизированным, поэтому продолжение сельскохозяйственной реформы должно навсегда покончить с аграрным вопросом.";
				}
				else
				{
					this.text_fake += "\n<color=red>Описание:</color> Наше сельское хозяйство продолжает оставаться неприбыльным и слабомеханизированным, поэтому продолжение сельскохозяйственной реформы должно навсегда покончить с аграрным вопросом.";
				}
			}
			else if (this.this_num == 7)
			{
				this.Name.text = "Развитие сельского хозяйства";
				this.text_fake = "<color=red>Влияние (еженедельно):</color> Поддержка народа + 0.1, Суверенитет +0.2";
				this.text_fake += "\n<color=red>Влияние (один раз):</color> Нужда в импорте -1; 1 новая ферма";
				if (this.global1.data[216] > 49)
				{
					this.text_fake += "\n<color=red>Описание:</color> Благодаря достижениям в генной индустрии, стало возможным насытить всех нумеров необходимым количеством провизии. Внедрив эти достижения в экономику, голод будет полностью побеждён! ";
				}
				else
				{
					this.text_fake += "\n<color=red>Описание:</color> На Западе всё сильнее усиливается влияние крупных сельскохозяйственных агро-холдингов, которые гораздо производительнее индивидуальных фермерских хозяйств. Возможно, нам стоит позаимствовать их опыт и начать укрупнение в сельском хозяйстве? ";
				}
			}
			else if (this.this_num == 8)
			{
				if (this.global1.data[216] > 49)
				{
					this.Name.text = "Внедрение автоматизации";
				}
				else
				{
					this.Name.text = "Внедрение механизации";
				}
				this.text_fake = "<color=red>Влияние (еженедельно):</color> Вестальгия : -0.1, суверенитет +0.1, Уровень жизни + 0.2";
				this.text_fake += "\n<color=red>Влияние (один раз):</color> Нужда в импорте -2";
				if (this.global1.data[216] > 49)
				{
					this.text_fake += "\n<color=red>Описание:</color> Часть нумеров-учёных предлагают выдвинуть новый план развития сельского хозяйства, по полной автоматизации выращивания продукции без участия человека, благодаря чему добиться окончательной стабилизации выпуска сельхозпродукции.";
				}
				else
				{
					this.text_fake += "\n<color=red>Описание:</color> Во всём мире давно отказались от устаревших методов ведения сельского хозяйства в пользу более производительных тракторов и других агро-машин, почему бы и нам не присоединиться к этой тенденции?";
				}
			}
			else if (this.this_num == 9)
			{
				if (this.global1.data[216] > 49)
				{
					this.Name.text = "Разработка \"ИНТЕГРАЛа\"";
				}
				else
				{
					this.Name.text = "Изучение проекта ядерного вооружения";
				}
				this.text_fake = "<color=red>Условие:</color> Есть чертежи и технологии, есть ядерный полигон\n";
				if (this.global1.data[216] > 49)
				{
					this.text_fake += "<color=red>Влияние (еженедельно):</color> Суверенитет +0.6, Единство Партии +0.6";
				}
				else
				{
					this.text_fake += "<color=red>Влияние (еженедельно):</color> Одобрение СССР -0.2, Недовольство НАТО +0.2, Суверенитет +0.6, Единство Партии +0.6";
				}
				if (this.global1.data[216] > 49)
				{
					this.text_fake += "\n<color=red>Описание:</color> Проект космического корабля «ИНТЕГРАЛ» - это венец всей нашей истории по стабилизации жизни на Земле, который позволит доносить до других планет наш стиль и правила жизни. Его запуск позволит нам перейти в общество будущего в прямом смысле этого слова!";
				}
				else
				{
					this.text_fake += "\n<color=red>Описание:</color> Ох, не к добру вы это затеяли, не к добру... Мало того, что этот проект влетит нам в копеечку, так еще и придется скрывать это от лишних глаз! Впрочем, если дело выгорит, нам не будут страшны ни США, ни СССР. Надеюсь, вы знаете, что делаете...";
				}
			}
		}
		else if (this.this_num == 0)
		{
			this.Name.text = "Масштабное переоснащение спецслужб";
			this.text_fake = "<color=red>Влияние (еженедельно):</color> Вестальгия -0.2, Агентурная сеть +0.2, Единство Партии +0.2";
			this.text_fake += "\n<color=red>Описание:</color> Наши спецслужбы должны быть оснащены по последнему слову техники, для опеспечения внутренней и внешней безопасности нашего государства! ";
		}
		else if (this.this_num == 1)
		{
			this.Name.text = "Массовое внедрение видеонаблюдения";
			this.text_fake = "<color=red>Влияние (еженедельно):</color> Вестальгия -0.2, Поддержка народа +0.2, Единство Партии +0.2";
			this.text_fake += "\n<color=red>Описание:</color> Система видеонаблюдения поможет нам поддерживать порядок на улицах и эффективнее бороться с преступностью. ";
		}
		else if (this.this_num == 2)
		{
			this.Name.text = "СОРМ";
			this.text_fake = "<color=red>Влияние (еженедельно):</color> Поддержка народа +0.2, Единство Партии +0.6";
			this.text_fake += "\n<color=red>Описание:</color> Система оперативно-розыскных мероприятий будет неплохим подспорьем как для спецслужб, так и для полиции, а также избавит нас от излишних бюрократических проволочек.  ";
		}
		else if (this.this_num == 3)
		{
			this.Name.text = "Технологическое общество";
			this.text_fake = "<color=red>Влияние (еженедельно):</color> Бюджет +0.2, Уровень жизни +0.2";
			this.text_fake += "\n<color=red>Влияние (один раз):</color> Нужда в импорте -3";
			this.text_fake += "\n<color=red>Описание:</color> ХХ век подходит к концу, а значит наступает очередная смена экономической модели. Многие переходят с индустриального на технологическое обещество, делая упор на науку, автоматизацию и информатику. Наша страна не должна отставать от них. ";
		}
		else if (this.this_num == 4)
		{
			this.Name.text = "Массовое внедрение ИВЦ И ВЦКП";
			this.text_fake = "<color=red>Влияние (еженедельно):</color> Бюджет +0.4, Уровень жизни +0.2";
			this.text_fake += "\n<color=red>Влияние (один раз):</color> Нужда в импорте -3";
			this.text_fake += "\n<color=red>Описание:</color> Автоматизация и доступ к большим вычислительным мощностям положат начало компьютеризации и существенно увеличат наши возможности во всех сферах деятельности. А также это наконец-то избавит нас и наших граждан от надоедливых бюрократических проволочек. ";
		}
		else if (this.this_num == 5)
		{
			this.Name.text = "Разработка аналога Киберсина";
			this.text_fake = "<color=red>Влияние (еженедельно):</color> Бюджет +0.2, Уровень жизни +0.2, Суверенитет +0.2";
			this.text_fake += "\n<color=red>Влияние (один раз):</color> Нужда в импорте -3";
			this.text_fake += "\n<color=red>Описание:</color> Чилийский Киберсин показал себя как эффективную и перспективную систему. Может быть, и нам стоит рассмотреть эту идею внимательнее? ";
		}
		else if (this.this_num == 6)
		{
			this.Name.text = "Вспомнить о генетике";
			this.text_fake = "<color=red>Влияние (еженедельно):</color> Суверенитет +0.2, Уровень жизни +0.2";
			this.text_fake += "\n<color=red>Влияние (один раз):</color> Нужда в импорте -2";
			this.text_fake += "\n<color=red>Описание:</color> Теперь, когда мы зажаты в угол обстоятельствами, пора воспользоваться всем, что у нас есть. Генетика - современный аналог селекции, который, к тому же, может принести нам неплохие плоды в области сельского хозяйства. Попробуем?";
		}
		else if (this.this_num == 7)
		{
			this.Name.text = "Первоочередная важность генетики";
			this.text_fake = "<color=red>Влияние (еженедельно):</color> Бюджет +0.2, Суверенитет +0.2, Уровень жизни +0.2";
			this.text_fake += "\n<color=red>Влияние (один раз):</color> Нужда в импорте -2";
			this.text_fake += "\n<color=red>Описание:</color> Как показала практика, генетика применима не только в сельском хозяйстве, но и в остальных областях, особенно в медицине. Необходимо как можно скорее провести дальнейшие исследования в этой области. ";
		}
		else if (this.this_num == 8)
		{
			this.Name.text = "Генетика для удовлетворения масс";
			this.text_fake = "<color=red>Влияние (еженедельно):</color> Вестальгия -0.2, Уровень жизни +0.3, Поддержка народа +0.2";
			this.text_fake += "\n<color=red>Влияние (один раз):</color> Нужда в импорте -5";
			this.text_fake += "\n<color=red>Описание:</color> Теперь, после тщательных исследований в области генетики, перед нами открываются поистине безграничные возможности: ГМО и излечение многих болезней не составляют и десятой части тех перспектив, которые открываются перед нами... ";
		}
		else if (this.this_num == 9)
		{
			this.Name.text = "Изучение проекта ядерного вооружения";
			this.text_fake = "<color=red>Условие:</color> Есть чертежи и технологии, есть ядерный полигон\n";
			this.text_fake += "<color=red>Влияние (еженедельно):</color> Одобрение СССР -0.2, Недовольство НАТО +0.2, Суверенитет +0.6, Единство Партии +0.6";
			this.text_fake += "\n<color=red>Описание:</color> Ох, не к добру вы это затеяли, не к добру... Мало того, что этот проект влетит нам в копеечку, так еще и придется скрывать это от лишних глаз! Впрочем, если дело выгорит, нам не будут страшны ни США, ни СССР. Надеюсь, вы знаете, что делаете...";
		}
		this.opis.text = this.Text(this.text_fake, 70);
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x001FCAF8 File Offset: 0x001FACF8
	private void OnMouseExit()
	{
		if (this.this_num == 9 && (this.global1.data[0] < 49 || this.global1.data[0] > 51) && !this.global1.povod && !this.global1.science[this.this_num] && this.global1.science_time[this.this_num] < 1)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.stop;
		}
		else if (this.this_num == 9 && this.global1.data[0] >= 49 && this.global1.data[0] <= 51 && (!this.global1.science[2] || !this.global1.science[5] || !this.global1.science[8]))
		{
			base.GetComponent<SpriteRenderer>().sprite = this.stop;
		}
		else if (this.global1.science_time[this.this_num] <= 0 && !this.global1.science[this.this_num])
		{
			base.GetComponent<SpriteRenderer>().sprite = this.off;
		}
		else if (this.global1.science_time[this.this_num] > 0 && !this.global1.science[this.this_num])
		{
			base.GetComponent<SpriteRenderer>().sprite = this.on;
		}
		this.Name.text = "";
		this.opis.text = "";
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00003D84 File Offset: 0x00001F84
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

	// Token: 0x0400028C RID: 652
	private GlobalScript global1;

	// Token: 0x0400028D RID: 653
	private Yugoglobal yug1;

	// Token: 0x0400028E RID: 654
	public Sprite on;

	// Token: 0x0400028F RID: 655
	public Sprite off;

	// Token: 0x04000290 RID: 656
	public Sprite stop;

	// Token: 0x04000291 RID: 657
	public Sprite new_icon;

	// Token: 0x04000292 RID: 658
	public SpriteRenderer now_icon;

	// Token: 0x04000293 RID: 659
	public TextMesh Name;

	// Token: 0x04000294 RID: 660
	public TextMesh opis;

	// Token: 0x04000295 RID: 661
	public TextMesh[] condition = new TextMesh[10];

	// Token: 0x04000296 RID: 662
	public int this_num;

	// Token: 0x04000297 RID: 663
	private string text_fake;

	// Token: 0x04000298 RID: 664
	public int nii;

	// Token: 0x04000299 RID: 665
	public GameObject progress;

	// Token: 0x0400029A RID: 666
	public int itogo_izuchaem;

	// Token: 0x0400029B RID: 667
	public int this_year = 1989;

	// Token: 0x0400029C RID: 668
	public TextMesh[] dates = new TextMesh[3];
}
