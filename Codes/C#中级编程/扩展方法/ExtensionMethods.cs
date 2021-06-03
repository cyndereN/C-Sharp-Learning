using UnityEngine;
using System.Collections;

//创建一个包含所有扩展方法的类
//是很常见的做法。此类必须是静态类。
public static class ExtensionMethods
{
    //扩展方法即使像普通方法一样使用，
    //也必须声明为静态。请注意，第一个
    //参数具有“this”关键字，后跟一个 Transform
    //变量。此变量表示扩展方法会成为
    //哪个类的一部分。
    public static void ResetTransformation(this Transform trans)
    {
        trans.position = Vector3.zero;
        trans.localRotation = Quaternion.identity;
        trans.localScale = new Vector3(1, 1, 1);
    }
}