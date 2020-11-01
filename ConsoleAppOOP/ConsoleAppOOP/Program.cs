using System;

namespace ConsoleAppOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new Shape[5];

            var aCircle = new Circle(15);
            var aRectangle = new Rectangle(5, 10);
            var aSquare = new Square(7);
            
            //shapes[0] = aCircle;
            //shapes[1] = aRectangle;
            //shapes[2] = aSquare;

            Print(aCircle);
            Print(aRectangle);
            Print(aSquare);


        }
        static void Print (Shape shape)
        {
            if(shape is Circle)
            {
                var circle = shape as Circle;
                Console.WriteLine($"Area = {circle.CalculateArea()}");
                Console.WriteLine($"Parameter = {circle.CalculatePerimeter()}\n");
            }
            else if(shape is Rectangle)
            {
                var rectangle = shape as Rectangle;
                Console.WriteLine($"Area = {rectangle.CalculateArea()}");
                Console.WriteLine($"Parameter = {rectangle.CalculatePerimeter()}\n");
            }
            else if (shape is Square)
            {
                var square = shape as Square;
                Console.WriteLine($"Area = {square.CalculateArea()}");
                Console.WriteLine($"Parameter = {square.CalculatePerimeter()}\n");
            }

        }
    }
}
