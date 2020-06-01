using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack_game
{
    public partial class Gaming : Form
    {
        public string name;
        public int numberOfOponents;
        public Gaming(string name, int numberOfOponents)
        {
            InitializeComponent();
            this.name = name;
            this.numberOfOponents = numberOfOponents;
        }

        private void Gaming_Load(object sender, EventArgs e)
        {
            username.Text = name;
            pictureTable.Controls.Add(pictureCrupie);
            pictureTable.Controls.Add(pictureGoblin);
            pictureTable.Controls.Add(pictureClim);

            pictureCrupie.Location = new Point(260, 38);
            pictureGoblin.Location = new Point(30, 100);
            pictureClim.Location = new Point(460, 150);

            pictureCrupie.BackColor = Color.Transparent;
            pictureGoblin.BackColor = Color.Transparent;
            pictureClim.BackColor = Color.Transparent;

            if (numberOfOponents < 2)
            {
                pictureGoblin.Visible = false;
            } 

            if (numberOfOponents < 3)
            {
                pictureClim.Visible = false;
            }
        }
    }
}
