using System;
using UnityEngine;

// Token: 0x0200003B RID: 59
public class Stat_script : MonoBehaviour
{
	// Token: 0x06000105 RID: 261 RVA: 0x001597D8 File Offset: 0x001579D8
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		if (PlayerPrefs.GetInt("language") == 0)
		{
			if (this.global1.data[216] > 50)
			{
				base.GetComponent<TextMesh>().text = " 报 告 ( 占3227 年 的 百 分 比)\n( 现 实)";
				this.Name[1].text = " 报 告 ( 占3227 年 的 百 分 比)\n( 玩 家)";
				this.Name[2].text = " 日 期\n 一 月 32\n 二 月 32\n 三 月 32\n 四 月 32\n 五 月 32\n 六 月 32\n 七 月 32\n 八 月 32\n 九 月 32\n 十 月 32\n 十 一 月 32\n 十 二 月 32\n";
				TextMesh textMesh = this.Name[2];
				textMesh.text += " 一 月 33\n 二 月 33\n 三 月 33\n 四 月 33\n 五 月 33\n 六 月 33\n 七 月 33\n 八 月 33\n 九 月 33\n 十 月 33\n 十 一 月 33\n 十 二 月 33\n";
				TextMesh textMesh2 = this.Name[2];
				textMesh2.text += " 一 月 34\n 二 月 34\n 三 月 34\n 四 月 34\n 五 月 34\n 六 月 34\n 七 月 34\n 八 月 34\n 九 月 34\n 十 月 34\n 十 一 月 34\n 十 二 月 34";
				this.Name[7].text = " 日 期\n 一 月 32\n 二 月 32\n 三 月 32\n 四 月 32\n 五 月 32\n 六 月 32\n 七 月 32\n 八 月 32\n 九 月 32\n 十 月 32\n 十 一 月 32\n 十 二 月 32\n";
				TextMesh textMesh3 = this.Name[7];
				textMesh3.text += " 一 月 33\n 二 月 33\n 三 月 33\n 四 月 33\n 五 月 33\n 六 月 33\n 七 月 33\n 八 月 33\n 九 月 33\n 十 月 33\n 十 一 月 33\n 十 二 月 33\n";
				TextMesh textMesh4 = this.Name[7];
				textMesh4.text += " 一 月 34\n 二 月 34\n 三 月 34\n 四 月 34\n 五 月 34\n 六 月 34\n 七 月 34\n 八 月 34\n 九 月 34\n 十 月 34\n 十 一 月 34\n 十 二 月 34";
			}
			else
			{
				base.GetComponent<TextMesh>().text = " 报 告 ( 占1985 年 的 百 分 比)\n( 现 实)";
				this.Name[1].text = " 报 告 ( 占1985 年 的 百 分 比)\n( 玩 家)";
				this.Name[2].text = " 日 期\n 一 月 89\n 二 月 89\n 三 月 89\n 四 月 89\n 五 月 89\n 六 月 89\n 七 月 89\n 八 月 89\n 九 月 89\n 十 月 89\n 十 一 月 89\n 十 二 月 89\n";
				TextMesh textMesh5 = this.Name[2];
				textMesh5.text += " 一 月 90\n 二 月 90\n 三 月 90\n 四 月 90\n 五 月 90\n 六 月 90\n 七 月 90\n 八 月 90\n 九 月 90\n 十 月 90\n 十 一 月 90\n 十 二 月 90\n";
				TextMesh textMesh6 = this.Name[2];
				textMesh6.text += " 一 月 91\n 二 月 91\n 三 月 91\n 四 月 91\n 五 月 91\n 六 月 91\n 七 月 91\n 八 月 91\n 九 月 91\n 十 月 91\n 十 一 月 91\n 十 二 月 91";
				this.Name[7].text = " 日 期\n 一 月 89\n 二 月 89\n 三 月 89\n 四 月 89\n 五 月 89\n 六 月 89\n 七 月 89\n 八 月 89\n 九 月 89\n 十 月 89\n 十 一 月 89\n 十 二 月 89\n";
				TextMesh textMesh7 = this.Name[7];
				textMesh7.text += " 一 月 90\n 二 月 90\n 三 月 90\n 四 月 90\n 五 月 90\n 六 月 90\n 七 月 90\n 八 月 90\n 九 月 90\n 十 月 90\n 十 一 月 90\n 十 二 月 90\n";
				TextMesh textMesh8 = this.Name[7];
				textMesh8.text += " 一 月 91\n 二 月 91\n 三 月 91\n 四 月 91\n 五 月 91\n 六 月 91\n 七 月 91\n 八 月 91\n 九 月 91\n 十 月 91\n 十 一 月 91\n 十 二 月 91";
			}
			this.Name[3].text = "GDP";
			this.Name[4].text = "HDI";
			this.Name[5].text = " 出 口\n 逆 差";
			this.Name[6].text = " 经 济\n 增 长";
			TextMesh textMesh9 = this.Name[3];
			textMesh9.text += PlayerPrefs.GetString("V1");
			TextMesh textMesh10 = this.Name[4];
			textMesh10.text += PlayerPrefs.GetString("I2");
			TextMesh textMesh11 = this.Name[5];
			textMesh11.text += PlayerPrefs.GetString("S3");
			TextMesh textMesh12 = this.Name[6];
			textMesh12.text += PlayerPrefs.GetString("R3");
			this.Name[8].text = "GDP";
			this.Name[9].text = "HDI";
			this.Name[10].text = " 出 口\n 逆 差";
			this.Name[11].text = " 经 济\n 增 长";
		}
		else
		{
			if (this.global1.data[216] > 50)
			{
				base.GetComponent<TextMesh>().text = "Отчёт (% of 3227)\n(реальность)";
				this.Name[1].text = "Отчёт (% of 3227)\n(игрок)";
				this.Name[2].text = "Дата\nЯнв 32\nФев 32\nМарт 32\nАпр 32\nМай 32\nИюнь 32\nИюль 32\nАвг 32\nСеп 32\nОкт 32\nНояб 32\nДек 32\n";
				TextMesh textMesh13 = this.Name[2];
				textMesh13.text += "Янв 33\nФев 33\nМарт 33\nАпр 33\nМай 33\nИюнь 33\nИюль 33\nАвг 33\nСеп 33\nОкт 33\nНояб 33\nДек 33\n";
				TextMesh textMesh14 = this.Name[2];
				textMesh14.text += "Янв 34\nФев 34\nМарт 34\nАпр 34\nМай 34\nИюнь 34\nИюль 34\nАвг 34\nСеп 34\nОкт 34\nНояб 34\nДек 34";
				this.Name[7].text = "Дата\nJan 32\nФев 32\nМарт 32\nАпр 32\nМай 32\nИюнь 32\nИюль 32\nАвг 32\nСеп 32\nОкт 32\nНояб 32\nДек 32\n";
				TextMesh textMesh15 = this.Name[7];
				textMesh15.text += "Янв 33\nФев 33\nМарт 33\nАпр 33\nМай 33\nИюнь 33\nИюль 33\nАвг 33\nСеп 33\nОкт 33\nНояб 33\nДек 33\n";
				TextMesh textMesh16 = this.Name[7];
				textMesh16.text += "Янв 34\nФев 34\nМарт 34\nАпр 34\nМай 34\nИюнь 34\nИюль 34\nАвг 34\nСеп 34\nОкт 34\nНояб 34\nДек 34";
			}
			TextMesh textMesh17 = this.Name[3];
			textMesh17.text += PlayerPrefs.GetString("V1");
			TextMesh textMesh18 = this.Name[4];
			textMesh18.text += PlayerPrefs.GetString("I2");
			TextMesh textMesh19 = this.Name[5];
			textMesh19.text += PlayerPrefs.GetString("S3");
			TextMesh textMesh20 = this.Name[6];
			textMesh20.text += PlayerPrefs.GetString("R3");
		}
		if (this.global1.data[0] == 1)
		{
			TextMesh textMesh21 = this.Name[8];
			textMesh21.text += "\n148%\n148%\n148%\n148%\n140%\n140%\n140%\n145%\n145%\n144%\n135%\n130%\n";
			TextMesh textMesh22 = this.Name[9];
			textMesh22.text += "\n100%\n100%\n100%\n99%\n99%\n99%\n99%\n99%\n99%\n99%\n100%\n100%\n";
			TextMesh textMesh23 = this.Name[10];
			textMesh23.text += "\n-1%\n-1%\n-1%\n0%\n0%\n1%\n1%\n1%\n1%\n1%\n0%\n0%\n";
			TextMesh textMesh24 = this.Name[11];
			textMesh24.text += "\n2.49%\n2.49%\n2.49%\n2.47%\n2.38%\n2.38%\n2.38%\n2.43%\n2.43%\n2.4%\n2.35%\n2.3%\n";
			TextMesh textMesh25 = this.Name[8];
			textMesh25.text += "121%\n107%\n103%\n99%\n91%\n83%\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh26 = this.Name[9];
			textMesh26.text += "101%\n101%\n103%\n105%\n108%\n110%\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh27 = this.Name[10];
			textMesh27.text += "0\n0%\n0%\n-1%\n-1%\n-5%\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh28 = this.Name[11];
			textMesh28.text += "2.19%\n2.08%\n2.02%\n1.96%\n1.9%\n1.88%\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh29 = this.Name[8];
			textMesh29.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh30 = this.Name[9];
			textMesh30.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh31 = this.Name[10];
			textMesh31.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh32 = this.Name[11];
			textMesh32.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			return;
		}
		if (this.global1.data[0] == 5)
		{
			TextMesh textMesh33 = this.Name[8];
			textMesh33.text += "\n101%\n100%\n99%\n138%\n130%\n129%\n128%\n127%\n126%\n119%\n112%\n91%\n";
			TextMesh textMesh34 = this.Name[9];
			textMesh34.text += "\n55%\n53%\n51%\n49%\n47%\n45%\n43%\n41%\n39%\n37%\n32%\n27%\n";
			TextMesh textMesh35 = this.Name[10];
			textMesh35.text += "\n4%\n4%\n4%\n4%\n5%\n5%\n5%\n5%\n5%\n6%\n6%\n10%\n";
			TextMesh textMesh36 = this.Name[11];
			textMesh36.text += "\n1.52%\n1.49%\n1.46%\n1.83%\n1.72%\n1.69%\n1.66%\n1.63%\n1.6%\n1.5%\n1.39%\n1.08%\n";
			TextMesh textMesh37 = this.Name[8];
			textMesh37.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh38 = this.Name[9];
			textMesh38.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh39 = this.Name[10];
			textMesh39.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh40 = this.Name[11];
			textMesh40.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh41 = this.Name[8];
			textMesh41.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh42 = this.Name[9];
			textMesh42.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh43 = this.Name[10];
			textMesh43.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh44 = this.Name[11];
			textMesh44.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			return;
		}
		if (this.global1.data[0] == 2)
		{
			TextMesh textMesh45 = this.Name[8];
			textMesh45.text += "\n131%\n131%\n131%\n131%\n131%\n131%\n131%\n136%\n136%\n136%\n136%\n136%\n";
			TextMesh textMesh46 = this.Name[9];
			textMesh46.text += "\n86%\n86%\n85%\n84%\n83%\n82%\n81%\n53%\n53%\n53%\n53%\n52%\n";
			TextMesh textMesh47 = this.Name[10];
			textMesh47.text += "\n0%\n0%\n0%\n0%\n0%\n0%\n0%\n-1%\n-1%\n-1%\n-3%\n-3%\n";
			TextMesh textMesh48 = this.Name[11];
			textMesh48.text += "\n2.22%\n2.17%\n2.17%\n2.16%\n2.14%\n2.13%\n2.12%\n2.19%\n2.19%\n2.19%\n2.19%\n2.19%\n";
			TextMesh textMesh49 = this.Name[8];
			textMesh49.text += "136%\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh50 = this.Name[9];
			textMesh50.text += "52%\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh51 = this.Name[10];
			textMesh51.text += "-5%\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh52 = this.Name[11];
			textMesh52.text += "2.22%\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh53 = this.Name[8];
			textMesh53.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh54 = this.Name[9];
			textMesh54.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh55 = this.Name[10];
			textMesh55.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh56 = this.Name[11];
			textMesh56.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			return;
		}
		if (this.global1.data[0] == 4)
		{
			TextMesh textMesh57 = this.Name[8];
			textMesh57.text += "\n137%\n137%\n133%\n133%\n127%\n127%\n127%\n119%\n109%\n-\n-\n-\n";
			TextMesh textMesh58 = this.Name[9];
			textMesh58.text += "\n94%\n91%\n88%\n84%\n82%\n81%\n81%\n80%\n80%\n-\n-\n-\n";
			TextMesh textMesh59 = this.Name[10];
			textMesh59.text += "\n1%\n1%\n1%\n1%\n2%\n2%\n2%\n5%\n5%\n-\n-\n-\n";
			TextMesh textMesh60 = this.Name[11];
			textMesh60.text += "\n2.3%\n2.27%\n2.2%\n2.16%\n2.07%\n2.06%\n2.06%\n1.89%\n1.79%\n-\n-\n-\n";
			TextMesh textMesh61 = this.Name[8];
			textMesh61.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh62 = this.Name[9];
			textMesh62.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh63 = this.Name[10];
			textMesh63.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh64 = this.Name[11];
			textMesh64.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh65 = this.Name[8];
			textMesh65.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh66 = this.Name[9];
			textMesh66.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh67 = this.Name[10];
			textMesh67.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh68 = this.Name[11];
			textMesh68.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			return;
		}
		if (this.global1.data[0] == 3)
		{
			TextMesh textMesh69 = this.Name[8];
			textMesh69.text += "\n137%\n137%\n137%\n137%\n127%\n127%\n127%\n127%\n126%\n120%\n105%\n-\n";
			TextMesh textMesh70 = this.Name[9];
			textMesh70.text += "\n99%\n99%\n99%\n99%\n99%\n99%\n99%\n99%\n99%\n98%\n90%\n-\n";
			TextMesh textMesh71 = this.Name[10];
			textMesh71.text += "\n0%\n0%\n0%\n0%\n1%\n1%\n1%\n1%\n1%\n2%\n5%\n-\n";
			TextMesh textMesh72 = this.Name[11];
			textMesh72.text += "\n2.38%\n2.38%\n2.36%\n2.36%\n2.26%\n2.25%\n2.25%\n2.25%\n2.23%\n2.17%\n1.81%\n-\n";
			TextMesh textMesh73 = this.Name[8];
			textMesh73.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh74 = this.Name[9];
			textMesh74.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh75 = this.Name[10];
			textMesh75.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh76 = this.Name[11];
			textMesh76.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh77 = this.Name[8];
			textMesh77.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh78 = this.Name[9];
			textMesh78.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh79 = this.Name[10];
			textMesh79.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh80 = this.Name[11];
			textMesh80.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			return;
		}
		if (this.global1.data[0] == 20)
		{
			TextMesh textMesh81 = this.Name[8];
			textMesh81.text += "\n93%\n93%\n93%\n93%\n93%\n93%\n93%\n93%\n93%\n93%\n105%\n105%\n";
			TextMesh textMesh82 = this.Name[9];
			textMesh82.text += "\n59%\n57%\n56%\n55%\n54%\n53%\n52%\n51%\n49%\n47%\n46%\n45%\n";
			TextMesh textMesh83 = this.Name[10];
			textMesh83.text += "\n1%\n1%\n1%\n1%\n1%\n1%\n1%\n1%\n1%\n1%\n0%\n0%\n";
			TextMesh textMesh84 = this.Name[11];
			textMesh84.text += "\n1.51%\n1.49%\n1.48%\n1.47%\n1.46%\n1.45%\n1.44%\n1.43%\n1.41%\n1.39%\n1.51%\n1.51%\n";
			TextMesh textMesh85 = this.Name[8];
			textMesh85.text += "105%\n119%\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh86 = this.Name[9];
			textMesh86.text += "43%\n41%\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh87 = this.Name[10];
			textMesh87.text += "-1%\n-5%\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh88 = this.Name[11];
			textMesh88.text += "1.51%\n1.63%\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh89 = this.Name[8];
			textMesh89.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh90 = this.Name[9];
			textMesh90.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh91 = this.Name[10];
			textMesh91.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh92 = this.Name[11];
			textMesh92.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			return;
		}
		if (this.global1.data[0] == 10)
		{
			TextMesh textMesh93 = this.Name[8];
			textMesh93.text += "\n105%\n105%\n105%\n105%\n105%\n105%\n105%\n105%\n105%\n105%\n105%\n105%\n";
			TextMesh textMesh94 = this.Name[9];
			textMesh94.text += "\n44%\n44%\n44%\n44%\n44%\n44%\n45%\n46%\n47%\n48%\n49%\n50%\n";
			TextMesh textMesh95 = this.Name[10];
			textMesh95.text += "\n1%\n1%\n1%\n1%\n1%\n1%\n1%\n1%\n1%\n1%\n1%\n1%\n";
			TextMesh textMesh96 = this.Name[11];
			textMesh96.text += "\n1.48%\n1.48%\n1.48%\n1.48%\n1.48%\n1.49%\n1.5%\n1.51%\n1.52%\n1.53%\n1.54%\n1.55%\n";
			TextMesh textMesh97 = this.Name[8];
			textMesh97.text += "103%\n103%\n103%\n97%\n96%\n94%\n94%\n94%\n92%\n90%\n88%\n86%\n";
			TextMesh textMesh98 = this.Name[9];
			textMesh98.text += "49%\n49%\n49%\n49%\n49%\n48%\n48%\n47%\n47%\n46%\n46%\n44%\n";
			TextMesh textMesh99 = this.Name[10];
			textMesh99.text += "1%\n1%\n1%\n3%\n3%\n4%\n4%\n4%\n4%\n5%\n5%\n6%\n";
			TextMesh textMesh100 = this.Name[11];
			textMesh100.text += "1.51%\n1.51%\n1.50%\n1.43%\n1.42%\n1.38%\n1.37%\n1.36%\n1.35%\n1.31%\n1.29%\n1.24%\n";
			TextMesh textMesh101 = this.Name[8];
			textMesh101.text += "84%\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh102 = this.Name[9];
			textMesh102.text += "42%\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh103 = this.Name[10];
			textMesh103.text += "13%\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			TextMesh textMesh104 = this.Name[11];
			textMesh104.text += "1.13%\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			return;
		}
		if (this.global1.data[0] == 18)
		{
			TextMesh textMesh105 = this.Name[8];
			textMesh105.text += "\n168%\n168%\n168%\n168%\n162%\n161%\n160%\n159%\n155%\n148%\n143%\n139%\n";
			TextMesh textMesh106 = this.Name[9];
			textMesh106.text += "\n66%\n69%\n72%\n75%\n75%\n75%\n75%\n75%\n75%\n75%\n75%\n75%\n";
			TextMesh textMesh107 = this.Name[10];
			textMesh107.text += "\n-3%\n-3%\n-3%\n-3%\n-2%\n-2%\n-2%\n-2%\n-2%\n-1%\n0%\n0%\n";
			TextMesh textMesh108 = this.Name[11];
			textMesh108.text += "\n2.37%\n2.4%\n2.43%\n2.46%\n2.4%\n2.4%\n2.4%\n2.2%\n2.37%\n2.24%\n2.18%\n2.14%\n";
			TextMesh textMesh109 = this.Name[8];
			textMesh109.text += "117%\n101%\n66%\n65%\n59%\n59%\n57%\n55%\n57%\n49%\n47%\n55%\n";
			TextMesh textMesh110 = this.Name[9];
			textMesh110.text += "72%\n68%\n65%\n61%\n56%\n55%\n51%\n46%\n45%\n41%\n36%\n35%\n";
			TextMesh textMesh111 = this.Name[10];
			textMesh111.text += "4%\n8%\n8%\n9%\n10%\n10%\n11%\n11%\n11%\n11%\n13%\n13%\n";
			TextMesh textMesh112 = this.Name[11];
			textMesh112.text += "1.85%\n1.61%\n1.19%\n1.12%\n1%\n0.92%\n0.85%\n0.85%\n0.78%\n0.62%\n0.55%\n0.69%\n";
			TextMesh textMesh113 = this.Name[8];
			textMesh113.text += "61%\n59%\n57%\n55%\n53%\n51%\n-11%\n-13%\n-15%\n-17%\n-13%\n-13%\n";
			TextMesh textMesh114 = this.Name[9];
			textMesh114.text += "32%\n31%\n26%\n25%\n22%\n21%\n21%\n21%\n21%\n21%\n21%\n21%\n";
			TextMesh textMesh115 = this.Name[10];
			textMesh115.text += "20%\n21%\n22%\n23%\n24%\n25%\n56%\n57%\n58%\n59%\n57%\n57%\n";
			TextMesh textMesh116 = this.Name[11];
			textMesh116.text += "0.61%\n0.55%\n0.49%\n0.44%\n0.38%\n0.33%\n-0.67%\n-0.7%\n-0.6%\n-0.59%\n-0.56%\n-0.52%\n";
			return;
		}
		if (this.global1.data[0] == 12)
		{
			TextMesh textMesh117 = this.Name[8];
			textMesh117.text += "\n143%\n143%\n143%\n143%\n147%\n147%\n151%\n151%\n151%\n151%\n151%\n151%\n";
			TextMesh textMesh118 = this.Name[9];
			textMesh118.text += "\n35%\n32%\n28%\n27%\n27%\n27%\n27%\n27%\n27%\n27%\n27%\n27%\n";
			TextMesh textMesh119 = this.Name[10];
			textMesh119.text += "\n0%\n0%\n0%\n0%\n0%\n0%\n0%\n0%\n0%\n0%\n0%\n0%\n";
			TextMesh textMesh120 = this.Name[11];
			textMesh120.text += "\n1.77%\n1.74%\n1.7%\n1.65%\n1.64%\n1.63%\n1.62%\n1.6%\n1.59%\n1.78%\n1.79%\n1.8%\n";
			TextMesh textMesh121 = this.Name[8];
			textMesh121.text += "151%\n151%\n151%\n151%\n149%\n147%\n147%\n147%\n145%\n143%\n141%\n141%\n";
			TextMesh textMesh122 = this.Name[9];
			textMesh122.text += "28%\n29%\n29%\n29%\n29%\n29%\n29%\n29%\n29%\n29%\n29%\n29%\n";
			TextMesh textMesh123 = this.Name[10];
			textMesh123.text += "1%\n1%\n1%\n1%\n2%\n2%\n2%\n2%\n6%\n2%\n2%\n1%\n";
			TextMesh textMesh124 = this.Name[11];
			textMesh124.text += "1.8%\n1.8%\n1.8%\n1.8%\n1.76%\n1.75%\n1.75%\n1.75%\n1.73%\n1.7%\n1.68%\n1.68%\n";
			TextMesh textMesh125 = this.Name[8];
			textMesh125.text += "141%\n171%\n169%\n169%\n169%\n163%\n158%\n158%\n158%\n153%\n153%\n153%\n";
			TextMesh textMesh126 = this.Name[9];
			textMesh126.text += "29%\n29%\n31%\n31%\n31%\n32%\n32%\n32%\n32%\n32%\n31%\n30%\n";
			TextMesh textMesh127 = this.Name[10];
			textMesh127.text += "0%\n-10%\n-10%\n-10%\n-10%\n-10%\n-10%\n-10%\n-10%\n-10%\n-10%\n-10%\n";
			TextMesh textMesh128 = this.Name[11];
			textMesh128.text += "1.68%\n2.14%\n2.13%\n2.12%\n2.08%\n2.02%\n1.93%\n1.9%\n1.87%\n1.81%\n1.81%\n1.8%\n";
			return;
		}
		TextMesh textMesh129 = this.Name[8];
		textMesh129.text += "\n150%\n150%\n150%\n150%\n146%\n146%\n146%\n146%\n141%\n139%\n127%\n142%\n";
		TextMesh textMesh130 = this.Name[9];
		textMesh130.text += "\n100%\n100%\n100%\n100%\n100%\n100%\n99%\n99%\n99%\n100%\n100%\n98%\n";
		TextMesh textMesh131 = this.Name[10];
		textMesh131.text += "\n-1%\n-1%\n-2%\n-2%\n-1%\n0%\n0%\n0%\n0%\n0%\n0%\n3%\n";
		TextMesh textMesh132 = this.Name[11];
		textMesh132.text += "\n2.5%\n2.5%\n2.52%\n2.52%\n2.47%\n2.45%\n2.45%\n2.45%\n2.45%\n2.41%\n2.37%\n2.41%\n";
		if (this.global1.data[216] > 50)
		{
			TextMesh textMesh133 = this.Name[8];
			textMesh133.text += "151%\n157%\n157%\n168%\n166%\n164%\n167%\n169%\n169%\n171%\n172%\n173%\n";
			TextMesh textMesh134 = this.Name[9];
			textMesh134.text += "66%\n64%\n62%\n63%\n63%\n63%\n63%\n60%\n60%\n59%\n59%\n59%\n";
			TextMesh textMesh135 = this.Name[10];
			textMesh135.text += "7%\n7%\n7%\n8%\n8%\n9%\n7%\n7%\n8%\n7%\n7%\n9%\n";
			TextMesh textMesh136 = this.Name[11];
			textMesh136.text += "2.37%\n2.22%\n1.74%\n1.23%\n1.21%\n1.19%\n1.24%\n1.23%\n1.21%\n1.12%\n1.23%\n1.19%\n";
			TextMesh textMesh137 = this.Name[8];
			textMesh137.text += "178%\n177%\n177%\n178%\n180%\n180%\n181%\n181%\n182%\n183%\n183%\n181%\n";
			TextMesh textMesh138 = this.Name[9];
			textMesh138.text += "62%\n68%\n68%\n67%\n69%\n71%\n73%\n70%\n70%\n73%\n74%\n74%\n";
			TextMesh textMesh139 = this.Name[10];
			textMesh139.text += "6%\n7%\n6%\n5%\n6%\n6%\n6%\n3%\n3%\n4%\n4%\n4%\n";
			TextMesh textMesh140 = this.Name[11];
			textMesh140.text += "1.47%\n1.52%\n1.74%\n1.81%\n1.82%\n1.83%\n1.84%\n1.83%\n1.91%\n1.92%\n1.93%\n1.89%\n";
			return;
		}
		TextMesh textMesh141 = this.Name[8];
		textMesh141.text += "151%\n137%\n117%\n68%\n66%\n64%\n-\n-\n-\n-\n-\n-\n";
		TextMesh textMesh142 = this.Name[9];
		textMesh142.text += "66%\n64%\n62%\n63%\n63%\n63%\n-\n-\n-\n-\n-\n-\n";
		TextMesh textMesh143 = this.Name[10];
		textMesh143.text += "7%\n7%\n7%\n8%\n8%\n9%\n-\n-\n-\n-\n-\n-\n";
		TextMesh textMesh144 = this.Name[11];
		textMesh144.text += "2.37%\n2.22%\n1.74%\n1.23%\n1.21%\n1.19%\n-\n-\n-\n-\n-\n-\n";
		TextMesh textMesh145 = this.Name[8];
		textMesh145.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
		TextMesh textMesh146 = this.Name[9];
		textMesh146.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
		TextMesh textMesh147 = this.Name[10];
		textMesh147.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
		TextMesh textMesh148 = this.Name[11];
		textMesh148.text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
	}

	// Token: 0x0400019B RID: 411
	public TextMesh[] Name = new TextMesh[12];

	// Token: 0x0400019C RID: 412
	private GlobalScript global1;
}
