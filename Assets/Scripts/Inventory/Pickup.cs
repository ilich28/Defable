using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
 private Inventory inventory;
 public GameObject slotButtton;

 static public string[] weaponsInInventory = new string[4];
 private void Start(){
    inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
     }
private void OnTriggerEnter2D(Collider2D other){
     if(other.CompareTag("Player")){
        for (int i = 0 ; i < inventory.slots.Length; i++){
            if(inventory.isFull[i]== false){
                inventory.isFull[i] = true;
                Instantiate(slotButtton, inventory.slots[i].transform);
                weaponsInInventory[i] = gameObject.tag.ToString();
                Destroy(gameObject);
                break;
            }
        }
     }
}
}
