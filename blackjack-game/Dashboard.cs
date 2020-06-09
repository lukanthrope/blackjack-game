using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace blackjack_game
{
    public partial class Dashboard : Form
    {
        struct UserData
        {
            public string name;
            public int money;
        }

        ArrayList db = new ArrayList();
        public Dashboard(string name, int money)
        {
            InitializeComponent();
            const string filename = @"data.dat";
            UserData userData = new UserData();
            userData.name = name;
            userData.money = money;

            using (FileStream fileStream = new FileStream(filename, FileMode.Append, FileAccess.ReadWrite, FileShare.None))
            using (BinaryReader bw = new BinaryReader(fileStream))
            {
                
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
