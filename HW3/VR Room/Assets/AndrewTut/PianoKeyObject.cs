using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[CreateAssetMenu(fileName = "KeyData")]
public class PianoKeyObject : ScriptableObject
{
    public List<PianoKey> pianoData;

    
}

[Serializable]
public class PianoKey
{
    [field: SerializeField]
    public string Key { get; private set; }
    [field: SerializeField]
    public GameObject Label { get; private set; }

}
