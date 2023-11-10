using CSConsoleCasino2.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleCasino2 {
    internal class Game {

        private static string[] avalibleCasinoGames = {
            "BlackJack"
        };

        public Game() { }

        public static string[] AvalibleCasinoGames {
            get { return avalibleCasinoGames; }
        }

        public void RunIntro() {
            Intro intro = new Intro();
            intro.PlayIntro();
            string playerName = Console.ReadLine(); //Probably not the best implementation, perhaps the intro should return the playername instead
            Player player = new Player(playerName);
            intro = null;
        }

        public void DisplayMainMenu() {
            bool gameChoiseHasBeenMade = false;
            MainMenu mainMenu = new MainMenu();
            mainMenu.DisplayMainMenu();

            while (!gameChoiseHasBeenMade) {
                string playerGameChoise = Console.ReadLine();
                if (playerGameChoise != null && CheckForValidGameChoiseInput(playerGameChoise)) {
                    int intPlayerGameChoise = Int32.Parse(playerGameChoise);
                    HandleGameChoise(intPlayerGameChoise);
                }
                else {
                    Console.WriteLine("Please enter a valid game: ");
                }
                

            }
        }

        public bool HandleGameChoise(int gameChoise) {
            switch (gameChoise) {
                case 1:
                    Console.WriteLine($"The game ");
                    return true;
                default:
                    Console.WriteLine("That is not a game that is sadly not avalible, please chose an avalible game: ");
                    return false;
            }
        }

        public bool CheckForValidGameChoiseInput(string gameChoise) {
            bool gameChoiseIsNumeric = int.TryParse(gameChoise, out int value);
            if (gameChoiseIsNumeric) {
                return true;
            }
            else { 
                return false; 
            }

        }

    }
}
