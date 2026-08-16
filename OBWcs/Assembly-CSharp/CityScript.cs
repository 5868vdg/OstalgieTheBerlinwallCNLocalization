using System;
using UnityEngine;

// Token: 0x0200000D RID: 13
public class CityScript : MonoBehaviour
{
	// Token: 0x0600003A RID: 58 RVA: 0x00002320 File Offset: 0x00000520
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
	}

	// Token: 0x0600003B RID: 59 RVA: 0x0000C7DC File Offset: 0x0000A9DC
	public void Repaint()
	{
		this.text.text = this.global1.regions[this.buildmanager1.now_region].city_level.ToString();
		if (this.global1.regions[this.buildmanager1.now_region].city_level <= 4 && this.global1.data[58] != this.buildmanager1.now_region)
		{
			base.GetComponent<OkoshkoScript>().text = "-" + (this.global1.regions[this.buildmanager1.now_region].city_level * 2 + 2).ToString() + " из бюджета";
			base.GetComponent<OkoshkoScript>().text_en = "-" + (this.global1.regions[this.buildmanager1.now_region].city_level * 2 + 2).ToString() + " 预 算";
			return;
		}
		if (this.global1.regions[this.buildmanager1.now_region].city_level < 2 && this.global1.data[58] == this.buildmanager1.now_region)
		{
			base.GetComponent<OkoshkoScript>().text = "-" + (this.global1.regions[this.buildmanager1.now_region].city_level * 2 + 2).ToString() + " из бюджета";
			base.GetComponent<OkoshkoScript>().text_en = "-" + (this.global1.regions[this.buildmanager1.now_region].city_level * 2 + 2).ToString() + " 预 算";
			return;
		}
		if (this.global1.data[58] == this.buildmanager1.now_region)
		{
			base.GetComponent<OkoshkoScript>().text = "Здесь есть автономия";
			base.GetComponent<OkoshkoScript>().text_en = " 有 自 主 权";
			return;
		}
		base.GetComponent<OkoshkoScript>().text = "Невозможно";
		base.GetComponent<OkoshkoScript>().text_en = " 不 可 能";
	}

	// Token: 0x0600003C RID: 60 RVA: 0x0000C9FC File Offset: 0x0000ABFC
	private void OnMouseDown()
	{
		if (this.global1.data[8] >= (this.global1.regions[this.buildmanager1.now_region].city_level * 2 + 2) * 10 && ((this.global1.regions[this.buildmanager1.now_region].city_level <= 4 && this.global1.data[58] != this.buildmanager1.now_region) || (this.global1.regions[this.buildmanager1.now_region].city_level < 2 && this.global1.data[58] == this.buildmanager1.now_region)))
		{
			this.global1.data[1] += this.global1.regions[this.buildmanager1.now_region].city_level * 5;
			this.global1.data[4] -= this.global1.regions[this.buildmanager1.now_region].city_level * 5;
			this.global1.data[5] += this.global1.regions[this.buildmanager1.now_region].city_level * 5;
			this.global1.data[8] -= (this.global1.regions[this.buildmanager1.now_region].city_level * 2 + 2) * 10;
			this.global1.regions[this.buildmanager1.now_region].city_level++;
			if (this.global1.regions[this.buildmanager1.now_region].city_level <= 4 && this.global1.data[58] != this.buildmanager1.now_region)
			{
				base.GetComponent<OkoshkoScript>().text = "-" + (this.global1.regions[this.buildmanager1.now_region].city_level * 2 + 2).ToString() + " из бюджета";
				base.GetComponent<OkoshkoScript>().text_en = "-" + (this.global1.regions[this.buildmanager1.now_region].city_level * 2 + 2).ToString() + " from the budget";
			}
			else if (this.global1.regions[this.buildmanager1.now_region].city_level < 2 && this.global1.data[58] == this.buildmanager1.now_region)
			{
				base.GetComponent<OkoshkoScript>().text = "Здесь есть автономия";
				base.GetComponent<OkoshkoScript>().text_en = " 有 自 主 权";
			}
			else
			{
				base.GetComponent<OkoshkoScript>().text = "Невозможно";
				base.GetComponent<OkoshkoScript>().text_en = " 不 可 能";
			}
		}
		this.bl1.Repaint();
		this.Repaint();
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002337 File Offset: 0x00000537
	private void OnMouseEnter()
	{
		if (this.global1.regions[this.buildmanager1.now_region].city_level <= 4)
		{
			base.GetComponent<SpriteRenderer>().sprite = this.on;
		}
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002369 File Offset: 0x00000569
	private void OnMouseExit()
	{
		base.GetComponent<SpriteRenderer>().sprite = this.off;
	}

	// Token: 0x0400004E RID: 78
	private GlobalScript global1;

	// Token: 0x0400004F RID: 79
	public BuildingManager buildmanager1;

	// Token: 0x04000050 RID: 80
	public TextMesh text;

	// Token: 0x04000051 RID: 81
	public Sprite on;

	// Token: 0x04000052 RID: 82
	public Sprite off;

	// Token: 0x04000053 RID: 83
	public BuildingManager bl1;
}
