using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer_MeteoStation
{
    class ConditionsDisplay : IObserver, IDisplay
    {
        private float temp;
        private float humidity;
        private float pressure;

        private ISubject data;

        public ConditionsDisplay(ISubject d)
        {
            this.data = d;
            d.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("I first observer - Current condition display");
            Console.WriteLine("Curent condition: t = " + temp + " h = " + humidity + " p = " + pressure);
            Console.WriteLine();
        }
    }
}
