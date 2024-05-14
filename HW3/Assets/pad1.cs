using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class pad1 : MonoBehaviour
{
    void OnEnable()
    {
        gotgrabbed.OnGrabbed += Deactivate;
        gotgrabbed.OnReleased += Activate;
    }

    void OnDisable()
    {
        gotgrabbed.OnGrabbed -= Deactivate;
        gotgrabbed.OnReleased -= Activate;
    }
    // Start is called before the first frame update

    void Deactivate()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    void Activate()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
    }
}
