using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public CharacterStats playerStats;

    List<IEndGameObserver> endGameObservers = new List<IEndGameObserver>();

    // 观察者模式，反向注册方法，player生成时告诉GM
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

    // 广播
    public void NotifyObservers()
	{
        foreach(var observer in endGameObservers)
		{
            observer.EndNotify();
		}
	}
}
