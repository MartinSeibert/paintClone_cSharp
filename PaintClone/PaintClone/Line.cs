using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing;

namespace PaintClone
{
    class Line: Shape
    {
        public Line()
        { 
        
        }
        public Line(int x_in, int y_in, int width_in, int height_in, Color color_in, Boolean dashed_in, int thickness_in, 
            Boolean filled_in, int alpha_in, Boolean gradient_in, Color gradient1_in, Color gradient2_in, Boolean cyclic_in) 
        {
            this.x = x_in;
            this.y = y_in;
            this.width = width_in;
            this.height = height_in;
            this.color = color_in;
            this.dashed = dashed_in;
            this.thickness = thickness_in;
            this.filled = filled_in;
            this.alpha = alpha_in;
            this.gradient = gradient_in;
            this.gradient1 = gradient1_in;
            this.gradient2 = gradient2_in;
            this.cyclic = cyclic_in;

        }
        public override void Draw()
        {
            throw new NotImplementedException();
        }
        public override void Draw(Image im)
        {
            throw new NotImplementedException();
        }
        
    }
}
