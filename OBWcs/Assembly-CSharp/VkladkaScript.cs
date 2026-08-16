using System;
using UnityEngine;

// Token: 0x02000043 RID: 67
public class VkladkaScript : MonoBehaviour
{
	// Token: 0x06000132 RID: 306 RVA: 0x00002F1D File Offset: 0x0000111D
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		this.elect1 = GameObject.Find("KrasnayaNEnazhataya 6").GetComponent<ElectScript>();
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00191F40 File Offset: 0x00190140
	private void OnMouseDown()
	{
		if (!this.is_showed)
		{
			this.vkladka.SetActive(true);
			this.is_showed = true;
			for (int i = 1; i < 4; i++)
			{
				Transform transform = this.vkladka.transform.Find("Min" + i.ToString());
				transform.transform.Find("Button").GetComponent<Politic_set_script>().dolshnost = this.dolshnost;
				transform.transform.Find("Button").GetComponent<Politic_set_script>().candidat = this.candidats[i - 1];
				if (this.global1.data[0] < 49 || this.global1.data[0] > 51)
				{
					transform.transform.Find("Pol").GetComponent<SpriteRenderer>().sprite = this.elect1.politics[(this.global1.data[0] - 1) * 10 + this.candidats[i - 1]];
				}
				else if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51 && this.global1.data[114] == 100)
				{
					transform.transform.Find("Pol").GetComponent<SpriteRenderer>().sprite = this.elect1.politics[this.global1.data[0] * 10 + this.candidats[i - 1]];
				}
				else if (this.global1.data[0] >= 49 && this.global1.data[0] <= 51 && this.global1.data[114] != 100)
				{
					transform.transform.Find("Pol").GetComponent<SpriteRenderer>().sprite = this.elect1.politics[150 + this.candidats[i - 1]];
				}
				transform.transform.Find("Text").GetComponent<TextMesh>().text = this.global1.politics_name[this.candidats[i - 1]];
				transform.transform.Find("Text1").GetComponent<TextMesh>().text = this.global1.politics_charact[this.candidats[i - 1]];
				transform.transform.Find("Text2").GetComponent<TextMesh>().text = this.global1.politics_opis[this.candidats[i - 1]];
			}
			return;
		}
		this.vkladka.SetActive(false);
		this.is_showed = false;
	}

	// Token: 0x040001D4 RID: 468
	public GameObject vkladka;

	// Token: 0x040001D5 RID: 469
	public bool is_showed;

	// Token: 0x040001D6 RID: 470
	public GameObject other;

	// Token: 0x040001D7 RID: 471
	public int dolshnost;

	// Token: 0x040001D8 RID: 472
	public int[] candidats = new int[3];

	// Token: 0x040001D9 RID: 473
	private GlobalScript global1;

	// Token: 0x040001DA RID: 474
	private ElectScript elect1;
}
