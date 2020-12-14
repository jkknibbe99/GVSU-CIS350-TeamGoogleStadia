using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Controller : MonoBehaviour
{
    public GameObject projectilePrefab;
    float timer;
    public float changeTime = 3.0f;
    Rigidbody2D rigidbody2d;
    Vector2 lookDirection = new Vector2(-1,0);
    public float force;
    public int maxHealth = 100;
    int currentHealth;
    GameObject enemy; 

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        timer = changeTime;
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer < 0) {
            Launch();
            timer = changeTime;
        }

        if(currentHealth <= 0){
            Destroy(gameObject);
        }
    }

    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody2d.position, Quaternion.identity);

        Projectile_Enemy projectile = projectileObject.GetComponent<Projectile_Enemy>();
        projectile.Launch(lookDirection, force);
    }

    public void TakeDamage(int damage) 
    {
        currentHealth -= damage;
        Debug.Log("Enemy Health 2s: " + currentHealth + "/" + maxHealth);
    }
}
