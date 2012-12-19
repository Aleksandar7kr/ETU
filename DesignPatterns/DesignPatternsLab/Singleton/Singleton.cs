using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    public class Singleton
    {
        protected static int name = 0;

        protected Singleton()
        {
            name += 1;
            Console.WriteLine("Singleton has been planted");
        }

        public static Singleton Instance
        {
            get { return SingletonCreator.Instance; }
        }

        public string getName
        {
            get { return name.ToString(); }
        }

        private sealed class SingletonCreator
        {
            private static readonly Singleton instance = new Singleton();
            public static Singleton Instance { get { return SingletonCreator.instance; } }
        }
    }

}
