using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Registry
{
    public class RegistryTable<T> where T : INamed
    {
        public List<T> Contents { get; set; } = new List<T>();

        public RegistryTable() { }

        public RegistryTable(params T[] targets) => Contents.AddRange(targets);

        public T GetByName(string name) => 
            this.Contents.Find(t => t.KeyName == name);
    }

    static Registry() { }

    public static RegistryTable<ItemBase> ITEM { get; set; } = new RegistryTable<ItemBase>();
    public static RegistryTable<BlockPrototype> BLOCK { get; set; } = new RegistryTable<BlockPrototype>();
    public static RegistryTable<Tag> TAG { get; set; } = new RegistryTable<Tag>();
    public static RegistryTable<Language> LANG { get; set; } = new RegistryTable<Language>();
    public static RegistryTable<AbstractPlanet> PLANET { get; set; } = new RegistryTable<AbstractPlanet>();
    public static RegistryTable<MetalMaterial> METAL { get; set; } = new RegistryTable<MetalMaterial>();

    public static void Register<U>(RegistryTable<U> table, U target) where U : INamed
    {
        table.Contents.Add(target);
    }
        
}