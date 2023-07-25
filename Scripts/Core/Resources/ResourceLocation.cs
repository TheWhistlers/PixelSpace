using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class ResourceLocation
{
    public string Location { get; set; }
    
    public ResourceLocation(string location)
    {
        this.Location = location;
    }
    
    public Sprite LoadAsTexture(int width = 16, int height = 16)
    {
        var texture = new Texture2D(width, height);

        texture.LoadImage(LoadAsBinary());
        texture.filterMode = FilterMode.Point;

        return ToSprite(texture);
    }

    private Sprite ToSprite(Texture2D texture)
    {
        var rect = new Rect(0, 0, texture.width, texture.height);
        var pivot = new Vector2(.5f, .5f);

        return Sprite.Create(texture, rect, pivot);
    }

    public byte[] LoadAsBinary()
    {
        byte[] data = new byte[1024 * 1024 * 5];

        if ((!string.IsNullOrEmpty(Location)) && File.Exists(Location))
        {
            using FileStream fs = File.OpenRead(Location);
            int fileLength = (int) fs.Length;
            data = new byte[fileLength];
            fs.Read(data, 0, fileLength);
        }

        return data;
    }

    public Font LoadAsFont()
    {
        return new Font(this.Location);
    }

    public string LoadAsText()
    {
        if (string.IsNullOrEmpty(Location))
            return null;

        using var reader = new StreamReader(this.Location);
        return reader.ReadToEnd();
    }
}
