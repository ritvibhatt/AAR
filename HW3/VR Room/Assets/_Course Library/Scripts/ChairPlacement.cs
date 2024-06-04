using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairPlacement : MonoBehaviour
{
    // Start is called before the first frame update
    private bool chairInPlace = false;

    void OnTriggerEnter(Collider other)
    {
        // Check if the chair enters the target area
        if (other.CompareTag("Chair"))
        {
            chairInPlace = true;
            Debug.Log("Chair is in the right area.");
            // Call your method to proceed to the next instruction
            ProceedToNextInstruction();
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the chair exits the target area
        if (other.CompareTag("Chair"))
        {
            chairInPlace = false;
            Debug.Log("Chair is not in the right area.");
        }
    }

    private void ProceedToNextInstruction()
    {
        // Implement your logic to proceed to the next instruction
        // For example, you can call a method in another script:
        FindObjectOfType<InstructionManager>().NextInstruction();
    }

    public bool IsChairInPlace()
    {
        return chairInPlace;
    }
}
