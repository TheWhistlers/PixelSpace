using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StringText
{
    protected string text;

    public StringText(string text)
    {
        this.text = text;
    }

    public virtual string GetTextContent() => text;
}