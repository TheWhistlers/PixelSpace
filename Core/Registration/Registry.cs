using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Registry
{
    public class RegistryTable<T>
    {
        public List<T> Contents { get; set; } = new List<T>();

        public RegistryTable(params T[] targets) => Contents.AddRange(targets);
    }

    public static RegistryTable<ItemBase> ITEM { get; set; } = new RegistryTable<ItemBase>();
    public static RegistryTable<BlockPrototype> BLOCK { get; set; } = new RegistryTable<BlockPrototype>();
    public static RegistryTable<Tag> TAG { get; set; } = new RegistryTable<Tag>();
    public static RegistryTable<Language> LANG { get; set; } = new RegistryTable<Language>();
    public static RegistryTable<AbstractPlanet> PLANET { get; set; } = new RegistryTable<AbstractPlanet>();

    public static void Register<U>(RegistryTable<U> table, U target) =>
        table.Contents.Add(target);
}