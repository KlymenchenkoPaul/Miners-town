using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Stamina : MonoBehaviour
{
    public float stamina;
    public float maxStamina = 100f;
    public Text stvalue;
    public Miner mnr;

    private void Start()
    {
        stamina = maxStamina;
    }
    private void Update()
    {
        if (stamina <= 0)
        {
            mnr.Dig2();
        }
        if (stamina == maxStamina)
        {
            mnr.bottonhome.SetActive(false);
            mnr.bottonmine.SetActive(true);
        }
        else
        {
            mnr.bottonmine.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "staminka")
        {
            mnr.animator.SetBool("Walk", false);
            Invoke("Stan", 3f);
        }

    }

    public void Stan()
    {
        stamina += 100f;
        stvalue.text = stamina.ToString();
    }
}
