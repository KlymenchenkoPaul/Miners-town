using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundTrigger : MonoBehaviour
{
    public ZombieSounds zombieSounds;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ZombieIDLESound")
        {
            zombieSounds.zombieIdle.Play();
        }
    }
}
