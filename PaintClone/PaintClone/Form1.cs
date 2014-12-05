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
        Image background, foreground;
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
            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            Pen mypen = new Pen(System.Drawing.Color.Red, 5);
            graphicsObj.DrawLine(mypen, 20, 20, 200, 210);
        }
    }
}
