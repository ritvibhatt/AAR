using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float SPEED = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(Vector3.forward * SPEED * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(Vector3.back * SPEED * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(Vector3.left * SPEED * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(Vector3.right * SPEED * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("PickUp")) {
            other.gameObject.SetActive(false);
        }
    }

}
