using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsLab
{
    class Quack : QuackBehavior
    {
        public void quack()
        {
            System.Console.WriteLine("Quack");
        }
    }

    class Slience : QuackBehavior
    {
        public void quack()
        {
            System.Console.WriteLine("Silence");
        }
    }

}
