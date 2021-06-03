using UnityEngine;
using System.Collections;

public class FruitSalad : MonoBehaviour 
{
    void Start () 
    {
        //让我们用默认构造函数
        //来说明继承。
        Debug.Log("Creating the fruit");
        Fruit myFruit = new Fruit();
        Debug.Log("Creating the apple");
        Apple myApple = new Apple();

        //调用 Fruit 类的方法。
        myFruit.SayHello();
        myFruit.Chop();

        //调用 Apple 类的方法。
        //注意 Apple 类如何访问
        //Fruit 类的所有公共方法。
        myApple.SayHello();
        myApple.Chop();

        //现在，让我们用读取字符串的
        //构造函数来说明继承。
        Debug.Log("Creating the fruit");
        myFruit = new Fruit("yellow");
        Debug.Log("Creating the apple");
        myApple = new Apple("green");

        //调用 Fruit 类的方法。
        myFruit.SayHello();
        myFruit.Chop();

        //调用 Apple 类的方法。
        //注意 Apple 类如何访问
        //Fruit 类的所有公共方法。
        myApple.SayHello();
        myApple.Chop();
    }
}