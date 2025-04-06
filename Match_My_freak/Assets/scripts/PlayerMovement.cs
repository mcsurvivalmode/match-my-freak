using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horizontalInput;
    float moveSpeed = 5f;

    bool isFacingRight = false; //starts as false cause the player spwans in facing left |
    Rigidbody2D rb;
    
    float jumpPower = 4f; //var for jump code!!
    
   // [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

      // Update is called once per frame
   void Start()
    {
       rb = GetComponent<Rigidbody2D>();

           
      }
    

//ON UPDATE 
    void Update()
    //gets the input 
    {
       horizontalInput = Input.GetAxis("Horizontal");

       FlipSprite();

       if(Input.GetButtonDown("Jump") && IsGrounded()) //makes player jump if space is pressed 
       {
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
       }
       if(Input.GetButtonUp("Jump") && rb.velocity.y > 0f) //makes it so u jump higher the longer the button is pressed 
       {
        rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f); 


       }
           
    }
  
  //MOVEMENT 
    private void FixedUpdate()
    //makes the player move by multiplying 
    {
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
       

    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer); //creates invisible circle at players feet, when on ground player can jump 


    }


//FLIPPING
    void FlipSprite()
    {
    

        if(isFacingRight && horizontalInput <0f || !isFacingRight && horizontalInput > 0f)
        {
            isFacingRight = !isFacingRight; //sets it so its the opposite of what is currently is 
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls; 

        }
    }

   

    

    


}
