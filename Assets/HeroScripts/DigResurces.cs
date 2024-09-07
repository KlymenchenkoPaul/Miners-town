using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigResurces : MonoBehaviour
{
    public GameObject PanelPlayer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wood")
        {
            PanelPlayer.SetActive(true);
        }

        if (other.gameObject.tag == "Rock")
        {
            PanelPlayer.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Wood")
        {
            PanelPlayer.SetActive(false);
        }

        if (other.gameObject.tag == "Rock")
        {
            PanelPlayer.SetActive(false);
        }
    }
}
