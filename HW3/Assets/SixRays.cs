using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SixRays : MonoBehaviour
{
    public string publicFace = "1";
    public string face = "1";
    public AudioClip audioClip;
    private AudioSource audioSource;
    // Start is called befor the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();

        audioSource.clip = audioClip;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3[] directions = {transform.forward, -transform.forward, transform.right, -transform.right, transform.up, -transform.up};
        for (int i = 0; i < directions.Length; i++)
        {
            RaycastHit hit;
  
            if (Physics.Raycast(transform.position, directions[i], out hit, 0.3f))
            {
                Debug.DrawRay(transform.position, directions[i] * 1f, Color.green);
                if (directions[i] == transform.forward)
                {
                    Debug.Log("1");
                    face = "1";
                }
                else if (directions[i] == -transform.forward)
                {
                    Debug.Log("2");
                    face = "6";
                }
                else if (directions[i] == transform.right)
                {
                    Debug.Log("3");
                    face = "3";
                }
                else if (directions[i] == -transform.right)
                {
                    Debug.Log("4");
                    face = "4";
                }
                else if (directions[i] == transform.up)
                {
                    Debug.Log("5");
                    face = "5";
                }
                else if (directions[i] == -transform.up)
                {
                    Debug.Log("6");
                    face = "2";
                }
            }
            if (publicFace != face){
                audioSource.Play();
            }
            publicFace = face;

        }


        
    }
}
