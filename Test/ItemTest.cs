using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTest : MonoBehaviour
{
    public GameObject DisplayOn, GeneratingItem;

    void Awake()
    {
        GenerateDisplay(Items.TIN_PLATE.AsStack(), Items.BRONZE_PLATE.AsStack(), Items.BRONZE_INGOT.AsStack());
    }

   
    void Update()
    {
        
    }

    private void GenerateDisplay(params ItemStack[] toDisplays)
    {
        for (int i = 0; i < toDisplays.Length; i++)
        {
            var generated = Instantiate(GeneratingItem, DisplayOn.transform);
            var displayName = generated.transform.GetChild(1).gameObject.GetComponent<Text>();
            var displayTexture = generated.transform.GetChild(0).gameObject.GetComponent<Image>();

            displayName.text = $"{toDisplays[i].Base.GetDisplayName()}: [ {toDisplays[i].Count} ]";
            displayTexture.sprite = toDisplays[i].Base.Texture;
        }
    }
}
