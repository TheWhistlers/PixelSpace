using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public sealed class ExcavationLevel
{
    public string ExcavationTool { get; set; }
    public int ExcavationMaterial { get; set; }

    public ExcavationLevel(string toolName, string material)
    {
        this.ExcavationTool = toolName;
        this.ExcavationMaterial = material;
    }

}