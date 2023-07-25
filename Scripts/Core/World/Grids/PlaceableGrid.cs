using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceableGrid : MonoBehaviour
{
    public int x, y;
    public BlockInstance Block = null;
    public float Temperature;

    public bool CanPlace() => this.Block == null;

    public void Place(BlockPrototype prototype)
    {
        this.Block = BlockInstance.CreateInstance(prototype,
            ItemTest.Map.GetWorldPosition(x, y));
        transform.GetChild(0).GetComponent<SpriteRenderer>().sprite
            = Block.Prototype.Models["default"].Texture;

        this.GetComponent<BoxCollider>().isTrigger =
            this.Block.Prototype.IsTriggerCoillder;
    }

    public void Place(string name) => Place(Registry.BLOCK.GetByName(name));

    internal void SetXY(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}
