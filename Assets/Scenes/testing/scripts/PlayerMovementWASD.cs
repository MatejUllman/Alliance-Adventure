using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovementWASD : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    private bool isOpened = false;
    

    private Animator anim;
    
    //jump
    [SerializeField] float jumpForce = 5f;

    private bool isGrounded = true;


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
        anim = GetComponent<Animator>();
        
        
        
    }

    private void Update()
    {
        //Movement
      
            inputHorizontal = Input.GetAxis(inputNameHorizontal);
            inputVertical = Input.GetAxis(inputNameVertical);
            Vector3 movementDirection = new Vector3(inputHorizontal, 0, inputVertical);
            movementDirection.Normalize();
            transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);


     
        if(movementDirection != Vector3.zero)
        {
            anim.SetBool("walks",true);
        }
        else
        {
            anim.SetBool("walks", false);
        }

        


            //turning to the point of movement
            if (movementDirection != Vector3.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);

            }
            

      


        Jump();
        
     
    }

    public void Jump()
    {
        if (Input.GetButtonDown(inputNameJump) && isGrounded)
        {
            anim.SetBool("grounded", false);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
        else
        {
            anim.SetBool("grounded", true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            
            isGrounded = true;
        }else if (collision.gameObject.CompareTag("KeyDoor"))
        {
           
                if (!isOpened)
                {
                    myDoor.Play("openSDoor", 0, 0.0f);
                    
                    
                    
                    isOpened = true;
                }
                else if (isOpened)
                {
                    myDoor.Play("closeSDooor", 0, 0.0f);
                    isOpened = false;
                }
            

           
        }
    }



}
