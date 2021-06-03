using UnityEngine;
using System.Collections;

//这是基类，
//也称为父类。
public class Fruit 
{
    public string color;

    //这是 Fruit 类的第一个构造函数，
    //不会被任何派生类继承。
    public Fruit()
    {
        color = "orange";
        Debug.Log("1st Fruit Constructor Called");
    }

    //这是 Fruit 类的第二个构造函数，
    //不会被任何派生类继承。
    public Fruit(string newColor)
    {
        color = newColor;
        Debug.Log("2nd Fruit Constructor Called");
    }

    public void Chop()
    {
        Debug.Log("The " + color + " fruit has been chopped.");        
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}