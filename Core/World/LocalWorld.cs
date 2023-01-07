using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LocalWorld
{
    public Dictionary<AbstractPlanet, bool> PlanetLockings { get; set; }
        = new Dictionary<AbstractPlanet, bool>();


}