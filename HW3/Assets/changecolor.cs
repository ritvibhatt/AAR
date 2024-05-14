using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour
{
    void OnEnable()
    {
        gotgrabbed.OnGrabbed += changeColor;
        gotgrabbed.OnReleased += changeColorBack;
    }
    void OnDisable()
    {
        gotgrabbed.OnGrabbed -= changeColor;
        gotgrabbed.OnReleased -= changeColorBack;
    }
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.blue;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void changeColor()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    void changeColorBack()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
}
