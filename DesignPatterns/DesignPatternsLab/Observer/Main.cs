using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            Observer Observer = new Observer(subject, "Center", "\t\t");
            Observer observer2 = new Observer(subject, "Right", "\t\t\t\t");
            subject.Go();
            Console.Read();
        }
    }
}
