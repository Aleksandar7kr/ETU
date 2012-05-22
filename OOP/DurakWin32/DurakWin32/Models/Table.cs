using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Durak.objects;

namespace Durak
{
    public class Table
    {
        private readonly List<Card> _attackCard;
        private readonly List<Card> _defenceCard;

        private int _maxAttackCard;
        private Suits _suit;

        public Table(int max, Suits suit)
        {
            _attackCard = new List<Card>();
            _defenceCard = new List<Card>();
            _maxAttackCard = max;
            _suit = suit;
        }

        public int CountAttackCards
        {
            get { return _attackCard.Count; }
        }

        public int CountDefenceCards
        {
            get { return _defenceCard.Count; }
        }

        public bool PutToAttack(Card c)
        {
            if (CountAttackCards < _maxAttackCard)
            {
                _attackCard.Add(c);
                return true;
            }
            return false;
        }

        public bool PutToDefence(Card c)
        {
            if (c.Suit == _suit)
            {
                if (_attackCard[_defenceCard.Count].Suit == _suit)
                {
                    if (c.Number < _attackCard[_defenceCard.Count].Number)
                    {
                        _defenceCard.Add(c);
                        return true;
                    }
                    return false;
                }
                else
                {
                    _defenceCard.Add(c);
                    return true;
                }
            }
            else
            {
                if (c.Suit == _attackCard[_defenceCard.Count].Suit)
                {
                    if (c.Number < _attackCard[_defenceCard.Count].Number)
                    {
                        _defenceCard.Add(c);
                        return true;
                    }
                    return false;
                }
                return false;
            }
        }

        public HashSet<int> GetCanPutNumber()
        {
            HashSet<int> maybe = new HashSet<int>();
            for (int i = 0; i < _attackCard.Count; i++)
            {
                maybe.Add(_attackCard[i].Number);
            }
            for (int i = 0; i < _defenceCard.Count; i++)
            {
                maybe.Add(_defenceCard[i].Number);
            }
            return maybe;
        }

        public bool isAllDefence()
        {
            return _attackCard.Count == _defenceCard.Count;
        }

        public List<Card> AttackCards
        {
            get { return _attackCard; }
        }
        public List<Card> DefenceCards
        {
            get { return _defenceCard; }
        }
    }
}
