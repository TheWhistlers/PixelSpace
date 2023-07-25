using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Earth : AbstractPlanet
{
    public Earth() : base("earth") { }

    public override ClampedFloat GetTemperature() => new ClampedFloat(30f, 50f, -80f);
}