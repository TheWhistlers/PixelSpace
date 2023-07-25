using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTest : MonoBehaviour
{
    public static GridMap Map;
    
    private void Start()
    {
        Map = new GridMap(10, 10, 1f);
            
    }

    void Update()
    {
        float height = Mathf.Sin(3f * Time.time) + 5f;
        
        Vector3 pos = transform.position;
        pos.y = height;
        transform.position = pos;

        transform.Translate(Vector3.right * Time.deltaTime);
    }
}