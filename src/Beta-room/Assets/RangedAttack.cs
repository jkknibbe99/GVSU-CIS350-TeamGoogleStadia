using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAttack : MonoBehaviour
{
    public Transform rangedAttackPoint;
    public GameObject rangedSpritePrefab;
    public Animator m_Animator;

    public float attackRate = 2f;
    float nextAttackTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {   if (m_Animator.GetInteger("Weapon") == 1){
            if (Input.GetButtonDown("Fire1")) {
                Shoot();
            }
        }

        if(Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Shoot();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    void Shoot() 
    {
        // Ranged attack logic only if the ranged weapon is selected
        if (m_Animator.GetInteger("Weapon") == 1) {
            Instantiate(rangedSpritePrefab, rangedAttackPoint.position, rangedAttackPoint.rotation);
        }
    }
}
