using UnityEngine;
using System.Collections;

public class GenericClassExample : MonoBehaviour 
{
    void Start () 
    {        
        //为了创建通用类的对象，必须
        //指定希望该类具有的类型。
        GenericClass<int> myClass = new GenericClass<int>();

        myClass.UpdateItem(5);
    }
}
