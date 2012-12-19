using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySingleton_Exercise6
{
    class Singleton
    {
        private static Singleton _instance = null;

        private static int count = 0;

        private Singleton()
        {
            count += 1;
        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {      
                _instance = new Singleton();
            }
            Console.Write(count.ToString() + " ");
            return _instance;
        }

        public string Count { get { return count.ToString(); } }
    }
}
