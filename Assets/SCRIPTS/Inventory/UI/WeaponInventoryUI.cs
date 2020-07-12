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
        inventory.onItemChangedCallback += UpdateUI;
        slots = parent.GetComponentsInChildren<InventorySlot>();
    }

    void UpdateUI(){
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
