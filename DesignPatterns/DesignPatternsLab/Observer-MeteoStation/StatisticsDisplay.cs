using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Observer_MeteoStation
{
    class StatisticsDisplay : IObserver, IDisplay
    {
        private float avgTemp;
        private List<float> allTemp;

        private ISubject data;

        public StatisticsDisplay(ISubject d)
        {
            this.data = d;
            d.RegisterObserver(this);
            allTemp = new List<float>();
        }

        public void Update(float temp, float humidity, float pressure)
        {
            CalcAvgTemp(temp);
            Display();
        }

        public void Display()
        {
            Console.WriteLine("I third observer - Average Statictisc Display");
            Console.WriteLine("Average t = " + avgTemp);
            Console.WriteLine();
        }

        private void CalcAvgTemp(float t)
        {
            allTemp.Add(t);
            avgTemp = allTemp.Average();
        }
    }
}
