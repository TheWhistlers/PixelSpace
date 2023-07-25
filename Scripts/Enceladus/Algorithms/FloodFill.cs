using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whistler.Enceladus.Algorithms
{
    public struct FloodFill
    {
        public static void FloodFill2D(float[,] target, int x, int y, float prev, float now)
        {
            int MaxX = target.GetLength(0), MaxY = target.GetLength(1);

            if (x < 0 || x >= MaxX || y < 0 || y >= MaxY)
                return;

            if (target[x, y] != prev)
                return;

            target[x, y] = now;

            FloodFill2D(target, x + 1, y, prev, now);
            FloodFill2D(target, x - 1, y, prev, now);
            FloodFill2D(target, x, y + 1, prev, now);
            FloodFill2D(target, x, y - 1, prev, now);
        }
    }
}
