using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour 
{
    void Start () 
    {
        Player myPlayer = new Player();

        //属性可以像变量一样使用
        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
    }
}