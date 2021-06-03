using UnityEngine;
using System.Collections;

public class Enemy
{
    //静态变量是在类的所有实例之间
    //共享的变量。
    public static int enemyCount = 0;

    public Enemy()
    {
        //通过递增静态变量了解
        //已创建此类的多少个对象。
        enemyCount++;
    }
}