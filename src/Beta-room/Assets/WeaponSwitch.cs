using UnityEngine;

public class WeaponSwitch : MonoBehaviour {

    public int selectedWeapon = 0;
    public Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
        
        int previousSelectedWeapon = selectedWeapon;
        
        // Advances the selected weapon by 1
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (selectedWeapon >= 3)
                selectedWeapon = 0;
            else
                selectedWeapon++;
        }

        // Reduces the selected weapon by 1
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (selectedWeapon <= 0)
                selectedWeapon = 3;
            else
                selectedWeapon--;
        }

        // Sets the animation for the selected weapon
        if(selectedWeapon == 0) {
            m_Animator.SetInteger("Weapon", 0);
        } else if(selectedWeapon == 1) {
            m_Animator.SetInteger("Weapon", 1);
        } else if(selectedWeapon == 2) {
            m_Animator.SetInteger("Weapon", 2);
        } else if(selectedWeapon == 3) {
            m_Animator.SetInteger("Weapon", 3);
        }
    }

}
