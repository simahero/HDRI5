using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public static Inventory instance;

    void Awake() {
        if (instance != null){
            Debug.Log("More that 1 inventory.");
            return;
        }
        instance = this;
    }


    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public List<Item> items = new List<Item>();

    public List<Item> weapons = new List<Item>();
    public List<Item> masks = new List<Item>();
    public List<Item> talismans = new List<Item>();

    public bool Add(Item item){
        if (item is Weapon){
            weapons.Add(item);
        } else if (item is Mask){
            masks.Add(item);
        } else {
            talismans.Add(item);
        }

        if(onItemChangedCallback != null)
            {
                onItemChangedCallback.Invoke();
            }
            return true;
        
    }

    public void Remove(Item item){
        if (item is Weapon){
            weapons.Remove(item);
        } else if (item is Mask){
            masks.Remove(item);
        } else {
            talismans.Remove(item);
        }

        if(onItemChangedCallback != null){
        onItemChangedCallback.Invoke();
        }
    }

}