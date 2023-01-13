using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStack
{
    public ItemBase Base { get; set; }
    public int Count { get; protected set; }

    public ItemStack(ItemBase @base, int count)
    {
        this.Base = @base;
        
        if (count > 0 && count <= @base.MaxStack) this.Count = count;
    }

    public void Shrink(int amount)
    {
        if (amount <= Count)
            Count -= amount;
    }

    public void Increase(int amount)
    {
        if ((amount + Count) <= Base.MaxStack)
            Count += amount;
    }
}
