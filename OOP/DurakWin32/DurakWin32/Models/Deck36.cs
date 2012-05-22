using System;
using System.Collections;
using System.Linq;
using System.Text;

using Durak.objects;

namespace Durak
{
    class Deck36 : Deck
    {
        public Deck36() : base(Constants.DECK_36)
        {
        }

        public override Card GenerateNextCard(int cardCode)
        {
            int number = 6 + (cardCode % 9);
            Suits suit = (Suits)Convert.ToInt32(cardCode / 9);
            return new Card(number, suit);
        }
    }
}