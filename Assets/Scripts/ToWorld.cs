using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToWorld : MonoBehaviour
{
    [SerializeField] private AudioSource button01;
    public void ToW()
    {
        button01.Play();
        Invoke("Scena", 0.6f);
    }

    public void Scena()
    {
        SceneManager.LoadScene(0);
    }
}
