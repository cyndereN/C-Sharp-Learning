using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public CharacterStats playerStats;

    List<IEndGameObserver> endGameObservers = new List<IEndGameObserver>();

    // �۲���ģʽ������ע�᷽����player����ʱ����GM
    public void RegisterPlayer(CharacterStats player)
	{
        playerStats = player;
	}

    public void AddObserver(IEndGameObserver observer)
	{
        endGameObservers.Add(observer);
	}

    public void RemoveObserver(IEndGameObserver observer)
    {
        endGameObservers.Remove(observer);
    }

    // �㲥
    public void NotifyObservers()
	{
        foreach(var observer in endGameObservers)
		{
            observer.EndNotify();
		}
	}
}
