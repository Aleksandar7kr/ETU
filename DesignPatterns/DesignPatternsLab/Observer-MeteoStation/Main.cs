using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer_MeteoStation
{
    class MainClass
    {
        static void Main(string[] args)
        {
            WeatherData wd = new WeatherData();

            ConditionsDisplay current = new ConditionsDisplay(wd);
            MobilePhone phone = new MobilePhone(wd);
            StatisticsDisplay stat = new StatisticsDisplay(wd);

            wd.SetMeasurement(29f, 65f, 30.4f);
            wd.SetMeasurement(29.4f, 70f, 31.2f);

            wd.RemoveObserver(stat);

            wd.SetMeasurement(31f, 75f, 33.3f);

            Console.Read();
        }
    }
}
