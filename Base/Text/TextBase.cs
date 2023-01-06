using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class TextBase
{
    public string KeyName { get; set; }
    public Font TextFont { get; set; }

    public TextBase(string keyName)
    {
        this.KeyName = keyName;
    }

    public TextBase SetFont(ResourceLocation location)
    {
        this.TextFont = location.LoadAsFont();
        return this;
    }
}
