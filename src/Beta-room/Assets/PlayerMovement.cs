using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller; 
    public Animator animator;

    public float runSpeed = 40f;

    float HorizontalMove = 0f; 
    bool jump = false; 
    int jumpInt = 0;
    

    // Update is called once per frame
    void Update()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed",Mathf.Abs(HorizontalMove));
        
        if(Input.GetButtonDown("Jump")){
            jump = true;
            jumpInt = 1;
            animator.SetFloat("Ups",Mathf.Abs(jumpInt));
        }
    }

    void FixedUpdate () 
    {
        //move our character 
        controller.Move(HorizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false; 
        jumpInt = 0;

    }
}
