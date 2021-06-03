using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SomeOtherClass : MonoBehaviour 
{
    void Start ()
    {
        //这是创建字典的方式。注意这是如何采用
        //两个通用术语的。在此情况中，您将使用字符串和
        //BadGuy 作为两个值。
        Dictionary<string, BadGuy> badguys = new Dictionary<string, BadGuy>();

        BadGuy bg1 = new BadGuy("Harvey", 50);
        BadGuy bg2 = new BadGuy("Magneto", 100);

        //可以使用 Add() 方法将变量
        //放入字典中。
        badguys.Add("gangster", bg1);
        badguys.Add("mutant", bg2);

        BadGuy magneto = badguys["mutant"];

        BadGuy temp = null;

        //这是一种访问字典中值的更安全
        //但缓慢的方法。
        if(badguys.TryGetValue("birds", out temp))
        {
            //成功！
        }
        else
        {
            //失败！
        }
    }
}