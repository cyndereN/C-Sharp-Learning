using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
    //静态变量是在类的所有实例之间
    //共享的变量。
    public static int playerCount = 0;

    void Start()
    {
        //通过递增静态变量了解
         //已创建此类的多少个对象。
        playerCount++;
    }
}