using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BlockModel
{
    public Vector2 LocalPosition { get; set; }
    public Vector2 Size { get; set; }
    public bool HasCollider { get; set; }
    public Sprite Texture { get; set; }

    public BlockModel(Vector2 lpos, Vector2 size, Sprite texture, bool hasCollider)
    {
        this.LocalPosition = lpos;
        this.Size = size;
        this.Texture = texture;
        this.HasCollider = hasCollider;
    }

    public virtual void Generate(GameObject Target)
    {

    }
}