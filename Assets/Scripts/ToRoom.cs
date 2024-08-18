using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToRoom : MonoBehaviour
{
    [SerializeField] private AudioSource button01;
    public void ToRoom1()
    {
        button01.Play();
        Invoke("Scena01", 0.6f);
    }

    public void ToRoom2()
    {
        button01.Play();
        Invoke("Scena02", 0.6f);
    }

    public void Scena01()
    {
        SceneManager.LoadScene(2);
    }

    public void Scena02()
    {
        SceneManager.LoadScene(1);
    }
}
