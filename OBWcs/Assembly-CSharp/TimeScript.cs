using System;
using System.IO;
using ReqEventsDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200003E RID: 62
public class TimeScript : MonoBehaviour
{
	// Token: 0x0600010D RID: 269 RVA: 0x0015AF00 File Offset: 0x00159100
	private bool pastDate(int day, int month, int year)
	{
		return (this.global1.data[19] >= day && this.global1.data[20] == month && this.global1.data[21] == year) || (this.global1.data[20] > month && this.global1.data[21] == year) || this.global1.data[21] > year;
	}

	// Token: 0x0600010E RID: 270 RVA: 0x0015AF78 File Offset: 0x00159178
	private bool checkWas(int place, int num)
	{
		if (!this.events[place].activeSelf && !this.global1.event_done[num])
		{
			this.this_num_event = num;
			this.this_num_place = place;
		}
		return (this.global1.data[216] <= 49 || this.events[15].activeSelf) && (this.events[place].activeSelf || this.global1.event_done[num]);
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00002D11 File Offset: 0x00000F11
	private bool FindNumOfEvent(int num)
	{
		Debug.Log(num);
		return true;
	}

	// Token: 0x06000110 RID: 272 RVA: 0x0015AFFC File Offset: 0x001591FC
	private void Awake()
	{
		this.map1 = GameObject.Find("MapChanges").GetComponent<MapChangesScript>();
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.goto_economy = GameObject.Find("Button (2)").GetComponent<EvetnnashScript>();
		this.goto_pause = GameObject.Find("Button (0)").GetComponent<SpeedScript>();
		this.achieves = GameObject.Find("Ach(Clone)");
		if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
		{
			this.yug1 = GameObject.Find("Yugoglobal(Clone)").GetComponent<Yugoglobal>();
			this.view.GetComponent<EvetnnashScript>().new_scene = "Creator";
			this.view.transform.GetChild(0).GetComponent<TextMesh>().text = this.yug1.science_text[51];
		}
		this.Repaint(false);
		if (this.global1.data[0] == 10 || this.global1.data[0] == 12 || this.global1.data[0] == 18)
		{
			this.newcountries.SetActive(true);
		}
		else
		{
			try
			{
				if (Application.platform == RuntimePlatform.WindowsPlayer)
				{
					if (File.Exists(Application.dataPath + "\\lefty".ToString() + ".txt"))
					{
						this.newcountries.SetActive(true);
					}
				}
				else if (File.Exists(Application.dataPath + "/lefty".ToString() + ".txt"))
				{
					this.newcountries.SetActive(true);
				}
			}
			catch
			{
			}
		}
		if (this.global1.data[0] == 5 && this.global1.data[59] == 1)
		{
			this.special[0].SetActive(true);
			this.donedone = true;
		}
		else if (((this.global1.data[0] == 6 || this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51) && this.global1.data[59] == 2) || (this.global1.allcountries[6].paths == 4 && this.global1.event_done[1067]))
		{
			this.special[1].SetActive(true);
			this.donedone = true;
		}
		else if (this.special[0].activeSelf)
		{
			this.special[0].SetActive(false);
		}
		else if (this.special[1].activeSelf)
		{
			this.special[1].SetActive(false);
		}
		bool flag = true;
		for (int i = 0; i < this.global1.science.Length; i++)
		{
			if (this.global1.science_time[i] < 360)
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			this.thishappened.SetActive(false);
		}
		else if (this.global1.neizucheno)
		{
			this.thishappened.SetActive(true);
			this.thishappened.GetComponent<ScienceHappenedScript>().this_num = 10;
			this.thishappened.GetComponent<ScienceHappenedScript>().IsHappened();
		}
		if (this.global1.data[20] == 13)
		{
			this.global1.data[20] = 1;
			this.global1.data[21]++;
		}
		this.Recrisis();
		if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
		{
			this.CheckYugoWars();
		}
	}

	// Token: 0x06000111 RID: 273 RVA: 0x00002D1F File Offset: 0x00000F1F
	private void Autosasvemethod()
	{
		this.goto_pause.OnMouseDown();
		if (this.global1.iron_and_blood)
		{
			this.Autosavej.number = 5;
		}
		else
		{
			this.Autosavej.number = 1;
		}
		this.Autosavej.OnMouseDown();
	}

	// Token: 0x06000112 RID: 274 RVA: 0x0015B390 File Offset: 0x00159590
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && !this.map1.okno.active && !this.is_showed)
		{
			this.probel.GetComponent<SpeedScript>().Probel();
		}
		if (this.map1.okno.active && this.is_showed && this.global1.speed != 0)
		{
			this.global1.speed = 0;
		}
		this.now_time += (float)this.global1.speed * Time.deltaTime;
		if (this.now_time >= 8f)
		{
			this.now_time = 0f;
			this.Repaint(true);
		}
	}

	// Token: 0x06000113 RID: 275
	private void CheckYugoWars()
	{
		if (this.global1.data[14] <= 0)
		{
			this.global1.allcountries[15].Gosstroy = 9;
		}
		else if (this.global1.data[14] <= 2)
		{
			this.global1.allcountries[15].Gosstroy = 0;
		}
		else if (this.global1.data[14] <= 3)
		{
			this.global1.allcountries[15].Gosstroy = 1;
		}
		else
		{
			this.global1.allcountries[15].Gosstroy = 2;
		}
		this.global1.allcountries[15].isSEV = this.global1.allcountries[this.global1.data[0]].isSEV;
		this.global1.allcountries[15].isOVD = this.global1.allcountries[this.global1.data[0]].isOVD;
		this.global1.allcountries[15].Vyshi = this.global1.allcountries[this.global1.data[0]].Vyshi;
		if (this.global1.data[10] < 500 && this.yug1.gameState.battle_royal)
		{
			this.global1.data[10] = 500;
		}
		this.global1.data[135] = 0;
		if (!this.yug1.gameState.yugcountries[0].is_independent)
		{
			this.global1.data[135]++;
		}
		if (!this.yug1.gameState.yugcountries[1].is_independent)
		{
			this.global1.data[135]++;
		}
		if (!this.yug1.gameState.yugcountries[2].is_independent)
		{
			this.global1.data[135]++;
		}
		if (!this.yug1.gameState.yugcountries[3].is_independent)
		{
			this.global1.data[135]++;
		}
		if (!this.yug1.gameState.yugcountries[4].is_independent)
		{
			this.global1.data[135]++;
		}
		if (!this.yug1.gameState.yugcountries[5].is_independent)
		{
			this.global1.data[135]++;
		}
		if (!this.yug1.gameState.yugcountries[6].is_independent)
		{
			this.global1.data[135]++;
		}
		if (!this.yug1.gameState.yugcountries[7].is_independent)
		{
			this.global1.data[135]++;
		}
		if (!this.yug1.gameState.yugcountries[8].is_independent)
		{
			this.global1.data[135]++;
		}
		if (!this.yug1.gameState.yugcountries[9].is_independent)
		{
			this.global1.data[135]++;
		}
		if (!this.yug1.gameState.yugcountries[10].is_independent)
		{
			this.global1.data[135]++;
		}
		if (!this.yug1.gameState.yugcountries[11].is_independent)
		{
			this.global1.data[135]++;
		}
		if (this.yug1.gameState.battle_royal && this.yug1.gameState.yugcountries[11].is_exist && this.global1.event_done[102])
		{
			this.yug1.gameState.yugcountries[10].name = this.yug1.science_text[109];
		}
		else if (this.global1.allcountries[6].Gosstroy == 9 && this.global1.event_done[313])
		{
			this.yug1.gameState.yugcountries[10].name = this.yug1.science_text[109];
		}
		else if (this.global1.allcountries[20].Gosstroy == 9 && this.global1.event_done[315])
		{
			this.yug1.gameState.yugcountries[10].name = this.yug1.science_text[112];
		}
		if (this.global1.allcountries[5].Gosstroy == 9 && this.global1.event_done[39] && this.global1.event_done[313])
		{
			this.yug1.gameState.yugcountries[9].name = this.yug1.science_text[111];
		}
		if (this.global1.data[114] != 100)
		{
			if (this.global1.data[112] != 0)
			{
				if (this.global1.data[112] == 1)
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.politics_name[2] = " 德 尔 诺 夫 舍 克";
						this.global1.politics_charact[2] = " 民 主 化 推 广 者";
					}
					else
					{
						this.global1.politics_name[2] = "Дрновшек";
						this.global1.politics_charact[2] = "Демократизатор";
					}
				}
				else if (this.global1.data[112] == 2)
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.politics_name[2] = " 布 尔 茨";
						this.global1.politics_charact[2] = " 新 左 翼";
					}
					else
					{
						this.global1.politics_name[2] = "Булц";
						this.global1.politics_charact[2] = "Новый левый";
					}
				}
				else if (this.global1.data[112] == 3)
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.politics_name[2] = " 约 维 奇";
						this.global1.politics_charact[2] = " 米 洛 舍 维 奇 的 傀 儡";
					}
					else
					{
						this.global1.politics_name[2] = "Йович";
						this.global1.politics_charact[2] = "Марионетка Милошевича";
					}
				}
				else if (this.global1.data[112] == 4)
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.politics_name[2] = " 舒 瓦 尔";
						this.global1.politics_charact[2] = " 反 分 离 主 义 者";
					}
					else
					{
						this.global1.politics_name[2] = "Шувар";
						this.global1.politics_charact[2] = "Борец с сепаратизмом";
					}
				}
				else if (this.global1.data[112] == 5)
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.politics_name[2] = " 梅 西 奇";
						this.global1.politics_charact[2] = " 克 罗 地 亚 民 族 主 义 者";
					}
					else
					{
						this.global1.politics_name[2] = "Месич";
						this.global1.politics_charact[2] = "Хорватский националист";
					}
				}
				else if (this.global1.data[112] == 6)
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.politics_name[2] = " 科 斯 蒂 奇";
						this.global1.politics_charact[2] = " 妥 协 大 师";
					}
					else
					{
						this.global1.politics_name[2] = "Костич";
						this.global1.politics_charact[2] = "Мастер компромиссов";
					}
				}
				else if (this.global1.data[112] == 7)
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.politics_name[2] = " 约 斯 卡";
						this.global1.politics_charact[2] = " 新 铁 托";
					}
					else
					{
						this.global1.politics_name[2] = "Йошка";
						this.global1.politics_charact[2] = "Новый Тито";
					}
				}
				else if (this.global1.data[112] == 8)
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.politics_name[2] = " 特 里 帕 洛";
						this.global1.politics_charact[2] = " 左 翼 异 见 者";
					}
					else
					{
						this.global1.politics_name[2] = "Трипало";
						this.global1.politics_charact[2] = "Левый диссидент";
					}
				}
				else if (this.global1.data[112] == 9)
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.politics_name[2] = " 巴 伊 拉 莫 维 奇";
						this.global1.politics_charact[2] = " 反 分 离 主 义 斗 士";
					}
					else
					{
						this.global1.politics_name[2] = "Байрамович";
						this.global1.politics_charact[2] = "Борец с сепаратизмом";
					}
				}
				else if (this.global1.data[112] == 10)
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.politics_name[2] = " 马 尔 科 维 奇";
						this.global1.politics_charact[2] = " 红 衣 主 教";
					}
					else
					{
						this.global1.politics_name[2] = "Маркович";
						this.global1.politics_charact[2] = "Красный кардинал";
					}
				}
				else if (this.global1.data[112] == 11)
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.politics_name[2] = " 拉 廷";
						this.global1.politics_charact[2] = " 马 尔 科 维 奇 的 门 徒";
					}
					else
					{
						this.global1.politics_name[2] = "Латин";
						this.global1.politics_charact[2] = "Протеже Марковича";
					}
				}
				else if (this.global1.data[112] == 12)
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.politics_name[2] = " 博 吉 切 维 奇";
						this.global1.politics_charact[2] = " 业 余 塞 尔 维 亚 人";
					}
					else
					{
						this.global1.politics_name[2] = "Богичевич";
						this.global1.politics_charact[2] = "Серб не по профессии";
					}
				}
			}
		}
		else if (!this.yug1.gameState.battle_royal)
		{
			if (this.global1.data[0] == 49)
			{
				if (this.global1.data[150] == 0 && this.global1.data[148] == 0)
				{
					this.global1.data[11] = 0;
				}
				else if (this.global1.data[150] == 1 && this.global1.data[148] == 2)
				{
					this.global1.data[11] = 1;
				}
				else if (this.global1.data[150] == 1 && this.global1.data[148] == 1)
				{
					this.global1.data[11] = 2;
				}
				else if (this.global1.data[150] == 0 && this.global1.data[148] == 1)
				{
					this.global1.data[11] = 3;
				}
			}
			else if (this.global1.data[0] == 50)
			{
				if (this.global1.data[136] == 1 && this.global1.data[137] == 0)
				{
					this.global1.data[11] = 0;
				}
				else if (this.global1.data[136] == 0 && this.global1.data[138] == 0)
				{
					this.global1.data[11] = 3;
				}
				else if (this.global1.data[136] == 1 && this.global1.data[137] == 1)
				{
					this.global1.data[11] = 2;
				}
				else if (this.global1.data[136] == 0 && this.global1.data[138] == 1)
				{
					this.global1.data[11] = 1;
				}
			}
			else if (this.global1.data[0] == 51)
			{
				if (this.global1.data[116] == 1 && this.global1.data[118] == 1)
				{
					this.global1.data[11] = 0;
				}
				else if (this.global1.data[116] == 2 && this.global1.data[118] == 1)
				{
					this.global1.data[11] = 1;
				}
				else if ((this.global1.data[117] == 1 || this.global1.data[117] == 2) && this.global1.data[118] == 0)
				{
					this.global1.data[11] = 2;
				}
				else if (this.global1.data[117] == 0 && this.global1.data[118] == 0)
				{
					this.global1.data[11] = 3;
				}
			}
		}
		if (this.yug_little.yug1 == null)
		{
			this.yug_little.Awake();
		}
		else if (this.global1.data[19] % 7 == 0)
		{
			this.yug_little.Repaint();
		}
		if (this.yug1.gameState.regionUnderAttack >= 0)
		{
			this.global1.number_event = 354;
			SceneManager.LoadScene("Event");
			return;
		}
		for (int i = 0; i < this.yug1.gameState.regionsAttacked.Length; i++)
		{
			if (this.yug1.gameState.regionsAttacked[i] >= 0)
			{
				this.yug1.gameState.regionUnderAttack = this.yug1.gameState.regionsAttacked[i];
				this.yug1.gameState.who_attack = this.yug1.gameState.whoAttacked[i];
				this.yug1.gameState.regionsAttacked[i] = -1;
				this.yug1.gameState.whoAttacked[i] = -1;
				this.global1.number_event = 354;
				SceneManager.LoadScene("Event");
			}
		}
	}

	// Token: 0x06000114 RID: 276 RVA: 0x0015C328 File Offset: 0x0015A528
	public void Reborn()
	{
		if (!this.is_showed)
		{
			this.ending.SetActive(true);
			this.is_showed = true;
			this.save_speed = this.global1.speed;
			this.global1.speed = 0;
			return;
		}
		this.is_showed = false;
		this.ending.SetActive(false);
		this.global1.speed = this.save_speed;
	}

	// Token: 0x06000115 RID: 277 RVA: 0x00002D5E File Offset: 0x00000F5E
	private void Reelect()
	{
		this.vybory = false;
		this.global1.is_elect = true;
		this.global1.event_done[2] = true;
		this.global1.number_event = 2;
		SceneManager.LoadScene("Event");
	}

	// Token: 0x06000116 RID: 278 RVA: 0x00002D97 File Offset: 0x00000F97
	private void VyzovEvent(int number_event)
	{
		this.global1.event_done[number_event] = true;
		this.global1.number_event = number_event;
		SceneManager.LoadScene("Event");
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00002DBD File Offset: 0x00000FBD
	private void DeathChoose(int this_event_n)
	{
		this.vybory = false;
		this.global1.is_elect = true;
		this.global1.event_done[this_event_n] = true;
		this.global1.number_event = this_event_n;
		SceneManager.LoadScene("Event");
	}

	// Token: 0x06000118 RID: 280 RVA: 0x0015C394 File Offset: 0x0015A594
	private void Recrisis()
	{
		for (int i = 0; i < this.re_war.Length; i++)
		{
			this.re_war[i].Repaint();
		}
		bool flag = false;
		if (this.global1.data[3] + this.global1.data[22] / 100 <= 300)
		{
			this.crisis[2].sprite = this.global1.crisis;
			this.crisis_color[2].color = Color.red;
			if (!flag)
			{
				this.crisis_show.SetActive(true);
				this.crisis_show.GetComponent<SpriteRenderer>().sprite = this.crisis_spr[0];
				this.crisis_show.GetComponent<OkoshkoScript>().text = "Народные беспорядки";
				this.crisis_show.GetComponent<OkoshkoScript>().text_en = " 人 民 暴 动";
				flag = true;
			}
		}
		else if (this.crisis[2].sprite != null)
		{
			this.crisis[2].sprite = null;
			this.crisis_color[2].color = Color.white;
			if (!flag)
			{
				this.crisis_show.SetActive(false);
			}
		}
		if (this.global1.data[71] == 1)
		{
			this.crisis[4].sprite = this.global1.crisis;
			this.crisis_color[4].color = Color.red;
		}
		else if (this.crisis[4].sprite != null)
		{
			this.crisis[4].sprite = null;
			this.crisis_color[4].color = Color.white;
		}
		if (this.global1.data[4] - this.global1.data[22] / 10 >= 840 || (this.global1.data[3] <= 450 && this.global1.data[4] - this.global1.data[22] / 10 >= 750) || (this.global1.data[3] <= 650 && this.global1.data[4] - this.global1.data[22] / 10 >= 800))
		{
			if ((this.global1.data[3] <= 450 && this.global1.data[4] - this.global1.data[22] / 10 >= 750) || (this.global1.data[3] <= 650 && this.global1.data[4] - this.global1.data[22] / 10 >= 800))
			{
				this.crisis[2].sprite = this.global1.crisis;
				this.crisis[3].sprite = this.global1.crisis;
				this.crisis_color[2].color = Color.red;
				this.crisis_color[3].color = Color.red;
				if (!flag)
				{
					this.crisis_show.SetActive(true);
					this.crisis_show.GetComponent<SpriteRenderer>().sprite = this.crisis_spr[0];
					this.crisis_show.GetComponent<OkoshkoScript>().text = "Народные беспорядки";
					this.crisis_show.GetComponent<OkoshkoScript>().text_en = " 人 民 暴 动";
					flag = true;
				}
			}
			else if (this.global1.data[4] - this.global1.data[22] / 10 >= 840)
			{
				this.crisis[3].sprite = this.global1.crisis;
				this.crisis_color[3].color = Color.red;
				if (!flag)
				{
					this.crisis_show.SetActive(true);
					this.crisis_show.GetComponent<SpriteRenderer>().sprite = this.crisis_spr[0];
					this.crisis_show.GetComponent<OkoshkoScript>().text = "Народные беспорядки";
					this.crisis_show.GetComponent<OkoshkoScript>().text_en = " 人 民 暴 动";
					flag = true;
				}
			}
		}
		else if (this.crisis[3].sprite != null)
		{
			this.crisis[3].sprite = null;
			this.crisis_color[3].color = Color.white;
			if (!flag)
			{
				this.crisis_show.SetActive(false);
			}
		}
		if (this.global1.data[1] < 400 || (this.global1.data[1] < 550 && this.global1.data[2] + this.global1.data[22] / 5 <= 550))
		{
			if (this.global1.data[1] < 400)
			{
				this.crisis[0].sprite = this.global1.crisis;
				this.crisis_color[0].color = Color.red;
				if (!flag)
				{
					this.crisis_show.SetActive(true);
					this.crisis_show.GetComponent<SpriteRenderer>().sprite = this.crisis_spr[1];
					this.crisis_show.GetComponent<OkoshkoScript>().text = "Волнения в Партии";
					this.crisis_show.GetComponent<OkoshkoScript>().text_en = " 党 内 动 乱";
				}
			}
			else if (this.global1.data[1] < 550 && this.global1.data[2] + this.global1.data[22] / 5 <= 550)
			{
				this.crisis[0].sprite = this.global1.crisis;
				this.crisis_color[0].color = Color.red;
				this.crisis[1].sprite = this.global1.crisis;
				this.crisis_color[1].color = Color.red;
				if (!flag)
				{
					this.crisis_show.SetActive(true);
					this.crisis_show.GetComponent<SpriteRenderer>().sprite = this.crisis_spr[1];
					this.crisis_show.GetComponent<OkoshkoScript>().text = "Волнения в Партии";
					this.crisis_show.GetComponent<OkoshkoScript>().text_en = " 党 内 动 乱";
				}
			}
		}
		else if (this.crisis[0].sprite != null)
		{
			this.crisis[0].sprite = null;
			this.crisis_color[0].color = Color.white;
			this.crisis_color[1].color = Color.white;
			if (!flag)
			{
				this.crisis_show.SetActive(false);
			}
		}
		if (!this.donedone)
		{
			if (this.global1.data[0] == 5 && this.global1.data[59] == 1)
			{
				this.special[0].SetActive(true);
			}
			else if (this.global1.data[0] == 6 && this.global1.data[59] == 2)
			{
				this.special[1].SetActive(true);
			}
			this.donedone = true;
		}
	}

	// Token: 0x06000119 RID: 281 RVA: 0x0015CA78 File Offset: 0x0015AC78
	private void YugoModifiesChanges()
	{
		if (this.yug1.gameState.modifies[1] == 1)
		{
			this.global1.data[4] -= 5;
			this.global1.data[31] -= 5;
		}
		if (this.yug1.gameState.modifies[2] == 1)
		{
			if (this.global1.data[19] == 7)
			{
				this.global1.data[3]++;
			}
		}
		else if (this.yug1.gameState.modifies[2] == 2)
		{
			if (this.global1.data[19] == 7)
			{
				this.global1.data[3] += 3;
			}
		}
		else if (this.yug1.gameState.modifies[2] == 3)
		{
			if (this.global1.data[19] == 7)
			{
				this.global1.data[3] += 3;
				this.global1.data[4] -= 3;
				this.global1.data[8] += 5;
			}
		}
		else if (this.yug1.gameState.modifies[2] == 4)
		{
			if (this.global1.data[19] == 7)
			{
				this.global1.data[3] += 3;
				this.global1.data[4] -= 3;
				this.global1.data[8] += 2;
			}
		}
		else if (this.yug1.gameState.modifies[2] == 5)
		{
			this.global1.data[3]++;
			this.global1.data[4] -= 4;
			this.global1.data[8] -= 6;
			this.global1.data[9] -= 2;
		}
		if (this.yug1.gameState.modifies[3] == 1)
		{
			this.global1.data[9] += 25;
			this.global1.data[8] += 25;
		}
		if (this.yug1.gameState.modifies[4] == 1)
		{
			this.global1.data[3] += 20;
			this.global1.data[9] -= 5;
			this.global1.data[8] -= 5;
			this.global1.data[31] -= 3;
		}
		if (this.yug1.gameState.modifies[5] == 1)
		{
			this.global1.data[3] += 15;
			this.global1.data[9] -= 10;
			this.global1.data[31] += 3;
		}
		if (this.yug1.gameState.modifies[6] == 1)
		{
			this.global1.data[8] -= 10;
			this.global1.data[26] -= 25;
			this.global1.data[1] += 10;
			if (this.global1.data[26] <= 0)
			{
				this.yug1.gameState.modifies[6] = 0;
			}
		}
		else if (this.yug1.gameState.modifies[6] == 2)
		{
			this.global1.data[8] -= 2;
			this.global1.data[26] -= 5;
			if (this.global1.data[26] <= 0)
			{
				this.yug1.gameState.modifies[6] = 0;
			}
		}
		if (this.yug1.gameState.modifies[7] == 1)
		{
			this.global1.data[10] += 15;
			this.global1.data[6] += 5;
			this.global1.data[8] -= 5;
		}
		if (this.yug1.gameState.modifies[8] >= 1 && this.yug1.gameState.modifies[8] <= 4)
		{
			this.global1.data[8] += 7;
			this.yug1.gameState.modifies[8]++;
		}
		if (this.yug1.gameState.modifies[9] == 1)
		{
			if (this.global1.data[19] == 7 && this.global1.data[20] % 3 == 0)
			{
				this.global1.data[9] += 40;
				this.global1.data[8] += 20;
			}
		}
		else if (this.yug1.gameState.modifies[9] == 2 && this.global1.data[19] == 7 && this.global1.data[20] % 3 == 0)
		{
			this.global1.data[9] += 20;
		}
		if (this.yug1.gameState.modifies[10] == 1)
		{
			this.global1.data[9] += 20;
		}
		if (this.yug1.gameState.modifies[11] == 1)
		{
			if (this.global1.data[19] == 7 && this.global1.data[20] % 3 == 0)
			{
				this.global1.data[9] += 60;
				this.global1.data[8] += 10;
			}
		}
		else if (this.yug1.gameState.modifies[11] == 2 && this.global1.data[19] == 7)
		{
			this.global1.data[9] += 60;
			this.global1.data[8] += 10;
		}
		if (this.yug1.gameState.modifies[12] == 1)
		{
			this.global1.data[3] -= 30;
			this.global1.data[31] -= 3;
		}
		else if (this.yug1.gameState.modifies[12] == 2)
		{
			this.global1.data[3] += 10;
			this.global1.data[9] -= 3;
			this.global1.data[31] += 5;
		}
		else if (this.yug1.gameState.modifies[12] == 3)
		{
			this.global1.data[3] += 10;
			this.global1.data[9]--;
			this.global1.data[8]--;
			this.global1.data[31] -= 5;
			if (this.global1.data[19] == 7 && this.global1.data[20] % 6 == 0)
			{
				this.global1.data[115]++;
			}
		}
		else if (this.yug1.gameState.modifies[12] == 4)
		{
			this.global1.data[1] -= 3;
			this.global1.data[9] -= 10;
			this.global1.data[31] += 5;
		}
		else if (this.yug1.gameState.modifies[12] == 5)
		{
			this.global1.data[3] += 10;
			this.global1.data[9] += 5;
			this.global1.data[8] += 5;
			this.global1.data[31] -= 3;
			if (this.global1.data[19] == 7 && this.global1.data[20] % 6 == 0)
			{
				this.global1.data[115]++;
			}
		}
		else if (this.yug1.gameState.modifies[12] == 6)
		{
			if (this.global1.data[20] >= 2 && this.global1.data[21] == 1991)
			{
				this.yug1.gameState.modifies[12] = 0;
			}
			else
			{
				this.global1.data[3] -= 4;
				this.global1.data[9] -= 5;
				this.global1.data[31] += 5;
			}
		}
		else if (this.yug1.gameState.modifies[12] == 7)
		{
			this.global1.data[3] -= 2;
			this.global1.data[9] -= 3;
			this.global1.data[31] += 5;
		}
		if (this.global1.data[21] >= 1991)
		{
			this.yug1.gameState.modifies[12] = 0;
		}
		if (this.yug1.gameState.modifies[13] == 1)
		{
			this.global1.data[3] -= 5;
			this.global1.data[9] -= 5;
			this.global1.data[4] += 7;
			this.global1.data[9] -= 5;
		}
		if (this.yug1.gameState.modifies[14] == 1)
		{
			this.global1.data[9] += 5;
			this.global1.data[8] -= 10;
			this.global1.data[6] += 5;
			this.global1.data[4] -= 15;
		}
		if (this.yug1.gameState.modifies[15] == 1)
		{
			this.global1.data[9] += 7;
			this.global1.data[1] += 5;
			this.global1.data[3] += 10;
		}
		if (this.yug1.gameState.modifies[16] == 1)
		{
			this.global1.data[9] -= 10;
			this.global1.data[8] -= 10;
		}
		if (this.yug1.gameState.modifies[17] == 1)
		{
			this.global1.data[8] -= 5;
			this.global1.data[3] -= 2;
			this.global1.data[4] += 4;
			this.global1.data[26] -= 5;
			this.global1.data[1] += 5;
			this.global1.data[1]--;
			if (this.global1.data[26] <= 1)
			{
				this.yug1.gameState.modifies[17] = 0;
			}
		}
		if (this.yug1.gameState.modifies[18] == 1)
		{
			this.global1.data[8] -= 2;
			this.global1.data[5] -= 2;
		}
		if (this.yug1.gameState.modifies[19] == 1)
		{
			this.global1.data[9] -= 4;
			if (this.global1.science[2])
			{
				this.yug1.gameState.modifies[19] = 0;
			}
		}
		if (this.yug1.gameState.modifies[20] == 1)
		{
			this.global1.data[4] -= 4;
		}
		if (this.yug1.gameState.modifies[21] == 1 && this.global1.data[19] == 7)
		{
			this.global1.data[3] -= 4;
			this.global1.data[1] -= 4;
		}
		if (this.yug1.gameState.modifies[22] == 1)
		{
			this.global1.data[9] -= 3;
			this.global1.data[3] -= 2;
		}
		else if (this.yug1.gameState.modifies[22] == 2)
		{
			this.global1.data[8] -= 3;
			this.global1.data[3] -= 2;
		}
		if (this.yug1.gameState.modifies[23] == 1)
		{
			this.global1.data[6] += 2;
			this.global1.data[3] -= 3;
		}
		else if (this.yug1.gameState.modifies[23] == 2)
		{
			this.global1.data[10] += 3;
			this.global1.data[6] -= 3;
		}
		if (this.yug1.gameState.modifies[24] == 1)
		{
			this.global1.data[6] += 2;
			this.global1.data[3] -= 3;
		}
		else if (this.yug1.gameState.modifies[24] == 2)
		{
			this.global1.data[10] += 3;
			this.global1.data[6] -= 3;
		}
		if (this.yug1.gameState.modifies[25] == 1)
		{
			this.global1.data[9] -= 2;
			this.global1.data[1]--;
			this.global1.data[3]--;
			this.global1.data[6]++;
		}
		if (this.yug1.gameState.modifies[26] == 1)
		{
			this.global1.data[4]++;
			this.global1.data[3]--;
			this.global1.data[31]++;
		}
		if (this.yug1.gameState.modifies[27] == 1)
		{
			this.global1.data[8] -= 2;
			this.global1.data[3]--;
			this.global1.data[1]--;
			this.global1.data[5]--;
		}
		if (this.yug1.gameState.modifies[28] == 1)
		{
			this.global1.data[4] += 2;
			this.global1.data[3] -= 2;
			this.global1.data[31]++;
		}
		if (this.yug1.gameState.modifies[29] == 1)
		{
			this.global1.data[4]++;
		}
		if (this.yug1.gameState.modifies[30] == 1)
		{
			this.global1.data[4]++;
		}
		else if (this.yug1.gameState.modifies[30] == 2)
		{
			this.global1.data[4]++;
			this.global1.data[3]--;
			this.global1.data[1]--;
			this.global1.data[9]--;
		}
		else if (this.yug1.gameState.modifies[30] == 3)
		{
			this.global1.data[4] += 2;
			this.global1.data[3]--;
			this.global1.data[1]--;
			this.global1.data[5]--;
			this.global1.data[9]--;
		}
		else if (this.yug1.gameState.modifies[30] == 4)
		{
			this.global1.data[4]++;
			this.global1.data[3]--;
			this.global1.data[1]--;
			this.global1.data[5]--;
			this.global1.data[8]--;
			this.global1.data[9] -= 2;
		}
		else if (this.yug1.gameState.modifies[31] == 1)
		{
			this.global1.data[4]++;
			this.global1.data[3]--;
			if (this.global1.data[10] <= 400)
			{
				this.global1.data[10]++;
			}
		}
		if (this.yug1.gameState.modifies[32] == 1)
		{
			this.global1.data[4] += 2;
			this.global1.data[10]++;
		}
		if (this.yug1.gameState.modifies[33] == 1)
		{
			this.global1.data[4]++;
			this.global1.data[10]++;
			if (this.global1.data[20] >= 7)
			{
				if (!this.global1.allcountries[7].Torg)
				{
					this.global1.data[8]--;
					this.global1.data[5]--;
				}
				if (!this.global1.allcountries[16].Torg)
				{
					this.global1.data[8]--;
					this.global1.data[5]--;
				}
				if (!this.global1.allcountries[48].Torg)
				{
					this.global1.data[8]--;
					this.global1.data[5]--;
				}
				if (!this.global1.allcountries[45].Torg)
				{
					this.global1.data[8]--;
					this.global1.data[5]--;
				}
			}
		}
		if (this.yug1.gameState.modifies[34] == 1)
		{
			this.global1.data[8] -= 2;
			this.global1.data[3]++;
			this.global1.data[5]++;
			if (!this.global1.regions[this.yug1.gameState.yugregions[8].inreg].buildings[this.yug1.gameState.yugregions[8].level].is_builded || !this.global1.regions[this.yug1.gameState.yugregions[8].inreg].buildings[this.yug1.gameState.yugregions[8].level + 1].is_builded || !this.global1.regions[this.yug1.gameState.yugregions[8].inreg].buildings[this.yug1.gameState.yugregions[8].level + 2].is_builded || !this.global1.regions[this.yug1.gameState.yugregions[8].inreg].buildings[this.yug1.gameState.yugregions[8].level + 3].is_builded || !this.global1.regions[this.yug1.gameState.yugregions[8].inreg].buildings[this.yug1.gameState.yugregions[8].level + 4].is_builded)
			{
				this.yug1.gameState.modifies[34] = 0;
			}
		}
		if (this.yug1.gameState.modifies[35] == 1)
		{
			this.global1.data[6]++;
			this.global1.data[3] -= 2;
			this.global1.data[4] += 2;
			if (this.global1.data[5] >= 70)
			{
				this.yug1.gameState.modifies[35] = 0;
			}
		}
		if (this.yug1.gameState.modifies[36] == 1)
		{
			this.global1.data[1]--;
			this.global1.data[5]++;
			this.global1.data[8] -= 25;
			for (int i = 0; i < this.global1.allcountries.Length; i++)
			{
				if (this.global1.allcountries[i] != null && this.global1.allcountries[i].isSEV && this.global1.allcountries[i].Gosstroy != this.global1.allcountries[this.global1.data[0]].Gosstroy)
				{
					this.global1.data[23] -= 2;
				}
			}
			if (this.global1.data[21] >= 1992 || (this.global1.data[0] == 49 && !this.global1.allcountries[49].isSEV) || (this.global1.data[0] == 50 && !this.global1.allcountries[50].isSEV) || (this.global1.data[0] == 51 && !this.global1.allcountries[51].isSEV))
			{
				this.yug1.gameState.modifies[36] = 0;
			}
		}
		if (this.yug1.gameState.modifies[37] == 1)
		{
			this.global1.data[1]--;
			this.global1.data[3] -= 2;
			this.global1.data[4] += 2;
		}
		if (this.yug1.gameState.yugregions[11].owner == this.yug1.gameState.player)
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				this.yug1.gameState.yugcountries[11].name = " 马 其 顿";
			}
			else
			{
				this.yug1.gameState.yugcountries[11].name = "Македония";
			}
		}
		if (this.yug1.gameState.yugregions[10].owner == this.yug1.gameState.player)
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				this.yug1.gameState.yugcountries[10].name = " 科 索 沃";
				return;
			}
			this.yug1.gameState.yugcountries[10].name = "Косово";
		}
	}

	// Token: 0x0600011A RID: 282 RVA: 0x0015E42C File Offset: 0x0015C62C
	private void YugoEvents()
	{
		Debug.Log("YUGEVENSTART");
		if (this.global1.data[162] != 3 && this.global1.data[20] >= 4 && this.global1.data[21] == 1989 && this.global1.data[0] == 51 && !this.events[15].activeSelf && !this.global1.event_done[266])
		{
			this.this_num_event = 266;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 15 && this.global1.data[20] >= 5 && this.global1.data[21] == 1991 && this.global1.data[131] == 0 && this.global1.data[128] == 0 && !this.global1.event_done[305] && !this.global1.event_done[306] && !this.global1.event_done[307] && !this.global1.event_done[312] && this.global1.data[115] >= 15 && this.global1.data[126] >= 1 && !this.events[15].activeSelf && !this.global1.event_done[308])
		{
			this.this_num_event = 308;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.allcountries[7].paths <= 0 && !this.global1.allcountries[7].isOVD && !this.global1.allcountries[7].isSEV && !this.global1.is_gkchp && this.global1.allcountries[7].paths != 2 && this.global1.data[162] != 3 && ((this.global1.data[126] == 0 && this.global1.data[115] <= 3 && ((this.yug1.gameState.yugregions[1].owner == this.yug1.gameState.player && !this.yug1.gameState.yugcountries[1].peace_with[8]) || !this.yug1.gameState.yugcountries[1].peace_with[0] || !this.yug1.gameState.yugcountries[1].peace_with[3] || !this.yug1.gameState.yugcountries[1].peace_with[11] || (this.yug1.gameState.yugregions[3].owner == this.yug1.gameState.player && !this.yug1.gameState.yugcountries[3].peace_with[8]) || !this.yug1.gameState.yugcountries[3].peace_with[0] || !this.yug1.gameState.yugcountries[3].peace_with[1] || !this.yug1.gameState.yugcountries[3].peace_with[11] || (this.yug1.gameState.yugregions[8].owner == this.yug1.gameState.player && !this.yug1.gameState.yugcountries[8].peace_with[1]) || !this.yug1.gameState.yugcountries[8].peace_with[0] || !this.yug1.gameState.yugcountries[8].peace_with[3] || !this.yug1.gameState.yugcountries[8].peace_with[11])) || (this.global1.data[161] == 4 && this.global1.data[114] != 100 && this.global1.data[52] == 3)) && !this.events[7].activeSelf && !this.global1.event_done[62])
		{
			this.this_num_event = 62;
			this.this_num_place = 7;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if ((this.global1.data[4] >= 1000 || this.global1.data[1] <= 300 || this.global1.data[3] <= 300) && this.global1.data[191] != 1 && this.global1.data[131] == 0 && this.global1.data[162] <= 2 && !this.events[15].activeSelf && !this.global1.event_done[312])
		{
			this.this_num_event = 317;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if ((this.pastDate(this.global1.data[49], 9, 1990) || (this.global1.data[7] <= 600 && this.global1.event_done[1066])) && this.global1.allcountries[6].paths == 4 && !this.checkWas(15, 361))
		{
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 17 && this.global1.data[20] >= 6 && this.global1.data[21] == 1989 && this.global1.data[0] == 51 && !this.events[15].activeSelf && !this.global1.event_done[267])
		{
			this.this_num_event = 267;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 11 && this.global1.data[20] >= 12 && this.global1.data[21] == 1989 && !this.events[15].activeSelf && !this.global1.event_done[268])
		{
			this.this_num_event = 268;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 24 && this.global1.data[20] >= 2 && this.global1.data[21] == 1990 && this.global1.data[118] == 0 && this.global1.data[115] >= 3 && this.global1.data[117] == 1 && this.global1.data[116] == 2 && this.global1.data[0] == 51 && !this.events[15].activeSelf && !this.global1.event_done[269])
		{
			this.this_num_event = 269;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 24 && this.global1.data[20] >= 2 && this.global1.data[21] == 1990 && this.global1.data[116] != 0 && this.global1.data[118] == 1 && this.global1.data[0] == 51 && !this.events[15].activeSelf && !this.global1.event_done[270])
		{
			this.this_num_event = 270;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 22 && this.global1.data[20] >= 4 && this.global1.data[21] == 1990 && !this.events[15].activeSelf && !this.global1.event_done[271])
		{
			this.this_num_event = 271;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 13 && this.global1.data[20] >= 5 && this.global1.data[21] == 1990 && this.global1.data[118] == 1 && this.global1.data[150] == 1 && this.global1.data[0] == 51 && !this.events[15].activeSelf && !this.global1.event_done[272])
		{
			this.this_num_event = 272;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && ((this.global1.data[20] >= 6 && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && this.global1.data[168] == 0 && this.global1.data[12] != 2 && this.global1.data[116] == 1 && this.global1.data[118] == 1 && !this.events[15].activeSelf && !this.global1.event_done[273])
		{
			this.this_num_event = 273;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.event_done[273] && this.global1.data[12] != 2 && this.global1.data[116] == 1 && this.global1.data[118] == 1 && !this.yug1.gameState.yugcountries[2].is_exist && !this.events[15].activeSelf && !this.global1.event_done[274])
		{
			this.this_num_event = 274;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 17 && this.global1.data[20] >= 8 && this.global1.data[21] == 1990 && this.global1.data[116] == 1 && this.global1.data[118] == 1 && this.yug1.gameState.yugcountries[2].is_exist && !this.events[15].activeSelf && !this.global1.event_done[275])
		{
			this.this_num_event = 275;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 19 && this.global1.data[20] >= 5 && this.global1.data[21] == 1991 && this.global1.data[131] == 0 && this.global1.data[168] == 0 && this.global1.data[116] == 1 && this.global1.data[118] == 1 && this.yug1.gameState.yugcountries[8].peace_with[1] && !this.events[15].activeSelf && !this.global1.event_done[276])
		{
			this.this_num_event = 276;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 14 && this.global1.data[20] >= 9 && this.global1.data[21] == 1991 && this.global1.data[131] == 0 && this.global1.data[168] == 0 && this.global1.data[116] == 1 && this.global1.data[118] == 1 && this.yug1.gameState.yugcountries[2].is_exist && this.yug1.gameState.yugcountries[8].peace_with[1] && this.yug1.gameState.yugregions[1].owner == 1 && !this.events[15].activeSelf && !this.global1.event_done[277])
		{
			this.this_num_event = 277;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 3 && this.global1.data[20] >= 9 && this.global1.data[21] == 1991 && this.global1.data[131] == 0 && this.global1.data[168] == 0 && this.global1.data[116] == 1 && this.global1.data[118] == 1 && this.global1.data[0] == 51 && (this.yug1.gameState.yugcountries[8].peace_with[1] || this.yug1.gameState.yugregions[8].owner == 1) && !this.yug1.gameState.yugcountries[2].is_exist && !this.events[15].activeSelf && !this.global1.event_done[278])
		{
			this.this_num_event = 278;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 22 && this.global1.data[20] >= 1 && this.global1.data[21] == 1991 && this.global1.data[0] == 51 && this.global1.data[117] == 2 && !this.events[15].activeSelf && !this.global1.event_done[279])
		{
			this.this_num_event = 279;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 6 && this.global1.data[20] >= 4 && this.global1.data[21] == 1991 && this.global1.data[0] == 51 && this.global1.data[117] == 2 && this.global1.data[116] == 1 && !this.events[15].activeSelf && !this.global1.event_done[280])
		{
			this.this_num_event = 280;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 22 && this.global1.data[20] >= 6 && this.global1.data[21] == 1990 && this.global1.data[117] == 2 && this.global1.data[0] == 51 && !this.events[15].activeSelf && !this.global1.event_done[281])
		{
			this.this_num_event = 281;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 2 && this.global1.data[20] >= 2 && this.global1.data[21] == 1989 && !this.events[15].activeSelf && !this.global1.event_done[282])
		{
			this.this_num_event = 282;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 4 && this.global1.data[20] >= 3 && this.global1.data[21] == 1989 && !this.events[15].activeSelf && !this.global1.event_done[283])
		{
			this.this_num_event = 283;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 1 && this.global1.data[20] >= 4 && this.global1.data[21] == 1989 && !this.events[15].activeSelf && !this.global1.event_done[284])
		{
			this.this_num_event = 284;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 15 && this.global1.data[20] >= 6 && this.global1.data[21] == 1989 && !this.events[15].activeSelf && !this.global1.event_done[285])
		{
			this.this_num_event = 285;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 1 && this.global1.data[20] >= 9 && this.global1.data[21] == 1989 && this.global1.data[157] != 0 && !this.events[15].activeSelf && !this.global1.event_done[286])
		{
			this.this_num_event = 286;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[19] >= 3 && this.global1.data[20] >= 11 && this.global1.data[21] == 1989 && !this.events[15].activeSelf && !this.global1.event_done[287])
		{
			this.this_num_event = 287;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 18 && this.global1.data[20] >= 1 && this.global1.data[21] == 1990 && !this.events[15].activeSelf && !this.global1.event_done[288])
		{
			this.this_num_event = 288;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 20 && this.global1.data[20] >= 1 && this.global1.data[21] == 1990 && !this.events[15].activeSelf && !this.global1.event_done[289])
		{
			this.this_num_event = 289;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 21 && this.global1.data[20] >= 1 && this.global1.data[21] == 1990 && !this.events[15].activeSelf && !this.global1.event_done[290])
		{
			this.this_num_event = 290;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 22 && this.global1.data[20] >= 1 && this.global1.data[21] == 1990 && !this.events[15].activeSelf && !this.global1.event_done[291])
		{
			this.this_num_event = 291;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 23 && this.global1.data[20] >= 1 && this.global1.data[21] == 1990 && this.global1.data[127] == 1 && this.global1.data[126] >= 1 && !this.events[15].activeSelf && !this.global1.event_done[292])
		{
			this.this_num_event = 292;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 24 && this.global1.data[20] >= 1 && this.global1.data[21] == 1990 && this.global1.data[123] == 1 && this.global1.data[126] >= 1 && !this.global1.event_done[293])
		{
			this.this_num_event = 293;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 25 && this.global1.data[20] >= 1 && this.global1.data[21] == 1990 && this.global1.data[126] >= 1 && !this.events[15].activeSelf && !this.global1.event_done[294])
		{
			this.this_num_event = 294;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[124] == 0 && this.global1.data[126] == 1 && !this.events[15].activeSelf && !this.global1.event_done[295])
		{
			this.this_num_event = 295;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 4 && this.global1.data[20] >= 3 && this.global1.data[21] == 1990 && !this.events[15].activeSelf && !this.global1.event_done[296])
		{
			this.this_num_event = 296;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 25 && this.global1.data[20] >= 3 && this.global1.data[21] == 1990 && !this.events[15].activeSelf && !this.global1.event_done[297])
		{
			this.this_num_event = 297;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 1 && this.global1.data[20] >= 4 && this.global1.data[21] == 1990 && !this.events[15].activeSelf && !this.global1.event_done[298])
		{
			this.this_num_event = 298;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 5 && this.global1.data[20] >= 5 && this.global1.data[21] == 1990 && !this.events[15].activeSelf && !this.global1.event_done[299])
		{
			this.this_num_event = 299;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 7 && this.global1.data[20] >= 8 && this.global1.data[21] == 1990 && this.global1.data[125] == 1 && this.global1.data[26] != 0 && !this.events[15].activeSelf && !this.global1.event_done[300])
		{
			this.this_num_event = 300;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 23 && this.global1.data[20] >= 12 && this.global1.data[21] == 1990 && this.global1.data[157] == 2 && !this.events[15].activeSelf && !this.global1.event_done[301])
		{
			this.this_num_event = 301;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 5 && this.global1.data[20] >= 4 && this.global1.data[21] == 1989 && !this.events[15].activeSelf && !this.global1.event_done[302])
		{
			this.this_num_event = 302;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 15 && this.global1.data[20] >= 5 && this.global1.data[21] == 1989 && !this.events[15].activeSelf && !this.global1.event_done[303])
		{
			this.this_num_event = 303;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 15 && this.global1.data[20] >= 5 && this.global1.data[21] == 1990 && !this.events[15].activeSelf && !this.global1.event_done[312] && !this.global1.event_done[304])
		{
			this.this_num_event = 304;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 15 && this.global1.data[20] >= 5 && this.global1.data[21] == 1991 && this.yug1.gameState.yugregions[1].owner == 1 && this.global1.data[128] == 2 && this.global1.data[131] == 0 && !this.global1.event_done[312] && !this.yug1.gameState.yugcountries[1].is_independent && !this.events[15].activeSelf && !this.global1.event_done[305])
		{
			this.this_num_event = 305;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 15 && this.global1.data[20] >= 5 && this.global1.data[21] == 1991 && this.global1.data[131] == 0 && this.yug1.gameState.modifies[5] == 0 && (this.global1.data[128] == 0 || this.global1.data[128] == 1 || this.global1.data[169] == 1) && !this.global1.event_done[312] && !this.events[15].activeSelf && !this.global1.event_done[308] && !this.global1.event_done[306])
		{
			this.this_num_event = 306;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 15 && this.global1.data[20] >= 5 && this.global1.data[21] == 1991 && this.global1.data[131] == 0 && !this.global1.event_done[305] && !this.global1.event_done[312] && ((this.global1.data[128] == 2 && this.yug1.gameState.yugcountries[1].is_independent) || (this.global1.data[112] == 9 && this.yug1.gameState.yugcountries[10].is_independent && this.yug1.gameState.yugregions[10].owner == 10)) && !this.events[15].activeSelf && !this.global1.event_done[307])
		{
			this.this_num_event = 307;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 1 && this.global1.data[20] >= 7 && this.global1.data[21] == 1991 && this.global1.data[129] == 1 && !this.global1.event_done[312] && this.global1.data[168] != 0 && !this.events[15].activeSelf && !this.global1.event_done[309])
		{
			this.this_num_event = 309;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[132] == 5 && this.global1.data[128] == 2 && !this.global1.event_done[312] && !this.events[15].activeSelf && !this.global1.event_done[310])
		{
			this.this_num_event = 310;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 25 && this.global1.data[20] >= 6 && this.global1.data[21] == 1991 && this.global1.data[131] == 0 && this.global1.data[168] == 0 && this.global1.data[157] == 2 && !this.events[15].activeSelf && !this.global1.event_done[311])
		{
			this.this_num_event = 311;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[135] <= 9 && this.global1.data[184] != 2 && this.global1.data[184] != 2 && !this.global1.event_done[406] && !this.events[15].activeSelf && !this.global1.event_done[312])
		{
			this.this_num_event = 312;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[131] == 1 && this.global1.data[135] <= 11 && this.global1.data[19] >= 1 && this.global1.data[20] == 99 && !this.events[15].activeSelf && !this.global1.event_done[313])
		{
			this.this_num_event = 313;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && ((this.global1.data[20] >= 5 && this.global1.data[21] >= 1990) || this.global1.data[21] > 1990) && !this.events[15].activeSelf && !this.global1.event_done[314])
		{
			this.this_num_event = 314;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[130] == 0 && !this.events[15].activeSelf && !this.global1.event_done[315])
		{
			this.this_num_event = 315;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 8 && this.global1.data[20] >= 9 && this.global1.data[21] == 1991 && this.global1.data[130] == 3 && this.global1.data[131] == 0 && this.global1.data[168] != 2 && !this.events[15].activeSelf && !this.global1.event_done[316])
		{
			this.this_num_event = 316;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 2 && this.global1.data[20] >= 5 && this.global1.data[21] == 1989 && this.global1.data[0] == 50 && !this.events[15].activeSelf && !this.global1.event_done[318])
		{
			this.this_num_event = 318;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 2 && this.global1.data[20] >= 12 && this.global1.data[21] == 1989 && this.global1.data[0] == 50 && !this.events[15].activeSelf && !this.global1.event_done[319])
		{
			this.this_num_event = 319;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 26 && this.global1.data[20] >= 3 && this.global1.data[21] == 1990 && this.global1.data[0] == 50 && !this.events[15].activeSelf && !this.global1.event_done[320])
		{
			this.this_num_event = 320;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 2 && this.global1.data[20] >= 9 && this.global1.data[21] == 1990 && this.global1.data[0] == 50 && !this.events[15].activeSelf && !this.global1.event_done[321])
		{
			this.this_num_event = 321;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 18 && this.global1.data[20] >= 11 && this.global1.data[21] == 1990 && this.global1.data[0] == 50 && !this.events[15].activeSelf && !this.global1.event_done[322])
		{
			this.this_num_event = 322;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 1 && this.global1.data[20] >= 3 && this.global1.data[21] == 1991 && this.global1.data[0] == 50 && !this.events[15].activeSelf && !this.global1.event_done[323])
		{
			this.this_num_event = 323;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 25 && this.global1.data[20] >= 3 && this.global1.data[21] == 1991 && this.global1.data[136] == 1 && this.global1.data[0] == 50 && this.global1.data[128] == 2 && this.global1.data[148] == 2 && this.global1.data[131] == 0 && this.yug1.gameState.yugregions[1].owner == 1 && !this.events[15].activeSelf && !this.global1.event_done[324])
		{
			this.this_num_event = 324;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 3 && this.global1.data[20] >= 4 && this.global1.data[21] == 1991 && this.global1.data[0] == 50 && this.global1.data[139] == 1 && !this.events[15].activeSelf && !this.global1.event_done[325])
		{
			this.this_num_event = 325;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[19] >= 10 && this.global1.data[20] >= 4 && this.global1.data[21] == 1991 && this.global1.data[0] == 50 && this.global1.data[136] == 1 && this.global1.data[137] == 0 && this.global1.data[131] == 0 && !this.events[15].activeSelf && !this.global1.event_done[326])
		{
			this.this_num_event = 326;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 2 && this.global1.data[20] >= 5 && this.global1.data[21] == 1991 && this.global1.data[0] == 50 && this.global1.data[136] == 1 && !this.events[15].activeSelf && !this.global1.event_done[327])
		{
			this.this_num_event = 327;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 3 && this.global1.data[20] >= 6 && this.global1.data[138] == 0 && this.global1.data[21] == 1991 && this.global1.data[136] == 1 && this.global1.data[0] == 50 && this.global1.data[131] == 0 && this.global1.data[115] <= 11 && !this.events[15].activeSelf && !this.global1.event_done[328])
		{
			this.this_num_event = 328;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 24 && this.global1.data[20] >= 7 && this.global1.data[21] == 1991 && this.global1.data[168] == 0 && this.global1.data[0] == 50 && this.global1.data[131] == 0 && !this.events[15].activeSelf && !this.global1.event_done[329])
		{
			this.this_num_event = 329;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 14 && this.global1.data[20] >= 10 && this.global1.data[21] == 1991 && this.global1.data[168] == 0 && this.global1.data[0] == 50 && this.global1.data[136] == 1 && this.global1.data[131] == 0 && !this.events[15].activeSelf && !this.global1.event_done[330])
		{
			this.this_num_event = 330;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 7 && this.global1.data[20] >= 10 && this.global1.data[21] == 1991 && !this.yug1.gameState.yugcountries[1].peace_with[8] && this.yug1.gameState.yugregions[1].owner == 1 && !this.events[15].activeSelf && !this.global1.event_done[331])
		{
			this.this_num_event = 331;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 14 && this.global1.data[20] >= 11 && this.global1.data[21] == 1991 && this.global1.allcountries[7].Gosstroy == 2 && (this.global1.data[140] >= 3 || this.global1.data[141] >= 3 || this.global1.data[143] >= 3) && !this.events[15].activeSelf && !this.global1.event_done[332])
		{
			this.this_num_event = 332;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 10 && this.global1.data[20] >= 1 && this.global1.data[21] == 1989 && !this.events[15].activeSelf && !this.global1.event_done[333])
		{
			this.this_num_event = 333;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 20 && this.global1.data[20] >= 2 && this.global1.data[21] == 1989 && this.global1.data[0] == 49 && !this.events[15].activeSelf && !this.global1.event_done[334])
		{
			this.this_num_event = 334;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 28 && this.global1.data[20] >= 2 && this.global1.data[21] == 1989 && this.global1.data[0] == 49 && !this.events[15].activeSelf && !this.global1.event_done[335])
		{
			this.this_num_event = 335;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 20 && this.global1.data[20] >= 3 && this.global1.data[21] == 1989 && !this.events[15].activeSelf && !this.global1.event_done[336])
		{
			this.this_num_event = 336;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 28 && this.global1.data[20] >= 3 && this.global1.data[21] == 1989 && this.global1.data[0] == 49 && !this.events[15].activeSelf && !this.global1.event_done[337])
		{
			this.this_num_event = 337;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 28 && this.global1.data[20] >= 6 && this.global1.data[21] == 1989 && this.global1.data[0] == 49 && !this.events[15].activeSelf && !this.global1.event_done[338])
		{
			this.this_num_event = 338;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 2 && this.global1.data[20] >= 12 && this.global1.data[21] == 1989 && !this.events[15].activeSelf && !this.global1.event_done[339])
		{
			this.this_num_event = 339;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.yug1.gameState.yugcountries[10].is_independent && this.global1.data[0] == 49 && !this.events[15].activeSelf && !this.global1.event_done[340])
		{
			this.this_num_event = 340;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[19] >= 3 && this.global1.data[20] >= 7 && this.global1.data[21] == 1990 && this.global1.data[0] == 49 && this.global1.data[126] == 0 && !this.events[15].activeSelf && !this.global1.event_done[341])
		{
			this.this_num_event = 341;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 23 && this.global1.data[20] >= 9 && this.global1.data[21] == 1990 && this.global1.data[0] == 49 && this.global1.data[152] >= 1 && !this.events[15].activeSelf && !this.global1.event_done[342])
		{
			this.this_num_event = 342;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 3 && this.global1.data[20] >= 11 && this.global1.data[21] == 1990 && this.global1.data[0] == 49 && this.global1.data[147] == 1 && !this.events[15].activeSelf && !this.global1.event_done[343])
		{
			this.this_num_event = 343;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 9 && this.global1.data[20] >= 12 && this.global1.data[21] == 1990 && ((this.global1.data[147] == 1 && this.yug1.gameState.yugcountries[8].is_player) || this.yug1.gameState.yugcountries[1].is_player || this.yug1.gameState.yugcountries[3].is_player) && !this.events[15].activeSelf && !this.global1.event_done[344])
		{
			this.this_num_event = 344;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 9 && this.global1.data[20] >= 3 && this.global1.data[21] == 1991 && (this.global1.data[0] == 49 || this.global1.data[0] == 50) && this.global1.data[147] == 1 && this.global1.data[154] != 1 && this.global1.data[148] != 1 && !this.events[15].activeSelf && !this.global1.event_done[345])
		{
			this.this_num_event = 345;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 25 && this.global1.data[20] >= 3 && this.global1.data[21] == 1991 && this.global1.data[0] == 49 && this.global1.data[116] == 1 && this.global1.data[118] == 1 && this.yug1.gameState.yugregions[1].owner == 1 && this.global1.data[131] == 0 && !this.events[15].activeSelf && !this.global1.event_done[346])
		{
			this.this_num_event = 346;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[19] >= 31 && this.global1.data[20] >= 4 && this.global1.data[21] == 1991 && this.global1.data[0] == 49 && this.global1.data[148] == 1 && !this.events[15].activeSelf && !this.global1.event_done[347])
		{
			this.this_num_event = 347;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[19] >= 7 && this.global1.data[20] >= 7 && this.global1.data[21] == 1991 && this.global1.data[0] == 49 && !this.events[15].activeSelf && !this.global1.event_done[348])
		{
			this.this_num_event = 348;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[19] >= 13 && this.global1.data[131] != 1 && this.global1.data[20] >= 7 && this.global1.data[21] == 1991 && this.global1.data[0] == 49 && this.global1.data[118] == 1 && this.global1.data[116] == 1 && !this.events[15].activeSelf && !this.global1.event_done[349])
		{
			this.this_num_event = 349;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 20 && this.global1.data[20] >= 10 && this.global1.data[21] == 1991 && this.global1.data[168] == 0 && this.global1.data[0] == 49 && this.global1.data[136] == 1 && this.global1.data[137] == 0 && (this.global1.data[144] == 0 || this.global1.data[144] == 2) && this.global1.data[131] == 0 && !this.events[15].activeSelf && !this.global1.event_done[350])
		{
			this.this_num_event = 350;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 0 && this.global1.data[157] != 0 && this.global1.data[135] <= 10 && !this.events[15].activeSelf && !this.global1.event_done[351])
		{
			this.this_num_event = 351;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[149] == 1 && this.global1.allcountries[4].Gosstroy == 2 && this.global1.data[0] == 49 && !this.events[15].activeSelf && !this.global1.event_done[353] && !this.global1.event_done[352])
		{
			this.this_num_event = 352;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[135] <= 8 && this.global1.data[149] == 1 && this.global1.data[0] == 49 && !this.events[15].activeSelf && !this.global1.event_done[353])
		{
			this.this_num_event = 353;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 1 && this.global1.data[20] >= 6 && this.global1.data[21] == 1989 && !this.global1.event_done[355])
		{
			this.this_num_event = 355;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 14 && this.global1.data[20] >= 2 && this.global1.data[21] == 1990 && this.global1.data[6] <= 600 && !this.global1.event_done[356])
		{
			this.this_num_event = 356;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (((this.yug1.gameState.yugcountries[3].army < this.yug1.gameState.yugcountries[6].army && !this.yug1.gameState.yugcountries[3].peace_with[8]) || (this.yug1.gameState.yugcountries[3].army < this.yug1.gameState.yugcountries[8].army && !this.yug1.gameState.yugcountries[3].peace_with[6])) && this.global1.data[0] == 50 && !this.global1.event_done[357])
		{
			this.this_num_event = 357;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[9] == 17 && this.global1.data[8] == 76 && this.global1.data[0] == 50 && !this.global1.event_done[358])
		{
			this.this_num_event = 358;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 15 && this.global1.data[20] >= 7 && this.global1.data[21] == 1991 && this.global1.data[128] == 2 && this.global1.data[0] == 50 && this.global1.data[131] == 0 && this.yug1.gameState.yugregions[1].owner == 1 && this.yug1.gameState.yugregions[4].owner == 3 && !this.global1.event_done[346] && !this.global1.event_done[359])
		{
			this.this_num_event = 359;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 9 && this.global1.data[20] >= 6 && this.global1.data[21] == 1991 && this.global1.data[148] == 2 && this.global1.data[0] == 50 && this.yug1.gameState.yugregions[6].owner == 3 && this.global1.data[131] == 0 && this.global1.data[171] == 0 && !this.global1.event_done[346] && !this.global1.event_done[360])
		{
			this.this_num_event = 360;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 2 && this.global1.data[20] >= 9 && this.global1.data[21] == 1990 && (this.global1.data[0] == 49 || this.global1.data[0] == 51) && !this.events[15].activeSelf && !this.global1.event_done[362])
		{
			this.this_num_event = 362;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 29 && this.global1.data[20] >= 11 && this.global1.data[21] == 1990 && this.global1.data[156] != 2 && !this.events[15].activeSelf && !this.global1.event_done[363])
		{
			this.this_num_event = 363;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 3 && this.global1.data[20] >= 9 && this.global1.data[21] == 1989 && !this.events[15].activeSelf && !this.global1.event_done[364])
		{
			this.this_num_event = 364;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 7 && this.global1.data[20] >= 12 && this.global1.data[21] == 1989 && this.global1.data[163] != 1 && !this.events[15].activeSelf && !this.global1.event_done[365])
		{
			this.this_num_event = 365;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 25 && this.global1.data[20] >= 4 && this.global1.data[21] == 1991 && (this.global1.data[131] == 0 || (this.global1.data[191] == 1 && this.global1.data[201] == 0)) && !this.global1.allcountries[49].isOVD && !this.global1.allcountries[50].isOVD && !this.global1.allcountries[51].isOVD && this.global1.data[163] == 2 && !this.events[15].activeSelf && !this.global1.event_done[366])
		{
			this.this_num_event = 366;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 17 && this.global1.data[20] >= 12 && this.global1.data[21] == 1989 && this.global1.data[165] >= 2 && !this.events[27].activeSelf && !this.global1.event_done[368])
		{
			this.this_num_event = 368;
			this.this_num_place = 27;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[20] >= 5 && this.global1.data[21] == 1991 && this.global1.data[164] == 6 && !this.events[27].activeSelf && !this.global1.event_done[372])
		{
			this.this_num_event = 372;
			this.this_num_place = 27;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[3] <= 500 && (!this.yug1.gameState.yugcountries[1].peace_with[2] || !this.yug1.gameState.yugcountries[1].peace_with[3] || !this.yug1.gameState.yugcountries[1].peace_with[0] || !this.yug1.gameState.yugcountries[1].peace_with[4] || !this.yug1.gameState.yugcountries[1].peace_with[5] || !this.yug1.gameState.yugcountries[1].peace_with[5] || !this.yug1.gameState.yugcountries[1].peace_with[6] || !this.yug1.gameState.yugcountries[1].peace_with[7] || !this.yug1.gameState.yugcountries[1].peace_with[8] || !this.yug1.gameState.yugcountries[1].peace_with[9] || !this.yug1.gameState.yugcountries[1].peace_with[10] || !this.yug1.gameState.yugcountries[1].peace_with[11] || !this.yug1.gameState.yugcountries[3].peace_with[0] || !this.yug1.gameState.yugcountries[3].peace_with[1] || !this.yug1.gameState.yugcountries[3].peace_with[2] || !this.yug1.gameState.yugcountries[3].peace_with[4] || !this.yug1.gameState.yugcountries[3].peace_with[5] || !this.yug1.gameState.yugcountries[3].peace_with[6] || !this.yug1.gameState.yugcountries[3].peace_with[7] || !this.yug1.gameState.yugcountries[3].peace_with[8] || !this.yug1.gameState.yugcountries[3].peace_with[9] || !this.yug1.gameState.yugcountries[3].peace_with[10] || !this.yug1.gameState.yugcountries[3].peace_with[11] || !this.yug1.gameState.yugcountries[8].peace_with[0] || !this.yug1.gameState.yugcountries[8].peace_with[1] || !this.yug1.gameState.yugcountries[8].peace_with[2] || !this.yug1.gameState.yugcountries[8].peace_with[3] || !this.yug1.gameState.yugcountries[8].peace_with[4] || !this.yug1.gameState.yugcountries[8].peace_with[5] || !this.yug1.gameState.yugcountries[8].peace_with[6] || !this.yug1.gameState.yugcountries[8].peace_with[7] || !this.yug1.gameState.yugcountries[8].peace_with[9] || !this.yug1.gameState.yugcountries[8].peace_with[10] || !this.yug1.gameState.yugcountries[8].peace_with[11]) && !this.events[15].activeSelf && !this.global1.event_done[373])
		{
			this.this_num_event = 373;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[130] == 1 && this.global1.data[162] != 3 && this.global1.data[19] >= 11 && this.global1.data[20] >= 11 && this.global1.data[21] == 1990 && !this.events[15].activeSelf && !this.global1.event_done[374])
		{
			this.this_num_event = 374;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 8 && this.global1.data[20] >= 3 && this.global1.data[21] == 1991 && this.global1.data[157] == 2 && this.global1.data[131] == 0 && this.global1.data[116] == 1 && this.global1.data[118] == 1 && this.global1.data[137] == 0 && this.global1.data[136] == 1 && this.yug1.gameState.yugregions[1].owner == 1 && this.yug1.gameState.yugregions[3].owner == 3 && !this.events[15].activeSelf && !this.global1.event_done[375])
		{
			this.this_num_event = 375;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 20 && this.global1.data[20] >= 1 && this.global1.data[21] == 1990 && this.global1.data[126] == 0 && !this.events[15].activeSelf && !this.global1.event_done[376])
		{
			this.this_num_event = 376;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 15 && this.global1.data[20] >= 9 && this.global1.data[21] == 1990 && this.global1.data[0] == 50 && this.global1.data[137] == 0 && this.global1.data[136] == 1 && !this.events[15].activeSelf && !this.global1.event_done[377])
		{
			this.this_num_event = 377;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 18 && this.global1.data[20] >= 9 && this.global1.data[21] == 1990 && this.global1.data[0] == 50 && this.global1.data[137] == 0 && this.global1.data[136] == 1 && !this.events[15].activeSelf && !this.global1.event_done[378])
		{
			this.this_num_event = 378;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 20 && this.global1.data[20] >= 12 && this.global1.data[21] == 1990 && this.global1.data[0] == 50 && this.global1.data[137] == 0 && this.global1.data[136] == 1 && !this.events[15].activeSelf && !this.global1.event_done[379])
		{
			this.this_num_event = 379;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && (this.global1.data[156] == 3 || this.global1.allcountries[20].Gosstroy == 2) && this.global1.data[157] == 2 && this.global1.data[128] == 2 && this.global1.data[21] == 1991 && !this.global1.event_done[383])
		{
			this.this_num_event = 383;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 15 && this.global1.data[20] >= 5 && this.global1.data[21] == 1990 && this.yug1.gameState.yugregions[10].owner == 10 && this.yug1.gameState.yugcountries[10].is_exist && !this.global1.event_done[384])
		{
			this.this_num_event = 384;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && ((this.global1.data[19] >= 20 && this.global1.data[20] >= 11 && this.global1.data[21] == 1990) || this.global1.data[21] == 1991) && this.yug1.gameState.yugregions[10].owner == 10 && this.yug1.gameState.yugcountries[10].is_exist && !this.yug1.gameState.yugcountries[10].is_independent && !this.global1.event_done[385])
		{
			this.this_num_event = 385;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 20 && this.global1.data[20] >= 9 && this.global1.data[21] == 1991 && this.global1.data[131] == 0 && this.yug1.gameState.yugregions[10].owner == 10 && this.yug1.gameState.yugcountries[10].is_exist && !this.yug1.gameState.yugcountries[10].is_independent && (this.global1.data[176] == 7 || this.global1.data[176] == 8 || (this.global1.data[176] == 2 && this.global1.data[168] != 2)) && !this.global1.event_done[386])
		{
			this.this_num_event = 386;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 20 && this.global1.data[20] >= 11 && this.global1.data[21] == 1991 && this.yug1.gameState.yugregions[10].owner == 10 && this.yug1.gameState.yugcountries[10].is_exist && !this.yug1.gameState.yugcountries[10].is_independent && this.global1.data[130] == 6 && !this.global1.event_done[387])
		{
			this.this_num_event = 387;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 3 && this.global1.data[20] >= 4 && this.global1.data[21] == 1989 && this.yug1.gameState.yugregions[10].owner != 10 && !this.global1.event_done[388])
		{
			this.this_num_event = 388;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 5 && this.global1.data[20] >= 2 && this.global1.data[21] == 1990 && this.yug1.gameState.yugregions[10].owner != 10 && !this.global1.event_done[389])
		{
			this.this_num_event = 389;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 3 && this.global1.data[20] >= 9 && this.global1.data[21] == 1990 && this.yug1.gameState.yugregions[10].owner != 10 && !this.global1.event_done[390])
		{
			this.this_num_event = 390;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 10 && this.global1.data[20] >= 10 && this.global1.data[21] == 1990 && this.global1.data[0] == 51 && !this.global1.event_done[391])
		{
			this.this_num_event = 391;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 3 && this.global1.data[20] >= 12 && this.global1.data[21] == 1990 && this.global1.data[147] == 1 && !this.global1.event_done[392])
		{
			this.this_num_event = 392;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 13 && this.global1.data[20] >= 6 && this.global1.data[21] == 1990 && this.global1.data[0] == 49 && !this.global1.event_done[393])
		{
			this.this_num_event = 393;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && ((this.global1.data[20] >= 6 && this.global1.data[21] == 1989) || (this.global1.data[20] <= 6 && this.global1.data[21] == 1990)) && this.global1.data[148] == 0 && (this.global1.data[3] <= 450 || this.global1.data[5] <= 350) && !this.global1.event_done[394])
		{
			this.this_num_event = 394;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[20] <= 11 && this.global1.data[21] == 1990 && this.global1.data[148] == 0 && this.global1.data[179] == 0 && (!this.global1.event_done[394] || !this.global1.event_done[397]) && (this.global1.data[3] <= 450 || this.global1.data[1] <= 450) && !this.global1.event_done[395])
		{
			this.this_num_event = 395;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 17 && this.global1.data[20] >= 11 && this.global1.data[21] == 1990 && this.global1.data[148] == 0 && this.global1.data[154] == 0 && this.global1.data[0] == 49 && !this.global1.event_done[396])
		{
			this.this_num_event = 396;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && ((this.global1.data[20] >= 6 && this.global1.data[21] == 1989) || (this.global1.data[20] <= 6 && this.global1.data[21] == 1990)) && this.global1.data[148] == 0 && this.global1.data[3] <= 500 && this.global1.data[0] == 49 && !this.global1.event_done[397])
		{
			this.this_num_event = 397;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 9 && this.global1.data[20] >= 8 && this.global1.data[21] == 1989 && !this.global1.event_done[398])
		{
			this.this_num_event = 398;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 22 && this.global1.data[20] >= 1 && this.global1.data[21] == 1990 && this.global1.data[126] >= 1 && this.yug1.gameState.yugregions[10].owner == 8 && !this.events[15].activeSelf && !this.global1.event_done[399] && !this.global1.event_done[400])
		{
			this.this_num_event = 399;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 22 && this.global1.data[20] >= 1 && this.global1.data[21] == 1990 && this.global1.data[126] >= 1 && !this.events[15].activeSelf && !this.global1.event_done[400])
		{
			this.this_num_event = 400;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 12 && this.global1.data[20] >= 6 && this.global1.data[21] == 1990 && this.global1.data[137] == 2 && !this.events[15].activeSelf && !this.global1.event_done[401])
		{
			this.this_num_event = 401;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 20 && this.global1.data[20] >= 6 && this.global1.data[21] == 1991 && this.global1.data[131] == 0 && this.global1.data[156] == 3 && this.global1.data[179] >= 1 && this.global1.data[148] != 2 && !this.events[15].activeSelf && !this.global1.event_done[402])
		{
			this.this_num_event = 402;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] <= 1 && this.global1.data[19] >= 27 && this.global1.data[20] >= 6 && this.global1.data[21] == 1990 && this.global1.data[128] == 2 && this.global1.data[157] == 2 && this.global1.data[0] != 51 && !this.events[15].activeSelf && !this.global1.event_done[403])
		{
			this.this_num_event = 403;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 30 && this.global1.data[20] >= 6 && this.global1.data[21] == 1990 && !this.events[15].activeSelf && !this.global1.event_done[404])
		{
			this.this_num_event = 404;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 15 && this.global1.data[20] >= 7 && this.global1.data[21] == 1990 && this.global1.allcountries[7].paths == 0 && !this.events[15].activeSelf && !this.global1.event_done[405])
		{
			this.this_num_event = 405;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 2 && !this.events[15].activeSelf && !this.global1.event_done[406])
		{
			this.this_num_event = 406;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 5 && !this.events[15].activeSelf && !this.global1.event_done[407])
		{
			this.this_num_event = 407;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 5 && !this.events[15].activeSelf && !this.global1.event_done[408])
		{
			this.this_num_event = 408;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 5 && !this.events[15].activeSelf && !this.global1.event_done[409])
		{
			this.this_num_event = 409;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 5 && !this.events[15].activeSelf && !this.global1.event_done[410])
		{
			this.this_num_event = 410;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 5 && !this.events[15].activeSelf && !this.global1.event_done[411])
		{
			this.this_num_event = 411;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 5 && !this.events[15].activeSelf && !this.global1.event_done[412])
		{
			this.this_num_event = 412;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 5 && !this.events[15].activeSelf && !this.global1.event_done[413])
		{
			this.this_num_event = 413;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 5 && !this.events[15].activeSelf && !this.global1.event_done[414])
		{
			this.this_num_event = 414;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 5 && !this.events[15].activeSelf && !this.global1.event_done[415])
		{
			this.this_num_event = 415;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 5 && !this.events[15].activeSelf && !this.global1.event_done[416])
		{
			this.this_num_event = 416;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 5 && !this.events[15].activeSelf && !this.global1.event_done[417])
		{
			this.this_num_event = 417;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 5 && !this.events[15].activeSelf && !this.global1.event_done[418])
		{
			this.this_num_event = 418;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 5 && !this.events[15].activeSelf && !this.global1.event_done[419])
		{
			this.this_num_event = 419;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 5 && !this.events[15].activeSelf && !this.global1.event_done[420])
		{
			this.this_num_event = 420;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 5 && !this.events[15].activeSelf && !this.global1.event_done[421])
		{
			this.this_num_event = 421;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 5 && !this.events[15].activeSelf && !this.global1.event_done[422])
		{
			this.this_num_event = 422;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 5 && !this.events[15].activeSelf && !this.global1.event_done[423])
		{
			this.this_num_event = 423;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 5 && !this.events[15].activeSelf && !this.global1.event_done[424])
		{
			this.this_num_event = 424;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] == 5 && !this.events[15].activeSelf && !this.global1.event_done[425])
		{
			this.this_num_event = 425;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 3 && this.global1.data[20] >= 7 && this.global1.data[21] == 1991 && this.global1.data[191] == 1 && !this.global1.event_done[409] && (this.global1.sovietPremiereName == "Горбачёв" || this.global1.sovietPremiereName == " 戈 尔 巴 乔 夫") && !this.events[7].activeSelf && !this.global1.event_done[426])
		{
			this.this_num_event = 426;
			this.this_num_place = 7;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 1 && this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 1 && !this.events[15].activeSelf && !this.global1.event_done[427])
		{
			this.this_num_event = 427;
			this.this_num_place = 7;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 20 && this.global1.data[20] >= 11 && this.global1.data[21] == 1991 && this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 1 && !this.events[15].activeSelf && !this.global1.event_done[428])
		{
			this.this_num_event = 428;
			this.this_num_place = 7;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 20 && this.global1.data[20] >= 6 && this.global1.data[21] == 1991 && this.global1.data[131] >= 1 && (!this.yug1.gameState.yugcountries[10].is_independent || this.yug1.gameState.yugregions[10].owner == 8 || this.yug1.gameState.yugregions[10].owner == 3) && !this.events[15].activeSelf && !this.global1.event_done[429])
		{
			this.this_num_event = 429;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 20 && this.global1.data[20] >= 5 && this.global1.data[21] == 1991 && this.yug1.gameState.modifies[32] == 1 && !this.events[15].activeSelf && !this.global1.event_done[430])
		{
			this.this_num_event = 430;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 20 && this.global1.data[20] >= 5 && this.global1.data[21] == 1991 && this.global1.data[199] == 1 && this.global1.data[200] == 1 && !this.events[15].activeSelf && !this.global1.event_done[431])
		{
			this.this_num_event = 431;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[20] >= 4 && this.global1.data[131] >= 1 && (this.global1.data[19] * this.global1.data[4] - this.global1.data[3]) / 10 > 1600 + this.global1.data[206] * 100 && this.global1.data[211] % 100 + 5 < this.global1.data[19] && !this.events[15].activeSelf && !this.global1.event_done[432])
		{
			this.this_num_event = 432;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 20 && this.global1.data[20] >= 7 && this.global1.data[21] == 1991 && this.global1.data[131] >= 1 && this.global1.data[198] >= 4 && !this.events[15].activeSelf && !this.global1.event_done[433])
		{
			this.this_num_event = 433;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[20] >= 4 && this.global1.data[131] >= 1 && this.global1.data[19] * (this.global1.data[197] + 1) > this.global1.data[206] * 4 && this.global1.data[211] % 100 < this.global1.data[19] && !this.events[15].activeSelf && !this.global1.event_done[434])
		{
			this.this_num_event = 434;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[20] >= 4 && this.global1.data[131] >= 1 && ((this.global1.data[0] == 49 && (this.yug1.gameState.yugcountries[8].army + this.global1.data[9]) / 10 > this.global1.data[10] / 10) || (this.global1.data[0] == 50 && (this.yug1.gameState.yugcountries[3].army + this.global1.data[9]) / 10 > this.global1.data[10] / 9)) && this.global1.data[211] % 100 < this.global1.data[19] && (this.yug1.gameState.yugregions[3].owner == 10 || this.yug1.gameState.yugregions[8].owner == 10 || !this.yug1.gameState.yugcountries[10].is_independent) && !this.events[15].activeSelf && !this.global1.event_done[435])
		{
			this.this_num_event = 435;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[131] >= 1 && this.global1.data[219] + 3 <= this.global1.data[20] && this.global1.data[219] != 0 && !this.events[15].activeSelf && !this.global1.event_done[436])
		{
			this.this_num_event = 436;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 3 && this.global1.data[20] >= 5 && this.global1.data[21] == 1991 && this.global1.data[131] >= 1 && this.global1.data[198] >= 4 && !this.events[15].activeSelf && !this.global1.event_done[437])
		{
			this.this_num_event = 437;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 3 && this.global1.data[20] >= 10 && this.global1.data[21] == 1991 && this.global1.data[131] >= 1 && this.global1.data[210] == 1 && (this.yug1.gameState.yugregions[3].owner == 10 || this.yug1.gameState.yugregions[8].owner == 10 || !this.yug1.gameState.yugcountries[10].is_independent) && !this.events[15].activeSelf && !this.global1.event_done[438])
		{
			this.this_num_event = 438;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[16] >= 3 && this.global1.data[20] >= 6 && this.global1.data[21] == 1991 && this.global1.data[191] == 1 && this.global1.data[194] == 1 && !this.events[15].activeSelf && !this.global1.event_done[439])
		{
			this.this_num_event = 439;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 15 && this.global1.data[20] >= 5 && this.global1.data[21] == 1991 && this.global1.data[191] == 1 && !this.global1.event_done[305] && !this.global1.event_done[306] && !this.global1.event_done[307] && !this.global1.event_done[312] && !this.events[15].activeSelf && !this.global1.event_done[440])
		{
			this.this_num_event = 440;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 27 && this.global1.data[20] >= 5 && this.global1.data[21] == 1991 && this.global1.data[118] == 1 && this.global1.data[116] == 1 && this.global1.data[157] == 2 && this.yug1.gameState.yugregions[0].owner == 0 && this.yug1.gameState.yugregions[1].owner == 1 && !this.events[15].activeSelf && !this.global1.event_done[441])
		{
			this.this_num_event = 441;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[19] >= 27 && this.global1.data[20] >= 6 && this.global1.data[21] == 1991 && this.global1.data[225] == 1 && this.global1.data[0] == 51 && !this.events[15].activeSelf && !this.global1.event_done[442])
		{
			this.this_num_event = 442;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[20] >= 2 && this.global1.data[21] == 1990 && this.yug1.gameState.modifies[5] == 1 && this.yug1.gameState.modifies[4] == 0 && ((this.global1.data[157] == 2 && this.global1.data[199] != 2) || (this.global1.data[157] == 1 && this.global1.data[223] == 1)) && this.global1.data[0] == 49 && !this.events[15].activeSelf && !this.global1.event_done[448])
		{
			this.this_num_event = 448;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[162] != 3 && this.global1.data[20] >= 10 && this.global1.data[21] == 1991 && this.yug1.gameState.yugcountries[0].is_independent && this.yug1.gameState.yugcountries[1].is_independent && this.yug1.gameState.yugcountries[11].is_independent && this.yug1.gameState.yugregions[0].owner == 0 && this.yug1.gameState.yugregions[1].owner == 1 && this.yug1.gameState.yugregions[11].owner == 11 && this.yug1.gameState.yugregions[7].owner != 8 && this.global1.data[0] == 49 && !this.events[15].activeSelf && !this.global1.event_done[449])
		{
			this.this_num_event = 449;
			this.this_num_place = 15;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		Debug.Log("YUGEVENDONE");
	}

	// Token: 0x0600011B RID: 283 RVA: 0x001682C0 File Offset: 0x001664C0
	private void DLCpaths()
	{
		if (this.global1.data[19] >= this.global1.data[47] && this.global1.data[20] >= 8 && this.global1.data[21] >= 1989 && (this.global1.allcountries[1].paths == 2 || this.global1.allcountries[1].paths == 3) && !this.events[1].activeSelf && !this.global1.event_done[1001])
		{
			this.this_num_event = 1001;
			this.this_num_place = 1;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[19] >= this.global1.data[47] && this.global1.data[20] >= 11 && this.global1.data[21] >= 1989 && this.global1.allcountries[1].paths == 2 && !this.events[1].activeSelf && !this.global1.event_done[1002])
		{
			this.this_num_event = 1002;
			this.this_num_place = 1;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[19] >= 3 && ((this.global1.data[20] >= 10 && this.global1.data[21] >= 1991) || (this.global1.data[7] <= 500 && this.global1.data[21] >= 1990) || (this.global1.data[7] <= 700 && this.global1.data[21] >= 1991)) && this.global1.allcountries[1].paths == 2 && !this.events[1].activeSelf && !this.global1.event_done[1003])
		{
			this.this_num_event = 1003;
			this.this_num_place = 1;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (((this.global1.data[20] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && this.global1.allcountries[1].paths == 3 && !this.events[1].activeSelf && !this.global1.event_done[1004])
		{
			this.this_num_event = 1004;
			this.this_num_place = 1;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[20] >= this.global1.data[48] + this.global1.data[49] && this.global1.data[21] >= 1991 && this.global1.allcountries[1].paths == 3 && !this.events[1].activeSelf && !this.global1.event_done[1005])
		{
			this.this_num_event = 1005;
			this.this_num_place = 1;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[19] >= this.global1.data[48] && this.global1.data[20] >= 3 && this.global1.data[21] >= 1990 && this.global1.allcountries[1].paths == 4 && !this.events[1].activeSelf && !this.global1.event_done[92])
		{
			this.this_num_event = 92;
			this.this_num_place = 1;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[19] >= this.global1.data[48] && this.global1.data[20] >= 11 && this.global1.data[21] >= 1989 && this.global1.allcountries[1].paths == 4 && !this.events[1].activeSelf && !this.global1.event_done[1007])
		{
			this.this_num_event = 1007;
			this.this_num_place = 1;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[19] >= 5 && ((this.global1.data[20] >= 10 && this.global1.data[21] >= 1991) || (this.global1.data[7] <= 500 && this.global1.data[20] >= 5 && this.global1.data[21] == 1990) || (this.global1.data[7] <= 700 && this.global1.data[20] >= 5 && this.global1.data[21] == 1991)) && this.global1.allcountries[1].paths == 4 && !this.events[1].activeSelf && !this.global1.event_done[1008])
		{
			this.this_num_event = 1008;
			this.this_num_place = 1;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[19] >= this.global1.data[47] && this.global1.data[20] >= 8 && this.global1.data[21] >= 1989 && this.global1.allcountries[1].paths == 5 && !this.events[1].activeSelf && !this.global1.event_done[89])
		{
			this.this_num_event = 89;
			this.this_num_place = 1;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[19] >= 4 && this.global1.data[20] >= 9 && this.global1.data[21] >= 1989 && this.global1.allcountries[1].paths == 5 && !this.events[1].activeSelf && !this.global1.event_done[1010])
		{
			this.this_num_event = 1010;
			this.this_num_place = 1;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[19] >= 2 && ((this.global1.data[20] >= 10 && this.global1.data[21] >= 1991) || (this.global1.data[7] <= 500 && this.global1.data[20] >= 5 && this.global1.data[21] == 1990) || (this.global1.data[7] <= 700 && this.global1.data[20] >= 5 && this.global1.data[21] == 1991)) && this.global1.allcountries[1].paths == 5 && !this.events[1].activeSelf && !this.global1.event_done[1011])
		{
			this.this_num_event = 1011;
			this.this_num_place = 1;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (((this.global1.data[7] <= 600 && this.global1.data[21] == 1989) || (this.global1.data[7] <= 750 && this.global1.data[21] == 1990) || this.global1.data[21] >= 1991) && this.global1.data[19] >= this.global1.data[49] && this.global1.allcountries[1].paths == 6 && !this.events[1].activeSelf && !this.global1.event_done[1012])
		{
			this.this_num_event = 1012;
			this.this_num_place = 1;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if ((this.global1.data[21] >= 1991 || this.global1.data[7] <= 665) && this.global1.allcountries[1].paths == 6 && !this.events[1].activeSelf && this.global1.event_done[1012] && !this.global1.event_done[1013])
		{
			this.this_num_event = 1013;
			this.this_num_place = 1;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[19] >= 5 && this.global1.data[20] >= 5 && this.global1.data[21] >= 1991 && this.global1.allcountries[1].paths == 6 && !this.events[1].activeSelf && !this.global1.event_done[1014])
		{
			this.this_num_event = 1014;
			this.this_num_place = 1;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		if (this.global1.data[19] >= 2 && this.global1.data[20] >= 8 && this.global1.data[21] >= 1989 && this.global1.allcountries[2].paths == 2 && !this.events[2].activeSelf && !this.global1.event_done[8])
		{
			this.this_num_event = 8;
			this.this_num_place = 2;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[19] >= 26 && this.global1.data[20] >= 8 && this.global1.data[21] >= 1989 && this.global1.allcountries[2].paths == 2 && !this.events[2].activeSelf && !this.global1.event_done[1016])
		{
			this.this_num_event = 1016;
			this.this_num_place = 2;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[21] >= 1990 && this.global1.allcountries[2].paths == 2 && !this.events[2].activeSelf && !this.global1.event_done[1017])
		{
			this.this_num_event = 1017;
			this.this_num_place = 2;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[20] >= 2 && this.global1.allcountries[2].paths == 3 && !this.events[2].activeSelf && !this.global1.event_done[1018])
		{
			this.this_num_event = 1018;
			this.this_num_place = 2;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[19] >= 25 && this.global1.data[20] >= 1 && this.global1.data[21] >= 1990 && this.global1.allcountries[2].paths == 3 && !this.events[2].activeSelf && !this.global1.event_done[1019])
		{
			this.this_num_event = 1019;
			this.this_num_place = 2;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[19] >= 14 && this.global1.data[20] >= 2 && this.global1.data[21] >= 1991 && this.global1.allcountries[2].paths == 3 && !this.events[2].activeSelf && !this.global1.event_done[1020])
		{
			this.this_num_event = 1020;
			this.this_num_place = 2;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.allcountries[2].paths == 4 && !this.events[2].activeSelf && !this.global1.event_done[1021])
		{
			this.this_num_event = 1021;
			this.this_num_place = 2;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (this.global1.data[19] >= 2 && this.global1.data[20] >= 8 && this.global1.data[21] >= 1989 && this.global1.allcountries[2].paths == 4 && !this.events[2].activeSelf && !this.global1.event_done[1022])
		{
			this.this_num_event = 1022;
			this.this_num_place = 2;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		else if (((this.global1.data[20] >= 10 && this.global1.data[21] >= 1991) || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 1) || this.global1.allcountries[this.global1.data[0]].Vyshi || this.global1.data[7] <= 210 || (this.global1.allcountries[4].Gosstroy >= 1 && !this.global1.allcountries[4].isSEV && !this.global1.allcountries[4].isOVD && this.global1.allcountries[2].Gosstroy >= 1 && !this.global1.allcountries[2].isSEV && !this.global1.allcountries[2].isOVD)) && this.global1.allcountries[2].paths == 4 && !this.events[2].activeSelf && !this.global1.event_done[65])
		{
			this.this_num_event = 65;
			this.this_num_place = 2;
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
		if (this.global1.allcountries[3].paths > 1)
		{
			if (this.global1.data[19] >= this.global1.data[49] && this.global1.data[20] >= 10 && this.global1.data[21] >= 1989 && this.global1.allcountries[3].paths == 2 && !this.events[3].activeSelf && !this.global1.event_done[1024])
			{
				this.this_num_event = 1024;
				this.this_num_place = 3;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[19] >= this.global1.data[49] && this.global1.data[20] >= 9 && this.global1.data[21] >= 1990 && this.global1.allcountries[3].paths == 2 && !this.events[3].activeSelf && !this.global1.event_done[1025])
			{
				this.this_num_event = 1025;
				this.this_num_place = 3;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[19] >= this.global1.data[48] && this.global1.data[20] >= 2 && this.global1.data[21] >= 1991 && this.global1.allcountries[3].paths == 2 && !this.events[3].activeSelf && !this.global1.event_done[1026])
			{
				this.this_num_event = 1026;
				this.this_num_place = 3;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[19] >= this.global1.data[49] && this.global1.data[20] >= 10 && this.global1.data[21] >= 1989 && this.global1.allcountries[3].paths == 3 && !this.events[3].activeSelf && !this.global1.event_done[1027])
			{
				this.this_num_event = 1027;
				this.this_num_place = 3;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[19] >= this.global1.data[49] && this.global1.data[20] >= 9 && this.global1.data[21] >= 1990 && this.global1.allcountries[3].paths == 3 && !this.events[3].activeSelf && !this.global1.event_done[1028])
			{
				this.this_num_event = 1028;
				this.this_num_place = 3;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[19] >= this.global1.data[48] && this.global1.data[20] >= 2 && this.global1.data[21] >= 1991 && this.global1.allcountries[3].paths == 3 && !this.events[3].activeSelf && !this.global1.event_done[1029])
			{
				this.this_num_event = 1029;
				this.this_num_place = 3;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.pastDate(this.global1.data[49], 10, 1989) && this.global1.allcountries[3].paths == 4 && !this.checkWas(3, 1030))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 0, 1990) || (this.global1.data[7] <= 400 && this.global1.event_done[1030])) && this.global1.allcountries[3].paths == 4 && !this.checkWas(3, 1031))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(0, this.global1.data[49] + this.global1.data[48], 1991) || (this.global1.data[7] <= 300 && this.global1.event_done[1031])) && this.global1.allcountries[3].paths == 4 && !this.checkWas(3, 1032))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.pastDate(this.global1.data[49], 10, 1989) && this.global1.allcountries[3].paths == 5 && !this.checkWas(3, 1033))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 0, 1990) || (this.global1.data[7] <= 659 && this.global1.event_done[1033])) && this.global1.allcountries[3].paths == 5 && !this.checkWas(3, 1034))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(0, this.global1.data[49] + this.global1.data[48], 1991) || (this.global1.data[7] <= 300 && this.global1.event_done[1034])) && this.global1.allcountries[3].paths == 5 && !this.checkWas(3, 1035))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
		}
		if (this.global1.allcountries[4].paths > 1)
		{
			if ((this.pastDate(this.global1.data[49], 7, 1989) || this.global1.data[7] <= 870) && this.global1.allcountries[4].paths == 2 && !this.checkWas(4, 1036))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.pastDate(this.global1.data[49], 11, 1989) && this.global1.allcountries[4].paths == 2 && !this.checkWas(4, 1037))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 0, 1991) || (this.global1.data[7] <= 370 && this.global1.event_done[1037])) && this.global1.allcountries[4].paths == 2 && !this.checkWas(4, 1038))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 7, 1989) || this.global1.data[7] <= 870) && this.global1.allcountries[4].paths == 3 && !this.checkWas(4, 1039))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 0, 1990) || (this.global1.data[7] <= 370 && this.global1.event_done[1039])) && this.global1.allcountries[4].paths == 3 && !this.checkWas(4, 1040))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 0, 1991) || (this.global1.data[7] <= 370 && this.global1.event_done[1037])) && this.global1.allcountries[4].paths == 3 && !this.checkWas(4, 1041))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 7, 1989) || this.global1.data[7] <= 870) && this.global1.allcountries[4].paths == 4 && !this.checkWas(4, 1042))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 0, 1990) || (this.global1.data[7] <= 470 && this.global1.event_done[1042])) && this.global1.allcountries[4].paths == 4 && !this.checkWas(4, 1043))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 0, 1991) || (this.global1.data[7] <= 370 && this.global1.event_done[1043])) && this.global1.allcountries[4].paths == 4 && this.global1.data[0] != 5 && !this.checkWas(4, 1044))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 0, 1991) || (this.global1.data[7] <= 370 && this.global1.event_done[1043])) && this.global1.allcountries[4].paths == 4 && this.global1.data[0] == 5 && !this.checkWas(4, 1045))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 7, 1989) || this.global1.data[7] <= 870) && this.global1.allcountries[4].paths == 5 && !this.checkWas(4, 1046))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 0, 1990) || (this.global1.data[7] <= 570 && this.global1.event_done[1046])) && this.global1.allcountries[4].paths == 5 && !this.checkWas(4, 1047))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 0, 1991) || (this.global1.data[7] <= 370 && this.global1.event_done[1047])) && this.global1.allcountries[4].paths == 5 && !this.checkWas(4, 1048))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
		}
		if (this.global1.allcountries[5].paths > 1)
		{
			if (this.pastDate(this.global1.data[49], 4, 1989) && this.global1.allcountries[5].paths == 2 && !this.checkWas(5, 1049) && !this.global1.event_done[1044])
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.pastDate(this.global1.data[49], 6, 1990) && this.global1.allcountries[5].paths == 2 && !this.checkWas(5, 46) && !this.global1.event_done[1044])
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 10, 1991) || (this.global1.data[7] <= 370 && this.global1.event_done[46])) && this.global1.allcountries[5].paths == 2 && !this.checkWas(4, 1050) && !this.global1.event_done[1044])
			{
				this.this_num_place = 5;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.pastDate(this.global1.data[49], 3, 1989) && this.global1.allcountries[5].paths == 3 && !this.checkWas(5, 1051) && !this.global1.event_done[1044])
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.pastDate(this.global1.data[49], 11, 1989) && this.global1.allcountries[5].paths == 3 && !this.checkWas(5, 1052) && !this.global1.event_done[1044])
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 2, 1991) || (this.global1.data[7] <= 370 && this.global1.event_done[1052])) && this.global1.allcountries[5].paths == 3 && !this.checkWas(5, 1053) && !this.global1.event_done[1044])
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.pastDate(this.global1.data[49], 12, 1989) && this.global1.allcountries[5].paths == 4 && !this.checkWas(5, 1054) && !this.global1.event_done[1044])
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.pastDate(this.global1.data[49], 5, 1990) && this.global1.allcountries[5].paths == 4 && !this.checkWas(5, 1055) && !this.global1.event_done[1044])
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 2, 1991) || (this.global1.data[7] <= 470 && this.global1.event_done[1055])) && this.global1.allcountries[5].paths == 4 && !this.checkWas(5, 1056) && !this.global1.event_done[1044])
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 0, 1990) || this.global1.data[7] <= 750) && this.global1.allcountries[5].paths == 5 && !this.checkWas(5, 1057) && !this.global1.event_done[1044])
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.pastDate(this.global1.data[49], 3, 1990) && this.global1.allcountries[5].paths == 5 && !this.checkWas(5, 1058) && !this.global1.event_done[1044])
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 9, 1991) || ((this.global1.data[7] <= 370 || !this.global1.allcountries[5].isOVD) && this.global1.event_done[1058])) && this.global1.allcountries[5].paths == 5 && !this.checkWas(5, 1059) && !this.global1.event_done[1044])
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
		}
		if (this.global1.allcountries[6].paths > 1)
		{
			if ((this.pastDate(this.global1.data[49], 11, 1989) || this.global1.data[7] <= 870) && this.global1.allcountries[6].paths == 2 && !this.checkWas(6, 1060))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 9, 1990) || (this.global1.data[7] <= 600 && this.global1.event_done[1060])) && this.global1.allcountries[6].paths == 2 && !this.checkWas(6, 1061))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(0, this.global1.data[49] + this.global1.data[48], 1991) || (this.global1.data[7] <= 400 && this.global1.event_done[1061])) && this.global1.allcountries[6].paths == 2 && !this.checkWas(6, 1062))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 11, 1989) || this.global1.data[7] <= 770) && this.global1.allcountries[6].paths == 3 && !this.checkWas(6, 1063))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 2, 1990) || (this.global1.data[7] <= 470 && this.global1.event_done[1063])) && this.global1.allcountries[6].paths == 3 && !this.checkWas(6, 1064))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(20, 20, 1990) || (this.global1.data[7] <= 370 && this.global1.event_done[1064])) && this.global1.allcountries[6].paths == 3 && !this.checkWas(6, 1065))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 11, 1989) || this.global1.data[7] <= 780) && this.global1.allcountries[6].paths == 4 && !this.checkWas(6, 1066))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 9, 1990) || (this.global1.data[7] <= 600 && this.global1.event_done[1066])) && this.global1.allcountries[6].paths == 4 && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51 && !this.checkWas(6, 1067))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(0, 2, 1991) || (this.global1.data[7] <= 400 && this.global1.event_done[1067])) && this.global1.data[235] != 9 && this.global1.allcountries[6].paths == 4 && !this.checkWas(6, 1068))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(this.global1.data[49], 11, 1989) || this.global1.data[7] <= 770) && this.global1.allcountries[6].paths == 5 && !this.checkWas(6, 1063))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(6, 7, 1990) || (this.global1.data[7] <= 280 && this.global1.event_done[1063])) && this.global1.allcountries[6].paths == 5 && !this.checkWas(6, 1070))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(20, 12, 1990) || (this.global1.data[7] <= 70 && this.global1.event_done[1070])) && this.global1.allcountries[6].paths == 5 && !this.checkWas(6, 1071))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
		}
		if (this.global1.allcountries[7].paths > 1)
		{
			if (this.pastDate(2, 4, 1989) && (this.global1.allcountries[7].paths == 2 || this.global1.allcountries[7].paths == 3) && !this.checkWas(7, 1072))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.pastDate(5, 5, 1989) && this.global1.allcountries[7].paths == 2 && !this.checkWas(7, 1073))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(2, 7, 1990) || (this.global1.data[7] <= 480 && this.global1.event_done[1073])) && this.global1.allcountries[7].paths == 2 && !this.checkWas(7, 1074))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.pastDate(1, 5, 1989) && this.global1.allcountries[7].paths == 3 && !this.checkWas(7, 1075))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.pastDate(13, 7, 1990) || (this.global1.data[7] <= 590 && this.global1.event_done[1075])) && this.global1.allcountries[7].paths == 3 && !this.checkWas(7, 1076))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.pastDate(7, 10, 1990) && this.global1.allcountries[7].paths == 4 && !this.checkWas(7, 62))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
		}
		if (this.global1.allcountries[17].Westalgie + this.global1.data[7] >= 1300 && !this.checkWas(21, 1078))
		{
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			return;
		}
		if (this.global1.allcountries[17].Westalgie >= 300 && this.global1.allcountries[1].Gosstroy == 2 && this.global1.data[0] != 1 && !this.checkWas(21, 1079))
		{
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			return;
		}
		if (this.global1.event_done[1045] && this.global1.allcountries[4].paths == 4 && this.global1.allcountries[6].paths == 3 && this.global1.data[0] == 5 && this.global1.data[50] == 1 && !this.checkWas(4, 1080))
		{
			this.events[this.this_num_place].SetActive(true);
			this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
		}
	}

	// Token: 0x0600011C RID: 284 RVA: 0x0016B87C File Offset: 0x00169A7C
	private void Repaint(bool need_to_pluse)
	{
		if (need_to_pluse)
		{
			int[] array = new int[9];
			int num;
			for (int i = 1; i < array.Length; i = num + 1)
			{
				array[i] = this.global1.data[i];
				num = i;
			}
			if (this.is_showed)
			{
				this.save_speed = this.global1.speed;
				this.global1.speed = 0;
			}
			ref int ptr = ref this.global1.data[19];
			ref int ptr2 = ref ptr;
			num = ptr;
			ptr2 = num + 1;
			if ((this.global1.data[20] == 2 && this.global1.data[19] == 29) || (this.global1.data[19] == 31 && (this.global1.data[20] == 4 || this.global1.data[20] == 6 || this.global1.data[20] == 9 || this.global1.data[20] == 11)) || (this.global1.data[19] == 32 && (this.global1.data[20] == 1 || this.global1.data[20] == 3 || this.global1.data[20] == 5 || this.global1.data[20] == 7 || this.global1.data[20] == 8 || this.global1.data[20] == 10 || this.global1.data[20] == 12)))
			{
				this.global1.data[19] = 1;
				ptr = ref this.global1.data[20];
				ref int ptr3 = ref ptr;
				num = ptr;
				ptr3 = num + 1;
				this.global1.bylo = false;
				if (this.global1.data[21] < 1992 && !this.global1.bylo)
				{
					int num2;
					if (this.global1.data[30] * 2 / 10 + 40 <= 0)
					{
						if (this.global1.data[26] > 0 && (this.global1.data[0] != 5 || (this.global1.data[0] == 5 && !this.global1.event_done[94])))
						{
							num2 = 10;
						}
						else if (this.global1.data[26] > 0 && this.global1.data[0] == 5 && this.global1.event_done[94] && this.global1.data[34] == 11)
						{
							num2 = 40;
						}
						else if (this.global1.data[26] > 0 && this.global1.data[0] == 5 && this.global1.event_done[94] && this.global1.data[34] == 4)
						{
							num2 = this.global1.data[30] * 2 / 10 + 25;
						}
						else
						{
							num2 = this.global1.data[30] * 2 / 10;
						}
					}
					else if (this.global1.data[30] <= 250)
					{
						if (this.global1.data[26] > 0 && (this.global1.data[0] != 5 || (this.global1.data[0] == 5 && !this.global1.event_done[94])))
						{
							num2 = (this.global1.data[30] * 2 - this.global1.data[26] / 4) / 10;
						}
						else if (this.global1.data[26] > 0 && this.global1.data[0] == 5 && this.global1.event_done[94] && this.global1.data[34] == 11)
						{
							num2 = this.global1.data[30] * 2 / 10 + 40;
						}
						else if (this.global1.data[26] > 0 && this.global1.data[0] == 5 && this.global1.event_done[94] && this.global1.data[34] == 4)
						{
							num2 = this.global1.data[30] * 2 / 10 + 25;
						}
						else
						{
							num2 = this.global1.data[30] * 2 / 10;
						}
					}
					else if (this.global1.data[26] > 0 && (this.global1.data[0] != 5 || (this.global1.data[0] == 5 && !this.global1.event_done[94])))
					{
						num2 = (500 - this.global1.data[26] / 4) / 10;
					}
					else if (this.global1.data[26] > 0 && this.global1.data[0] == 5 && this.global1.event_done[94] && this.global1.data[34] == 11)
					{
						num2 = 90;
					}
					else if (this.global1.data[26] > 0 && this.global1.data[0] == 5 && this.global1.event_done[94] && this.global1.data[34] == 4)
					{
						num2 = 75;
					}
					else
					{
						num2 = 50;
					}
					int num3;
					if (this.global1.data[23] > this.global1.data[24])
					{
						num3 = (this.global1.data[23] - this.global1.data[24]) * 2 - 1;
					}
					else
					{
						num3 = (this.global1.data[24] - this.global1.data[23]) * -2 + 1;
					}
					string text = PlayerPrefs.GetString("V1");
					PlayerPrefs.SetString("V1", text + "\n" + (100 + num2 + num3).ToString() + "%");
					text = PlayerPrefs.GetString("I2");
					PlayerPrefs.SetString("I2", text + "\n" + (this.global1.data[5] * 10 / (64 + (this.global1.data[21] - 1984))).ToString() + "%");
					int num4 = (this.global1.data[23] - this.global1.data[24]) / (1992 - this.global1.data[21]);
					int num5 = this.global1.data[5] * 10 / (64 + (this.global1.data[21] - 1984)) / 100;
					text = PlayerPrefs.GetString("S3");
					PlayerPrefs.SetString("S3", text + "\n" + ((num4 + num5) * -1).ToString() + "%");
					float num6 = ((float)(100 + num2 + num3) + (float)(this.global1.data[5] * 10 / (64 + (this.global1.data[21] - 1984))) - (float)((num4 + num5) * -1)) / 100f;
					text = PlayerPrefs.GetString("R3");
					PlayerPrefs.SetString("R3", text + "\n" + num6.ToString() + "%");
				}
			}
			if (this.global1.data[20] == 13)
			{
				this.global1.data[20] = 1;
				ptr = ref this.global1.data[21];
				ref int ptr4 = ref ptr;
				num = ptr;
				ptr4 = num + 1;
			}
			bool flag = true;
			for (int j = 0; j < this.global1.science.Length; j = num + 1)
			{
				if (this.global1.science_time[j] < 360)
				{
					flag = false;
					break;
				}
				num = j;
			}
			if (flag)
			{
				this.thishappened.SetActive(false);
			}
			else if (this.izuchenp)
			{
				this.thishappened.SetActive(true);
				this.thishappened.GetComponent<ScienceHappenedScript>().this_num = this.sci_num + ((this.global1.data[0] >= 49 && this.global1.data[0] <= 51) ? 11 : 0);
				this.thishappened.GetComponent<ScienceHappenedScript>().IsHappened();
				this.izuchenp = false;
				this.global1.neizucheno = true;
			}
			if (this.global1.data[97] <= 0)
			{
				this.global1.data[97] = this.global1.data[7];
			}
			if (this.global1.data[97] - this.global1.data[7] >= 400)
			{
				this.global1.data[97] = this.global1.data[7];
				ptr = ref this.global1.data[65];
				ref int ptr5 = ref ptr;
				num = ptr;
				ptr5 = num - 1;
			}
			if (this.global1.data[0] == 12 && this.global1.data[19] == 3 && (this.global1.data[20] == 6 || this.global1.data[20] == 1))
			{
				this.global1.event_done[250] = false;
			}
			if (this.global1.allcountries[1].paths > 0 || this.global1.allcountries[2].paths > 0 || this.global1.allcountries[3].paths > 0 || this.global1.allcountries[4].paths > 0 || this.global1.allcountries[5].paths > 0 || this.global1.allcountries[6].paths > 0 || this.global1.allcountries[7].paths > 0)
			{
				this.DLCpaths();
			}
			if ((this.global1.data[0] == 45 || this.global1.data[0] == 8 || this.global1.data[0] == 11) && ReqEventForDLC.RequrementsDLC04(ref this.this_num_event, ref this.this_num_place, ref this.global1))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((this.global1.data[0] == 38 || this.global1.data[0] == 23 || this.global1.data[0] == 26) && ReqEventForDLC.RequrementsDLC05(ref this.this_num_event, ref this.this_num_place, ref this.global1))
			{
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
			{
				if (!this.yug1.gameState.battle_royal)
				{
					this.YugoEvents();
				}
				else if (this.global1.data[19] <= 3 && this.global1.data[20] >= 2 && this.global1.data[21] == 1989 && !this.global1.event_done[1108])
				{
					this.this_num_event = 1108;
					this.this_num_place = 15;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] >= 13 && this.global1.data[20] >= 2 && this.global1.data[21] == 1989 && !this.global1.event_done[1100])
				{
					this.this_num_event = 1100;
					this.this_num_place = 15;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] <= 3 && this.global1.data[20] >= 3 && this.global1.data[21] == 1989 && !this.global1.event_done[1101])
				{
					this.this_num_event = 1101;
					this.this_num_place = 15;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] <= 3 && this.global1.data[20] >= 6 && this.global1.data[21] == 1989 && this.yug1.gameState.yugcountries[11].is_exist && this.yug1.gameState.player != 11 && !this.global1.event_done[1102])
				{
					this.this_num_event = 1102;
					this.this_num_place = 15;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (!this.yug1.gameState.yugcountries[10].is_exist && this.global1.event_done[1101] && !this.global1.event_done[1103])
				{
					this.this_num_event = 1103;
					this.this_num_place = 15;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (!this.yug1.gameState.yugcountries[9].is_exist && this.global1.event_done[1101] && !this.global1.event_done[1105])
				{
					this.this_num_event = 1105;
					this.this_num_place = 15;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (!this.yug1.gameState.yugcountries[0].is_exist && this.global1.event_done[1101] && !this.global1.event_done[1106])
				{
					this.this_num_event = 1106;
					this.this_num_place = 15;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.yug1.gameState.yugcountries[this.yug1.gameState.player].have_regions >= 8 && !this.global1.event_done[1107])
				{
					this.this_num_event = 1107;
					this.this_num_place = 15;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] == 15 && this.global1.data[20] % 6 == 0)
				{
					this.this_num_event = 1104;
					this.this_num_place = 15;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
			}
			if (this.global1.data[216] <= 49 && ((this.global1.data[19] >= this.global1.data[48] && this.global1.data[20] >= 1 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && this.global1.data[0] != 12 && this.global1.data[0] != 38 && !this.events[7].activeSelf && !this.global1.event_done[3])
			{
				this.this_num_event = 3;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && this.global1.allcountries[7].paths != 3 && ((this.global1.data[19] >= this.global1.data[48] && this.global1.data[20] >= 7 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && !this.events[7].activeSelf && !this.global1.event_done[4])
			{
				this.this_num_event = 4;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && this.global1.allcountries[7].paths != 3 && (this.global1.data[7] <= 860 || (this.global1.data[21] == 1990 && this.global1.data[7] <= 900) || (this.global1.data[21] > 1990 && this.global1.data[7] <= 920)) && !this.global1.is_gkchp && !this.events[7].activeSelf && !this.global1.event_done[5])
			{
				this.this_num_event = 5;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && (this.global1.data[7] <= 600 || (this.global1.data[21] == 1990 && this.global1.data[7] <= 675) || (this.global1.data[21] > 1990 && this.global1.data[7] <= 750)) && !this.events[7].activeSelf && !this.global1.event_done[6] && this.global1.event_done[5])
			{
				this.this_num_event = 6;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.allcountries[6].Torg && this.global1.data[216] <= 48 && this.global1.allcountries[5].Torg && this.global1.data[0] != 5 && this.global1.data[0] != 10 && this.global1.data[0] != 12 && this.global1.data[0] != 18 && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51 && ((this.global1.data[19] >= this.global1.data[48] && this.global1.data[20] >= 1 && this.global1.data[21] >= 1990) || (this.global1.data[20] >= 2 && this.global1.data[21] >= 1990)) && this.global1.allcountries[6].Gosstroy <= 0 && (this.global1.allcountries[5].Gosstroy <= 0 || this.global1.allcountries[5].subideology == 0) && !this.events[7].activeSelf && !this.global1.event_done[7])
			{
				this.this_num_event = 7;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[0] != 2 && this.global1.data[216] <= 48 && this.global1.allcountries[2].paths <= 0 && this.global1.allcountries[2].Gosstroy == 1 && this.global1.data[236] != 1 && !this.events[2].activeSelf && !this.global1.event_done[8])
			{
				this.this_num_event = 8;
				this.this_num_place = 2;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[0] != 4 && this.global1.data[216] <= 48 && this.global1.allcountries[4].paths <= 0 && this.global1.allcountries[4].Gosstroy == 2 && !this.events[4].activeSelf && !this.global1.event_done[9])
			{
				this.this_num_event = 9;
				this.this_num_place = 4;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[0] != 6 && this.global1.data[216] <= 48 && this.global1.allcountries[6].paths <= 0 && this.global1.allcountries[6].Gosstroy == 1 && !this.events[6].activeSelf && !this.global1.event_done[10])
			{
				this.this_num_event = 10;
				this.this_num_place = 6;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[0] != 3 && this.global1.data[216] <= 48 && this.global1.allcountries[3].paths <= 0 && this.global1.allcountries[3].Gosstroy == 1 && !this.events[3].activeSelf && !this.global1.event_done[11])
			{
				this.this_num_event = 11;
				this.this_num_place = 3;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[0] != 5 && this.global1.data[216] <= 48 && this.global1.allcountries[5].paths <= 0 && this.global1.data[229] == 0 && this.global1.allcountries[5].Gosstroy == 1 && !this.events[5].activeSelf && !this.global1.event_done[12])
			{
				this.this_num_event = 12;
				this.this_num_place = 5;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.allcountries[7].Gosstroy == 0 && this.global1.data[216] <= 48 && !this.global1.allcountries[7].Vyshi && !this.global1.is_gkchp && this.global1.data[0] != 10 && this.global1.data[0] != 12 && this.global1.data[0] != 18 && this.global1.data[15] < 8 && (((this.global1.data[0] < 49 || this.global1.data[0] > 51) && this.global1.data[21] >= 1990 && this.global1.data[20] >= 3) || this.global1.data[21] >= 1991) && !this.events[7].activeSelf && !this.global1.event_done[34])
			{
				this.this_num_event = 34;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.allcountries[7].paths <= 2 && this.global1.data[216] <= 48 && ((this.global1.data[21] >= 1990 && !this.global1.is_gkchp) || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 1)) && this.global1.allcountries[7].isSEV && (this.global1.data[20] >= 3 + this.global1.data[51] || this.global1.event_done[73]) && !this.events[7].activeSelf && !this.global1.event_done[35])
			{
				this.this_num_event = 35;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.allcountries[7].paths <= 0 && this.global1.data[216] <= 48 && this.global1.data[7] <= 200 && !this.global1.is_gkchp && !this.events[7].activeSelf && !this.global1.event_done[36])
			{
				this.this_num_event = 36;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.allcountries[7].paths <= 0 && this.global1.data[216] <= 48 && (this.global1.data[14] <= 1 || this.global1.data[15] <= 6 || (this.global1.data[15] <= 7 && this.global1.data[17] <= 15)) && this.global1.data[0] != 20 && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51 && this.global1.data[0] != 12 && !this.global1.allcountries[7].Vyshi && !this.global1.is_elect && !this.global1.is_gkchp && ((this.global1.data[20] >= this.global1.data[47] && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && !this.events[7].activeSelf && !this.global1.event_done[37])
			{
				this.this_num_event = 37;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[0] != 2 && this.global1.data[216] <= 48 && this.global1.allcountries[2].paths <= 0 && this.global1.allcountries[2].Gosstroy == 2 && !this.events[2].activeSelf && !this.global1.event_done[38])
			{
				this.this_num_event = 38;
				this.this_num_place = 2;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[0] != 5 && this.global1.data[216] <= 48 && this.global1.allcountries[5].paths <= 0 && this.global1.allcountries[5].Gosstroy == 2 && !this.events[5].activeSelf && !this.global1.event_done[71] && !this.global1.event_done[39])
			{
				this.this_num_event = 39;
				this.this_num_place = 5;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[0] != 6 && this.global1.data[216] <= 48 && this.global1.allcountries[6].paths <= 0 && this.global1.allcountries[6].Gosstroy == 0 && this.global1.data[20] >= 2 && this.global1.data[21] >= 1990 && !this.events[6].activeSelf && !this.global1.event_done[40])
			{
				this.this_num_event = 40;
				this.this_num_place = 6;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (((this.global1.data[20] >= 5 && this.global1.data[216] <= 48 && this.global1.data[21] >= 1990) || this.global1.allcountries[7].Gosstroy == 2) && !this.events[29].activeSelf && !this.global1.event_done[41])
			{
				this.this_num_event = 41;
				this.this_num_place = 29;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.allcountries[9].Gosstroy == 1 && this.global1.data[216] <= 48 && !this.events[9].activeSelf && !this.global1.event_done[42])
			{
				this.this_num_event = 42;
				this.this_num_place = 9;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[0] != 3 && this.global1.data[216] <= 48 && this.global1.allcountries[3].paths <= 0 && this.global1.allcountries[3].Gosstroy == 0 && this.global1.data[20] >= 3 && this.global1.data[21] >= 1990 && !this.events[3].activeSelf && !this.global1.event_done[43])
			{
				this.this_num_event = 43;
				this.this_num_place = 3;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[0] != 4 && this.global1.data[216] <= 48 && this.global1.allcountries[4].paths <= 0 && this.global1.allcountries[4].Gosstroy == 1 && this.global1.data[20] >= 4 && this.global1.data[21] >= 1990 && !this.events[4].activeSelf && !this.global1.event_done[44])
			{
				this.this_num_event = 44;
				this.this_num_place = 4;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.allcountries[20].Gosstroy == 1 && this.global1.data[216] <= 48 && this.global1.data[0] != 20 && !this.events[20].activeSelf && !this.global1.event_done[45])
			{
				this.this_num_event = 45;
				this.this_num_place = 20;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[0] != 5 && this.global1.data[216] <= 48 && this.global1.allcountries[5].paths <= 0 && (this.global1.allcountries[5].Gosstroy == 0 || this.global1.allcountries[5].subideology == 0) && this.global1.data[20] >= 6 && this.global1.data[21] >= 1990 && !this.events[5].activeSelf && !this.global1.event_done[71] && !this.global1.event_done[46])
			{
				this.this_num_event = 46;
				this.this_num_place = 5;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[0] != 6 && this.global1.data[216] <= 48 && this.global1.allcountries[6].paths <= 0 && this.global1.allcountries[6].Gosstroy == 2 && !this.events[6].activeSelf && !this.global1.event_done[47])
			{
				this.this_num_event = 47;
				this.this_num_place = 6;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.allcountries[15].Gosstroy == 2 && this.global1.data[216] <= 48 && !this.events[15].activeSelf && (this.global1.data[0] < 49 || this.global1.data[0] > 51) && !this.global1.event_done[48])
			{
				this.this_num_event = 48;
				this.this_num_place = 15;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[0] != 2 && this.global1.data[216] <= 48 && this.global1.allcountries[2].paths <= 0 && this.global1.allcountries[2].Gosstroy == 0 && this.global1.data[20] >= 12 && this.global1.data[21] >= 1990 && !this.events[2].activeSelf && !this.global1.event_done[49])
			{
				this.this_num_event = 49;
				this.this_num_place = 2;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.allcountries[7].paths <= 0 && this.global1.data[216] <= 48 && ((!this.global1.allcountries[7].isOVD && !this.global1.allcountries[7].isSEV) || this.global1.data[7] <= 170 || (this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.data[7] >= 500 && this.global1.data[0] != 20 && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51)) && this.global1.data[0] != 10 && this.global1.data[0] != 12 && !this.global1.is_gkchp && this.global1.data[20] >= 11 && (this.global1.data[21] == 1990 || (this.global1.data[21] == 1989 && this.global1.data[0] != 4)) && !this.events[7].activeSelf && !this.global1.event_done[62])
			{
				this.this_num_event = 62;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.allcountries[7].paths <= 2 && this.global1.data[216] <= 48 && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 1)) && this.global1.data[0] != 12 && !this.global1.allcountries[7].Vyshi && this.global1.data[0] != 20 && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51 && this.global1.data[14] <= 2 && this.global1.data[14] <= 2 && this.global1.data[20] >= 1 && this.global1.data[21] >= 1991 && !this.events[7].activeSelf && !this.global1.event_done[63])
			{
				this.this_num_event = 63;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (((this.global1.data[19] >= this.global1.data[48] && this.global1.data[20] >= 2 && this.global1.data[21] >= 1991) || this.global1.data[21] >= 1992) && this.global1.data[216] <= 48 && this.global1.data[0] != 20 && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51 && !this.events[7].activeSelf && this.global1.event_done[35] && !this.global1.event_done[64])
			{
				this.this_num_event = 64;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.data[216] <= 48 && this.global1.allcountries[7].Gosstroy > 1)) && !this.global1.allcountries[this.global1.data[0]].Vyshi && (this.global1.data[7] <= 210 || (this.global1.data[20] >= 8 && this.global1.allcountries[4].Gosstroy >= 1 && !this.global1.allcountries[4].isSEV && !this.global1.allcountries[4].isOVD && this.global1.allcountries[2].Gosstroy >= 1 && !this.global1.allcountries[2].isSEV && !this.global1.allcountries[2].isOVD)) && this.global1.data[20] >= 2 && this.global1.data[21] >= 1991 && !this.events[7].activeSelf && !this.global1.event_done[65])
			{
				this.this_num_event = 65;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.allcountries[7].paths <= 2 && this.global1.data[216] <= 48 && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 1)) && this.global1.allcountries[7].isOVD && ((this.global1.data[0] != 1 && this.global1.data[0] <= 6 && this.global1.allcountries[1].Gosstroy == 2 && this.global1.data[10] >= 501) || (!this.global1.allcountries[7].isSEV && this.global1.data[53] - this.global1.data[7] >= 90) || this.global1.data[7] <= 120) && this.global1.data[191] != 1 && !this.events[7].activeSelf && !this.global1.event_done[66])
			{
				this.this_num_event = 66;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.data[216] <= 48 && this.global1.allcountries[7].Gosstroy > 1)) && !this.global1.allcountries[7].Vyshi && this.global1.data[20] >= 2 && this.global1.data[21] >= 1991 && !this.events[7].activeSelf && !this.global1.event_done[67])
			{
				this.this_num_event = 67;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.data[216] <= 48 && this.global1.allcountries[7].Gosstroy > 1)) && this.global1.allcountries[7].isOVD && this.global1.data[20] >= 6 && this.global1.data[21] >= 1991 && !this.events[7].activeSelf && !this.global1.event_done[68])
			{
				this.this_num_event = 68;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.data[216] <= 48 && this.global1.allcountries[7].Gosstroy > 1)) && this.global1.allcountries[7].paths != 3 && this.global1.allcountries[7].isSEV && (this.global1.data[7] <= 75 || this.global1.data[53] - this.global1.data[7] >= 90) && !this.events[7].activeSelf && !this.global1.event_done[69])
			{
				this.this_num_event = 69;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.allcountries[7].paths <= 0 && this.global1.data[216] <= 48 && !this.global1.is_gkchp && !this.global1.allcountries[7].isOVD && !this.global1.allcountries[7].isSEV && (this.global1.data[7] <= 59 || (this.global1.data[53] - this.global1.data[7] >= 20 && this.global1.data[21] >= 1991)) && this.global1.data[191] != 1 && !this.events[7].activeSelf && !this.global1.event_done[426] && !this.global1.event_done[70])
			{
				this.this_num_event = 70;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.is_gkchp && this.global1.data[216] <= 48 && (this.global1.allcountries[7].paths != 4 || (!this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD)) && this.global1.allcountries[7].Gosstroy <= 1 && !this.events[7].activeSelf && !this.global1.event_done[71])
			{
				this.this_num_event = 71;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.is_gkchp && this.global1.data[216] <= 48 && this.global1.allcountries[7].Gosstroy > 1 && !this.events[7].activeSelf && !this.global1.event_done[72])
			{
				this.this_num_event = 72;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if ((!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.data[216] <= 48 && this.global1.allcountries[7].Gosstroy > 1)) && (this.global1.data[7] <= 20 || (this.global1.data[53] - this.global1.data[7] >= 30 && this.global1.event_done[72])) && !this.events[7].activeSelf && !this.global1.event_done[73])
			{
				this.this_num_event = 73;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 48 && ((!this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 1) || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 1)) && (this.global1.data[7] <= 0 || (this.global1.data[53] - this.global1.data[7] >= 20 && this.global1.event_done[73])) && ((this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51) || this.global1.event_done[428]) && !this.global1.allcountries[7].isSEV && this.global1.data[204] == 0 && !this.events[7].activeSelf && !this.global1.event_done[74])
			{
				this.this_num_event = 74;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (((this.global1.data[19] >= this.global1.data[48] && this.global1.data[216] <= 48 && this.global1.data[20] >= 6 && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991 || this.global1.allcountries[7].Gosstroy == 2) && !this.events[12].activeSelf && !this.global1.event_done[75] && this.global1.data[0] != 12)
			{
				this.this_num_event = 75;
				this.this_num_place = 12;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (((this.global1.data[19] >= this.global1.data[48] && this.global1.data[216] <= 48 && this.global1.data[20] >= 4 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && !this.events[11].activeSelf && !this.global1.event_done[76])
			{
				this.this_num_event = 76;
				this.this_num_place = 11;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.allcountries[20].Gosstroy == 2 && this.global1.data[216] <= 48 && this.global1.data[0] != 20 && !this.events[20].activeSelf && !this.global1.event_done[77])
			{
				this.this_num_event = 77;
				this.this_num_place = 20;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.allcountries[1].Gosstroy == 1 && this.global1.data[216] <= 48 && this.global1.allcountries[1].paths <= 0 && this.global1.data[0] != 1 && !this.events[1].activeSelf && !this.global1.event_done[89])
			{
				this.this_num_event = 89;
				this.this_num_place = 1;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[7] <= 665 && this.global1.data[216] <= 48 && this.global1.allcountries[1].paths <= 0 && this.global1.data[0] != 1 && !this.events[1].activeSelf && !this.global1.event_done[90] && this.global1.event_done[89])
			{
				this.this_num_event = 90;
				this.this_num_place = 1;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.allcountries[1].Gosstroy == 2 && this.global1.data[216] <= 48 && this.global1.allcountries[1].paths <= 0 && this.global1.data[0] != 1 && !this.events[1].activeSelf && !this.global1.event_done[91])
			{
				this.this_num_event = 91;
				this.this_num_place = 1;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (!this.global1.event_done[62] && this.global1.data[216] <= 48 && this.global1.data[7] <= 800 && this.global1.allcountries[7].paths != 3 && ((this.global1.allcountries[7].Gosstroy == 2 && this.global1.data[5] >= 700) || (this.global1.allcountries[7].Vyshi && this.global1.data[5] >= 500) || this.global1.data[5] >= 900) && this.global1.data[0] != 18 && this.global1.data[0] != 20 && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51 && this.global1.data[20] >= this.global1.data[47] + this.global1.data[48] && !this.events[7].activeSelf && !this.global1.event_done[107] && this.global1.data[0] != 12)
			{
				this.this_num_event = 107;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (((this.global1.data[19] >= this.global1.data[48] && this.global1.data[216] <= 48 && this.global1.data[20] >= 3 && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && this.global1.allcountries[1].paths <= 0 && !this.global1.event_done[89] && this.global1.allcountries[1].Gosstroy == 0 && this.global1.data[0] != 1 && !this.events[1].activeSelf && !this.global1.event_done[92])
			{
				this.this_num_event = 92;
				this.this_num_place = 1;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[0] != 1 && this.global1.data[216] <= 48 && this.global1.data[0] != 18 && this.global1.data[0] != 10 && this.global1.data[0] != 12 && this.global1.data[0] != 18 && this.global1.data[0] != 20 && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51 && this.global1.data[21] >= 1990 && this.global1.data[0] != 4 && (this.global1.data[27] + this.global1.data[28] + this.global1.data[29] <= 0 || this.global1.data[29] > 0) && (this.global1.data[11] != 0 || (this.global1.allcountries[this.global1.data[0]].isSEV && this.global1.allcountries[this.global1.data[0]].isOVD && !this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD)) && !this.events[7].activeSelf && !this.global1.event_done[108])
			{
				this.this_num_event = 108;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.allcountries[15].isOVD && this.global1.data[216] <= 48 && this.global1.allcountries[4].paths <= 0 && this.global1.science[9] && this.global1.allcountries[5].isOVD && this.global1.allcountries[5].isSEV && this.global1.allcountries[3].isOVD && this.global1.allcountries[3].isSEV && this.global1.allcountries[this.global1.data[0]].isOVD && this.global1.allcountries[this.global1.data[0]].isSEV && !this.global1.allcountries[4].isOVD && !this.global1.allcountries[4].isSEV && !this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD && !this.events[1].activeSelf && !this.global1.event_done[129])
			{
				this.this_num_event = 129;
				this.this_num_place = 4;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			if (((this.global1.data[19] >= this.global1.data[48] && this.global1.data[216] <= 48 && this.global1.data[20] >= 1 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && this.global1.data[0] != 12 && this.global1.data[0] != 38 && !this.events[7].activeSelf && !this.global1.event_done[3])
			{
				this.this_num_event = 3;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[19] >= 4 && this.global1.data[20] >= 7 && this.global1.data[21] == 1989 && this.global1.data[165] >= 2 && !this.events[27].activeSelf && !this.global1.event_done[367])
			{
				this.this_num_event = 367;
				this.this_num_place = 27;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[19] >= 24 && this.global1.data[20] >= 10 && this.global1.data[21] == 1990 && this.global1.data[165] >= 2 && !this.events[27].activeSelf && !this.global1.event_done[369])
			{
				this.this_num_event = 369;
				this.this_num_place = 27;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[19] >= 11 && this.global1.data[20] >= 4 && this.global1.data[21] == 1991 && this.global1.data[165] >= 2 && !this.events[27].activeSelf && !this.global1.event_done[370])
			{
				this.this_num_event = 370;
				this.this_num_place = 27;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[19] >= 9 && this.global1.data[20] >= 8 && this.global1.data[21] == 1989 && this.global1.data[165] >= 2 && !this.events[27].activeSelf && !this.global1.event_done[380])
			{
				this.this_num_event = 380;
				this.this_num_place = 27;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[19] >= 9 && this.global1.data[20] >= 6 && this.global1.data[21] == 1990 && this.global1.data[165] >= 2 && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51 && !this.events[27].activeSelf && !this.global1.event_done[381])
			{
				this.this_num_event = 381;
				this.this_num_place = 27;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[20] >= 5 && this.global1.data[21] == 1991 && this.global1.allcountries[17].Westalgie >= 200 && this.global1.data[164] >= 3 && !this.events[27].activeSelf && !this.global1.event_done[371])
			{
				this.this_num_event = 371;
				this.this_num_place = 27;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[20] >= 6 && this.global1.data[21] == 1991 && (this.global1.data[164] == 6 || this.global1.data[164] == 5) && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51 && !this.events[27].activeSelf && this.global1.event_done[371] && !this.global1.event_done[382])
			{
				this.this_num_event = 382;
				this.this_num_place = 27;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			if (this.global1.data[216] <= 49 && ((this.global1.data[19] >= this.global1.data[47] && this.global1.data[20] >= 1 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && !this.events[21].activeSelf && !this.global1.event_done[13])
			{
				this.this_num_event = 13;
				this.this_num_place = 21;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && ((this.global1.data[19] >= this.global1.data[47] && this.global1.data[20] >= 8 - this.global1.data[47] / 7 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && !this.events[8].activeSelf && !this.global1.event_done[14])
			{
				this.this_num_event = 14;
				this.this_num_place = 8;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && ((this.global1.data[19] >= this.global1.data[47] && this.global1.data[20] >= 6 && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && this.global1.allcountries[33].subideology != 9 && !this.events[22].activeSelf && !this.global1.event_done[15])
			{
				this.this_num_event = 15;
				this.this_num_place = 22;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && ((this.global1.data[19] >= this.global1.data[47] && this.global1.data[20] >= 6 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && !this.events[16].activeSelf && !this.global1.event_done[16])
			{
				this.this_num_event = 16;
				this.this_num_place = 16;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && this.global1.data[7] <= 935 && this.global1.allcountries[11].Gosstroy >= 1 && !this.events[11].activeSelf && !this.global1.event_done[17] && this.global1.event_done[76])
			{
				this.this_num_event = 17;
				this.this_num_place = 11;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && ((this.global1.data[19] >= this.global1.data[47] && this.global1.data[20] >= 11 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && !this.global1.event_done[18])
			{
				this.this_num_event = 18;
				this.this_num_place = 19;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				this.global1.event_done[this.this_num_event] = true;
			}
			else if (this.global1.data[216] <= 49 && ((this.global1.data[19] >= this.global1.data[47] && this.global1.data[20] >= 9 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && this.global1.allcountries[19].Stasi && !this.events[19].activeSelf && !this.global1.event_done[19])
			{
				this.this_num_event = 19;
				this.this_num_place = 19;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && this.global1.science[5] && (this.global1.data[0] < 49 || this.global1.data[0] > 51) && this.global1.data[0] != 10 && this.global1.data[0] != 12 && this.global1.data[0] != 18 && !this.events[7].activeSelf && !this.global1.event_done[59])
			{
				this.this_num_event = 59;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && this.global1.science[8] && (this.global1.data[0] < 49 || this.global1.data[0] > 51) && this.global1.data[0] != 10 && this.global1.data[0] != 12 && this.global1.data[0] != 18 && !this.events[7].activeSelf && !this.global1.event_done[60])
			{
				this.this_num_event = 60;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && this.global1.science[2] && (this.global1.data[0] < 49 || this.global1.data[0] > 51) && this.global1.data[0] != 10 && this.global1.data[0] != 12 && this.global1.data[0] != 18 && !this.events[7].activeSelf && !this.global1.event_done[61])
			{
				this.this_num_event = 61;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && this.global1.data[20] >= 11 && !this.events[25].activeSelf && !this.global1.event_done[50])
			{
				this.this_num_event = 50;
				this.this_num_place = 25;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && this.global1.data[20] >= 1 && this.global1.data[21] >= 1990 && this.global1.data[0] != 12 && !this.events[0].activeSelf && !this.global1.event_done[51])
			{
				this.this_num_event = 51;
				this.this_num_place = 0;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && this.global1.data[20] >= 8 && this.global1.data[21] >= 1990 && !this.events[14].activeSelf && !this.global1.event_done[53])
			{
				this.this_num_event = 53;
				this.this_num_place = 14;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && this.global1.data[20] >= 7 && this.global1.data[21] >= 1991 && this.global1.allcountries[7].isSEV && !this.global1.allcountries[this.global1.data[0]].Vyshi && !this.events[0].activeSelf && !this.global1.event_done[54])
			{
				this.this_num_event = 54;
				this.this_num_place = 0;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && ((this.global1.data[19] >= this.global1.data[47] && this.global1.data[20] >= 11 && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && this.global1.data[0] == 1 && !this.events[0].activeSelf && !this.global1.event_done[78])
			{
				this.this_num_event = 78;
				this.this_num_place = 0;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && ((this.global1.data[19] >= this.global1.data[47] && this.global1.data[20] >= 6 && this.global1.data[21] >= 1991) || this.global1.data[21] >= 1992) && !this.global1.allcountries[7].Vyshi && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 1)) && ((this.global1.allcountries[7].isSEV && this.global1.allcountries[7].isOVD) || (this.global1.data[7] <= 750 && this.global1.allcountries[7].Gosstroy >= 1)) && !this.events[7].activeSelf && !this.global1.event_done[79])
			{
				this.this_num_event = 79;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && ((this.global1.data[19] >= this.global1.data[47] && this.global1.data[20] >= 3 && this.global1.data[21] >= 1991) || this.global1.data[21] >= 1992) && !this.events[23].activeSelf && !this.global1.event_done[80])
			{
				this.this_num_event = 80;
				this.this_num_place = 23;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && ((this.global1.data[19] >= this.global1.data[47] && this.global1.data[20] >= 3 && this.global1.data[21] >= 1991) || this.global1.data[21] >= 1992) && !this.global1.allcountries[36].Vyshi && !this.events[14].activeSelf && !this.global1.event_done[81])
			{
				this.this_num_event = 81;
				this.this_num_place = 14;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && this.global1.science[9] && (this.global1.data[0] < 49 || this.global1.data[0] > 51) && !this.events[7].activeSelf && !this.global1.event_done[87] && this.global1.data[0] != 18)
			{
				this.this_num_event = 87;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && (this.global1.data[14] >= 4 || this.global1.allcountries[this.global1.data[0]].Vyshi || this.global1.data[11] == 3) && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51 && this.global1.data[0] != 10 && this.global1.data[0] != 12 && this.global1.data[0] != 38 && this.global1.data[0] != 18 && this.global1.data[0] != 1 && !this.global1.event_done[106])
			{
				this.this_num_event = 106;
				if (this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51)
				{
					this.this_num_place = 15;
				}
				else if (this.global1.data[0] == 18)
				{
					this.this_num_place = 26;
				}
				else
				{
					this.this_num_place = this.global1.data[0];
				}
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && ((this.global1.data[2] <= 200 && this.global1.allcountries[7].isOVD) || (this.global1.data[10] >= 700 && !this.global1.allcountries[this.global1.data[0]].Vyshi)) && this.global1.data[21] >= 1991 && this.global1.data[0] != 18 && (this.global1.data[0] < 49 || this.global1.data[0] > 51) && this.global1.science[9] && !this.events[7].activeSelf && !this.global1.event_done[105])
			{
				this.this_num_event = 105;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && this.global1.allcountries[7].paths <= 0 && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 1 && !this.global1.allcountries[7].Vyshi)) && !this.global1.allcountries[7].Vyshi && this.global1.data[2] == 0 && this.global1.data[6] >= 900 && ((this.global1.data[20] > 10 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && this.global1.data[0] != 20 && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51 && this.global1.data[0] != 10 && this.global1.data[0] != 12 && this.global1.data[0] != 18 && !this.events[7].activeSelf && !this.global1.event_done[128])
			{
				this.this_num_event = 128;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && this.global1.allcountries[7].paths <= 0 && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 1 && !this.global1.allcountries[7].Vyshi)) && this.global1.data[6] - this.global1.data[2] / 4 >= 900 && ((this.global1.data[20] > 10 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && this.global1.data[0] != 20 && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51 && this.global1.data[0] != 10 && this.global1.data[0] != 12 && this.global1.data[0] != 18 && !this.events[7].activeSelf && !this.global1.event_done[128])
			{
				this.this_num_event = 128;
				this.this_num_place = 7;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && this.global1.data[20] == 7 && this.global1.data[21] == 1989 && !this.events[24].activeSelf && !this.global1.event_done[130])
			{
				this.this_num_event = 130;
				this.this_num_place = 24;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.pastDate(1, 2, 1990) && !this.events[28].activeSelf && this.global1.data[216] <= 49 && !this.global1.event_done[253])
			{
				this.this_num_event = 253;
				this.this_num_place = 28;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.event_done[50] && !this.global1.event_done[443])
			{
				this.this_num_event = 443;
				this.this_num_place = 9;
				this.global1.event_done[this.this_num_event] = true;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[20] > 1 && this.global1.data[21] >= 1990 && this.global1.data[239] != 1 && !this.global1.event_done[444])
			{
				this.this_num_event = 444;
				this.this_num_place = 24;
				this.global1.event_done[this.this_num_event] = true;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			else if (this.global1.data[216] <= 49 && this.global1.data[20] >= 6 && this.global1.data[21] >= 1991 && !this.events[19].activeSelf && !this.global1.event_done[445])
			{
				this.this_num_event = 445;
				this.this_num_place = 19;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				this.global1.event_done[this.this_num_event] = true;
			}
			else if (this.global1.data[162] != 3 && ((this.global1.data[19] >= 11 && this.global1.data[20] >= 11 && this.global1.data[21] == 1989) || this.global1.data[21] >= 1990) && this.global1.data[0] == 1 && this.global1.data[17] >= 16 && (this.global1.data[4] >= 700 || this.global1.data[3] <= 400 || this.global1.data[31] >= 700) && !this.events[1].activeSelf && !this.global1.event_done[446])
			{
				this.this_num_event = 446;
				this.this_num_place = 1;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				this.global1.event_done[this.this_num_event] = true;
			}
			else if (this.global1.data[216] <= 49 && ((this.global1.data[19] >= this.global1.data[47] && this.global1.data[20] >= 4 && this.global1.data[21] >= 1991) || this.global1.data[21] >= 1992) && this.global1.allcountries[36].Vyshi && (this.global1.allcountries[7].Gosstroy > 0 || this.global1.data[7] <= 500) && !this.events[14].activeSelf && !this.global1.event_done[81] && !this.global1.event_done[447])
			{
				this.this_num_event = 447;
				this.this_num_place = 14;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				this.global1.event_done[this.this_num_event] = true;
			}
			else if (this.global1.data[19] >= 1 && this.global1.data[20] >= 2 && this.global1.data[21] == 3232 && this.global1.data[216] >= 50 && !this.events[15].activeSelf && !this.global1.event_done[900])
			{
				this.this_num_event = 900;
				this.this_num_place = 15;
				this.events[this.this_num_place].SetActive(true);
				this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
			}
			if (this.global1.data[0] == 5)
			{
				if (((this.global1.data[20] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[21] >= 1991) || this.global1.data[21] >= 1992) && !this.events[5].activeSelf && !this.global1.event_done[102])
				{
					this.this_num_event = 102;
					this.this_num_place = 5;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[20] >= 8 && this.global1.data[20] <= 9 && this.global1.data[21] == 1989 && this.global1.data[14] <= 2 && !this.events[5].activeSelf && !this.global1.event_done[95])
				{
					this.this_num_event = 95;
					this.this_num_place = 5;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] >= this.global1.data[49] && this.global1.event_done[98] && ((this.global1.allcountries[this.global1.data[0]].isSEV && this.global1.allcountries[7].isSEV) || (this.global1.allcountries[this.global1.data[0]].isOVD && this.global1.allcountries[7].isOVD)) && !this.global1.is_gkchp && (this.global1.data[11] == 0 || this.global1.data[11] == 5) && !this.events[5].activeSelf && !this.global1.event_done[99])
				{
					this.this_num_event = 99;
					this.this_num_place = 5;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[20] >= 2 && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && this.global1.data[19] >= this.global1.data[49] && this.global1.event_done[98] && this.global1.data[11] != 0 && !this.events[5].activeSelf && !this.global1.event_done[100])
				{
					this.this_num_event = 100;
					this.this_num_place = 5;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] >= this.global1.data[49] && this.global1.data[11] != 0 && (this.global1.data[14] >= 4 || this.global1.data[11] == 3) && !this.events[5].activeSelf && !this.global1.event_done[103])
				{
					this.this_num_event = 103;
					this.this_num_place = 5;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[20] >= 11 && this.global1.data[11] == 0 && this.global1.data[21] == 1989 && !this.events[5].activeSelf && !this.global1.event_done[96])
				{
					this.this_num_event = 96;
					this.this_num_place = 5;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[20] >= 3 && this.global1.data[11] == 0 && this.global1.data[21] == 1989 && !this.events[5].activeSelf && !this.global1.event_done[93])
				{
					this.this_num_event = 93;
					this.this_num_place = 5;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[20] >= 4 && this.global1.data[11] == 0 && this.global1.data[21] == 1989 && !this.events[5].activeSelf && !this.global1.event_done[94])
				{
					this.this_num_event = 94;
					this.this_num_place = 5;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[31] >= 700 && this.global1.data[21] >= 1990 && !this.events[5].activeSelf && !this.global1.event_done[110])
				{
					this.this_num_event = 110;
					this.this_num_place = 5;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[3] - this.global1.data[4] <= 100 && this.global1.data[21] >= 1990) || this.global1.data[3] <= 250 || this.global1.data[4] >= 750) && this.global1.event_done[95] && !this.global1.event_done[98] && this.global1.data[11] == 0 && !this.events[5].activeSelf && !this.global1.event_done[97])
				{
					this.this_num_event = 97;
					this.this_num_place = 5;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[3] - this.global1.data[4] <= -200 && this.global1.data[21] >= 1990) || this.global1.data[3] <= 215) && this.global1.event_done[97] && this.global1.data[11] == 0 && !this.events[5].activeSelf && !this.global1.event_done[98])
				{
					this.this_num_event = 98;
					this.this_num_place = 5;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[11] > 1 && ((this.global1.data[21] >= 1990 && this.global1.data[20] >= 3) || this.global1.data[21] >= 1991) && !this.events[5].activeSelf && !this.global1.event_done[101])
				{
					this.this_num_event = 101;
					this.this_num_place = 5;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
			}
			else if (this.global1.data[0] == 10)
			{
				if (this.pastDate(28, 6, 1989) && !this.events[10].activeSelf && !this.global1.event_done[195])
				{
					this.this_num_event = 195;
					this.this_num_place = 10;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[4] > 750 && this.global1.data[11] != 0 && this.global1.data[3] < 500 && this.global1.data[5] < 300 && this.global1.data[15] < 8 && this.global1.allcountries[5].Gosstroy != 0 && this.global1.allcountries[5].Gosstroy != 9 && !this.events[10].activeSelf && !this.global1.event_done[254])
				{
					this.this_num_event = 254;
					this.this_num_place = 10;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 1, 1989) && !this.events[10].activeSelf && !this.global1.event_done[208])
				{
					this.this_num_event = 208;
					this.this_num_place = 10;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 7, 1990) && this.global1.data[101] == 1 && (this.global1.data[10] > 850 || this.global1.data[7] < 500) && !this.events[10].activeSelf && !this.global1.event_done[255])
				{
					this.this_num_event = 255;
					this.this_num_place = 10;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 12, 1989) && !this.events[10].activeSelf && !this.global1.event_done[196])
				{
					this.this_num_event = 196;
					this.this_num_place = 10;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if ((this.global1.data[20] >= this.global1.data[64] + 4 || (this.global1.data[20] <= 4 && this.global1.data[64] >= 8 && this.global1.data[20] >= this.global1.data[64] - 9)) && !this.events[10].activeSelf && !this.global1.event_done[197])
				{
					this.this_num_event = 197;
					this.this_num_place = 10;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(3, 2, 1991) && !this.events[10].activeSelf && !this.global1.event_done[198])
				{
					this.this_num_event = 198;
					this.this_num_place = 10;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[65] <= 0 && !this.events[10].activeSelf && !this.global1.event_done[199])
				{
					this.this_num_event = 199;
					this.this_num_place = 10;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 12, 1991) && !this.events[10].activeSelf && !this.global1.event_done[200])
				{
					this.this_num_event = 200;
					this.this_num_place = 10;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 5, 1991) && !this.events[10].activeSelf && !this.global1.event_done[201])
				{
					this.this_num_event = 201;
					this.this_num_place = 10;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if ((this.global1.data[4] > 400 || this.global1.data[1] < 550) && this.global1.data[16] < 13 && !this.events[10].activeSelf && !this.global1.event_done[202])
				{
					this.this_num_event = 202;
					this.this_num_place = 10;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 11, 1991) && this.global1.data[66] == 1 && this.global1.data[11] == 3 && !this.events[10].activeSelf && !this.global1.event_done[203])
				{
					this.this_num_event = 203;
					this.this_num_place = 10;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.pastDate(1, 3, 1991) && this.global1.allcountries[16].Gosstroy != 0) || (!this.global1.allcountries[16].Torg && !this.global1.allcountries[7].isSEV)) && !this.events[16].activeSelf && !this.global1.event_done[204])
				{
					this.this_num_event = 204;
					this.this_num_place = 16;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 3, 1989) && !this.events[10].activeSelf && !this.global1.event_done[205])
				{
					this.this_num_event = 205;
					this.this_num_place = 10;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 1, 1991) && this.global1.science[9] && !this.events[10].activeSelf && !this.global1.event_done[206])
				{
					this.this_num_event = 206;
					this.this_num_place = 10;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 12, 1990) && !this.events[10].activeSelf && !this.global1.event_done[207])
				{
					this.this_num_event = 207;
					this.this_num_place = 10;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 10, 1990) && !this.events[10].activeSelf && !this.global1.event_done[208])
				{
					this.this_num_event = 208;
					this.this_num_place = 10;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[5] < 200 && this.global1.data[21] > 1989 && !this.events[10].activeSelf && !this.global1.event_done[209])
				{
					this.this_num_event = 209;
					this.this_num_place = 10;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 9, 1989) && !this.events[24].activeSelf && !this.global1.event_done[210])
				{
					this.this_num_event = 210;
					this.this_num_place = 24;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 12, 1990) && !this.events[10].activeSelf && !this.global1.event_done[243])
				{
					this.this_num_event = 243;
					this.this_num_place = 10;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[11] == 2 && (this.global1.data[20] >= this.global1.data[64] + 2 || (this.global1.data[20] <= 2 && this.global1.data[64] >= 10 && this.global1.data[20] >= this.global1.data[64] - 11)) && !this.events[10].activeSelf && !this.global1.event_done[194])
				{
					this.this_num_event = 194;
					this.this_num_place = 10;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
			}
			else if (this.global1.data[0] == 2)
			{
				if (this.global1.data[20] >= 0 && !this.events[2].activeSelf && !this.global1.event_done[132])
				{
					this.this_num_event = 132;
					this.this_num_place = 2;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.event_done[132] && !this.events[2].activeSelf && !this.global1.event_done[133])
				{
					this.this_num_event = 133;
					this.this_num_place = 2;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[20] >= 2 && !this.events[2].activeSelf && !this.global1.event_done[134])
				{
					this.this_num_event = 134;
					this.this_num_place = 2;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[20] >= 6 && !this.events[2].activeSelf && !this.global1.event_done[135])
				{
					this.this_num_event = 135;
					this.this_num_place = 2;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.event_done[135] && !this.events[2].activeSelf && !this.global1.event_done[136])
				{
					this.this_num_event = 136;
					this.this_num_place = 2;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (!this.global1.event_done[141] && this.global1.event_done[136] && this.global1.is_elect && !this.events[2].activeSelf && !this.global1.event_done[137])
				{
					this.this_num_event = 137;
					this.this_num_place = 2;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[20] >= 8 && !this.events[2].activeSelf && !this.global1.event_done[138])
				{
					this.this_num_event = 138;
					this.this_num_place = 2;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[15] > 7 && this.global1.event_done[138] && (this.global1.is_party_enabled[3] || this.global1.is_party_enabled[4]) && (this.global1.data[4] >= 600 || this.global1.data[3] <= 400) && !this.events[2].activeSelf && !this.global1.event_done[139])
				{
					this.this_num_event = 139;
					this.this_num_place = 2;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[20] >= this.global1.data[47] + this.global1.data[48] && this.global1.allcountries[1].Gosstroy <= 0 && !this.events[1].activeSelf && !this.global1.event_done[140])
				{
					this.this_num_event = 140;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[20] >= 6 && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && (this.global1.data[4] - this.global1.data[3] >= 200 || (this.global1.data[3] <= 300 && this.global1.data[21] >= 1991) || (this.global1.data[4] >= 700 && this.global1.data[3] <= 500 && this.global1.data[21] >= 1991) || this.global1.data[17] >= 17 || this.global1.data[14] >= 4) && !this.events[2].activeSelf && !this.global1.event_done[141])
				{
					this.this_num_event = 141;
					this.this_num_place = 2;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[21] >= 1990 && (this.global1.data[18] >= 21 || this.global1.data[31] >= 700 || this.global1.data[14] >= 4 || this.global1.data[14] <= 0) && !this.events[2].activeSelf && !this.global1.event_done[142])
				{
					this.this_num_event = 142;
					this.this_num_place = 2;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[20] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[21] >= 1991) || this.global1.data[21] >= 1992) && (this.global1.data[8] >= 100 || this.global1.data[34] >= 1) && !this.events[2].activeSelf && !this.global1.event_done[143])
				{
					this.this_num_event = 143;
					this.this_num_place = 2;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy >= 2 && this.global1.data[31] >= 600 && ((this.global1.data[20] >= this.global1.data[49] && this.global1.data[21] >= 1991) || this.global1.data[21] >= 1992) && !this.events[2].activeSelf && !this.global1.event_done[144])
				{
					this.this_num_event = 144;
					this.this_num_place = 2;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[20] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && (this.global1.data[14] <= 2 || this.global1.data[17] <= 14) && (this.global1.is_party_enabled[1] || this.global1.is_party_enabled[2]) && !this.events[2].activeSelf && !this.global1.event_done[145])
				{
					this.this_num_event = 145;
					this.this_num_place = 2;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[20] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && this.global1.data[11] != 2 && (this.global1.data[14] <= 0 || this.global1.data[31] > 600) && this.global1.data[18] <= 19 && !this.events[2].activeSelf && !this.global1.event_done[146])
				{
					this.this_num_event = 146;
					this.this_num_place = 2;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
			}
			else if (this.global1.data[0] == 4)
			{
				if (((this.global1.data[19] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[20] >= 1) || this.global1.data[20] >= 2) && !this.events[4].activeSelf && !this.global1.event_done[147])
				{
					this.this_num_event = 147;
					this.this_num_place = 4;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[19] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[20] >= 5) || this.global1.data[20] >= 6) && !this.events[4].activeSelf && !this.global1.event_done[148])
				{
					this.this_num_event = 148;
					this.this_num_place = 4;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[19] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[20] >= 6) || this.global1.data[20] >= 7) && !this.events[4].activeSelf && !this.global1.event_done[149])
				{
					this.this_num_event = 149;
					this.this_num_place = 4;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[19] >= 22 && this.global1.data[20] >= 9) || this.global1.data[20] >= 10) && !this.events[4].activeSelf && !this.global1.event_done[150])
				{
					this.this_num_event = 150;
					this.this_num_place = 4;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[19] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[20] >= 7) || this.global1.data[20] >= 8) && !this.events[4].activeSelf && !this.global1.event_done[152])
				{
					this.this_num_event = 152;
					this.this_num_place = 4;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[19] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[20] >= 7) || this.global1.data[20] >= 8) && !this.events[4].activeSelf && !this.global1.event_done[151])
				{
					this.this_num_event = 151;
					this.this_num_place = 4;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] >= this.global1.data[47] + this.global1.data[48] && !this.events[4].activeSelf && this.global1.event_done[152] && !this.global1.event_done[153])
				{
					this.this_num_event = 153;
					this.this_num_place = 4;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[20] >= (1000 - this.global1.data[2]) / 100 && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && !this.global1.allcountries[7].Vyshi && !this.events[4].activeSelf && !this.global1.event_done[154])
				{
					this.this_num_event = 154;
					this.this_num_place = 4;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[20] >= 11 && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && !this.events[4].activeSelf && !this.global1.event_done[155])
				{
					this.this_num_event = 155;
					this.this_num_place = 4;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[20] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[21] >= 1991 && !this.events[4].activeSelf && !this.global1.event_done[156])
				{
					this.this_num_event = 156;
					this.this_num_place = 4;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[20] >= 11 && !this.events[4].activeSelf && !this.global1.event_done[157])
				{
					this.this_num_event = 157;
					this.this_num_place = 4;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] >= this.global1.data[47] + this.global1.data[48] && (this.global1.data[57] == 10 || (this.global1.event_done[151] && this.global1.data[57] == 0)) && this.global1.data[60] == 1 && this.global1.data[50] == 1 && this.global1.data[11] != 3 && !this.events[4].activeSelf && !this.global1.event_done[158])
				{
					this.this_num_event = 158;
					this.this_num_place = 4;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[31] >= 700 && this.global1.data[21] >= 1991 && this.global1.data[11] != 3 && ((this.global1.allcountries[5].Gosstroy != 0 && this.global1.allcountries[5].subideology != 0) || this.global1.event_done[46]) && this.global1.allcountries[5].Gosstroy != 9 && !this.events[5].activeSelf && !this.global1.event_done[159])
				{
					this.this_num_event = 159;
					this.this_num_place = 5;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[31] >= 700 && this.global1.data[21] >= 1991 && this.global1.data[11] != 3 && this.global1.allcountries[7].Vyshi && this.global1.event_done[159] && !this.events[7].activeSelf && !this.global1.event_done[160])
				{
					this.this_num_event = 160;
					this.this_num_place = 7;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[21] >= 1990 && this.global1.data[6] >= 700 && this.global1.data[14] <= 2 && this.global1.data[11] == 1 && !this.events[4].activeSelf && !this.global1.event_done[161])
				{
					this.this_num_event = 161;
					this.this_num_place = 4;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
			}
			else if (this.global1.data[0] == 20)
			{
				if (this.global1.data[19] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[20] >= 1 && !this.events[20].activeSelf && !this.global1.event_done[165])
				{
					this.this_num_event = 165;
					this.this_num_place = 20;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] >= 1 && this.global1.data[20] >= 3 && !this.events[20].activeSelf && !this.global1.event_done[166])
				{
					this.this_num_event = 166;
					this.this_num_place = 20;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] >= this.global1.data[47] + this.global1.data[48] && !this.events[20].activeSelf && !this.global1.event_done[167] && this.global1.event_done[12])
				{
					this.this_num_event = 167;
					this.this_num_place = 20;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] >= this.global1.data[47] + this.global1.data[48] && !this.global1.allcountries[this.global1.data[0]].Vyshi && ((this.global1.data[20] >= 3 && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && !this.events[20].activeSelf && !this.global1.event_done[168])
				{
					this.this_num_event = 168;
					this.this_num_place = 20;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] >= this.global1.data[47] + this.global1.data[48] && this.global1.allcountries[8].Torg && this.global1.data[21] == 1989 && !this.events[20].activeSelf && !this.global1.event_done[169])
				{
					this.this_num_event = 169;
					this.this_num_place = 20;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[57] <= 0 && this.global1.data[11] == 2 && !this.events[20].activeSelf && !this.global1.event_done[170])
				{
					this.this_num_event = 170;
					this.this_num_place = 20;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[57] < 1000 && this.global1.data[20] >= 11 && !this.events[20].activeSelf && !this.global1.event_done[171])
				{
					this.this_num_event = 171;
					this.this_num_place = 20;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[15] < 7 && this.global1.data[7] < 850 && !this.events[20].activeSelf && !this.global1.event_done[172])
				{
					this.this_num_event = 172;
					this.this_num_place = 20;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[20] >= 7 && !this.events[20].activeSelf && !this.global1.event_done[173] && this.global1.event_done[4])
				{
					this.this_num_event = 173;
					this.this_num_place = 20;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[16] < 13 && this.global1.data[7] < 800 && !this.global1.event_done[174])
				{
					this.this_num_event = 174;
					this.this_num_place = 20;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[21] >= 1990 && this.global1.data[57] < 100 && this.global1.data[11] == 2 && (this.global1.data[3] < 500 || this.global1.data[4] > 500) && !this.global1.event_done[175])
				{
					this.this_num_event = 175;
					this.this_num_place = 20;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if ((this.global1.data[3] < 300 || this.global1.data[4] > 700 || this.global1.data[7] < 750) && !this.global1.event_done[176])
				{
					this.this_num_event = 176;
					this.this_num_place = 20;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if ((this.global1.data[3] < 300 || this.global1.data[4] > 700 || this.global1.data[7] < 600) && !this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.data[21] >= 1991 && !this.global1.event_done[177] && this.global1.event_done[176])
				{
					this.this_num_event = 177;
					this.this_num_place = 20;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[56] >= 100 && this.global1.data[20] >= 6 && this.global1.data[11] == 0 && this.global1.data[21] >= 1991 && !this.global1.event_done[178])
				{
					this.this_num_event = 178;
					this.this_num_place = 20;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
			}
			else if (this.global1.data[0] == 6)
			{
				if (((this.global1.data[20] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && this.global1.data[11] == 0 && this.global1.data[14] <= 2 && this.global1.data[2] <= 700 && !this.events[6].activeSelf && !this.global1.event_done[111])
				{
					this.this_num_event = 111;
					this.this_num_place = 6;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[21] >= 1990 && this.global1.data[11] == 2 && this.global1.data[16] <= 11 && this.global1.data[31] >= 750 && this.global1.data[15] >= 8 && !this.events[6].activeSelf && !this.global1.event_done[1000])
				{
					this.this_num_event = 1000;
					this.this_num_place = 6;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[20] >= 5 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && this.global1.data[11] == 0 && this.global1.data[17] <= 16 && (this.global1.data[10] >= 250 || this.global1.data[4] >= 250 || this.global1.data[2] <= 500) && !this.events[6].activeSelf && !this.global1.event_done[112])
				{
					this.this_num_event = 112;
					this.this_num_place = 6;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.event_done[48] && !this.events[6].activeSelf && !this.global1.event_done[113])
				{
					this.this_num_event = 113;
					this.this_num_place = 6;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if ((this.global1.data[14] <= 2 || this.global1.data[17] <= 16) && (this.global1.data[3] <= 400 || this.global1.data[4] >= 700 || this.global1.data[2] <= 200) && !this.events[6].activeSelf && !this.global1.event_done[114])
				{
					this.this_num_event = 114;
					this.this_num_place = 6;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[21] >= 1990 && this.global1.data[11] != 0 && !this.events[6].activeSelf && !this.global1.event_done[116])
				{
					this.this_num_event = 116;
					this.this_num_place = 6;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[21] >= 1990 && (this.global1.data[14] >= 3 || this.global1.data[18] >= 21) && !this.global1.allcountries[this.global1.data[0]].Vyshi && !this.events[6].activeSelf && !this.global1.event_done[117])
				{
					this.this_num_event = 117;
					this.this_num_place = 6;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[20] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && this.global1.data[11] != 0 && !this.events[6].activeSelf && !this.global1.event_done[119])
				{
					this.this_num_event = 119;
					this.this_num_place = 6;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[20] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && this.global1.data[11] == 0 && !this.events[6].activeSelf && !this.global1.event_done[120])
				{
					this.this_num_event = 120;
					this.this_num_place = 6;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if ((this.global1.data[18] >= 21 || this.global1.data[18] <= 18 || this.global1.data[14] <= 0 || this.global1.data[14] >= 4 || (this.global1.data[22] > 700 && this.global1.data[31] > 700)) && this.global1.data[21] >= 1991 && !this.events[6].activeSelf && !this.global1.event_done[123])
				{
					this.this_num_event = 123;
					this.this_num_place = 6;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[11] == 2 && this.global1.data[14] <= 4 && (this.global1.data[1] + this.global1.data[2] <= 1100 || this.global1.data[4] - this.global1.data[3] >= 300 || this.global1.data[3] <= 350) && !this.events[6].activeSelf && !this.global1.event_done[124])
				{
					this.this_num_event = 124;
					this.this_num_place = 6;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data_old[8] < 0 && this.global1.data[8] + this.global1.data_old[0] * 4 <= 0) || this.global1.data[24] - this.global1.data[23] >= 25) && this.global1.data[21] >= 1990 && !this.events[6].activeSelf && !this.global1.event_done[125])
				{
					this.this_num_event = 125;
					this.this_num_place = 6;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[10] >= 700 && this.global1.data[21] >= 1990 && !this.events[6].activeSelf && !this.global1.event_done[126])
				{
					this.this_num_event = 126;
					this.this_num_place = 6;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if ((this.global1.data[11] == 1 || (this.global1.data[11] != 0 && this.global1.data[31] >= 600)) && !this.events[this.global1.data[0]].activeSelf && !this.global1.event_done[118])
				{
					this.this_num_event = 118;
					this.this_num_place = 6;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[59] == 3 && this.global1.data[0] == 6 && this.global1.data[6] > 400 && this.global1.data[21] >= 1991 && this.global1.allcountries[this.global1.data[0]].isOVD && (this.global1.data[54] >= 7 || (this.global1.allcountries[15].isOVD && this.global1.data[54] >= 5)) && !this.global1.allcountries[15].Help && (this.global1.allcountries[20].isSEV || this.global1.allcountries[20].isOVD) && ((this.global1.allcountries[20].Gosstroy == 0 && this.global1.data[14] < 3) || (this.global1.allcountries[20].Gosstroy == 1 && this.global1.data[14] == 3)) && !this.events[6].activeSelf && !this.global1.event_done[121])
				{
					this.this_num_event = 121;
					this.this_num_place = 6;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if ((this.global1.data[14] >= 4 || this.global1.allcountries[this.global1.data[0]].Vyshi) && this.global1.event_done[106] && !this.events[this.global1.data[0]].activeSelf && !this.global1.event_done[122])
				{
					this.this_num_event = 122;
					this.this_num_place = 6;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[11] == 0 && this.global1.data[14] <= 3 && !this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.data[2] + this.global1.data[1] <= 1050 && !this.events[this.global1.data[0]].activeSelf && !this.global1.event_done[115])
				{
					this.this_num_event = 115;
					this.this_num_place = 6;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[11] != 0 && ((this.global1.data[20] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && !this.events[this.global1.data[0]].activeSelf && !this.global1.event_done[127])
				{
					this.this_num_event = 127;
					this.this_num_place = 6;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
			}
			else if (this.global1.data[0] == 12)
			{
				if (this.global1.data[20] == 6 && this.global1.data[21] == 1990 && !this.events[12].activeSelf && !this.global1.event_done[228])
				{
					this.this_num_event = 228;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 8, 1991) && ((this.global1.data[80] == 100 && this.global1.data[81] == 0) || (this.global1.data[82] == 1 && this.global1.data[81] == 0 && this.global1.data[80] >= 60)) && !this.events[12].activeSelf && !this.global1.event_done[229])
				{
					this.this_num_event = 229;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 10, 1990) && this.global1.data[83] == 1 && !this.events[12].activeSelf && !this.global1.event_done[230])
				{
					this.this_num_event = 230;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(14, 1, 1989) && !this.events[12].activeSelf && !this.global1.event_done[231])
				{
					this.this_num_event = 231;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 12, 1990) && !this.events[12].activeSelf && !this.global1.event_done[232] && this.global1.data[84] == 1)
				{
					this.this_num_event = 232;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 9, 1990) && this.global1.event_done[19] && !this.events[12].activeSelf && !this.global1.event_done[233])
				{
					this.this_num_event = 233;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 2, 1991) && !this.events[12].activeSelf && !this.global1.event_done[234])
				{
					this.this_num_event = 234;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 8, 1989) && !this.events[12].activeSelf && !this.global1.event_done[235] && this.global1.data[11] != 0 && this.global1.data[1] <= 750)
				{
					this.this_num_event = 235;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 3, 1990) && !this.events[12].activeSelf && !this.global1.event_done[236] && this.global1.data[11] != 0 && ((this.global1.data[1] <= 750 && this.global1.data[86] == 1) || (this.global1.data[1] <= 850 && this.global1.data[86] == 2)))
				{
					this.this_num_event = 236;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 11, 1991) && this.global1.data[87] == 1 && !this.events[12].activeSelf && !this.global1.event_done[237])
				{
					this.this_num_event = 237;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 8, 1990) && !this.events[12].activeSelf && !this.global1.event_done[239])
				{
					this.this_num_event = 239;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(15, 2, 1989) && !this.events[12].activeSelf && !this.global1.event_done[240])
				{
					this.this_num_event = 240;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 10, 1990) && !this.events[12].activeSelf && !this.global1.event_done[246] && this.global1.data[4] >= 600)
				{
					this.this_num_event = 246;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 7, 1990) && !this.events[12].activeSelf && !this.global1.event_done[247] && this.global1.data[96] == 1 && this.global1.data[80] <= 60 && this.global1.data[91] == 1)
				{
					this.this_num_event = 247;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[0] == 12 && this.global1.science[6] && !this.events[12].activeSelf && !this.global1.event_done[248])
				{
					this.this_num_event = 248;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 1, 1991) && !this.events[12].activeSelf && !this.global1.event_done[249] && this.global1.data[11] == 3 && this.global1.data[81] == 1 && this.global1.data[4] >= 600 && this.global1.data[80] <= 60)
				{
					this.this_num_event = 249;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if ((this.global1.data[5] < 100 || this.global1.data[4] >= 850 || this.global1.data[3] < 450) && (this.global1.data[90] == 1 || this.global1.data[92] == 1 || this.global1.data[93] == 1 || this.global1.data[94] == 1) && this.global1.data[88] <= 0 && !this.events[12].activeSelf && !this.global1.event_done[250])
				{
					this.this_num_event = 250;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[0] == 12 && this.global1.science[2] && !this.events[12].activeSelf && !this.global1.event_done[251])
				{
					this.this_num_event = 251;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[80] >= 60 && this.global1.data[21] > 1989 && this.global1.data[4] <= 250 && !this.events[12].activeSelf && !this.global1.event_done[252])
				{
					this.this_num_event = 252;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 3, 1989) && !this.events[12].activeSelf && !this.global1.event_done[258] && this.global1.data[11] == 0 && this.global1.data[1] <= 750)
				{
					this.this_num_event = 258;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 5, 1989) && !this.events[12].activeSelf && this.global1.event_done[258] && !this.global1.event_done[259] && this.global1.data[92] == 1 && this.global1.data[11] == 0 && this.global1.data[1] <= 800)
				{
					this.this_num_event = 259;
					this.this_num_place = 12;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
			}
			else if (this.global1.data[0] == 3)
			{
				if (((this.global1.data[19] >= this.global1.data[49] && this.global1.data[20] >= 1 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && !this.events[3].activeSelf && !this.global1.event_done[179])
				{
					this.this_num_event = 179;
					this.this_num_place = 3;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[19] >= this.global1.data[49] && this.global1.data[20] >= 3 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && !this.events[3].activeSelf && !this.global1.event_done[180])
				{
					this.this_num_event = 180;
					this.this_num_place = 3;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[19] >= this.global1.data[49] && this.global1.data[20] >= 6 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && !this.global1.event_done[181] && !this.events[3].activeSelf)
				{
					this.this_num_event = 181;
					this.this_num_place = 3;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if ((this.global1.data[3] <= 327 || this.global1.data[4] >= 930 || this.global1.data[7] <= 650 || this.global1.data[1] <= 300) && !this.global1.event_done[182] && !this.events[3].activeSelf)
				{
					this.this_num_event = 182;
					this.this_num_place = 3;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] >= this.global1.data[49] && (!this.global1.event_done[190] || this.global1.data[57] == 10) && this.global1.event_done[182] && !this.global1.event_done[183] && !this.events[3].activeSelf)
				{
					this.this_num_event = 183;
					this.this_num_place = 3;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] >= this.global1.data[49] + this.global1.data[48] && this.global1.event_done[183] && !this.global1.event_done[184] && this.global1.data[11] != 1 && !this.events[3].activeSelf)
				{
					this.this_num_event = 184;
					this.this_num_place = 3;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[19] >= this.global1.data[49] && this.global1.data[20] >= 3 && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && this.global1.data[11] != 3 && !this.global1.event_done[185] && !this.events[3].activeSelf)
				{
					this.this_num_event = 185;
					this.this_num_place = 3;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] >= this.global1.data[49] && this.global1.data[21] >= 1990 && this.global1.data[14] <= 2 && (this.global1.data[3] < 400 || this.global1.data[4] > 800) && !this.global1.event_done[186] && !this.events[3].activeSelf)
				{
					this.this_num_event = 186;
					this.this_num_place = 3;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[20] >= this.global1.data[49] + this.global1.data[48] && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && this.global1.data[11] < 2 && !this.global1.event_done[187] && !this.events[3].activeSelf)
				{
					this.this_num_event = 187;
					this.this_num_place = 3;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[19] >= this.global1.data[49] && this.global1.data[20] >= 9 && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && !this.global1.event_done[188] && !this.events[3].activeSelf)
				{
					this.this_num_event = 188;
					this.this_num_place = 3;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[19] >= this.global1.data[49] && this.global1.data[20] >= 3 && this.global1.data[21] >= 1991) || this.global1.data[21] >= 1992) && !this.global1.allcountries[3].Vyshi && !this.global1.allcountries[7].Vyshi && !this.global1.event_done[189] && !this.events[3].activeSelf)
				{
					this.this_num_event = 189;
					this.this_num_place = 3;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[11] == 0 && (this.global1.event_done[183] || (this.global1.data[20] >= 11 && this.global1.data[21] >= 1991) || this.global1.data[21] >= 1992) && (this.global1.data[4] >= 900 || this.global1.data[3] <= 300 || this.global1.data[1] <= 300 || this.global1.allcountries[7].Vyshi) && !this.global1.event_done[190] && !this.events[3].activeSelf)
				{
					this.this_num_event = 190;
					this.this_num_place = 3;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[20] >= this.global1.data[49] + this.global1.data[48] && this.global1.data[21] >= 1991) || this.global1.data[21] >= 1992) && !this.global1.event_done[191] && !this.events[3].activeSelf)
				{
					this.this_num_event = 191;
					this.this_num_place = 3;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[11] <= 1 && this.global1.allcountries[2].Gosstroy == 2 && !this.global1.event_done[192] && !this.events[3].activeSelf)
				{
					this.this_num_event = 192;
					this.this_num_place = 3;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[19] >= this.global1.data[49] && this.global1.event_done[192] && this.global1.data[60] == 10 && !this.global1.event_done[193] && !this.events[3].activeSelf)
				{
					this.this_num_event = 193;
					this.this_num_place = 3;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
			}
			else if (this.global1.data[0] == 18)
			{
				if (this.global1.data[11] == 2 && this.global1.data[4] > 650 && this.global1.data[15] < 8 && !this.events[26].activeSelf && !this.global1.event_done[211])
				{
					this.this_num_event = 211;
					this.this_num_place = 26;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[11] == 3 && this.global1.data[16] < 13 && (this.global1.data[20] >= this.global1.data[76] + 5 || (this.global1.data[20] <= 5 && this.global1.data[76] >= 7 && this.global1.data[20] >= this.global1.data[76] - 8)) && !this.events[26].activeSelf && !this.global1.event_done[212])
				{
					this.this_num_event = 212;
					this.this_num_place = 26;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[11] != 3 && this.global1.allcountries[1].Gosstroy == 2 && !this.global1.allcountries[1].isSEV && !this.global1.allcountries[1].isOVD && !this.events[1].activeSelf && !this.global1.event_done[363])
				{
					this.this_num_event = 363;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(2, 4, 1989) && !this.events[26].activeSelf && !this.global1.event_done[213])
				{
					this.this_num_event = 213;
					this.this_num_place = 26;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.allcountries[7].Gosstroy > 0 && !this.events[26].activeSelf && !this.global1.event_done[214])
				{
					this.this_num_event = 214;
					this.this_num_place = 26;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 2, 1990) && !this.events[7].activeSelf && !this.global1.event_done[215])
				{
					this.this_num_event = 215;
					this.this_num_place = 7;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 1, 1990) && this.global1.data[7] < 700 && this.global1.data[14] >= 3 && this.global1.data[77] > 0 && this.global1.data[10] < 500 && !this.global1.science[9] && !this.events[26].activeSelf && !this.global1.event_done[216])
				{
					this.this_num_event = 216;
					this.this_num_place = 26;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[7] < 600 && this.global1.data[77] > 0 && this.pastDate(1, 8, 1990) && this.global1.data[10] > 900 && this.global1.data[14] <= 2 && !this.events[26].activeSelf && !this.global1.event_done[217])
				{
					this.this_num_event = 217;
					this.this_num_place = 26;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[11] == 2 && this.global1.data[4] > 800 && !this.events[26].activeSelf && !this.global1.event_done[218])
				{
					this.this_num_event = 218;
					this.this_num_place = 26;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[11] == 3 && this.global1.data[14] <= 3 && (this.global1.data[20] >= this.global1.data[76] + 2 || (this.global1.data[20] <= 2 && this.global1.data[76] >= 10 && this.global1.data[20] >= this.global1.data[76] - 11)) && !this.events[26].activeSelf && !this.global1.event_done[219])
				{
					this.this_num_event = 219;
					this.this_num_place = 26;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 4, 1991) && !this.events[26].activeSelf && !this.global1.event_done[220])
				{
					this.this_num_event = 220;
					this.this_num_place = 26;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 3 + this.global1.data[51], 1990) && !this.events[26].activeSelf && !this.global1.event_done[221])
				{
					this.this_num_event = 221;
					this.this_num_place = 26;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 5, 1989) && this.global1.data[11] < 3 && !this.events[26].activeSelf && !this.global1.event_done[222])
				{
					this.this_num_event = 222;
					this.this_num_place = 26;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 2, 1991) && !this.events[26].activeSelf && !this.global1.event_done[223])
				{
					this.this_num_event = 223;
					this.this_num_place = 26;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 11, 1990) && !this.events[26].activeSelf && !this.global1.event_done[224])
				{
					this.this_num_event = 224;
					this.this_num_place = 26;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 10, 1991) && !this.events[26].activeSelf && !this.global1.event_done[225])
				{
					this.this_num_event = 225;
					this.this_num_place = 26;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 4, 1990) && !this.events[26].activeSelf && !this.global1.event_done[226])
				{
					this.this_num_event = 226;
					this.this_num_place = 26;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 1, 1989) && !this.events[26].activeSelf && !this.global1.event_done[242])
				{
					this.this_num_event = 242;
					this.this_num_place = 26;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (!this.events[26].activeSelf && (!this.global1.event_done[244] & this.global1.science[8]))
				{
					this.this_num_event = 244;
					this.this_num_place = 26;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.pastDate(1, 12, 1990) && this.global1.data[7] < 500 && this.global1.allcountries[41].Westalgie != 1000 && this.global1.allcountries[41].Westalgie != 0 && !this.events[26].activeSelf && !this.global1.event_done[245])
				{
					this.this_num_event = 245;
					this.this_num_place = 26;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (!this.global1.allcountries[this.global1.data[0]].isSEV && !this.events[26].activeSelf && !this.global1.event_done[256])
				{
					this.this_num_event = 256;
					this.this_num_place = 26;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[11] == 1 && this.global1.data[7] <= 669 && !this.events[26].activeSelf && !this.global1.event_done[257])
				{
					this.this_num_event = 257;
					this.this_num_place = 26;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
			}
			else if (this.global1.data[0] == 1)
			{
				if (((this.global1.data[19] >= this.global1.data[49] && this.global1.data[20] >= 1 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && !this.events[1].activeSelf && !this.global1.event_done[20])
				{
					this.this_num_event = 20;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[19] >= this.global1.data[49] && this.global1.data[20] >= 8 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && !this.events[1].activeSelf && !this.global1.event_done[21])
				{
					this.this_num_event = 21;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[19] >= this.global1.data[49] && this.global1.data[20] >= 8 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && !this.events[1].activeSelf && !this.global1.event_done[22])
				{
					this.this_num_event = 22;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[7] <= 940 && (this.global1.data[27] + this.global1.data[28] + this.global1.data[29] <= 0 || this.global1.data[29] > 0) && !this.events[1].activeSelf && !this.global1.event_done[23])
				{
					this.this_num_event = 23;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if ((this.global1.data[5] < 600 || this.global1.data[3] < 400) && this.global1.data[4] >= 600 && (this.global1.data[27] + this.global1.data[28] + this.global1.data[29] <= 0 || this.global1.data[29] > 0) && !this.events[1].activeSelf && !this.global1.event_done[24])
				{
					this.this_num_event = 24;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.allcountries[2].paths != 2 && this.global1.allcountries[2].paths != 3 && (this.global1.allcountries[2].Gosstroy >= 1 || (this.global1.event_done[24] && this.global1.event_done[23])) && (this.global1.data[27] + this.global1.data[28] + this.global1.data[29] <= 0 || this.global1.data[29] > 0) && !this.events[1].activeSelf && !this.global1.event_done[25])
				{
					this.this_num_event = 25;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.allcountries[5].Gosstroy >= 1 && this.global1.allcountries[5].subideology != 0 && this.global1.allcountries[6].Gosstroy >= 1) || (this.global1.event_done[25] && this.global1.event_done[24] && this.global1.event_done[23])) && (this.global1.data[27] + this.global1.data[28] + this.global1.data[29] <= 0 || this.global1.data[29] > 0) && !this.events[1].activeSelf && !this.global1.event_done[26])
				{
					this.this_num_event = 26;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if ((this.global1.data[3] < 500 || this.global1.data[4] > 500) && !this.events[1].activeSelf && !this.global1.event_done[27])
				{
					this.this_num_event = 27;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[19] >= this.global1.data[49] && this.global1.data[20] >= 9 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && this.global1.data[16] == 10 && !this.global1.event_done[32] && !this.events[1].activeSelf && !this.global1.event_done[28])
				{
					this.this_num_event = 28;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[19] >= this.global1.data[49] && this.global1.data[20] >= 9 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && this.global1.data[14] < 3 && this.global1.data[1] <= 600 && this.global1.data[11] != 3 && !this.events[1].activeSelf && !this.global1.event_done[29])
				{
					this.this_num_event = 29;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[19] >= this.global1.data[49] && this.global1.data[20] >= 10 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && !this.events[1].activeSelf && !this.global1.event_done[30])
				{
					this.this_num_event = 30;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[3] <= 400 && this.global1.data[21] == 1989) || (this.global1.data[3] <= 500 && this.global1.data[21] > 1989) || (this.global1.data[4] >= 600 && this.global1.data[21] > 1990) || (this.global1.data[4] >= 650 && this.global1.data[21] == 1990) || (this.global1.data[4] >= 700 && this.global1.data[21] == 1989) || (((this.global1.data[2] < 500 && this.global1.data[21] == 1989) || (this.global1.data[2] < 575 && this.global1.data[21] == 1990) || (this.global1.data[2] < 650 && this.global1.data[21] > 1990)) && this.global1.data[22] < 700) || this.global1.data[1] < 500) && ((this.global1.data[19] >= this.global1.data[49] && this.global1.data[20] >= 9) || this.global1.data[20] >= 10) && this.global1.data[11] == 0 && !this.events[1].activeSelf && !this.global1.event_done[31])
				{
					this.this_num_event = 31;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[19] >= this.global1.data[49] && this.global1.data[20] >= 11 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && this.global1.data[11] >= 2 && !this.events[1].activeSelf && !this.global1.event_done[32])
				{
					this.this_num_event = 32;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if ((this.global1.data[3] < 300 || this.global1.data[4] >= 650) && (this.global1.data[11] != 0 || this.global1.data[28] >= 5 || this.global1.data[27] >= 1) && !this.events[1].activeSelf && !this.global1.event_done[33])
				{
					this.this_num_event = 33;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if ((this.global1.data[3] <= 250 || this.global1.data[4] >= 800 || this.global1.data[14] >= 4 || this.global1.data[11] == 3) && !this.events[1].activeSelf && !this.global1.event_done[55])
				{
					this.this_num_event = 55;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if ((this.global1.data[3] <= 200 || this.global1.data[4] >= 900) && this.global1.data[0] != 20 && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51 && this.global1.data[21] >= 1990 && !this.events[1].activeSelf && !this.global1.event_done[56])
				{
					this.this_num_event = 56;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[20] >= 10 && this.global1.data[19] >= 3 && !this.global1.is_gkchp && this.global1.data[21] >= 1990 && !this.events[1].activeSelf && !this.global1.event_done[57])
				{
					this.this_num_event = 57;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.eventVariantChosen[1098] != 2 && ((this.global1.data[20] >= this.global1.data[47] + this.global1.data[48] && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && this.global1.data[11] != 0 && !this.events[1].activeSelf && !this.global1.event_done[58])
				{
					this.this_num_event = 58;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[20] <= 10 && this.global1.data[21] <= 1989 && this.global1.data[11] != 0 && !this.events[1].activeSelf && !this.global1.event_done[1098])
				{
					this.this_num_event = 1098;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[20] >= (this.global1.data[47] + this.global1.data[48] + this.global1.data[49]) / 2 && this.global1.data[21] >= 1991) || this.global1.data[21] >= 1992) && !this.events[1].activeSelf && !this.global1.event_done[82])
				{
					this.this_num_event = 82;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[19] >= this.global1.data[49] && this.global1.data[20] >= 9 && this.global1.data[21] >= 1989) || this.global1.data[21] >= 1990) && !this.events[1].activeSelf && !this.global1.event_done[83])
				{
					this.this_num_event = 83;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (((this.global1.data[19] >= this.global1.data[49] && this.global1.data[20] >= 4 && this.global1.data[21] >= 1990) || this.global1.data[21] >= 1991) && !this.events[1].activeSelf && !this.global1.event_done[84])
				{
					this.this_num_event = 84;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.science[0] && this.global1.science[3] && this.global1.science[4] && this.global1.data[0] != 10 && this.global1.data[0] != 12 && this.global1.data[0] != 18 && this.global1.data[21] >= 1990 && !this.events[1].activeSelf && !this.global1.event_done[85])
				{
					this.this_num_event = 85;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if ((!this.global1.allcountries[7].isOVD || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy >= 2)) && this.global1.regions[2].buildings[12].is_builded && this.global1.data[21] >= 1991 && !this.events[1].activeSelf && !this.global1.event_done[86])
				{
					this.this_num_event = 86;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
				else if (this.global1.data[22] >= 700 && this.global1.data[0] == 1 && this.global1.data[31] >= 600 && this.global1.data[20] >= this.global1.data[48] + this.global1.data[49] && this.global1.data[21] >= 1990 && !this.events[1].activeSelf && !this.global1.event_done[131])
				{
					this.this_num_event = 131;
					this.this_num_place = 1;
					this.events[this.this_num_place].SetActive(true);
					this.events[this.this_num_place].GetComponent<EventScript>().Reset(this.this_num_event);
				}
			}
			if (this.global1.data[19] == 30 && this.global1.data[20] == 11 && this.global1.data[21] == 1991 && !this.global1.allcountries[7].isOVD && !this.global1.allcountries[7].isSEV)
			{
				ptr = ref this.global1.data[7];
				ptr -= 10;
			}
			int num7 = 0;
			num7 -= 17 - this.global1.data[18];
			num7 -= 13 - this.global1.data[17];
			num7 -= 9 - this.global1.data[16];
			num7 -= 5 - this.global1.data[15];
			if (num7 <= 5 || (num7 <= 8 && this.global1.data[16] == 13 && (this.global1.data[18] <= 19 || this.global1.data[18] >= 22) && this.global1.data[216] < 50))
			{
				this.global1.data[14] = 0;
			}
			else if (num7 <= 7 && this.global1.data[216] < 50)
			{
				this.global1.data[14] = 1;
			}
			else if (num7 <= 10 && this.global1.data[216] < 50)
			{
				this.global1.data[14] = 2;
			}
			else if (num7 <= 13 && this.global1.data[216] < 50)
			{
				this.global1.data[14] = 3;
			}
			else if (num7 <= 16 && this.global1.data[216] < 50)
			{
				this.global1.data[14] = 4;
			}
			else if (num7 > 16 && this.global1.data[216] < 50)
			{
				this.global1.data[14] = 5;
			}
			if (this.global1.data[33] <= 190)
			{
				this.global1.data[18] = 23;
			}
			else if (this.global1.data[33] <= 390)
			{
				this.global1.data[18] = 22;
			}
			else if (this.global1.data[33] <= 590)
			{
				this.global1.data[18] = 21;
			}
			else if (this.global1.data[33] <= 790)
			{
				this.global1.data[18] = 20;
			}
			else if (this.global1.data[33] <= 990)
			{
				this.global1.data[18] = 19;
			}
			else if (this.global1.data[33] > 990)
			{
				this.global1.data[18] = 18;
			}
			if (this.global1.data[22] < 0)
			{
				this.global1.data[22] = 0;
			}
			else if (this.global1.data[22] > 1000)
			{
				this.global1.data[22] = 1000;
			}
			if (this.global1.data[31] < 0)
			{
				this.global1.data[31] = 0;
			}
			else if (this.global1.data[31] > 1000)
			{
				this.global1.data[31] = 1000;
			}
			if (this.global1.data[33] < -100)
			{
				this.global1.data[33] = -100;
			}
			else if (this.global1.data[33] > 1300)
			{
				this.global1.data[33] = 1300;
			}
			this.global1.data[23] = 0;
			this.global1.data[25] = 0;
			if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
			{
				this.global1.data[23] = 25;
				if (this.global1.allcountries[7].isSEV)
				{
					ptr = ref this.global1.data[23];
					ptr += 25;
				}
				if (this.global1.allcountries[this.global1.data[0]].isOVD || (this.global1.allcountries[7].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV))
				{
					ptr = ref this.global1.data[23];
					ptr -= 25;
				}
			}
			else
			{
				this.global1.data[23] = 0;
			}
			int num8 = 0;
			num8 -= 18 - this.global1.data[18];
			num8 -= 14 - this.global1.data[17];
			num8 -= 6 - this.global1.data[15];
			if (this.global1.data[14] >= 3 && this.global1.data[16] >= 12)
			{
				num8 -= 11 - this.global1.data[16];
			}
			if (this.global1.data[31] < 400 && (this.global1.data[232] == 16 || this.global1.data[232] == 1 || this.global1.data[232] == 3))
			{
				this.global1.data[232] = 0;
			}
			else if (this.global1.data[14] == 1 || this.global1.data[14] == 2)
			{
				if (this.global1.data[232] != 16 && this.global1.data[232] != 1 && this.global1.data[232] != 4 && this.global1.data[232] != 5 && this.global1.data[232] != 6 && this.global1.data[232] != 7)
				{
					this.global1.data[232] = 0;
				}
			}
			else if (this.global1.data[14] == 3)
			{
				if (this.global1.data[232] != 8 && this.global1.data[232] != 9 && this.global1.data[232] != 10 && this.global1.data[232] != 11)
				{
					this.global1.data[232] = 0;
				}
			}
			else if (this.global1.data[14] == 4 || this.global1.data[14] == 5)
			{
				if (this.global1.data[232] != 2 && this.global1.data[232] != 12 && this.global1.data[232] != 13 && this.global1.data[232] != 14 && this.global1.data[232] != 15)
				{
					this.global1.data[232] = 0;
				}
			}
			else if (this.global1.data[14] == 0 && this.global1.data[232] != 16 && this.global1.data[232] != 1 && this.global1.data[232] != 2 && this.global1.data[232] != 3 && this.global1.data[232] != 15)
			{
				this.global1.data[232] = 0;
			}
			if (this.global1.data[232] == 0)
			{
				if (this.global1.data[14] == 1 || this.global1.data[14] == 2)
				{
					if (this.global1.data[15] == 6 && (this.global1.data[16] == 11 || this.global1.data[16] == 12) && (this.global1.data[17] == 16 || this.global1.data[17] == 17) && this.global1.data[31] <= 400)
					{
						this.global1.allcountries[this.global1.data[0]].subideology = 5;
					}
					else if (this.global1.data[15] == 6 && (this.global1.data[16] == 11 || this.global1.data[16] == 12) && this.global1.data[17] != 17 && this.global1.data[18] == 18 && this.global1.data[31] >= 700)
					{
						this.global1.allcountries[this.global1.data[0]].subideology = 6;
					}
					else if (this.global1.data[16] == 13)
					{
						if (this.global1.data[31] >= 701)
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 1;
						}
						else
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 11;
						}
					}
					else if (num8 < 1)
					{
						if (this.global1.data[16] <= 11)
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 6;
						}
						else
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 5;
						}
					}
					else if (num8 < 3 && this.global1.data[31] >= 701)
					{
						this.global1.allcountries[this.global1.data[0]].subideology = 0;
					}
					else if (this.global1.data[14] == 1)
					{
						this.global1.allcountries[this.global1.data[0]].subideology = 7;
					}
					else if (this.global1.data[31] >= 701)
					{
						this.global1.allcountries[this.global1.data[0]].subideology = 1;
					}
					else
					{
						this.global1.allcountries[this.global1.data[0]].subideology = 4;
					}
				}
				else if (this.global1.data[14] == 3)
				{
					if ((this.global1.data[16] == 12 || this.global1.data[16] == 13) && this.global1.data[18] == 23)
					{
						if (this.global1.data[31] >= 701)
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 3;
						}
						else
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 10;
						}
					}
					else if (num8 <= 7)
					{
						if (this.global1.data[17] <= 15)
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 8;
						}
						else
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 9;
						}
					}
					else if (num8 >= 8)
					{
						if (this.global1.data[31] >= 701)
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 0;
						}
						else
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 11;
						}
					}
				}
				else if (this.global1.data[14] == 4 || this.global1.data[14] == 5)
				{
					if (this.global1.data[15] == 7 && this.global1.data[16] == 13 && this.global1.data[17] == 15 && this.global1.data[18] == 23)
					{
						if (this.global1.data[31] >= 701)
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 3;
						}
						else if (this.global1.data[31] >= 400)
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 2;
						}
						else
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 14;
						}
					}
					else if (num8 <= 9)
					{
						if (this.global1.data[16] <= 12)
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 10;
						}
						else
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 12;
						}
					}
					else if (num8 == 10)
					{
						if (this.global1.data[16] <= 12)
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 13;
						}
						else
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 14;
						}
					}
					else if (num8 >= 11)
					{
						if (this.global1.data[31] >= 701)
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 3;
						}
						else
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 15;
						}
					}
				}
				else if (this.global1.data[14] == 0)
				{
					if (this.global1.data[16] == 13)
					{
						if (this.global1.allcountries[this.global1.data[0]].Vyshi)
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 15;
						}
						else if (this.global1.data[31] >= 701)
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 3;
						}
						else
						{
							this.global1.allcountries[this.global1.data[0]].subideology = 2;
						}
					}
					else if (this.global1.data[31] >= 701)
					{
						this.global1.allcountries[this.global1.data[0]].subideology = 3;
					}
					else if (this.global1.data[31] < 400)
					{
						this.global1.allcountries[this.global1.data[0]].subideology = 11;
					}
					else
					{
						this.global1.allcountries[this.global1.data[0]].subideology = 0;
					}
				}
				else if (this.global1.data[14] == 25)
				{
					this.global1.allcountries[this.global1.data[0]].Gosstroy = 6;
				}
			}
			for (int k = 0; k < this.global1.regions.Length; k = num + 1)
			{
				for (int l = 0; l < 15; l = num + 1)
				{
					if (this.global1.regions[k].buildings[l].type == 6 && (this.global1.data[19] == 1 || this.global1.data[19] == 15) && this.global1.regions[k].buildings[l].is_builded)
					{
						if (this.global1.data[16] < 12)
						{
							this.global1.regions[k].buildings[l].is_private = false;
							this.global1.regions[k].buildings[l].is_working = false;
						}
						else
						{
							this.global1.regions[k].buildings[l].is_working = true;
						}
					}
					num = l;
				}
				num = k;
			}
			bool flag2 = false;
			for (int m = 0; m < this.global1.allcountries.Length; m = num + 1)
			{
				if (this.global1.allcountries[m] != null)
				{
					if (this.global1.allcountries[m].Torg && !this.global1.allcountries[m].isSEV)
					{
						ptr = ref this.global1.data[25];
						ref int ptr6 = ref ptr;
						num = ptr;
						ptr6 = num + 1;
						ptr = ref this.global1.data[23];
						ptr += 2;
					}
					else if (this.global1.allcountries[m].Torg && this.global1.allcountries[m].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV)
					{
						ptr = ref this.global1.data[23];
						ref int ptr7 = ref ptr;
						num = ptr;
						ptr7 = num + 1;
					}
					if (m == 7 && this.global1.allcountries[m].isSEV && this.global1.data[0] == 6)
					{
						ptr = ref this.global1.data[23];
						ptr += 15 - this.global1.allcountries[7].Gosstroy * 5;
					}
					else if ((this.global1.allcountries[m].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV && this.global1.allcountries[m].Gosstroy == 0) || (this.global1.allcountries[m].isSEV && this.global1.allcountries[m].Gosstroy == 9 && m < 7))
					{
						ptr = ref this.global1.data[23];
						ptr += 9;
					}
					else if (this.global1.allcountries[m].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV && (this.global1.allcountries[m].Gosstroy == 1 || this.global1.allcountries[m].Gosstroy == 9))
					{
						ptr = ref this.global1.data[23];
						ptr += 6;
					}
					else if (this.global1.allcountries[m].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV && this.global1.allcountries[m].Gosstroy == 2)
					{
						ptr = ref this.global1.data[23];
						ptr += 4;
					}
					else if (this.global1.allcountries[m].Vyshi)
					{
						ptr = ref this.global1.data[23];
						ptr += 3;
					}
					if (this.global1.allcountries[m].isOVD && m != this.global1.data[0] && m == 4 && !this.global1.allcountries[3].isOVD && !this.global1.allcountries[5].isOVD && !this.global1.allcountries[7].isOVD)
					{
						this.global1.allcountries[m].isOVD = false;
					}
					else if (this.global1.allcountries[m].isOVD && (m != 4 || !this.global1.event_done[129]) && m != this.global1.data[0] && m <= 6 && !this.global1.allcountries[m].Torg && this.global1.allcountries[m].Gosstroy == 0 && this.global1.data[6] < 690 && !this.global1.allcountries[7].isOVD)
					{
						this.global1.allcountries[m].isOVD = false;
					}
					else if (this.global1.allcountries[m].isOVD && (m != 4 || !this.global1.event_done[129]) && m != this.global1.data[0] && this.global1.allcountries[m].Gosstroy == 2 && this.global1.data[6] > 300 && !this.global1.allcountries[7].isOVD)
					{
						this.global1.allcountries[m].isOVD = false;
					}
					else if (this.global1.allcountries[m].isOVD && (m != 4 || !this.global1.event_done[129]) && m != this.global1.data[0] && m <= 6 && !this.global1.allcountries[m].Money && !this.global1.allcountries[m].Torg && this.global1.allcountries[m].Gosstroy == 1 && (this.global1.data[6] < 400 || this.global1.data[6] > 710) && !this.global1.allcountries[7].isOVD)
					{
						this.global1.allcountries[m].isOVD = false;
					}
					else if (this.global1.allcountries[m].isSEV && (m != 4 || !this.global1.event_done[129]) && m != this.global1.data[0] && m <= 6 && !this.global1.allcountries[m].Torg && this.global1.allcountries[m].Gosstroy == 0 && this.global1.data[6] < 600 && !this.global1.allcountries[7].isSEV)
					{
						this.global1.allcountries[m].isSEV = false;
					}
					else if (this.global1.allcountries[m].isSEV && (m == 34 || m == 25 || (m == 24 && this.global1.allcountries[24].Gosstroy == this.global1.allcountries[25].Gosstroy)) && (this.global1.data[6] > 400 || this.global1.allcountries[7].isSEV))
					{
						this.global1.allcountries[m].isSEV = false;
					}
					else if (this.global1.allcountries[m].isSEV && m >= 40 && m <= 43 && this.global1.allcountries[m].Westalgie == 0 && (this.global1.data[6] > 400 || this.global1.allcountries[7].isSEV))
					{
						this.global1.allcountries[m].isSEV = false;
					}
					else if (this.global1.allcountries[m].isSEV && (m != 4 || !this.global1.event_done[129]) && m != this.global1.data[0] && m != 52 && this.global1.allcountries[m].Gosstroy == 2 && this.global1.data[6] > 390 && !this.global1.allcountries[7].isSEV)
					{
						this.global1.allcountries[m].isSEV = false;
					}
					else if (this.global1.allcountries[m].isSEV && m == 52 && this.global1.allcountries[m].Gosstroy == 2 && this.global1.data[6] > 700 && !this.global1.allcountries[7].isSEV)
					{
						this.global1.allcountries[m].isSEV = false;
					}
					else if (this.global1.allcountries[m].isSEV && m != this.global1.data[0] && m <= 6 && (m != 4 || !this.global1.event_done[129]) && !this.global1.allcountries[m].Money && !this.global1.allcountries[m].Torg && this.global1.allcountries[m].Gosstroy == 1 && (this.global1.data[6] < 300 || this.global1.data[6] > 810) && !this.global1.allcountries[7].isSEV)
					{
						this.global1.allcountries[m].isSEV = false;
					}
					else if (this.global1.allcountries[m].isSEV && (m != 4 || !this.global1.event_done[129]) && m != this.global1.data[0] && m <= 6 && this.global1.allcountries[m].Vyshi && this.global1.data[14] <= 3 && !this.global1.allcountries[7].isSEV)
					{
						this.global1.allcountries[m].isSEV = false;
					}
					else if (this.global1.allcountries[m].isSEV && m == 52 && (this.global1.allcountries[45].isSEV || this.global1.allcountries[7].isSEV) && this.global1.allcountries[m].Vyshi)
					{
						this.global1.allcountries[m].isSEV = false;
					}
					else if (this.global1.allcountries[m].Torg && (m != 24 || this.global1.allcountries[24].Stasi) && m != 11 && m != 12 && m != 52 && (m < 40 || m > 43) && (m != 44 || (this.global1.allcountries[44].subideology != 9 && this.global1.allcountries[44].subideology != 12 && this.global1.allcountries[44].subideology != 13 && this.global1.data[239] != 1)) && m != this.global1.data[0] && !this.global1.allcountries[m].isSEV && !this.global1.allcountries[m].isOVD && this.global1.allcountries[m].Gosstroy == 0 && this.global1.data[6] < 500 && !this.global1.allcountries[7].isSEV)
					{
						this.global1.allcountries[m].Torg = false;
					}
					else if (this.global1.allcountries[m].Torg && (m != 24 || this.global1.allcountries[24].Stasi) && m != 11 && m != 12 && m != 52 && (m < 40 || m > 43) && (m != 44 || (this.global1.allcountries[44].subideology != 9 && this.global1.allcountries[44].subideology != 12 && this.global1.allcountries[44].subideology != 13 && this.global1.data[239] != 1)) && m != this.global1.data[0] && m != 21 && m != 36 && m != 38 && !this.global1.allcountries[m].isSEV && !this.global1.allcountries[m].isOVD && this.global1.allcountries[m].Gosstroy == 2 && this.global1.data[6] > 490 && !this.global1.allcountries[7].isSEV && !this.global1.allcountries[this.global1.data[0]].Vyshi)
					{
						this.global1.allcountries[m].Torg = false;
					}
					else if (this.global1.allcountries[m].Torg && (m != 24 || this.global1.allcountries[24].Stasi) && m != 11 && m != 12 && m != 30 && m != 35 && m != 52 && (m < 40 || m > 43) && (m != 44 || (this.global1.allcountries[44].subideology != 9 && this.global1.allcountries[44].subideology != 12 && this.global1.data[239] != 1)) && m != this.global1.data[0] && !this.global1.allcountries[m].isSEV && !this.global1.allcountries[m].isOVD && this.global1.allcountries[m].Gosstroy == 1 && this.global1.data[6] < 250 && !this.global1.allcountries[7].isSEV)
					{
						this.global1.allcountries[m].Torg = false;
					}
					else if (this.global1.allcountries[m].Torg && m == 52 && !this.global1.allcountries[m].isSEV && !this.global1.allcountries[m].isOVD && this.global1.data[6] > 800)
					{
						this.global1.allcountries[m].Torg = false;
					}
					else if (this.global1.allcountries[m].Torg && m == 44 && (this.global1.allcountries[44].subideology == 12 || this.global1.data[239] == 1) && this.global1.data[6] > 800 && !this.global1.event_done[210])
					{
						this.global1.allcountries[m].Torg = false;
					}
					else if (this.global1.allcountries[m].Torg && m == 11 && !this.global1.allcountries[m].isSEV && ((this.global1.data[6] > 600 && this.global1.allcountries[m].Gosstroy == 2) || (this.global1.data[6] < 350 && this.global1.allcountries[m].Gosstroy == 0)))
					{
						this.global1.allcountries[m].Torg = false;
					}
					else if (this.global1.allcountries[m].Torg && m == 38 && this.global1.allcountries[16].isSEV)
					{
						this.global1.allcountries[m].Torg = false;
						this.global1.allcountries[m].Money = false;
					}
					else if (!this.global1.allcountries[m].Torg && m != this.global1.data[0] && this.global1.allcountries[m].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV)
					{
						this.global1.allcountries[m].Torg = true;
					}
					if ((this.global1.allcountries[m].isSEV || this.global1.allcountries[m].isOVD) && this.global1.data[0] != m)
					{
						flag2 = true;
					}
				}
				num = m;
			}
			if (!flag2)
			{
				this.global1.allcountries[this.global1.data[0]].isSEV = false;
				this.global1.allcountries[this.global1.data[0]].isOVD = false;
			}
			if (this.global1.allcountries[this.global1.data[0]].isSEV)
			{
				ptr = ref this.global1.data[23];
				ptr -= 10;
			}
			if (this.global1.data[38] < 0 && this.global1.data[15] > 6)
			{
				ptr = ref this.global1.data[15];
				ref int ptr8 = ref ptr;
				num = ptr;
				ptr8 = num - 1;
				int num9 = this.global1.data[38];
				this.global1.data[38] = 10 + num9;
				if (this.global1.data[15] == 6)
				{
					for (int n = 1; n < this.global1.is_party_ally.Length; n = num + 1)
					{
						bool flag3 = this.global1.is_party_ally[n];
						if (this.global1.is_party_enabled[n])
						{
							ptr = ref this.global1.data[6];
							ptr += 10;
							ptr = ref this.global1.data[2];
							ptr -= 150;
							ptr = ref this.global1.data[3];
							ptr -= this.global1.party_number[n] * 3;
							ptr = ref this.global1.data[4];
							ptr += this.global1.party_number[n] * 3;
							this.global1.is_party_ally[n] = false;
							this.global1.is_party_enabled[n] = false;
							this.global1.party_number[n] = 0;
						}
						num = n;
					}
					this.global1.is_konst_max = true;
					this.global1.data[41] = 0;
				}
			}
			else if (this.global1.data[38] > 10 && this.global1.data[15] < 9)
			{
				ptr = ref this.global1.data[15];
				ref int ptr9 = ref ptr;
				num = ptr;
				ptr9 = num + 1;
				if (this.global1.data[15] == 9 && this.global1.data[17] >= 16 && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51 && !this.vybory)
				{
					this.vybory = true;
				}
				ptr = ref this.global1.data[65];
				ref int ptr10 = ref ptr;
				num = ptr;
				ptr10 = num - 1;
				int num10 = this.global1.data[38];
				this.global1.data[38] = Mathf.Abs(10 - num10);
				for (int num11 = 0; num11 < this.global1.is_party_enabled.Length; num11 = num + 1)
				{
					if (!this.global1.is_party_enabled[num11])
					{
						ptr = ref this.global1.data[1];
						ptr -= 10;
						ptr = ref this.global1.data[2];
						ptr += 50;
						ptr = ref this.global1.data[3];
						ptr += 10;
						ptr = ref this.global1.data[4];
						ptr += 25;
						ptr = ref this.global1.data[6];
						ptr -= 15;
						this.global1.is_party_enabled[num11] = true;
						this.global1.party_number[num11] = 0;
					}
					num = num11;
				}
			}
			if (this.global1.data[39] < 0 && this.global1.data[16] > 11)
			{
				int num12 = this.global1.data[39];
				if (this.global1.data[16] == 13 && num12 >= -10)
				{
					this.global1.data[39] = 5;
				}
				else
				{
					this.global1.data[39] = 10 + num12;
				}
				if (this.global1.data[16] == 12)
				{
					this.global1.data[16] = 10;
				}
				else
				{
					ptr = ref this.global1.data[16];
					ref int ptr11 = ref ptr;
					num = ptr;
					ptr11 = num - 1;
				}
			}
			else if (this.global1.data[39] < 0 && this.global1.data[16] == 11)
			{
				this.global1.data[16] = 10;
				ptr = ref this.global1.data[1];
				ptr += 200;
				int num13 = this.global1.data[39];
				this.global1.data[39] = 10 + num13;
			}
			else if (this.global1.data[39] > 10 && this.global1.data[16] < 13)
			{
				int num14 = this.global1.data[39];
				if (this.global1.data[16] <= 11 && num14 < 20)
				{
					this.global1.data[39] = 5;
				}
				else
				{
					this.global1.data[39] = Mathf.Abs(10 - num14);
				}
				if (this.global1.data[16] == 10)
				{
					this.global1.data[16] = 12;
				}
				else
				{
					ptr = ref this.global1.data[16];
					ref int ptr12 = ref ptr;
					num = ptr;
					ptr12 = num + 1;
				}
				ptr = ref this.global1.data[65];
				ref int ptr13 = ref ptr;
				num = ptr;
				ptr13 = num - 1;
				ptr = ref this.global1.data[5];
				ptr -= this.global1.data[5] / (16 - this.global1.data[16]);
			}
			if (this.global1.data[40] < 0 && this.global1.data[17] > 14)
			{
				ptr = ref this.global1.data[17];
				ref int ptr14 = ref ptr;
				num = ptr;
				ptr14 = num - 1;
				int num15 = this.global1.data[40];
				this.global1.data[40] = 10 + num15;
			}
			else if (this.global1.data[40] > 10 && this.global1.data[17] < 17)
			{
				ptr = ref this.global1.data[17];
				ref int ptr15 = ref ptr;
				num = ptr;
				ptr15 = num + 1;
				ptr = ref this.global1.data[65];
				ref int ptr16 = ref ptr;
				num = ptr;
				ptr16 = num - 1;
				if (this.global1.data[17] == 17 && this.global1.data[15] >= 8 && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51 && !this.vybory)
				{
					this.vybory = true;
				}
				int num16 = this.global1.data[40];
				this.global1.data[40] = Mathf.Abs(10 - num16);
			}
			if (this.global1.allcountries[7].Gosstroy == 0 && this.global1.allcountries[7].paths <= 0 && this.global1.data[21] >= 1990 && this.global1.data[20] >= 12 && !this.global1.is_gkchp && !this.global1.event_done[34])
			{
				this.global1.event_done[34] = true;
				this.global1.allcountries[7].Gosstroy = 1;
				this.global1.allcountries[7].subideology = 8;
			}
			if (this.global1.allcountries[6].Gosstroy == 0 && !this.global1.allcountries[7].Vyshi && this.global1.data[0] != 6 && (this.global1.data[7] <= 720 || (this.global1.data[21] == 1989 && this.global1.data[20] == 11 && this.global1.data[7] <= 770)))
			{
				int num17 = 0;
				if (this.global1.allcountries[6].Torg)
				{
					num17 += 2;
				}
				if (this.global1.allcountries[6].Help)
				{
					num17 += 5;
				}
				if (this.global1.allcountries[6].Stasi)
				{
					num17 += 2;
				}
				if (this.global1.allcountries[6].Donat || this.global1.data[20] == 1)
				{
					num17 += 2;
				}
				if (this.global1.data[7] <= (72 - num17) * 10 || (this.global1.data[21] == 1989 && this.global1.data[20] == 11 && this.global1.data[7] <= (77 - num17) * 10))
				{
					this.global1.allcountries[6].Gosstroy = 1;
					this.global1.allcountries[6].subideology = 11;
					this.global1.allcountries[6].Torg = false;
					this.global1.allcountries[6].Stasi = false;
				}
			}
			if (this.global1.allcountries[1].Gosstroy == 0 && this.global1.allcountries[1].paths <= 0 && this.global1.data[0] != 1 && (((this.global1.data[7] <= 750 || (this.global1.data[21] == 1989 && this.global1.data[20] == 10 && this.global1.data[7] <= 813)) && !this.global1.event_done[89]) || (this.global1.data[7] <= 580 && this.global1.event_done[89])))
			{
				int num18 = 0;
				if (this.global1.allcountries[1].Torg)
				{
					num18 += 2;
				}
				if (this.global1.allcountries[1].Help)
				{
					num18 += 5;
				}
				if (this.global1.allcountries[1].Stasi)
				{
					num18 += 2;
				}
				if (this.global1.allcountries[1].Donat || this.global1.data[20] == 1)
				{
					num18 += 2;
				}
				if (((this.global1.data[7] <= (75 - num18) * 10 || (this.global1.data[21] == 1989 && this.global1.data[20] == 10 && this.global1.data[7] <= (81 - num18) * 10 + 3)) && !this.global1.event_done[89]) || (this.global1.data[7] <= (58 - num18) * 10 && this.global1.event_done[89]))
				{
					this.global1.allcountries[1].Gosstroy = 1;
					this.global1.allcountries[1].subideology = 8;
					this.global1.allcountries[1].Torg = false;
					this.global1.allcountries[1].Stasi = false;
				}
			}
			if (this.global1.allcountries[1].Gosstroy == 1 && this.global1.allcountries[1].paths <= 0 && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 0)) && this.global1.data[0] != 1 && ((this.global1.data[7] <= 530 && !this.global1.event_done[91]) || (this.global1.data[7] <= 500 && this.global1.event_done[91])))
			{
				int num19 = 0;
				if (this.global1.allcountries[1].Torg)
				{
					num19 += 2;
				}
				if (this.global1.allcountries[1].Help)
				{
					num19 += 5;
				}
				if (this.global1.allcountries[1].Stasi)
				{
					num19 += 2;
				}
				if (this.global1.allcountries[1].Donat || this.global1.data[20] == 1)
				{
					num19 += 2;
				}
				if (this.global1.data[7] <= (53 - num19) * 10 && !this.global1.event_done[91])
				{
					this.global1.allcountries[1].Gosstroy = 2;
					this.global1.allcountries[1].subideology = 15;
					this.global1.allcountries[1].Torg = false;
					this.global1.allcountries[1].Stasi = false;
				}
				else if (this.global1.data[7] <= (50 - num19) * 10 && this.global1.event_done[91])
				{
					this.global1.allcountries[1].Gosstroy = 2;
					this.global1.allcountries[1].subideology = 15;
					this.global1.allcountries[1].Torg = false;
					this.global1.allcountries[1].Stasi = false;
					this.global1.allcountries[1].isSEV = false;
					this.global1.allcountries[1].isOVD = false;
				}
			}
			if (this.global1.allcountries[3].Gosstroy == 0 && this.global1.allcountries[3].paths <= 0 && ((this.global1.data[21] != 1989 && this.global1.data[7] <= 660) || this.global1.data[7] <= 659))
			{
				int num20 = 0;
				if (this.global1.allcountries[3].Torg)
				{
					num20 += 2;
				}
				if (this.global1.allcountries[3].Help)
				{
					num20 += 5;
				}
				if (this.global1.allcountries[3].Stasi)
				{
					num20 += 2;
				}
				if (this.global1.allcountries[3].Donat || this.global1.data[20] == 1)
				{
					num20 += 2;
				}
				if ((this.global1.data[21] != 1989 && this.global1.data[7] <= (66 - num20) * 10) || this.global1.data[7] <= (66 - num20) * 10 - 1)
				{
					this.global1.allcountries[3].Gosstroy = 1;
					this.global1.allcountries[3].subideology = 11;
					this.global1.allcountries[3].Torg = false;
					this.global1.allcountries[3].Stasi = false;
				}
			}
			if (this.global1.allcountries[4].Gosstroy == 1 && this.global1.allcountries[4].paths <= 0 && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 0)) && (((this.global1.data[7] <= 870 || (this.global1.data[21] == 1989 && this.global1.data[20] == 10 && this.global1.data[7] <= 920)) && !this.global1.event_done[9]) || (this.global1.data[7] <= 780 && this.global1.event_done[9])))
			{
				int num21 = 0;
				if (this.global1.allcountries[4].Torg)
				{
					num = num21;
					num21 = num + 1;
				}
				if (this.global1.allcountries[4].Help)
				{
					num21 += 5;
				}
				if (this.global1.allcountries[4].Stasi)
				{
					num21 += 2;
				}
				if (this.global1.allcountries[4].Donat || this.global1.data[20] == 1)
				{
					num21 += 3;
				}
				if (((this.global1.data[7] <= (87 - num21) * 10 || (this.global1.data[21] == 1989 && this.global1.data[20] == 10 && this.global1.data[7] <= (92 - num21) * 10)) && !this.global1.event_done[9]) || (this.global1.data[7] <= (78 - num21) * 10 && this.global1.event_done[9]))
				{
					this.global1.allcountries[4].Gosstroy = 2;
					this.global1.allcountries[4].subideology = 15;
					this.global1.allcountries[4].Torg = false;
					this.global1.allcountries[4].Stasi = false;
				}
			}
			if (this.global1.allcountries[2].Gosstroy == 0 && this.global1.allcountries[2].paths <= 0 && this.global1.data[0] != 2 && (this.global1.data[7] <= 940 || (this.global1.data[21] == 1989 && this.global1.data[20] == 8 && this.global1.data[7] <= 941)))
			{
				int num22 = 0;
				if (this.global1.allcountries[2].Torg)
				{
					num22 += 3;
				}
				if (this.global1.allcountries[2].Help)
				{
					num22 += 5;
				}
				if (this.global1.allcountries[2].Stasi)
				{
					num22 += 2;
				}
				if (this.global1.allcountries[2].Donat || this.global1.data[20] == 1)
				{
					num22 += 4;
				}
				if (this.global1.data[7] < (94 - num22) * 10 || (this.global1.data[21] == 1989 && this.global1.data[20] == 8 && this.global1.data[7] <= (95 - num22) * 10 - 9))
				{
					this.global1.allcountries[2].Gosstroy = 1;
					this.global1.allcountries[2].subideology = 11;
					this.global1.allcountries[2].Torg = false;
					this.global1.allcountries[2].Stasi = false;
				}
			}
			if (this.global1.allcountries[2].Gosstroy == 9 && this.global1.allcountries[2].paths <= 0 && this.global1.data[0] != 2 && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 0)) && this.global1.data[7] <= 850)
			{
				int num23 = 0;
				if (this.global1.allcountries[2].Torg)
				{
					num = num23;
					num23 = num + 1;
				}
				if (this.global1.allcountries[2].Help)
				{
					num23 += 5;
				}
				if (this.global1.allcountries[2].Stasi)
				{
					num23 += 2;
				}
				if (this.global1.allcountries[2].Donat || this.global1.data[20] == 1)
				{
					num23 += 3;
				}
				if (this.global1.data[7] <= (85 - num23) * 10)
				{
					this.global1.allcountries[2].Gosstroy = 1;
					this.global1.allcountries[2].subideology = 11;
					this.global1.allcountries[2].Torg = false;
					this.global1.allcountries[2].Stasi = false;
				}
			}
			if ((this.global1.allcountries[5].Gosstroy == 0 || this.global1.allcountries[5].subideology == 0) && this.global1.allcountries[5].paths <= 0 && this.global1.data[0] != 5 && (this.global1.data[7] <= 660 || (this.global1.data[21] == 1989 && this.global1.data[19] > 10 && this.global1.data[20] == 12 && this.global1.data[7] <= 670) || (this.global1.data[7] <= 460 && this.global1.event_done[46])))
			{
				int num24 = 0;
				if (this.global1.allcountries[5].Torg)
				{
					num24 += 2;
				}
				if (this.global1.allcountries[5].Help)
				{
					num24 += 5;
				}
				if (this.global1.allcountries[5].Stasi)
				{
					num24 += 3;
				}
				if (this.global1.allcountries[5].Donat || this.global1.data[20] == 1)
				{
					num = num24;
					num24 = num + 1;
				}
				if (((this.global1.data[7] <= (66 - num24) * 10 || (this.global1.data[21] == 1989 && this.global1.data[19] > 10 && this.global1.data[20] == 12 && this.global1.data[7] <= (67 - num24) * 10)) && !this.global1.event_done[46]) || this.global1.data[7] <= (46 - num24) * 10)
				{
					this.global1.allcountries[5].Gosstroy = 1;
					this.global1.allcountries[5].subideology = 11;
					this.global1.allcountries[5].Torg = false;
					this.global1.allcountries[5].Stasi = false;
				}
			}
			if (this.global1.allcountries[2].Gosstroy == 1 && this.global1.allcountries[2].paths <= 0 && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 0)) && ((this.global1.data[7] <= 480 && !this.global1.event_done[38]) || (this.global1.data[7] <= 540 && this.global1.data[20] > 1 && this.global1.data[21] != 1989 && !this.global1.event_done[38]) || (this.global1.data[7] <= 400 && this.global1.event_done[38])))
			{
				int num25 = 0;
				if (this.global1.allcountries[2].Torg)
				{
					num = num25;
					num25 = num + 1;
				}
				if (this.global1.allcountries[2].Help)
				{
					num25 += 5;
				}
				if (this.global1.allcountries[2].Stasi)
				{
					num25 += 2;
				}
				if (this.global1.allcountries[2].Donat)
				{
					num25 += 3;
				}
				else if (this.global1.data[20] == 1)
				{
					num = num25;
					num25 = num + 1;
				}
				if ((this.global1.data[7] <= (48 - num25) * 10 && !this.global1.event_done[38]) || (this.global1.data[7] <= (54 - num25) * 10 && this.global1.data[20] > 1 && this.global1.data[21] != 1989 && !this.global1.event_done[38]) || this.global1.data[7] <= (40 - num25) * 10)
				{
					this.global1.allcountries[2].Gosstroy = 2;
					this.global1.allcountries[2].subideology = 15;
					this.global1.allcountries[2].Torg = false;
					this.global1.allcountries[2].Stasi = false;
				}
			}
			if (this.global1.allcountries[5].Gosstroy == 1 && this.global1.allcountries[5].paths <= 0 && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 0)) && this.global1.data[0] != 5 && (this.global1.data[7] <= 340 || (this.global1.data[21] > 1990 && this.global1.data[7] <= 440)))
			{
				int num26 = 0;
				if (this.global1.allcountries[5].Torg)
				{
					num26 += 2;
				}
				if (this.global1.allcountries[5].Help)
				{
					num26 += 5;
				}
				if (this.global1.allcountries[5].Stasi)
				{
					num26 += 3;
				}
				if (this.global1.allcountries[5].Donat || this.global1.data[20] == 1)
				{
					num = num26;
					num26 = num + 1;
				}
				if (this.global1.data[7] <= (34 - num26) * 10 || (this.global1.data[21] > 1990 && this.global1.data[7] <= (44 - num26) * 10))
				{
					this.global1.allcountries[5].Gosstroy = 2;
					this.global1.allcountries[5].subideology = 13;
					this.global1.allcountries[5].Torg = false;
					this.global1.allcountries[5].Stasi = false;
				}
			}
			if (this.global1.allcountries[5].Gosstroy == 9 && this.global1.allcountries[5].paths <= 0 && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 0)) && this.global1.data[0] != 5 && this.global1.data[7] <= 150)
			{
				int num27 = 0;
				if (this.global1.allcountries[5].Torg)
				{
					num27 += 2;
				}
				if (this.global1.allcountries[5].Help)
				{
					num27 += 5;
				}
				if (this.global1.allcountries[5].Stasi)
				{
					num27 += 3;
				}
				if (this.global1.allcountries[5].Donat || this.global1.data[20] == 1)
				{
					num = num27;
					num27 = num + 1;
				}
				if (this.global1.data[7] <= (15 - num27) * 10)
				{
					this.global1.allcountries[5].Gosstroy = 2;
					this.global1.allcountries[5].subideology = 13;
					this.global1.allcountries[5].Torg = false;
					this.global1.allcountries[5].Stasi = false;
				}
			}
			if (this.global1.allcountries[9].Gosstroy == 0 && ((this.global1.data[7] <= 225 * (1 + this.global1.allcountries[7].Gosstroy) && !this.global1.event_done[42]) || this.global1.data[7] <= 150 * (1 + this.global1.allcountries[7].Gosstroy)))
			{
				int num28 = 0;
				if (this.global1.allcountries[9].Torg)
				{
					num28 += 2;
				}
				if (this.global1.allcountries[9].Help)
				{
					num28 += 5;
				}
				if (this.global1.allcountries[9].Stasi)
				{
					num28 += 2;
				}
				if (this.global1.allcountries[9].Donat || this.global1.data[20] == 1)
				{
					num28 += 2;
				}
				if (((this.global1.data[7] <= (22 * (1 + this.global1.allcountries[7].Gosstroy) - num28) * 10 && !this.global1.event_done[42]) || this.global1.data[7] <= (15 * (1 + this.global1.allcountries[7].Gosstroy) - num28) * 10) && this.global1.data[228] != 1)
				{
					this.global1.allcountries[9].Gosstroy = 1;
					this.global1.allcountries[9].subideology = 9;
					this.global1.allcountries[9].Torg = false;
					this.global1.allcountries[9].Stasi = false;
				}
			}
			if (this.global1.allcountries[20].Gosstroy == 0 && this.global1.data[0] != 20 && ((((this.global1.data[7] <= 380 && this.global1.data[21] <= 1990) || (this.global1.data[7] <= 680 && this.global1.data[21] > 1990)) && !this.global1.event_done[45]) || (((this.global1.data[7] <= 480 && this.global1.data[21] > 1990) || (this.global1.data[7] <= 280 && this.global1.data[21] <= 1990)) && !this.global1.event_done[45])))
			{
				int num29 = 0;
				if (this.global1.allcountries[20].Torg)
				{
					num29 += 2;
				}
				if (this.global1.allcountries[20].Help)
				{
					num29 += 5;
				}
				if (this.global1.allcountries[20].Stasi)
				{
					num29 += 2;
				}
				if (this.global1.allcountries[20].Donat || this.global1.data[20] == 1)
				{
					num29 += 2;
				}
				if ((((this.global1.data[7] <= (38 - num29) * 10 && this.global1.data[21] <= 1990) || (this.global1.data[7] <= (68 - num29) * 10 && this.global1.data[21] > 1990)) && !this.global1.event_done[45]) || (((this.global1.data[7] <= (48 - num29) * 10 && this.global1.data[21] > 1990) || (this.global1.data[7] <= (28 - num29) * 10 && this.global1.data[21] <= 1990)) && this.global1.event_done[45]))
				{
					this.global1.allcountries[20].Gosstroy = 1;
					this.global1.allcountries[20].subideology = 11;
					this.global1.allcountries[20].Torg = false;
					this.global1.allcountries[20].Stasi = false;
				}
			}
			if (this.global1.allcountries[6].Gosstroy == 1 && this.global1.allcountries[6].paths <= 0 && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 0)) && this.global1.data[0] != 6 && ((this.global1.data[7] <= 280 && !this.global1.event_done[47]) || this.global1.data[7] <= 220))
			{
				int num30 = 0;
				if (this.global1.allcountries[6].Torg)
				{
					num30 += 2;
				}
				if (this.global1.allcountries[6].Help)
				{
					num30 += 5;
				}
				if (this.global1.allcountries[6].Stasi)
				{
					num30 += 2;
				}
				if (this.global1.allcountries[6].Donat || this.global1.data[20] == 1)
				{
					num30 += 2;
				}
				if ((this.global1.data[7] <= (28 - num30) * 10 && !this.global1.event_done[47]) || this.global1.data[7] <= (22 - num30) * 10)
				{
					this.global1.allcountries[6].Gosstroy = 2;
					this.global1.allcountries[6].subideology = 14;
					this.global1.allcountries[6].Torg = false;
					this.global1.allcountries[6].Stasi = false;
				}
			}
			if (this.global1.allcountries[15].Gosstroy == 1 && (this.global1.data[0] < 49 || this.global1.data[0] > 51) && ((this.global1.data[7] <= 240 && this.global1.data[21] >= 1989) || (this.global1.data[20] >= 9 && this.global1.data[21] >= 1990) || (this.global1.data[7] <= 600 && this.global1.data[21] >= 1990)))
			{
				int num31 = 0;
				if (this.global1.allcountries[15].Torg)
				{
					num31 += 2;
				}
				if (this.global1.allcountries[15].Help)
				{
					num31 += 5;
				}
				if (this.global1.allcountries[15].Stasi)
				{
					num31 += 2;
				}
				if (this.global1.allcountries[15].Donat || this.global1.data[20] == 1)
				{
					num31 += 2;
				}
				if (this.global1.data[7] <= (24 - num31) * 10 || (this.global1.data[20] >= 9 && this.global1.data[21] >= 1990) || (this.global1.data[7] <= (60 - num31) * 10 && this.global1.data[21] >= 1990))
				{
					this.global1.allcountries[15].Gosstroy = 2;
					this.global1.allcountries[15].subideology = 13;
					this.global1.allcountries[15].Torg = false;
					this.global1.allcountries[15].Stasi = false;
				}
			}
			if (this.global1.allcountries[20].Gosstroy == 1 && (!this.global1.is_gkchp || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy > 0) || (this.global1.allcountries[7].Gosstroy == 0 && !this.global1.allcountries[7].isOVD)) && ((this.global1.data[7] <= 100 && !this.global1.event_done[77]) || this.global1.data[7] <= 1))
			{
				int num32 = 0;
				if (this.global1.allcountries[20].Torg)
				{
					num32 += 2;
				}
				if (this.global1.allcountries[20].Help)
				{
					num32 += 5;
				}
				if (this.global1.allcountries[20].Stasi)
				{
					num32 += 2;
				}
				if (this.global1.allcountries[20].Donat || this.global1.data[20] == 1)
				{
					num32 += 2;
				}
				if ((this.global1.data[7] <= (10 - num32) * 10 && !this.global1.event_done[77]) || this.global1.data[7] <= (1 - num32) * 10)
				{
					this.global1.allcountries[20].Gosstroy = 2;
					this.global1.allcountries[20].subideology = 14;
					this.global1.allcountries[20].Torg = false;
					this.global1.allcountries[20].Stasi = false;
				}
			}
			if (this.global1.allcountries[this.global1.data[0]].Vyshi && (this.global1.data[6] > 650 || this.global1.data[14] <= 1 || this.global1.data[16] <= 11))
			{
				this.global1.allcountries[this.global1.data[0]].Vyshi = false;
				ptr = ref this.global1.data[6];
				ptr += 50;
				ptr = ref this.global1.data[4];
				ptr += 150;
				ptr = ref this.global1.data[10];
				ptr += 100;
			}
			int num33 = 0;
			int num34 = 0;
			int num35 = 0;
			int num36 = 0;
			int num37 = 0;
			if (this.global1.data[15] > 7)
			{
				for (int num38 = 1; num38 < this.global1.is_party_ally.Length; num38 = num + 1)
				{
					bool flag4 = this.global1.is_party_ally[num38];
					if (this.global1.is_party_ally[num38] && this.global1.party_ideology[num38] == 1 && (this.global1.data[18] < 21 || this.global1.data[18] > 22))
					{
						this.global1.is_party_ally[num38] = false;
					}
					else if (this.global1.is_party_ally[num38] && this.global1.party_ideology[num38] == 2 && this.global1.data[18] < 22)
					{
						this.global1.is_party_ally[num38] = false;
					}
					else if (this.global1.is_party_ally[num38] && this.global1.party_ideology[num38] == 3 && this.global1.data[18] > 18 && this.global1.data[18] < 23)
					{
						this.global1.is_party_ally[num38] = false;
					}
					else if (this.global1.is_party_ally[num38] && this.global1.party_ideology[num38] == 10 && this.global1.data[18] > 19)
					{
						this.global1.is_party_ally[num38] = false;
					}
					num = num38;
				}
			}
			if (this.global1.data[15] >= 7 && !this.global1.is_party_enabled[1] && !this.global1.is_party_enabled[2] && !this.global1.is_party_enabled[3] && !this.global1.is_party_enabled[4])
			{
				this.global1.data[15] = 6;
				this.global1.data[38] = 10;
				this.global1.is_konst_max = true;
				this.global1.data[41] = 0;
			}
			if (this.global1.is_party_enabled[1])
			{
				if (!this.global1.is_party_ally[1])
				{
					if (this.global1.party_ideology[1] == 1)
					{
						num33 += this.global1.party_number[1];
					}
					else if (this.global1.party_ideology[1] == 2)
					{
						num34 += this.global1.party_number[1];
					}
					else if (this.global1.party_ideology[1] == 3)
					{
						num35 += this.global1.party_number[1];
					}
					else if (this.global1.party_ideology[1] == 10)
					{
						num36 += this.global1.party_number[1];
					}
				}
				else
				{
					num37 += this.global1.party_number[1];
				}
			}
			if (this.global1.is_party_enabled[2])
			{
				if (!this.global1.is_party_ally[2])
				{
					if (this.global1.party_ideology[2] == 1)
					{
						num33 += this.global1.party_number[2];
					}
					else if (this.global1.party_ideology[2] == 2)
					{
						num34 += this.global1.party_number[2];
					}
					else if (this.global1.party_ideology[2] == 3)
					{
						num35 += this.global1.party_number[2];
					}
					else if (this.global1.party_ideology[2] == 10)
					{
						num36 += this.global1.party_number[2];
					}
				}
				else
				{
					num37 += this.global1.party_number[2];
				}
			}
			if (this.global1.is_party_enabled[3])
			{
				if (!this.global1.is_party_ally[3])
				{
					if (this.global1.party_ideology[3] == 1)
					{
						num33 += this.global1.party_number[3];
					}
					else if (this.global1.party_ideology[3] == 2)
					{
						num34 += this.global1.party_number[3];
					}
					else if (this.global1.party_ideology[3] == 3)
					{
						num35 += this.global1.party_number[3];
					}
					else if (this.global1.party_ideology[3] == 10)
					{
						num36 += this.global1.party_number[3];
					}
				}
				else
				{
					num37 += this.global1.party_number[3];
				}
			}
			if (this.global1.is_party_enabled[4])
			{
				if (!this.global1.is_party_ally[4])
				{
					if (this.global1.party_ideology[4] == 1)
					{
						num33 += this.global1.party_number[4];
					}
					else if (this.global1.party_ideology[4] == 2)
					{
						num34 += this.global1.party_number[4];
					}
					else if (this.global1.party_ideology[4] == 3)
					{
						num35 += this.global1.party_number[4];
					}
					else if (this.global1.party_ideology[4] == 10)
					{
						num36 += this.global1.party_number[4];
					}
				}
				else
				{
					num37 += this.global1.party_number[4];
				}
			}
			num37 += this.global1.party_number[0];
			if (this.global1.data[15] == 6)
			{
				this.global1.data[41] = 0;
			}
			else if (num33 > num34 && num33 > num35 && num33 > num37 && num33 > num36)
			{
				this.global1.data[41] = 1;
			}
			else if (num35 > num33 && num35 > num34 && num35 > num37 && num34 > num36)
			{
				this.global1.data[41] = 3;
			}
			else if (num36 > num33 && num36 > num34 && num36 > num37 && num34 < num36)
			{
				this.global1.data[41] = 4;
			}
			else if (num37 > num33 && num37 > num34 && num37 > num35 && num37 > num36)
			{
				this.global1.data[41] = 0;
			}
			else
			{
				this.global1.data[41] = 2;
			}
			if (num37 > 266 || this.global1.data[15] <= 6)
			{
				this.global1.is_konst_max = true;
			}
			else
			{
				this.global1.is_konst_max = false;
			}
			if (this.global1.data[8] < 0)
			{
				this.goto_pause.OnMouseDown();
				if (this.global1.automat)
				{
					ptr = ref this.global1.data[1];
					ptr += this.global1.data[8] * 10;
					ptr = ref this.global1.data[3];
					ptr += this.global1.data[8] * 10;
					ptr = ref this.global1.data[5];
					ptr += this.global1.data[8] * 5;
					this.global1.data[8] = 1;
				}
				else
				{
					this.goto_economy.OnMouseDown();
				}
			}
			if (this.global1.data[20] == 1 && this.global1.data[19] == 1 && this.global1.data[21] > 1989)
			{
				for (int num39 = 0; num39 < this.global1.allcountries.Length; num39 = num + 1)
				{
					if (this.global1.allcountries[num39] != null)
					{
						if (((this.global1.allcountries[num39].isSEV && this.global1.allcountries[num39].Donat && num39 > 0 && num39 < 7) || num39 == 23 || num39 == 24 || num39 == 25 || num39 == 30 || num39 == 37 || num39 == 38 || num39 == 47 || num39 == 52 || num39 == 54) && this.global1.is_konst_max)
						{
							this.global1.allcountries[num39].Donat = false;
							if (num39 == 24)
							{
								this.global1.data[227] = 0;
							}
							else if (num39 == 37)
							{
								this.global1.allcountries[num39].Help = false;
							}
							else if (num39 == 38)
							{
								this.global1.allcountries[num39].Money = false;
							}
						}
						else if (num39 == 0 || num39 == 8 || num39 == 14)
						{
							this.global1.allcountries[num39].Money = false;
						}
						else if (((num39 > 11 && num39 < 13) || num39 == 15) && this.global1.is_konst_max)
						{
							this.global1.allcountries[num39].Donat = false;
							this.global1.allcountries[num39].Stasi = false;
						}
						else if (num39 > 16 && num39 < 18 && this.global1.is_konst_max)
						{
							this.global1.allcountries[num39].Stasi = false;
							this.global1.allcountries[num39].Help = false;
						}
						else if (num39 == 33)
						{
							this.global1.allcountries[num39].Help = false;
							this.global1.allcountries[num39].Donat = false;
						}
						else if (num39 == 44)
						{
							this.global1.allcountries[num39].Help = false;
						}
						else if ((num39 == 7 && this.global1.is_konst_max) || num39 == 0)
						{
							this.global1.allcountries[num39].Stasi = false;
						}
					}
					num = num39;
				}
			}
			if (this.global1.allcountries[7].isSEV && this.global1.allcountries[7].Donat && this.global1.is_konst_max && this.global1.data[19] == 1 && ((this.global1.data[20] % 3 == 0 && this.global1.data[21] <= 1989) || (this.global1.data[20] % 4 == 0 && this.global1.data[21] > 1989)))
			{
				this.global1.allcountries[7].Donat = false;
			}
			if (this.global1.data[19] == 7 || this.global1.data[19] == 9 || this.global1.data[19] == 11)
			{
				this.global1.data[211] = 111;
			}
			if (this.global1.data[20] == 7 && this.global1.data[21] == 1990 && this.global1.data[228] == 1)
			{
				this.global1.allcountries[9].subideology = 0;
			}
			if (((this.global1.data[19] >= 18 && this.global1.data[20] >= 6 && this.global1.data[21] == 1989) || this.global1.data[21] >= 1990) && this.global1.allcountries[33].subideology != 9)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					this.global1.allcountries[33].name = " 缅 甸";
				}
				else
				{
					this.global1.allcountries[33].name = "Мьянма";
				}
			}
			if (this.global1.data[19] == 1)
			{
				if (this.global1.data[20] == 6 && this.global1.data[21] == 1990)
				{
					this.global1.allcountries[31].subideology = 15;
				}
				if (this.global1.data[197] < 0)
				{
					this.global1.data[197] = 1;
				}
				if (this.global1.data[20] == 1 || this.global1.data[20] == 6)
				{
					this.global1.allcountries[0].Help = false;
				}
				this.global1.data[220] = 0;
				if (this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51)
				{
					for (int num40 = 0; num40 < 12; num40 = num + 1)
					{
						if (this.yug1.gameState.yugcountries[num40].is_exist && !this.yug1.gameState.yugcountries[num40].is_independent && this.yug1.gameState.yugregions[num40].owner == num40)
						{
							ptr = ref this.global1.data[220];
							ref int ptr17 = ref ptr;
							int num41 = ptr;
							ptr17 = num41 + 1;
						}
						num = num40;
					}
					if (!this.yug1.gameState.battle_royal)
					{
						if (this.global1.data[0] == 49)
						{
							if (this.yug1.gameState.yugcountries[2].is_independent && (this.yug1.gameState.yugregions[1].owner != 1 || this.yug1.gameState.yugcountries[1].peace_with[2]))
							{
								this.yug1.gameState.yugregions[2].owner = 8;
								this.yug1.gameState.yugcountries[2].is_independent = false;
							}
							if (this.yug1.gameState.yugcountries[6].is_independent && (this.yug1.gameState.yugregions[3].owner != 3 || this.yug1.gameState.yugcountries[3].peace_with[6]))
							{
								this.yug1.gameState.yugregions[6].owner = 8;
								this.yug1.gameState.yugcountries[6].is_independent = false;
							}
						}
						else if (this.global1.data[0] == 51 && this.yug1.gameState.yugcountries[4].is_independent && (this.yug1.gameState.yugregions[3].owner != 3 || this.yug1.gameState.yugcountries[3].peace_with[4]))
						{
							this.yug1.gameState.yugregions[4].owner = 1;
							this.yug1.gameState.yugcountries[4].is_independent = false;
						}
					}
				}
				if (this.global1.data[7] > 1000)
				{
					int num42 = 0;
					int num43 = 0;
					for (int num44 = 0; num44 < 53; num44 = num + 1)
					{
						if (this.global1.allcountries[num44].Gosstroy == 2 || (this.global1.allcountries[num44].Gosstroy == 9 && this.global1.allcountries[num44].subideology == 2))
						{
							int num41 = num42;
							num42 = num41 + 1;
						}
						if (((num44 >= 1 && num44 <= 7) || num44 == 15 || num44 == 20) && (this.global1.allcountries[num44].Gosstroy == 2 || (this.global1.allcountries[num44].Gosstroy == 9 && this.global1.allcountries[num44].subideology == 2)))
						{
							int num41 = num43;
							num43 = num41 + 1;
						}
						num = num44;
					}
					if (this.global1.data[7] > 1050)
					{
						this.global1.data[7] = this.global1.data[7] - num42 * (this.global1.data[7] - 1000) / 100;
					}
					else
					{
						this.global1.data[7] = this.global1.data[7] - (1 + num43) * this.global1.data[7] / 80;
					}
					if (this.global1.data[7] < 1000)
					{
						this.global1.data[7] = 1000;
					}
				}
				if (this.global1.data[164] == 7)
				{
					this.global1.allcountries[54].Gosstroy = 1;
					this.global1.allcountries[54].subideology = 9;
				}
				else if (this.global1.data[164] == 8)
				{
					this.global1.allcountries[54].Gosstroy = 9;
					this.global1.allcountries[54].subideology = 3;
				}
				if (this.global1.is_party_ally[1])
				{
					for (int num45 = 1; num45 < this.global1.is_party_enabled.Length; num45 = num + 1)
					{
						if (this.global1.is_party_ally[num45] && this.global1.party_number[0] <= this.global1.party_number[num45])
						{
							if (this.global1.party_ideology[num45] == 1)
							{
								if (this.global1.data[14] >= 3 && this.global1.data[16] >= 12 && this.global1.data[17] >= 16)
								{
									ptr = ref this.global1.data[3];
									ptr += 2;
									ptr = ref this.global1.data[4];
									ref int ptr18 = ref ptr;
									int num41 = ptr;
									ptr18 = num41 - 1;
									ptr = ref this.global1.data[6];
									ref int ptr19 = ref ptr;
									num41 = ptr;
									ptr19 = num41 - 1;
								}
								else
								{
									ptr = ref this.global1.data[3];
									ptr -= 3;
									ptr = ref this.global1.data[4];
									ptr += 2;
								}
							}
							else if (this.global1.party_ideology[num45] == 2)
							{
								if (this.global1.data[15] != 6 && this.global1.data[15] != 9 && this.global1.data[16] != 10 && this.global1.data[16] != 13 && this.global1.data[17] != 14 && this.global1.data[17] != 17)
								{
									ptr = ref this.global1.data[3];
									ref int ptr20 = ref ptr;
									int num41 = ptr;
									ptr20 = num41 + 1;
									ptr = ref this.global1.data[4];
									ref int ptr21 = ref ptr;
									num41 = ptr;
									ptr21 = num41 + 1;
									ptr = ref this.global1.data[31];
									ref int ptr22 = ref ptr;
									num41 = ptr;
									ptr22 = num41 - 1;
								}
								else
								{
									ptr = ref this.global1.data[3];
									ptr -= 2;
									ptr = ref this.global1.data[4];
									ref int ptr23 = ref ptr;
									int num41 = ptr;
									ptr23 = num41 + 1;
								}
							}
							else if (this.global1.party_ideology[num45] == 3)
							{
								if (this.global1.data[14] >= 4)
								{
									ptr = ref this.global1.data[3];
									ref int ptr24 = ref ptr;
									int num41 = ptr;
									ptr24 = num41 + 1;
									ptr = ref this.global1.data[4];
									ptr -= 3;
									ptr = ref this.global1.data[31];
									ptr += 2;
								}
								else
								{
									ptr = ref this.global1.data[3];
									ref int ptr25 = ref ptr;
									int num41 = ptr;
									ptr25 = num41 - 1;
									ptr = ref this.global1.data[4];
									ptr += 2;
									ptr = ref this.global1.data[5];
									ref int ptr26 = ref ptr;
									num41 = ptr;
									ptr26 = num41 - 1;
								}
							}
							else if (this.global1.party_ideology[num45] == 10)
							{
								if (this.global1.data[14] <= 2)
								{
									ptr = ref this.global1.data[3];
									ptr += 2;
									ptr = ref this.global1.data[4];
									ptr -= 2;
									ptr = ref this.global1.data[31];
									ref int ptr27 = ref ptr;
									int num41 = ptr;
									ptr27 = num41 - 1;
								}
								else
								{
									ptr = ref this.global1.data[2];
									ref int ptr28 = ref ptr;
									int num41 = ptr;
									ptr28 = num41 + 1;
									ptr = ref this.global1.data[4];
									ptr += 2;
									ptr = ref this.global1.data[31];
									ref int ptr29 = ref ptr;
									num41 = ptr;
									ptr29 = num41 + 1;
								}
							}
						}
						num = num45;
					}
				}
				if (this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51)
				{
					if (this.yug1.gameState.battle_royal)
					{
						if (this.global1.data[20] == 4 && this.global1.data[21] == 1989)
						{
							this.yug1.StartBattleRoyal();
						}
						else if (this.global1.data[20] == 2 && this.global1.data[21] == 1989)
						{
							this.yug1.SetBattleRoyal();
						}
					}
					this.yug1.MoneyGetBot();
					if (this.global1.data[21] < 1992)
					{
						for (int num46 = 0; num46 < this.yug1.gameState.yugcountries.Length; num46 = num + 1)
						{
							this.yug1.gameState.yugcountries[num46].have_regions = this.yug1.SummRegions(num46);
							num = num46;
						}
						for (int num47 = 0; num47 < this.yug1.gameState.yugregions.Length; num47 = num + 1)
						{
							if (this.yug1.gameState.yugregions[num47].owner != this.yug1.gameState.player)
							{
								this.yug1.BuildingBot(num47, this.yug1.gameState.yugregions[num47].level);
							}
							num = num47;
						}
					}
					if (this.yug1.gameState.yugcountries[11].name != "Захвачено Болгарией" || this.yug1.gameState.yugcountries[11].name == " 被 保 加 利 亚 占 领")
					{
						this.global1.data[59] = 0;
					}
					if (this.yug1.gameState.yugcountries[9].is_exist && this.yug1.gameState.yugcountries[10].is_exist)
					{
						this.global1.data[222] = 2;
					}
					else if (this.yug1.gameState.yugcountries[9].is_exist)
					{
						this.global1.data[222] = 1;
					}
					else if (this.yug1.gameState.yugcountries[10].is_exist)
					{
						this.global1.data[222] = 1;
					}
					else
					{
						this.global1.data[222] = 0;
					}
					if (this.yug1.gameState.modifies[8] > 0)
					{
						ptr = ref this.yug1.gameState.modifies_time[8];
						ref int ptr30 = ref ptr;
						num = ptr;
						ptr30 = num + 1;
						if (this.yug1.gameState.modifies_time[8] > 3)
						{
							this.yug1.gameState.modifies_time[8] = 0;
							this.yug1.gameState.modifies[8] = 0;
						}
					}
					if (this.yug1.gameState.modifies[12] > 0)
					{
						ptr = ref this.yug1.gameState.modifies_time[12];
						ref int ptr31 = ref ptr;
						num = ptr;
						ptr31 = num + 1;
						if ((this.yug1.gameState.modifies_time[12] > 6 && this.yug1.gameState.modifies[12] == 2) || this.yug1.gameState.modifies_time[12] > 12)
						{
							this.yug1.gameState.modifies_time[12] = 0;
							this.yug1.gameState.modifies[12] = 0;
						}
					}
				}
				if (this.global1.data[0] == 10)
				{
					if (this.global1.data[100] > 0 && this.global1.event_done[255])
					{
						ptr = ref this.global1.data[9];
						ptr -= 5;
						ptr = ref this.global1.data[31];
						ptr += 5;
						ptr = ref this.global1.data[8];
						ptr -= this.global1.data[8] / 10;
					}
					else if (this.global1.data[100] > 0)
					{
						ptr = ref this.global1.data[9];
						ptr -= 5;
						ptr = ref this.global1.data[31];
						ptr += 5;
					}
				}
				else if (this.global1.data[0] == 18 && this.global1.data[13] == 8)
				{
					ptr = ref this.global1.data[7];
					ref int ptr32 = ref ptr;
					num = ptr;
					ptr32 = num + 1;
				}
				if (this.global1.allcountries[0].Stasi)
				{
					this.global1.allcountries[0].Stasi = false;
				}
				if (this.global1.allcountries[this.global1.data[0]].Help)
				{
					this.global1.allcountries[this.global1.data[0]].Help = false;
				}
				if (this.global1.data[0] == 20)
				{
					if (this.global1.data[19] % 3 == 0 && this.global1.data[23] >= this.global1.data[24])
					{
						ptr = ref this.global1.data[24];
						ref int ptr33 = ref ptr;
						num = ptr;
						ptr33 = num + 1;
					}
					if (this.global1.data[23] - this.global1.data[24] > 15)
					{
						ptr = ref this.global1.data[23];
						ptr += (this.global1.data[23] - this.global1.data[24]) / 3 * 2;
					}
				}
				if ((this.global1.allcountries[7].isOVD && this.global1.is_gkchp) || (this.global1.allcountries[7].paths == 3 && this.global1.event_done[1075]))
				{
					ptr = ref this.global1.data[7];
					ref int ptr34 = ref ptr;
					num = ptr;
					ptr34 = num + 1;
				}
				else if (this.global1.event_done[426])
				{
					ptr = ref this.global1.data[7];
					ref int ptr35 = ref ptr;
					num = ptr;
					ptr35 = num + 1;
					if (this.global1.allcountries[7].isSEV && this.global1.allcountries[0].isSEV)
					{
						ptr = ref this.global1.data[8];
						ptr += this.global1.data[30] / 50;
						ptr = ref this.global1.data[30];
						ptr += this.global1.data[30] / 50;
					}
				}
				else if ((this.global1.event_done[4] || (this.global1.data[0] == 18 && this.global1.data[79] == 1)) && this.global1.data[21] < 1992 && (!this.global1.is_gkchp || !this.global1.allcountries[7].isOVD))
				{
					if (this.global1.event_done[4] && (this.global1.data[7] > 300 || this.global1.data[21] > 1989))
					{
						ptr = ref this.global1.data[7];
						ptr -= 10;
					}
					if (this.global1.data[30] > 0 && this.global1.data[0] != 20 && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51)
					{
						ptr = ref this.global1.data[8];
						ptr -= this.global1.data[30] / 50;
						ptr = ref this.global1.data[30];
						ptr -= this.global1.data[30] / 50;
						if (this.global1.data[0] == 18)
						{
							if (this.global1.data[16] == 10)
							{
								ptr = ref this.global1.data[5];
								ptr -= 22;
							}
							else if (this.global1.data[16] == 12)
							{
								ptr = ref this.global1.data[5];
								ptr -= 12;
							}
						}
					}
				}
				if (this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.data[21] <= 1991)
				{
					ptr = ref this.global1.data[7];
					ptr -= 2 * (1992 - this.global1.data[21]);
					ptr = ref this.global1.data[10];
					ptr -= 1992 - this.global1.data[21];
				}
				if (this.global1.diff[0])
				{
					ptr = ref this.global1.data[5];
					ptr -= 2 * (this.global1.data[21] - 1988);
					if (this.global1.data[21] < 1992 || !this.global1.is_gkchp || !this.global1.allcountries[7].isOVD)
					{
						ptr = ref this.global1.data[7];
						ref int ptr36 = ref ptr;
						num = ptr;
						ptr36 = num - 1;
					}
					ptr = ref this.global1.data[10];
					ptr += 5 - this.global1.data[14];
				}
				if (this.global1.data[0] == 20)
				{
					ptr = ref this.global1.data[8];
					ptr += 3;
				}
				if (this.global1.data[0] != 12)
				{
					if (this.global1.diff[1])
					{
						ptr = ref this.global1.data[5];
						ptr -= 3 * (this.global1.data[21] - 1988);
						if (this.global1.data[21] < 1992 || !this.global1.is_gkchp || !this.global1.allcountries[7].isOVD)
						{
							ptr = ref this.global1.data[7];
							ref int ptr37 = ref ptr;
							num = ptr;
							ptr37 = num - 1;
						}
						ptr = ref this.global1.data[10];
						ptr += 5 - this.global1.data[14];
					}
					else if (this.global1.diff[2])
					{
						ptr = ref this.global1.data[5];
						ptr -= this.global1.data[21] - 1988;
						if (this.global1.data[21] < 1992 || !this.global1.is_gkchp || !this.global1.allcountries[7].isOVD)
						{
							ptr = ref this.global1.data[7];
							ref int ptr38 = ref ptr;
							num = ptr;
							ptr38 = num - 1;
						}
						ptr = ref this.global1.data[10];
						ptr += 5 - this.global1.data[14];
					}
					else if (this.global1.diff[4])
					{
						ptr = ref this.global1.data[7];
						ptr -= 3;
						ptr = ref this.global1.data[8];
						ptr -= this.global1.data[21] - 1985;
					}
					if (this.global1.science[5])
					{
						if (this.global1.data[63] <= (this.global1.data[21] - 1989) * 2 + 4 && this.global1.data[21] <= 1991)
						{
							ptr = ref this.global1.data[8];
							ptr -= this.global1.data[63];
							this.global1.data[63] = (this.global1.data[21] - 1989) * 2;
						}
						else
						{
							ptr = ref this.global1.data[8];
							ptr -= this.global1.data[63] / 2;
							ptr = ref this.global1.data[63];
							ptr -= 4;
						}
					}
					else if (this.global1.science[4])
					{
						if (this.global1.data[63] <= (this.global1.data[21] - 1988) * 2 + 4 && this.global1.data[21] <= 1991)
						{
							ptr = ref this.global1.data[8];
							ptr -= this.global1.data[63];
							this.global1.data[63] = (this.global1.data[21] - 1988) * 2;
						}
						else
						{
							ptr = ref this.global1.data[8];
							ptr -= this.global1.data[63] / 2;
							ptr = ref this.global1.data[63];
							ptr -= 4;
						}
					}
					else if (this.global1.science[3])
					{
						if (this.global1.data[63] <= (this.global1.data[21] - 1987) * 2 + 4 && this.global1.data[21] <= 1991)
						{
							ptr = ref this.global1.data[8];
							ptr -= this.global1.data[63];
							this.global1.data[63] = (this.global1.data[21] - 1987) * 2;
						}
						else
						{
							ptr = ref this.global1.data[8];
							ptr -= this.global1.data[63] / 2;
							ptr = ref this.global1.data[63];
							ptr -= 4;
						}
					}
					else if (this.global1.data[63] <= (this.global1.data[21] - 1986) * 2 + 4 && this.global1.data[21] <= 1991)
					{
						ptr = ref this.global1.data[8];
						ptr -= this.global1.data[63];
						this.global1.data[63] = (this.global1.data[21] - 1986) * 2;
					}
					else
					{
						ptr = ref this.global1.data[8];
						ptr -= this.global1.data[63] / 2;
						ptr = ref this.global1.data[63];
						ptr -= 4;
					}
				}
				if (this.global1.data[63] < 0)
				{
					this.global1.data[63] = 0;
				}
				if (this.global1.data[0] == 12)
				{
					this.global1.data[63] = 0;
				}
				if (this.global1.allcountries[7].isOVD && this.global1.is_gkchp)
				{
					ptr = ref this.global1.data[7];
					ptr += 5;
				}
				this.global1.is_liber = false;
				if (this.global1.data[20] % 3 == 0 || this.global1.data[20] == 1)
				{
					this.global1.is_elect = false;
					this.global1.event_done[2] = false;
					if (this.global1.data[0] == 12)
					{
						if (!this.global1.allcountries[7].Vyshi)
						{
							if (this.global1.data[90] == 0 && this.global1.data[92] == 0 && this.global1.data[93] == 0 && this.global1.data[94] == 0)
							{
								if (this.global1.data[8] < 200)
								{
									ptr = ref this.global1.data[8];
									ptr += 35;
								}
								ptr = ref this.global1.data[30];
								ptr += 10;
								if (this.global1.data[9] < 200)
								{
									ptr = ref this.global1.data[9];
									ptr += 30;
								}
								this.global1.data[10] = 0;
								ptr = ref this.global1.data[2];
								ptr += 100;
							}
							else
							{
								if (this.global1.data[8] < 200)
								{
									ptr = ref this.global1.data[8];
									ptr += 70;
								}
								ptr = ref this.global1.data[30];
								ptr += 25;
								if (this.global1.data[9] < 200)
								{
									ptr = ref this.global1.data[9];
									ptr += 60;
								}
								this.global1.data[10] = 0;
								ptr = ref this.global1.data[2];
								ptr += 300;
							}
						}
						else if (this.global1.data[30] != 0)
						{
							this.global1.data[30] = 0;
						}
					}
				}
				if (this.global1.data[20] == 5 || this.global1.data[20] == 11)
				{
					this.global1.is_speech = false;
					this.global1.event_done[1] = false;
				}
				if (this.global1.event_done[35] && this.global1.data[0] != 20 && this.global1.data[0] != 49 && this.global1.data[0] != 50 && this.global1.data[0] != 51 && this.global1.data[21] < 1992 && (!this.global1.is_gkchp || (this.global1.allcountries[7].Gosstroy > 1 && this.global1.is_gkchp)))
				{
					ptr = ref this.global1.data[24];
					ref int ptr39 = ref ptr;
					num = ptr;
					ptr39 = num + 1;
				}
				for (int num48 = 0; num48 < this.global1.regions.Length; num48 = num + 1)
				{
					for (int num49 = 0; num49 < 15; num49 = num + 1)
					{
						if (this.global1.regions[num48].buildings[num49].type == 17 && this.global1.regions[num48].buildings[num49].is_builded && this.global1.regions[num48].buildings[num49].is_working)
						{
							if (this.global1.data[14] < 3)
							{
								ptr = ref this.global1.data[3];
								ref int ptr40 = ref ptr;
								num = ptr;
								ptr40 = num + 1;
							}
							else if (this.global1.data[14] > 3)
							{
								ptr = ref this.global1.data[3];
								ref int ptr41 = ref ptr;
								num = ptr;
								ptr41 = num - 1;
							}
						}
						else if (this.global1.regions[num48].buildings[num49].type == 21 && this.global1.regions[num48].buildings[num49].is_builded && this.global1.regions[num48].buildings[num49].is_working)
						{
							ptr = ref this.global1.data[5];
							ptr -= 10;
							ptr = ref this.global1.data[22];
							ptr += 5;
							ptr = ref this.global1.data[4];
							ptr += 30;
							ptr = ref this.global1.data[8];
							ptr -= 5;
							ptr = ref this.global1.data[9];
							ptr += 10;
						}
						else if (this.global1.regions[num48].buildings[num49].is_private && this.global1.regions[num48].buildings[num49].is_builded && this.global1.regions[num48].buildings[num49].is_working)
						{
							ptr = ref this.global1.data[4];
							ptr += 13 - this.global1.data[16];
						}
						num = num49;
					}
					num = num48;
				}
				if (this.global1.data[0] == 12)
				{
					for (int num50 = 114; num50 < 126; num50 = num + 1)
					{
						if (this.global1.data[num50] > 20)
						{
							ptr = ref this.global1.data[num50];
							ref int ptr42 = ref ptr;
							num = ptr;
							ptr42 = num - 1;
						}
						num = num50;
					}
					this.global1.data[89] = this.global1.data[4] / 20 + (1000 - this.global1.data[3]) / 20;
					if (this.global1.data[21] > 1989)
					{
						ptr = ref this.global1.data[89];
						ptr += 5;
					}
					if (this.global1.data[109] >= 6 || this.global1.allcountries[7].Vyshi)
					{
						ptr = ref this.global1.data[89];
						ptr += this.global1.data[4] / 20 + (1000 - this.global1.data[3]) / 20;
					}
					if (this.global1.data[109] >= 12 || this.global1.allcountries[7].Vyshi)
					{
						ptr = ref this.global1.data[89];
						ptr += this.global1.data[4] / 20 + (1000 - this.global1.data[3]) / 20;
					}
					if (this.global1.data[109] >= 18)
					{
						ptr = ref this.global1.data[89];
						ptr += this.global1.data[4] / 20 + (1000 - this.global1.data[3]) / 20;
					}
					if (this.global1.data[109] >= 24)
					{
						ptr = ref this.global1.data[89];
						ptr += this.global1.data[4] / 20 + (1000 - this.global1.data[3]) / 20;
					}
					Debug.Log(this.global1.data[113 + this.global1.data[20]]);
					Debug.Log(this.global1.data[89]);
					if (this.global1.data[110] <= 0 && this.global1.data[20] != 1 && this.global1.data[112] != 1 && (this.global1.data[90] != 0 || this.global1.data[92] != 0 || this.global1.data[93] != 0 || this.global1.data[94] != 0 || (this.global1.data[90] == 1 && this.global1.data[92] == 1 && this.global1.data[93] == 1 && this.global1.data[94] == 1 && this.global1.data[81] == 1)) && this.global1.event_done[240] && this.global1.data[88] <= 0 && this.global1.data[113 + this.global1.data[20]] < this.global1.data[89])
					{
						this.global1.data[109] = 0;
						this.VyzovEvent(241);
					}
					else if (this.global1.data[110] <= 0 && this.global1.data[20] != 1 && this.global1.data[112] != 1 && this.global1.data[90] == 0 && this.global1.data[92] == 0 && this.global1.data[93] == 0 && this.global1.data[94] == 0 && this.global1.event_done[240] && this.global1.data[88] <= 0 && this.global1.data[113 + this.global1.data[20]] < this.global1.data[89])
					{
						this.global1.data[109] = 0;
						this.VyzovEvent(237);
					}
					else if (this.global1.data[20] == 3 && this.global1.data[21] == 1989)
					{
						this.VyzovEvent(241);
					}
					if (this.global1.data[88] < 2)
					{
						ptr = ref this.global1.data[109];
						ref int ptr43 = ref ptr;
						num = ptr;
						ptr43 = num + 1;
					}
					else
					{
						this.global1.data[109] = 0;
					}
				}
				else if (this.global1.data[0] == 2 && this.global1.data[113] > 0 && !this.global1.is_party_enabled[4])
				{
					this.global1.data[113] = 0;
				}
			}
			if (this.global1.data[19] % 14 == 0)
			{
				if (this.global1.diff[2])
				{
					ptr = ref this.global1.data[10];
					ref int ptr44 = ref ptr;
					num = ptr;
					ptr44 = num + 1;
				}
				if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
				{
					for (int num51 = 0; num51 < this.yug1.gameState.yugcountries.Length; num51 = num + 1)
					{
						this.yug1.gameState.yugcountries[num51].traded = false;
						num = num51;
					}
				}
			}
			if (this.global1.data[19] % 7 == 0)
			{
				if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51 && !this.yug1.gameState.battle_royal)
				{
					this.YugoModifiesChanges();
				}
				else
				{
					ptr = ref this.global1.data[3];
					ptr += 10;
				}
				this.global1.data[215] = 1;
				int num52 = global::UnityEngine.Random.Range(1, 8);
				this.global1.data[207] = num52;
				if (this.global1.allcountries[46].isSEV && !this.global1.allcountries[7].isSEV)
				{
					ptr = ref this.global1.data[8];
					ptr -= 2;
				}
				else if (this.global1.allcountries[46].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV && this.global1.allcountries[7].isSEV)
				{
					ptr = ref this.global1.data[23];
					ptr -= 4;
					ptr = ref this.global1.data[8];
					ref int ptr45 = ref ptr;
					int num41 = ptr;
					ptr45 = num41 - 1;
				}
				if (this.global1.allcountries[33].isSEV && !this.global1.allcountries[7].isSEV)
				{
					ptr = ref this.global1.data[8];
					ptr -= 2;
				}
				else if (this.global1.allcountries[33].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV && this.global1.allcountries[7].isSEV)
				{
					ptr = ref this.global1.data[23];
					ptr -= 4;
					ptr = ref this.global1.data[8];
					ref int ptr46 = ref ptr;
					int num41 = ptr;
					ptr46 = num41 - 1;
				}
				if (this.global1.allcountries[22].isSEV && !this.global1.allcountries[7].isSEV)
				{
					ptr = ref this.global1.data[8];
					ptr -= 2;
				}
				else if (this.global1.allcountries[22].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV && this.global1.allcountries[7].isSEV)
				{
					ptr = ref this.global1.data[23];
					ptr -= 4;
					ptr = ref this.global1.data[8];
					ref int ptr47 = ref ptr;
					int num41 = ptr;
					ptr47 = num41 - 1;
				}
				if (this.global1.allcountries[9].isSEV && !this.global1.allcountries[7].isSEV && !this.global1.allcountries[16].isSEV)
				{
					ptr = ref this.global1.data[8];
					ptr -= 2;
				}
				else if (this.global1.allcountries[9].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV && this.global1.allcountries[7].isSEV)
				{
					ptr = ref this.global1.data[23];
					ptr -= 4;
					ptr = ref this.global1.data[8];
					ref int ptr48 = ref ptr;
					int num41 = ptr;
					ptr48 = num41 - 1;
				}
				if (this.global1.allcountries[23].isSEV && this.global1.data[224] <= 1 && !this.global1.allcountries[7].isSEV)
				{
					ptr = ref this.global1.data[8];
					ptr -= 2;
				}
				else if (this.global1.allcountries[23].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV && this.global1.allcountries[7].isSEV)
				{
					ptr = ref this.global1.data[23];
					ptr -= 4;
					ptr = ref this.global1.data[8];
					ref int ptr49 = ref ptr;
					int num41 = ptr;
					ptr49 = num41 - 1;
				}
				if (this.global1.allcountries[43].isSEV && !this.global1.allcountries[7].isSEV && !this.global1.allcountries[19].Torg && (!this.global1.allcountries[19].Stasi || this.global1.allcountries[19].Gosstroy != 2) && !this.global1.allcountries[16].Torg)
				{
					ptr = ref this.global1.data[23];
					ptr -= 6;
				}
				Debug.Log("MODFIEDONE");
				if (this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51)
				{
					for (int num53 = 0; num53 < this.yug1.gameState.yugcountries.Length; num53 = num + 1)
					{
						this.yug1.gameState.yugcountries[num53].last = this.yug1.IsLastOne(num53);
						this.yug1.gameState.yugcountries[num53].have_regions = this.yug1.SummRegions(num53);
						if (this.global1.data[19] % 14 == 0)
						{
							this.yug1.ArmyAutoGrowth(num53, ref this.yug1.gameState.yugcountries[num53].army);
						}
						if (this.yug1.gameState.yugcountries[num53].temp_peace)
						{
							YugoCountry yugoCountry = this.yug1.gameState.yugcountries[num53];
							YugoCountry yugoCountry2 = yugoCountry;
							num = yugoCountry.temp_peace_time;
							yugoCountry2.temp_peace_time = num - 1;
							if (this.yug1.gameState.yugcountries[num53].temp_peace_time <= 0)
							{
								this.yug1.MakeTempPeace(num53);
							}
						}
						num = num53;
					}
					for (int num54 = 0; num54 < this.yug1.gameState.yugcountries.Length; num54 = num + 1)
					{
						if (num54 != this.yug1.gameState.player && this.yug1.gameState.yugcountries[num54].have_regions > 0 && this.yug1.gameState.yugcountries[num54].army > 49)
						{
							this.yug1.ChooseAttackBot(num54);
						}
						num = num54;
					}
					for (int num55 = 0; num55 < this.yug1.gameState.yugregions.Length; num55 = num + 1)
					{
						this.yug1.gameState.yugregions[num55].defence = this.yug1.DefenceRegionalPower(num55);
						num = num55;
					}
				}
				Debug.Log("ATTACKDONE");
				if (this.global1.data[0] == 10)
				{
					ptr = ref this.global1.data[5];
					ptr -= 5;
					if (this.global1.event_done[16] && this.global1.allcountries[16].Gosstroy != 0 && this.global1.data[73] > 0)
					{
						ptr = ref this.global1.data[73];
						ref int ptr50 = ref ptr;
						num = ptr;
						ptr50 = num - 1;
					}
					else if (this.global1.data[73] < 0)
					{
						this.global1.data[73] = 0;
					}
					if (this.global1.event_done[209] && this.global1.data[5] <= 200)
					{
						this.global1.data[71] = 1;
					}
					else if (this.global1.data[5] >= 300)
					{
						this.global1.data[71] = 0;
					}
				}
				else if (this.global1.data[0] == 12 || this.global1.data[0] == 18)
				{
					if (this.global1.data[5] <= 200)
					{
						this.global1.data[71] = 1;
					}
					else if (this.global1.data[5] >= 300)
					{
						this.global1.data[71] = 0;
					}
				}
				else
				{
					int num56 = 0;
					for (int num57 = 0; num57 < this.global1.science.Length; num57 = num + 1)
					{
						if (this.global1.science[num57])
						{
							num = num56;
							num56 = num + 1;
						}
						num = num57;
					}
					if (this.global1.data[5] <= (35 - num56) * 10)
					{
						this.global1.data[71] = 1;
					}
					else if (this.global1.data[5] <= (57 - num56) * 10)
					{
						this.global1.data[71] = 2;
					}
					else if (this.global1.data[5] <= (77 - num56) * 10)
					{
						this.global1.data[71] = 3;
					}
					else if (this.global1.data[5] <= (92 - num56) * 10)
					{
						this.global1.data[71] = 4;
					}
					else
					{
						this.global1.data[71] = 5;
					}
					if (this.global1.data[71] == 1)
					{
						ptr = ref this.global1.data[3];
						ptr -= 5;
						ptr = ref this.global1.data[1];
						ptr -= 4;
						ptr = ref this.global1.data[8];
						ptr -= 2;
						ptr = ref this.global1.data[22];
						ptr -= 2;
					}
					else if (this.global1.data[71] == 2)
					{
						ptr = ref this.global1.data[3];
						ptr -= 2;
						ptr = ref this.global1.data[1];
						ref int ptr51 = ref ptr;
						int num41 = ptr;
						ptr51 = num41 - 1;
					}
					else if (this.global1.data[71] == 3)
					{
						ptr = ref this.global1.data[3];
						ref int ptr52 = ref ptr;
						int num41 = ptr;
						ptr52 = num41 - 1;
						ptr = ref this.global1.data[1];
						ref int ptr53 = ref ptr;
						num41 = ptr;
						ptr53 = num41 - 1;
						ptr = ref this.global1.data[4];
						ref int ptr54 = ref ptr;
						num41 = ptr;
						ptr54 = num41 + 1;
					}
					else if (this.global1.data[71] == 4)
					{
						ptr = ref this.global1.data[3];
						ref int ptr55 = ref ptr;
						int num41 = ptr;
						ptr55 = num41 + 1;
						ptr = ref this.global1.data[1];
						ref int ptr56 = ref ptr;
						num41 = ptr;
						ptr56 = num41 + 1;
						ptr = ref this.global1.data[4];
						ref int ptr57 = ref ptr;
						num41 = ptr;
						ptr57 = num41 + 1;
					}
					else if (this.global1.data[71] == 5)
					{
						ptr = ref this.global1.data[3];
						ptr += 3;
						ptr = ref this.global1.data[1];
						ptr += 2;
						ptr = ref this.global1.data[8];
						ref int ptr58 = ref ptr;
						int num41 = ptr;
						ptr58 = num41 - 1;
						ptr = ref this.global1.data[4];
						ref int ptr59 = ref ptr;
						num41 = ptr;
						ptr59 = num41 - 1;
					}
					if (this.global1.data[72] > 0)
					{
						ptr = ref this.global1.data[6];
						ptr += 2;
						ptr = ref this.global1.data[10];
						ptr += 2;
						ptr = ref this.global1.data[8];
						ptr -= 5;
						ptr = ref this.global1.data[22];
						ptr += 2;
					}
				}
				if (this.global1.data[72] > 0)
				{
					ptr = ref this.global1.data[6];
					ptr += 2;
					ptr = ref this.global1.data[10];
					ptr += 2;
					ptr = ref this.global1.data[5];
					ptr -= 2;
					ptr = ref this.global1.data[8];
					ptr -= 5;
					ptr = ref this.global1.data[22];
					ptr += 2;
				}
				if (this.global1.diff[4] && this.global1.data[21] < 1992)
				{
					ptr = ref this.global1.data[1];
					ptr -= this.global1.data[1] / 50 / 3 * (this.global1.data[1] / 250) * (this.global1.data[1] / (600 - (this.global1.data[21] - 1989) * 150)) * (this.global1.data[21] - 1988);
					ptr = ref this.global1.data[8];
					ptr -= this.global1.data[8] / 5 / 3 * (this.global1.data[8] / 50) * (this.global1.data[8] / (80 - (this.global1.data[21] - 1989) * 15)) * (this.global1.data[21] - 1988);
					if (this.global1.data[9] > 0)
					{
						ptr = ref this.global1.data[9];
						ptr -= this.global1.data[9] / 5 / 3 * (this.global1.data[9] / 50) * (this.global1.data[9] / (80 - (this.global1.data[21] - 1989) * 15)) * (this.global1.data[21] - 1988);
					}
					else if (this.global1.data[9] <= -100)
					{
						this.global1.data[9] = -100;
					}
					ptr = ref this.global1.data[2];
					ptr -= (5 - this.global1.data[14]) * (this.global1.data[21] - 1988) * (this.global1.data[21] - 1988);
					if (this.global1.data[14] < 3 || ((this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51) && this.global1.data[14] < 4))
					{
						ptr = ref this.global1.data[4];
						ptr += (1100 - this.global1.data[4]) / 40 / 3 * ((1100 - this.global1.data[4]) / 200) * ((1100 - this.global1.data[4]) / (500 - (this.global1.data[21] - 1989) * 150)) * (this.global1.data[21] - 1988);
					}
					else
					{
						ptr = ref this.global1.data[3];
						ptr -= this.global1.data[4] / 40 / 3 * (this.global1.data[4] / 200) * (this.global1.data[4] / (500 - (this.global1.data[21] - 1989) * 150)) * (this.global1.data[21] - 1988);
					}
				}
				if (this.global1.data[61] > 40)
				{
					ptr = ref this.global1.data[61];
					ref int ptr60 = ref ptr;
					num = ptr;
					ptr60 = num - 1;
					ptr = ref this.global1.data[10];
					ptr -= 5;
					ptr = ref this.global1.data[4];
					ptr += 2;
					ptr = ref this.global1.data[6];
					ptr -= 2;
				}
				else if (this.global1.data[61] > 30 && this.global1.data[61] < 35)
				{
					ptr = ref this.global1.data[61];
					ref int ptr61 = ref ptr;
					num = ptr;
					ptr61 = num - 1;
					ptr = ref this.global1.data[2];
					ref int ptr62 = ref ptr;
					num = ptr;
					ptr62 = num - 1;
					ptr = ref this.global1.data[4];
					ref int ptr63 = ref ptr;
					num = ptr;
					ptr63 = num - 1;
					ptr = ref this.global1.data[22];
					ptr += 2;
					ptr = ref this.global1.data[31];
					ptr += 2;
					ptr = ref this.global1.data[6];
					ref int ptr64 = ref ptr;
					num = ptr;
					ptr64 = num + 1;
					ptr = ref this.global1.data[10];
					ptr += 2;
				}
				else if (this.global1.data[61] > 20 && this.global1.data[61] < 25)
				{
					ptr = ref this.global1.data[61];
					ref int ptr65 = ref ptr;
					num = ptr;
					ptr65 = num - 1;
					ptr = ref this.global1.data[2];
					ptr += 5;
					ptr = ref this.global1.data[4];
					ptr += 2;
					ptr = ref this.global1.data[31];
					ptr -= 2;
				}
				else if (this.global1.data[61] > 10 && this.global1.data[61] < 15)
				{
					ptr = ref this.global1.data[61];
					ref int ptr66 = ref ptr;
					num = ptr;
					ptr66 = num - 1;
					ptr = ref this.global1.data[33];
					ptr -= 5;
					ptr = ref this.global1.data[6];
					ref int ptr67 = ref ptr;
					num = ptr;
					ptr67 = num - 1;
				}
				else if (this.global1.data[61] > 0 && this.global1.data[61] < 5)
				{
					ptr = ref this.global1.data[61];
					ref int ptr68 = ref ptr;
					num = ptr;
					ptr68 = num - 1;
					ptr = ref this.global1.data[33];
					ptr += 5;
					ptr = ref this.global1.data[6];
					ref int ptr69 = ref ptr;
					num = ptr;
					ptr69 = num + 1;
				}
				else
				{
					this.global1.data[61] = 0;
				}
				if (this.global1.allcountries[40].Westalgie > 100 && this.global1.allcountries[40].Westalgie < 1000)
				{
					if (this.global1.data[21] < 1991 || this.global1.allcountries[40].Westalgie > 950)
					{
						Country country = this.global1.allcountries[40];
						Country country2 = country;
						num = country.Westalgie;
						country2.Westalgie = num - 1;
					}
					else
					{
						Country country3 = this.global1.allcountries[40];
						Country country4 = country3;
						country4.Westalgie -= 4;
					}
				}
				else if (this.global1.allcountries[40].Westalgie >= 1000 && this.global1.allcountries[40].subideology != 3 && this.global1.allcountries[40].Gosstroy != 1 && !this.global1.event_done[1078])
				{
					this.global1.allcountries[40].Gosstroy = 1;
					this.global1.allcountries[40].subideology = 11;
					Country country5 = this.global1.allcountries[17];
					Country country4 = country5;
					country4.Westalgie += 5;
					ptr = ref this.global1.data[7];
					ptr += 3;
				}
				else if (this.global1.allcountries[40].Westalgie <= 0 && this.global1.allcountries[40].subideology != 3 && !this.global1.event_done[1078])
				{
					this.global1.allcountries[40].Gosstroy = 9;
					this.global1.allcountries[40].subideology = 3;
				}
				if (this.global1.allcountries[41].Westalgie > 100 && this.global1.allcountries[41].Westalgie < 1000)
				{
					if (this.global1.data[21] < 1990 || this.global1.allcountries[41].Westalgie > 950)
					{
						Country country6 = this.global1.allcountries[41];
						Country country4 = country6;
						country4.Westalgie -= 2;
					}
					else
					{
						Country country7 = this.global1.allcountries[41];
						Country country4 = country7;
						country4.Westalgie -= 5;
					}
				}
				else if (this.global1.allcountries[41].Westalgie <= 0 && this.global1.allcountries[41].Gosstroy != 1)
				{
					this.global1.allcountries[41].Gosstroy = 1;
					this.global1.allcountries[41].subideology = 11;
				}
				else if (this.global1.allcountries[41].Westalgie >= 1000 && this.global1.allcountries[41].Gosstroy != 0)
				{
					this.global1.allcountries[41].Gosstroy = 0;
					this.global1.allcountries[41].subideology = 7;
					Country country8 = this.global1.allcountries[17];
					Country country4 = country8;
					country4.Westalgie += 5;
					ptr = ref this.global1.data[7];
					ptr += 3;
				}
				if (this.global1.allcountries[42].Westalgie > 100 && this.global1.allcountries[42].Westalgie < 950)
				{
					if (this.global1.allcountries[42].Westalgie > 900)
					{
						Country country9 = this.global1.allcountries[42];
						Country country4 = country9;
						country4.Westalgie -= 2;
					}
					else
					{
						Country country10 = this.global1.allcountries[42];
						Country country4 = country10;
						country4.Westalgie -= 5;
					}
				}
				else if (this.global1.allcountries[42].Westalgie <= 0 && this.global1.allcountries[42].subideology != 2)
				{
					this.global1.allcountries[42].Gosstroy = 9;
					this.global1.allcountries[42].subideology = 2;
				}
				else if (this.global1.allcountries[42].Westalgie >= 1000 && this.global1.allcountries[42].subideology != 1)
				{
					this.global1.allcountries[42].Gosstroy = 9;
					this.global1.allcountries[42].subideology = 1;
					Country country11 = this.global1.allcountries[17];
					Country country4 = country11;
					country4.Westalgie += 5;
					ptr = ref this.global1.data[7];
					ptr += 3;
				}
				if (this.global1.allcountries[43].Westalgie > 100 && this.global1.allcountries[43].Westalgie < 1000)
				{
					if (this.global1.data[21] < 1990 || this.global1.allcountries[43].Westalgie > 950)
					{
						Country country12 = this.global1.allcountries[43];
						Country country4 = country12;
						country4.Westalgie -= 2;
					}
					else
					{
						Country country13 = this.global1.allcountries[43];
						Country country4 = country13;
						country4.Westalgie -= 5;
					}
					if (this.global1.allcountries[19].Gosstroy > 1)
					{
						Country country14 = this.global1.allcountries[43];
						Country country15 = country14;
						num = country14.Westalgie;
						country15.Westalgie = num - 1;
					}
					if (this.global1.allcountries[16].Gosstroy > 0)
					{
						Country country16 = this.global1.allcountries[43];
						Country country17 = country16;
						num = country16.Westalgie;
						country17.Westalgie = num - 1;
					}
				}
				else if (this.global1.allcountries[43].Westalgie <= 0 && this.global1.allcountries[43].subideology != 2)
				{
					this.global1.allcountries[43].Gosstroy = 9;
					this.global1.allcountries[43].subideology = 2;
				}
				else if (this.global1.allcountries[43].Westalgie >= 1000 && this.global1.allcountries[43].Gosstroy != 1)
				{
					this.global1.allcountries[43].Gosstroy = 1;
					this.global1.allcountries[43].subideology = 9;
					Country country18 = this.global1.allcountries[17];
					Country country4 = country18;
					country4.Westalgie += 5;
					ptr = ref this.global1.data[7];
					ptr += 3;
				}
				if (this.global1.data[41] == 1)
				{
					ptr = ref this.global1.data[3];
					ptr -= num33 / 30 * (this.global1.data[21] - 1988);
				}
				else if (this.global1.data[41] == 2)
				{
					ptr = ref this.global1.data[4];
					ptr += num33 / 30 * (this.global1.data[21] - 1988);
				}
				else if (this.global1.data[41] == 3)
				{
					ptr = ref this.global1.data[4];
					ptr += num33 / 30 * (this.global1.data[21] - 1988);
					ptr = ref this.global1.data[3];
					ptr -= num33 / 30 * (this.global1.data[21] - 1988);
				}
				else if (this.global1.data[41] == 4)
				{
					ptr = ref this.global1.data[10];
					ptr += 2;
					ptr = ref this.global1.data[6];
					ref int ptr70 = ref ptr;
					num = ptr;
					ptr70 = num + 1;
					ptr = ref this.global1.data[9];
					ref int ptr71 = ref ptr;
					num = ptr;
					ptr71 = num + 1;
					ptr = ref this.global1.data[31];
					ref int ptr72 = ref ptr;
					num = ptr;
					ptr72 = num + 1;
					ptr = ref this.global1.data[22];
					ref int ptr73 = ref ptr;
					num = ptr;
					ptr73 = num + 1;
					ptr = ref this.global1.data[1];
					ptr -= 5;
				}
				if (!this.global1.is_konst_max)
				{
					ptr = ref this.global1.data[4];
					ptr += this.global1.data[21] - 1988;
					ptr = ref this.global1.data[3];
					ptr -= this.global1.data[21] - 1988;
				}
				ptr = ref this.global1.data[4];
				ptr -= this.global1.data[15] - 7;
				ptr = ref this.global1.data[3];
				ptr -= this.global1.data[15] - 7;
				ptr = ref this.global1.data[2];
				ptr += this.global1.data[15] - 7;
				ptr = ref this.global1.data[4];
				ptr -= this.global1.data[17] - 15;
				ptr = ref this.global1.data[3];
				ptr -= this.global1.data[17] - 15;
				ptr = ref this.global1.data[2];
				ptr += this.global1.data[17] - 15;
				if (this.global1.allcountries[this.global1.data[0]].Vyshi)
				{
					if (this.global1.data[4] > 500)
					{
						ptr = ref this.global1.data[4];
						ptr -= 25;
						if (this.global1.data[0] == 4 && this.global1.data[11] == 3)
						{
							ptr = ref this.global1.data[4];
							ptr -= 5;
						}
					}
					else if (this.global1.data[4] > 300)
					{
						ptr = ref this.global1.data[4];
						ptr -= 5;
						if (this.global1.data[0] == 4 && this.global1.data[11] == 3)
						{
							ptr = ref this.global1.data[4];
							ref int ptr74 = ref ptr;
							num = ptr;
							ptr74 = num - 1;
						}
					}
					else
					{
						ptr = ref this.global1.data[4];
						ref int ptr75 = ref ptr;
						num = ptr;
						ptr75 = num - 1;
					}
					if (this.global1.data[22] > 0)
					{
						ptr = ref this.global1.data[22];
						ref int ptr76 = ref ptr;
						num = ptr;
						ptr76 = num - 1;
					}
					if (this.global1.data[1] < 500)
					{
						ptr = ref this.global1.data[1];
						ptr += 5;
					}
					ptr = ref this.global1.data[8];
					ptr += 20;
					if (this.global1.data[5] > 900)
					{
						ptr = ref this.global1.data[5];
						ptr -= 9;
					}
					else if (this.global1.data[5] > 700)
					{
						ptr = ref this.global1.data[5];
						ptr -= 6;
					}
					else if (this.global1.data[5] > 500)
					{
						ptr = ref this.global1.data[5];
						ptr -= 3;
					}
					else
					{
						ptr = ref this.global1.data[4];
						ref int ptr77 = ref ptr;
						num = ptr;
						ptr77 = num - 1;
					}
				}
				if (this.global1.data[16] < 12 || this.global1.data[21] > 1991)
				{
					ptr = ref this.global1.data[5];
					ptr -= this.global1.data[5] / 690 * (this.global1.data[5] / 60);
				}
				else
				{
					ptr = ref this.global1.data[5];
					ptr -= this.global1.data[5] / (690 - (this.global1.data[16] - 11) * 125) * (this.global1.data[5] / 60);
				}
				if (!this.global1.allcountries[this.global1.data[0]].Vyshi || this.global1.data[21] > 1991)
				{
					ptr = ref this.global1.data[22];
					ptr -= this.global1.data[22] / 700 * (this.global1.data[22] / 100);
				}
				else
				{
					ptr = ref this.global1.data[22];
					ptr -= this.global1.data[22] / 500 * (this.global1.data[22] / 100);
				}
				if (this.global1.event_done[5])
				{
					ptr = ref this.global1.data[3];
					ptr -= this.global1.data[3] / 700 * (this.global1.data[3] / 80);
					ptr = ref this.global1.data[4];
					ptr += (1000 - this.global1.data[4]) / 700 * ((1000 - this.global1.data[4]) / 80);
				}
				else if (this.global1.event_done[4])
				{
					ptr = ref this.global1.data[3];
					ptr -= this.global1.data[3] / 700 * (this.global1.data[3] / 160);
					ptr = ref this.global1.data[4];
					ptr += (1000 - this.global1.data[4]) / 700 * ((1000 - this.global1.data[4]) / 160);
				}
				ptr = ref this.global1.data[8];
				ptr -= this.global1.data[8] / 100 * (this.global1.data[8] / 100);
				ptr = ref this.global1.data[1];
				ptr -= this.global1.data[10] / 200;
				if (this.global1.data[3] > 300)
				{
					ptr = ref this.global1.data[3];
					ptr -= this.global1.data[10] / 300;
				}
				if (this.global1.data[4] < 700)
				{
					ptr = ref this.global1.data[4];
					ptr += this.global1.data[10] / 400;
				}
				if (this.global1.data[16] >= 12)
				{
					ptr = ref this.global1.data[8];
					ptr += this.global1.data[8] / 50;
				}
				if (this.global1.data[14] <= 0 && this.global1.data[18] > 18)
				{
					ptr = ref this.global1.data[33];
					ref int ptr78 = ref ptr;
					num = ptr;
					ptr78 = num + 1;
				}
				else if (this.global1.data[14] <= 1 && this.global1.data[18] > 19)
				{
					ptr = ref this.global1.data[33];
					ref int ptr79 = ref ptr;
					num = ptr;
					ptr79 = num + 1;
				}
				else if (this.global1.data[14] <= 2 && this.global1.data[18] > 20)
				{
					ptr = ref this.global1.data[33];
					ref int ptr80 = ref ptr;
					num = ptr;
					ptr80 = num + 1;
				}
				else if (this.global1.data[14] <= 3 && this.global1.data[18] > 21)
				{
					ptr = ref this.global1.data[33];
					ref int ptr81 = ref ptr;
					num = ptr;
					ptr81 = num + 1;
				}
				else if (this.global1.data[14] <= 4 && this.global1.data[18] > 22)
				{
					ptr = ref this.global1.data[33];
					ref int ptr82 = ref ptr;
					num = ptr;
					ptr82 = num + 1;
				}
				else if (this.global1.data[14] >= 5 && this.global1.data[18] < 23)
				{
					ptr = ref this.global1.data[33];
					ref int ptr83 = ref ptr;
					num = ptr;
					ptr83 = num - 1;
				}
				else if (this.global1.data[14] >= 4 && this.global1.data[18] < 22)
				{
					ptr = ref this.global1.data[33];
					ref int ptr84 = ref ptr;
					num = ptr;
					ptr84 = num - 1;
				}
				else if (this.global1.data[14] >= 3 && this.global1.data[18] < 21)
				{
					ptr = ref this.global1.data[33];
					ref int ptr85 = ref ptr;
					num = ptr;
					ptr85 = num - 1;
				}
				else if (this.global1.data[14] >= 1 && this.global1.data[18] < 20)
				{
					ptr = ref this.global1.data[33];
					ref int ptr86 = ref ptr;
					num = ptr;
					ptr86 = num - 1;
				}
				if (this.global1.data[15] <= 7 && this.global1.data[18] > 20)
				{
					ptr = ref this.global1.data[33];
					ref int ptr87 = ref ptr;
					num = ptr;
					ptr87 = num + 1;
				}
				else if (this.global1.data[15] <= 8 && this.global1.data[18] > 21)
				{
					ptr = ref this.global1.data[33];
					ref int ptr88 = ref ptr;
					num = ptr;
					ptr88 = num + 1;
				}
				else if (this.global1.data[15] >= 9 && this.global1.data[18] < 21)
				{
					ptr = ref this.global1.data[33];
					ref int ptr89 = ref ptr;
					num = ptr;
					ptr89 = num - 1;
				}
				else if (this.global1.data[15] >= 8 && this.global1.data[18] < 20)
				{
					ptr = ref this.global1.data[33];
					ref int ptr90 = ref ptr;
					num = ptr;
					ptr90 = num - 1;
				}
				if (this.global1.data[17] <= 14 && this.global1.data[18] > 19)
				{
					ptr = ref this.global1.data[33];
					ref int ptr91 = ref ptr;
					num = ptr;
					ptr91 = num + 1;
				}
				else if (this.global1.data[17] <= 15 && this.global1.data[18] > 20)
				{
					ptr = ref this.global1.data[33];
					ref int ptr92 = ref ptr;
					num = ptr;
					ptr92 = num + 1;
				}
				else if (this.global1.data[17] <= 16 && this.global1.data[18] > 21)
				{
					ptr = ref this.global1.data[33];
					ref int ptr93 = ref ptr;
					num = ptr;
					ptr93 = num + 1;
				}
				else if (this.global1.data[17] >= 17 && this.global1.data[18] < 22)
				{
					ptr = ref this.global1.data[33];
					ref int ptr94 = ref ptr;
					num = ptr;
					ptr94 = num - 1;
				}
				else if (this.global1.data[17] >= 16 && this.global1.data[18] < 20)
				{
					ptr = ref this.global1.data[33];
					ref int ptr95 = ref ptr;
					num = ptr;
					ptr95 = num - 1;
				}
				else if (this.global1.data[17] >= 15 && this.global1.data[18] < 19)
				{
					ptr = ref this.global1.data[33];
					ref int ptr96 = ref ptr;
					num = ptr;
					ptr96 = num - 1;
				}
				if (this.global1.data[0] == 1 && this.global1.data[10] < 30 - this.global1.data[14] - this.global1.data[14])
				{
					ptr = ref this.global1.data[10];
					ref int ptr97 = ref ptr;
					num = ptr;
					ptr97 = num + 1;
				}
				bool[][] array2 = new bool[this.global1.regions.Length][];
				for (int num58 = 0; num58 < array2.Length; num58 = num + 1)
				{
					array2[num58] = new bool[3];
					num = num58;
				}
				if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
				{
					for (int num59 = 0; num59 < this.yug1.gameState.yugregions.Length; num59 = num + 1)
					{
						if (this.yug1.gameState.yugregions[num59].owner == this.yug1.gameState.player)
						{
							if (this.yug1.gameState.yugregions[num59].level <= 0)
							{
								array2[this.yug1.gameState.yugregions[num59].inreg][0] = true;
							}
							else if (this.yug1.gameState.yugregions[num59].level <= 5)
							{
								array2[this.yug1.gameState.yugregions[num59].inreg][1] = true;
							}
							else if (this.yug1.gameState.yugregions[num59].level <= 10)
							{
								array2[this.yug1.gameState.yugregions[num59].inreg][2] = true;
							}
						}
						num = num59;
					}
				}
				for (int num60 = 0; num60 < this.global1.regions.Length; num60 = num + 1)
				{
					for (int num61 = 0; num61 < 15; num61 = num + 1)
					{
						if (this.global1.data[0] < 49 || this.global1.data[0] > 51 || num60 == 2 || (array2[num60][0] && num61 < 5) || (array2[num60][1] && num61 < 10) || (array2[num60][2] && num61 < 15))
						{
							if (this.global1.regions[num60].buildings[num61].type == 1 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[8];
								ref int ptr98 = ref ptr;
								num = ptr;
								ptr98 = num + 1;
								ptr = ref this.global1.data[5];
								ref int ptr99 = ref ptr;
								num = ptr;
								ptr99 = num + 1;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 2 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[8];
								ptr += 2;
								ptr = ref this.global1.data[4];
								ref int ptr100 = ref ptr;
								num = ptr;
								ptr100 = num + 1;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 3 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								if (this.global1.science[9] && this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
								{
									ptr = ref this.global1.data[8];
									ptr -= 3;
								}
								else
								{
									ptr = ref this.global1.data[8];
									ptr -= 2;
								}
								if (this.global1.science[2] && this.global1.science[5] && this.global1.science[8])
								{
									ptr = ref this.global1.data[4];
									ptr -= 2;
								}
								else
								{
									ptr = ref this.global1.data[4];
									ref int ptr101 = ref ptr;
									num = ptr;
									ptr101 = num - 1;
								}
								if (this.global1.science[9] && this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
								{
									ptr = ref this.global1.data[5];
									ptr += 2;
								}
								else
								{
									ptr = ref this.global1.data[5];
									ref int ptr102 = ref ptr;
									num = ptr;
									ptr102 = num + 1;
								}
							}
							else if (this.global1.regions[num60].buildings[num61].type == 4 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[8];
								ptr -= 2;
								ptr = ref this.global1.data[4];
								ptr -= 2;
								ptr = ref this.global1.data[9];
								ptr += 2;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 5 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[4];
								ptr += 2;
								ptr = ref this.global1.data[3];
								ptr += 2;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 6 && this.global1.data[19] == 1 && this.global1.data[20] % 2 == 0 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[8];
								ref int ptr103 = ref ptr;
								num = ptr;
								ptr103 = num + 1;
								ptr = ref this.global1.data[4];
								ref int ptr104 = ref ptr;
								num = ptr;
								ptr104 = num + 1;
								if (this.global1.data[16] < 12)
								{
									this.global1.regions[num60].buildings[num61].is_working = false;
								}
								else
								{
									this.global1.regions[num60].buildings[num61].is_working = true;
								}
							}
							else if (this.global1.regions[num60].buildings[num61].type == 7 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[1];
								ref int ptr105 = ref ptr;
								num = ptr;
								ptr105 = num + 1;
								ptr = ref this.global1.data[3];
								ref int ptr106 = ref ptr;
								num = ptr;
								ptr106 = num + 1;
								ptr = ref this.global1.data[10];
								ptr += 2;
								ptr = ref this.global1.data[2];
								ptr -= 2;
								if (this.global1.regions[num60].buildings[num61].is_private)
								{
									this.global1.regions[num60].buildings[num61].is_private = false;
								}
							}
							else if (this.global1.regions[num60].buildings[num61].type == 8 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[8];
								ptr -= 2;
								ptr = ref this.global1.data[4];
								ptr -= 2;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 9 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[8];
								ref int ptr107 = ref ptr;
								num = ptr;
								ptr107 = num - 1;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 10 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[8];
								ptr -= 2;
								ptr = ref this.global1.data[9];
								ptr += 2;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 11 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[8];
								ptr -= 2;
								ptr = ref this.global1.data[3];
								ptr += 2;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 12 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[4];
								ptr -= 2;
								ptr = ref this.global1.data[9];
								ptr += 2;
								ptr = ref this.global1.data[2];
								ref int ptr108 = ref ptr;
								num = ptr;
								ptr108 = num - 1;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 13 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[1];
								ptr += 4;
								ptr = ref this.global1.data[3];
								ptr += (this.global1.data[1] - 500) / 250;
								ptr = ref this.global1.data[4];
								ptr -= (this.global1.data[1] - 500) / 250;
								ptr = ref this.global1.data[8];
								ref int ptr109 = ref ptr;
								num = ptr;
								ptr109 = num + 1;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 14 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[22];
								ptr += 2;
								ptr = ref this.global1.data[1];
								ptr += 4;
								ptr = ref this.global1.data[10];
								ref int ptr110 = ref ptr;
								num = ptr;
								ptr110 = num + 1;
								ptr = ref this.global1.data[2];
								ref int ptr111 = ref ptr;
								num = ptr;
								ptr111 = num - 1;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 15 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[8];
								ptr += 3;
								ptr = ref this.global1.data[5];
								ptr += 2;
								ptr = ref this.global1.data[3];
								ref int ptr112 = ref ptr;
								int num41 = ptr;
								ptr112 = num41 - 1;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 16 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[8];
								ptr += 2;
								ptr = ref this.global1.data[3];
								ref int ptr113 = ref ptr;
								num = ptr;
								ptr113 = num - 1;
								ptr = ref this.global1.data[5];
								ref int ptr114 = ref ptr;
								num = ptr;
								ptr114 = num + 1;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 18 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[8];
								ptr += 3;
								ptr = ref this.global1.data[3];
								ref int ptr115 = ref ptr;
								num = ptr;
								ptr115 = num + 1;
								ptr = ref this.global1.data[10];
								ref int ptr116 = ref ptr;
								num = ptr;
								ptr116 = num - 1;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 19 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[1];
								ptr += 3;
								ptr = ref this.global1.data[22];
								ref int ptr117 = ref ptr;
								num = ptr;
								ptr117 = num + 1;
								ptr = ref this.global1.data[4];
								ptr += 3;
								ptr = ref this.global1.data[2];
								ref int ptr118 = ref ptr;
								num = ptr;
								ptr118 = num + 1;
								ptr = ref this.global1.data[10];
								ref int ptr119 = ref ptr;
								num = ptr;
								ptr119 = num - 1;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 20 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[3];
								ptr += 2;
								ptr = ref this.global1.data[4];
								ptr -= 2;
								ptr = ref this.global1.data[5];
								ref int ptr120 = ref ptr;
								num = ptr;
								ptr120 = num + 1;
								ptr = ref this.global1.data[8];
								ptr -= 3;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 22 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[3];
								ptr += 2;
								ptr = ref this.global1.data[4];
								ptr -= 2;
								ptr = ref this.global1.data[8];
								ref int ptr121 = ref ptr;
								num = ptr;
								ptr121 = num - 1;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 24 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[9];
								ptr += 5;
								ptr = ref this.global1.data[3];
								ptr += 2;
								ptr = ref this.global1.data[1];
								ptr += 4;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 23 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								if (!this.global1.allcountries[7].Vyshi)
								{
									ptr = ref this.global1.data[9];
									ptr += 2;
									ptr = ref this.global1.data[10];
									ptr -= 4;
									ptr = ref this.global1.data[22];
									ptr -= 2;
								}
								else
								{
									ptr = ref this.global1.data[8];
									ref int ptr122 = ref ptr;
									num = ptr;
									ptr122 = num - 1;
								}
								ptr = ref this.global1.data[2];
								ptr += 4;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 25 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[4];
								ref int ptr123 = ref ptr;
								int num41 = ptr;
								ptr123 = num41 + 1;
								ptr = ref this.global1.data[6];
								ref int ptr124 = ref ptr;
								num41 = ptr;
								ptr124 = num41 - 1;
								ptr = ref this.global1.data[3];
								ref int ptr125 = ref ptr;
								num41 = ptr;
								ptr125 = num41 - 1;
								ptr = ref this.global1.data[31];
								ref int ptr126 = ref ptr;
								num41 = ptr;
								ptr126 = num41 + 1;
								ptr = ref this.global1.data[5];
								ref int ptr127 = ref ptr;
								num41 = ptr;
								ptr127 = num41 + 1;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 26 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[4];
								ref int ptr128 = ref ptr;
								int num41 = ptr;
								ptr128 = num41 + 1;
								if ((this.global1.data[118] == 1 && this.global1.data[0] == 51) || this.global1.data[120] == 1)
								{
									ptr = ref this.global1.data[3];
									ptr += 2;
								}
								else
								{
									ptr = ref this.global1.data[3];
									ref int ptr129 = ref ptr;
									num41 = ptr;
									ptr129 = num41 - 1;
									ptr = ref this.global1.data[1];
									ref int ptr130 = ref ptr;
									num41 = ptr;
									ptr130 = num41 - 1;
								}
							}
							else if (this.global1.regions[num60].buildings[num61].type == 27 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								int num41;
								if (this.global1.data[118] == 1 && this.global1.data[0] == 51)
								{
									ptr = ref this.global1.data[3];
									ptr -= 2;
									ptr = ref this.global1.data[1];
									ptr -= 2;
									ptr = ref this.global1.data[9];
									ref int ptr131 = ref ptr;
									num41 = ptr;
									ptr131 = num41 - 1;
								}
								else
								{
									ptr = ref this.global1.data[3];
									ref int ptr132 = ref ptr;
									num41 = ptr;
									ptr132 = num41 + 1;
									ptr = ref this.global1.data[1];
									ref int ptr133 = ref ptr;
									num41 = ptr;
									ptr133 = num41 + 1;
									ptr = ref this.global1.data[4];
									ref int ptr134 = ref ptr;
									num41 = ptr;
									ptr134 = num41 - 1;
								}
								ptr = ref this.global1.data[31];
								ref int ptr135 = ref ptr;
								num41 = ptr;
								ptr135 = num41 + 1;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 28 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[4];
								ref int ptr136 = ref ptr;
								int num41 = ptr;
								ptr136 = num41 + 1;
								ptr = ref this.global1.data[6];
								ref int ptr137 = ref ptr;
								num41 = ptr;
								ptr137 = num41 + 1;
								ptr = ref this.global1.data[3];
								ref int ptr138 = ref ptr;
								num41 = ptr;
								ptr138 = num41 - 1;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 29 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								if (this.global1.data[140] >= 1)
								{
									ptr = ref this.global1.data[3];
									ptr -= 2;
									ptr = ref this.global1.data[4];
									ref int ptr139 = ref ptr;
									int num41 = ptr;
									ptr139 = num41 + 1;
									ptr = ref this.global1.data[9];
									ref int ptr140 = ref ptr;
									num41 = ptr;
									ptr140 = num41 - 1;
								}
								else
								{
									ptr = ref this.global1.data[3];
									ptr += 2;
								}
							}
							else if (this.global1.regions[num60].buildings[num61].type == 30 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[8];
								ptr += 3;
								ptr = ref this.global1.data[5];
								ref int ptr141 = ref ptr;
								int num41 = ptr;
								ptr141 = num41 - 1;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 31 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[5];
								ref int ptr142 = ref ptr;
								int num41 = ptr;
								ptr142 = num41 + 1;
								if (this.global1.data[141] >= 1)
								{
									ptr = ref this.global1.data[3];
									ptr -= 2;
									ptr = ref this.global1.data[4];
									ref int ptr143 = ref ptr;
									num41 = ptr;
									ptr143 = num41 + 1;
									ptr = ref this.global1.data[9];
									ref int ptr144 = ref ptr;
									num41 = ptr;
									ptr144 = num41 - 1;
								}
								else
								{
									ptr = ref this.global1.data[3];
									ref int ptr145 = ref ptr;
									num41 = ptr;
									ptr145 = num41 + 1;
									ptr = ref this.global1.data[1];
									ref int ptr146 = ref ptr;
									num41 = ptr;
									ptr146 = num41 + 1;
									ptr = ref this.global1.data[4];
									ref int ptr147 = ref ptr;
									num41 = ptr;
									ptr147 = num41 - 1;
								}
							}
							else if (this.global1.regions[num60].buildings[num61].type == 32 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[9];
								ptr += 3;
								ptr = ref this.global1.data[4];
								ref int ptr148 = ref ptr;
								int num41 = ptr;
								ptr148 = num41 - 1;
								ptr = ref this.global1.data[8];
								ref int ptr149 = ref ptr;
								num41 = ptr;
								ptr149 = num41 - 1;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 33 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								int num41;
								if (this.global1.data[148] == 1 && this.global1.data[0] == 49)
								{
									ptr = ref this.global1.data[1];
									ptr -= 2;
									ptr = ref this.global1.data[3];
									ref int ptr150 = ref ptr;
									num41 = ptr;
									ptr150 = num41 - 1;
								}
								else
								{
									ptr = ref this.global1.data[1];
									ptr += 2;
									ptr = ref this.global1.data[3];
									ref int ptr151 = ref ptr;
									num41 = ptr;
									ptr151 = num41 + 1;
								}
								ptr = ref this.global1.data[4];
								ref int ptr152 = ref ptr;
								num41 = ptr;
								ptr152 = num41 - 1;
								ptr = ref this.global1.data[8];
								ref int ptr153 = ref ptr;
								num41 = ptr;
								ptr153 = num41 + 1;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 34 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[3];
								ptr += 2;
								ptr = ref this.global1.data[5];
								ref int ptr154 = ref ptr;
								int num41 = ptr;
								ptr154 = num41 + 1;
								if (this.global1.data[179] == 0)
								{
									ptr = ref this.global1.data[6];
									ref int ptr155 = ref ptr;
									num41 = ptr;
									ptr155 = num41 + 1;
								}
							}
							else if (this.global1.regions[num60].buildings[num61].type == 35 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[3];
								ptr += 2;
								int num41;
								if (this.global1.data[115] <= 8)
								{
									ptr = ref this.global1.data[6];
									ref int ptr156 = ref ptr;
									num41 = ptr;
									ptr156 = num41 + 1;
								}
								ptr = ref this.global1.data[31];
								ref int ptr157 = ref ptr;
								num41 = ptr;
								ptr157 = num41 - 1;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 36 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								ptr = ref this.global1.data[3];
								ptr += 2;
								ptr = ref this.global1.data[4];
								ref int ptr158 = ref ptr;
								int num41 = ptr;
								ptr158 = num41 - 1;
								ptr = ref this.global1.data[31];
								ref int ptr159 = ref ptr;
								num41 = ptr;
								ptr159 = num41 + 1;
							}
							else if (this.global1.regions[num60].buildings[num61].type == 37 && this.global1.regions[num60].buildings[num61].is_builded && this.global1.regions[num60].buildings[num61].is_working)
							{
								if (this.global1.data[160] == 1)
								{
									ptr = ref this.global1.data[4];
									ref int ptr160 = ref ptr;
									int num41 = ptr;
									ptr160 = num41 + 1;
								}
								else if (this.global1.data[160] == 2)
								{
									ptr = ref this.global1.data[4];
									ref int ptr161 = ref ptr;
									int num41 = ptr;
									ptr161 = num41 + 1;
									ptr = ref this.global1.data[1];
									ref int ptr162 = ref ptr;
									num41 = ptr;
									ptr162 = num41 + 1;
								}
								else
								{
									ptr = ref this.global1.data[4];
									ref int ptr163 = ref ptr;
									int num41 = ptr;
									ptr163 = num41 - 1;
								}
							}
						}
						num = num61;
					}
					num = num60;
				}
				Debug.Log("BUILDINGSDONE");
				if (this.global1.data[31] > 700)
				{
					ptr = ref this.global1.data[4];
					ptr -= (this.global1.data[31] - 500) / 100;
					ptr = ref this.global1.data[1];
					ptr += (this.global1.data[31] - 500) / 100;
					ptr = ref this.global1.data[22];
					ptr += (this.global1.data[31] - 500) / 50;
					ptr = ref this.global1.data[2];
					ptr -= (this.global1.data[31] - 500) / 100;
					ptr = ref this.global1.data[10];
					ptr += (this.global1.data[31] - 500) / 100;
				}
				else if (this.global1.data[31] < 400)
				{
					ptr = ref this.global1.data[4];
					ptr += (500 - this.global1.data[31]) / 100;
					ptr = ref this.global1.data[1];
					ptr += (500 - this.global1.data[31]) / 100;
					ptr = ref this.global1.data[22];
					ptr -= (500 - this.global1.data[31]) / 50;
					ptr = ref this.global1.data[10];
					ptr -= (500 - this.global1.data[31]) / 100;
				}
				ptr = ref this.global1.data[2];
				ptr += this.global1.data[27];
				ptr = ref this.global1.data[3];
				ptr += this.global1.data[27];
				ptr = ref this.global1.data[4];
				ptr += this.global1.data[27];
				ptr = ref this.global1.data[8];
				ptr += this.global1.data[28];
				ptr = ref this.global1.data[4];
				ptr -= this.global1.data[29];
				if (this.global1.data[26] - this.global1.data[34] > 0)
				{
					if (this.global1.data[34] >= 0)
					{
						ptr = ref this.global1.data[26];
						ptr -= this.global1.data[34];
					}
					ptr = ref this.global1.data[8];
					ptr += this.global1.data[34];
				}
				else if (this.global1.data[26] > 0)
				{
					ptr = ref this.global1.data[8];
					ptr += this.global1.data[26];
					this.global1.data[26] = 0;
				}
				if (this.global1.data[25] < 4)
				{
					ptr = ref this.global1.data[4];
					ptr += -4 + this.global1.data[25];
					ptr = ref this.global1.data[22];
					ptr += 4 - this.global1.data[25];
					ptr = ref this.global1.data[5];
					ptr += -4 + this.global1.data[25];
					ptr = ref this.global1.data[9];
					ptr += -4 + this.global1.data[25];
				}
				else if (this.global1.data[25] > 8)
				{
					ptr = ref this.global1.data[4];
					ptr += this.global1.data[25] - 8;
					ptr = ref this.global1.data[22];
					ptr += 8 - this.global1.data[25];
					ptr = ref this.global1.data[5];
					ptr += this.global1.data[25] - 8;
				}
				ptr = ref this.global1.data[8];
				ptr += (this.global1.data[23] - this.global1.data[24]) / 2;
				ptr = ref this.global1.data[3];
				ptr += (this.global1.data[23] - this.global1.data[24]) / 3;
				if (this.global1.data[23] <= this.global1.data[24])
				{
					ptr = ref this.global1.data[5];
					ptr += (this.global1.data[23] - this.global1.data[24]) / 4;
				}
				if (this.global1.data[0] == 1)
				{
					if (this.global1.data[11] == 0)
					{
						if (this.global1.data[14] < 3)
						{
							if (this.global1.data[33] < 900)
							{
								ptr = ref this.global1.data[33];
								ptr += 2;
							}
							else
							{
								ptr = ref this.global1.data[33];
								ref int ptr164 = ref ptr;
								num = ptr;
								ptr164 = num - 1;
							}
						}
						ptr = ref this.global1.data[4];
						ref int ptr165 = ref ptr;
						num = ptr;
						ptr165 = num + 1;
						ptr = ref this.global1.data[1];
						ref int ptr166 = ref ptr;
						num = ptr;
						ptr166 = num + 1;
						ptr = ref this.global1.data[2];
						ptr -= 2;
						if (this.global1.data[6] < 900)
						{
							ptr = ref this.global1.data[6];
							ref int ptr167 = ref ptr;
							num = ptr;
							ptr167 = num + 1;
						}
						ptr = ref this.global1.data[10];
						ref int ptr168 = ref ptr;
						num = ptr;
						ptr168 = num + 1;
						if (this.global1.data[31] > 500)
						{
							ptr = ref this.global1.data[31];
							ref int ptr169 = ref ptr;
							num = ptr;
							ptr169 = num - 1;
						}
					}
					else if (this.global1.data[11] == 1)
					{
						if (this.global1.data[33] < 900)
						{
							ptr = ref this.global1.data[33];
							ptr += 2;
						}
						else
						{
							ptr = ref this.global1.data[33];
							ref int ptr170 = ref ptr;
							num = ptr;
							ptr170 = num + 1;
						}
						ptr = ref this.global1.data[9];
						ref int ptr171 = ref ptr;
						num = ptr;
						ptr171 = num + 1;
						ptr = ref this.global1.data[2];
						ptr -= 12;
						ptr = ref this.global1.data[1];
						ptr -= 8;
						ptr = ref this.global1.data[4];
						ptr -= 8;
						ptr = ref this.global1.data[3];
						ptr -= 4;
						if (this.global1.data[31] < 650)
						{
							ptr = ref this.global1.data[31];
							ref int ptr172 = ref ptr;
							num = ptr;
							ptr172 = num + 1;
						}
					}
					else if (this.global1.data[11] == 2)
					{
						if (this.global1.data[33] > 600)
						{
							ptr = ref this.global1.data[33];
							ptr -= 2;
						}
						else
						{
							ptr = ref this.global1.data[33];
							ref int ptr173 = ref ptr;
							num = ptr;
							ptr173 = num + 1;
						}
						ptr = ref this.global1.data[2];
						ptr += 4;
						ptr = ref this.global1.data[3];
						ptr += 2;
						ptr = ref this.global1.data[4];
						ptr += 4;
						ptr = ref this.global1.data[1];
						ptr -= 10;
						if (this.global1.data[31] > 300)
						{
							ptr = ref this.global1.data[31];
							ref int ptr174 = ref ptr;
							num = ptr;
							ptr174 = num - 1;
						}
					}
					else if (this.global1.data[11] == 3)
					{
						if (this.global1.data[33] > 600)
						{
							ptr = ref this.global1.data[33];
							ptr -= 4;
						}
						else
						{
							ptr = ref this.global1.data[33];
							ptr -= 2;
						}
						ptr = ref this.global1.data[2];
						ptr += 6;
						ptr = ref this.global1.data[3];
						ptr += 6;
						ptr = ref this.global1.data[1];
						ptr += 6;
						ptr = ref this.global1.data[4];
						ptr += 12;
						ptr = ref this.global1.data[10];
						ref int ptr175 = ref ptr;
						num = ptr;
						ptr175 = num - 1;
						ptr = ref this.global1.data[31];
						ref int ptr176 = ref ptr;
						num = ptr;
						ptr176 = num - 1;
						if (this.global1.data[6] >= 400 && this.global1.data[21] <= 1991)
						{
							ptr = ref this.global1.data[6];
							ref int ptr177 = ref ptr;
							num = ptr;
							ptr177 = num - 1;
						}
					}
					if (this.global1.data[12] == 4)
					{
						if (this.global1.data[11] > 1)
						{
							ptr = ref this.global1.data[33];
							ptr += 2;
						}
						ptr = ref this.global1.data[4];
						ptr += 4;
						ptr = ref this.global1.data[1];
						ptr += 4;
						ptr = ref this.global1.data[2];
						ptr -= 4;
						if (this.global1.data[22] < 700)
						{
							ptr = ref this.global1.data[22];
							ptr += 2;
						}
						ptr = ref this.global1.data[8];
						ptr += 2;
						ptr = ref this.global1.data[5];
						ref int ptr178 = ref ptr;
						num = ptr;
						ptr178 = num - 1;
						ptr = ref this.global1.data[9];
						ref int ptr179 = ref ptr;
						num = ptr;
						ptr179 = num + 1;
						ptr = ref this.global1.data[3];
						ptr -= 4;
					}
					else if (this.global1.data[12] == 5)
					{
						if (this.global1.data[33] > 600)
						{
							ptr = ref this.global1.data[33];
							ptr -= 2;
						}
						else
						{
							ptr = ref this.global1.data[33];
							ref int ptr180 = ref ptr;
							num = ptr;
							ptr180 = num + 1;
						}
						if (this.global1.data[5] < 650)
						{
							ptr = ref this.global1.data[5];
							ref int ptr181 = ref ptr;
							num = ptr;
							ptr181 = num + 1;
						}
						ptr = ref this.global1.data[2];
						ptr -= 2;
						ptr = ref this.global1.data[4];
						ptr += 4;
						ptr = ref this.global1.data[8];
						ref int ptr182 = ref ptr;
						num = ptr;
						ptr182 = num + 1;
					}
					else if (this.global1.data[12] == 6)
					{
						if (this.global1.data[33] > 600)
						{
							ptr = ref this.global1.data[33];
							ptr -= 4;
						}
						else
						{
							ptr = ref this.global1.data[33];
							ptr -= 2;
						}
						ptr = ref this.global1.data[2];
						ptr += 4;
						ptr = ref this.global1.data[3];
						ptr += 4;
						ptr = ref this.global1.data[4];
						ptr += 12;
						ptr = ref this.global1.data[10];
						ref int ptr183 = ref ptr;
						num = ptr;
						ptr183 = num - 1;
						ptr = ref this.global1.data[31];
						ref int ptr184 = ref ptr;
						num = ptr;
						ptr184 = num - 1;
						if (this.global1.data[6] >= 400 && this.global1.data[21] <= 1991)
						{
							ptr = ref this.global1.data[6];
							ref int ptr185 = ref ptr;
							num = ptr;
							ptr185 = num - 1;
						}
					}
					if (this.global1.data[13] == 7)
					{
						if (this.global1.data[11] > 1)
						{
							ptr = ref this.global1.data[33];
							ptr += 2;
						}
						ptr = ref this.global1.data[4];
						ptr += 4;
						ptr = ref this.global1.data[1];
						ptr += 8;
						ptr = ref this.global1.data[2];
						ptr -= 2;
						if (this.global1.data[22] < 700)
						{
							ptr = ref this.global1.data[22];
							ptr += 4;
						}
						ptr = ref this.global1.data[5];
						ref int ptr186 = ref ptr;
						num = ptr;
						ptr186 = num - 1;
						ptr = ref this.global1.data[9];
						ref int ptr187 = ref ptr;
						num = ptr;
						ptr187 = num + 1;
						if (this.global1.data[31] < 650)
						{
							ptr = ref this.global1.data[31];
							ref int ptr188 = ref ptr;
							num = ptr;
							ptr188 = num + 1;
						}
						ptr = ref this.global1.data[3];
						ptr -= 4;
					}
					else if (this.global1.data[13] == 8)
					{
						if (!this.global1.science[4] && this.global1.data[5] < 500)
						{
							ptr = ref this.global1.data[5];
							ref int ptr189 = ref ptr;
							num = ptr;
							ptr189 = num + 1;
						}
						else if (!this.global1.science[5] && this.global1.data[5] < 600)
						{
							ptr = ref this.global1.data[5];
							ref int ptr190 = ref ptr;
							num = ptr;
							ptr190 = num + 1;
						}
						else if (this.global1.data[5] < 700)
						{
							ptr = ref this.global1.data[5];
							ref int ptr191 = ref ptr;
							num = ptr;
							ptr191 = num + 1;
						}
						ptr = ref this.global1.data[2];
						ptr -= 2;
						ptr = ref this.global1.data[1];
						ptr -= 12;
						ptr = ref this.global1.data[8];
						ptr += 1 + this.global1.data[43];
						ptr = ref this.global1.data[4];
						ptr -= 2;
					}
					else if (this.global1.data[13] == 9)
					{
						if (this.global1.data[33] > 500)
						{
							ptr = ref this.global1.data[33];
							ref int ptr192 = ref ptr;
							num = ptr;
							ptr192 = num - 1;
						}
						else if (this.global1.data[33] > 400)
						{
							ptr = ref this.global1.data[33];
							ptr -= 2;
						}
						ptr = ref this.global1.data[2];
						ptr += 3;
						ptr = ref this.global1.data[10];
						ptr -= 2;
						ptr = ref this.global1.data[1];
						ptr += 2;
						ptr = ref this.global1.data[3];
						ptr -= 2;
						ptr = ref this.global1.data[4];
						ptr += 2;
					}
				}
				else if (this.global1.data[0] == 12)
				{
					this.global1.data[10] = -1000;
					if (!this.global1.event_done[230])
					{
						this.global1.is_elect = true;
					}
					if (this.global1.data[90] != 1)
					{
						ptr = ref this.global1.data[5];
						ptr -= 2;
						ptr = ref this.global1.data[4];
						ref int ptr193 = ref ptr;
						num = ptr;
						ptr193 = num + 1;
						ptr = ref this.global1.data[3];
						ref int ptr194 = ref ptr;
						num = ptr;
						ptr194 = num - 1;
					}
					if (this.global1.data[93] != 1)
					{
						ptr = ref this.global1.data[8];
						ptr -= 2;
						ptr = ref this.global1.data[4];
						ref int ptr195 = ref ptr;
						num = ptr;
						ptr195 = num + 1;
						ptr = ref this.global1.data[3];
						ref int ptr196 = ref ptr;
						num = ptr;
						ptr196 = num - 1;
					}
					if (this.global1.data[92] != 1)
					{
						ptr = ref this.global1.data[9];
						ptr -= 2;
						ptr = ref this.global1.data[3];
						ref int ptr197 = ref ptr;
						num = ptr;
						ptr197 = num + 1;
						ptr = ref this.global1.data[4];
						ref int ptr198 = ref ptr;
						num = ptr;
						ptr198 = num - 1;
					}
					if (this.global1.data[94] != 1)
					{
						ptr = ref this.global1.data[8];
						ref int ptr199 = ref ptr;
						num = ptr;
						ptr199 = num - 1;
						ptr = ref this.global1.data[4];
						ref int ptr200 = ref ptr;
						num = ptr;
						ptr200 = num + 1;
						ptr = ref this.global1.data[3];
						ref int ptr201 = ref ptr;
						num = ptr;
						ptr201 = num - 1;
					}
					if (this.global1.data[88] > 0)
					{
						if (this.global1.data[81] == 1)
						{
							ptr = ref this.global1.data[108];
							ptr -= 7;
						}
						else if (this.global1.data[81] != 1)
						{
							ptr = ref this.global1.data[108];
							ptr -= 5;
						}
						if (this.global1.data[107] == 1)
						{
							ptr = ref this.global1.data[108];
							ref int ptr202 = ref ptr;
							num = ptr;
							ptr202 = num - 1;
						}
						else if (this.global1.data[107] == 3)
						{
							ptr = ref this.global1.data[108];
							ref int ptr203 = ref ptr;
							num = ptr;
							ptr203 = num + 1;
						}
					}
					if (this.global1.data[91] == 1)
					{
						ptr = ref this.global1.data[1];
						ptr -= 10;
					}
					if (this.global1.allcountries[7].Vyshi)
					{
						ptr = ref this.global1.data[5];
						ptr -= this.global1.data[5] / 100;
						ptr = ref this.global1.data[4];
						ptr += 6;
					}
					else if (this.global1.data[5] < 100)
					{
						ptr = ref this.global1.data[5];
						ptr += 10;
					}
					else if (this.global1.data[5] < 200)
					{
						ptr = ref this.global1.data[5];
						ptr += 5;
					}
					if (this.global1.data[11] == 0)
					{
						ptr = ref this.global1.data[9];
						ptr += 2;
						ptr = ref this.global1.data[1];
						ptr += 3;
						ptr = ref this.global1.data[4];
						ptr += 2;
						ptr = ref this.global1.data[3];
						ptr += 3;
						ptr = ref this.global1.data[2];
						ptr -= 2;
					}
					else if (this.global1.data[11] == 1)
					{
						ptr = ref this.global1.data[9];
						ptr += 2;
						ptr = ref this.global1.data[1];
						ptr -= 4;
						ptr = ref this.global1.data[4];
						ptr -= 4;
						ptr = ref this.global1.data[6];
						ptr += 2;
						ptr = ref this.global1.data[2];
						ptr -= 4;
					}
					else if (this.global1.data[11] == 2)
					{
						ptr = ref this.global1.data[1];
						ptr += 3;
						ptr = ref this.global1.data[3];
						ptr += 3;
						ptr = ref this.global1.data[4];
						ptr -= 2;
					}
					else if (this.global1.data[11] == 3)
					{
						ptr = ref this.global1.data[3];
						ref int ptr204 = ref ptr;
						num = ptr;
						ptr204 = num + 1;
						ptr = ref this.global1.data[2];
						ptr += 4;
						if (this.global1.data[6] > 400)
						{
							ptr = ref this.global1.data[6];
							ptr -= 2;
						}
					}
					if (this.global1.data[12] == 4)
					{
						ptr = ref this.global1.data[1];
						ptr -= 5;
						ptr = ref this.global1.data[4];
						ptr -= 3;
					}
					else if (this.global1.data[12] == 5)
					{
						ptr = ref this.global1.data[5];
						ptr += 2;
					}
					else if (this.global1.data[12] == 6)
					{
						ptr = ref this.global1.data[1];
						ref int ptr205 = ref ptr;
						int num41 = ptr;
						ptr205 = num41 + 1;
						ptr = ref this.global1.data[2];
						ptr += 2;
						ptr = ref this.global1.data[4];
						ptr += 2;
						ptr = ref this.global1.data[10];
						ref int ptr206 = ref ptr;
						num41 = ptr;
						ptr206 = num41 - 1;
					}
					if (this.global1.data[13] == 7)
					{
						ptr = ref this.global1.data[1];
						ptr += 6;
						ptr = ref this.global1.data[4];
						ptr += 2;
					}
					else if (this.global1.data[13] == 8)
					{
						ptr = ref this.global1.data[9];
						ptr += 3;
						ptr = ref this.global1.data[4];
						ptr += 5;
						ptr = ref this.global1.data[1];
						ptr += 3;
					}
					else if (this.global1.data[13] == 9)
					{
						ptr = ref this.global1.data[1];
						ptr -= 5;
						ptr = ref this.global1.data[4];
						ptr -= 3;
						ptr = ref this.global1.data[3];
						ptr += 4;
					}
					if (this.global1.data[80] - 20 < 80)
					{
						int num62 = (80 - (this.global1.data[80] - 20)) / 20;
						if (this.global1.data[1] > 1000 - num62 * 100)
						{
							this.global1.data[1] = 1000 - num62 * 100;
						}
						if (this.global1.data[3] > 1000 - num62 * 100)
						{
							this.global1.data[3] = 1000 - num62 * 100;
						}
						if (this.global1.data[5] > 1000 - num62 * 100)
						{
							this.global1.data[5] = 1000 - num62 * 100;
						}
						if (this.global1.data[4] < num62 * 150)
						{
							this.global1.data[4] = num62 * 150;
						}
					}
				}
				else if (this.global1.data[0] == 5)
				{
					if (this.global1.data[11] == 0)
					{
						if (this.global1.data[14] <= 3)
						{
							if (this.global1.data[33] < 1000)
							{
								ptr = ref this.global1.data[33];
								ptr += 2;
							}
						}
						else if (this.global1.data[33] < 900)
						{
							ptr = ref this.global1.data[33];
							ref int ptr207 = ref ptr;
							num = ptr;
							ptr207 = num + 1;
						}
						ptr = ref this.global1.data[4];
						ptr += 2;
						ptr = ref this.global1.data[1];
						ptr += 5;
						ptr = ref this.global1.data[2];
						ptr -= 2;
						if (this.global1.data[6] < 900)
						{
							ptr = ref this.global1.data[6];
							ref int ptr208 = ref ptr;
							num = ptr;
							ptr208 = num + 1;
						}
						ptr = ref this.global1.data[10];
						ref int ptr209 = ref ptr;
						num = ptr;
						ptr209 = num + 1;
						if (this.global1.data[31] > 700)
						{
							ptr = ref this.global1.data[31];
							ref int ptr210 = ref ptr;
							num = ptr;
							ptr210 = num - 1;
						}
						else if (this.global1.data[31] < 700)
						{
							ptr = ref this.global1.data[31];
							ref int ptr211 = ref ptr;
							num = ptr;
							ptr211 = num + 1;
						}
						ptr = ref this.global1.data[9];
						ref int ptr212 = ref ptr;
						num = ptr;
						ptr212 = num + 1;
						ptr = ref this.global1.data[3];
						ptr += 2;
					}
					else if (this.global1.data[11] == 1)
					{
						if (this.global1.data[33] < 900)
						{
							ptr = ref this.global1.data[33];
							ptr += 2;
						}
						ptr = ref this.global1.data[9];
						ref int ptr213 = ref ptr;
						num = ptr;
						ptr213 = num + 1;
						ptr = ref this.global1.data[2];
						ptr -= 2;
						ptr = ref this.global1.data[4];
						ptr -= 2;
						ptr = ref this.global1.data[3];
						ptr -= 6;
						if (this.global1.data[31] < 600)
						{
							ptr = ref this.global1.data[31];
							ref int ptr214 = ref ptr;
							num = ptr;
							ptr214 = num + 1;
						}
					}
					else if (this.global1.data[11] == 2)
					{
						if (this.global1.data[33] > 800)
						{
							ptr = ref this.global1.data[33];
							ref int ptr215 = ref ptr;
							num = ptr;
							ptr215 = num - 1;
						}
						else
						{
							ptr = ref this.global1.data[33];
							ref int ptr216 = ref ptr;
							num = ptr;
							ptr216 = num + 1;
						}
						ptr = ref this.global1.data[2];
						ptr += 2;
						ptr = ref this.global1.data[4];
						ptr += 4;
						ptr = ref this.global1.data[1];
						ptr -= 5;
						if (this.global1.data[31] > 500)
						{
							ptr = ref this.global1.data[31];
							ref int ptr217 = ref ptr;
							num = ptr;
							ptr217 = num - 1;
						}
						ptr = ref this.global1.data[8];
						ptr += 2;
					}
					else if (this.global1.data[11] == 3)
					{
						ptr = ref this.global1.data[2];
						ptr += 6;
						ptr = ref this.global1.data[3];
						ptr += 5;
						ptr = ref this.global1.data[1];
						ptr -= 10;
						ptr = ref this.global1.data[4];
						ptr += 10;
						ptr = ref this.global1.data[10];
						ref int ptr218 = ref ptr;
						num = ptr;
						ptr218 = num - 1;
						ptr = ref this.global1.data[31];
						ref int ptr219 = ref ptr;
						num = ptr;
						ptr219 = num - 1;
						if (this.global1.data[6] >= 600 && this.global1.data[21] <= 1991)
						{
							ptr = ref this.global1.data[6];
							ref int ptr220 = ref ptr;
							num = ptr;
							ptr220 = num - 1;
						}
						ptr = ref this.global1.data[9];
						ref int ptr221 = ref ptr;
						num = ptr;
						ptr221 = num + 1;
					}
					if (this.global1.data[12] == 4)
					{
						ptr = ref this.global1.data[1];
						ptr += 5;
						ptr = ref this.global1.data[4];
						ref int ptr222 = ref ptr;
						num = ptr;
						ptr222 = num - 1;
						if (this.global1.data[11] == 0 && this.global1.data[21] <= 1989)
						{
							ptr = ref this.global1.data[3];
							ref int ptr223 = ref ptr;
							num = ptr;
							ptr223 = num + 1;
						}
						else
						{
							ptr = ref this.global1.data[3];
							ref int ptr224 = ref ptr;
							num = ptr;
							ptr224 = num - 1;
						}
						ptr = ref this.global1.data[8];
						ref int ptr225 = ref ptr;
						num = ptr;
						ptr225 = num - 1;
						if (this.global1.data[22] < 700)
						{
							ptr = ref this.global1.data[22];
							ref int ptr226 = ref ptr;
							num = ptr;
							ptr226 = num + 1;
						}
					}
					else if (this.global1.data[12] == 5)
					{
						ptr = ref this.global1.data[1];
						ptr -= 2;
						ptr = ref this.global1.data[3];
						ptr -= 5;
						ptr = ref this.global1.data[4];
						ptr -= 5;
						ptr = ref this.global1.data[9];
						ptr += 2;
						ptr = ref this.global1.data[8];
						ref int ptr227 = ref ptr;
						num = ptr;
						ptr227 = num - 1;
						ptr = ref this.global1.data[2];
						ptr -= 2;
					}
					else if (this.global1.data[12] == 6)
					{
						ptr = ref this.global1.data[22];
						ptr += 2;
						ptr = ref this.global1.data[2];
						ptr -= 4;
						ptr = ref this.global1.data[3];
						ptr += 2;
						ptr = ref this.global1.data[4];
						ptr += 2;
						ptr = ref this.global1.data[5];
						ref int ptr228 = ref ptr;
						num = ptr;
						ptr228 = num + 1;
						if (this.global1.data[6] > 800 && this.global1.data[21] <= 1991)
						{
							ptr = ref this.global1.data[6];
							ref int ptr229 = ref ptr;
							num = ptr;
							ptr229 = num - 1;
						}
						ptr = ref this.global1.data[10];
						ref int ptr230 = ref ptr;
						num = ptr;
						ptr230 = num + 1;
						if (this.global1.data[31] > 650)
						{
							ptr = ref this.global1.data[31];
							ref int ptr231 = ref ptr;
							num = ptr;
							ptr231 = num - 1;
						}
						ptr = ref this.global1.data[8];
						ptr += 2;
					}
					if (this.global1.data[13] == 7)
					{
						ptr = ref this.global1.data[1];
						ptr += 3;
						ptr = ref this.global1.data[4];
						ref int ptr232 = ref ptr;
						num = ptr;
						ptr232 = num + 1;
						if (this.global1.data[11] == 0 && this.global1.data[21] <= 1989)
						{
							ptr = ref this.global1.data[3];
							ptr += 3;
						}
						else
						{
							ptr = ref this.global1.data[3];
							ref int ptr233 = ref ptr;
							num = ptr;
							ptr233 = num + 1;
						}
						ptr = ref this.global1.data[8];
						ref int ptr234 = ref ptr;
						num = ptr;
						ptr234 = num - 1;
						if (this.global1.data[22] < 700)
						{
							ptr = ref this.global1.data[22];
							ref int ptr235 = ref ptr;
							num = ptr;
							ptr235 = num + 1;
						}
						ptr = ref this.global1.data[5];
						ref int ptr236 = ref ptr;
						num = ptr;
						ptr236 = num - 1;
						ptr = ref this.global1.data[9];
						ref int ptr237 = ref ptr;
						num = ptr;
						ptr237 = num + 1;
					}
					else if (this.global1.data[13] == 8)
					{
						if (this.global1.data[14] == 0 || this.global1.allcountries[this.global1.data[0]].Vyshi || (!this.global1.allcountries[this.global1.data[0]].isSEV && !this.global1.allcountries[this.global1.data[0]].isOVD))
						{
							ptr = ref this.global1.data[1];
							ptr -= 10;
						}
						else
						{
							ptr = ref this.global1.data[1];
							ptr += 2;
						}
						ptr = ref this.global1.data[2];
						ptr += 10;
						ptr = ref this.global1.data[3];
						ptr += 2;
						ptr = ref this.global1.data[4];
						ptr += 5;
						ptr = ref this.global1.data[9];
						ref int ptr238 = ref ptr;
						num = ptr;
						ptr238 = num - 1;
						ptr = ref this.global1.data[10];
						ptr -= 2;
						ptr = ref this.global1.data[5];
						ref int ptr239 = ref ptr;
						num = ptr;
						ptr239 = num + 1;
					}
					else if (this.global1.data[13] == 9)
					{
						if (this.global1.data[14] == 0 || this.global1.data[33] < 800 || this.global1.data[14] > 3 || this.global1.data[16] == 13 || this.global1.allcountries[this.global1.data[0]].Vyshi)
						{
							ptr = ref this.global1.data[1];
							ptr -= 10;
						}
						else
						{
							ptr = ref this.global1.data[1];
							ptr += 2;
						}
						ptr = ref this.global1.data[3];
						ref int ptr240 = ref ptr;
						num = ptr;
						ptr240 = num + 1;
						ptr = ref this.global1.data[4];
						ptr -= 2;
						ptr = ref this.global1.data[9];
						ptr += 2;
						ptr = ref this.global1.data[10];
						ptr += 2;
					}
				}
				else if (this.global1.data[0] == 18)
				{
					if (this.global1.data[102] > 0)
					{
						if (this.global1.data[8] - array[8] >= (this.global1.data[102] - 1) * 2)
						{
							ptr = ref this.global1.data[8];
							ptr -= this.global1.data[102];
						}
						else if (this.global1.data[8] - array[8] > 0)
						{
							ptr = ref this.global1.data[8];
							ptr -= this.global1.data[8] - array[8] - (this.global1.data[102] - 1);
						}
						else
						{
							ptr = ref this.global1.data[8];
							ptr += this.global1.data[102] - 1;
						}
						if (this.global1.data[5] > 400 - this.global1.data[102] * 20)
						{
							ptr = ref this.global1.data[5];
							ptr -= this.global1.data[102];
						}
						if (this.global1.allcountries[this.global1.data[0]].isSEV || this.global1.allcountries[7].isSEV)
						{
							ptr = ref this.global1.data[4];
							ptr += this.global1.data[102] / 2;
							ptr = ref this.global1.data[3];
							ptr -= this.global1.data[102] / 2;
						}
						if (!this.global1.allcountries[this.global1.data[0]].isSEV && !this.global1.allcountries[7].isSEV && !this.global1.allcountries[this.global1.data[0]].Vyshi)
						{
							ptr = ref this.global1.data[8];
							ptr += this.global1.data[102] * 2;
						}
					}
					if (this.global1.data[77] > 0)
					{
						ptr = ref this.global1.data[22];
						ptr += 2;
						ptr = ref this.global1.data[8];
						ptr -= this.global1.data[77];
						ptr = ref this.global1.data[3];
						ptr += this.global1.data[77];
						ptr = ref this.global1.data[10];
						ptr += this.global1.data[77] / 2;
					}
					if (this.global1.data[11] != 0)
					{
						if (this.global1.data[11] == 1)
						{
							ptr = ref this.global1.data[3];
							ptr += 2;
							ptr = ref this.global1.data[1];
							ptr += 4;
							ptr = ref this.global1.data[4];
							ptr += 3;
							ptr = ref this.global1.data[9];
							ref int ptr241 = ref ptr;
							num = ptr;
							ptr241 = num + 1;
						}
						else if (this.global1.data[11] == 2)
						{
							ptr = ref this.global1.data[3];
							ptr += 4;
							if (this.global1.data[3] - array[3] > 0)
							{
								ptr = ref this.global1.data[3];
								ptr += 3;
							}
							if (this.global1.event_done[218])
							{
								ptr = ref this.global1.data[3];
								ptr += (500 - this.global1.data[3]) / 100 * 3;
							}
							ptr = ref this.global1.data[4];
							ptr -= 2;
							ptr = ref this.global1.data[1];
							ptr += 7;
							ptr = ref this.global1.data[4];
							ptr += 2;
							ptr = ref this.global1.data[10];
							ref int ptr242 = ref ptr;
							num = ptr;
							ptr242 = num + 1;
						}
						else if (this.global1.data[11] == 3)
						{
							ptr = ref this.global1.data[3];
							ptr += 2;
							ptr = ref this.global1.data[1];
							ptr -= 3;
							ptr = ref this.global1.data[4];
							ptr += 2;
							ptr = ref this.global1.data[2];
							ptr += 4;
						}
					}
					if (this.global1.data[12] == 4)
					{
						ptr = ref this.global1.data[8];
						ptr += 2;
						if (this.global1.data[16] < 12)
						{
							ptr = ref this.global1.data[8];
							ptr += 2;
						}
						ptr = ref this.global1.data[1];
						ref int ptr243 = ref ptr;
						num = ptr;
						ptr243 = num + 1;
						ptr = ref this.global1.data[3];
						ptr -= 3;
						ptr = ref this.global1.data[4];
						ptr += 2;
					}
					else if (this.global1.data[12] == 5)
					{
						ptr = ref this.global1.data[8];
						ptr -= 2;
						ptr = ref this.global1.data[1];
						ptr -= 3;
						ptr = ref this.global1.data[5];
						ptr += 4;
						ptr = ref this.global1.data[3];
						ptr += 3;
						ptr = ref this.global1.data[4];
						ptr += 2;
					}
					else if (this.global1.data[12] == 6)
					{
						ptr = ref this.global1.data[2];
						ptr += 2;
						ptr = ref this.global1.data[4];
						ptr += 4;
						ptr = ref this.global1.data[3];
						ptr += 6;
						ptr = ref this.global1.data[1];
						ptr -= 3;
					}
					if (this.global1.data[13] == 7)
					{
						ptr = ref this.global1.data[9];
						ptr += 2;
						ptr = ref this.global1.data[10];
						ptr += 2;
						ptr = ref this.global1.data[4];
						ptr -= 2;
						ptr = ref this.global1.data[3];
						ptr -= 5;
					}
					else if (this.global1.data[13] == 8)
					{
						ptr = ref this.global1.data[1];
						ptr += 2;
						ptr = ref this.global1.data[2];
						ptr += 2;
						ptr = ref this.global1.data[4];
						ref int ptr244 = ref ptr;
						num = ptr;
						ptr244 = num - 1;
						ptr = ref this.global1.data[10];
						ptr += 3;
					}
					else if (this.global1.data[13] == 9)
					{
						ptr = ref this.global1.data[1];
						ptr -= 6;
						if (this.global1.data[16] < 12 && this.global1.data[102] > 0)
						{
							ptr = ref this.global1.data[8];
							ptr += 2;
						}
					}
				}
				else if (this.global1.data[0] == 10)
				{
					if (this.global1.data[11] == 0)
					{
						ptr = ref this.global1.data[3];
						ptr += 5;
						ptr = ref this.global1.data[1];
						ptr += 5;
						ptr = ref this.global1.data[31];
						ref int ptr245 = ref ptr;
						num = ptr;
						ptr245 = num + 1;
						ptr = ref this.global1.data[22];
						ref int ptr246 = ref ptr;
						num = ptr;
						ptr246 = num + 1;
						if (this.global1.data[21] >= 1991)
						{
							ptr = ref this.global1.data[3];
							ptr += 4;
						}
					}
					else if (this.global1.data[11] == 1)
					{
						ptr = ref this.global1.data[9];
						ptr += 2;
						ptr = ref this.global1.data[3];
						ptr -= 3;
						ptr = ref this.global1.data[1];
						ptr -= 4;
						ptr = ref this.global1.data[6];
						ptr += 2;
						if (this.global1.data[31] < 700)
						{
							ptr = ref this.global1.data[31];
							ref int ptr247 = ref ptr;
							num = ptr;
							ptr247 = num + 1;
						}
						ptr = ref this.global1.data[22];
						ref int ptr248 = ref ptr;
						num = ptr;
						ptr248 = num + 1;
					}
					else if (this.global1.data[11] == 2)
					{
						ptr = ref this.global1.data[3];
						ptr += 5;
						ptr = ref this.global1.data[1];
						ptr += 3;
						if (this.global1.data[31] < 700)
						{
							ptr = ref this.global1.data[31];
							ref int ptr249 = ref ptr;
							num = ptr;
							ptr249 = num + 1;
						}
						ptr = ref this.global1.data[22];
						ref int ptr250 = ref ptr;
						num = ptr;
						ptr250 = num + 1;
					}
					else if (this.global1.data[11] == 3)
					{
						ptr = ref this.global1.data[3];
						ptr += 5;
						ptr = ref this.global1.data[4];
						ptr += 3;
						ptr = ref this.global1.data[1];
						ptr -= 4;
						if (this.global1.data[22] > 300)
						{
							ptr = ref this.global1.data[22];
							ref int ptr251 = ref ptr;
							num = ptr;
							ptr251 = num - 1;
						}
					}
					if (this.global1.data[12] == 4)
					{
						ptr = ref this.global1.data[5];
						ref int ptr252 = ref ptr;
						num = ptr;
						ptr252 = num + 1;
						ptr = ref this.global1.data[4];
						ptr += 3;
					}
					else if (this.global1.data[12] == 5)
					{
						ptr = ref this.global1.data[10];
						ptr -= 5;
						ptr = ref this.global1.data[1];
						ptr -= 3;
						ptr = ref this.global1.data[2];
						ref int ptr253 = ref ptr;
						num = ptr;
						ptr253 = num + 1;
						ptr = ref this.global1.data[22];
						ref int ptr254 = ref ptr;
						num = ptr;
						ptr254 = num - 1;
						if (this.global1.data[6] > 700)
						{
							ptr = ref this.global1.data[6];
							ref int ptr255 = ref ptr;
							num = ptr;
							ptr255 = num - 1;
						}
					}
					else if (this.global1.data[12] == 6)
					{
						ptr = ref this.global1.data[1];
						ptr -= 5;
						ptr = ref this.global1.data[8];
						ptr += 2;
						ptr = ref this.global1.data[4];
						ptr += 3;
					}
					if (this.global1.data[13] == 7)
					{
						ptr = ref this.global1.data[4];
						ptr -= 5;
						ptr = ref this.global1.data[3];
						ptr += 4;
						ptr = ref this.global1.data[10];
						ref int ptr256 = ref ptr;
						num = ptr;
						ptr256 = num + 1;
						ptr = ref this.global1.data[2];
						ref int ptr257 = ref ptr;
						num = ptr;
						ptr257 = num - 1;
					}
					else if (this.global1.data[13] == 8)
					{
						ptr = ref this.global1.data[10];
						ptr += 3;
						ptr = ref this.global1.data[9];
						ptr += 2;
						ptr = ref this.global1.data[6];
						ptr += 2;
						ptr = ref this.global1.data[4];
						ptr -= 3;
					}
					else if (this.global1.data[13] == 9)
					{
						ptr = ref this.global1.data[1];
						ptr += 8;
						ptr = ref this.global1.data[3];
						ref int ptr258 = ref ptr;
						num = ptr;
						ptr258 = num - 1;
						ptr = ref this.global1.data[4];
						ptr += 6;
					}
				}
				else if (this.global1.data[0] == 6)
				{
					if (this.global1.data[11] == 0)
					{
						if (this.global1.data[14] < 3 && this.global1.data[33] < 850)
						{
							ptr = ref this.global1.data[33];
							ptr += 2;
						}
						ptr = ref this.global1.data[1];
						ptr -= this.global1.data[1] / 100;
						ptr = ref this.global1.data[2];
						ptr -= 2;
						if (this.global1.data[4] > 300)
						{
							ptr = ref this.global1.data[4];
							ptr -= 7;
						}
						if (this.global1.data[3] < 900)
						{
							ptr = ref this.global1.data[3];
							ptr += 7;
						}
						if (this.global1.data[6] < 900)
						{
							ptr = ref this.global1.data[6];
							ref int ptr259 = ref ptr;
							num = ptr;
							ptr259 = num + 1;
						}
						if (this.global1.data[31] > 600)
						{
							ptr = ref this.global1.data[31];
							ref int ptr260 = ref ptr;
							num = ptr;
							ptr260 = num - 1;
						}
						else if (this.global1.data[31] < 500)
						{
							ptr = ref this.global1.data[31];
							ref int ptr261 = ref ptr;
							num = ptr;
							ptr261 = num + 1;
						}
						ptr = ref this.global1.data[9];
						ptr += 2;
						ptr = ref this.global1.data[8];
						ptr -= 2;
					}
					else if (this.global1.data[11] == 1)
					{
						if (this.global1.data[33] < 900)
						{
							ptr = ref this.global1.data[33];
							ptr += 2;
						}
						ptr = ref this.global1.data[9];
						ref int ptr262 = ref ptr;
						num = ptr;
						ptr262 = num + 1;
						ptr = ref this.global1.data[2];
						ptr -= 4;
						ptr = ref this.global1.data[4];
						ptr -= 2;
						ptr = ref this.global1.data[3];
						ptr -= 6;
						ptr = ref this.global1.data[10];
						ref int ptr263 = ref ptr;
						num = ptr;
						ptr263 = num + 1;
						if (this.global1.data[31] < 700)
						{
							ptr = ref this.global1.data[31];
							ref int ptr264 = ref ptr;
							num = ptr;
							ptr264 = num + 1;
						}
					}
					else if (this.global1.data[11] == 2)
					{
						if (this.global1.data[33] > 750)
						{
							ptr = ref this.global1.data[33];
							ref int ptr265 = ref ptr;
							num = ptr;
							ptr265 = num - 1;
						}
						else
						{
							ptr = ref this.global1.data[33];
							ref int ptr266 = ref ptr;
							num = ptr;
							ptr266 = num + 1;
						}
						ptr = ref this.global1.data[2];
						ptr += 5;
						ptr = ref this.global1.data[4];
						ptr += 4;
						ptr = ref this.global1.data[1];
						ptr -= 5;
						ptr = ref this.global1.data[3];
						ptr += 5;
						if (this.global1.data[31] > 500)
						{
							ptr = ref this.global1.data[31];
							ref int ptr267 = ref ptr;
							num = ptr;
							ptr267 = num - 1;
						}
					}
					else if (this.global1.data[11] == 3)
					{
						ptr = ref this.global1.data[2];
						ptr += 6;
						ptr = ref this.global1.data[3];
						ptr += 5;
						ptr = ref this.global1.data[1];
						ptr -= 5;
						ptr = ref this.global1.data[4];
						ptr += 10;
						ptr = ref this.global1.data[10];
						ref int ptr268 = ref ptr;
						num = ptr;
						ptr268 = num - 1;
						ptr = ref this.global1.data[31];
						ref int ptr269 = ref ptr;
						num = ptr;
						ptr269 = num - 1;
						if (this.global1.data[6] >= 600 && this.global1.data[21] <= 1991)
						{
							ptr = ref this.global1.data[6];
							ref int ptr270 = ref ptr;
							num = ptr;
							ptr270 = num - 1;
						}
						ptr = ref this.global1.data[9];
						ref int ptr271 = ref ptr;
						num = ptr;
						ptr271 = num - 1;
						ptr = ref this.global1.data[8];
						ptr += 2;
					}
					if (this.global1.data[12] == 4)
					{
						ptr = ref this.global1.data[1];
						ptr += 5;
						ptr = ref this.global1.data[4];
						ref int ptr272 = ref ptr;
						num = ptr;
						ptr272 = num + 1;
						ptr = ref this.global1.data[8];
						ref int ptr273 = ref ptr;
						num = ptr;
						ptr273 = num - 1;
					}
					else if (this.global1.data[12] == 5)
					{
						ptr = ref this.global1.data[1];
						ptr -= 2;
						ptr = ref this.global1.data[3];
						ptr += 5;
						ptr = ref this.global1.data[4];
						ptr += 5;
						ptr = ref this.global1.data[9];
						ptr -= 2;
						ptr = ref this.global1.data[8];
						ptr += 3;
						ptr = ref this.global1.data[2];
						ptr += 2;
						ptr = ref this.global1.data[10];
						ref int ptr274 = ref ptr;
						num = ptr;
						ptr274 = num - 1;
					}
					else if (this.global1.data[12] == 6)
					{
						ptr = ref this.global1.data[2];
						ptr -= 4;
						ptr = ref this.global1.data[3];
						ptr -= 5;
						ptr = ref this.global1.data[4];
						ptr -= 5;
						ptr = ref this.global1.data[5];
						ref int ptr275 = ref ptr;
						num = ptr;
						ptr275 = num - 1;
						if (this.global1.data[6] < 800 && this.global1.data[21] <= 1991)
						{
							ptr = ref this.global1.data[6];
							ref int ptr276 = ref ptr;
							num = ptr;
							ptr276 = num + 1;
						}
						ptr = ref this.global1.data[10];
						ref int ptr277 = ref ptr;
						num = ptr;
						ptr277 = num + 1;
						ptr = ref this.global1.data[9];
						ptr += 2;
					}
					if (this.global1.data[13] == 7)
					{
						if (this.global1.data[11] == 0)
						{
							ptr = ref this.global1.data[1];
							ptr += 3;
						}
						else
						{
							ptr = ref this.global1.data[1];
							ptr += 5;
						}
						ptr = ref this.global1.data[4];
						ref int ptr278 = ref ptr;
						num = ptr;
						ptr278 = num + 1;
						ptr = ref this.global1.data[8];
						ref int ptr279 = ref ptr;
						num = ptr;
						ptr279 = num - 1;
						if (this.global1.data[22] < 500)
						{
							ptr = ref this.global1.data[22];
							ref int ptr280 = ref ptr;
							num = ptr;
							ptr280 = num + 1;
						}
						ptr = ref this.global1.data[9];
						ref int ptr281 = ref ptr;
						num = ptr;
						ptr281 = num - 1;
					}
					else if (this.global1.data[13] == 8)
					{
						if (this.global1.data[33] > 600)
						{
							ptr = ref this.global1.data[33];
							ptr -= 2;
						}
						else
						{
							ptr = ref this.global1.data[33];
							ref int ptr282 = ref ptr;
							num = ptr;
							ptr282 = num + 1;
						}
						if (this.global1.data[5] < 650)
						{
							ptr = ref this.global1.data[5];
							ref int ptr283 = ref ptr;
							num = ptr;
							ptr283 = num + 1;
						}
						ptr = ref this.global1.data[2];
						ref int ptr284 = ref ptr;
						num = ptr;
						ptr284 = num + 1;
						ptr = ref this.global1.data[4];
						ptr += 3;
						ptr = ref this.global1.data[8];
						ref int ptr285 = ref ptr;
						num = ptr;
						ptr285 = num + 1;
					}
					else if (this.global1.data[13] == 9)
					{
						if (this.global1.data[14] > 0 && this.global1.data[14] < 5)
						{
							ptr = ref this.global1.data[1];
							ptr -= 5;
						}
						else
						{
							ptr = ref this.global1.data[1];
							ptr += 5;
						}
						ptr = ref this.global1.data[3];
						ref int ptr286 = ref ptr;
						num = ptr;
						ptr286 = num + 1;
						ptr = ref this.global1.data[4];
						ptr += 2;
						ptr = ref this.global1.data[9];
						ptr += 2;
						ptr = ref this.global1.data[10];
						ptr += 2;
						ptr = ref this.global1.data[31];
						ref int ptr287 = ref ptr;
						num = ptr;
						ptr287 = num + 1;
					}
				}
				else if (this.global1.data[0] == 2)
				{
					if (this.global1.data[11] == 0)
					{
						this.global1.data[1] = 1000;
						this.global1.data[3] = 1000;
						this.global1.data[4] = 0;
					}
					else if (this.global1.data[11] == 1)
					{
						ptr = ref this.global1.data[33];
						ref int ptr288 = ref ptr;
						num = ptr;
						ptr288 = num + 1;
						ptr = ref this.global1.data[22];
						ref int ptr289 = ref ptr;
						num = ptr;
						ptr289 = num + 1;
						ptr = ref this.global1.data[31];
						ptr += 2;
						ptr = ref this.global1.data[1];
						ptr += 2;
						ptr = ref this.global1.data[2];
						ptr -= 5;
						ptr = ref this.global1.data[3];
						ptr -= 8;
						ptr = ref this.global1.data[4];
						ptr += 5;
						ptr = ref this.global1.data[5];
						ref int ptr290 = ref ptr;
						num = ptr;
						ptr290 = num - 1;
						ptr = ref this.global1.data[6];
						ptr += 2;
						ptr = ref this.global1.data[9];
						ref int ptr291 = ref ptr;
						num = ptr;
						ptr291 = num + 1;
						ptr = ref this.global1.data[10];
						ref int ptr292 = ref ptr;
						num = ptr;
						ptr292 = num + 1;
						ptr = ref this.global1.data[5];
						ptr -= 2;
					}
					else if (this.global1.data[11] == 2)
					{
						ptr = ref this.global1.data[33];
						ref int ptr293 = ref ptr;
						num = ptr;
						ptr293 = num - 1;
						ptr = ref this.global1.data[1];
						ptr += 6;
						ptr = ref this.global1.data[2];
						ptr += 3;
						ptr = ref this.global1.data[3];
						ptr -= 2;
						ptr = ref this.global1.data[4];
						ptr += 2;
						ptr = ref this.global1.data[9];
						ref int ptr294 = ref ptr;
						num = ptr;
						ptr294 = num + 1;
						ptr = ref this.global1.data[5];
						ptr -= 2;
					}
					else if (this.global1.data[11] == 3)
					{
						ptr = ref this.global1.data[33];
						ref int ptr295 = ref ptr;
						num = ptr;
						ptr295 = num - 1;
						ptr = ref this.global1.data[22];
						ref int ptr296 = ref ptr;
						num = ptr;
						ptr296 = num - 1;
						ptr = ref this.global1.data[31];
						ref int ptr297 = ref ptr;
						num = ptr;
						ptr297 = num - 1;
						ptr = ref this.global1.data[1];
						ptr += 2;
						ptr = ref this.global1.data[2];
						ptr -= 5;
						ptr = ref this.global1.data[3];
						ptr += 2;
						if (!this.global1.allcountries[this.global1.data[0]].Vyshi)
						{
							ptr = ref this.global1.data[4];
							ptr += 8;
							ptr = ref this.global1.data[5];
							ref int ptr298 = ref ptr;
							num = ptr;
							ptr298 = num + 1;
							ptr = ref this.global1.data[6];
							ref int ptr299 = ref ptr;
							num = ptr;
							ptr299 = num - 1;
							ptr = ref this.global1.data[9];
							ref int ptr300 = ref ptr;
							num = ptr;
							ptr300 = num - 1;
							ptr = ref this.global1.data[10];
							ptr -= 2;
						}
						else
						{
							ptr = ref this.global1.data[4];
							ptr += 2;
							ptr = ref this.global1.data[9];
							ptr -= 2;
							ptr = ref this.global1.data[10];
							ref int ptr301 = ref ptr;
							num = ptr;
							ptr301 = num - 1;
						}
					}
					if (this.global1.data[12] == 4)
					{
						ptr = ref this.global1.data[1];
						ptr += 2;
						ptr = ref this.global1.data[3];
						ptr -= 3;
						ptr = ref this.global1.data[4];
						ptr += 3;
						ptr = ref this.global1.data[5];
						ptr -= 3;
						ptr = ref this.global1.data[8];
						ptr += 3;
					}
					else if (this.global1.data[12] == 5)
					{
						ptr = ref this.global1.data[1];
						ptr -= 2;
						ptr = ref this.global1.data[3];
						ptr += 4;
						ptr = ref this.global1.data[4];
						ptr += 4;
						ptr = ref this.global1.data[9];
						ref int ptr302 = ref ptr;
						num = ptr;
						ptr302 = num - 1;
						ptr = ref this.global1.data[8];
						ptr += 2;
						ptr = ref this.global1.data[2];
						ptr += 4;
						ptr = ref this.global1.data[10];
						ref int ptr303 = ref ptr;
						num = ptr;
						ptr303 = num - 1;
						ptr = ref this.global1.data[22];
						ref int ptr304 = ref ptr;
						num = ptr;
						ptr304 = num - 1;
					}
					else if (this.global1.data[12] == 6)
					{
						ptr = ref this.global1.data[1];
						ptr += 5;
						ptr = ref this.global1.data[2];
						ptr += 2;
						ptr = ref this.global1.data[3];
						ptr -= 3;
						ptr = ref this.global1.data[4];
						ptr += 3;
					}
					if (this.global1.data[13] == 7)
					{
						ptr = ref this.global1.data[1];
						ptr += 3;
						ptr = ref this.global1.data[4];
						ptr -= 2;
						ptr = ref this.global1.data[3];
						ptr += 2;
						ptr = ref this.global1.data[8];
						ptr -= 2;
						if (this.global1.data[22] < 700)
						{
							ptr = ref this.global1.data[22];
							ref int ptr305 = ref ptr;
							num = ptr;
							ptr305 = num + 1;
						}
						ptr = ref this.global1.data[5];
						ref int ptr306 = ref ptr;
						num = ptr;
						ptr306 = num - 1;
						ptr = ref this.global1.data[9];
						ref int ptr307 = ref ptr;
						num = ptr;
						ptr307 = num + 1;
					}
					else if (this.global1.data[13] == 8)
					{
						ptr = ref this.global1.data[33];
						ref int ptr308 = ref ptr;
						num = ptr;
						ptr308 = num + 1;
						ptr = ref this.global1.data[3];
						ptr -= 4;
						ptr = ref this.global1.data[4];
						ptr += 4;
						ptr = ref this.global1.data[1];
						ptr += 8;
						ptr = ref this.global1.data[2];
						ptr -= 2;
						if (this.global1.data[22] < 700)
						{
							ptr = ref this.global1.data[22];
							ptr += 3;
						}
						ptr = ref this.global1.data[5];
						ref int ptr309 = ref ptr;
						num = ptr;
						ptr309 = num - 1;
						ptr = ref this.global1.data[9];
						ptr += 2;
						if (this.global1.data[31] < 650)
						{
							ptr = ref this.global1.data[31];
							ref int ptr310 = ref ptr;
							num = ptr;
							ptr310 = num + 1;
						}
					}
					else if (this.global1.data[13] == 9)
					{
						ptr = ref this.global1.data[1];
						ptr += 5;
						ptr = ref this.global1.data[4];
						ref int ptr311 = ref ptr;
						num = ptr;
						ptr311 = num + 1;
						ptr = ref this.global1.data[8];
						ref int ptr312 = ref ptr;
						num = ptr;
						ptr312 = num - 1;
						if (this.global1.data[22] < 500)
						{
							ptr = ref this.global1.data[22];
							ref int ptr313 = ref ptr;
							num = ptr;
							ptr313 = num + 1;
						}
						if (this.global1.data[16] >= 12)
						{
							ptr = ref this.global1.data[9];
							ref int ptr314 = ref ptr;
							num = ptr;
							ptr314 = num + 1;
							ptr = ref this.global1.data[8];
							ptr += 2;
						}
					}
				}
				else if (this.global1.data[0] == 3)
				{
					if (this.global1.data[11] == 0)
					{
						ptr = ref this.global1.data[1];
						ptr += 8;
						ptr = ref this.global1.data[4];
						ptr += 2;
						ptr = ref this.global1.data[5];
						ptr += 4;
					}
					else if (this.global1.data[11] == 1)
					{
						ptr = ref this.global1.data[2];
						ref int ptr315 = ref ptr;
						num = ptr;
						ptr315 = num + 1;
						ptr = ref this.global1.data[1];
						ptr += 2;
						ptr = ref this.global1.data[3];
						ref int ptr316 = ref ptr;
						num = ptr;
						ptr316 = num + 1;
						ptr = ref this.global1.data[4];
						ptr += 2;
					}
					else if (this.global1.data[11] == 2)
					{
						ptr = ref this.global1.data[2];
						ptr += 3;
						ptr = ref this.global1.data[1];
						ptr -= 2;
						ptr = ref this.global1.data[3];
						ptr += 2;
						ptr = ref this.global1.data[4];
						ptr += 3;
					}
					else if (this.global1.data[11] == 3)
					{
						ptr = ref this.global1.data[10];
						ptr -= 2;
						ptr = ref this.global1.data[22];
						ptr -= 2;
						ptr = ref this.global1.data[9];
						ptr -= 2;
						if (this.global1.data[14] < 4)
						{
							if (this.global1.data[15] < 9)
							{
								ptr = ref this.global1.data[38];
								ref int ptr317 = ref ptr;
								num = ptr;
								ptr317 = num + 1;
							}
							else if (this.global1.data[17] < 17)
							{
								ptr = ref this.global1.data[40];
								ref int ptr318 = ref ptr;
								num = ptr;
								ptr318 = num + 1;
							}
							else if (this.global1.data[16] < 13)
							{
								ptr = ref this.global1.data[39];
								ref int ptr319 = ref ptr;
								num = ptr;
								ptr319 = num + 1;
							}
							ptr = ref this.global1.data[8];
							ptr -= 2;
						}
					}
					if (this.global1.data[12] == 4)
					{
						ptr = ref this.global1.data[2];
						ref int ptr320 = ref ptr;
						num = ptr;
						ptr320 = num + 1;
						ptr = ref this.global1.data[8];
						ptr += 2;
						ptr = ref this.global1.data[5];
						ptr -= 2;
						ptr = ref this.global1.data[1];
						ref int ptr321 = ref ptr;
						num = ptr;
						ptr321 = num - 1;
					}
					else if (this.global1.data[12] == 5)
					{
						ptr = ref this.global1.data[2];
						ptr += 2;
						ptr = ref this.global1.data[4];
						ptr += 3;
						ptr = ref this.global1.data[3];
						ptr += 2;
					}
					else if (this.global1.data[12] == 6)
					{
						ptr = ref this.global1.data[2];
						ptr += 3;
						ptr = ref this.global1.data[10];
						ptr -= 2;
						ptr = ref this.global1.data[3];
						ptr += 2;
						ptr = ref this.global1.data[4];
						ptr += 5;
					}
					if (this.global1.data[13] == 7)
					{
						ptr = ref this.global1.data[2];
						ptr += 2;
						ptr = ref this.global1.data[10];
						ptr -= 2;
						ptr = ref this.global1.data[4];
						ptr += 2;
						ptr = ref this.global1.data[1];
						ptr -= 2;
					}
					else if (this.global1.data[13] == 8)
					{
						ptr = ref this.global1.data[2];
						ptr -= 2;
						ptr = ref this.global1.data[10];
						ref int ptr322 = ref ptr;
						num = ptr;
						ptr322 = num + 1;
						ptr = ref this.global1.data[4];
						ptr -= 4;
						ptr = ref this.global1.data[3];
						ptr -= 2;
						ptr = ref this.global1.data[9];
						ptr += 2;
					}
					else if (this.global1.data[13] == 9)
					{
						ptr = ref this.global1.data[2];
						ref int ptr323 = ref ptr;
						num = ptr;
						ptr323 = num + 1;
						ptr = ref this.global1.data[10];
						ptr -= 2;
						ptr = ref this.global1.data[4];
						ptr += 4;
						ptr = ref this.global1.data[3];
						ptr += 2;
						if (this.global1.data[14] < 4)
						{
							ptr = ref this.global1.data[1];
							ptr -= 6;
						}
					}
				}
				else if (this.global1.data[0] == 4)
				{
					if (this.global1.data[11] == 0)
					{
						ptr = ref this.global1.data[1];
						ref int ptr324 = ref ptr;
						num = ptr;
						ptr324 = num + 1;
						ptr = ref this.global1.data[2];
						ref int ptr325 = ref ptr;
						num = ptr;
						ptr325 = num - 1;
						ptr = ref this.global1.data[3];
						ref int ptr326 = ref ptr;
						num = ptr;
						ptr326 = num + 1;
						ptr = ref this.global1.data[4];
						ref int ptr327 = ref ptr;
						num = ptr;
						ptr327 = num - 1;
						if (this.global1.data[31] > 500)
						{
							ptr = ref this.global1.data[31];
							ptr -= 2;
						}
						else if (this.global1.data[31] > 300)
						{
							ptr = ref this.global1.data[31];
							ref int ptr328 = ref ptr;
							num = ptr;
							ptr328 = num - 1;
						}
					}
					else if (this.global1.data[11] == 1)
					{
						ptr = ref this.global1.data[2];
						ptr -= 2;
						ptr = ref this.global1.data[9];
						ptr += 2;
						ptr = ref this.global1.data[3];
						ref int ptr329 = ref ptr;
						num = ptr;
						ptr329 = num + 1;
						ptr = ref this.global1.data[1];
						ref int ptr330 = ref ptr;
						num = ptr;
						ptr330 = num + 1;
						ptr = ref this.global1.data[10];
						ref int ptr331 = ref ptr;
						num = ptr;
						ptr331 = num + 1;
						if (this.global1.data[31] > 500)
						{
							ptr = ref this.global1.data[31];
							ref int ptr332 = ref ptr;
							num = ptr;
							ptr332 = num + 1;
						}
						else if (this.global1.data[31] > 300)
						{
							ptr = ref this.global1.data[31];
							ptr -= 2;
						}
					}
					else if (this.global1.data[11] == 2)
					{
						ptr = ref this.global1.data[2];
						ptr += 2;
						ptr = ref this.global1.data[3];
						ptr -= 2;
						ptr = ref this.global1.data[4];
						ptr += 2;
						ptr = ref this.global1.data[1];
						ref int ptr333 = ref ptr;
						num = ptr;
						ptr333 = num - 1;
						if (this.global1.data[1] >= 500)
						{
							ptr = ref this.global1.data[1];
							ptr -= (this.global1.data[1] - 400) / 100;
						}
						if (this.global1.data[1] >= 700)
						{
							ptr = ref this.global1.data[1];
							ptr -= (this.global1.data[1] - 400) / 50;
						}
						if (this.global1.data[1] >= 800)
						{
							ptr = ref this.global1.data[1];
							ptr -= (this.global1.data[1] - 400) / 25;
						}
					}
					else if (this.global1.data[11] == 3)
					{
						ptr = ref this.global1.data[2];
						ptr += 3;
						ptr = ref this.global1.data[22];
						ref int ptr334 = ref ptr;
						num = ptr;
						ptr334 = num - 1;
						ptr = ref this.global1.data[31];
						ref int ptr335 = ref ptr;
						num = ptr;
						ptr335 = num - 1;
						ptr = ref this.global1.data[4];
						ptr += 3;
					}
					if (this.global1.data[12] == 4)
					{
						ptr = ref this.global1.data[3];
						ptr += 2;
						ptr = ref this.global1.data[9];
						ref int ptr336 = ref ptr;
						num = ptr;
						ptr336 = num - 1;
					}
					else if (this.global1.data[12] == 5)
					{
						ptr = ref this.global1.data[2];
						ref int ptr337 = ref ptr;
						num = ptr;
						ptr337 = num - 1;
						ptr = ref this.global1.data[4];
						ptr += 2 * (this.global1.data[21] - 1988);
					}
					else if (this.global1.data[12] == 6)
					{
						ptr = ref this.global1.data[2];
						ptr += 2;
						ptr = ref this.global1.data[8];
						ptr += 2;
						ptr = ref this.global1.data[4];
						ptr += 3;
						ptr = ref this.global1.data[22];
						ref int ptr338 = ref ptr;
						num = ptr;
						ptr338 = num - 1;
					}
					if (this.global1.data[13] == 7)
					{
						ptr = ref this.global1.data[2];
						ptr += 3;
						ptr = ref this.global1.data[10];
						ref int ptr339 = ref ptr;
						num = ptr;
						ptr339 = num - 1;
						ptr = ref this.global1.data[4];
						ptr += 3;
					}
					else if (this.global1.data[13] == 8)
					{
						if (this.global1.data[31] < 800)
						{
							ptr = ref this.global1.data[31];
							ref int ptr340 = ref ptr;
							num = ptr;
							ptr340 = num + 1;
						}
						ptr = ref this.global1.data[2];
						ref int ptr341 = ref ptr;
						num = ptr;
						ptr341 = num - 1;
						ptr = ref this.global1.data[3];
						ptr += 2;
						ptr = ref this.global1.data[4];
						ptr += 2;
						if (this.global1.data[22] < 500)
						{
							ptr = ref this.global1.data[22];
							ref int ptr342 = ref ptr;
							num = ptr;
							ptr342 = num + 1;
						}
					}
					else if (this.global1.data[13] == 9)
					{
						ptr = ref this.global1.data[2];
						ptr -= 2;
						ptr = ref this.global1.data[8];
						ptr += 2;
						ptr = ref this.global1.data[5];
						ref int ptr343 = ref ptr;
						num = ptr;
						ptr343 = num + 1;
					}
				}
				else if (this.global1.data[0] == 20)
				{
					if (this.global1.data[11] == 0)
					{
						ptr = ref this.global1.data[4];
						ptr -= 11;
						ptr = ref this.global1.data[1];
						ptr += 4;
						ptr = ref this.global1.data[2];
						ptr -= 4;
						ptr = ref this.global1.data[22];
						ptr += 2;
						ptr = ref this.global1.data[31];
						ptr += 2;
						ptr = ref this.global1.data[10];
						ref int ptr344 = ref ptr;
						num = ptr;
						ptr344 = num + 1;
						ptr = ref this.global1.data[5];
						ref int ptr345 = ref ptr;
						num = ptr;
						ptr345 = num - 1;
						ptr = ref this.global1.data[6];
						ref int ptr346 = ref ptr;
						num = ptr;
						ptr346 = num + 1;
					}
					else if (this.global1.data[11] == 2)
					{
						ptr = ref this.global1.data[3];
						ptr += 5;
						ptr = ref this.global1.data[4];
						ptr -= 8;
						ptr = ref this.global1.data[2];
						ref int ptr347 = ref ptr;
						num = ptr;
						ptr347 = num + 1;
						ptr = ref this.global1.data[1];
						ref int ptr348 = ref ptr;
						num = ptr;
						ptr348 = num + 1;
						if (this.global1.data[22] > 500)
						{
							ptr = ref this.global1.data[22];
							ref int ptr349 = ref ptr;
							num = ptr;
							ptr349 = num - 1;
						}
						if (this.global1.data[31] > 500)
						{
							ptr = ref this.global1.data[31];
							ref int ptr350 = ref ptr;
							num = ptr;
							ptr350 = num - 1;
						}
					}
					else if (this.global1.data[11] == 3)
					{
						ptr = ref this.global1.data[4];
						ptr -= 9;
						ptr = ref this.global1.data[2];
						ref int ptr351 = ref ptr;
						num = ptr;
						ptr351 = num + 1;
						ptr = ref this.global1.data[1];
						ref int ptr352 = ref ptr;
						num = ptr;
						ptr352 = num - 1;
						ptr = ref this.global1.data[22];
						ref int ptr353 = ref ptr;
						num = ptr;
						ptr353 = num - 1;
						ptr = ref this.global1.data[31];
						ptr -= 2;
						ptr = ref this.global1.data[5];
						ref int ptr354 = ref ptr;
						num = ptr;
						ptr354 = num - 1;
					}
					if (this.global1.data[12] == 4)
					{
						ptr = ref this.global1.data[1];
						ptr += 4;
					}
					else if (this.global1.data[12] == 5)
					{
						ptr = ref this.global1.data[3];
						ptr -= 4;
						ptr = ref this.global1.data[4];
						ptr -= 2;
						ptr = ref this.global1.data[2];
						ptr -= 4;
						ptr = ref this.global1.data[9];
						ptr += 2;
					}
					else if (this.global1.data[12] == 6)
					{
						ptr = ref this.global1.data[3];
						ptr += 4;
						ptr = ref this.global1.data[4];
						ptr += 2;
						ptr = ref this.global1.data[10];
						ref int ptr355 = ref ptr;
						num = ptr;
						ptr355 = num - 1;
						ptr = ref this.global1.data[8];
						ptr += 2;
						ptr = ref this.global1.data[5];
						ptr -= 2;
						if (this.global1.data[14] < 4 || this.global1.data[11] == 0)
						{
							ptr = ref this.global1.data[1];
							ptr -= 4;
							ptr = ref this.global1.data[8];
							ptr -= 4;
						}
					}
					if (this.global1.data[13] == 7)
					{
						ptr = ref this.global1.data[3];
						ptr -= 2;
						ptr = ref this.global1.data[4];
						ptr -= 2;
						ptr = ref this.global1.data[1];
						ptr += 2;
						ptr = ref this.global1.data[2];
						ptr -= 4;
						if (this.global1.data[21] > 1989)
						{
							ptr = ref this.global1.data[6];
							ref int ptr356 = ref ptr;
							num = ptr;
							ptr356 = num + 1;
						}
					}
					else if (this.global1.data[13] == 8)
					{
						ptr = ref this.global1.data[1];
						ptr -= 4;
						ptr = ref this.global1.data[4];
						ptr += 2;
						ptr = ref this.global1.data[5];
						ptr += 2;
					}
					else if (this.global1.data[13] == 9)
					{
						ptr = ref this.global1.data[3];
						ptr += 2;
						ptr = ref this.global1.data[31];
						ref int ptr357 = ref ptr;
						num = ptr;
						ptr357 = num + 1;
						if (this.global1.data[14] < 4 || this.global1.data[11] == 0)
						{
							ptr = ref this.global1.data[1];
							ptr -= 4;
							ptr = ref this.global1.data[8];
							ptr -= 4;
						}
					}
				}
				else if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
				{
					if (this.global1.data[114] != 100)
					{
						if (this.global1.data[112] == 0)
						{
							ptr = ref this.global1.data[26];
							ptr -= 3;
							ptr = ref this.global1.data[10];
							ptr -= 5;
						}
						else if (this.global1.data[112] == 1)
						{
							ptr = ref this.global1.data[4];
							ptr += 3;
							ptr = ref this.global1.data[10];
							ptr -= 5;
							ptr = ref this.global1.data[6];
							ptr -= 2;
						}
						else if (this.global1.data[112] == 2)
						{
							ptr = ref this.global1.data[6];
							ptr -= 2;
							ptr = ref this.global1.data[31];
							ref int ptr358 = ref ptr;
							num = ptr;
							ptr358 = num - 1;
							ptr = ref this.global1.data[4];
							ptr += 2;
							ptr = ref this.global1.data[8];
							ptr += 5;
							YugoCountry yugoCountry3 = this.yug1.gameState.yugcountries[0];
							YugoCountry yugoCountry4 = yugoCountry3;
							yugoCountry4.money += 5;
						}
						else if (this.global1.data[112] == 3)
						{
							ptr = ref this.global1.data[4];
							ptr -= 3;
							ptr = ref this.global1.data[3];
							ptr -= 3;
							YugoCountry yugoCountry5 = this.yug1.gameState.yugcountries[8];
							YugoCountry yugoCountry4 = yugoCountry5;
							yugoCountry4.money += 5;
							if (this.global1.data[0] == 49)
							{
								ptr = ref this.global1.data[8];
								ptr += 3;
							}
						}
						else if (this.global1.data[112] == 4)
						{
							ptr = ref this.global1.data[4];
							ptr -= 5;
							ptr = ref this.global1.data[3];
							ptr -= 4;
							ptr = ref this.global1.data[6];
							ptr += 3;
							ptr = ref this.global1.data[31];
							ref int ptr359 = ref ptr;
							int num41 = ptr;
							ptr359 = num41 + 1;
						}
						else if (this.global1.data[112] == 5)
						{
							ptr = ref this.global1.data[4];
							ptr += 5;
							ptr = ref this.global1.data[10];
							ptr -= 10;
							YugoCountry yugoCountry6 = this.yug1.gameState.yugcountries[1];
							YugoCountry yugoCountry4 = yugoCountry6;
							yugoCountry4.money += 5;
							if (this.global1.data[0] == 51)
							{
								ptr = ref this.global1.data[8];
								ptr += 3;
							}
							ptr = ref this.global1.data[6];
							ptr -= 6;
							ptr = ref this.global1.data[31];
							ptr -= 2;
						}
						else if (this.global1.data[112] == 7)
						{
							ptr = ref this.global1.data[4];
							ptr -= 5;
							ptr = ref this.global1.data[3];
							ptr += 3;
							ptr = ref this.global1.data[6];
							ptr += 2;
							ptr = ref this.global1.data[1];
							ref int ptr360 = ref ptr;
							int num41 = ptr;
							ptr360 = num41 + 1;
							ptr = ref this.global1.data[31];
							ptr += 2;
						}
						else if (this.global1.data[112] == 8)
						{
							ptr = ref this.global1.data[4];
							ptr -= 4;
							ptr = ref this.global1.data[3];
							ptr += 5;
							ptr = ref this.global1.data[6];
							ptr -= 2;
							ptr = ref this.global1.data[1];
							ptr -= 3;
							ptr = ref this.global1.data[31];
							ptr -= 2;
						}
						else if (this.global1.data[112] == 9)
						{
							ptr = ref this.global1.data[4];
							ptr -= 5;
							ptr = ref this.global1.data[3];
							ptr -= 4;
							ptr = ref this.global1.data[6];
							ptr += 3;
							ptr = ref this.global1.data[31];
							ref int ptr361 = ref ptr;
							int num41 = ptr;
							ptr361 = num41 + 1;
						}
						else if (this.global1.data[112] == 10)
						{
							ptr = ref this.global1.data[3];
							ptr += 3;
							ptr = ref this.global1.data[4];
							ptr += 2;
							ptr = ref this.global1.data[10];
							ptr -= 5;
							ptr = ref this.global1.data[5];
							ptr += 4;
							ptr = ref this.global1.data[8];
							ref int ptr362 = ref ptr;
							int num41 = ptr;
							ptr362 = num41 + 1;
							ptr = ref this.global1.data[23];
							ref int ptr363 = ref ptr;
							num41 = ptr;
							ptr363 = num41 - 1;
						}
						else if (this.global1.data[112] == 11)
						{
							ptr = ref this.global1.data[3];
							ptr += 5;
							ptr = ref this.global1.data[4];
							ref int ptr364 = ref ptr;
							int num41 = ptr;
							ptr364 = num41 - 1;
							ptr = ref this.global1.data[5];
							ref int ptr365 = ref ptr;
							num41 = ptr;
							ptr365 = num41 + 1;
							ptr = ref this.global1.data[31];
							ptr -= 3;
							if (this.global1.data[6] <= 30)
							{
								ptr = ref this.global1.data[6];
								ref int ptr366 = ref ptr;
								num41 = ptr;
								ptr366 = num41 - 1;
							}
						}
						else if (this.global1.data[112] == 12)
						{
							ptr = ref this.global1.data[3];
							ptr += 3;
							ptr = ref this.global1.data[4];
							ref int ptr367 = ref ptr;
							int num41 = ptr;
							ptr367 = num41 + 1;
							ptr = ref this.global1.data[5];
							ref int ptr368 = ref ptr;
							num41 = ptr;
							ptr368 = num41 + 1;
							ptr = ref this.global1.data[31];
							ref int ptr369 = ref ptr;
							num41 = ptr;
							ptr369 = num41 - 1;
							if (this.global1.data[6] <= 30)
							{
								ptr = ref this.global1.data[6];
								ref int ptr370 = ref ptr;
								num41 = ptr;
								ptr370 = num41 - 1;
							}
						}
						if (this.global1.data[12] == 4)
						{
							ptr = ref this.global1.data[1];
							ptr += 3;
							ptr = ref this.global1.data[4];
							ptr += 2;
							ptr = ref this.global1.data[9];
							ptr += 12;
							ptr = ref this.global1.data[31];
							ptr += 2;
							ptr = ref this.global1.data[33];
							ptr += 3;
						}
						else if (this.global1.data[12] == 5)
						{
							ptr = ref this.global1.data[4];
							ptr -= 5;
							ptr = ref this.global1.data[3];
							ref int ptr371 = ref ptr;
							int num41 = ptr;
							ptr371 = num41 - 1;
							ptr = ref this.global1.data[9];
							ptr += 5;
							ptr = ref this.global1.data[6];
							ptr += 5;
							YugoCountry yugoCountry7 = this.yug1.gameState.yugcountries[8];
							YugoCountry yugoCountry4 = yugoCountry7;
							yugoCountry4.money += 5;
							if (this.global1.data[0] == 49)
							{
								ptr = ref this.global1.data[8];
								ptr += 3;
							}
							ptr = ref this.global1.data[31];
							ref int ptr372 = ref ptr;
							num41 = ptr;
							ptr372 = num41 - 1;
							ptr = ref this.global1.data[33];
							ref int ptr373 = ref ptr;
							num = ptr;
							ptr373 = num + 1;
						}
						else if (this.global1.data[12] == 6)
						{
							ptr = ref this.global1.data[1];
							ptr -= 3;
							ptr = ref this.global1.data[10];
							ptr -= 5;
							ptr = ref this.global1.data[4];
							ptr += 2;
							YugoCountry yugoCountry8 = this.yug1.gameState.yugcountries[1];
							YugoCountry yugoCountry4 = yugoCountry8;
							yugoCountry4.money += 5;
							if (this.global1.data[0] == 51)
							{
								ptr = ref this.global1.data[8];
								ptr += 3;
							}
							ptr = ref this.global1.data[31];
							ref int ptr374 = ref ptr;
							int num41 = ptr;
							ptr374 = num41 - 1;
							ptr = ref this.global1.data[6];
							ptr -= 2;
						}
						if (this.global1.data[13] == 7)
						{
							ptr = ref this.global1.data[1];
							ptr += 3;
							ptr = ref this.global1.data[10];
							ptr -= 5;
							ptr = ref this.global1.data[31];
							ref int ptr375 = ref ptr;
							int num41 = ptr;
							ptr375 = num41 + 1;
							ptr = ref this.global1.data[2];
							ref int ptr376 = ref ptr;
							num = ptr;
							ptr376 = num + 1;
							ptr = ref this.global1.data[4];
							ref int ptr377 = ref ptr;
							num41 = ptr;
							ptr377 = num41 - 1;
						}
						else if (this.global1.data[13] == 8)
						{
							ptr = ref this.global1.data[1];
							ptr -= 2;
							ptr = ref this.global1.data[5];
							ptr -= 2;
							ptr = ref this.global1.data[8];
							ptr += 4;
							YugoCountry yugoCountry9 = this.yug1.gameState.yugcountries[3];
							YugoCountry yugoCountry10 = yugoCountry9;
							num = yugoCountry9.money;
							yugoCountry10.money = num + 1;
							if (this.global1.data[0] == 50)
							{
								ptr = ref this.global1.data[8];
								ref int ptr378 = ref ptr;
								num = ptr;
								ptr378 = num + 1;
							}
						}
						else if (this.global1.data[13] == 9)
						{
							ptr = ref this.global1.data[3];
							ptr += 2;
							ptr = ref this.global1.data[4];
							ptr += 4;
							ptr = ref this.global1.data[10];
							ptr -= 5;
							ptr = ref this.global1.data[5];
							ptr += 2;
							ptr = ref this.global1.data[8];
							ptr += 2;
							ptr = ref this.global1.data[23];
							ref int ptr379 = ref ptr;
							int num41 = ptr;
							ptr379 = num41 - 1;
							ptr = ref this.global1.data[6];
							ref int ptr380 = ref ptr;
							num = ptr;
							ptr380 = num - 1;
						}
					}
					else if (this.global1.data[0] == 49)
					{
						if (this.global1.data[11] == 0)
						{
							int num41;
							if (this.global1.data[7] <= 700)
							{
								ptr = ref this.global1.data[7];
								ref int ptr381 = ref ptr;
								num41 = ptr;
								ptr381 = num41 + 1;
							}
							ptr = ref this.global1.data[1];
							ptr += 3;
							ptr = ref this.global1.data[9];
							ptr += 10;
							ptr = ref this.global1.data[31];
							ref int ptr382 = ref ptr;
							num41 = ptr;
							ptr382 = num41 - 1;
						}
						else if (this.global1.data[11] == 1)
						{
							ptr = ref this.global1.data[4];
							ptr -= 4;
							ptr = ref this.global1.data[3];
							ptr += 3;
							ptr = ref this.global1.data[6];
							ptr += 5;
							ptr = ref this.global1.data[9];
							ptr += 5;
							ptr = ref this.global1.data[31];
							ptr += 3;
						}
						else if (this.global1.data[11] == 2)
						{
							ptr = ref this.global1.data[3];
							ptr += 2;
							ptr = ref this.global1.data[4];
							ptr -= 4;
							ptr = ref this.global1.data[6];
							ptr -= 5;
							ptr = ref this.global1.data[9];
							ptr += 5;
							ptr = ref this.global1.data[31];
							ptr += 3;
						}
						else if (this.global1.data[11] == 3)
						{
							ptr = ref this.global1.data[10];
							ptr -= 2;
							ptr = ref this.global1.data[1];
							ref int ptr383 = ref ptr;
							int num41 = ptr;
							ptr383 = num41 - 1;
							ptr = ref this.global1.data[4];
							ptr += 4;
							ptr = ref this.global1.data[6];
							ref int ptr384 = ref ptr;
							num41 = ptr;
							ptr384 = num41 - 1;
							ptr = ref this.global1.data[31];
							ref int ptr385 = ref ptr;
							num41 = ptr;
							ptr385 = num41 + 1;
							ptr = ref this.global1.data[5];
							ref int ptr386 = ref ptr;
							num41 = ptr;
							ptr386 = num41 + 1;
						}
						if (this.global1.data[12] == 4)
						{
							ptr = ref this.global1.data[3];
							ptr += 4;
							ptr = ref this.global1.data[1];
							ptr += 4;
							ptr = ref this.global1.data[10];
							ref int ptr387 = ref ptr;
							int num41 = ptr;
							ptr387 = num41 + 1;
							ptr = ref this.global1.data[5];
							ref int ptr388 = ref ptr;
							num41 = ptr;
							ptr388 = num41 - 1;
						}
						else if (this.global1.data[12] == 5)
						{
							ptr = ref this.global1.data[3];
							ptr -= 2;
							ptr = ref this.global1.data[1];
							ptr += 2;
							ptr = ref this.global1.data[9];
							ptr += 10;
						}
						else if (this.global1.data[12] == 6)
						{
							ptr = ref this.global1.data[10];
							ptr += 5;
							ptr = ref this.global1.data[8];
							ptr -= 5;
							ptr = ref this.global1.data[9];
							ptr += 15;
							ptr = ref this.global1.data[31];
							ref int ptr389 = ref ptr;
							int num41 = ptr;
							ptr389 = num41 + 1;
						}
						if (this.global1.data[13] == 7)
						{
							ptr = ref this.global1.data[10];
							ptr -= 2;
							ptr = ref this.global1.data[2];
							ref int ptr390 = ref ptr;
							num = ptr;
							ptr390 = num + 1;
							ptr = ref this.global1.data[3];
							ptr += 3;
							ptr = ref this.global1.data[9];
							ptr += 5;
							ptr = ref this.global1.data[31];
							ptr += 2;
						}
						else if (this.global1.data[13] == 8)
						{
							ptr = ref this.global1.data[3];
							ref int ptr391 = ref ptr;
							int num41 = ptr;
							ptr391 = num41 + 1;
							ptr = ref this.global1.data[1];
							ptr -= 5;
							ptr = ref this.global1.data[9];
							ptr += 8;
							ptr = ref this.global1.data[31];
							ptr += 3;
							ptr = ref this.global1.data[10];
							ptr += 5;
						}
						else if (this.global1.data[13] == 9)
						{
							ptr = ref this.global1.data[3];
							ptr += 10;
							ptr = ref this.global1.data[5];
							ref int ptr392 = ref ptr;
							num = ptr;
							ptr392 = num + 1;
							ptr = ref this.global1.data[1];
							ref int ptr393 = ref ptr;
							num = ptr;
							ptr393 = num - 1;
							ptr = ref this.global1.data[10];
							ref int ptr394 = ref ptr;
							num = ptr;
							ptr394 = num - 1;
						}
					}
					else if (this.global1.data[0] == 50)
					{
						if (this.global1.data[11] == 0)
						{
							ptr = ref this.global1.data[1];
							ptr += 5;
							ptr = ref this.global1.data[3];
							ptr += 8;
							ptr = ref this.global1.data[31];
							ptr += 2;
						}
						else if (this.global1.data[11] == 1)
						{
							ptr = ref this.global1.data[3];
							ref int ptr395 = ref ptr;
							int num41 = ptr;
							ptr395 = num41 + 1;
							ptr = ref this.global1.data[5];
							ref int ptr396 = ref ptr;
							num41 = ptr;
							ptr396 = num41 + 1;
							ptr = ref this.global1.data[1];
							ref int ptr397 = ref ptr;
							num41 = ptr;
							ptr397 = num41 + 1;
							ptr = ref this.global1.data[31];
							ref int ptr398 = ref ptr;
							num41 = ptr;
							ptr398 = num41 - 1;
						}
						else if (this.global1.data[11] == 2)
						{
							ptr = ref this.global1.data[1];
							ptr += 2;
							ptr = ref this.global1.data[10];
							ptr -= 5;
							ptr = ref this.global1.data[5];
							ptr += 5;
							ptr = ref this.global1.data[6];
							ptr -= 4;
							ptr = ref this.global1.data[31];
							ref int ptr399 = ref ptr;
							int num41 = ptr;
							ptr399 = num41 + 1;
						}
						else if (this.global1.data[11] == 3)
						{
							ptr = ref this.global1.data[1];
							ptr += 3;
							ptr = ref this.global1.data[3];
							ref int ptr400 = ref ptr;
							int num41 = ptr;
							ptr400 = num41 + 1;
							ptr = ref this.global1.data[6];
							ptr += 2;
							ptr = ref this.global1.data[31];
							ref int ptr401 = ref ptr;
							num41 = ptr;
							ptr401 = num41 - 1;
						}
						if (this.global1.data[12] == 4)
						{
							ptr = ref this.global1.data[3];
							ref int ptr402 = ref ptr;
							int num41 = ptr;
							ptr402 = num41 + 1;
							ptr = ref this.global1.data[8];
							ptr -= 10;
							ptr = ref this.global1.data[9];
							ptr += 30;
							ptr = ref this.global1.data[31];
							ref int ptr403 = ref ptr;
							num41 = ptr;
							ptr403 = num41 + 1;
						}
						else if (this.global1.data[12] == 5)
						{
							ptr = ref this.global1.data[4];
							ptr += 5;
							ptr = ref this.global1.data[3];
							ptr += 3;
							ptr = ref this.global1.data[31];
							ptr += 2;
							ptr = ref this.global1.data[10];
							ptr -= 2;
						}
						else if (this.global1.data[12] == 6)
						{
							ptr = ref this.global1.data[5];
							ptr -= 3;
							ptr = ref this.global1.data[8];
							ptr += 12;
							ptr = ref this.global1.data[3];
							ptr += 3;
						}
						if (this.global1.data[13] == 7)
						{
							ptr = ref this.global1.data[1];
							ref int ptr404 = ref ptr;
							int num41 = ptr;
							ptr404 = num41 + 1;
							ptr = ref this.global1.data[6];
							ptr -= 3;
							ptr = ref this.global1.data[10];
							ptr -= 2;
							ptr = ref this.global1.data[4];
							ptr += 3;
							ptr = ref this.global1.data[3];
							ptr -= 2;
							ptr = ref this.global1.data[8];
							ptr += 4;
						}
						else if (this.global1.data[13] == 8)
						{
							ptr = ref this.global1.data[1];
							ptr += 2;
							ptr = ref this.global1.data[10];
							ptr -= 5;
							ptr = ref this.global1.data[5];
							ptr += 5;
							ptr = ref this.global1.data[6];
							ptr -= 4;
							ptr = ref this.global1.data[31];
							ptr += 3;
						}
						else if (this.global1.data[13] == 9)
						{
							ptr = ref this.global1.data[1];
							ptr += 3;
							ptr = ref this.global1.data[3];
							ref int ptr405 = ref ptr;
							int num41 = ptr;
							ptr405 = num41 + 1;
							ptr = ref this.global1.data[6];
							ptr += 2;
							ptr = ref this.global1.data[31];
							ref int ptr406 = ref ptr;
							num41 = ptr;
							ptr406 = num41 - 1;
						}
					}
					else if (this.global1.data[0] == 51)
					{
						if (this.global1.data[11] == 0)
						{
							ptr = ref this.global1.data[1];
							ptr += 4;
							ptr = ref this.global1.data[10];
							ptr -= 5;
							ptr = ref this.global1.data[4];
							ptr += 5;
							ptr = ref this.global1.data[3];
							ptr += 5;
						}
						else if (this.global1.data[11] == 1)
						{
							ptr = ref this.global1.data[3];
							ptr += 2;
							ptr = ref this.global1.data[8];
							ptr += 10;
							ptr = ref this.global1.data[4];
							ptr += 2;
							ptr = ref this.global1.data[5];
							ptr += 2;
						}
						else if (this.global1.data[11] == 2)
						{
							ptr = ref this.global1.data[2];
							ref int ptr407 = ref ptr;
							int num41 = ptr;
							ptr407 = num41 + 1;
							ptr = ref this.global1.data[9];
							ptr += 25;
							ptr = ref this.global1.data[1];
							ref int ptr408 = ref ptr;
							num41 = ptr;
							ptr408 = num41 + 1;
							ptr = ref this.global1.data[3];
							ref int ptr409 = ref ptr;
							num41 = ptr;
							ptr409 = num41 - 1;
							ptr = ref this.global1.data[31];
							ref int ptr410 = ref ptr;
							num41 = ptr;
							ptr410 = num41 - 1;
							ptr = ref this.global1.data[4];
							ref int ptr411 = ref ptr;
							num41 = ptr;
							ptr411 = num41 + 1;
							if (this.global1.data[6] <= 500)
							{
								ptr = ref this.global1.data[6];
								ref int ptr412 = ref ptr;
								num41 = ptr;
								ptr412 = num41 + 1;
							}
							if (this.global1.data[6] >= 600)
							{
								ptr = ref this.global1.data[6];
								ref int ptr413 = ref ptr;
								num41 = ptr;
								ptr413 = num41 - 1;
							}
						}
						else if (this.global1.data[11] == 3)
						{
							ptr = ref this.global1.data[1];
							ptr += 2;
							ptr = ref this.global1.data[3];
							ref int ptr414 = ref ptr;
							int num41 = ptr;
							ptr414 = num41 + 1;
							ptr = ref this.global1.data[31];
							ref int ptr415 = ref ptr;
							num41 = ptr;
							ptr415 = num41 - 1;
							ptr = ref this.global1.data[5];
							ref int ptr416 = ref ptr;
							num41 = ptr;
							ptr416 = num41 + 1;
							ptr = ref this.global1.data[4];
							ref int ptr417 = ref ptr;
							num41 = ptr;
							ptr417 = num41 - 1;
							ptr = ref this.global1.data[6];
							ref int ptr418 = ref ptr;
							num41 = ptr;
							ptr418 = num41 + 1;
						}
						if (this.global1.data[12] == 4)
						{
							ptr = ref this.global1.data[8];
							ptr -= 10;
							ptr = ref this.global1.data[9];
							ptr += 18;
						}
						else if (this.global1.data[12] == 5)
						{
							ptr = ref this.global1.data[3];
							ptr += 3;
							ptr = ref this.global1.data[4];
							ptr -= 5;
							ptr = ref this.global1.data[31];
							ptr -= 2;
						}
						else if (this.global1.data[12] == 6)
						{
							ptr = ref this.global1.data[1];
							ptr += 3;
							ptr = ref this.global1.data[3];
							ptr += 3;
							ptr = ref this.global1.data[31];
							ref int ptr419 = ref ptr;
							int num41 = ptr;
							ptr419 = num41 - 1;
							ptr = ref this.global1.data[5];
							ptr += 3;
						}
						if (this.global1.data[13] == 7)
						{
							ptr = ref this.global1.data[3];
							ptr += 3;
							ptr = ref this.global1.data[8];
							ptr += 7;
							ptr = ref this.global1.data[4];
							ptr += 2;
							ptr = ref this.global1.data[5];
							ptr += 2;
						}
						else if (this.global1.data[13] == 8)
						{
							ptr = ref this.global1.data[3];
							ptr += 3;
							ptr = ref this.global1.data[10];
							ptr -= 5;
							ptr = ref this.global1.data[5];
							ref int ptr420 = ref ptr;
							int num41 = ptr;
							ptr420 = num41 + 1;
							ptr = ref this.global1.data[31];
							ref int ptr421 = ref ptr;
							num41 = ptr;
							ptr421 = num41 - 1;
						}
						else if (this.global1.data[13] == 9)
						{
							ptr = ref this.global1.data[3];
							ref int ptr422 = ref ptr;
							int num41 = ptr;
							ptr422 = num41 + 1;
							ptr = ref this.global1.data[1];
							ptr += 2;
							ptr = ref this.global1.data[4];
							ptr += 5;
							ptr = ref this.global1.data[9];
							ref int ptr423 = ref ptr;
							num41 = ptr;
							ptr423 = num41 + 1;
							ptr = ref this.global1.data[31];
							ref int ptr424 = ref ptr;
							num41 = ptr;
							ptr424 = num41 + 1;
							ptr = ref this.global1.data[6];
							ptr -= 3;
						}
					}
					Debug.Log("MINISTERDONE");
				}
				if (this.global1.data[2] < 501)
				{
					if (this.global1.allcountries[this.global1.data[0]].Vyshi && !this.global1.allcountries[this.global1.data[0]].isOVD && !this.global1.allcountries[this.global1.data[0]].isSEV)
					{
						ptr = ref this.global1.data[1];
						ptr -= (1000 - this.global1.data[2]) / 200;
					}
					else if (this.global1.allcountries[this.global1.data[0]].Vyshi && !this.global1.allcountries[this.global1.data[0]].isOVD)
					{
						ptr = ref this.global1.data[1];
						ptr -= (1000 - this.global1.data[2]) / 150;
					}
					else if (this.global1.allcountries[this.global1.data[0]].Vyshi)
					{
						ptr = ref this.global1.data[1];
						ptr -= (1000 - this.global1.data[2]) / 100;
					}
					else
					{
						ptr = ref this.global1.data[1];
						ptr -= (1000 - this.global1.data[2]) / 80;
					}
					if (this.global1.data[30] > 0 && this.global1.data[0] != 12)
					{
						ptr = ref this.global1.data[8];
						ptr -= this.global1.data[30] / 50;
						ptr = ref this.global1.data[30];
						ptr -= this.global1.data[30] / 50;
					}
				}
				if (this.global1.data[4] > 600)
				{
					ptr = ref this.global1.data[1];
					ptr -= this.global1.data[4] / 180;
					ptr = ref this.global1.data[3];
					ptr -= this.global1.data[4] / 90;
				}
				ptr = ref this.global1.data[4];
				ptr += (500 - this.global1.data[22]) / 100;
				ptr = ref this.global1.data[4];
				ptr -= this.global1.allcountries[17].Westalgie / 80;
				ptr = ref this.global1.data[10];
				ptr -= this.global1.allcountries[17].Westalgie / 120;
				if (this.global1.data[21] < 1992)
				{
					if (this.global1.diff[0])
					{
						ptr = ref this.global1.data[1];
						ptr -= 3 + (this.global1.data[21] - 1988);
						if (this.global1.data[0] == 4 && this.global1.data[11] != 2)
						{
							ptr = ref this.global1.data[1];
							ptr -= 5;
						}
						else if (this.global1.data[0] == 20)
						{
							ptr = ref this.global1.data[8];
							ptr -= this.global1.data[21] - 1988;
						}
					}
					if (this.global1.diff[1])
					{
						if (!this.global1.is_gkchp || (this.global1.is_gkchp && !this.global1.allcountries[7].isOVD && !this.global1.allcountries[this.global1.data[0]].Vyshi))
						{
							ptr = ref this.global1.data[2];
							ptr -= 3 + (this.global1.data[21] - 1988);
						}
						else
						{
							ptr = ref this.global1.data[2];
							ptr += 3 + (this.global1.data[21] - 1988);
						}
					}
					if (this.global1.diff[2])
					{
						ptr = ref this.global1.data[3];
						ptr -= 3 + (this.global1.data[21] - 1988);
					}
				}
				else
				{
					if (this.global1.diff[0])
					{
						ptr = ref this.global1.data[1];
						ptr -= 6;
					}
					if (this.global1.diff[1])
					{
						if (!this.global1.is_gkchp || (this.global1.is_gkchp && !this.global1.allcountries[7].isOVD && !this.global1.allcountries[this.global1.data[0]].Vyshi))
						{
							ptr = ref this.global1.data[2];
							ptr -= 6;
						}
						else
						{
							ptr = ref this.global1.data[10];
							ptr += 6;
						}
					}
					if (this.global1.diff[2])
					{
						ptr = ref this.global1.data[3];
						ptr -= 6;
					}
				}
				if (this.global1.allcountries[7].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV)
				{
					ptr = ref this.global1.data[1];
					ptr += this.global1.data[22] / 100;
				}
				else
				{
					ptr = ref this.global1.data[1];
					ptr += this.global1.data[22] / 50;
				}
				ptr = ref this.global1.data[3];
				ptr -= (700 - this.global1.data[5]) / 70;
				if ((this.global1.science_time[0] > 0 && this.global1.science_time[0] < 360) || (this.global1.science_time[1] > 0 && this.global1.science_time[1] < 360) || (this.global1.science_time[2] > 0 && this.global1.science_time[2] < 360))
				{
					if (this.global1.data[0] == 10 || this.global1.data[0] == 12 || this.global1.data[0] == 18)
					{
						ptr = ref this.global1.data[1];
						ref int ptr425 = ref ptr;
						num = ptr;
						ptr425 = num + 1;
						ptr = ref this.global1.data[3];
						ptr -= 2;
						ptr = ref this.global1.data[4];
						ref int ptr426 = ref ptr;
						num = ptr;
						ptr426 = num - 1;
						ptr = ref this.global1.data[10];
						ref int ptr427 = ref ptr;
						num = ptr;
						ptr427 = num + 1;
						ptr = ref this.global1.data[2];
						ref int ptr428 = ref ptr;
						num = ptr;
						ptr428 = num - 1;
					}
					else
					{
						ptr = ref this.global1.data[2];
						ptr -= 2;
						ptr = ref this.global1.data[10];
						ref int ptr429 = ref ptr;
						num = ptr;
						ptr429 = num + 1;
						ptr = ref this.global1.data[1];
						ptr += 2;
						ptr = ref this.global1.data[22];
						ref int ptr430 = ref ptr;
						num = ptr;
						ptr430 = num + 1;
					}
				}
				if ((this.global1.science_time[3] > 0 && this.global1.science_time[3] < 360) || (this.global1.science_time[4] > 0 && this.global1.science_time[4] < 360) || (this.global1.science_time[5] > 0 && this.global1.science_time[5] < 360))
				{
					if (this.global1.data[0] == 10 || this.global1.data[0] == 12 || this.global1.data[0] == 18)
					{
						ptr = ref this.global1.data[5];
						ptr += 2;
						ptr = ref this.global1.data[3];
						ref int ptr431 = ref ptr;
						num = ptr;
						ptr431 = num + 1;
						ptr = ref this.global1.data[4];
						ptr += 2;
					}
					else
					{
						ptr = ref this.global1.data[1];
						ptr -= 4;
						ptr = ref this.global1.data[5];
						ref int ptr432 = ref ptr;
						num = ptr;
						ptr432 = num + 1;
						ptr = ref this.global1.data[22];
						ref int ptr433 = ref ptr;
						num = ptr;
						ptr433 = num + 1;
					}
				}
				if ((this.global1.science_time[6] > 0 && this.global1.science_time[6] < 360) || (this.global1.science_time[7] > 0 && this.global1.science_time[7] < 360) || (this.global1.science_time[8] > 0 && this.global1.science_time[8] < 360))
				{
					if (this.global1.data[0] == 10 || this.global1.data[0] == 12 || this.global1.data[0] == 18)
					{
						ptr = ref this.global1.data[1];
						ptr += 2;
						ptr = ref this.global1.data[5];
						ptr += 2;
						ptr = ref this.global1.data[3];
						ptr -= 2;
					}
					else
					{
						ptr = ref this.global1.data[5];
						ref int ptr434 = ref ptr;
						num = ptr;
						ptr434 = num + 1;
						ptr = ref this.global1.data[1];
						ptr -= 2;
					}
				}
				if (this.global1.science_time[9] > 0 && this.global1.science_time[9] < 360)
				{
					ptr = ref this.global1.data[2];
					ptr -= 4;
					ptr = ref this.global1.data[10];
					ref int ptr435 = ref ptr;
					num = ptr;
					ptr435 = num + 1;
					ptr = ref this.global1.data[22];
					ptr += 2;
				}
				if (this.global1.data[0] == 10 || this.global1.data[0] == 12 || this.global1.data[0] == 18)
				{
					if (this.global1.science[0])
					{
						ptr = ref this.global1.data[4];
						ptr -= 2;
						ptr = ref this.global1.data[3];
						ptr += 2;
						ptr = ref this.global1.data[5];
						ref int ptr436 = ref ptr;
						num = ptr;
						ptr436 = num + 1;
					}
					if (this.global1.science[1])
					{
						ptr = ref this.global1.data[1];
						ptr += 2;
						ptr = ref this.global1.data[9];
						ptr += 2;
						ptr = ref this.global1.data[4];
						ptr -= 2;
					}
					if (this.global1.science[2])
					{
						ptr = ref this.global1.data[1];
						ptr += 4;
						ptr = ref this.global1.data[2];
						ptr += 4;
						ptr = ref this.global1.data[10];
						ptr -= 3;
					}
					if (this.global1.science[3])
					{
						ptr = ref this.global1.data[8];
						ptr += 2;
						ptr = ref this.global1.data[5];
						ptr += 2;
					}
					if (this.global1.science[4])
					{
						ptr = ref this.global1.data[1];
						ref int ptr437 = ref ptr;
						num = ptr;
						ptr437 = num + 1;
						ptr = ref this.global1.data[5];
						ref int ptr438 = ref ptr;
						num = ptr;
						ptr438 = num + 1;
					}
					if (this.global1.science[5])
					{
						ptr = ref this.global1.data[8];
						ptr += 2;
						ptr = ref this.global1.data[5];
						ptr += 3;
						ptr = ref this.global1.data[22];
						ptr += 3;
					}
					if (this.global1.science[6])
					{
						ptr = ref this.global1.data[5];
						ptr += 2;
						ptr = ref this.global1.data[1];
						ptr += 2;
						ptr = ref this.global1.data[22];
						ref int ptr439 = ref ptr;
						num = ptr;
						ptr439 = num + 1;
					}
					if (this.global1.science[7])
					{
						ptr = ref this.global1.data[4];
						ref int ptr440 = ref ptr;
						num = ptr;
						ptr440 = num + 1;
						ptr = ref this.global1.data[22];
						ptr += 2;
					}
					if (this.global1.science[8])
					{
						ptr = ref this.global1.data[4];
						ref int ptr441 = ref ptr;
						num = ptr;
						ptr441 = num - 1;
						ptr = ref this.global1.data[22];
						ref int ptr442 = ref ptr;
						num = ptr;
						ptr442 = num + 1;
						ptr = ref this.global1.data[5];
						ptr += 2;
					}
				}
				else if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
				{
					if (this.global1.data[114] != 100)
					{
						if (this.global1.science[0])
						{
							ptr = ref this.global1.data[4];
							ref int ptr443 = ref ptr;
							num = ptr;
							ptr443 = num - 1;
							ptr = ref this.global1.data[3];
							ref int ptr444 = ref ptr;
							num = ptr;
							ptr444 = num + 1;
							ptr = ref this.global1.data[8];
							ref int ptr445 = ref ptr;
							num = ptr;
							ptr445 = num - 1;
						}
						if (this.global1.science[1])
						{
							ptr = ref this.global1.data[9];
							ptr += 3;
							ptr = ref this.global1.data[1];
							ptr += 4;
							ptr = ref this.global1.data[22];
							ref int ptr446 = ref ptr;
							num = ptr;
							ptr446 = num + 1;
						}
						if (this.global1.science[2])
						{
							ptr = ref this.global1.data[1];
							ptr += 2;
							ptr = ref this.global1.data[9];
							ptr += 3;
							ptr = ref this.global1.data[6];
							ref int ptr447 = ref ptr;
							num = ptr;
							ptr447 = num + 1;
						}
						if (this.global1.science[6])
						{
							ptr = ref this.global1.data[3];
							ptr += 2;
							ptr = ref this.global1.data[4];
							ref int ptr448 = ref ptr;
							num = ptr;
							ptr448 = num + 1;
							if (this.global1.data[6] >= 300)
							{
								ptr = ref this.global1.data[6];
								ref int ptr449 = ref ptr;
								num = ptr;
								ptr449 = num - 1;
							}
						}
						if (this.global1.science[7])
						{
							ptr = ref this.global1.data[1];
							ref int ptr450 = ref ptr;
							num = ptr;
							ptr450 = num + 1;
							ptr = ref this.global1.data[4];
							ptr -= 2;
							ptr = ref this.global1.data[6];
							ref int ptr451 = ref ptr;
							num = ptr;
							ptr451 = num + 1;
						}
						if (this.global1.science[8])
						{
							ptr = ref this.global1.data[3];
							ptr += 6;
							ptr = ref this.global1.data[4];
							ptr += 2;
							ptr = ref this.global1.data[22];
							ref int ptr452 = ref ptr;
							num = ptr;
							ptr452 = num + 1;
						}
					}
					else
					{
						if (this.global1.science[1])
						{
							ptr = ref this.global1.data[1];
							ptr += 4;
							ptr = ref this.global1.data[22];
							ref int ptr453 = ref ptr;
							num = ptr;
							ptr453 = num + 1;
						}
						if (this.global1.science[2])
						{
							ptr = ref this.global1.data[4];
							ptr -= 2;
							ptr = ref this.global1.data[8];
							ptr -= 2;
						}
						if (this.global1.science[6])
						{
							ptr = ref this.global1.data[4];
							ptr -= 2;
							ptr = ref this.global1.data[22];
							ref int ptr454 = ref ptr;
							num = ptr;
							ptr454 = num + 1;
						}
						if (this.global1.science[7])
						{
							ptr = ref this.global1.data[3];
							ptr += 2;
							ptr = ref this.global1.data[9];
							ref int ptr455 = ref ptr;
							num = ptr;
							ptr455 = num + 1;
						}
						if (this.global1.science[8])
						{
							ptr = ref this.global1.data[4];
							ptr -= 2;
							ptr = ref this.global1.data[3];
							ptr += 2;
							ptr = ref this.global1.data[8];
							ptr += 2;
						}
					}
					if (this.global1.science[3] && (!this.global1.allcountries[7].isSEV || !this.global1.allcountries[this.global1.data[0]].isSEV) && !this.global1.allcountries[this.global1.data[0]].isOVD)
					{
						ptr = ref this.global1.data[8];
						ptr += 2;
						if (this.global1.data[6] >= 500)
						{
							ptr = ref this.global1.data[6];
							ref int ptr456 = ref ptr;
							num = ptr;
							ptr456 = num - 1;
						}
						ptr = ref this.global1.data[10];
						ptr -= 2;
					}
					if (this.global1.science[4])
					{
						ptr = ref this.global1.data[10];
						ptr -= 2;
					}
					if (this.global1.science[5])
					{
						ptr = ref this.global1.data[9];
						ptr += 3;
						ptr = ref this.global1.data[22];
						ptr += 2;
						ptr = ref this.global1.data[1];
						ptr += 2;
						ptr = ref this.global1.data[8];
						ptr += 2;
						ptr = ref this.global1.data[10];
						ptr += 2;
						ptr = ref this.global1.data[4];
						ref int ptr457 = ref ptr;
						int num41 = ptr;
						ptr457 = num41 - 1;
					}
					if (this.global1.science[9])
					{
						ptr = ref this.global1.data[8];
						ptr += 2;
						ptr = ref this.global1.data[9];
						ptr += 3;
						ptr = ref this.global1.data[1];
						ptr += 2;
						ptr = ref this.global1.data[3];
						ptr += 2;
						ptr = ref this.global1.data[4];
						ptr += 2;
					}
				}
				else
				{
					if (this.global1.science[0])
					{
						ptr = ref this.global1.data[4];
						ptr -= 2;
						ptr = ref this.global1.data[9];
						ptr += 2;
						ptr = ref this.global1.data[1];
						ptr += 2;
					}
					if (this.global1.science[1])
					{
						ptr = ref this.global1.data[4];
						ptr -= 2;
						ptr = ref this.global1.data[1];
						ptr += 2;
						ptr = ref this.global1.data[3];
						ptr += 2;
					}
					if (this.global1.science[2])
					{
						ptr = ref this.global1.data[1];
						ptr += 6;
						ptr = ref this.global1.data[3];
						ptr += 2;
					}
					if (this.global1.science[3])
					{
						ptr = ref this.global1.data[8];
						ptr += 2;
						ptr = ref this.global1.data[5];
						ptr += 2;
					}
					if (this.global1.science[4])
					{
						ptr = ref this.global1.data[8];
						ptr += 4;
						ptr = ref this.global1.data[5];
						ptr += 2;
					}
					if (this.global1.science[5])
					{
						ptr = ref this.global1.data[8];
						ptr += 2;
						ptr = ref this.global1.data[5];
						ptr += 2;
						ptr = ref this.global1.data[22];
						ptr += 2;
					}
					if (this.global1.science[6])
					{
						ptr = ref this.global1.data[22];
						ptr += 2;
						ptr = ref this.global1.data[5];
						ptr += 2;
					}
					if (this.global1.science[7])
					{
						ptr = ref this.global1.data[22];
						ptr += 2;
						ptr = ref this.global1.data[5];
						ptr += 2;
						ptr = ref this.global1.data[8];
						ptr += 2;
					}
					if (this.global1.science[8])
					{
						ptr = ref this.global1.data[4];
						ptr -= 2;
						ptr = ref this.global1.data[5];
						ptr += 3;
						ptr = ref this.global1.data[3];
						ptr += 2;
					}
				}
				if (this.global1.science[9])
				{
					ptr = ref this.global1.data[2];
					ptr -= 2;
					ptr = ref this.global1.data[10];
					ref int ptr458 = ref ptr;
					num = ptr;
					ptr458 = num + 1;
					ptr = ref this.global1.data[22];
					ptr += 6;
					ptr = ref this.global1.data[1];
					ptr += 6;
				}
			}
			Debug.Log("SCIENCEDONE");
			for (int num63 = 1; num63 < 11; num63 = num + 1)
			{
				if (num63 != 8)
				{
					if (this.global1.data[num63] < 0 && num63 != 9)
					{
						this.global1.data[num63] = 0;
					}
					else if (this.global1.data[num63] > 1000 && num63 != 7 && num63 != 4)
					{
						this.global1.data[num63] = 1000;
					}
					else if (this.global1.data[num63] > 1500 && num63 == 4)
					{
						this.global1.data[num63] = 1500;
					}
				}
				num = num63;
			}
			int num64 = 0;
			for (int num65 = 0; num65 < this.global1.science_time.Length; num65 = num + 1)
			{
				if (this.global1.science_time[num65] > 0 && this.global1.science_time[num65] < 360)
				{
					num = num64;
					num64 = num + 1;
				}
				num = num65;
			}
			num = num64;
			num64 = num - 1;
			for (int num66 = 0; num66 < this.global1.science_time.Length; num66 = num + 1)
			{
				if (this.global1.science_time[num66] > 0 && this.global1.science_time[num66] < 360)
				{
					this.global1.neizucheno = false;
					int num67 = this.global1.science_time[num66];
					for (int num68 = 0; num68 < 15; num68 = num + 1)
					{
						if ((this.global1.regions[0].buildings[num68].type == 25 || this.global1.regions[0].buildings[num68].type == 9 || this.global1.regions[0].buildings[num68].type == 3 || this.global1.regions[0].buildings[num68].type == 16 || this.global1.regions[0].buildings[num68].type == 14) && this.global1.regions[0].buildings[num68].is_builded && this.global1.regions[0].buildings[num68].is_working)
						{
							ptr = ref this.global1.science_time[num66];
							ref int ptr459 = ref ptr;
							num = ptr;
							ptr459 = num + 1;
						}
						if ((this.global1.regions[1].buildings[num68].type == 25 || this.global1.regions[1].buildings[num68].type == 9 || this.global1.regions[1].buildings[num68].type == 3 || this.global1.regions[1].buildings[num68].type == 16 || this.global1.regions[1].buildings[num68].type == 14) && this.global1.regions[1].buildings[num68].is_builded && this.global1.regions[1].buildings[num68].is_working)
						{
							ptr = ref this.global1.science_time[num66];
							ref int ptr460 = ref ptr;
							num = ptr;
							ptr460 = num + 1;
						}
						if ((this.global1.regions[2].buildings[num68].type == 25 || this.global1.regions[2].buildings[num68].type == 9 || this.global1.regions[2].buildings[num68].type == 3 || this.global1.regions[2].buildings[num68].type == 16 || this.global1.regions[2].buildings[num68].type == 14) && this.global1.regions[2].buildings[num68].is_builded && this.global1.regions[2].buildings[num68].is_working)
						{
							ptr = ref this.global1.science_time[num66];
							ref int ptr461 = ref ptr;
							num = ptr;
							ptr461 = num + 1;
						}
						if ((this.global1.regions[3].buildings[num68].type == 25 || this.global1.regions[3].buildings[num68].type == 9 || this.global1.regions[3].buildings[num68].type == 3 || this.global1.regions[3].buildings[num68].type == 16 || this.global1.regions[3].buildings[num68].type == 14) && this.global1.regions[3].buildings[num68].is_builded && this.global1.regions[3].buildings[num68].is_working)
						{
							ptr = ref this.global1.science_time[num66];
							ref int ptr462 = ref ptr;
							num = ptr;
							ptr462 = num + 1;
						}
						if ((this.global1.regions[4].buildings[num68].type == 25 || this.global1.regions[4].buildings[num68].type == 9 || this.global1.regions[4].buildings[num68].type == 3 || this.global1.regions[4].buildings[num68].type == 16 || this.global1.regions[4].buildings[num68].type == 14) && this.global1.regions[4].buildings[num68].is_builded && this.global1.regions[4].buildings[num68].is_working)
						{
							ptr = ref this.global1.science_time[num66];
							ref int ptr463 = ref ptr;
							num = ptr;
							ptr463 = num + 1;
						}
						num = num68;
					}
					if ((this.global1.data[12] == 5 && this.global1.data[0] == 4) || (this.global1.data[12] == 5 && this.global1.data[0] == 12) || (this.global1.data[13] == 9 && this.global1.data[0] == 18) || (this.global1.data[13] == 8 && this.global1.data[0] == 20) || (this.global1.data[12] == 4 && this.global1.data[0] == 10))
					{
						ptr = ref this.global1.science_time[num66];
						ref int ptr464 = ref ptr;
						num = ptr;
						ptr464 = num + 1;
					}
					if (this.global1.allcountries[38].Money)
					{
						ptr = ref this.global1.science_time[num66];
						ref int ptr465 = ref ptr;
						num = ptr;
						ptr465 = num + 1;
					}
					ptr = ref this.global1.science_time[num66];
					ptr -= num64;
					if (this.global1.science_time[num66] < num67)
					{
						this.global1.science_time[num66] = num67;
					}
					if (this.global1.science_time[num66] >= 360)
					{
						this.izuchenp = true;
						this.sci_num = num66;
					}
				}
				else if (this.global1.science_time[num66] >= 360 && !this.global1.science[num66])
				{
					this.global1.science[num66] = true;
					if (this.global1.data[0] == 10 || this.global1.data[0] == 12 || this.global1.data[0] == 18)
					{
						if (num66 == 3)
						{
							ptr = ref this.global1.data[24];
							ptr -= 3;
						}
						else if (num66 == 4)
						{
							ptr = ref this.global1.data[24];
							ref int ptr466 = ref ptr;
							num = ptr;
							ptr466 = num - 1;
							int num69 = 1;
							for (int num70 = 0; num70 < 15; num70 = num + 1)
							{
								if (!this.global1.regions[2].buildings[num70].is_builded)
								{
									this.global1.regions[2].buildings[num70].type = 2;
									this.global1.regions[2].buildings[num70].is_working = true;
									this.global1.regions[2].buildings[num70].is_private = false;
									this.global1.regions[2].buildings[num70].is_builded = true;
									num = num69;
									num69 = num + 1;
								}
								if (num69 > 1)
								{
									break;
								}
								num = num70;
							}
						}
						else if (num66 == 5 || num66 == 8)
						{
							ptr = ref this.global1.data[24];
							ptr -= 2;
						}
						else if (num66 == 6)
						{
							ptr = ref this.global1.data[24];
							ref int ptr467 = ref ptr;
							num = ptr;
							ptr467 = num - 1;
						}
						else if (num66 == 7)
						{
							ptr = ref this.global1.data[24];
							ref int ptr468 = ref ptr;
							num = ptr;
							ptr468 = num - 1;
							int num71 = 1;
							for (int num72 = 0; num72 < 15; num72 = num + 1)
							{
								if (!this.global1.regions[2].buildings[num72].is_builded)
								{
									this.global1.regions[2].buildings[num72].type = 1;
									this.global1.regions[2].buildings[num72].is_working = true;
									this.global1.regions[2].buildings[num72].is_private = false;
									this.global1.regions[2].buildings[num72].is_builded = true;
									num = num71;
									num71 = num + 1;
								}
								if (num71 > 1)
								{
									break;
								}
								num = num72;
							}
						}
					}
					else
					{
						if (num66 > 2 && num66 < 6)
						{
							ptr = ref this.global1.data[24];
							ptr -= 3;
						}
						else if (num66 > 5 && num66 < 7)
						{
							ptr = ref this.global1.data[24];
							ptr -= 2;
						}
						if (num66 > 7 && num66 < 9)
						{
							ptr = ref this.global1.data[24];
							ptr -= 5;
						}
					}
				}
				num = num66;
			}
			Debug.Log("RESEARCHDONE");
			if (this.global1.data[19] % 7 == 0)
			{
				for (int num73 = 1; num73 < array.Length; num73 = num + 1)
				{
					this.global1.data_old[num73] = this.global1.data[num73] - array[num73];
					num = num73;
				}
			}
			if (this.global1.data[3] + this.global1.data[22] / 100 <= 150 && this.global1.data[216] < 49)
			{
				if (this.global1.event_done[163])
				{
					this.crisis_event[1] = false;
					this.global1.data[46] = 1;
					GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
					GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
				}
				else
				{
					this.crisis_event[1] = true;
					this.DeathChoose(163);
				}
			}
			else if (this.global1.data[4] - this.global1.data[22] / 10 >= 990 || (this.global1.data[3] <= 300 && this.global1.data[4] - this.global1.data[22] / 10 >= 900) || (this.global1.data[3] <= 500 && this.global1.data[4] - this.global1.data[22] / 10 >= 950 && this.global1.data[216] < 49))
			{
				if (this.global1.event_done[162])
				{
					this.crisis_event[0] = false;
					this.global1.data[46] = 2;
					GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
					GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
				}
				else
				{
					this.crisis_event[0] = true;
					this.DeathChoose(162);
				}
			}
			else if ((this.global1.data[0] != 3 || this.global1.data[11] != 3) && (this.global1.data[1] < 250 || (!this.global1.allcountries[this.global1.data[0]].isOVD && this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.data[1] < 400 && this.global1.data[2] + this.global1.data[22] / 5 <= 100) || ((this.global1.allcountries[this.global1.data[0]].isOVD || !this.global1.allcountries[this.global1.data[0]].Vyshi) && this.global1.data[1] < 400 && this.global1.data[2] + this.global1.data[22] / 5 <= 400)) && this.global1.data[216] < 50)
			{
				if (this.global1.event_done[164])
				{
					this.crisis_event[2] = false;
					this.global1.data[46] = 3;
					GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
					GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
				}
				else
				{
					this.crisis_event[2] = true;
					this.DeathChoose(164);
				}
			}
			else if (this.global1.data[1] < 500 && this.global1.data[216] >= 50)
			{
				this.global1.data[46] = 49;
				GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
				GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
			}
			if (this.global1.data[19] == 1 && this.global1.data[20] == 1 && this.global1.data[21] == 1992)
			{
				this.Reborn();
			}
			if (this.global1.data[19] >= 6 && this.global1.data[20] == 11 && this.global1.data[21] == 1990)
			{
				this.global1.allcountries[31].subideology = 14;
				if (this.global1.allcountries[19].Gosstroy == 2)
				{
					this.global1.allcountries[19].subideology = 13;
				}
			}
			if (this.global1.data[19] >= 15 && this.global1.data[20] == 8 && this.global1.data[21] == 1991 && !this.global1.allcountries[22].Donat)
			{
				this.global1.allcountries[22].Gosstroy = 9;
				this.global1.allcountries[22].subideology = 2;
			}
			if (this.global1.data[20] == 4 && this.global1.data[21] == 1991)
			{
				this.global1.allcountries[26].subideology = 14;
			}
			if (this.global1.data[20] == 5 && this.global1.data[21] == 1991 && !this.global1.allcountries[35].Donat)
			{
				this.global1.allcountries[35].Gosstroy = 9;
				this.global1.allcountries[35].subideology = 2;
			}
			if (this.global1.data[20] == 5 && this.global1.data[21] == 1991)
			{
				this.global1.allcountries[38].subideology = 12;
			}
			if (this.global1.data[20] == 7 && this.global1.data[21] == 1993)
			{
				this.global1.allcountries[31].subideology = 13;
			}
			Debug.Log("END");
			if (this.global1.data[21] >= 1992)
			{
				if (this.global1.data[21] >= 1995)
				{
					if (!this.global1.allcountries[28].Vyshi)
					{
						this.global1.allcountries[28].Vyshi = true;
					}
					if (!this.global1.allcountries[27].Vyshi && this.global1.allcountries[7].Vyshi)
					{
						this.global1.allcountries[27].Vyshi = true;
					}
					if (!this.global1.allcountries[26].Vyshi && !this.global1.allcountries[26].Torg)
					{
						this.global1.allcountries[26].Vyshi = true;
					}
				}
				if (this.global1.data[21] >= 2004)
				{
					if (!this.global1.allcountries[2].Vyshi && !this.global1.allcountries[2].isSEV && !this.global1.allcountries[2].isOVD && this.global1.allcountries[2].Gosstroy >= 2)
					{
						this.global1.allcountries[2].Vyshi = true;
					}
					if (!this.global1.allcountries[3].Vyshi && !this.global1.allcountries[3].isSEV && !this.global1.allcountries[3].isOVD && this.global1.allcountries[3].Gosstroy >= 2)
					{
						this.global1.allcountries[3].Vyshi = true;
					}
					if (!this.global1.allcountries[4].Vyshi && !this.global1.allcountries[4].isSEV && !this.global1.allcountries[4].isOVD && this.global1.allcountries[4].Gosstroy >= 2)
					{
						this.global1.allcountries[4].Vyshi = true;
					}
				}
				if (this.global1.data[21] >= 2007)
				{
					if (!this.global1.allcountries[5].Vyshi && !this.global1.allcountries[5].isSEV && !this.global1.allcountries[5].isOVD && this.global1.allcountries[5].Gosstroy >= 2)
					{
						this.global1.allcountries[5].Vyshi = true;
					}
					if (!this.global1.allcountries[6].Vyshi && !this.global1.allcountries[6].isSEV && !this.global1.allcountries[6].isOVD && this.global1.allcountries[6].Gosstroy >= 2)
					{
						this.global1.allcountries[6].Vyshi = true;
					}
				}
				if (this.global1.data[21] >= 2009 && !this.global1.allcountries[20].Vyshi && !this.global1.allcountries[20].isSEV && !this.global1.allcountries[20].isOVD && this.global1.allcountries[20].Gosstroy >= 2)
				{
					this.global1.allcountries[20].Vyshi = true;
				}
			}
			if (this.global1.allcountries[17].Westalgie < 0)
			{
				this.global1.allcountries[17].Westalgie = 0;
			}
			else if (this.global1.allcountries[17].Westalgie > 1000)
			{
				this.global1.allcountries[17].Westalgie = 1000;
			}
			if (this.global1.data[0] == 18 && this.global1.data[77] == 0)
			{
				this.global1.allcountries[this.global1.data[0]].Vyshi = true;
			}
			if (this.global1.data[57] > 100 && this.global1.data[57] < 1000)
			{
				this.global1.data[57] = 1000;
			}
			if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
			{
				if (this.global1.data[177] == 3)
				{
					this.global1.allcountries[20].Gosstroy = this.global1.allcountries[15].Gosstroy;
					this.global1.allcountries[20].subideology = this.global1.allcountries[15].subideology;
					if (this.global1.allcountries[49].isSEV || this.global1.allcountries[50].isSEV || this.global1.allcountries[51].isSEV)
					{
						this.global1.allcountries[20].isSEV = true;
					}
					else
					{
						this.global1.allcountries[20].isSEV = false;
					}
					if (this.global1.allcountries[49].isOVD || this.global1.allcountries[50].isOVD || this.global1.allcountries[51].isOVD)
					{
						this.global1.allcountries[20].isOVD = true;
					}
					else
					{
						this.global1.allcountries[20].isOVD = false;
					}
					if (this.global1.allcountries[49].Vyshi || this.global1.allcountries[50].Vyshi || this.global1.allcountries[51].Vyshi)
					{
						this.global1.allcountries[20].Vyshi = true;
					}
					else
					{
						this.global1.allcountries[20].Vyshi = false;
					}
					this.global1.allcountries[20].Torg = false;
				}
				if (this.global1.data[149] == 3)
				{
					this.global1.allcountries[4].Gosstroy = this.global1.allcountries[15].Gosstroy;
					this.global1.allcountries[4].subideology = this.global1.allcountries[15].subideology;
					if (this.global1.allcountries[49].isSEV || this.global1.allcountries[50].isSEV || this.global1.allcountries[51].isSEV)
					{
						this.global1.allcountries[4].isSEV = true;
					}
					else
					{
						this.global1.allcountries[4].isSEV = false;
					}
					if (this.global1.allcountries[49].isOVD || this.global1.allcountries[50].isOVD || this.global1.allcountries[51].isOVD)
					{
						this.global1.allcountries[4].isOVD = true;
					}
					else
					{
						this.global1.allcountries[4].isOVD = false;
					}
					if (this.global1.allcountries[49].Vyshi || this.global1.allcountries[50].Vyshi || this.global1.allcountries[51].Vyshi)
					{
						this.global1.allcountries[4].Vyshi = true;
					}
					else
					{
						this.global1.allcountries[4].Vyshi = false;
					}
					this.global1.allcountries[4].Torg = false;
				}
				if (this.global1.data[235] == 9)
				{
					this.global1.allcountries[6].Gosstroy = this.global1.allcountries[15].Gosstroy;
					this.global1.allcountries[6].subideology = this.global1.allcountries[15].subideology;
					if (this.global1.allcountries[49].isSEV || this.global1.allcountries[50].isSEV || this.global1.allcountries[51].isSEV)
					{
						this.global1.allcountries[6].isSEV = true;
					}
					else
					{
						this.global1.allcountries[6].isSEV = false;
					}
					if (this.global1.allcountries[49].isOVD || this.global1.allcountries[50].isOVD || this.global1.allcountries[51].isOVD)
					{
						this.global1.allcountries[6].isOVD = true;
					}
					else
					{
						this.global1.allcountries[6].isOVD = false;
					}
					if (this.global1.allcountries[49].Vyshi || this.global1.allcountries[50].Vyshi || this.global1.allcountries[51].Vyshi)
					{
						this.global1.allcountries[6].Vyshi = true;
					}
					else
					{
						this.global1.allcountries[6].Vyshi = false;
					}
					this.global1.allcountries[6].Torg = false;
				}
			}
			if (this.global1.data[0] == 12)
			{
				this.global1.data[80] = 20;
				if (this.global1.data[90] == 1)
				{
					ptr = ref this.global1.data[80];
					ptr += 20;
				}
				if (this.global1.data[92] == 1)
				{
					ptr = ref this.global1.data[80];
					ptr += 20;
				}
				if (this.global1.data[93] == 1)
				{
					ptr = ref this.global1.data[80];
					ptr += 20;
				}
				if (this.global1.data[94] == 1)
				{
					ptr = ref this.global1.data[80];
					ptr += 20;
				}
				if (this.global1.data[88] == 0)
				{
					this.global1.data[107] = 0;
				}
				if (this.global1.data[108] >= 100 && this.global1.data[88] > 0)
				{
					ptr = ref this.global1.data[3];
					ptr += 70;
					ptr = ref this.global1.data[1];
					ptr += 100;
					ptr = ref this.global1.data[2];
					ptr += 120;
					ptr = ref this.global1.data[4];
					ptr -= 90;
					if (this.global1.data[88] == 1)
					{
						int num74;
						if (this.global1.data[107] > 1)
						{
							this.global1.data[this.global1.data[107] + 90] = 1;
							num74 = this.global1.data[107] + 90;
						}
						else
						{
							this.global1.data[90] = 1;
							num74 = 90;
						}
						if (num74 == 93)
						{
							num74 = 0;
						}
						else if (num74 == 92)
						{
							num74 = 1;
						}
						else if (num74 == 90)
						{
							num74 = 3;
						}
						else if (num74 == 94)
						{
							num74 = 4;
						}
						this.global1.regions[num74].buildings[1].type = 1;
						this.global1.regions[num74].buildings[1].is_builded = true;
						this.global1.regions[num74].buildings[1].is_working = true;
						this.global1.regions[num74].buildings[1].is_private = true;
						this.global1.regions[num74].buildings[2].type = 4;
						this.global1.regions[num74].buildings[2].is_builded = true;
						this.global1.regions[num74].buildings[2].is_working = true;
						this.global1.regions[num74].buildings[2].is_private = false;
					}
					this.global1.data[111] = 0;
					this.global1.data[88] = 0;
					this.global1.data[107] = 0;
					this.global1.data[108] = 0;
				}
				else if (this.global1.data[108] <= 0 && this.global1.data[88] > 0)
				{
					ptr = ref this.global1.data[3];
					ptr -= 70;
					ptr = ref this.global1.data[1];
					ptr -= 100;
					ptr = ref this.global1.data[4];
					ptr += 90;
					if (this.global1.data[88] == 2)
					{
						if (this.global1.data[107] > 9)
						{
							this.global1.data[46] = 11;
							SceneManager.LoadScene("Ending");
						}
						else
						{
							int num75;
							if (this.global1.data[107] > 1)
							{
								this.global1.data[this.global1.data[107] + 90] = 0;
								num75 = this.global1.data[107] + 90;
							}
							else
							{
								this.global1.data[90] = 0;
								num75 = 90;
							}
							if (num75 == 93)
							{
								num75 = 0;
							}
							else if (num75 == 92)
							{
								num75 = 1;
							}
							else if (num75 == 90)
							{
								num75 = 3;
							}
							else if (num75 == 94)
							{
								num75 = 4;
							}
							for (int num76 = 0; num76 < 15; num76 = num + 1)
							{
								this.global1.regions[num75].buildings[num76].type = 0;
								this.global1.regions[num75].buildings[num76].is_working = false;
								this.global1.regions[num75].buildings[num76].is_private = false;
								this.global1.regions[num75].buildings[num76].is_builded = false;
								num = num76;
							}
						}
					}
					this.global1.data[111] = 0;
					this.global1.data[88] = 0;
					this.global1.data[107] = 0;
					this.global1.data[108] = 0;
				}
			}
			if (this.global1.iron_and_blood)
			{
				if (this.global1.data[19] == 1 && this.global1.data[20] == 1 && this.global1.data[21] == 1990)
				{
					this.achieves.GetComponent<achievements>().Set(1);
					int num77 = 0;
					for (int num78 = 0; num78 < 7; num78 = num + 1)
					{
						if (this.global1.allcountries[num78].Gosstroy == 0 && this.global1.data[0] != num78 && num78 != 4 && num78 != 5)
						{
							num = num77;
							num77 = num + 1;
						}
						num = num78;
					}
					if (this.global1.allcountries[4].Gosstroy == 1)
					{
						num = num77;
						num77 = num + 1;
					}
					if (this.global1.allcountries[5].Gosstroy == 9)
					{
						num = num77;
						num77 = num + 1;
					}
					if (num77 >= 5)
					{
						this.achieves.GetComponent<achievements>().Set(2);
					}
				}
				if (this.global1.data[0] == 49 && this.yug1.gameState.yugregions[0].owner == 8 && this.yug1.gameState.yugregions[1].owner == 8 && this.yug1.gameState.yugregions[2].owner == 8 && this.yug1.gameState.yugregions[3].owner == 8 && this.yug1.gameState.yugregions[4].owner == 8 && this.yug1.gameState.yugregions[5].owner == 8 && this.yug1.gameState.yugregions[6].owner == 8 && this.yug1.gameState.yugregions[7].owner == 8 && this.yug1.gameState.yugregions[8].owner == 8 && this.yug1.gameState.yugregions[9].owner == 8 && this.yug1.gameState.yugregions[10].owner == 8 && this.yug1.gameState.yugregions[11].owner == 8 && this.global1.data[162] != 3)
				{
					this.achieves.GetComponent<achievements>().Set(120);
				}
				Debug.Log("ACHIEVDONE");
			}
			this.Recrisis();
			if (this.vybory)
			{
				this.Reelect();
			}
			else if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
			{
				this.CheckYugoWars();
			}
			if (this.global1.autosave > 0)
			{
				if (this.global1.autosave == 1 && this.global1.data[19] == 1)
				{
					this.Autosasvemethod();
				}
				else if (this.global1.autosave == 2 && this.global1.data[19] == 1 && this.global1.data[20] == 6)
				{
					this.Autosasvemethod();
				}
			}
		}
		base.GetComponent<TextMesh>().text = string.Concat(new object[]
		{
			this.global1.data[19],
			".",
			this.global1.data[20],
			".",
			this.global1.data[21]
		});
	}

	// Token: 0x040001A3 RID: 419
	public GameObject ending;

	// Token: 0x040001A4 RID: 420
	public GameObject view;

	// Token: 0x040001A5 RID: 421
	public bool is_showed;

	// Token: 0x040001A6 RID: 422
	private int save_speed;

	// Token: 0x040001A7 RID: 423
	private int this_num_event;

	// Token: 0x040001A8 RID: 424
	private int this_num_place;

	// Token: 0x040001A9 RID: 425
	private GlobalScript global1;

	// Token: 0x040001AA RID: 426
	private Yugoglobal yug1;

	// Token: 0x040001AB RID: 427
	public float now_time;

	// Token: 0x040001AC RID: 428
	private EvetnnashScript goto_economy;

	// Token: 0x040001AD RID: 429
	private SpeedScript goto_pause;

	// Token: 0x040001AE RID: 430
	public GameObject thishappened;

	// Token: 0x040001AF RID: 431
	public GameObject newcountries;

	// Token: 0x040001B0 RID: 432
	public GameObject probel;

	// Token: 0x040001B1 RID: 433
	public SpriteRenderer[] crisis = new SpriteRenderer[8];

	// Token: 0x040001B2 RID: 434
	public TextMesh[] crisis_color = new TextMesh[8];

	// Token: 0x040001B3 RID: 435
	public bool vybory;

	// Token: 0x040001B4 RID: 436
	private GameObject achieves;

	// Token: 0x040001B5 RID: 437
	public Sprite[] crisis_spr = new Sprite[2];

	// Token: 0x040001B6 RID: 438
	public GameObject crisis_show;

	// Token: 0x040001B7 RID: 439
	public GameObject[] special = new GameObject[2];

	// Token: 0x040001B8 RID: 440
	private bool donedone;

	// Token: 0x040001B9 RID: 441
	public at_war_script[] re_war = new at_war_script[9];

	// Token: 0x040001BA RID: 442
	public bool izuchenp;

	// Token: 0x040001BB RID: 443
	private int sci_num;

	// Token: 0x040001BC RID: 444
	public Savescript Autosavej;

	// Token: 0x040001BD RID: 445
	public bool[] crisis_event = new bool[3];

	// Token: 0x040001BE RID: 446
	public YugoMapManager yug_little;

	// Token: 0x040001BF RID: 447
	private MapChangesScript map1;

	// Token: 0x040001C0 RID: 448
	public GameObject[] events = new GameObject[26];
}
