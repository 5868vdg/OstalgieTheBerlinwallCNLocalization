using System;
using UnityEngine;

// Token: 0x02000059 RID: 89
public class modify_choose : MonoBehaviour
{
	// Token: 0x060001B7 RID: 439 RVA: 0x001F1DD8 File Offset: 0x001EFFD8
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		if (this.num_this == 3 && this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				base.transform.GetChild(0).GetComponent<TextMesh>().text = " 修 正";
			}
			else
			{
				base.transform.GetChild(0).GetComponent<TextMesh>().text = "Модификатор";
			}
		}
		if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
		{
			this.yug1 = GameObject.Find("Yugoglobal(Clone)").GetComponent<Yugoglobal>();
		}
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x001F1EA0 File Offset: 0x001F00A0
	private void Start()
	{
		if (this.num_this == 3 && this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				base.transform.GetChild(0).GetComponent<TextMesh>().text = " 修 正";
				return;
			}
			base.transform.GetChild(0).GetComponent<TextMesh>().text = "Модификатор";
		}
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x001F1F1C File Offset: 0x001F011C
	private void OnMouseDown()
	{
		if (PlayerPrefs.GetInt("language") == 0)
		{
			if (this.num_this == 0)
			{
				this.num_names = 3;
				this.Name_1.text = " 当 前 出 口";
				this.Name_2.text = " 进 口 需 求";
				this.Name_3.text = " 差 别";
				if (this.global1.data[0] != 20)
				{
					this.Text_1.text = " 占1985 年 的 百 分 比:\n" + this.global1.data[23].ToString() + "%";
					this.Text_2.text = " 占1985 年 的 百 分 比:\n" + this.global1.data[24].ToString() + "%";
					this.Text_3.text = " 占1985 年 的 百 分 比:\n" + (this.global1.data[23] - this.global1.data[24]).ToString() + "%";
				}
				else
				{
					this.Text_1.text = " 占1961 年 的 百 分 比:\n" + this.global1.data[23].ToString() + "%";
					this.Text_2.text = " 占1961 年 的 百 分 比:\n" + this.global1.data[24].ToString() + "%";
					this.Text_3.text = " 占1961 年 的 百 分 比:\n" + (this.global1.data[23] - this.global1.data[24]).ToString() + "%";
				}
				if (this.global1.data[23] > this.global1.data[24])
				{
					TextMesh textMesh = this.Text_3;
					textMesh.text = string.Concat(new string[]
					{
						textMesh.text,
						"\n 贸 易 利 润\n （ 每 周 ）: +",
						((this.global1.data[23] - this.global1.data[24]) / 20).ToString(),
						".",
						Mathf.Abs((this.global1.data[23] - this.global1.data[24]) / 2 % 10).ToString()
					});
					textMesh = this.Text_3;
					textMesh.text = string.Concat(new string[]
					{
						textMesh.text,
						"\n 人 民 支 持\n （ 每 周 ）: +",
						((this.global1.data[23] - this.global1.data[24]) / 20).ToString(),
						".",
						Mathf.Abs((this.global1.data[23] - this.global1.data[24]) / 2 % 10).ToString()
					});
				}
				else
				{
					TextMesh textMesh2 = this.Text_3;
					textMesh2.text = string.Concat(new string[]
					{
						textMesh2.text,
						"\n 贸 易 利 润\n （ 每 周 ）: -",
						((this.global1.data[23] - this.global1.data[24]) / 20).ToString(),
						".",
						Mathf.Abs((this.global1.data[23] - this.global1.data[24]) / 2 % 10).ToString()
					});
					textMesh2 = this.Text_3;
					textMesh2.text = string.Concat(new string[]
					{
						textMesh2.text,
						"\n 人 民 支 持\n （ 每 周 ）: -",
						((this.global1.data[23] - this.global1.data[24]) / 30).ToString(),
						".",
						Mathf.Abs((this.global1.data[23] - this.global1.data[24]) / 3 % 10).ToString()
					});
					textMesh2 = this.Text_3;
					textMesh2.text = string.Concat(new string[]
					{
						textMesh2.text,
						"\n 生 活 条 件\n （ 每 周 ）: -",
						((this.global1.data[23] - this.global1.data[24]) / 40).ToString(),
						".",
						Mathf.Abs((this.global1.data[23] - this.global1.data[24]) / 4 % 10).ToString()
					});
				}
			}
			else if (this.num_this == 1)
			{
				this.num_names = 3;
				this.Name_1.text = " 贸 易 伙 伴";
				this.Name_2.text = "";
				this.Name_3.text = " 情 况";
				if (this.global1.data[19] > 1)
				{
					this.Text_1.text = string.Concat(new string[]
					{
						"(",
						(this.global1.data[19] - 1).ToString(),
						") 天 以 来 共:\n",
						this.global1.data[25].ToString(),
						" 个 国 家"
					});
				}
				else
				{
					this.Text_1.text = " 三 十 一 天 以 来 共:\n" + this.global1.data[25].ToString() + "  个 国 家";
				}
				TextMesh text_ = this.Text_1;
				text_.text += "\n\n<color=red> 贸 易:</color>\n";
				string text = "";
				string text2 = "";
				string text3 = "";
				for (int i = 0; i < this.global1.allcountries.Length; i++)
				{
					if (this.global1.allcountries[i] != null)
					{
						if (this.global1.allcountries[i].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV && this.global1.allcountries[i].Torg && i != this.global1.data[0])
						{
							text3 = text3 + this.global1.allcountries[i].name + "; ";
						}
						else if (((this.global1.allcountries[i].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV) || (this.global1.allcountries[i].Vyshi && this.global1.allcountries[this.global1.data[0]].Vyshi)) && !this.global1.allcountries[i].Torg && i != this.global1.data[0])
						{
							text2 = text2 + this.global1.allcountries[i].name + "; ";
						}
						else if (this.global1.allcountries[i].Torg)
						{
							text = text + this.global1.allcountries[i].name + "; ";
						}
					}
				}
				text = this.Text(text, 30);
				TextMesh text_2 = this.Text_1;
				text_2.text += text;
				TextMesh text_3 = this.Text_1;
				text_3.text += "\n<color=red> 经 济 盟 友:</color>\n";
				text2 = this.Text(text2, 30);
				TextMesh text_4 = this.Text_1;
				text_4.text += text2;
				TextMesh text_5 = this.Text_1;
				text_5.text += "\n<color=red> 战 略 合 作 伙 伴:</color>\n";
				text3 = this.Text(text3, 30);
				TextMesh text_6 = this.Text_1;
				text_6.text += text3;
				if (this.global1.data[25] < 4)
				{
					this.Text_3.text = " 孤 立";
					TextMesh textMesh3 = this.Text_3;
					textMesh3.text = string.Concat(new string[]
					{
						textMesh3.text,
						"\n 西 方 情 结  （ 每 周 ）: -",
						((-4 + this.global1.data[25]) / 10).ToString(),
						".",
						Mathf.Abs((-4 + this.global1.data[25]) % 10).ToString()
					});
					textMesh3 = this.Text_3;
					textMesh3.text = string.Concat(new string[]
					{
						textMesh3.text,
						"\n 主 权  （ 每 周 ）: +",
						((4 - this.global1.data[25]) / 10).ToString(),
						".",
						Mathf.Abs((4 - this.global1.data[25]) % 10).ToString()
					});
					textMesh3 = this.Text_3;
					textMesh3.text = string.Concat(new string[]
					{
						textMesh3.text,
						"\n 生 活 条 件\n （ 每 周 ）: -",
						((-4 + this.global1.data[25]) / 10).ToString(),
						".",
						Mathf.Abs((-4 + this.global1.data[25]) % 10).ToString()
					});
					textMesh3 = this.Text_3;
					textMesh3.text = string.Concat(new string[]
					{
						textMesh3.text,
						"\n 间 谍  （ 每 周 ）: -",
						((-4 + this.global1.data[25]) / 10).ToString(),
						".",
						Mathf.Abs((-4 + this.global1.data[25]) % 10).ToString()
					});
				}
				else if (this.global1.data[25] > 8)
				{
					this.Text_3.text = " 全 球 化";
					TextMesh textMesh4 = this.Text_3;
					textMesh4.text = string.Concat(new string[]
					{
						textMesh4.text,
						"\n 西 方 情 结  （ 每 周 ）: +",
						((this.global1.data[25] - 8) / 10).ToString(),
						".",
						Mathf.Abs((this.global1.data[25] - 8) % 10).ToString()
					});
					if (this.global1.data[25] < 18)
					{
						textMesh4 = this.Text_3;
						textMesh4.text = string.Concat(new string[]
						{
							textMesh4.text,
							"\n 主 权  （ 每 周 ）: -",
							((8 - this.global1.data[25]) / 10).ToString(),
							".",
							Mathf.Abs((8 - this.global1.data[25]) % 10).ToString()
						});
					}
					else
					{
						textMesh4 = this.Text_3;
						textMesh4.text = string.Concat(new string[]
						{
							textMesh4.text,
							"\n 主 权  （ 每 周 ）: ",
							((8 - this.global1.data[25]) / 10).ToString(),
							".",
							Mathf.Abs((8 - this.global1.data[25]) % 10).ToString()
						});
					}
					textMesh4 = this.Text_3;
					textMesh4.text = string.Concat(new string[]
					{
						textMesh4.text,
						"\n 生 活 条 件\n （ 每 周 ）: +",
						((this.global1.data[25] - 8) / 10).ToString(),
						".",
						Mathf.Abs((this.global1.data[25] - 8) % 10).ToString()
					});
				}
				else
				{
					this.Text_3.text = " 平 衡";
				}
				this.Text_2.text = "";
			}
			else if (this.num_this == 2)
			{
				if (this.global1.data[0] != 5 || this.global1.data[26] <= 0 || (this.global1.data[0] == 5 && !this.global1.event_done[94]))
				{
					if (this.global1.data[26] > 0)
					{
						this.num_names = 2;
						this.Name_1.text = " 国 债";
						this.Name_2.text = " 差 别";
						this.Text_1.text = " 债 务: " + (this.global1.data[26] / 10).ToString() + "." + Mathf.Abs(this.global1.data[26] % 10).ToString();
						if (this.global1.data[34] >= 0)
						{
							this.Text_2.text = " 在 收 取 和 偿 还 之 间\n 从 债 务 支 付 中\n 释 放 资 金\n （ 每 周 ）:\n+" + (this.global1.data[34] / 10).ToString() + "." + Mathf.Abs(this.global1.data[34] % 10).ToString();
							TextMesh text_7 = this.Text_2;
							text_7.text = text_7.text + "\n 每 周 共 付\n 大 约: " + (this.global1.data[26] / this.global1.data[34]).ToString();
						}
						else
						{
							this.Text_2.text = " 在 收 取 和 偿 还 之 间\n 从 债 务 支 付 中\n 释 放 资 金\n （ 每 周 ）:\n0";
						}
					}
					else
					{
						this.num_names = 1;
						this.Name_1.text = " 国 债";
						this.Text_1.text = " 债 务: 0";
					}
				}
				else
				{
					this.num_names = 1;
					this.Name_1.text = " 五 年 内 存 款";
					this.Text_1.text = " 利 润:\n+" + (this.global1.data[34] / 10).ToString() + "." + Mathf.Abs(this.global1.data[34] % 10).ToString();
				}
			}
			else if (this.num_this == 3 && this.global1.data[0] != 12)
			{
				if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
				{
					this.num_names = 1;
					Yugoglobal component = GameObject.Find("Yugoglobal(Clone)").GetComponent<Yugoglobal>();
					this.Name_1.text = component.science_text[106];
					this.Text_1.text = "";
					this.Text_1.characterSize = 0.08f;
					for (int j = 1; j < component.gameState.modifies.Length; j++)
					{
						if (component.gameState.modifies[j] > 0)
						{
							TextMesh text_8 = this.Text_1;
							text_8.text = text_8.text + "\n" + string.Format(component.science_text[190 + j - 1], component.gameState.modifies[j]);
							int num = 0;
							int num2 = 0;
							string text4 = component.science_text[226 + j - 1];
							string text5 = component.science_text[226 + j - 1];
							for (int k = 0; k < text4.Length; k++)
							{
								num2++;
								if (text4[k] == char.Parse(":"))
								{
									num++;
								}
								if (num == component.gameState.modifies[j])
								{
									text5 = text5.Remove(0, num2);
									num2 = -1;
									num = 100;
								}
								else if (num > 100)
								{
									text5 = text5.Remove(num2);
									break;
								}
							}
							TextMesh text_9 = this.Text_1;
							text_9.text = text_9.text + "\n<color=red>" + text5 + "</color>";
						}
					}
				}
				else
				{
					this.num_names = 3;
					this.Name_1.text = " 完 全 开 放";
					this.Name_2.text = " 付 费 开 放";
					this.Name_3.text = " 受 限";
					this.Text_1.text = " 边 境: " + this.global1.data[27].ToString();
					TextMesh textMesh5;
					if (this.global1.data[216] < 50)
					{
						textMesh5 = this.Text_1;
						textMesh5.text = string.Concat(new string[]
						{
							textMesh5.text,
							"\n 苏 联 支 持 和 人 民 支 持\n 每 周: +",
							(this.global1.data[27] / 10).ToString(),
							".",
							Mathf.Abs(this.global1.data[27] % 10).ToString()
						});
					}
					else
					{
						textMesh5 = this.Text_1;
						textMesh5.text = string.Concat(new string[]
						{
							textMesh5.text,
							"\n 人 民 支 持\n 每 周: +",
							(this.global1.data[27] / 10).ToString(),
							".",
							Mathf.Abs(this.global1.data[27] % 10).ToString()
						});
					}
					textMesh5 = this.Text_1;
					textMesh5.text = string.Concat(new string[]
					{
						textMesh5.text,
						"\n 西 方 情 结\n 每 周: +",
						(this.global1.data[28] / 10).ToString(),
						".",
						Mathf.Abs(this.global1.data[28] % 10).ToString()
					});
					this.Text_2.text = " 边 境: " + this.global1.data[28].ToString();
					textMesh5 = this.Text_2;
					textMesh5.text = string.Concat(new string[]
					{
						textMesh5.text,
						"\n 顾 客 利 润\n 每 周: +",
						(this.global1.data[28] / 10).ToString(),
						".",
						Mathf.Abs(this.global1.data[28] % 10).ToString()
					});
					this.Text_3.text = " 边 境: " + this.global1.data[29].ToString();
					textMesh5 = this.Text_3;
					textMesh5.text = string.Concat(new string[]
					{
						textMesh5.text,
						"\n 西 方 情 结\n 每 周: -",
						(this.global1.data[29] / 10).ToString(),
						".",
						Mathf.Abs(this.global1.data[29] % 10).ToString()
					});
					TextMesh text_10 = this.Text_3;
					text_10.text = text_10.text + "\n\n 已 关 闭 边 境: " + (5 - this.global1.data[27] - this.global1.data[28] - this.global1.data[29]).ToString();
				}
			}
			else if (this.num_this == 3)
			{
				this.num_names = 1;
				this.Name_1.text = " 最 大 边 境 数";
				this.Text_1.text = "";
				if (this.global1.data[80] - 20 < 80)
				{
					int num3 = (80 - (this.global1.data[80] - 20)) / 20;
					TextMesh text_11 = this.Text_1;
					text_11.text = text_11.text + "\n 上 限:\n 党 内 团 结: " + (100 - num3 * 10).ToString();
					TextMesh text_12 = this.Text_1;
					text_12.text = text_12.text + "\n 上 限:\n 人 民 支 持: " + (100 - num3 * 10).ToString();
					TextMesh text_13 = this.Text_1;
					text_13.text = text_13.text + "\n 上 限:\n 生 活 条 件: " + (100 - num3 * 10).ToString();
					TextMesh text_14 = this.Text_1;
					text_14.text = text_14.text + "\n 下 限:\n 西 方 情 结: " + (num3 * 15).ToString();
				}
			}
			else if (this.num_this == 4)
			{
				this.num_names = 2;
				if (this.global1.data[216] < 50)
				{
					this.Name_1.text = " 苏 联 援 助";
				}
				else
				{
					this.Name_1.text = " 蛮 族 威 胁";
				}
				this.Text_1.text = "\n 总 计: " + (this.global1.data[30] / 10).ToString() + "." + Mathf.Abs(this.global1.data[30] % 10).ToString();
				if (this.global1.data[216] < 50)
				{
					this.Name_2.text = "\n 当 前 苏 联 政 策";
				}
				else
				{
					this.Name_2.text = "\n 积 极 向 海 洋 排 水";
				}
				if (this.global1.data[216] < 50)
				{
					this.Name_2.text = "\n当 前 苏 联 政 策";
				}
				else
				{
					this.Name_2.text = "\n 向 海 洋 排 水";
				}
				if (this.global1.data[0] == 10)
				{
					this.num_names = 3;
					this.Name_3.text = " 中 国 援 助";
					this.Text_3.text = "\n 总 计: " + (this.global1.data[73] / 10).ToString() + "." + Mathf.Abs(this.global1.data[73] % 10).ToString();
				}
				if (this.global1.data[191] == 1 && !this.global1.event_done[409] && !this.global1.event_done[426])
				{
					this.Text_2.text = "\n\n\n 别 斯 梅 尔 特 内 赫 政 策";
					TextMesh text_15 = this.Text_2;
					text_15.text += "\n 东 欧 合 作";
					TextMesh text_16 = this.Text_2;
					text_16.text += "\n 的 复 兴";
				}
				else if (this.global1.event_done[35] && this.global1.data[21] <= 1991 && (!this.global1.is_gkchp || (this.global1.allcountries[7].Gosstroy > 1 && this.global1.is_gkchp)))
				{
					this.Text_2.text = "\n\n\n 拒 绝 援 助\n 社 会 主 义 阵 营";
					TextMesh text_17 = this.Text_2;
					text_17.text += "\n 每 月 影 响 力:";
					TextMesh text_18 = this.Text_2;
					text_18.text += "\n 社 会 主 义 阵 营 稳 定: -1";
					TextMesh text_19 = this.Text_2;
					text_19.text += "\n 没 有 援 助 ！";
				}
				else if (this.global1.event_done[4] && this.global1.data[21] <= 1991 && (!this.global1.is_gkchp || (this.global1.allcountries[7].Gosstroy > 1 && this.global1.is_gkchp)))
				{
					this.Text_2.text = "\n\n\n 辛 纳 屈 政 策";
					TextMesh text_20 = this.Text_2;
					text_20.text += "\n 每 月 影 响 力:";
					TextMesh text_21 = this.Text_2;
					text_21.text += "\n 社 会 主 义 阵 营 稳 定: -1";
					TextMesh text_22 = this.Text_2;
					text_22.text += "\n 苏 联 援 助: -2%";
				}
				else if (this.global1.data[21] > 1991 || (this.global1.allcountries[7].isOVD && this.global1.is_gkchp))
				{
					this.Text_2.text = "\n\n\n 稳 定 化";
					TextMesh text_23 = this.Text_2;
					text_23.text += "\n 外 部 政 策";
					TextMesh text_24 = this.Text_2;
					text_24.text += "\n 正 试 图 稳 定 化";
				}
				else
				{
					this.Text_2.text = "\n\n\n 勃 列 日 涅 夫 政 策";
					TextMesh text_25 = this.Text_2;
					text_25.text += "\n 稳 定";
				}
			}
			else if (this.num_this == 5)
			{
				this.num_names = 2;
				this.Name_1.text = " 世 界 观";
				this.Name_2.text = " 特 殊 影 响";
				this.Text_1.text = " 当 前:";
				if (this.global1.data[31] > 700)
				{
					TextMesh textMesh6 = this.Text_1;
					textMesh6.text = string.Concat(new string[]
					{
						textMesh6.text,
						"\n 民 族 主 义\n(",
						(this.global1.data[31] / 10).ToString(),
						".",
						Mathf.Abs(this.global1.data[31] % 10).ToString(),
						"/100)"
					});
					this.Text_2.text = " 西 方 情 结\n 每 周: -" + ((this.global1.data[31] - 500) / 100 / 10).ToString() + "." + Mathf.Abs((this.global1.data[31] - 500) / 100 % 10).ToString();
					textMesh6 = this.Text_2;
					textMesh6.text = string.Concat(new string[]
					{
						textMesh6.text,
						"\n 党 内 团 结\n 每 周: +",
						((this.global1.data[31] - 500) / 100 / 10).ToString(),
						".",
						Mathf.Abs((this.global1.data[31] - 500) / 100 % 10).ToString()
					});
					textMesh6 = this.Text_2;
					textMesh6.text = string.Concat(new string[]
					{
						textMesh6.text,
						"\n 主 权\n 每 周: +",
						((this.global1.data[31] - 500) / 50 / 10).ToString(),
						".",
						Mathf.Abs((this.global1.data[31] - 500) / 50 % 10).ToString()
					});
					if (this.global1.data[216] < 50)
					{
						textMesh6 = this.Text_2;
						textMesh6.text = string.Concat(new string[]
						{
							textMesh6.text,
							"\n 苏 联 认 可\n 每 周: -",
							((this.global1.data[31] - 500) / 100 / 10).ToString(),
							".",
							Mathf.Abs((this.global1.data[31] - 500) / 100 % 10).ToString()
						});
						textMesh6 = this.Text_2;
						textMesh6.text = string.Concat(new string[]
						{
							textMesh6.text,
							"\n 北 约 不 满\n 每 周: +",
							((this.global1.data[31] - 500) / 100 / 10).ToString(),
							".",
							Mathf.Abs((this.global1.data[31] - 500) / 100 % 10).ToString()
						});
					}
				}
				else if (this.global1.data[31] >= 400 && this.global1.data[31] <= 700)
				{
					TextMesh text_26 = this.Text_1;
					text_26.text = string.Concat(new string[]
					{
						text_26.text,
						"\n 苏 式 爱 国 主 义\n(",
						(this.global1.data[31] / 10).ToString(),
						".",
						Mathf.Abs(this.global1.data[31] % 10).ToString(),
						"/100)"
					});
					this.Text_2.text = " 无".ToString();
				}
				else
				{
					TextMesh textMesh7 = this.Text_1;
					textMesh7.text = string.Concat(new string[]
					{
						textMesh7.text,
						"\n 世 界 主 义\n(",
						(this.global1.data[31] / 10).ToString(),
						".",
						Mathf.Abs(this.global1.data[31] % 10).ToString(),
						"/100)"
					});
					this.Text_2.text = " 西 方 情 结\n 每 周: +" + ((500 - this.global1.data[31]) / 100 / 10).ToString() + "." + Mathf.Abs((500 - this.global1.data[31]) / 100 % 10).ToString();
					textMesh7 = this.Text_2;
					textMesh7.text = string.Concat(new string[]
					{
						textMesh7.text,
						"\n 党 内 团 结\n 每 周: +",
						((500 - this.global1.data[31]) / 100 / 10).ToString(),
						".",
						Mathf.Abs((500 - this.global1.data[31]) / 100 % 10).ToString()
					});
					textMesh7 = this.Text_2;
					textMesh7.text = string.Concat(new string[]
					{
						textMesh7.text,
						"\n 主 权\n 每 周: -",
						((500 - this.global1.data[31]) / 50 / 10).ToString(),
						".",
						Mathf.Abs((500 - this.global1.data[31]) / 50 % 10).ToString()
					});
					if (this.global1.data[216] < 50)
					{
						textMesh7 = this.Text_2;
						textMesh7.text = string.Concat(new string[]
						{
							textMesh7.text,
							"\n 北 约 不 满\n 每 周: -",
							((500 - this.global1.data[31]) / 100 / 10).ToString(),
							".",
							Mathf.Abs((500 - this.global1.data[31]) / 100 % 10).ToString()
						});
					}
				}
			}
			else if (this.num_this == 6)
			{
				this.num_names = 2;
				this.Name_1.text = " 主 权";
				this.Name_2.text = " 特 殊 影 响";
				this.Text_1.text = string.Concat(new string[]
				{
					" 当 前: ",
					(this.global1.data[22] / 10).ToString(),
					".",
					Mathf.Abs(this.global1.data[22] % 10).ToString(),
					"/100"
				});
				if (this.global1.data[22] - 500 < 0)
				{
					this.Text_2.text = " 西 方 情 结\n 每 周: +" + ((this.global1.data[22] - 500) / 100 / 10).ToString() + "." + Mathf.Abs((this.global1.data[22] - 500) / 100 % 10).ToString();
				}
				else
				{
					this.Text_2.text = " 西 方 情 结\n 每 周: -" + ((this.global1.data[22] - 500) / 100 / 10).ToString() + "." + Mathf.Abs((this.global1.data[22] - 500) / 100 % 10).ToString();
				}
				if (this.global1.allcountries[7].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV)
				{
					TextMesh text_27 = this.Text_2;
					text_27.text = string.Concat(new string[]
					{
						text_27.text,
						"\n 党 内 团 结\n 每 周: +",
						(this.global1.data[22] / 100 / 10).ToString(),
						".",
						Mathf.Abs(this.global1.data[22] / 100 % 10).ToString()
					});
				}
				else
				{
					TextMesh text_28 = this.Text_2;
					text_28.text = string.Concat(new string[]
					{
						text_28.text,
						"\n 党 内 团 结\n 每 周: +",
						(this.global1.data[22] / 50 / 10).ToString(),
						".",
						Mathf.Abs(this.global1.data[22] / 50 % 10).ToString()
					});
				}
				TextMesh text_29 = this.Text_2;
				text_29.text += "\n 同 时 影 响\n 我 们 失 败 的 可 能 性";
				if (this.global1.data[0] == 10)
				{
					this.num_names = 3;
					this.Name_3.text = " 核 计 划";
					if (this.global1.data[100] > 0 && this.global1.event_done[255])
					{
						this.Text_3.text = " 每 月:\n 间 谍: -0.5\n 爱 国 主 义 +0.5\n 预 算 -10%";
					}
					else if (this.global1.data[100] > 0)
					{
						this.Text_3.text = " 每 月:\n 间 谍: -0.5\n 爱 国 主 义 +0.5";
					}
					else
					{
						this.Text_3.text = " 我 们 没 有";
					}
				}
			}
			else if (this.num_this == 7)
			{
				this.num_names = 2;
				this.Name_1.text = " 东 方 情 结";
				this.Name_2.text = " 特 殊 影 响";
				if (this.global1.data[0] == 10)
				{
					this.num_names = 3;
					this.Name_3.text = " 西 方 制 裁";
					if (this.global1.data[72] > 0)
					{
						this.Text_3.text = " 每 周:\n 外 交 声 望: +0.2;\n 北 约 不 满: +0.2\n 预 算: -0.5\n 主 权: +0.2\n 生 活 条 件: -0.2";
					}
				}
				else if (this.global1.data[0] == 18)
				{
					this.num_names = 3;
					this.Name_3.text = " 美 国 禁 运";
					if (this.global1.data[77] > 0)
					{
						this.Text_3.text = string.Concat(new object[]
						{
							" 每 周:\n 主 权: +0.2\n 预 算: -0.",
							this.global1.data[77],
							"\n 北 约 不 满: +0.",
							this.global1.data[77] / 2,
							"\n 人 民 支 持: +0.",
							this.global1.data[77]
						});
					}
					else
					{
						this.Text_3.text = " 无";
					}
				}
				else if (this.global1.data[0] >= 1 && this.global1.data[0] <= 6)
				{
					this.num_names = 3;
					this.Name_3.text = " 西 方 制 裁";
					if (this.global1.data[72] > 0)
					{
						this.Text_3.text = " 每 周:\n 外 交 声 望: +0.2;\n 北 约 不 满: +0.2\n 预 算: -0.5\n 主 权: +0.2";
					}
					else
					{
						this.Text_3.text = " 无";
					}
				}
				this.Text_1.text = string.Concat(new string[]
				{
					" 西 方 公 民 的 不 满\n和 他 们 对 左 翼 思 想\n 的 同 情:\n",
					(this.global1.allcountries[17].Westalgie / 10).ToString(),
					".",
					Mathf.Abs(this.global1.allcountries[17].Westalgie % 10).ToString(),
					"/100"
				});
				this.Text_2.text = " 西 方 情 结\n 每 周: -" + (this.global1.allcountries[17].Westalgie / 80 / 10).ToString() + "." + Mathf.Abs(this.global1.allcountries[17].Westalgie / 80 % 10).ToString();
				TextMesh text_30 = this.Text_2;
				text_30.text = string.Concat(new string[]
				{
					text_30.text,
					"\n 北 约 不 满\n 每 周: -",
					(this.global1.allcountries[17].Westalgie / 120 / 10).ToString(),
					".",
					Mathf.Abs(this.global1.allcountries[17].Westalgie / 120 % 10).ToString()
				});
			}
			else if (this.num_this == 8 && this.global1.data[0] != 12)
			{
				this.num_names = 3;
				this.Name_1.text = " 亚 细 亚";
				this.Name_2.text = " 欧 罗 巴";
				this.Name_3.text = " 阿 非 利 加";
				if (this.global1.data[216] < 50)
				{
					this.Text_1.text = " 阿 富 汗 控 制 度: ";
				}
				else
				{
					this.Text_1.text = " 第15 区 控 制 度: ";
				}
				int num4 = 30;
				if (this.global1.allcountries[7].isSEV || this.global1.allcountries[16].isSEV || this.global1.allcountries[19].Gosstroy <= 0)
				{
					num4 += 25;
				}
				if (this.global1.allcountries[31].Help)
				{
					num4 += 5;
				}
				if (this.global1.data[37] <= 6)
				{
					num4 += this.global1.data[37] * 4;
				}
				else if (this.global1.data[37] <= 8)
				{
					num4 += this.global1.data[37] * 5;
				}
				else
				{
					num4 += 40;
				}
				TextMesh text_31 = this.Text_1;
				text_31.text = text_31.text + num4.ToString() + " %";
				if (this.global1.data[216] < 50)
				{
					TextMesh text_32 = this.Text_1;
					text_32.text += "\n 也 门 民 主 人 民 共 和 国 发 展 度: ";
				}
				else
				{
					TextMesh text_33 = this.Text_1;
					text_33.text += "\n 第27 区 发 展 度: ";
				}
				num4 = 40;
				if (this.global1.allcountries[24].Stasi)
				{
					num4 += 25;
				}
				if (this.global1.allcountries[24].Gosstroy == 0)
				{
					num4 += 5;
				}
				if (this.global1.data[55] <= 1)
				{
					num4 += this.global1.data[55] * 10;
				}
				else
				{
					num4 += 30;
				}
				TextMesh text_34 = this.Text_1;
				text_34.text = text_34.text + num4.ToString() + " %";
				if (this.global1.data[216] < 50)
				{
					TextMesh text_35 = this.Text_1;
					text_35.text += "\n 尼 泊 尔 控 制 度: ";
				}
				else
				{
					TextMesh text_36 = this.Text_1;
					text_36.text += "\n 第46 区 控 制 度: ";
				}
				TextMesh textMesh8 = this.Text_1;
				textMesh8.text = string.Concat(new string[]
				{
					textMesh8.text,
					(this.global1.allcountries[43].Westalgie / 10).ToString(),
					".",
					Mathf.Abs(this.global1.allcountries[43].Westalgie % 10).ToString(),
					" %"
				});
				if (this.global1.data[0] < 49 || this.global1.data[0] > 51)
				{
					if (this.global1.data[216] < 50)
					{
						this.Text_2.text = " 南 斯 拉 夫 控 制 度: ";
					}
					else
					{
						this.Text_2.text = " 大 都 会 控 制 度: ";
					}
					num4 = 25;
					if (this.global1.allcountries[5].isOVD || this.global1.allcountries[6].isOVD)
					{
						num4 += 20;
					}
					if (this.global1.allcountries[this.global1.data[0]].isOVD)
					{
						num4 += 20;
					}
					if (this.global1.data[54] <= 4)
					{
						num4 += this.global1.data[54] * 3;
					}
					else if (this.global1.data[54] <= 6)
					{
						num4 += this.global1.data[54] * 5;
					}
					else
					{
						num4 += 35;
					}
					if (this.global1.data[59] == 2)
					{
						num4 -= num4 / 3;
					}
					num4 -= this.global1.data[206] * 10;
					TextMesh text_37 = this.Text_2;
					text_37.text = text_37.text + num4.ToString() + " %";
				}
				else if (this.global1.data[191] == 1 || this.global1.data[131] == 1)
				{
					this.Text_2.text = " 反 南 斯 拉 夫 武 装 力 量\n 相 比 \n1991 年 初: ";
					num4 = 100;
					if (this.global1.data[21] >= 1992)
					{
						num4 -= this.yug1.gameState.modifies[30] * 13;
					}
					else
					{
						num4 -= this.yug1.gameState.modifies[30] * this.global1.data[20];
					}
					if (this.global1.data[193] == 1)
					{
						num4 += 20;
					}
					else if (this.global1.data[193] == 2)
					{
						num4 -= 15;
					}
					num4 -= this.global1.data[115] * 2;
					if (this.yug1.gameState.modifies[32] == 1)
					{
						num4 += 10;
					}
					if (this.global1.data[196] == 1)
					{
						num4 -= 10;
					}
					if (this.yug1.gameState.modifies[31] == 1)
					{
						num4 += 15;
					}
					if (this.global1.data[210] == 1)
					{
						num4 -= 7;
					}
					else if (this.global1.data[210] == 2)
					{
						num4 += 15;
					}
					if (this.global1.data[195] == 1)
					{
						num4 -= 30;
					}
					if (this.global1.data[112] == 12)
					{
						num4 -= 10;
					}
					if (this.global1.allcountries[49].isOVD || this.global1.allcountries[50].isOVD || this.global1.allcountries[51].isOVD)
					{
						num4 += 10;
						if (this.global1.allcountries[7].isOVD)
						{
							num4 += 15;
						}
					}
					num4 += 3 * this.global1.data[198];
					num4 -= 3 * this.global1.data[197];
					num4 -= 5 * this.global1.data[206];
					num4 -= this.global1.data[9] / 20;
					if (num4 <= 1)
					{
						num4 = 1;
					}
					this.global1.data[214] = num4;
					TextMesh text_38 = this.Text_2;
					text_38.text = text_38.text + num4.ToString() + " %";
				}
				else
				{
					this.Text_2.text = " 去 拯 救 南 斯 拉 夫 ！";
				}
				num4 = 0;
				if (this.global1.data[216] < 50)
				{
					TextMesh text_39 = this.Text_2;
					text_39.text += "\n 在 苏 联\n\"联盟\" 派 系 的 力 量: ";
				}
				else
				{
					TextMesh text_40 = this.Text_2;
					text_40.text += "\n 在 第10 区\n\"联盟\" 的 派 系 力 量: ";
				}
				if (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy == 0 && !this.global1.allcountries[7].Vyshi)
				{
					num4 = 100;
				}
				else if (this.global1.allcountries[7].isOVD && this.global1.allcountries[7].isSEV && !this.global1.is_gkchp && !this.global1.allcountries[7].Vyshi)
				{
					num4 = 80;
					num4 -= this.global1.allcountries[7].Gosstroy * 15;
				}
				else if ((this.global1.allcountries[7].isSEV || this.global1.allcountries[7].isOVD) && this.global1.data[7] >= 250 && !this.global1.is_gkchp && !this.global1.allcountries[7].Vyshi)
				{
					num4 = 60;
					num4 -= this.global1.allcountries[7].Gosstroy * 15;
				}
				else if ((this.global1.allcountries[7].isSEV && !this.global1.is_gkchp) || (this.global1.allcountries[7].isOVD && !this.global1.is_gkchp && !this.global1.allcountries[7].Vyshi) || (this.global1.data[7] >= 600 && !this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD && !this.global1.is_gkchp && !this.global1.allcountries[7].Vyshi))
				{
					num4 = 40;
					num4 -= this.global1.allcountries[7].Gosstroy * 15;
				}
				else if ((!this.global1.allcountries[7].Vyshi && this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy >= 2 && !this.global1.allcountries[7].Vyshi) || (!this.global1.is_gkchp && this.global1.data[7] <= 600 && !this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD && !this.global1.allcountries[7].Vyshi))
				{
					num4 = 20;
				}
				else if (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy == 1 && !this.global1.allcountries[7].Vyshi)
				{
					num4 = 70;
				}
				else
				{
					num4 = num4;
				}
				num4 += this.global1.allcountries[7].Westalgie;
				if (num4 > 100)
				{
					num4 = 100;
				}
				TextMesh text_41 = this.Text_2;
				text_41.text = text_41.text + num4.ToString() + " %";
				if (this.global1.data[216] < 50)
				{
					this.Text_3.text = " 阿 尔 及 利 亚 控 制 度: ";
				}
				else
				{
					this.Text_3.text = " 第43 区 控 制 度: ";
				}
				textMesh8 = this.Text_3;
				textMesh8.text = string.Concat(new string[]
				{
					textMesh8.text,
					(this.global1.allcountries[40].Westalgie / 10).ToString(),
					".",
					Mathf.Abs(this.global1.allcountries[40].Westalgie % 10).ToString(),
					" %"
				});
				if (this.global1.data[216] < 50)
				{
					TextMesh text_42 = this.Text_3;
					text_42.text += "\n 埃 塞 俄 比 亚 控 制 度: ";
				}
				else
				{
					TextMesh text_43 = this.Text_3;
					text_43.text += "\n 第44 区 控 制 度: ";
				}
				textMesh8 = this.Text_3;
				textMesh8.text = string.Concat(new string[]
				{
					textMesh8.text,
					(this.global1.allcountries[41].Westalgie / 10).ToString(),
					".",
					Mathf.Abs(this.global1.allcountries[41].Westalgie % 10).ToString(),
					" %"
				});
				if (this.global1.data[216] < 50)
				{
					TextMesh text_44 = this.Text_3;
					text_44.text += "\n 索 马 里 控 制 度: ";
				}
				else
				{
					TextMesh text_45 = this.Text_3;
					text_45.text += "\n 第45 区 控 制 度: ";
				}
				textMesh8 = this.Text_3;
				textMesh8.text = string.Concat(new string[]
				{
					textMesh8.text,
					(this.global1.allcountries[42].Westalgie / 10).ToString(),
					".",
					Mathf.Abs(this.global1.allcountries[42].Westalgie % 10).ToString(),
					" %"
				});
			}
			else if (this.num_this == 8)
			{
				this.num_names = 3;
				this.Name_1.text = " 地 区";
				this.Name_2.text = " 损 失";
				this.Name_3.text = " 战 斗";
				this.Text_1.text = " 东 部: " + ((this.global1.data[90] == 1) ? " 控 制" : " 丢 失");
				TextMesh text_46 = this.Text_1;
				text_46.text = text_46.text + "\n 西 部: " + ((this.global1.data[92] == 1) ? " 控 制" : " 丢 失");
				TextMesh text_47 = this.Text_1;
				text_47.text = text_47.text + "\n 北 部: " + ((this.global1.data[93] == 1) ? " 控 制" : " 丢 失");
				TextMesh text_48 = this.Text_1;
				text_48.text = text_48.text + "\n 南 部: " + ((this.global1.data[94] == 1) ? " 控 制" : " 丢 失");
				TextMesh textMesh9 = this.Text_1;
				textMesh9.text = string.Concat(new object[]
				{
					textMesh9.text,
					"\n 总 计: ",
					this.global1.data[80],
					"%"
				});
				int num5 = 0;
				int num6 = 0;
				int num7 = 0;
				int num8 = 0;
				int num9 = 0;
				if (this.global1.data[90] != 1)
				{
					num9 -= 2;
					num7++;
					num6--;
				}
				if (this.global1.data[93] != 1)
				{
					num8 -= 2;
					num7++;
					num6--;
				}
				if (this.global1.data[92] != 1)
				{
					num5 -= 2;
					num7++;
					num6--;
				}
				if (this.global1.data[94] != 1)
				{
					num8--;
					num7++;
					num6--;
				}
				this.Text_2.text = string.Concat(new object[]
				{
					"-0.",
					num9 * -1,
					" 生 活 条 件\n+0.",
					num7,
					" 西 方 情 结\n-0.",
					num6 * -1,
					" 人 民 支 持\n-0.",
					num8 * -1,
					" 预 算\n-0.",
					num5 * -1,
					" 间 谍 网 络"
				});
				if (this.global1.data[88] == 0)
				{
					this.Text_3.text = " 一 切 稳 定";
				}
				else if (this.global1.data[88] == 1)
				{
					this.Text_3.text = " 我 们 正 推 进: ";
				}
				else if (this.global1.data[88] == 2)
				{
					this.Text_3.text = " 我 们 正 防 御: ";
				}
				if (this.global1.data[107] == 1)
				{
					textMesh9 = this.Text_3;
					textMesh9.text = string.Concat(new object[]
					{
						textMesh9.text,
						"\n 东 部 控 制: ",
						this.global1.data[108],
						"%"
					});
				}
				else if (this.global1.data[107] == 2)
				{
					textMesh9 = this.Text_3;
					textMesh9.text = string.Concat(new object[]
					{
						textMesh9.text,
						"\n 西 部 控 制: ",
						this.global1.data[108],
						"%"
					});
				}
				else if (this.global1.data[107] == 3)
				{
					textMesh9 = this.Text_3;
					textMesh9.text = string.Concat(new object[]
					{
						textMesh9.text,
						"\n 北 部 控 制: ",
						this.global1.data[108],
						"%"
					});
				}
				else if (this.global1.data[107] == 4)
				{
					textMesh9 = this.Text_3;
					textMesh9.text = string.Concat(new object[]
					{
						textMesh9.text,
						"\n 南 部 控 制: ",
						this.global1.data[108],
						"%"
					});
				}
				else if (this.global1.data[107] == 10)
				{
					textMesh9 = this.Text_3;
					textMesh9.text = string.Concat(new object[]
					{
						textMesh9.text,
						"\n 喀 布 尔 控 制: ",
						this.global1.data[108],
						"%"
					});
				}
			}
			else if (this.num_this == 9)
			{
				this.num_names = 2;
				this.Name_1.text = " 行 政 费 用";
				this.Name_2.text = " 特 殊 影 响";
				if (this.global1.data[0] == 10 || this.global1.data[0] == 12)
				{
					this.num_names = 3;
					if (this.global1.data[71] > 0)
					{
						this.Name_3.text = " 饥 荒";
						this.Text_3.text = " 每 周:\n 人 民 支 持: -0.5;\n 党 内 团 结: -0.4\n 预 算: -0.2\n 主 权: -0.2";
					}
					else
					{
						this.Name_3.text = " 缺 乏 饥 饿 感";
						this.Text_3.text = " 一 切 安 好\n 当 生 活 条 件\n 大 于20.0";
					}
				}
				else if (this.global1.data[0] == 18)
				{
					this.num_names = 3;
					this.Name_3.text = " 特 殊 时 期";
					if (this.global1.data[102] > 0)
					{
						this.Text_3.text = " 每 周:\n 预 算 变 更 至 0." + (this.global1.data[102] - 1).ToString();
						if (this.global1.data[5] > 400 - this.global1.data[102] * 30)
						{
							TextMesh text_49 = this.Text_3;
							text_49.text = text_49.text + "\n 生 活 条 件: -0." + this.global1.data[102].ToString();
						}
						if (this.global1.allcountries[this.global1.data[0]].isSEV || this.global1.allcountries[7].isSEV)
						{
							TextMesh text_50 = this.Text_3;
							text_50.text = string.Concat(new object[]
							{
								text_50.text,
								"\n 西 方 情 结: +0.",
								this.global1.data[102] / 2,
								"\n 人 民 支 持: -0.",
								this.global1.data[102] / 2
							});
						}
						if (!this.global1.allcountries[this.global1.data[0]].isSEV && !this.global1.allcountries[7].isSEV && !this.global1.allcountries[this.global1.data[0]].Vyshi)
						{
							TextMesh text_51 = this.Text_3;
							text_51.text = text_51.text + "\n 预 算: +0." + (this.global1.data[102] * 2).ToString();
						}
					}
					else
					{
						this.Text_3.text = " 一 切 安 好";
					}
				}
				else
				{
					this.num_names = 3;
					if (this.global1.data[71] == 1)
					{
						this.Name_3.text = " 配 给 券";
					}
					else
					{
						this.Name_3.text = " 生 活 质 量";
					}
					if (this.global1.data[71] == 1)
					{
						int num10 = 0;
						for (int l = 0; l < this.global1.science.Length; l++)
						{
							if (this.global1.science[l])
							{
								num10++;
							}
						}
						this.Text_3.text = "<color=red> 饥 荒 的 开 始</color>\n";
						this.Text_3.text = " 每 周:\n 人 民 支 持: -0.5;\n 党 内 团 结: -0.4\n 预 算: -0.2\n";
						TextMesh text_52 = this.Text_3;
						text_52.text = text_52.text + " 当 生 活 条 件\n 小 于 " + (36 - num10).ToString();
					}
					else if (this.global1.data[71] == 2)
					{
						int num11 = 0;
						for (int m = 0; m < this.global1.science.Length; m++)
						{
							if (this.global1.science[m])
							{
								num11++;
							}
						}
						this.Text_3.text = "<color=red> 低 生 活 条 件</color>\n";
						TextMesh text_53 = this.Text_3;
						text_53.text += " 每 周:\n 人 民 支 持: -0.2;\n 党 内 团 结: -0.1\n";
						TextMesh text_54 = this.Text_3;
						text_54.text = text_54.text + " 当 生 活 条 件\n 小 于 " + (58 - num11).ToString();
					}
					else if (this.global1.data[71] == 3)
					{
						int num12 = 0;
						for (int n = 0; n < this.global1.science.Length; n++)
						{
							if (this.global1.science[n])
							{
								num12++;
							}
						}
						this.Text_3.text = "<color=red> 平 均 生 活 条 件</color>\n";
						TextMesh text_55 = this.Text_3;
						text_55.text += " 每 周:\n 人 民 支 持: -0.1;\n 党 内 团 结: -0.1\n 西 方 情 结: +0.1\n";
						TextMesh text_56 = this.Text_3;
						text_56.text = text_56.text + " 当 生 活 条 件\n 小 于 " + (78 - num12).ToString();
					}
					else if (this.global1.data[71] == 4)
					{
						int num13 = 0;
						for (int num14 = 0; num14 < this.global1.science.Length; num14++)
						{
							if (this.global1.science[num14])
							{
								num13++;
							}
						}
						this.Text_3.text = "<color=red> 高 生 活 条 件</color>\n";
						TextMesh text_57 = this.Text_3;
						text_57.text += " 每 周:\n 人 民 支 持: +0.1;\n 党 内 团 结: +0.1\n 西 方 情 结: +0.1\n";
						TextMesh text_58 = this.Text_3;
						text_58.text = text_58.text + " 当 生 活 条 件\n 小 于 " + (93 - num13).ToString();
					}
					else if (this.global1.data[71] == 5)
					{
						int num15 = 0;
						for (int num16 = 0; num16 < this.global1.science.Length; num16++)
						{
							if (this.global1.science[num16])
							{
								num15++;
							}
						}
						this.Text_3.text = "<color=red> 西 化 的 生 活 条 件</color>\n";
						TextMesh text_59 = this.Text_3;
						text_59.text += " 每 周:\n 人 民 支 持: +0.3;\n 党 内 团 结: +0.1\n 预 算: -0.1\n 西 方 情 结: -0.1\n";
						TextMesh text_60 = this.Text_3;
						text_60.text = text_60.text + " 当 生 活 条 件 大 于 " + (93 - num15).ToString();
					}
					else
					{
						int num17 = 0;
						for (int num18 = 0; num18 < this.global1.science.Length; num18++)
						{
							if (this.global1.science[num18])
							{
								num17++;
							}
						}
						this.Text_3.text = " 一 切 安 好\n 当 生 活 条 件\n 大 于 " + (35 - num17).ToString();
					}
				}
				this.Text_1.text = " 当 前:\n" + this.global1.data[63].ToString();
				if (this.global1.data[21] <= 1991)
				{
					if (this.global1.science[5])
					{
						TextMesh text_61 = this.Text_1;
						text_61.text = text_61.text + "\n 最 小 规 模:\n" + ((this.global1.data[21] - 1989) * 2).ToString();
					}
					else if (this.global1.science[4])
					{
						TextMesh text_62 = this.Text_1;
						text_62.text = text_62.text + "\n 最 小 规 模:\n" + ((this.global1.data[21] - 1988) * 2).ToString();
					}
					else if (this.global1.science[3])
					{
						TextMesh text_63 = this.Text_1;
						text_63.text = text_63.text + "\n 最 小 规 模:\n" + ((this.global1.data[21] - 1987) * 2).ToString();
					}
					else
					{
						TextMesh text_64 = this.Text_1;
						text_64.text = text_64.text + "\n 最 小 规 模:\n" + ((this.global1.data[21] - 1986) * 2).ToString();
					}
				}
				TextMesh text_65 = this.Text_1;
				text_65.text += "\n 通 过 达 成 贸 易 协 议\n 以 及 地 图 上 的 行 动\n 增 长";
				this.Text_2.text = " 预 算 减 少\n 每 月: -" + (this.global1.data[63] / 2 / 10).ToString() + "." + Mathf.Abs(this.global1.data[63] / 2 % 10).ToString();
				TextMesh text_66 = this.Text_2;
				text_66.text += "\n 支 出 减 少\n 每 月: - 4";
			}
		}
		else if (this.num_this == 0)
		{
			this.num_names = 3;
			this.Name_1.text = "Текущий экспорт";
			this.Name_2.text = "Нужда в импорте";
			this.Name_3.text = "Разница";
			if (this.global1.data[0] != 20 && this.global1.data[0] != 12)
			{
				this.Text_1.text = "% от 1985:\n" + this.global1.data[23].ToString() + "%";
				this.Text_2.text = "% от 1985:\n" + this.global1.data[24].ToString() + "%";
				this.Text_3.text = "% от 1985:\n" + (this.global1.data[23] - this.global1.data[24]).ToString() + "%";
			}
			else if (this.global1.data[0] == 12)
			{
				this.Text_1.text = "% от 1973:\n" + this.global1.data[23].ToString() + "%";
				this.Text_2.text = "% от 1973:\n" + this.global1.data[24].ToString() + "%";
				this.Text_3.text = "% от 1973:\n" + (this.global1.data[23] - this.global1.data[24]).ToString() + "%";
			}
			else
			{
				this.Text_1.text = "% от 1961:\n" + this.global1.data[23].ToString() + "%";
				this.Text_2.text = "% от 1961:\n" + this.global1.data[24].ToString() + "%";
				this.Text_3.text = "% от 1961:\n" + (this.global1.data[23] - this.global1.data[24]).ToString() + "%";
			}
			if (this.global1.data[23] > this.global1.data[24])
			{
				TextMesh textMesh10 = this.Text_3;
				textMesh10.text = string.Concat(new string[]
				{
					textMesh10.text,
					"\nВыручка от сделок\n(еженедельно): +",
					((this.global1.data[23] - this.global1.data[24]) / 20).ToString(),
					".",
					Mathf.Abs((this.global1.data[23] - this.global1.data[24]) / 2 % 10).ToString()
				});
				textMesh10 = this.Text_3;
				textMesh10.text = string.Concat(new string[]
				{
					textMesh10.text,
					"\nУдовлетворение народа\n(еженедельно): +",
					((this.global1.data[23] - this.global1.data[24]) / 20).ToString(),
					".",
					Mathf.Abs((this.global1.data[23] - this.global1.data[24]) / 2 % 10).ToString()
				});
			}
			else
			{
				TextMesh textMesh11 = this.Text_3;
				textMesh11.text = string.Concat(new string[]
				{
					textMesh11.text,
					"\nВыручка от сделок\n(еженедельно): -",
					((this.global1.data[23] - this.global1.data[24]) / 20).ToString(),
					".",
					Mathf.Abs((this.global1.data[23] - this.global1.data[24]) / 2 % 10).ToString()
				});
				textMesh11 = this.Text_3;
				textMesh11.text = string.Concat(new string[]
				{
					textMesh11.text,
					"\nУдовлетворение народа\n(еженедельно): -",
					((this.global1.data[23] - this.global1.data[24]) / 30).ToString(),
					".",
					Mathf.Abs((this.global1.data[23] - this.global1.data[24]) / 3 % 10).ToString()
				});
				textMesh11 = this.Text_3;
				textMesh11.text = string.Concat(new string[]
				{
					textMesh11.text,
					"\nУровень жизни\n(еженедельно): -",
					((this.global1.data[23] - this.global1.data[24]) / 40).ToString(),
					".",
					Mathf.Abs((this.global1.data[23] - this.global1.data[24]) / 4 % 10).ToString()
				});
			}
		}
		else if (this.num_this == 1)
		{
			this.num_names = 3;
			this.Name_1.text = "Торговые партнёры";
			this.Name_2.text = "";
			this.Name_3.text = "Статус";
			if (this.global1.data[19] > 1)
			{
				this.Text_1.text = string.Concat(new string[]
				{
					"За прошлое (",
					(this.global1.data[19] - 1).ToString(),
					") число:\n",
					this.global1.data[25].ToString(),
					" шт."
				});
			}
			else
			{
				this.Text_1.text = "За 31 число:\n" + this.global1.data[25].ToString() + " шт.";
			}
			TextMesh text_67 = this.Text_1;
			text_67.text += "\n\n<color=red>Торговые:</color>\n";
			string text6 = "";
			string text7 = "";
			string text8 = "";
			for (int num19 = 0; num19 < this.global1.allcountries.Length; num19++)
			{
				if (this.global1.allcountries[num19] != null)
				{
					if (this.global1.allcountries[num19].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV && this.global1.allcountries[num19].Torg && num19 != this.global1.data[0])
					{
						text8 = text8 + this.global1.allcountries[num19].name + "; ";
					}
					else if (((this.global1.allcountries[num19].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV) || (this.global1.allcountries[num19].Vyshi && this.global1.allcountries[this.global1.data[0]].Vyshi)) && !this.global1.allcountries[num19].Torg && num19 != this.global1.data[0])
					{
						text7 = text7 + this.global1.allcountries[num19].name + "; ";
					}
					else if (this.global1.allcountries[num19].Torg)
					{
						text6 = text6 + this.global1.allcountries[num19].name + "; ";
					}
				}
			}
			text6 = this.Text(text6, 30);
			TextMesh text_68 = this.Text_1;
			text_68.text += text6;
			TextMesh text_69 = this.Text_1;
			text_69.text += "\n<color=red>Экономические:</color>\n";
			text7 = this.Text(text7, 30);
			TextMesh text_70 = this.Text_1;
			text_70.text += text7;
			TextMesh text_71 = this.Text_1;
			text_71.text += "\n<color=red>Стратегические:</color>\n";
			text8 = this.Text(text8, 30);
			TextMesh text_72 = this.Text_1;
			text_72.text += text8;
			if (this.global1.data[25] < 4)
			{
				this.Text_3.text = "Изоляция";
				TextMesh textMesh12 = this.Text_3;
				textMesh12.text = string.Concat(new string[]
				{
					textMesh12.text,
					"\nВестальгия (еженедельно): -",
					((-4 + this.global1.data[25]) / 10).ToString(),
					".",
					Mathf.Abs((-4 + this.global1.data[25]) % 10).ToString()
				});
				textMesh12 = this.Text_3;
				textMesh12.text = string.Concat(new string[]
				{
					textMesh12.text,
					"\nСуверенитет (еженедельно): +",
					((4 - this.global1.data[25]) / 10).ToString(),
					".",
					Mathf.Abs((4 - this.global1.data[25]) % 10).ToString()
				});
				textMesh12 = this.Text_3;
				textMesh12.text = string.Concat(new string[]
				{
					textMesh12.text,
					"\nУровень жизни\n(еженедельно): -",
					((-4 + this.global1.data[25]) / 10).ToString(),
					".",
					Mathf.Abs((-4 + this.global1.data[25]) % 10).ToString()
				});
				textMesh12 = this.Text_3;
				textMesh12.text = string.Concat(new string[]
				{
					textMesh12.text,
					"\nАгенты (еженедельно): -",
					((-4 + this.global1.data[25]) / 10).ToString(),
					".",
					Mathf.Abs((-4 + this.global1.data[25]) % 10).ToString()
				});
			}
			else if (this.global1.data[25] > 8)
			{
				this.Text_3.text = "Глобализация";
				TextMesh textMesh13 = this.Text_3;
				textMesh13.text = string.Concat(new string[]
				{
					textMesh13.text,
					"\nВестальгия (еженедельно): +",
					((this.global1.data[25] - 8) / 10).ToString(),
					".",
					Mathf.Abs((this.global1.data[25] - 8) % 10).ToString()
				});
				if (this.global1.data[25] < 18)
				{
					textMesh13 = this.Text_3;
					textMesh13.text = string.Concat(new string[]
					{
						textMesh13.text,
						"\nСуверенитет (еженедельно): -",
						((8 - this.global1.data[25]) / 10).ToString(),
						".",
						Mathf.Abs((8 - this.global1.data[25]) % 10).ToString()
					});
				}
				else
				{
					textMesh13 = this.Text_3;
					textMesh13.text = string.Concat(new string[]
					{
						textMesh13.text,
						"\nСуверенитет (еженедельно): ",
						((8 - this.global1.data[25]) / 10).ToString(),
						".",
						Mathf.Abs((8 - this.global1.data[25]) % 10).ToString()
					});
				}
				textMesh13 = this.Text_3;
				textMesh13.text = string.Concat(new string[]
				{
					textMesh13.text,
					"\nУровень жизни\n(еженедельно): +",
					((this.global1.data[25] - 8) / 10).ToString(),
					".",
					Mathf.Abs((this.global1.data[25] - 8) % 10).ToString()
				});
			}
			else
			{
				this.Text_3.text = "Баланс";
			}
			this.Text_2.text = "";
		}
		else if (this.num_this == 2)
		{
			if (this.global1.data[0] != 5 || this.global1.data[26] <= 0 || (this.global1.data[0] == 5 && !this.global1.event_done[94]))
			{
				if (this.global1.data[26] > 0)
				{
					this.num_names = 2;
					this.Name_1.text = "Государственный долг";
					this.Name_2.text = "Разница";
					this.Text_1.text = "Задолжность: " + (this.global1.data[26] / 10).ToString() + "." + Mathf.Abs(this.global1.data[26] % 10).ToString();
					if (this.global1.data[34] >= 0)
					{
						this.Text_2.text = "между взятием и выплатой.\nВысвобождение средств от\nвыплаты долгов\n(еженедельно):\n+" + (this.global1.data[34] / 10).ToString() + "." + Mathf.Abs(this.global1.data[34] % 10).ToString();
						TextMesh text_73 = this.Text_2;
						text_73.text = text_73.text + "\nОсталось недель до выплаты\nПримерно: " + (this.global1.data[26] / this.global1.data[34]).ToString();
					}
					else
					{
						this.Text_2.text = "между взятием и выплатой.\nВысвобождение средств от\nвыплаты долгов\n(еженедельно):\n0";
					}
				}
				else
				{
					this.num_names = 1;
					this.Name_1.text = "Государственный долг";
					this.Text_1.text = "Задолжность: 0";
				}
			}
			else
			{
				this.num_names = 1;
				this.Name_1.text = "Пятилетка экономии";
				this.Text_1.text = "Прибыль:\n+" + (this.global1.data[34] / 10).ToString() + "." + Mathf.Abs(this.global1.data[34] % 10).ToString();
			}
		}
		else if (this.num_this == 3 && this.global1.data[0] != 12)
		{
			if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
			{
				this.num_names = 1;
				Yugoglobal component2 = GameObject.Find("Yugoglobal(Clone)").GetComponent<Yugoglobal>();
				this.Name_1.text = component2.science_text[106];
				this.Text_1.text = "";
				this.Text_1.characterSize = 0.08f;
				for (int num20 = 1; num20 < component2.gameState.modifies.Length; num20++)
				{
					if (component2.gameState.modifies[num20] > 0)
					{
						TextMesh text_74 = this.Text_1;
						text_74.text = text_74.text + "\n" + string.Format(component2.science_text[190 + num20 - 1], component2.gameState.modifies[num20]);
						int num21 = 0;
						int num22 = 0;
						string text9 = component2.science_text[227 + num20 - 1];
						string text10 = component2.science_text[227 + num20 - 1];
						for (int num23 = 0; num23 < text9.Length; num23++)
						{
							num22++;
							if (text9[num23] == char.Parse(":"))
							{
								num21++;
							}
							if (num21 == component2.gameState.modifies[num20])
							{
								text10 = text10.Remove(0, num22);
								num22 = -1;
								num21 = 100;
							}
							else if (num21 > 100)
							{
								text10 = text10.Remove(num22);
								break;
							}
						}
						TextMesh text_75 = this.Text_1;
						text_75.text = text_75.text + "\n<color=red>" + text10 + "</color>";
					}
				}
			}
			else
			{
				this.num_names = 3;
				this.Name_1.text = "Полностью открытые";
				this.Name_2.text = "Открытые платно";
				this.Name_3.text = "Ограниченные";
				this.Text_1.text = "Границ: " + this.global1.data[27].ToString();
				TextMesh textMesh14;
				if (this.global1.data[216] < 50)
				{
					textMesh14 = this.Text_1;
					textMesh14.text = string.Concat(new string[]
					{
						textMesh14.text,
						"\nОдобрение СССР и народа\nЕженедельно: +",
						(this.global1.data[27] / 10).ToString(),
						".",
						Mathf.Abs(this.global1.data[27] % 10).ToString()
					});
				}
				else
				{
					textMesh14 = this.Text_1;
					textMesh14.text = string.Concat(new string[]
					{
						textMesh14.text,
						"\nОдобрение народа\nЕженедельно: +",
						(this.global1.data[27] / 10).ToString(),
						".",
						Mathf.Abs(this.global1.data[27] % 10).ToString()
					});
				}
				textMesh14 = this.Text_1;
				textMesh14.text = string.Concat(new string[]
				{
					textMesh14.text,
					"\nВестальгия\nЕженедельно: +",
					(this.global1.data[28] / 10).ToString(),
					".",
					Mathf.Abs(this.global1.data[28] % 10).ToString()
				});
				this.Text_2.text = "Границ: " + this.global1.data[28].ToString();
				textMesh14 = this.Text_2;
				textMesh14.text = string.Concat(new string[]
				{
					textMesh14.text,
					"\nТаможенная выручка\nЕженедельно: +",
					(this.global1.data[28] / 10).ToString(),
					".",
					Mathf.Abs(this.global1.data[28] % 10).ToString()
				});
				this.Text_3.text = "Границ: " + this.global1.data[29].ToString();
				textMesh14 = this.Text_3;
				textMesh14.text = string.Concat(new string[]
				{
					textMesh14.text,
					"\nВестальгия\nЕженедельно: -",
					(this.global1.data[29] / 10).ToString(),
					".",
					Mathf.Abs(this.global1.data[29] % 10).ToString()
				});
				TextMesh text_76 = this.Text_3;
				text_76.text = text_76.text + "\n\nЗакрытые границы: " + (5 - this.global1.data[27] - this.global1.data[28] - this.global1.data[29]).ToString();
			}
		}
		else if (this.num_this == 3)
		{
			this.num_names = 1;
			this.Name_1.text = "Максимальная\nграница";
			this.Text_1.text = "";
			if (this.global1.data[80] - 20 < 80)
			{
				int num24 = (80 - (this.global1.data[80] - 20)) / 20;
				TextMesh text_77 = this.Text_1;
				text_77.text = text_77.text + "\nВерхний предел:\nЕдинство партии: " + (100 - num24 * 10).ToString();
				TextMesh text_78 = this.Text_1;
				text_78.text = text_78.text + "\nВерхний предел:\nПоддержка народа: " + (100 - num24 * 10).ToString();
				TextMesh text_79 = this.Text_1;
				text_79.text = text_79.text + "\nВерхний предел:\nУровень жизни: " + (100 - num24 * 10).ToString();
				TextMesh text_80 = this.Text_1;
				text_80.text = text_80.text + "\nНижний предел:\nВестальгия: " + (num24 * 15).ToString();
			}
		}
		else if (this.num_this == 4)
		{
			this.num_names = 2;
			if (this.global1.data[216] < 50)
			{
				this.Name_1.text = "Советская помощь";
			}
			else
			{
				this.Name_1.text = "Угроза варваров";
			}
			this.Text_1.text = "\nИтого: " + (this.global1.data[30] / 10).ToString() + "." + Mathf.Abs(this.global1.data[30] % 10).ToString();
			if (this.global1.data[216] < 50)
			{
				this.Name_2.text = "\nТекущая\nсоветская доктрина";
			}
			else
			{
				this.Name_2.text = "\nАктивное\nвытеснение в океаны";
			}
			if (this.global1.data[0] == 10)
			{
				this.num_names = 3;
				this.Name_3.text = "Китайская помощь";
				this.Text_3.text = "\nИтого: " + (this.global1.data[73] / 10).ToString() + "." + Mathf.Abs(this.global1.data[73] % 10).ToString();
			}
			if (this.global1.data[191] == 1 && !this.global1.event_done[409] && !this.global1.event_done[426])
			{
				this.Text_2.text = "\n\n\nДоктрина Бессмертных";
				TextMesh text_81 = this.Text_2;
				text_81.text += "\nРенессанс сотрудничества";
				TextMesh text_82 = this.Text_2;
				text_82.text += "\nв Восточной Европе.";
			}
			else if (this.global1.data[21] > 1991 || (this.global1.allcountries[7].isOVD && this.global1.is_gkchp) || (this.global1.allcountries[7].paths == 3 && this.global1.event_done[1075]))
			{
				this.Text_2.text = "\n\n\nСтабилизация";
				TextMesh text_83 = this.Text_2;
				text_83.text += "\nВнешняя политика пытается";
				TextMesh text_84 = this.Text_2;
				text_84.text += "\nбыть стабилизирована.";
			}
			else if (this.global1.event_done[35] && this.global1.data[21] <= 1991 && (!this.global1.is_gkchp || (this.global1.allcountries[7].Gosstroy > 1 && this.global1.is_gkchp)))
			{
				this.Text_2.text = "\n\n\nОтказ от помощи\nсоциалистическому лагерю";
				TextMesh text_85 = this.Text_2;
				text_85.text += "\nВлияние ежемесячно:";
				TextMesh text_86 = this.Text_2;
				text_86.text += "\nСтабильность соцлагеря: -1";
				TextMesh text_87 = this.Text_2;
				text_87.text += "\nНикакой помощи!";
			}
			else if (this.global1.event_done[4] && this.global1.data[21] <= 1991 && (!this.global1.is_gkchp || (this.global1.allcountries[7].Gosstroy > 1 && this.global1.is_gkchp)))
			{
				this.Text_2.text = "\n\n\nДоктрина Синатры";
				TextMesh text_88 = this.Text_2;
				text_88.text += "\nВлияние ежемесячно:";
				TextMesh text_89 = this.Text_2;
				text_89.text += "\nСтабильность соцлагеря: -1";
				TextMesh text_90 = this.Text_2;
				text_90.text += "\nСоветская помощь: -2%";
			}
			else
			{
				this.Text_2.text = "\n\n\nДоктрина Брежнева";
				TextMesh text_91 = this.Text_2;
				text_91.text += "\nСтабильность";
			}
		}
		else if (this.num_this == 5)
		{
			this.num_names = 2;
			this.Name_1.text = "Мировоззрение";
			this.Name_2.text = "Особое влияние";
			this.Text_1.text = "Сейчас:";
			if (this.global1.data[31] > 700)
			{
				TextMesh textMesh15 = this.Text_1;
				textMesh15.text = string.Concat(new string[]
				{
					textMesh15.text,
					"\nНационализм\n(",
					(this.global1.data[31] / 10).ToString(),
					".",
					Mathf.Abs(this.global1.data[31] % 10).ToString(),
					"/100)"
				});
				this.Text_2.text = "Вестальгия\nЕженедельно: -" + ((this.global1.data[31] - 500) / 100 / 10).ToString() + "." + Mathf.Abs((this.global1.data[31] - 500) / 100 % 10).ToString();
				textMesh15 = this.Text_2;
				textMesh15.text = string.Concat(new string[]
				{
					textMesh15.text,
					"\nПоддержка партии\nЕженедельно: +",
					((this.global1.data[31] - 500) / 100 / 10).ToString(),
					".",
					Mathf.Abs((this.global1.data[31] - 500) / 100 % 10).ToString()
				});
				textMesh15 = this.Text_2;
				textMesh15.text = string.Concat(new string[]
				{
					textMesh15.text,
					"\nСуверенитет\nЕженедельно: +",
					((this.global1.data[31] - 500) / 50 / 10).ToString(),
					".",
					Mathf.Abs((this.global1.data[31] - 500) / 50 % 10).ToString()
				});
				if (this.global1.data[216] < 50)
				{
					textMesh15 = this.Text_2;
					textMesh15.text = string.Concat(new string[]
					{
						textMesh15.text,
						"\nОдобрение СССР\nЕженедельно: -",
						((this.global1.data[31] - 500) / 100 / 10).ToString(),
						".",
						Mathf.Abs((this.global1.data[31] - 500) / 100 % 10).ToString()
					});
					textMesh15 = this.Text_2;
					textMesh15.text = string.Concat(new string[]
					{
						textMesh15.text,
						"\nНедовольство НАТО\nЕженедельно: +",
						((this.global1.data[31] - 500) / 100 / 10).ToString(),
						".",
						Mathf.Abs((this.global1.data[31] - 500) / 100 % 10).ToString()
					});
				}
			}
			else if (this.global1.data[31] >= 400 && this.global1.data[31] <= 700)
			{
				TextMesh text_92 = this.Text_1;
				text_92.text = string.Concat(new string[]
				{
					text_92.text,
					"\nПатриотизм советского типа\n(",
					(this.global1.data[31] / 10).ToString(),
					".",
					Mathf.Abs(this.global1.data[31] % 10).ToString(),
					"/100)"
				});
				this.Text_2.text = "Отсутствует".ToString();
			}
			else
			{
				TextMesh textMesh16 = this.Text_1;
				textMesh16.text = string.Concat(new string[]
				{
					textMesh16.text,
					"\nКосмополитизм\n(",
					(this.global1.data[31] / 10).ToString(),
					".",
					Mathf.Abs(this.global1.data[31] % 10).ToString(),
					"/100)"
				});
				this.Text_2.text = "Вестальгия\nЕженедельно: +" + ((500 - this.global1.data[31]) / 100 / 10).ToString() + "." + Mathf.Abs((500 - this.global1.data[31]) / 100 % 10).ToString();
				textMesh16 = this.Text_2;
				textMesh16.text = string.Concat(new string[]
				{
					textMesh16.text,
					"\nПоддержка партии\nЕженедельно: +",
					((500 - this.global1.data[31]) / 100 / 10).ToString(),
					".",
					Mathf.Abs((500 - this.global1.data[31]) / 100 % 10).ToString()
				});
				textMesh16 = this.Text_2;
				textMesh16.text = string.Concat(new string[]
				{
					textMesh16.text,
					"\nСуверенитет\nЕженедельно: -",
					((500 - this.global1.data[31]) / 50 / 10).ToString(),
					".",
					Mathf.Abs((500 - this.global1.data[31]) / 50 % 10).ToString()
				});
				if (this.global1.data[216] < 50)
				{
					textMesh16 = this.Text_2;
					textMesh16.text = string.Concat(new string[]
					{
						textMesh16.text,
						"\nНедовольство НАТО\nЕженедельно: -",
						((500 - this.global1.data[31]) / 100 / 10).ToString(),
						".",
						Mathf.Abs((500 - this.global1.data[31]) / 100 % 10).ToString()
					});
				}
			}
		}
		else if (this.num_this == 6)
		{
			this.num_names = 2;
			this.Name_1.text = "Суверенитет";
			this.Name_2.text = "Особое влияние";
			this.Text_1.text = string.Concat(new string[]
			{
				"Сейчас: ",
				(this.global1.data[22] / 10).ToString(),
				".",
				Mathf.Abs(this.global1.data[22] % 10).ToString(),
				"/100"
			});
			if (this.global1.data[22] - 500 < 0)
			{
				this.Text_2.text = "Вестальгия\nЕженедельно: +" + ((this.global1.data[22] - 500) / 100 / 10).ToString() + "." + Mathf.Abs((this.global1.data[22] - 500) / 100 % 10).ToString();
			}
			else
			{
				this.Text_2.text = "Вестальгия\nЕженедельно: -" + ((this.global1.data[22] - 500) / 100 / 10).ToString() + "." + Mathf.Abs((this.global1.data[22] - 500) / 100 % 10).ToString();
			}
			if (this.global1.allcountries[7].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV)
			{
				TextMesh text_93 = this.Text_2;
				text_93.text = string.Concat(new string[]
				{
					text_93.text,
					"\nПоддержка Партии\nЕженедельно: +",
					(this.global1.data[22] / 100 / 10).ToString(),
					".",
					Mathf.Abs(this.global1.data[22] / 100 % 10).ToString()
				});
			}
			else
			{
				TextMesh text_94 = this.Text_2;
				text_94.text = string.Concat(new string[]
				{
					text_94.text,
					"\nПоддержка Партии\nЕженедельно: +",
					(this.global1.data[22] / 50 / 10).ToString(),
					".",
					Mathf.Abs(this.global1.data[22] / 50 % 10).ToString()
				});
			}
			TextMesh text_95 = this.Text_2;
			text_95.text += "\nТакже влияет на\nвероятность поражения.";
			if (this.global1.data[0] == 10)
			{
				this.num_names = 3;
				this.Name_3.text = "Ядерная программа";
				if (this.global1.data[100] > 0 && this.global1.event_done[255])
				{
					this.Text_3.text = "ежемесячно:\nАгенты: -0.5\nПатриотизм +0.5\nБюджет -10%";
				}
				else if (this.global1.data[100] > 0)
				{
					this.Text_3.text = "ежемесячно:\nАгенты: -0.5\nПатриотизм +0.5";
				}
				else
				{
					this.Text_3.text = "У нас её нет";
				}
			}
		}
		else if (this.num_this == 7)
		{
			this.num_names = 2;
			this.Name_1.text = "Остальгия";
			this.Name_2.text = "Особое влияние";
			if (this.global1.data[0] == 10)
			{
				this.num_names = 3;
				this.Name_3.text = "Западные санкции";
				if (this.global1.data[72] > 0)
				{
					this.Text_3.text = "Еженедельно:\nДипрепутация: +0.2;\nНедовольство НАТО: +0.2\nБюджет: -0.5\nСуверенитет: +0.2\nУровень жизни: -0.2";
				}
				else
				{
					this.Text_3.text = "Нет";
				}
			}
			else if (this.global1.data[0] == 18)
			{
				this.num_names = 3;
				this.Name_3.text = "Американское эмбарго";
				if (this.global1.data[77] > 0)
				{
					this.Text_3.text = string.Concat(new object[]
					{
						"Еженедельно:\nСуверенитет: +0.2\nБюджет: -0.",
						this.global1.data[77],
						"\nНедовольство НАТО: +0.",
						this.global1.data[77] / 2,
						"\nПоддержка народа: +0.",
						this.global1.data[77]
					});
				}
				else
				{
					this.Text_3.text = "Нет";
				}
			}
			else if (this.global1.data[0] >= 1 && this.global1.data[0] <= 6)
			{
				this.num_names = 3;
				this.Name_3.text = "Западные санкции";
				if (this.global1.data[72] > 0)
				{
					this.Text_3.text = "Еженедельно:\nДипрепутация: +0.2;\nНедовольство НАТО: +0.2\nБюджет: -0.5\nСуверенитет: +0.2";
				}
				else
				{
					this.Text_3.text = "Нет";
				}
			}
			this.Text_1.text = string.Concat(new string[]
			{
				"Недовольство граждан Запада\nи их сочуствие левым идеям:\n",
				(this.global1.allcountries[17].Westalgie / 10).ToString(),
				".",
				Mathf.Abs(this.global1.allcountries[17].Westalgie % 10).ToString(),
				"/100"
			});
			this.Text_2.text = "Вестальгия\nЕженедельно: -" + (this.global1.allcountries[17].Westalgie / 80 / 10).ToString() + "." + Mathf.Abs(this.global1.allcountries[17].Westalgie / 80 % 10).ToString();
			TextMesh text_96 = this.Text_2;
			text_96.text = string.Concat(new string[]
			{
				text_96.text,
				"\nНедовольство НАТО\nЕженедельно: -",
				(this.global1.allcountries[17].Westalgie / 120 / 10).ToString(),
				".",
				Mathf.Abs(this.global1.allcountries[17].Westalgie / 120 % 10).ToString()
			});
		}
		else if (this.num_this == 8 && this.global1.data[0] != 12)
		{
			this.num_names = 3;
			this.Name_1.text = "АЗИЯ";
			this.Name_2.text = "ЕВРОПА";
			this.Name_3.text = "АФРИКА";
			if (this.global1.data[216] < 50)
			{
				this.Text_1.text = "Контроль в Афганистане: ";
			}
			else
			{
				this.Text_1.text = "Контроль в дистрикте №15: ";
			}
			int num25 = 30;
			if (this.global1.allcountries[7].isSEV || this.global1.allcountries[16].isSEV || this.global1.allcountries[19].Gosstroy <= 0)
			{
				num25 += 25;
			}
			if (this.global1.allcountries[31].Help)
			{
				num25 += 5;
			}
			if (this.global1.data[37] <= 6)
			{
				num25 += this.global1.data[37] * 4;
			}
			else if (this.global1.data[37] <= 8)
			{
				num25 += this.global1.data[37] * 5;
			}
			else
			{
				num25 += 40;
			}
			TextMesh text_97 = this.Text_1;
			text_97.text = text_97.text + num25.ToString() + " %";
			if (this.global1.data[216] < 50)
			{
				TextMesh text_98 = this.Text_1;
				text_98.text += "\nРазвитость НДРЙ: ";
			}
			else
			{
				TextMesh text_99 = this.Text_1;
				text_99.text += "\nРазвитие в дистрикте №27: ";
			}
			num25 = 40;
			if (this.global1.allcountries[24].Stasi)
			{
				num25 += 25;
			}
			if (this.global1.allcountries[24].Gosstroy == 0)
			{
				num25 += 5;
			}
			if (this.global1.data[55] <= 1)
			{
				num25 += this.global1.data[55] * 10;
			}
			else
			{
				num25 += 30;
			}
			TextMesh text_100 = this.Text_1;
			text_100.text = text_100.text + num25.ToString() + " %";
			if (this.global1.data[216] < 50)
			{
				TextMesh text_101 = this.Text_1;
				text_101.text += "\nКонтроль в Непале: ";
			}
			else
			{
				TextMesh text_102 = this.Text_1;
				text_102.text += "\nРазвитие в дистрикте №46: ";
			}
			TextMesh textMesh17 = this.Text_1;
			textMesh17.text = string.Concat(new string[]
			{
				textMesh17.text,
				(this.global1.allcountries[43].Westalgie / 10).ToString(),
				".",
				Mathf.Abs(this.global1.allcountries[43].Westalgie % 10).ToString(),
				" %"
			});
			if (this.global1.data[0] < 49 || this.global1.data[0] > 51)
			{
				if (this.global1.data[216] < 50)
				{
					this.Text_2.text = "Контроль в Югославии: ";
				}
				else
				{
					this.Text_2.text = "Контроль в столичном регионе: ";
				}
				num25 = 25;
				if (this.global1.allcountries[5].isOVD || this.global1.allcountries[6].isOVD)
				{
					num25 += 20;
				}
				if (this.global1.allcountries[this.global1.data[0]].isOVD)
				{
					num25 += 20;
				}
				if (this.global1.data[54] <= 4)
				{
					num25 += this.global1.data[54] * 3;
				}
				else if (this.global1.data[54] <= 6)
				{
					num25 += this.global1.data[54] * 5;
				}
				else
				{
					num25 += 35;
				}
				if (this.global1.data[59] == 2)
				{
					num25 -= num25 / 3;
				}
				num25 -= this.global1.data[206] * 10;
				TextMesh text_103 = this.Text_2;
				text_103.text = text_103.text + num25.ToString() + " %";
			}
			else if (this.global1.data[191] == 1 || this.global1.data[131] == 1)
			{
				this.Text_2.text = "Мощь антиюгославских сил \nв сравнении \nс началом 1991 года: ";
				num25 = 100;
				if (this.global1.data[21] >= 1992)
				{
					num25 -= this.yug1.gameState.modifies[30] * 13;
				}
				else
				{
					num25 -= this.yug1.gameState.modifies[30] * this.global1.data[20];
				}
				if (this.global1.data[193] == 1)
				{
					num25 += 20;
				}
				else if (this.global1.data[193] == 2)
				{
					num25 -= 15;
				}
				num25 -= this.global1.data[115] * 2;
				if (this.yug1.gameState.modifies[32] == 1)
				{
					num25 += 10;
				}
				if (this.global1.data[196] == 1)
				{
					num25 -= 10;
				}
				if (this.yug1.gameState.modifies[31] == 1)
				{
					num25 += 15;
				}
				if (this.global1.data[210] == 1)
				{
					num25 -= 7;
				}
				else if (this.global1.data[210] == 2)
				{
					num25 += 15;
				}
				if (this.global1.data[195] == 1)
				{
					num25 -= 30;
				}
				if (this.global1.data[112] == 12)
				{
					num25 -= 10;
				}
				if (this.global1.allcountries[49].isOVD || this.global1.allcountries[50].isOVD || this.global1.allcountries[51].isOVD)
				{
					num25 += 10;
					if (this.global1.allcountries[7].isOVD)
					{
						num25 += 15;
					}
				}
				num25 += 3 * this.global1.data[198];
				num25 -= 3 * this.global1.data[197];
				num25 -= 5 * this.global1.data[206];
				num25 -= this.global1.data[9] / 20;
				if (num25 <= 1)
				{
					num25 = 1;
				}
				this.global1.data[214] = num25;
				TextMesh text_104 = this.Text_2;
				text_104.text = text_104.text + num25.ToString() + " %";
			}
			else
			{
				this.Text_2.text = "Иди спасай Югославию!";
			}
			num25 = 0;
			if (this.global1.data[216] < 50)
			{
				TextMesh text_105 = this.Text_2;
				text_105.text += "\nСила фракции\n\"Союз\" в СССР: ";
			}
			else
			{
				TextMesh text_106 = this.Text_2;
				text_106.text += "\nСила фракции\n\"Союз\" в дистрикте №10: ";
			}
			if (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy == 0 && !this.global1.allcountries[7].Vyshi)
			{
				num25 = 100;
			}
			else if (this.global1.allcountries[7].isOVD && this.global1.allcountries[7].isSEV && !this.global1.is_gkchp && !this.global1.allcountries[7].Vyshi)
			{
				num25 = 80;
				num25 -= this.global1.allcountries[7].Gosstroy * 15;
			}
			else if ((this.global1.allcountries[7].isSEV || this.global1.allcountries[7].isOVD) && this.global1.data[7] >= 250 && !this.global1.is_gkchp && !this.global1.allcountries[7].Vyshi)
			{
				num25 = 60;
				num25 -= this.global1.allcountries[7].Gosstroy * 15;
			}
			else if ((this.global1.allcountries[7].isSEV && !this.global1.is_gkchp) || (this.global1.allcountries[7].isOVD && !this.global1.is_gkchp && !this.global1.allcountries[7].Vyshi) || (this.global1.data[7] >= 600 && !this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD && !this.global1.is_gkchp && !this.global1.allcountries[7].Vyshi))
			{
				num25 = 40;
				num25 -= this.global1.allcountries[7].Gosstroy * 15;
			}
			else if ((!this.global1.allcountries[7].Vyshi && this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy >= 2 && !this.global1.allcountries[7].Vyshi) || (!this.global1.is_gkchp && this.global1.data[7] <= 600 && !this.global1.allcountries[7].isSEV && !this.global1.allcountries[7].isOVD && !this.global1.allcountries[7].Vyshi))
			{
				num25 = 20;
			}
			else if (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy == 1 && !this.global1.allcountries[7].Vyshi)
			{
				num25 = 70;
			}
			else
			{
				num25 = num25;
			}
			num25 += this.global1.allcountries[7].Westalgie;
			if (num25 > 100)
			{
				num25 = 100;
			}
			TextMesh text_107 = this.Text_2;
			text_107.text = text_107.text + num25.ToString() + " %";
			if (this.global1.data[216] < 50)
			{
				this.Text_3.text = "Контроль в Алжире: ";
			}
			else
			{
				this.Text_3.text = "Контроль в дистрикте №43: ";
			}
			textMesh17 = this.Text_3;
			textMesh17.text = string.Concat(new string[]
			{
				textMesh17.text,
				(this.global1.allcountries[40].Westalgie / 10).ToString(),
				".",
				Mathf.Abs(this.global1.allcountries[40].Westalgie % 10).ToString(),
				" %"
			});
			if (this.global1.data[216] < 50)
			{
				TextMesh text_108 = this.Text_3;
				text_108.text += "\nКонтроль в Эфиопии: ";
			}
			else
			{
				TextMesh text_109 = this.Text_3;
				text_109.text += "\nКонтроль в дистрикте №44: ";
			}
			textMesh17 = this.Text_3;
			textMesh17.text = string.Concat(new string[]
			{
				textMesh17.text,
				(this.global1.allcountries[41].Westalgie / 10).ToString(),
				".",
				Mathf.Abs(this.global1.allcountries[41].Westalgie % 10).ToString(),
				" %"
			});
			if (this.global1.data[216] < 50)
			{
				TextMesh text_110 = this.Text_3;
				text_110.text += "\nКонтроль в Сомали: ";
			}
			else
			{
				TextMesh text_111 = this.Text_3;
				text_111.text += "\nКонтроль в дистрикте №45: ";
			}
			textMesh17 = this.Text_3;
			textMesh17.text = string.Concat(new string[]
			{
				textMesh17.text,
				(this.global1.allcountries[42].Westalgie / 10).ToString(),
				".",
				Mathf.Abs(this.global1.allcountries[42].Westalgie % 10).ToString(),
				" %"
			});
		}
		else if (this.num_this == 8)
		{
			this.num_names = 3;
			this.Name_1.text = "РЕГИОНЫ";
			this.Name_2.text = "ПОТЕРИ";
			this.Name_3.text = "БОЕВЫЕ ДЕЙСТВИЯ";
			this.Text_1.text = "Восток: " + ((this.global1.data[90] == 1) ? "Под контролем" : "Нет контроля");
			TextMesh text_112 = this.Text_1;
			text_112.text = text_112.text + "\nЗапад: " + ((this.global1.data[92] == 1) ? "Под контролем" : "Нет контроля");
			TextMesh text_113 = this.Text_1;
			text_113.text = text_113.text + "\nСевер: " + ((this.global1.data[93] == 1) ? "Под контролем" : "Нет контроля");
			TextMesh text_114 = this.Text_1;
			text_114.text = text_114.text + "\nЮг: " + ((this.global1.data[94] == 1) ? "Под контролем" : "Нет контроля");
			TextMesh textMesh18 = this.Text_1;
			textMesh18.text = string.Concat(new object[]
			{
				textMesh18.text,
				"\nИтого: ",
				this.global1.data[80],
				"%"
			});
			int num26 = 0;
			int num27 = 0;
			int num28 = 0;
			int num29 = 0;
			int num30 = 0;
			if (this.global1.data[90] != 1)
			{
				num30 -= 2;
				num28++;
				num27--;
			}
			if (this.global1.data[93] != 1)
			{
				num29 -= 2;
				num28++;
				num27--;
			}
			if (this.global1.data[92] != 1)
			{
				num26 -= 2;
				num28++;
				num27--;
			}
			if (this.global1.data[94] != 1)
			{
				num29--;
				num28++;
				num27--;
			}
			this.Text_2.text = string.Concat(new object[]
			{
				"-0.",
				num30 * -1,
				" Уровень жизни\n+0.",
				num28,
				" Вестальгия\n-0.",
				num27 * -1,
				" Поддержка народа\n-0.",
				num29 * -1,
				" Бюджет\n-0.",
				num26 * -1,
				" Агентурных сетей"
			});
			if (this.global1.data[88] == 0)
			{
				this.Text_3.text = "Всё стабильно";
			}
			else if (this.global1.data[88] == 1)
			{
				this.Text_3.text = "Нападаем: ";
			}
			else if (this.global1.data[88] == 2)
			{
				this.Text_3.text = "Обороняемся: ";
			}
			if (this.global1.data[107] == 1)
			{
				textMesh18 = this.Text_3;
				textMesh18.text = string.Concat(new object[]
				{
					textMesh18.text,
					"\nВосток\nКонтроль: ",
					this.global1.data[108],
					"%"
				});
			}
			else if (this.global1.data[107] == 2)
			{
				textMesh18 = this.Text_3;
				textMesh18.text = string.Concat(new object[]
				{
					textMesh18.text,
					"\nЗапад\nКонтроль: ",
					this.global1.data[108],
					"%"
				});
			}
			else if (this.global1.data[107] == 3)
			{
				textMesh18 = this.Text_3;
				textMesh18.text = string.Concat(new object[]
				{
					textMesh18.text,
					"\nСевер\nКонтроль: ",
					this.global1.data[108],
					"%"
				});
			}
			else if (this.global1.data[107] == 4)
			{
				textMesh18 = this.Text_3;
				textMesh18.text = string.Concat(new object[]
				{
					textMesh18.text,
					"\nЮг\nКонтроль: ",
					this.global1.data[108],
					"%"
				});
			}
			else if (this.global1.data[107] == 10)
			{
				textMesh18 = this.Text_3;
				textMesh18.text = string.Concat(new object[]
				{
					textMesh18.text,
					"\nКабул\nКонтроль: ",
					this.global1.data[108],
					"%"
				});
			}
		}
		else if (this.num_this == 9)
		{
			this.num_names = 2;
			this.Name_1.text = "Админтраты";
			this.Name_2.text = "Особое влияние";
			if (this.global1.data[0] == 10 || this.global1.data[0] == 12)
			{
				this.num_names = 3;
				if (this.global1.data[71] > 0)
				{
					this.Name_3.text = "Голод";
					this.Text_3.text = "Еженедельно:\nПоддержка народа: -0.5;\nЕдинство партии: -0.4\nБюджет: -0.2\nСуверенитет: -0.2";
				}
				else
				{
					this.Name_3.text = "Отсутствие голода";
					this.Text_3.text = "Всё хорошо\nпока уровень жизни\nбольше 20.0";
				}
			}
			else if (this.global1.data[0] == 18)
			{
				this.num_names = 3;
				this.Name_3.text = "Особый период";
				if (this.global1.data[102] > 0)
				{
					this.Text_3.text = "Еженедельно:\nИзменяет бюджет на 0." + (this.global1.data[102] - 1).ToString();
					if (this.global1.data[5] > 400 - this.global1.data[102] * 30)
					{
						TextMesh text_115 = this.Text_3;
						text_115.text = text_115.text + "\nУровень жизни: -0." + this.global1.data[102].ToString();
					}
					if (this.global1.allcountries[this.global1.data[0]].isSEV || this.global1.allcountries[7].isSEV)
					{
						TextMesh text_116 = this.Text_3;
						text_116.text = string.Concat(new object[]
						{
							text_116.text,
							"\nВестальгия: +0.",
							this.global1.data[102] / 2,
							"\nПоддержка народа: -0.",
							this.global1.data[102] / 2
						});
					}
					if (!this.global1.allcountries[this.global1.data[0]].isSEV && !this.global1.allcountries[7].isSEV && !this.global1.allcountries[this.global1.data[0]].Vyshi)
					{
						TextMesh text_117 = this.Text_3;
						text_117.text = text_117.text + "\nБюджет: +0." + (this.global1.data[102] * 2).ToString();
					}
				}
				else
				{
					this.Text_3.text = "Всё хорошо";
				}
			}
			else
			{
				this.num_names = 3;
				if (this.global1.data[71] == 1)
				{
					this.Name_3.text = "Карточная система";
				}
				else
				{
					this.Name_3.text = "Качество жизни";
				}
				if (this.global1.data[71] == 1)
				{
					int num31 = 0;
					for (int num32 = 0; num32 < this.global1.science.Length; num32++)
					{
						if (this.global1.science[num32])
						{
							num31++;
						}
					}
					this.Text_3.text = "<color=red>Начало голода\n</color>";
					TextMesh text_118 = this.Text_3;
					text_118.text += "Еженедельно:\nПоддержка народа: -0.5;\nЕдинство партии: -0.4\nБюджет: -0.2\n";
					TextMesh text_119 = this.Text_3;
					text_119.text = text_119.text + "пока уровень жизни\nменьше " + (36 - num31).ToString();
				}
				else if (this.global1.data[71] == 2)
				{
					int num33 = 0;
					for (int num34 = 0; num34 < this.global1.science.Length; num34++)
					{
						if (this.global1.science[num34])
						{
							num33++;
						}
					}
					this.Text_3.text = "<color=red>Низкий уровень жизни\n</color>";
					TextMesh text_120 = this.Text_3;
					text_120.text += "Еженедельно:\nПоддержка народа: -0.2;\nЕдинство партии: -0.1\n";
					TextMesh text_121 = this.Text_3;
					text_121.text = text_121.text + "пока уровень жизни\nменьше " + (58 - num33).ToString();
				}
				else if (this.global1.data[71] == 3)
				{
					int num35 = 0;
					for (int num36 = 0; num36 < this.global1.science.Length; num36++)
					{
						if (this.global1.science[num36])
						{
							num35++;
						}
					}
					this.Text_3.text = "<color=red>Средний уровень жизни\n</color>";
					TextMesh text_122 = this.Text_3;
					text_122.text += "Еженедельно:\nПоддержка народа: -0.1;\nЕдинство партии: -0.1\nВестальгия: +0.1\n";
					TextMesh text_123 = this.Text_3;
					text_123.text = text_123.text + "пока уровень жизни\nменьше " + (78 - num35).ToString();
				}
				else if (this.global1.data[71] == 4)
				{
					int num37 = 0;
					for (int num38 = 0; num38 < this.global1.science.Length; num38++)
					{
						if (this.global1.science[num38])
						{
							num37++;
						}
					}
					this.Text_3.text = "<color=red>Высокий уровень жизни\n</color>";
					TextMesh text_124 = this.Text_3;
					text_124.text += "Еженедельно:\nПоддержка народа: +0.1;\nЕдинство партии: +0.1\nВестальгия: +0.1\n";
					TextMesh text_125 = this.Text_3;
					text_125.text = text_125.text + "пока уровень жизни\nменьше " + (93 - num37).ToString();
				}
				else if (this.global1.data[71] == 5)
				{
					int num39 = 0;
					for (int num40 = 0; num40 < this.global1.science.Length; num40++)
					{
						if (this.global1.science[num40])
						{
							num39++;
						}
					}
					this.Text_3.text = "<color=red>Уровень жизни,\n приближенный к западному\n</color>";
					TextMesh text_126 = this.Text_3;
					text_126.text += "Еженедельно:\nПоддержка народа: +0.3;\nЕдинство партии: +0.1\nБюджет: -0.1\nВестальгия: -0.1\n";
					TextMesh text_127 = this.Text_3;
					text_127.text = text_127.text + "пока уровень жизни больше " + (93 - num39).ToString();
				}
				else
				{
					int num41 = 0;
					for (int num42 = 0; num42 < this.global1.science.Length; num42++)
					{
						if (this.global1.science[num42])
						{
							num41++;
						}
					}
					this.Text_3.text = "Всё хорошо\nпока уровень жизни\nбольше " + (35 - num41).ToString();
				}
			}
			this.Text_1.text = "Текущий размер:\n" + this.global1.data[63].ToString();
			if (this.global1.data[21] <= 1991)
			{
				if (this.global1.science[5])
				{
					TextMesh text_128 = this.Text_1;
					text_128.text = text_128.text + "\nМинимальный размер:\n" + ((this.global1.data[21] - 1989) * 2).ToString();
				}
				else if (this.global1.science[4])
				{
					TextMesh text_129 = this.Text_1;
					text_129.text = text_129.text + "\nМинимальный размер:\n" + ((this.global1.data[21] - 1988) * 2).ToString();
				}
				else if (this.global1.science[3])
				{
					TextMesh text_130 = this.Text_1;
					text_130.text = text_130.text + "\nМинимальный размер:\n" + ((this.global1.data[21] - 1987) * 2).ToString();
				}
				else
				{
					TextMesh text_131 = this.Text_1;
					text_131.text = text_131.text + "\nМинимальный размер:\n" + ((this.global1.data[21] - 1986) * 2).ToString();
				}
			}
			TextMesh text_132 = this.Text_1;
			text_132.text += "\nПовышается от заключенных\nторговых сделок и\nдействий на политической\nкарте.";
			this.Text_2.text = "Сокращение бюджета\nЕжемесячно: -" + (this.global1.data[63] / 2 / 10).ToString() + "." + Mathf.Abs(this.global1.data[63] / 2 % 10).ToString();
			TextMesh text_133 = this.Text_2;
			text_133.text += "\nСокращение трат\nЕжемесячно: - 4";
		}
		if (this.num_names != 3)
		{
			if (this.num_names == 2)
			{
				this.Name_3.text = null;
				this.Text_3.text = null;
				return;
			}
			if (this.num_names == 1)
			{
				this.Name_3.text = null;
				this.Text_3.text = null;
				this.Name_2.text = null;
				this.Text_2.text = null;
			}
		}
	}

	// Token: 0x060001BA RID: 442 RVA: 0x0000339D File Offset: 0x0000159D
	private void OnMouseEnter()
	{
		base.GetComponent<SpriteRenderer>().sprite = this.on;
	}

	// Token: 0x060001BB RID: 443 RVA: 0x000033B0 File Offset: 0x000015B0
	private void OnMouseExit()
	{
		base.GetComponent<SpriteRenderer>().sprite = this.off;
	}

	// Token: 0x060001BC RID: 444 RVA: 0x00007820 File Offset: 0x00005A20
	private string Text(string text, int col)
	{
		int num = 0;
		string text2 = "";
		for (int i = 0; i < text.Length; i++)
		{
			if (num >= col)
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

	// Token: 0x0400027C RID: 636
	public GlobalScript global1;

	// Token: 0x0400027D RID: 637
	public Sprite on;

	// Token: 0x0400027E RID: 638
	public Sprite off;

	// Token: 0x0400027F RID: 639
	public int num_this;

	// Token: 0x04000280 RID: 640
	public int num_names;

	// Token: 0x04000281 RID: 641
	public TextMesh Name_1;

	// Token: 0x04000282 RID: 642
	public TextMesh Name_2;

	// Token: 0x04000283 RID: 643
	public TextMesh Name_3;

	// Token: 0x04000284 RID: 644
	public TextMesh Text_1;

	// Token: 0x04000285 RID: 645
	public TextMesh Text_2;

	// Token: 0x04000286 RID: 646
	public TextMesh Text_3;

	// Token: 0x04000287 RID: 647
	private Yugoglobal yug1;
}
