using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horizontal;
    float vertical;
    public float speed = 5.0f;
    public float jumpForce = 5.0f;
    private bool grounded = true;

    Vector3 movement;

    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (grounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
                grounded = false;
            }
        }
        rb.velocity = new Vector3(horizontal * speed, rb.velocity.y, 0);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        grounded = true;
    }
}
