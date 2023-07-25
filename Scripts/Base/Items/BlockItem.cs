using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BlockItem : ItemBase
{
    public BlockPrototype CorrespondingBlock { get; set; }

    public BlockItem(BlockPrototype block, string keyName, BlockModel model, string prefix = "pixel") : 
        base($"block.{keyName}", prefix)
    {
        this.CorrespondingBlock = block;
        this.Texture = model.Texture;
        this.ShortName = "__block__." + keyName;
    }

    public override string GetDisplayName() => CorrespondingBlock.GetDisplayName();
}