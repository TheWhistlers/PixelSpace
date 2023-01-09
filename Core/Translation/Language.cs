using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

public class Language : INamed
{
    public string KeyName { get; set; }
    public string Description { get; set; }
    internal ResourceLocation LangFile { get; set; }

    public Language(string name, string description)
    {
        this.KeyName = name;
        this.Description = description;

        if (!string.IsNullOrEmpty(this.KeyName))
        {
            this.LangFile = new ResourceLocation($@"{GameManager.Persistent}/games/resources/langs/{this.KeyName}.json");
        }

        Registry.Register(Registry.LANG, this);
    }

    public string GetDisplayName() => this.Description;
}

public class Languages
{
    public static readonly Language ZH_CN = new Language("zh_cn", "中文 (简体)");
    public static readonly Language ZH_TW = new Language("zh_tw", "中文 (繁體)");
    public static readonly Language EN_US = new Language("en_us", "English (the United States)");
    public static readonly Language EN_UK = new Language("en_uk", "English (the United Kingdom)");
    public static readonly Language RU_RU = new Language("ru_ru", "Русский");

    public static void Inititalize() {}
}