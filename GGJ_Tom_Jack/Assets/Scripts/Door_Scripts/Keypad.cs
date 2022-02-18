using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    public string currentPassword = "3461";

    public string input;

    public bool onTrigger;
    public bool keypadScreen;
    public bool doorOpened;
    public Transform DoorHinge_2;

    public AudioClip completionSound;
    private bool soundPlayed = false;

    void OnTriggerEnter(Collider keypad)
    {
        onTrigger = true;
    }

    private void OnTriggerExit(Collider keypad)
    {
        onTrigger = false;
        keypadScreen = false;
        input = "";
    }

    private void Update()
    {
        if (input == currentPassword)
        {
            doorOpened = true;
            if(GetComponent<AudioSource>() != null && !soundPlayed)
            {
                GetComponent<AudioSource>().clip = completionSound;
                GetComponent<AudioSource>().Play();
                soundPlayed = true;
            }
        }
        if (doorOpened)
        {
            var newRotation = Quaternion.RotateTowards(DoorHinge_2.rotation, Quaternion.Euler(0.0f, -85.0f, 0.0f), Time.deltaTime * 250);
            DoorHinge_2.rotation = newRotation;
        }
    }

    private void OnGUI()
    {
        if (onTrigger)
        {
            GUI.Box(new Rect(0, 0, 200, 25), "Press 'E' to open keypad");

            if (Input.GetKeyDown(KeyCode.E))
            {
                keypadScreen = true;
                onTrigger = false;
                GetComponent<InteractionSound>().PlayInteractionSound();
            }
        }

        if (keypadScreen)
        {
            if (!doorOpened)
            {
                GUI.Box(new Rect(0, 0, 320, 455), "");
                GUI.Box(new Rect(5, 5, 310, 25), input);

                if (GUI.Button(new Rect(5, 35, 100, 100), "1"))
                {
                    Debug.Log("Hit 1");
                    input = input + "1";
                }

                if (GUI.Button(new Rect(110, 35, 100, 100), "2"))
                {
                    Debug.Log("Hit 2");
                    input = input + "2";
                }

                if (GUI.Button(new Rect(215, 35, 100, 100), "3"))
                {
                    Debug.Log("Hit 3");
                    input = input + "3";
                }

                if (GUI.Button(new Rect(5, 140, 100, 100), "4"))
                {
                    Debug.Log("Hit 4");
                    input = input + "4";
                }

                if (GUI.Button(new Rect(110, 140, 100, 100), "5"))
                {
                    Debug.Log("Hit 5");
                    input = input + "5";
                }

                if (GUI.Button(new Rect(215, 140, 100, 100), "6"))
                {
                    Debug.Log("Hit 6");
                    input = input + "6";
                }
                if (GUI.Button(new Rect(5, 245, 100, 100), "7"))
                {
                    Debug.Log("Hit 7");
                    input = input + "7";
                }

                if (GUI.Button(new Rect(110, 245, 100, 100), "8"))
                {
                    Debug.Log("Hit 8");
                    input = input + "8";
                }

                if (GUI.Button(new Rect(215, 245, 100, 100), "9"))
                {
                    Debug.Log("Hit 9");
                    input = input + "9";
                }

                if (GUI.Button(new Rect(110, 350, 100, 100), "0"))
                {
                    Debug.Log("Hit 0");
                    input = input + "0";
                }
            }
        }
    }
}
