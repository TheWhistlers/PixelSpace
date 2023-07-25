using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BlockInstance
{
    public BlockPrototype Prototype { get; set; }
    public Vector3 Position { get; set; }
    public BlockDirection Direction { get; set; } = BlockDirection.EAST;
    protected BlockState State { get; set; }

    public BlockInstance(BlockPrototype prototype)
    {
        this.Prototype = prototype;
        this.State = new BlockState();

        this.State.StateTable = this.Prototype.PresetStates;
    }

    public static BlockInstance CreateInstance(BlockPrototype prototype,
        Vector3 position, BlockDirection direction = BlockDirection.EAST) =>
        new BlockInstance(prototype.)
        {
            Position = position,
            Direction = direction
        };

    public void SetState(string name, string value) =>
        this.State.SetState(name, value);

    public string GetState(string name) =>
        this.State.GetState(name);
}
