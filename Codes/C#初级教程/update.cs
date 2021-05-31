using UnityEngine;
using System.Collections;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    void FixedUpdate ()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);   //regular updates
    }
    
    
    void Update ()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
}