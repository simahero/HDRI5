using UnityEngine;
using UnityEngine.UI;


public class InventorySlot : MonoBehaviour
{
    private EquipmentManager manager;
    private PlayerLoader loader;
    private Button slotButton;
    public Image icon;
    public Item item;

    void Start(){
        manager = EquipmentManager.Instance;
        loader = PlayerLoader.instance;
        slotButton = GetComponent<Button>();
        slotButton.onClick.AddListener(EquipItem);
    }

    public void AddItem(Item newitem){
        item = newitem;
        icon.sprite = item.icon;
        icon.enabled = true;
    }

    public void clearSlot(){
        item = null;
        icon.sprite = null;
        icon.enabled = false;
    }

    public void EquipItem(){
        loader.RemoveModifiers();
        manager.Equip(item);
        loader.UpdatePlayer();
    }
}
