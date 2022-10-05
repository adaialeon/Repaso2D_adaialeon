using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundchecker : MonoBehaviour
{
    public Player Elfa; 


    void Awake()
    {
        Elfa = GameObject.Find("Elfa").GetComponent<Player>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Elfa._animator.SetBool("Saltar", false);
        Elfa.isGorounded = true;
    }


    void OnTriggerStay2D(Collider2D col)
    {
        Elfa.isGorounded = true;
        
    }

    void OnTriggerExit2D(Collider2D col)

    {
        Elfa.isGorounded = false;
    }
}