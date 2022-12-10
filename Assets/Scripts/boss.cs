using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    public Rigidbody2D EnemyRigibody;
    public float bossSpeed = 3.0f;
    private int j = 0;
    private Vector3 bossTempvector;
    private SpriteRenderer bossSprite;
    private void Start(){
        
        bossSprite = GetComponentInChildren<SpriteRenderer>();
    }
    void BossMove() {
        
        j++;
        if (j%2000<1000){
            bossTempvector = Vector3.left;  
            transform.position = Vector3.MoveTowards(transform.position, transform.position + bossTempvector, 3.0f * Time.deltaTime);
            bossSprite.flipX = false;
            
        }
        else if (j%2000>=1000){
            bossTempvector = Vector3.right;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + bossTempvector, 3.0f * Time.deltaTime); 
            bossSprite.flipX = true;
        }



         
    }
    void Update()
    {
        BossMove();
    }
}
