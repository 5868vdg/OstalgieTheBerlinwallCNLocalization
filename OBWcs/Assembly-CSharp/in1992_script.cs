using System;
using UnityEngine;

// Token: 0x02000056 RID: 86
public class in1992_script : MonoBehaviour
{
	// Token: 0x060001A2 RID: 418 RVA: 0x000032BB File Offset: 0x000014BB
	private void OnMouseEnter()
	{
		base.GetComponent<SpriteRenderer>().sprite = this.navel;
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x000032CE File Offset: 0x000014CE
	private void OnMouseExit()
	{
		base.GetComponent<SpriteRenderer>().sprite = this.nenavel;
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x001EF390 File Offset: 0x001ED590
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		if (this.is_left)
		{
			if (this.global1.data[216] >= 50)
			{
				this.Name.text = "01001110 01100101 01110111 00100000 01100100 01100001 01110111 01101110";
				this.End.text = "01010100 01101000 01100101 00100000 01000101 01101110 01100100";
				if (this.global1.data[19] == 1 && this.global1.data[20] == 1 && this.global1.data[21] == 1992)
				{
					this.time1 = GameObject.Find("Text_time").GetComponent<TimeScript>();
					this.fake_text = "01001001 01101101 01101101 01100101 01100100 01101001 01100001 01110100 01100101 01101100 01111001 00100000 01100001 01100110 01110100 01100101 01110010 00100000 01110100 01101000 01100101 00100000 01110100 01110010 01101001 01100010 01110101 01101100 01100001 01110100 01101001 01101111 01101110 00100000 01101111 01100110 00100000 01110100 01101000 01101111 01110011 01100101 00100000 01100100 01100001 01111001 01110011 00100000 01110100 01101000 01100101 00100000 01110011 01110101 01101110 00100000 01110111 01101001 01101100 01101100 00100000 01100010 01100101 00100000 01100100 01100001 01110010 01101011 01100101 01101110 01100101 01100100 00101100 00100000 01100001 01101110 01100100 00100000 01110100 01101000 01100101 00100000 01101101 01101111 01101111 01101110 00100000 01110111 01101001 01101100 01101100 00100000 01101110 01101111 01110100 00100000 01100111 01101001 01110110 01100101 00100000 01101001 01110100 01110011 00100000 01101100 01101001 01100111 01101000 01110100 00101100 00100000 01100001 01101110 01100100 00100000 01110100 01101000 01100101 00100000 01110011 01110100 01100001 01110010 01110011 00100000 01110111 01101001 01101100 01101100 00100000 01100110 01100001 01101100 01101100 00100000 01100110 01110010 01101111 01101101 00100000 01101000 01100101 01100001 01110110 01100101 01101110 00101100 00100000 01100001 01101110 01100100 00100000 01110100 01101000 01100101 00100000 01110000 01101111 01110111 01100101 01110010 01110011 00100000 01101111 01100110 00100000 01110100 01101000 01100101 00100000 01101000 01100101 01100001 01110110 01100101 01101110 01110011 00100000 01110111 01101001 01101100 01101100 00100000 01100010 01100101 00100000 01110011 01101000 01100001 01101011 01100101 01101110 00101110";
					this.this_text.text = this.Text(this.fake_text, 72);
					return;
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				this.Name.text = "New beginnings";
				this.End.text = "The End";
				if (this.global1.data[19] == 1 && this.global1.data[20] == 1 && this.global1.data[21] == 1992)
				{
					this.time1 = GameObject.Find("Text_time").GetComponent<TimeScript>();
					this.fake_text = " 同 志 ！|1991 年 已 经 结 束 ， 这 意 味 着 世 界 已 经 发 生 了 翻 天 覆 地 的 变 化 ， 当 然 ， 未 来 还 会 有 令 人 难 忘 且 充 满 挑 战 的 岁 月 ， 既 有 苦 涩 的 成 就 ， 也 有 伟 大 的 胜 利 ， 但 我 们 正 在 为 我 们 的 光 明 未 来 奠 定 基 础 。 不 过 ， 你 是 我 们 的 领 袖 ， 如 同 太 阳 般 指 引 方 向 ， 你 将 决 定 如 何 继 续 前 行:| 你 可 以 选 择 继 续 游 戏 — — 从1992 年 直 至 无 限 ， 随 时 都 有 机 会 结 束 游 戏 ， 以 你 认 为 合 适 的 方 式 重 塑 世 界 。然 而 ， 这 样 你 将 无 法 获 得 任 何 成 就 ， 只 能 从 新 的 日 期 开 始 。| 或 者 ， 你 可 以 结 束 这 一 切 ， 只 需 选 择 右 侧 的 按 钮 ， 结 束 游 戏 并 进 入 总 结 窗 口 ， 在 那 里 你 将 为 自 己 多 年 的 工 作 画 上 句 号 ， 并 描 述 未 来 数 年 整 个 世 界 的 状 态 。 最 重 要 的 是 ， 你 可 以 解 锁 成 就 ！ 选 择 权 在 你 手 中";
					this.this_text.text = this.Text(this.fake_text, 72);
					return;
				}
			}
			else if (this.global1.data[19] == 1 && this.global1.data[20] == 1 && this.global1.data[21] == 1992)
			{
				this.time1 = GameObject.Find("Text_time").GetComponent<TimeScript>();
				this.fake_text = "Товарищ!| 1991 год закончился, а значит и мир изменился до неузнаваемости. Конечно, дальше нас ждут незабываемые и тяжелые времена горьких свершений и великих побед, однако фундамент нашего светлого будущего мы заложили уже сейчас. Впрочем, вы - наш солнцеликий руководитель и вам решать, как поступить дальше:|Вы можете решить играть дальше - с 1992 года до бесконечности, в любой момент имея возможность закончить игру, дабы перекроить мир так, как вы считаете нужным. Однако, тогда вы не сможете добиться ни одного достижения, начиная с новой даты.|В ином случае вы можете положить всему этому конец и, просто выбрав правую кнопку, закончить игру и перейти к окну итогов, где будет подведена черта под вашей многолетней работой, а также будет описано состояние всего мира на грядущие годы. И, самое главное, вы сможете открыть достижения!|Выбор за вами.";
				this.this_text.text = this.Text(this.fake_text, 72);
			}
		}
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x001EF588 File Offset: 0x001ED788
	private void OnMouseDown()
	{
		this.global1.data[218] = 0;
		for (int i = 0; i < this.global1.regions.Length; i++)
		{
			for (int j = 0; j < 15; j++)
			{
				if (this.global1.regions[i].buildings[j].type == 37 && this.global1.regions[i].buildings[j].is_builded && this.global1.regions[i].buildings[j].is_working)
				{
					this.global1.data[217] = 1;
				}
				if (this.global1.regions[i].buildings[j].type == 17 && this.global1.regions[i].buildings[j].is_builded && this.global1.regions[i].buildings[j].is_working)
				{
					this.global1.data[218]++;
				}
			}
		}
		if (this.global1.data[217] == 1 && this.global1.data[220] == 7 && this.global1.data[218] == 9 && this.global1.data[14] == 3 && !this.global1.allcountries[49].isSEV && !this.global1.allcountries[50].isSEV && !this.global1.allcountries[51].isSEV)
		{
			this.global1.data[219] = 1;
		}
		if (this.global1.data[164] == 7 && this.global1.allcountries[17].Westalgie + this.global1.data[7] + this.global1.data[9] / 10 + this.global1.data[6] / 10 + this.global1.data[8] / 20 >= 1350)
		{
			this.global1.allcountries[54].Vyshi = false;
		}
		if (this.global1.allcountries[27].Westalgie >= 2 || (!this.global1.allcountries[27].Donat && this.global1.data[7] >= 800 && this.global1.allcountries[27].Torg))
		{
			this.global1.allcountries[27].subideology = 14;
		}
		if (this.global1.data[242] == 1 && this.global1.data[0] == 1 && (this.global1.science[9] || (this.global1.is_gkchp && (!this.global1.is_gkchp || this.global1.allcountries[7].Gosstroy < 2)) || this.global1.data[0] != 1 || (this.global1.data[14] != 3 && (this.global1.data[14] != 2 || this.global1.data[15] < 8 || this.global1.data[17] < 16) && (this.global1.data[14] != 4 || this.global1.data[16] > 12)) || ((this.global1.allcountries[17].Westalgie < 300 || !this.global1.allcountries[this.global1.data[0]].isOVD || !this.global1.allcountries[7].isOVD) && (((this.global1.allcountries[17].Westalgie < 350 || this.global1.allcountries[16].Gosstroy != 0) && this.global1.allcountries[17].Westalgie < 400) || !this.global1.allcountries[this.global1.data[0]].isSEV || (this.global1.allcountries[17].Westalgie < 550 && (!this.global1.allcountries[7].isSEV || this.global1.is_gkchp))))) && this.global1.allcountries[1].Gosstroy != 2)
		{
			this.global1.data[242] = 2;
		}
		if (this.global1.data[0] == 49)
		{
			if (!this.global1.regions[4].buildings[5].is_builded)
			{
				this.global1.data[192] = 1;
			}
			else if (!this.global1.regions[4].buildings[6].is_builded)
			{
				this.global1.data[192] = 1;
			}
			else if (!this.global1.regions[4].buildings[7].is_builded)
			{
				this.global1.data[192] = 1;
			}
			else if (!this.global1.regions[4].buildings[8].is_builded)
			{
				this.global1.data[192] = 1;
			}
			else if (!this.global1.regions[4].buildings[9].is_builded)
			{
				this.global1.data[192] = 1;
			}
		}
		if (this.is_left)
		{
			this.time1.Reborn();
			this.global1.iron_and_blood = false;
			return;
		}
		if (this.global1.data[4] - this.global1.data[22] / 10 >= 940 || (this.global1.data[3] <= 350 && this.global1.data[4] - this.global1.data[22] / 10 >= 850) || (this.global1.data[3] <= 550 && this.global1.data[4] - this.global1.data[22] / 10 >= 900))
		{
			this.global1.data[46] = 2;
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
			return;
		}
		if (this.global1.data[216] >= 50)
		{
			this.global1.data[46] = 32;
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
			return;
		}
		if (this.global1.data[1] < 300 || (this.global1.data[1] < 500 && this.global1.data[2] + this.global1.data[22] / 5 <= 450))
		{
			this.global1.data[46] = 3;
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
			return;
		}
		if (this.global1.data[3] + this.global1.data[22] / 100 <= 200)
		{
			this.global1.data[46] = 1;
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
			return;
		}
		if (this.global1.data[11] == 1 && this.global1.data[68] <= -3 && (!this.global1.science[9] || this.global1.allcountries[16].Gosstroy != 0))
		{
			this.global1.data[46] = 8;
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
			return;
		}
		if (this.global1.data[0] == 12 && this.global1.data[80] <= 60 && this.global1.data[106] == 0 && this.global1.data[81] == 1 && this.global1.allcountries[7].Vyshi)
		{
			this.global1.data[46] = 10;
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
			return;
		}
		if ((this.global1.data[0] < 49 || this.global1.data[0] > 51) && ((this.global1.data[10] > 499 && this.global1.regions[2].buildings[0].type != 21 && this.global1.regions[1].buildings[0].type == 23) || this.global1.data[10] > 549) && (!this.global1.allcountries[7].isOVD || !this.global1.allcountries[this.global1.data[0]].isOVD))
		{
			if (this.global1.data[0] == 18)
			{
				this.global1.data[76] = this.global1.data[10];
				if (this.global1.regions[1].buildings[0].type == 23 && this.global1.allcountries[7].Gosstroy < 2)
				{
					this.global1.data[10] -= 500;
				}
				else if (this.global1.regions[1].buildings[0].type == 23 && !this.global1.allcountries[7].Vyshi)
				{
					this.global1.data[10] -= 250;
				}
				else if (this.global1.regions[1].buildings[0].type == 23)
				{
					this.global1.data[10] -= 100;
				}
			}
			int num = 0;
			int num2 = 0;
			for (int k = 0; k < this.global1.allcountries.Length; k++)
			{
				if (this.global1.allcountries[k] != null)
				{
					if (this.global1.allcountries[k].isOVD)
					{
						num++;
						num2++;
					}
					else if (this.global1.allcountries[k].isSEV)
					{
						num++;
					}
				}
			}
			if (num2 >= 6)
			{
				this.global1.data[10] -= (num2 - 6) * 30;
			}
			else
			{
				this.global1.data[10] += (num2 - 6) * 30;
			}
			if (num >= 9)
			{
				this.global1.data[10] -= (num - 9) * 10;
			}
			else
			{
				this.global1.data[10] += (num - 9) * 10;
			}
			if (this.global1.science_time[9] > 0)
			{
				this.global1.data[10] -= 50;
				if (this.global1.science[9])
				{
					this.global1.data[10] -= 250;
				}
			}
			if (this.global1.data[0] == 1)
			{
				this.global1.data[10] += 50;
			}
			if (!this.global1.allcountries[7].isOVD && !this.global1.allcountries[7].isSEV)
			{
				this.global1.data[10] += 50;
			}
			if (this.global1.allcountries[7].Gosstroy <= 0)
			{
				this.global1.data[10] -= 50;
				if (this.global1.data[0] == 10)
				{
					this.global1.data[10] -= 500;
				}
			}
			else if (this.global1.allcountries[7].Gosstroy <= 1)
			{
				this.global1.data[10] -= 25;
			}
			if (this.global1.allcountries[16].Gosstroy <= 0 && this.global1.data[14] <= 3 && this.global1.allcountries[16].isSEV && !this.global1.allcountries[this.global1.data[0]].Vyshi)
			{
				this.global1.data[10] -= 100;
			}
			else if (this.global1.allcountries[16].Gosstroy >= 1 && this.global1.data[14] >= 3 && this.global1.allcountries[16].isSEV && !this.global1.allcountries[this.global1.data[0]].Vyshi)
			{
				this.global1.data[10] -= 100;
			}
			if (this.global1.allcountries[10].Stasi)
			{
				this.global1.data[10] -= 50;
			}
			if (this.global1.allcountries[this.global1.data[0]].isOVD && (this.global1.allcountries[5].isOVD || this.global1.allcountries[6].isOVD) && (this.global1.data[54] >= 7 || (this.global1.allcountries[15].isOVD && this.global1.data[54] >= 5)) && !this.global1.allcountries[15].Help)
			{
				this.global1.data[10] -= 25;
			}
			if ((this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 1 && this.global1.data[10] > 450) || (!this.global1.allcountries[7].isSEV && this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy <= 1 && this.global1.data[10] > 550) || (!this.global1.allcountries[7].isSEV && !this.global1.is_gkchp && this.global1.data[10] > 700) || (this.global1.allcountries[7].isSEV && this.global1.data[10] > 850))
			{
				this.global1.data[46] = 4;
				GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
				GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
				return;
			}
			this.global1.data[46] = 0;
			this.GoodEnding();
			return;
		}
		else
		{
			if (this.global1.data[0] < 49 || this.global1.data[0] > 51)
			{
				this.global1.data[46] = 0;
				this.GoodEnding();
				return;
			}
			Yugoglobal component = GameObject.Find("Yugoglobal(Clone)").GetComponent<Yugoglobal>();
			int num3 = 0;
			foreach (YugoRegion yugoRegion in component.gameState.yugregions)
			{
				if (num3 > 2)
				{
					break;
				}
				if (yugoRegion.owner == component.gameState.player)
				{
					num3++;
				}
			}
			if (GameObject.Find("Yugoglobal(Clone)").GetComponent<Yugoglobal>().gameState.battle_royal)
			{
				for (int m = 0; m < component.gameState.yugcountries.Length; m++)
				{
					if (m != component.gameState.player && this.global1.data[21] == 1991 && this.global1.data[21] == 6 && component.gameState.yugcountries[m].is_exist && !component.gameState.yugcountries[m].is_ally)
					{
						this.global1.data[46] = -1;
						GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
						GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
					}
				}
				this.global1.data[46] = 0;
				this.GoodEnding();
				return;
			}
			if (num3 <= 0)
			{
				this.global1.data[46] = -6;
				GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
				GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
				return;
			}
			if (this.global1.data[210] == 3)
			{
				this.global1.data[46] = 27;
				GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
				GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
				return;
			}
			if ((!this.global1.allcountries[this.global1.data[0]].isOVD || (this.global1.allcountries[this.global1.data[0]].isOVD && !this.global1.allcountries[7].isOVD) || !this.global1.allcountries[this.global1.data[0]].Vyshi || this.global1.allcountries[this.global1.data[0]].Vyshi) && (this.global1.data[3] <= 500 || this.global1.data[9] <= 250) && this.global1.data[10] >= 501 && this.global1.data[161] > 2 && ((this.global1.data[150] == 1 && this.global1.data[0] == 49) || (((this.global1.data[136] == 1 && this.global1.data[137] == 0) || (this.global1.data[136] == 0 && this.global1.data[138] == 0)) && this.global1.data[0] == 50) || (((this.global1.data[118] == 1 && this.global1.data[116] == 1) || (this.global1.data[118] == 0 && this.global1.data[117] == 0)) && this.global1.data[0] == 51)))
			{
				this.global1.data[46] = -10;
				GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
				GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
				return;
			}
			if (this.global1.data[214] >= 70)
			{
				this.global1.data[46] = 28;
				GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
				GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
				return;
			}
			if (!this.CheckNATO())
			{
				this.global1.data[46] = 0;
				this.GoodEnding();
			}
			return;
		}
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x001F0A2C File Offset: 0x001EEC2C
	private bool CheckNATO()
	{
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < this.global1.allcountries.Length; i++)
		{
			if (this.global1.allcountries[i] != null)
			{
				if (this.global1.allcountries[i].isOVD)
				{
					num++;
					num2++;
				}
				else if (this.global1.allcountries[i].isSEV)
				{
					num++;
				}
			}
		}
		if (num2 >= 6)
		{
			this.global1.data[10] -= (num2 - 6) * 30;
		}
		else
		{
			this.global1.data[10] += (num2 - 6) * 30;
		}
		if (num >= 9)
		{
			this.global1.data[10] -= (num - 9) * 10;
		}
		else
		{
			this.global1.data[10] += (num - 9) * 10;
		}
		if (this.global1.science_time[9] > 0)
		{
			this.global1.data[10] -= 50;
			if (this.global1.science[9])
			{
				this.global1.data[10] -= 250;
			}
		}
		if (this.global1.data[0] == 1)
		{
			this.global1.data[10] += 50;
		}
		if (!this.global1.allcountries[7].isOVD && !this.global1.allcountries[7].isSEV)
		{
			this.global1.data[10] += 50;
		}
		if (this.global1.allcountries[7].Gosstroy <= 0)
		{
			this.global1.data[10] -= 50;
			if (this.global1.data[0] == 10)
			{
				this.global1.data[10] -= 500;
			}
		}
		else if (this.global1.allcountries[7].Gosstroy <= 1)
		{
			this.global1.data[10] -= 25;
		}
		if (this.global1.allcountries[16].Gosstroy <= 0 && this.global1.data[14] <= 3 && this.global1.allcountries[16].isSEV && !this.global1.allcountries[this.global1.data[0]].Vyshi)
		{
			this.global1.data[10] -= 100;
		}
		else if (this.global1.allcountries[16].Gosstroy >= 1 && this.global1.data[14] >= 3 && this.global1.allcountries[16].isSEV && !this.global1.allcountries[this.global1.data[0]].Vyshi)
		{
			this.global1.data[10] -= 100;
		}
		if (this.global1.allcountries[10].Stasi)
		{
			this.global1.data[10] -= 50;
		}
		if (this.global1.allcountries[this.global1.data[0]].isOVD && (this.global1.allcountries[5].isOVD || this.global1.allcountries[6].isOVD) && (this.global1.data[54] >= 7 || (this.global1.allcountries[15].isOVD && this.global1.data[54] >= 5)) && !this.global1.allcountries[15].Help)
		{
			this.global1.data[10] -= 25;
		}
		if ((this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 1 && this.global1.data[10] > 450) || (!this.global1.allcountries[7].isSEV && this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy <= 1 && this.global1.data[10] > 550) || (!this.global1.allcountries[7].isSEV && !this.global1.is_gkchp && this.global1.data[10] > 700) || (this.global1.allcountries[7].isSEV && this.global1.data[10] > 850))
		{
			this.global1.data[46] = 4;
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
			return true;
		}
		return false;
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x000032E1 File Offset: 0x000014E1
	private void GoodEnding()
	{
		GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
		GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x00003D84 File Offset: 0x00001F84
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

	// Token: 0x04000268 RID: 616
	public bool is_left;

	// Token: 0x04000269 RID: 617
	public Sprite navel;

	// Token: 0x0400026A RID: 618
	public Sprite nenavel;

	// Token: 0x0400026B RID: 619
	private GlobalScript global1;

	// Token: 0x0400026C RID: 620
	private Yugoglobal yug1;

	// Token: 0x0400026D RID: 621
	private TimeScript time1;

	// Token: 0x0400026E RID: 622
	public TextMesh this_text;

	// Token: 0x0400026F RID: 623
	public TextMesh Name;

	// Token: 0x04000270 RID: 624
	public TextMesh End;

	// Token: 0x04000271 RID: 625
	private string fake_text;
}
