using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    private Transform player;
    private void Start(){
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
   
    public void SpawnDroppedItem(){
        
        Vector2 playerPos = new Vector2(player.position.x+2*Character_Move.moveRight ,player.position.y-4);
        Instantiate(item,playerPos,Quaternion.identity);
    }
    
}
