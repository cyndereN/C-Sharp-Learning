using UnityEngine;
using System.Collections;

//这是一个通用类。注意通用类型“T”。
//“T”将被替换为实际类型，同样，
//该类中使用的“T”类型实例也将被替换。
public class GenericClass <T>
{
    T item;

    public void UpdateItem(T newItem)
    {
        item = newItem;
    }
}