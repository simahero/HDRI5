using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Weapon")]
public class Weapon : Item
{
    public GameObject prefab;

    public float damage;
    public float fireRate;

}
