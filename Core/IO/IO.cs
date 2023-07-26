using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public interface IO
{
    public static void SaveSections(LocalWorld world)
    {
        var folder = $@"{GameManager.Persistent}/games/worlds/{world.Name}/sections";

        for (int i = 0; i < world.Sections.Count; i++)
        {
            var section = world.Sections[i];
            var path = Path.Combine(folder, $"section_{i}");

            using var writer = new StreamWriter(path);

            for (int x = 0; x < section.Blocks.GetLength(0); x++)
            {
                for (int y = 0; y < section.Blocks.GetLength(1); y++)
                {
                    writer.WriteLine($"{section.Blocks[x, y].Block.Prototype.KeyName}:{section.Blocks[x, y].Block.Position}"); ;

                    writer.Close();
                }
            }
        }
    }
}