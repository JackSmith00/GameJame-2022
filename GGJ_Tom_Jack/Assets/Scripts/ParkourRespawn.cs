using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkourRespawn : MonoBehaviour
{
    public GameObject player;
    public GameObject mirroredPlayer;

    public bool hasFallen;

    private void OnTriggerEnter(Collider other)
    {
        hasFallen = true;
        GetComponent<AudioSource>().Play();
    }

    private void LateUpdate()
    {
        if (hasFallen)
        {
            player.transform.position = new Vector3(-7.4f, 1.148f, -10.201f);
            mirroredPlayer.transform.position = new Vector3(-7.4f, 1.148f, 0.06183147f);
            hasFallen = false;
        }
    }
}
