using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller; 
    public Animator animator;

    public float runSpeed = 40f;
    public float timeInvincible = 0.5f;

    float HorizontalMove = 0f; 
    bool jump = false; 
    int jumpInt = 0;

    //variables used for health
    public int maxHealth = 15;
    int currentHealth;
    public int health { get { return currentHealth; }}

    //variables for breif invinciblity timer(prevents double hits from projectiles)
    bool isInvincible;
    float invincibleTimer;

    void Start()
    {
        currentHealth = maxHealth; 
        animator.SetInteger("Era",0);
        DontDestroyOnLoad(gameObject);
    }

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

        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
                isInvincible = false;
        }
    }

    void FixedUpdate () 
    {
        //move our character 
        controller.Move(HorizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false; 
        jumpInt = 0;

    }

    public void ChangeHealth(int amount)
    {
        if (isInvincible)
            return;
            
        isInvincible = true;
        invincibleTimer = timeInvincible;


        currentHealth -= amount;
        Debug.Log(currentHealth + "/" + maxHealth);
            
        
    }
}
