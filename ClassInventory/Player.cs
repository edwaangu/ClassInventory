using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInventory
{
    class Player
    {
        public string name, team, position;
        public int age;
        public int ID;
        public Player(string _name, string _team, string _position, int _age, int _ID)
        {
            name = _name;
            team = _team;
            position = _position;
            age = _age;
            ID = _ID;
        }
    }
}
