using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySingleton_Exercise6
{
    class MainClass
    {
        static void Main(string[] args)
        {
            List<Singleton> singletonList = new List<Singleton>();
            List<NotSingleton> notSingletonList = new List<NotSingleton>();

            for (int i = 0; i < 10; ++i)
            {
                singletonList.Add(Singleton.GetInstance());
            }
            Console.WriteLine();
            for (int i = 0; i < 10; ++i)
            {
                notSingletonList.Add(new NotSingleton());
            }

            Console.ReadKey();
        }
    }
}
