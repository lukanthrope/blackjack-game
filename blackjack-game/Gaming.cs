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
    public partial class Gaming : Form
    {
        public string name;
        public Gaming(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void Gaming_Load(object sender, EventArgs e)
        {
            username.Text = this.name;
        }
    }
}
