﻿using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface IScreenHandler
{
    public abstract void Render(ScreenRenderer renderer);
}

public class PlayerScreenHandler : IScreenHandler
{
    public void Render(ScreenRenderer renderer)
    {
        var pms = renderer.CreateSlider("player_movement_slider",
            new Vector2(-470f, -305f),
            new Vector2(566f, 80f), -1f, 1f);

        pms.value = 0f;
        ColorUtility.TryParseHtmlString("#FFFFFF00",
            out Color pms_color);
        pms.transform.GetChild(1).GetChild(0).GetComponent<Image>().color = pms_color;
        pms.transform.GetChild(2).GetChild(0).GetComponent<RectTransform>().sizeDelta
            = new Vector2(80f, 0f);

        renderer.CreateButtonNoText("player_jump_button",
            new Vector2(1980f / 2f, 1080f / 2f),//730f, -240f
            new Vector2(150, 150f),
            GameObject.Find("Player").GetComponent<PlayerMovement>().Jump);
    }
}