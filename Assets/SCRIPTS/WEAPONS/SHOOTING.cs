using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHOOTING : MonoBehaviour
{
   public Transform firepoint;
   public GameObject prefab;
   public Joystick joy;
   public float bulletforce = 20f;
   public float fr = 1;
   private float nextFire = 0f;
   

    // Update is called once per frame
    void Update()
    {
  
        if (joy.Horizontal != 0 && joy.Vertical != 0 && Time.time > nextFire){
		nextFire = Time.time + fr;
        	Shoot();

        
        }
    }
    
     void Shoot(){
    	GameObject bullet = Instantiate(prefab, firepoint.position, firepoint.rotation);
        bullet.GetComponent<Bullet>().setOwner(firepoint.root.gameObject);
    	Rigidbody rb = bullet.GetComponent<Rigidbody>();
    	rb.AddForce(firepoint.forward * bulletforce, ForceMode.Impulse);
    }
    
}
