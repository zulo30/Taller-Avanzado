using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sawtooth : IFunction
{

    public float range = 1;
    public float period = 1;
    public float phase = 1;

    public Sawtooth(Function fun)
    {
        this.range = fun.range;
        this.period = fun.period;
        this.phase = fun.phase;
    }

    public float Evaluate(float n)
    {
        return range * (n - Mathf.Floor(phase + n));
    }
}