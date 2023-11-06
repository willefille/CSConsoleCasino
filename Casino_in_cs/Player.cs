using System;
using System.Collections.Generic;
using System.Text;

namespace Casino_in_cs {
    class Player {

        public Player(int _money, string _name) {
            Money = _money;
            Name = _name;
        }

        private int money;
        public int Money {
            get { return money; }
            set { money = value; } //Make check later if the money is less than 0, eg. game over
        }
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }


    }
}
