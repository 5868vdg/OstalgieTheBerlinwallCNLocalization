using System;
using UnityEngine;

// Token: 0x0200003D RID: 61
public class ThisPostNamePolitics : MonoBehaviour
{
	// Token: 0x06000109 RID: 265 RVA: 0x00002CF2 File Offset: 0x00000EF2
	private void Start()
	{
		this.UpdateTexts();
	}

	// Token: 0x0600010A RID: 266 RVA: 0x00002CFA File Offset: 0x00000EFA
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
	}

	// Token: 0x0600010B RID: 267 RVA: 0x0015ACB4 File Offset: 0x00158EB4
	private void UpdateTexts()
	{
		if ((this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51) && this.global1.data[114] != 100)
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				this.leaderTextMesh.fontSize = 15;
				this.leaderTextMesh.text = " 主 席 团 主 席";
				this.predsovmTextMesh.fontSize = 15;
				this.predsovmTextMesh.text = " 共 和 国 事 务 部 长";
				this.secTextMesh.fontSize = 17;
				this.secTextMesh.text = " 外 贸 部 长";
				return;
			}
			this.leaderTextMesh.fontSize = 16;
			this.leaderTextMesh.text = "Председатель\nПрезидиума";
			this.predsovmTextMesh.fontSize = 17;
			this.predsovmTextMesh.text = "Секретарь по\nресп. вопросам";
			this.secTextMesh.fontSize = 16;
			this.secTextMesh.text = "Секретарь по\nвнешней торговле";
			return;
		}
		else if (this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51)
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				this.leaderTextMesh.text = " 总 统";
				this.predsovmTextMesh.fontSize = 16;
				this.predsovmTextMesh.text = " 国 内 政 策 专 家";
				this.secTextMesh.text = " 发 言 人";
				return;
			}
			this.leaderTextMesh.text = "ПРЕЗИДЕНТ";
			this.predsovmTextMesh.fontSize = 15;
			this.predsovmTextMesh.text = "Эксперт по\nвнутренней политике";
			this.secTextMesh.fontSize = 17;
			this.secTextMesh.text = "Пресс-секретарь";
			return;
		}
		else
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				this.leaderTextMesh.text = " 领 袖";
				this.predsovmTextMesh.text = " 部 长 会 议";
				this.secTextMesh.text = " 意 识 形 态";
				return;
			}
			this.leaderTextMesh.text = "ЛИДЕР";
			this.predsovmTextMesh.text = "ПРЕДСОВМИНА";
			this.secTextMesh.text = "II СЕКРЕТАРЬ";
			return;
		}
	}

	// Token: 0x0400019F RID: 415
	public TextMesh leaderTextMesh;

	// Token: 0x040001A0 RID: 416
	public TextMesh predsovmTextMesh;

	// Token: 0x040001A1 RID: 417
	public TextMesh secTextMesh;

	// Token: 0x040001A2 RID: 418
	private GlobalScript global1;
}
