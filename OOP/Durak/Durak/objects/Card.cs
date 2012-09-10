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
        #region fields
        /// <summary>
        /// private field for card number
        /// </summary>
        private readonly int _number;

        /// <summary>
        /// private field for card suit
        /// </summary>
        private readonly Suits _suit;

        #endregion

        #region constructors
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="number">number of card</param>
        /// <param name="suit">suit of card</param>
        public Card(int number, Suits suit)
        {
            _number = number;
            _suit = suit;
        }
        #endregion

        #region properties
        /// <summary>
        /// Property Number (get and set)
        /// </summary>
        public int Number
        {
            get { return _number; }
        }

        /// <summary>
        /// Property Suit (get and set)
        /// </summary>
        public Suits Suit
        {
            get { return _suit; }
        }
        #endregion


        #region methods
        /// <summary>
        /// Overide object.ToString()
        /// </summary>
        /// <returns>String declaration of card</returns>
        public override string ToString()
        {
            return Number.ToString() + " of " + Suit.ToString();
        }
        #endregion
    }
}
