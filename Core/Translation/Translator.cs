using System.Collections;
using UnityEngine;
using LitJson;

public static class Translator
{
    public static string Translate(Language language, string keyName)
    {
        var langMapper = JsonMapper.ToObject(language.LangFile.LoadAsText());
        return (string)langMapper[keyName];
    }
}