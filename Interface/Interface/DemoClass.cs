using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class DemoClass : FirstPerson, SecondPerson
    {
        public void firstMethod()
        {
            Console.WriteLine("Wasim Akram");
        }
        public void secondMethod()
        {
            Console.WriteLine("Shuvo");
        }
    }
}
