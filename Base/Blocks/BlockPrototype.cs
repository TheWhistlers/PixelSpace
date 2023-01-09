using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BlockPrototype : INamed
{
    public string ShortName { get; protected set; }
    public string KeyName { get; set; }
    public string Description { get; set; }

    public float Hardness { get; set; }
    public ExcavationLevel ExcavationLevel { get; set; }

    protected Dictionary<string, BlockModel> Models;

    public BlockPrototype(string keyName, string prefix = "pixel")
    {
        this.KeyName = $@"{prefix}:block.{keyName}";
        this.ShortName = keyName;

        Registry.Register(Registry.BLOCK, this);
    }

    public virtual ItemBase GetBlockItem() =>
        new BlockItem(this, this.ShortName, this.GetModels()["default"]);

    public virtual Dictionary<string, BlockModel> GetModels()
    {
        this.Models.Add("defalut", ModelBuilder.Build(new Vector2(0f, 0f),
            new Vector2(1f, 1f), TextureManager.GetItemTexture(this.ShortName), 
            false));
        return this.Models;
    }

    public virtual Canvas GetUICanvas() =>
        GameObject.Find(this.ShortName + "_ui_canvas").GetComponent<Canvas>();

    public virtual InteractionResult Use(PlayerEntity user, Time when) =>
        InteractionResult.Pass;

    public virtual string GetDisplayName() => 
        Translator.Translate(GameManager.CurrentLanguage, this.KeyName);

    public virtual void RenderUI(ScreenRenderer renderer) { }
}