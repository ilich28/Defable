using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword1 : MonoBehaviour
{


    public Animator CharAnimator;

    public SpriteRenderer Sword;

    private void Awake() {
        
        CharAnimator = GetComponentInChildren<Animator>();
   
        Sword = GetComponentInChildren<SpriteRenderer>();

    }




   


    void Update()
    {
       
        if (Input.GetButton("Horizontal"))
        {
        
            CharAnimator.SetInteger("State1", 1);
        }
        else {
            CharAnimator.SetInteger("State1", 0);
                }
        
    }
}
