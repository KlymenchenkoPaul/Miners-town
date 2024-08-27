using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoHome2 : MonoBehaviour
{
    [SerializeField] private AudioSource Button01;
    public void GoHome()
    {
        Button01.Play();
        Invoke("Scena", 0.6f);
    }
    public void Scena()
    {
        SceneManager.LoadScene(1);
    }
}
