using UnityEngine;
using System.Collections;

public class DualAxisExample : MonoBehaviour{
    public float range;
    public GUIText textOutput;

    void Update(){
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * range;
        float yPos = v * range;
    }
}