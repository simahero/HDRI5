using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionText : MonoBehaviour
{
    
public string Paneltext = "Add a text here";
public Text txt;
public GameObject panel;

   void OnTriggerEnter(Collider collision){
 	   panel.SetActive(true);
 	   txt.text = Paneltext;
 	 	  Debug.Log("tigger!");
    }
    
   void OnTriggerExit(Collider collision){
 	   panel.SetActive(false);
    }
}
