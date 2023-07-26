using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TripleCompound
{
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }

    public Func<float, float, float, float> Compounder { get; set; }

    public float Value
    {
        get => Compounder(x, y, z);
    }


    public TripleCompound(Func<float, float, float, float> compounder) =>
        this.Compounder = compounder;

    public TripleCompound(float x, float y, float z, Func<float, float, float, float> compounder)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        Compounder = compounder;
    }

}