using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollDisplay : MonoBehaviour
{
    public GameObject src;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshPro>().text = src.GetComponent<SixRays>().publicFace;
    }
}
