using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{

    public Mask maskSlot;
    public Weapon weaponSlot;
    public Talisman talismanSlot;

    public static EquipmentManager Instance {
        get;
        set;
    }

    void Awake() {
        Instance = this;    
        DontDestroyOnLoad(transform.gameObject);    
    }

}
