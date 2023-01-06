using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Tag
{
    public string TagName { get; set; }
    public List<ItemBase> Contents { get; set; } = new List<ItemBase>();

    public Tag(string name)
    {
        this.TagName = name;
    }

    public void AddContent(ItemBase target) => this.Contents.Add(target);

    public void AddContents(params ItemBase[] targets) => 
        targets.ToList().ForEach(this.Contents.Add);

    public string GetDisplayName(Language language) => 
        Translator.Translate(language, this.TagName);
}

public class Tags
{
    public static readonly Tag WOOD = TagBuilder.Build("wood");
    public static readonly Tag METAL = TagBuilder.Build("metal");
}