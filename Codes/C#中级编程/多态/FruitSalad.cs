using UnityEngine;
using System.Collections;

public class FruitSalad : MonoBehaviour
{
    void Start () 
    {
        //请注意，这里的变量“myFruit”的类型是
        //Fruit，但是被分配了对 Apple 的引用。这是
        //由于多态而起作用的。由于 Apple 是 Fruit，
        //因此这样是可行的。虽然 Apple 引用存储
        //在 Fruit 变量中，但只能像 Fruit 一样使用
        Fruit myFruit = new Apple();

        myFruit.SayHello();
        myFruit.Chop();

        //这称为向下转换。Fruit 类型的变量“myFruit”
        //实际上包含对 Apple 的引用。因此，
        //可以安全地将它转换回 Apple 变量。这使得
        //它可以像 Apple 一样使用，而在以前只能像 Fruit
        //一样使用。
        Apple myApple = (Apple)myFruit;

        myApple.SayHello();
        myApple.Chop();    
    }
}
