using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.Interaction.Toolkit;
public class gotgrabbed : MonoBehaviour
{
    private XRGrabInteractable graInteractable;
    public delegate void Grabbed();
    public static event Grabbed OnGrabbed;
    public delegate void Released();
    public static event Released OnReleased;


    private bool grabbed  = false;
    // Start is called before the first frame update
    void Start()
    {
        graInteractable = GetComponent<XRGrabInteractable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (graInteractable.isSelected)
        {
            if (!grabbed)
            {
                grabbed = true;
                Debug.Log("Grabbed");
                grabbed = true;
                if (OnGrabbed != null)
                {
                    OnGrabbed();
                }

            }

        }
        else
        {
            if (grabbed)
            {
                grabbed = false;
                Debug.Log("Released");
                grabbed = false;
                if (OnReleased != null)
                {
                    OnReleased();
                }
            }
        }
        
    }
}
