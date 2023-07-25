using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MouseManager
{
    public static RaycastHit2D GetMouseRaycast()
    {
        return Physics2D.Raycast(
            Camera.main.ScreenToWorldPoint(Input.mousePosition),
            Vector2.zero);
    }
}