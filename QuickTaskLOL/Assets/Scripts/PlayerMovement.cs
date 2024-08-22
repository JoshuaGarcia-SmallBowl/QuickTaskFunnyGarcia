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

    private CharacterController characterController;
    

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (grounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
            }
        }
        movement = new Vector3(horizontal, 0, 0).normalized * speed * Time.deltaTime;
        characterController.Move(movement);
        
    }
}
