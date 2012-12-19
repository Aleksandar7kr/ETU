using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    public class FirstClass
    {
        Singleton single = Singleton.Instance;
        public FirstClass() { }
        public string getName()
        {
            return single.getName;
        }
    }

    public class SecondClass
    {
        Singleton single = Singleton.Instance;
        public SecondClass() { }
        public string getName()
        {
            return single.getName;
        }
    }

}
