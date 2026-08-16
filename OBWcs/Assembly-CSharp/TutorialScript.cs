using System;
using UnityEngine;

// Token: 0x02000004 RID: 4
public class TutorialScript : MonoBehaviour
{
	// Token: 0x0600000A RID: 10 RVA: 0x000036DC File Offset: 0x000018DC
	private void Repaint()
	{
		if (PlayerPrefs.GetInt("language") == 0)
		{
			this.shower.sprite = this.slides_en[this.now];
			if (this.now_text == 0)
			{
				this.text_this = " 同 志 ， 你 好 ！这 是 你 第 一 次 进 入 游 戏 ， 并 且 不 知 道 该 做 什 么 ？ 不 用 担 心 ， 现 在 我 将 教 你 如 何 治 理 国 家 ！";
			}
			else if (this.now_text == 1)
			{
				this.text_this = " 这 是 外 交 界 面 ， 也 就 是 这 个 游 戏 的 主 要 行 动 进 行 的 地 方 。 通 过 点 击 国 家 ， 你 可 以 查 看 你 可 以 对 它 们 做 出 的 外 交 行 动 以 及 相 应 的 条 件 。";
			}
			else if (this.now_text == 2)
			{
				this.text_this = " 在 左 上 角 ， 显 示 了 日 期 和 速 度 图 标 。 “ 东 德 情 结 ” 是 一 款 实 时 游 戏 ， 所 以 为 了 继 续 你 将 需 要 点 击 日 期 下 方 一 行 的 按 钮 以 设 定 速 度 。 ";
			}
			else if (this.now_text == 3)
			{
				this.text_this = " 点 击 同 一 个 面 板 上 旁 边 的 按 钮 ， 你 就 可 以 随 时 暂 停 游 戏 ， 你 也 可 以 按 空 格 ， 效 果 是 一 样 的 。";
			}
			else if (this.now_text == 4)
			{
				this.text_this = " 事 件 会 在 游 戏 过 程 中 出 现 ， 并 会 显 示 为 像 这 样 的 图 标 。 点 击 它 ， 你 就 会 进 入 该 事 件 并 决 定 如 何 处 理 它 们 。";
			}
			else if (this.now_text == 5)
			{
				this.text_this = " 游 戏 会 暂 停 并 保 持 到 你 手 动 恢 复 ， 所 以 当 有 多 个 事 件 时 不 需 要 按 下 暂 停 ， 只 要 点 进 其 中 一 个 就 行 。";
			}
			else if (this.now_text == 6)
			{
				this.text_this = " 在 外 交 界 面 的 上 方 是 你 国 家 状 态 的 数 字 指 示 器 ， 每 周 更 新 一 次 。 把 光 标 悬 停 在 上 面 ， 你 就 可 以 了 解 它 们 的 含 义 以 及 它 们 上 周 改 变 了 多 少 。";
			}
			else if (this.now_text == 7)
			{
				this.text_this = " 在 指 示 器 下 方 是 切 换 到 其 他 界 面 的 按 钮 ， 让 我 们 从 政 治 界 面 开 始 。";
			}
			else if (this.now_text == 8)
			{
				this.text_this = " 在 这 里 你 可 以 看 到 你 国 家 的 领 导 人 并 替 换 他 们 。";
			}
			else if (this.now_text == 9)
			{
				this.text_this = " 你 也 可 以 在 这 里 看 到 并 修 改 由 领 域 分 组 的 法 律 和 政 策 — — 你 每 个 月 可 以 提 升 或 降 低 一 次 一 个 特 定 领 域 的 自 由 化 程 度 ， 它 们 同 时 也 会 根 据 事 件 上 升 或 下 降 。";
			}
			else if (this.now_text == 10)
			{
				this.text_this = " 这 里 还 有 北 约 威 胁 指 示 器 ， 展 示 北 约 有 多 想 给 你 的 国 家 “ 带 来 民 主 与 和 平 ” ， 就 让 我 们 叫 它 与 美 国 的 关 系 吧 。 直 到 游 戏 结 束 之 前 ， 不 需 要 担 心 入 侵 发 生 ， 所 以 不 要 担 心 。";
			}
			else if (this.now_text == 11)
			{
				this.text_this = " 间 谍 网 络 的 数 量 是 特 勤 强 度 的 一 个 条 件 指 示 器 。 它 们 会 随 着 外 交 行 动 和 事 件 被 消 耗 并 通 过 你 的 建 筑 随 时 间 恢 复 。";
			}
			else if (this.now_text == 12)
			{
				this.text_this = " 现 在 来 讲 经 济 界 面 。";
			}
			else if (this.now_text == 13)
			{
				this.text_this = " 在 这 里 你 可 以 看 见 以 地 区 为 准 分 布 的 已 建 造 建 筑 并 建 造 新 的 建 筑 。 通 过 点 击 “ + ” 图 标 你 可 以 建 造 列 出 的 建 筑 并 且 看 到 它 的 效 果 以 及 花 费 。";
			}
			else if (this.now_text == 14)
			{
				this.text_this = " 所 有 建 筑 都 可 以 拆 除 以 腾 出 空 间 ， 或 是 暂 停 它 们 的 运 作 ， 这 通 常 更 加 有 利 可 图 ， 许 多 建 筑 还 可 以 被 私 有 化 以 赚 取 资 金 ， 但 只 有 在 市 场 经 济 下 或 是 预 算 为 负 时 可 用 。 ";
			}
			else if (this.now_text == 15)
			{
				this.text_this = " 空 位 数 被 地 区 的 等 级 限 制 和 决 定 。 等 级 可 以 提 升 ， 但 要 花 费 资 金 ， 等 级 越 高 花 费 的 资 金 越 多 ， 所 以 有 时 拆 除 一 些 建 筑 会 更 有 用 。";
			}
			else if (this.now_text == 16)
			{
				this.text_this = " 这 是 科 学 界 面 。 在 这 里 你 可 以 选 择 从 三 条 分 支 中 （ 以 及 核 武 器 ） 选 择 研 究 以 及 中 止 进 度 。";
			}
			else if (this.now_text == 17)
			{
				this.text_this = " 每 个 科 技 研 究 的 开 始 花 费 1 资 金 。 你 可 以 同 时 研 究 所 有 四 个 科 技 ， 但 研 究 速 度 会 放 缓 。";
			}
			else if (this.now_text == 18)
			{
				this.text_this = " 研 究 的 速 度 由 发 展 科 技 的 建 筑 数 量 决 定 。 在 研 究 完 全 部 分 支 的 科 技 以 后 ， 你 将 收 到 一 个 可 以 获 利 的 有 关 事 件 。";
			}
			else if (this.now_text == 19)
			{
				this.text_this = " 接 下 来 是 浏 览 界 面";
			}
			else if (this.now_text == 20)
			{
				this.text_this = " 这 里 是 一 些 关 于 你 的 国 家 的 细 节 以 及 它 的 影 响 — 贸 易 伙 伴 的 数 量 ， 进 口 与 出 口 ， 主 权 ， 苏 联 援 助 等 。 （ 也 可 以 在 浏 览 界 面 中 的 按 钮 之 间 切 换 ）";
			}
			else if (this.now_text == 21)
			{
				this.text_this = " 然 而 ， 如 果 你 想 在 阿 富 汗 胜 利 或 看 到 一 个 统 一 的 南 斯 拉 夫 — 它 们 政 府 对 国 家 的 控 制 应 不 小 于100%";
			}
			else if (this.now_text == 22)
			{
				this.text_this = " 最 后 一 个 界 面 — 统 计 数 据";
			}
			else if (this.now_text == 23)
			{
				this.text_this = " 在 这 里 是 关 于 所 选 国 家 在1989-1991 的 史 实 指 标 以 及 你 的 指 标 。 这 个 界 面 不 影 响 游 戏 体 验 ， 但 在 这 里 你 说 不 定 可 以 发 现 你 做 得 比 史 实 更 好 。";
			}
			else if (this.now_text == 24)
			{
				this.text_this = " 好 吧 ， 这 就 是 全 部 了 。 当 然 还 有 一 些 小 差 异 ， 但 你 会 在 游 戏 中 了 解 的 。";
			}
			else if (this.now_text == 25)
			{
				this.text_this = " 向 更 加 光 明 的 未 来 前 进 吧 ， 同 志 ！";
			}
		}
		else
		{
			this.shower.sprite = this.slides_ru[this.now];
			if (this.now_text == 0)
			{
				this.text_this = "Привет, товарищ! Только зашли в игру и не знаете, что делать? Не беда, сейчас я научу вас управлять страной!";
			}
			else if (this.now_text == 1)
			{
				this.text_this = "Это - экран дипломатии, на котором происходит основное действо этой игры. Нажимая на страны вы можете видеть какие дипломатические действия с ними можно выполнять и что для этого нужно";
			}
			else if (this.now_text == 2)
			{
				this.text_this = "В левом верхнем углу показана дата и значки скорости хода игры. \"Остальгия\" - игра в реальном времени, так что для продвижения вам нужно будет нажать на одну из чёрточек под датой, которые и устанавливают скорость. ";
			}
			else if (this.now_text == 3)
			{
				this.text_this = "Нажав на соответствующую кнопку на всё той же панели, вы можете в любой момент поставить игру на паузу, так же это можно сделать, нажав на клавишу Пробел.";
			}
			else if (this.now_text == 4)
			{
				this.text_this = "События будут появляться по ходу времени в игре и будут отображаться вот таким значком. Нажав на него вы перейдте к самому событию и будете решать, как поступить.";
			}
			else if (this.now_text == 5)
			{
				this.text_this = "Игра при этом поставится на паузу и будет на ней стоять, пока вы сами её не снимете. Таким образом необходимости нажимать паузу при наличии нескольких событий нет, можно просто нажать на одно из них.";
			}
			else if (this.now_text == 6)
			{
				this.text_this = "Наверху экрана дипломатии есть численные показатели ситуации в вашей стране, которые меняются каждые 7 дней. Наведя на них курсор, вы узнаете, что они значат и насколько они изменились за последнюю неделю.";
			}
			else if (this.now_text == 7)
			{
				this.text_this = "Под показателями расположены кнопки перехода на другие экраны. Начнём с политики.";
			}
			else if (this.now_text == 8)
			{
				this.text_this = "Здесь вы можете видеть первых лиц вашего государства и менять их.";
			}
			else if (this.now_text == 9)
			{
				this.text_this = "Также здесь можно видеть и менять законы и доктрины вашего государства, сгруппированные в области - можно раз в месяц повышать или понижать либерализацию в определённой области, также она повышается и понижается по событиям.";
			}
			else if (this.now_text == 10)
			{
				this.text_this = "Ещё здесь расположен показатель угрозы НАТО, который отвечает за то, насколько НАТО хочет \"принести демократию и мир\" в вашу страну, можно сказать, это отношения с США. До конца игры вторжение вас не ждёт, так что не беспокойтесь.";
			}
			else if (this.now_text == 11)
			{
				this.text_this = "Количество агентурных сетей - это условный показатель силы ваших спецслужб. Они расходуются для действий в дипломатии и событиях и восстанавливаются со временем в зависимости от ваших построек.";
			}
			else if (this.now_text == 12)
			{
				this.text_this = "Теперь об экономике.";
			}
			else if (this.now_text == 13)
			{
				this.text_this = "Здесь вы можете видеть построенные здания, распределённые по регионам и строить новые. Нажав на значок + вы можете построить одно из предложенных зданий и увидеть, какой эффект оно даст и сколько стоит.";
			}
			else if (this.now_text == 14)
			{
				this.text_this = "Все здания можно снести, чтобы освободить место, или временно приостановить их работу, что обычно выгоднее. Многие здания также можно приватизировать, чтобы получить деньги, но только при рыночной экномике или отрицательном бюджете. ";
			}
			else if (this.now_text == 15)
			{
				this.text_this = "Количество свободных мест для постройки ограничено и определяется уровнем региона. Уровень можно улучшить, но это стоит денег и чем больше уровень, тем выше стоимость, так что иногда может быть полезнее снести уже ненужное здание.";
			}
			else if (this.now_text == 16)
			{
				this.text_this = "Это наука. Здесь вы можете выбирать, какую технологию из трёх ветвей (+ ядерное оружие) изучать и приостанавливать этот процесс.";
			}
			else if (this.now_text == 17)
			{
				this.text_this = "Начало изучения каждой технологии стоит 1 очко денег. Одновременно можно изучать хоть 4 технологии, но скорость изучения в данном случае замедляется.";
			}
			else if (this.now_text == 18)
			{
				this.text_this = "Сама скорость изучения зависит от количества у вас развивающих науку зданий. После полного изучения каждой ветки технологий вы получите связанное с ними событие из которого также может извлечь пользу.";
			}
			else if (this.now_text == 19)
			{
				this.text_this = "Дальше идёт экран обзора";
			}
			else if (this.now_text == 20)
			{
				this.text_this = "Здесь показаны некоторые детали положения вашей страны и их влияние - количество торговых партнёров, импорт и экспорт, суверенитет, советская помощь и т.д. (Также присутствует возможность переключаться между кнопками обзора)";
			}
			else if (this.now_text == 21)
			{
				this.text_this = "Однако, если вы хотите победить в Афганистане или очень сильно желаете видеть единую Югославию - контроль их правительства над страной должен быть 100% и никак не менее.";
			}
			else if (this.now_text == 22)
			{
				this.text_this = "Последний экран - статистика.";
			}
			else if (this.now_text == 23)
			{
				this.text_this = "Здесь показаны реальные показатели выбранной страны за каждый месяц 1989-1991 годов и ваши показатели. Какого-либо влияния этот экран на игровой процесс не оказывает, но тут вы можете узнать, сделали ли вы лучше, чем было в реальной истории.";
			}
			else if (this.now_text == 24)
			{
				this.text_this = "Ну и на этом всё. Разумеется, есть ещё несколько мелких нюансов, но с ними вы сможете теперь сами освоиться в процессе игры.";
			}
			else if (this.now_text == 25)
			{
				this.text_this = "Вперёд к светлому будущему, товарищ!";
			}
		}
		this.text.text = this.Text(this.text_this, 30);
		if (this.now_text == 0)
		{
			this.right.GetComponent<TutorialButtonScript>().Show(true);
			this.left.GetComponent<TutorialButtonScript>().Show(false);
			return;
		}
		if (this.now_text == 25)
		{
			this.right.GetComponent<TutorialButtonScript>().Show(false);
			this.left.GetComponent<TutorialButtonScript>().Show(true);
			return;
		}
		this.right.GetComponent<TutorialButtonScript>().Show(true);
		this.left.GetComponent<TutorialButtonScript>().Show(true);
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00003CE0 File Offset: 0x00001EE0
	public void OnDown(bool isleft)
	{
		if (isleft)
		{
			this.now--;
			this.now_text--;
		}
		else
		{
			if (this.now_text == 0 || this.now_text == 3 || this.now_text == 4 || this.now_text == 5 || this.now_text == 7 || this.now_text == 12 || this.now_text == 15 || this.now_text == 19 || this.now_text == 22)
			{
				this.now++;
			}
			this.now_text++;
		}
		this.Repaint();
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002124 File Offset: 0x00000324
	private void Awake()
	{
		this.Repaint();
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00003D84 File Offset: 0x00001F84
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

	// Token: 0x04000006 RID: 6
	public GameObject left;

	// Token: 0x04000007 RID: 7
	public GameObject right;

	// Token: 0x04000008 RID: 8
	public int now;

	// Token: 0x04000009 RID: 9
	public int now_text;

	// Token: 0x0400000A RID: 10
	public TextMesh text;

	// Token: 0x0400000B RID: 11
	private string text_this;

	// Token: 0x0400000C RID: 12
	public Sprite[] slides_en;

	// Token: 0x0400000D RID: 13
	public Sprite[] slides_ru;

	// Token: 0x0400000E RID: 14
	public SpriteRenderer shower;
}
