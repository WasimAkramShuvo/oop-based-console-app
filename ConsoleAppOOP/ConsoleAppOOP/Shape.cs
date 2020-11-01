using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOP
{
    public abstract class Shape
    {
        private float _area;
        private float _perimeter;

        public float Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public float Perimeter
        {
            get { return _perimeter; }
            set { _perimeter = value; }
        }

        public abstract float CalculateArea();

        public abstract float CalculatePerimeter();

    }
}
