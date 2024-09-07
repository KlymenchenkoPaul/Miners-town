using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float dirX, dirY;
    public float speed;
    public Joystick joystick;
    private Rigidbody rb;
    public Animator animator;
    public GameObject Axebutton;
    public GameObject AxeinHand;
    public GameObject KirkainHand;
    [SerializeField] AudioSource AxeSound;

    void Start()
    {
        Initialization();
    }

    void Update()
    {
        Movement();
    }

    private void FixedUpdate()
    {
        ChangeAnimation();
        ChangeDirection();
        Direction();
    }

    public void AxlePlayer()
    {
        animator.SetBool("Hero_Wood", true);
        Invoke("soundAxe", 0.2f);
        Axebutton.SetActive(false);
        Invoke("buttonAxe", 0.6f);
        Invoke("offAxlePlayer", 0.4f);
    }

    private void buttonAxe()
    {
        Axebutton.SetActive(true);
    }
    private void soundAxe()
    {
        AxeSound.Play();
    }

    private void offAxlePlayer()
    {
        animator.SetBool("Hero_Wood", false);
    }

    private void ChangeAnimation()
    {
        if (joystick.Horizontal !=0)
        {
            animator.SetBool("Hero_Walk", true);
            animator.SetBool("Hero_Wood", false);
            AxeinHand.SetActive(false);
            KirkainHand.SetActive(false);
        }
        else
        {
            animator.SetBool("Hero_Walk", false);
        }
    }

    private void ChangeDirection()
    {
        Vector3 directionVector = new Vector3(joystick.Horizontal * speed, 0, joystick.Vertical * speed);
        if (directionVector.magnitude > Mathf.Abs(0.05f))
            transform.rotation = Quaternion.LookRotation(directionVector);
    }

    private void Direction()
    {
        rb.velocity = new Vector3(joystick.Horizontal*speed, 0, joystick.Vertical*speed);
    }

    private void Initialization()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    private void Movement()
    {
        dirX = joystick.Horizontal*speed;
        dirY = joystick.Vertical*speed;
    }

    public void AxetoHand()
    {
        KirkainHand.SetActive(false);
        AxeinHand.SetActive(true);
    }

    public void KirkatoHand()
    {
        AxeinHand.SetActive(false);
        KirkainHand.SetActive(true);
    }

}
