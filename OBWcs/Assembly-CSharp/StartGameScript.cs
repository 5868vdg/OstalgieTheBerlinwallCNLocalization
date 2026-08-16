using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000039 RID: 57
public class StartGameScript : MonoBehaviour
{
	// Token: 0x060000FF RID: 255 RVA: 0x00002C85 File Offset: 0x00000E85
	private void Start()
	{
		SceneManager.LoadScene("Main");
	}
}
