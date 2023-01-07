using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Earth : AbstractPlanet
{
    public Earth() : base("earth") { }

    public override ClampRange GetTemperature() => new ClampRange(30f, 50f, -80f);
}