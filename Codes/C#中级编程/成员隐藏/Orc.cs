using UnityEngine;
using System.Collections;

public class Orc : Enemy
{
    //这会隐藏 Enemy 版本。
    new public void Yell()
    {
        Debug.Log ("Orc version of the Yell() method");
    }
}