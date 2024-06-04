using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WrongLabel : MonoBehaviour
{
    public TMP_Text keyLabel;

    public void ChangeLabel()
    {
        keyLabel.text = "B1";
    }
}
