using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Miner : MonoBehaviour
{
    [SerializeField] private AudioSource dig;
    public static int coins;
    public Text TextCoins;
    public Animator animator;
    public Stamina st;



    public GameObject bottonhome;
    public GameObject bottonmine;


    void Start()
    {
        coins = PlayerPrefs.GetInt("Coin", coins);
        TextCoins.text = coins.ToString();
        animator = GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            coins += 2;
            MoneyDigRes.coinsHome +=2;
            PlayerPrefs.SetInt("Coin", coins);
            dig.Play();
            st.stamina -=5;
            st.stvalue.text = st.stamina.ToString();
            TextCoins.text = coins.ToString();
        }
    }


    public void Dig1()
    {
        animator.SetBool("DigOn", true);
        bottonhome.SetActive(false);
    }

    public void Dig2()
    {
        animator.SetBool("DigOn", false);
        bottonhome.SetActive(true);
    }
}
