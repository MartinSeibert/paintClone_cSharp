using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing;

namespace PaintClone
{
    abstract class Shape
    {
        // later if I choose to make them private then I will need to setup the set and get for them
        //private int xField;
        //private int yField;
        //private int newxField;
        //private int newyField;
        //private int oldxField;
        //private int oldyField;
        //private int widthField;
        //private int heightField;
        //private int thicknessField;
        //private Color colorField;
        //private Boolean dashedField;
        //private Boolean filledField;
        //private Boolean alphaField;
        //private Boolean gradientField;
        //private Boolean cyclicField;
        //private Boolean acyclicField;
        //private Color gradient1Field;
        //private Color gradient2Field;
        //private Boolean textured;
        public int x;
        public int y;
        public int newx;
        public int newy;
        public int oldx;
        public int oldy;
        public int width;
        public int height;
        public int thickness;
        public Color color;
        
        // I need the c# version of JPanel

        public Boolean dashed;
        public Boolean filled;
        public int alpha;
        public Boolean gradient;
        public Boolean cyclic;
        public Boolean acyclic;
        public Color gradient1;
        public Color gradient2;
        public Boolean textured;

        // I need a c# version of a BufferedImage for the texture image

        // I need two methods for writing and reading an object, so that I can save a project and then open a project
        public abstract void Draw();
        public abstract void Draw(Image im);
    }
}
