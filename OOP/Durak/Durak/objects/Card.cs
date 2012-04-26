using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Durak.objects
{
    class Card
    {
        private int _number;
        private Suits _suit;


        public Card(int number, Suits suit)
        {
            Number = number;
            Suit = suit;
        }

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public Suits Suit
        {
            get { return _suit; }
            set { _suit = value; }
        }
    }
}
