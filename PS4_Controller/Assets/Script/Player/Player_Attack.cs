using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack : MonoBehaviour
{
    public Animator gunAnim;
    public AudioClip attackAudio;
    public float specialAbilityBar;

    AudioSource gunAudio;
    bool canAttack;
    bool specialAbilityOn;

	void Awake ()
    {
        gunAnim = GetComponent<Animator>();

        canAttack = true;

        specialAbilityBar = 0;
    }
	

	void FixedUpdate ()
    {
        if (Input.GetButtonDown("R2") && canAttack == true && specialAbilityOn == false)
        {
            canAttack = false;
            gunAnim.SetBool("Attack", true);
            //add sound
            //damage enemy with raycast
        }
        else if (Input.GetButtonDown("R2") && canAttack == true && specialAbilityOn == true)
        {
            canAttack = false;
            //instantiate the special bullet
            //disable the placeholder bullet
            //change can attack back to true after the reload
            //add sound
        }

        if (Input.GetButtonDown("R1") && Input.GetButtonDown("L1") && specialAbilityBar == 100)
        {
            EnableSpecialAbility();
        }
	}

    public void AllowAttack()
    {
        canAttack = true;
        gunAnim.SetBool("Attack", false);
    }

    public void EnableSpecialAbility()
    {
        // lower spicial ability bar at a rate off 5 points a second = 20 seconds ability
    }
}
