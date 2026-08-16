using System;
using UnityEngine;

// Token: 0x02000057 RID: 87
public class leading_script : MonoBehaviour
{
	// Token: 0x060001AA RID: 426 RVA: 0x00003310 File Offset: 0x00001510
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
	}

	// Token: 0x060001AB RID: 427 RVA: 0x00003327 File Offset: 0x00001527
	private void Start()
	{
		this.Cam = GameObject.Find("Main Camera").GetComponent<Camera>();
	}

	// Token: 0x060001AC RID: 428 RVA: 0x001F0F48 File Offset: 0x001EF148
	private void OnMouseEnter()
	{
		if (this.Cam == null)
		{
			this.Cam = GameObject.Find("Main Camera").GetComponent<Camera>();
		}
		this.pidor = global::UnityEngine.Object.Instantiate<GameObject>(this.okno, new Vector3(this.Cam.ScreenToWorldPoint(Input.mousePosition).x, this.Cam.ScreenToWorldPoint(Input.mousePosition).y, -9.6f), new Quaternion(0f, 0f, 0f, 0f));
		if (PlayerPrefs.GetInt("language") == 0)
		{
			this.pidor.transform.Find("Text").GetComponent<TextMesh>().text = " 修 宪 多 数: \n";
			if (this.global1.is_konst_max)
			{
				TextMesh component = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
				component.text += "<color=red> 是</color>";
			}
			else
			{
				TextMesh component2 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
				component2.text += "<color=yellow> 否</color>";
			}
			TextMesh component3 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
			component3.text += "\n 执 政: ";
			if (this.global1.data[41] == 0)
			{
				TextMesh component4 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
				component4.text += " 我 们 的 联 盟\n";
			}
			else if (this.global1.data[41] == 1)
			{
				TextMesh component5 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
				component5.text += " 左 翼 联 盟\n";
			}
			else if (this.global1.data[41] == 2)
			{
				TextMesh component6 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
				component6.text += " 中 间 派 联 盟\n";
			}
			else if (this.global1.data[41] == 3)
			{
				TextMesh component7 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
				component7.text += " 右 翼 联 盟\n";
			}
			else if (this.global1.data[41] == 4)
			{
				TextMesh component8 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
				component8.text += " 激 进 派 联 盟\n";
			}
			for (int i = 0; i < this.global1.is_party_enabled.Length; i++)
			{
				if (this.global1.is_party_enabled[i])
				{
					if (i == 3)
					{
						TextMesh component9 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
						component9.text += "\n";
					}
					TextMesh component10 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
					component10.text = component10.text + this.global1.party_name[i] + ": ";
					TextMesh component11 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
					component11.text = component11.text + "<color=yellow>" + this.global1.party_number[i].ToString() + "; </color>";
				}
			}
			return;
		}
		this.pidor.transform.Find("Text").GetComponent<TextMesh>().text = "Конституционное большинство: \n";
		if (this.global1.is_konst_max)
		{
			TextMesh component12 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
			component12.text += "<color=red>Да</color>";
		}
		else
		{
			TextMesh component13 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
			component13.text += "<color=yellow>Нет</color>";
		}
		TextMesh component14 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
		component14.text += "\nЛидирует: ";
		if (this.global1.data[41] == 0)
		{
			TextMesh component15 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
			component15.text += "Наш союз\n";
		}
		else if (this.global1.data[41] == 1)
		{
			TextMesh component16 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
			component16.text += "Союз левых\n";
		}
		else if (this.global1.data[41] == 2)
		{
			TextMesh component17 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
			component17.text += "Союз центристов\n";
		}
		else if (this.global1.data[41] == 3)
		{
			TextMesh component18 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
			component18.text += "Союз правых\n";
		}
		else if (this.global1.data[41] == 4)
		{
			TextMesh component19 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
			component19.text += "Союз радикалов\n";
		}
		for (int j = 0; j < this.global1.is_party_enabled.Length; j++)
		{
			if (this.global1.is_party_enabled[j])
			{
				if (j == 3)
				{
					TextMesh component20 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
					component20.text += "\n";
				}
				TextMesh component21 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
				component21.text = component21.text + this.global1.party_name[j] + ": ";
				TextMesh component22 = this.pidor.transform.Find("Text").GetComponent<TextMesh>();
				component22.text = component22.text + "<color=yellow>" + this.global1.party_number[j].ToString() + "; </color>";
			}
		}
	}

	// Token: 0x060001AD RID: 429 RVA: 0x0000333E File Offset: 0x0000153E
	private void OnMouseExit()
	{
		global::UnityEngine.Object.Destroy(this.pidor);
	}

	// Token: 0x04000272 RID: 626
	private GlobalScript global1;

	// Token: 0x04000273 RID: 627
	private GameObject pidor;

	// Token: 0x04000274 RID: 628
	public GameObject okno;

	// Token: 0x04000275 RID: 629
	public Camera Cam;
}
