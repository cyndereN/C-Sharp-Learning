using UnityEngine;
using System.Collections;

public static class Utilities 
{
    //可以在没有类对象的情况下调用
    //静态方法。请注意，静态方法无法访问
    //非静态成员变量。
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}