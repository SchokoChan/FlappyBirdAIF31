using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird
{
    public class User
    {
        private string benutzername;
        private string hashPasswort;
        private string salt;
        private int highscore;
        private int coins;

        public User(string name, string hashPasswort, string salt,int highscore,int coins)
        {
            this.benutzername = name;
            this.hashPasswort = hashPasswort;
            this.salt = salt;
            this.highscore = highscore;
            this.coins = coins;
        }

        public string Benutzername { get => benutzername;}
        public int Highscore { get => highscore; set => highscore = value; }
        public int Coins { get => coins; set => coins = value; }
        public string HashPasswort { get => hashPasswort;}
        public string Salt { get => salt;}
    }
}
