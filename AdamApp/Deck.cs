using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamApp
{
    internal class Deck
    {
        private List<PlayingCard> _Cards; // a

        public List<PlayingCard> Cards // b
        {
            get { return _Cards; }
        }

        public int Count
        {
            get { return _Cards.Count; } // c
        }

        public void Add(PlayingCard cardToAdd) // d
        {
            _Cards.Add(cardToAdd);
        } // End Add
        public Deck() // e
        {
            _Cards = new List<PlayingCard>(); // 1
            foreach (String suit in PlayingCard.Suits)
                foreach(String face in PlayingCard.Faces)
                    _Cards.Add(new PlayingCard(suit, face)); // 2

            Shuffle(); // 3
        
        } // End Deck constructor

        private void Shuffle() // 4 used in h
        {
            List<PlayingCard> newDeck = new List<PlayingCard> (); // 1
            while (_Cards.Count > 0)            // 2
            {
                int cardToMove = rndNum.Next(_Cards.Count); // 3
                newDeck.Add(_Cards[cardToMove]);            // 4
                _Cards.RemoveAt(cardToMove);                // 5
            }
            _Cards = newDeck; // 6
            // End shuffle
        }

        public PlayingCard Deal()
        {
            PlayingCard cardToDeal = _Cards[0]; // 1
            _Cards.RemoveAt(0); // 2
            return cardToDeal;
        }

        private Random rndNum = new Random(Guid.NewGuid().GetHashCode()); // g

    } // end of Deck class
}
