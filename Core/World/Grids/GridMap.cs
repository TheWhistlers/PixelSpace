﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GridMap
{
    public int Width { get; set; }
    public int Height { get; set; }
    public float CellSize { get; set; }
    public PlaceableGrid[,] Blocks { get; set; }

    protected GameObject Cell;

    public GridMap(int width, int height, float cellSize)
    {
        this.Width = width;
        this.Height = height;
        this.CellSize = cellSize;
        this.Blocks = new PlaceableGrid[width, height];

        this.Cell = Resources.Load("cell") as GameObject;
        for (int x = 0; x < Blocks.GetLength(0); x++)
        {
            for (int y = 0; y < Blocks.GetLength(1); y++)
            {
                var cell = IWorld.Generate(this.Cell, 
                    GetWorldPosition(x, y) 
                    + new Vector3(this.CellSize, this.CellSize) * 0.5f, 
                    GameObject.Find("GridMapTest").transform);

                cell.GetComponent<PlaceableGrid>().SetXY(x, y);
                cell.transform.GetChild(1).GetComponent<TextMesh>().text = $"({x}, {y})";

                this.Blocks[x, y] = cell.GetComponent<PlaceableGrid>();
            }
        }
    }

    public Vector3 GetWorldPosition(int x, int y) => new Vector3(x, y) * this.CellSize;

    public void GetGridPosition(Vector3 worldPosition, out int x, out int y)
    {
        x = Mathf.FloorToInt((worldPosition - Vector3.zero).x / CellSize);
        y = Mathf.FloorToInt((worldPosition - Vector3.zero).y / CellSize);
    }

    public PlaceableGrid GetGrid(int x, int y) =>
        this.Blocks[x, y];
}