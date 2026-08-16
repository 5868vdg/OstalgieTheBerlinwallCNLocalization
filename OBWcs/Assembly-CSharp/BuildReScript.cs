using System;
using UnityEngine;

// Token: 0x02000005 RID: 5
public class BuildReScript : MonoBehaviour
{
	// Token: 0x0600000F RID: 15 RVA: 0x00003E9C File Offset: 0x0000209C
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.build1 = base.transform.parent.GetComponent<BuildingScript>();
		if (this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51)
		{
			this.yug1 = GameObject.Find("Yugoglobal(Clone)").GetComponent<Yugoglobal>();
		}
	}

	// Token: 0x06000010 RID: 16 RVA: 0x0000212C File Offset: 0x0000032C
	private void OnMouseDown()
	{
		this.Change();
		this.buildmanager1.HideSelects();
		if (this.enabled)
		{
			base.transform.parent.GetComponent<BuildingScript>().DoSomething(this.this_force);
		}
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00003F1C File Offset: 0x0000211C
	private void Change()
	{
		if (this.buildmanager1.now_region != 2 && (this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51))
		{
			if (this.yug1.gameState.yugregions[this.buildmanager1.yugreg[0]].level + 5 > this.build1.this_number)
			{
				if (!this.buildmanager1.yugown[0])
				{
					this.enabled = false;
					return;
				}
			}
			else if (this.yug1.gameState.yugregions[this.buildmanager1.yugreg[1]].level + 5 > this.build1.this_number)
			{
				if (this.yug1.gameState.yugregions[this.buildmanager1.yugreg[1]].owner == 7 && this.yug1.gameState.yugregions[7].owner == 7 && this.global1.data[156] == 2 && this.global1.data[0] == 49)
				{
					this.enabled = true;
				}
				else if (!this.buildmanager1.yugown[1])
				{
					this.enabled = false;
					return;
				}
			}
			else if (this.yug1.gameState.yugregions[this.buildmanager1.yugreg[2]].level + 5 > this.build1.this_number)
			{
				if (this.yug1.gameState.yugregions[this.buildmanager1.yugreg[2]].owner == 2 && this.yug1.gameState.yugregions[2].owner == 2 && !this.yug1.gameState.yugcountries[2].is_exist && this.global1.event_done[274] && this.global1.data[0] == 51)
				{
					this.enabled = true;
				}
				else if (this.yug1.gameState.yugregions[this.buildmanager1.yugreg[2]].owner == 2 && this.yug1.gameState.yugregions[2].owner == 2 && this.yug1.gameState.yugcountries[2].is_exist && this.global1.data[150] == 1 && this.global1.data[0] == 49)
				{
					this.enabled = true;
				}
				else if (!this.buildmanager1.yugown[2])
				{
					this.enabled = false;
					return;
				}
			}
		}
		if (!this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].is_builded)
		{
			base.GetComponent<OkoshkoScript>().text = "<color=red>Невозможно</color>";
			base.GetComponent<OkoshkoScript>().text_en = "<color=red> 不 可 能</color>";
			this.enabled = false;
			return;
		}
		if (this.this_force == 0)
		{
			if (this.global1.data[0] == 12 && !this.global1.science[3])
			{
				base.GetComponent<OkoshkoScript>().text = "<color=red>Вы не можете,\nпока не закончите\nисследование\n\"Строительство промышленности\"</color>";
				base.GetComponent<OkoshkoScript>().text_en = "<color=red>直 到 完 成\n 研 究\n \" 工 业 建 设\"\n 方 可 建 设</color>";
			}
			else if ((this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type < 7 || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type > 9 || (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 9 && this.global1.data[16] > 11)) && (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type != 4 || (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 4 && this.global1.data[16] > 11)) && (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type < 12 || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 15) && this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type != 10 && (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type < 25 || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type > 36) && !this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].is_private && (this.global1.data[16] > 11 || this.global1.data[8] < 0))
			{
				base.GetComponent<OkoshkoScript>().text = "<color=lime>Приватизировать</color>";
				base.GetComponent<OkoshkoScript>().text_en = "<color=lime> 私 有 化</color>";
				if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 1)
				{
					OkoshkoScript component = base.GetComponent<OkoshkoScript>();
					component.text += "\n<color=yellow>Выгода:</color> +2 к бюджету";
					OkoshkoScript component2 = base.GetComponent<OkoshkoScript>();
					component2.text_en += "\n<color=yellow> 利 润:</color> +2 预 算";
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 2)
				{
					OkoshkoScript component3 = base.GetComponent<OkoshkoScript>();
					component3.text += "\n<color=yellow>Выгода:</color> +1 к бюджету";
					OkoshkoScript component4 = base.GetComponent<OkoshkoScript>();
					component4.text_en += "\n<color=yellow> 利 润:</color> +1 预 算";
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 3)
				{
					OkoshkoScript component5 = base.GetComponent<OkoshkoScript>();
					component5.text += "\n<color=yellow>Выгода:</color> +2 к бюджету";
					OkoshkoScript component6 = base.GetComponent<OkoshkoScript>();
					component6.text_en += "\n<color=yellow> 利 润:</color> +2 预 算";
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 4)
				{
					OkoshkoScript component7 = base.GetComponent<OkoshkoScript>();
					component7.text += "\n<color=yellow>Выгода:</color> +3 к бюджету";
					OkoshkoScript component8 = base.GetComponent<OkoshkoScript>();
					component8.text_en += "\n<color=yellow> 利 润:</color> +3 预 算";
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 5)
				{
					OkoshkoScript component9 = base.GetComponent<OkoshkoScript>();
					component9.text += "\n<color=yellow>Выгода:</color> +2 к бюджету";
					OkoshkoScript component10 = base.GetComponent<OkoshkoScript>();
					component10.text_en += "\n<color=yellow> 利 润:</color> +2 预 算";
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 6)
				{
					OkoshkoScript component11 = base.GetComponent<OkoshkoScript>();
					component11.text += "\n<color=yellow>Выгода:</color> +1 к бюджету";
					OkoshkoScript component12 = base.GetComponent<OkoshkoScript>();
					component12.text_en += "\n<color=yellow> 利 润:</color> +1 预 算";
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 9)
				{
					OkoshkoScript component13 = base.GetComponent<OkoshkoScript>();
					component13.text += "\n<color=yellow>Выгода:</color> +3 к бюджету";
					OkoshkoScript component14 = base.GetComponent<OkoshkoScript>();
					component14.text_en += "\n<color=yellow> 利 润:</color> +3 预 算";
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 11)
				{
					OkoshkoScript component15 = base.GetComponent<OkoshkoScript>();
					component15.text += "\n<color=yellow>Выгода:</color> +3 к бюджету";
					OkoshkoScript component16 = base.GetComponent<OkoshkoScript>();
					component16.text_en += "\n<color=yellow> 利 润:</color> +3 预 算";
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 15)
				{
					OkoshkoScript component17 = base.GetComponent<OkoshkoScript>();
					component17.text += "\n<color=yellow>Выгода:</color> +3 к бюджету";
					OkoshkoScript component18 = base.GetComponent<OkoshkoScript>();
					component18.text_en += "\n<color=yellow> 利 润:</color> +3 预 算";
				}
			}
			else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].is_private && this.global1.data[16] <= 11)
			{
				base.GetComponent<OkoshkoScript>().text = "<color=lime>Национализировать</color>";
				base.GetComponent<OkoshkoScript>().text_en = "<color=lime> 国 有 化</color>";
				if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 1 || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 3 || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 5)
				{
					OkoshkoScript component19 = base.GetComponent<OkoshkoScript>();
					component19.text += "\n<color=yellow>Расходы:</color> -2 из бюджета,\n+ 2 к Вестальгии, -4 к Поддержке народа";
					OkoshkoScript component20 = base.GetComponent<OkoshkoScript>();
					component20.text_en += "\n<color=yellow> 花 费:</color> -2 预 算,\n+2 西 方 情 结, -4 人 民 支 持";
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 2)
				{
					OkoshkoScript component21 = base.GetComponent<OkoshkoScript>();
					component21.text += "\n<color=yellow>Расходы:</color> -1 из бюджета,\n+ 2 к Вестальгии, -4 к Поддержке народа";
					OkoshkoScript component22 = base.GetComponent<OkoshkoScript>();
					component22.text_en += "\n<color=yellow> 花 费:</color> -1 预 算,\n+2 西 方 情 结, -4 人 民 支 持";
				}
				else
				{
					OkoshkoScript component23 = base.GetComponent<OkoshkoScript>();
					component23.text += "\n<color=yellow>Расходы:</color> -3 из бюджета,\n+ 2 к Вестальгии, -4 к Поддержке народа";
					OkoshkoScript component24 = base.GetComponent<OkoshkoScript>();
					component24.text_en += "\n<color=yellow> 花 费:</color> -3 预 算,\n+2 西 方 情 结, -4 人 民 支 持";
				}
			}
			else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].is_private && this.global1.data[16] == 12)
			{
				base.GetComponent<OkoshkoScript>().text = "<color=lime>Национализировать</color>";
				base.GetComponent<OkoshkoScript>().text_en = "<color=lime> 国 有 化</color>";
				if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 1 || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 3 || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 5)
				{
					OkoshkoScript component25 = base.GetComponent<OkoshkoScript>();
					component25.text += "\n<color=yellow>Расходы:</color> -2 из бюджета,\n+ 4 к Вестальгии, -8 к Поддержке народа";
					OkoshkoScript component26 = base.GetComponent<OkoshkoScript>();
					component26.text_en += "\n<color=yellow> 花 费:</color> -2 预 算,\n+4 西 方 情 结, -8 人 民 支 持";
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 2)
				{
					OkoshkoScript component27 = base.GetComponent<OkoshkoScript>();
					component27.text += "\n<color=yellow>Расходы:</color> -1 из бюджета,\n+ 4 к Вестальгии, -8 к Поддержке народа";
					OkoshkoScript component28 = base.GetComponent<OkoshkoScript>();
					component28.text_en += "\n<color=yellow> 花 费:</color> -1 预 算,\n+4 西 方 情 结, -8 人 民 支 持";
				}
				else
				{
					OkoshkoScript component29 = base.GetComponent<OkoshkoScript>();
					component29.text += "\n<color=yellow>Расходы:</color> -3 из бюджета,\n+ 4 к Вестальгии, -8 к Поддержке народа";
					OkoshkoScript component30 = base.GetComponent<OkoshkoScript>();
					component30.text_en += "\n<color=yellow> 花 费:</color> -3 预 算,\n+4 西 方 情 结, -8 人 民 支 持";
				}
			}
			else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].is_private && this.global1.data[16] == 13 && (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 2 || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 3 || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 5))
			{
				base.GetComponent<OkoshkoScript>().text = "<color=lime>Национализировать</color>";
				base.GetComponent<OkoshkoScript>().text_en = "<color=lime> 国 有 化</color>";
				OkoshkoScript component31 = base.GetComponent<OkoshkoScript>();
				component31.text += "\n<color=yellow>Расходы:</color> -3 из бюджета,\n+ 4 к Вестальгии, -8 к Поддержке народа";
				OkoshkoScript component32 = base.GetComponent<OkoshkoScript>();
				component32.text_en += "\n<color=yellow> 花 费:</color> -3 预 算,\n+4 西 方 情 结, -8 人 民 支 持";
			}
			else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].is_private && this.global1.data[16] > 11)
			{
				base.GetComponent<OkoshkoScript>().text = "<color=lime>Национализировать</color>";
				base.GetComponent<OkoshkoScript>().text_en = "<color=lime> 国 有 化</color>";
				base.GetComponent<OkoshkoScript>().text = "<color=red>Требуется плановая экономика</color>";
				base.GetComponent<OkoshkoScript>().text_en = "<color=red> 需 要 计 划 经 济</color>";
			}
			else if ((this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type > 5 && this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type < 9) || (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type > 11 && this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type != 15) || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 10)
			{
				base.GetComponent<OkoshkoScript>().text = "<color=lime>Приватизировать</color>";
				base.GetComponent<OkoshkoScript>().text_en = "<color=lime> 私 有 化</color>";
				base.GetComponent<OkoshkoScript>().text = "<color=red>Невозможно</color>";
				base.GetComponent<OkoshkoScript>().text_en = "<color=red> 不 可 能</color>";
			}
			else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 4 || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 9)
			{
				base.GetComponent<OkoshkoScript>().text = "<color=red>Не плановая экономика</color>";
				base.GetComponent<OkoshkoScript>().text_en = "<color=red> 不 是 计 划 经 济</color>";
			}
			else
			{
				base.GetComponent<OkoshkoScript>().text = "<color=red>Не плановая экономика\nили бюджет отрицателен</color>";
				base.GetComponent<OkoshkoScript>().text_en = "<color=red> 不 是 计 划 经 济\n 或 者 预 算 为 负</color>";
			}
		}
		else if (this.this_force == 1)
		{
			if ((this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type < 12 || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 15) && this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type != 6 && this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].is_working && !this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].is_private)
			{
				base.GetComponent<OkoshkoScript>().text = "<color=lime>Остановить</color>";
				base.GetComponent<OkoshkoScript>().text_en = "<color=lime> 停 用</color>";
			}
			else if ((this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type > 11 && this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type != 15) || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 6 || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].is_private)
			{
				base.GetComponent<OkoshkoScript>().text = "<color=red>Невозможно</color>";
				base.GetComponent<OkoshkoScript>().text_en = "<color=red> 不 可 能</color>";
			}
			else
			{
				base.GetComponent<OkoshkoScript>().text = "<color=red>Возобновить</color>";
				base.GetComponent<OkoshkoScript>().text_en = "<color=red> 启 用</color>";
				if (this.global1.data[16] > 11)
				{
					if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 1 || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 15)
					{
						OkoshkoScript component33 = base.GetComponent<OkoshkoScript>();
						component33.text += "\n<color=yellow>Расходы:</color> -2 из бюджета";
						OkoshkoScript component34 = base.GetComponent<OkoshkoScript>();
						component34.text_en += "\n<color=yellow> 花 费:</color> -2 预 算";
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 3)
					{
						OkoshkoScript component35 = base.GetComponent<OkoshkoScript>();
						component35.text += "\n<color=yellow>Расходы:</color> -2 из бюджета";
						OkoshkoScript component36 = base.GetComponent<OkoshkoScript>();
						component36.text_en += "\n<color=yellow> 花 费:</color> -2 预 算";
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 4)
					{
						OkoshkoScript component37 = base.GetComponent<OkoshkoScript>();
						component37.text += "\n<color=yellow>Расходы:</color> -2 из бюджета";
						OkoshkoScript component38 = base.GetComponent<OkoshkoScript>();
						component38.text_en += "\n<color=yellow> 花 费:</color> -2 预 算";
					}
					else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 7)
					{
						OkoshkoScript component39 = base.GetComponent<OkoshkoScript>();
						component39.text += "\n<color=yellow>Расходы:</color> -2 из бюджета";
						OkoshkoScript component40 = base.GetComponent<OkoshkoScript>();
						component40.text_en += "\n<color=yellow> 花 费:</color> -2 预 算";
					}
				}
			}
		}
		else if (!this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].is_private && (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type < 25 || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type > 36 || this.global1.event_done[375]) && this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type != 19 && this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type != 24)
		{
			if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type != 12)
			{
				base.GetComponent<OkoshkoScript>().text_en = "<color=lime> 拆 除</color>";
				base.GetComponent<OkoshkoScript>().text = "<color=lime>Снести</color>";
			}
			else
			{
				base.GetComponent<OkoshkoScript>().text_en = "<color=lime> 推 倒</color>";
				base.GetComponent<OkoshkoScript>().text = "<color=lime>Снести эту стену</color>";
			}
			if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 38 || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 39 || (this.global1.data[216] >= 50 && (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 3 || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 9)))
			{
				OkoshkoScript component41 = base.GetComponent<OkoshkoScript>();
				component41.text += "\n<color=red>Недостаточный уровень допуска</color>";
				OkoshkoScript component42 = base.GetComponent<OkoshkoScript>();
				component42.text_en += "\n<color=red> 许 可 等 级 不 足</color>";
			}
			else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 1 || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 15)
			{
				OkoshkoScript component43 = base.GetComponent<OkoshkoScript>();
				component43.text += "\n<color=yellow>Расходы:</color> -3 из бюджета";
				OkoshkoScript component44 = base.GetComponent<OkoshkoScript>();
				component44.text_en += "\n<color=yellow> 花 费:</color> -3 预 算";
			}
			else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 2)
			{
				OkoshkoScript component45 = base.GetComponent<OkoshkoScript>();
				component45.text += "\n<color=yellow>Расходы:</color> -1 из бюджета";
				OkoshkoScript component46 = base.GetComponent<OkoshkoScript>();
				component46.text_en += "\n<color=yellow> 花 费:</color> -1 预 算";
			}
			else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 37)
			{
				OkoshkoScript component47 = base.GetComponent<OkoshkoScript>();
				component47.text += "\n<color=yellow>Расходы:</color> -1 из бюджета";
				OkoshkoScript component48 = base.GetComponent<OkoshkoScript>();
				component48.text_en += "\n<color=yellow> 花 费:</color> -1 预 算";
			}
			else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 3)
			{
				OkoshkoScript component49 = base.GetComponent<OkoshkoScript>();
				component49.text += "\n<color=yellow>Расходы:</color> -3 из бюджета";
				OkoshkoScript component50 = base.GetComponent<OkoshkoScript>();
				component50.text_en += "\n<color=yellow> 花 费:</color> -3 预 算";
			}
			else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 4)
			{
				OkoshkoScript component51 = base.GetComponent<OkoshkoScript>();
				component51.text += "\n<color=yellow>Расходы:</color> -3 из бюджета";
				OkoshkoScript component52 = base.GetComponent<OkoshkoScript>();
				component52.text_en += "\n<color=yellow> 花 费:</color> -3 预 算";
			}
			else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 5)
			{
				OkoshkoScript component53 = base.GetComponent<OkoshkoScript>();
				component53.text += "\n<color=yellow>Расходы:</color> -1 из бюджета";
				OkoshkoScript component54 = base.GetComponent<OkoshkoScript>();
				component54.text_en += "\n<color=yellow> 花 费:</color> -1 预 算";
			}
			else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 7)
			{
				OkoshkoScript component55 = base.GetComponent<OkoshkoScript>();
				component55.text += "\n<color=yellow>Расходы:</color> -7 из бюджета";
				OkoshkoScript component56 = base.GetComponent<OkoshkoScript>();
				component56.text_en += "\n<color=yellow> 花 费:</color> -7 预 算";
			}
			else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 8)
			{
				OkoshkoScript component57 = base.GetComponent<OkoshkoScript>();
				component57.text += "\n<color=yellow>Расходы:</color> -1 из бюджета";
				OkoshkoScript component58 = base.GetComponent<OkoshkoScript>();
				component58.text_en += "\n<color=yellow>Costs:</color> -1 from the budget";
			}
			else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 9)
			{
				OkoshkoScript component59 = base.GetComponent<OkoshkoScript>();
				component59.text += "\n<color=yellow>Расходы:</color> -1 из бюджета";
				OkoshkoScript component60 = base.GetComponent<OkoshkoScript>();
				component60.text_en += "\n<color=yellow> 花 费:</color> -1 预 算";
			}
			else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 10)
			{
				OkoshkoScript component61 = base.GetComponent<OkoshkoScript>();
				component61.text += "\n<color=yellow>Расходы:</color> -1 из бюджета";
				OkoshkoScript component62 = base.GetComponent<OkoshkoScript>();
				component62.text_en += "\n<color=yellow> 花 费:</color> -1 预 算";
			}
			else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 11)
			{
				OkoshkoScript component63 = base.GetComponent<OkoshkoScript>();
				component63.text += "\n<color=yellow>Расходы:</color> -1 из бюджета";
				OkoshkoScript component64 = base.GetComponent<OkoshkoScript>();
				component64.text_en += "\n<color=yellow> 花 费:</color> -1 预 算";
			}
			else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type > 11)
			{
				if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 16)
				{
					OkoshkoScript component65 = base.GetComponent<OkoshkoScript>();
					component65.text += "\n<color=yellow>Расходы:</color> +1 в бюджет";
					OkoshkoScript component66 = base.GetComponent<OkoshkoScript>();
					component66.text_en += "\n<color=yellow> 花 费:</color> +1 预 算";
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 21)
				{
					OkoshkoScript component67 = base.GetComponent<OkoshkoScript>();
					component67.text += "\n<color=yellow>Расходы:</color> -15 из бюджета";
					OkoshkoScript component68 = base.GetComponent<OkoshkoScript>();
					component68.text_en += "\n<color=yellow> 花 费:</color> -15 预 算";
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 20)
				{
					OkoshkoScript component69 = base.GetComponent<OkoshkoScript>();
					component69.text += "\n<color=yellow>Расходы:</color> -5 из бюджета";
					OkoshkoScript component70 = base.GetComponent<OkoshkoScript>();
					component70.text_en += "\n<color=yellow> 花 费:</color> -5 预 算";
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 23)
				{
					OkoshkoScript component71 = base.GetComponent<OkoshkoScript>();
					component71.text += "\n<color=yellow>Расходы:</color> -2 из бюджета\n<color=red>Если СССР распался</color>";
					OkoshkoScript component72 = base.GetComponent<OkoshkoScript>();
					component72.text_en += "\n<color=yellow> 花 费:</color> -2 预 算\n<color=red> 如 果 苏 联 崩 溃</color>";
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 22 && this.global1.data[75] > 0)
				{
					OkoshkoScript component73 = base.GetComponent<OkoshkoScript>();
					component73.text += "\n<color=yellow>Расходы:</color> -3 из бюджета";
					OkoshkoScript component74 = base.GetComponent<OkoshkoScript>();
					component74.text_en += "\n<color=yellow> 花 费:</color> -3 预 算";
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 13)
				{
					OkoshkoScript okoshkoScript = base.GetComponent<OkoshkoScript>();
					okoshkoScript.text = string.Concat(new string[]
					{
						okoshkoScript.text,
						"\n<color=yellow>Поддержка народа:</color> ",
						(this.global1.data[14] - 3).ToString(),
						".",
						Mathf.Abs((this.global1.data[14] - 3) * 8 % 10).ToString()
					});
					okoshkoScript = base.GetComponent<OkoshkoScript>();
					okoshkoScript.text_en = string.Concat(new string[]
					{
						okoshkoScript.text_en,
						"\n<color=yellow> 人 民 支 持:</color> ",
						(this.global1.data[14] - 3).ToString(),
						".",
						Mathf.Abs((this.global1.data[14] - 3) * 8 % 10).ToString()
					});
					OkoshkoScript component75 = base.GetComponent<OkoshkoScript>();
					component75.text_en = component75.text_en + "\n<color=yellow> 党 内 团 结:</color> " + ((this.global1.data[14] > 4) ? "+" : "") + ((this.global1.data[14] - 4) * 5).ToString();
					OkoshkoScript component76 = base.GetComponent<OkoshkoScript>();
					component76.text = component76.text + "\n<color=yellow>Единство Партии:</color> " + ((this.global1.data[14] > 4) ? "+" : "") + ((this.global1.data[14] - 4) * 5).ToString();
					okoshkoScript = base.GetComponent<OkoshkoScript>();
					okoshkoScript.text_en = string.Concat(new string[]
					{
						okoshkoScript.text_en,
						"\n<color=yellow> 西 方 情 结:</color> ",
						(3 - this.global1.data[14]).ToString(),
						".",
						Mathf.Abs((3 - this.global1.data[14]) * 8 % 10).ToString()
					});
					okoshkoScript = base.GetComponent<OkoshkoScript>();
					okoshkoScript.text = string.Concat(new string[]
					{
						okoshkoScript.text,
						"\n<color=yellow>Вестальгия:</color> ",
						(3 - this.global1.data[14]).ToString(),
						".",
						Mathf.Abs((3 - this.global1.data[14]) * 8 % 10).ToString()
					});
					OkoshkoScript component77 = base.GetComponent<OkoshkoScript>();
					component77.text += "\n<color=yellow>Репутация:</color> -3.0 ";
					OkoshkoScript component78 = base.GetComponent<OkoshkoScript>();
					component78.text_en += "\n<color=yellow> 外 交 声 誉:</color> -3.0 ";
					OkoshkoScript component79 = base.GetComponent<OkoshkoScript>();
					component79.text += "<color=yellow>Недовольство НАТО:</color> -3.0";
					OkoshkoScript component80 = base.GetComponent<OkoshkoScript>();
					component80.text_en += "<color=yellow> 北 约 不 满:</color> -3.0";
				}
				else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 17)
				{
					OkoshkoScript component81 = base.GetComponent<OkoshkoScript>();
					component81.text = component81.text + "\n<color=yellow>Поддержка народа:</color> " + (this.global1.data[14] - 3).ToString();
					OkoshkoScript component82 = base.GetComponent<OkoshkoScript>();
					component82.text_en = component82.text_en + "\n<color=yellow> 人 民 支 持:</color> " + (this.global1.data[14] - 3).ToString();
					OkoshkoScript component83 = base.GetComponent<OkoshkoScript>();
					component83.text_en = component83.text_en + "\n<color=yellow> 党 内 团 结:</color> " + (this.global1.data[14] - 3).ToString();
					OkoshkoScript component84 = base.GetComponent<OkoshkoScript>();
					component84.text = component84.text + "\n<color=yellow>Единство Партии:</color> " + (this.global1.data[14] - 3).ToString();
					OkoshkoScript component85 = base.GetComponent<OkoshkoScript>();
					component85.text_en = component85.text_en + "\n<color=yellow> 西 方 情 结:</color> " + (3 - this.global1.data[14]).ToString();
					OkoshkoScript component86 = base.GetComponent<OkoshkoScript>();
					component86.text = component86.text + "\n<color=yellow>Вестальгия:</color> " + (3 - this.global1.data[14]).ToString();
				}
				else if ((this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type != 12 && this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type != 22) || this.global1.event_done[33])
				{
					OkoshkoScript component87 = base.GetComponent<OkoshkoScript>();
					component87.text += "\n<color=yellow>Расходы:</color> -3 из бюджета";
					OkoshkoScript component88 = base.GetComponent<OkoshkoScript>();
					component88.text_en += "\n<color=yellow> 花 费:</color> -3 预 算";
				}
				else
				{
					OkoshkoScript component89 = base.GetComponent<OkoshkoScript>();
					component89.text += "\n<color=red>Нет повода</color>";
					OkoshkoScript component90 = base.GetComponent<OkoshkoScript>();
					component90.text_en += "\n<color=red> 无 理 由</color>";
				}
			}
		}
		else if (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type != 12)
		{
			base.GetComponent<OkoshkoScript>().text = "<color=red>Невозможно</color>";
			base.GetComponent<OkoshkoScript>().text_en = "<color=red> 不 可 能e</color>";
		}
		else
		{
			base.GetComponent<OkoshkoScript>().text = "<color=red>Нет повода</color>";
			base.GetComponent<OkoshkoScript>().text_en = "<color=red> 无 理 由</color>";
		}
		if (this.this_force != 0)
		{
			this.enabled = true;
			return;
		}
		if ((!this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].is_private || ((this.global1.data[16] <= 12 || (this.global1.data[16] == 13 && (this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 2 || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 3 || this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].type == 5))) && this.global1.regions[this.buildmanager1.now_region].buildings[this.build1.this_number].is_private)) && (this.global1.data[0] != 12 || this.global1.science[3]))
		{
			this.enabled = true;
			return;
		}
		this.enabled = false;
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002162 File Offset: 0x00000362
	private void OnMouseExit()
	{
		this.Change();
		base.GetComponent<SpriteRenderer>().sprite = this.buildmanager1.respriteoff[this.this_force];
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002187 File Offset: 0x00000387
	private void OnMouseEnter()
	{
		this.Change();
		if (this.enabled)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.buildmanager1.resprite_on[this.this_force];
		}
	}

	// Token: 0x0400000F RID: 15
	public new bool enabled = true;

	// Token: 0x04000010 RID: 16
	public BuildingManager buildmanager1;

	// Token: 0x04000011 RID: 17
	private GlobalScript global1;

	// Token: 0x04000012 RID: 18
	private BuildingScript build1;

	// Token: 0x04000013 RID: 19
	private Yugoglobal yug1;

	// Token: 0x04000014 RID: 20
	public int this_force;
}
