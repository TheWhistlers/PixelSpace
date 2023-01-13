using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

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
        var grid = GameObject.Find("GridMapTest").GetComponent<ItemTest>().Map;
        var hit = MouseManager.GetMouseRaycast();

        if (hit.collider != null)
        {
            var target = hit.collider.gameObject;
            grid.GetGridPosition(hit.transform.position, out int x, out int y);

            if ((target.GetComponent<PlaceableGrid>().CanPlace()))
            {
                var toplace = target.GetComponent<PlaceableGrid>();
                toplace.Place("iron_block");
            }
        }
    }
}