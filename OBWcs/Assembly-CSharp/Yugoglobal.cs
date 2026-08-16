using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200004D RID: 77
public class Yugoglobal : MonoBehaviour
{
	// Token: 0x0600015C RID: 348 RVA: 0x00003141 File Offset: 0x00001341
	public bool DoneBy()
	{
		if (Application.platform == RuntimePlatform.WindowsPlayer)
		{
			return File.Exists(Application.dataPath + "\\VRes\\1.jpg");
		}
		return File.Exists(Application.dataPath + "/VRes/1.jpg");
	}

	// Token: 0x0600015D RID: 349 RVA: 0x0019B058 File Offset: 0x00199258
	public void CreateWorld(int player)
	{
		this.CreateText();
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.gameState.has_ally = false;
		for (int i = 0; i < this.gameState.yugcountries.Length; i++)
		{
			this.gameState.yugcountries[i] = new YugoCountry();
			this.gameState.yugregions[i] = new YugoRegion();
			for (int j = 0; j < this.gameState.yugcountries[i].peace_with.Length; j++)
			{
				this.gameState.yugcountries[i].peace_with[j] = true;
				this.gameState.yugcountries[i].is_independent = false;
				this.gameState.yugcountries[i].army = 0;
				this.gameState.yugcountries[i].money = 0;
				this.gameState.yugcountries[i].last = false;
				this.gameState.yugcountries[i].have_regions = 0;
				this.gameState.yugcountries[i].temp_peace = false;
				this.gameState.yugcountries[i].temp_peace_time = 0;
				this.gameState.yugcountries[i].temp_peace_count = 0;
				this.gameState.yugcountries[i].is_ally = false;
			}
			this.MakeUpBuildingBot(i);
		}
		for (int k = 0; k < this.gameState.modifies.Length; k++)
		{
			this.gameState.modifies[k] = 0;
			this.gameState.modifies_time[k] = 0;
		}
		if (PlayerPrefs.GetInt("language") == 0)
		{
			this.gameState.yugcountries[0].name = " 斯 洛 文 尼 亚 共 和 国";
			this.gameState.yugcountries[1].name = " 克 罗 地 亚 共 和 国";
			this.gameState.yugcountries[2].name = " 塞 尔 维 亚 克 拉 伊 纳 共 和 国";
			this.gameState.yugcountries[3].name = " 波 斯 尼 亚 和 黑 塞 哥 维 纳";
			this.gameState.yugcountries[4].name = " 克 罗 地 亚 赫 塞 哥 波 斯 尼 亚 共 和 国";
			this.gameState.yugcountries[5].name = " 西 波 斯 尼 亚 省";
			this.gameState.yugcountries[6].name = " 塞 族 共 和 国";
			this.gameState.yugcountries[7].name = " 黑 山 共 和 国";
			this.gameState.yugcountries[8].name = " 塞 尔 维 亚 共 和 国";
			this.gameState.yugcountries[9].name = " 伏 伊 伏 丁 那 省";
			this.gameState.yugcountries[10].name = " 科 索 沃 共 和 国";
			this.gameState.yugcountries[11].name = " 马 其 顿 共 和 国";
			this.gameState.yugregions[0].name = " 斯 洛 文 尼 亚";
			this.gameState.yugregions[1].name = " 克 罗 地 亚";
			this.gameState.yugregions[2].name = " 塞 族 克 罗 地 亚";
			this.gameState.yugregions[3].name = " 波 斯 尼 亚 和 黑 塞 哥 维 纳";
			this.gameState.yugregions[4].name = " 克 族 波 斯 尼 亚 和 黑 塞 哥 维 纳";
			this.gameState.yugregions[5].name = " 西 波 斯 尼 亚";
			this.gameState.yugregions[6].name = " 塞 族 波 斯 尼 亚 和 黑 塞 哥 维 纳";
			this.gameState.yugregions[7].name = " 黑 山";
			this.gameState.yugregions[8].name = " 塞 尔 维 亚";
			this.gameState.yugregions[9].name = " 伏 伊 伏 丁 那";
			this.gameState.yugregions[10].name = " 黑 山";
			this.gameState.yugregions[11].name = " 马 其 顿";
		}
		else
		{
			this.gameState.yugcountries[0].name = "Республика Словения";
			this.gameState.yugcountries[1].name = "Республика Хорватия";
			this.gameState.yugcountries[2].name = "Республика Сербская Краина";
			this.gameState.yugcountries[3].name = "Босния и Герцеговина";
			this.gameState.yugcountries[4].name = "Хорватская Республика Герцег-Босна";
			this.gameState.yugcountries[5].name = "Республика Западная Босния";
			this.gameState.yugcountries[6].name = "Республика Сербская";
			this.gameState.yugcountries[7].name = "Республика Черногория";
			this.gameState.yugcountries[8].name = "Республика Сербия";
			this.gameState.yugcountries[9].name = "Федерация Воеводина";
			this.gameState.yugcountries[10].name = "Республика Косово";
			this.gameState.yugcountries[11].name = "Республика Македония";
			this.gameState.yugregions[0].name = "Словения";
			this.gameState.yugregions[1].name = "Хорватия";
			this.gameState.yugregions[2].name = "Сербская Хорватия";
			this.gameState.yugregions[3].name = "Босния и Герцеговина";
			this.gameState.yugregions[4].name = "Хорватская Босния и Герцеговина";
			this.gameState.yugregions[5].name = "Западная Босния";
			this.gameState.yugregions[6].name = "Сербская Босния и Герцеговина";
			this.gameState.yugregions[7].name = "Черногория";
			this.gameState.yugregions[8].name = "Сербия";
			this.gameState.yugregions[9].name = "Воеводина";
			this.gameState.yugregions[10].name = "Косово";
			this.gameState.yugregions[11].name = "Македония";
		}
		this.gameState.yugcountries[0].is_exist = true;
		this.gameState.yugcountries[0].army = 6;
		this.gameState.yugcountries[1].is_exist = true;
		this.gameState.yugcountries[1].army = 18;
		this.gameState.yugcountries[3].is_exist = true;
		this.gameState.yugcountries[3].army = 25;
		this.gameState.yugcountries[7].is_exist = true;
		this.gameState.yugcountries[7].army = 2;
		this.gameState.yugcountries[8].is_exist = true;
		this.gameState.yugcountries[8].army = 28;
		this.gameState.yugcountries[11].is_exist = true;
		this.gameState.yugcountries[11].army = 8;
		if (player == 49)
		{
			this.gameState.yugcountries[8].is_player = true;
			this.gameState.player = 8;
		}
		else if (player == 50)
		{
			this.gameState.yugcountries[3].is_player = true;
			this.gameState.player = 3;
		}
		else if (player == 51)
		{
			this.gameState.yugcountries[1].is_player = true;
			this.gameState.player = 1;
		}
		this.gameState.yugregions[0].owner = 0;
		this.gameState.yugregions[1].owner = 1;
		this.gameState.yugregions[2].owner = 1;
		this.gameState.yugregions[3].owner = 3;
		this.gameState.yugregions[4].owner = 3;
		this.gameState.yugregions[5].owner = 3;
		this.gameState.yugregions[6].owner = 3;
		this.gameState.yugregions[7].owner = 7;
		this.gameState.yugregions[8].owner = 8;
		this.gameState.yugregions[9].owner = 8;
		this.gameState.yugregions[10].owner = 8;
		this.gameState.yugregions[11].owner = 11;
		this.gameState.yugregions[0].population = 1996;
		this.gameState.yugregions[1].population = 4321;
		this.gameState.yugregions[2].population = 435;
		this.gameState.yugregions[3].population = 1648;
		this.gameState.yugregions[4].population = 1238;
		this.gameState.yugregions[5].population = 53;
		this.gameState.yugregions[6].population = 1569;
		this.gameState.yugregions[7].population = 606;
		this.gameState.yugregions[8].population = 3698;
		this.gameState.yugregions[9].population = 1932;
		this.gameState.yugregions[10].population = 1956;
		this.gameState.yugregions[11].population = 2100;
		this.gameState.yugregions[0].inreg = 0;
		this.gameState.yugregions[0].level = 0;
		this.gameState.yugregions[1].inreg = 0;
		this.gameState.yugregions[1].level = 5;
		this.gameState.yugregions[2].inreg = 0;
		this.gameState.yugregions[2].level = 10;
		this.gameState.yugregions[3].inreg = 1;
		this.gameState.yugregions[3].level = 0;
		this.gameState.yugregions[4].inreg = 1;
		this.gameState.yugregions[4].level = 5;
		this.gameState.yugregions[5].inreg = 1;
		this.gameState.yugregions[5].level = 10;
		this.gameState.yugregions[6].inreg = 4;
		this.gameState.yugregions[6].level = 0;
		this.gameState.yugregions[7].inreg = 4;
		this.gameState.yugregions[7].level = 5;
		this.gameState.yugregions[8].inreg = 3;
		this.gameState.yugregions[8].level = 0;
		this.gameState.yugregions[9].inreg = 3;
		this.gameState.yugregions[9].level = 5;
		this.gameState.yugregions[10].inreg = 3;
		this.gameState.yugregions[10].level = 10;
		this.gameState.yugregions[11].inreg = 4;
		this.gameState.yugregions[11].level = 10;
		this.gameState.yugregions[0].borders = new int[1];
		this.gameState.yugregions[0].borders[0] = 1;
		this.gameState.yugregions[1].borders = new int[6];
		this.gameState.yugregions[1].borders[0] = 0;
		this.gameState.yugregions[1].borders[1] = 2;
		this.gameState.yugregions[1].borders[2] = 4;
		this.gameState.yugregions[1].borders[3] = 6;
		this.gameState.yugregions[1].borders[4] = 7;
		this.gameState.yugregions[1].borders[5] = 9;
		this.gameState.yugregions[2].borders = new int[5];
		this.gameState.yugregions[2].borders[0] = 1;
		this.gameState.yugregions[2].borders[1] = 5;
		this.gameState.yugregions[2].borders[2] = 4;
		this.gameState.yugregions[2].borders[3] = 6;
		this.gameState.yugregions[2].borders[4] = 3;
		this.gameState.yugregions[3].borders = new int[4];
		this.gameState.yugregions[3].borders[0] = 1;
		this.gameState.yugregions[3].borders[1] = 2;
		this.gameState.yugregions[3].borders[2] = 4;
		this.gameState.yugregions[3].borders[3] = 6;
		this.gameState.yugregions[4].borders = new int[4];
		this.gameState.yugregions[4].borders[0] = 1;
		this.gameState.yugregions[4].borders[1] = 2;
		this.gameState.yugregions[4].borders[2] = 3;
		this.gameState.yugregions[4].borders[3] = 6;
		this.gameState.yugregions[5].borders = new int[2];
		this.gameState.yugregions[5].borders[0] = 2;
		this.gameState.yugregions[5].borders[1] = 6;
		this.gameState.yugregions[6].borders = new int[8];
		this.gameState.yugregions[6].borders[0] = 1;
		this.gameState.yugregions[6].borders[1] = 2;
		this.gameState.yugregions[6].borders[2] = 3;
		this.gameState.yugregions[6].borders[3] = 4;
		this.gameState.yugregions[6].borders[4] = 5;
		this.gameState.yugregions[6].borders[5] = 7;
		this.gameState.yugregions[6].borders[6] = 8;
		this.gameState.yugregions[6].borders[7] = 9;
		this.gameState.yugregions[7].borders = new int[4];
		this.gameState.yugregions[7].borders[0] = 6;
		this.gameState.yugregions[7].borders[1] = 1;
		this.gameState.yugregions[7].borders[2] = 8;
		this.gameState.yugregions[7].borders[3] = 10;
		this.gameState.yugregions[8].borders = new int[5];
		this.gameState.yugregions[8].borders[0] = 6;
		this.gameState.yugregions[8].borders[1] = 7;
		this.gameState.yugregions[8].borders[2] = 9;
		this.gameState.yugregions[8].borders[3] = 10;
		this.gameState.yugregions[8].borders[4] = 11;
		this.gameState.yugregions[9].borders = new int[3];
		this.gameState.yugregions[9].borders[0] = 1;
		this.gameState.yugregions[9].borders[1] = 6;
		this.gameState.yugregions[9].borders[2] = 8;
		this.gameState.yugregions[10].borders = new int[3];
		this.gameState.yugregions[10].borders[0] = 7;
		this.gameState.yugregions[10].borders[1] = 8;
		this.gameState.yugregions[10].borders[2] = 11;
		this.gameState.yugregions[11].borders = new int[2];
		this.gameState.yugregions[11].borders[0] = 8;
		this.gameState.yugregions[11].borders[1] = 10;
		for (int l = 0; l < this.gameState.yugcountries.Length; l++)
		{
			this.gameState.yugregions[l].defence = this.DefenceRegionalPower(l);
		}
	}

