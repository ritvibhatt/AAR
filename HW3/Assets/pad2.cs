using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pad2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        gotgrabbed.OnGrabbed += Activate;
        gotgrabbed.OnReleased += Deactivate;
    }

    void OnDisable()
    {
        gotgrabbed.OnGrabbed -= Activate;
        gotgrabbed.OnReleased -= Deactivate;
    }

    void Activate()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
    }

    void Deactivate()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }
}
