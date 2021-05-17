using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthMech : MonoBehaviour
{
    public Slider slider;

    public void SetMaxHealth(float health)
    {
        Debug.Log("set max health");
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(float health)
    {
        slider.value = health;
        Debug.Log("Took Damage");
    }
}
