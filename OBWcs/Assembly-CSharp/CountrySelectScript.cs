using System;
using UnityEngine;

// Token: 0x0200000F RID: 15
public class CountrySelectScript : MonoBehaviour
{
	// Token: 0x06000046 RID: 70 RVA: 0x000135DC File Offset: 0x000117DC
	private void Awake()
	{
		this.kometa_int = PlayerPrefs.GetInt("kometa");
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		if (this.kometa_int >= 12)
		{
			this.achieves = GameObject.Find("Ach(Clone)");
		}
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00013628 File Offset: 0x00011828
	private void OnMouseDown()
	{
		base.GetComponent<SpriteRenderer>().material.SetFloat("_F", 0.571f);
		if (this.number == 999)
		{
			if (!this.plash1.activeSelf)
			{
				this.plash1.SetActive(true);
				return;
			}
			this.plash1.SetActive(false);
			return;
		}
		else
		{
			this.flag.sprite = this.my_flag;
			this.znachki_okno[0].nonono = false;
			this.znachki_okno[1].nonono = false;
			this.znachki_okno[2].nonono = false;
			if (this.number == 18)
			{
				this.znachki_okno[0].nonono = true;
				this.znachki_okno[1].nonono = false;
				if (PlayerPrefs.GetInt("language") == 0)
				{
					this.znachki_okno[1].text_en = " 经 互 会";
				}
				else
				{
					this.znachki_okno[1].text = "СЭВ";
				}
				this.znachki[0].sprite = null;
				this.znachki[1].sprite = this.sev;
			}
			else if (this.number >= 49 && this.number <= 51)
			{
				this.znachki_okno[0].nonono = true;
				this.znachki_okno[1].nonono = true;
				this.znachki[0].sprite = null;
				this.znachki[1].sprite = null;
			}
			else if (this.number != 20 && this.number != 18 && this.number != 12 && this.number != 10 && this.number != 38)
			{
				this.znachki_okno[0].nonono = false;
				this.znachki_okno[1].nonono = false;
				if (PlayerPrefs.GetInt("language") == 0)
				{
					this.znachki_okno[0].text_en = " 华 沙 条 约";
					this.znachki_okno[1].text_en = " 经 互 会";
				}
				else
				{
					this.znachki_okno[0].text = "Варшавский договор";
					this.znachki_okno[1].text = "СЭВ";
				}
				this.znachki[0].sprite = this.ovd;
				this.znachki[1].sprite = this.sev;
			}
			else
			{
				this.znachki_okno[0].nonono = true;
				this.znachki_okno[1].nonono = true;
				this.znachki[0].sprite = null;
				this.znachki[1].sprite = null;
			}
			if (this.number == 4)
			{
				this.znachki[2].sprite = this.socdem;
				this.znachki_okno[2].text = "Реформиcтский";
				this.znachki_okno[2].text_en = " 改 良 主 义";
			}
			else if (this.number == 5 || this.number == 12 || this.number == 38)
			{
				this.znachki[2].sprite = this.totalitarin;
				this.znachki_okno[2].text = "Авторитаризм";
				this.znachki_okno[2].text_en = " 威 权 主 义";
			}
			else if (this.number >= 49 && this.number <= 51)
			{
				this.znachki[2].sprite = this.socdem;
				this.znachki_okno[2].text = "Реформиcтский";
				this.znachki_okno[2].text_en = " 改 良 主 义";
			}
			else
			{
				this.znachki[2].sprite = this.conserv;
				this.znachki_okno[2].text = "Консервативный";
				this.znachki_okno[2].text_en = " 保 守 主 义";
			}
			if (this.kometa_int >= 12)
			{
				this.znachki[1].sprite = null;
				this.achieves.GetComponent<achievements>().Set(47);
				this.znachki_okno[0].text_en = " 罗 马 治 下 的 和 平";
				this.znachki_okno[1].text_en = "";
				this.znachki_okno[0].text = "Pax Romana";
				if (this.achieves.GetComponent<achievements>().ach_this[47])
				{
					this.znachki_okno[1].text = "ACH_47";
				}
				this.znachki_okno[2].text = "Коммунизм";
				this.znachki_okno[2].text_en = " 共 产 主 义";
				PlayerPrefs.SetInt("kometa", 0);
				return;
			}
			this.game1.number = this.number;
			for (int i = 0; i < this.other_countries.Length; i++)
			{
				this.other_countries[i].GetComponent<SpriteRenderer>().material.SetFloat("_F", 0f);
			}
			return;
		}
	}

	// Token: 0x06000048 RID: 72 RVA: 0x000023A8 File Offset: 0x000005A8
	private void OnMouseEnter()
	{
		base.GetComponent<SpriteRenderer>().material.SetFloat("_F", 0.571f);
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00013AC4 File Offset: 0x00011CC4
	private void OnMouseExit()
	{
		if (this.kometa_int >= 12)
		{
			base.GetComponent<SpriteRenderer>().material.SetFloat("_F", 0f);
			return;
		}
		if (this.game1.number != this.number)
		{
			base.GetComponent<SpriteRenderer>().material.SetFloat("_F", 0f);
		}
	}

	// Token: 0x0400005F RID: 95
	public int number = -1;

	// Token: 0x04000060 RID: 96
	public SpriteRenderer[] znachki = new SpriteRenderer[3];

	// Token: 0x04000061 RID: 97
	public OkoshkoScript[] znachki_okno = new OkoshkoScript[3];

	// Token: 0x04000062 RID: 98
	public SpriteRenderer flag;

	// Token: 0x04000063 RID: 99
	public Sprite my_flag;

	// Token: 0x04000064 RID: 100
	private int kometa_int;

	// Token: 0x04000065 RID: 101
	private GlobalScript global1;

	// Token: 0x04000066 RID: 102
	public GameObject achieves;

	// Token: 0x04000067 RID: 103
	public GameObject plash1;

	// Token: 0x04000068 RID: 104
	public GameStartScript game1;

	// Token: 0x04000069 RID: 105
	public Sprite ovd;

	// Token: 0x0400006A RID: 106
	public Sprite sev;

	// Token: 0x0400006B RID: 107
	public Sprite conserv;

	// Token: 0x0400006C RID: 108
	public Sprite liberal;

	// Token: 0x0400006D RID: 109
	public Sprite socdem;

	// Token: 0x0400006E RID: 110
	public Sprite totalitarin;

	// Token: 0x0400006F RID: 111
	public GameObject[] other_countries = new GameObject[6];
}
