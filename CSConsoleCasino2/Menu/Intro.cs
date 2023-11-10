using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleCasino2.Menu {
    internal class Intro : BaseMenu {

        private const string welcomeText = "Welcome to the greatest casino of all time!\nOf course, it's the Wille super casino!";
        private const string playerCreationText = "Please enter your name: ";
        
        public Intro() { }

        public string WelcomeText {
            get { return welcomeText; }
        }
        public string PlayerCreationText {
            get { return playerCreationText; }
        }

        public void PlayIntro() {
            WriteStringWithCharacterPause(WelcomeText);
            WriteStringWithCharacterPause(PlayerCreationText);
        }
    }
}
