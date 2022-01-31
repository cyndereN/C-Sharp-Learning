using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public CharacterStats playerStats;

    // 观察者模式，反向注册方法，player生成时告诉GM
    public void RegisterPlayer(CharacterStats player)
	{
        playerStats = player;

	}
}
