using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    
    public void SetMaxHp(float hp){
    	slider.maxValue = (int)hp;
    	slider.value = hp;
    }
    
    public void SetHp(float hp){
    	slider.value = (int)hp;
    }
}
