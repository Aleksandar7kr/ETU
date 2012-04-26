using System;
using System.Collections;
using System.Linq;
using System.Text;

using Durak.objects;

namespace Durak
{
    abstract class Deck  
    {
        protected readonly int deckSize;          // full deck size: 36 or 52 or ??
        protected int capacity;          // remain of cards in the deck
        protected ArrayList cards;       // codes for card in the deck: range 1-deckSize

        public Deck(int fullSize)
        {
            capacity = deckSize = fullSize;
            cards = new ArrayList();
            for (int i = 0; i < deckSize; ++i)
            {
                cards.Add(i);
            }
        }

        public Card GiveNextCard()
        {
            if (capacity == 0) return null;

            int randomIndex = new Random().Next(capacity);
            int cardCode = Convert.ToInt32(cards[randomIndex]);
            cards[randomIndex] = cards[capacity-1];
            capacity--;
            return GenerateNextCard(cardCode);
        }

        public int GetDeckSize()
        {
            return deckSize;
        }

        public bool isEmpty()
        {
            return capacity == 0;
        }

        abstract public Card GenerateNextCard(int cardCode);
    }
}
