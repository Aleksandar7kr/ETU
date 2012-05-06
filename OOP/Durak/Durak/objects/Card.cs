using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Durak.objects
{
    /// <summary>
    /// Class Card
    /// </summary>
    class Card
    {
        /// <summary>
        /// private field for card number
        /// </summary>
        private int _number;

        /// <summary>
        /// private field for card suit
        /// </summary>
        private Suits _suit;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="number">number of card</param>
        /// <param name="suit">suit of card</param>
        public Card(int number, Suits suit)
        {
            Number = number;
            Suit = suit;
        }

        /// <summary>
        /// Property Number (get and set)
        /// </summary>
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        /// <summary>
        /// Property Suit (get and set)
        /// </summary>
        public Suits Suit
        {
            get { return _suit; }
            set { _suit = value; }
        }

        /// <summary>
        /// Overide object.ToString()
        /// </summary>
        /// <returns>String declaration of card</returns>
        public override string ToString()
        {
            return Number.ToString() + " of " + Suit.ToString();
        }
    }
}
