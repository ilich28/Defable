using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackByPlayer : MonoBehaviour
{
    public int collisionDamage = 25;
    public string collisionTag;
    public bool attacking;


    public void OnCollisionStay2D(Collision2D coll) {
        if (coll.gameObject.tag == collisionTag && Character_Move.isAttacking){
            Health health = coll.gameObject.GetComponent<Health>();
            health.TakeHit(collisionDamage);
        }
    }
    private void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == collisionTag && Character_Move.isAttacking){
            Health health = coll.gameObject.GetComponent<Health>();
            health.TakeHit(collisionDamage);
        }
    }
}
