using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    public Animator m_Animator;

    public int heal = 5;
    public int potion = 1;

    // Update is called once per frame
    void Update()
    {
        PlayerMovement player = gameObject.GetComponent<PlayerMovement>();
        if (Input.GetKeyDown(KeyCode.E) && potion == 1){
            m_Animator.SetTrigger("Heal");
            player.ChangeHealth(-heal);
            potion--;
        }
    }
    


}
