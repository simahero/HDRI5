using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{

    public Mask maskSlot;
    public Weapon weaponSlot;
    public Talisman talismanSlot;
    private Inventory inventory;
    public Item i1;
    public Item i2;

    public static EquipmentManager Instance {
        get;
        set;
    }

    void Awake() {
        Instance = this;
        inventory = Inventory.instance;
        DontDestroyOnLoad(transform.gameObject);    
    }

    void Start(){
        bool c = inventory.Add(i1);
        bool d = inventory.Add(i2);
        if(c){
            Debug.Log("Added 1");
        } else {
            Debug.Log("Error 1");
        }
        if (d){
            Debug.Log("Added 2");
        } else {
            Debug.Log("Error 1");
        }
    }

    public void Equip(Item item){
        if(item is Weapon){
            inventory.Add(weaponSlot);
            inventory.Remove(item);
            weaponSlot = (Weapon)item;

        } else if (item is Mask){
            inventory.Add(maskSlot);
            inventory.Remove(item);
            maskSlot = (Mask)item;

        } else if (item is Talisman){
            inventory.Add(talismanSlot);
            inventory.Remove(item);
            talismanSlot = (Talisman)item;
        }
    }

}
