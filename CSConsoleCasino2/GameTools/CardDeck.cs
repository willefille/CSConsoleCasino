using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleCasino2.GameTools {
    internal class CardDeck {

        private int deckSize = 52;
        public List<PlayingCard> cards = new List<PlayingCard>();

        public CardDeck() { }

        public int DeckSize {
            get{ return deckSize; }
            set { deckSize = value; }
        }
        public void Generate52CardDeck() {
            for (int i = 1; i < 14; i++) { 
                for (int j = 0; j < 4; j++) {
                    PlayingCard card = new PlayingCard(i, PlayingCard.CardSuites[j]);
                    cards.Add(card);
                }
            }
        }


    }
}
