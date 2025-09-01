using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControls : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    void Movement()
    {
        float forwardMovement =
            Input.GetAxis("Vertical") *
            Time.deltaTime * speed;
        float turnMovement =
            Input.GetAxis("Horizontal") *
            Time.deltaTime * turnSpeed;
        transform.Translate(
            Vector3.forward * forwardMovement);
        transform.Rotate(
            Vector3.up * turnMovement);
    }
    void Update()
    {
        Movement();
    }
}
