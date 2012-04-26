using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Durak.objects;

namespace Durak
{
    class Deck52 : Deck
    {
        public Deck52() : base(Constants.DECK_52)
        {
        }

        public override Card GenerateNextCard(int cardCode)
        {
            int number = 2 + (cardCode % 13);
            Suits suit = (Suits)Convert.ToInt32(cardCode / 13);
            return new Card(number, suit);
        }
    }
}
