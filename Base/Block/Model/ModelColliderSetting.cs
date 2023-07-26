using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class ModelColliderSetting
{
    public Vector2 Size { get; set; }
    public bool IsTrigger { get; set; }

    public ModelColliderSetting(Vector2 size, bool isTrigger)
    {
        this.Size = size;
        this.IsTrigger = isTrigger;
    }
}