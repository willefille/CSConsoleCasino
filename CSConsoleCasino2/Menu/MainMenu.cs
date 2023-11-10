using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleCasino2.Menu {
    internal class MainMenu : BaseMenu {

        private string[] gameList;
        private string mainMenuText;


        public MainMenu() { 
            GameList = Game.AvalibleCasinoGames;
            InitMainMenuText(GameList);
        }
        
        public string[] GameList {  
            get { return GameList; } 
            set {  GameList = value; } 
        }
        public string MainMenuText {
            get { return mainMenuText; }
            set { mainMenuText = value; }
        }

        public void InitMainMenuText(string[] games) {
            MainMenuText += "Welcome to the Casino!\nWhat would you like to play? \n\n";
            int amtAvalibleGames = games.Length;
            for (int i = 1; i < amtAvalibleGames + 1; i++) {
                MainMenuText += $"{i}. {games[i]}\n";
            }
            MainMenuText += "\n";
            MainMenuText += $"What would you like to play? (1 - {amtAvalibleGames}): ";
        }

        public void DisplayMainMenu() {
            Console.WriteLine(MainMenuText);
        }
    
    }
}
