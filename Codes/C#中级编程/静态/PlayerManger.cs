using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour 
{
    void Start()
    {
        //可以使用类名和点运算符
        //来访问静态变量。
        int x = Player.playerCount;
    }
}
