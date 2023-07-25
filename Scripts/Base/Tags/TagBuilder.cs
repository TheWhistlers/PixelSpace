using System.Collections;
using UnityEngine;

public sealed class TagBuilder
{
    public static Tag Build(string name, string prefix = "pixel")
    {
        var tag = new Tag($"{prefix}:tag.{name}");
        Registry.Register(Registry.TAG, tag);
        return tag;
    }
}