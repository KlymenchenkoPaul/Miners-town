using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataResurces : MonoBehaviour
{
    public static int wood;
    public Text TextWood;

    public static int rock;
    public Text TextRock;

    public static int coin;
    public Text TextCoin;

    void Start()
    {
        wood = PlayerPrefs.GetInt("Wood", wood);
        coin = PlayerPrefs.GetInt("Coin", coin);
        rock = PlayerPrefs.GetInt("Rock", rock);
        TextWood.text = wood.ToString();
        TextCoin.text = coin.ToString();    
        TextRock.text = rock.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wood_res")
        {
            wood += 1;
            PlayerPrefs.SetInt("Wood", wood);
            TextWood.text = wood.ToString();
        }

        if (other.gameObject.tag == "Rock_res")
        {
            rock += 1;
            PlayerPrefs.SetInt("Rock", rock) ;
            TextRock .text = rock.ToString();
        }
    }
}
