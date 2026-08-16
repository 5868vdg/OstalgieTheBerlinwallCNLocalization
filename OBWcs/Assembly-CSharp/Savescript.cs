using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using UnityEngine;

// Token: 0x02000034 RID: 52
public class Savescript : MonoBehaviour
{
	// Token: 0x060000E8 RID: 232 RVA: 0x00002800 File Offset: 0x00000A00
	public bool from_string(string str)
	{
		return str == "True";
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x00002BBA File Offset: 0x00000DBA
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00157494 File Offset: 0x00155694
	public void OnMouseDown()
	{
		string[] array = new string[]
		{
			PlayerPrefs.GetString("V1"),
			PlayerPrefs.GetString("I2"),
			PlayerPrefs.GetString("S3"),
			PlayerPrefs.GetString("R3")
		};
		PlayerPrefs.SetString("V1" + this.number.ToString(), array[0]);
		PlayerPrefs.SetString("I2" + this.number.ToString(), array[1]);
		PlayerPrefs.SetString("S3" + this.number.ToString(), array[2]);
		PlayerPrefs.SetString("R3" + this.number.ToString(), array[3]);
		PlayerPrefs.SetString("b4" + this.number.ToString(), this.global1.bylo.ToString());
		PlayerPrefs.SetString("n5" + this.number.ToString(), this.global1.neizucheno.ToString());
		PlayerPrefs.SetString("g6" + this.number.ToString(), string.Concat(new string[]
		{
			this.global1.data[19].ToString(),
			".",
			this.global1.data[20].ToString(),
			".",
			this.global1.data[21].ToString()
		}));
		PlayerPrefs.SetString("01d" + this.number.ToString(), this.global1.diff[0].ToString());
		PlayerPrefs.SetString("02d" + this.number.ToString(), this.global1.diff[1].ToString());
		PlayerPrefs.SetString("03d" + this.number.ToString(), this.global1.diff[2].ToString());
		PlayerPrefs.SetString("sand" + this.number.ToString(), this.global1.diff[3].ToString());
		PlayerPrefs.SetString("04d" + this.number.ToString(), this.global1.diff[4].ToString());
		PlayerPrefs.SetString("n6" + this.number.ToString(), this.global1.allcountries[this.global1.data[0]].name);
		if (this.number == 5)
		{
			PlayerPrefs.SetString("i7" + this.number.ToString(), this.global1.iron_and_blood.ToString());
		}
		else
		{
			PlayerPrefs.SetString("i7" + this.number.ToString(), "False");
		}
		for (int i = 0; i < 5; i++)
		{
			for (int j = 0; j < 15; j++)
			{
				PlayerPrefs.SetString("b8" + i.ToString() + j.ToString() + this.number.ToString(), this.global1.regions[i].buildings[j].is_builded.ToString());
				PlayerPrefs.SetString("w9" + i.ToString() + j.ToString() + this.number.ToString(), this.global1.regions[i].buildings[j].is_working.ToString());
				PlayerPrefs.SetString("p10" + i.ToString() + j.ToString() + this.number.ToString(), this.global1.regions[i].buildings[j].is_private.ToString());
				PlayerPrefs.SetInt(string.Concat(new object[] { "t11", i, j, this.number }), this.global1.regions[i].buildings[j].type);
				PlayerPrefs.SetInt("l12" + i.ToString() + this.number.ToString(), this.global1.regions[i].city_level);
			}
		}
		for (int k = 0; k < this.global1.allcountries.Length; k++)
		{
			if (this.global1.allcountries[k] != null)
			{
				PlayerPrefs.SetString("SEV" + k.ToString() + this.number.ToString(), this.global1.allcountries[k].isSEV.ToString());
				PlayerPrefs.SetString("OVD" + k.ToString() + this.number.ToString(), this.global1.allcountries[k].isOVD.ToString());
				PlayerPrefs.SetString("Vys" + k.ToString() + this.number.ToString(), this.global1.allcountries[k].Vyshi.ToString());
				PlayerPrefs.SetString("Don" + k.ToString() + this.number.ToString(), this.global1.allcountries[k].Donat.ToString());
				PlayerPrefs.SetString("Hel" + k.ToString() + this.number.ToString(), this.global1.allcountries[k].Help.ToString());
				PlayerPrefs.SetString("Sta" + k.ToString() + this.number.ToString(), this.global1.allcountries[k].Stasi.ToString());
				PlayerPrefs.SetString("Tor" + k.ToString() + this.number.ToString(), this.global1.allcountries[k].Torg.ToString());
				PlayerPrefs.SetString("Mon" + k.ToString() + this.number.ToString(), this.global1.allcountries[k].Money.ToString());
				PlayerPrefs.SetInt("Wes" + k.ToString() + this.number.ToString(), this.global1.allcountries[k].Westalgie);
				PlayerPrefs.SetInt("Gos" + k.ToString() + this.number.ToString(), this.global1.allcountries[k].Gosstroy);
				PlayerPrefs.SetInt("Cou" + k.ToString() + this.number.ToString(), this.global1.allcountries[k].paths);
				PlayerPrefs.SetInt("Sub" + k.ToString() + this.number.ToString(), this.global1.allcountries[k].subideology);
			}
			PlayerPrefs.SetInt("Wes" + 17.ToString() + this.number.ToString(), this.global1.allcountries[17].Westalgie);
			PlayerPrefs.SetInt("Wes" + 40.ToString() + this.number.ToString(), this.global1.allcountries[40].Westalgie);
			PlayerPrefs.SetInt("Wes" + 41.ToString() + this.number.ToString(), this.global1.allcountries[41].Westalgie);
			PlayerPrefs.SetInt("Wes" + 42.ToString() + this.number.ToString(), this.global1.allcountries[42].Westalgie);
			PlayerPrefs.SetInt("Wes" + 43.ToString() + this.number.ToString(), this.global1.allcountries[43].Westalgie);
			PlayerPrefs.SetInt("Wes" + 44.ToString() + this.number.ToString(), this.global1.allcountries[44].Westalgie);
			PlayerPrefs.SetInt("Wes" + 45.ToString() + this.number.ToString(), this.global1.allcountries[45].Westalgie);
			PlayerPrefs.SetInt("Wes" + 46.ToString() + this.number.ToString(), this.global1.allcountries[46].Westalgie);
			PlayerPrefs.SetInt("Wes" + 47.ToString() + this.number.ToString(), this.global1.allcountries[47].Westalgie);
		}
		for (int l = 1; l < 8; l++)
		{
			PlayerPrefs.SetInt("Cou" + l.ToString() + this.number.ToString(), this.global1.allcountries[l].paths);
		}
		for (int m = 0; m < this.global1.Events_number.Length; m++)
		{
			PlayerPrefs.SetInt("E_num" + m.ToString() + this.number.ToString(), this.global1.Events_number[m]);
			PlayerPrefs.SetFloat("E_tim" + m.ToString() + this.number.ToString(), this.global1.Events_time[m]);
			PlayerPrefs.SetString("E_act" + m.ToString() + this.number.ToString(), this.global1.Events_active[m].ToString());
			PlayerPrefs.SetString("E_don" + m.ToString() + this.number.ToString(), this.global1.event_done[m].ToString());
			PlayerPrefs.SetInt("E_variant" + m.ToString() + this.number.ToString(), this.global1.eventVariantChosen[m]);
		}
		PlayerPrefs.SetString("elec" + this.number.ToString(), this.global1.is_elect.ToString());
		PlayerPrefs.SetString("spee" + this.number.ToString(), this.global1.is_speech.ToString());
		PlayerPrefs.SetString("libe" + this.number.ToString(), this.global1.is_liber.ToString());
		PlayerPrefs.SetString("povod" + this.number.ToString(), this.global1.povod.ToString());
		PlayerPrefs.SetString("konst" + this.number.ToString(), this.global1.is_konst_max.ToString());
		PlayerPrefs.SetString("gkchp" + this.number.ToString(), this.global1.is_gkchp.ToString());
		PlayerPrefs.SetInt("issled" + this.number.ToString(), this.global1.issleduetsya);
		for (int n = 0; n < this.global1.party_number.Length; n++)
		{
			PlayerPrefs.SetString("P_ally" + n.ToString() + this.number.ToString(), this.global1.is_party_ally[n].ToString());
			PlayerPrefs.SetString("P_enab" + n.ToString() + this.number.ToString(), this.global1.is_party_enabled[n].ToString());
			PlayerPrefs.SetInt("P_num" + n.ToString() + this.number.ToString(), this.global1.party_number[n]);
			PlayerPrefs.SetInt("P_ideo" + n.ToString() + this.number.ToString(), this.global1.party_ideology[n]);
			PlayerPrefs.SetString("P_name" + n.ToString() + this.number.ToString(), this.global1.party_name[n]);
		}
		for (int num = 0; num < this.global1.science.Length; num++)
		{
			PlayerPrefs.SetString("science" + num.ToString() + this.number.ToString(), this.global1.science[num].ToString());
			PlayerPrefs.SetInt("S_time" + num.ToString() + this.number.ToString(), this.global1.science_time[num]);
		}
		for (int num2 = 0; num2 < this.global1.data_old.Length; num2++)
		{
			PlayerPrefs.SetInt("D_old" + num2.ToString() + this.number.ToString(), this.global1.data_old[num2]);
		}
		for (int num3 = 0; num3 < this.global1.data.Length; num3++)
		{
			PlayerPrefs.SetInt("data" + num3.ToString() + this.number.ToString(), this.global1.data[num3]);
		}
		this.DeleteSave(this.number);
		if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51)
		{
			this.WriteYugoSave(this.number);
		}
		if (PlayerPrefs.GetInt("language") == 0)
		{
			this.Opis.text = "SAVED";
			return;
		}
		this.Opis.text = "СОХРАНЕНО";
	}

