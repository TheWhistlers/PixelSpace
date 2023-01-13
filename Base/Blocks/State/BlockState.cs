using System;
using System.Collections.Generic;
using System.Linq;
using LitJson;
using UnityEngine;

public class BlockState
{
    public Dictionary<string, string> StateTable { get; set; } 
        = new Dictionary<string, string>();

    public BlockState() { }

    public void SetState(string name, string value)
    {
        if (!this.StateTable.ContainsKey(name))
            throw new NullReferenceException($"property:'{name}' wasn't contained in current table");

        this.StateTable[name] = value;
    }

    public string GetState(string name)
    {
        if (!this.StateTable.ContainsKey(name))
            throw new NullReferenceException($"property:'{name}' wasn't contained in current table");
        
        return this.StateTable[name];
    }

    public string ToJson() => JsonMapper.ToJson(this.StateTable);
}