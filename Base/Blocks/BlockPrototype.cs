using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class BlockPrototype : INamed
{
    public string ShortName { get; set; }
    public string KeyName { get; set; }
    public string Description { get; set; }

    public float Hardness { get; set; }
    public ExcavationLevel ExcavationLevel { get; set; }

    public Dictionary<string, BlockModel> Models { get; set; } = new Dictionary<string, BlockModel>();
    public Dictionary<string, string> PresetStates { get; set; } 
        = new Dictionary<string, string>();
    
    public BlockPrototype(string keyName, string prefix = "pixel")
    {
        this.KeyName = $@"{prefix}:block.{keyName}";
        this.ShortName = keyName;

        this.Models.Add("default", ModelBuilder.Build(new Vector2(0f, 0f),
            new Vector2(1f, 1f), TextureManager.GetBlockTexture(this.ShortName), 
            false));

        Registry.Register(Registry.BLOCK, this);
    }

    /// <summary>
    /// argument-preset's format: [name:value]
    /// </summary>
    public BlockPrototype AddPresetStates(params string[] presets)
    {
        foreach (var preset in presets)
        {
            var splited = preset.Split(':');
            string name = splited[0], default_value = splited[1];

            this.PresetStates.Add(name, default_value);
        }
        return this;
    }

    public virtual ItemBase GetBlockItem() =>
        new BlockItem(this, this.ShortName, this.Models["default"]);

    public virtual Canvas GetUICanvas() =>
        GameObject.Find(this.ShortName + "_ui_canvas").GetComponent<Canvas>();

    public virtual InteractionResult Use(PlayerEntity user, Time when) =>
        InteractionResult.Pass;

    public virtual string GetDisplayName() => 
        Translator.Translate(GameManager.CurrentLanguage, this.KeyName);

    public virtual void RenderUI(ScreenRenderer renderer) { }
}

public class Blocks
{
    public static void Inititalize() {}

    public static readonly BlockPrototype GLASS_DIRT =
        new BlockPrototype("glass_dirt")
        .AddPresetStates(
            "has_glass:true"
            );

    public static readonly BlockPrototype IRON_BLOCK =
        new BlockPrototype("iron_block");
}