	// Token: 0x060000EB RID: 235 RVA: 0x001582F8 File Offset: 0x001564F8
	private void WriteYugoSave(int num)
	{
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		Yugoglobal component = GameObject.Find("Yugoglobal(Clone)").GetComponent<Yugoglobal>();
		if (!Directory.Exists("YugData"))
		{
			Directory.CreateDirectory("YugData");
		}
		using (FileStream fileStream = File.Create(string.Format("YugData{0}{1}.save", Path.DirectorySeparatorChar, num)))
		{
			binaryFormatter.Serialize(fileStream, component.gameState);
		}
	}

	// Token: 0x060000EC RID: 236 RVA: 0x0015837C File Offset: 0x0015657C
	public void DeleteSave(int num)
	{
		if (File.Exists(string.Format("YugData{0}{1}.save", Path.DirectorySeparatorChar, num)))
		{
			File.Delete(string.Format("YugData{0}{1}.save", Path.DirectorySeparatorChar, num));
		}
	}

	// Token: 0x060000ED RID: 237 RVA: 0x001583CC File Offset: 0x001565CC
	private void OnMouseEnter()
	{
		if (PlayerPrefs.GetInt("language") == 0)
		{
			if (this.number == 5)
			{
				this.Opis.text = " 可 解 锁 成 就";
			}
			else
			{
				this.Opis.text = " 不 可 解 锁 成 就";
			}
			if (PlayerPrefs.HasKey("g6" + this.number.ToString()))
			{
				TextMesh opis = this.Opis;
				opis.text = opis.text + "\n 日 期: " + PlayerPrefs.GetString("g6" + this.number.ToString());
				TextMesh opis2 = this.Opis;
				opis2.text = opis2.text + "\n 国 家: " + this.global1.allcountries[PlayerPrefs.GetInt("data0" + this.number.ToString())].name;
				TextMesh opis3 = this.Opis;
				opis3.text = opis3.text + "\n 北 约 威 胁: " + (PlayerPrefs.GetInt("data10" + this.number.ToString()) / 10).ToString();
				int @int = PlayerPrefs.GetInt("data14" + this.number.ToString(), -1);
				if (@int != -1 && @int < this.global1.doctr.Length)
				{
					string text = this.global1.doctr[@int];
					text = Regex.Replace(text, "(?<=-)\\|", "");
					text = Regex.Replace(text, "\\|", "\n");
					text = text.Replace("\n\n", "\n");
					if (!string.IsNullOrEmpty(text))
					{
						TextMesh opis4 = this.Opis;
						opis4.text = opis4.text + "\n 体 制: " + text;
					}
				}
				TextMesh opis5 = this.Opis;
				opis5.text = opis5.text + "\n 社 会 主 义 阵 营: " + (PlayerPrefs.GetInt("data7" + this.number.ToString()) / 10).ToString();
				TextMesh opis6 = this.Opis;
				opis6.text += "\n 难 度: ";
				bool flag = this.from_string(PlayerPrefs.GetString("01d" + this.number.ToString()));
				bool flag2 = this.from_string(PlayerPrefs.GetString("02d" + this.number.ToString()));
				bool flag3 = this.from_string(PlayerPrefs.GetString("03d" + this.number.ToString()));
				if (flag && flag2 && flag3)
				{
					TextMesh opis7 = this.Opis;
					opis7.text += "<color=red> 开 启</color>";
				}
				else
				{
					TextMesh opis8 = this.Opis;
					opis8.text += "<color=red> 关 闭</color>";
				}
				TextMesh opis9 = this.Opis;
				opis9.text += "\n 成 就: ";
				bool flag4 = this.from_string(PlayerPrefs.GetString("i7" + this.number.ToString()));
				bool flag5 = this.from_string(PlayerPrefs.GetString("sand" + this.number.ToString()));
				if (flag4)
				{
					TextMesh opis10 = this.Opis;
					opis10.text += "<color=red> 可 用</color>";
				}
				else if (flag && flag2 && flag3 && !flag5)
				{
					TextMesh opis11 = this.Opis;
					opis11.text += "<color=red> 仅 路 线</color>";
				}
				else
				{
					TextMesh opis12 = this.Opis;
					opis12.text += "<color=red> 不 可 用</color>";
				}
				TextMesh opis13 = this.Opis;
				opis13.text += "\n 戈 尔 巴 乔 夫 的 电 话: ";
				if (this.from_string(PlayerPrefs.GetString("04d" + this.number.ToString())))
				{
					TextMesh opis14 = this.Opis;
					opis14.text += "<color=blue> 开 启</color>";
				}
				else
				{
					TextMesh opis15 = this.Opis;
					opis15.text += "<color=blue> 关 闭</color>";
				}
			}
			else
			{
				TextMesh opis16 = this.Opis;
				opis16.text += "\n 空 位";
			}
		}
		else
		{
			if (this.number == 5)
			{
				this.Opis.text = "С Достижениями";
			}
			else
			{
				this.Opis.text = "Без Достижений";
			}
			if (PlayerPrefs.HasKey("g6" + this.number.ToString()))
			{
				TextMesh opis17 = this.Opis;
				opis17.text = opis17.text + "\nДата: " + PlayerPrefs.GetString("g6" + this.number.ToString());
				TextMesh opis18 = this.Opis;
				opis18.text = opis18.text + "\nСтрана: " + this.global1.allcountries[PlayerPrefs.GetInt("data0" + this.number.ToString())].name;
				TextMesh opis19 = this.Opis;
				opis19.text = opis19.text + "\nУгроза НАТО: " + (PlayerPrefs.GetInt("data10" + this.number.ToString()) / 10).ToString();
				int int2 = PlayerPrefs.GetInt("data14" + this.number.ToString(), -1);
				if (int2 != -1 && int2 < this.global1.doctr.Length)
				{
					string text2 = this.global1.doctr[int2];
					text2 = Regex.Replace(text2, "(?<=-)\\|", "");
					text2 = Regex.Replace(text2, "\\|", "\n");
					text2 = text2.Replace("\n\n", "\n");
					if (!string.IsNullOrEmpty(text2))
					{
						TextMesh opis20 = this.Opis;
						opis20.text = opis20.text + "\nГосстрой: " + text2;
					}
				}
				TextMesh opis21 = this.Opis;
				opis21.text = opis21.text + "\nСоцлагерь: " + (PlayerPrefs.GetInt("data7" + this.number.ToString()) / 10).ToString();
				TextMesh opis22 = this.Opis;
				opis22.text += "\nСложность: ";
				bool flag6 = this.from_string(PlayerPrefs.GetString("01d" + this.number.ToString()));
				bool flag7 = this.from_string(PlayerPrefs.GetString("02d" + this.number.ToString()));
				bool flag8 = this.from_string(PlayerPrefs.GetString("03d" + this.number.ToString()));
				if (flag6 && flag7 && flag8)
				{
					TextMesh opis23 = this.Opis;
					opis23.text += "<color=red>Включена</color>";
				}
				else
				{
					TextMesh opis24 = this.Opis;
					opis24.text += "<color=red>Выключена</color>";
				}
				TextMesh opis25 = this.Opis;
				opis25.text += "\nДостижения: ";
				bool flag9 = this.from_string(PlayerPrefs.GetString("i7" + this.number.ToString()));
				bool flag10 = this.from_string(PlayerPrefs.GetString("sand" + this.number.ToString()));
				if (flag9)
				{
					TextMesh opis26 = this.Opis;
					opis26.text += "<color=red>Доступны</color>";
				}
				else if (flag6 && flag7 && flag8 && !flag10)
				{
					TextMesh opis27 = this.Opis;
					opis27.text += "<color=red>Только пути</color>";
				}
				else
				{
					TextMesh opis28 = this.Opis;
					opis28.text += "<color=red>Недоступны</color>";
				}
				TextMesh opis29 = this.Opis;
				opis29.text += "\nЗвонок Горбачёва: ";
				if (this.from_string(PlayerPrefs.GetString("04d" + this.number.ToString())))
				{
					TextMesh opis30 = this.Opis;
					opis30.text += "<color=blue>Включён</color>";
				}
				else
				{
					TextMesh opis31 = this.Opis;
					opis31.text += "<color=blue>Выключен</color>";
				}
			}
			else
			{
				TextMesh opis32 = this.Opis;
				opis32.text += "\nПустой слот";
			}
		}
		base.GetComponent<SpriteRenderer>().sprite = this.navel;
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00002BD1 File Offset: 0x00000DD1
	private void OnMouseExit()
	{
		base.GetComponent<SpriteRenderer>().sprite = this.nenavel;
		this.Opis.text = "";
	}

	// Token: 0x0400017C RID: 380
	public int number;

	// Token: 0x0400017D RID: 381
	public GlobalScript global1;

	// Token: 0x0400017E RID: 382
	public TextMesh Opis;

	// Token: 0x0400017F RID: 383
	public Sprite navel;

	// Token: 0x04000180 RID: 384
	public Sprite nenavel;
}
