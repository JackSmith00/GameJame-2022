using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSound : MonoBehaviour
{

    public AudioClip[] clips;

    public void PlayInteractionSound()
    {
        // set the audio clip to a random sound from the array
        if(GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().clip = clips[Random.Range(0, clips.Length)];
            GetComponent<AudioSource>().Play();
        }
    }

}
