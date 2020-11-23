using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Controller : MonoBehaviour
{
     public GameObject projectilePrefab;
    Vector2 lookDirection = new Vector2(-1, 0);
    public float force;

    public float speed = 1.0f; 
    Rigidbody2D rigidbody2D;
    public float changeTime = 1.0f; 
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
            Launch();
            timer = changeTime;
        }

        if(currentHealth <= 0){
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2D.position;
        position.y = position.y + Time.deltaTime * speed * direction;
        
        rigidbody2D.MovePosition(position);
    }

    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody2D.position, Quaternion.identity);

        Projectile_Enemy projectile = projectileObject.GetComponent<Projectile_Enemy>();
        projectile.Launch(lookDirection, force);
    }

    public void TakeDamage(int damage) 
    {
        currentHealth -= damage;
        Debug.Log("Enemy Health 3s: " + currentHealth + "/" + maxHealth);
    }
}
