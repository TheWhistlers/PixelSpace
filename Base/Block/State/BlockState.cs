using System;
using System.Collections.Generic;
using System.Linq;
using LitJson;
using UnityEngine;

public class BlockState
{
    public string Key { get; set; }
    public string Value { get; set; }

    public BlockState(string key)
    {
        this.Key = key;
    }

    public string GetKVP()
    {
        return $"{this.Key}:{this.Value}";
    }

    public BlockState SetValue(string value)
    {
        this.Value = value;
        return this;
    }
}