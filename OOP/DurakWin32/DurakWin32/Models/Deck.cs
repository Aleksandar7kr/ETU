using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Durak.objects;

namespace Durak
{
    public abstract class Deck  
    {
        protected readonly int _fullDeckSize; // full deck size: 36 or 52 or ??
        protected System.Collections.Generic.List<int> _cards;       // codes for card in the deck: range 1-deckSize

        public Deck(int fullSize)
        {
            _fullDeckSize = fullSize;
            _cards = new List<int>();
            for (int i = 0; i < _fullDeckSize; ++i)
            {
                _cards.Add(i);
            }
        }

        public Card GiveNextCard()
        {
            if (isEmpty()) return null;

            int randomIndex = new Random().Next(99999) % _cards.Count;
            int cardCode = Convert.ToInt32(_cards[randomIndex]);
            _cards.RemoveAt(randomIndex);
            return GenerateNextCard(cardCode);
        }

        public int GetDeckSize()
        {
            return _fullDeckSize;
        }

        public int GetCapacity()
        {
            return _cards.Count;
        }

        public bool isEmpty()
        {
            return _cards.Count == 0;
        }

        public abstract Card GenerateNextCard(int cardCode);
    }
}
    