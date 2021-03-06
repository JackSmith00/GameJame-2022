using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKey : MonoBehaviour
{
    [HideInInspector] public bool inTrigger;

    public GameObject mirroredKey;

    private void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }
    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

    private void Update()
    {
        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                DoorScript.doorKey = true;
                if(GetComponentInParent<AudioSource>() != null)
                {
                    GetComponentInParent<AudioSource>().Play();
                }
                this.gameObject.SetActive(false);
                mirroredKey.SetActive(false);
            }
        }
    }

    private void OnGUI()
    {
        if (inTrigger)
        {
            GUI.Box(new Rect(0, 0, 200, 25), "Press E to pick up key");
        }
    }
}
