using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Durak.objects;

namespace Durak
{
    class Deck36andJorers : Deck
    {
        public Deck36andJorers() : base(Constants.DECK_36_AND_2_JOKERS)
        {
        }

        public override objects.Card GenerateNextCard(int cardCode)
        {
            if (cardCode >= Constants.DECK_36)
            {
                return new Card(999, Suits.Joker);
            }
            int number = 6 + (cardCode % 9);
            Suits suit = (Suits)Convert.ToInt32(cardCode / 9);
            return new Card(number, suit);
        }
    }
}
