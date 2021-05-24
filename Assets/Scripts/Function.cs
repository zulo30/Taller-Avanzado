using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum FunctionType { Sine, Cosine, Squared, Sawtooth };
[System.Serializable]

[CreateAssetMenu(menuName = "Function")]
public class Function : ScriptableObject
{
    public FunctionType category;
    public float range = 10;
    public float period = 1;
    public float phase = 1;
}

