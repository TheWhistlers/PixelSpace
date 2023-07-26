using System;
using System.Collections.Generic;
using System.Linq;
using LitJson;
using UnityEngine;

public class LocalWorld
{
    public string Name { get; set; }
    public Dictionary<string, bool> PlanetLockings { get; protected set; }
        = new Dictionary<string, bool>();
    public List<GridMap> Sections { get; set; } = new List<GridMap>();
    public PlayerEntity PlayerIn { get; set; }

    public LocalWorld()
    {
        Registry.PLANET.Contents
            .ForEach(planet => PlanetLockings.Add(planet.ShortName, false));
    }

    public bool IsPlanetUnLocked(string name) => this.PlanetLockings[name];
}