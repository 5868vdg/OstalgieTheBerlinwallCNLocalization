using System;
using UnityEngine;

// Token: 0x02000042 RID: 66
public class VersioNScript : MonoBehaviour
{
	// Token: 0x0600012A RID: 298 RVA: 0x00002E87 File Offset: 0x00001087
	private void Awake()
	{
		if (this.active)
		{
			this.Vivod();
		}
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00002E97 File Offset: 0x00001097
	private void OnMouseEnter()
	{
		if (this.active)
		{
			base.GetComponent<TextMesh>().color = Color.green;
			return;
		}
		base.GetComponent<SpriteRenderer>().sprite = this.navel;
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00002EC3 File Offset: 0x000010C3
	private void OnMouseExit()
	{
		if (this.active)
		{
			base.GetComponent<TextMesh>().color = Color.red;
			return;
		}
		base.GetComponent<SpriteRenderer>().sprite = this.nenavel;
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00002EEF File Offset: 0x000010EF
	private void OnMouseDown()
	{
		if (!this.planshet.activeSelf)
		{
			this.planshet.SetActive(true);
			this.TextAfter();
			return;
		}
		this.planshet.SetActive(false);
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00191EB4 File Offset: 0x001900B4
	private void TextAfter()
	{
		string text;
		if (PlayerPrefs.GetInt("language") == 0)
		{
			text = "|1) 在 游 戏 末 尾 增 加 了 不 同 情 景 下 北 约 的 结 局 |2) 增 加 了 2 个 新 成 就|3) 增 加 了 在 尼 基 施 主 义 路 线 下 与 民 主 德 国 和 奥 地 利 的 互 动 |4) 统 计 界 面 中 “ 联 盟 ” 派 系 的 状 态 现 在 更 好 地 反 映 了 国 家 紧 急 状 态 委 员 会 的 胜 利 后 的  实 际 情 况|5) 增 加 了 与 越 南 在 经 互 会 崩 溃 后 贸 易 的 选 项|6) 增 加 了 以 民 主 改 革 为 代 价 减 少 北 约 威 胁 的 可 能|7) 修 复 了 漏 洞 及 错 误|| 玩 得 开 心 ！";
		}
		else
		{
			text = "|1) Добавлены концовки НАТО под разные ситуации на конец игры.|2) Добавлено 2 новых достижения.|3) Добавлено взаимодействие ГДР с Австрией при пути никишизма.|4) Описание состояния фракции «Союз» в статистике больше соответствует действительности для успеха ГКЧП.|5) Добавлена возможность торговли с Вьетнамом при крушении СЭВ.|6) Добавлена возможность снижения угрозы НАТО ценой проведения демократических реформ.|7) Исправлены баги и ошибки.||Приятной игры!";
		}
		this.text.text = this.Text(text, 54);
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00191EF0 File Offset: 0x001900F0
	private void Vivod()
	{
		if (!PlayerPrefs.HasKey("versionlast") || PlayerPrefs.GetInt("versionlast") != this.versionlast)
		{
			PlayerPrefs.SetInt("versionlast", this.versionlast);
			this.planshet.SetActive(true);
			this.TextAfter();
		}
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00003D84 File Offset: 0x00001F84
	private string Text(string text, int col)
	{
		int num = 0;
		string text2 = "";
		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] == char.Parse("|"))
			{
				num = 0;
				text2 += "\n";
			}
			else if (num >= col)
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

	// Token: 0x040001CD RID: 461
	public TextMesh text;

	// Token: 0x040001CE RID: 462
	public Sprite navel;

	// Token: 0x040001CF RID: 463
	public Sprite nenavel;

	// Token: 0x040001D0 RID: 464
	public GameObject planshet;

	// Token: 0x040001D1 RID: 465
	public bool active;

	// Token: 0x040001D2 RID: 466
	public bool button;

	// Token: 0x040001D3 RID: 467
	public int versionlast;
}
