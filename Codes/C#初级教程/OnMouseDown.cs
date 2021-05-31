using UnityEngine;
using System.Collections;

public class MouseClick : MonoBehaviour
{
    void OnMouseDown ()
    {
        rigidbody.AddForce(-transform.forward * 500f);
        rigidbody.useGravity = true;
    }
}
