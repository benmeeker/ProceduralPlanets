using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 15;
    public Vector3 moveDirection;
    Rigidbody rb;

    void Update()
    {
        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
    }

    void FixedUpdate() 
    {
        rb = GetComponent<Rigidbody>();

        rb.MovePosition(rb.position + transform.TransformDirection(moveDirection) * moveSpeed * Time.deltaTime);
    }
}
