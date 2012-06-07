using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Durak
{
    class Player
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

        public void WatchingTable()
        {
            ;
        }

        public void Attack()
        {
            ;
        }

        public void Defence()
        {
            ;
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
