using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
   public Transform firepoint;
   public GameObject prefab;
   public float bulletforce = 20f;
   

    public void Shoot(){
    	GameObject bullet = Instantiate(prefab, firepoint.position, firepoint.rotation);
    	Rigidbody rb = bullet.GetComponent<Rigidbody>();
    	rb.AddForce(firepoint.forward * bulletforce, ForceMode.Impulse);
    }

}
