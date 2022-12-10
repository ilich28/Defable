using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public bool[] isFull;
    public GameObject[] slots;
    public GameObject inventory;
    public GameObject Sword;
    public GameObject Axe;

    static public GameObject[] weapons = new GameObject[2];

    static public string actualWeaponName;
    private bool inventoryOn;
    private bool WeaponOn;
    private void Satrt(){
        inventoryOn = false;
    }
    
    public void Chest(){
        if (inventoryOn == false){
            inventoryOn = true;
            inventory.SetActive(true);
        }
        else if (inventoryOn == true){
            inventoryOn = false;
            inventory.SetActive(false);

        }
    }
     public void Weapon(){
        weapons[0] = Sword;
        weapons[1] = Axe;
        if (Input.GetKeyDown(KeyCode.Alpha1) ){
            for (int i = 0; i<weapons.Length; i++)
                weapons[i].SetActive(false);

            for (int i =0; i < weapons.Length; i++){
                if (Pickup.weaponsInInventory[0]==weapons[i].tag.ToString()){
                    weapons[i].SetActive(true);
                    actualWeaponName = weapons[i].tag.ToString();
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) ){
            for (int i = 0; i<weapons.Length; i++)
                weapons[i].SetActive(false);
                
            for (int i =0; i < weapons.Length; i++){
                if (Pickup.weaponsInInventory[1]==weapons[i].tag.ToString()){
                    weapons[i].SetActive(true);
                    actualWeaponName = weapons[i].tag.ToString();
                }
            }
        }
    }
    void Update(){
        Weapon();
        if (Input.GetKeyDown(KeyCode.I) ){
            if (inventoryOn == false){
                inventoryOn = true;
                inventory.SetActive(true);
            }
            else if(inventoryOn == true){ 
                inventoryOn = false;
                inventory.SetActive(false);
            }

        }
    }
}
