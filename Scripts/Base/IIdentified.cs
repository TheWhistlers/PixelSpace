using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public interface IIdentified
{
    public string KeyName { get; set; }
    public string ShortName { get; set; }

    public virtual string GetDisplayName() =>
        Translator.Translate(GameManager.CurrentLanguage, this.KeyName);
}