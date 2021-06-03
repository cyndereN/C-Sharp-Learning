using UnityEngine;
using System.Collections;

public class SomeClass : MonoBehaviour 
{
    void Start () {
        //请注意，即使方法声明中
        //有一个参数，也不会将任何参数传递给
        //此扩展方法。调用此方法的
        //Transform 对象会自动作为
        //第一个参数传入。
        transform.ResetTransformation();
    }
}