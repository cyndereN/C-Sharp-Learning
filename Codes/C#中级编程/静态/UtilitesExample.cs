using UnityEngine;
using System.Collections;

public class UtilitiesExample : MonoBehaviour 
{
    void Start()
    {
        //可以使用类名和点运算符
        //来访问静态方法。
        int x = Utilities.Add (5, 6);
    }
}
