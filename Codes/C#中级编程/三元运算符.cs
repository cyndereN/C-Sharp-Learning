using UnityEngine;
using System.Collections;

public class TernaryOperator : MonoBehaviour 
{
    void Start () 
    {
        int health = 10;
        string message;

        //这是一个三元运算的示例，其中根据
        //变量“health”选择一条消息。
        message = health > 0 ? "Player is Alive" : "Player is Dead";
    }
}