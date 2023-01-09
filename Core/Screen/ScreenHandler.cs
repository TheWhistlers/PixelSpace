using System;
using System.Collections.Generic;
using UnityEngine;

public interface IScreenHandler
{
    public abstract void Render(ScreenRenderer renderer);
}

public class PlayerScreenHandler : IScreenHandler
{
    public void Render(ScreenRenderer renderer)
    {
        renderer.CreateText("test_text",
            new Vector2(renderer.ScreenWidth / 2, renderer.ScreenHeight / 2),
            new Vector2(250f, 250f),
            new StringText(Items.BRONZE_INGOT.GetDisplayName()));
    }
}