	// Token: 0x0600015E RID: 350 RVA: 0x0019C0C4 File Offset: 0x0019A2C4
	private void CreateText()
	{
		string text;
		if (PlayerPrefs.GetInt("language") == 0)
		{
			text = "en";
		}
		else
		{
			text = "ru";
		}
		TextAsset textAsset = Resources.Load(string.Format("{0}_text/science_text", text)) as TextAsset;
		this.science_text = textAsset.text.Split(new char[] { '\n' });
		Resources.UnloadAsset(textAsset);
	}

	// Token: 0x0600015F RID: 351 RVA: 0x0019C124 File Offset: 0x0019A324
	public void ChangeLeaders()
	{
		string text;
		if (PlayerPrefs.GetInt("language") == 0)
		{
			text = "en";
		}
		else
		{
			text = "ru";
		}
		TextAsset textAsset = Resources.Load(string.Format("{0}_text/polit_text", text)) as TextAsset;
		string[] array = textAsset.text.Split(new char[] { '\n' });
		Resources.UnloadAsset(textAsset);
		string[] array2 = array[0].Split(new char[] { ':' });
		string[] array3 = array[1].Split(new char[] { ':' });
		string[] array4 = array[2].Split(new char[] { ':' });
		for (int i = 0; i < array2.Length; i++)
		{
			string[] array5 = array2[i].Split(new char[] { ';' });
			string[] array6 = array3[i].Split(new char[] { ';' });
			string[] array7 = array4[i].Split(new char[] { ';' });
			if (int.Parse(array5[0]) == this.global1.data[0])
			{
				this.global1.politics_name[0] = array5[1];
				this.global1.politics_name[1] = array5[2];
				this.global1.politics_name[2] = array5[3];
				this.global1.politics_name[3] = array5[4];
				this.global1.politics_name[4] = array5[5];
				this.global1.politics_name[5] = array5[6];
				this.global1.politics_name[6] = array5[7];
				this.global1.politics_name[7] = array5[8];
				this.global1.politics_name[8] = array5[9];
				this.global1.politics_name[9] = array5[10];
				this.global1.politics_charact[0] = array6[1];
				this.global1.politics_charact[1] = array6[2];
				this.global1.politics_charact[2] = array6[3];
				this.global1.politics_charact[3] = array6[4];
				this.global1.politics_charact[4] = array6[5];
				this.global1.politics_charact[5] = array6[6];
				this.global1.politics_charact[6] = array6[7];
				this.global1.politics_charact[7] = array6[8];
				this.global1.politics_charact[8] = array6[9];
				this.global1.politics_charact[9] = array6[10];
				this.global1.politics_opis[0] = array7[1].Replace("|", "\n");
				this.global1.politics_opis[1] = array7[2].Replace("|", "\n");
				this.global1.politics_opis[2] = array7[3].Replace("|", "\n");
				this.global1.politics_opis[3] = array7[4].Replace("|", "\n");
				this.global1.politics_opis[4] = array7[5].Replace("|", "\n");
				this.global1.politics_opis[5] = array7[6].Replace("|", "\n");
				this.global1.politics_opis[6] = array7[7].Replace("|", "\n");
				this.global1.politics_opis[7] = array7[8].Replace("|", "\n");
				this.global1.politics_opis[8] = array7[9].Replace("|", "\n");
				this.global1.politics_opis[9] = array7[10].Replace("|", "\n");
				break;
			}
		}
		this.ChangeParties();
	}

