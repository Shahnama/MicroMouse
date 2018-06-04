namespace MicroMouse
{
    partial class Enviroment_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBox_MainCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_MainCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox_MainCanvas
            // 
            this.PictureBox_MainCanvas.Location = new System.Drawing.Point(12, 12);
            this.PictureBox_MainCanvas.Name = "PictureBox_MainCanvas";
            this.PictureBox_MainCanvas.Size = new System.Drawing.Size(340, 340);
            this.PictureBox_MainCanvas.TabIndex = 0;
            this.PictureBox_MainCanvas.TabStop = false;
            this.PictureBox_MainCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_MainCanvas_Paint);
            // 
            // Enviroment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 879);
            this.Controls.Add(this.PictureBox_MainCanvas);
            this.Name = "Enviroment";
            this.Text = "Enviroment";
            this.Load += new System.EventHandler(this.Enviroment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_MainCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_MainCanvas;
    }
}

