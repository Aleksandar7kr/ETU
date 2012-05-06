using System;
using System.Collections;
using System.Linq;
using System.Text;

using Durak.objects;

namespace Durak
{
    abstract class Deck  
    {
        protected readonly int deckSize; // full deck size: 36 or 52 or ??
        protected ArrayList cards;       // codes for card in the deck: range 1-deckSize

        public Deck(int fullSize)
        {
            deckSize = fullSize;
            cards = new ArrayList();
            for (int i = 0; i < deckSize; ++i) cards.Add(i);
        }

        public Card GiveNextCard()
        {
            if (isEmpty()) return null;

            int randomIndex = new Random().Next(cards.Count);
            int cardCode = Convert.ToInt32(cards[randomIndex]);
            cards.RemoveAt(randomIndex);
            return GenerateNextCard(cardCode);
        }

        public int GetDeckSize()
        {
            return deckSize;
        }

        public int GetCapacity()
        {
            return cards.Count;
        }

        public bool isEmpty()
        {
            return cards.Count == 0;
        }

        abstract public Card GenerateNextCard(int cardCode);
    }
}
    