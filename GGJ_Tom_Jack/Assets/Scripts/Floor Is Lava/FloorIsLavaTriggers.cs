using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorIsLavaTriggers : MonoBehaviour
{
    public GameObject FloorIsLavaPath;

    private bool soundPlayed;

    private void OnTriggerEnter(Collider other)
    {
        FloorIsLavaPath.GetComponent<FloorIsLava>().inRoom = false;
        if(GetComponent<AudioSource>() != null && !soundPlayed)
        {
            GetComponent<AudioSource>().Play();
            soundPlayed = true;
        }
    }
}
