using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorIsLavaTriggers : MonoBehaviour
{
    public GameObject FloorIsLavaPath;

    private void OnTriggerEnter(Collider other)
    {
        FloorIsLavaPath.GetComponent<FloorIsLava>().inRoom = false;
    }
}
