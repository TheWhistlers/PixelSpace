using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class BlockPrototype : IIdentified
{
    public string ShortName { get; set; }
    public string KeyName { get; set; }
    public string Description { get; set; }

    public float Hardness { get; set; }
    public ExcavationLevel ExcavationLevel { get; set; }
    public bool AirPlaceable { get; set; } = false;

    protected List<BlockState> States { get; set; } = new ();
    protected BlockModelBuilder ModelBuilder { get; set; } = new BlockModelBuilder();

    public BlockPrototype(string keyName, string prefix = "pixel")
    {
        this.KeyName = $@"{prefix}:block.{keyName}";
        this.ShortName = keyName;

        Registry.Register(Registry.BLOCK, this);
    }

    public BlockPrototype SetDefaultStates(params string[] kvps)
    {
        this.SetDefaultStates(this.States, kvps);
        return this;
    }

    internal BlockPrototype SetDefaultStates(List<BlockState> states, params string[] kvps)
    {
        foreach (var kvp in kvps)
        {
            var key = kvp.Split('.')[0];
            var value = kvp.Split('.')[1];

            states.Add(new BlockState(key).SetValue(value));
        }

        this.states_kvps = kvps;
        return this;
    }

    private string[] states_kvps;

    public BlockInstance CreateInstance(BlockPrototype prototype,
        Vector3 position) =>
        new BlockInstance(prototype)
        {
            Position = position,
            states_kvps = this.states_kvps
        };

    public virtual string GetDisplayName() => 
        Translator.Translate(GameManager.CurrentLanguage, this.KeyName);

    public virtual InteractionResult Use(PlayerEntity user, Time when) =>
        InteractionResult.Pass;
}

public class Blocks
{
    public static void Inititalize() {}

    public static readonly BlockPrototype GRASS_BLOCK = new BlockPrototype("grass_block")
        .SetDefaultStates("attachment:grass");
}