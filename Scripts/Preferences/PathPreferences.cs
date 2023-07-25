using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PathPreferences
{
    public static string ITEM_TEXTURE_PATH { get; set; } = $@"{GameManager.Persistent}/games/resources/textures/items/";
    public static string BLOCK_TEXTURE_PATH { get; set; } = $@"{GameManager.Persistent}/games/resources/textures/blocks/";
}
