using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public static bool doorKey;
    private bool open;
    private bool close = true;
    public bool inTrigger;
    public bool isMirroredDoor = false;

    private float rotation;

    private void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

    private void Start()
    { 
        if (isMirroredDoor)
        {
            rotation = -90.0f;
        }
        else
        {
            rotation = 90.0f;
        }
    }

    void Update()
    {
        if (inTrigger)
        {
            if (close)
            {
                if (doorKey)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        open = true;
                        close = false;

                    }
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    open = false;
                    close = true;

                }
            }
        }


        if (inTrigger)
        {
            if (open)
            {
           
                var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, rotation, 0.0f), Time.deltaTime * 200);

                transform.rotation = newRot;
            }
            else
            {
                var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f), Time.deltaTime * 200);

                transform.rotation = newRot;
            }
        }
    }

    private void OnGUI()
    {
        if (inTrigger)
        {
            if (open)
            {
                GUI.Box(new Rect(0, 0, 200, 25), "Press E to Open");
            }
            else
            {
                if (doorKey)
                {
                    GUI.Box(new Rect(0, 0, 200, 25), "Press E to Open");
                }
                else
                {
                    GUI.Box(new Rect(0, 0, 200, 25), "This door is locked, You need a key!!!");
                }
            }
        }
    }
}
