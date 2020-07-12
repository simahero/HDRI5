using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{

    public EquipmentManager manager;
    public PlayerStat statManager;
    
    public GameObject maskHolder;
    public GameObject weaponHolder;

    public static PlayerLoader instance;

    public GameObject player;

    void Awake() {
        instance = this;
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<EquipmentManager>();
        if (manager.maskSlot != null)
        {
            GameObject mask = Instantiate(manager.maskSlot.prefab, maskHolder.transform.position, maskHolder.transform.rotation);
            mask.transform.SetParent(maskHolder.transform);
            statManager.health.AddModifier(manager.maskSlot.health);
            statManager.armor.AddModifier(manager.maskSlot.armor);
        }

        if (manager.weaponSlot != null)
        {
            GameObject weapon = Instantiate(manager.weaponSlot.prefab, weaponHolder.transform.position, weaponHolder.transform.rotation);
            weapon.transform.SetParent(weaponHolder.transform);
            statManager.damage.AddModifier(manager.weaponSlot.damage);
            statManager.fireRate.AddModifier(manager.weaponSlot.fireRate);
        }

        if(manager.talismanSlot != null){
            statManager.health.AddModifier(manager.talismanSlot.health);
            statManager.damage.AddModifier(manager.talismanSlot.damage);
            statManager.armor.AddModifier(manager.talismanSlot.armor);
            statManager.fireRate.AddModifier(manager.talismanSlot.fireRate);
            statManager.movenentSpeed.AddModifier(manager.talismanSlot.movementSpeed);

        }

    }
    
}
