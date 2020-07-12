using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalismanInventoryUI : MonoBehaviour
{
    Inventory inventory;
    public Transform parent;
    InventorySlot[] slots;
    public Item item;

    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;
        slots = parent.GetComponentsInChildren<InventorySlot>();
    }


    void UpdateUI(){
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.talismans.Count)
            {
                //slots[i].SetActive(true);
                slots[i].AddItem(inventory.talismans[i]);
            } else {
                slots[i].clearSlot();
            }
        }
    }
}
