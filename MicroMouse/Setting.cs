using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroMouse
{
    class Setting
    {
        private static float GraphicScale = 3.0F; 
        public static Size mazeSize = new Size(16, 16); // 16x16 Cell IEEE classix maze size
        public static SizeF cellSize = new SizeF(18* GraphicScale, 18* GraphicScale); // 18x18 cm IEEE classic maze size
        public static SizeF PostSize = new SizeF(cellSize.Width / 12.0F, cellSize.Height / 12.0F); // Post 1.5cm and wall 16.5cm
        public static SizeF WallSize = new SizeF(cellSize.Width - PostSize.Width, cellSize.Height - PostSize.Height); // Post 1.5cm and wall 16.5cm
    }
}
