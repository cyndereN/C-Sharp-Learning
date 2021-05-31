using UnityEngine;
using System.Collections;

public class DualAxisExample : MonoBehaviour 
{
    public float range;
    public GUIText textOutput;
    
    
    void Update () 
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * range;
        float yPos = v * range;
        
        transform.position = new Vector3(xPos, yPos, 0);
        textOutput.text = "Horizontal Value Returned: "+h.ToString("F2")+"\nVertical Value Returned: "+v.ToString("F2");    
    }
}