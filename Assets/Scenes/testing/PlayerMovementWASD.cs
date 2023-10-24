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


    //smoother rotation
    [SerializeField]private float rotationSpeed;

   

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
        
        inputHorizontal = Input.GetAxis(inputNameHorizontal);
        inputVertical = Input.GetAxis(inputNameVertical);
        Vector3 movementDirection = new Vector3(inputHorizontal, 0, inputVertical);
        movementDirection.Normalize();
        transform.Translate(movementDirection * speed * Time.deltaTime,Space.World);
        if (isGrounded())
        {
            speed = 5f;
        }
        else
        {
            speed = 1f;
        }

        //turning to the point of movement
        if (movementDirection!= Vector3.zero )
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }


        Jump();
     
    }

    public void Jump()
    {
        if (Input.GetButtonDown(inputNameJump) && isGrounded())
        {
            rb.velocity = Vector3.up * jumpForce;
        }
    }
   
    bool isGrounded()
    {
       
        return Physics.Raycast(transform.position, Vector3.down, groundDis);

    }
   
}
