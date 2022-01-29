using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorToggle : MonoBehaviour
{

    private bool open = false;
    public bool isMirrored;

    private float xTranslate;

    private void Start()
    {
        xTranslate = isMirrored ? 1.4f : -1.4f;
    }

    public void ToggleDoor()
    {
        if (!open)
        {
            transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
            transform.Translate(1.4f, 0f, -1.2f);
            open = true;
        }
    }
    
}
