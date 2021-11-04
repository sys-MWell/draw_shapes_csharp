using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Exercise_4
{
    public class Square : Shape
    {
        public Square(int shapeX, int shapeY, int height, int width, Color penColour) : base(shapeX, shapeY, height, width, penColour)
        {

        }

        public override void Draw(Graphics g)
        {
            Pen penColour = new Pen(PenColour, 2);
            Rectangle square = new Rectangle(ShapeX, ShapeY, Width, Height);
            g.DrawRectangle(penColour, square);
        }
    }
}
