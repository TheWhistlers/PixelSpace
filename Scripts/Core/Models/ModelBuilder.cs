using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ModelBuilder
{
    public static BlockModel Build(Vector2 lpos, Vector2 size, Sprite texture, bool hasCollider) =>
        new BlockModel(lpos, size, texture, hasCollider);
}