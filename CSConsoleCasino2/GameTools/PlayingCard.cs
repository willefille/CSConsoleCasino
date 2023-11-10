using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleCasino2.GameTools {
    internal class PlayingCard {

        private int cardNumber;
        private string cardSuite;
        
        public PlayingCard(int _num, string _suite) {
            cardNumber = _num;
            cardSuite = _suite;
        }

        public int CardNumber {
            get { return cardNumber; }
            set { cardNumber = value; }
        }
        public string CardSuite {
            get { return cardSuite; }
            set { cardSuite = value; }
        }
        /*
        enum CardSuites {
            Hearts,
            Diamonds,
            Spades,
            Clover
        }*/
        public static string[] CardSuites = {
            "Hearts",
            "Diamonds",
            "Spades",
            "Clover"
        };

        public string GenerateCardVisual() {
            int n = CardNumber;
            string s = CardSuite;

            int heigth = 9;
            int width = 5;

            string cardVisual = null;

            for (int i = 0; i < heigth; i++) {
                for (int j = 0; j < width; j++) {
                    if (i == 0 || i == heigth - 1) {
                        cardVisual += "_";
                    }
                    else if (j == 0 || j == width - 1) {
                        cardVisual += "|";
                    }
                    else if ((i == 1 && j == 1) || (i == heigth - 1 && j == width - 1)) {
                        cardVisual += CardSuite[0];
                    }
                    else if ((i == 1 && j == width - 1) || (i == heigth - 1 && j == 1)) {
                        cardVisual += CardNumber;
                    }
                    else {
                        cardVisual += " ";
                    }

                }
                cardVisual += "\n";
            }          
            return cardVisual;
        }

        public void DisplayCard() {
            string card = GenerateCardVisual();
            Console.WriteLine(card);
        }
    }
}
