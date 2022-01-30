using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorIsLava : MonoBehaviour
{
    public GameObject player;
    public GameObject reflection;

    [HideInInspector] public bool inRoom = false;

    private void OnCollisionEnter(Collision collision)
    {
        inRoom = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (inRoom) // if they leave the path in the room
        {
            player.transform.position = new Vector3(-5.812823f, 0.8099499f, -10.48899f);
            reflection.transform.position = new Vector3(-5.431764f, 3.596092f, 0.2098336f);
            GetComponent<AudioSource>().Play();
        }
    }
}
