using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PaintClone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int type;           // integer to represent which shape is to be drawn
        int oldx, oldy, newx, newy, alpha;
        // array of points in the java code goes here (the points is used for the freehand drawing tool)
        // will also need a BufferedImage for textures
        Boolean textured;

        List<Shape> shapes = new List<Shape>();
        List<Shape> redo = new List<Shape>();       // to hold the shapes that have been undone
        String text;
        //Image background, foreground;
        Bitmap background, foreground;
        Shape s;
        Color c;
        Color gradient1, gradient2;
        Boolean gradient;

        Boolean dashed;
        Boolean filled;
        Boolean cyclic = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void Form1_Paint(object sender, PaintEventArgs e) 
        {
            

            
        }

        private void controls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            // Testing
            Line l = new Line(this.drawPanel, 15, 15, 0, 0, drawColor.BackColor, false, 0, 
            false, 0, false, System.Drawing.Color.Red, System.Drawing.Color.Red, false);

            l.Draw();
         
        }

        private void greenSlider_Scroll(object sender, EventArgs e)
        {
            this.drawColor.BackColor = Color.FromArgb(255, this.redSlider.Value, this.greenSlider.Value, this.blueSlider.Value);
        }

        private void blueSlider_Scroll(object sender, EventArgs e)
        {
            this.drawColor.BackColor = Color.FromArgb(255, this.redSlider.Value, this.greenSlider.Value, this.blueSlider.Value);
        }

        private void thicknessSlider_Scroll(object sender, EventArgs e)
        {
            this.drawColor.BackColor = Color.FromArgb(255, this.redSlider.Value, this.greenSlider.Value, this.blueSlider.Value);
        }

 

        private void redSlider_Scroll(object sender, EventArgs e)
        {
            this.drawColor.BackColor = Color.FromArgb(255, this.redSlider.Value, this.greenSlider.Value, this.blueSlider.Value);
            // later, textured = false;
        }

        private void drawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (background == null)
            {
                background = new Bitmap(drawPanel.Height, drawPanel.Width);
                Rectangle r = new Rectangle(drawPanel.Location.X, drawPanel.Location.Y, drawPanel.Height, drawPanel.Width);
                drawPanel.DrawToBitmap(background, r);

                oldx = e.X;
                oldy = e.Y;
                alpha = alphaSlider.Value;

                // must add checks here to see if placeText or freeDraw were selected last
            }
        }

        private void drawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            // must getGraphics() of bitmap
           // System.Drawing.Graphics backgroundGraphics = background;
        }
    }
}
