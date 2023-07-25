using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Tag : IIdentified
{
    public string KeyName { get; set; }
    public string ShortName { get; set; }
    public List<ItemBase> Contents { get; set; } = new List<ItemBase>();

    public Tag(string keyName)
    {
        this.KeyName = $"tag.{keyName}";
        this.ShortName = keyName;
    }

    public void AddContent(ItemBase target) => this.Contents.Add(target);

    public void AddContents(params ItemBase[] targets) => 
        targets.ToList().ForEach(this.Contents.Add);
}

public class Tags
{
    public static readonly Tag WOOD = TagBuilder.Build("wood");
    public static readonly Tag METAL_INGOT = TagBuilder.Build("metal.ingot");
    public static readonly Tag METAL_PLATE= TagBuilder.Build("metal.plate");
}