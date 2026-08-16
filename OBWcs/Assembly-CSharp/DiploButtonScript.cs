using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000014 RID: 20
public class DiploButtonScript : MonoBehaviour
{
	// Token: 0x06000054 RID: 84 RVA: 0x00002424 File Offset: 0x00000624
	private void Awake()
	{
		this.map1 = GameObject.Find("MapChanges").GetComponent<MapChangesScript>();
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00002450 File Offset: 0x00000650
	public void Hide()
	{
		base.transform.Find("Text").GetComponent<TextMesh>().text = null;
		this.is_active = false;
		base.GetComponent<SpriteRenderer>().sprite = null;
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00013DDC File Offset: 0x00011FDC
	public void Show(string text, int number)
	{
		this.is_active = true;
		this.this_type = number;
		base.GetComponent<SpriteRenderer>().sprite = this.off;
		base.transform.Find("Text").GetComponent<TextMesh>().text = text;
		if (this.global1.data[216] < 50)
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				if (this.this_type == 1)
				{
					this.this_opis = " 邀 请 外 国 投 资 者";
					this.number_uslovie = 3;
					this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Money;
					this.uslovie_text[0] = " 投 资 者 还 未 被 邀 请";
					if (this.global1.allcountries[21].Gosstroy == 2)
					{
						this.uslovie_bool[1] = this.global1.data[16] >= 12;
						this.uslovie_text[1] = " 有 市 场 的 经 济 体 制";
					}
					else
					{
						this.uslovie_bool[1] = this.global1.data[16] >= 12;
						this.uslovie_text[1] = " 不 是 计 划 经 济 或 自 动 化";
					}
					this.uslovie_bool[2] = this.global1.data[6] < 800 - this.global1.allcountries[21].Gosstroy * 200;
					this.uslovie_text[2] = " 外 交 声 誉 低 于 " + (80 - this.global1.allcountries[21].Gosstroy * 20).ToString();
					return;
				}
				if (this.this_type == 2)
				{
					this.this_opis = " 与 法 国 的 友 好 协 议";
					this.number_uslovie = 2;
					this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Torg;
					this.uslovie_text[0] = " 协 议 未 签 署";
					if (this.global1.allcountries[21].Gosstroy != 2)
					{
						this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.data[31] >= 700;
						this.uslovie_text[1] = " 民 族 主 义 并 且 我 们 未 整 合 进 欧 共 体";
						return;
					}
					if (this.global1.allcountries[7].isSEV)
					{
						this.uslovie_bool[1] = this.global1.data[6] < 800;
						this.uslovie_text[1] = " 外 交 声 誉 低 于 80";
						return;
					}
					this.uslovie_bool[1] = this.global1.data[6] < 490;
					this.uslovie_text[1] = " 外 交 声 誉 低 于 49";
					return;
				}
				else
				{
					if (this.this_type == 3)
					{
						this.this_opis = " 加 入 欧 洲 经 济 共 同 体 的 整 合 社 区";
						this.number_uslovie = 4;
						this.uslovie_bool[0] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
						this.uslovie_text[0] = " 我 们 未 在 整 合 进 欧 共 体";
						if (this.global1.data[14] >= 4 && this.global1.data[16] >= 13)
						{
							this.uslovie_bool[1] = this.global1.data[6] < 600;
							this.uslovie_text[1] = " 外 交 声 誉 低 于 60";
						}
						else
						{
							this.uslovie_bool[1] = this.global1.data[6] < 400;
							this.uslovie_text[1] = " 外 交 声 誉 低 于 40";
						}
						this.uslovie_bool[2] = !this.global1.allcountries[this.global1.data[0]].isOVD;
						this.uslovie_text[2] = " 我 们 不 是 华 沙 条 约 成 员";
						this.uslovie_bool[3] = this.global1.data[16] > 11;
						this.uslovie_text[3] = " 不 是 计 划 经 济 或 自 动 化";
						return;
					}
					if (this.this_type == 4)
					{
						this.this_opis = " 加 入 国 际 禁 运";
						this.number_uslovie = 4;
						this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Torg && !this.global1.allcountries[14].isSEV;
						this.uslovie_text[0] = " 未 加 深 贸 易 关 系";
						this.uslovie_bool[1] = this.global1.data[6] < 800;
						this.uslovie_text[1] = " 外 交 声 誉 低 于 80";
						this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
						this.uslovie_text[2] = " 未 禁 运";
						this.uslovie_bool[3] = this.global1.data[32] == 1;
						this.uslovie_text[3] = " 国 际 制 裁 措 施 已 实 施";
						return;
					}
					if (this.this_type == 5)
					{
						this.this_opis = " 深 化 贸 易 关 系 发 展";
						this.number_uslovie = 4;
						this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Torg;
						this.uslovie_text[0] = " 未 深 化 贸 易 关 系";
						this.uslovie_bool[1] = this.global1.data[6] > 600;
						this.uslovie_text[1] = " 外 交 声 誉 高 于 60";
						this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help && !this.global1.allcountries[8].Torg;
						this.uslovie_text[2] = " 未 禁 运 且 未 与 伊 朗 建 立 友 好 关 系";
						this.uslovie_bool[3] = this.global1.data[32] == 1;
						this.uslovie_text[3] = " 国 际 制 裁 措 施 已 实 施";
						return;
					}
					if (this.this_type == 6 && !this.global1.allcountries[this.selected_country].Donat)
					{
						this.this_opis = " 承 认 利 比 亚 在 乍 得 的 宣 称 并 提 供 武 器 援 助";
						this.number_uslovie = 3;
						this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Donat;
						this.uslovie_text[0] = " 未 支 持";
						this.uslovie_bool[1] = this.global1.data[6] > 650;
						this.uslovie_text[1] = " 外 交 声 誉 高 于 65";
						this.uslovie_bool[2] = this.global1.data[9] >= 10;
						this.uslovie_text[2] = " 间 谍 网 络: 1.0";
						return;
					}
					if (this.this_type == 6 && this.global1.allcountries[this.selected_country].Donat)
					{
						this.this_opis = " 为 利 比 亚 经 济 提 供 规 避 制 裁 的 途 径";
						this.number_uslovie = 4;
						this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Money || !this.global1.allcountries[this.selected_country].Torg;
						this.uslovie_text[0] = " 他 们 还 没 有";
						this.uslovie_bool[1] = this.global1.data[6] > 650;
						this.uslovie_text[1] = " 外 交 声 誉 高 于 65";
						this.uslovie_bool[2] = this.global1.data[9] >= 10;
						this.uslovie_text[2] = " 间 谍 网 络: 5.0";
						this.uslovie_bool[3] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
						this.uslovie_text[3] = " 未 在 整 合 进 欧 共 体";
						return;
					}
					if (this.this_type == 7 && !this.global1.allcountries[this.selected_country].Stasi)
					{
						this.this_opis = " 向 改 革 支 持 者 的 账 户 中 注 入 资 金 迫 使 他 们 放 弃 立 场";
						this.number_uslovie = 3;
						this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
						this.uslovie_text[0] = " 未 注 入 资 金";
						this.uslovie_bool[1] = this.global1.data[6] > 600;
						this.uslovie_text[1] = " 外 交 声 誉 高 于 60";
						this.uslovie_bool[2] = this.global1.data[8] >= 10;
						this.uslovie_text[2] = " 预 算: 1.0";
						return;
					}
					if (this.this_type == 7 && this.global1.allcountries[this.selected_country].Stasi)
					{
						if (this.global1.allcountries[this.selected_country].Gosstroy != 0)
						{
							this.this_opis = " 推 进 社 会 主 义 发 展 道 路 并 开 展 贸 易 活 动";
						}
						else
						{
							this.this_opis = " 恢 复 贸 易";
						}
						this.number_uslovie = 3;
						this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Gosstroy != 0 || !this.global1.allcountries[this.selected_country].Torg;
						this.uslovie_text[0] = " 还 没 有";
						this.uslovie_bool[1] = this.global1.data[6] >= 650;
						this.uslovie_text[1] = " 外 交 声 誉 高 于 65";
						this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Donat && this.global1.allcountries[this.selected_country].Stasi;
						this.uslovie_text[2] = " 支 持 了 利 比 亚 在 乍 得 的 宣 称";
						return;
					}
					if (this.this_type == 8)
					{
						this.this_opis = " 建 立 应 急 石 油 供 应 渠 道";
						this.number_uslovie = 3;
						this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Gosstroy == 0;
						this.uslovie_text[0] = " 我 们 干 涉 了 卡 扎 菲 的 内 政";
						this.uslovie_bool[1] = this.global1.data[6] > 600;
						this.uslovie_text[1] = " 外 交 声 誉 高 于 60";
						this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
						this.uslovie_text[2] = " 未 建 立 渠 道";
						return;
					}
					if (this.this_type == 9)
					{
						this.this_opis = " 提 供 粮 食 支 援";
						this.number_uslovie = 2;
						if (!this.global1.allcountries[this.selected_country].Donat)
						{
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Donat;
							this.uslovie_text[0] = " 未 提 供 粮 食";
						}
						else if (!this.global1.is_konst_max)
						{
							this.uslovie_bool[0] = this.global1.is_konst_max;
							this.uslovie_text[0] = " 我 们 有 修 宪 多 数";
						}
						else
						{
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Donat;
							this.uslovie_text[0] = " 等 待 至 明 年";
						}
						this.uslovie_bool[1] = this.global1.data[6] > 590;
						this.uslovie_text[1] = " 外 交 声 誉 高 于 59";
						return;
					}
					if (this.this_type == 10)
					{
						this.this_opis = " 提 供 军 事 支 援";
						this.number_uslovie = 3;
						if (!this.global1.allcountries[this.selected_country].Stasi)
						{
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
							this.uslovie_text[0] = " 未 提 供 军 事 支 援";
						}
						else if (!this.global1.is_konst_max)
						{
							this.uslovie_bool[0] = this.global1.is_konst_max;
							this.uslovie_text[0] = " 我 们 有 修 宪 多 数";
						}
						else
						{
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
							this.uslovie_text[0] = " 等 待 至 明 年";
						}
						this.uslovie_bool[1] = this.global1.data[6] > 790;
						this.uslovie_text[1] = " 外 交 声 誉 高 于 79";
						this.uslovie_bool[2] = this.global1.data[9] >= 10;
						this.uslovie_text[2] = " 有 空 余 的 间 谍 网 络";
						return;
					}
					if (this.this_type == 11)
					{
						if (!this.global1.event_done[58] || this.global1.eventVariantChosen[58] != 0)
						{
							this.this_opis = " 帮 助 红 军 旅";
						}
						else
						{
							this.this_opis = " 号 召 并 支 持 自 由 德 国 工 人 党 ， 德 意 志 替 代 阵 线 和 国 家 社 会 主 义 行 动 阵 线";
						}
						this.number_uslovie = 3;
						if (!this.global1.allcountries[this.selected_country].Stasi)
						{
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
							this.uslovie_text[0] = " 未 提 供 帮 助";
						}
						else if (!this.global1.is_konst_max)
						{
							this.uslovie_bool[0] = this.global1.is_konst_max;
							this.uslovie_text[0] = " 我 们 有 修 宪 多 数";
						}
						else
						{
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
							this.uslovie_text[0] = " 等 待 至 明 年";
						}
						this.uslovie_bool[1] = this.global1.data[6] > 790;
						this.uslovie_text[1] = " 外 交 声 誉 高 于 79";
						this.uslovie_bool[2] = this.global1.data[9] >= 10;
						this.uslovie_text[2] = " 有 空 余 的 间 谍 网 络";
						return;
					}
					if (this.this_type == 12)
					{
						this.this_opis = " 通 过 \" 和 平 将 军\" 发 起 一 场 反 战 运 动";
						this.number_uslovie = 4;
						if (!this.global1.allcountries[this.selected_country].Help)
						{
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Help;
							this.uslovie_text[0] = " 运 动 未 发 起";
						}
						else if (!this.global1.is_konst_max)
						{
							this.uslovie_bool[0] = this.global1.is_konst_max;
							this.uslovie_text[0] = " 我 们 有 修 宪 多 数";
						}
						else
						{
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Help;
							this.uslovie_text[0] = " 等 待 至 明 年";
						}
						this.uslovie_bool[1] = this.global1.data[6] > 390;
						this.uslovie_text[1] = " 外 交 声 誉 高 于 39";
						this.uslovie_bool[2] = this.global1.data[9] >= 10;
						this.uslovie_text[2] = " 有 空 余 的 间 谍 网 络";
						if (this.global1.data[0] != 1)
						{
							this.uslovie_bool[3] = this.global1.data[233] == 1;
							this.uslovie_text[3] = " 帮 助 了 社 会 主 义 阵 营 国 家";
							return;
						}
						this.uslovie_bool[3] = this.global1.data[0] == 1;
						this.uslovie_text[3] = " 是 德 意 志 民 主 共 和 国";
						return;
					}
					else
					{
						if (this.this_type == 13)
						{
							this.this_opis = " 提 供 人 道 主 义 援 助";
							this.number_uslovie = 2;
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Donat;
							this.uslovie_text[0] = " 今 年 未 提 供 人 道 主 义 援 助";
							this.uslovie_bool[1] = this.global1.data[6] > 190;
							this.uslovie_text[1] = " 外 交 声 誉 高 于 19";
							return;
						}
						if (this.this_type == 14)
						{
							this.this_opis = " 帮 助 米 洛 舍 维 奇";
							this.number_uslovie = 4;
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
							this.uslovie_text[0] = " 今 年 未 提 供 军 事 援 助";
							this.uslovie_bool[1] = this.global1.data[6] > 390;
							this.uslovie_text[1] = " 外 交 声 誉 高 于 39";
							this.uslovie_bool[2] = this.global1.data[9] >= 10;
							this.uslovie_text[2] = " 有 空 余 的 间 谍 网 络";
							this.uslovie_bool[3] = this.global1.allcountries[this.selected_country].Gosstroy >= 2;
							this.uslovie_text[3] = " 民 族 主 义 者 赢 得 南 斯 拉 夫 选 举";
							return;
						}
						if (this.this_type == 51)
						{
							if (this.global1.allcountries[this.selected_country].isSEV)
							{
								this.this_opis = " 签 署 军 事 互 助 协 议";
							}
							else
							{
								this.this_opis = " 签 署 经 济 互 助 协 议";
							}
							this.number_uslovie = 4;
							if (this.global1.data[59] != 2 || this.global1.data[0] != 6)
							{
								this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Stasi;
								this.uslovie_text[0] = " 米 洛 舍 维 奇 被 支 持";
							}
							else
							{
								this.uslovie_bool[0] = this.global1.data[59] != 2;
								this.uslovie_text[0] = " 南 斯 拉 夫 拥 有 马 其 顿";
							}
							if (this.global1.allcountries[this.selected_country].isSEV)
							{
								this.uslovie_bool[1] = this.global1.allcountries[this.global1.data[0]].isOVD && !this.global1.allcountries[this.selected_country].isOVD;
							}
							else
							{
								this.uslovie_bool[1] = this.global1.allcountries[this.global1.data[0]].isSEV && !this.global1.allcountries[this.selected_country].isSEV;
							}
							this.uslovie_text[1] = " 我 们 在 同 盟 中";
							this.uslovie_bool[2] = this.global1.data[9] >= 50;
							this.uslovie_text[2] = " 我 们 有5 间 谍 网 络";
							if (this.global1.allcountries[this.selected_country].isSEV)
							{
								this.uslovie_bool[3] = !this.global1.allcountries[7].isOVD || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy <= 0);
							}
							else
							{
								this.uslovie_bool[3] = !this.global1.allcountries[7].isSEV || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy <= 0);
							}
							this.uslovie_text[3] = " 苏 联 不 在 同 盟 中 或 阿 尔 克 斯 尼 斯 上 台";
							return;
						}
						if (this.this_type == 15)
						{
							this.this_opis = " 帮 助 分 离 主 义 者";
							this.number_uslovie = 4;
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Help && !this.global1.allcountries[this.selected_country].Stasi;
							this.uslovie_text[0] = " 未 提 供 军 事 援 助";
							this.uslovie_bool[1] = this.global1.data[6] < 800;
							this.uslovie_text[1] = " 外 交 声 誉 低 于 80";
							this.uslovie_bool[2] = this.global1.data[9] >= 10;
							this.uslovie_text[2] = " 有 空 余 的 间 谍 网 络";
							this.uslovie_bool[3] = this.global1.allcountries[this.selected_country].Gosstroy >= 2;
							this.uslovie_text[3] = " 民 族 主 义 者 赢 得 南 斯 拉 夫 选 举";
							return;
						}
						if (this.this_type == 44)
						{
							this.this_opis = " 消 灭 邓 小 平 ， 让 保 守 派 重 掌 权 力";
							this.number_uslovie = 4;
							if (this.global1.data[6] >= 800)
							{
								this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Torg;
								this.uslovie_text[0] = " 我 们 已 建 立 贸 易";
							}
							else
							{
								this.uslovie_bool[0] = this.global1.data[6] >= 800;
								this.uslovie_text[0] = " 外 交 声 誉 高 于 80";
							}
							this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Gosstroy == 9;
							this.uslovie_text[1] = " 中 国 的 反 对 派 已 被 镇 压";
							this.uslovie_bool[2] = this.global1.data[9] >= 100 && this.global1.data[8] >= 100;
							this.uslovie_text[2] = " 有10 间 谍 网 络 及 资 金";
							if (this.global1.data[21] >= 1991 && (this.global1.data[0] == 12 || this.global1.data[0] == 10 || this.global1.data[0] == 18))
							{
								this.uslovie_bool[3] = this.global1.science[2];
								this.uslovie_text[3] = " “ 外 国 间 谍 网 络 ” 已 研 发";
								return;
							}
							if (this.global1.data[21] >= 1991)
							{
								this.uslovie_bool[3] = this.global1.science[2];
								this.uslovie_text[3] = " 我 们 有 “ 信 息 通 讯 审 查 系 统 ”";
								return;
							}
							if (this.global1.data[21] >= 1991)
							{
								this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Stasi;
								this.uslovie_text[3] = " 未 消 灭 邓 小 平";
								return;
							}
							if (!this.global1.is_konst_max)
							{
								this.uslovie_bool[3] = this.global1.is_konst_max;
								this.uslovie_text[3] = " 我 们 有 修 宪 多 数";
								return;
							}
							this.uslovie_bool[3] = this.global1.data[21] >= 1991;
							this.uslovie_text[3] = " 不 早 于1991 年";
							return;
						}
						else
						{
							if (this.this_type == 16)
							{
								this.this_opis = " 建 立 外 交 关 系";
								this.number_uslovie = 3;
								this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Donat && !this.global1.allcountries[this.selected_country].Torg;
								this.uslovie_text[0] = " 我 们 还 未 建 立 外 交 关 系";
								if (this.global1.allcountries[this.selected_country].Gosstroy == 1)
								{
									this.uslovie_bool[1] = this.global1.data[6] < 880;
									this.uslovie_text[1] = " 外 交 声 誉 低 于 88";
								}
								else if (this.global1.allcountries[this.selected_country].Gosstroy == 2)
								{
									this.uslovie_bool[1] = this.global1.data[6] < 700;
									this.uslovie_text[1] = " 外 交 声 誉 低 于 70";
								}
								else if (this.global1.allcountries[this.selected_country].Gosstroy == 0 || this.global1.allcountries[this.selected_country].Gosstroy == 9)
								{
									this.uslovie_bool[1] = this.global1.data[6] > 600;
									this.uslovie_text[1] = " 外 交 声 誉 高 于 60";
								}
								this.uslovie_bool[2] = !this.global1.allcountries[38].Help;
								this.uslovie_text[2] = " 未 谴 责 中 国";
								return;
							}
							if (this.this_type == 17)
							{
								this.this_opis = " 进 入 活 跃 贸 易 阶 段";
								if (this.selected_country == 38)
								{
									this.number_uslovie = 4;
								}
								else
								{
									this.number_uslovie = 3;
								}
								this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Torg;
								this.uslovie_text[0] = " 我 们 未 建 立 贸 易";
								if (this.global1.allcountries[this.selected_country].Stasi)
								{
									this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].Stasi;
									this.uslovie_text[1] = " 我 们 未 断 绝 关 系";
								}
								else if (this.selected_country == 38)
								{
									this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Help;
									this.uslovie_text[1] = " 已 谴 责 中 国";
								}
								else
								{
									this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Donat || this.global1.allcountries[this.selected_country].Help;
									this.uslovie_text[1] = " 建 立 外 交 关 系";
								}
								if (this.selected_country == 38)
								{
									this.uslovie_bool[2] = this.global1.data[10] <= 300;
									this.uslovie_text[2] = " 北 约 威 胁 低 于 30.0";
								}
								else if (this.global1.allcountries[this.selected_country].Gosstroy == 1)
								{
									this.uslovie_bool[2] = this.global1.data[6] < 880;
									this.uslovie_text[2] = " 外 交 声 誉 低 于 88";
								}
								else if (this.global1.allcountries[this.selected_country].Gosstroy == 2)
								{
									this.uslovie_bool[2] = this.global1.data[6] < 500;
									this.uslovie_text[2] = " 外 交 声 誉 低 于 50";
								}
								else if (this.global1.allcountries[this.selected_country].Gosstroy == 0)
								{
									this.uslovie_bool[2] = this.global1.data[6] > 600;
									this.uslovie_text[2] = " 外 交 声 誉 高 于 60";
								}
								else if (this.global1.allcountries[this.selected_country].Gosstroy == 9)
								{
									this.uslovie_bool[2] = this.global1.data[8] >= 60;
									this.uslovie_text[2] = " 预 算: 6";
								}
								if (this.selected_country == 38)
								{
									this.uslovie_bool[3] = !this.global1.allcountries[16].isSEV;
									this.uslovie_text[3] = " 中 国 不 在 关 税 联 盟 中";
									return;
								}
							}
							else
							{
								if (this.this_type == 68)
								{
									this.this_opis = " 派 遣 代 表 团 至 科 威 特 建 立 友 好 关 系";
									this.number_uslovie = 4;
									this.uslovie_bool[0] = this.global1.allcountries[14].Help;
									this.uslovie_text[0] = " 我 们 对 伊 拉 克 实 施 了 禁 运";
									this.uslovie_bool[1] = this.global1.event_done[81] || !this.global1.event_done[53] || this.global1.allcountries[36].Vyshi;
									this.uslovie_text[1] = " 该 国 家 未 被 吞 并";
									this.uslovie_bool[2] = this.global1.allcountries[14].Gosstroy != 9;
									this.uslovie_text[2] = " 你 已 帮 助 推 翻 了 萨 达 姆 · 侯 赛 因";
									this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Torg;
									this.uslovie_text[3] = " 未 派 遣 代 表 团";
									return;
								}
								if (this.this_type == 18)
								{
									this.this_opis = " 邀 请 加 入 关 税 联 盟";
									this.number_uslovie = 4;
									if (!this.global1.allcountries[this.global1.data[0]].Vyshi)
									{
										this.uslovie_bool[1] = !this.global1.allcountries[16].isSEV;
										this.uslovie_text[1] = " 中 国 不 在 关 税 联 盟 中";
									}
									else
									{
										this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
										this.uslovie_text[1] = " 我 们 未 在 整 合 进 欧 共 体";
									}
									this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Torg && this.global1.allcountries[this.global1.data[0]].isSEV;
									this.uslovie_text[2] = " 贸 易 活 跃 并 且 我 们 有 联 盟";
									if (this.global1.allcountries[this.selected_country].Gosstroy == 1)
									{
										this.uslovie_bool[3] = this.global1.data[6] > 390;
										this.uslovie_text[3] = " 外 交 声 誉 高 于 39";
										this.uslovie_bool[0] = !this.global1.allcountries[7].isSEV;
										this.uslovie_text[0] = " 苏 联 不 在 经 互 会";
									}
									else if (this.global1.allcountries[this.selected_country].Gosstroy == 2)
									{
										this.uslovie_bool[3] = this.global1.data[6] < 400;
										this.uslovie_text[3] = " 外 交 声 誉 低 于 40";
										this.uslovie_bool[0] = !this.global1.allcountries[7].isSEV;
										this.uslovie_text[0] = " 苏 联 不 在 经 互 会";
									}
									else if (this.global1.allcountries[this.selected_country].Gosstroy == 0 && this.global1.data[7] > 700)
									{
										this.uslovie_bool[3] = this.global1.data[7] > 700;
										this.uslovie_text[3] = " 社 会 主 义 阵 营 稳 定 高 于 70";
										this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Gosstroy == 0;
										this.uslovie_text[0] = " 中 国 是 保 守 派";
									}
									else if (this.global1.allcountries[this.selected_country].Gosstroy == 0)
									{
										this.uslovie_bool[3] = this.global1.data[8] >= 100;
										this.uslovie_text[3] = " 拥 有 至 少10 资 金";
										this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Gosstroy == 0;
										this.uslovie_text[0] = " 中 国 是 保 守 派";
									}
									else
									{
										this.uslovie_bool[3] = this.global1.data[6] < 800;
										this.uslovie_text[3] = " 外 交 声 誉 低 于 80";
										this.uslovie_bool[0] = !this.global1.allcountries[7].isSEV;
										this.uslovie_text[0] = " 苏 联 不 在 经 互 会";
									}
									if (this.global1.allcountries[38].Torg)
									{
										this.uslovie_bool[0] = !this.global1.allcountries[38].Torg;
										this.uslovie_text[0] = " 未 与 台 湾 建 交";
										return;
									}
								}
								else
								{
									if (this.this_type == 19)
									{
										this.this_opis = " 与 印 度 签 署 武 器 供 应 协 议";
										this.number_uslovie = 3;
										this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Torg;
										this.uslovie_text[0] = " 协 议 未 签 署";
										if (this.global1.allcountries[this.selected_country].Gosstroy != 2)
										{
											this.uslovie_bool[1] = this.global1.data[6] > 590;
											this.uslovie_text[1] = " 外 交 声 誉 高 于 59";
										}
										else
										{
											this.uslovie_bool[1] = this.global1.data[6] < 490;
											this.uslovie_text[1] = " 外 交 声 誉 低 于 49";
										}
										this.uslovie_bool[2] = !this.global1.allcountries[31].Torg;
										this.uslovie_text[2] = " 我 们 未 与 巴 基 斯 坦 开 展 贸 易";
										return;
									}
									if (this.this_type == 20)
									{
										this.this_opis = " 为 我 们 的 党 组 织 提 供 政 治 庇 护 保 障";
										this.number_uslovie = 3;
										this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Torg;
										this.uslovie_text[0] = " 协 议 已 签 署";
										this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].Help;
										this.uslovie_text[1] = " 未 提 供 保 障";
										this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Gosstroy != 2;
										this.uslovie_text[2] = " 国 大 党 掌 权";
										return;
									}
									if (this.this_type == 45)
									{
										this.this_opis = " 挑 起 新 的 印 巴 战 争";
										this.number_uslovie = 4;
										this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Gosstroy != 2;
										this.uslovie_text[0] = " 国 大 党 掌 权";
										this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Torg;
										this.uslovie_text[1] = " 已 出 售 武 器";
										this.uslovie_bool[2] = this.global1.data[9] >= 80;
										this.uslovie_text[2] = " 有8 空 余 的 间 谍 网 络";
										this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Stasi && this.global1.data[21] == 1989;
										this.uslovie_text[3] = " 在1989 年 未 挑 起 战 争";
										return;
									}
									if (this.this_type == 21)
									{
										this.this_opis = " 恢 复 外 交 关 系";
										this.number_uslovie = 3;
										this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Donat && !this.global1.allcountries[this.selected_country].Torg;
										this.uslovie_text[0] = " 未 恢 复 外 交 关 系";
										this.uslovie_bool[1] = this.global1.data[6] > 190 && this.global1.data[6] < 800;
										this.uslovie_text[1] = " 外 交 声 誉 在 19 和 80 之 间";
										this.uslovie_bool[2] = this.global1.event_done[14];
										this.uslovie_text[2] = " 伊 朗 开 始 自 由 化";
										return;
									}
									if (this.this_type == 22)
									{
										this.this_opis = " 进 入 活 跃 贸 易 阶 段";
										if (this.selected_country == 46)
										{
											this.number_uslovie = 4;
										}
										else
										{
											this.number_uslovie = 3;
										}
										if (this.selected_country == 30 || this.selected_country == 8)
										{
											this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Donat;
											this.uslovie_text[0] = " 已 恢 复 外 交 关 系";
										}
										else
										{
											this.uslovie_bool[0] = this.global1.data[8] >= 30;
											this.uslovie_text[0] = " 至 少3 资 金";
										}
										if (this.selected_country == 46 && this.global1.allcountries[46].Gosstroy == 0)
										{
											this.uslovie_bool[1] = this.global1.data[6] > 390;
											this.uslovie_text[1] = " 外 交 声 誉 高 于 39";
										}
										else
										{
											this.uslovie_bool[1] = this.global1.data[6] > 250 && this.global1.data[6] < 800;
											this.uslovie_text[1] = " 外 交 声 誉 在 25 和 80 之 间";
										}
										this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Torg;
										this.uslovie_text[2] = " 未 开 始 贸 易";
										if (this.selected_country == 46 && this.global1.allcountries[46].Gosstroy == 0)
										{
											this.uslovie_bool[3] = this.global1.allcountries[46].Gosstroy == 0;
											this.uslovie_text[3] = " 人 民 解 放 阵 线 掌 权";
											return;
										}
										if (this.selected_country == 46)
										{
											this.uslovie_bool[3] = !this.global1.allcountries[46].Stasi;
											this.uslovie_text[3] = " 未 支 持 人 民 解 放 阵 线";
											return;
										}
									}
									else
									{
										if (this.this_type == 23)
										{
											this.this_opis = " 邀 请 至 经 济 联 盟";
											this.number_uslovie = 4;
											if (this.selected_country == 8)
											{
												this.uslovie_bool[0] = !this.global1.allcountries[7].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV;
												this.uslovie_text[0] = " 苏 联 不 在 经 互 会 内 且 我 们 在 联 盟 内";
											}
											else if (this.selected_country == 14 && this.global1.allcountries[14].Gosstroy == 1)
											{
												this.uslovie_bool[0] = this.global1.allcountries[14].Gosstroy == 1 && this.global1.allcountries[35].isSEV && !this.global1.allcountries[7].isSEV;
												this.uslovie_text[0] = " 改 革 派 伊 拉 克 且 叙 利 亚 在 改 革 后 的 经 互 会 内 ， 苏 联 不 在 经 互 会 内";
											}
											else
											{
												this.uslovie_bool[0] = this.global1.allcountries[14].Gosstroy == 0 && this.global1.allcountries[8].isSEV && this.global1.allcountries[35].isSEV;
												this.uslovie_text[0] = " 伊 拉 克 和 叙 利 亚 是 社 会 主 义 且 伊 朗 在 经 互 会 内";
											}
											this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isSEV;
											this.uslovie_text[1] = " 该 国 不 在 经 互 会 内";
											this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Torg;
											this.uslovie_text[2] = " 贸 易 活 跃";
											this.uslovie_bool[3] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
											this.uslovie_text[3] = " 我 们 未 在 整 合 进 欧 共 体";
											return;
										}
										if (this.this_type == 24)
										{
											if (!this.global1.allcountries[7].Vyshi)
											{
												this.this_opis = " 支 持 苏 联 的 保 守 派";
											}
											else
											{
												this.this_opis = " 支 持 独 联 体 的 共 产 主 义 者";
											}
											this.this_opis = this.this_opis + "\n提供的援助量: " + this.global1.data[52].ToString();
											this.number_uslovie = 4;
											this.uslovie_bool[0] = this.global1.data[9] > 29;
											this.uslovie_text[0] = " 至 少3 空 余 的 间 谍 网 络";
											this.uslovie_bool[1] = this.global1.data[14] <= 3;
											this.uslovie_text[1] = " 我 们 是 社 会 主 义";
											this.uslovie_bool[2] = this.global1.data[8] > 10;
											this.uslovie_text[2] = " 资 金 大 于1";
											if (!this.global1.allcountries[this.selected_country].Stasi)
											{
												this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Stasi;
												this.uslovie_text[3] = " 我 们 未 支 持 他 们";
												return;
											}
											if (!this.global1.is_konst_max)
											{
												this.uslovie_bool[3] = this.global1.is_konst_max;
												this.uslovie_text[3] = " 我 们 有 修 宪 多 数";
												return;
											}
											this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Stasi;
											this.uslovie_text[3] = " 等 待 至 明 年";
											return;
										}
										else if (this.this_type == 25)
										{
											this.this_opis = " 向 苏 联 提 供 一 笔 贷 款";
											this.this_opis = this.this_opis + "\n提供的贷款数: " + this.global1.data[51].ToString();
											this.number_uslovie = 3;
											this.uslovie_bool[0] = this.global1.data[8] > 30;
											this.uslovie_text[0] = " 资 金 大 于 3";
											this.uslovie_bool[1] = this.global1.allcountries[7].isSEV;
											this.uslovie_text[1] = " 苏 联 在 经 互 会 内";
											if (this.global1.data[8] < 30)
											{
												this.uslovie_bool[2] = this.global1.data[8] >= 30;
												this.uslovie_text[2] = " 需 要 3 资 金";
												return;
											}
											if (!this.global1.allcountries[this.selected_country].Donat)
											{
												this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
												this.uslovie_text[2] = " 未 提 供 贷 款";
												return;
											}
											this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
											this.uslovie_text[2] = " 等 待";
											return;
										}
										else
										{
											if (this.this_type == 26)
											{
												this.this_opis = " 出 售 武 器 许 可 证";
												this.number_uslovie = 2;
												this.uslovie_bool[0] = this.global1.data[6] > 390;
												this.uslovie_text[0] = " 外 交 声 誉 高 于 39";
												this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].Donat;
												this.uslovie_text[1] = " 未 出 售 许 可 证";
												return;
											}
											if (this.this_type == 43)
											{
												this.this_opis = " 秘 密 出 售 核 武 蓝 图 和 科 技";
												this.number_uslovie = 4;
												this.uslovie_bool[0] = this.global1.data[6] > 790 || this.global1.data[8] <= 0;
												this.uslovie_text[0] = " 外 交 声 誉 高 于 79 或 预 算 为 负";
												this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].Stasi;
												this.uslovie_text[1] = " 未 出 售 蓝 图 和 科 技";
												this.uslovie_bool[2] = this.global1.data[36] == 1;
												this.uslovie_text[2] = " 我 们 有 蓝 图 和 科 技";
												this.uslovie_bool[3] = this.global1.data[9] > 20;
												this.uslovie_text[3] = " 空 余 的 间 谍 网 络 大 于 2";
												return;
											}
											if (this.this_type == 27)
											{
												this.this_opis = " 派 遣 分 析 人 员 研 究 主 体 思 想";
												this.number_uslovie = 2;
												this.uslovie_bool[0] = this.global1.data[6] > 790;
												this.uslovie_text[0] = " 外 交 声 誉 高 于 79";
												this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].Help;
												this.uslovie_text[1] = " 我 们 未 派 遣 分 析 人 员";
												return;
											}
											if (this.this_type == 28)
											{
												this.this_opis = " 邀 请 至 经 济 联 盟";
												if (this.selected_country == 24 || this.selected_country == 13 || (this.global1.allcountries[47].Gosstroy == 2 && this.selected_country == 47))
												{
													this.number_uslovie = 4;
												}
												else
												{
													this.number_uslovie = 3;
												}
												if (!this.global1.allcountries[this.global1.data[0]].Vyshi)
												{
													this.uslovie_bool[0] = !this.global1.allcountries[7].isSEV;
													this.uslovie_text[0] = " 苏 联 不 在 经 互 会 内";
												}
												else
												{
													this.uslovie_bool[0] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
													this.uslovie_text[0] = " 我 们 未 在 整 合 进 欧 共 体";
												}
												this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV;
												this.uslovie_text[1] = " 该 国 不 在 经 互 会 内 且 我 们 在 联 盟 中";
												if (this.selected_country == 13 && this.global1.allcountries[13].Gosstroy == 1)
												{
													this.uslovie_bool[2] = this.global1.allcountries[30].isSEV && this.global1.allcountries[40].isSEV;
													this.uslovie_text[2] = " 阿 尔 及 利 亚 和 埃 及 在 经 互 会 内";
												}
												else if (this.selected_country == 13)
												{
													this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Gosstroy == 0;
													this.uslovie_text[2] = " 改 革 措 施 被 叫 停";
												}
												else if ((this.selected_country == 11 && this.global1.allcountries[11].Gosstroy == 2) || (this.global1.allcountries[47].Gosstroy == 2 && this.selected_country == 47))
												{
													this.uslovie_bool[2] = this.global1.data[6] < 350;
													this.uslovie_text[2] = " 外 交 声 誉 低 于 35";
												}
												else if (this.selected_country != 35 && this.selected_country != 47)
												{
													this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Gosstroy != 2;
													this.uslovie_text[2] = " 他 们 不 是 自 由 派";
												}
												else if (this.selected_country != 47)
												{
													this.uslovie_bool[2] = this.global1.data[9] >= 10;
													this.uslovie_text[2] = " 有 空 余 的 间 谍 网 络";
												}
												else
												{
													this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Gosstroy <= 1;
													this.uslovie_text[2] = " 桑 地 诺 民 族 解 放 阵 线 掌 权";
												}
												if (this.selected_country == 13 && this.global1.allcountries[13].Gosstroy == 1)
												{
													this.uslovie_bool[3] = this.global1.allcountries[this.selected_country].Money && this.global1.data[8] >= 30;
													this.uslovie_text[3] = " 改 革 尚 未 被 逆 转 ， 有 空 余 资 金";
													return;
												}
												if (this.selected_country == 24)
												{
													this.uslovie_bool[3] = this.global1.data[55] >= 2;
													this.uslovie_text[3] = " 我 们 已 多 次 投 资 石 油 生 产";
													return;
												}
												if (this.selected_country == 13)
												{
													this.uslovie_bool[3] = this.global1.data[6] > 700 && this.global1.data[8] >= 30;
													this.uslovie_text[3] = " 外 交 声 誉 高 于 70.0 ， 有 空 余 资 金";
													return;
												}
												if (this.global1.allcountries[47].Gosstroy == 2 && this.selected_country == 47)
												{
													this.uslovie_bool[3] = this.global1.data[8] >= 20 && this.global1.data[14] >= 3;
													this.uslovie_text[3] = " 卡 达 尔 主 义 或 更 右 ， 有 空 余 资 金";
													return;
												}
											}
											else
											{
												if (this.this_type == 56)
												{
													this.this_opis = " 邀 请 至 经 济 联 盟";
													this.number_uslovie = 4;
													this.uslovie_bool[0] = !this.global1.allcountries[7].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV;
													this.uslovie_text[0] = " 苏 联 不 在 经 互 会 内 且 我 们 在 联 盟 中";
													this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isSEV;
													this.uslovie_text[1] = " 该 国 不 在 经 互 会 内";
													if (this.global1.data[0] == 5 && this.global1.data[11] == 0)
													{
														this.uslovie_bool[2] = this.global1.data[11] == 0;
														this.uslovie_text[2] = " 齐 奥 塞 斯 库 掌 权";
													}
													else
													{
														this.uslovie_bool[2] = this.global1.data[6] >= 990;
														this.uslovie_text[2] = " 外 交 声 誉 不 低 于 99";
													}
													this.uslovie_bool[3] = this.global1.allcountries[this.selected_country].Help;
													this.uslovie_text[3] = " 我 们 已 派 遣 分 析 人 员";
													return;
												}
												if (this.this_type == 29)
												{
													this.this_opis = " 恢 复 外 交 关 系";
													this.number_uslovie = 3;
													this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Torg;
													this.uslovie_text[0] = " 未 恢 复 外 交 关 系";
													if (this.global1.data[6] <= 900)
													{
														this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Gosstroy != 0;
														this.uslovie_text[1] = " 霍 查 主 义 不 为 主 导 意 识 形 态";
														this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Stasi;
														this.uslovie_text[2] = " 已 支 持 拉 米 兹 · 阿 利 雅 或 有 新 的 民 主 政 权";
														return;
													}
													this.uslovie_bool[1] = this.global1.data[6] > 900;
													this.uslovie_text[1] = " 外 交 声 誉 高 于 90";
													this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Stasi;
													this.uslovie_text[2] = " 未 支 持 拉 米 兹 · 阿 利 雅";
													return;
												}
												else
												{
													if (this.this_type == 30)
													{
														if (this.selected_country == 46 || this.selected_country == 33 || this.selected_country == 22)
														{
															this.this_opis = " 邀 请 至 经 济 联 盟 \n 注 意 ！ 该 国 将 被 补 贴";
														}
														else if (this.selected_country == 43)
														{
															this.this_opis = " 邀 请 至 经 济 联 盟 注 意 ！ 与 邻 国 贸 易 的 利 益 将 扩 大";
														}
														else
														{
															this.this_opis = " 邀 请 至 经 济 联 盟";
														}
														this.number_uslovie = 4;
														this.uslovie_bool[0] = !this.global1.allcountries[7].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV;
														this.uslovie_text[0] = " 苏 联 不 在 经 互 会 内 且 我 们 在 联 盟 中";
														this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isSEV;
														this.uslovie_text[1] = " 该 国 不 在 经 互 会 内";
														this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Torg;
														this.uslovie_text[2] = " 已 恢 复 贸 易 关 系";
														this.uslovie_bool[3] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
														this.uslovie_text[3] = " 我 们 未 在 整 合 进 欧 共 体";
														return;
													}
													if (this.this_type == 31)
													{
														if (this.global1.allcountries[this.selected_country].Gosstroy != 2)
														{
															this.this_opis = " 支 持 拉 米 兹 · 阿 利 雅 政 权";
														}
														else
														{
															this.this_opis = " 支 持 新 的 民 主 政 权";
														}
														this.number_uslovie = 4;
														this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
														this.uslovie_text[0] = " 未 支 持 拉 米 兹 · 阿 利 雅";
														if (this.global1.allcountries[this.selected_country].Gosstroy == 2)
														{
															this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Gosstroy == 2;
															this.uslovie_text[1] = " 民 主 派 掌 权";
														}
														else
														{
															this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Gosstroy <= 1;
															this.uslovie_text[1] = " 拉 米 兹 · 阿 利 雅 掌 权";
														}
														if (this.global1.allcountries[this.selected_country].Gosstroy == 2)
														{
															this.uslovie_bool[2] = this.global1.data[6] < 450;
															this.uslovie_text[2] = " 外 交 声 誉 低 于 45";
														}
														else
														{
															this.uslovie_bool[2] = this.global1.data[6] > 590;
															this.uslovie_text[2] = " 外 交 声 誉 高 于 59";
														}
														this.uslovie_bool[3] = this.global1.data[9] >= 10;
														this.uslovie_text[3] = " 有 空 余 的 间 谍 网 络";
														return;
													}
													if (this.this_type == 32)
													{
														this.this_opis = " 支 持 执 政 党";
														this.number_uslovie = 4;
														this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
														this.uslovie_text[0] = " 未 支 持 执 政 党";
														this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Torg;
														this.uslovie_text[1] = " 至 少 一 个 国 家 在 秘 密 协 议 中 或 建 立 贸 易";
														this.uslovie_bool[2] = this.global1.data[6] > 690;
														this.uslovie_text[2] = " 外 交 声 誉 高 于 69";
														this.uslovie_bool[3] = this.global1.data[9] >= 10;
														this.uslovie_text[3] = " 有 空 余 的 间 谍 网 络";
														return;
													}
													if (this.this_type == 33)
													{
														this.this_opis = " 邀 请 加 入 欧 洲 经 济 共 同 体";
														this.number_uslovie = 4;
														this.uslovie_bool[0] = this.global1.allcountries[this.global1.data[0]].Vyshi;
														this.uslovie_text[0] = " 我 们 已 整 合 进 欧 共 体";
														this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].Vyshi;
														this.uslovie_text[1] = " 他 们 未 整 合 进 欧 共 体";
														this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].isOVD;
														this.uslovie_text[2] = " 该 国 不 在 华 沙 条 约";
														this.uslovie_bool[3] = this.global1.allcountries[this.selected_country].Gosstroy == 2;
														this.uslovie_text[3] = " 该 国 已 自 由 化";
														return;
													}
													if (this.this_type == 34)
													{
														this.this_opis = " 提 供 财 政 支 援";
														if (this.selected_country == 35)
														{
															this.number_uslovie = 4;
														}
														else
														{
															this.number_uslovie = 3;
														}
														this.uslovie_bool[0] = this.global1.data[6] > 390;
														this.uslovie_text[0] = " 外 交 声 誉 高 于 39";
														if (this.selected_country == 30)
														{
															this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Torg;
															this.uslovie_text[1] = " 贸 易 关 系 已 恢 复";
														}
														else
														{
															this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Gosstroy != 2;
															this.uslovie_text[1] = " 该 国 未 自 由 化";
														}
														this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
														this.uslovie_text[2] = " 未 提 供 财 政 支 援";
														if (this.global1.data[8] < 30)
														{
															this.uslovie_bool[2] = this.global1.data[8] >= 30;
															this.uslovie_text[2] = " 需 要 3 预 算";
														}
														else if (!this.global1.allcountries[this.selected_country].Donat || this.selected_country == 35)
														{
															this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
															this.uslovie_text[2] = " 未 提 供 财 政 支 援";
														}
														else if (!this.global1.is_konst_max)
														{
															this.uslovie_bool[2] = this.global1.is_konst_max;
															this.uslovie_text[2] = " 我 们 有 修 宪 多 数";
														}
														else
														{
															this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
															this.uslovie_text[2] = " 等 待 至 明 年";
														}
														if (this.selected_country == 35)
														{
															this.uslovie_bool[3] = (this.global1.data[20] < 5 && this.global1.data[21] == 1991) || this.global1.data[21] <= 1990;
															this.uslovie_text[3] = "在 1991 年 五 月 之 前";
															return;
														}
													}
													else
													{
														if (this.this_type == 35)
														{
															this.this_opis = " 提 供 军 事 和 特 勤 支 援";
															this.number_uslovie = 4;
															this.uslovie_bool[0] = this.global1.data[6] > (3 - this.global1.allcountries[this.selected_country].Gosstroy) * 300 - 200;
															this.uslovie_text[0] = " 外 交 声 誉 高 于 " + (((3 - this.global1.allcountries[this.selected_country].Gosstroy) * 300 - 200) / 10).ToString();
															this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Gosstroy != 2;
															this.uslovie_text[1] = " 该 国 未 自 由 化";
															this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Stasi;
															this.uslovie_text[2] = " 未 提 供 军 事 和 特 勤 支 援";
															this.uslovie_bool[3] = this.global1.data[9] >= 10;
															this.uslovie_text[3] = " 有2 空 余 的 间 谍 网 络";
															return;
														}
														if (this.this_type == 36)
														{
															this.this_opis = " 邀 请 至 经 济 联 盟";
															this.number_uslovie = 4;
															if (this.global1.allcountries[this.selected_country].Gosstroy == 9)
															{
																this.uslovie_bool[0] = this.global1.data[6] > 790;
																this.uslovie_text[0] = " 外 交 声 誉 高 于 79";
															}
															else if (this.global1.allcountries[this.selected_country].Gosstroy == 0)
															{
																this.uslovie_bool[0] = this.global1.data[6] > 690;
																this.uslovie_text[0] = " 外 交 声 誉 高 于 69";
															}
															else if (this.global1.allcountries[this.selected_country].Gosstroy == 1)
															{
																this.uslovie_bool[0] = this.global1.data[6] > 390 && this.global1.data[6] < 800;
																this.uslovie_text[0] = " 外 交 声 誉 在 39 和 80 之 间";
															}
															else
															{
																this.uslovie_bool[0] = this.global1.data[6] <= 390;
																this.uslovie_text[0] = " 外 交 声 誉 低 于 40";
															}
															this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isSEV;
															this.uslovie_text[1] = " 该 国 不 在 经 互 会 内";
															this.uslovie_bool[2] = this.global1.allcountries[this.global1.data[0]].isSEV;
															this.uslovie_text[2] = " 我 们 在 经 济 联 盟 中";
															this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Vyshi && !this.global1.allcountries[this.global1.data[0]].Vyshi;
															this.uslovie_text[3] = " 我 们 和 他 们 皆 未 整 合 进 欧 共 体";
															return;
														}
														if (this.this_type == 37)
														{
															this.this_opis = " 邀 请 至 军 事 条 约";
															this.number_uslovie = 4;
															if (this.global1.allcountries[this.selected_country].Gosstroy == 9)
															{
																this.uslovie_bool[0] = this.global1.data[6] > 890;
																this.uslovie_text[0] = " 外 交 声 誉 高 于 89";
															}
															else if (this.global1.allcountries[this.selected_country].Gosstroy == 0)
															{
																this.uslovie_bool[0] = this.global1.data[6] > 790;
																this.uslovie_text[0] = " 外 交 声 誉 高 于 79";
															}
															else if (this.global1.allcountries[this.selected_country].Gosstroy == 1)
															{
																this.uslovie_bool[0] = this.global1.data[6] > 390 && this.global1.data[6] < 600;
																this.uslovie_text[0] = " 外 交 声 誉 在 39 和 60 之 间";
															}
															else
															{
																this.uslovie_bool[0] = this.global1.data[6] < 200;
																this.uslovie_text[0] = " 外 交 声 誉 低 于 20";
															}
															this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isOVD && this.global1.allcountries[this.selected_country].isSEV;
															this.uslovie_text[1] = " 他 们 不 在 华 沙 条 约 内 ， 但 在 经 互 会 内";
															this.uslovie_bool[2] = this.global1.allcountries[this.global1.data[0]].isOVD;
															this.uslovie_text[2] = " 我 们 在 军 事 条 约 内";
															this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Vyshi && !this.global1.allcountries[this.global1.data[0]].Vyshi;
															this.uslovie_text[3] = " 我 们 和 他 们 皆 未 整 合 进 欧 共 体";
															return;
														}
														if (this.this_type == 38)
														{
															this.this_opis = " 深 化 贸 易 关 系";
															if (this.selected_country == 27)
															{
																this.number_uslovie = 4;
															}
															else
															{
																this.number_uslovie = 3;
															}
															this.uslovie_bool[0] = this.global1.data[6] < 300 + (28 - this.selected_country) * 100;
															this.uslovie_text[0] = " 外 交 声 誉 低 于 " + (30 + (28 - this.selected_country) * 10).ToString();
															this.uslovie_bool[1] = this.global1.data[27] > 0;
															this.uslovie_text[1] = " 至 少 有 一 个 完 全 开 放 的 边 境";
															this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Torg;
															this.uslovie_text[2] = " 未 深 化 贸 易 关 系";
															if (this.selected_country == 27)
															{
																this.uslovie_bool[3] = !this.global1.event_done[441];
																this.uslovie_text[3] = " 未 宣 布 任 何 针 对 个 人 的 制 裁 措 施";
																return;
															}
														}
														else
														{
															if (this.this_type == 39)
															{
																this.this_opis = " 邀 请 加 入 欧 洲 经 济 共 同 体";
																this.number_uslovie = 4;
																this.uslovie_bool[0] = this.global1.allcountries[this.global1.data[0]].Vyshi;
																this.uslovie_text[0] = " 我 们 已 整 合 进 欧 共 体";
																this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].Vyshi;
																this.uslovie_text[1] = " 他 们 未 整 合 进 欧 共 体";
																this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Torg;
																this.uslovie_text[2] = " 已 深 化 贸 易 关 系";
																this.uslovie_bool[3] = !this.global1.allcountries[7].isSEV;
																this.uslovie_text[3] = " 苏 联 不 在 经 互 会 内";
																return;
															}
															if (this.this_type == 40)
															{
																this.this_opis = " 恢 复 友 好 关 系";
																this.number_uslovie = 2;
																this.uslovie_bool[0] = this.global1.data[6] > 390 && this.global1.data[6] < 800;
																this.uslovie_text[0] = " 外 交 声 誉 在 39 和 80 之 间";
																this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].Torg;
																this.uslovie_text[1] = " 未 恢 复 友 好 关 系";
																return;
															}
															if (this.this_type == 41)
															{
																if (this.selected_country == 46 || this.selected_country == 33 || this.selected_country == 22)
																{
																	this.this_opis = " 邀 请 至 经 济 联 盟 \n 注 意 ！ 该 国 将 被 补 贴";
																}
																else
																{
																	this.this_opis = " 邀 请 至 贸 易 及 关 税 联 盟";
																}
																this.number_uslovie = 4;
																this.uslovie_bool[0] = !this.global1.allcountries[7].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV;
																this.uslovie_text[0] = " 苏 联 不 在 经 互 会 内 且 我 们 在 联 盟 中";
																this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isSEV;
																this.uslovie_text[1] = " 未 被 邀 请 至 贸 易 及 关 税 联 盟";
																this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Torg;
																this.uslovie_text[2] = " 已 恢 复 友 好 关 系";
																this.uslovie_bool[3] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																this.uslovie_text[3] = " 我 们 未 在 整 合 进 欧 共 体";
																return;
															}
															if (this.this_type == 42)
															{
																this.this_opis = " 与 缅 甸 新 政 府 全 面 恢 复 关 系";
																this.number_uslovie = 3;
																this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Torg;
																this.uslovie_text[0] = " 未 与 该 国 恢 复 关 系";
																this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Gosstroy == 9 || this.global1.allcountries[this.selected_country].Gosstroy == 0;
																this.uslovie_text[1] = " 新 政 府 已 全 面 掌 权";
																this.uslovie_bool[2] = this.global1.data[6] > 790;
																this.uslovie_text[2] = " 外 交 声 誉 高 于 79";
																return;
															}
															if (this.this_type == 46)
															{
																this.this_opis = " 说 服 我 们 的 盟 友 对 支 持 阿 富 汗 恐 怖 主 义 实 施 制 裁";
																this.number_uslovie = 4;
																this.uslovie_bool[0] = this.global1.data[6] > 590;
																this.uslovie_text[0] = " 外 交 声 誉 高 于 59";
																this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																this.uslovie_text[1] = " 我 们 未 在 整 合 进 欧 共 体";
																this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
																this.uslovie_text[2] = " 未 实 施 制 裁";
																this.uslovie_bool[3] = this.global1.is_konst_max;
																this.uslovie_text[3] = " 我 们 有 修 宪 多 数";
																return;
															}
															if (this.this_type == 52)
															{
																this.this_opis = " 取 消 制 裁";
																this.number_uslovie = 3;
																this.uslovie_bool[0] = this.global1.data[6] < 400;
																this.uslovie_text[0] = " 外 交 声 誉 低 于 40";
																this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].isOVD || !this.global1.allcountries[7].isOVD;
																this.uslovie_text[1] = " 我 们 与 苏 联 不 在 同 一 个 军 事 联 盟";
																this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Help;
																this.uslovie_text[2] = " 已 实 施 制 裁";
																return;
															}
															if (this.this_type == 47)
															{
																this.this_opis = " 承 认 叙 利 亚 属 黎 巴 嫩 并 与 以 色 列 属 黎 巴 嫩 断 交";
																this.number_uslovie = 3;
																this.uslovie_bool[0] = this.global1.data[6] > 790;
																this.uslovie_text[0] = " 外 交 声 誉 高 于 79";
																this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																this.uslovie_text[1] = " 我 们 未 在 整 合 进 欧 共 体";
																this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
																this.uslovie_text[2] = " 未 承 认 叙 利 亚 属 黎 巴 嫩";
																return;
															}
															if (this.this_type == 48)
															{
																this.this_opis = " 贿 赂 官 员 ， 获 取 核 武 的 蓝 图 和 技 术";
																this.number_uslovie = 4;
																this.uslovie_bool[0] = this.global1.data[9] >= 100;
																this.uslovie_text[0] = " 空 余 的 间 谍 网 络 大 于9";
																this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																this.uslovie_text[1] = " 我 们 未 整 合 进 欧 共 体";
																this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Stasi;
																this.uslovie_text[2] = " 未 贿 赂 官 员";
																if (this.global1.data[0] != 10 || this.global1.event_done[255])
																{
																	this.uslovie_bool[3] = this.global1.data[8] >= 250;
																	this.uslovie_text[3] = " 有 25 资 金";
																	return;
																}
																this.uslovie_bool[3] = this.global1.event_done[255];
																this.uslovie_text[3] = " 我 们 想 要 它 们 吗 ？";
																return;
															}
															else if (this.this_type == 50)
															{
																this.this_opis = " 贿 赂 官 员 ， 获 取 核 武 的 蓝 图 和 技 术";
																this.number_uslovie = 4;
																this.uslovie_bool[0] = this.global1.data[9] >= 50;
																this.uslovie_text[0] = " 空 余 的 间 谍 网 络 大 于 4";
																this.uslovie_bool[1] = this.global1.allcountries[7].Vyshi;
																this.uslovie_text[1] = " 苏 联 不 复 存 在";
																this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
																this.uslovie_text[2] = " 未 贿 赂 官 员";
																if (this.global1.data[0] != 10 || this.global1.event_done[255])
																{
																	this.uslovie_bool[3] = this.global1.data[8] >= 100;
																	this.uslovie_text[3] = " 有 10 资 金";
																	return;
																}
																this.uslovie_bool[3] = this.global1.event_done[255];
																this.uslovie_text[3] = " 我 们 想 要 它 们 吗 ？";
																return;
															}
															else
															{
																if (this.this_type == 49)
																{
																	this.this_opis = " 协 助 石 油 开 采 的 发 展";
																	this.number_uslovie = 2;
																	this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
																	this.uslovie_text[0] = " 未 协 助";
																	this.uslovie_bool[1] = this.global1.data[8] >= 30;
																	this.uslovie_text[1] = " 有 3 资 金";
																	return;
																}
																if (this.this_type == 53)
																{
																	if (this.selected_country == 23)
																	{
																		this.this_opis = " 投 资 海 上 石 油 开 采";
																		this.this_opis += " ( 政 权 获 得 的 补 贴 将 减 少)";
																	}
																	else
																	{
																		this.this_opis = " 投 资 石 油 开 采";
																	}
																	this.number_uslovie = 3;
																	this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Donat;
																	this.uslovie_text[0] = " 今 年 未 投 资";
																	if (this.selected_country == 23)
																	{
																		this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Torg;
																		this.uslovie_text[1] = " 已 加 强 贸 易 关 系";
																	}
																	else
																	{
																		this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Stasi;
																		this.uslovie_text[1] = " 曾 协 助 发 展";
																	}
																	this.uslovie_bool[2] = this.global1.data[8] >= 30;
																	this.uslovie_text[2] = " 有 3 资 金";
																	return;
																}
																if (this.this_type == 54)
																{
																	this.this_opis = " 签 署 缓 和 协 议";
																	this.number_uslovie = 4;
																	this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
																	this.uslovie_text[0] = " 本 月 未 签 署";
																	this.uslovie_bool[1] = this.global1.data[9] >= this.global1.data[6] / 20;
																	this.uslovie_text[1] = " 间 谍 网 络: " + (this.global1.data[6] / 200).ToString() + "." + Mathf.Abs(this.global1.data[6] / 20 % 10).ToString();
																	this.uslovie_bool[2] = this.global1.data[8] >= this.global1.data[6] / 20;
																	this.uslovie_text[2] = " 资 金: " + (this.global1.data[6] / 200).ToString() + "." + Mathf.Abs(this.global1.data[6] / 20 % 10).ToString();
																	this.uslovie_bool[3] = this.global1.data[10] > 400;
																	this.uslovie_text[3] = " 北 约 威 胁 大 于 40";
																	return;
																}
																if (this.this_type == 55)
																{
																	this.this_opis = " 将 钱 存 入 一 个 秘 密 银 行 账 户";
																	this.number_uslovie = 1;
																	this.uslovie_bool[0] = this.global1.data[8] >= 80;
																	this.uslovie_text[0] = " 资 金: 8";
																	return;
																}
																if (this.this_type == 57)
																{
																	this.this_opis = " 让 比 萨 拉 比 亚 回 归 罗 马 尼 亚";
																	this.number_uslovie = 4;
																	if (this.global1.data[59] == 0)
																	{
																		this.uslovie_bool[0] = this.global1.allcountries[7].Vyshi;
																		this.uslovie_text[0] = " 苏 联 崩 溃";
																	}
																	else
																	{
																		this.uslovie_bool[0] = this.global1.data[59] == 0;
																		this.uslovie_text[0] = " 比 萨 拉 比 亚 不 是 我 们 的";
																	}
																	this.uslovie_bool[1] = this.global1.data[11] == 0 || this.global1.data[31] >= 700;
																	this.uslovie_text[1] = " 罗 马 尼 亚 是 齐 奥 塞 斯 库 掌 权 或 民 族 主 义";
																	this.uslovie_bool[2] = this.global1.data[9] >= 100;
																	this.uslovie_text[2] = " 间 谍 网 络: 10";
																	this.uslovie_bool[3] = this.global1.data[8] >= 60;
																	this.uslovie_text[3] = " 资 金: 6";
																	return;
																}
																if (this.this_type == 58)
																{
																	if (this.global1.allcountries[this.selected_country].Westalgie > 25)
																	{
																		this.this_opis = string.Concat(new string[]
																		{
																			" 支 持 亲 美 右 翼 组 织 ( 左 翼: ",
																			(this.global1.allcountries[this.selected_country].Westalgie / 10).ToString(),
																			".",
																			Mathf.Abs(this.global1.allcountries[this.selected_country].Westalgie % 10).ToString(),
																			")"
																		});
																	}
																	else
																	{
																		this.this_opis = string.Concat(new string[]
																		{
																			" 建 立 亲 美 右 翼 组 织 ( 左 翼: ",
																			(this.global1.allcountries[this.selected_country].Westalgie / 10).ToString(),
																			".",
																			Mathf.Abs(this.global1.allcountries[this.selected_country].Westalgie % 10).ToString(),
																			")"
																		});
																	}
																	this.number_uslovie = 4;
																	this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
																	this.uslovie_text[0] = " 未 支 持 左 翼 组 织";
																	this.uslovie_bool[1] = this.global1.data[8] >= 8;
																	this.uslovie_text[1] = " 资 金: 0.8";
																	this.uslovie_bool[2] = this.global1.data[9] >= 10;
																	this.uslovie_text[2] = " 有 空 余 的 间 谍 网 络";
																	this.uslovie_bool[3] = this.global1.allcountries[this.selected_country].Westalgie > 0 && this.global1.allcountries[this.selected_country].Westalgie < 1000;
																	this.uslovie_text[3] = "1-99";
																	return;
																}
																if (this.this_type == 59)
																{
																	if (this.global1.allcountries[this.selected_country].Westalgie <= 975)
																	{
																		this.this_opis = string.Concat(new string[]
																		{
																			" 支 持 反 美 左 翼 组 织 ( 左 翼: ",
																			(this.global1.allcountries[this.selected_country].Westalgie / 10).ToString(),
																			".",
																			Mathf.Abs(this.global1.allcountries[this.selected_country].Westalgie % 10).ToString(),
																			")"
																		});
																	}
																	else
																	{
																		this.this_opis = string.Concat(new string[]
																		{
																			" 建 立 反 美 左 翼 组 织 ( 左 翼: ",
																			(this.global1.allcountries[this.selected_country].Westalgie / 10).ToString(),
																			".",
																			Mathf.Abs(this.global1.allcountries[this.selected_country].Westalgie % 10).ToString(),
																			")"
																		});
																	}
																	this.number_uslovie = 4;
																	this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Donat;
																	this.uslovie_text[0] = " 未 支 持 右 翼 组 织";
																	this.uslovie_bool[1] = this.global1.data[8] >= 8;
																	this.uslovie_text[1] = " 资 金: 0.8";
																	this.uslovie_bool[2] = this.global1.data[9] >= 10;
																	this.uslovie_text[2] = " 有 空 余 的 间 谍 网 络";
																	this.uslovie_bool[3] = this.global1.allcountries[this.selected_country].Westalgie > 0 && this.global1.allcountries[this.selected_country].Westalgie < 1000;
																	this.uslovie_text[3] = " 他 们 存 活 且 未 建 立";
																	return;
																}
																if (this.this_type == 60)
																{
																	this.this_opis = string.Concat(new string[]
																	{
																		" 向 他 们 的 人 民 提 供 人 道 主 义 援 助 ( 左 翼: ",
																		(this.global1.allcountries[this.selected_country].Westalgie / 10).ToString(),
																		".",
																		Mathf.Abs(this.global1.allcountries[this.selected_country].Westalgie % 10).ToString(),
																		")"
																	});
																	this.number_uslovie = 2;
																	this.uslovie_bool[0] = this.global1.data[8] >= 20;
																	this.uslovie_text[0] = " 资 金: 2";
																	this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Westalgie > 0 && this.global1.allcountries[this.selected_country].Westalgie < 1000;
																	this.uslovie_text[1] = "1-99";
																	return;
																}
																if (this.this_type == 61)
																{
																	this.this_opis = " 完 全 开 放 一 个 边 境";
																	this.number_uslovie = 3;
																	this.uslovie_bool[0] = this.global1.data[27] < 5;
																	this.uslovie_text[0] = " 至 少 一 个 未 完 全 开 放 边 境";
																	this.uslovie_bool[1] = this.global1.data[6] < 600;
																	this.uslovie_text[1] = " 外 交 声 誉 低 于 60";
																	this.uslovie_bool[2] = !this.global1.allcountries[this.global1.data[0]].Help;
																	this.uslovie_text[2] = " 本 月 我 们 没 有 涉 及 边 境 问 题";
																	return;
																}
																if (this.this_type == 62)
																{
																	this.this_opis = " 收 费 开 放 一 个 边 境";
																	this.number_uslovie = 4;
																	this.uslovie_bool[0] = this.global1.data[28] < 5;
																	this.uslovie_text[0] = " 至 少 一 个 开 放 边 境";
																	this.uslovie_bool[1] = this.global1.data[6] < 800;
																	this.uslovie_text[1] = " 外 交 声 誉 低 于 80";
																	this.uslovie_bool[2] = this.global1.data[6] > 400;
																	this.uslovie_text[2] = " 外 交 声 誉 高 于 40";
																	this.uslovie_bool[3] = !this.global1.allcountries[this.global1.data[0]].Help;
																	this.uslovie_text[3] = " 本 月 我 们 没 有 涉 及 边 境 问 题";
																	return;
																}
																if (this.this_type == 63)
																{
																	this.this_opis = " 关 闭 一 个 边 境";
																	this.number_uslovie = 3;
																	this.uslovie_bool[0] = this.global1.data[27] + this.global1.data[28] + this.global1.data[29] > 0;
																	this.uslovie_text[0] = " 至 少 一 个 未 关 闭 边 境";
																	this.uslovie_bool[1] = this.global1.data[6] > 800;
																	this.uslovie_text[1] = " 外 交 声 誉 高 于 80";
																	this.uslovie_bool[2] = !this.global1.allcountries[this.global1.data[0]].Help;
																	this.uslovie_text[2] = " 本 月 我 们 没 有 涉 及 边 境 问 题";
																	return;
																}
																if (this.this_type == 64)
																{
																	this.this_opis = " 获 得 开 采 资 源 的 专 有 权";
																	this.number_uslovie = 3;
																	if (this.selected_country == 40)
																	{
																		this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Westalgie >= 1000 || this.global1.allcountries[this.selected_country].subideology == 3;
																		this.uslovie_text[0] = " 左 翼 有 100 控 制 度 或 意 识 形 态 是 第 三 道 路";
																	}
																	else if (this.selected_country == 41)
																	{
																		this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Westalgie >= 1000 || this.global1.allcountries[this.selected_country].subideology == 11;
																		this.uslovie_text[0] = " 左 翼 有 100 控 制 度 或 意 识 形 态 是 左 翼 实 用 主 义";
																	}
																	else
																	{
																		this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Westalgie >= 1000 || this.global1.allcountries[this.selected_country].subideology == 2;
																		this.uslovie_text[0] = " 左 翼 有 100 控 制 度 或 意 识 形 态 是 市 场 独 裁 体 制";
																	}
																	this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].Torg;
																	this.uslovie_text[1] = " 右 翼 未 夺 权";
																	this.uslovie_bool[2] = !this.global1.allcountries[this.global1.data[0]].Vyshi || this.global1.allcountries[this.selected_country].Westalgie <= 0;
																	this.uslovie_text[2] = " 我 们 未 在 整 合 进 欧 共 体 或 左 翼 有 0 控 制 度";
																	return;
																}
																if (this.this_type == 65)
																{
																	this.this_opis = " 与 日 本 共 产 主 义 者 建 立 联 系";
																	this.number_uslovie = 4;
																	this.uslovie_bool[0] = this.global1.data[6] < 850;
																	this.uslovie_text[0] = " 外 交 声 誉 低 于 85";
																	this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																	this.uslovie_text[1] = " 我 们 未 在 整 合 进 欧 共 体";
																	this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Stasi;
																	this.uslovie_text[2] = " 未 建 立 联 系";
																	this.uslovie_bool[3] = this.global1.data[14] <= 3 && this.global1.data[14] > 0;
																	this.uslovie_text[3] = " 满 足 于 日 共 对 共 产 主 义 的 看 法";
																	return;
																}
																if (this.this_type == 66)
																{
																	this.this_opis = " 与 日 本 建 立 贸 易 关 系";
																	this.number_uslovie = 4;
																	if (this.global1.allcountries[this.selected_country].Gosstroy == 1)
																	{
																		this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Gosstroy == 1;
																		this.uslovie_text[0] = " 日 本 社 会 主 义 者 胜 利";
																	}
																	else
																	{
																		this.uslovie_bool[0] = !this.global1.allcountries[this.global1.data[0]].isOVD || !this.global1.allcountries[7].isOVD;
																		this.uslovie_text[0] = " 我 们 与 苏 联 不 在 同 一 个 军 事 同 盟";
																	}
																	this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																	this.uslovie_text[1] = " 我 们 未 在 整 合 进 欧 共 体";
																	this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Torg;
																	this.uslovie_text[2] = " 未 建 立 贸 易 关 系";
																	this.uslovie_bool[3] = !this.global1.allcountries[44].Vyshi;
																	this.uslovie_text[3] = " 左 翼 联 盟 在 日 本 国 会 中 处 于 领 先 地 位";
																	return;
																}
																if (this.this_type == 67)
																{
																	this.this_opis = " 邀 请 加 入 我 们 的 经 济 同 盟";
																	this.number_uslovie = 4;
																	this.uslovie_bool[0] = !this.global1.allcountries[7].isOVD;
																	this.uslovie_text[0] = " 苏 联 不 在 华 沙 条 约 中";
																	if (this.global1.allcountries[this.selected_country].isSEV)
																	{
																		this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isSEV;
																		this.uslovie_text[1] = " 希 腊 不 在 我 们 的 经 济 同 盟 中";
																	}
																	else if (!this.global1.event_done[50])
																	{
																		this.uslovie_bool[1] = this.global1.event_done[50];
																		this.uslovie_text[1] = "1989 年 选 举 已 举 行";
																	}
																	else
																	{
																		this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Gosstroy <= 1;
																		this.uslovie_text[1] = " 社 会 主 义 联 盟 处 于 领 导 地 位";
																	}
																	this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Torg && this.global1.allcountries[this.global1.data[0]].isSEV;
																	this.uslovie_text[2] = " 贸 易 活 跃";
																	this.uslovie_bool[3] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																	this.uslovie_text[3] = " 我 们 未 在 整 合 进 欧 共 体";
																	return;
																}
																if (this.this_type == 69)
																{
																	this.this_opis = " 利 用 印 度 调 解 员 支 持 罗 汉 · 维 杰 维 拉";
																	this.number_uslovie = 4;
																	this.uslovie_bool[0] = this.global1.allcountries[19].Torg && this.global1.allcountries[16].Torg;
																	this.uslovie_text[0] = " 与 印 度 和 中 国 有 紧 密 关 系";
																	this.uslovie_bool[1] = !this.global1.allcountries[46].Donat;
																	this.uslovie_text[1] = " 未 支 持 他 们";
																	this.uslovie_bool[2] = this.global1.data[8] > 30;
																	this.uslovie_text[2] = " 资 金 多 于 3";
																	this.uslovie_bool[3] = this.global1.data[20] < 3 && this.global1.data[21] == 1989;
																	this.uslovie_text[3] = " 早 于 1989 年 三 月";
																	return;
																}
																if (this.this_type == 70)
																{
																	this.this_opis = " 为 罗 汉 · 维 杰 维 拉 组 织 安 保 服 务";
																	this.number_uslovie = 4;
																	this.uslovie_bool[0] = this.global1.allcountries[46].Donat && !this.global1.allcountries[46].Stasi;
																	this.uslovie_text[0] = " 已 支 持 他 们 ， 但 未 组 织 服 务";
																	this.uslovie_bool[1] = this.global1.data[9] > 30;
																	this.uslovie_text[1] = " 间 谍 网 络 大 于 3";
																	this.uslovie_bool[2] = this.global1.allcountries[19].Help;
																	this.uslovie_text[2] = " 在 印 度 获 得 庇 护";
																	this.uslovie_bool[3] = this.global1.data[20] < 11 && this.global1.data[21] == 1989;
																	this.uslovie_text[3] = " 早 于 1989 年 十 一 月";
																	return;
																}
																if (this.this_type == 71)
																{
																	this.this_opis = " 煽 动 人 民 解 放 阵 线 起 义";
																	this.number_uslovie = 4;
																	if (this.global1.allcountries[46].Westalgie == 1 || (this.global1.data[20] < 12 && this.global1.data[21] == 1989))
																	{
																		this.uslovie_bool[0] = this.global1.allcountries[46].Donat && this.global1.allcountries[46].Stasi;
																	}
																	else
																	{
																		this.uslovie_bool[0] = this.global1.allcountries[46].Stasi;
																	}
																	this.uslovie_text[0] = " 人 民 解 放 阵 线 已 做 好 准 备";
																	this.uslovie_bool[1] = this.global1.allcountries[46].Gosstroy != 0;
																	this.uslovie_text[1] = " 旧 政 府";
																	this.uslovie_bool[2] = this.global1.data[9] > 50;
																	this.uslovie_text[2] = " 间 谍 网 络 大 于 5";
																	this.uslovie_bool[3] = this.global1.data[8] > 50;
																	this.uslovie_text[3] = " 资 金 多 于 5";
																	return;
																}
																if (this.this_type == 72)
																{
																	this.this_opis = " 秘 密 资 助 诺 埃 尔 · 布 朗";
																	this.number_uslovie = 4;
																	this.uslovie_bool[0] = !this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.data[14] < 4;
																	this.uslovie_text[0] = " 不 是 西 渐 派";
																	this.uslovie_bool[1] = this.global1.data[8] > 80;
																	this.uslovie_text[1] = " 资 金 多 于 8";
																	this.uslovie_bool[2] = this.global1.data[21] == 1989;
																	this.uslovie_text[2] = " 早 于 1990 年";
																	this.uslovie_bool[3] = !this.global1.allcountries[29].Donat;
																	this.uslovie_text[3] = " 未 帮 助 他 们";
																	return;
																}
																if (this.this_type == 73)
																{
																	this.this_opis = " 消 灭 迪 克 · 斯 普 林";
																	this.number_uslovie = 4;
																	this.uslovie_bool[0] = !this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.data[14] < 4;
																	this.uslovie_text[0] = " 不 是 西 渐 派";
																	this.uslovie_bool[1] = this.global1.data[9] > 150;
																	this.uslovie_text[1] = " 间 谍 网 络 大 于 15";
																	this.uslovie_bool[2] = this.global1.data[21] == 1989;
																	this.uslovie_text[2] = " 早 于 1990";
																	this.uslovie_bool[3] = !this.global1.allcountries[29].Stasi;
																	this.uslovie_text[3] = " 未 消 灭 他";
																	return;
																}
																if (this.this_type == 74)
																{
																	this.this_opis = " 创 建 一 个 由 工 党 和 左 翼 政 党 组 成 的 联 合 政 党";
																	this.number_uslovie = 4;
																	this.uslovie_bool[0] = this.global1.allcountries[29].Stasi && this.global1.allcountries[29].Donat && ((this.global1.data[20] < 11 && this.global1.data[21] <= 1990) || this.global1.data[21] <= 1989);
																	this.uslovie_text[0] = " 万 事 俱 备 ( 在 1990 年 十 一 月 之 前)";
																	this.uslovie_bool[1] = this.global1.science[2];
																	this.uslovie_text[1] = " 已 研 发 信 息 通 讯 审 查 系 统";
																	this.uslovie_bool[2] = this.global1.allcountries[29].Gosstroy != 1;
																	this.uslovie_text[2] = " 左 翼 未 赢 得 1990 年 选 举";
																	this.uslovie_bool[3] = this.global1.data[10] <= 510;
																	this.uslovie_text[3] = " 北 约 威 胁 小 于 51";
																	return;
																}
																if (this.this_type == 75)
																{
																	this.this_opis = " 对 凯 山 · 丰 威 汉 实 施 恐 怖 主 义 行 动";
																	this.number_uslovie = 4;
																	this.uslovie_bool[0] = !this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.data[14] < 4;
																	this.uslovie_text[0] = " 不 是 西 渐 派";
																	this.uslovie_bool[1] = this.global1.data[9] > 100;
																	this.uslovie_text[1] = " 间 谍 网 络 大 于 10";
																	this.uslovie_bool[2] = this.global1.data[21] <= 1990;
																	this.uslovie_text[2] = " 早 于 1991 年";
																	this.uslovie_bool[3] = !this.global1.allcountries[22].Stasi;
																	this.uslovie_text[3] = " 未 实 施";
																	return;
																}
																if (this.this_type == 76)
																{
																	this.this_opis = " 帮 助 苏 发 努 冯 — 富 米 派";
																	this.number_uslovie = 4;
																	this.uslovie_bool[0] = this.global1.allcountries[22].Stasi;
																	this.uslovie_text[0] = " 已 实 施 恐 怖 主 义 行 动";
																	this.uslovie_bool[1] = this.global1.data[9] > 50 && this.global1.data[8] > 50;
																	this.uslovie_text[1] = " 间 谍 网 络 大 于 5";
																	this.uslovie_bool[2] = (this.global1.data[20] < 8 && this.global1.data[21] <= 1991) || this.global1.data[21] <= 1990;
																	this.uslovie_text[2] = " 早 于 1991 年 八 月";
																	this.uslovie_bool[3] = !this.global1.allcountries[22].Donat;
																	this.uslovie_text[3] = " 未 帮 助";
																	return;
																}
																if (this.this_type == 77)
																{
																	this.this_opis = " 开 始 进 攻";
																	this.number_uslovie = 1;
																	this.uslovie_bool[0] = this.global1.data[90] != 1 || this.global1.data[92] != 1 || this.global1.data[93] != 1 || this.global1.data[94] != 1;
																	this.uslovie_text[0] = " 有 我 们 可 以 进 攻 的 地 方";
																	return;
																}
																if (this.this_type == 78)
																{
																	this.this_opis = " 增 援 阿 富 汗 军 队";
																	this.number_uslovie = 2;
																	this.uslovie_bool[0] = this.global1.data[8] >= 30;
																	this.uslovie_text[0] = " 资 金: 3";
																	this.uslovie_bool[1] = this.global1.data[9] >= 50;
																	this.uslovie_text[1] = " 间 谍 网 络 大 于 5";
																	return;
																}
																if (this.this_type == 79)
																{
																	this.this_opis = " 进 入 活 跃 贸 易 阶 段";
																	this.number_uslovie = 4;
																	if (this.global1.data[0] == 18)
																	{
																		this.uslovie_bool[0] = this.global1.data[77] <= 0;
																		this.uslovie_text[0] = " 已 解 除 禁 运";
																		this.uslovie_bool[2] = !this.global1.allcountries[this.global1.data[0]].isSEV;
																		this.uslovie_text[2] = " 我 们 不 在 经 互 会 内";
																	}
																	else if (this.global1.data[0] == 12 || this.global1.data[0] == 10)
																	{
																		this.uslovie_bool[0] = this.global1.data[101] == 0 || (this.global1.data[98] < 0 && this.global1.data[68] > 3) || this.global1.data[112] == 1;
																		this.uslovie_text[0] = " 已 签 署 和 平 协 议 或 已 放 弃 核 武 器";
																		this.uslovie_bool[2] = this.global1.data[101] == 0;
																		this.uslovie_text[2] = " 没 有 核 武 器";
																	}
																	else
																	{
																		this.uslovie_bool[0] = this.global1.allcountries[this.global1.data[0]].Vyshi;
																		this.uslovie_text[0] = " 我 们 在 整 合 进 欧 共 体";
																		this.uslovie_bool[2] = !this.global1.allcountries[this.global1.data[0]].isSEV;
																		this.uslovie_text[2] = " 我 们 不 在 经 互 会 内";
																	}
																	this.uslovie_bool[1] = this.global1.data[6] <= 500;
																	this.uslovie_text[1] = " 外 交 声 誉 低 于 50";
																	this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Torg;
																	this.uslovie_text[3] = " 我 们 没 有 活 跃 贸 易";
																	return;
																}
																if (this.this_type == 80)
																{
																	this.this_opis = " 邀 请 外 国 投 资 者";
																	this.number_uslovie = 4;
																	if (this.selected_country == 0)
																	{
																		this.uslovie_bool[0] = this.global1.data[10] < 400;
																		this.uslovie_text[0] = " 北 约 威 胁 小 于 40.0";
																	}
																	else
																	{
																		this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Torg;
																		this.uslovie_text[0] = " 我 们 有 活 跃 贸 易";
																	}
																	if (this.selected_country == 44 && this.global1.allcountries[44].subideology == 12)
																	{
																		this.uslovie_bool[1] = this.global1.allcountries[44].subideology == 12;
																		this.uslovie_text[1] = " 中 间 派 联 合 已 成 立";
																	}
																	else if (this.selected_country == 44 && this.global1.allcountries[44].subideology == 9)
																	{
																		this.uslovie_bool[1] = this.global1.data[6] <= 600;
																		this.uslovie_text[1] = " 外 交 声 誉 低 于 60";
																	}
																	else if (this.selected_country == 44 && this.global1.data[239] == 1)
																	{
																		this.uslovie_bool[1] = this.global1.data[6] <= 500;
																		this.uslovie_text[1] = " 外 交 声 誉 低 于 50";
																	}
																	else
																	{
																		this.uslovie_bool[1] = this.global1.data[6] <= 300;
																		this.uslovie_text[1] = " 外 交 声 誉 低 于 30";
																	}
																	this.uslovie_bool[2] = this.global1.data[16] >= 12 || this.global1.data[70] > 0;
																	this.uslovie_text[2] = " 适 应 经 济";
																	if (this.selected_country == 0)
																	{
																		this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Money;
																		this.uslovie_text[3] = " 今 年 未 协 商 任 何 投 资";
																		return;
																	}
																	this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Money;
																	this.uslovie_text[3] = " 未 收 到 投 资";
																	return;
																}
																else
																{
																	if (this.this_type == 81)
																	{
																		this.this_opis = " 利 用 经 济 影 响 推 动 朝 鲜 体 制 的 改 革";
																		this.number_uslovie = 4;
																		this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].isSEV;
																		this.uslovie_text[0] = " 该 国 在 经 互 会 内";
																		this.uslovie_bool[1] = this.global1.allcountries[16].isSEV && this.global1.allcountries[16].Gosstroy == 0;
																		this.uslovie_text[1] = " 中 国 在 经 互 会 内 且 为 社 会 主 义 道 路";
																		int num = 0;
																		if (this.global1.allcountries[16].isSEV && this.global1.allcountries[16].Gosstroy == 0 && !this.global1.allcountries[7].isSEV && this.global1.allcountries[this.selected_country].Gosstroy != 0)
																		{
																			foreach (Country country in this.global1.allcountries)
																			{
																				if (country != null && country.isSEV)
																				{
																					num++;
																				}
																			}
																		}
																		this.uslovie_bool[2] = this.global1.allcountries[7].isSEV || num > 8;
																		this.uslovie_text[2] = " 苏 联 在 经 互 会 内 或 成 员 国 多 于 8";
																		this.uslovie_bool[3] = this.global1.allcountries[this.selected_country].Gosstroy != 0;
																		this.uslovie_text[3] = " 没 有 正 统 社 会 主 义";
																		return;
																	}
																	if (this.this_type == 82)
																	{
																		if (this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51)
																		{
																			this.this_opis = " 增 加 在 意 大 利 的 国 家 安 全 局 间 谍 数 量";
																		}
																		else
																		{
																			this.this_opis = " 增 加 在 意 大 利 的 间 谍 数 量";
																		}
																		this.number_uslovie = 3;
																		this.uslovie_bool[0] = this.global1.data[9] >= 50;
																		this.uslovie_text[0] = " 间 谍 网 络 - 5";
																		this.uslovie_bool[1] = this.global1.data[6] < 600 || this.global1.data[14] >= 3;
																		this.uslovie_text[1] = " 外 交 声 誉 低 于 60 或 国 家 体 制 为 卡 达 尔 主 义 或 更 右";
																		this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Stasi;
																		this.uslovie_text[2] = " 未 利 用";
																		return;
																	}
																	if (this.this_type == 83)
																	{
																		this.this_opis = " 支 持 共 产 主 义 战 斗 旅";
																		this.number_uslovie = 3;
																		this.uslovie_bool[0] = this.global1.data[8] >= 50;
																		this.uslovie_text[0] = " 资 金 - 5";
																		this.uslovie_bool[1] = this.global1.data[6] < 850 && this.global1.data[6] > 390;
																		this.uslovie_text[1] = " 外 交 声 誉 低 于 85 高 于 39";
																		this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Money;
																		this.uslovie_text[2] = " 未 利 用";
																		return;
																	}
																	if (this.this_type == 84)
																	{
																		this.this_opis = " 进 入 活 跃 贸 易 阶 段";
																		if (this.selected_country == 53 || this.selected_country == 31 || this.selected_country == 37)
																		{
																			this.number_uslovie = 4;
																		}
																		else
																		{
																			this.number_uslovie = 3;
																		}
																		if (this.selected_country == 33)
																		{
																			this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Donat;
																			this.uslovie_text[0] = " 已 协 助 恢 委 会";
																		}
																		else
																		{
																			this.uslovie_bool[0] = this.global1.data[27] > 0;
																			this.uslovie_text[0] = " 至 少 一 个 开 放 边 境";
																		}
																		if (this.selected_country == 54 && this.global1.allcountries[54].Gosstroy == 1)
																		{
																			this.uslovie_bool[1] = this.global1.data[6] < 650;
																			this.uslovie_text[1] = " 外 交 声 誉 低 于 65.0";
																		}
																		else if ((this.selected_country == 23 && this.global1.allcountries[23].Gosstroy != 2) || this.selected_country == 33 || (this.selected_country == 47 && this.global1.allcountries[47].Gosstroy != 2))
																		{
																			this.uslovie_bool[1] = this.global1.data[6] > 450;
																			this.uslovie_text[1] = " 外 交 声 誉 高 于 45.0";
																		}
																		else if (this.selected_country == 34 && this.global1.allcountries[34].Gosstroy == 9)
																		{
																			this.uslovie_bool[1] = this.global1.data[6] >= 390 && this.global1.data[6] <= 800;
																			this.uslovie_text[1] = " 外 交 声 誉 在 39.0 和 80.0 之 间";
																		}
																		else if (this.selected_country == 29 && this.global1.allcountries[29].Gosstroy == 1)
																		{
																			this.uslovie_bool[1] = this.global1.data[6] >= 400 && this.global1.data[6] <= 850;
																			this.uslovie_text[1] = " 外 交 声 誉 在 40.0 和 85.0 之 间";
																		}
																		else
																		{
																			this.uslovie_bool[1] = this.global1.data[6] < 350;
																			this.uslovie_text[1] = " 外 交 声 誉 低 于 35.0";
																		}
																		this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Torg;
																		this.uslovie_text[2] = " 未 开 始 与 他 们 贸 易";
																		if (this.selected_country == 53)
																		{
																			this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Help;
																			this.uslovie_text[3] = " 未 承 认 北 塞 浦 路 斯";
																		}
																		if (this.selected_country == 31)
																		{
																			this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Help && !this.global1.allcountries[19].Torg;
																			this.uslovie_text[3] = " 我 们 未 发 起 制 裁 且 未 与 印 度 贸 易";
																		}
																		if (this.selected_country == 37)
																		{
																			this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Donat && this.global1.allcountries[this.selected_country].Westalgie == 0;
																			this.uslovie_text[3] = " 未 支 持 恐 怖 分 子";
																			return;
																		}
																	}
																	else
																	{
																		if (this.this_type == 85)
																		{
																			this.this_opis = " 赞 助 武 装 部 队\n( 军 队 力 量:" + this.global1.data[50].ToString() + ")";
																			this.number_uslovie = 2;
																			this.uslovie_bool[0] = this.global1.data[8] >= 50;
																			this.uslovie_text[0] = " 资 金 - 5";
																			this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].Stasi;
																			this.uslovie_text[1] = " 本 月 未 赞 助";
																			return;
																		}
																		if (this.this_type == 86)
																		{
																			this.this_opis = " 邀 请 至 经 济 联 盟";
																			this.number_uslovie = 4;
																			this.uslovie_bool[0] = !this.global1.allcountries[7].isSEV && !this.global1.allcountries[45].isSEV;
																			this.uslovie_text[0] = " 苏 联 和 希 腊 不 在 我 们 的 经 济 联 盟 内";
																			this.uslovie_bool[1] = this.global1.allcountries[53].Help && this.global1.data[6] < 650;
																			this.uslovie_text[1] = " 已 承 认 北 塞 浦 路 斯 且 外 交 声 誉 低 于 65";
																			this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Torg && !this.global1.allcountries[this.global1.data[0]].Vyshi;
																			this.uslovie_text[2] = " 贸 易 活 跃 且 我 们 未 在 整 合 进 欧 共 体";
																			this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].isSEV;
																			this.uslovie_text[3] = " 土 耳 其 不 在 经 济 联 盟 内";
																			return;
																		}
																		if (this.this_type == 87)
																		{
																			this.this_opis = " 承 认 北 塞 浦 路 斯";
																			this.number_uslovie = 3;
																			this.uslovie_bool[0] = this.global1.data[6] > 550;
																			this.uslovie_text[0] = " 外 交 声 誉 高 于 55";
																			this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																			this.uslovie_text[1] = " 我 们 未 在 整 合 进 欧 共 体";
																			this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
																			this.uslovie_text[2] = " 未 承 认 北 塞 浦 路 斯";
																			return;
																		}
																		if (this.this_type == 88)
																		{
																			this.this_opis = " 进 入 活 跃 贸 易 阶 段";
																			if (this.selected_country == 52)
																			{
																				this.number_uslovie = 4;
																			}
																			else
																			{
																				this.number_uslovie = 3;
																			}
																			this.uslovie_bool[0] = this.global1.data[27] > 0;
																			this.uslovie_text[0] = " 至 少 一 个 开 放 边 境";
																			this.uslovie_bool[1] = this.global1.data[6] < 700;
																			this.uslovie_text[1] = " 外 交 声 誉 低 于 70.0";
																			this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Torg;
																			this.uslovie_text[2] = " 未 开 始 与 他 们 贸 易";
																			if (this.selected_country == 52)
																			{
																				this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Donat && this.global1.allcountries[this.selected_country].Westalgie == 0;
																				this.uslovie_text[3] = " 未 支 持 恐 怖 分 子";
																				return;
																			}
																		}
																		else
																		{
																			if (this.this_type == 89)
																			{
																				if (this.selected_country == 43)
																				{
																					this.this_opis = " 邀 请 至 经 济 联 盟 注 意 ！ 与 邻 国 贸 易 的 利 益 将 扩 大";
																				}
																				else
																				{
																					this.this_opis = " 邀 请 至 经 济 联 盟";
																				}
																				this.number_uslovie = 4;
																				this.uslovie_bool[0] = !this.global1.allcountries[7].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV;
																				this.uslovie_text[0] = " 苏 联 不 在 经 互 会 内 且 我 们 在 联 盟 内";
																				this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isSEV;
																				this.uslovie_text[1] = " 该 国 不 在 经 互 会 内";
																				this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Torg && this.global1.data[6] < 350;
																				this.uslovie_text[2] = " 贸 易 关 系 已 恢 复 且 外 交 声 誉 低 于 35.0";
																				this.uslovie_bool[3] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																				this.uslovie_text[3] = " 我 们 未 在 整 合 进 欧 共 体";
																				return;
																			}
																			if (this.this_type == 90)
																			{
																				if (this.selected_country == 46 || this.selected_country == 33 || this.selected_country == 22)
																				{
																					this.this_opis = " 邀 请 至 经 济 联 盟 \n 注 意 ！ 该 国 将 被 补 贴";
																				}
																				else
																				{
																					this.this_opis = " 邀 请 至 经 济 联 盟";
																				}
																				this.number_uslovie = 4;
																				this.uslovie_bool[0] = this.global1.allcountries[16].isSEV && this.global1.allcountries[11].isSEV;
																				this.uslovie_text[0] = " 中 国 和 越 南 在 经 济 联 盟 内";
																				this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isSEV && this.global1.allcountries[this.selected_country].Torg;
																				this.uslovie_text[1] = " 他 们 不 在 经 互 会 内 且 我 们 有 贸 易";
																				this.uslovie_bool[2] = this.global1.data[6] >= 450 || this.global1.data[14] <= 3;
																				this.uslovie_text[2] = " 外 交 声 誉 高 于 45 或 国 家 体 制 为 卡 达 尔 主 义 或 更 左";
																				this.uslovie_bool[3] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																				this.uslovie_text[3] = " 未 在 整 合 进 欧 共 体";
																				return;
																			}
																			if (this.this_type == 91)
																			{
																				if (this.global1.data[224] <= 1)
																				{
																					this.this_opis = " 邀 请 至 经 济 联 盟 \n 注 意 ！ 该 国 将 被 补 贴";
																				}
																				else
																				{
																					this.this_opis = " 邀 请 至 经 济 联 盟";
																				}
																				this.number_uslovie = 4;
																				if (this.global1.allcountries[23].Gosstroy != 2)
																				{
																					this.uslovie_bool[0] = this.global1.allcountries[16].isSEV && this.global1.allcountries[11].isSEV;
																					this.uslovie_text[0] = " 中 国 和 越 南 在 经 济 联 盟 内";
																				}
																				else
																				{
																					this.uslovie_bool[0] = this.global1.data[224] > 1;
																					this.uslovie_text[0] = " 曾 多 次 投 资 石 油 发 展";
																				}
																				this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isSEV && this.global1.allcountries[this.selected_country].Torg;
																				this.uslovie_text[1] = " 他 们 不 在 经 互 会 内 且 我 们 有 贸 易";
																				if (this.global1.allcountries[23].Gosstroy != 2)
																				{
																					this.uslovie_bool[2] = this.global1.data[6] >= 450 || this.global1.data[14] <= 3;
																					this.uslovie_text[2] = " 外 交 声 誉 高 于 45 或 国 家 体 制 为 卡 达 尔 主 义 或 更 左";
																				}
																				else
																				{
																					this.uslovie_bool[2] = this.global1.data[6] < 40 || this.global1.data[14] >= 3;
																					this.uslovie_text[2] = " 外 交 声 誉 低 于 40 或 国 家 体 制 为 卡 达 尔 主 义 或 更 右";
																				}
																				this.uslovie_bool[3] = !this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.allcountries[this.global1.data[0]].isSEV;
																				this.uslovie_text[3] = " 未 在 整 合 进 欧 共 体 且 经 济 联 盟 存 在";
																				return;
																			}
																			if (this.this_type == 92)
																			{
																				this.this_opis = " 支 持 也 门 左 翼 组 织";
																				this.number_uslovie = 4;
																				this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Torg;
																				this.uslovie_text[0] = " 贸 易 正 在 进 行 中";
																				this.uslovie_bool[1] = this.global1.data[6] < 750;
																				this.uslovie_text[1] = " 外 交 声 誉 低 于 75.0";
																				this.uslovie_bool[2] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																				this.uslovie_text[2] = " 未 在 整 合 进 欧 共 体";
																				this.uslovie_bool[3] = this.global1.data[227] == 0;
																				this.uslovie_text[3] = " 今 年 未 支 持";
																				return;
																			}
																			if (this.this_type == 93)
																			{
																				this.this_opis = " 支 持 民 主 组 织";
																				this.number_uslovie = 4;
																				this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Torg;
																				this.uslovie_text[0] = " 未 加 强 贸 易 关 系";
																				this.uslovie_bool[1] = this.global1.data[6] < 750 || this.global1.data[14] >= 3;
																				this.uslovie_text[1] = " 外 交 声 誉 低 于 75.0 或 国 家 体 制 为 卡 达 尔 主 义 或 更 右";
																				this.uslovie_bool[2] = this.global1.data[9] >= 50;
																				this.uslovie_text[2] = " 间 谍 网 络 - 5";
																				this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Help;
																				this.uslovie_text[3] = " 今 年 未 支 持";
																				return;
																			}
																			if (this.this_type == 94)
																			{
																				this.this_opis = " 与 国 家 恢 复 法 律 与 秩 序 委 员 会 建 立 联 系";
																				this.number_uslovie = 3;
																				this.uslovie_bool[0] = this.global1.data[6] > 600 || this.global1.data[14] <= 3;
																				this.uslovie_text[0] = " 外 交 声 誉 高 于 60 或 国 家 体 制 为 卡 达 尔 主 义 或 更 左";
																				this.uslovie_bool[1] = this.global1.data[8] >= 50;
																				this.uslovie_text[1] = " 资 金 - 5";
																				this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
																				this.uslovie_text[2] = " 今 年 未 支 持";
																				return;
																			}
																			if (this.this_type == 95)
																			{
																				this.this_opis = " 促 使 军 方 和 反 对 派 起 草 一 部 宪 法";
																				this.number_uslovie = 3;
																				this.uslovie_bool[0] = this.global1.data[230] >= 2;
																				this.uslovie_text[0] = " 在 反 对 派 中 有 很 高 的 影 响 力";
																				this.uslovie_bool[1] = this.global1.data[231] >= 2;
																				this.uslovie_text[1] = " 在 恢 委 会 有 很 高 的 影 响 力";
																				this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].subideology != 9 && !this.global1.event_done[75];
																				this.uslovie_text[2] = " 未 在 谈 判 桌 上 得 到 一 席 之 地";
																				return;
																			}
																			if (this.this_type == 96)
																			{
																				if (this.selected_country == 52)
																				{
																					this.this_opis = " 支 持 库 尔 德 工 人 党 和 反 土 耳 其 游 击 队";
																				}
																				else
																				{
																					this.this_opis = " 支 持 与 以 色 列 作 战 的 激  进 组 织 、 叛 乱 分 子 和 其 他 组 织";
																				}
																				this.number_uslovie = 4;
																				this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Torg;
																				if (this.selected_country == 52)
																				{
																					this.uslovie_text[0] = " 未 建 立 与 土 耳 其 的 经 济 关 系";
																				}
																				else
																				{
																					this.uslovie_text[0] = " 未 建 立 与 以 色 列 的 经 济 关 系";
																				}
																				if ((this.global1.data[0] == 12 || this.global1.data[0] == 10 || this.global1.data[0] == 18) && !this.global1.allcountries[this.global1.data[0]].Vyshi)
																				{
																					this.uslovie_bool[1] = this.global1.science[2];
																					this.uslovie_text[1] = " 国 外 间 谍 网 络 得 到 了 发 展";
																				}
																				else
																				{
																					this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																					this.uslovie_text[1] = " 未 在 整 合 进 欧 共 体";
																				}
																				this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																				this.uslovie_text[1] = " 未 在 整 合 进 欧 共 体";
																				this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
																				this.uslovie_text[2] = " 今 年 未 帮 助";
																				this.uslovie_bool[3] = this.global1.data[9] >= 50;
																				this.uslovie_text[3] = " 间 谍 网 络 - 5";
																				return;
																			}
																			if (this.this_type == 97)
																			{
																				this.this_opis = " 向 亲 南 斯 拉 夫 反 对 派 提 供 财 政 援 助";
																				this.number_uslovie = 3;
																				this.uslovie_bool[0] = this.global1.data[6] < 850;
																				this.uslovie_text[0] = " 外 交 声 誉 低 于 85.0";
																				this.uslovie_bool[1] = this.global1.data[235] != 9;
																				this.uslovie_text[1] = " 政 权 未 倒 台";
																				if (this.global1.data[8] < 30)
																				{
																					this.uslovie_bool[2] = this.global1.data[8] >= 30;
																					this.uslovie_text[2] = " 资 金 - 3";
																					return;
																				}
																				if (!this.global1.allcountries[this.selected_country].Donat)
																				{
																					this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
																					this.uslovie_text[2] = " 未 提 供 财 政 援 助";
																					return;
																				}
																				if (!this.global1.is_konst_max)
																				{
																					this.uslovie_bool[2] = this.global1.is_konst_max;
																					this.uslovie_text[2] = " 有 修 宪 多 数";
																					return;
																				}
																				this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
																				this.uslovie_text[2] = " 等 待 至 明 年";
																				return;
																			}
																			else
																			{
																				if (this.this_type == 98)
																				{
																					if (this.selected_country == 37)
																					{
																						this.this_opis = " 与 以 色 列 国 防 公 司 签 订 军 事 合 同";
																					}
																					else
																					{
																						this.this_opis = " 与 台 湾 国 防 公 司 签 订 军 事 合 同";
																					}
																					this.number_uslovie = 3;
																					this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Torg;
																					this.uslovie_text[0] = " 我 们 有 贸 易";
																					this.uslovie_bool[1] = this.global1.data[8] >= 30;
																					this.uslovie_text[1] = " 资 金: 3.0";
																					if (this.selected_country == 37)
																					{
																						this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
																					}
																					else
																					{
																						this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
																					}
																					this.uslovie_text[2] = " 今 年 未 签 订 任 何 合 同";
																					return;
																				}
																				if (this.this_type == 99)
																				{
																					this.this_opis = " 支 持 \" 意 大 利 和 平 运 动\" ";
																					this.number_uslovie = 4;
																					if (!this.global1.is_konst_max)
																					{
																						this.uslovie_bool[0] = this.global1.is_konst_max;
																						this.uslovie_text[0] = " 有 修 宪 多 数";
																					}
																					else
																					{
																						this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Donat;
																						this.uslovie_text[0] = " 今 年 未 支 持";
																					}
																					this.uslovie_bool[1] = this.global1.data[6] < 490;
																					this.uslovie_text[1] = " 外 交 声 誉 低 于 49";
																					this.uslovie_bool[2] = this.global1.data[8] >= 30;
																					this.uslovie_text[2] = " 资 金: 3.0";
																					this.uslovie_bool[3] = this.global1.allcountries[this.selected_country].Stasi;
																					this.uslovie_text[3] = " 已 扩 大 在 意 大 利 的 间 谍 网 络";
																					return;
																				}
																				if (this.this_type == 100)
																				{
																					if (this.global1.allcountries[46].Westalgie != 2 && ((this.global1.data[20] > 11 && this.global1.data[21] == 1989) || this.global1.data[21] >= 1990))
																					{
																						this.this_opis = " 召 集 人 民 解 放 阵 线 的 残 余 力 量";
																					}
																					else
																					{
																						this.this_opis = " 贿 赂 泰 米 尔 官 员 以 改 善 人 民 解 放 阵 线 的 补 给";
																					}
																					this.number_uslovie = 4;
																					if (this.global1.allcountries[46].Westalgie != 2 && ((this.global1.data[20] > 11 && this.global1.data[21] == 1989) || this.global1.data[21] >= 1990))
																					{
																						this.uslovie_bool[0] = this.global1.allcountries[19].Torg && this.global1.allcountries[16].Torg;
																						this.uslovie_text[0] = " 与 印 度 和 中 国 有 紧 密 关 系";
																					}
																					else
																					{
																						this.uslovie_bool[0] = this.global1.allcountries[19].Torg;
																						this.uslovie_text[0] = " 与 印 度 有 紧 密 关 系";
																					}
																					if (this.global1.allcountries[46].Westalgie != 2 && ((this.global1.data[20] > 11 && this.global1.data[21] == 1989) || this.global1.data[21] >= 1990))
																					{
																						this.uslovie_bool[1] = !this.global1.allcountries[46].Stasi;
																						this.uslovie_text[1] = " 未 召 集";
																					}
																					else
																					{
																						this.uslovie_bool[1] = !this.global1.allcountries[46].Donat;
																						this.uslovie_text[1] = " 未 提 供 帮 助";
																					}
																					if (this.global1.allcountries[46].Westalgie != 2 && ((this.global1.data[20] > 11 && this.global1.data[21] == 1989) || this.global1.data[21] >= 1990))
																					{
																						if (this.global1.allcountries[46].Donat)
																						{
																							this.uslovie_bool[2] = this.global1.data[8] > 30 * (this.global1.data[21] - 1988) && this.global1.data[9] > 30 * (this.global1.data[21] - 1988);
																							this.uslovie_text[2] = " 且 资 金 和 间 谍 多 于 " + (3 * (this.global1.data[21] - 1988)).ToString();
																						}
																						else
																						{
																							this.uslovie_bool[2] = this.global1.data[8] > 40 * (this.global1.data[21] - 1988);
																							this.uslovie_text[2] = " 且 资 金 和 间 谍 多 于 " + (4 * (this.global1.data[21] - 1988)).ToString();
																						}
																					}
																					else
																					{
																						this.uslovie_bool[2] = this.global1.data[8] > 80;
																						this.uslovie_text[2] = " 有 8 资 金";
																					}
																					if (this.global1.allcountries[46].Westalgie != 2 && ((this.global1.data[20] > 11 && this.global1.data[21] == 1989) || this.global1.data[21] >= 1990))
																					{
																						this.uslovie_bool[3] = !this.global1.allcountries[46].Torg && this.global1.allcountries[46].Gosstroy == 1;
																						this.uslovie_text[3] = " 未 开 始 贸 易";
																						return;
																					}
																					this.uslovie_bool[3] = this.global1.data[20] < 11 && this.global1.data[21] == 1989;
																					this.uslovie_text[3] = " 早 于 1989 年 十 一 月";
																					return;
																				}
																				else if (this.this_type == 101)
																				{
																					this.this_opis = " 签 订 有 利 的 石 油 供 应 合 同";
																					this.number_uslovie = 4;
																					this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Torg;
																					this.uslovie_text[0] = " 贸 易 已 建 立";
																					this.uslovie_bool[1] = this.global1.data[8] >= 30;
																					this.uslovie_text[1] = " 资 金: 3.0";
																					this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Money;
																					this.uslovie_text[2] = " 今 年 未 签 订 任 何 合 同";
																					if (this.global1.allcountries[14].Gosstroy != 9)
																					{
																						this.uslovie_bool[3] = this.global1.allcountries[14].Gosstroy != 9;
																						this.uslovie_text[3] = " 侯 赛 因 政 权 已 垮 台";
																						return;
																					}
																					if (this.selected_country == 14)
																					{
																						this.uslovie_bool[3] = this.global1.allcountries[8].Westalgie == 0;
																						this.uslovie_text[3] = " 未 与 伊 朗 签 订 类 似 合 同";
																						return;
																					}
																					if (this.selected_country == 8)
																					{
																						this.uslovie_bool[3] = this.global1.allcountries[14].Westalgie == 0;
																						this.uslovie_text[3] = " 未 与 伊 拉 克 签 订 类 似 合 同";
																						return;
																					}
																				}
																				else if (this.this_type == 102)
																				{
																					this.this_opis = " 就 埃 及 的 经 济 改 革 举 行 会 谈";
																					this.number_uslovie = 4;
																					this.uslovie_bool[0] = this.global1.allcountries[30].isSEV;
																					this.uslovie_text[0] = " 埃 及 在 经 济 联 盟 内";
																					this.uslovie_bool[1] = this.global1.data[8] >= 50;
																					this.uslovie_text[1] = " 资 金: 5.0";
																					this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
																					this.uslovie_text[2] = " 未 举 行 会 谈";
																					if (this.global1.allcountries[14].Gosstroy == 9)
																					{
																						this.uslovie_bool[3] = this.global1.allcountries[14].Gosstroy != 9 || this.global1.allcountries[14].subideology == 2;
																						this.uslovie_text[3] = " 侯 赛 因 政 权 已 垮 台";
																						return;
																					}
																					this.uslovie_bool[3] = this.global1.data[10] <= 400;
																					this.uslovie_text[3] = " 北 约 威 胁 小 于 40.0";
																					return;
																				}
																				else
																				{
																					if (this.this_type == 103)
																					{
																						this.this_opis = " 切 断 与 台 北 政 府 的 一 切 关 系";
																						this.number_uslovie = 2;
																						this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Torg;
																						this.uslovie_text[0] = " 未 切 断 关 系";
																						this.uslovie_bool[1] = this.global1.allcountries[16].Torg;
																						this.uslovie_text[1] = " 正 与 中 华 人 民 共 和 国 贸 易";
																						return;
																					}
																					if (this.this_type == 104)
																					{
																						if (this.global1.allcountries[this.selected_country].Westalgie > 25)
																						{
																							this.this_opis = string.Concat(new string[]
																							{
																								" 增 加 对 右 翼 势 力 的 援 助 ( 左 翼: ",
																								(this.global1.allcountries[this.selected_country].Westalgie / 10).ToString(),
																								".",
																								Mathf.Abs(this.global1.allcountries[this.selected_country].Westalgie % 10).ToString(),
																								")"
																							});
																						}
																						else
																						{
																							this.this_opis = string.Concat(new string[]
																							{
																								" 建 立 亲 美 右 翼 组 织 ( 左 翼: ",
																								(this.global1.allcountries[this.selected_country].Westalgie / 10).ToString(),
																								".",
																								Mathf.Abs(this.global1.allcountries[this.selected_country].Westalgie % 10).ToString(),
																								")"
																							});
																						}
																						this.number_uslovie = 3;
																						this.uslovie_bool[0] = this.global1.data[8] >= 35;
																						this.uslovie_text[0] = " 资 金: 3.5";
																						this.uslovie_bool[1] = this.global1.data[9] >= 50;
																						this.uslovie_text[1] = " 空 余 间 谍 网 络: 5.0";
																						this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Westalgie > 0 && this.global1.allcountries[this.selected_country].Westalgie < 1000;
																						this.uslovie_text[2] = "1-99";
																						return;
																					}
																					if (this.this_type == 105)
																					{
																						if (this.global1.allcountries[this.selected_country].Westalgie <= 975)
																						{
																							this.this_opis = string.Concat(new string[]
																							{
																								" 增 加 对 左 翼 势 力 的 援 助 ( 左 翼: ",
																								(this.global1.allcountries[this.selected_country].Westalgie / 10).ToString(),
																								".",
																								Mathf.Abs(this.global1.allcountries[this.selected_country].Westalgie % 10).ToString(),
																								")"
																							});
																						}
																						else
																						{
																							this.this_opis = string.Concat(new string[]
																							{
																								" 建 立 反 美 左 翼 组 织 ( 左 翼: ",
																								(this.global1.allcountries[this.selected_country].Westalgie / 10).ToString(),
																								".",
																								Mathf.Abs(this.global1.allcountries[this.selected_country].Westalgie % 10).ToString(),
																								")"
																							});
																						}
																						this.number_uslovie = 3;
																						this.uslovie_bool[0] = this.global1.data[8] >= 35;
																						this.uslovie_text[0] = " 资 金: 3.5";
																						this.uslovie_bool[1] = this.global1.data[9] >= 50;
																						this.uslovie_text[1] = " 空 余 间 谍 网 络: 5.0";
																						this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Westalgie > 0 && this.global1.allcountries[this.selected_country].Westalgie < 1000;
																						this.uslovie_text[2] = " 他 们 存 活 且 未 建 立";
																						return;
																					}
																					if (this.this_type == 106)
																					{
																						this.this_opis = string.Concat(new string[]
																						{
																							" 派 出 一 支 运 送 大 量 人 道 主 义 援 助 物 资 的 船 队 ( 左 翼: ",
																							(this.global1.allcountries[this.selected_country].Westalgie / 10).ToString(),
																							".",
																							Mathf.Abs(this.global1.allcountries[this.selected_country].Westalgie % 10).ToString(),
																							")"
																						});
																						this.number_uslovie = 2;
																						this.uslovie_bool[0] = this.global1.data[8] >= 80;
																						this.uslovie_text[0] = " 资 金: 8";
																						this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Westalgie > 0 && this.global1.allcountries[this.selected_country].Westalgie < 1000;
																						this.uslovie_text[1] = "1-99";
																						return;
																					}
																					if (this.this_type == 107)
																					{
																						this.this_opis = " 与 台 北 建 立 联 系";
																						this.number_uslovie = 3;
																						this.uslovie_bool[0] = this.global1.data[9] >= 15;
																						this.uslovie_text[0] = " 空 余 间 谍 网 络: 1.5";
																						this.uslovie_bool[1] = !this.global1.allcountries[16].Torg;
																						this.uslovie_text[1] = " 未 与 中 华 人 民 共 和 国 贸 易";
																						this.uslovie_bool[2] = this.global1.data[10] <= 400;
																						this.uslovie_text[2] = " 北 约 威 胁 低 于 40.0";
																						return;
																					}
																					if (this.this_type == 108)
																					{
																						this.this_opis = " 在 台 北 开 设 一 个 贸 易 局";
																						this.number_uslovie = 2;
																						this.uslovie_bool[0] = this.global1.data[8] >= 30;
																						this.uslovie_text[0] = " 资 金: 3";
																						this.uslovie_bool[1] = this.global1.data[27] > 0 || this.global1.data[28] > 0;
																						this.uslovie_text[1] = " 至 少 一 个 开 放 或 付 费 边 境";
																						return;
																					}
																					if (this.this_type == 109)
																					{
																						this.this_opis = " 与 台 湾 电 子 制 造 商 谈 判 合 同";
																						this.number_uslovie = 4;
																						this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Torg;
																						this.uslovie_text[0] = " 已 建 立 贸 易";
																						this.uslovie_bool[1] = this.global1.data[8] >= 30;
																						this.uslovie_text[1] = " 资 金: 3.0";
																						this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Money;
																						this.uslovie_text[2] = " 未 与 伊 朗 签 订 类 似 合 同";
																						this.uslovie_bool[3] = this.global1.data[10] <= 300 && (this.global1.allcountries[0].Money || this.global1.allcountries[44].Money || this.global1.allcountries[48].Money || this.global1.allcountries[21].Money || this.global1.allcountries[this.global1.data[0]].Vyshi);
																						this.uslovie_text[3] = " 在 整 合 进 欧 共 体 或 接 受 投 资";
																						return;
																					}
																					if (this.this_type == 110)
																					{
																						this.this_opis = " 与 左 翼 议 会 反 对 派 取 得 联 系";
																						this.number_uslovie = 4;
																						this.uslovie_bool[0] = this.global1.data[6] < 800;
																						this.uslovie_text[0] = " 外 交 声 誉 低 于 80";
																						this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																						this.uslovie_text[1] = " 未 在 整 合 进 欧 共 体";
																						this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
																						this.uslovie_text[2] = " 未 取 得 联 系";
																						this.uslovie_bool[3] = this.global1.data[10] < 150;
																						this.uslovie_text[3] = " 北 约 威 胁 低 于 15";
																						return;
																					}
																					if (this.this_type == 111)
																					{
																						if (this.global1.data[239] == 4 || this.global1.data[239] == 6)
																						{
																							this.this_opis = " 帮 助 日 本 共 产 党 团 结 反 对 派";
																						}
																						else if (this.global1.data[239] == 5)
																						{
																							this.this_opis = " 帮 助 日 本 公 明 党 团 结 反 对 派";
																						}
																						else if (this.global1.data[239] == 3)
																						{
																							this.this_opis = " 帮 助 日 本 社 会 党 团 结 反 对 派";
																						}
																						this.this_opis += "  ( 每 次 支 持 都 会 影 响 选 举 结 果)";
																						this.number_uslovie = 4;
																						this.uslovie_bool[0] = this.global1.data[9] >= 25;
																						this.uslovie_text[0] = " 空 余 间 谍 网 络: 2.5";
																						this.uslovie_bool[1] = this.global1.data[8] >= 30;
																						this.uslovie_text[1] = " 资 金: 3.0";
																						this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
																						this.uslovie_text[2] = " 今 年 未 支 持";
																						this.uslovie_bool[3] = this.global1.data[10] <= 500;
																						this.uslovie_text[3] = " 北 约 威 胁 低 于 50.0";
																						return;
																					}
																					if (this.this_type == 112)
																					{
																						this.this_opis = " 帮 助 巩 固 丹 尼 尔 · 奥 尔 特 加 政 权";
																						this.number_uslovie = 4;
																						this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Torg && this.global1.allcountries[47].Gosstroy == 1;
																						this.uslovie_text[0] = " 与 桑 地 诺 政 府 建 立 贸 易 关 系";
																						if ((this.global1.data[0] == 12 || this.global1.data[0] == 10 || this.global1.data[0] == 18) && !this.global1.allcountries[this.global1.data[0]].Vyshi)
																						{
																							this.uslovie_bool[1] = this.global1.science[2];
																							this.uslovie_text[1] = " 已 发 展 国 外 网 络";
																						}
																						else
																						{
																							this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																							this.uslovie_text[1] = " 未 在 整 合 进 欧 共 体";
																						}
																						this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
																						this.uslovie_text[2] = " 今 年 未 支 持";
																						this.uslovie_bool[3] = this.global1.data[8] >= 30 && this.global1.data[9] >= 30;
																						this.uslovie_text[3] = " 空 余 间 谍 网 络 及 资 金: 3";
																						return;
																					}
																					if (this.this_type == 113)
																					{
																						this.this_opis = " 在 苏 联 支 持 普 里 马 科 夫 对 中 东 的 态 度";
																						this.number_uslovie = 4;
																						this.uslovie_bool[0] = this.global1.allcountries[7].Westalgie >= 8;
																						this.uslovie_text[0] = " 曾 帮 助 加 强 “ 联 盟 ” 派 的 地 位 超 过7 次";
																						if ((this.global1.data[0] == 12 || this.global1.data[0] == 10 || this.global1.data[0] == 18) && this.global1.data[9] > 30)
																						{
																							this.uslovie_bool[1] = this.global1.science[2];
																							this.uslovie_text[1] = " 有 发 展 良 好 的 海 外 网 络 且 间 谍 多 于 3.0";
																						}
																						else
																						{
																							this.uslovie_bool[1] = this.global1.data[9] > 30;
																							this.uslovie_text[1] = " 空 余 间 谍 网 络: 3.0";
																						}
																						this.uslovie_bool[2] = this.global1.data[2] > 750 && this.global1.data[242] != 1;
																						this.uslovie_text[2] = " 与 苏 联 的 关 系 高 于 75.0, 未 提 供 协 助";
																						this.uslovie_bool[3] = this.global1.data[20] < 8 && this.global1.data[21] == 1990;
																						this.uslovie_text[3] = "1990 年 的 前 半 年";
																						return;
																					}
																					if (this.this_type == 114)
																					{
																						this.this_opis = " 向 奥 地 利 自 由 党 提 供 支 持";
																						this.number_uslovie = 3;
																						this.uslovie_bool[0] = this.global1.data[8] >= 30 && this.global1.data[9] >= 30;
																						this.uslovie_text[0] = " 有 发 展 良 好 的 海 外 网 络 且 间 谍 多 于 3.0";
																						this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																						this.uslovie_text[1] = " 未 在 整 合 进 欧 共 体";
																						this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
																						this.uslovie_text[2] = " 未 提 供 支 持";
																						return;
																					}
																					if (this.this_type == 115)
																					{
																						this.this_opis = " 向 奥 地 利 自 由 党 内 的 民 族 主 义 者 提 供 支 持";
																						this.number_uslovie = 3;
																						this.uslovie_bool[0] = this.global1.data[8] >= 50;
																						this.uslovie_text[0] = " 空 余 资 金: 5.0";
																						this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																						this.uslovie_text[1] = " 未 在 整 合 进 欧 共 体";
																						this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
																						this.uslovie_text[2] = " 未 提 供 支 持";
																						return;
																					}
																					if (this.this_type == 116)
																					{
																						this.this_opis = " 向 奥 地 利 自 由 党 内 的 自 由 派 提 供 支 持";
																						this.number_uslovie = 3;
																						this.uslovie_bool[0] = this.global1.data[8] >= 50;
																						this.uslovie_text[0] = " 空 余 资 金: 5.0";
																						this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																						this.uslovie_text[1] = " 未 在 整 合 进 欧 共 体";
																						this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Money;
																						this.uslovie_text[2] = " 未 提 供 支 持";
																						return;
																					}
																					if (this.this_type == 117)
																					{
																						this.this_opis = " 向 民 族 主 义 者 \" 争 取 权 利 和 自 由 运 动\" 提 供 支 持";
																						this.number_uslovie = 3;
																						this.uslovie_bool[0] = this.global1.data[9] >= 50;
																						this.uslovie_text[0] = " 空 余 间 谍: 5.0";
																						this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																						this.uslovie_text[1] = " 未 在 整 合 进 欧 共 体";
																						this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Stasi;
																						this.uslovie_text[2] = " 未 提 供 支 持";
																						return;
																					}
																					if (this.this_type == 118)
																					{
																						if (this.global1.allcountries[27].Help)
																						{
																							this.this_opis = " 在 奥 地 利 人 民 党 和 奥 地 利 自 由 党 之 间 进 行 谈 判";
																						}
																						else if ((this.global1.data[20] > 5 && this.global1.data[21] >= 1991) || this.global1.data[21] > 1992)
																						{
																							this.this_opis = " 在 奥 地 利 社 会 民 主 党 和 奥 地 利 自 由 党 之 间 进 行 谈 判";
																						}
																						else
																						{
																							this.this_opis = " 在 奥 地 利 社 会 党 和 奥 地 利 自 由 党 之 间 进 行 谈 判";
																						}
																						this.number_uslovie = 4;
																						this.uslovie_bool[0] = this.global1.data[8] >= 30 && this.global1.data[9] >= 30;
																						this.uslovie_text[0] = " 有 发 展 良 好 的 海 外 网 络 且 间 谍 多 于 3.0";
																						this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																						this.uslovie_text[1] = " 未 在 整 合 进 欧 共 体";
																						this.uslovie_bool[2] = this.global1.allcountries[27].Westalgie < 2;
																						this.uslovie_text[2] = " 未 进 行 谈 判";
																						this.uslovie_bool[3] = this.global1.data[10] < 350;
																						this.uslovie_text[3] = " 北 约 威 胁 小 于 35";
																						return;
																					}
																					if (this.this_type == 119)
																					{
																						this.this_opis = " 就 自 由 改 革 的 实 施 进 行 谈 判";
																						this.number_uslovie = 3;
																						this.uslovie_bool[0] = this.global1.data[10] < 600;
																						this.uslovie_text[0] = " 北 约 威 胁 小 于 60.0";
																						this.uslovie_bool[1] = this.global1.data[15] < 9 || this.global1.data[16] < 13 || this.global1.data[17] < 17;
																						this.uslovie_text[1] = " 政 策 不 是 自 由 派";
																						this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
																						this.uslovie_text[2] = " 每 六 个 月 一 次";
																						return;
																					}
																					if (this.this_type == 120)
																					{
																						this.this_opis = " 进 入 活 跃 贸 易 阶 段";
																						this.number_uslovie = 4;
																						this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Torg;
																						this.uslovie_text[0] = " 未 开 始 与 他 们 贸 易";
																						if (this.global1.allcountries[7].isSEV)
																						{
																							this.uslovie_bool[1] = !this.global1.allcountries[7].isSEV;
																							this.uslovie_text[1] = " 苏 联 不 在 经 互 会 内";
																						}
																						else if ((this.global1.eventVariantChosen[76] == 1 || this.global1.eventVariantChosen[76] == 2) && this.global1.allcountries[this.selected_country].Gosstroy == this.global1.allcountries[this.global1.data[0]].Gosstroy)
																						{
																							this.uslovie_bool[1] = (this.global1.eventVariantChosen[76] == 1 || this.global1.eventVariantChosen[76] == 2) && this.global1.allcountries[this.selected_country].Gosstroy == this.global1.allcountries[this.global1.data[0]].Gosstroy;
																							this.uslovie_text[1] = " 为 他 们 上 台 提 供 了 帮 助 ， 相 同 的 意 识 形 态";
																						}
																						else if (this.global1.allcountries[this.selected_country].Gosstroy == 1)
																						{
																							this.uslovie_bool[1] = this.global1.data[6] < 800;
																							this.uslovie_text[1] = " 外 交 声 誉 低 于 80";
																						}
																						else if (this.global1.allcountries[this.selected_country].Gosstroy == 2)
																						{
																							this.uslovie_bool[1] = this.global1.data[6] < 500;
																							this.uslovie_text[1] = " 外 交 声 誉 低 于 50";
																						}
																						else
																						{
																							this.uslovie_bool[1] = this.global1.data[6] > 600;
																							this.uslovie_text[1] = " 外 交 声 誉 高 于 60";
																						}
																						this.uslovie_bool[2] = this.global1.data[8] >= 30;
																						this.uslovie_text[2] = " 资 金: 3";
																						this.uslovie_bool[3] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																						this.uslovie_text[3] = " 未 在 整 合 进 欧 共 体";
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
							}
						}
					}
				}
			}
			else
			{
				if (this.this_type == 1)
				{
					this.this_opis = "Пригласить иностранных инвесторов";
					this.number_uslovie = 3;
					this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Money;
					this.uslovie_text[0] = "Инвесторы не приглашены";
					if (this.global1.allcountries[21].Gosstroy == 2)
					{
						this.uslovie_bool[1] = this.global1.data[16] >= 12;
						this.uslovie_text[1] = "Экономика с рынком";
					}
					else
					{
						this.uslovie_bool[1] = this.global1.data[16] >= 12;
						this.uslovie_text[1] = "Не плановая экономика/автоматизация";
					}
					this.uslovie_bool[2] = this.global1.data[6] < 800 - this.global1.allcountries[21].Gosstroy * 200;
					this.uslovie_text[2] = "Дипломатическая репутация меньше " + (80 - this.global1.allcountries[21].Gosstroy * 20).ToString();
					return;
				}
				if (this.this_type == 2)
				{
					this.this_opis = "Договор о дружбе с Францией";
					this.number_uslovie = 2;
					this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Torg;
					this.uslovie_text[0] = "Договор не подписан";
					if (this.global1.allcountries[21].Gosstroy != 2)
					{
						this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.data[31] >= 700;
						this.uslovie_text[1] = "Национализм и не евроинтегрируемся";
						return;
					}
					if (this.global1.allcountries[7].isSEV)
					{
						this.uslovie_bool[1] = this.global1.data[6] < 800;
						this.uslovie_text[1] = "Дипломатическая репутация меньше 80";
						return;
					}
					this.uslovie_bool[1] = this.global1.data[6] < 490;
					this.uslovie_text[1] = "Дипломатическая репутация меньше 49";
					return;
				}
				else
				{
					if (this.this_type == 3)
					{
						this.this_opis = "Войти в сообщество по интеграции в ЕЭС";
						this.number_uslovie = 4;
						this.uslovie_bool[0] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
						this.uslovie_text[0] = "Не интегрируемся";
						if (this.global1.data[14] >= 4 && this.global1.data[16] >= 13)
						{
							this.uslovie_bool[1] = this.global1.data[6] < 600;
							this.uslovie_text[1] = "Дипломатическая репутация меньше 60";
						}
						else
						{
							this.uslovie_bool[1] = this.global1.data[6] < 400;
							this.uslovie_text[1] = "Дипломатическая репутация меньше 40";
						}
						this.uslovie_bool[2] = !this.global1.allcountries[this.global1.data[0]].isOVD;
						this.uslovie_text[2] = "Не состоять в ОВД";
						this.uslovie_bool[3] = this.global1.data[16] > 11;
						this.uslovie_text[3] = "Не плановая экономика/не автоматизация";
						return;
					}
					if (this.this_type == 4)
					{
						this.this_opis = "Присоединиться к международному эмбарго";
						this.number_uslovie = 4;
						this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Torg && !this.global1.allcountries[14].isSEV;
						this.uslovie_text[0] = "Не углубляли торговлю";
						this.uslovie_bool[1] = this.global1.data[6] < 800;
						this.uslovie_text[1] = "Дипломатическая репутация меньше 80";
						this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
						this.uslovie_text[2] = "Нет эмбарго";
						this.uslovie_bool[3] = this.global1.data[32] == 1;
						this.uslovie_text[3] = "Введены международные санкции";
						return;
					}
					if (this.this_type == 5)
					{
						this.this_opis = "Углубить развитие торговых отношений";
						this.number_uslovie = 4;
						this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Torg;
						this.uslovie_text[0] = "Не углубляли торговлю";
						this.uslovie_bool[1] = this.global1.data[6] > 600;
						this.uslovie_text[1] = "Дипломатическая репутация выше 60";
						this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help && !this.global1.allcountries[8].Torg;
						this.uslovie_text[2] = "Нет эмбарго и дружбы с Ираном";
						this.uslovie_bool[3] = this.global1.data[32] == 1;
						this.uslovie_text[3] = "Введены международные санкции";
						return;
					}
					if (this.this_type == 6 && !this.global1.allcountries[this.selected_country].Donat)
					{
						this.this_opis = "Признать ливийские претензии в Чаде и оказать помощь вооружением";
						this.number_uslovie = 3;
						this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Donat;
						this.uslovie_text[0] = "Не поддержали";
						this.uslovie_bool[1] = this.global1.data[6] > 650;
						this.uslovie_text[1] = "Дипломатическая репутация выше 65";
						this.uslovie_bool[2] = this.global1.data[9] >= 10;
						this.uslovie_text[2] = "Агентурных сетей: 1.0";
						return;
					}
					if (this.this_type == 6 && this.global1.allcountries[this.selected_country].Donat)
					{
						this.this_opis = "Предоставить пути по обходу санкций для ливийской экономики";
						this.number_uslovie = 4;
						this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Money || !this.global1.allcountries[this.selected_country].Torg;
						this.uslovie_text[0] = "Не предоставили";
						this.uslovie_bool[1] = this.global1.data[6] > 650;
						this.uslovie_text[1] = "Дипломатическая репутация выше 65";
						this.uslovie_bool[2] = this.global1.data[9] >= 10;
						this.uslovie_text[2] = "Агентурных сетей: 5.0";
						this.uslovie_bool[3] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
						this.uslovie_text[3] = "Не интегрируемся с ЕЭС";
						return;
					}
					if (this.this_type == 7 && !this.global1.allcountries[this.selected_country].Stasi)
					{
						this.this_opis = "Положить деньги на счета сторонников реформ, чтобы те отказались от своей позиции";
						this.number_uslovie = 3;
						this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
						this.uslovie_text[0] = "Не клали денег";
						this.uslovie_bool[1] = this.global1.data[6] > 600;
						this.uslovie_text[1] = "Дипломатическая репутация выше 60";
						this.uslovie_bool[2] = this.global1.data[8] >= 10;
						this.uslovie_text[2] = "Денег в бюджете: 1.0";
						return;
					}
					if (this.this_type == 7 && this.global1.allcountries[this.selected_country].Stasi)
					{
						if (this.global1.allcountries[this.selected_country].Gosstroy != 0)
						{
							this.this_opis = "Подтолкнуть на социалистический путь развития и начать торговлю";
						}
						else
						{
							this.this_opis = "Возобновить торговлю";
						}
						this.number_uslovie = 3;
						this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Gosstroy != 0 || !this.global1.allcountries[this.selected_country].Torg;
						this.uslovie_text[0] = "Ещё нет";
						this.uslovie_bool[1] = this.global1.data[6] >= 650;
						this.uslovie_text[1] = "Дипломатическая репутация выше 65";
						this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Donat && this.global1.allcountries[this.selected_country].Stasi;
						this.uslovie_text[2] = "Поддержать претензии Ливии в Чаде";
						return;
					}
					if (this.this_type == 8)
					{
						this.this_opis = "Наладить чрезвычайный канал поставок нефти";
						this.number_uslovie = 3;
						this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Gosstroy == 0;
						this.uslovie_text[0] = "Вмешались во внутрненнюю политику Каддафи";
						this.uslovie_bool[1] = this.global1.data[6] > 600;
						this.uslovie_text[1] = "Дипломатическая репутация выше 60";
						this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
						this.uslovie_text[2] = "Не наладили поставки";
						return;
					}
					if (this.this_type == 9)
					{
						this.this_opis = "Оказать продовольственную помощь";
						this.number_uslovie = 2;
						if (!this.global1.allcountries[this.selected_country].Donat)
						{
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Donat;
							this.uslovie_text[0] = "Не направили продовольствие";
						}
						else if (!this.global1.is_konst_max)
						{
							this.uslovie_bool[0] = this.global1.is_konst_max;
							this.uslovie_text[0] = "Есть конституционное большинство";
						}
						else
						{
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Donat;
							this.uslovie_text[0] = "Подождите до нового года";
						}
						this.uslovie_bool[1] = this.global1.data[6] > 590;
						this.uslovie_text[1] = "Дипломатическая репутация выше 59";
						return;
					}
					if (this.this_type == 10)
					{
						this.this_opis = "Оказать военную помощь";
						this.number_uslovie = 3;
						if (!this.global1.allcountries[this.selected_country].Stasi)
						{
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
							this.uslovie_text[0] = "Не оказали военную помощь";
						}
						else if (!this.global1.is_konst_max)
						{
							this.uslovie_bool[0] = this.global1.is_konst_max;
							this.uslovie_text[0] = "Есть конституционное большинство";
						}
						else
						{
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
							this.uslovie_text[0] = "Подождите до нового года";
						}
						this.uslovie_bool[1] = this.global1.data[6] > 790;
						this.uslovie_text[1] = "Дипломатическая репутация выше 79";
						this.uslovie_bool[2] = this.global1.data[9] >= 10;
						this.uslovie_text[2] = "Есть свободные агентурные сети";
						return;
					}
					if (this.this_type == 11)
					{
						if (!this.global1.event_done[58] || this.global1.eventVariantChosen[58] != 0)
						{
							this.this_opis = "Оказать помощь RAF";
						}
						else
						{
							this.this_opis = "Сплотить и поддержать FAP, DA и NAF";
						}
						this.number_uslovie = 3;
						if (!this.global1.allcountries[this.selected_country].Stasi)
						{
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
							this.uslovie_text[0] = "Не оказали помощь";
						}
						else if (!this.global1.is_konst_max)
						{
							this.uslovie_bool[0] = this.global1.is_konst_max;
							this.uslovie_text[0] = "Есть конституционное большинство";
						}
						else
						{
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
							this.uslovie_text[0] = "Подождите до нового года";
						}
						this.uslovie_bool[1] = this.global1.data[6] > 790;
						this.uslovie_text[1] = "Дипломатическая репутация выше 79";
						this.uslovie_bool[2] = this.global1.data[9] >= 10;
						this.uslovie_text[2] = "Есть свободные агентурные сети";
						return;
					}
					if (this.this_type == 12)
					{
						this.this_opis = "Начать антивоенную кампанию через \"Генералы за мир\" ";
						this.number_uslovie = 4;
						if (!this.global1.allcountries[this.selected_country].Help)
						{
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Help;
							this.uslovie_text[0] = "Не начали кампанию";
						}
						else if (!this.global1.is_konst_max)
						{
							this.uslovie_bool[0] = this.global1.is_konst_max;
							this.uslovie_text[0] = "Есть конституционное большинство";
						}
						else
						{
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Help;
							this.uslovie_text[0] = "Подождите до нового года";
						}
						this.uslovie_bool[1] = this.global1.data[6] > 390;
						this.uslovie_text[1] = "Дипломатическая репутация выше 39";
						this.uslovie_bool[2] = this.global1.data[9] >= 10;
						this.uslovie_text[2] = "Есть свободные агентурные сети";
						if (this.global1.data[0] != 1)
						{
							this.uslovie_bool[3] = this.global1.data[233] == 1;
							this.uslovie_text[3] = "Помогли странам соцлагеря";
							return;
						}
						this.uslovie_bool[3] = this.global1.data[0] == 1;
						this.uslovie_text[3] = "Германская Демократическая Республика";
						return;
					}
					else
					{
						if (this.this_type == 13)
						{
							this.this_opis = "Оказать гуманитарную помощь";
							this.number_uslovie = 2;
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Donat;
							this.uslovie_text[0] = "Не оказали гуманитарную помощь  в этом году";
							this.uslovie_bool[1] = this.global1.data[6] > 190;
							this.uslovie_text[1] = "Дипломатическая репутация выше 19";
							return;
						}
						if (this.this_type == 14)
						{
							this.this_opis = "Оказать помощь Милошевичу";
							this.number_uslovie = 4;
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi && !this.global1.allcountries[this.selected_country].Help;
							this.uslovie_text[0] = "Не оказали военную помощь в этом году";
							this.uslovie_bool[1] = this.global1.data[6] > 390;
							this.uslovie_text[1] = "Дипломатическая репутация выше 39";
							this.uslovie_bool[2] = this.global1.data[9] >= 10;
							this.uslovie_text[2] = "Есть свободные агентурные сети";
							this.uslovie_bool[3] = this.global1.allcountries[this.selected_country].Gosstroy >= 2;
							this.uslovie_text[3] = "На выборах в Югославии победили националисты";
							return;
						}
						if (this.this_type == 51)
						{
							if (this.global1.allcountries[this.selected_country].isSEV)
							{
								this.this_opis = "Подписать договор о военной взаимопомощи";
							}
							else
							{
								this.this_opis = "Подписать договор об экономической взаимопомощи";
							}
							this.number_uslovie = 4;
							if (this.global1.data[59] != 2 || this.global1.data[0] != 6)
							{
								this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Stasi;
								this.uslovie_text[0] = "Милошевичу оказана поддержка";
							}
							else
							{
								this.uslovie_bool[0] = this.global1.data[59] != 2;
								this.uslovie_text[0] = "Македония в Югославии";
							}
							if (this.global1.allcountries[this.selected_country].isSEV)
							{
								this.uslovie_bool[1] = this.global1.allcountries[this.global1.data[0]].isOVD && !this.global1.allcountries[this.selected_country].isOVD;
							}
							else
							{
								this.uslovie_bool[1] = this.global1.allcountries[this.global1.data[0]].isSEV && !this.global1.allcountries[this.selected_country].isSEV;
							}
							this.uslovie_text[1] = "Мы состоим в альянсе";
							this.uslovie_bool[2] = this.global1.data[9] >= 50;
							this.uslovie_text[2] = "Есть пять агентурных сетей";
							if (this.global1.allcountries[this.selected_country].isSEV)
							{
								this.uslovie_bool[3] = !this.global1.allcountries[7].isOVD || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy <= 0);
							}
							else
							{
								this.uslovie_bool[3] = !this.global1.allcountries[7].isSEV || (this.global1.is_gkchp && this.global1.allcountries[7].Gosstroy <= 0);
							}
							this.uslovie_text[3] = "Советский Союз не в альянсе или победил Алкснис";
							return;
						}
						if (this.this_type == 15)
						{
							this.this_opis = "Оказать помощь сепаратистам";
							this.number_uslovie = 4;
							this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Help && !this.global1.allcountries[this.selected_country].Stasi;
							this.uslovie_text[0] = "Не оказали военную помощь";
							this.uslovie_bool[1] = this.global1.data[6] < 800;
							this.uslovie_text[1] = "Дипломатическая репутация меньше 80";
							this.uslovie_bool[2] = this.global1.data[9] >= 10;
							this.uslovie_text[2] = "Есть свободные агентурные сети";
							this.uslovie_bool[3] = this.global1.allcountries[this.selected_country].Gosstroy >= 2;
							this.uslovie_text[3] = "На выборах в Югославии победили националисты";
							return;
						}
						if (this.this_type == 44)
						{
							this.this_opis = "Устранить Дэн Сяопина, позволив консерваторам удержать власть";
							this.number_uslovie = 4;
							if (this.global1.data[6] >= 800)
							{
								this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Torg;
								this.uslovie_text[0] = "Наладили торговлю";
							}
							else
							{
								this.uslovie_bool[0] = this.global1.data[6] >= 800;
								this.uslovie_text[0] = "Дипломатическая репутация больше 80";
							}
							this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Gosstroy == 9;
							this.uslovie_text[1] = "Оппозиция в Китае подавлена";
							this.uslovie_bool[2] = this.global1.data[9] >= 100 && this.global1.data[8] >= 100;
							this.uslovie_text[2] = "Свободных агентурных сетей 10 (и денег тоже)";
							if (this.global1.data[21] >= 1991 && (this.global1.data[0] == 12 || this.global1.data[0] == 10 || this.global1.data[0] == 18))
							{
								this.uslovie_bool[3] = this.global1.science[2];
								this.uslovie_text[3] = "Развита зарубежная сеть";
								return;
							}
							if (this.global1.data[21] >= 1991)
							{
								this.uslovie_bool[3] = this.global1.science[2];
								this.uslovie_text[3] = "Есть СОРМ";
								return;
							}
							if (this.global1.data[21] >= 1991)
							{
								this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Stasi;
								this.uslovie_text[3] = "Не устранили Сяопина";
								return;
							}
							if (!this.global1.is_konst_max)
							{
								this.uslovie_bool[3] = this.global1.is_konst_max;
								this.uslovie_text[3] = "Есть конституционное большинство";
								return;
							}
							this.uslovie_bool[3] = this.global1.data[21] >= 1991;
							this.uslovie_text[3] = "Не раньше 1991 года";
							return;
						}
						else
						{
							if (this.this_type == 16)
							{
								this.this_opis = "Наладить дипотношения";
								this.number_uslovie = 3;
								this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Donat && !this.global1.allcountries[this.selected_country].Torg;
								this.uslovie_text[0] = "Не наладили отношения";
								if (this.global1.allcountries[this.selected_country].Gosstroy == 1)
								{
									this.uslovie_bool[1] = this.global1.data[6] < 880;
									this.uslovie_text[1] = "Дипломатическая репутация меньше 88";
								}
								else if (this.global1.allcountries[this.selected_country].Gosstroy == 2)
								{
									this.uslovie_bool[1] = this.global1.data[6] < 700;
									this.uslovie_text[1] = "Дипломатическая репутация меньше 70";
								}
								else if (this.global1.allcountries[this.selected_country].Gosstroy == 0 || this.global1.allcountries[this.selected_country].Gosstroy == 9)
								{
									this.uslovie_bool[1] = this.global1.data[6] > 600;
									this.uslovie_text[1] = "Дипломатическая репутация больше 60";
								}
								this.uslovie_bool[2] = !this.global1.allcountries[38].Help;
								this.uslovie_text[2] = "Китай не был осуждён";
								return;
							}
							if (this.this_type == 17)
							{
								this.this_opis = "Перейти в фазу активной торговли";
								if (this.selected_country == 38)
								{
									this.number_uslovie = 4;
								}
								else
								{
									this.number_uslovie = 3;
								}
								this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Torg;
								this.uslovie_text[0] = "Не наладили торговлю";
								if (this.global1.allcountries[this.selected_country].Stasi)
								{
									this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].Stasi;
									this.uslovie_text[1] = "Не разорвали связи";
								}
								else if (this.selected_country == 38)
								{
									this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Help;
									this.uslovie_text[1] = "Китай был осуждён";
								}
								else
								{
									this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Donat || this.global1.allcountries[this.selected_country].Help;
									this.uslovie_text[1] = "Наладили отношения";
								}
								if (this.selected_country == 38)
								{
									this.uslovie_bool[2] = this.global1.data[10] <= 300;
									this.uslovie_text[2] = "Угроза НАТО меньше 30.0";
								}
								else if (this.global1.allcountries[this.selected_country].Gosstroy == 1)
								{
									this.uslovie_bool[2] = this.global1.data[6] < 880;
									this.uslovie_text[2] = "Дипломатическая репутация меньше 88";
								}
								else if (this.global1.allcountries[this.selected_country].Gosstroy == 2)
								{
									this.uslovie_bool[2] = this.global1.data[6] < 500;
									this.uslovie_text[2] = "Дипломатическая репутация меньше 50";
								}
								else if (this.global1.allcountries[this.selected_country].Gosstroy == 0)
								{
									this.uslovie_bool[2] = this.global1.data[6] > 600;
									this.uslovie_text[2] = "Дипломатическая репутация больше 60";
								}
								else if (this.global1.allcountries[this.selected_country].Gosstroy == 9)
								{
									this.uslovie_bool[2] = this.global1.data[8] >= 60;
									this.uslovie_text[2] = "Денег в бюджете: 6";
								}
								if (this.selected_country == 38)
								{
									this.uslovie_bool[3] = !this.global1.allcountries[16].isSEV;
									this.uslovie_text[3] = "Китай не в таможенном союзе";
									return;
								}
							}
							else if (this.this_type == 18)
							{
								this.this_opis = "Пригласить в таможенный союз";
								this.number_uslovie = 4;
								if (!this.global1.allcountries[this.global1.data[0]].Vyshi)
								{
									this.uslovie_bool[1] = !this.global1.allcountries[16].isSEV;
									this.uslovie_text[1] = "Китай не в таможенном союзе";
								}
								else
								{
									this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
									this.uslovie_text[1] = "Мы не Евроинтегрируемся";
								}
								this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Torg && this.global1.allcountries[this.global1.data[0]].isSEV;
								this.uslovie_text[2] = "Наладили торговлю и есть альянс";
								if (this.global1.allcountries[this.selected_country].Gosstroy == 1)
								{
									this.uslovie_bool[3] = this.global1.data[6] > 390;
									this.uslovie_text[3] = "Дипломатическая репутация больше 39.0";
									this.uslovie_bool[0] = !this.global1.allcountries[7].isSEV;
									this.uslovie_text[0] = "СССР не в СЭВ";
								}
								else if (this.global1.allcountries[this.selected_country].Gosstroy == 2)
								{
									this.uslovie_bool[3] = this.global1.data[6] < 400;
									this.uslovie_text[3] = "Дипломатическая репутация меньше 40";
									this.uslovie_bool[0] = !this.global1.allcountries[7].isSEV;
									this.uslovie_text[0] = "СССР не в СЭВ";
								}
								else if (this.global1.allcountries[this.selected_country].Gosstroy == 0 && this.global1.data[7] > 700)
								{
									this.uslovie_bool[3] = this.global1.data[7] > 700;
									this.uslovie_text[3] = "Стабильность соцлагеря больше 70.0";
									this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Gosstroy == 0;
									this.uslovie_text[0] = "Консерватизм в Китае";
								}
								else if (this.global1.allcountries[this.selected_country].Gosstroy == 0)
								{
									this.uslovie_bool[3] = this.global1.data[8] >= 100;
									this.uslovie_text[3] = "Денег в бюджете более 10";
									this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Gosstroy == 0;
									this.uslovie_text[0] = "Консерватизм в Китае";
								}
								else
								{
									this.uslovie_bool[3] = this.global1.data[6] < 800;
									this.uslovie_text[3] = "Дипломатическая репутация меньше 80";
									this.uslovie_bool[0] = !this.global1.allcountries[7].isSEV;
									this.uslovie_text[0] = "СССР не в СЭВ";
								}
								if (this.global1.allcountries[38].Torg)
								{
									this.uslovie_bool[0] = !this.global1.allcountries[38].Torg;
									this.uslovie_text[0] = "Нет отношений с Тайванем";
									return;
								}
							}
							else
							{
								if (this.this_type == 19)
								{
									this.this_opis = "Подписать контракт о поставках оружия в Индию";
									this.number_uslovie = 3;
									this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Torg;
									this.uslovie_text[0] = "Не подписан контракт";
									if (this.global1.allcountries[this.selected_country].Gosstroy != 2)
									{
										this.uslovie_bool[1] = this.global1.data[6] > 590;
										this.uslovie_text[1] = "Дипломатическая репутация больше 59";
									}
									else
									{
										this.uslovie_bool[1] = this.global1.data[6] < 490;
										this.uslovie_text[1] = "Дипломатическая репутация меньше 49";
									}
									this.uslovie_bool[2] = !this.global1.allcountries[31].Torg;
									this.uslovie_text[2] = "Не торгуем с Пакистаном";
									return;
								}
								if (this.this_type == 20)
								{
									this.this_opis = "Получить гарантии политического убежища партаппарату";
									this.number_uslovie = 3;
									this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Torg;
									this.uslovie_text[0] = "Подписан контракт";
									this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].Help;
									this.uslovie_text[1] = "Гарантии не получены";
									this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Gosstroy <= 1;
									this.uslovie_text[2] = "ИНК у власти";
									return;
								}
								if (this.this_type == 45)
								{
									this.this_opis = "Спровоцировать новую индо-пакистанскую войну";
									this.number_uslovie = 4;
									this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Gosstroy != 2;
									this.uslovie_text[0] = "ИНК у власти";
									this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Torg;
									this.uslovie_text[1] = "Оружие поставлено";
									this.uslovie_bool[2] = this.global1.data[9] >= 80;
									this.uslovie_text[2] = "Свободных агентурных сетей 8";
									this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Stasi && this.global1.data[21] == 1989;
									this.uslovie_text[3] = "Не спровоцировали войну в 1989 году";
									return;
								}
								if (this.this_type == 21)
								{
									this.this_opis = "Восстановить дипотношения";
									this.number_uslovie = 3;
									this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Donat && !this.global1.allcountries[this.selected_country].Torg;
									this.uslovie_text[0] = "Отношения не восстановлены";
									this.uslovie_bool[1] = this.global1.data[6] > 190 && this.global1.data[6] < 800;
									this.uslovie_text[1] = "Дипломатическая репутация между 19 и 80";
									this.uslovie_bool[2] = this.global1.event_done[14];
									this.uslovie_text[2] = "Началась либерализация Ирана";
									return;
								}
								if (this.this_type == 22)
								{
									this.this_opis = "Перейти в фазу активной торговли";
									if (this.selected_country == 46)
									{
										this.number_uslovie = 4;
									}
									else
									{
										this.number_uslovie = 3;
									}
									if (this.selected_country == 30 || this.selected_country == 8)
									{
										this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Donat;
										this.uslovie_text[0] = "Отношения восстановлены";
									}
									else
									{
										this.uslovie_bool[0] = this.global1.data[8] >= 30;
										this.uslovie_text[0] = "Нужно 3 из бюджета";
									}
									if (this.selected_country == 46 && this.global1.allcountries[46].Gosstroy == 0)
									{
										this.uslovie_bool[1] = this.global1.data[6] > 390;
										this.uslovie_text[1] = "Дипломатическая репутация больше 39";
									}
									else
									{
										this.uslovie_bool[1] = this.global1.data[6] > 250 && this.global1.data[6] < 800;
										this.uslovie_text[1] = "Дипломатическая репутация между 25 и 80";
									}
									this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Torg;
									this.uslovie_text[2] = "Не начата торговля";
									if (this.selected_country == 46 && this.global1.allcountries[46].Gosstroy == 0)
									{
										this.uslovie_bool[3] = this.global1.allcountries[46].Gosstroy == 0;
										this.uslovie_text[3] = "ДВП пришла к власти";
										return;
									}
									if (this.selected_country == 46)
									{
										this.uslovie_bool[3] = !this.global1.allcountries[46].Stasi;
										this.uslovie_text[3] = "Не поддержали ДВП";
										return;
									}
								}
								else
								{
									if (this.this_type == 23)
									{
										this.this_opis = "Пригласить в экономический союз";
										this.number_uslovie = 4;
										if (this.selected_country == 8)
										{
											this.uslovie_bool[0] = !this.global1.allcountries[7].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV;
											this.uslovie_text[0] = "СССР не в СЭВ и мы в альянсе";
										}
										else if (this.selected_country == 14 && this.global1.allcountries[14].Gosstroy == 1)
										{
											this.uslovie_bool[0] = this.global1.allcountries[14].Gosstroy == 1 && this.global1.allcountries[35].isSEV && !this.global1.allcountries[7].isSEV;
											this.uslovie_text[0] = "Реформисты в Ираке, Сирия в новом СЭВ, СССР не в альянсе";
										}
										else
										{
											this.uslovie_bool[0] = this.global1.allcountries[14].Gosstroy == 0 && this.global1.allcountries[8].isSEV && this.global1.allcountries[35].isSEV;
											this.uslovie_text[0] = "Социализм в Ираке и Сирия с Ираном в СЭВ";
										}
										this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isSEV;
										this.uslovie_text[1] = "Эта страна не в СЭВ";
										this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Torg;
										this.uslovie_text[2] = "Активно идет торговля";
										this.uslovie_bool[3] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
										this.uslovie_text[3] = "Мы не Евроинтегрируемся";
										return;
									}
									if (this.this_type == 24)
									{
										if (!this.global1.allcountries[7].Vyshi)
										{
											this.this_opis = "Поддержать консерваторов в СССР";
										}
										else
										{
											this.this_opis = "Поддержать коммунистов в СНГ";
										}
										this.this_opis = this.this_opis + "\nКоличество оказанной помощи: " + this.global1.data[52].ToString();
										this.number_uslovie = 4;
										this.uslovie_bool[0] = this.global1.data[9] > 29;
										this.uslovie_text[0] = "Свободных агентурных сетей >= 3";
										this.uslovie_bool[1] = this.global1.data[14] <= 3;
										this.uslovie_text[1] = "У нас социализм";
										this.uslovie_bool[2] = this.global1.data[8] > 9;
										this.uslovie_text[2] = "Денег в бюджете больше 1";
										if (!this.global1.allcountries[this.selected_country].Stasi)
										{
											this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Stasi;
											this.uslovie_text[3] = "Не поддержали их";
											return;
										}
										if (!this.global1.is_konst_max)
										{
											this.uslovie_bool[3] = this.global1.is_konst_max;
											this.uslovie_text[3] = "Есть конституционное большинство";
											return;
										}
										this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Stasi;
										this.uslovie_text[3] = "Подождите до следующего года";
										return;
									}
									else if (this.this_type == 25)
									{
										this.this_opis = "Выдать кредит СССР";
										this.this_opis = this.this_opis + "\nКоличество выданных кредитов: " + this.global1.data[51].ToString();
										this.number_uslovie = 3;
										this.uslovie_bool[0] = this.global1.data[8] > 30;
										this.uslovie_text[0] = "Денег в бюджете больше 3";
										this.uslovie_bool[1] = this.global1.allcountries[7].isSEV;
										this.uslovie_text[1] = "СССР в СЭВ";
										if (this.global1.data[8] < 30)
										{
											this.uslovie_bool[2] = this.global1.data[8] >= 30;
											this.uslovie_text[2] = "Нужно 3 из бюджета";
											return;
										}
										if (!this.global1.allcountries[this.selected_country].Donat)
										{
											this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
											this.uslovie_text[2] = "Кредит не выдан";
											return;
										}
										this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
										this.uslovie_text[2] = "Подождите";
										return;
									}
									else
									{
										if (this.this_type == 26)
										{
											this.this_opis = "Продать лицензии на оружие";
											this.number_uslovie = 2;
											this.uslovie_bool[0] = this.global1.data[6] > 390;
											this.uslovie_text[0] = "Дипломатическая репутация больше 39";
											this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].Donat;
											this.uslovie_text[1] = "Не продали лицензии";
											return;
										}
										if (this.this_type == 43)
										{
											this.this_opis = "Тайно продать чертежи и технологии изготовления Ядерного оружия";
											this.number_uslovie = 4;
											this.uslovie_bool[0] = this.global1.data[6] > 790 || this.global1.data[8] <= 0;
											this.uslovie_text[0] = "Дип. репутация больше 79 или отрицательный бюджет";
											this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].Stasi;
											this.uslovie_text[1] = "Не продали чертежи и технологии";
											this.uslovie_bool[2] = this.global1.data[36] == 1;
											this.uslovie_text[2] = "У нас есть чертежи и технологии";
											this.uslovie_bool[3] = this.global1.data[9] > 20;
											this.uslovie_text[3] = "Свободных агентурных сетей более двух";
											return;
										}
										if (this.this_type == 27)
										{
											this.this_opis = "Отправить аналитиков для изучения Чучхе";
											this.number_uslovie = 2;
											this.uslovie_bool[0] = this.global1.data[6] > 790;
											this.uslovie_text[0] = "Дипломатическая репутация больше 79";
											this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].Help;
											this.uslovie_text[1] = "Не направили аналитиков";
											return;
										}
										if (this.this_type == 28)
										{
											this.this_opis = "Пригласить в экономический союз";
											if (this.selected_country == 24 || this.selected_country == 13 || (this.global1.allcountries[47].Gosstroy == 2 && this.selected_country == 47))
											{
												this.number_uslovie = 4;
											}
											else
											{
												this.number_uslovie = 3;
											}
											if (!this.global1.allcountries[this.global1.data[0]].Vyshi)
											{
												this.uslovie_bool[0] = !this.global1.allcountries[7].isSEV;
												this.uslovie_text[0] = "СССР не в СЭВ";
											}
											else
											{
												this.uslovie_bool[0] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
												this.uslovie_text[0] = "Мы не евроинтегрируемся";
											}
											this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV;
											this.uslovie_text[1] = "Страна не в СЭВ и мы в Альянсе";
											if (this.selected_country == 13 && this.global1.allcountries[13].Gosstroy == 1)
											{
												this.uslovie_bool[2] = this.global1.allcountries[30].isSEV && this.global1.allcountries[40].isSEV;
												this.uslovie_text[2] = "Алжир и Египет в экономическом союзе";
											}
											else if (this.selected_country == 13)
											{
												this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Gosstroy == 0;
												this.uslovie_text[2] = "Реформы были свёрнуты";
											}
											else if ((this.selected_country == 11 && this.global1.allcountries[11].Gosstroy == 2) || (this.global1.allcountries[47].Gosstroy == 2 && this.selected_country == 47))
											{
												this.uslovie_bool[2] = this.global1.data[6] < 350;
												this.uslovie_text[2] = "Дипломатическая репутация меньше 35";
											}
											else if (this.selected_country != 35 && this.selected_country != 47)
											{
												this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Gosstroy != 2;
												this.uslovie_text[2] = "Они не либерализовались";
											}
											else if (this.selected_country != 47)
											{
												this.uslovie_bool[2] = this.global1.data[9] >= 10;
												this.uslovie_text[2] = "Есть свободные агентурные сети";
											}
											else
											{
												this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Gosstroy <= 1;
												this.uslovie_text[2] = "СФНО находится у власти ";
											}
											if (this.selected_country == 13 && this.global1.allcountries[13].Gosstroy == 1)
											{
												this.uslovie_bool[3] = this.global1.allcountries[this.selected_country].Money && this.global1.data[8] >= 30;
												this.uslovie_text[3] = "Реформы не были свёрнуты, есть свободные деньги";
												return;
											}
											if (this.selected_country == 24)
											{
												this.uslovie_bool[3] = this.global1.data[55] >= 2;
												this.uslovie_text[3] = "Несколько раз инвестировали в нефтедобычу";
												return;
											}
											if (this.selected_country == 13)
											{
												this.uslovie_bool[3] = this.global1.data[6] > 700 && this.global1.data[8] >= 30;
												this.uslovie_text[3] = "Дип. репутация > 70.0, есть свободные деньги";
												return;
											}
											if (this.global1.allcountries[47].Gosstroy == 2 && this.selected_country == 47)
											{
												this.uslovie_bool[3] = this.global1.data[8] >= 20 && this.global1.data[14] >= 3;
												this.uslovie_text[3] = "Госстрой кадаризм или правее, есть свободные деньги";
												return;
											}
										}
										else
										{
											if (this.this_type == 56)
											{
												this.this_opis = "Пригласить в экономический союз";
												this.number_uslovie = 4;
												this.uslovie_bool[0] = !this.global1.allcountries[7].isSEV;
												this.uslovie_text[0] = "СССР не в СЭВ";
												this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV;
												this.uslovie_text[1] = "Страна не в СЭВ и мы в Альянсе";
												if (this.global1.data[0] == 5 && this.global1.data[11] == 0)
												{
													this.uslovie_bool[2] = this.global1.data[11] == 0;
													this.uslovie_text[2] = "Чаушеску у власти";
												}
												else
												{
													this.uslovie_bool[2] = this.global1.data[6] >= 990;
													this.uslovie_text[2] = "Дипломатическая репутация не менее 99";
												}
												this.uslovie_bool[3] = this.global1.allcountries[this.selected_country].Help;
												this.uslovie_text[3] = "Направили аналитиков";
												return;
											}
											if (this.this_type == 29)
											{
												this.this_opis = "Восстановить торговые отношения";
												this.number_uslovie = 3;
												this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Torg;
												this.uslovie_text[0] = "Не начата торговля";
												if (this.global1.data[6] <= 900)
												{
													this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Gosstroy != 0;
													this.uslovie_text[1] = "Не господствует ходжаизм";
													this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Stasi;
													this.uslovie_text[2] = "Мы поддержали Рамиза Алию или новый демократический режим";
													return;
												}
												this.uslovie_bool[1] = this.global1.data[6] > 900;
												this.uslovie_text[1] = "Дипломатическая репутация больше 90";
												this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Stasi;
												this.uslovie_text[2] = "Мы поддержали Рамиза Алию";
												return;
											}
											else
											{
												if (this.this_type == 30)
												{
													if (this.selected_country == 46 || this.selected_country == 33 || this.selected_country == 22)
													{
														this.this_opis = "Пригласить в эконом. союз\nВнимание! Эта страна будет дотационной";
													}
													else if (this.selected_country == 43)
													{
														this.this_opis = "Пригласить в эконом. союз\nВнимание! Выгода увеличится от торговли с соседями";
													}
													else
													{
														this.this_opis = "Пригласить в экономический союз";
													}
													this.number_uslovie = 4;
													this.uslovie_bool[0] = !this.global1.allcountries[7].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV;
													this.uslovie_text[0] = "СССР не в СЭВ и мы в Альянсе";
													this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isSEV;
													this.uslovie_text[1] = "Эта страна не в СЭВ";
													this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Torg;
													this.uslovie_text[2] = "Идет торговля";
													this.uslovie_bool[3] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
													this.uslovie_text[3] = "Мы не евроинтегрируемся";
													return;
												}
												if (this.this_type == 31)
												{
													if (this.global1.allcountries[this.selected_country].Gosstroy != 2)
													{
														this.this_opis = "Поддержать режим Рамиза Алии";
													}
													else
													{
														this.this_opis = "Поддержать новый демократический режим";
													}
													this.number_uslovie = 4;
													this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
													this.uslovie_text[0] = "Не поддержали режим";
													if (this.global1.allcountries[this.selected_country].Gosstroy == 2)
													{
														this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Gosstroy == 2;
														this.uslovie_text[1] = "Демократы у власти";
													}
													else
													{
														this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Gosstroy <= 1;
														this.uslovie_text[1] = "Рамиз Алия у власти";
													}
													if (this.global1.allcountries[this.selected_country].Gosstroy == 2)
													{
														this.uslovie_bool[2] = this.global1.data[6] < 450;
														this.uslovie_text[2] = "Дипломатическая репутация меньше 45";
													}
													else
													{
														this.uslovie_bool[2] = this.global1.data[6] > 590;
														this.uslovie_text[2] = "Дипломатическая репутация больше 59";
													}
													this.uslovie_bool[3] = this.global1.data[9] >= 10;
													this.uslovie_text[3] = "Есть свободные агентурные сети";
													return;
												}
												if (this.this_type == 32)
												{
													this.this_opis = "Поддержать правящую партию";
													this.number_uslovie = 4;
													this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
													this.uslovie_text[0] = "Не поддержали режим";
													this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Torg;
													this.uslovie_text[1] = "Есть тайный договор или торгуем";
													this.uslovie_bool[2] = this.global1.data[6] > 690;
													this.uslovie_text[2] = "Дипломатическая репутация больше 69";
													this.uslovie_bool[3] = this.global1.data[9] >= 10;
													this.uslovie_text[3] = "Есть свободные агентурные сети";
													return;
												}
												if (this.this_type == 33)
												{
													this.this_opis = "Пригласить интегрироваться в ЕЭС";
													this.number_uslovie = 4;
													this.uslovie_bool[0] = this.global1.allcountries[this.global1.data[0]].Vyshi;
													this.uslovie_text[0] = "Мы евроинтегрируемся";
													this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].Vyshi;
													this.uslovie_text[1] = "Они не евроинтегрируются";
													this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].isOVD;
													this.uslovie_text[2] = "Эта страна не в ОВД";
													this.uslovie_bool[3] = this.global1.allcountries[this.selected_country].Gosstroy == 2;
													this.uslovie_text[3] = "Эта страна либерализовалась";
													return;
												}
												if (this.this_type == 34)
												{
													this.this_opis = "Выслать финансовую помощь";
													if (this.selected_country == 35)
													{
														this.number_uslovie = 4;
													}
													else
													{
														this.number_uslovie = 3;
													}
													this.uslovie_bool[0] = this.global1.data[6] > 390;
													this.uslovie_text[0] = "Дипломатическая репутация больше 39";
													if (this.selected_country == 30)
													{
														this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Torg;
														this.uslovie_text[1] = "Идет торговля";
													}
													else
													{
														this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Gosstroy != 2;
														this.uslovie_text[1] = "Они не либерализовались";
													}
													if (this.global1.data[8] < 30)
													{
														this.uslovie_bool[2] = this.global1.data[8] >= 30;
														this.uslovie_text[2] = "Нужно 3 из бюджета";
													}
													else if (!this.global1.allcountries[this.selected_country].Donat || this.selected_country == 35)
													{
														this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
														this.uslovie_text[2] = "Не высылали финансов";
													}
													else if (!this.global1.is_konst_max)
													{
														this.uslovie_bool[2] = this.global1.is_konst_max;
														this.uslovie_text[2] = "Есть конституционное большинство";
													}
													else
													{
														this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
														this.uslovie_text[2] = "Подождите до нового года";
													}
													if (this.selected_country == 35)
													{
														this.uslovie_bool[3] = (this.global1.data[20] < 5 && this.global1.data[21] == 1991) || this.global1.data[21] <= 1990;
														this.uslovie_text[3] = "Раньше, чем май 1991";
														return;
													}
												}
												else
												{
													if (this.this_type == 35)
													{
														this.this_opis = "Оказать помощь спецслужбами";
														this.number_uslovie = 4;
														this.uslovie_bool[0] = this.global1.data[6] > (3 - this.global1.allcountries[this.selected_country].Gosstroy) * 300 - 200;
														this.uslovie_text[0] = "Дипломатическая репутация больше " + (((3 - this.global1.allcountries[this.selected_country].Gosstroy) * 300 - 200) / 10).ToString();
														this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Gosstroy != 2;
														this.uslovie_text[1] = "Они не либерализовались";
														this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Stasi;
														this.uslovie_text[2] = "Не оказали помощь";
														this.uslovie_bool[3] = this.global1.data[9] >= 20;
														this.uslovie_text[3] = "Есть две свободные агентурные сети";
														return;
													}
													if (this.this_type == 36)
													{
														this.this_opis = "Пригласить в экономический союз";
														this.number_uslovie = 4;
														if (this.global1.allcountries[this.selected_country].Gosstroy == 9)
														{
															this.uslovie_bool[0] = this.global1.data[6] > 790;
															this.uslovie_text[0] = "Дипломатическая репутация больше 79";
														}
														else if (this.global1.allcountries[this.selected_country].Gosstroy == 0)
														{
															this.uslovie_bool[0] = this.global1.data[6] > 690;
															this.uslovie_text[0] = "Дипломатическая репутация больше 69";
														}
														else if (this.global1.allcountries[this.selected_country].Gosstroy == 1)
														{
															this.uslovie_bool[0] = this.global1.data[6] > 390 && this.global1.data[6] < 800;
															this.uslovie_text[0] = "Дипломатическая репутация между 39 и 80";
														}
														else
														{
															this.uslovie_bool[0] = this.global1.data[6] <= 399;
															this.uslovie_text[0] = "Дипломатическая репутация меньше 40";
														}
														this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isSEV;
														this.uslovie_text[1] = "Они не в СЭВ";
														this.uslovie_bool[2] = this.global1.allcountries[this.global1.data[0]].isSEV;
														this.uslovie_text[2] = "Мы в СЭВ";
														this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Vyshi && !this.global1.allcountries[this.global1.data[0]].Vyshi;
														this.uslovie_text[3] = "Они и мы не евроинтегрируемся";
														return;
													}
													if (this.this_type == 37)
													{
														this.this_opis = "Пригласить в военный договор";
														this.number_uslovie = 4;
														if (this.global1.allcountries[this.selected_country].Gosstroy == 9)
														{
															this.uslovie_bool[0] = this.global1.data[6] > 890;
															this.uslovie_text[0] = "Дипломатическая репутация больше 89";
														}
														else if (this.global1.allcountries[this.selected_country].Gosstroy == 0)
														{
															this.uslovie_bool[0] = this.global1.data[6] > 790;
															this.uslovie_text[0] = "Дипломатическая репутация больше 79";
														}
														else if (this.global1.allcountries[this.selected_country].Gosstroy == 1)
														{
															this.uslovie_bool[0] = this.global1.data[6] > 390 && this.global1.data[6] < 600;
															this.uslovie_text[0] = "Дипломатическая репутация между 39 и 60";
														}
														else
														{
															this.uslovie_bool[0] = this.global1.data[6] < 200;
															this.uslovie_text[0] = "Дипломатическая репутация меньше 20";
														}
														this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isOVD && this.global1.allcountries[this.selected_country].isSEV;
														this.uslovie_text[1] = "Они не в ОВД. Они в СЭВ.";
														this.uslovie_bool[2] = this.global1.allcountries[this.global1.data[0]].isOVD;
														this.uslovie_text[2] = "Мы в ОВД";
														this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Vyshi && !this.global1.allcountries[this.global1.data[0]].Vyshi;
														this.uslovie_text[3] = "Они и мы не евроинтегрируемся";
														return;
													}
													if (this.this_type == 38)
													{
														this.this_opis = "Углубить торговые отношения";
														if (this.selected_country == 27)
														{
															this.number_uslovie = 4;
														}
														else
														{
															this.number_uslovie = 3;
														}
														this.uslovie_bool[0] = this.global1.data[6] < 350 + (28 - this.selected_country) * 100;
														this.uslovie_text[0] = "Дипломатическая репутация меньше " + (35 + (28 - this.selected_country) * 10).ToString();
														this.uslovie_bool[1] = this.global1.data[27] > 0;
														this.uslovie_text[1] = "Есть хоть одна полностью открытая граница";
														this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Torg;
														this.uslovie_text[2] = "Не углублены торговые отношения";
														if (this.selected_country == 27)
														{
															this.uslovie_bool[3] = !this.global1.event_done[441];
															this.uslovie_text[3] = "Не было объявлено о персональных санкциях";
															return;
														}
													}
													else
													{
														if (this.this_type == 39)
														{
															this.this_opis = "Пригласить интегрироваться в ЕЭС";
															this.number_uslovie = 4;
															this.uslovie_bool[0] = this.global1.allcountries[this.global1.data[0]].Vyshi;
															this.uslovie_text[0] = "Мы евроинтегрируемся";
															this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].Vyshi;
															this.uslovie_text[1] = "Они не евроинтегрируются";
															this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Torg;
															this.uslovie_text[2] = "Углублены торговые отношения";
															this.uslovie_bool[3] = !this.global1.allcountries[7].isSEV;
															this.uslovie_text[3] = "СССР не в СЭВ";
															return;
														}
														if (this.this_type == 40)
														{
															this.this_opis = "Восстановить дружеские отношения";
															this.number_uslovie = 2;
															this.uslovie_bool[0] = this.global1.data[6] > 390 && this.global1.data[6] < 800;
															this.uslovie_text[0] = "Дипломатическая репутация между 39 и 80";
															this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].Torg;
															this.uslovie_text[1] = "Не восстановлены дружеские отношения";
															return;
														}
														if (this.this_type == 41)
														{
															if (this.selected_country == 46 || this.selected_country == 33 || this.selected_country == 22)
															{
																this.this_opis = "Пригласить в эконом. союз\nВнимание! Эта страна будет дотационной";
															}
															else
															{
																this.this_opis = "Пригласить в торгово-таможенный союз";
															}
															this.number_uslovie = 4;
															this.uslovie_bool[0] = !this.global1.allcountries[7].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV;
															this.uslovie_text[0] = "СССР не в СЭВ и мы в Альянсе";
															this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isSEV;
															this.uslovie_text[1] = "Не состоит в торгово-таможенном союзе";
															this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Torg;
															this.uslovie_text[2] = "Дружеские отношения восстановлены";
															this.uslovie_bool[3] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
															this.uslovie_text[3] = "Мы не евроинтегрируемся";
															return;
														}
														if (this.this_type == 42)
														{
															this.this_opis = "Восстановить все отношения с новым правительством Мьянмы";
															this.number_uslovie = 3;
															this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Torg;
															this.uslovie_text[0] = "Отношения с этой страной не восстановлены";
															this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Gosstroy == 9 || this.global1.allcountries[this.selected_country].Gosstroy == 0;
															this.uslovie_text[1] = "Новое правительство уже захватило всю полноту власти";
															this.uslovie_bool[2] = this.global1.data[6] > 790;
															this.uslovie_text[2] = "Дипломатическая репутация больше 79";
															return;
														}
														if (this.this_type == 46)
														{
															this.this_opis = "Убедить союзников наложить санкции за поддержку терроризма в Афганистане";
															this.number_uslovie = 4;
															this.uslovie_bool[0] = this.global1.data[6] > 590;
															this.uslovie_text[0] = "Дипломатическая репутация больше 59";
															this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
															this.uslovie_text[1] = "Мы не евроинтегрируемся";
															this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
															this.uslovie_text[2] = "Не наложили санкции";
															this.uslovie_bool[3] = this.global1.is_konst_max;
															this.uslovie_text[3] = "Есть конституционное большинство";
															return;
														}
														if (this.this_type == 52)
														{
															this.this_opis = "Снять санкции";
															this.number_uslovie = 3;
															this.uslovie_bool[0] = this.global1.data[6] < 400;
															this.uslovie_text[0] = "Дипломатическая репутация меньше 40";
															this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].isOVD || !this.global1.allcountries[7].isOVD;
															this.uslovie_text[1] = "Мы не в ОВД с СССР";
															this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Help;
															this.uslovie_text[2] = "Наложили санкции";
															return;
														}
														if (this.this_type == 47)
														{
															this.this_opis = "Признать сирийский Ливан и разорвать отношения с израильским";
															this.number_uslovie = 3;
															this.uslovie_bool[0] = this.global1.data[6] > 790;
															this.uslovie_text[0] = "Дипломатическая репутация больше 79";
															this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
															this.uslovie_text[1] = "Мы не евроинтегрируемся";
															this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
															this.uslovie_text[2] = "Не признали сирийский Ливан";
															return;
														}
														if (this.this_type == 48)
														{
															this.this_opis = "Подкупить чиновников и получить чертежи и технологии производства Ядерного оружия";
															this.number_uslovie = 4;
															this.uslovie_bool[0] = this.global1.data[9] >= 100;
															this.uslovie_text[0] = "Свободных агентурных сетей: 10";
															this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
															this.uslovie_text[1] = "Мы не евроинтегрируемся";
															this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Stasi;
															this.uslovie_text[2] = "Не подкупили чиновников";
															if (this.global1.data[0] != 10 || this.global1.event_done[255])
															{
																this.uslovie_bool[3] = this.global1.data[8] >= 250;
																this.uslovie_text[3] = "Свободных денег в бюджете: 25";
																return;
															}
															this.uslovie_bool[3] = this.global1.event_done[255];
															this.uslovie_text[3] = "Хотим ли мы?";
															return;
														}
														else if (this.this_type == 50)
														{
															this.this_opis = "Подкупить чиновников и получить чертежи и технологии производства Ядерного оружия";
															this.number_uslovie = 4;
															this.uslovie_bool[0] = this.global1.data[9] >= 50;
															this.uslovie_text[0] = "Свободных агентурных сетей: 5";
															this.uslovie_bool[1] = this.global1.allcountries[7].Vyshi;
															this.uslovie_text[1] = "СССР не существует";
															this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
															this.uslovie_text[2] = "Не подкупили чиновников";
															if (this.global1.data[0] != 10 || this.global1.event_done[255])
															{
																this.uslovie_bool[3] = this.global1.data[8] >= 100;
																this.uslovie_text[3] = "Свободных денег в бюджете: 10";
																return;
															}
															this.uslovie_bool[3] = this.global1.event_done[255];
															this.uslovie_text[3] = "Хотим ли мы?";
															return;
														}
														else
														{
															if (this.this_type == 49)
															{
																this.this_opis = "Помочь с развитием нефтедобычи";
																this.number_uslovie = 2;
																this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
																this.uslovie_text[0] = "Не помогли";
																this.uslovie_bool[1] = this.global1.data[8] >= 30;
																this.uslovie_text[1] = "Свободных денег в бюджете: 3";
																return;
															}
															if (this.this_type == 53)
															{
																if (this.selected_country == 23)
																{
																	this.this_opis = "Инвестировать в морскую нефтедобычу";
																	this.this_opis += " (режим станет менее дотационным)";
																}
																else
																{
																	this.this_opis = "Инвестировать в нефтедобычу";
																}
																this.number_uslovie = 3;
																this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Donat;
																this.uslovie_text[0] = "Не инвестировали в этом году";
																if (this.selected_country == 23)
																{
																	this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Torg;
																	this.uslovie_text[1] = "Укрепили торговые отношения";
																}
																else
																{
																	this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Stasi;
																	this.uslovie_text[1] = "Помогли с развитием нефтедобычи";
																}
																this.uslovie_bool[2] = this.global1.data[8] >= 30;
																this.uslovie_text[2] = "Свободных денег в бюджете: 3";
																return;
															}
															if (this.this_type == 54)
															{
																this.this_opis = "Подписать договор о Разрядке";
																this.number_uslovie = 4;
																this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
																this.uslovie_text[0] = "Не подписывали в этом месяце";
																this.uslovie_bool[1] = this.global1.data[9] >= this.global1.data[6] / 20;
																this.uslovie_text[1] = "Агенутрных сетей: " + (this.global1.data[6] / 200).ToString() + "." + Mathf.Abs(this.global1.data[6] / 20 % 10).ToString();
																this.uslovie_bool[2] = this.global1.data[8] >= this.global1.data[6] / 20;
																this.uslovie_text[2] = "Свободных денег в бюджете: " + (this.global1.data[6] / 200).ToString() + "." + Mathf.Abs(this.global1.data[6] / 20 % 10).ToString();
																this.uslovie_bool[3] = this.global1.data[10] > 400;
																this.uslovie_text[3] = "Угроза НАТО больше 40";
																return;
															}
															if (this.this_type == 55)
															{
																this.this_opis = "Положить деньги на тайный счёт Партии в банке";
																this.number_uslovie = 1;
																this.uslovie_bool[0] = this.global1.data[8] >= 80;
																this.uslovie_text[0] = "Свободных денег в бюджете: 8";
																return;
															}
															if (this.this_type == 57)
															{
																this.this_opis = "Вернуть Бессарабию в лоно Румынии";
																this.number_uslovie = 4;
																if (this.global1.data[59] == 0)
																{
																	this.uslovie_bool[0] = this.global1.allcountries[7].Vyshi;
																	this.uslovie_text[0] = "СССР распался";
																}
																else
																{
																	this.uslovie_bool[0] = this.global1.data[59] == 0;
																	this.uslovie_text[0] = "Бессарабия не наша";
																}
																this.uslovie_bool[1] = this.global1.data[11] == 0 || this.global1.data[31] >= 700;
																this.uslovie_text[1] = "Чаушеску или национализм в Румынии";
																this.uslovie_bool[2] = this.global1.data[9] >= 100;
																this.uslovie_text[2] = "Агентурных сетей не менее 10";
																this.uslovie_bool[3] = this.global1.data[8] >= 60;
																this.uslovie_text[3] = "Свободных денег в бюджете: 6";
																return;
															}
															if (this.this_type == 58)
															{
																if (this.global1.allcountries[this.selected_country].Westalgie > 25)
																{
																	this.this_opis = string.Concat(new string[]
																	{
																		"Поддержать проамериканские правые группировки (Левые: ",
																		(this.global1.allcountries[this.selected_country].Westalgie / 10).ToString(),
																		".",
																		Mathf.Abs(this.global1.allcountries[this.selected_country].Westalgie % 10).ToString(),
																		")"
																	});
																}
																else
																{
																	this.this_opis = string.Concat(new string[]
																	{
																		"Утвердить проамериканские правые группировки (Левые: ",
																		(this.global1.allcountries[this.selected_country].Westalgie / 10).ToString(),
																		".",
																		Mathf.Abs(this.global1.allcountries[this.selected_country].Westalgie % 10).ToString(),
																		")"
																	});
																}
																this.number_uslovie = 4;
																this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Stasi;
																this.uslovie_text[0] = "Не встали на сторону левых группировок";
																this.uslovie_bool[1] = this.global1.data[8] >= 8;
																this.uslovie_text[1] = "Свободных денег в бюджете: 0,8";
																this.uslovie_bool[2] = this.global1.data[9] >= 10;
																this.uslovie_text[2] = "Есть свободные агентурные сети";
																this.uslovie_bool[3] = this.global1.allcountries[this.selected_country].Westalgie > 0 && this.global1.allcountries[this.selected_country].Westalgie < 1000;
																this.uslovie_text[3] = "1-99";
																return;
															}
															if (this.this_type == 59)
															{
																if (this.global1.allcountries[this.selected_country].Westalgie <= 975)
																{
																	this.this_opis = string.Concat(new string[]
																	{
																		"Поддержать антиамериканские левые группировки (Левые: ",
																		(this.global1.allcountries[this.selected_country].Westalgie / 10).ToString(),
																		".",
																		Mathf.Abs(this.global1.allcountries[this.selected_country].Westalgie % 10).ToString(),
																		")"
																	});
																}
																else
																{
																	this.this_opis = string.Concat(new string[]
																	{
																		"Утвердить антиамериканские левые группировки (Левые: ",
																		(this.global1.allcountries[this.selected_country].Westalgie / 10).ToString(),
																		".",
																		Mathf.Abs(this.global1.allcountries[this.selected_country].Westalgie % 10).ToString(),
																		")"
																	});
																}
																this.number_uslovie = 4;
																this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Donat;
																this.uslovie_text[0] = "Не встали на сторону правых группировок";
																this.uslovie_bool[1] = this.global1.data[8] >= 8;
																this.uslovie_text[1] = "Свободных денег в бюджете: 0,8";
																this.uslovie_bool[2] = this.global1.data[9] >= 10;
																this.uslovie_text[2] = "Есть свободные агентурные сети";
																this.uslovie_bool[3] = this.global1.allcountries[this.selected_country].Westalgie > 0 && this.global1.allcountries[this.selected_country].Westalgie < 1000;
																this.uslovie_text[3] = "Не пали и не утвердились";
																return;
															}
															if (this.this_type == 60)
															{
																this.this_opis = string.Concat(new string[]
																{
																	"Выслать гуманитарную помощь населению (Левые: ",
																	(this.global1.allcountries[this.selected_country].Westalgie / 10).ToString(),
																	".",
																	Mathf.Abs(this.global1.allcountries[this.selected_country].Westalgie % 10).ToString(),
																	")"
																});
																this.number_uslovie = 2;
																this.uslovie_bool[0] = this.global1.data[8] >= 20;
																this.uslovie_text[0] = "Свободных денег в бюджете: 2";
																this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Westalgie > 0 && this.global1.allcountries[this.selected_country].Westalgie < 1000;
																this.uslovie_text[1] = "1-99";
																return;
															}
															if (this.this_type == 61)
															{
																this.this_opis = "Полностью открыть одну из границ";
																this.number_uslovie = 3;
																this.uslovie_bool[0] = this.global1.data[27] < 5;
																this.uslovie_text[0] = "Есть хоть одна не открытая полностью граница";
																this.uslovie_bool[1] = this.global1.data[6] < 600;
																this.uslovie_text[1] = "Дипломатическая репутация меньше 60";
																this.uslovie_bool[2] = !this.global1.allcountries[this.global1.data[0]].Help;
																this.uslovie_text[2] = "Мы не трогали границы в этом месяце";
																return;
															}
															if (this.this_type == 62)
															{
																this.this_opis = "Платно открыть одну из границ";
																this.number_uslovie = 4;
																this.uslovie_bool[0] = this.global1.data[28] < 5;
																this.uslovie_text[0] = "Есть хоть одна не платная граница";
																this.uslovie_bool[1] = this.global1.data[6] < 800;
																this.uslovie_text[1] = "Дипломатическая репутация меньше 80";
																this.uslovie_bool[2] = this.global1.data[6] > 400;
																this.uslovie_text[2] = "Дипломатическая репутация больше 40";
																this.uslovie_bool[3] = !this.global1.allcountries[this.global1.data[0]].Help;
																this.uslovie_text[3] = "Мы не трогали границы в этом месяце";
																return;
															}
															if (this.this_type == 63)
															{
																this.this_opis = "Закрыть одну из границ";
																this.number_uslovie = 3;
																this.uslovie_bool[0] = this.global1.data[27] + this.global1.data[28] + this.global1.data[29] > 0;
																this.uslovie_text[0] = "Есть хоть одна не закрытая граница";
																this.uslovie_bool[1] = this.global1.data[6] > 800;
																this.uslovie_text[1] = "Дипломатическая репутация больше 80";
																this.uslovie_bool[2] = !this.global1.allcountries[this.global1.data[0]].Help;
																this.uslovie_text[2] = "Мы не трогали границы в этом месяце";
																return;
															}
															if (this.this_type == 64)
															{
																this.this_opis = "Получить эксклюзивные права добычи ресурсов";
																this.number_uslovie = 3;
																if (this.selected_country == 40)
																{
																	this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Westalgie >= 1000 || this.global1.allcountries[this.selected_country].subideology == 3;
																	this.uslovie_text[0] = "Контроль левыми силами - 100 или идеология Третьего пути";
																}
																else if (this.selected_country == 41)
																{
																	this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Westalgie >= 1000 || this.global1.allcountries[this.selected_country].subideology == 11;
																	this.uslovie_text[0] = "Контроль левыми силами - 100 или идеология Левого прагматизма";
																}
																else
																{
																	this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Westalgie >= 1000 || this.global1.allcountries[this.selected_country].subideology == 2;
																	this.uslovie_text[0] = "Контроль левыми силами - 100 или идеология Рыночной диктатуры";
																}
																this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].Torg;
																this.uslovie_text[1] = "Права не получены";
																this.uslovie_bool[2] = !this.global1.allcountries[this.global1.data[0]].Vyshi || this.global1.allcountries[this.selected_country].Westalgie <= 0;
																this.uslovie_text[2] = "Мы не Евроинтегрируемся или контроль левыми силами - 0";
																return;
															}
															if (this.this_type == 65)
															{
																this.this_opis = "Установить связи с японскими коммунистами";
																this.number_uslovie = 4;
																this.uslovie_bool[0] = this.global1.data[6] < 850;
																this.uslovie_text[0] = "Дипломатическая репутация меньше 85";
																this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																this.uslovie_text[1] = "Мы не Евроинтегрируемся";
																this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Stasi;
																this.uslovie_text[2] = "Связи еще не установлены";
																this.uslovie_bool[3] = this.global1.data[14] <= 3 && this.global1.data[14] > 0;
																this.uslovie_text[3] = "Удовлетворяем взглядам КПЯ на коммунизм";
																return;
															}
															if (this.this_type == 66)
															{
																this.this_opis = "Установить торговые отношения с Японией";
																this.number_uslovie = 4;
																if (this.global1.allcountries[this.selected_country].Gosstroy == 1)
																{
																	this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Gosstroy == 1;
																	this.uslovie_text[0] = "Социалисты победили в Японии";
																}
																else
																{
																	this.uslovie_bool[0] = !this.global1.allcountries[this.global1.data[0]].isOVD || !this.global1.allcountries[7].isOVD;
																	this.uslovie_text[0] = "Не состоим в одном военном альянсе с СССР";
																}
																this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																this.uslovie_text[1] = "Мы не Евроинтегрируемся";
																this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Torg;
																this.uslovie_text[2] = "Торговля не возобновлена";
																this.uslovie_bool[3] = !this.global1.allcountries[44].Vyshi;
																this.uslovie_text[3] = "Альянс левых партий лидирует в парламенте Японии";
																return;
															}
															if (this.this_type == 67)
															{
																this.this_opis = "Пригласить в экономический союз";
																this.number_uslovie = 4;
																this.uslovie_bool[0] = !this.global1.allcountries[7].isOVD;
																this.uslovie_text[0] = "СССР не в ОВД";
																if (this.global1.allcountries[this.selected_country].isSEV)
																{
																	this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isSEV;
																	this.uslovie_text[1] = "Греция не в СЭВ";
																}
																else if (!this.global1.event_done[50])
																{
																	this.uslovie_bool[1] = this.global1.event_done[50];
																	this.uslovie_text[1] = "Выборы 1989 года в Греции прошли";
																}
																else
																{
																	this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Gosstroy <= 1;
																	this.uslovie_text[1] = "Социалистический блок возглавляет страну";
																}
																this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Torg && this.global1.allcountries[this.global1.data[0]].isSEV;
																this.uslovie_text[2] = "Активно идет торговля";
																this.uslovie_bool[3] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																this.uslovie_text[3] = "Мы не Евроинтегрируемся";
																return;
															}
															if (this.this_type == 68)
															{
																this.this_opis = "Послать делегацию в Кувейт для создания дружественных отношений";
																this.number_uslovie = 4;
																this.uslovie_bool[0] = this.global1.allcountries[14].Help;
																this.uslovie_text[0] = "Наложили эмбарго на Ирак";
																this.uslovie_bool[1] = this.global1.event_done[81] || !this.global1.event_done[53] || this.global1.allcountries[36].Vyshi;
																this.uslovie_text[1] = "Страна не оккупирована";
																this.uslovie_bool[2] = this.global1.allcountries[14].Gosstroy != 9;
																this.uslovie_text[2] = "Помогли свергнуть Саддама Хусейна";
																this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Torg;
																this.uslovie_text[3] = "Делегация еще не была послана.";
																return;
															}
															if (this.this_type == 69)
															{
																this.this_opis = "Использовать индийских посредников для поддержки Рохана Виджевира";
																this.number_uslovie = 4;
																this.uslovie_bool[0] = this.global1.allcountries[19].Torg && this.global1.allcountries[16].Torg;
																this.uslovie_text[0] = "Тесные отношения с Индией и Китаем";
																this.uslovie_bool[1] = !this.global1.allcountries[46].Donat;
																this.uslovie_text[1] = "Не оказали помощь";
																this.uslovie_bool[2] = this.global1.data[8] > 30;
																this.uslovie_text[2] = "Денег в бюджете больше 3";
																this.uslovie_bool[3] = this.global1.data[20] < 3 && this.global1.data[21] == 1989;
																this.uslovie_text[3] = "Раньше, чем март 1989";
																return;
															}
															if (this.this_type == 70)
															{
																this.this_opis = "Организовать Службу Безопасности для Роханы Виджевиры";
																this.number_uslovie = 4;
																this.uslovie_bool[0] = this.global1.allcountries[46].Donat && !this.global1.allcountries[46].Stasi;
																this.uslovie_text[0] = "Оказали помощь, но не создали службу";
																this.uslovie_bool[1] = this.global1.data[9] > 30;
																this.uslovie_text[1] = "Агентурных сетей больше 3";
																this.uslovie_bool[2] = this.global1.allcountries[19].Help;
																this.uslovie_text[2] = "Получили убежище в Индии";
																this.uslovie_bool[3] = this.global1.data[20] < 11 && this.global1.data[21] == 1989;
																this.uslovie_text[3] = "Раньше, чем ноябрь 1989";
																return;
															}
															if (this.this_type == 71)
															{
																this.this_opis = "Спровоцировать восстание НОФ";
																this.number_uslovie = 4;
																if (this.global1.allcountries[46].Westalgie == 1 || (this.global1.data[20] < 12 && this.global1.data[21] == 1989))
																{
																	this.uslovie_bool[0] = this.global1.allcountries[46].Donat && this.global1.allcountries[46].Stasi;
																}
																else
																{
																	this.uslovie_bool[0] = this.global1.allcountries[46].Stasi;
																}
																this.uslovie_text[0] = "НОФ готов";
																this.uslovie_bool[1] = this.global1.allcountries[46].Gosstroy != 0;
																this.uslovie_text[1] = "Старые власти";
																this.uslovie_bool[2] = this.global1.data[9] > 50;
																this.uslovie_text[2] = "Агентурных сетей больше 5";
																this.uslovie_bool[3] = this.global1.data[8] > 50;
																this.uslovie_text[3] = "Денег в бюджете больше 5";
																return;
															}
															if (this.this_type == 72)
															{
																this.this_opis = "Негласно профинансировать Ноэля Брауна";
																this.number_uslovie = 4;
																this.uslovie_bool[0] = !this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.data[14] < 4;
																this.uslovie_text[0] = "Не западники";
																this.uslovie_bool[1] = this.global1.data[8] > 80;
																this.uslovie_text[1] = "Денег в бюджете больше 8";
																this.uslovie_bool[2] = this.global1.data[21] == 1989;
																this.uslovie_text[2] = "Раньше, чем 1990";
																this.uslovie_bool[3] = !this.global1.allcountries[29].Donat;
																this.uslovie_text[3] = "Не финансировали";
																return;
															}
															if (this.this_type == 73)
															{
																this.this_opis = "Устранить Дика Спринга";
																this.number_uslovie = 4;
																this.uslovie_bool[0] = !this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.data[14] < 4;
																this.uslovie_text[0] = "Не западники";
																this.uslovie_bool[1] = this.global1.data[9] > 150;
																this.uslovie_text[1] = "Агентурный сетей больше 15";
																this.uslovie_bool[2] = this.global1.data[21] == 1989;
																this.uslovie_text[2] = "Раньше, чем 1990";
																this.uslovie_bool[3] = !this.global1.allcountries[29].Stasi;
																this.uslovie_text[3] = "Не устраняли";
																return;
															}
															if (this.this_type == 74)
															{
																this.this_opis = "Создать объединённую партию Лейбористов и левых";
																this.number_uslovie = 4;
																this.uslovie_bool[0] = this.global1.allcountries[29].Stasi && this.global1.allcountries[29].Donat && ((this.global1.data[20] < 11 && this.global1.data[21] <= 1990) || this.global1.data[21] <= 1989);
																this.uslovie_text[0] = "Всё готово для единения (до ноября 1990)";
																this.uslovie_bool[1] = this.global1.science[2];
																this.uslovie_text[1] = "Есть СОРМ";
																this.uslovie_bool[2] = this.global1.allcountries[29].Gosstroy != 1;
																this.uslovie_text[2] = "Левые ещё не победили на выборах 1990";
																this.uslovie_bool[3] = this.global1.data[10] <= 510;
																this.uslovie_text[3] = "Угроза НАТО меньше 51";
																return;
															}
															if (this.this_type == 75)
															{
																this.this_opis = "Совершить теракт против Кейсона Фомвихана";
																this.number_uslovie = 4;
																this.uslovie_bool[0] = !this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.data[14] < 4;
																this.uslovie_text[0] = "Не западники";
																this.uslovie_bool[1] = this.global1.data[9] > 100;
																this.uslovie_text[1] = "Агентурный сетей больше 10";
																this.uslovie_bool[2] = this.global1.data[21] <= 1990;
																this.uslovie_text[2] = "Раньше, чем 1991";
																this.uslovie_bool[3] = !this.global1.allcountries[22].Stasi;
																this.uslovie_text[3] = "Не совершали теракт";
																return;
															}
															if (this.this_type == 76)
															{
																this.this_opis = "Оказать помощь фракции Суфанувонга-Фуми";
																this.number_uslovie = 4;
																this.uslovie_bool[0] = this.global1.allcountries[22].Stasi;
																this.uslovie_text[0] = "Совершили теракт";
																this.uslovie_bool[1] = this.global1.data[9] > 50 && this.global1.data[8] > 50;
																this.uslovie_text[1] = "Агентурный сетей и денег больше 5";
																this.uslovie_bool[2] = (this.global1.data[20] < 8 && this.global1.data[21] <= 1991) || this.global1.data[21] <= 1990;
																this.uslovie_text[2] = "Раньше, чем август 1991";
																this.uslovie_bool[3] = !this.global1.allcountries[22].Donat;
																this.uslovie_text[3] = "Не помогли фракции";
																return;
															}
															if (this.this_type == 77)
															{
																this.this_opis = "Начать наступление";
																this.number_uslovie = 1;
																this.uslovie_bool[0] = this.global1.data[90] != 1 || this.global1.data[92] != 1 || this.global1.data[93] != 1 || this.global1.data[94] != 1;
																this.uslovie_text[0] = "Есть куда воевать";
																return;
															}
															if (this.this_type == 78)
															{
																this.this_opis = "Отправить подкрепление афганской армии";
																this.number_uslovie = 2;
																this.uslovie_bool[0] = this.global1.data[8] >= 30;
																this.uslovie_text[0] = "Денег в бюджете: 3";
																this.uslovie_bool[1] = this.global1.data[9] >= 50;
																this.uslovie_text[1] = "Агентурный сетей больше 5";
																return;
															}
															if (this.this_type == 79)
															{
																this.this_opis = "Перейти в фазу активной торговли";
																this.number_uslovie = 4;
																if (this.global1.data[0] == 18)
																{
																	this.uslovie_bool[0] = this.global1.data[77] <= 0;
																	this.uslovie_text[0] = "Эмбарго снято";
																	this.uslovie_bool[2] = !this.global1.allcountries[this.global1.data[0]].isSEV;
																	this.uslovie_text[2] = "Мы не в СЭВ";
																}
																else if (this.global1.data[0] == 12 || this.global1.data[0] == 10)
																{
																	this.uslovie_bool[0] = this.global1.data[101] == 0 || (this.global1.data[98] < 0 && this.global1.data[68] > 3) || this.global1.data[112] == 1;
																	this.uslovie_text[0] = "Мирный договор подписан или отказались от ядерного оружия";
																	this.uslovie_bool[2] = this.global1.data[101] == 0;
																	this.uslovie_text[2] = "Нет ядерного оружия";
																}
																else
																{
																	this.uslovie_bool[0] = this.global1.allcountries[this.global1.data[0]].Vyshi;
																	this.uslovie_text[0] = "Мы евроинтегрируемся";
																	this.uslovie_bool[2] = !this.global1.allcountries[this.global1.data[0]].isSEV;
																	this.uslovie_text[2] = "Мы не в СЭВ";
																}
																this.uslovie_bool[1] = this.global1.data[6] <= 500;
																this.uslovie_text[1] = "Дипломатическая репутация менее 50";
																this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Torg;
																this.uslovie_text[3] = "Не наладили торговлю";
																return;
															}
															if (this.this_type == 80)
															{
																this.this_opis = "Пригласить иностранных инвесторов";
																this.number_uslovie = 4;
																if (this.selected_country == 0)
																{
																	this.uslovie_bool[0] = this.global1.data[10] < 400;
																	this.uslovie_text[0] = "Угроза НАТО меньше 40.0";
																}
																else
																{
																	this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Torg;
																	this.uslovie_text[0] = "Наладили торговлю";
																}
																if (this.selected_country == 44 && this.global1.allcountries[44].subideology == 12)
																{
																	this.uslovie_bool[1] = this.global1.allcountries[44].subideology == 12;
																	this.uslovie_text[1] = "Образована центристская коалиция";
																}
																else if (this.selected_country == 44 && this.global1.allcountries[44].subideology == 9)
																{
																	this.uslovie_bool[1] = this.global1.data[6] <= 600;
																	this.uslovie_text[1] = "Дипломатическая репутация менее 60";
																}
																else if (this.selected_country == 44 && this.global1.data[239] == 1)
																{
																	this.uslovie_bool[1] = this.global1.data[6] <= 500;
																	this.uslovie_text[1] = "Дипломатическая репутация менее 50";
																}
																else
																{
																	this.uslovie_bool[1] = this.global1.data[6] <= 300;
																	this.uslovie_text[1] = "Дипломатическая репутация менее 30";
																}
																this.uslovie_bool[2] = this.global1.data[16] >= 12 || this.global1.data[70] > 0;
																this.uslovie_text[2] = "Соответствующая экономика";
																if (this.selected_country == 0)
																{
																	this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Money;
																	this.uslovie_text[3] = "Не проводили переговоров об инвестициях в этом году";
																	return;
																}
																this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Money;
																this.uslovie_text[3] = "Инвестиции не получены";
																return;
															}
															else
															{
																if (this.this_type == 81)
																{
																	this.this_opis = "Экономически повлиять на реформирование корейской системы";
																	this.number_uslovie = 4;
																	this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].isSEV;
																	this.uslovie_text[0] = "Эта страна в СЭВ";
																	this.uslovie_bool[1] = this.global1.allcountries[16].isSEV && this.global1.allcountries[16].Gosstroy == 0;
																	this.uslovie_text[1] = "Китай в СЭВ и социалистический";
																	int num2 = 0;
																	if (this.global1.allcountries[16].isSEV && this.global1.allcountries[16].Gosstroy == 0 && !this.global1.allcountries[7].isSEV && this.global1.allcountries[this.selected_country].Gosstroy != 0)
																	{
																		foreach (Country country2 in this.global1.allcountries)
																		{
																			if (country2 != null && country2.isSEV)
																			{
																				num2++;
																			}
																		}
																	}
																	this.uslovie_bool[2] = this.global1.allcountries[7].isSEV || num2 > 8;
																	this.uslovie_text[2] = "СССР в СЭВ или в эконом. союзе более 8 стран";
																	this.uslovie_bool[3] = this.global1.allcountries[this.selected_country].Gosstroy != 0;
																	this.uslovie_text[3] = "Не ортодоксально социалистический";
																	return;
																}
																if (this.this_type == 82)
																{
																	if (this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51)
																	{
																		this.this_opis = "Увеличить число резидентов УДБА в Италии";
																	}
																	else
																	{
																		this.this_opis = "Увеличить число резидентов разведки в Италии";
																	}
																	this.number_uslovie = 3;
																	this.uslovie_bool[0] = this.global1.data[9] >= 50;
																	this.uslovie_text[0] = "Агентурных сетей - 5";
																	this.uslovie_bool[1] = this.global1.data[6] < 600 || this.global1.data[14] >= 3;
																	this.uslovie_text[1] = "Дипломатическая репутация менее 60 ИЛИ Госстрой кадаризм или правее";
																	this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Stasi;
																	this.uslovie_text[2] = "Не использовали";
																	return;
																}
																if (this.this_type == 83)
																{
																	this.this_opis = "Поддержать Коммунистические Боевые Бригады";
																	this.number_uslovie = 3;
																	this.uslovie_bool[0] = this.global1.data[8] >= 50;
																	this.uslovie_text[0] = "Денег в бюджете - 5";
																	this.uslovie_bool[1] = this.global1.data[6] < 850 && this.global1.data[6] > 390;
																	this.uslovie_text[1] = "Дипломатическая репутация менее 85 и больше 39";
																	this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Money;
																	this.uslovie_text[2] = "Не использовали";
																	return;
																}
																if (this.this_type == 84)
																{
																	this.this_opis = "Перейти в фазу активной торговли";
																	if (this.selected_country == 53 || this.selected_country == 31 || this.selected_country == 37)
																	{
																		this.number_uslovie = 4;
																	}
																	else
																	{
																		this.number_uslovie = 3;
																	}
																	if (this.selected_country == 33)
																	{
																		this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Donat;
																		this.uslovie_text[0] = "Оказали помощь ГСВП";
																	}
																	else
																	{
																		this.uslovie_bool[0] = this.global1.data[27] > 0;
																		this.uslovie_text[0] = "Есть хоть одна открытая граница";
																	}
																	if (this.selected_country == 54 && this.global1.allcountries[54].Gosstroy == 1)
																	{
																		this.uslovie_bool[1] = this.global1.data[6] < 650;
																		this.uslovie_text[1] = "Дипломатическая репутация меньше 65.0";
																	}
																	else if ((this.selected_country == 23 && this.global1.allcountries[23].Gosstroy != 2) || this.selected_country == 33 || (this.selected_country == 47 && this.global1.allcountries[47].Gosstroy != 2))
																	{
																		this.uslovie_bool[1] = this.global1.data[6] > 450;
																		this.uslovie_text[1] = "Дипломатическая репутация выше 45.0";
																	}
																	else if (this.selected_country == 34 && this.global1.allcountries[34].Gosstroy == 9)
																	{
																		this.uslovie_bool[1] = this.global1.data[6] >= 390 && this.global1.data[6] <= 800;
																		this.uslovie_text[1] = "Дипломатическая репутация между 39.0 и 80.0";
																	}
																	else if (this.selected_country == 29 && this.global1.allcountries[29].Gosstroy == 1)
																	{
																		this.uslovie_bool[1] = this.global1.data[6] >= 400 && this.global1.data[6] <= 850;
																		this.uslovie_text[1] = "Дипломатическая репутация между 40.0 и 85.0";
																	}
																	else
																	{
																		this.uslovie_bool[1] = this.global1.data[6] < 350;
																		this.uslovie_text[1] = "Дипломатическая репутация меньше 35.0";
																	}
																	this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Torg;
																	this.uslovie_text[2] = "Не начата торговля";
																	if (this.selected_country == 53)
																	{
																		this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Help;
																		this.uslovie_text[3] = "Не признали ТРСК";
																	}
																	if (this.selected_country == 31)
																	{
																		this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Help && !this.global1.allcountries[19].Torg;
																		this.uslovie_text[3] = "Не ввели санкции и не торгуем с Индией";
																	}
																	if (this.selected_country == 37)
																	{
																		this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Donat && this.global1.allcountries[this.selected_country].Westalgie == 0;
																		this.uslovie_text[3] = "Не поддерживали террористов";
																		return;
																	}
																}
																else
																{
																	if (this.this_type == 85)
																	{
																		this.this_opis = "Проспонсировать вооружённые силы\n(Сила армии:" + this.global1.data[50].ToString() + ")";
																		this.number_uslovie = 2;
																		this.uslovie_bool[0] = this.global1.data[8] >= 50;
																		this.uslovie_text[0] = "Денег в бюджете - 5";
																		this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].Stasi;
																		this.uslovie_text[1] = "Не спонсировали в этом месяце";
																		return;
																	}
																	if (this.this_type == 86)
																	{
																		this.this_opis = "Пригласить в экономический союз";
																		this.number_uslovie = 4;
																		this.uslovie_bool[0] = !this.global1.allcountries[7].isSEV && !this.global1.allcountries[45].isSEV;
																		this.uslovie_text[0] = "СССР и Греция не в экономическом альянсе с нами";
																		this.uslovie_bool[1] = this.global1.allcountries[53].Help && this.global1.data[6] < 650;
																		this.uslovie_text[1] = "Признали ТРСК, дипломатическая репутация меньше 65";
																		this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Torg && !this.global1.allcountries[this.global1.data[0]].Vyshi;
																		this.uslovie_text[2] = "Активно идет торговля и мы не евроинтегрируемся";
																		this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].isSEV;
																		this.uslovie_text[3] = "Турция не в союзе";
																		return;
																	}
																	if (this.this_type == 87)
																	{
																		this.this_opis = "Признать ТРСК";
																		this.number_uslovie = 3;
																		this.uslovie_bool[0] = this.global1.data[6] > 550;
																		this.uslovie_text[0] = "Дипломатическая репутация больше 55";
																		this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																		this.uslovie_text[1] = "Мы не евроинтегрируемся";
																		this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
																		this.uslovie_text[2] = "Не признали ТРСК";
																		return;
																	}
																	if (this.this_type == 88)
																	{
																		this.this_opis = "Перейти в фазу активной торговли";
																		if (this.selected_country == 52)
																		{
																			this.number_uslovie = 4;
																		}
																		else
																		{
																			this.number_uslovie = 3;
																		}
																		this.uslovie_bool[0] = this.global1.data[27] > 0;
																		this.uslovie_text[0] = "Есть хоть одна открытая граница";
																		this.uslovie_bool[1] = this.global1.data[6] < 700;
																		this.uslovie_text[1] = "Дипломатическая репутация меньше 70.0";
																		this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Torg;
																		this.uslovie_text[2] = "Не начата торговля";
																		if (this.selected_country == 52)
																		{
																			this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Donat && this.global1.allcountries[this.selected_country].Westalgie == 0;
																			this.uslovie_text[3] = "Не поддерживали террористов";
																			return;
																		}
																	}
																	else
																	{
																		if (this.this_type == 89)
																		{
																			if (this.selected_country == 43)
																			{
																				this.this_opis = "Пригласить в эконом. союз\nВнимание! Выгода увеличится от торговли с соседями";
																			}
																			else
																			{
																				this.this_opis = "Пригласить в экономический союз";
																			}
																			this.number_uslovie = 4;
																			this.uslovie_bool[0] = !this.global1.allcountries[7].isSEV && this.global1.allcountries[this.global1.data[0]].isSEV;
																			this.uslovie_text[0] = "СССР не в СЭВ и мы в Альянсе";
																			this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isSEV;
																			this.uslovie_text[1] = "Эта страна не в СЭВ";
																			this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Torg && this.global1.data[6] < 350;
																			this.uslovie_text[2] = "Идет торговля и наша дипрепутация ниже 35.0";
																			this.uslovie_bool[3] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																			this.uslovie_text[3] = "Мы не евроинтегрируемся";
																			return;
																		}
																		if (this.this_type == 90)
																		{
																			if (this.selected_country == 46 || this.selected_country == 33 || this.selected_country == 22)
																			{
																				this.this_opis = "Пригласить в эконом. союз\nВнимание! Эта страна будет дотационной";
																			}
																			else
																			{
																				this.this_opis = "Пригласить в экономический союз";
																			}
																			this.number_uslovie = 4;
																			this.uslovie_bool[0] = this.global1.allcountries[16].isSEV && this.global1.allcountries[11].isSEV;
																			this.uslovie_text[0] = "Китай и Вьетнам в экономическом союзе";
																			this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isSEV && this.global1.allcountries[this.selected_country].Torg;
																			this.uslovie_text[1] = "Эта страна не в СЭВ, идёт торговля";
																			this.uslovie_bool[2] = this.global1.data[6] >= 450 || this.global1.data[14] <= 3;
																			this.uslovie_text[2] = "Дип. репутация выше 45 ИЛИ Госстрой кадаризм или левее";
																			this.uslovie_bool[3] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																			this.uslovie_text[3] = "Мы не евроинтегрируемся";
																			return;
																		}
																		if (this.this_type == 91)
																		{
																			if (this.global1.data[224] <= 1)
																			{
																				this.this_opis = "Пригласить в эконом. союз\nВнимание! Эта страна будет дотационной";
																			}
																			else
																			{
																				this.this_opis = "Пригласить в экономический союз";
																			}
																			this.number_uslovie = 4;
																			if (this.global1.allcountries[23].Gosstroy != 2)
																			{
																				this.uslovie_bool[0] = this.global1.allcountries[16].isSEV && this.global1.allcountries[11].isSEV;
																				this.uslovie_text[0] = "Китай и Вьетнам в экономическом союзе";
																			}
																			else
																			{
																				this.uslovie_bool[0] = this.global1.data[224] > 1;
																				this.uslovie_text[0] = "Инвестировали в нефтедобычу несколько раз";
																			}
																			this.uslovie_bool[1] = !this.global1.allcountries[this.selected_country].isSEV && this.global1.allcountries[this.selected_country].Torg;
																			this.uslovie_text[1] = "Эта страна не в СЭВ, идёт торговля";
																			if (this.global1.allcountries[23].Gosstroy != 2)
																			{
																				this.uslovie_bool[2] = this.global1.data[6] >= 450 || this.global1.data[14] <= 3;
																				this.uslovie_text[2] = "Дип. репутация выше 45 ИЛИ Госстрой кадаризм или левее";
																			}
																			else
																			{
																				this.uslovie_bool[2] = this.global1.data[6] < 40 || this.global1.data[14] >= 3;
																				this.uslovie_text[2] = "Дип. репутация ниже 40 ИЛИ Госстрой кадаризм или правее";
																			}
																			this.uslovie_bool[3] = !this.global1.allcountries[this.global1.data[0]].Vyshi && this.global1.allcountries[this.global1.data[0]].isSEV;
																			this.uslovie_text[3] = "Мы не евроинтегрируемся, мы состоим в эк. союзе";
																			return;
																		}
																		if (this.this_type == 92)
																		{
																			this.this_opis = "Поддержать левые организации в Йемене";
																			this.number_uslovie = 4;
																			this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Torg;
																			this.uslovie_text[0] = "Идёт торговля";
																			this.uslovie_bool[1] = this.global1.data[6] < 750;
																			this.uslovie_text[1] = "Дипломатическая репутация ниже 75.0";
																			this.uslovie_bool[2] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																			this.uslovie_text[2] = "Мы не евроинтегрируемся";
																			this.uslovie_bool[3] = this.global1.data[227] == 0;
																			this.uslovie_text[3] = "Не помогали в этом году";
																			return;
																		}
																		if (this.this_type == 93)
																		{
																			this.this_opis = "Поддержать демократические организации";
																			this.number_uslovie = 4;
																			this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Torg;
																			this.uslovie_text[0] = "Не укрепили торговые отношения с текущим правительством";
																			this.uslovie_bool[1] = this.global1.data[6] < 750 || this.global1.data[14] >= 3;
																			this.uslovie_text[1] = "Дип. репутация ниже 75.0 ИЛИ Госстрой кадаризм или правее";
																			this.uslovie_bool[2] = this.global1.data[9] >= 50;
																			this.uslovie_text[2] = "Агентурных сетей - 5";
																			this.uslovie_bool[3] = !this.global1.allcountries[this.selected_country].Help;
																			this.uslovie_text[3] = "Не помогали в этом году";
																			return;
																		}
																		if (this.this_type == 94)
																		{
																			this.this_opis = "Найти связи в Государственном совете по восстановлению правопорядка";
																			this.number_uslovie = 3;
																			this.uslovie_bool[0] = this.global1.data[6] > 600 || this.global1.data[14] <= 3;
																			this.uslovie_text[0] = "Дип. репутация выше 60 ИЛИ Госстрой кадаризм или левее";
																			this.uslovie_bool[1] = this.global1.data[8] >= 50;
																			this.uslovie_text[1] = "Денег в бюджете - 5";
																			this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
																			this.uslovie_text[2] = "Не помогали в этом году";
																			return;
																		}
																		if (this.this_type == 95)
																		{
																			this.this_opis = "Склонить к разработке конституции военных и оппозицию";
																			this.number_uslovie = 3;
																			this.uslovie_bool[0] = this.global1.data[230] >= 2;
																			this.uslovie_text[0] = "Высокое влияние среди оппозиции";
																			this.uslovie_bool[1] = this.global1.data[231] >= 2;
																			this.uslovie_text[1] = "Высокое влияние среди ГСВП";
																			this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].subideology != 9 && !this.global1.event_done[75];
																			this.uslovie_text[2] = "Не усадили за стол переговоров";
																			return;
																		}
																		if (this.this_type == 96)
																		{
																			if (this.selected_country == 52)
																			{
																				this.this_opis = "Поддержать Рабочую партию Курдистана и антитурецких партизан";
																			}
																			else
																			{
																				this.this_opis = "Поддержать боевые организации, повстанцев и прочих борцов с Израилем";
																			}
																			this.number_uslovie = 4;
																			this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Torg;
																			if (this.selected_country == 52)
																			{
																				this.uslovie_text[0] = "Не налажены экономические отношения с Турцией";
																			}
																			else
																			{
																				this.uslovie_text[0] = "Не налажены экономические отношения с Израилем";
																			}
																			if ((this.global1.data[0] == 12 || this.global1.data[0] == 10 || this.global1.data[0] == 18) && !this.global1.allcountries[this.global1.data[0]].Vyshi)
																			{
																				this.uslovie_bool[1] = this.global1.science[2];
																				this.uslovie_text[1] = "Развита зарубежная сеть";
																			}
																			else
																			{
																				this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																				this.uslovie_text[1] = "Мы не евроинтегрируемся";
																			}
																			this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
																			this.uslovie_text[2] = "Не поддерживали в этом году";
																			this.uslovie_bool[3] = this.global1.data[9] >= 50;
																			this.uslovie_text[3] = "Свободных агентурных сетей: 5";
																			return;
																		}
																		if (this.this_type == 97)
																		{
																			this.this_opis = "Оказать финансовую помощь проюгославской оппозиции";
																			this.number_uslovie = 3;
																			this.uslovie_bool[0] = this.global1.data[6] < 850;
																			this.uslovie_text[0] = "Дипломатическая репутация меньше 85.0";
																			this.uslovie_bool[1] = this.global1.data[235] != 9;
																			this.uslovie_text[1] = "Режим не пал";
																			if (this.global1.data[8] < 30)
																			{
																				this.uslovie_bool[2] = this.global1.data[8] >= 30;
																				this.uslovie_text[2] = "Нужно 3 из бюджета";
																				return;
																			}
																			if (!this.global1.allcountries[this.selected_country].Donat)
																			{
																				this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
																				this.uslovie_text[2] = "Не высылали финансов";
																				return;
																			}
																			if (!this.global1.is_konst_max)
																			{
																				this.uslovie_bool[2] = this.global1.is_konst_max;
																				this.uslovie_text[2] = "Есть конституционное большинство";
																				return;
																			}
																			this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
																			this.uslovie_text[2] = "Подождите до нового года";
																			return;
																		}
																		else
																		{
																			if (this.this_type == 98)
																			{
																				if (this.selected_country == 37)
																				{
																					this.this_opis = "Заключить военные контракты с израильскими оборонными компаниями";
																				}
																				else
																				{
																					this.this_opis = "Заключить военные контракты с тайваньскими оборонными компаниями";
																				}
																				this.number_uslovie = 3;
																				this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Torg;
																				this.uslovie_text[0] = "Наладили торговлю";
																				this.uslovie_bool[1] = this.global1.data[8] >= 30;
																				this.uslovie_text[1] = "Денег в бюджете: 3.0";
																				if (this.selected_country == 37)
																				{
																					this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
																				}
																				else
																				{
																					this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
																				}
																				this.uslovie_text[2] = "Не подписывали соглашения в этом году";
																				return;
																			}
																			if (this.this_type == 99)
																			{
																				this.this_opis = "Оказать поддержку \"Движению за мир в Италии\" ";
																				this.number_uslovie = 4;
																				if (!this.global1.is_konst_max)
																				{
																					this.uslovie_bool[0] = this.global1.is_konst_max;
																					this.uslovie_text[0] = "Есть конституционное большинство";
																				}
																				else
																				{
																					this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Donat;
																					this.uslovie_text[0] = "Не поддерживали в этом году";
																				}
																				this.uslovie_bool[1] = this.global1.data[6] < 490;
																				this.uslovie_text[1] = "Дипломатическая репутация ниже 49";
																				this.uslovie_bool[2] = this.global1.data[8] >= 30;
																				this.uslovie_text[2] = "Денег в бюджете: 3.0";
																				this.uslovie_bool[3] = this.global1.allcountries[this.selected_country].Stasi;
																				this.uslovie_text[3] = "Увеличили агентурную сеть в Италии";
																				return;
																			}
																			if (this.this_type == 100)
																			{
																				if (this.global1.allcountries[46].Westalgie != 2 && ((this.global1.data[20] > 11 && this.global1.data[21] == 1989) || this.global1.data[21] >= 1990))
																				{
																					this.this_opis = "Сплотить остатки актива Джанатха Вимукти Перамуны";
																				}
																				else
																				{
																					this.this_opis = "Подкупить тамильских чиновников для улучшения снабжения Джанатха Вимукти Перамуны";
																				}
																				this.number_uslovie = 4;
																				if (this.global1.allcountries[46].Westalgie != 2 && ((this.global1.data[20] > 11 && this.global1.data[21] == 1989) || this.global1.data[21] >= 1990))
																				{
																					this.uslovie_bool[0] = this.global1.allcountries[19].Torg && this.global1.allcountries[16].Torg;
																					this.uslovie_text[0] = "Тесные отношения с Индией и Китаем";
																				}
																				else
																				{
																					this.uslovie_bool[0] = this.global1.allcountries[19].Torg;
																					this.uslovie_text[0] = "Тесные отношения с Индией";
																				}
																				if (this.global1.allcountries[46].Westalgie != 2 && ((this.global1.data[20] > 11 && this.global1.data[21] == 1989) || this.global1.data[21] >= 1990))
																				{
																					this.uslovie_bool[1] = !this.global1.allcountries[46].Stasi;
																					this.uslovie_text[1] = "Не сплотили";
																				}
																				else
																				{
																					this.uslovie_bool[1] = !this.global1.allcountries[46].Donat;
																					this.uslovie_text[1] = "Не оказали помощь";
																				}
																				if (this.global1.allcountries[46].Westalgie != 2 && ((this.global1.data[20] > 11 && this.global1.data[21] == 1989) || this.global1.data[21] >= 1990))
																				{
																					if (this.global1.allcountries[46].Donat)
																					{
																						this.uslovie_bool[2] = this.global1.data[8] > 30 * (this.global1.data[21] - 1988) && this.global1.data[9] > 30 * (this.global1.data[21] - 1988);
																						this.uslovie_text[2] = "И денег, и агентов больше " + (3 * (this.global1.data[21] - 1988)).ToString();
																					}
																					else
																					{
																						this.uslovie_bool[2] = this.global1.data[8] > 40 * (this.global1.data[21] - 1988);
																						this.uslovie_text[2] = "И денег, и агентов больше " + (4 * (this.global1.data[21] - 1988)).ToString();
																					}
																				}
																				else
																				{
																					this.uslovie_bool[2] = this.global1.data[8] > 80;
																					this.uslovie_text[2] = "Денег в бюджете больше 8";
																				}
																				if (this.global1.allcountries[46].Westalgie != 2 && ((this.global1.data[20] > 11 && this.global1.data[21] == 1989) || this.global1.data[21] >= 1990))
																				{
																					this.uslovie_bool[3] = !this.global1.allcountries[46].Torg && this.global1.allcountries[46].Gosstroy == 1;
																					this.uslovie_text[3] = "Не наладили торговлю";
																					return;
																				}
																				this.uslovie_bool[3] = this.global1.data[20] < 11 && this.global1.data[21] == 1989;
																				this.uslovie_text[3] = "Раньше, чем ноябрь 1989";
																				return;
																			}
																			else if (this.this_type == 101)
																			{
																				this.this_opis = "Заключить льготные контракты на поставку нефти";
																				this.number_uslovie = 4;
																				this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Torg;
																				this.uslovie_text[0] = "Наладили торговлю";
																				this.uslovie_bool[1] = this.global1.data[8] >= 30;
																				this.uslovie_text[1] = "Денег в бюджете: 3.0";
																				this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Money;
																				this.uslovie_text[2] = "Не подписывали соглашения в этом году";
																				if (this.global1.allcountries[14].Gosstroy != 9)
																				{
																					this.uslovie_bool[3] = this.global1.allcountries[14].Gosstroy != 9;
																					this.uslovie_text[3] = "Режим Хусейна пал";
																					return;
																				}
																				if (this.selected_country == 14)
																				{
																					this.uslovie_bool[3] = this.global1.allcountries[8].Westalgie == 0;
																					this.uslovie_text[3] = "Не подписывали схожие соглашения с Ираном";
																					return;
																				}
																				if (this.selected_country == 8)
																				{
																					this.uslovie_bool[3] = this.global1.allcountries[14].Westalgie == 0;
																					this.uslovie_text[3] = "Не подписывали схожие соглашения с Ираком";
																					return;
																				}
																			}
																			else if (this.this_type == 102)
																			{
																				this.this_opis = "Провести переговоры об экономических реформах Египта";
																				this.number_uslovie = 4;
																				this.uslovie_bool[0] = this.global1.allcountries[30].isSEV;
																				this.uslovie_text[0] = "Египет в экономическом союзе";
																				this.uslovie_bool[1] = this.global1.data[8] >= 50;
																				this.uslovie_text[1] = "Денег в бюджете: 5.0";
																				this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
																				this.uslovie_text[2] = "Не проводили переговоры";
																				if (this.global1.allcountries[14].Gosstroy == 9)
																				{
																					this.uslovie_bool[3] = this.global1.allcountries[14].Gosstroy != 9 || this.global1.allcountries[14].subideology == 2;
																					this.uslovie_text[3] = "Режим Хусейна пал";
																					return;
																				}
																				this.uslovie_bool[3] = this.global1.data[10] <= 400;
																				this.uslovie_text[3] = "Угроза НАТО меньше 40.0";
																				return;
																			}
																			else
																			{
																				if (this.this_type == 103)
																				{
																					this.this_opis = "Прекратить все связи с администрацией Тайбэя";
																					this.number_uslovie = 2;
																					this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Torg;
																					this.uslovie_text[0] = "Не прекратили отношения";
																					this.uslovie_bool[1] = this.global1.allcountries[16].Torg;
																					this.uslovie_text[1] = "Ведём торговлю с КНР";
																					return;
																				}
																				if (this.this_type == 104)
																				{
																					if (this.global1.allcountries[this.selected_country].Westalgie > 25)
																					{
																						this.this_opis = string.Concat(new string[]
																						{
																							"Выслать усиленную помощь правым силам (Левые: ",
																							(this.global1.allcountries[this.selected_country].Westalgie / 10).ToString(),
																							".",
																							Mathf.Abs(this.global1.allcountries[this.selected_country].Westalgie % 10).ToString(),
																							")"
																						});
																					}
																					else
																					{
																						this.this_opis = string.Concat(new string[]
																						{
																							"Утвердить проамериканские правые группировки (Левые: ",
																							(this.global1.allcountries[this.selected_country].Westalgie / 10).ToString(),
																							".",
																							Mathf.Abs(this.global1.allcountries[this.selected_country].Westalgie % 10).ToString(),
																							")"
																						});
																					}
																					this.number_uslovie = 3;
																					this.uslovie_bool[0] = this.global1.data[8] >= 35;
																					this.uslovie_text[0] = "Свободных денег в бюджете: 3.5";
																					this.uslovie_bool[1] = this.global1.data[9] >= 50;
																					this.uslovie_text[1] = "Свободных агентурных сетей: 5.0";
																					this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Westalgie > 0 && this.global1.allcountries[this.selected_country].Westalgie < 1000;
																					this.uslovie_text[2] = "1-99";
																					return;
																				}
																				if (this.this_type == 105)
																				{
																					if (this.global1.allcountries[this.selected_country].Westalgie <= 975)
																					{
																						this.this_opis = string.Concat(new string[]
																						{
																							"Выслать усиленную помощь левым силам (Левые: ",
																							(this.global1.allcountries[this.selected_country].Westalgie / 10).ToString(),
																							".",
																							Mathf.Abs(this.global1.allcountries[this.selected_country].Westalgie % 10).ToString(),
																							")"
																						});
																					}
																					else
																					{
																						this.this_opis = string.Concat(new string[]
																						{
																							"Утвердить антиамериканские левые группировки (Левые: ",
																							(this.global1.allcountries[this.selected_country].Westalgie / 10).ToString(),
																							".",
																							Mathf.Abs(this.global1.allcountries[this.selected_country].Westalgie % 10).ToString(),
																							")"
																						});
																					}
																					this.number_uslovie = 3;
																					this.uslovie_bool[0] = this.global1.data[8] >= 35;
																					this.uslovie_text[0] = "Свободных денег в бюджете: 3.5";
																					this.uslovie_bool[1] = this.global1.data[9] >= 50;
																					this.uslovie_text[1] = "Свободных агентурных сетей: 5.0";
																					this.uslovie_bool[2] = this.global1.allcountries[this.selected_country].Westalgie > 0 && this.global1.allcountries[this.selected_country].Westalgie < 1000;
																					this.uslovie_text[2] = "Не пали и не утвердились";
																					return;
																				}
																				if (this.this_type == 106)
																				{
																					this.this_opis = string.Concat(new string[]
																					{
																						"Выслать конвой с большой гуманитарной помощью (Левые: ",
																						(this.global1.allcountries[this.selected_country].Westalgie / 10).ToString(),
																						".",
																						Mathf.Abs(this.global1.allcountries[this.selected_country].Westalgie % 10).ToString(),
																						")"
																					});
																					this.number_uslovie = 2;
																					this.uslovie_bool[0] = this.global1.data[8] >= 80;
																					this.uslovie_text[0] = "Свободных денег в бюджете: 8";
																					this.uslovie_bool[1] = this.global1.allcountries[this.selected_country].Westalgie > 0 && this.global1.allcountries[this.selected_country].Westalgie < 1000;
																					this.uslovie_text[1] = "1-99";
																					return;
																				}
																				if (this.this_type == 107)
																				{
																					this.this_opis = "Установить контакты с Тайбэем";
																					this.number_uslovie = 3;
																					this.uslovie_bool[0] = this.global1.data[9] >= 15;
																					this.uslovie_text[0] = "Свободных агентурных сетей: 1.5";
																					this.uslovie_bool[1] = !this.global1.allcountries[16].Torg;
																					this.uslovie_text[1] = "Не торгуем с КНР";
																					this.uslovie_bool[2] = this.global1.data[10] <= 400;
																					this.uslovie_text[2] = "Угроза НАТО меньше 40.0";
																					return;
																				}
																				if (this.this_type == 108)
																				{
																					this.this_opis = "Открыть торговое бюро в Тайбэе";
																					this.number_uslovie = 2;
																					this.uslovie_bool[0] = this.global1.data[8] >= 30;
																					this.uslovie_text[0] = "Свободных денег в бюджете: 3";
																					this.uslovie_bool[1] = this.global1.data[27] > 0 || this.global1.data[28] > 0;
																					this.uslovie_text[1] = "Есть хоть одна открытая граница, либо платная граница";
																					return;
																				}
																				if (this.this_type == 109)
																				{
																					this.this_opis = "Заключить контракты с тайванскими производителями электроники";
																					this.number_uslovie = 4;
																					this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Torg;
																					this.uslovie_text[0] = "Наладили торговлю";
																					this.uslovie_bool[1] = this.global1.data[8] >= 30;
																					this.uslovie_text[1] = "Денег в бюджете: 3.0";
																					this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Money;
																					this.uslovie_text[2] = "Не подписывали контракты в этом году";
																					this.uslovie_bool[3] = this.global1.data[10] <= 300 && (this.global1.allcountries[0].Money || this.global1.allcountries[44].Money || this.global1.allcountries[48].Money || this.global1.allcountries[21].Money || this.global1.allcountries[this.global1.data[0]].Vyshi);
																					this.uslovie_text[3] = "Евроинтегрируемся или получаем инвестиции";
																					return;
																				}
																				if (this.this_type == 110)
																				{
																					this.this_opis = "Выйти на контакт с левой парламентской оппозицией";
																					this.number_uslovie = 4;
																					this.uslovie_bool[0] = this.global1.data[6] < 800;
																					this.uslovie_text[0] = "Дипломатическая репутация меньше 80";
																					this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																					this.uslovie_text[1] = "Мы не Евроинтегрируемся";
																					this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
																					this.uslovie_text[2] = "Связи еще не установлены";
																					this.uslovie_bool[3] = this.global1.data[10] < 150;
																					this.uslovie_text[3] = "Угроза НАТО меньше 15";
																					return;
																				}
																				if (this.this_type == 111)
																				{
																					if (this.global1.data[239] == 4 || this.global1.data[239] == 6)
																					{
																						this.this_opis = "Помочь КПЯ сплотить оппозицию";
																					}
																					else if (this.global1.data[239] == 5)
																					{
																						this.this_opis = "Помочь Комэйто сплотить оппозицию";
																					}
																					else if (this.global1.data[239] == 3)
																					{
																						this.this_opis = "Помочь СПЯ сплотить оппозицию";
																					}
																					this.this_opis += " (каждая поддержка окажет влияние на выборы)";
																					this.number_uslovie = 4;
																					this.uslovie_bool[0] = this.global1.data[9] >= 25;
																					this.uslovie_text[0] = "Свободных агентурных сетей: 2.5";
																					this.uslovie_bool[1] = this.global1.data[8] >= 30;
																					this.uslovie_text[1] = "Денег в бюджете: 3.0";
																					this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
																					this.uslovie_text[2] = "Не оказывали помощь в этом году";
																					this.uslovie_bool[3] = this.global1.data[10] <= 500;
																					this.uslovie_text[3] = "Угроза НАТО меньше 50.0";
																					return;
																				}
																				if (this.this_type == 112)
																				{
																					this.this_opis = "Помочь укрепить режим Д. Ортеги";
																					this.number_uslovie = 4;
																					this.uslovie_bool[0] = this.global1.allcountries[this.selected_country].Torg && this.global1.allcountries[47].Gosstroy == 1;
																					this.uslovie_text[0] = "Наладили торговлю с правительством сандинистов";
																					if ((this.global1.data[0] == 12 || this.global1.data[0] == 10 || this.global1.data[0] == 18) && !this.global1.allcountries[this.global1.data[0]].Vyshi)
																					{
																						this.uslovie_bool[1] = this.global1.science[2];
																						this.uslovie_text[1] = "Развита зарубежная сеть";
																					}
																					else
																					{
																						this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																						this.uslovie_text[1] = "Мы не евроинтегрируемся";
																					}
																					this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
																					this.uslovie_text[2] = "Не поддерживали в этом году";
																					this.uslovie_bool[3] = this.global1.data[8] >= 30 && this.global1.data[9] >= 30;
																					this.uslovie_text[3] = "Свободных агентурных сетей и денег: 3";
																					return;
																				}
																				if (this.this_type == 113)
																				{
																					this.this_opis = "Помочь в укреплении позиции Примакова по Ближнему Востоку в МИД СССР";
																					this.number_uslovie = 4;
																					this.uslovie_bool[0] = this.global1.allcountries[7].Westalgie >= 8;
																					this.uslovie_text[0] = "Помогли в укреплении позиций фракции \"Союз\" больше 7 раз";
																					if ((this.global1.data[0] == 12 || this.global1.data[0] == 10 || this.global1.data[0] == 18) && this.global1.data[9] > 30)
																					{
																						this.uslovie_bool[1] = this.global1.science[2];
																						this.uslovie_text[1] = "Развита зарубежная сеть и агентов > 3.0";
																					}
																					else
																					{
																						this.uslovie_bool[1] = this.global1.data[9] > 30;
																						this.uslovie_text[1] = "Свободных агентурных сетей: 3.0";
																					}
																					this.uslovie_bool[2] = this.global1.data[2] > 750 && this.global1.data[242] != 1;
																					this.uslovie_text[2] = "Отношения с СССР выше 75.0, не оказали помощь";
																					this.uslovie_bool[3] = this.global1.data[20] < 8 && this.global1.data[21] == 1990;
																					this.uslovie_text[3] = "Первая половина 1990 года";
																					return;
																				}
																				if (this.this_type == 114)
																				{
																					this.this_opis = "Оказать поддержку Австрийской партии свободы";
																					this.number_uslovie = 3;
																					this.uslovie_bool[0] = this.global1.data[8] >= 30 && this.global1.data[9] >= 30;
																					this.uslovie_text[0] = "Свободных агентурных сетей и денег: 3.0";
																					this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																					this.uslovie_text[1] = "Мы не Евроинтегрируемся";
																					this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Donat;
																					this.uslovie_text[2] = "Поддержка не оказана";
																					return;
																				}
																				if (this.this_type == 115)
																				{
																					this.this_opis = "Поддержать националистическое крыло в АПС";
																					this.number_uslovie = 3;
																					this.uslovie_bool[0] = this.global1.data[8] >= 50;
																					this.uslovie_text[0] = "Свободных денег: 5.0";
																					this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																					this.uslovie_text[1] = "Мы не Евроинтегрируемся";
																					this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
																					this.uslovie_text[2] = "Поддержка не оказана";
																					return;
																				}
																				if (this.this_type == 116)
																				{
																					this.this_opis = "Поддержать либеральное крыло в АПС";
																					this.number_uslovie = 3;
																					this.uslovie_bool[0] = this.global1.data[8] >= 50;
																					this.uslovie_text[0] = "Свободных денег: 5.0";
																					this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																					this.uslovie_text[1] = "Мы не Евроинтегрируемся";
																					this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Money;
																					this.uslovie_text[2] = "Поддержка не оказана";
																					return;
																				}
																				if (this.this_type == 117)
																				{
																					this.this_opis = "Поддержать националистическое «Движение за права граждан»";
																					this.number_uslovie = 3;
																					this.uslovie_bool[0] = this.global1.data[9] >= 50;
																					this.uslovie_text[0] = "Свободных агентов: 5.0";
																					this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																					this.uslovie_text[1] = "Мы не Евроинтегрируемся";
																					this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Stasi;
																					this.uslovie_text[2] = "Поддержка не оказана";
																					return;
																				}
																				if (this.this_type == 118)
																				{
																					if (this.global1.allcountries[27].Help)
																					{
																						this.this_opis = "Провести переговоры между Австрийской народной партией и АПС";
																					}
																					else if ((this.global1.data[20] > 5 && this.global1.data[21] >= 1991) || this.global1.data[21] > 1992)
																					{
																						this.this_opis = "Провести переговоры о взаимодействии Социал-демократической партии и АПС";
																					}
																					else
																					{
																						this.this_opis = "Провести переговоры о взаимодействии Социалистической партии и АПС";
																					}
																					this.number_uslovie = 4;
																					this.uslovie_bool[0] = this.global1.data[8] >= 30 && this.global1.data[9] >= 30;
																					this.uslovie_text[0] = "Свободных агентурных сетей и денег: 3.0";
																					this.uslovie_bool[1] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																					this.uslovie_text[1] = "Мы не Евроинтегрируемся";
																					this.uslovie_bool[2] = this.global1.allcountries[27].Westalgie < 2;
																					this.uslovie_text[2] = "Переговоры не проведены";
																					this.uslovie_bool[3] = this.global1.data[10] < 350;
																					this.uslovie_text[3] = "Угроза НАТО меньше 35";
																					return;
																				}
																				if (this.this_type == 119)
																				{
																					this.this_opis = "Провести переговоры о проведении либеральных реформ";
																					this.number_uslovie = 3;
																					this.uslovie_bool[0] = this.global1.data[10] < 600;
																					this.uslovie_text[0] = "Угроза НАТО меньше 60.0";
																					this.uslovie_bool[1] = this.global1.data[15] < 9 || this.global1.data[16] < 13 || this.global1.data[17] < 17;
																					this.uslovie_text[1] = "Доктрины не либеральные";
																					this.uslovie_bool[2] = !this.global1.allcountries[this.selected_country].Help;
																					this.uslovie_text[2] = "Раз в полгода";
																					return;
																				}
																				if (this.this_type == 120)
																				{
																					this.this_opis = "Перейти в фазу активной торговли";
																					this.number_uslovie = 4;
																					this.uslovie_bool[0] = !this.global1.allcountries[this.selected_country].Torg;
																					this.uslovie_text[0] = "Не наладили торговлю";
																					if (this.global1.allcountries[7].isSEV)
																					{
																						this.uslovie_bool[1] = !this.global1.allcountries[7].isSEV;
																						this.uslovie_text[1] = "СССР не в СЭВ";
																					}
																					else if ((this.global1.eventVariantChosen[76] == 1 || this.global1.eventVariantChosen[76] == 2) && this.global1.allcountries[this.selected_country].Gosstroy == this.global1.allcountries[this.global1.data[0]].Gosstroy)
																					{
																						this.uslovie_bool[1] = (this.global1.eventVariantChosen[76] == 1 || this.global1.eventVariantChosen[76] == 2) && this.global1.allcountries[this.selected_country].Gosstroy == this.global1.allcountries[this.global1.data[0]].Gosstroy;
																						this.uslovie_text[1] = "Оказали помощь в приходе к власти, один госстрой";
																					}
																					else if (this.global1.allcountries[this.selected_country].Gosstroy == 1)
																					{
																						this.uslovie_bool[1] = this.global1.data[6] < 800;
																						this.uslovie_text[1] = "Дипломатическая репутация меньше 80";
																					}
																					else if (this.global1.allcountries[this.selected_country].Gosstroy == 2)
																					{
																						this.uslovie_bool[1] = this.global1.data[6] < 500;
																						this.uslovie_text[1] = "Дипломатическая репутация меньше 50";
																					}
																					else
																					{
																						this.uslovie_bool[1] = this.global1.data[6] > 600;
																						this.uslovie_text[1] = "Дипломатическая репутация больше 60";
																					}
																					this.uslovie_bool[2] = this.global1.data[8] >= 30;
																					this.uslovie_text[2] = "Денег в бюджете: 3";
																					this.uslovie_bool[3] = !this.global1.allcountries[this.global1.data[0]].Vyshi;
																					this.uslovie_text[3] = "Мы не евроинтегрируемся";
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
						}
					}
				}
			}
		}
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00026514 File Offset: 0x00024714
	private void OnMouseDown()
	{
		if (this.is_active && (this.number_uslovie == 0 || (this.number_uslovie == 1 && this.uslovie_bool[0]) || (this.number_uslovie == 2 && this.uslovie_bool[0] && this.uslovie_bool[1]) || (this.number_uslovie == 3 && this.uslovie_bool[0] && this.uslovie_bool[1] && this.uslovie_bool[2]) || (this.number_uslovie == 4 && this.uslovie_bool[0] && this.uslovie_bool[1] && this.uslovie_bool[2] && this.uslovie_bool[3])))
		{
			if (this.this_type == 1)
			{
				this.global1.data[8] += 50;
				this.global1.allcountries[this.selected_country].Money = true;
				this.global1.data[4] += 50;
				this.global1.data[22] -= 50;
				this.global1.data[1] += 150;
				this.global1.data[24] -= 3;
			}
			else if (this.this_type == 46)
			{
				this.global1.allcountries[this.selected_country].Help = true;
				this.global1.allcountries[this.selected_country].Torg = false;
				this.global1.data[10] += 10;
				this.global1.data[6] += 5;
				this.global1.data[7] += 5;
				this.global1.data[2] += 100;
				this.global1.data[24]++;
			}
			else if (this.this_type == 52)
			{
				this.global1.allcountries[this.selected_country].Help = false;
				this.global1.data[10] -= 25;
				this.global1.data[37]--;
				this.global1.data[6] -= 10;
				this.global1.data[7] -= 5;
				this.global1.data[2] += 100;
				this.global1.data[24]--;
			}
			else if (this.this_type == 47)
			{
				this.global1.allcountries[this.selected_country].Help = true;
				this.global1.data[10] += 25;
				this.global1.data[6] -= 10;
				this.global1.data[7] += 2;
				this.global1.data[2] -= 250;
			}
			else if (this.this_type == 48)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.povod = true;
				this.global1.data[36] = 1;
				this.global1.data[8] -= 250;
				this.global1.data[9] -= 100;
				if (this.global1.data[6] > 0)
				{
					this.global1.data[6] += 6;
				}
				else
				{
					this.global1.data[6] = 20;
				}
				this.global1.data[2] -= 250;
				this.global1.data[1] -= 150;
			}
			else if (this.this_type == 50)
			{
				this.global1.allcountries[this.selected_country].Help = true;
				this.global1.povod = true;
				this.global1.data[36] = 1;
				this.global1.data[8] -= 100;
				this.global1.data[9] -= 50;
				if (this.global1.data[6] > 0)
				{
					this.global1.data[6] += 6;
				}
				else
				{
					this.global1.data[6] = 20;
				}
				this.global1.data[1] -= 150;
			}
			else if (this.this_type == 49)
			{
				this.global1.data[8] -= 30;
				this.global1.data[9] += 10;
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.allcountries[this.selected_country].Torg = true;
				this.global1.data[22] += 50;
				this.global1.data[24] -= 2;
			}
			else if (this.this_type == 53)
			{
				this.global1.data[8] -= 30;
				if (this.selected_country == 23)
				{
					this.global1.data[224]++;
				}
				else
				{
					this.global1.data[55]++;
					if (this.global1.allcountries[this.selected_country].subideology != 4 && this.global1.allcountries[24].Gosstroy != this.global1.allcountries[25].Gosstroy && this.global1.data[55] >= 3)
					{
						this.global1.allcountries[this.selected_country].Gosstroy = 0;
						this.global1.allcountries[this.selected_country].subideology = 4;
					}
					else if (this.global1.allcountries[this.selected_country].subideology != 4 && this.global1.allcountries[24].Gosstroy != this.global1.allcountries[25].Gosstroy && this.global1.data[55] >= 2)
					{
						this.global1.allcountries[this.selected_country].Gosstroy = 1;
						this.global1.allcountries[this.selected_country].subideology = 11;
					}
				}
				this.global1.allcountries[this.selected_country].Donat = true;
				this.global1.allcountries[this.selected_country].Torg = true;
			}
			else if (this.this_type == 54)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.data[9] -= this.global1.data[6] / 20;
				this.global1.data[8] -= this.global1.data[6] / 20;
				this.global1.data[6] -= 20;
				this.global1.data[2] += 150;
				this.global1.data[4] += this.global1.data[6] / 20;
				this.global1.data[10] -= 100;
			}
			else if (this.this_type == 55)
			{
				this.global1.data[1] += 300;
				this.global1.data[8] -= 80;
				this.global1.data[6] -= 10;
				this.global1.data[10] -= 10;
				this.global1.allcountries[this.selected_country].Stasi = true;
			}
			else if (this.this_type == 2)
			{
				this.global1.allcountries[this.selected_country].Torg = true;
				this.global1.data[6] -= 20;
				this.global1.data[10] -= 20;
				if (this.global1.allcountries[21].Gosstroy != 2)
				{
					this.global1.data[7] += 5;
				}
			}
			else if (this.this_type == 3)
			{
				this.global1.allcountries[this.global1.data[0]].Vyshi = true;
				this.global1.data[10] -= 100;
				this.global1.data[7] -= 50;
				this.global1.data[6] -= 50;
				this.global1.data[4] -= this.global1.data[4] / 4;
				this.global1.data[23] -= 3;
			}
			else if (this.this_type == 4)
			{
				this.global1.allcountries[this.selected_country].Help = true;
				this.global1.allcountries[this.selected_country].Torg = false;
				this.global1.data[10] -= 10;
				this.global1.data[6] -= 20;
				this.global1.data[7] -= 10;
				this.global1.data[2] += 100;
				this.global1.data[24] += 2;
			}
			else if (this.this_type == 5)
			{
				this.global1.allcountries[this.selected_country].Torg = true;
				this.global1.data[6] += 50;
				this.global1.data[10] += 20;
				this.global1.data[2] -= 100;
				this.global1.data[7] += 10;
			}
			else if (this.this_type == 6)
			{
				if (!this.global1.allcountries[this.selected_country].Donat)
				{
					this.global1.allcountries[this.selected_country].Donat = true;
					this.global1.data[10] += 10;
					this.global1.data[8] -= 10;
				}
				else
				{
					this.global1.allcountries[this.selected_country].Money = true;
					this.global1.allcountries[this.selected_country].Torg = true;
					this.global1.data[10] += 120;
					this.global1.data[9] -= 50;
					this.global1.data[8] += 20;
				}
				this.global1.data[7]++;
			}
			else if (this.this_type == 7)
			{
				if (!this.global1.allcountries[this.selected_country].Stasi)
				{
					this.global1.allcountries[this.selected_country].Stasi = true;
					this.global1.data[10] += 10;
					this.global1.data[8] -= 10;
				}
				else
				{
					this.global1.allcountries[this.selected_country].Torg = true;
					this.global1.allcountries[this.selected_country].Gosstroy = 0;
					this.global1.allcountries[this.selected_country].subideology = 4;
				}
			}
			else if (this.this_type == 8)
			{
				this.global1.allcountries[this.selected_country].Help = true;
				this.global1.data[4] -= 50;
				this.global1.data[1] += 150;
				this.global1.data[22] += 50;
				this.global1.data[24] -= 3;
				this.global1.data[2] -= 150;
			}
			else if (this.this_type == 9)
			{
				this.global1.allcountries[this.selected_country].Donat = true;
				this.global1.data[8] -= 20;
				this.global1.data[10] += 10;
				this.global1.data[7] += 5;
				this.global1.data[37]++;
				this.global1.data[2] += 10;
			}
			else if (this.this_type == 10)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.data[10] += 10;
				this.global1.data[7] += 5;
				this.global1.data[6] += 10;
				this.global1.data[9] -= 10;
				this.global1.data[37]++;
			}
			else if (this.this_type == 11)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.data[9] -= 10;
				this.global1.data[10] += 10;
				this.global1.data[7] += 5;
				this.global1.data[6] += 10;
				this.global1.data[8] -= 20;
				this.global1.allcountries[17].Westalgie += 30;
			}
			else if (this.this_type == 12)
			{
				this.global1.allcountries[this.selected_country].Help = true;
				this.global1.data[9] -= 10;
				this.global1.data[10] -= 20;
				this.global1.data[8] -= 25;
				this.global1.data[2] += 50;
				this.global1.allcountries[17].Westalgie += 50;
			}
			else if (this.this_type == 13)
			{
				this.global1.allcountries[this.selected_country].Donat = true;
				this.global1.data[8] -= 20 * (this.global1.data[21] - 1988);
				this.global1.data[7] += 5;
				this.global1.data[54]++;
			}
			else if (this.this_type == 14)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.data[9] -= 20;
				this.global1.data[7] += 5;
				this.global1.data[10] += 10;
				this.global1.data[6] += 10;
				this.global1.data[54]++;
			}
			else if (this.this_type == 51)
			{
				if (this.global1.allcountries[this.selected_country].isSEV)
				{
					this.global1.allcountries[this.selected_country].isOVD = true;
				}
				else
				{
					this.global1.allcountries[this.selected_country].isSEV = true;
					this.global1.allcountries[this.selected_country].Gosstroy = 9;
					this.global1.allcountries[this.selected_country].subideology = 2;
				}
				this.global1.data[9] -= 50;
				this.global1.data[8] -= 50;
				this.global1.data[10] += 50;
				if (!this.global1.is_gkchp || this.global1.allcountries[7].Gosstroy > 0)
				{
					this.global1.data[2] -= 250;
				}
			}
			else if (this.this_type == 15)
			{
				this.global1.allcountries[this.selected_country].Help = true;
				this.global1.data[9] -= 10;
				this.global1.data[7] -= 10;
				this.global1.data[10] -= 50;
				this.global1.data[6] -= 25;
				this.global1.data[54] -= 2;
			}
			else if (this.this_type == 44)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.data[9] -= 100;
				this.global1.allcountries[this.selected_country].Gosstroy = 0;
				this.global1.allcountries[this.selected_country].subideology = 4;
				this.global1.allcountries[7].Westalgie++;
				this.global1.data[6] += 30;
				this.global1.data[10] -= 30;
				this.global1.data[7] += 30;
				this.global1.data[2] -= 150;
				this.global1.data[8] -= 100;
				this.global1.number_event = 1099;
				this.global1.speed = 0;
				this.map1.EventRead();
				SceneManager.LoadScene("Event");
			}
			else if (this.this_type == 16)
			{
				this.global1.allcountries[this.selected_country].Donat = true;
				this.global1.data[10] -= 10;
				this.global1.data[8] -= 10;
				this.global1.data[2] += 20;
				this.global1.data[6] -= 10;
				this.global1.data[22] += 10;
			}
			else if (this.this_type == 17)
			{
				this.global1.allcountries[this.selected_country].Torg = true;
				if (this.selected_country != 38)
				{
					this.global1.data[6] -= 10;
					this.global1.allcountries[17].Westalgie += 30;
					this.global1.data[22] += 20;
				}
				else if (this.selected_country == 38)
				{
					this.global1.data[8] += 10;
					this.global1.data[6] -= this.global1.data[6] / 10;
					this.global1.data[10] -= 100;
					this.global1.data[2] -= 150;
					this.global1.data[7] -= 3;
				}
			}
			else if (this.this_type == 68)
			{
				this.global1.allcountries[this.selected_country].Torg = true;
				if (this.global1.data[0] == 5)
				{
					this.global1.data[8] += 10;
				}
				this.global1.data[6] -= this.global1.data[6] / 20;
				this.global1.data[10] -= 50;
				this.global1.data[7] -= 3;
			}
			else if (this.this_type == 18)
			{
				this.global1.allcountries[this.selected_country].isSEV = true;
				this.global1.allcountries[17].Westalgie += 50;
				this.global1.data[10] -= 30;
				this.global1.data[6] -= 30;
				this.global1.data[2] += 30;
				this.global1.data[3] += 30;
				this.global1.data[5] += 20;
			}
			else if (this.this_type == 19)
			{
				this.global1.allcountries[this.selected_country].Torg = true;
				this.global1.data[10] += 10;
				this.global1.data[2] -= 25;
				this.global1.data[6] += 10;
			}
			else if (this.this_type == 20)
			{
				this.global1.allcountries[this.selected_country].Help = true;
				this.global1.data[22] += 50;
				this.global1.data[1] += 150;
				this.global1.data[2] -= 50;
			}
			else if (this.this_type == 45)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.data[9] -= 80;
				this.global1.allcountries[31].subideology = 15;
				this.global1.allcountries[this.selected_country].Gosstroy = 1;
				this.global1.allcountries[this.selected_country].subideology = 11;
				this.global1.data[6] += 30;
				this.global1.data[10] += 30;
				this.global1.data[2] -= 150;
				this.global1.data[8] -= 50;
			}
			else if (this.this_type == 21)
			{
				this.global1.allcountries[this.selected_country].Donat = true;
				this.global1.data[10] += 10;
				this.global1.data[22] += 10;
				this.global1.data[2] -= 50;
				this.global1.data[6] -= 20;
			}
			else if (this.this_type == 22)
			{
				this.global1.allcountries[this.selected_country].Torg = true;
				this.global1.data[10] += 10;
				this.global1.data[22] += 20;
				this.global1.data[2] -= 50;
				this.global1.data[6] -= 10;
				if (this.selected_country != 30)
				{
					this.global1.data[8] -= 30;
				}
			}
			else if (this.this_type == 23)
			{
				this.global1.allcountries[this.selected_country].isSEV = true;
				this.global1.data[10] += 30;
				this.global1.data[22] += 30;
				this.global1.data[2] -= 50;
				this.global1.data[6] -= 20;
			}
			else if (this.this_type == 24)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.data[7] += 10;
				this.global1.data[9] -= 30;
				this.global1.data[6]++;
				this.global1.data[8] -= 10;
				this.global1.data[52]++;
				this.global1.allcountries[7].Westalgie++;
			}
			else if (this.this_type == 25)
			{
				this.global1.allcountries[this.selected_country].Donat = true;
				this.global1.data[2] += 100;
				this.global1.data[8] -= 30;
				this.global1.data[51]++;
				this.global1.allcountries[7].Westalgie++;
			}
			else if (this.this_type == 26)
			{
				this.global1.allcountries[this.selected_country].Donat = true;
				this.global1.data[2] -= 50;
				this.global1.data[8] += 30;
				this.global1.data[6] += 20;
			}
			else if (this.this_type == 43)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.data[2] -= 250;
				this.global1.data[10] -= 50;
				this.global1.data[8] += 50;
				this.global1.data[6] += 50;
				this.global1.data[7] -= 10;
				this.global1.data[1] -= 150;
				this.global1.data[9] -= 20;
			}
			else if (this.this_type == 27)
			{
				this.global1.allcountries[this.selected_country].Help = true;
				this.global1.data[10] += 10;
				this.global1.data[6] += 20;
				this.global1.data[2] -= 100;
				this.global1.data[4] -= 50;
				this.global1.data[9] += 10;
				this.global1.data[3] += 50;
			}
			else if (this.this_type == 28)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.allcountries[this.selected_country].isSEV = true;
				this.global1.data[6] -= 10;
				this.global1.data[9] -= 10;
				if (this.selected_country == 13)
				{
					this.global1.data[8] -= 30;
				}
				else if (this.selected_country == 47 && this.global1.allcountries[47].Gosstroy == 2)
				{
					this.global1.data[8] -= 20;
				}
			}
			else if (this.this_type == 56)
			{
				this.global1.allcountries[this.selected_country].isSEV = true;
				this.global1.allcountries[this.selected_country].Torg = true;
				this.global1.data[6] += 30;
				this.global1.data[8] -= 10;
				this.global1.data[9] -= 10;
				this.global1.data[2] -= 150;
				this.global1.data[10] += 200;
			}
			else if (this.this_type == 29)
			{
				this.global1.allcountries[this.selected_country].Torg = true;
				this.global1.data[22] += 10;
				this.global1.data[6] += 10;
			}
			else if (this.this_type == 30)
			{
				this.global1.allcountries[this.selected_country].isSEV = true;
				this.global1.data[22] += 10;
				this.global1.data[6] += 10;
				this.global1.data[10] += 20;
				this.global1.data[2] -= 50;
			}
			else if (this.this_type == 31)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.data[6] += 10;
				this.global1.data[9] -= 10;
				this.global1.data[10] += 10;
				if (this.global1.allcountries[this.selected_country].Gosstroy != 2)
				{
					this.global1.data[7] += 10;
				}
				else
				{
					this.global1.data[7] -= 10;
				}
			}
			else if (this.this_type == 32)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.data[6] += 10;
				this.global1.data[7] += 10;
				this.global1.data[9] -= 10;
			}
			else if (this.this_type == 33)
			{
				this.global1.allcountries[this.selected_country].Vyshi = true;
				this.global1.data[10] -= 10;
				this.global1.data[7] -= 20;
				this.global1.data[6] -= 10;
				this.global1.data[22] -= 10;
			}
			else if (this.this_type == 34)
			{
				this.global1.allcountries[this.selected_country].Donat = true;
				this.global1.data[7]++;
				this.global1.data[8] -= 30;
				if (this.selected_country == 30)
				{
					this.global1.data[237]++;
				}
			}
			else if (this.this_type == 35)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.data[7]++;
				this.global1.data[10] += 5;
				this.global1.data[9] -= 20;
			}
			else if (this.this_type == 36)
			{
				this.global1.allcountries[this.selected_country].isSEV = true;
				this.global1.data[1] += 50;
				this.global1.data[10] += 10;
				this.global1.data[4] -= 20;
				if (this.global1.data[6] > 59)
				{
					this.global1.data[7] += 10;
				}
				else if (this.global1.data[6] < 40)
				{
					this.global1.data[7] -= 10;
				}
			}
			else if (this.this_type == 37)
			{
				this.global1.allcountries[this.selected_country].isOVD = true;
				this.global1.data[10] -= 10;
				this.global1.data[1] += 50;
				this.global1.data[4] -= 50;
				this.global1.data[2] -= 50;
				if (this.global1.data[6] > 79)
				{
					this.global1.data[7] += 20;
				}
				else if (this.global1.data[6] > 59 && this.global1.data[6] < 80)
				{
					this.global1.data[7] += 10;
				}
				else
				{
					this.global1.data[7] -= 10;
				}
			}
			else if (this.this_type == 38)
			{
				this.global1.allcountries[this.selected_country].Torg = true;
				this.global1.data[5] += 20;
				this.global1.data[3] += 25;
				this.global1.data[6] -= 5;
			}
			else if (this.this_type == 39)
			{
				this.global1.allcountries[this.selected_country].Vyshi = true;
				this.global1.data[10] -= 10;
				this.global1.data[7] -= 20;
				this.global1.data[6] -= 10;
				this.global1.data[22] -= 10;
			}
			else if (this.this_type == 40)
			{
				this.global1.allcountries[this.selected_country].Torg = true;
				this.global1.data[5] += 10;
				this.global1.data[3] += 10;
				this.global1.data[6] -= 5;
				this.global1.data[22] += 10;
			}
			else if (this.this_type == 41)
			{
				this.global1.allcountries[this.selected_country].isSEV = true;
				this.global1.data[22] += 10;
				this.global1.data[6] += 10;
				this.global1.data[2] -= 25;
				this.global1.data[1] += 25;
			}
			else if (this.this_type == 42)
			{
				this.global1.allcountries[this.selected_country].Torg = true;
				this.global1.data[6] += 25;
				this.global1.data[10] += 10;
				this.global1.data[2] -= 25;
			}
			else if (this.this_type == 57)
			{
				this.global1.data[59] = 1;
				this.global1.data[1] += 300;
				this.global1.data[2] -= 500;
				this.global1.data[3] += 200;
				this.global1.data[4] += 100;
				this.global1.data[5] -= 30;
				this.global1.data[6] += 300;
				this.global1.data[7] += 10;
				this.global1.data[8] -= 60;
				this.global1.data[9] -= 100;
				this.global1.data[10] += 500;
				this.global1.data[31] += 50;
			}
			else if (this.this_type == 58)
			{
				this.global1.allcountries[this.selected_country].Donat = true;
				this.global1.allcountries[this.selected_country].Westalgie -= 15;
				this.global1.data[8] -= 8;
				this.global1.data[9] -= 10;
				if (this.global1.allcountries[this.selected_country].Westalgie > 1000)
				{
					this.global1.allcountries[this.selected_country].Westalgie = 1000;
				}
				else if (this.global1.allcountries[this.selected_country].Westalgie < 0)
				{
					this.global1.allcountries[this.selected_country].Westalgie = 0;
				}
			}
			else if (this.this_type == 59)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.allcountries[this.selected_country].Westalgie += 25;
				this.global1.data[8] -= 8;
				this.global1.data[9] -= 10;
				if (this.global1.allcountries[this.selected_country].Westalgie > 1000)
				{
					this.global1.allcountries[this.selected_country].Westalgie = 1000;
				}
				else if (this.global1.allcountries[this.selected_country].Westalgie < 0)
				{
					this.global1.allcountries[this.selected_country].Westalgie = 0;
				}
			}
			else if (this.this_type == 60)
			{
				if (this.global1.allcountries[this.selected_country].Donat)
				{
					this.global1.allcountries[this.selected_country].Westalgie -= 5;
					this.global1.data[8] -= 20;
				}
				else
				{
					this.global1.allcountries[this.selected_country].Westalgie += 10;
					this.global1.data[8] -= 20;
				}
				if (this.global1.allcountries[this.selected_country].Westalgie > 1000)
				{
					this.global1.allcountries[this.selected_country].Westalgie = 1000;
				}
				else if (this.global1.allcountries[this.selected_country].Westalgie < 0)
				{
					this.global1.allcountries[this.selected_country].Westalgie = 0;
				}
			}
			else if (this.this_type == 61)
			{
				if (this.global1.data[28] > 0)
				{
					this.global1.data[28]--;
				}
				else if (this.global1.data[29] > 0)
				{
					this.global1.data[29]--;
				}
				this.global1.data[27]++;
				this.global1.data[1] -= (4 - this.global1.data[14]) * 50;
				this.global1.data[2] += (6 - this.global1.data[14]) * 15;
				this.global1.data[9] -= (6 - this.global1.data[14]) * 5;
				this.global1.data[3] += (6 - this.global1.data[14]) * 15;
				this.global1.data[4] += (6 - this.global1.data[14]) * 15;
				this.global1.data[22] -= 25;
				this.global1.data[6] -= (5 - this.global1.data[14]) * 10;
				this.global1.data[33] -= 25;
				this.global1.allcountries[this.global1.data[0]].Help = true;
			}
			else if (this.this_type == 62)
			{
				if (this.global1.data[27] > 0)
				{
					this.global1.data[27]--;
					this.global1.data[9] += 6 - this.global1.data[14];
					this.global1.data[3] += (2 - this.global1.data[14]) * 15;
					this.global1.data[4] += (2 - this.global1.data[14]) * 15;
					this.global1.data[22] += 10;
					this.global1.data[6] -= (2 - this.global1.data[14]) * 10;
				}
				else if (this.global1.data[29] > 0)
				{
					this.global1.data[29]--;
					this.global1.data[9] -= (6 - this.global1.data[14]) * 2;
					this.global1.data[3] += (6 - this.global1.data[14]) * 10;
					this.global1.data[4] += (5 - this.global1.data[14]) * 10;
					this.global1.data[6] -= (5 - this.global1.data[14]) * 10;
				}
				this.global1.data[28]++;
				this.global1.data[8] += 10;
				this.global1.allcountries[this.global1.data[0]].Help = true;
			}
			else if (this.this_type == 63)
			{
				if (this.global1.data[27] > 0)
				{
					this.global1.data[27]--;
				}
				else if (this.global1.data[28] > 0)
				{
					this.global1.data[28]--;
				}
				else if (this.global1.data[29] > 0)
				{
					this.global1.data[29]--;
				}
				this.global1.allcountries[this.global1.data[0]].Help = true;
				this.global1.data[1] += (3 - this.global1.data[14]) * 40;
				this.global1.data[3] -= (6 - this.global1.data[14]) * 15;
				this.global1.data[4] += (6 - this.global1.data[14]) * 15;
				this.global1.data[22] += 5;
				this.global1.data[6] += this.global1.data[14] * 10;
				this.global1.data[22] += 10;
			}
			else if (this.this_type == 64)
			{
				this.global1.allcountries[this.selected_country].Torg = true;
				this.global1.data[6] += 30;
				this.global1.data[10] += 50;
				this.global1.data[22] += 50;
			}
			else if (this.this_type == 65)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.data[2] -= 100;
				this.global1.data[9] += 15;
				this.global1.data[1] -= 50;
				this.global1.data[10] += 50;
				this.global1.data[7]++;
				this.global1.data[22]++;
			}
			else if (this.this_type == 66)
			{
				this.global1.allcountries[this.selected_country].Torg = true;
				this.global1.data[2] -= 100;
				this.global1.data[1] += 50;
				this.global1.data[10] += 50;
				this.global1.data[7]++;
				this.global1.data[22] += 50;
			}
			else if (this.this_type == 67)
			{
				this.global1.allcountries[this.selected_country].isSEV = true;
				this.global1.allcountries[this.selected_country].Vyshi = false;
				this.global1.data[4] -= 50;
				this.global1.data[1] += 100;
				this.global1.data[10] += 100;
				this.global1.data[7] += 5;
				this.global1.data[22] += 25;
				this.global1.data[9] += 25;
				this.global1.data[8] -= 30;
			}
			else if (this.this_type == 69)
			{
				this.global1.allcountries[this.selected_country].Donat = true;
				this.global1.data[8] -= 30;
				this.global1.data[10]++;
				this.global1.allcountries[46].Westalgie = 1;
			}
			else if (this.this_type == 70)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.data[9] -= 30;
				this.global1.data[10] += 10;
				this.global1.data[2] -= 100;
				this.global1.allcountries[46].Westalgie = 2;
			}
			else if (this.this_type == 71)
			{
				this.global1.allcountries[this.selected_country].Gosstroy = 0;
				this.global1.allcountries[this.selected_country].subideology = 4;
				this.global1.allcountries[this.selected_country].Torg = true;
				this.global1.data[9] -= 50;
				this.global1.data[8] -= 50;
				this.global1.data[10] += 100;
				this.global1.data[2] -= 100;
			}
			else if (this.this_type == 72)
			{
				this.global1.allcountries[this.selected_country].Donat = true;
				this.global1.data[8] -= 80;
				this.global1.data[10] += 10;
			}
			else if (this.this_type == 73)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.data[9] -= 150;
				this.global1.data[2] -= 500;
				this.global1.data[10] += 300;
			}
			else if (this.this_type == 74)
			{
				this.global1.allcountries[this.selected_country].Gosstroy = 1;
				this.global1.allcountries[this.selected_country].subideology = 10;
				this.global1.allcountries[this.selected_country].Torg = true;
				this.global1.data[7] += 50;
				this.global1.data[10] += 100;
			}
			else if (this.this_type == 75)
			{
				this.global1.allcountries[this.selected_country].Torg = false;
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.data[9] -= 100;
				this.global1.data[2] -= 200;
				this.global1.data[1] -= 100;
			}
			else if (this.this_type == 76)
			{
				this.global1.allcountries[this.selected_country].Donat = true;
				this.global1.allcountries[this.selected_country].Torg = true;
				this.global1.data[9] -= 50;
				this.global1.data[8] -= 50;
				this.global1.data[2] -= 200;
			}
			else if (this.this_type == 77)
			{
				this.global1.data[108] = 25;
				this.global1.number_event = 238;
				this.global1.speed = 0;
				this.map1.EventRead();
				SceneManager.LoadScene("Event");
			}
			else if (this.this_type == 78)
			{
				this.global1.data[108] += 25;
				this.global1.data[8] -= 30;
				this.global1.data[9] -= 50;
				this.global1.data[3] += 10;
			}
			else if (this.this_type == 79)
			{
				this.global1.allcountries[this.selected_country].Torg = true;
			}
			else if (this.this_type == 80)
			{
				this.global1.allcountries[this.selected_country].Money = true;
				this.global1.data[8] += 30;
				this.global1.data[4] += 50;
				this.global1.data[22] -= 50;
				this.global1.data[24] -= 3;
			}
			else if (this.this_type == 81)
			{
				this.global1.allcountries[this.selected_country].Gosstroy = 0;
				this.global1.allcountries[this.selected_country].subideology = 7;
				this.global1.data[6] += 15;
			}
			else if (this.this_type == 82)
			{
				this.global1.data[4] -= 50;
				this.global1.data[1] += 50;
				this.global1.data[165]++;
				this.global1.data[9] -= 50;
				this.global1.allcountries[17].Westalgie += 50;
				this.global1.allcountries[this.selected_country].Stasi = true;
			}
			else if (this.this_type == 83)
			{
				this.global1.data[4] -= 50;
				this.global1.data[165]++;
				this.global1.data[8] -= 50;
				this.global1.allcountries[17].Westalgie += 5;
				this.global1.data[7]++;
				this.global1.allcountries[this.selected_country].Money = true;
			}
			else if (this.this_type == 84)
			{
				this.global1.allcountries[this.selected_country].Torg = true;
				this.global1.data[4] += 5;
			}
			else if (this.this_type == 85)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.data[50]++;
				this.global1.data[8] -= 50;
			}
			else if (this.this_type == 86)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.allcountries[this.selected_country].isSEV = true;
				this.global1.allcountries[45].Torg = false;
				this.global1.data[22] += 10;
				this.global1.data[6] += 10;
				this.global1.data[2] -= 25;
				this.global1.data[1] += 25;
			}
			else if (this.this_type == 87)
			{
				this.global1.allcountries[this.selected_country].Help = true;
				this.global1.allcountries[53].Torg = false;
				this.global1.data[10] += 25;
				this.global1.data[6] -= 10;
				this.global1.data[7] += 2;
				this.global1.data[2] -= 250;
			}
			else if (this.this_type == 88)
			{
				this.global1.allcountries[this.selected_country].Torg = true;
				this.global1.data[22] += 10;
				this.global1.data[6] += 10;
				this.global1.data[2] -= 25;
				this.global1.data[1] += 25;
			}
			else if (this.this_type == 89)
			{
				this.global1.allcountries[this.selected_country].isSEV = true;
				if (this.selected_country == 25)
				{
					this.global1.allcountries[24].isSEV = true;
				}
				this.global1.data[22] += 10;
				this.global1.data[6] += 10;
				this.global1.data[10] += 20;
				this.global1.data[2] -= 50;
			}
			else if (this.this_type == 90)
			{
				this.global1.allcountries[this.selected_country].isSEV = true;
				this.global1.data[22] += 10;
				this.global1.data[6] += 10;
				this.global1.data[10] += 20;
				this.global1.data[2] -= 50;
			}
			else if (this.this_type == 91)
			{
				this.global1.allcountries[this.selected_country].isSEV = true;
				this.global1.data[22] += 10;
				this.global1.data[6] += 10;
				this.global1.data[10] += 20;
				this.global1.data[2] -= 50;
			}
			else if (this.this_type == 92)
			{
				this.global1.data[226]++;
				this.global1.data[227] = 1;
				this.global1.allcountries[this.selected_country].Torg = true;
			}
			else if (this.this_type == 93)
			{
				this.global1.allcountries[this.selected_country].Help = true;
				this.global1.data[230]++;
				this.global1.data[22] += 10;
				this.global1.data[6] -= 10;
				this.global1.data[10] -= 20;
				this.global1.data[1] -= 50;
				this.global1.data[9] -= 50;
			}
			else if (this.this_type == 94)
			{
				this.global1.allcountries[this.selected_country].Donat = true;
				this.global1.data[231]++;
				this.global1.data[22] += 10;
				this.global1.data[6] += 10;
				this.global1.data[10] += 5;
				this.global1.data[1] -= 50;
				this.global1.data[8] -= 50;
			}
			else if (this.this_type == 95)
			{
				this.global1.allcountries[this.selected_country].Torg = true;
				this.global1.allcountries[this.selected_country].subideology = 9;
				this.global1.data[22] += 10;
				this.global1.data[6] -= 20;
				this.global1.data[10] += 5;
				this.global1.data[1] += 50;
			}
			else if (this.this_type == 96)
			{
				this.global1.allcountries[this.selected_country].Donat = true;
				this.global1.data[9] -= 55;
				this.global1.data[6] += 15;
				this.global1.data[2] += 65;
				this.global1.data[1] -= 50;
				this.global1.data[10] += 75;
				this.global1.allcountries[17].Westalgie += 4;
				this.global1.allcountries[this.selected_country].Westalgie++;
			}
			else if (this.this_type == 97)
			{
				this.global1.allcountries[this.selected_country].Donat = true;
				this.global1.data[8] -= 30;
				this.global1.data[6] -= 25;
				this.global1.data[235]++;
				this.global1.data[1] += 50;
			}
			else if (this.this_type == 98)
			{
				if (this.selected_country == 37)
				{
					this.global1.allcountries[this.selected_country].Help = true;
				}
				else
				{
					this.global1.allcountries[this.selected_country].Donat = true;
				}
				this.global1.data[8] -= 30;
				this.global1.data[9] += 35;
				this.global1.data[23] += 2;
				this.global1.data[1] += 50;
				this.global1.data[2] -= 75;
			}
			else if (this.this_type == 99)
			{
				this.global1.allcountries[this.selected_country].Donat = true;
				this.global1.data[4] -= 20;
				this.global1.data[165]++;
				this.global1.data[8] -= 30;
				this.global1.data[1] += 50;
				this.global1.data[2] += 50;
				this.global1.allcountries[17].Westalgie += 30;
			}
			else if (this.this_type == 100)
			{
				if (this.global1.allcountries[46].Westalgie != 2 && ((this.global1.data[20] > 11 && this.global1.data[21] == 1989) || this.global1.data[21] >= 1990))
				{
					this.global1.allcountries[this.selected_country].Stasi = true;
					if (this.global1.allcountries[46].Donat)
					{
						this.global1.data[8] -= 30 * (this.global1.data[21] - 1988);
						this.global1.data[9] -= 30 * (this.global1.data[21] - 1988);
					}
					else
					{
						this.global1.data[8] -= 40 * (this.global1.data[21] - 1988);
						this.global1.data[9] -= 40 * (this.global1.data[21] - 1988);
					}
					this.global1.data[10]++;
					this.global1.data[10] += 10;
					this.global1.data[2] -= 100;
				}
				else
				{
					this.global1.allcountries[this.selected_country].Donat = true;
					this.global1.data[8] -= 80;
					this.global1.data[10]++;
				}
			}
			else if (this.this_type == 101)
			{
				this.global1.allcountries[this.selected_country].Money = true;
				this.global1.data[8] -= 30;
				this.global1.data[5] += 35;
				this.global1.data[22]++;
				this.global1.data[23] += 2;
				this.global1.data[1] += 50;
				this.global1.data[2] -= 25;
				this.global1.data[10] += 50;
				if (this.selected_country == 14)
				{
					this.global1.allcountries[14].Westalgie++;
				}
				else if (this.selected_country == 8)
				{
					this.global1.allcountries[8].Westalgie++;
				}
			}
			else if (this.this_type == 102)
			{
				this.global1.allcountries[this.selected_country].Help = true;
				this.global1.data[8] -= 50;
				this.global1.data[5] += 15;
				this.global1.data[22]++;
				this.global1.data[23] += 2;
				if (this.global1.allcountries[this.global1.data[0]].Gosstroy == 2)
				{
					this.global1.allcountries[30].Gosstroy = 2;
					this.global1.allcountries[30].subideology = 14;
					this.global1.data[10] -= 75;
					this.global1.data[2] -= 25;
				}
				else if (this.global1.allcountries[this.global1.data[0]].Gosstroy == 9)
				{
					this.global1.allcountries[30].Gosstroy = 9;
					if (this.global1.allcountries[this.global1.data[0]].subideology == 3 || this.global1.allcountries[this.global1.data[0]].subideology == 2)
					{
						this.global1.allcountries[30].subideology = 2;
					}
					else
					{
						this.global1.allcountries[30].subideology = 0;
					}
				}
				else
				{
					this.global1.allcountries[30].Gosstroy = 1;
					this.global1.allcountries[30].subideology = 10;
					this.global1.data[2] += 25;
					this.global1.allcountries[17].Westalgie += 15;
				}
			}
			else if (this.this_type == 103)
			{
				this.global1.allcountries[this.selected_country].Torg = false;
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.allcountries[this.selected_country].Money = false;
				this.global1.data[4] -= 20;
				this.global1.data[8] += 15;
				this.global1.data[1] += 25;
				this.global1.data[2] += 50;
			}
			else if (this.this_type == 104)
			{
				this.global1.allcountries[this.selected_country].Donat = true;
				this.global1.allcountries[this.selected_country].Westalgie -= 80;
				this.global1.data[8] -= 35;
				this.global1.data[9] -= 50;
				if (this.global1.allcountries[this.selected_country].Westalgie > 1000)
				{
					this.global1.allcountries[this.selected_country].Westalgie = 1000;
				}
				else if (this.global1.allcountries[this.selected_country].Westalgie < 0)
				{
					this.global1.allcountries[this.selected_country].Westalgie = 0;
				}
			}
			else if (this.this_type == 105)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.allcountries[this.selected_country].Westalgie += 130;
				this.global1.data[8] -= 35;
				this.global1.data[9] -= 50;
				if (this.global1.allcountries[this.selected_country].Westalgie > 1000)
				{
					this.global1.allcountries[this.selected_country].Westalgie = 1000;
				}
				else if (this.global1.allcountries[this.selected_country].Westalgie < 0)
				{
					this.global1.allcountries[this.selected_country].Westalgie = 0;
				}
			}
			else if (this.this_type == 106)
			{
				if (this.global1.allcountries[this.selected_country].Donat)
				{
					this.global1.allcountries[this.selected_country].Westalgie -= 30;
					this.global1.data[8] -= 80;
				}
				else
				{
					this.global1.allcountries[this.selected_country].Westalgie += 50;
					this.global1.data[8] -= 80;
				}
				if (this.global1.allcountries[this.selected_country].Westalgie > 1000)
				{
					this.global1.allcountries[this.selected_country].Westalgie = 1000;
				}
				else if (this.global1.allcountries[this.selected_country].Westalgie < 0)
				{
					this.global1.allcountries[this.selected_country].Westalgie = 0;
				}
			}
			else if (this.this_type == 107)
			{
				this.global1.allcountries[49].Help = true;
				this.global1.data[9] -= 15;
				this.global1.data[22] += 2;
				this.global1.data[1] -= 25;
				this.global1.data[6] -= 25;
				this.global1.data[4] += 25;
			}
			else if (this.this_type == 108)
			{
				this.global1.allcountries[49].Donat = true;
				this.global1.data[4] -= 20;
				this.global1.data[8] -= 30;
				this.global1.data[3] -= 25;
				this.global1.data[2] -= 50;
				this.global1.data[23] += 3;
				this.global1.data[7] -= 5;
			}
			else if (this.this_type == 109)
			{
				this.global1.allcountries[this.selected_country].Money = true;
				this.global1.data[4] -= 20;
				this.global1.data[8] -= 30;
				this.global1.data[5] += 25;
				this.global1.data[1] += 50;
				this.global1.data[24] += 3;
				this.global1.data[26] += 2;
			}
			else if (this.this_type == 110)
			{
				this.global1.allcountries[this.selected_country].Donat = true;
				this.global1.data[1] += 50;
				this.global1.data[4] -= 10;
				this.global1.data[7]++;
				this.global1.data[22]++;
				this.global1.data[31]++;
			}
			else if (this.this_type == 111)
			{
				this.global1.allcountries[this.selected_country].Help = true;
				this.global1.data[241]++;
				this.global1.data[9] -= 25;
				this.global1.data[8] -= 10;
				this.global1.data[7]++;
				this.global1.data[4] -= 10;
				this.global1.allcountries[17].Westalgie++;
			}
			else if (this.this_type == 112)
			{
				this.global1.allcountries[this.selected_country].Donat = true;
				this.global1.data[9] -= 30;
				this.global1.data[8] -= 30;
				this.global1.data[10] += 20;
				this.global1.data[7] += 4;
				this.global1.data[6] += 10;
				this.global1.allcountries[17].Westalgie += 15;
			}
			else if (this.this_type == 113)
			{
				this.global1.allcountries[7].Westalgie++;
				this.global1.data[9] -= 30;
				this.global1.data[7]++;
				this.global1.data[10] += 20;
				this.global1.allcountries[17].Westalgie -= 2;
				this.global1.data[242] = 1;
			}
			else if (this.this_type == 114)
			{
				this.global1.allcountries[this.selected_country].Donat = true;
				this.global1.data[1] += 50;
				this.global1.data[4] -= 10;
				this.global1.data[6] += 5;
				this.global1.data[22]++;
				this.global1.data[31]++;
				this.global1.data[8] -= 30;
				this.global1.data[9] -= 30;
			}
			else if (this.this_type == 115)
			{
				this.global1.allcountries[this.selected_country].Help = true;
				this.global1.data[1] += 50;
				this.global1.data[4] -= 10;
				this.global1.data[6] += 5;
				this.global1.data[22]++;
				this.global1.data[31]++;
				this.global1.data[8] -= 50;
				this.global1.allcountries[17].Westalgie -= 10;
				this.global1.allcountries[27].Westalgie++;
			}
			else if (this.this_type == 116)
			{
				this.global1.allcountries[this.selected_country].Money = true;
				this.global1.data[1] += 50;
				this.global1.data[4] -= 10;
				this.global1.data[6] += 5;
				this.global1.data[22]++;
				this.global1.data[31]++;
				this.global1.data[8] -= 50;
				this.global1.allcountries[27].Westalgie++;
			}
			else if (this.this_type == 117)
			{
				this.global1.allcountries[this.selected_country].Stasi = true;
				this.global1.data[1] += 50;
				this.global1.data[4] -= 10;
				this.global1.data[6] += 10;
				this.global1.data[22]++;
				this.global1.data[31]++;
				this.global1.data[9] -= 50;
				this.global1.data[10] += 100;
				this.global1.allcountries[17].Westalgie -= 50;
			}
			else if (this.this_type == 118)
			{
				this.global1.allcountries[27].Westalgie++;
				this.global1.data[1] += 50;
				this.global1.data[4] -= 10;
				this.global1.data[6] += 5;
				this.global1.data[22]++;
				this.global1.data[31]++;
				this.global1.data[8] -= 30;
				this.global1.data[9] -= 30;
			}
			else if (this.this_type == 119)
			{
				this.global1.allcountries[17].Westalgie -= 2;
				this.global1.data[1] -= 50;
				this.global1.data[4] += 70;
				this.global1.data[6] -= 5;
				this.global1.data[8]++;
				this.global1.data[9] -= 10;
				this.global1.data[10] -= 80;
				if (this.global1.data[10] < 0)
				{
					this.global1.data[10] = 0;
				}
				if (this.global1.data[15] != 9 || this.global1.data[38] < 10)
				{
					this.global1.data[38]++;
				}
				if (this.global1.data[16] != 13 || this.global1.data[39] < 10)
				{
					this.global1.data[39]++;
				}
				if (this.global1.data[17] != 17 || this.global1.data[40] < 10)
				{
					this.global1.data[40]++;
				}
				this.global1.allcountries[this.selected_country].Help = true;
			}
			else if (this.this_type == 120)
			{
				this.global1.allcountries[this.selected_country].Torg = true;
				this.global1.data[4] += 5;
			}
			if (this.selected_country < 40 || this.selected_country > 43)
			{
				this.global1.data[63]++;
			}
			this.map1.UpdateMap();
			this.map1.ShowHideOcno(false);
		}
	}

	// Token: 0x06000058 RID: 88 RVA: 0x0002BC24 File Offset: 0x00029E24
	private void OnMouseEnter()
	{
		if (this.is_active)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.on;
			this.opis.GetComponent<TextMesh>().text = this.Text(this.this_opis, 20);
			for (int i = 0; i < this.number_uslovie; i++)
			{
				this.uslovie[i].GetComponent<TextMesh>().text = this.Text(this.uslovie_text[i], 30);
				if (this.uslovie_bool[i])
				{
					this.uslovie[i].transform.Find("If").GetComponent<SpriteRenderer>().sprite = this.usl_on;
				}
				else
				{
					this.uslovie[i].transform.Find("If").GetComponent<SpriteRenderer>().sprite = this.usl_off;
				}
			}
		}
	}

	// Token: 0x06000059 RID: 89 RVA: 0x0002BD00 File Offset: 0x00029F00
	private void OnMouseExit()
	{
		if (this.is_active)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.off;
			this.opis.GetComponent<TextMesh>().text = null;
			for (int i = 0; i < 4; i++)
			{
				this.uslovie[i].GetComponent<TextMesh>().text = null;
				this.uslovie[i].transform.Find("If").GetComponent<SpriteRenderer>().sprite = null;
			}
		}
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00007820 File Offset: 0x00005A20
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

	// Token: 0x0400007C RID: 124
	public Sprite usl_off;

	// Token: 0x0400007D RID: 125
	public Sprite usl_on;

	// Token: 0x0400007E RID: 126
	private bool is_active;

	// Token: 0x0400007F RID: 127
	public GameObject opis;

	// Token: 0x04000080 RID: 128
	public GameObject[] uslovie = new GameObject[4];

	// Token: 0x04000081 RID: 129
	private bool[] uslovie_bool = new bool[4];

	// Token: 0x04000082 RID: 130
	private int number_uslovie;

	// Token: 0x04000083 RID: 131
	private string[] uslovie_text = new string[4];

	// Token: 0x04000084 RID: 132
	private string this_opis;

	// Token: 0x04000085 RID: 133
	public GlobalScript global1;

	// Token: 0x04000086 RID: 134
	private MapChangesScript map1;

	// Token: 0x04000087 RID: 135
	public Sprite on;

	// Token: 0x04000088 RID: 136
	public Sprite off;

	// Token: 0x04000089 RID: 137
	private int this_type = -1;

	// Token: 0x0400008A RID: 138
	public int selected_country = -1;
}
