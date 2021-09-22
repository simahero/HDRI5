using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

public GameObject player;
public float h = 12f;
public float b = 13f;

    void  Start(){
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 pos = player.transform.position;
        pos.y += h;
        pos.z -= b;
        transform.position = pos;
    }
}
