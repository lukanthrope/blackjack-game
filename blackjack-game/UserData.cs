using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_game
{
    class UserData
    {
        public string name;
        public int money;
        public UserData(string name, int money)
        {
            this.name = name;
            this.money = money;
        }
    }
}
