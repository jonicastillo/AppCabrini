using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fund
{
    private float _value;

    public float value { get { return _value; } }
    public string name;


    public Fund(string name, float value)
    {
        this.name = name;
        _value = value;
    }


    public unsafe void SetFeed(float* feed)
    {

    }
}
