using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack_game
{
    class Player
    {
        public Dictionary<PictureBox, int> cards = new Dictionary<PictureBox, int>();
        private string name;

        public Player(string name)
        {
            this.name = name;
        }
        
        public string getName()
        {
            return name;
        }
    }
}
