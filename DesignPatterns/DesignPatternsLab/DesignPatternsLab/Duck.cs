using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsLab
{
    class Duck
    {
        protected FlyBehavior flybehavior;
        protected QuackBehavior quackbehavior;

        public Duck() { }
        public void performFly()
        {
            flybehavior.fly();
        }
        public void performQuack()
        {
            quackbehavior.quack();
        }
        public void swim() { }
    }


    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackbehavior = new Quack();
            flybehavior = new FlyWithWings();
            System.Console.WriteLine("I MallardDuck");
        }
    }


    class WoodDuck : Duck
    {
        public WoodDuck()
        {
            quackbehavior = new Slience();
            flybehavior = new FlyWithWings();
            System.Console.WriteLine("I WoodDuck");
        }
    }
}
