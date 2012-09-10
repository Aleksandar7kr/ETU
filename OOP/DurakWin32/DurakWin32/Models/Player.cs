using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Durak
{
    public class Player
    {
        private static int _nextId = 0;

        private readonly int _id;
        private List<objects.Card> _hand;

        public Player()
        {
            _id = NextId();
            _hand = new List<objects.Card>();
        }

        public int Id
        {
            get { return _id; }
        }

        public int CardCount
        {
            get { return _hand.Count; }
        }

        public List<objects.Card> Hand
        {
            get { return _hand; }
        }

        public objects.Card Attack(List<int> possibleNumbers)
        {
            foreach (int number in possibleNumbers)
            {
                foreach (objects.Card c in _hand)
                {
                    if (c.Number == number)
                    {
                        _hand.Remove(c);
                        return c;
                    }
                }
            }
            return null;
        }

        public objects.Card Defence(objects.Card card, objects.Suits suit)
        {
            if (card.Suit == suit)
            {
                foreach (objects.Card c in _hand)
                {
                    if (c.Suit == suit && c.Number > card.Number)
                    {
                        _hand.Remove(c);
                        return c;
                    }
                }
                return null;
            }
            else
            {
                foreach (objects.Card c in _hand)
                {
                    if ((c.Suit == card.Suit && c.Number > card.Number) || (c.Suit == suit))
                    {
                        _hand.Remove(c);
                        return c;
                    }
                }
                return null;
            }
        }

        public objects.Card Attack(int i)
        {
            if (i > 0 && i < _hand.Count)
            {
                objects.Card c = _hand[i];
                _hand.RemoveAt(i);
                return c;
            }
            return null;
        }

        public objects.Card Defence(int i)
        {
            if (i > 0 && i < _hand.Count)
            {
                objects.Card c = _hand[i];
                _hand.RemoveAt(i);
                return c;
            }
            return null;
        }

        public objects.Card FirstAttack()
        {
            objects.Card c = _hand[0];
            _hand.Remove(c);
            return c;
        }

        public void CardToHand(objects.Card card)
        {
            _hand.Add(card);
        }

        private static int NextId()
        {
            return _nextId++;
        }
    }
}