	// Token: 0x06000160 RID: 352 RVA: 0x0019C4D8 File Offset: 0x0019A6D8
	public void ChangeParties()
	{
		string[] array = this.science_text[178].Split(new char[] { ':' });
		if (this.global1.data[0] == 51)
		{
			if (this.global1.party_name[0] == array[0] || this.global1.party_name[0] == array[1])
			{
				if (this.global1.data[11] == 3)
				{
					this.global1.party_name[0] = this.science_text[115];
				}
				else if (this.global1.data[11] == 2)
				{
					this.global1.party_name[0] = this.science_text[116];
				}
				else
				{
					this.global1.party_name[0] = this.science_text[117];
				}
			}
			this.global1.party_name[1] = this.science_text[118];
			this.global1.party_name[2] = this.science_text[119];
			this.global1.party_name[4] = this.science_text[121];
		}
		else if (this.global1.data[0] == 50)
		{
			if (this.global1.party_name[0] == array[0] || this.global1.party_name[0] == array[1])
			{
				if (this.global1.data[11] == 1)
				{
					this.global1.party_name[0] = this.science_text[122];
				}
				else if (this.global1.data[11] == 2)
				{
					this.global1.party_name[0] = this.science_text[123];
				}
				else
				{
					this.global1.party_name[0] = this.science_text[124];
				}
			}
			this.global1.party_name[1] = this.science_text[125];
			this.global1.party_name[2] = this.science_text[126];
		}
		else if (this.global1.data[0] == 49)
		{
			if (this.global1.party_name[0] == array[0] || this.global1.party_name[0] == array[1])
			{
				if (this.global1.data[11] == 0)
				{
					this.global1.party_name[0] = this.science_text[129];
				}
				else if (this.global1.data[11] == 1)
				{
					this.global1.party_name[0] = this.science_text[130];
				}
				else
				{
					this.global1.party_name[0] = this.science_text[131];
				}
			}
			this.global1.party_name[1] = this.science_text[132];
			this.global1.party_name[2] = this.science_text[133];
			this.global1.party_name[3] = this.science_text[134];
		}
		if (this.global1.allcountries[this.global1.data[0]].subideology == 5)
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				this.global1.party_name[0] = this.global1.allcountries[this.global1.data[0]].name + " 社 会 主 义 工 人 党 (" + this.global1.allcountries[this.global1.data[0]].name + " 工 人 党)";
				return;
			}
			this.global1.party_name[0] = this.global1.allcountries[this.global1.data[0]].name.Substring(0, 1) + "СРИ (РП" + this.global1.allcountries[this.global1.data[0]].name.Substring(0, 1) + ")";
			return;
		}
		else
		{
			if (this.global1.allcountries[this.global1.data[0]].subideology != 6)
			{
				if (this.global1.allcountries[this.global1.data[0]].subideology == 7)
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.party_name[0] = this.global1.allcountries[this.global1.data[0]].name + " 革 命 共 产 党 （ 马 列 ）";
						return;
					}
					this.global1.party_name[0] = "РКП" + this.global1.allcountries[this.global1.data[0]].name.Substring(0, 1) + " (МЛ)";
				}
				return;
			}
			if (PlayerPrefs.GetInt("language") == 0)
			{
				this.global1.party_name[0] = this.global1.allcountries[this.global1.data[0]].name + " 共 产 党 （ 马 列 ）";
				return;
			}
			this.global1.party_name[0] = "КП" + this.global1.allcountries[this.global1.data[0]].name.Substring(0, 1) + " (МЛ)";
			return;
		}
	}

	// Token: 0x06000161 RID: 353 RVA: 0x0019CA0C File Offset: 0x0019AC0C
	public void SetBattleRoyal()
	{
		for (int i = 0; i < this.gameState.yugcountries.Length; i++)
		{
			this.gameState.yugcountries[i].is_exist = true;
			this.gameState.yugregions[i].owner = i;
			for (int j = 0; j < this.gameState.yugcountries[i].peace_with.Length; j++)
			{
				this.gameState.yugcountries[i].peace_with[j] = true;
				this.gameState.yugcountries[i].last = true;
				this.gameState.yugcountries[i].have_regions = 1;
			}
		}
		this.gameState.yugcountries[2].army = this.gameState.yugcountries[1].army / 10;
		this.gameState.yugcountries[1].army -= this.gameState.yugcountries[2].army;
		this.gameState.yugcountries[4].army = this.gameState.yugcountries[3].army * 27 / 100;
		this.gameState.yugcountries[5].army = this.gameState.yugcountries[3].army / 100;
		this.gameState.yugcountries[6].army = this.gameState.yugcountries[3].army * 34 / 100;
		this.gameState.yugcountries[3].army -= this.gameState.yugcountries[4].army + this.gameState.yugcountries[5].army + this.gameState.yugcountries[6].army;
		this.gameState.yugcountries[9].army = this.gameState.yugcountries[8].army / 4;
		this.gameState.yugcountries[10].army = this.gameState.yugcountries[8].army / 4;
		this.gameState.yugcountries[8].army -= this.gameState.yugcountries[9].army + this.gameState.yugcountries[10].army;
		for (int k = 0; k < this.gameState.yugregions.Length; k++)
		{
			this.gameState.yugregions[k].defence = this.DefenceRegionalPower(k);
		}
	}

	// Token: 0x06000162 RID: 354 RVA: 0x0019CC94 File Offset: 0x0019AE94
	public void StartBattleRoyal()
	{
		for (int i = 0; i < this.gameState.yugcountries.Length; i++)
		{
			this.gameState.yugcountries[i].is_exist = true;
			this.gameState.yugcountries[i].is_independent = true;
			this.gameState.yugregions[i].owner = i;
			for (int j = 0; j < this.gameState.yugcountries[i].peace_with.Length; j++)
			{
				this.gameState.yugcountries[i].peace_with[j] = false;
			}
		}
	}

	// Token: 0x06000163 RID: 355 RVA: 0x0019CD2C File Offset: 0x0019AF2C
	public bool IsLastOne(int country)
	{
		int num = 0;
		foreach (YugoRegion yugoRegion in this.gameState.yugregions)
		{
			if (num > 1)
			{
				return false;
			}
			if (yugoRegion.owner == country)
			{
				num++;
			}
		}
		this.gameState.yugcountries[country].have_regions = this.SummRegions(country);
		return true;
	}

	// Token: 0x06000164 RID: 356 RVA: 0x0019CD88 File Offset: 0x0019AF88
	private void MakeUpBuildingBot(int country)
	{
		for (int i = 0; i < this.gameState.yugcountries[country].build.Length; i++)
		{
			this.gameState.yugcountries[country].build[i] = global::UnityEngine.Random.Range(1, 12);
			if (this.gameState.yugcountries[country].build[i] == 7)
			{
				this.gameState.yugcountries[country].build[i] = 15;
			}
			else if (this.gameState.yugcountries[country].build[i] == 9)
			{
				this.gameState.yugcountries[country].build[i] = 17;
			}
			else if (this.gameState.yugcountries[country].build[i] == 3)
			{
				this.gameState.yugcountries[country].build[i] = 24;
			}
		}
	}

	// Token: 0x06000165 RID: 357 RVA: 0x0019CE64 File Offset: 0x0019B064
	public int DefenceRegionalPower(int yreg)
	{
		int num = this.gameState.yugregions[yreg].population / 25;
		for (int i = this.gameState.yugregions[yreg].level; i < this.gameState.yugregions[yreg].level + 5; i++)
		{
			if (this.global1.regions[this.gameState.yugregions[yreg].inreg].buildings[i].type != 0)
			{
				num += 10;
				if (this.global1.regions[this.gameState.yugregions[yreg].inreg].buildings[i].type == 10 || this.global1.regions[this.gameState.yugregions[yreg].inreg].buildings[i].type == 8 || this.global1.regions[this.gameState.yugregions[yreg].inreg].buildings[i].type == 2 || this.global1.regions[this.gameState.yugregions[yreg].inreg].buildings[i].type == 3)
				{
					num += 5;
				}
				else if (this.global1.regions[this.gameState.yugregions[yreg].inreg].buildings[i].type == 4 || this.global1.regions[this.gameState.yugregions[yreg].inreg].buildings[i].type == 7)
				{
					num += 10;
				}
			}
			if (this.gameState.yugcountries[this.gameState.yugregions[yreg].owner].army > 0 && !this.gameState.yugcountries[this.gameState.yugregions[yreg].owner].is_player)
			{
				num += this.gameState.yugcountries[this.gameState.yugregions[yreg].owner].army / 3;
			}
		}
		if (this.gameState.yugcountries[this.gameState.yugregions[yreg].owner].last)
		{
			if (this.gameState.yugcountries[this.gameState.yugregions[yreg].owner].army > 0)
			{
				if (!this.gameState.yugcountries[this.gameState.yugregions[yreg].owner].is_player)
				{
					num += this.gameState.yugcountries[this.gameState.yugregions[yreg].owner].army + 40;
				}
				else
				{
					num += this.gameState.yugcountries[this.gameState.yugregions[yreg].owner].army + 20;
				}
			}
		}
		else if (this.gameState.yugcountries[this.gameState.yugregions[yreg].owner].army > 0 && this.gameState.yugcountries[this.gameState.yugregions[yreg].owner].have_regions > 0 && !this.gameState.yugcountries[this.gameState.yugregions[yreg].owner].is_player)
		{
			num += this.gameState.yugcountries[this.gameState.yugregions[yreg].owner].army / this.gameState.yugcountries[this.gameState.yugregions[yreg].owner].have_regions;
		}
		if ((yreg == 10 || yreg == 11) && this.gameState.yugregions[yreg].owner != this.gameState.player)
		{
			if (this.global1.event_done[1001])
			{
				num *= 2;
			}
			if (this.global1.event_done[1002] && yreg == 11)
			{
				num *= 2;
			}
		}
		return num;
	}

	// Token: 0x06000166 RID: 358 RVA: 0x0019D270 File Offset: 0x0019B470
	public void MoneyGetBot()
	{
		foreach (YugoRegion yugoRegion in this.gameState.yugregions)
		{
			this.gameState.yugcountries[yugoRegion.owner].money += yugoRegion.population / 100;
			this.gameState.yugcountries[yugoRegion.owner].money += 5;
		}
	}

	// Token: 0x06000167 RID: 359 RVA: 0x0019D2E4 File Offset: 0x0019B4E4
	public void BuildingBot(int reg, int level)
	{
		int owner = this.gameState.yugregions[reg].owner;
		int num = this.global1.data[20] / 3 + 3 * (this.global1.data[21] - 1989);
		if (num >= 9)
		{
			num -= 9;
		}
		for (int i = level; i < level + 4; i++)
		{
			if (this.global1.regions[this.gameState.yugregions[reg].inreg].buildings[i].type == 0 && this.gameState.yugcountries[owner].money >= 100)
			{
				Debug.Log(string.Concat(new object[]
				{
					this.gameState.yugcountries[owner].name,
					" построил ",
					this.gameState.yugcountries[owner].build[num],
					" в ",
					this.gameState.yugregions[reg].name,
					", МЕСТО: ",
					i
				}));
				this.global1.regions[this.gameState.yugregions[reg].inreg].buildings[i].type = this.gameState.yugcountries[owner].build[num];
				this.global1.regions[this.gameState.yugregions[reg].inreg].buildings[i].is_builded = true;
				this.global1.regions[this.gameState.yugregions[reg].inreg].buildings[i].is_working = true;
				this.gameState.yugcountries[owner].money -= 100;
			}
			else if ((this.global1.regions[this.gameState.yugregions[reg].inreg].buildings[i].type < 25 || this.global1.regions[this.gameState.yugregions[reg].inreg].buildings[i].type > 36) && this.global1.regions[this.gameState.yugregions[reg].inreg].buildings[i].type != 0 && this.global1.regions[this.gameState.yugregions[reg].inreg].buildings[i].type != this.gameState.yugcountries[owner].build[num] && this.gameState.yugcountries[owner].money >= 300)
			{
				this.global1.regions[this.gameState.yugregions[reg].inreg].buildings[i].type = 0;
				this.global1.regions[this.gameState.yugregions[reg].inreg].buildings[i].is_builded = false;
				this.global1.regions[this.gameState.yugregions[reg].inreg].buildings[i].is_working = false;
				this.gameState.yugcountries[owner].money -= 300;
			}
		}
	}

	// Token: 0x06000168 RID: 360 RVA: 0x0019D64C File Offset: 0x0019B84C
	public void ArmyAutoGrowth(int country, ref int army)
	{
		for (int i = 0; i < this.gameState.yugregions.Length; i++)
		{
			if (army < 0)
			{
				army = 0;
			}
			if (army > 1000)
			{
				army = 1000;
			}
			if (this.gameState.yugregions[i].owner == country)
			{
				army += this.gameState.yugregions[i].population / 100;
				for (int j = this.gameState.yugregions[i].level; j < this.gameState.yugregions[i].level + 4; j++)
				{
					if (this.global1.regions[this.gameState.yugregions[i].inreg].buildings[j].type != 0)
					{
						army += 3;
						if (this.global1.regions[this.gameState.yugregions[i].inreg].buildings[j].type == 10 || this.global1.regions[this.gameState.yugregions[i].inreg].buildings[j].type == 8 || this.global1.regions[this.gameState.yugregions[i].inreg].buildings[j].type == 2 || this.global1.regions[this.gameState.yugregions[i].inreg].buildings[j].type == 3)
						{
							army += 6;
						}
						else if (this.global1.regions[this.gameState.yugregions[i].inreg].buildings[j].type == 4 || this.global1.regions[this.gameState.yugregions[i].inreg].buildings[j].type == 7)
						{
							army += 9;
						}
					}
				}
			}
		}
		this.AmericanHelpToBots(country, ref army);
		army -= army / 9;
		for (int k = 0; k < this.global1.science.Length; k++)
		{
			if (country == this.gameState.player)
			{
				if (k == 1 || k == 7)
				{
					if (this.global1.science[k])
					{
						army += army / 40;
					}
				}
				else if (k == 2)
				{
					if (this.global1.science[k])
					{
						army += army / 20;
					}
				}
				else if (k == 0 && this.global1.science[k])
				{
					army += army / 100;
				}
			}
			else if (k == 6)
			{
				if (this.global1.science[k])
				{
					army -= army / 100;
				}
			}
			else if (k == 8 && this.global1.science[k])
			{
				army -= army / 50;
			}
		}
	}

	// Token: 0x06000169 RID: 361 RVA: 0x0019D92C File Offset: 0x0019BB2C
	public void AmericanHelpToBots(int country, ref int army)
	{
		if (!this.gameState.yugcountries[country].peace_with[this.gameState.player] && !this.gameState.yugcountries[this.gameState.player].peace_with[country] && country != this.gameState.player)
		{
			army += this.global1.data[10] / (100 - this.global1.data[10] + 1);
			this.gameState.yugcountries[country].money += this.global1.data[10] / 100;
		}
	}

	// Token: 0x0600016A RID: 362 RVA: 0x0019D9D8 File Offset: 0x0019BBD8
	public void AttackAmongBots(int attacker, int yreg)
	{
		if (this.gameState.yugcountries[attacker].have_regions > 0)
		{
			int num = this.gameState.yugcountries[attacker].army / this.gameState.yugcountries[attacker].have_regions;
			this.gameState.yugregions[yreg].defence -= num;
			if (this.gameState.yugregions[yreg].defence < 0)
			{
				this.gameState.yugregions[yreg].owner = attacker;
				this.gameState.yugregions[yreg].population -= this.gameState.yugregions[yreg].population / 25;
				this.gameState.yugregions[yreg].defence = this.DefenceRegionalPower(yreg);
			}
			else
			{
				this.gameState.yugcountries[this.gameState.yugregions[yreg].owner].army -= num;
				this.gameState.yugregions[yreg].defence = this.DefenceRegionalPower(yreg);
			}
			this.gameState.yugcountries[attacker].army -= num;
			if (this.gameState.yugcountries[attacker].army <= 4)
			{
				this.gameState.yugcountries[attacker].army = 5;
			}
			this.KillCountry(this.gameState.yugregions[yreg].owner);
		}
	}

	// Token: 0x0600016B RID: 363 RVA: 0x0019DB4C File Offset: 0x0019BD4C
	public void AttackAgainstBot(int yreg, int player)
	{
		this.gameState.yugcountries[player].army -= 35 * (1 + this.global1.data[215] / 2);
		if (this.gameState.yugcountries[yreg].army > 0)
		{
			this.gameState.yugcountries[yreg].army -= 35 * (2 + this.global1.data[215] / 2);
		}
		else if (35 - this.global1.data[215] * 3 > 0)
		{
			this.gameState.yugregions[yreg].defence -= 35 - this.global1.data[215] * 3;
		}
		else
		{
			YugoRegion yugoRegion = this.gameState.yugregions[yreg];
			yugoRegion.defence = yugoRegion.defence;
		}
		if (!this.global1.science[2] && this.gameState.battle_royal)
		{
			this.global1.data[215]++;
		}
		else if (this.global1.science[2])
		{
			this.gameState.yugregions[yreg].defence -= 20;
		}
		else if (this.global1.science[1])
		{
			this.gameState.yugregions[yreg].defence -= 10;
		}
		else if (this.global1.science[0])
		{
			this.gameState.yugregions[yreg].defence -= 5;
		}
		if (this.gameState.yugregions[yreg].defence >= 1500)
		{
			this.gameState.yugregions[yreg].defence = 1500;
		}
		if (this.gameState.yugregions[yreg].defence <= 0)
		{
			this.gameState.yugregions[yreg].owner = player;
			this.gameState.yugregions[yreg].population -= this.gameState.yugregions[yreg].population / 25;
		}
		this.KillCountry(this.gameState.yugregions[yreg].owner);
	}

	// Token: 0x0600016C RID: 364 RVA: 0x0019DD90 File Offset: 0x0019BF90
	public void AttackAgainstBotx3(int yreg, int player)
	{
		this.gameState.yugcountries[player].army -= 110 * (1 + this.global1.data[215] / 2);
		if (this.gameState.yugcountries[yreg].army > 0)
		{
			this.gameState.yugcountries[yreg].army -= 110 * (2 + this.global1.data[215] / 2);
		}
		else if (110 - this.global1.data[215] * 3 > 0)
		{
			this.gameState.yugregions[yreg].defence -= 110 - this.global1.data[215] * 3;
		}
		else
		{
			YugoRegion yugoRegion = this.gameState.yugregions[yreg];
			yugoRegion.defence = yugoRegion.defence;
		}
		if (!this.global1.science[2] && this.gameState.battle_royal)
		{
			this.global1.data[215] += 3;
		}
		else if (this.global1.science[2])
		{
			this.gameState.yugregions[yreg].defence -= 60;
		}
		else if (this.global1.science[1])
		{
			this.gameState.yugregions[yreg].defence -= 40;
		}
		else if (this.global1.science[0])
		{
			this.gameState.yugregions[yreg].defence -= 20;
		}
		if (this.gameState.yugregions[yreg].defence <= 0)
		{
			this.gameState.yugregions[yreg].owner = player;
			this.gameState.yugregions[yreg].population -= this.gameState.yugregions[yreg].population / 25 * 3;
		}
		this.KillCountry(this.gameState.yugregions[yreg].owner);
	}

	// Token: 0x0600016D RID: 365 RVA: 0x0019DFA8 File Offset: 0x0019C1A8
	public void RegionDefence(int yreg, int player)
	{
		this.gameState.yugregions[yreg].control += 25;
		this.gameState.yugcountries[player].army -= 50;
		if (this.gameState.yugregions[yreg].control > 100)
		{
			this.gameState.yugregions[yreg].control = 100;
		}
	}

	// Token: 0x0600016E RID: 366 RVA: 0x0019E018 File Offset: 0x0019C218
	public void MakeTempPeace(int country)
	{
		this.gameState.yugcountries[country].temp_peace = !this.gameState.yugcountries[country].temp_peace;
		if (this.gameState.yugcountries[country].temp_peace)
		{
			this.gameState.yugcountries[country].temp_peace_time = 4;
			this.gameState.yugcountries[country].temp_peace_count++;
		}
	}

	// Token: 0x0600016F RID: 367 RVA: 0x0019E090 File Offset: 0x0019C290
	public void KillCountry(int country)
	{
		int num = 0;
		if (!this.gameState.battle_royal)
		{
			if (this.global1.data[0] == 49)
			{
				this.gameState.yugcountries[8].is_player = true;
				this.gameState.yugcountries[3].is_player = false;
				this.gameState.yugcountries[1].is_player = false;
				this.gameState.player = 8;
			}
			else if (this.global1.data[0] == 50)
			{
				this.gameState.yugcountries[3].is_player = true;
				this.gameState.yugcountries[8].is_player = false;
				this.gameState.yugcountries[1].is_player = false;
				this.gameState.player = 3;
			}
			else if (this.global1.data[0] == 51)
			{
				this.gameState.yugcountries[1].is_player = true;
				this.gameState.yugcountries[3].is_player = false;
				this.gameState.yugcountries[8].is_player = false;
				this.gameState.player = 1;
			}
		}
		for (int i = 0; i < this.gameState.yugregions.Length; i++)
		{
			if (this.gameState.yugregions[i].owner == country)
			{
				num++;
			}
		}
		if (num <= 0 && !this.gameState.yugcountries[country].is_player)
		{
			this.gameState.yugcountries[country].is_exist = false;
			this.gameState.yugcountries[country].is_independent = false;
			if (this.gameState.yugcountries[country].is_ally)
			{
				this.gameState.yugcountries[country].is_ally = false;
				this.gameState.has_ally = false;
				return;
			}
		}
		else
		{
			if (num <= 0 && this.gameState.yugcountries[country].is_player)
			{
				this.global1.data[46] = -1;
				SceneManager.LoadScene("Ending");
				return;
			}
			this.gameState.yugcountries[country].last = this.IsLastOne(country);
		}
	}

	// Token: 0x06000170 RID: 368 RVA: 0x0019E2A8 File Offset: 0x0019C4A8
	public int SummRegions(int country)
	{
		int num = 0;
		for (int i = 0; i < this.gameState.yugregions.Length; i++)
		{
			if (this.gameState.yugregions[i].owner == country)
			{
				num++;
			}
		}
		if (num <= 0)
		{
			this.KillCountry(country);
		}
		return num;
	}

	// Token: 0x06000171 RID: 369 RVA: 0x0019E2F4 File Offset: 0x0019C4F4
	private float HeureticAlgoAttack(YugoRegion reg, int attacker)
	{
		float num = ((this.gameState.yugcountries[attacker].army / this.gameState.yugcountries[attacker].have_regions >= this.gameState.yugcountries[reg.owner].army / this.gameState.yugcountries[reg.owner].have_regions) ? ((float)reg.defence) : ((float)reg.defence * 1.2f));
		num += (float)(this.gameState.yugcountries[reg.owner].army / 2);
		num = ((reg.owner == this.gameState.player) ? (num * 0.75f) : num);
		if (!this.gameState.battle_royal)
		{
			num = ((reg.owner == this.gameState.player) ? (num * 0.75f) : num);
		}
		return num;
	}

	// Token: 0x06000172 RID: 370 RVA: 0x0019E3D8 File Offset: 0x0019C5D8
	public bool IsBorderedreion(int region, int country, bool dont_need = false)
	{
		if (country != this.gameState.player)
		{
			foreach (YugoRegion yugoRegion in this.gameState.yugregions)
			{
				if (yugoRegion.owner == country)
				{
					int[] borders = yugoRegion.borders;
					for (int j = 0; j < borders.Length; j++)
					{
						if (borders[j] == region)
						{
							return true;
						}
					}
				}
			}
		}
		else
		{
			foreach (YugoRegion yugoRegion2 in this.gameState.yugregions)
			{
				if (yugoRegion2.owner == country)
				{
					int[] borders2 = yugoRegion2.borders;
					for (int k = 0; k < borders2.Length; k++)
					{
						if (borders2[k] == region)
						{
							return true;
						}
					}
				}
				else if (!dont_need)
				{
					for (int l = 0; l < this.gameState.yugcountries.Length; l++)
					{
						if (yugoRegion2.owner == l && !this.gameState.yugcountries[l].is_independent && this.gameState.yugcountries[l].peace_with[this.gameState.player])
						{
							int[] borders3 = yugoRegion2.borders;
							for (int m = 0; m < borders3.Length; m++)
							{
								if (borders3[m] == region)
								{
									return true;
								}
							}
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06000173 RID: 371 RVA: 0x0019E528 File Offset: 0x0019C728
	public void ChooseAttackBot(int country)
	{
		List<int> list = new List<int>();
		int num = -1;
		float num2 = float.PositiveInfinity;
		foreach (YugoRegion yugoRegion in this.gameState.yugregions)
		{
			if (yugoRegion.owner == country)
			{
				foreach (int num3 in yugoRegion.borders)
				{
					if (!list.Contains(num3))
					{
						list.Add(num3);
					}
				}
			}
		}
		foreach (int num4 in list)
		{
			float num5 = this.HeureticAlgoAttack(this.gameState.yugregions[num4], country);
			if (this.gameState.yugregions[num4].owner != country && !this.gameState.yugcountries[country].peace_with[this.gameState.yugregions[num4].owner] && !this.gameState.yugcountries[this.gameState.yugregions[num4].owner].peace_with[country] && (this.gameState.yugregions[num4].owner != this.gameState.player || (!this.gameState.yugcountries[country].temp_peace && !this.gameState.yugcountries[country].is_ally)) && num5 < num2)
			{
				num = num4;
				num2 = num5;
			}
		}
		if (num != -1)
		{
			Debug.Log("АТАКА: " + this.gameState.yugregions[num].name);
			this.AttackByBot(country, num);
		}
	}

	// Token: 0x06000174 RID: 372 RVA: 0x0019E6E8 File Offset: 0x0019C8E8
	public void AttackByBot(int country, int yreg)
	{
		if (this.gameState.yugcountries[this.gameState.yugregions[yreg].owner].is_player)
		{
			if (this.gameState.yugregions[yreg].control >= 100)
			{
				this.gameState.yugregions[yreg].control -= 20;
				this.global1.number_event = 354;
				this.gameState.yugcountries[country].army -= this.gameState.yugcountries[country].army / this.gameState.yugcountries[country].have_regions;
				if (this.gameState.regionUnderAttack < 0)
				{
					this.gameState.regionUnderAttack = yreg;
					this.gameState.who_attack = country;
					return;
				}
				for (int i = 0; i < this.gameState.regionsAttacked.Length; i++)
				{
					if (this.gameState.regionsAttacked[i] < 0)
					{
						this.gameState.regionsAttacked[i] = yreg;
						this.gameState.whoAttacked[i] = country;
						return;
					}
				}
				return;
			}
			else if (this.gameState.yugregions[yreg].control < 100)
			{
				this.gameState.yugcountries[country].army -= this.gameState.yugcountries[country].army / this.gameState.yugcountries[country].have_regions;
				this.gameState.yugregions[yreg].control -= 25 - this.gameState.yugregions[yreg].defence / 20;
				if (this.gameState.yugregions[yreg].control <= 0)
				{
					this.gameState.yugregions[yreg].owner = country;
					this.gameState.yugregions[yreg].control = 100;
					this.gameState.yugregions[yreg].population -= this.gameState.yugregions[yreg].population / 25;
					this.KillCountry(this.gameState.yugregions[yreg].owner);
					return;
				}
			}
		}
		else
		{
			this.AttackAmongBots(country, yreg);
		}
	}

	// Token: 0x04000213 RID: 531
	public GameState gameState;

	// Token: 0x04000214 RID: 532
	private GlobalScript global1;

	// Token: 0x04000215 RID: 533
	public string[] science_text;
}
