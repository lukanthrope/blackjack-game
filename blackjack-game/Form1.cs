﻿using System;
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
                this.Hide();
                Gaming form2 = new Gaming("stasyan");
                form2.Closed += (object s, EventArgs args) => this.Close();
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
