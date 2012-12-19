using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySingleton_Exercise6
{
    class NotSingleton
    {
        private static int count = 0;

        public NotSingleton()
        {  
            count += 1;
            Console.Write(count.ToString() + " ");
        }

        public string Count { get { return count.ToString(); } }
    }
}
