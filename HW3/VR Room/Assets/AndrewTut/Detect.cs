using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Detect : MonoBehaviour
{
    [SerializeField] private List<string> song = new List<string>();

    [SerializeField] private List<GameObject> right = new List<GameObject>();
    [SerializeField] private List<GameObject> wrong = new List<GameObject>();
    [SerializeField] private TextMeshPro text;
    [SerializeField] private TextMeshPro succText;
    public bool correctNotes = false;
    public string pressedKey;
    private int currentKey = 0;
    private List<GameObject> use;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (correctNotes)
        {
            use = right;

        }
        else
        {
            use = wrong;
        }
        DisplayNote(currentKey);
        Debug.Log(currentKey);
        if (pressedKey == song[currentKey])
        {
            Debug.Log(pressedKey);
            currentKey++;
            use[currentKey - 1].SetActive(false);
            
        }
        if (currentKey == (song.Count - 1))
        {
            text.gameObject.SetActive(false);
            succText.gameObject.SetActive(true);
        }
    }

    public void DisplayNote(int i)
    {
        text.text = $"Note To Play: {song[i]}";
        use[i].SetActive(true);
    }

    public void getKey(string key)
    {
        pressedKey = key;
    }

    public void changeTut()
    {
        correctNotes = true;
        currentKey = 0;
        foreach (var i in wrong)
        {
            i.SetActive(false);
        }
    }
    
}
