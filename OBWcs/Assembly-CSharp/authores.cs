using System;
using UnityEngine;

// Token: 0x02000050 RID: 80
public class authores : MonoBehaviour
{
	// Token: 0x06000181 RID: 385 RVA: 0x0019EFCC File Offset: 0x0019D1CC
	private void Awake()
	{
		if (PlayerPrefs.GetInt("language") == 0)
		{
			this.text1.text = " 东 德 情 结:\n 柏 林 墙\n\n 主 要 开 发 人 员:\nVasiliy Vladimirovich Kostilev\nMaxim Olegovich Chornobuk";
			this.text4.text = "\n 游 戏 使 用 的 社 会 主 义 时 期 音 乐\nhttps://nostal.games";
			this.text2.text = " 参 与 开 发 人 员 ：\nIllarion Soldaev - vk.com/id17834106\nEldar Manyashev - vk.com/id109719499\n\n 特 别 鸣 谢:\nGeorgy Emelyanov - vk.com/gogaa24\nIlya Kuznetsov - vk.com/id276119505\nVladimir Gridasov - vk.com/id145067238\nVasiliy Anreyev - vk.com/brutalpin\nМаксим Косицын - vk.com/socialmaxim";
			this.text3.text = " 特 别 鸣 谢:\nДаниил Чумаков\nГеоргий Коршиков - vk.com/id455054985\nАлександр Кучкин - vk.com/sachasaha\nВолкович - vk.com/volkovichstanislav\nАнтон Максимов - vk.com/mash2525\nВиктор Гордеев\nЕгор Клюев - vk.com/trallshaman\nDavid52522\nKeTsarl\nДмитрий Иванов - vk.com/kratos999god";
			return;
		}
		this.text1.text = "Ostalgie:\nБерлинская стена\n\nВедущие разработчики:\nВасилий Владимирович Костылев\nМаксим Олегович Чорнобук";
		this.text4.text = "\nВ игре используются песни\nсоциалистических времён.\nhttps://nostal.games";
		this.text2.text = "В разработке проекта участвовали:\nИлларион Солдаев - vk.com/id17834106\nЭльдар Маняшев - vk.com/id109719499\n\nОсобая благодарность:\nГеоргий Емельянов - vk.com/gogaa24\nИлья Кузнецов - vk.com/id276119505\nВладимир Гридасов - vk.com/id145067238\nВасилий Андреев - vk.com/brutalpin\nМаксим Косицын - vk.com/socialmaxim";
		this.text3.text = "Особая благодарность:\nДаниил Чумаков\nГеоргий Коршиков - vk.com/id455054985\nАлександр Кучкин - vk.com/sachasaha\nВолкович - vk.com/volkovichstanislav\nАнтон Максимов - vk.com/mash2525\nВиктор Гордеев\nЕгор Клюев - vk.com/trallshaman\nDavid52522\nKeTsarl\nДмитрий Иванов - vk.com/kratos999god";
	}

	// Token: 0x04000222 RID: 546
	public TextMesh text1;

	// Token: 0x04000223 RID: 547
	public TextMesh text2;

	// Token: 0x04000224 RID: 548
	public TextMesh text3;

	// Token: 0x04000225 RID: 549
	public TextMesh text4;
}
