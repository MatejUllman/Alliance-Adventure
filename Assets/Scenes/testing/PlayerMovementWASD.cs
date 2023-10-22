using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementWASD : MonoBehaviour
{
    //jump
    [SerializeField] float jumpForce = 5f;
    [SerializeField] float groundDis = 1.5f;


    //Movement
    [SerializeField] private float speed;
    [SerializeField] private string inputNameHorizontal;
    [SerializeField] private string inputNameVertical;
    [SerializeField] private string inputNameJump;

   

    private Rigidbody rb;
   

    private float inputHorizontal;
    private float inputVertical;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        
    }

    private void Update()
    {
        //Movement
        inputHorizontal = Input.GetAxisRaw(inputNameHorizontal);
        inputVertical = Input.GetAxisRaw(inputNameVertical);

        //jump
        if (Input.GetButtonDown(inputNameJump) && isGrounded())
        {
            rb.velocity = Vector3.up* jumpForce;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(inputHorizontal * speed * Time.fixedDeltaTime, rb.velocity.y, inputVertical * speed * Time.fixedDeltaTime);
    }
    bool isGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, groundDis);
    }
}
