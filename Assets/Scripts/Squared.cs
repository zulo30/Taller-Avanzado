using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squared : IFunction
{

    public float range = 1;
    public float period = 1;
    public float phase = 1;

    public Squared(Function fun)
    {
        this.range = fun.range;
        this.period = fun.period;
        this.phase = fun.phase;
    }

    public float Evaluate(float n)
    {
        return phase - range * Mathf.Round(n - Mathf.Floor(n));
    }
}