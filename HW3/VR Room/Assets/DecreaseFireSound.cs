using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Add this line to access UI components


public class DecreaseFireSound : MonoBehaviour
{
    // Start is called before the first frame update
public AudioSource fireplaceAudioSource;
    public float volumeDecreaseAmount = 0.1f; // The amount to decrease the volume by each click
    private Button fireButton;

    void Start()
    {
        // Get the Button component attached to this GameObject
        fireButton = GetComponent<Button>();

        // Ensure the button and audio source are assigned
        if (fireButton == null)
        {
            Debug.LogError("Fire button is not assigned!");
            return;
        }
        if (fireplaceAudioSource == null)
        {
            Debug.LogError("AudioSource is not assigned!");
            return;
        }

        // Add a listener to the button to call DecreaseVolume when clicked
        fireButton.onClick.AddListener(DecreaseVolume);
    }

    void DecreaseVolume()
    {
        if (fireplaceAudioSource != null)
        {
            fireplaceAudioSource.volume = Mathf.Max(0, fireplaceAudioSource.volume - volumeDecreaseAmount);
            Debug.Log("Volume Decreased: " + fireplaceAudioSource.volume);
        }
    }
}
