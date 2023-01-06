﻿using System;
using System.Collections.Generic;
using UnityEngine;

public interface IWorld
{
    public static GameObject GetFromPos(Vector3 position)
{
        RaycastHit2D hit = Physics2D.Raycast(position, Vector3.zero);
        return hit.transform.gameObject != null ? hit.transform.gameObject : null;
    }
}