using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Durak.objects;

namespace Durak
{
    /// <summary>
    
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            Deck deck = new Deck36();
            int i = 0;
            for (i = 0; !deck.isEmpty(); i++)
            {
                Card test = deck.GiveNextCard();
                Console.WriteLine(test.ToString());
            }

            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
