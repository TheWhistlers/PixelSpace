using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastHelper
{
    public static RaycastHit2D CreateRaycast(GameObject target, Vector2 offset, Vector2 direction, float length, LayerMask layer)
    {
        Vector2 pos = target.transform.position;
        RaycastHit2D hit = Physics2D.Raycast(pos + offset, direction, length, layer);
        Color color = hit ? Color.red : Color.green;
        Debug.DrawRay(pos + offset, direction * length, color);
        
        return hit;
    }

    public static RaycastHit2D CreateMouseRaycast(Vector2 origin)
    {
        var hit = Physics2D.Raycast(origin, 
            Camera.main.ScreenToWorldPoint(Input.mousePosition)); 

        Debug.DrawRay(origin, 
            Camera.main.ScreenToWorldPoint(Input.mousePosition), 
            hit ? Color.red : Color.green);

        return hit;
    }
}
