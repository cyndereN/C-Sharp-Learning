using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPlayerMove : MonoBehaviour
{
    float h;
    float v;
    Vector3 movement;
    Vector3 camForward;

    public float speed = 6;
    public float turnSpeed = 15;
    public Transform camTransform;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
	{
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        //GetComponent<Rigidbody>().MovePosition(transform.position + camTransform.right*h + camForward*v);
        transform.Translate(camTransform.right * h * speed * Time.deltaTime + camForward * v * speed * Time.deltaTime, Space.World);
        if(h != 0 || v != 0)
		{
            Rotate(h, v);
		}
	}

    void Rotate(float h, float v)
	{
        camForward = Vector3.Cross(camTransform.right, Vector3.up);
        Vector3 targetDir = camTransform.right * h + camForward * v;
        Quaternion targetRotation = Quaternion.LookRotation(targetDir, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
	}
}
