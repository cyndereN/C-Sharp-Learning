using UnityEngine;
using System.Collections;

public class DatatypeScript : MonoBehaviour 
{
    void Start () 
    {
        //值类型变量
        Vector3 pos = transform.position;
        pos = new Vector3(0, 2, 0);
        
        //引用类型变量
        Transform tran = transform;
        tran.position = new Vector3(0, 2, 0);
    }
}
