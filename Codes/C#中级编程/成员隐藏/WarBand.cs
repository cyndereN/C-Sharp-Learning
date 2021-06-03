using UnityEngine;
using System.Collections;

public class WarBand : MonoBehaviour 
{
    void Start () 
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemy();
        Humanoid orc = new Orc();

        //注意每个 Humanoid 变量如何包含
        //对继承层级视图中
        //不同类的引用，但每个变量都
        //调用 Humanoid Yell() 方法。
        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}