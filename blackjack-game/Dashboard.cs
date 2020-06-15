using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace blackjack_game
{
    public partial class Dashboard : Form
    {
        int usermoney;
        string username;
        List<UserData> db = new List<UserData>();
        public Dashboard(string name, int money)
        {
            InitializeComponent();
            usermoney = money;
            username = name;
            const string filename = @"data.dat";
            UserData userData = new UserData(name, money);

            using (FileStream fileStream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
            using (BinaryReader reader = new BinaryReader(fileStream))
            {
                while (reader.PeekChar() != -1)
                {
                    db.Add(new UserData(reader.ReadString(), reader.ReadInt32()));
                }
            }

            bool flag = false;
            foreach (UserData ud in db)
            {
                if (ud.name.ToLower() == userData.name.ToLower())
                {
                    if (ud.money <= userData.money)
                        ud.money = userData.money;

                    flag = true;
                    break;
                }
            }

            if (!flag) db.Add(userData);

            using (FileStream fileStream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                foreach (UserData el in db )
                {
                    writer.Write(el.name);
                    writer.Write(el.money);
                }
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            int i = 0;
            dataGridView1.RowCount = db.Count;
            List<UserData> sortedList = db
                                          .OrderBy((UserData el) => el.money)
                                          .Reverse()
                                          .ToList();
            foreach (UserData el in sortedList)
            {
                dataGridView1.Rows[i].Cells[0].Value = el.name;
                dataGridView1.Rows[i].Cells[1].Value = el.money;
                i++;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string text = "Я виграв " + usermoney + "$ у грі BlackJack goblino \n https://github.com/lukanthrope/blackjack-game";
            string link = "https://twitter.com/intent/tweet?hashtags=gaming&text=";
            System.Diagnostics.Process.Start(link + text);
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            Hide();

            Form1 form1 = new Form1();
            form1.Closed += (object s, EventArgs args) => Close();
            form1.Show();
        }
    }
}
