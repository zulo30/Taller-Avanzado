
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionRenderer : MonoBehaviour
{
    public Function fun;

    public float speed = 1;
    public float lowerLimit = -20;
    public float upperLimit = 20;

    public FunctionType category;
    public float range = 10;
    public float period = 1;
    public float phase = 1;

    private IFunction factory;
    float sign = 1;
    float index = 0;
    private void Start()
    {
        this.factory = FunctionFactory.CreateFunctionFilter(fun);
    }

    private void Update()
    {
        index += Time.deltaTime * sign * speed;
        float x = index;
        float y = factory.Evaluate(index);
        float z = transform.position.z;

        if (index > upperLimit) sign = -1;
        if (index < lowerLimit) sign = 1;

        transform.localPosition = new Vector3(x, y, z);
        fun.range = range;
        fun.category = category;
        fun.phase = phase;
        fun.period = period;
        this.factory = FunctionFactory.CreateFunctionFilter(fun);
    }

}