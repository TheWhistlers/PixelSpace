using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using LitJson;

public static class RecipeTypes
{
    public static string FLINT_GRINDING { get; set; } = "pixel:compounding/flint_grinding";
}

public class FlintGrindingRecipe
{
    public class GrindingCoordinate
    {
        // Zero Point: The most left and top
        public int X { get; set; }
        public int Y { get; set; }
    }
    public string Type { get; set; }
    public ItemStack Ingredient { get; set; }
    public List<GrindingCoordinate> Coordinates { get; set; }
    public ItemStack Result { get; set; }

    public FlintGrindingRecipe(string file)
    {
        var root = JsonMapper.ToObject(file);
        this.Type = ((string) root["type"]);
    }
}

