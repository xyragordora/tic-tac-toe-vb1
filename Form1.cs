﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void play_Click(object sender, EventArgs e)
        {
            Maingame form = new Maingame();
            form.Show();
            this.Hide();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic-tac-toe is a game in which two players take turns in drawing either an ' O' or an ' X' in one square of a grid consisting of nine squares. \n" +
                "The winner is the first player to get three of the same symbols in a row.");
        }
    }
}
