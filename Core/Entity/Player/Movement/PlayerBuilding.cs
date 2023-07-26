using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Whistler.Enceladus.Algorithms;

public class PlayerBuilding : MonoBehaviour
{
    public bool IsBuildMode;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (IsBuildMode == true)
            {
                Build();
            }
        }
    }

    public void ChangeBuildMode() => IsBuildMode = !IsBuildMode;

    private void Build()
    {
        var grid = ItemTest.Map;
        var hit = MouseManager.GetMouseRaycast();


        if (hit.collider != null && hit.collider.CompareTag("PlaceableGrid"))
        {
            var target = hit.collider.gameObject;
            grid.GetGridPosition(hit.transform.position, out int x, out int y);
            
            if (grid.GetGrid(x, y).CanPlace())
            {
                var toplace = grid.GetGrid(x, y);
            }
        }
    }
}