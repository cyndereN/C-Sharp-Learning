using UnityEngine;
using System.Collections;

public class SpinScript : MonoBehaviour 
{
    [Range(-100, 100)] public int speed = 0; // Above or below

    void Update () 
    {
        transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
    }
}
