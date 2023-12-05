using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird
{
    public class User
    {
        private string benutzername;
        private int highscore;
        private int coins;

        public User(string name,int highscore,int coins)
        {
            this.benutzername = name;
            this.highscore = highscore;
            this.coins = coins;
        }

        public string Benutzername { get => benutzername;}
        public int Highscore { get => highscore; set => highscore = value; }
        public int Coins { get => coins; set => coins = value; }
    }
}
