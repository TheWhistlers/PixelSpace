using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceableGrid : MonoBehaviour
{
    public BlockPrototype Block;
    public float Temperature;

    public bool CanPlace() => this.Block == null;

    public void Place(string name)
    {
        Block = Registry.BLOCK.GetByName(name);
        transform.GetChild(0).GetComponent<SpriteRenderer>().sprite 
            = Block.Models["default"].Texture;
    }
}
