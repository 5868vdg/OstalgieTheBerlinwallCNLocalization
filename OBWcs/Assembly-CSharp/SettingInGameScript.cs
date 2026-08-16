using System;
using UnityEngine;

// Token: 0x02000036 RID: 54
public class SettingInGameScript : MonoBehaviour
{
	// Token: 0x060000F2 RID: 242 RVA: 0x00002C2A File Offset: 0x00000E2A
	private void Awake()
	{
		this.global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		if (!this.global1.turn_on)
		{
			this.Exit.GetComponent<LoadScript>().new_scene = "Diplomacy";
		}
	}

	// Token: 0x04000183 RID: 387
	private GlobalScript global1;

	// Token: 0x04000184 RID: 388
	public GameObject Exit;
}
