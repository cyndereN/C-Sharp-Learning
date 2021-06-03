using UnityEngine;
using System.Collections;
using System; //这允许 IComparable 接口

//这是您将存储在
//不同集合中的类。为了使用
//集合的 Sort() 方法，此类需要
//实现 IComparable 接口。
public class BadGuy : IComparable<BadGuy>
{
    public string name;
    public int power;

    public BadGuy(string newName, int newPower)
    {
        name = newName;
        power = newPower;
    }

    //IComparable 接口需要
    //此方法。
    public int CompareTo(BadGuy other)
    {
        if(other == null)
        {
            return 1;
        }

        //返回力量差异。
        return power - other.power;
    }
}
