using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOP
{
    class Circle : Shape
    {
        private float _radius;

        public Circle(float radius)
        {
            _radius = radius;
        }

        public float Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        //override
        public override float CalculateArea()
        {
            return (float)3.14 * _radius * _radius;
        }
        public override float CalculatePerimeter()
        {
            return 2 * (float)3.14 * _radius;
        }
    }
}
