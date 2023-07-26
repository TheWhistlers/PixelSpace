using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BlockInstance
{
    public BlockPrototype Prototype { get; set; }
    public Vector3 Position { get; set; }

    public List<BlockState> States { get; set; } = new();
    internal string[] states_kvps;

    public BlockInstance(BlockPrototype prototype)
    {
        this.Prototype = prototype;

        this.Prototype.SetDefaultStates(this.States, states_kvps);
    }

    public void SetState(string key, string value) =>
        this.States.Find(_ => _.Key.Equals(key)).SetValue(value);

    public string GetState(string key) =>
        this.States.Find(_ => _.Key.Equals(key)).Value;
}
