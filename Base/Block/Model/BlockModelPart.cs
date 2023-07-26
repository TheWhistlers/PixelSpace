using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class BlockModelPart
{
    public int Index { get; set; }
    public Vector2 Size { get; set; }
    public ResourceLocation Texture { get; set; }
    public ModelColliderSetting ColliderSetting { get; set; }

    public BlockModelPart(int index, Vector2 size, ResourceLocation texture, ModelColliderSetting colliderSetting)
    {
        this.Index = index;
        this.Size = size;
        this.Texture = texture;
        this.ColliderSetting = colliderSetting;
    }
}
