using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroMouse
{
    class Graphic
    {


        public void DrawMaze(ref Bitmap InputImage)
        {
            Graphics InputGraphics;
            InputGraphics = Graphics.FromImage(InputImage);
            DrawPost(ref InputGraphics);
            drawWalls(ref InputGraphics);
        }

        private void DrawPost(ref Graphics InputGraphic)
        {
            List<RectangleF> AllPost = new List<RectangleF>();
            AllPost.Clear();
            for (int x = 0; x <= Setting.mazeSize.Width; x++)
                for (int y = 0; y <= Setting.mazeSize.Height; y++)
                    AllPost.Add( new RectangleF(
                        new PointF(x*Setting.cellSize.Width,y* Setting.cellSize.Height),
                                        Setting.PostSize));
            InputGraphic.FillRectangles(new SolidBrush(Color.Red), AllPost.ToArray());
        }

        void drawWalls(ref Graphics InputGraphic)
        {
            List<RectangleF> WallRectangles = new List<RectangleF>();
            WallRectangles.Clear();
            for (int p = 0; p < DataBase.wall.GetLength(0); p++)
                for (int x = 0; x < DataBase.wall.GetLength(1); x++)
                    for (int y = 0; y < DataBase.wall.GetLength(2); y++)
                    {
                        if (p == 0 && x != 16)// p=0 Horizental Wall , only 16horizental wall 
                        {
                            if (DataBase.wall[p, x, y])
                                WallRectangles.Add(new RectangleF(new PointF(Setting.PostSize.Width + x * Setting.cellSize.Width,
                                        y * Setting.cellSize.Height), new SizeF(Setting.WallSize.Width, Setting.PostSize.Height)));
                        }
                        else if (p == 1 && y != 16)// Vertical Wall
                        {
                            if (DataBase.wall[p, x, y])
                                WallRectangles.Add(new RectangleF(new PointF(x * Setting.cellSize.Width,
                                     Setting.PostSize.Height + y * Setting.cellSize.Height), new SizeF( Setting.PostSize.Width, Setting.WallSize.Height)));
                        }
                    }
            //Console.WriteLine(WallRectangles.Count);
            InputGraphic.FillRectangles(new SolidBrush(Color.Black), WallRectangles.ToArray());
        }
    }
}
