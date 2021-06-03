using UnityEngine;
using System.Collections;

public class Player
{
    //成员变量可以称为
    //字段。
    private int experience;

    //Experience 是一个基本属性
    public int Experience
    {
        get
        {
            //其他一些代码
            return experience;
        }
        set
        {
            //其他一些代码
            experience = value;
        }
    }

    //Level 是一个将经验值自动转换为
    //玩家等级的属性
    public int Level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }

    //这是一个自动实现的属性的
    //示例
    public int Health{ get; set;}
}