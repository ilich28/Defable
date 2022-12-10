using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
 private Inventory inventory;
 public int i;
 private void Start(){
    inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
     }

private void Update(){
    if(transform.childCount<=0){
        inventory.isFull[i]= false;
    }
    
}
public void DropItem(){
 
    if (Pickup.weaponsInInventory[i]==Inventory.actualWeaponName){
        for (int i=0; i<Inventory.weapons.Length; i++){
            if (Inventory.actualWeaponName==Inventory.weapons[i].tag.ToString())
                Inventory.weapons[i].SetActive(false);
        }
    }
    
    inventory.isFull[i]=false;
    Pickup.weaponsInInventory[i]=string.Empty;
    foreach(Transform child in transform){

        child.GetComponent<Spawn>().SpawnDroppedItem();
        GameObject.Destroy(child.gameObject);
        
        
        //Если в игре появилось название оружие с буквы I - идите нахуй!!!!
    }
}
}

