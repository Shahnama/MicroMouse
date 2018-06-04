using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroMouse
{
    public partial class Enviroment_Form : Form
    {
        Graphic Main_Graphic = new Graphic();
        Bitmap MainCanvas;
        public Enviroment_Form()
        {
            InitializeComponent();
        }

        private void Enviroment_Load(object sender, EventArgs e)//
        {
            DataBase.initMap();
            PictureBox_MainCanvas.Size = Size.Round(
                                new SizeF(Setting.mazeSize.Width*Setting.cellSize.Width+Setting.PostSize.Width ,
                                            Setting.mazeSize.Height * Setting.cellSize.Height + Setting.PostSize.Height));
            MainCanvas = new Bitmap(PictureBox_MainCanvas.Size.Width, PictureBox_MainCanvas.Size.Height);
            this.Size = new Size(PictureBox_MainCanvas.Size.Width + 200 , PictureBox_MainCanvas.Size.Height + 100);
            Main_Graphic.DrawMaze(ref MainCanvas);
        }

        private void PictureBox_MainCanvas_Paint(object sender, PaintEventArgs e)
        {
           // e.Graphics.Clear(Color.Blue);
            e.Graphics.DrawImage(MainCanvas , 0,0);
        }
    }
}
