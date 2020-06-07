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
        public int[] currentCardPosition = new int[2];
        private PictureBox cloud;
        private Label cloudText;

        public Player(string name, int[] currentCardPosition, PictureBox cloud = null, Label cloudText = null)
        {
            this.name = name;
            this.currentCardPosition = currentCardPosition;
            this.cloud = cloud;
            this.cloudText = cloudText;
        }
        
        public string getName()
        {
            return name;
        }

        public void Say(string text, int time = -1)
        {
            cloud.Visible = true;
            cloudText.Text = text;
            cloudText.Visible = true;

            if (time > -1)
            {
                Gaming.wait(time);

                cloud.Visible = false;
                cloudText.Visible = false;
            }
            
        }
    }
}
