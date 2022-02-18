using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMirrorVisibility : MonoBehaviour
{
    public GameObject mirror;
    public GameObject roomKey;
    public GameObject mirroredKey;

    public Material mirrorMaterial;
    public Material foggedMaterial;

    private bool inTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

    /// <summary>
    /// Change the current material used my the mirror
    /// </summary>
    public void ToggleMirrorMaterial()
    {
        if(mirror.GetComponent<MeshRenderer>().material == mirrorMaterial)
        {
            mirror.GetComponent<MeshRenderer>().material = foggedMaterial;
        }
        else
        {
            mirror.GetComponent<MeshRenderer>().material = mirrorMaterial;
        }
    }

    private void OnGUI()
    {
        if (inTrigger)
        {
            GUI.Box(new Rect(0, 0, 200, 25), "Press E to interact");
        }
    }

    void Update()
    {
        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ToggleMirrorMaterial();
                GetComponent<InteractionSound>().PlayInteractionSound();
                if (roomKey != null)
                {
                    roomKey.SetActive(true);
                }
                if (mirroredKey != null)
                {
                    mirroredKey.SetActive(true);
                }
            }
        }
    }
}
