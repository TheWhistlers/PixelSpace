using System;
using System.Collections.Generic;
using System.Linq;
using LitJson;
using UnityEngine;

public class LocalWorld
{
    protected Dictionary<string, bool> PlanetLockings = new Dictionary<string, bool>();

    public PlayerEntity PlayerIn { get; set; }

    public LocalWorld()
    {
        Registry.PLANET.Contents
            .ForEach(planet => PlanetLockings.Add(planet.ShortName, false));
    }

    public bool IsPlanetUnLocked(string name) => this.PlanetLockings[name];
}