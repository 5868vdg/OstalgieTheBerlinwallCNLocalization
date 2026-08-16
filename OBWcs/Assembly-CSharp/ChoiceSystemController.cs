using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200000C RID: 12
public class ChoiceSystemController : MonoBehaviour
{
	// Token: 0x06000033 RID: 51 RVA: 0x0000C084 File Offset: 0x0000A284
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		if (PlayerPrefs.GetInt("language") == 0)
		{
			this.Set(new int[7], new string[] { " 东 德 路 线", " 波 兰 路 线", " 捷 斯 路 线", " 匈 牙 利 路 线", " 罗 马 尼 亚 路 线", " 保 加 利 亚 路 线", " 苏 联 路 线" }, new List<string>[]
			{
				new List<string> { " 史 实", " 随 机", " 米 尔 克 ，  威 权 主 义", " 米 尔 克 ，  民 族 布 尔 什 维 主 义", " 昂 纳 克,  自 动 化", " 克 伦 茨,  回 归 1948" },
				new List<string> { " 史 实", " 随 机", " 干 预 选 举 ( 沃 罗 特 尼 科 夫 上 台)", " 米 雅 尔,  民 族 工 团 主 义", " 克 瓦 希 涅 夫 斯 基,  比 团 结 工 会 更 快" },
				new List<string> { " 史 实", " 随 机", " 胡 萨 克,  新 民 族", " 阿 达 麦 茨,  解 放 思 想", " 什 特 劳 加 尔,  邦 联", " 捷 族 优 势 ( 沃 罗 特 尼 科 夫 上 台)" },
				new List<string> { " 史 实", " 随 机", " 苏 联 揭 露 纳 吉 ( 沃 罗 特 尼 科 夫 上 台)", " 内 梅 特,  红 色 资 本 主 义", " 博 尔 贝 伊,  新 摄 政", " 克 劳 斯,  两 步 向 后" },
				new List<string> { " 史 实", " 随 机", " 齐 奥 塞 斯 库,  红 色 王 朝", " 阿 波 斯 托 尔,  回 归 社 会 主 义", " 干 预 ( 沃 罗 特 尼 科 夫 上 台)", " 维 尔 德 茨,  内 战" },
				new List<string> { " 史 实", " 随 机", " 日 夫 科 夫,  南 斯 拉 夫 ( 未 扮 演 南 斯 拉 夫)", " 姆 拉 德 诺 夫,  君 主 制 社 会 主 义", " 索 拉 科 夫,  保 加 利 亚 化", " 利 洛 夫,  资 本 主 义 与 社 会 主 义 " },
				new List<string> { " 史 实", " 随 机", " 雅 科 夫 列 夫 ( 未 扮 演 古 巴)", " 沃 罗 特 尼 科 夫 ( 未 扮 演 古 巴)", "1990 年 事 变" }
			});
			return;
		}
		this.Set(new int[7], new string[] { "Курс ГДР", "Курс ПНР", "Курс ЧССР", "Курс ВНР", "Курс СРР", "Курс НРБ", "Курс СССР" }, new List<string>[]
		{
			new List<string> { "Исторический", "Случайный", "Мильке, авторитаризм", "Мильке, национал-большевизм", "Хонеккер, автоматизация", "Кренц, к 1948" },
			new List<string> { "Исторический", "Случайный", "Вмешательство в выборы (✓Воротников)", "Мияль, национал-синдикализм", "Квасьневский, быстрее Солидарности" },
			new List<string> { "Исторический", "Случайный", "Гусак, новая нация", "Адамец, теология освобождения", "Штроугал, конфедерация", "Гавел, чехонационализм (✓Воротников)" },
			new List<string> { "Исторический", "Случайный", "СССР публикует Надя (✓Воротников)", "Немет, красный капитализм", "Борбей, новый регент", "Краус, два шага назад" },
			new List<string> { "Исторический", "Случайный", "Чаушеску, красная династия", "Апостол, назад к социализму", "Ввод войск (✓Воротников)", "Вердец, гражданская война" },
			new List<string> { "Исторический", "Случайный", "Живков, Югославия (✘Югославия)", "Младенов, монархо-социализм", "Солаков, болгаризация", "Лилов, капитализм и социализм" },
			new List<string> { "Исторический", "Случайный", "Яковлев (✘Куба)", "Воротников (✘Куба)", "Инцидент 1990" }
		});
	}

	// Token: 0x06000034 RID: 52 RVA: 0x000022A8 File Offset: 0x000004A8
	public void Set(int[] currentSelectedChoices, string[] choiceTypeNames, List<string>[] choicesNames)
	{
		this.currentSelectedChoices = currentSelectedChoices;
		this.choicesNames = choicesNames;
		this.choiceTypeNames = choiceTypeNames;
		this.Repaint();
	}

	// Token: 0x06000035 RID: 53 RVA: 0x0000C538 File Offset: 0x0000A738
	private void Repaint()
	{
		this.subWindow.gameObject.SetActive(this.selectedChoiceType != -1);
		if (this.selectedChoiceType != -1)
		{
			for (int i = 0; i < this.subButtons.Length; i++)
			{
				if (i > this.choicesNames[this.selectedChoiceType].Count - 1)
				{
					this.subButtons[i].gameObject.SetActive(false);
				}
				else
				{
					this.subButtons[i].gameObject.SetActive(true);
					this.subButtons[i].ChangeText(this.choicesNames[this.selectedChoiceType][i]);
					this.subButtons[i].ChangeSelected(this.currentSelectedChoices[this.selectedChoiceType] == i);
					this.subButtons[i].transform.localPosition = new Vector3((this.subWindowTR.localPosition.x + this.subWindowBL.localPosition.x) * 0.5f, Mathf.Lerp(this.subWindowTR.localPosition.y, this.subWindowBL.localPosition.y, (float)i / (float)(this.choicesNames[this.selectedChoiceType].Count - 1)), this.subButtons[i].transform.localPosition.z);
				}
			}
		}
		for (int j = 0; j < this.mainButtons.Length; j++)
		{
			if (j > this.choiceTypeNames.Length - 1)
			{
				this.mainButtons[j].gameObject.SetActive(false);
			}
			else
			{
				this.mainButtons[j].ChangeText(this.choiceTypeNames[j]);
				this.mainButtons[j].ChangeSelected(this.selectedChoiceType == j);
				this.mainButtons[j].transform.localPosition = new Vector3((this.mainWindowTR.localPosition.x + this.mainWindowBL.localPosition.x) * 0.5f, Mathf.Lerp(this.mainWindowTR.localPosition.y, this.mainWindowBL.localPosition.y, (float)j / (float)(this.choiceTypeNames.Length - 1)), this.mainButtons[j].transform.localPosition.z);
			}
		}
	}

	// Token: 0x06000036 RID: 54 RVA: 0x000022C5 File Offset: 0x000004C5
	public void ChoiceMade(int choiceType, int choiceValue)
	{
		Debug.Log(string.Format("Choice {0} is {1} now", choiceType, choiceValue));
		this.global1.allcountries[choiceType + 1].paths = choiceValue;
		this.game1.Repaint();
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002302 File Offset: 0x00000502
	public void CloseSubWindow()
	{
		this.selectedChoiceType = -1;
		this.Repaint();
	}

	// Token: 0x06000038 RID: 56 RVA: 0x0000C788 File Offset: 0x0000A988
	public void ReceiveButtonPress(int num)
	{
		if (num >= 100)
		{
			num -= 100;
			this.selectedChoiceType = ((this.selectedChoiceType == num) ? (-1) : num);
			this.Repaint();
			return;
		}
		this.currentSelectedChoices[this.selectedChoiceType] = num;
		this.ChoiceMade(this.selectedChoiceType, num);
		this.Repaint();
	}

	// Token: 0x04000041 RID: 65
	public Transform mainWindowTR;

	// Token: 0x04000042 RID: 66
	public Transform mainWindowBL;

	// Token: 0x04000043 RID: 67
	public Transform subWindowTR;

	// Token: 0x04000044 RID: 68
	public Transform subWindowBL;

	// Token: 0x04000045 RID: 69
	public Transform subWindow;

	// Token: 0x04000046 RID: 70
	public ChoiceButton[] mainButtons;

	// Token: 0x04000047 RID: 71
	public ChoiceButton[] subButtons;

	// Token: 0x04000048 RID: 72
	private int selectedChoiceType = -1;

	// Token: 0x04000049 RID: 73
	private int[] currentSelectedChoices;

	// Token: 0x0400004A RID: 74
	private string[] choiceTypeNames;

	// Token: 0x0400004B RID: 75
	private List<string>[] choicesNames;

	// Token: 0x0400004C RID: 76
	public GlobalScript global1;

	// Token: 0x0400004D RID: 77
	public GameStartScript game1;
}
