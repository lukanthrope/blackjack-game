using System;
using System.Drawing;
using System.Windows.Forms;

namespace blackjack_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NameInput.KeyPress += NameInputValidator;
        }

        private void NameInputValidator(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsLetter(c) && !char.IsDigit(c) && c != 8)
                e.Handled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (NameInput.Text.Trim() == "")
            {
                errorMessage.Visible = true;
            } else
            {
                Hide();
                string username = NameInput.Text;
                int num = Convert.ToInt32(numericUpDown1.Value);
                Gaming form2 = new Gaming(username, num);
                form2.Closed += (object s, EventArgs args) => Close();
                form2.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
   
            pictureBox1.Controls.Add(pictureBox2);
            pictureBox2.Location = new Point(350, 50);
            pictureBox2.BackColor = Color.Transparent;

            numericUpDown1.Value = 3;
        }
    }
}
