using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleCasino2 {
    internal class Player {
        private string playerName;
        private int playerMoney;

        public Player(string name) {
            playerName = name;
            playerMoney = 1000;
        }

        public string PlayerName {
            get { return playerName; }
        }
        public int PlayerMoney {
            get { return playerMoney; }
            set { playerMoney = value; }
        } 

        public void AddPlayerMoney(int amt) {
            playerMoney += amt;
        }
        public void RemovePlayerMoney(int amt) {  
            playerMoney -= amt; 
        }


    }
}
