using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer_MeteoStation
{
    interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}
