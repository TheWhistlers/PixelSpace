using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class AbstractPlanet : IIdentified
{
    public string KeyName { get; set; }
    public string ShortName { get; set; }
    public string Description { get; set; }

    public AbstractPlanet(string name, string prefix = "pixel")
    {
        this.KeyName = $"{prefix}:planet.{name}";
        this.ShortName = name;

        Registry.Register(Registry.PLANET, this);
    }

    public string DisplayName() =>
        Translator.Translate(GameManager.CurrentLanguage, this.KeyName);

    public abstract ClampedFloat GetTemperature();

    public virtual Vector3 GetGravity() => Physics.gravity;
}

public class Planets
{
    public static void Inititalize() {}

    public static readonly Earth EARTH = new Earth();
}