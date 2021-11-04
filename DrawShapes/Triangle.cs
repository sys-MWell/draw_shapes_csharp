using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Exercise_4
{
    public class Triangle : Shape
    {
        public Triangle(int shapeX, int shapeY, int height, int width, Color pencolour) : base(shapeX, shapeY, height, width, pencolour)
        {

        }
        public override void Draw(Graphics g)
        {
            Pen penColour = new Pen(PenColour, 2);
            //Generates triangle using DrawPolygon method
            Point[] points = new Point[3];
            points[0] = new Point(ShapeX, ShapeY);
            points[1] = new Point(ShapeX + (Width / 2), ShapeY + Height);
            points[2] = new Point(ShapeX + Width, ShapeY);
            g.DrawPolygon(penColour, points);
        }
    }
}
