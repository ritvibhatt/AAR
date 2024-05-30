using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip keySound;
    private void PlaySound()
    {
        audioSource.clip = keySound;
        audioSource.Play();
    }
}
