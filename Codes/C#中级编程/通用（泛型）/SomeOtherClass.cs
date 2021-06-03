using UnityEngine;
using System.Collections;

public class SomeOtherClass : MonoBehaviour 
{
    void Start () 
    {
        SomeClass myClass = new SomeClass();

        //为了使用此方法，必须
        //告诉此方法用什么类型替换
        //“T”。
        myClass.GenericMethod<int>(5);
    }
}