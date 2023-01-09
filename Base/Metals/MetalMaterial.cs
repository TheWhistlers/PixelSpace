using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MetalMaterial : INamed
{
    public string KeyName { get; set; }
    public string ShortName { get; set; }

    public float FusingPoint { get; set; }
    public float Density { get; set; }
    public float ElectricalConductivity { get; set; }
    public float ThermalConductivity { get; set; }

    public MetalMaterial(string keyName, string prefix = "pixel")
    {
        this.KeyName = $"{prefix}:metal_material.{keyName}";
        this.ShortName = keyName;

        Registry.Register(Registry.METAL, this);
    }
}