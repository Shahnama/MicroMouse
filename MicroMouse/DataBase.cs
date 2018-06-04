using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroMouse
{
    class DataBase
    {
        public static bool[,,] wall = new bool[2, Setting.mazeSize.Width+1, Setting.mazeSize.Height+1];  // 0:Horizental 1:Vertical
        DataBase()
        {
            initMap();
        }

        public static void initMap()
        {
            for (int p = 0; p < wall.GetLength(0); p++)
                for (int x = 0; x < wall.GetLength(1); x++)
                    for (int y = 0; y < wall.GetLength(2); y++)
                        wall[p, x, y] = true;
        }
    }
}
