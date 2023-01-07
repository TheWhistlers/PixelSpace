using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;

public class ClampRange
{
    private float number;

    public float Value
    {
        get => number;
        private set => number = value;
    }
    public float Max { get; set; }
    public float Min { get; set; }

    public ClampRange(float value, float max, float min)
    {
        this.Value = value;
        this.Max = max;
        this.Min = min;
    }

    public void SetValue(float target)
    {
        if (target >= this.Min && target <= this.Max)
            this.Value = target;
        else
            Debug.LogWarning($"{target} doesn't belong to the Range({this.Min}~{this.Max})");
    }
}