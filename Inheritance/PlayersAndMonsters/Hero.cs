using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public class Hero
    {
        private string username;
        private int level;
        public int Level { get => this.level; set => this.level = value; }
        public string Username { get => this.username; set => this.username = value; }
        public Hero(string username, int lvl)
        {
            this.username = username;
            this.level = lvl;
        }
        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }

    }
}
