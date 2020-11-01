using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOP
{
    class Square : Shape
    {
        private float _side;

        public Square (float side)
        {
            _side = side;
        }

        public float Side
        {
            get { return _side; }
            set { _side = value; }
        }
        public override float CalculateArea()
        {
            return _side * _side;
        }


        public override float CalculatePerimeter()
        {
            return _side * 4;
        }
    }
}
