using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyDigRes : MonoBehaviour
{
    public static int coinsHome;
    public Text TextCoins;

    public void Start()
    {
        coinsHome = PlayerPrefs.GetInt("Coin2", coinsHome);
        TextCoins.text = coinsHome.ToString();

    }
}

