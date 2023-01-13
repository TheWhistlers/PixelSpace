using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTest : MonoBehaviour
{
    public GridMap Map;
    
    private void Start()
    {
        Map = new GridMap(10, 10, 1f);
    }
}
