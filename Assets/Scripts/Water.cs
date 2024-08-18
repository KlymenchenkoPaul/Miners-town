using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Water : MonoBehaviour
{
    public static int waterpoint;
    public Text TextWater;

    private void Start()
    {
        waterpoint = PlayerPrefs.GetInt("Water2", waterpoint);
        TextWater.text = waterpoint.ToString();
    }

    void Update()
    {
        
    }

    public void TakeWater()
    {
        waterpoint += 15;
        PlayerPrefs.GetInt("Water2", waterpoint);
    }    
}
