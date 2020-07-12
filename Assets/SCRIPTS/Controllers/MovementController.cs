using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{

public Joystick jm;
public Joystick jf;
public float speed = 20f;
public Rigidbody rb;
public CharacterController controller;
private Vector3 moveDirection;

    void FixedUpdate()
    {
    	moveDirection = new Vector3(jm.Horizontal, 0.0f, jm.Vertical);
        moveDirection *= speed;
        controller.Move(moveDirection * Time.deltaTime);

        
        float xf = jf.Horizontal;
 	float yf = jf.Vertical;
 	
 	float xm = jm.Horizontal;
 	float ym = jm.Vertical;
 	
 	float angle;
 	
 	if (xf == 0 && yf == 0){
 		angle = Mathf.Atan2(ym, xm) * Mathf.Rad2Deg;
 		angle -= 90;
 	} else {
        	angle = Mathf.Atan2(yf, xf) * Mathf.Rad2Deg;
        	angle -= 90;
        }
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, -angle, transform.eulerAngles.z);

    }
}
