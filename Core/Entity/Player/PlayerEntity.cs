using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity : LivingEntity, IPlayerData
{
    public PlayerMovement Movement { get; set; }

    public TripleCompound Hunger { get; set; } = new TripleCompound(HungerManager.CalculateHunger);
    public ClampedFloat Moisture { get; set; } = new ClampedFloat(100f, 100f, 0f);
    public ClampedFloat Vitamin { get; set; } = new ClampedFloat(100f, 100f, 0f);
    public ClampedFloat Protein { get; set; } = new ClampedFloat(100f, 100f, 0f);
    public ClampedFloat Vegetable { get; set; } = new ClampedFloat(100f, 100f, 0f);
    public ClampedFloat Carbonhydrate { get; set; } = new ClampedFloat(100f, 100f, 0f);

    public AbstractPlanet PlanetIn { get; set; }

    public void OpenUI(BlockPrototype block)
    {
        if (block != null) 
            block.RenderUI(new ScreenRenderer(block.GetUICanvas()));
    }
}
