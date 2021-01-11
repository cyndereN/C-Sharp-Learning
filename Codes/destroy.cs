using UnityEngine;
using System.Collections;

public class DestroyBasic : MonoBehaviour{
    public GameObject other;
    void update(){
        if(Input.GetKey(KeyCode.Space)){
            Destroy(other, 3f);  // 3 seconds delay
        }
    }
}

public class DestroyComponent : MonoBehaviour{
    
    void update(){
        if(Input.GetKey(KeyCode.Space)){
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}

