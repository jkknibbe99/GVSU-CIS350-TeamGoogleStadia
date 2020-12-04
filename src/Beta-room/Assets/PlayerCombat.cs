using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator m_Animator;

    public Transform attackPoint;
    public LayerMask enemyLayers;
    

    public float attackRange = 0.5f;
    public int attackDamage = 25;

    public float attackRate = 2f;
    float nextAttackTime = 0f;

    // Update is called once per frame
    void Update()
    {
        // Limits the time between attacks
        if(Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    void Attack()
    {
        // Play an attack animation
        m_Animator.SetTrigger("Attack");

        // Detect enemies in range of attack
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        // Damage the enemies
        foreach(Collider2D enemy in hitEnemies)
        {
            if(enemy.GetComponent<Enemy1Controller>() != null){
                enemy.GetComponent<Enemy1Controller>().TakeDamage(attackDamage);
                
            }else if(enemy.GetComponent<Enemy2Controller>() != null){
                enemy.GetComponent<Enemy2Controller>().TakeDamage(attackDamage);

            }else if(enemy.GetComponent<Enemy3Controller>() != null){
                enemy.GetComponent<Enemy3Controller>().TakeDamage(attackDamage);
            }
            
        }
    }

    // Shows the area of the attack

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
