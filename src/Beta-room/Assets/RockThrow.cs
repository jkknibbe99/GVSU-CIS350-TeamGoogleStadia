using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockThrow : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 20;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo) {
        Enemy1Controller enemy1 = hitInfo.GetComponent<Enemy1Controller>();
        Enemy2Controller enemy2 = hitInfo.GetComponent<Enemy2Controller>();
        Enemy3Controller enemy3 = hitInfo.GetComponent<Enemy3Controller>();

        if(enemy1 != null){
                enemy1.TakeDamage(damage);
                
        }else if(enemy2 != null){
                enemy2.TakeDamage(damage);

         }else if(enemy3 != null){
                enemy3.TakeDamage(damage);
         }
        Destroy(gameObject);
    }

}
