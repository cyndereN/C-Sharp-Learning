using UnityEngine;
using System.Collections;

public class Game
{
    void Start () 
    {
        Enemy enemy1 = new Enemy();
        Enemy enemy2 = new Enemy();
        Enemy enemy3 = new Enemy();

        //可以使用类名和点运算符
        //来访问静态变量。
        int x = Enemy.enemyCount;
    }
}