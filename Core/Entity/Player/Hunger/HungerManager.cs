using System;
using System.Collections.Generic;
using UnityEngine;

public class HungerManager
{
    public const float PROTEIN_WEIGHT = 0.3f;
    public const float VEGETABLE_WEIGHT = 0.2f;
    public const float CARBONHYDRATE_WEIGHT = 0.5f;

    public static float CalculateHunger(float protein, float vegetable, float carbohydrate) =>
        (protein * PROTEIN_WEIGHT + 
        vegetable * VEGETABLE_WEIGHT + 
        carbohydrate * CARBONHYDRATE_WEIGHT) / 3;
}