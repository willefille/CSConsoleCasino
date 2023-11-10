using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleCasino2.Menu {
    internal class BaseMenu {

        public BaseMenu() { }

        public void WriteStringWithCharacterPause(string _text) {
            int textlength = _text.Length;
            for (int i = 0; i < textlength; i++) {
                Console.Write(_text[i]);
                Thread.Sleep(80);
            }
        }

        public void WriteString(string _text) {
            Console.Write(_text);
        }



    }
}
