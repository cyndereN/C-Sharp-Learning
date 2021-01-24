using UnityEngine;
using System.Collections;

public class ActiveObjects : MonoBehaviour{
    void Start(){
        gameObject.SetActive(false);
    }
}

public class CheckState : MonoBehaviour{
    public gameObject myObject;

    void Start(){
        Debug.log("Active Self: " + myObject.activeSelf);
        Debug.log("Active in Hierarchy" + myObject.activeInHierarchy);
    }
}