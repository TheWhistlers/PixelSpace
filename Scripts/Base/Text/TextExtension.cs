using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;

public static class TextExtension
{
    public static void Centralize(this Text self)
    {
        self.alignment = UnityEngine.TextAnchor.MiddleCenter;
    }
}
