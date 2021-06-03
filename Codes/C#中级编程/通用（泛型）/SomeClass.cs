using UnityEngine;
using System.Collections;

public class SomeClass 
{
    //这是一个通用方法。注意通用
    //类型“T”。该“T”将在运行时替换为
    //实际类型。
    public T GenericMethod<T>(T param)
    {
        return param;
    }
}