using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : Interactable
{

    public Item item;
    public override void Interact(){

        base.Interact();
        Debug.Log(item.name);
        //add to inv
        if(Inventory.instance.Add(item)){
        Destroy(gameObject);
        }

    }

}