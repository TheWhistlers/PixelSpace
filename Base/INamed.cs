using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public interface INamed
{
    public string KeyName { get; set; }
    public virtual string GetDisplayName() =>
        Translator.Translate(GameManager.CurrentLanguage, this.KeyName);
}