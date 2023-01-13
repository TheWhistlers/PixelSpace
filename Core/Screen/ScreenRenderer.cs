using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScreenRenderer
{
    public Canvas TargetCanvas { get; set; }
    public int ScreenWidth { get; set; }
    public int ScreenHeight { get; set; }

    public ScreenRenderer(Canvas canvas)
    {
        this.TargetCanvas = canvas;
        this.ScreenWidth = Mathf.RoundToInt(canvas.GetComponent<RectTransform>().sizeDelta.x);
        this.ScreenHeight = Mathf.RoundToInt(canvas.GetComponent<RectTransform>().sizeDelta.y);
    }

    public Text CreateText(string name, Vector2 position, Vector2 size, StringText text)
    {
        var result = GameManager.Instantiate(GameManager.Instance.TextPrototype);
        result.transform.SetParent(this.TargetCanvas.transform);

        result.name = name;
        result.GetComponent<RectTransform>().position = position;
        result.GetComponent<RectTransform>().sizeDelta = size;
        result.GetComponent<Text>().text = text.GetTextContent();

        return result.GetComponent<Text>();
    }

    public Image CreateImage(string name, Vector2 position, Vector2 size, ResourceLocation location)
    {
        var result = GameManager.Instantiate(GameManager.Instance.ImagePrototype);
        result.transform.SetParent(this.TargetCanvas.transform);

        result.name = name;
        result.GetComponent<RectTransform>().position = position;
        result.GetComponent<RectTransform>().sizeDelta = size;
        result.GetComponent<Image>().sprite = location.LoadAsTexture(Mathf.RoundToInt(size.x), Mathf.RoundToInt(size.y));

        return result.GetComponent<Image>();
    }

    public Button CreateButton(string name, Vector2 position, Vector2 size, StringText text, UnityAction callback)
    {
        var result = GameManager.Instantiate(GameManager.Instance.ButtonPrototype);
        result.transform.SetParent(this.TargetCanvas.transform);
        var label = result.transform.GetChild(0);

        result.name = name;
        result.GetComponent<RectTransform>().position = position;
        result.GetComponent<RectTransform>().sizeDelta = size;
        result.GetComponent<Button>().onClick.AddListener(callback);
        label.GetComponent<Text>().text = text.GetTextContent();

        return result.GetComponent<Button>();
    }

    public Slider CreateSlider(string name, Vector2 position, Vector2 size, float min, float max)
    {
        var result = GameManager.Instantiate(GameManager.Instance.SliderPrototype);
        result.transform.SetParent(this.TargetCanvas.transform);

        result.name = name;
        result.GetComponent<RectTransform>().position = position;
        result.GetComponent<RectTransform>().sizeDelta = size;

        result.GetComponent<Slider>().minValue = min;
        result.GetComponent<Slider>().maxValue = max;

        return result.GetComponent<Slider>();
    }

    public Button CreateCloseButton(string name, Vector2 position, Vector2 size, StringText text)
    {
        var result = GameManager.Instantiate(GameManager.Instance.ButtonPrototype);
        result.transform.SetParent(this.TargetCanvas.transform);
        var label = result.transform.GetChild(0);

        result.name = name;
        result.GetComponent<RectTransform>().position = position;
        result.GetComponent<RectTransform>().sizeDelta = size;
        label.GetComponent<Text>().text = text.GetTextContent();
        result.GetComponent<Button>().onClick.AddListener(() => this.TargetCanvas.enabled = false);

        return result.GetComponent<Button>();
    }

    public Button CreateButtonNoText(string name, Vector2 position, Vector2 size, UnityAction callback)
    {
        var result = GameManager.Instantiate(GameManager.Instance.ButtonPrototype);
        result.transform.SetParent(this.TargetCanvas.transform);
        var label = result.transform.GetChild(0);

        result.name = name;
        result.GetComponent<RectTransform>().position = position;
        result.GetComponent<RectTransform>().sizeDelta = size;
        result.GetComponent<Button>().onClick.AddListener(callback);

        GameObject.Destroy(label.gameObject);

        return result.GetComponent<Button>();
    }
}