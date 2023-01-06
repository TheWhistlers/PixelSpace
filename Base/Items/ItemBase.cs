using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemBase
{
    public string Prefix { get; set; }
    public string Name { get; set; }
    public string IndexName { get; set; }
    public string Description { get; set; }
    public Sprite Texture { get; set; }
    public ResourceLocation TextureLocation { get; set; }
    public int MaxStack { get; set; } = 1024;
    
    public ItemBase(string name, string prefix = "pixel")
    {
        this.Prefix = prefix;
        this.IndexName = $@"{this.Prefix}:{name}";
        this.Name = Translator.Translate(GameManager.CurrentLanguage, this.IndexName); // need to translate into the correct language!


        if (!string.IsNullOrEmpty(this.Name))
        {
            this.TextureLocation = new ResourceLocation($@"{Application.persistentDataPath}/games/resources/textures/items//{name}.png");
            this.Texture = this.TextureLocation.LoadAsTexture();
        }

        Registry.Register(Registry.ITEM, this);
    }

    public ItemBase AddTag(Tag tag)
    {
        tag.AddContent(this);
        return this;
    }

    public ItemBase AddTags(params Tag[] tags)
    {
        tags.ToList().ForEach(t => t.AddContent(this));
        return this;
    }

    public ItemStack AsStack() => new ItemStack(this, 1);

    public virtual InteractionResult Use(PlayerEntity user, Time when) => InteractionResult.Pass;

    public virtual int CalculateDamage(LivingEntity user) => user.Damage;

    public virtual void RenderHUD(PlayerEntity user, ScreenRenderer renderer) { }
}

public class Items
{
    public static readonly ItemBase TIN_INGOT = new ItemBase("tin_ingot");
    public static readonly ItemBase COPPER_INGOT = new ItemBase("copper_ingot");
    public static readonly ItemBase BRONZE_INGOT = new ItemBase("bronze_ingot");
    public static readonly ItemBase TIN_PLATE = new ItemBase("tin_plate");
    public static readonly ItemBase COPPER_PLATE = new ItemBase("copper_plate");
    public static readonly ItemBase BRONZE_PLATE = new ItemBase("bronze_plate");
}