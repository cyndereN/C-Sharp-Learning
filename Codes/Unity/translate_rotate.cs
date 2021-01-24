using UnityEngine;
using System.Collections;

public class TransformFunctions : MonoBehaviour{
    void update(){
        transform.Translate(new Vector3(0,0,1)); //per frame
    }
}

void update(){
    transform.Translate(new Vector3(0,0,1)*Time.DeltaTime); //per second
}

public class TransformFunctions : MonoBehaviour{
    public float moveSpeed = 10f;

    void update(){
        transform.Translate(Vector3.forward * moveSpeed * Time.DeltaTime); 
    }
}

void update(){
    if(Input.GetKey(KeyCode.UpArrow))
        transform.Translate(Vector3.forward * moveSpeed * Time.DeltaTime); 
    if(Input.GetKey(KeyCode.DownArrow))
        transform.Translate(-Vector3.forward * moveSpeed * Time.DeltaTime); 
}


//Rotate
public class TransformFunctions : MonoBehaviour{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    void update(){
    if(Input.GetKey(KeyCode.UpArrow))
        transform.Translate(Vector3.forward * moveSpeed * Time.DeltaTime); 
    if(Input.GetKey(KeyCode.DownArrow))
        transform.Translate(-Vector3.forward * moveSpeed * Time.DeltaTime); 
    if(Input.GetKey(KeyCode.LeftArrow))
        transform.Translate(Vector3.up * -turnSpeed * Time.DeltaTime); 
    if(Input.GetKey(KeyCode.RightArrow))
        transform.Translate(Vector3.up * turnSpeed * Time.DeltaTime); 
    }
}
