using System;

namespace Partial_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.age);
            Console.WriteLine(obj.weight);
            Console.WriteLine(obj.height);
            obj.Method();
        }
    }
}
