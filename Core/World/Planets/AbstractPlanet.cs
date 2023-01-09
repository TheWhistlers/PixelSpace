using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class AbstractPlanet : INamed
{
    public string KeyName { get; set; }
    public string Description { get; set; }

    public AbstractPlanet(string name, string prefix = "pixel")
    {
        this.KeyName = $"{prefix}:planet.{name}";
        Registry.Register(Registry.PLANET, this);
    }

    public string DisplayName() =>
        Translator.Translate(GameManager.CurrentLanguage, this.KeyName);

    public abstract ClampedFloat GetTemperature();

    public virtual Vector3 GetGravity() => Physics.gravity;
}