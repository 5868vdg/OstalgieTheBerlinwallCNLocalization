using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000015 RID: 21
public class ElectScript : MonoBehaviour
{
	// Token: 0x0600005C RID: 92 RVA: 0x0002BD78 File Offset: 0x00029F78
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.Repaint();
		if (PlayerPrefs.GetInt("language") == 0)
		{
			this.texts[0].text = " 政 治 体 制";
			this.texts[1].text = " 党 派";
			this.texts[2].text = " 党 内 路 线";
			this.texts[3].text = " 经 济 类 型";
			this.texts[4].text = " 自 由";
			this.texts[5].text = " 选 举";
			this.texts[6].text = " 领 导";
			this.texts[7].text = " 部 长 会 议";
			this.texts[8].text = " 意 识 形 态";
			this.texts[9].text = " 外 交";
			this.texts[10].text = " 科 学";
			this.texts[11].text = " 经 济";
			this.texts[12].text = " 同 盟";
			this.texts[13].text = " 允 许";
			this.texts[15].text = " 演 讲";
		}
		this.texts[14].text = (this.global1.data[33] / 10).ToString() + "." + Mathf.Abs(this.global1.data[33] % 10).ToString();
		this.texts[16].text = this.global1.data[14].ToString();
	}

	// Token: 0x0600005D RID: 93 RVA: 0x0002BF38 File Offset: 0x0002A138
	private void OnMouseDown()
	{
		if (!this.global1.is_elect && this.global1.data[15] > 6)
		{
			this.global1.is_elect = true;
			this.Repaint();
			this.global1.event_done[2] = true;
			this.global1.data[8] -= 10;
			this.global1.number_event = 2;
			SceneManager.LoadScene("Event");
		}
	}

	// Token: 0x0600005E RID: 94 RVA: 0x000024BA File Offset: 0x000006BA
	private void OnMouseEnter()
	{
		base.GetComponent<SpriteRenderer>().sprite = this.on;
	}

	// Token: 0x0600005F RID: 95 RVA: 0x000024CD File Offset: 0x000006CD
	private void OnMouseExit()
	{
		if (!this.global1.is_elect)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.off;
		}
	}

	// Token: 0x06000060 RID: 96 RVA: 0x000024ED File Offset: 0x000006ED
	private void Repaint()
	{
		if (this.global1.is_elect)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.on;
			return;
		}
		base.GetComponent<SpriteRenderer>().sprite = this.off;
	}

	// Token: 0x0400008B RID: 139
	private GlobalScript global1;

	// Token: 0x0400008C RID: 140
	public Sprite on;

	// Token: 0x0400008D RID: 141
	public Sprite off;

	// Token: 0x0400008E RID: 142
	public TextMesh[] texts = new TextMesh[16];

	// Token: 0x0400008F RID: 143
	public Sprite[] politics = new Sprite[60];
}
