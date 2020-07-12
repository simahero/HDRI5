using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NyamcarLaser : MonoBehaviour
{

    private LineRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        renderer.SetPosition(0, transform.position);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider)
            {
                renderer.SetPosition(1, hit.point);
            }
            
        }
        else 
            {
                renderer.SetPosition(1, transform.forward*5000);
            }
    }
}
