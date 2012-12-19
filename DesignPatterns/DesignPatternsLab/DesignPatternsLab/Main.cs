using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsLab
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();
            Duck wood = new WoodDuck();
            wood.performQuack();
            wood.performFly();
            System.Console.ReadKey();
        }
    }
}
