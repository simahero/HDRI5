using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

	public float damage;
	public GameObject owner;
	private CharacterStat characterStat;

	public void setOwner(GameObject owner){
		this.owner = owner;
	}

    void OnTriggerEnter (Collider coll){
		characterStat = coll.GetComponent<CharacterStat>();
		damage = owner.transform.GetComponent<CharacterStat>().damage.GetValue();
 		if (characterStat != null){
 			characterStat.TakeDamage(damage);
 			Destroy(gameObject);
 		} else {
 	 	Destroy(gameObject, 2f);
 		}
    }
}
