using UnityEngine;
using System.Collections;

public class SomeClass
{
    //第一个 Add 方法的签名为
    //“Add(int, int)”。该签名必须具有唯一性。
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    //第二个 Add 方法的签名为
    //“Add(string, string)”。同样，该签名必须具有唯一性。
    public string Add(string str1, string str2)
    {
        return str1 + str2;
    }
}