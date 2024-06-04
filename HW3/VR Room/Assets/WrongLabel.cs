using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WrongLabel : MonoBehaviour
{
    public TMP_Text keyLabel;

    void Start()
    {
    }

    public void ChangeLabel()
    {
        keyLabel.text = "D1";
    }
}
