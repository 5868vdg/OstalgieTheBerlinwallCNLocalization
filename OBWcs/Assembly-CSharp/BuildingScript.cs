using System;
using UnityEngine;

// Token: 0x02000008 RID: 8
public class BuildingScript : MonoBehaviour
{
	// Token: 0x06000020 RID: 32 RVA: 0x00007B10 File Offset: 0x00005D10
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		if (this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51)
		{
			this.yug1 = GameObject.Find("Yugoglobal(Clone)").GetComponent<Yugoglobal>();
		}
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00007B7C File Offset: 0x00005D7C
	public void Repaint()
	{
		if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_builded)
		{
			base.transform.Find("image").GetComponent<SpriteRenderer>().sprite = this.buildmanager1.sprites[this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type];
		}
		else if (this.this_number > 3 * this.global1.regions[this.buildmanager1.now_region].city_level - 1)
		{
			base.transform.Find("image").GetComponent<SpriteRenderer>().sprite = this.buildmanager1.empty_build;
		}
		else
		{
			base.transform.Find("image").GetComponent<SpriteRenderer>().sprite = this.buildmanager1.sprites[0];
		}
		if (this.buildmanager1.now_region == 2)
		{
			this.TextRepaint();
			return;
		}
		if (this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51)
		{
			if (this.yug1.gameState.yugregions[this.buildmanager1.yugreg[0]].level + 5 > this.this_number)
			{
				if (!this.buildmanager1.yugown[0])
				{
					base.GetComponent<OkoshkoScript>().text = "Владелец: " + this.yug1.gameState.yugcountries[this.yug1.gameState.yugregions[this.buildmanager1.yugreg[0]].owner].name + "\nРегион: " + this.yug1.gameState.yugregions[this.buildmanager1.yugreg[0]].name;
					base.GetComponent<OkoshkoScript>().text_en = " 拥 有 者: " + this.yug1.gameState.yugcountries[this.yug1.gameState.yugregions[this.buildmanager1.yugreg[0]].owner].name + "\n 地 区: " + this.yug1.gameState.yugregions[this.buildmanager1.yugreg[0]].name;
					return;
				}
				this.TextRepaint();
				return;
			}
			else if (this.yug1.gameState.yugregions[this.buildmanager1.yugreg[1]].level + 5 > this.this_number)
			{
				if (this.yug1.gameState.yugregions[this.buildmanager1.yugreg[1]].owner == 7 && this.yug1.gameState.yugregions[7].owner == 7 && this.global1.data[156] == 2 && this.global1.data[0] == 49)
				{
					this.TextRepaint();
					return;
				}
				if (!this.buildmanager1.yugown[1])
				{
					base.GetComponent<OkoshkoScript>().text = "Владелец: " + this.yug1.gameState.yugcountries[this.yug1.gameState.yugregions[this.buildmanager1.yugreg[1]].owner].name + "\nРегион: " + this.yug1.gameState.yugregions[this.buildmanager1.yugreg[1]].name;
					base.GetComponent<OkoshkoScript>().text_en = " 拥 有 者: " + this.yug1.gameState.yugcountries[this.yug1.gameState.yugregions[this.buildmanager1.yugreg[1]].owner].name + "\n 地 区: " + this.yug1.gameState.yugregions[this.buildmanager1.yugreg[1]].name;
					return;
				}
				this.TextRepaint();
				return;
			}
			else if (this.yug1.gameState.yugregions[this.buildmanager1.yugreg[2]].level + 5 > this.this_number)
			{
				if (this.yug1.gameState.yugregions[this.buildmanager1.yugreg[2]].owner == 2 && this.yug1.gameState.yugregions[2].owner == 2 && this.this_number > 2 && !this.yug1.gameState.yugcountries[2].is_exist && this.global1.event_done[274] && this.global1.data[0] == 51)
				{
					this.TextRepaint();
					return;
				}
				if (this.yug1.gameState.yugregions[this.buildmanager1.yugreg[2]].owner == 2 && this.yug1.gameState.yugregions[2].owner == 2 && this.yug1.gameState.yugcountries[2].is_exist && this.global1.data[150] == 1 && this.global1.data[0] == 49)
				{
					this.TextRepaint();
					return;
				}
				if (!this.buildmanager1.yugown[2])
				{
					base.GetComponent<OkoshkoScript>().text = "Владелец: " + this.yug1.gameState.yugcountries[this.yug1.gameState.yugregions[this.buildmanager1.yugreg[2]].owner].name + "\nРегион: " + this.yug1.gameState.yugregions[this.buildmanager1.yugreg[2]].name;
					base.GetComponent<OkoshkoScript>().text_en = " 拥 有 者: " + this.yug1.gameState.yugcountries[this.yug1.gameState.yugregions[this.buildmanager1.yugreg[2]].owner].name + "\n 地 区: " + this.yug1.gameState.yugregions[this.buildmanager1.yugreg[2]].name;
					return;
				}
				this.TextRepaint();
				return;
			}
		}
		else
		{
			this.TextRepaint();
		}
	}

	// Token: 0x06000022 RID: 34 RVA: 0x000081EC File Offset: 0x000063EC
	private void TextRepaint()
	{
		if (!this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_builded && this.this_number <= 3 * this.global1.regions[this.buildmanager1.now_region].city_level - 1)
		{
			base.GetComponent<OkoshkoScript>().text = "Пусто";
			base.GetComponent<OkoshkoScript>().text_en = " 空";
			return;
		}
		if (!this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_builded && this.this_number > 3 * this.global1.regions[this.buildmanager1.now_region].city_level - 1)
		{
			base.GetComponent<OkoshkoScript>().text = "Нет мест";
			base.GetComponent<OkoshkoScript>().text_en = " 没 有 位 置";
			return;
		}
		if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_private)
		{
			base.GetComponent<OkoshkoScript>().text = "<color=red>Приватизировано</color>\nЕжемесячно Вестальгии: +0." + (13 - this.global1.data[16]).ToString() + "\n";
			base.GetComponent<OkoshkoScript>().text_en = "<color=red> 已 私 有 化</color>\n 每 月 西 方 情 结: +0." + (13 - this.global1.data[16]).ToString() + "\n";
		}
		else if (!this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_working)
		{
			base.GetComponent<OkoshkoScript>().text = "<color=red>Приостановлено</color>\n";
			base.GetComponent<OkoshkoScript>().text_en = "<color=red> 已 停 用</color>\n";
		}
		else
		{
			base.GetComponent<OkoshkoScript>().text = "<color=lime>Работает</color>\n";
			base.GetComponent<OkoshkoScript>().text_en = "<color=lime> 启 用 中</color>\n";
		}
		if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 1)
		{
			if (this.global1.data[0] != 18)
			{
				OkoshkoScript component = base.GetComponent<OkoshkoScript>();
				component.text += "<color=yellow>Сельхоз учреждение\n</color>";
				OkoshkoScript component2 = base.GetComponent<OkoshkoScript>();
				component2.text_en += "<color=yellow> 农 业 设 施\n</color>";
			}
			else
			{
				OkoshkoScript component3 = base.GetComponent<OkoshkoScript>();
				component3.text += "<color=yellow>Плантация\n</color>";
				OkoshkoScript component4 = base.GetComponent<OkoshkoScript>();
				component4.text_en += "<color=yellow> 种 植 园\n</color>";
			}
			OkoshkoScript component5 = base.GetComponent<OkoshkoScript>();
			component5.text += "Еженедельно: Бюджет +0.1;\nУровень жизни +0.1;";
			OkoshkoScript component6 = base.GetComponent<OkoshkoScript>();
			component6.text_en += " 每 周 ：  预 算 +0.1;\n 生 活 条 件 +0.1;";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 2)
		{
			OkoshkoScript component7 = base.GetComponent<OkoshkoScript>();
			component7.text += "<color=yellow>Промышленность\n</color>";
			OkoshkoScript component8 = base.GetComponent<OkoshkoScript>();
			component8.text_en += "<color=yellow> 工 业\n</color>";
			OkoshkoScript component9 = base.GetComponent<OkoshkoScript>();
			component9.text += "Еженедельно: Бюджет +0.2; Вестальгия +0.1;";
			OkoshkoScript component10 = base.GetComponent<OkoshkoScript>();
			component10.text_en += " 每 周 ：  预 算 +0.2;   西 方 情 结+0.1;";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 3)
		{
			OkoshkoScript component11 = base.GetComponent<OkoshkoScript>();
			component11.text += "<color=yellow>Завод электроники\n</color>";
			OkoshkoScript component12 = base.GetComponent<OkoshkoScript>();
			component12.text_en += "<color=yellow> 电 子 工 厂\n</color>";
			if (this.global1.science[2] && this.global1.science[5] && this.global1.science[8] && this.global1.science[9] && this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
			{
				OkoshkoScript component13 = base.GetComponent<OkoshkoScript>();
				component13.text += "Еженедельно: Бюджет -0.3; Вестальгия -0.2;\nУровень жизни +0.2;";
				OkoshkoScript component14 = base.GetComponent<OkoshkoScript>();
				component14.text_en += " 每 周 ：  预 算 -0.3;  西 方 情 结 -0.2;\n 生 活 条 件 +0.2;";
			}
			else if (this.global1.science[2] && this.global1.science[5] && this.global1.science[8])
			{
				OkoshkoScript component15 = base.GetComponent<OkoshkoScript>();
				component15.text += "Еженедельно: Бюджет -0.2; Вестальгия -0.2;\nУровень жизни +0.1;";
				OkoshkoScript component16 = base.GetComponent<OkoshkoScript>();
				component16.text_en += " 每 周 ：  预 算 -0.2;  西 方 情 结 -0.2;\n 生 活 条 件 +0.1;";
			}
			else
			{
				OkoshkoScript component17 = base.GetComponent<OkoshkoScript>();
				component17.text += "Еженедельно: Бюджет -0.2; Вестальгия -0.1;\nУровень жизни +0.1;\nРазвивает науку;";
				OkoshkoScript component18 = base.GetComponent<OkoshkoScript>();
				component18.text_en += " 每 周 ：  预 算 -0.2;  西 方 情 结 -0.1;\n 生 活 条 件 +0.1;\n 发 展 科 学;";
			}
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 4)
		{
			OkoshkoScript component19 = base.GetComponent<OkoshkoScript>();
			component19.text += "<color=yellow>Военная база\n</color>";
			OkoshkoScript component20 = base.GetComponent<OkoshkoScript>();
			component20.text_en += "<color=yellow> 陆 军 基 地\n</color>";
			OkoshkoScript component21 = base.GetComponent<OkoshkoScript>();
			component21.text += "Еженедельно: Бюджет -0.2; Вестальгия -0.2;\nАгентурная сеть +0.2;";
			OkoshkoScript component22 = base.GetComponent<OkoshkoScript>();
			component22.text_en += " 每 周 ：  预 算 -0.2;  西 方 情 结 -0.2;\n 间 谍 网 络 +0.2;";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 5)
		{
			OkoshkoScript component23 = base.GetComponent<OkoshkoScript>();
			component23.text += "<color=yellow>Алкогольный завод\n</color>";
			OkoshkoScript component24 = base.GetComponent<OkoshkoScript>();
			component24.text_en += "<color=yellow> 酒 精 工 厂\n</color>";
			OkoshkoScript component25 = base.GetComponent<OkoshkoScript>();
			component25.text += "Еженедельно: Поддержка народа +0.2; Вестальгия +0.2;";
			OkoshkoScript component26 = base.GetComponent<OkoshkoScript>();
			component26.text_en += " 每 周:  人 民 支 持 +0.2;  西 方 情 结 +0.2;";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 6)
		{
			OkoshkoScript component27 = base.GetComponent<OkoshkoScript>();
			component27.text += "<color=yellow>Частное предприятие\n</color>";
			OkoshkoScript component28 = base.GetComponent<OkoshkoScript>();
			component28.text_en += "<color=yellow> 私 营 部 门\n</color>";
			OkoshkoScript component29 = base.GetComponent<OkoshkoScript>();
			component29.text += "Каждые 2 месяца: Деньги +0.1;\nВестальгия +0.1;";
			OkoshkoScript component30 = base.GetComponent<OkoshkoScript>();
			component30.text_en += " 每 两 个 月:   预 算 +0.1;\n 西 方 情 结 +0.1;";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 7)
		{
			OkoshkoScript component31 = base.GetComponent<OkoshkoScript>();
			component31.text += "<color=yellow>Ядерный полигон\n</color>";
			OkoshkoScript component32 = base.GetComponent<OkoshkoScript>();
			component32.text_en += "<color=yellow> 核 试 验 场\n</color>";
			OkoshkoScript component33 = base.GetComponent<OkoshkoScript>();
			component33.text += "Еженедельно:\nЕдинство Партии +0.1; Поддержка народа +0.1;\nНедовольство НАТО +0.2; Одобрение СССР -0.2;";
			OkoshkoScript component34 = base.GetComponent<OkoshkoScript>();
			component34.text_en += " 每 周:\n 党 内 团 结 +0.1;  人 民 支 持 +0.1;\n 北 约 不 满 +0.2;  苏 联 认 可 -0.2;";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 8)
		{
			OkoshkoScript component35 = base.GetComponent<OkoshkoScript>();
			component35.text += "<color=yellow>Штаб-квартира спецслужб\n</color>";
			OkoshkoScript component36 = base.GetComponent<OkoshkoScript>();
			component36.text_en += "<color=yellow> 特 勤 总 部\n</color>";
			OkoshkoScript component37 = base.GetComponent<OkoshkoScript>();
			component37.text += "Еженедельно: Бюджет -0.2; Вестальгия -0.2;";
			OkoshkoScript component38 = base.GetComponent<OkoshkoScript>();
			component38.text_en += " 每 周:  预 算 -0.2;  西 方 情 结 -0.2;";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 9)
		{
			OkoshkoScript component39 = base.GetComponent<OkoshkoScript>();
			component39.text += "<color=yellow>НИИ\n</color>";
			OkoshkoScript component40 = base.GetComponent<OkoshkoScript>();
			component40.text_en += "<color=yellow> 研 究 机 构\n</color>";
			OkoshkoScript component41 = base.GetComponent<OkoshkoScript>();
			component41.text += "Еженедельно: Бюджет -0.1;\nРазвивает науку;";
			OkoshkoScript component42 = base.GetComponent<OkoshkoScript>();
			component42.text_en += " 每 周:  预 算 -0.1;\n 发 展 科 学;";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 10)
		{
			OkoshkoScript component43 = base.GetComponent<OkoshkoScript>();
			component43.text += "<color=yellow>Штаб внешней разведки\n</color>";
			OkoshkoScript component44 = base.GetComponent<OkoshkoScript>();
			component44.text_en += "<color=yellow> 对 外 情 报 局\n</color>";
			OkoshkoScript component45 = base.GetComponent<OkoshkoScript>();
			component45.text += "Еженедельно: Бюджет -0.2; Агентурная сеть +0.2;";
			OkoshkoScript component46 = base.GetComponent<OkoshkoScript>();
			component46.text_en += " 每 周:  预 算 -0.2;  间 谍 网 络 +0.2;";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 11)
		{
			OkoshkoScript component47 = base.GetComponent<OkoshkoScript>();
			component47.text += "<color=yellow>Телецентр\n</color>";
			OkoshkoScript component48 = base.GetComponent<OkoshkoScript>();
			component48.text_en += "<color=yellow> 电 视 中 心\n</color>";
			OkoshkoScript component49 = base.GetComponent<OkoshkoScript>();
			component49.text += "Еженедельно: Бюджет -0.2; Поддержка народа +0.2;";
			OkoshkoScript component50 = base.GetComponent<OkoshkoScript>();
			component50.text_en += " 每 周:  预 算 -0.2;  人 民 支 持 +0.2;";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 12)
		{
			OkoshkoScript component51 = base.GetComponent<OkoshkoScript>();
			component51.text += "<color=yellow>Берлинская стена\n</color>";
			OkoshkoScript component52 = base.GetComponent<OkoshkoScript>();
			component52.text_en += "<color=yellow> 柏 林 墙\n</color>";
			OkoshkoScript component53 = base.GetComponent<OkoshkoScript>();
			component53.text += "Еженедельно: Одобрение СССР -0.1; Вестальгия -0.2;\nАгентурная сеть +0.2;";
			OkoshkoScript component54 = base.GetComponent<OkoshkoScript>();
			component54.text_en += " 每 周:  苏 联 认 可 -0.1;  西 方 情 结 -0.2;\n 间 谍 网 络 +0.2;";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 13)
		{
			OkoshkoScript component55 = base.GetComponent<OkoshkoScript>();
			component55.text += "<color=yellow>Бузлуджа\n</color>";
			OkoshkoScript component56 = base.GetComponent<OkoshkoScript>();
			component56.text_en += "<color=yellow> 布 兹 卢 达 纪 念 碑\n</color>";
			OkoshkoScript okoshkoScript = base.GetComponent<OkoshkoScript>();
			okoshkoScript.text = string.Concat(new string[]
			{
				okoshkoScript.text,
				"Еженедельно: Единство Партии +0.4; Бюджет +0.1; \nПоддержка народа ",
				(this.global1.data[1] < 500) ? "0." : "+0.",
				((this.global1.data[1] - 500) / 250).ToString(),
				"; Вестальгия ",
				(this.global1.data[1] < 500) ? "0." : "+0.",
				((this.global1.data[1] - 500) / 250).ToString(),
				";"
			});
			okoshkoScript = base.GetComponent<OkoshkoScript>();
			okoshkoScript.text_en = string.Concat(new string[]
			{
				okoshkoScript.text_en,
				" 每 周:  党 内 团 结 +0.4;  预 算 +0.1; \n 人 民 支 持 ",
				(this.global1.data[1] < 500) ? "0." : "+0.",
				((this.global1.data[1] - 500) / 250).ToString(),
				"; 西 方 情 结 ",
				(this.global1.data[1] < 500) ? "0." : "+0.",
				((this.global1.data[1] - 500) / 250).ToString(),
				";"
			});
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 14)
		{
			OkoshkoScript component57 = base.GetComponent<OkoshkoScript>();
			component57.text += "<color=yellow>Институт атомной энергетики\n</color>";
			OkoshkoScript component58 = base.GetComponent<OkoshkoScript>();
			component58.text_en += "<color=yellow> 核 能 研 究 所\n</color>";
			OkoshkoScript component59 = base.GetComponent<OkoshkoScript>();
			component59.text += "Еженедельно: Единство Партии +0.4; Суверенитет +0.2;\nНедовольство НАТО +0.1; Одобрение СССР -0.1;";
			OkoshkoScript component60 = base.GetComponent<OkoshkoScript>();
			component60.text_en += " 每 周:  党 内 团 结 +0.4;  主 权 +0.2;\n 北 约 不 满 +0.1;  苏 联 认 可 -0.1;";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 15)
		{
			OkoshkoScript component61 = base.GetComponent<OkoshkoScript>();
			component61.text += "<color=yellow>Генномодифицированная ферма\n</color>";
			OkoshkoScript component62 = base.GetComponent<OkoshkoScript>();
			component62.text_en += "<color=yellow> 转 基 因 农 场\n</color>";
			OkoshkoScript component63 = base.GetComponent<OkoshkoScript>();
			component63.text += "Еженедельно: Бюджет +0.3;\nПоддержка народа -0.1;\nУровень жизни +0.2;";
			OkoshkoScript component64 = base.GetComponent<OkoshkoScript>();
			component64.text_en += " 每 周:  预 算 +0.3;\n 人 民 支 持 -0.1;\n 生 活 条 件 +0.2;";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 16)
		{
			OkoshkoScript component65 = base.GetComponent<OkoshkoScript>();
			component65.text += "<color=yellow>Киберсин\n</color>";
			OkoshkoScript component66 = base.GetComponent<OkoshkoScript>();
			component66.text_en += "<color=yellow> 网 络 同 步 系 统\n</color>";
			OkoshkoScript component67 = base.GetComponent<OkoshkoScript>();
			component67.text += "Еженедельно: Бюджет +0.2; Вестальгия -0.1;\nУровень жизни +0.1;\nРазвивает науку;";
			OkoshkoScript component68 = base.GetComponent<OkoshkoScript>();
			component68.text_en += " 每 周:  预 算 +0.2;  西 方 情 结 -0.1;\n 生 活 条 件 +0.1;\n 发 展 科 学;";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 17)
		{
			OkoshkoScript component69 = base.GetComponent<OkoshkoScript>();
			component69.text += "<color=yellow>Площадь Ленина\n</color>";
			OkoshkoScript component70 = base.GetComponent<OkoshkoScript>();
			component70.text_en += "<color=yellow> 列 宁 广 场\n</color>";
			if (this.global1.data[0] < 49 || this.global1.data[0] > 51)
			{
				OkoshkoScript component71 = base.GetComponent<OkoshkoScript>();
				component71.text += "<color=red>1 на регион\n</color>";
				OkoshkoScript component72 = base.GetComponent<OkoshkoScript>();
				component72.text_en += "<color=red> 每 地 区 限 一 个\n</color>";
			}
			if (this.global1.data[14] < 3)
			{
				OkoshkoScript component73 = base.GetComponent<OkoshkoScript>();
				component73.text += "Ежемесячно: Поддержка народа +0.1;";
				OkoshkoScript component74 = base.GetComponent<OkoshkoScript>();
				component74.text_en += " 每 月:  人 民 支 持 +0.1;";
			}
			else if (this.global1.data[14] > 3)
			{
				OkoshkoScript component75 = base.GetComponent<OkoshkoScript>();
				component75.text += "Ежемесячно: Поддержка народа -0.1;";
				OkoshkoScript component76 = base.GetComponent<OkoshkoScript>();
				component76.text_en += " 每 月:  人 民 支 持 -0.1;";
			}
			else
			{
				OkoshkoScript component77 = base.GetComponent<OkoshkoScript>();
				component77.text += "Ничего;";
				OkoshkoScript component78 = base.GetComponent<OkoshkoScript>();
				component78.text_en += " 无;";
			}
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 18)
		{
			OkoshkoScript component79 = base.GetComponent<OkoshkoScript>();
			component79.text += "<color=yellow>Соляная шахта (Величка)\n</color>";
			OkoshkoScript component80 = base.GetComponent<OkoshkoScript>();
			component80.text_en += "<color=yellow> 维 利 奇 卡 盐 矿\n</color>";
			OkoshkoScript component81 = base.GetComponent<OkoshkoScript>();
			component81.text += "Еженедельно: Бюджет +0.3;\nПоддержка народа +0.1; \nНедовольство НАТО -0.1;";
			OkoshkoScript component82 = base.GetComponent<OkoshkoScript>();
			component82.text_en += " 每 周:  预 算 +0.3;\n 人 民 支 持 +0.1;\n 北 约 不 满 -0.1;";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 19)
		{
			OkoshkoScript component83 = base.GetComponent<OkoshkoScript>();
			component83.text += "<color=yellow>Országház\n</color>";
			OkoshkoScript component84 = base.GetComponent<OkoshkoScript>();
			component84.text_en += "<color=yellow> 匈 牙 利 国 会 大 厦\n</color>";
			OkoshkoScript component85 = base.GetComponent<OkoshkoScript>();
			component85.text += "Еженедельно: Единство партии +0.3;\nСуверенитет +0.1; Вестальгия +0.3\nНедовольство НАТО -0.1; Одобрение СССР +0.1";
			OkoshkoScript component86 = base.GetComponent<OkoshkoScript>();
			component86.text_en += " 每 周:  党 内 团 结 +0.3;\n 主 权 +0.1;  西 方 情 结 +0.3\n 北 约 不 满 -0.1;  苏 联 认 可 +0.1";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 20)
		{
			OkoshkoScript component87 = base.GetComponent<OkoshkoScript>();
			component87.text += "<color=yellow>Автомобильный мегаконцерн\n</color>";
			OkoshkoScript component88 = base.GetComponent<OkoshkoScript>();
			component88.text_en += "<color=yellow> 汽 车 巨 头 集 团\n</color>";
			OkoshkoScript component89 = base.GetComponent<OkoshkoScript>();
			component89.text += "Еженедельно: Поддержка народа +0.2;\nВестальгия -0.2; \nУровень жизни +0.1; Бюджет - 0.3";
			OkoshkoScript component90 = base.GetComponent<OkoshkoScript>();
			component90.text_en += " 每 周:  人 民 支 持 +0.2;\n 西 方 情 结 -0.2;\n 生 活 条 件 +0.1;  预 算 - 0.3";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 21)
		{
			OkoshkoScript component91 = base.GetComponent<OkoshkoScript>();
			component91.text += "<color=yellow>Сеть бункеров\n</color>";
			OkoshkoScript component92 = base.GetComponent<OkoshkoScript>();
			component92.text_en += "<color=yellow> 碉 堡 群\n</color>";
			OkoshkoScript component93 = base.GetComponent<OkoshkoScript>();
			component93.text += "Ежемесячно: Бюджет - 0.5;\nУровень жизни -1; Суверенитет +0.5;\nВестальгия +3; Агентурная сеть +1;";
			OkoshkoScript component94 = base.GetComponent<OkoshkoScript>();
			component94.text_en += " 每 月:  预 算 - 0.5;\n 生 活 条 件 -1;  主 权 +0.5\n 西 方 情 结 +3;  间 谍 网 络 +1;";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 22)
		{
			OkoshkoScript component95 = base.GetComponent<OkoshkoScript>();
			component95.text += "<color=yellow>Монумент идей Чучхе\n</color>";
			OkoshkoScript component96 = base.GetComponent<OkoshkoScript>();
			component96.text_en += "<color=yellow> 主 体 塔\n</color>";
			OkoshkoScript component97 = base.GetComponent<OkoshkoScript>();
			component97.text += "Еженедельно: Поддержка народа +0.2;\nБюджет -0.1; Вестальгия -0.2;";
			OkoshkoScript component98 = base.GetComponent<OkoshkoScript>();
			component98.text_en += " 每 周:  人 民 支 持 +0.2;\n 预 算 - 0.1;  西 方 情 结 -0.2;";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 24)
		{
			OkoshkoScript component99 = base.GetComponent<OkoshkoScript>();
			component99.text += "<color=yellow>Генеральный штаб\n</color>";
			OkoshkoScript component100 = base.GetComponent<OkoshkoScript>();
			component100.text_en += "<color=yellow> 总 参 谋 部\n</color>";
			OkoshkoScript component101 = base.GetComponent<OkoshkoScript>();
			component101.text += "Еженедельно: Поддержка народа +0.2;\nАгентурная сеть +0.5; Единство партии +0.4;";
			OkoshkoScript component102 = base.GetComponent<OkoshkoScript>();
			component102.text_en += " 每 周:  人 民 支 持 +0.2;\n 间 谍 网 络 +0.5;  党 内 团 结 +0.4;";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 37)
		{
			OkoshkoScript component103 = base.GetComponent<OkoshkoScript>();
			component103.text += "<color=yellow>Центральный памятник маршалу Тито\n</color>";
			OkoshkoScript component104 = base.GetComponent<OkoshkoScript>();
			component104.text_en += "<color=yellow> 铁 托 元 帅 中 央 纪 念 碑\n</color>";
			if (this.global1.data[160] == 1)
			{
				OkoshkoScript component105 = base.GetComponent<OkoshkoScript>();
				component105.text += "Ежемесячно: Поддержка народа +0.1; Единство партии +0.1";
				OkoshkoScript component106 = base.GetComponent<OkoshkoScript>();
				component106.text_en += " 每 月:  人 民 支 持 +0.1;  党 内 团 结 +0.1";
			}
			else if (this.global1.data[160] == 2)
			{
				OkoshkoScript component107 = base.GetComponent<OkoshkoScript>();
				component107.text += "Ежемесячно: Поддержка народа -0.1;";
				OkoshkoScript component108 = base.GetComponent<OkoshkoScript>();
				component108.text_en += " 每 月:  人 民 支 持 -0.1;";
			}
			else
			{
				OkoshkoScript component109 = base.GetComponent<OkoshkoScript>();
				component109.text += "Еженедельно: Поддержка народа +0.1;";
				OkoshkoScript component110 = base.GetComponent<OkoshkoScript>();
				component110.text_en += " 每 周:  人 民 支 持 +0.1;";
			}
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 38)
		{
			OkoshkoScript okoshkoScript2 = base.GetComponent<OkoshkoScript>();
			okoshkoScript2.text = string.Concat(new object[]
			{
				okoshkoScript2.text,
				"<color=yellow>Городская ячейка",
				1 + this.buildmanager1.now_region * 100 + this.this_number * 10,
				"\n</color>"
			});
			okoshkoScript2 = base.GetComponent<OkoshkoScript>();
			okoshkoScript2.text_en = string.Concat(new object[]
			{
				okoshkoScript2.text_en,
				"<color=yellow> 城 市 单 元",
				1 + this.buildmanager1.now_region * 100 + this.this_number * 10,
				"\n</color>"
			});
			OkoshkoScript component111 = base.GetComponent<OkoshkoScript>();
			component111.text += "Ежемесячно: Уровень жизни +0.5; Единство партии +0.5;\n Поддержка населения +0.5";
			OkoshkoScript component112 = base.GetComponent<OkoshkoScript>();
			component112.text_en += " 每 月:  生 活 条 件 +0.5;  党 内 团 结 +0.5;\n  人 民 支 持 +0.5";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 39)
		{
			OkoshkoScript component113 = base.GetComponent<OkoshkoScript>();
			component113.text += "<color=yellow>Правительственный модуль №15\n</color>";
			OkoshkoScript component114 = base.GetComponent<OkoshkoScript>();
			component114.text_en += "<color=yellow> 政 府 模 块 第15 号\n</color>";
			OkoshkoScript component115 = base.GetComponent<OkoshkoScript>();
			component115.text += "Ежемесячно: Вестальгия -1; Единство партии +1";
			OkoshkoScript component116 = base.GetComponent<OkoshkoScript>();
			component116.text_en += " 每 月:  西 方 情 结 -1;  党 内 团 结 +1";
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 23)
		{
			if (!this.global1.allcountries[7].Vyshi)
			{
				OkoshkoScript component117 = base.GetComponent<OkoshkoScript>();
				component117.text += "<color=yellow>Советская военная база\n</color>";
				OkoshkoScript component118 = base.GetComponent<OkoshkoScript>();
				component118.text_en += "<color=yellow> 苏 联 军 事 基 地\n</color>";
				OkoshkoScript component119 = base.GetComponent<OkoshkoScript>();
				component119.text += "Еженедельно: Агентурные сети +0.2;\nНедовольство НАТО -0.2;\nОдобрение СССР +0.4; Суверенитет -0.2;";
				OkoshkoScript component120 = base.GetComponent<OkoshkoScript>();
				component120.text_en += " 每 周:  间 谍 网 络 +0.2;\n 北 约 不 满 -0.2;\n 苏 联 认 可 +0.4;  主 权 -0.2;";
			}
			else
			{
				OkoshkoScript component121 = base.GetComponent<OkoshkoScript>();
				component121.text += "<color=yellow>Российская военная база\n</color>";
				OkoshkoScript component122 = base.GetComponent<OkoshkoScript>();
				component122.text_en += "<color=yellow> 俄 罗 斯 军 事 基 地\n</color>";
				OkoshkoScript component123 = base.GetComponent<OkoshkoScript>();
				component123.text += "Одобрение России +0.4;\nБюджет -0.1;";
				OkoshkoScript component124 = base.GetComponent<OkoshkoScript>();
				component124.text_en += " 俄 罗 斯 认 可 +0.4;\n 预 算 - 0.1;";
			}
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type < 37 && this.global1.data[216] <= 49)
		{
			OkoshkoScript component125 = base.GetComponent<OkoshkoScript>();
			component125.text += string.Format(this.yug1.science_text[41 + this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type], '\n', "<color=yellow>", "</color>");
			OkoshkoScript component126 = base.GetComponent<OkoshkoScript>();
			component126.text_en += string.Format(this.yug1.science_text[41 + this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type], '\n', "<color=yellow>", "</color>");
		}
		if (this.buildmanager1.now_region != 2 && (this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51))
		{
			if (this.yug1.gameState.yugregions[this.buildmanager1.yugreg[0]].level + 5 > this.this_number)
			{
				OkoshkoScript component127 = base.GetComponent<OkoshkoScript>();
				component127.text = component127.text + "\nРегион: " + this.yug1.gameState.yugregions[this.buildmanager1.yugreg[0]].name;
				OkoshkoScript component128 = base.GetComponent<OkoshkoScript>();
				component128.text_en = component128.text_en + "\n 地 区: " + this.yug1.gameState.yugregions[this.buildmanager1.yugreg[0]].name;
				return;
			}
			if (this.yug1.gameState.yugregions[this.buildmanager1.yugreg[1]].level + 5 > this.this_number)
			{
				OkoshkoScript component129 = base.GetComponent<OkoshkoScript>();
				component129.text = component129.text + "\nРегион: " + this.yug1.gameState.yugregions[this.buildmanager1.yugreg[1]].name;
				OkoshkoScript component130 = base.GetComponent<OkoshkoScript>();
				component130.text_en = component130.text_en + "\n 地 区: " + this.yug1.gameState.yugregions[this.buildmanager1.yugreg[1]].name;
				return;
			}
			if (this.yug1.gameState.yugregions[this.buildmanager1.yugreg[2]].level + 5 > this.this_number)
			{
				OkoshkoScript component131 = base.GetComponent<OkoshkoScript>();
				component131.text = component131.text + "\nРегион: " + this.yug1.gameState.yugregions[this.buildmanager1.yugreg[2]].name;
				OkoshkoScript component132 = base.GetComponent<OkoshkoScript>();
				component132.text_en = component132.text_en + "\n 地 区: " + this.yug1.gameState.yugregions[this.buildmanager1.yugreg[2]].name;
			}
		}
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00009CF4 File Offset: 0x00007EF4
	public void DoSomething(int thing)
	{
		if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_builded)
		{
			if (thing == 0)
			{
				if ((this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type < 7 || this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type > 9 || (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 9 && this.global1.data[16] > 11)) && (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type != 4 || (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 4 && this.global1.data[16] > 11)) && (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type < 12 || this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 15) && this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type != 10 && !this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_private && (this.global1.data[16] > 11 || this.global1.data[8] < 0))
				{
					if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 1)
					{
						this.global1.data[8] += 20;
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 2)
					{
						this.global1.data[8] += 10;
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 3)
					{
						this.global1.data[8] += 20;
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 4)
					{
						this.global1.data[8] += 30;
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 5)
					{
						this.global1.data[8] += 20;
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 6)
					{
						this.global1.data[8] += 10;
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 9)
					{
						this.global1.data[8] += 30;
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 11)
					{
						this.global1.data[8] += 30;
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 15)
					{
						this.global1.data[8] += 30;
					}
					this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_private = true;
					this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_working = true;
					if (this.global1.data[16] <= 11)
					{
						this.global1.data[39] += 2;
						this.global1.data[33] -= 10;
						this.global1.data[1] -= 50;
						this.global1.data[2] += 10;
						this.global1.data[22] -= 4;
						this.global1.data[10] -= 2;
						this.global1.data[6] -= 4;
						this.global1.data[3] += 30;
						this.global1.data[4] += 10;
					}
					else if (this.global1.data[16] == 12)
					{
						if (this.global1.data[39] < 5)
						{
							this.global1.data[39]++;
						}
						this.global1.data[33] -= 10;
						this.global1.data[1] += 10;
						this.global1.data[2] += 5;
						this.global1.data[22] -= 4;
						this.global1.data[10]--;
						this.global1.data[6] -= 2;
						this.global1.data[3] += 15;
						this.global1.data[4] += 10;
					}
					else
					{
						this.global1.data[33]--;
						this.global1.data[2] += 5;
						this.global1.data[22] -= 2;
						this.global1.data[10]--;
						this.global1.data[6] -= 2;
						this.global1.data[3] += 15;
						this.global1.data[4] += 5;
					}
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_private && this.global1.data[16] <= 11)
				{
					if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 1 || this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 3 || this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 5)
					{
						this.global1.data[8] -= 20;
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 2)
					{
						this.global1.data[8] -= 10;
					}
					else
					{
						this.global1.data[8] -= 30;
					}
					this.global1.data[3] -= 40;
					this.global1.data[4] += 20;
					this.global1.data[39]--;
					this.global1.data[1] += 40;
					this.global1.data[2] -= 5;
					this.global1.data[22] += 2;
					this.global1.data[6] += 4;
					this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_private = false;
					this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_working = true;
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_private && this.global1.data[16] == 12)
				{
					if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 1 || this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 3 || this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 5)
					{
						this.global1.data[8] -= 20;
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 2)
					{
						this.global1.data[8] -= 10;
					}
					else
					{
						this.global1.data[8] -= 30;
					}
					this.global1.data[3] -= 80;
					this.global1.data[4] += 40;
					this.global1.data[1] += 40;
					this.global1.data[2] -= 10;
					this.global1.data[22] += 2;
					this.global1.data[6] += 4;
					this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_private = false;
					this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_working = true;
					if (this.global1.data[39] > 5)
					{
						this.global1.data[39]--;
					}
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_private && this.global1.data[16] == 13 && (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 2 || this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 3 || this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 5))
				{
					this.global1.data[8] -= 30;
					this.global1.data[3] -= 80;
					this.global1.data[4] += 40;
					this.global1.data[1] += 40;
					this.global1.data[2] -= 10;
					this.global1.data[22] += 2;
					this.global1.data[6] += 4;
					this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_private = false;
					this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_working = true;
				}
			}
			else if (thing == 1)
			{
				if ((this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type < 12 || this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 15) && this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type != 6 && this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_working && !this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_private)
				{
					this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_working = false;
				}
				else if ((this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type <= 11 || this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 15) && this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type != 6 && !this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_private)
				{
					if (this.global1.data[16] > 11)
					{
						if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 1 || this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 15)
						{
							this.global1.data[8] -= 20;
						}
						else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 3)
						{
							this.global1.data[8] -= 20;
						}
						else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 4)
						{
							this.global1.data[8] -= 20;
						}
						else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 7)
						{
							this.global1.data[8] -= 20;
						}
					}
					this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_working = true;
				}
			}
			else if (!this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_private)
			{
				if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 1 || this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 15)
				{
					this.global1.data[8] -= 30;
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 2)
				{
					this.global1.data[8] -= 10;
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 3)
				{
					this.global1.data[8] -= 30;
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 4)
				{
					this.global1.data[8] -= 30;
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 5)
				{
					this.global1.data[8] -= 10;
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 6)
				{
					this.global1.data[8]++;
					this.global1.data[4] += 30;
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 7)
				{
					this.global1.data[8] -= 70;
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 8)
				{
					this.global1.data[8] -= 10;
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 9)
				{
					this.global1.data[8] -= 10;
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 10)
				{
					this.global1.data[8] -= 10;
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 11)
				{
					this.global1.data[8] -= 10;
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 14)
				{
					this.global1.data[8] -= 30;
					this.global1.data[1] -= 70;
					this.global1.data[4] += 100;
					this.global1.data[6] -= 50;
					this.global1.data[10] -= 50;
					this.global1.data[2] += 150;
					this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_builded = false;
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 23 && this.global1.allcountries[7].Vyshi)
				{
					this.global1.data[8] -= 20;
					this.global1.data[10] += 50;
					this.global1.data[9] -= 20;
					this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_builded = false;
				}
				if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 38 || this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 39 || (this.global1.data[216] >= 50 && (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 3 || this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 9)))
				{
					this.global1.data[1] = 800;
					this.global1.data[2] = 1000;
					this.global1.data[3] = 900;
					this.global1.data[4] = 10;
					this.global1.data[5] = 1000;
					this.global1.data[6] = 0;
					this.global1.data[7] = 1000;
					this.global1.data[8] = 0;
					this.global1.data[9] = 25;
					this.global1.data[10] = 0;
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type > 11)
				{
					if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 12 && this.global1.event_done[33])
					{
						this.global1.data[8] -= 30;
						this.global1.data[1] -= 50;
						this.global1.data[4] += 100;
						this.global1.data[6] -= 50;
						this.global1.data[10] -= 30;
						this.global1.data[2] += 150;
						this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_builded = false;
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 13)
					{
						this.global1.data[8] -= 10;
						this.global1.data[1] += (this.global1.data[14] - 4) * 50;
						this.global1.data[6] -= 30;
						this.global1.data[10] -= 30;
						this.global1.data[3] += (this.global1.data[14] - 3) * 10;
						this.global1.data[4] -= (this.global1.data[14] - 3) * 10;
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 21)
					{
						this.global1.data[8] -= 150;
						this.global1.data[6] -= 25;
						this.global1.data[10] -= 50;
						this.global1.data[2] += 150;
						this.global1.povod = false;
						this.global1.data[36] = 0;
						this.global1.data[1] -= (4 - this.global1.data[14]) * 100;
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 20)
					{
						this.global1.data[8] -= 50;
						this.global1.data[3] -= 100;
						this.global1.data[4] += 200;
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 22 && this.global1.data[75] > 0)
					{
						this.global1.data[8] -= 30;
						this.global1.data[3] += 100;
						this.global1.data[4] += 200;
						this.global1.data[2] += 200;
						this.global1.data[10] -= 200;
						this.global1.data[1] -= 250;
						this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_builded = false;
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 16)
					{
						this.global1.data[8] += 10;
						this.global1.data[1] += 50;
						this.global1.data[10] -= 10;
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 17)
					{
						this.global1.data[3] += (this.global1.data[14] - 3) * 10;
						this.global1.data[1] += (this.global1.data[14] - 3) * 10;
						this.global1.data[4] -= (this.global1.data[14] - 3) * 10;
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 37)
					{
						if (this.global1.data[160] == 1)
						{
							this.global1.data[4]++;
						}
						else if (this.global1.data[160] == 2)
						{
							this.global1.data[4]++;
							this.global1.data[1]++;
						}
						else
						{
							this.global1.data[4]--;
						}
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type == 38)
					{
						this.global1.data[1] = 800;
						this.global1.data[2] = 1000;
						this.global1.data[3] = 900;
						this.global1.data[4] = 10;
						this.global1.data[5] = 1000;
						this.global1.data[6] = 0;
						this.global1.data[7] = 1000;
						this.global1.data[8] = 0;
						this.global1.data[9] = 25;
						this.global1.data[10] = 0;
					}
				}
				if (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type != 12 && (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type < 25 || this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type > 36 || this.global1.event_done[375]) && this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type != 23 && this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type != 24 && this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type != 22 && this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type != 19 && this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type != 38 && this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type != 39 && (this.global1.data[216] < 50 || (this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type != 3 && this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type != 6 && this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type != 9)))
				{
					this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_builded = false;
				}
			}
		}
		this.Repaint();
	}

	// Token: 0x06000024 RID: 36 RVA: 0x0000BE24 File Offset: 0x0000A024
	public void BuildThis(int type)
	{
		this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_builded = true;
		this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_working = true;
		if (type == 6)
		{
			this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_private = true;
		}
		else
		{
			this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_private = false;
		}
		this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].type = type;
		this.Repaint();
	}

	// Token: 0x06000025 RID: 37 RVA: 0x0000BF0C File Offset: 0x0000A10C
	private void OnMouseDown()
	{
		if (!this.global1.regions[this.buildmanager1.now_region].buildings[this.this_number].is_builded && this.this_number <= 3 * this.global1.regions[this.buildmanager1.now_region].city_level - 1)
		{
			this.buildmanager1.selected_thing = this.this_number;
			this.buildmanager1.ShowSelects();
			return;
		}
		this.buildmanager1.HideSelects();
	}

	// Token: 0x0400002C RID: 44
	public int this_number = -1;

	// Token: 0x0400002D RID: 45
	private GlobalScript global1;

	// Token: 0x0400002E RID: 46
	public BuildingManager buildmanager1;

	// Token: 0x0400002F RID: 47
	private Yugoglobal yug1;
}
