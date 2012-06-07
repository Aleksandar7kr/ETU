using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Durak
{
    class Round
    {
        private readonly Deck _deck;
        private readonly Queue<Player> _players;
        private readonly int _defenceId;
        private List<KeyValuePair<objects.Card, objects.Card>> _table;
        
        public Round(Deck deck, Queue<Player> players, int defId)
        {
            _table = new List<KeyValuePair<objects.Card,objects.Card>>();
            _defenceId = defId;
            _players = players;
            _deck = deck;
        }

        public bool RunRound()
        {
            return true;
        }

        private bool EndRound()
        {     
            return true;
        }
    }
}
