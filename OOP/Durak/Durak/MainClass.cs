using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Durak.objects;

namespace Durak
{
    public static class Tests
    {
        public static void DeckTest()
        {
            Deck deck = new Deck36();
            int i = 0;
            for (i = 0; !deck.isEmpty(); i++)
            {
                Card test = deck.GiveNextCard();
                Console.WriteLine(test.ToString());
            }
            Console.WriteLine(i);
        }


        public static void QueueTest()
        {
            Deck d = new Deck36();
            Queue<Card> q = new Queue<Card>();

            while (!d.isEmpty())
            {
                q.Enqueue(d.GiveNextCard());
            }

            for (int i = 0; i < q.Count; i++)
            {
                q.Enqueue(q.Dequeue());
                Console.WriteLine(q.Peek().ToString());
            }
        }

        public static void HashSetTest()
        {
            HashSet<int> s = new HashSet<int>();
            s.Add(1);
            s.Add(2);
            s.Add(1);
            s.Add(3);
            s.Add(1);
            Console.WriteLine(s.Count);
        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Console.ReadKey();
        }
    }
}
