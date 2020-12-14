using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Controller : MonoBehaviour
{
    public float speed = 3.0f; 
    Rigidbody2D rigidbody2D;
    public float changeTime = 3.0f; 
    float timer;
    int direction = -1; 
    public int maxHealth = 100;
    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        timer = changeTime;
        currentHealth = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer < 0){
            direction = -direction;
            timer = changeTime;

            Vector3 theScale = transform.localScale;
		    theScale.x *= -1;
		    transform.localScale = theScale;
        }

        if(currentHealth <= 0){
            Destroy(gameObject);
        }
    
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2D.position;
        position.x = position.x + Time.deltaTime * speed * direction;
        
        rigidbody2D.MovePosition(position);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        PlayerMovement player = other.gameObject.GetComponent<PlayerMovement >();

        if(player != null){
            player.ChangeHealth(1);
        }
        //turns enemy around on any collision
        timer = -1;
    }

    public void TakeDamage(int damage) 
    {
        currentHealth -= damage;
        Debug.Log("Enemy 1s Health: " + currentHealth + "/" + maxHealth);
        //turns enemy around when hit 
        timer = -1;
    }
}
