using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SomeClass : MonoBehaviour
{
    void Start () 
    {
        //这是创建列表的方式。注意如何在
        //尖括号 (< >) 中指定类型。
        List<BadGuy> badguys = new List<BadGuy>();

        //这里将 3 个 BadGuy 添加到列表
        badguys.Add( new BadGuy("Harvey", 50));
        badguys.Add( new BadGuy("Magneto", 100));
        badguys.Add( new BadGuy("Pip", 5));

        badguys.Sort();

        foreach(BadGuy guy in badguys)
        {
            print (guy.name + " " + guy.power);
        }

        //这会清除列表，使其
        //为空。
        badguys.Clear();
    }
}
