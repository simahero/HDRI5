using UnityEngine;

public class InventoryUI : MonoBehaviour
{

    Inventory inventory;
    public Transform parent;
    InventorySlot[] slots;
    
    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;
        slots = parent.GetComponentsInChildren<InventorySlot>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateUI(){
        Debug.Log("asd");
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            } else {
                slots[i].clearSlot();
            }
        }
    }
}
