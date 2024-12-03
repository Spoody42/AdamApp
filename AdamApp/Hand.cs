using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamApp
{
    /// <summary>
    /// a) Creates a private list of a hand of cards
    /// b) Creates a public list of a hand of cards
    /// c) The count is used to for counting how many cards are in a hand
    /// d) Creates a new hand after previous one
    /// e) "Add" will add another card to the hand
    /// </summary>

    internal class Hand
    {
        private List<PlayingCard> _Cards; // a

        public List<PlayingCard> Cards // b
        {
            get { return _Cards; }
        }

        public int Count // c
        {
            get { return _Cards.Count; }
        }

        public Hand() // d
        {
            _Cards = new List<PlayingCard>();
        }

        public void AddCardToHand(PlayingCard cardToAdd) // e
        {
            _Cards.Add(cardToAdd);
        } // End Add


        public int GetHandValue() // f
        {

        }
    }
}
