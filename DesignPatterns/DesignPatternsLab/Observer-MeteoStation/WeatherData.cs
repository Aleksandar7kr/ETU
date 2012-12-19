using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Observer_MeteoStation
{
    class WeatherData : ISubject
    {
        private ArrayList observers;
        private float temp;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);     
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(temp, humidity, pressure);
            }
        }

        public void MeasurementChange()
        {
            NotifyObservers();
        }

        public void SetMeasurement(float t, float h, float p)
        {
            this.temp = t;
            this.humidity = h;
            this.pressure = p;
            MeasurementChange();
        }
    }
}
