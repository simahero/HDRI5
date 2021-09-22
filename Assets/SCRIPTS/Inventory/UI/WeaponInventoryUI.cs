using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInventoryUI : MonoBehaviour
{
    Inventory inventory;
    public Transform parent;
    InventorySlot[] slots;

    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateWeaponUI;
        slots = parent.GetComponentsInChildren<InventorySlot>();
        UpdateWeaponUI();
    }

    void UpdateWeaponUI(){
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.weapons.Count)
            {
                //slots[i].SetActive(true);
                slots[i].AddItem(inventory.weapons[i]);
            } else 
            {
                slots[i].clearSlot();
            }
        }
    }
}
