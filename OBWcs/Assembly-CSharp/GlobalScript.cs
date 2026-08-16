using System;
using UnityEngine;

// Token: 0x0200001F RID: 31
public class GlobalScript : MonoBehaviour
{
	// Token: 0x06000084 RID: 132 RVA: 0x00002794 File Offset: 0x00000994
	public void ChangeMusicTo(int num)
	{
		this.music[this.now_playing].UnloadAudioData();
		this.now_playing = num;
		this.music[this.now_playing].LoadAudioData();
		this.is_ready_to_play = true;
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00031C6C File Offset: 0x0002FE6C
	public void MusicReset()
	{
		this.music[this.now_playing].UnloadAudioData();
		int num = this.now_playing;
		while (this.now_playing == num)
		{
			if (this.bitss == 1)
			{
				this.now_playing = global::UnityEngine.Random.Range(0, 29);
			}
			else if (this.bitss == 2)
			{
				this.now_playing = global::UnityEngine.Random.Range(29, 49);
			}
			else if (this.bitss == 3)
			{
				this.now_playing = global::UnityEngine.Random.Range(49, 70);
			}
			else if (this.bitss == 4)
			{
				this.now_playing = global::UnityEngine.Random.Range(70, 87);
			}
			else if (this.bitss == 5)
			{
				this.now_playing = global::UnityEngine.Random.Range(87, 102);
			}
			else if (this.bitss == 6)
			{
				this.now_playing = global::UnityEngine.Random.Range(102, 114);
			}
			else if (this.bitss == 7)
			{
				this.now_playing = global::UnityEngine.Random.Range(114, 130);
			}
			else if (this.bitss == 8)
			{
				this.now_playing = global::UnityEngine.Random.Range(130, 139);
			}
			else if (this.bitss == 9)
			{
				this.now_playing = global::UnityEngine.Random.Range(139, 152);
			}
			else if (this.bitss == 10)
			{
				this.now_playing = global::UnityEngine.Random.Range(283, 299);
			}
			else if (this.bitss == 11)
			{
				this.now_playing = global::UnityEngine.Random.Range(152, 201);
			}
			else if (this.bitss == 12)
			{
				this.now_playing = global::UnityEngine.Random.Range(201, 250);
			}
			else if (this.bitss == 13)
			{
				this.now_playing = global::UnityEngine.Random.Range(250, 283);
			}
		}
		this.music[this.now_playing].LoadAudioData();
		this.is_ready_to_play = true;
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00031E54 File Offset: 0x00030054
	private void Awake()
	{
		this.bitss = global::UnityEngine.Random.Range(1, 11);
		if (!PlayerPrefs.HasKey("voice_ost"))
		{
			PlayerPrefs.SetInt("voice_ost", 5);
		}
		this.voice = PlayerPrefs.GetInt("voice_ost");
		if (PlayerPrefs.HasKey("autosave_check"))
		{
			this.autosave = PlayerPrefs.GetInt("autosave_check");
		}
		Application.targetFrameRate = 60;
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00031EBC File Offset: 0x000300BC
	private void FixedUpdate()
	{
		if (base.GetComponent<AudioSource>().volume != (float)this.voice / 100f)
		{
			base.GetComponent<AudioSource>().volume = (float)this.voice / 100f;
		}
		if (this.music[this.now_playing].loadState == AudioDataLoadState.Failed)
		{
			this.MusicReset();
			return;
		}
		if (this.is_ready_to_play && this.music[this.now_playing].loadState == AudioDataLoadState.Loaded)
		{
			this.is_ready_to_play = false;
			base.GetComponent<AudioSource>().PlayOneShot(this.music[this.now_playing]);
			return;
		}
		if (!this.is_ready_to_play && !base.GetComponent<AudioSource>().isPlaying)
		{
			this.MusicReset();
		}
	}

	// Token: 0x040000D4 RID: 212
	public int[] Events_number = new int[1100];

	// Token: 0x040000D5 RID: 213
	public float[] Events_time = new float[1100];

	// Token: 0x040000D6 RID: 214
	public bool[] Events_active = new bool[1100];

	// Token: 0x040000D7 RID: 215
	public Region[] regions = new Region[5];

	// Token: 0x040000D8 RID: 216
	public int number_event = -1;

	// Token: 0x040000D9 RID: 217
	public int number_otvet = -1;

	// Token: 0x040000DA RID: 218
	public int this_stump = -1;

	// Token: 0x040000DB RID: 219
	public bool is_progorel;

	// Token: 0x040000DC RID: 220
	public bool[] event_done = new bool[1100];

	// Token: 0x040000DD RID: 221
	public int[] eventVariantChosen = new int[1100];

	// Token: 0x040000DE RID: 222
	public bool achivki_sosut;

	// Token: 0x040000DF RID: 223
	public Country[] allcountries = new Country[55];

	// Token: 0x040000E0 RID: 224
	public int speed;

	// Token: 0x040000E1 RID: 225
	public int voice = 5;

	// Token: 0x040000E2 RID: 226
	public bool[] diff = new bool[4];

	// Token: 0x040000E3 RID: 227
	public Game_Event[] events = new Game_Event[40];

	// Token: 0x040000E4 RID: 228
	public bool is_save_bylo;

	// Token: 0x040000E5 RID: 229
	public bool is_elect;

	// Token: 0x040000E6 RID: 230
	public bool is_speech;

	// Token: 0x040000E7 RID: 231
	public bool automat;

	// Token: 0x040000E8 RID: 232
	public bool is_liber;

	// Token: 0x040000E9 RID: 233
	public bool povod;

	// Token: 0x040000EA RID: 234
	public bool is_konst_max = true;

	// Token: 0x040000EB RID: 235
	public bool iron_and_blood;

	// Token: 0x040000EC RID: 236
	public bool turn_on = true;

	// Token: 0x040000ED RID: 237
	public int issleduetsya;

	// Token: 0x040000EE RID: 238
	public int map_type = 1;

	// Token: 0x040000EF RID: 239
	public bool is_gkchp;

	// Token: 0x040000F0 RID: 240
	public bool bylo;

	// Token: 0x040000F1 RID: 241
	public bool neizucheno = true;

	// Token: 0x040000F2 RID: 242
	public int autosave;

	// Token: 0x040000F3 RID: 243
	public int[] party_number = new int[5];

	// Token: 0x040000F4 RID: 244
	public string[] party_name = new string[5];

	// Token: 0x040000F5 RID: 245
	public bool[] is_party_ally = new bool[5];

	// Token: 0x040000F6 RID: 246
	public bool[] is_party_enabled = new bool[5];

	// Token: 0x040000F7 RID: 247
	public int[] party_ideology = new int[5];

	// Token: 0x040000F8 RID: 248
	public string[] politics_name = new string[10];

	// Token: 0x040000F9 RID: 249
	public string[] politics_charact = new string[10];

	// Token: 0x040000FA RID: 250
	public string[] politics_opis = new string[10];

	// Token: 0x040000FB RID: 251
	public AudioClip[] music = new AudioClip[166];

	// Token: 0x040000FC RID: 252
	public int now_playing;

	// Token: 0x040000FD RID: 253
	public bool is_ready_to_play;

	// Token: 0x040000FE RID: 254
	public int bitss = 1;

	// Token: 0x040000FF RID: 255
	public string[] new_texts;

	// Token: 0x04000100 RID: 256
	public string[] doctr = new string[26];

	// Token: 0x04000101 RID: 257
	public bool[] science = new bool[10];

	// Token: 0x04000102 RID: 258
	public int[] science_time = new int[10];

	// Token: 0x04000103 RID: 259
	public string[] dates = new string[] { "1989", "1990", "1991" };

	// Token: 0x04000104 RID: 260
	public int[] data_old = new int[9];

	// Token: 0x04000105 RID: 261
	public int[] data = new int[150];

	// Token: 0x04000106 RID: 262
	public string sovietPremiereName;

	// Token: 0x04000107 RID: 263
	public Sprite crisis;

	// Token: 0x04000108 RID: 264
	public string Num1;
}
