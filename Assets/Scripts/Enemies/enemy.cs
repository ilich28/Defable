using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Rigidbody2D EnemyRigibody;
    public float enemySpeed = 2.0f;
    private int i = 0;
    private Vector3 tempvector;
    private SpriteRenderer enemySprite;
    private void Awake(){
        
        enemySprite = GetComponentInChildren<SpriteRenderer>();
    }
    void Move() {
        
        i++;
        if (i%2000<1000){
            tempvector = Vector3.left;  
            transform.position = Vector3.MoveTowards(transform.position, transform.position + tempvector, enemySpeed * Time.deltaTime);
            enemySprite.flipX = false;
            
        }
        else if (i%2000>=1000){
            tempvector = Vector3.right;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + tempvector, enemySpeed * Time.deltaTime); 
            enemySprite.flipX = true;
        }


    


     
       
    
         
    }
    void Update()
    {
        Move();
    }
}
