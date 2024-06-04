using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InstructionManager : MonoBehaviour
{

    public TextMeshProUGUI instructionText;
    public TextMeshProUGUI DisplayTruthTMP;
    private string[] instructions = {
        "Welcome to our piano tutorial. Come on inside, then click next!",
        "Sit on the chair next to the piano.",
        "Follow the text on the screen to play the piano, and click next to continue.",
        "You are now starting to play! We will display the note you are going to play on the screen. ",
        "use the foot pedal",
        ""
    };

    // private string[] refreshInstructions = {
    //     "Sorry, it looks like the chair isn't in the right place. Please move the chair in front of the piano.",
    // };

    private int currentInstructionIndex = 0;

    public Button nextButton;
    public Button prevButton;
    public Button refreshButton;
    private string currentNote = "C"; // The note that the user should play
    private string playedNote = ""; // The note that the user played

    // Start is called before the first frame update
    void Start()
    {
        instructionText.text = instructions[currentInstructionIndex];
        
        // Add a listener to the button to call the NextInstruction method when clicked
        nextButton.onClick.AddListener(CheckInstruction);

        prevButton.onClick.AddListener(PrevInstruction);

        refreshButton.onClick.AddListener(RefreshInstruction);
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.C))
        // {
        //     playedNote = "C";
        //     DisplayPlayedNote();
        // }
            //     playedNote = "C";
            // DisplayPlayedNote();
    }
    void RefreshInstruction()
    {
        if (currentInstructionIndex == 1)
        {
            CheckInstruction();
        }
    }

    public void NextInstruction()
    {
        // Increment the instruction index
        currentInstructionIndex++;

        // Check if we are still within the bounds of the instructions array
        if (currentInstructionIndex < instructions.Length)
        {
            // Update the instruction text
            instructionText.text = instructions[currentInstructionIndex];
        }
        else
        {
            // Optionally, disable the button or handle the end of the instructions
            currentInstructionIndex --;
            // instructionText.text = "";
            // nextButton.interactable = false;
        }
         if (currentInstructionIndex == 4) // Check if it's the foot pedal instruction
            {
                StartCoroutine(FootPedalSequence());
            }
    }

    void PrevInstruction()
    {
        // Increment the instruction index
        currentInstructionIndex--;

        // Check if we are still within the bounds of the instructions array
        if (currentInstructionIndex >= 0)
        {
            // Update the instruction text
            instructionText.text = instructions[currentInstructionIndex];
        }
        else
        {
            // Optionally, disable the button or handle the end of the instructions
            // instructionText.text = "";
            // nextButton.interactable = false;
            currentInstructionIndex++;
        }
    }

    void CheckInstruction()
    {
        // If the current instruction requires the chair to be placed, check its placement
        // if (instructions[currentInstructionIndex] == "Sit on the chair next to the piano.")
        // {
        //     ChairPlacement placementChecker = FindObjectOfType<ChairPlacement>();
        //     if (placementChecker.IsChairInPlace())
        //     {
        //         NextInstruction();
        //     }
        //     else
        //     {
        //         Debug.Log("Chair is not in the right area yet.");
        //         // Optionally display a message to the user
        //         instructionText.text = "Sorry, it looks like the chair isn't in the right place. Please move the chair in front of the piano.";
        //     }
        // }
        // else
        // {
        //     NextInstruction();
        // }
        NextInstruction();
    }


            private IEnumerator FootPedalSequence()
        {
        nextButton.interactable = false; // Disable the Next button
        instructionText.text = "use the foot pedal";
        yield return new WaitForSeconds(1); // Wait for 2 seconds
        instructionText.text = "scanning the foot pedal...";

        yield return new WaitForSeconds(3); // Wait for 2 seconds

        instructionText.text = "Sorry, it seems you don't have the foot pedal.";
        nextButton.interactable = true; // Re-enable the Next button
        }
}
