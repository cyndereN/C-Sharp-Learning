using UnityEngine;
using System.Collections;

public class InvokeScript : MonoBehaviour {
    public GameObject target;

    void start(){
        Invoke("SpawnObject", 2);
    }

    void SpawnObject(){
        Instantiate(target, new Vector3(0,2,0), Quaternion.identity);
    }
}

public class InvokeRepeating : MonoBehaviour {
    public GameObject target;

    void start(){
        InvokeRepeating("SpawnObject", 2, 1);   //Called after 2 secs and called again every 1 sec
        
        //CancelInvoke("SpawnObject");"
    }

    void SpawnObject(){
        float x = Random.Range(-2.0f, 2.0f);
        float y = Random.Range(-2.0f, 2.0f);
        Instantiate(target, new Vector3(x,2,z), Quaternion.identity);
    }
}