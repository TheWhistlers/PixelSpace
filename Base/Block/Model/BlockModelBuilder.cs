using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class BlockModelBuilder
{
    protected List<BlockModelPart> ModelParts { get; set; }

    public BlockModelBuilder() { ModelParts = new List<BlockModelPart>(); }

    public BlockModelBuilder AddPart(int index, Vector2 size, ResourceLocation texture, ModelColliderSetting setting)
    {
        this.ModelParts.Add(new BlockModelPart(index, size, texture, setting));
        return this;
    }
}
