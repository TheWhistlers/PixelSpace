using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BlockPrototype
{
    public string Prefix { get; set; }
    public string Name { get; set; }
    public string IndexName { get; set; }
    public string Description { get; set; }
    public Sprite Texture { get; set; }
    public ResourceLocation TextureLocation { get; set; }
    public List<string> BlockStatePresets { get; set; }
    private ItemBase BlockItem;

    public BlockPrototype(string name, string prefix = "pixel")
    {
        this.Prefix = prefix;
        this.Name = name; // need to translate into the correct language!
        this.IndexName = $@"{this.Prefix}:{name}";

        BlockItem = new ItemBase(name)
        {
            Texture = this.Texture,
            TextureLocation = this.TextureLocation,

        };

        if (!string.IsNullOrEmpty(this.Name))
        {
            this.TextureLocation = new ResourceLocation($@"{Application.persistentDataPath}/games/resources/textures/blocks/{name}.png");
            this.Texture = this.TextureLocation.LoadAsTexture();
        }
    }
}