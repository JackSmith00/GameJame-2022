using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLighting : MonoBehaviour
{

    public GameObject SpotLightObject;

    private void Start()
    {
        SpotLightObject.active = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FirstPersonPlayer")
        {
            SpotLightObject.active = true;
        }
    }
}
