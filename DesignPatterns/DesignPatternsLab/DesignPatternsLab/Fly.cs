using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsLab
{
    class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            System.Console.WriteLine("I can fly");
        }
    }

    class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            System.Console.WriteLine("I can`t fly");
        }
    }
}
