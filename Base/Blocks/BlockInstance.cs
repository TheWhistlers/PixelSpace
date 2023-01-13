using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BlockInstance
{
    public BlockPrototype Prototype { get; set; }
    public Vector3 Position { get; set; }
    public BlockDirection Direction { get; set; } = BlockDirection.EAST;
    public BlockState State { get; set; }

    public BlockInstance(BlockPrototype prototype, Vector3 position)
    {
        this.Prototype = prototype;
        this.Position = position;

        this.State.StateTable = this.Prototype.PresetStates;
    }
}
