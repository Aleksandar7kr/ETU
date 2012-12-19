using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer_MeteoStation
{
    interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
