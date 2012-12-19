using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer_MeteoStation
{
    class MobilePhone : IObserver, IDisplay
    {
        private float temp;

        private ISubject data;

        public MobilePhone(ISubject d)
        {
            this.data = d;
            d.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("I second observer - MobilePhone");
            Console.WriteLine("Current t = " + temp);
            Console.WriteLine();
        }
    }
}
