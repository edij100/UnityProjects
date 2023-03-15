using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 500f;
    private Rigidbody rb;
    public float jumpSpeed = 800f;
    private bool running = false;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 1000f;
            running = true;
        }
        if (running == true && Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 500f;
        }
        if (Input.GetKey(KeyCode.Space) && IsGrounded())
        {
            rb.velocity = Vector3.up * jumpSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * speed * Time.deltaTime );
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * speed * Time.deltaTime);
        }
    }
    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }
}
