using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOP
{
    class Rectangle : Shape
    {
        private float _height;
        private float _width;

        public Rectangle (float height, float width)
        {
            _height = height;
            _width = width;
        }

        public float Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public float Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public override float CalculateArea()
        {
            return _height * _width;
        }


        public override float CalculatePerimeter()
        {
            return (_height * 2) + (_width * 2);
        }

    }
}
