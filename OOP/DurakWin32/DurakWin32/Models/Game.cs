using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Durak.objects;

namespace Durak
{
    public enum userActionType
    {
        attack, defence, take, end
    }

    public class Game
    {
        private static int _gameNumber = 0;
        private static int _cpuWin = 0;
        private static int _userWin = 0;

        private Durak.Deck _deck;
        private Durak.Player _cpuPlayer;
        private Durak.Player _userPlayer;
        private Durak.Table _table;
     //   private Durak.Battle _battle;

        private Durak.objects.Suits _gameSuit;
        public Durak.objects.Card _lastCard;

        public UserTableManager m;
        public int state = 1;

        public Game()
        {
            InitGame();
            _table = new Table(6, _gameSuit);
            m = new UserTableManager(_userPlayer, _cpuPlayer, _deck, _gameSuit, _table,1);
        }

        public void InitGame()
        {
            _gameNumber++;
            _deck = new Durak.Deck36();
            _cpuPlayer = new Durak.Player();
            _userPlayer = new Durak.Player();
            _lastCard = _deck.GiveNextCard();
            _gameSuit = _lastCard.Suit;

            for (int i = 0; i < 6; i++)
            {
         //       _userPlayer.CardToHand(_deck.GiveNextCard());
         //       _cpuPlayer.CardToHand(_deck.GiveNextCard());
            }
        }

        public static void CpuWin()
        {
            _cpuWin++;
        }
        public static void UserWin()
        {
            _userWin++;
        }
        public static int GameNumber
        {
            get { return _gameNumber; }
        }

        public Player User
        {
            get { return _userPlayer; }
        }

        public Player Cpu
        {
            get { return _cpuPlayer; }
        }

        public Table GameTable
        {
            get { return _table; }
        }

        public void UserAction(userActionType action, Card c)
        {
            switch (action)
            {
                case userActionType.attack:
                    {
                        if (m.Att(c))
                        {
                            _userPlayer.Hand.Remove(c);
                            if (m.End)
                            {
                                _table.Clear();
                                m = new UserTableManager(_userPlayer, _cpuPlayer, _deck, _gameSuit, _table,1);
                            }
                        }
                        else
                        {
                            _userPlayer.Hand.Add(c);
                        }
                        break;
                    }
                case userActionType.defence:
                    {
                        if (!m.End)
                        {
                            if (m.Def(c))
                            {
                                _userPlayer.Hand.Remove(c);
                                if (_table.isAllDefence())
                                {
                                    _table.Clear();
                                    m = new UserTableManager(_userPlayer, _cpuPlayer, _deck, _gameSuit, _table,0);
                                }
                            };
                        }
                        else
                        {
                            _table.Clear();
                            m = new UserTableManager(_userPlayer, _cpuPlayer, _deck, _gameSuit, _table,1);
                        }
                        break;
                    }
                case userActionType.take:
                    {
                        m.Take(_userPlayer);
                        _table.Clear();
                        m = new UserTableManager(_userPlayer, _cpuPlayer, _deck, _gameSuit, _table,1);
                        break;
                    }
                case userActionType.end:
                    {
                        _table.Clear();
                        m = new UserTableManager(_userPlayer, _cpuPlayer, _deck, _gameSuit, _table,1);
                        break;
                    }
            }
        }
    }

    public class UserTableManager
    {
        Player _u;
        Player _c;
        Table _t;
        Deck _d;
        Suits _s;

        bool end;


        public UserTableManager(Player u, Player c, Deck d, Suits s, Table t, int state)
        {
            _u = u; _c = c; _d = d; _s = s; _t = t;
            end = false;
            if (state == 1)
            {
                while (_u.CardCount < 6 && !_d.isEmpty())
                {
                    _u.CardToHand(_d.GiveNextCard());
                }
                while (_c.CardCount < 6 && !_d.isEmpty())
                {
                    _c.CardToHand(_d.GiveNextCard());
                }
                _t.PutToAttack(_c.Hand[0]);
                _c.Hand.RemoveAt(0);
            }
            else
            {
                while (_c.CardCount < 6 && !_d.isEmpty())
                {
                    _c.CardToHand(_d.GiveNextCard());
                }
                while (_c.CardCount < 6 && !_d.isEmpty())
                {
                    _c.CardToHand(_d.GiveNextCard());
                }
            }
        }

        public bool Def(Card card)
        {
            if (_t.PutToDefence(card))
            {
                Card att = _c.Attack(_t.GetCanPutNumber());
                if (att != null)
                {
                    _t.PutToAttack(att);
                }
                else
                {
                    end = true;
                }
                return true;
            }
            return false;
        }

        public bool Att(Card card)
        {
            if (_t.PutToAttack(card))
            {
                Card defCard = _c.Defence(card, _s);
                if (defCard != null)
                {
                    _t.PutToDefence(defCard);
                    return true;
                }
                Take(_c);
                end = true;
                return true;
            }
            return false;
        }

        public bool Take(Player p)
        {
            foreach (Card card in _t.AttackCards)
            {
                p.CardToHand(card);
            }
            foreach (Card card in _t.DefenceCards)
            {
                p.CardToHand(card);
            }
            _t.Clear();
            return true;
        }

        public bool End
        {
            get { return end; }
        }
    }
}
