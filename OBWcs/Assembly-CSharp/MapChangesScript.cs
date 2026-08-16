using System;
using UnityEngine;

// Token: 0x02000023 RID: 35
public class MapChangesScript : MonoBehaviour
{
	// Token: 0x06000099 RID: 153 RVA: 0x0003412C File Offset: 0x0003232C
	public void EventWrite()
	{
		for (int i = 0; i < this.events.Length; i++)
		{
			if (this.events[i] != null && this.global1.Events_active[i])
			{
				this.events[i].SetActive(true);
				this.events[i].GetComponent<EventScript>().Reset(this.global1.Events_number[i], this.global1.Events_time[i]);
				this.global1.Events_active[i] = false;
			}
		}
	}

	// Token: 0x0600009A RID: 154 RVA: 0x000341B4 File Offset: 0x000323B4
	public void EventRead()
	{
		for (int i = 0; i < this.events.Length; i++)
		{
			if (this.events[i] != null)
			{
				if (this.events[i].activeSelf)
				{
					this.global1.Events_time[i] = this.events[i].GetComponent<EventScript>().time;
					this.global1.Events_number[i] = this.events[i].GetComponent<EventScript>().this_event;
				}
				this.global1.Events_active[i] = this.events[i].activeSelf;
			}
		}
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00034250 File Offset: 0x00032450
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.flagok.sprite = this.flagoks[this.global1.data[0] - 1];
		this.UpdateMap();
		this.EventWrite();
	}

	// Token: 0x0600009C RID: 156 RVA: 0x000342A0 File Offset: 0x000324A0
	public void ShowHideOcno(bool active)
	{
		if (active)
		{
			if (!this.okno.active)
			{
				this.save_speed = this.global1.speed;
			}
			this.global1.speed = 0;
			this.okno.transform.Find("TextIf (0)").GetComponent<TextMesh>().text = null;
			this.okno.transform.Find("TextIf (1)").GetComponent<TextMesh>().text = null;
			this.okno.transform.Find("TextIf (2)").GetComponent<TextMesh>().text = null;
			this.okno.transform.Find("TextIf (3)").GetComponent<TextMesh>().text = null;
			this.okno.transform.Find("TextIf (0)").transform.Find("If").GetComponent<SpriteRenderer>().sprite = null;
			this.okno.transform.Find("TextIf (1)").transform.Find("If").GetComponent<SpriteRenderer>().sprite = null;
			this.okno.transform.Find("TextIf (2)").transform.Find("If").GetComponent<SpriteRenderer>().sprite = null;
			this.okno.transform.Find("TextIf (3)").transform.Find("If").GetComponent<SpriteRenderer>().sprite = null;
			this.okno.transform.Find("Text (1)").GetComponent<TextMesh>().text = null;
		}
		else
		{
			this.global1.speed = this.save_speed;
		}
		for (int i = 0; i < 4; i++)
		{
			this.speed[i].GetComponent<SpeedScript>().Repaint();
		}
		this.okno.SetActive(active);
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00034478 File Offset: 0x00032678
	public void UpdateMap()
	{
		if (this.global1.allcountries[7].Vyshi)
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				this.global1.allcountries[7].name = " 前 联 盟 地 区";
			}
			else
			{
				this.global1.allcountries[7].name = "Бывший Союз";
			}
		}
		if (this.global1.allcountries[1].Vyshi && this.global1.allcountries[1].Gosstroy == 2 && this.global1.data[0] != 1)
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				this.global1.allcountries[1].name = " 联 邦 德 国";
			}
			else
			{
				this.global1.allcountries[1].name = "ФРГ";
			}
		}
		if ((this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51) && this.global1.data[149] == 3)
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				this.global1.allcountries[4].name = " 大 伏 伊 伏 丁 那";
			}
			else
			{
				this.global1.allcountries[4].name = "Большая\nВоеводина";
			}
		}
		if ((this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51) && this.global1.data[177] == 3)
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				this.global1.allcountries[20].name = " 南 斯 拉 夫 属\n 阿 尔 巴 尼 亚";
			}
			else
			{
				this.global1.allcountries[20].name = "Югославская\nАлбания";
			}
		}
		if ((this.global1.data[0] == 49 || this.global1.data[0] == 50 || this.global1.data[0] == 51) && this.global1.data[235] == 9)
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				this.global1.allcountries[6].name = "Yugoslav\nBulgaria";
			}
			else
			{
				this.global1.allcountries[6].name = " 南 斯 拉 夫 属\n 保 加 利 亚";
			}
		}
		for (int i = 0; i < this.cont.Length; i++)
		{
			if (this.cont[i] != null)
			{
				this.cont[i].Repaint();
			}
		}
	}

	// Token: 0x0400011A RID: 282
	private int save_speed;

	// Token: 0x0400011B RID: 283
	public GameObject[] speed = new GameObject[4];

	// Token: 0x0400011C RID: 284
	public GameObject[] buttons = new GameObject[4];

	// Token: 0x0400011D RID: 285
	public GameObject[] event_icons = new GameObject[27];

	// Token: 0x0400011E RID: 286
	public Sprite[] znachki = new Sprite[11];

	// Token: 0x0400011F RID: 287
	public Sprite[] subIdZ = new Sprite[16];

	// Token: 0x04000120 RID: 288
	public GameObject okno;

	// Token: 0x04000121 RID: 289
	public SpriteRenderer flagok;

	// Token: 0x04000122 RID: 290
	public Sprite[] flagoks = new Sprite[6];

	// Token: 0x04000123 RID: 291
	private GlobalScript global1;

	// Token: 0x04000124 RID: 292
	public CountryScript[] cont = new CountryScript[56];

	// Token: 0x04000125 RID: 293
	public GameObject[] events = new GameObject[27];
}
