using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public CharacterStats playerStats;

    // �۲���ģʽ������ע�᷽����player����ʱ����GM
    public void RegisterPlayer(CharacterStats player)
	{
        playerStats = player;

	}
}
