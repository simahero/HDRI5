using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TlalocController : MonoBehaviour
{
    private Transform player;
    private LaserEye lr1;
    private LaserEye lr2;
    private CharacterStat characterStat;

    private Animator animator;

    public Color enRagedHpBarFill;

    private bool hasEnraged = false;

    public GameObject lasereyefp1;
    public GameObject lasereyefp2;
    public GameObject indicator;
    
    
    void Start(){
        player = GameObject.FindGameObjectWithTag("Player").transform;
    	lr1 = lasereyefp1.GetComponent<LaserEye>();
    	lr2 = lasereyefp2.GetComponent<LaserEye>();
        characterStat = GetComponent<CharacterStat>();
        animator = GetComponent<Animator>();
    }
    
    
    public void setPos(){
        indicator.SetActive(true);
    	lr1.setPos(player.position);
    	lr2.setPos(player.position);
    	Vector3 indicatorV = player.position;
    	indicatorV.y = 0.01f;
    	gameObject.transform.LookAt(player.position);
    	indicator.transform.position = indicatorV;
    }
    
    public void ShootL(){
        indicator.SetActive(false);
    	lr1.Laser();
    	lr2.Laser();
     }
     
    public void stopLaser(){
        lr1.stopLaser();
        lr2.stopLaser();
     }

     void Die(){
         Destroy(gameObject);
     }
     
     void Update(){
         
     }
    
}
