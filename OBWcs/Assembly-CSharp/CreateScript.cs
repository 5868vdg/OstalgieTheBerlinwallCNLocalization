using System;
using UnityEngine;

// Token: 0x02000010 RID: 16
public class CreateScript : MonoBehaviour
{
	// Token: 0x0600004B RID: 75 RVA: 0x00013B24 File Offset: 0x00011D24
	private void Awake()
	{
		if (GameObject.Find("Global(Clone)") == null)
		{
			global::UnityEngine.Object.Instantiate<GameObject>(this.un);
			global::UnityEngine.Object.DontDestroyOnLoad(GameObject.Find("Global(Clone)"));
		}
		if (GameObject.Find("Ach(Clone)") == null)
		{
			global::UnityEngine.Object.Instantiate<GameObject>(this.ach);
			global::UnityEngine.Object.DontDestroyOnLoad(GameObject.Find("Ach(Clone)"));
		}
	}

	// Token: 0x04000070 RID: 112
	public GameObject un;

	// Token: 0x04000071 RID: 113
	public GameObject ach;
}
