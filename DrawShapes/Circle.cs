using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    public class Circle : Shape
    {
        public Circle(int shapeX, int shapeY, int height, int width, Color pencolour) : base(shapeX, shapeY, height, width, pencolour)
        {
        }

        public override void Draw(Graphics g)
        {
            Pen penColour = new Pen(PenColour, 2);
            Rectangle circle = new Rectangle(ShapeX, ShapeY, Width, Height);
            g.DrawEllipse(penColour, circle); //draw circle
        }
    }
}
