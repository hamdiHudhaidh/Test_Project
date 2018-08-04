using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack : MonoBehaviour
{
    public Animator gunAnim;
    public AudioClip attackAudio;

    AudioSource gunAudio;
    bool canAttack;

	void Awake ()
    {
        gunAnim = GetComponent<Animator>();

        canAttack = true;
    }
	

	void Update ()
    {
        if (Input.GetButtonDown("R2") && canAttack == true)
        {
            print("pushed");
            canAttack = false;
            gunAnim.SetBool("Attack", true);
            //add sound
            //damage enemy with raycast
        }
	}

    public void AllowAttack()
    {
        canAttack = true;
        gunAnim.SetBool("Attack", false);
    }
}
