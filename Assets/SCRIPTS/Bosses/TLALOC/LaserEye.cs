using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserEye : MonoBehaviour
{

public LineRenderer lr;
public Transform fp;
private Vector3 target;
public GameObject effect;
public ParticleSystem exploison;

public float damage = 100f;


public void setPos(Vector3 pos){
	target = pos;
	
}

public void Laser(){
	fp.transform.LookAt(target);
	lr.enabled = true; 
	lr.SetPosition(0, fp.position);
	target.y = 0;
	lr.SetPosition(1, target);
	effect.transform.position = target;
	effect.SetActive(true);
	exploison.Play();
	RaycastHit hit;


	if (Physics.Raycast(fp.position, fp.forward, out hit))
	{	
		PlayerStat player = hit.transform.GetComponent<PlayerStat>();
		if (player != null)
		{
			player.TakeDamage(damage);
		}	
	}

	Debug.DrawRay(fp.position, fp.forward, Color.white);

}

public void stopLaser(){
	lr.enabled = false; 
}


}
