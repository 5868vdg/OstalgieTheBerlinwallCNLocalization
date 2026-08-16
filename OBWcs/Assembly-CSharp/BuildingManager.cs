using System;
using UnityEngine;

// Token: 0x02000007 RID: 7
public class BuildingManager : MonoBehaviour
{
	// Token: 0x0600001A RID: 26 RVA: 0x000021C3 File Offset: 0x000003C3
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000021DA File Offset: 0x000003DA
	private void Start()
	{
		this.Repaint();
		this.HideSelects();
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00007910 File Offset: 0x00005B10
	public void Repaint()
	{
		for (int i = 0; i < this.buildings.Length; i++)
		{
			this.buildings[i].Repaint();
		}
		this.city.Repaint();
		for (int j = 0; j < this.region_buttons.Length; j++)
		{
			this.region_buttons[j].Repaint();
		}
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00007968 File Offset: 0x00005B68
	public void ShowSelects()
	{
		for (int i = 0; i < this.selects.Length; i++)
		{
			if ((this.global1.data[0] == 10 || this.global1.data[0] == 12 || this.global1.data[0] == 18) && ((!this.global1.science[3] && i == 1) || (!this.global1.science[5] && (i == 2 || i == 7)) || (!this.global1.science[6] && i == 0)))
			{
				this.selects[i].transform.gameObject.SetActive(false);
			}
			else if (this.global1.data[14] > 3 && i == 17)
			{
				this.selects[i].transform.gameObject.SetActive(false);
			}
			else
			{
				this.selects[i].transform.gameObject.SetActive(true);
				this.selects[i].Repaint();
			}
		}
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00007A6C File Offset: 0x00005C6C
	public void HideSelects()
	{
		for (int i = 0; i < this.selects.Length; i++)
		{
			this.selects[i].transform.gameObject.SetActive(false);
		}
	}

	// Token: 0x0400001B RID: 27
	public Sprite[] resprite_on;

	// Token: 0x0400001C RID: 28
	public Sprite[] respriteoff;

	// Token: 0x0400001D RID: 29
	public string[] types_names_ru;

	// Token: 0x0400001E RID: 30
	public string[] types_names_en;

	// Token: 0x0400001F RID: 31
	public string[] usloviya_ru = new string[18];

	// Token: 0x04000020 RID: 32
	public string[] usloviya_en = new string[18];

	// Token: 0x04000021 RID: 33
	public CityScript city;

	// Token: 0x04000022 RID: 34
	public int selected_thing = -1;

	// Token: 0x04000023 RID: 35
	public BuildSelectScript[] selects;

	// Token: 0x04000024 RID: 36
	public Sprite[] sprites = new Sprite[18];

	// Token: 0x04000025 RID: 37
	public BuildingScript[] buildings;

	// Token: 0x04000026 RID: 38
	public int now_region = 2;

	// Token: 0x04000027 RID: 39
	private GlobalScript global1;

	// Token: 0x04000028 RID: 40
	public Sprite empty_build;

	// Token: 0x04000029 RID: 41
	public int[] yugreg = new int[3];

	// Token: 0x0400002A RID: 42
	public bool[] yugown = new bool[3];

	// Token: 0x0400002B RID: 43
	public RegionChangeScript[] region_buttons = new RegionChangeScript[5];
}
