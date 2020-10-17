using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller; 

    public float runSpeed = 40f;

    float HorizontalMove = 0f; 
    bool jump = false; 
    

    // Update is called once per frame
    void Update()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
        if(Input.GetButtonDown("Jump")){
            jump = true;
        }
    }

    void FixedUpdate () 
    {
        //move our character 
        controller.Move(HorizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false; 

    }
}
