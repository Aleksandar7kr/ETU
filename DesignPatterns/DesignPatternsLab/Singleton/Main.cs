using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class MainClass
    {
        static void Main(string[] args)
        {
            FirstClass first = new FirstClass();
            SecondClass second = new SecondClass();
            Console.WriteLine("Singleton name in firstclass: " + first.getName());
            Console.WriteLine("Singleton name in secondtclass: " + second.getName());
            Console.Read();
        }
    }
}
