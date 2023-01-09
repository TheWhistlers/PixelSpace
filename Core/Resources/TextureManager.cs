using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TextureManager
{
    public static Sprite GetItemTexture(string name) =>
        new ResourceLocation(
            $@"{GameManager.Persistent}/games/resources/textures/items/{name}.png")
        .LoadAsTexture();

    public static Sprite GetBlockTexture(string name) =>
        new ResourceLocation(
            $@"{GameManager.Persistent}/games/resources/textures/blocks/{name}.png")
        .LoadAsTexture();
}