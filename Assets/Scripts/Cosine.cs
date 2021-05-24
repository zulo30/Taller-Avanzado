using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cosine : IFunction
{

    public float range = 1;
    public float period = 1;
    public float phase = 1;

    public Cosine(Function fun)
    {
        this.range = fun.range;
        this.period = fun.period;
        this.phase = fun.phase;
    }

    public float Evaluate(float n)
    {
        return range * Mathf.Cos(period * n + phase);
    }
}