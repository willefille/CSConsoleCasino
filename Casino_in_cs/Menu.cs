using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Casino_in_cs {
    class Menu {

        public Menu() { }

        private string welcomeText = "Welcome to the greatest casino of all time!\nOf course, it's the Wille super casino!";
        public string WelcomeText {
            get { return welcomeText; }
        }

        private string mainMenuText;
        public string MainMenuText {
            get { return mainMenuText; }
            set { mainMenuText = value; }
        }

        public void WriteWelcomeText() {
            int textlength = welcomeText.Length;
            for (int i = 0; i < textlength; i++) {
                Console.Write(WelcomeText[i]);
                Thread.Sleep(80);
            }
        }

        public void WriteMainMenu() {
            // Add player total and player name in main menu
            Console.WriteLine($"{mainMenuText}");
        }
    }
}
