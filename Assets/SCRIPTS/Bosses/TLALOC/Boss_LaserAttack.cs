using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_LaserAttack : StateMachineBehaviour
{
    public float speed = 2.5f;
	public float minDist = 20f;
	public float maxDist = 100f;	
	
	Transform player;
	Transform boss;
	Rigidbody rb;	
	
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        boss = animator.GetComponent<Transform>();
        rb = animator.GetComponent<Rigidbody>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    	Vector3 lookPos = player.position - boss.position;
    	lookPos.y = 0;
    	Quaternion rotation = Quaternion.LookRotation(lookPos);
    	boss.rotation = Quaternion.Slerp(boss.rotation, rotation, Time.deltaTime * 2);
        if (Vector3.Distance(boss.position, player.position) >= minDist){
        	boss.position += boss.forward * speed * Time.deltaTime;
        }
        
        if (Vector3.Distance(boss.position, player.position) <= maxDist){
        	//attack
        }
        
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("DoLaser", false);
    }
}
