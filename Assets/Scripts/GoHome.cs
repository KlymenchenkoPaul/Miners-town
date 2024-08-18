using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoHome : MonoBehaviour
{
    public float speed = 3f;
    public Transform go;
    public Transform go2;

    public GameObject kirka;


    public bool gotohome;
    public bool gotomine;

    public int casio;

    public GameObject camerahome;
    public GameObject camerago;
    public GameObject maincamera;

    public GameObject bottondigstart;
    public GameObject bottondigoff;

    public GameObject trigcamhome;
    public GameObject trigcamend;
    public GameObject trigcamstart;

    public GameObject animoff;

    public Miner mr;

    private void FixedUpdate()
    {
        if (gotohome == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, go.position, speed * Time.fixedDeltaTime);

        }
        if (gotomine == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, go2.position, speed * Time.fixedDeltaTime);

        }
    }
    public void Home()
    {
        gotohome = false;
        gotomine = false;
        maincamera.SetActive(false);
        camerago.SetActive(true);
        trigcamhome.SetActive(true);
        trigcamend.SetActive(false);
        trigcamstart.SetActive(false);
        mr.bottonhome.SetActive(false);
        bottondigoff.SetActive(false);
        bottondigstart.SetActive(false);
        kirka.SetActive(false);
        animoff.SetActive(false);
        mr.animator.SetBool("Walk", true);

    }

    public void Mine()
    {
        casio = 1;
        gotomine = false;
        gotohome = false;
        trigcamhome.SetActive(false);
        trigcamend.SetActive(true);
        trigcamstart.SetActive(true);
        mr.animator.SetBool("Walk", true);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "HomeDoor")
        {
            camerago.SetActive(false);
            camerahome.SetActive(true);

        }
        if(other.gameObject.tag == "OutDoor")
        {
            camerago.SetActive(true);
            camerahome.SetActive(false);

        }
        if (other.gameObject.tag == "MineDoor")
        {
            camerago.SetActive(false);
            maincamera.SetActive(true);
            mr.bottonhome.SetActive(true);
            bottondigoff.SetActive(true);
            bottondigstart.SetActive(true);
            kirka.SetActive(true);
            animoff.SetActive(true);


        }
        if (other.gameObject.tag == "AnimOff")
        {
            mr.animator.SetBool("Walk", false);
        }
    }
}
