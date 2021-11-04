using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Exercise_4
{
    public abstract class Shape
    {
        int _shapeX;
        int _shapeY;
        int _height;
        int _width;
        Color _penColour;


        public Shape()
        {
            _shapeX = 0;
            _shapeY = 0;
            _height = 0;
            _width = 0;
            _penColour = Color.Blue;
        }

        public Shape(int shapeX, int shapeY, int height, int width, Color penColour)
        {
            _shapeX = shapeX;
            _shapeY = shapeY;
            _height = height;
            _width = width;
            _penColour = penColour;
        }

        public int ShapeX
        {
            get
            {
                return _shapeX;
            }
        }

        public int ShapeY
        {
            get
            {
                return _shapeY;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
        }

        public Color PenColour
        {
            get
            {
                return _penColour;
            }
        }

        public virtual void Draw(Graphics g)
        {
        }
    }
}
