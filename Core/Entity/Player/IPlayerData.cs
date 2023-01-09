using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public interface IPlayerData
{
    public TripleCompound Hunger { get; set; }
    public ClampedFloat Moisture { get; set; }
    public ClampedFloat Protein { get; set; }
    public ClampedFloat Vegetable { get; set; }
    public ClampedFloat Carbonhydrate { get; set; }
    public ClampedFloat Vitamin { get; set; }
}