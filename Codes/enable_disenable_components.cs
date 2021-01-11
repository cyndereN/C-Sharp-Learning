using UnityEngine;
using System.Collections;

public class EnableComponents : MonoBehaviour {
    private Light myLight;

    void Start(){
        myLight = GetComponent<light>();
    }

    void update(){
        if(Input.GetKeyUp(KeyCode.Space)){
            myLight.enabled = !myLight.enabled;  //Toggle
        }
    }
}