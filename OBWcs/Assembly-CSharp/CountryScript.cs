using System;
using UnityEngine;

// Token: 0x0200000E RID: 14
public class CountryScript : MonoBehaviour
{
	// Token: 0x06000040 RID: 64 RVA: 0x0000CD00 File Offset: 0x0000AF00
	private void OnMouseEnter()
	{
		if (!this.rightwing)
		{
			this.Repaint();
		}
		else
		{
			this.Repaint_right(true);
		}
		this.sp.material.SetColor("_MainColor", new Color(0.4f, 0.4f, 0.4f));
	}

	// Token: 0x06000041 RID: 65 RVA: 0x0000237C File Offset: 0x0000057C
	private void OnMouseExit()
	{
		if (!this.rightwing)
		{
			this.Repaint();
			return;
		}
		this.Repaint_right(true);
	}

	// Token: 0x06000042 RID: 66 RVA: 0x0000CD50 File Offset: 0x0000AF50
	private void OnMouseDown()
	{
		if (this.this_number != 15 || this.global1.data[0] < 49 || this.global1.data[0] > 51)
		{
			if (this.okno1[0] == null)
			{
				this.okno1[0] = this.map1.okno.transform.Find("Znach (0)").GetComponent<OkoshkoScript>();
				this.okno1[1] = this.map1.okno.transform.Find("Znach (1)").GetComponent<OkoshkoScript>();
				this.okno1[2] = this.map1.okno.transform.Find("Znach (2)").GetComponent<OkoshkoScript>();
				this.okno1[3] = this.map1.okno.transform.Find("Znach (3)").GetComponent<OkoshkoScript>();
			}
			if (this.global1.data[0] != 999999)
			{
				this.map1.ShowHideOcno(true);
				this.map1.okno.transform.Find("Text (0)").GetComponent<TextMesh>().text = this.global1.allcountries[this.this_number].name;
				this.okno1[0].nonono = false;
				this.okno1[1].nonono = false;
				this.okno1[2].nonono = false;
				this.okno1[3].nonono = false;
				if (this.global1.allcountries[this.this_number].subideology < 0 || this.global1.allcountries[this.this_number].subideology >= 100)
				{
					if (this.global1.allcountries[this.this_number].Gosstroy == 0)
					{
						this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.znachki[1];
						if (PlayerPrefs.GetInt("language") == 0)
						{
							this.okno1[0].text_en = " 社 会 主 义";
						}
						else
						{
							this.okno1[0].text = "Социализм";
						}
					}
					else if (this.global1.allcountries[this.this_number].Gosstroy == 1)
					{
						this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.znachki[3];
						if (PlayerPrefs.GetInt("language") == 0)
						{
							this.okno1[0].text_en = " 改 良 主 义";
						}
						else
						{
							this.okno1[0].text = "Реформизм";
						}
					}
					else if (this.global1.allcountries[this.this_number].Gosstroy == 2)
					{
						this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.znachki[4];
						if (PlayerPrefs.GetInt("language") == 0)
						{
							this.okno1[0].text_en = " 自 由 主 义";
						}
						else
						{
							this.okno1[0].text = "Либерализм";
						}
					}
					else
					{
						this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.znachki[8];
						if (PlayerPrefs.GetInt("language") == 0)
						{
							this.okno1[0].text_en = " 威 权 主 义";
						}
						else
						{
							this.okno1[0].text = "Авторитаризм";
						}
					}
				}
				else if (this.global1.allcountries[this.this_number].subideology == 0)
				{
					this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.subIdZ[0];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[0].text_en = " 左 翼 民 族 主 义";
					}
					else
					{
						this.okno1[0].text = "Левый национализм";
					}
				}
				else if (this.global1.allcountries[this.this_number].subideology == 1)
				{
					this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.subIdZ[1];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[0].text_en = " 民 族 布 尔 什 维 主 义";
					}
					else
					{
						this.okno1[0].text = "Национал-большевизм";
					}
				}
				else if (this.global1.allcountries[this.this_number].subideology == 2)
				{
					this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.subIdZ[2];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[0].text_en = " 亲 市 场 独 裁 体 制";
					}
					else
					{
						this.okno1[0].text = "Рыночная диктатура";
					}
				}
				else if (this.global1.allcountries[this.this_number].subideology == 3)
				{
					this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.subIdZ[3];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[0].text_en = " 第 三 位 置";
					}
					else
					{
						this.okno1[0].text = "Третий путь";
					}
				}
				else if (this.global1.allcountries[this.this_number].subideology == 4)
				{
					this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.subIdZ[4];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[0].text_en = " 保 守 社 会 主 义";
					}
					else
					{
						this.okno1[0].text = "Консервативный социализм";
					}
				}
				else if (this.global1.allcountries[this.this_number].subideology == 5)
				{
					this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.subIdZ[5];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[0].text_en = " 托 洛 茨 基 主 义";
					}
					else
					{
						this.okno1[0].text = "Троцкизм";
					}
				}
				else if (this.global1.allcountries[this.this_number].subideology == 6)
				{
					this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.subIdZ[6];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[0].text_en = " 毛 主 义";
					}
					else
					{
						this.okno1[0].text = "Маоизм";
					}
				}
				else if (this.global1.allcountries[this.this_number].subideology == 7)
				{
					this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.subIdZ[7];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[0].text_en = " 反 修 正 主 义";
					}
					else
					{
						this.okno1[0].text = "Антиревизионизм";
					}
				}
				else if (this.global1.allcountries[this.this_number].subideology == 8)
				{
					this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.subIdZ[8];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[0].text_en = " 民 主 社 会 主 义";
					}
					else
					{
						this.okno1[0].text = "Демократический социализм";
					}
				}
				else if (this.global1.allcountries[this.this_number].subideology == 9)
				{
					this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.subIdZ[9];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[0].text_en = " 左 翼 社 会 民 主 主 义";
					}
					else
					{
						this.okno1[0].text = "Левая социал-демократия";
					}
				}
				else if (this.global1.allcountries[this.this_number].subideology == 10)
				{
					this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.subIdZ[10];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[0].text_en = " 红 色 保 守 主 义";
					}
					else
					{
						this.okno1[0].text = "Красный торизм";
					}
				}
				else if (this.global1.allcountries[this.this_number].subideology == 11)
				{
					this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.subIdZ[11];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[0].text_en = " 政 治 实 用 主 义";
					}
					else
					{
						this.okno1[0].text = "Политический прагматизм";
					}
				}
				else if (this.global1.allcountries[this.this_number].subideology == 12)
				{
					this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.subIdZ[12];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[0].text_en = " 中 间 主 义";
					}
					else
					{
						this.okno1[0].text = "Центризм";
					}
				}
				else if (this.global1.allcountries[this.this_number].subideology == 13)
				{
					this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.subIdZ[13];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[0].text_en = " 右 翼 社 会 民 主 主 义";
					}
					else
					{
						this.okno1[0].text = "Правая социал-демократия";
					}
				}
				else if (this.global1.allcountries[this.this_number].subideology == 14)
				{
					this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.subIdZ[14];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[0].text_en = " 自 由 保 守 主 义";
					}
					else
					{
						this.okno1[0].text = "Либерал-консерватизм";
					}
				}
				else if (this.global1.allcountries[this.this_number].subideology == 15)
				{
					this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.subIdZ[15];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[0].text_en = " 欧 洲 大 西 洋 主 义";
					}
					else
					{
						this.okno1[0].text = "Евроатлантизм";
					}
				}
				else if (this.global1.allcountries[this.this_number].subideology == 16)
				{
					this.map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = this.map1.subIdZ[16];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[0].text_en = " 社 会 主 义 泰 罗 制";
					}
					else
					{
						this.okno1[0].text = "Социалистический тейлоризм";
					}
				}
				if (this.global1.allcountries[this.this_number].isOVD && this.global1.allcountries[7].isOVD)
				{
					this.map1.okno.transform.Find("Znach (1)").GetComponent<SpriteRenderer>().sprite = this.map1.znachki[2];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[1].text_en = " 华 沙 条 约";
					}
					else
					{
						this.okno1[1].text = "Варшавский договор";
					}
				}
				else if (this.global1.allcountries[this.this_number].isOVD)
				{
					this.map1.okno.transform.Find("Znach (1)").GetComponent<SpriteRenderer>().sprite = this.map1.znachki[6];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[1].text_en = " 集 体 安 全 条 约 组 织";
					}
					else
					{
						this.okno1[1].text = "ОКБ";
					}
				}
				else
				{
					this.map1.okno.transform.Find("Znach (1)").GetComponent<SpriteRenderer>().sprite = null;
					this.okno1[1].nonono = true;
				}
				if (this.global1.allcountries[this.this_number].isSEV && this.global1.allcountries[7].isSEV)
				{
					this.map1.okno.transform.Find("Znach (2)").GetComponent<SpriteRenderer>().sprite = this.map1.znachki[5];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[2].text_en = " 经 互 会";
					}
					else
					{
						this.okno1[2].text = "СЭВ";
					}
				}
				else if (this.global1.allcountries[this.this_number].isSEV)
				{
					this.map1.okno.transform.Find("Znach (2)").GetComponent<SpriteRenderer>().sprite = this.map1.znachki[7];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[2].text_en = " 新 经 互 会";
					}
					else
					{
						this.okno1[2].text = "Новый СЭВ";
					}
				}
				else if (this.global1.allcountries[this.this_number].Torg)
				{
					this.map1.okno.transform.Find("Znach (2)").GetComponent<SpriteRenderer>().sprite = this.map1.znachki[9];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[2].text_en = " 紧 密 贸 易";
					}
					else
					{
						this.okno1[2].text = "Тесная торговля";
					}
				}
				else
				{
					this.map1.okno.transform.Find("Znach (2)").GetComponent<SpriteRenderer>().sprite = null;
					this.okno1[2].nonono = true;
				}
				if ((this.this_number == 4 && this.global1.data[149] == 3) || (this.this_number == 6 && (this.global1.data[161] == 1 || this.global1.data[161] == 3 || this.global1.data[235] == 9)) || (this.this_number == 27 && this.global1.event_done[441] && this.global1.allcountries[27].Torg) || (this.this_number == 20 && this.global1.data[177] == 3) || (this.this_number == 45 && (this.global1.data[161] == 1 || this.global1.data[161] == 3)))
				{
					this.map1.okno.transform.Find("Znach (3)").GetComponent<SpriteRenderer>().sprite = this.map1.znachki[10];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[3].text_en = " 受 南 斯 拉 夫 \n 影 响";
					}
					else
					{
						this.okno1[3].text = "Под влиянием \nЮгославии";
					}
				}
				else if (this.global1.allcountries[this.this_number].Vyshi)
				{
					this.map1.okno.transform.Find("Znach (3)").GetComponent<SpriteRenderer>().sprite = this.map1.znachki[0];
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.okno1[3].text_en = " 受 美 国 影 响";
					}
					else
					{
						this.okno1[3].text = "Под влиянием США";
					}
				}
				else
				{
					this.map1.okno.transform.Find("Znach (3)").GetComponent<SpriteRenderer>().sprite = null;
					this.okno1[3].nonono = true;
				}
				for (int i = 0; i < 4; i++)
				{
					this.map1.buttons[i].GetComponent<DiploButtonScript>().Hide();
					this.map1.buttons[i].GetComponent<DiploButtonScript>().selected_country = this.this_number;
				}
				if (this.global1.data[216] < 50)
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						if (this.this_number == this.global1.data[0])
						{
							if ((this.global1.data[0] != 10 || this.global1.data[11] == 3) && this.global1.data[0] != 12 && this.global1.data[0] != 38)
							{
								this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 开 放", 61);
								this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 付 款", 62);
								this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 关 闭", 63);
								return;
							}
							if (this.global1.data[0] == 12)
							{
								if (this.global1.data[88] == 0)
								{
									this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 侵 略", 77);
									return;
								}
								this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 增 援", 78);
								return;
							}
						}
						else
						{
							if (this.this_number == 21)
							{
								this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 投 资", 1);
								this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 友 谊", 2);
								return;
							}
							if (this.this_number == 0)
							{
								if (this.global1.data[0] != 10 && this.global1.data[0] != 12 && this.global1.data[0] != 18 && (this.global1.data[0] < 49 || this.global1.data[0] > 51))
								{
									this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 整 合", 3);
								}
								if (this.global1.data[0] != 12)
								{
									this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 缓 和", 54);
								}
								this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 投 资", 80);
								this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 民 主", 119);
								return;
							}
							if (this.this_number == 54)
							{
								if (this.global1.data[0] != 12 || this.global1.science[2])
								{
									this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 旅 团", 83);
								}
								if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
								{
									this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 国 家 安 全 局", 82);
								}
								else if (this.global1.data[0] != 12 || this.global1.science[2])
								{
									this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 侦 察", 82);
								}
								this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 贸 易", 84);
								this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 和 平", 99);
								return;
							}
							if (this.this_number == 53)
							{
								this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 贸 易", 84);
								if (this.global1.data[0] != 12 || this.global1.science[2])
								{
									this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 北 塞 浦 路 斯", 87);
									return;
								}
							}
							else if (this.this_number == 52)
							{
								this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 贸 易", 88);
								this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 联 盟", 86);
								if (this.global1.data[0] != 12 || this.global1.science[2])
								{
									this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 库 工 党", 96);
									return;
								}
							}
							else if (this.this_number == 14)
							{
								this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 禁 运", 4);
								this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 贸 易", 5);
								this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 联 盟", 23);
								if (this.global1.data[0] != 12 || this.global1.science[2])
								{
									this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 合 约", 101);
									return;
								}
							}
							else
							{
								if (this.this_number == 13)
								{
									if (!this.global1.allcountries[this.this_number].Donat)
									{
										this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 承 认", 6);
									}
									else
									{
										this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 物 资", 6);
									}
									if (!this.global1.allcountries[this.this_number].Stasi)
									{
										this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 支 持", 7);
									}
									else
									{
										this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 干 预", 7);
									}
									this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 渠 道", 8);
									this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 联 盟", 28);
									return;
								}
								if (this.this_number == 12)
								{
									this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 人 道 主 义", 9);
									this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 军 事", 10);
									return;
								}
								if (this.this_number == 17)
								{
									if (this.global1.data[0] != 12 || this.global1.science[2])
									{
										if (!this.global1.event_done[58] || this.global1.eventVariantChosen[58] != 0)
										{
											this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 红 军 旅", 11);
										}
										else
										{
											this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 斯 特 拉 瑟 主 义 者", 11);
										}
									}
									this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 和 平", 12);
									this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 贸 易", 84);
									return;
								}
								if (this.this_number == 15)
								{
									if (this.global1.data[0] != 12 || this.global1.science[2])
									{
										this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 帮 助", 13);
										this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 米 洛 舍 维 奇", 14);
										this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 分 离 主 义 者", 15);
										this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 协 议", 51);
										return;
									}
								}
								else
								{
									if (this.this_number == 16)
									{
										this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 关 系", 16);
										this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 贸 易", 17);
										this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 海 关", 18);
										this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 消 灭", 44);
										return;
									}
									if (this.this_number == 23 && this.global1.event_done[17])
									{
										this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 贸 易", 17);
										if (this.global1.data[0] != 12 || this.global1.science[2])
										{
											this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 投 资", 53);
										}
										this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 联 盟", 91);
										return;
									}
									if (this.this_number == 34)
									{
										this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 贸 易", 84);
										if (this.global1.allcountries[34].Gosstroy == 2)
										{
											this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 联 盟", 89);
											return;
										}
									}
									else if (this.this_number == 19)
									{
										this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 协 议", 19);
										this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 庇 护", 20);
										if (this.global1.data[0] != 10)
										{
											this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 挑 衅", 45);
											return;
										}
									}
									else if (this.this_number == 8)
									{
										if (this.global1.data[0] != 12)
										{
											this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 外 交", 21);
											this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 贸 易", 22);
											this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 经 济", 23);
											this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 协 议", 101);
											return;
										}
									}
									else if (this.this_number == 7)
									{
										if (this.global1.data[0] != 20 && this.global1.data[0] != 10 && this.global1.data[0] != 12)
										{
											this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 贷 款", 25);
										}
										if (this.global1.data[0] != 12 || this.global1.science[2])
										{
											this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 保 守 派", 24);
										}
										if (this.global1.data[0] != 18 && this.global1.data[0] != 12)
										{
											this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 购 买", 50);
										}
										if (this.global1.data[0] == 5)
										{
											this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 摩 尔 达 维 亚", 57);
										}
										if (this.global1.data[0] != 18 && this.global1.data[0] != 12 && this.global1.event_done[34] && !this.global1.event_done[53])
										{
											this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 普 里 马 科 夫", 113);
											return;
										}
									}
									else if (this.this_number == 10)
									{
										this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 执 照", 26);
										this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 分 析 师", 27);
										this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 科 技", 43);
										if (!this.global1.allcountries[this.this_number].isSEV)
										{
											this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 联 盟", 56);
											return;
										}
										this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 影 响", 81);
										return;
									}
									else
									{
										if (this.this_number == 11)
										{
											this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 联 盟", 28);
											this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 贸 易", 120);
											return;
										}
										if (this.this_number == 18)
										{
											this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 联 盟", 28);
											return;
										}
										if (this.this_number == 47)
										{
											this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 贸 易", 84);
											this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 联 盟", 28);
											if (this.global1.allcountries[47].Gosstroy == 1 && this.global1.event_done[253])
											{
												this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 帮 助", 112);
												return;
											}
										}
										else if (this.this_number == 48)
										{
											if (this.global1.data[0] != 12 || this.global1.science[2])
											{
												this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 友 谊", 79);
												this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 投 资", 80);
												return;
											}
										}
										else if (this.this_number == 20)
										{
											if (this.global1.data[0] != 12 || this.global1.science[2])
											{
												this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 恢 复", 29);
												if (!this.global1.allcountries[this.global1.data[0]].Vyshi)
												{
													this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 联 盟", 30);
												}
												else
												{
													this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 整 合", 39);
												}
												if (this.global1.allcountries[20].Gosstroy == 2)
												{
													this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 民 主 派", 31);
												}
												else
												{
													this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 阿 利 雅", 31);
												}
												this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 同 盟", 37);
												return;
											}
										}
										else
										{
											if (this.this_number == 9)
											{
												this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 联 盟", 28);
												this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 支 持", 32);
												return;
											}
											if (this.this_number >= 1 && this.this_number <= 6)
											{
												if (this.global1.data[0] != 12 || this.global1.science[2])
												{
													if (this.global1.allcountries[this.global1.data[0]].Vyshi)
													{
														this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 邀 请", 33);
													}
													else if ((this.this_number != 6 && this.this_number != 4) || (!this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD))
													{
														this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 联 盟", 36);
													}
													else if (this.global1.allcountries[6].paths != 4 && this.this_number == 6)
													{
														this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 联 盟", 36);
													}
													else if (!this.global1.event_done[1045] && this.this_number == 4)
													{
														this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 联 盟", 36);
													}
													if (this.global1.allcountries[6].paths == 4 && this.this_number == 6 && this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
													{
														this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 南 斯 拉 夫 主 义 者", 97);
													}
													else
													{
														this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 资 助", 34);
													}
													this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 协 调", 35);
													this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 同 盟", 37);
													return;
												}
											}
											else
											{
												if (this.this_number == 28)
												{
													this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 深 度 贸 易", 38);
													this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 整 合", 39);
													return;
												}
												if (this.this_number == 27)
												{
													this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 深 度 贸 易", 38);
													this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 整 合", 39);
													if (this.global1.event_done[58] && this.global1.eventVariantChosen[58] == 0)
													{
														this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 自 由 党", 114);
														if (this.global1.allcountries[27].Donat)
														{
															this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 民 族 主 义 者", 115);
															this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 自 由 派", 116);
														}
														if (this.global1.allcountries[27].Westalgie >= 1 && this.global1.allcountries[27].Help)
														{
															this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 诺 贝 特 · 布 格 尔", 117);
															this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 人 民 党", 118);
														}
														if (this.global1.allcountries[27].Westalgie >= 1 && this.global1.allcountries[27].Money)
														{
															this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 诺 贝 特 · 布 格 尔", 117);
															this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 社 会 党", 118);
															return;
														}
													}
												}
												else
												{
													if (this.this_number == 26)
													{
														this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 深 度 贸 易", 38);
														this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 整 合", 39);
														return;
													}
													if (this.this_number == 30)
													{
														this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 恢 复", 40);
														this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 联 盟", 41);
														if (this.global1.data[237] >= 2)
														{
															this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 谈 判", 102);
															return;
														}
														if (this.global1.data[0] != 12 || this.global1.science[2])
														{
															this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 帮 助", 34);
															return;
														}
													}
													else if (this.this_number == 33)
													{
														if (this.global1.allcountries[33].Gosstroy == 9 || this.global1.allcountries[33].Gosstroy == 0)
														{
															this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 外 交", 42);
														}
														else if (this.global1.data[230] >= 2 && this.global1.data[231] >= 2 && this.global1.allcountries[33].Gosstroy != 2)
														{
															this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 谈 判", 95);
														}
														else
														{
															this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 贸 易", 84);
														}
														this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 联 盟", 41);
														if (this.global1.allcountries[33].Gosstroy == 1 && this.global1.allcountries[33].subideology != 9)
														{
															this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 民 主 派", 93);
														}
														if (this.global1.allcountries[33].Gosstroy == 1 && this.global1.allcountries[33].subideology != 9)
														{
															this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 恢 委 会", 94);
															return;
														}
													}
													else if (this.this_number == 31)
													{
														if (this.global1.data[0] != 12)
														{
															this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 制 裁", 46);
															this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 撤 回", 52);
															this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 贸 易", 84);
															return;
														}
													}
													else
													{
														if (this.this_number == 35)
														{
															this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 黎 巴 嫩", 47);
															this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 贸 易", 17);
															this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 联 盟", 28);
															this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 帮 助", 34);
															return;
														}
														if (this.this_number == 37)
														{
															if (this.global1.data[0] != 18 && this.global1.data[0] != 12)
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 购 买", 48);
																this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 叛 军", 96);
																this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 贸 易", 84);
																this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 武 器", 98);
																return;
															}
														}
														else if (this.this_number == 24)
														{
															if (this.global1.data[0] != 12 || this.global1.science[2])
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 石 油", 49);
																this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 投 资", 53);
																this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 联 盟", 28);
																return;
															}
														}
														else if (this.this_number == 25)
														{
															if (this.global1.allcountries[24].Gosstroy == this.global1.allcountries[25].Gosstroy)
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 也 门 社 会 党", 92);
																this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 石 油", 49);
																this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 投 资", 53);
																this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 联 盟", 89);
																return;
															}
														}
														else if (this.this_number == 39)
														{
															if (this.global1.data[0] != 12)
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 银 行", 55);
																return;
															}
														}
														else if (this.this_number == 38)
														{
															if (this.global1.allcountries[38].Torg)
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 关 系", 103);
															}
															else if (this.global1.allcountries[49].Donat)
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 贸 易", 17);
															}
															else if (this.global1.allcountries[49].Help)
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 主 席 团", 108);
															}
															else if (this.global1.data[0] != 12 || this.global1.science[2])
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 联 系", 107);
															}
															if (this.global1.data[0] != 12 || this.global1.science[2])
															{
																this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 武 器", 98);
															}
															if (this.global1.data[0] != 12 || this.global1.science[2])
															{
																this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 协 议", 109);
																return;
															}
														}
														else if (this.this_number >= 40 && this.this_number <= 43)
														{
															if (this.global1.data[0] != 12 || this.global1.science[2])
															{
																if (this.global1.allcountries[this.this_number].Westalgie == 1000)
																{
																	this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 联 盟", 30);
																}
																else if (this.global1.allcountries[this.this_number].Stasi)
																{
																	this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 帮 助", 105);
																}
																else
																{
																	this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 右 翼", 58);
																}
																if (this.global1.allcountries[this.this_number].Westalgie == 0)
																{
																	this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 联 盟", 89);
																}
																else if (this.global1.allcountries[this.this_number].Donat)
																{
																	this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 帮 助", 104);
																}
																else
																{
																	this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 左 翼", 59);
																}
																this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 人 道 主 义", 60);
																if (this.global1.allcountries[this.this_number].Westalgie == 1000 || this.global1.allcountries[this.this_number].Westalgie == 0)
																{
																	this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 资 源", 64);
																	return;
																}
																this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 船 队", 106);
																return;
															}
														}
														else if (this.this_number == 44)
														{
															if (this.global1.data[0] != 12)
															{
																if (!this.global1.event_done[444] && this.global1.data[239] != 1)
																{
																	this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 日 本 共 产 党", 65);
																}
																else
																{
																	this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 投 资", 80);
																}
																if (!this.global1.event_done[444] || !this.global1.allcountries[44].Vyshi)
																{
																	this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 深 度 贸 易", 66);
																}
																else
																{
																	this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 深 度 贸 易", 84);
																}
																this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 左 派", 110);
																if (!this.global1.event_done[444] && this.global1.event_done[130] && this.global1.data[239] >= 3 && this.global1.data[239] <= 6)
																{
																	this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 支 持", 111);
																	return;
																}
															}
														}
														else
														{
															if (this.this_number == 45)
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 联 盟", 67);
																return;
															}
															if (this.this_number == 36)
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 友 谊", 68);
																return;
															}
															if (this.this_number == 46)
															{
																if (this.global1.data[0] != 12 || this.global1.science[2])
																{
																	if (this.global1.allcountries[46].Westalgie == 1 || (this.global1.data[20] < 3 && this.global1.data[21] == 1989))
																	{
																		this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 维 杰 维 拉", 69);
																	}
																	else
																	{
																		this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 人 民 解 放 阵 线", 100);
																	}
																	if (this.global1.allcountries[46].Westalgie == 1 || (this.global1.data[20] < 12 && this.global1.data[21] == 1989))
																	{
																		this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 安 保", 70);
																	}
																	else
																	{
																		this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 贸 易", 22);
																	}
																	this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 人 民 解 放 阵 线", 71);
																	this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 联 盟", 30);
																	return;
																}
															}
															else if (this.this_number == 29)
															{
																if (this.global1.data[0] != 12 || this.global1.science[2])
																{
																	this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 布 朗", 72);
																	this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 斯 普 林", 73);
																	this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 左 派", 74);
																	this.map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 贸 易", 84);
																	return;
																}
															}
															else if (this.this_number == 22 && (this.global1.data[0] != 12 || this.global1.science[2]))
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 丰 威 汉", 75);
																this.map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 派 系", 76);
																this.map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 联 盟", 90);
																return;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					else if (this.this_number == this.global1.data[0])
					{
						if ((this.global1.data[0] != 10 || this.global1.data[11] == 3) && this.global1.data[0] != 12 && this.global1.data[0] != 38)
						{
							this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Открытые", 61);
							this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Платная", 62);
							this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Закрыть", 63);
							return;
						}
						if (this.global1.data[0] == 12)
						{
							if (this.global1.data[88] == 0)
							{
								this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Наступление", 77);
								return;
							}
							this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Подкрепления", 78);
							return;
						}
						else if (this.global1.data[0] == 38)
						{
							this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Армия", 85);
							return;
						}
					}
					else
					{
						if (this.this_number == 21)
						{
							this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Инвестиции", 1);
							this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Дружба", 2);
							return;
						}
						if (this.this_number == 0)
						{
							if (this.global1.data[0] != 10 && this.global1.data[0] != 12 && this.global1.data[0] != 18 && (this.global1.data[0] < 49 || this.global1.data[0] > 51))
							{
								this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Интеграция", 3);
							}
							if (this.global1.data[0] != 12)
							{
								this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Разрядка", 54);
							}
							this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Инвестиции", 80);
							this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Демократизм", 119);
							return;
						}
						if (this.this_number == 54)
						{
							if (this.global1.data[0] != 12 || this.global1.science[2])
							{
								this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Боевые Ядра", 83);
							}
							if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
							{
								this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("УДБА", 82);
							}
							else if (this.global1.data[0] != 12 || this.global1.science[2])
							{
								this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Разведка", 82);
							}
							this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Торговля", 84);
							this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Мир", 99);
							return;
						}
						if (this.this_number == 53)
						{
							this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 84);
							if (this.global1.data[0] != 12 || this.global1.science[2])
							{
								this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("ТРСК", 87);
								return;
							}
						}
						else
						{
							if (this.this_number == 52)
							{
								this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 88);
								if (this.global1.data[0] != 12 || this.global1.science[2])
								{
									this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 86);
								}
								this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("РПК", 96);
								return;
							}
							if (this.this_number == 14)
							{
								this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Эмбарго", 4);
								this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 5);
								this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Союз", 23);
								if (this.global1.data[0] != 12 || this.global1.science[2])
								{
									this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Контракты", 101);
									return;
								}
							}
							else
							{
								if (this.this_number == 13)
								{
									if (!this.global1.allcountries[this.this_number].Donat)
									{
										this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Признать", 6);
									}
									else
									{
										this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Поcтавки", 6);
									}
									if (!this.global1.allcountries[this.this_number].Stasi)
									{
										this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Поддержать", 7);
									}
									else
									{
										this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Вмешаться", 7);
									}
									this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Канал", 8);
									this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Союз", 28);
									return;
								}
								if (this.this_number == 12)
								{
									this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Гуманитарная", 9);
									this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Военная", 10);
									return;
								}
								if (this.this_number == 17)
								{
									if (this.global1.data[0] != 12 || this.global1.science[2])
									{
										if (!this.global1.event_done[58] || this.global1.eventVariantChosen[58] != 0)
										{
											this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("RAF", 11);
										}
										else
										{
											this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Штрассеристы", 11);
										}
									}
									this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Мир", 12);
									this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Торговля", 84);
									return;
								}
								if (this.this_number == 15)
								{
									if (this.global1.data[0] != 12 || this.global1.science[2])
									{
										this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Помощь", 13);
										this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Милошевич", 14);
										this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Сепаратисты", 15);
										this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Договор", 51);
										return;
									}
								}
								else
								{
									if (this.this_number == 16)
									{
										this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Отношения", 16);
										this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 17);
										this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Таможня", 18);
										this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Устранение", 44);
										return;
									}
									if (this.this_number == 23 && this.global1.event_done[17])
									{
										this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 17);
										if (this.global1.data[0] != 12 || this.global1.science[2])
										{
											this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Инвестиции", 53);
										}
										this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Союз", 91);
										return;
									}
									if (this.this_number == 34)
									{
										this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 84);
										if (this.global1.allcountries[34].Gosstroy == 2)
										{
											this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 89);
											return;
										}
									}
									else if (this.this_number == 19)
									{
										this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Контракт", 19);
										this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Убежище", 20);
										if (this.global1.data[0] != 10)
										{
											this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Провокация", 45);
											return;
										}
									}
									else if (this.this_number == 8)
									{
										if (this.global1.data[0] != 12)
										{
											this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Дипломатия", 21);
											this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 22);
											this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Экономика", 23);
											this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Контракты", 101);
											return;
										}
									}
									else if (this.this_number == 7)
									{
										if (this.global1.data[0] != 20 && this.global1.data[0] != 10 && this.global1.data[0] != 12)
										{
											this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Кредит", 25);
										}
										if (this.global1.data[0] != 12 || this.global1.science[2])
										{
											this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Консерваторы", 24);
										}
										if (this.global1.data[0] != 18 && this.global1.data[0] != 12)
										{
											this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Купить", 50);
										}
										if (this.global1.data[0] == 5)
										{
											this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Молдавия", 57);
										}
										if (this.global1.data[0] != 18 && this.global1.data[0] != 12 && this.global1.event_done[34] && !this.global1.event_done[53])
										{
											this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Примаков", 113);
											return;
										}
									}
									else if (this.this_number == 10)
									{
										this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Лицензии", 26);
										this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Аналитики", 27);
										this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Технологии", 43);
										if (!this.global1.allcountries[this.this_number].isSEV)
										{
											this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Союз", 56);
											return;
										}
										this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Повлиять", 81);
										return;
									}
									else
									{
										if (this.this_number == 11)
										{
											this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Союз", 28);
											this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 120);
											return;
										}
										if (this.this_number == 18)
										{
											this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Союз", 28);
											return;
										}
										if (this.this_number == 47)
										{
											this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 84);
											this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 28);
											if (this.global1.allcountries[47].Gosstroy == 1 && this.global1.event_done[253])
											{
												this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Помощь", 112);
												return;
											}
										}
										else if (this.this_number == 48)
										{
											if (this.global1.data[0] != 12 || this.global1.science[2])
											{
												this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Дружба", 79);
												this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Инвестиции", 80);
												return;
											}
										}
										else if (this.this_number == 20)
										{
											if (this.global1.data[0] != 12 || this.global1.science[2])
											{
												this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Восстановить", 29);
												if (!this.global1.allcountries[this.global1.data[0]].Vyshi)
												{
													this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 30);
												}
												else
												{
													this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Интеграция", 39);
												}
												if (this.global1.allcountries[20].Gosstroy == 2)
												{
													this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Демократы", 31);
												}
												else
												{
													this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Алия", 31);
												}
												this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Альянс", 37);
												return;
											}
										}
										else
										{
											if (this.this_number == 9)
											{
												this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Союз", 28);
												this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Поддержка", 32);
												return;
											}
											if (this.this_number >= 1 && this.this_number <= 6)
											{
												if (this.global1.data[0] != 12 || this.global1.science[2])
												{
													if (this.global1.allcountries[this.global1.data[0]].Vyshi)
													{
														this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Пригласить", 33);
													}
													else if ((this.this_number != 6 && this.this_number != 4) || (!this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD))
													{
														this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Союз", 36);
													}
													else if (this.global1.allcountries[6].paths != 4 && this.this_number == 6)
													{
														this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Союз", 36);
													}
													else if (!this.global1.event_done[1045] && this.this_number == 4)
													{
														this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Союз", 36);
													}
													if (this.global1.allcountries[6].paths == 4 && this.this_number == 6 && this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
													{
														this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Югослависты", 97);
													}
													else
													{
														this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Финансы", 34);
													}
													this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Координация", 35);
													this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Альянс", 37);
													return;
												}
											}
											else
											{
												if (this.this_number == 28)
												{
													this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Углубить", 38);
													this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Интеграция", 39);
													return;
												}
												if (this.this_number == 27)
												{
													this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Углубить", 38);
													this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Интеграция", 39);
													if (this.global1.event_done[58] && this.global1.eventVariantChosen[58] == 0)
													{
														this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("АПС", 114);
														if (this.global1.allcountries[27].Donat)
														{
															this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Националисты", 115);
															this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Либералы", 116);
														}
														if (this.global1.allcountries[27].Westalgie >= 1 && this.global1.allcountries[27].Help)
														{
															this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Н. Бургер", 117);
															this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("АНП", 118);
														}
														if (this.global1.allcountries[27].Westalgie >= 1 && this.global1.allcountries[27].Money)
														{
															this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Н. Бургер", 117);
															this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("СПА", 118);
															return;
														}
													}
												}
												else
												{
													if (this.this_number == 26)
													{
														this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Углубить", 38);
														this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Интеграция", 39);
														return;
													}
													if (this.this_number == 30)
													{
														this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Восстановить", 40);
														this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 41);
														if (this.global1.data[237] >= 2)
														{
															this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Переговоры", 102);
															return;
														}
														if (this.global1.data[0] != 12 || this.global1.science[2])
														{
															this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Помощь", 34);
															return;
														}
													}
													else if (this.this_number == 33)
													{
														if (this.global1.allcountries[33].Gosstroy == 9 || this.global1.allcountries[33].Gosstroy == 0)
														{
															this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Дипломатия", 42);
														}
														else if (this.global1.data[230] >= 2 && this.global1.data[231] >= 2 && this.global1.allcountries[33].Gosstroy != 2)
														{
															this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Переговоры", 95);
														}
														else
														{
															this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 84);
														}
														this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 41);
														if (this.global1.allcountries[33].Gosstroy == 1 && this.global1.allcountries[33].subideology != 9)
														{
															this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Демократы", 93);
														}
														if (this.global1.allcountries[33].Gosstroy == 1 && this.global1.allcountries[33].subideology != 9)
														{
															this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("ГСВП", 94);
															return;
														}
													}
													else if (this.this_number == 31)
													{
														if (this.global1.data[0] != 12)
														{
															this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Санкции", 46);
															this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Снять", 52);
															this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Торговля", 84);
															return;
														}
													}
													else
													{
														if (this.this_number == 35)
														{
															this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Ливан", 47);
															this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 17);
															this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Союз", 28);
															this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Помощь", 34);
															return;
														}
														if (this.this_number == 37)
														{
															if (this.global1.data[0] != 18 && this.global1.data[0] != 12)
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Купить", 48);
																this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Повстанцы", 96);
																this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Торговля", 84);
																this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Оружие", 98);
																return;
															}
														}
														else if (this.this_number == 24)
														{
															if ((this.global1.data[0] != 12 || this.global1.science[2]) && this.global1.allcountries[24].Gosstroy != this.global1.allcountries[25].Gosstroy)
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Нефть", 49);
																this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Инвестиции", 53);
																this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Союз", 28);
																return;
															}
														}
														else if (this.this_number == 25)
														{
															if (this.global1.allcountries[24].Gosstroy == this.global1.allcountries[25].Gosstroy)
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("ЙСП", 92);
																this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Нефть", 49);
																this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Инвестиции", 53);
																this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Союз", 89);
																return;
															}
														}
														else if (this.this_number == 39)
														{
															if (this.global1.data[0] != 12)
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Банк", 55);
																return;
															}
														}
														else if (this.this_number == 38)
														{
															if (this.global1.allcountries[38].Torg)
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Отношения", 103);
															}
															else if (this.global1.allcountries[49].Donat)
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 17);
															}
															else if (this.global1.allcountries[49].Help)
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Бюро", 108);
															}
															else if (this.global1.data[0] != 12 || this.global1.science[2])
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Контакты", 107);
															}
															if (this.global1.data[0] != 12 || this.global1.science[2])
															{
																this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Оружие", 98);
															}
															if (this.global1.data[0] != 12 || this.global1.science[2])
															{
																this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Контракты", 109);
																return;
															}
														}
														else if (this.this_number >= 40 && this.this_number <= 43)
														{
															if (this.global1.data[0] != 12 || this.global1.science[2])
															{
																if (this.global1.allcountries[this.this_number].Westalgie == 1000)
																{
																	this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 30);
																}
																else if (this.global1.allcountries[this.this_number].Stasi)
																{
																	this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Помощь", 105);
																}
																else
																{
																	this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Правые", 58);
																}
																if (this.global1.allcountries[this.this_number].Westalgie == 0)
																{
																	this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Союз", 89);
																}
																else if (this.global1.allcountries[this.this_number].Donat)
																{
																	this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Помощь", 104);
																}
																else
																{
																	this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Левые", 59);
																}
																this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Гуманитарная", 60);
																if (this.global1.allcountries[this.this_number].Westalgie == 1000 || this.global1.allcountries[this.this_number].Westalgie == 0)
																{
																	this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Ресурсы", 64);
																	return;
																}
																this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Конвой", 106);
																return;
															}
														}
														else if (this.this_number == 44)
														{
															if (this.global1.data[0] != 12)
															{
																if (!this.global1.event_done[444] && this.global1.data[239] != 1)
																{
																	this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("КПЯ", 65);
																}
																else
																{
																	this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Инвестиции", 80);
																}
																if (!this.global1.event_done[444] || !this.global1.allcountries[44].Vyshi)
																{
																	this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 66);
																}
																else
																{
																	this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 84);
																}
																this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Левые", 110);
																if (!this.global1.event_done[444] && this.global1.event_done[130] && this.global1.data[239] >= 3 && this.global1.data[239] <= 6)
																{
																	this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Поддержка", 111);
																	return;
																}
															}
														}
														else
														{
															if (this.this_number == 45)
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Союз", 67);
																return;
															}
															if (this.this_number == 36)
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Дружба", 68);
																return;
															}
															if (this.this_number == 46)
															{
																if (this.global1.data[0] != 12 || this.global1.science[2])
																{
																	if (this.global1.allcountries[46].Westalgie == 1 || (this.global1.data[20] < 3 && this.global1.data[21] == 1989))
																	{
																		this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Виджевир", 69);
																	}
																	else
																	{
																		this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("ДВП", 100);
																	}
																	if (this.global1.allcountries[46].Westalgie == 1 || (this.global1.data[20] < 12 && this.global1.data[21] == 1989))
																	{
																		this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Безопасность", 70);
																	}
																	else
																	{
																		this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 22);
																	}
																	this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("НОФ", 71);
																	this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Союз", 30);
																	return;
																}
															}
															else if (this.this_number == 29)
															{
																if (this.global1.data[0] != 12 || this.global1.science[2])
																{
																	this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Браун", 72);
																	this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Спринг", 73);
																	this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Левые", 74);
																	this.map1.buttons[3].GetComponent<DiploButtonScript>().Show("Торговля", 84);
																	return;
																}
															}
															else if (this.this_number == 22 && (this.global1.data[0] != 12 || this.global1.science[2]))
															{
																this.map1.buttons[0].GetComponent<DiploButtonScript>().Show("Фомвихан", 75);
																this.map1.buttons[1].GetComponent<DiploButtonScript>().Show("Фракция", 76);
																this.map1.buttons[2].GetComponent<DiploButtonScript>().Show("Союз", 90);
																return;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		else
		{
			this.vkladka.SetActive(!this.vkladka.activeSelf);
			this.vkladka.GetComponent<YugoMapManager>().AddButtons(false);
			this.vkladka.GetComponent<YugoMapManager>().Repaint();
		}
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00012164 File Offset: 0x00010364
	public void Repaint_right(bool nado = true)
	{
		if (this.global1 == null)
		{
			this.map1 = GameObject.Find("MapChanges").GetComponent<MapChangesScript>();
			this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		}
		if (nado)
		{
			this.sp = base.GetComponent<SpriteRenderer>();
			this.sp.sprite = this.grey;
			this.sp.material.SetColor("_MainColor", new Color(0f, 0f, 0f));
		}
		if (this.global1.data[0] == this.this_number)
		{
			if (this.global1.data[14] <= 0)
			{
				this.global1.allcountries[this.global1.data[0]].Gosstroy = 9;
				return;
			}
			if (this.global1.data[14] <= 2)
			{
				this.global1.allcountries[this.global1.data[0]].Gosstroy = 0;
				return;
			}
			if (this.global1.data[14] <= 3)
			{
				this.global1.allcountries[this.global1.data[0]].Gosstroy = 1;
				return;
			}
			if (this.global1.data[14] == 25)
			{
				this.global1.allcountries[this.global1.data[0]].Gosstroy = 6;
				return;
			}
			this.global1.allcountries[this.global1.data[0]].Gosstroy = 2;
		}
	}

	// Token: 0x06000044 RID: 68 RVA: 0x000122F0 File Offset: 0x000104F0
	public void Repaint()
	{
		this.map1 = GameObject.Find("MapChanges").GetComponent<MapChangesScript>();
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.sp = base.GetComponent<SpriteRenderer>();
		if (this.this_number == 1)
		{
			if (this.global1.allcountries[1].Gosstroy == 2 && this.global1.data[0] != 1 && !this.global1.allcountries[1].isSEV && !this.global1.allcountries[1].isOVD)
			{
				this.this_number = 17;
			}
		}
		else if (this.this_number == 24)
		{
			if (this.global1.allcountries[24].Gosstroy == 2)
			{
				this.this_number = 25;
			}
		}
		else if (this.this_number == 36)
		{
			if (this.global1.event_done[53] && !this.global1.event_done[81] && !this.global1.allcountries[36].Vyshi)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					this.global1.allcountries[this.this_number].name = " 科 威 特 省";
				}
				else
				{
					this.global1.allcountries[this.this_number].name = "Ас-Саддамия";
				}
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				this.global1.allcountries[this.this_number].name = " 科 威 特";
			}
			else
			{
				this.global1.allcountries[this.this_number].name = "Кувейт";
			}
		}
		else if (this.this_number == 5)
		{
			if (this.global1.event_done[1044])
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					this.global1.allcountries[this.this_number].name = " 匈 属 罗 马 尼 亚";
				}
				else
				{
					this.global1.allcountries[this.this_number].name = "Венг. Румыния";
				}
			}
		}
		else if (this.this_number == 4)
		{
			if (this.global1.data[149] == 3)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					this.global1.allcountries[this.this_number].name = " 大 伏 伊 伏 丁 那";
				}
				else
				{
					this.global1.allcountries[this.this_number].name = "Большая\nВоеводина";
				}
			}
		}
		else if (this.this_number == 6)
		{
			if (this.global1.data[235] == 9)
			{
				if (PlayerPrefs.GetInt("language") == 0)
				{
					this.global1.allcountries[6].name = " 南 斯 拉 夫 属\n 保 加 利 亚";
				}
				else
				{
					this.global1.allcountries[6].name = "Югославская\nБолгария";
				}
			}
		}
		else if (this.this_number == 20 && this.global1.data[177] == 3)
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				this.global1.allcountries[20].name = " 南 斯 拉 夫 属\n 阿 尔 巴 尼 亚";
			}
			else
			{
				this.global1.allcountries[20].name = "Югославская\nАлбания";
			}
		}
		if (this.global1.data[216] >= 50)
		{
			for (int i = 0; i < 55; i++)
			{
				if (i == 49 || i == 50 || i == 51)
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.allcountries[15].name = " 中 央 区";
					}
					else
					{
						this.global1.allcountries[15].name = "Центральный\nокруг";
					}
				}
				else if (i == 6)
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.allcountries[6].name = " 中 央 区";
					}
					else
					{
						this.global1.allcountries[6].name = "Центральный\nокруг";
					}
				}
				else if (i == 20)
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.allcountries[20].name = " 中 央 区";
					}
					else
					{
						this.global1.allcountries[20].name = "Центральный\nокруг";
					}
				}
				else if (i == 45)
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.allcountries[45].name = " 中 央 区";
					}
					else
					{
						this.global1.allcountries[45].name = "Центральный\nокруг";
					}
				}
				else if (i == 0)
				{
					if (PlayerPrefs.GetInt("language") == 0)
					{
						this.global1.allcountries[0].name = " 西 区";
					}
					else
					{
						this.global1.allcountries[0].name = "Западные\nокруга";
					}
				}
				else if (PlayerPrefs.GetInt("language") == 0)
				{
					this.global1.allcountries[i].name = " 第" + (i + 3).ToString() + " 区";
				}
				else
				{
					this.global1.allcountries[i].name = "Округ №" + (i + 3).ToString();
				}
			}
		}
		this.sp.sprite = this.grey;
		this.sp.material.SetColor("_MainColor", new Color(0f, 0f, 0f));
		if (this.global1.map_type == 0)
		{
			if (this.global1.allcountries[this.this_number].isOVD)
			{
				this.sp.material.SetColor("_MainColor2", new Color(0f, 1f, 1f, 0f));
			}
			else if (this.global1.allcountries[this.this_number].Vyshi)
			{
				this.sp.material.SetColor("_MainColor", new Color(0f, 0f, 0.46f));
				this.sp.material.SetColor("_MainColor2", new Color(1f, 0.48f, 0f, 0f));
			}
			else
			{
				this.sp.material.SetColor("_MainColor2", new Color(0f, 0f, 0f, 0f));
			}
			this.Repaint_right(false);
		}
		else if (this.global1.map_type == 2)
		{
			if (this.global1.allcountries[this.this_number].isSEV)
			{
				this.sp.material.SetColor("_MainColor2", new Color(0f, 1f, 1f, 0f));
			}
			else if (this.global1.allcountries[this.this_number].Vyshi)
			{
				this.sp.material.SetColor("_MainColor", new Color(0f, 0f, 0.46f));
				this.sp.material.SetColor("_MainColor2", new Color(1f, 0.48f, 0f, 0f));
			}
			else if (this.global1.allcountries[this.this_number].Torg)
			{
				this.sp.material.SetColor("_MainColor", new Color(0f, 0f, 0.72f));
				this.sp.material.SetColor("_MainColor2", new Color(1f, 0f, 1f, 0f));
			}
			else
			{
				this.sp.material.SetColor("_MainColor2", new Color(0f, 0f, 0f, 0f));
			}
			this.Repaint_right(false);
		}
		else if (this.global1.data[0] == this.this_number)
		{
			if (this.global1.data[14] <= 0)
			{
				this.sp.material.SetColor("_MainColor2", new Color(0f, 0f, 0f, 0f));
				this.global1.allcountries[this.global1.data[0]].Gosstroy = 9;
			}
			else if (this.global1.data[14] <= 2)
			{
				this.sp.material.SetColor("_MainColor2", new Color(0f, 1f, 1f, 0f));
				this.global1.allcountries[this.global1.data[0]].Gosstroy = 0;
			}
			else if (this.global1.data[14] <= 3)
			{
				this.sp.material.SetColor("_MainColor", new Color(0f, 0f, 0.72f));
				this.sp.material.SetColor("_MainColor2", new Color(1f, 0f, 1f, 0f));
				this.global1.allcountries[this.global1.data[0]].Gosstroy = 1;
			}
			else if (this.global1.data[14] == 25)
			{
				this.global1.allcountries[this.global1.data[0]].Gosstroy = 6;
				this.sp.material.SetColor("_MainColor", new Color(0.12f, 0.12f, 0.12f));
				this.sp.material.SetColor("_MainColor2", new Color(0.52f, 0.52f, 0.52f, 0.84f));
			}
			else
			{
				this.sp.material.SetColor("_MainColor", new Color(0f, 0f, 0.46f));
				this.sp.material.SetColor("_MainColor2", new Color(1f, 0.48f, 0f, 0f));
				this.global1.allcountries[this.global1.data[0]].Gosstroy = 2;
			}
		}
		else if (this.global1.allcountries[this.this_number].Gosstroy == 2)
		{
			this.sp.material.SetColor("_MainColor", new Color(0f, 0f, 0.46f));
			this.sp.material.SetColor("_MainColor2", new Color(1f, 0.48f, 0f, 0f));
		}
		else if (this.global1.allcountries[this.this_number].Gosstroy == 0)
		{
			this.sp.material.SetColor("_MainColor2", new Color(0f, 1f, 1f, 0f));
		}
		else if (this.global1.allcountries[this.this_number].Gosstroy == 5)
		{
			this.sp.material.SetColor("_MainColor", new Color(0.12f, 0.12f, 0.12f));
			this.sp.material.SetColor("_MainColor2", new Color(0.72f, 0.72f, 0.72f, 0.84f));
		}
		else if (this.global1.allcountries[this.this_number].Gosstroy == 6)
		{
			this.sp.material.SetColor("_MainColor", new Color(0.12f, 0.12f, 0.12f));
			this.sp.material.SetColor("_MainColor2", new Color(0.52f, 0.52f, 0.52f, 0.84f));
		}
		else if (this.global1.allcountries[this.this_number].Gosstroy == 1)
		{
			this.sp.material.SetColor("_MainColor", new Color(0f, 0f, 0.72f));
			this.sp.material.SetColor("_MainColor2", new Color(1f, 0f, 1f, 0f));
		}
		else
		{
			this.sp.material.SetColor("_MainColor2", new Color(0f, 0f, 0f, 0f));
		}
		if (this.global1.data[216] >= 50)
		{
			for (int j = 0; j < 55; j++)
			{
				if (j == 15 || j == 32 || j == 49 || j == 50 || j == 51)
				{
					this.global1.allcountries[15].Gosstroy = 5;
					this.global1.allcountries[6].Gosstroy = 5;
					this.global1.allcountries[20].Gosstroy = 5;
					this.global1.allcountries[45].Gosstroy = 5;
					this.global1.allcountries[0].Gosstroy = 6;
					this.global1.allcountries[j].subideology = 16;
					this.global1.allcountries[j].isSEV = false;
					this.global1.allcountries[j].isOVD = false;
					this.global1.allcountries[j].Vyshi = false;
					this.global1.allcountries[j].Torg = false;
				}
				else
				{
					this.global1.allcountries[j].Gosstroy = 6;
					this.global1.allcountries[j].subideology = 16;
					this.global1.allcountries[j].isSEV = false;
					this.global1.allcountries[j].isOVD = false;
					this.global1.allcountries[j].Vyshi = false;
					this.global1.allcountries[j].Torg = false;
				}
			}
			if (this.this_number == 15)
			{
				this.sp.sprite = this.special2;
			}
			if (this.this_number == 6)
			{
				this.sp.sprite = this.special2;
			}
			if (this.this_number == 20)
			{
				this.sp.sprite = this.special;
			}
			if (this.this_number == 45)
			{
				this.sp.sprite = this.special2;
			}
		}
		if (this.this_number == 7)
		{
			if (this.global1.allcountries[7].Vyshi)
			{
				this.sp.sprite = this.special;
				this.sp.material.SetColor("_MainColor", new Color(0f, 0f, 0.46f));
				this.sp.material.SetColor("_MainColor2", new Color(1f, 0.48f, 0f, 0f));
				return;
			}
		}
		else if (this.this_number == 17)
		{
			if (this.global1.allcountries[1].Gosstroy == 2 && this.global1.data[0] != 1)
			{
				this.sp.sprite = this.special;
				return;
			}
		}
		else if (this.this_number == 24)
		{
			if (this.global1.allcountries[24].Gosstroy == 2)
			{
				this.sp.sprite = this.special;
				this.sp.material.SetColor("_MainColor", new Color(0f, 0f, 0.46f));
				this.sp.material.SetColor("_MainColor2", new Color(1f, 0.48f, 0f, 0f));
				return;
			}
		}
		else if (this.this_number == 4)
		{
			if ((this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51) && this.global1.data[149] == 3)
			{
				this.sp.sprite = this.special2;
				return;
			}
			if (this.global1.event_done[1044])
			{
				this.sp.sprite = this.special;
				return;
			}
		}
		else if (this.this_number == 5)
		{
			if (this.global1.data[59] == 1 && this.global1.data[0] == 5)
			{
				this.sp.sprite = this.special;
				return;
			}
			if (this.global1.event_done[1044])
			{
				this.sp.sprite = this.special2;
				return;
			}
		}
		else if (this.this_number == 6)
		{
			if (this.global1.data[59] == 2)
			{
				this.sp.sprite = this.special;
				return;
			}
			if (this.global1.data[235] == 9)
			{
				this.sp.sprite = this.special2;
				return;
			}
		}
		else if (this.this_number == 15)
		{
			if ((this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51) && this.global1.data[149] == 3 && this.global1.data[177] == 3)
			{
				this.sp.sprite = this.special;
				return;
			}
			if ((this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51) && this.global1.data[149] == 3)
			{
				this.sp.sprite = this.special3;
				return;
			}
			if ((this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51) && this.global1.data[177] == 3)
			{
				this.sp.sprite = this.special;
				return;
			}
		}
		else if (this.this_number == 20 && this.global1.data[177] == 3)
		{
			this.sp.sprite = this.special;
			this.global1.allcountries[20].Gosstroy = this.global1.allcountries[15].Gosstroy;
		}
	}

	// Token: 0x04000054 RID: 84
	public GlobalScript global1;

	// Token: 0x04000055 RID: 85
	public int this_number;

	// Token: 0x04000056 RID: 86
	public Sprite grey;

	// Token: 0x04000057 RID: 87
	public Sprite special;

	// Token: 0x04000058 RID: 88
	public Sprite special2;

	// Token: 0x04000059 RID: 89
	public Sprite special3;

	// Token: 0x0400005A RID: 90
	private MapChangesScript map1;

	// Token: 0x0400005B RID: 91
	private SpriteRenderer sp;

	// Token: 0x0400005C RID: 92
	public bool rightwing;

	// Token: 0x0400005D RID: 93
	private OkoshkoScript[] okno1 = new OkoshkoScript[4];

	// Token: 0x0400005E RID: 94
	public GameObject vkladka;
}
