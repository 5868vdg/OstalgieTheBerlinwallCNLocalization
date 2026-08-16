using System;
using Steamworks;
using UnityEngine;

// Token: 0x0200004E RID: 78
public class achievements : MonoBehaviour
{
	// Token: 0x06000176 RID: 374 RVA: 0x0019E920 File Offset: 0x0019CB20
	private void OnEnable()
	{
		if (!GameObject.Find("SteamManager").GetComponent<SteamManager>().achivki_sosut)
		{
			try
			{
				if (SteamManager.Initialized)
				{
					Debug.Log("------------ACHIVKI ACTIVIROVANI-------------------");
					this.m_GameID = new CGameID(SteamUtils.GetAppID());
					this.m_UserStatsReceived = Callback<UserStatsReceived_t>.Create(new Callback<UserStatsReceived_t>.DispatchDelegate(this.OnUserStatsReceived));
					this.m_UserStatsStored = Callback<UserStatsStored_t>.Create(new Callback<UserStatsStored_t>.DispatchDelegate(this.OnUserStatsStored));
					this.m_UserAchievementStored = Callback<UserAchievementStored_t>.Create(new Callback<UserAchievementStored_t>.DispatchDelegate(this.OnAchievementStored));
					this.m_bRequestedStats = false;
					this.m_bStatsValid = false;
				}
			}
			catch
			{
				Debug.Log("------------OSHIBKA PRO ACRIVACCI-------------------");
			}
		}
	}

	// Token: 0x06000177 RID: 375 RVA: 0x00003174 File Offset: 0x00001374
	public void Set(int number)
	{
		Debug.Log("------------SET VISVAN-------------------");
		this.ach_this[number] = true;
	}

	// Token: 0x06000178 RID: 376 RVA: 0x0019E9DC File Offset: 0x0019CBDC
	private void UnlockAchievement(string ach, bool clear)
	{
		if (!GameObject.Find("SteamManager").GetComponent<SteamManager>().achivki_sosut)
		{
			try
			{
				Debug.Log("------------UNLOCK ACHIVMENT VIS VAN BES OSHIPOK-------------------");
				if (clear)
				{
					SteamUserStats.ClearAchievement(ach);
				}
				else
				{
					Debug.Log("------------OTRKIVAEM  " + ach + "-------------------");
					SteamUserStats.SetAchievement(ach);
				}
				this.m_bStoreStats = true;
			}
			catch
			{
			}
		}
	}

	// Token: 0x06000179 RID: 377 RVA: 0x0019EA50 File Offset: 0x0019CC50
	private void Update()
	{
		if (!GameObject.Find("SteamManager").GetComponent<SteamManager>().achivki_sosut)
		{
			try
			{
				if (SteamManager.Initialized)
				{
					if (!this.m_bRequestedStats)
					{
						if (!SteamManager.Initialized)
						{
							this.m_bRequestedStats = true;
							return;
						}
						bool flag = SteamUserStats.RequestCurrentStats();
						this.m_bRequestedStats = flag;
					}
					if (this.m_bStatsValid)
					{
						for (int i = 1; i < this.ach_this.Length; i++)
						{
							if (this.ach_this[i])
							{
								Debug.Log("---------NASHL CHTO " + i.ToString() + " TRUE=========");
								this.ach_this[i] = false;
								this.UnlockAchievement("ACH_" + i, false);
							}
						}
						if (this.m_bStoreStats)
						{
							Debug.Log("------------STORESTATS VISIVAEM-------------------");
							bool flag2 = SteamUserStats.StoreStats();
							this.m_bStoreStats = !flag2;
						}
					}
				}
			}
			catch
			{
			}
		}
	}

	// Token: 0x0600017A RID: 378 RVA: 0x0019EB44 File Offset: 0x0019CD44
	private void OnUserStatsReceived(UserStatsReceived_t pCallback)
	{
		if (!SteamManager.Initialized)
		{
			return;
		}
		if ((ulong)this.m_GameID == pCallback.m_nGameID)
		{
			if (EResult.k_EResultOK == pCallback.m_eResult)
			{
				this.m_bStatsValid = true;
				Debug.Log("------------POLUCHILI STATI-------------------");
				return;
			}
			Debug.Log("------------POLUCHENIE STATOV NE POLUICHILOS-------------------");
		}
	}

	// Token: 0x0600017B RID: 379 RVA: 0x0019EB94 File Offset: 0x0019CD94
	private void OnUserStatsStored(UserStatsStored_t pCallback)
	{
		if ((ulong)this.m_GameID == pCallback.m_nGameID)
		{
			if (EResult.k_EResultOK == pCallback.m_eResult)
			{
				Debug.Log("------------STROE STATS SDELALI------------------");
				return;
			}
			if (EResult.k_EResultInvalidParam == pCallback.m_eResult)
			{
				Debug.Log("------------YA NE ZNA U CHE ETO  NO  IZ STORESTST VIZIVAEM ON USERSTATSRECIVED CALLBACK------------------");
				this.OnUserStatsReceived(new UserStatsReceived_t
				{
					m_eResult = EResult.k_EResultOK,
					m_nGameID = (ulong)this.m_GameID
				});
				return;
			}
			Debug.Log("------------STORESTATS NE POLUCHILOS PITAEMSA ZANOVO-------------------");
		}
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00003189 File Offset: 0x00001389
	private void OnAchievementStored(UserAchievementStored_t pCallback)
	{
		if ((ulong)this.m_GameID == pCallback.m_nGameID)
		{
			Debug.Log("-------Achievement " + pCallback.m_rgchAchievementName + " unlocked!------");
		}
	}

	// Token: 0x04000216 RID: 534
	public bool[] ach_this = new bool[200];

	// Token: 0x04000217 RID: 535
	protected Callback<UserStatsReceived_t> m_UserStatsReceived;

	// Token: 0x04000218 RID: 536
	protected Callback<UserStatsStored_t> m_UserStatsStored;

	// Token: 0x04000219 RID: 537
	protected Callback<UserAchievementStored_t> m_UserAchievementStored;

	// Token: 0x0400021A RID: 538
	private bool m_bStoreStats;

	// Token: 0x0400021B RID: 539
	private bool m_bRequestedStats;

	// Token: 0x0400021C RID: 540
	private bool m_bStatsValid;

	// Token: 0x0400021D RID: 541
	private CGameID m_GameID;
}
