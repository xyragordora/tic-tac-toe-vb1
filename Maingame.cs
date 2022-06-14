using System;
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
    public partial class Maingame : Form
    {
        char turn = 'X';

        public Maingame()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (b1.Text == "")
            {
                b1.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }

                Winner();
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (b2.Text == "")
            {
                b2.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }

                Winner();
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (b3.Text == "")
            {
                b3.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }

                Winner();
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (b4.Text == "")
            {
                b4.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
                Winner();

            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (b5.Text == "")
            {
                b5.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }
                Winner();

            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (b6.Text == "")
            {
                b6.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }

                Winner();

            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (b7.Text == "")
            {
                b7.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }

                Winner();

            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (b8.Text == "")
            {
                b8.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }

                Winner();

            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (b9.Text == "")
            {
                b9.Text = turn.ToString();
                if (turn == 'X')
                {
                    turn = 'O';
                }
                else
                {
                    turn = 'X';
                }

                Winner();
            }
        }

        private void buttonnew_Click(object sender, EventArgs e)
        {
            turn = 'X';
            b1.Enabled = true;
            b1.Text = "";

            b2.Enabled = true;
            b2.Text = "";

            b3.Enabled = true;
            b3.Text = "";

            b4.Enabled = true;
            b4.Text = "";

            b5.Enabled = true;
            b5.Text = "";

            b6.Enabled = true;
            b6.Text = "";

            b7.Enabled = true;
            b7.Text = "";

            b8.Enabled = true;
            b8.Text = "";

            b9.Enabled = true;
            b9.Text = "";
        }

        private void buttonhelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. The first player are X, the next player is O.\n" + "Players take turns putting their marks in empty squares.\n" +
               "2. The first player to get 3 of her marks in a row (up, down, across, or diagonally) is the winner. ");
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Winner() //to automaticallly check the winner
        {
            bool winner = false;

            //horizontal X
            if (b1.Text == "X" && b2.Text == "X" && b3.Text == "X")
            {
                winner = true;
                MessageBox.Show(" X wins!");
            }
            else if (b4.Text == "X" && b5.Text == "X" && b6.Text == "X")
            {
                winner = true;
                MessageBox.Show(" X wins!");

            }
            else if (b7.Text == "X" && b8.Text == "X" && b9.Text == "X")
            {
                winner = true;
                MessageBox.Show(" X wins!");
            }

            //diagonal X
            else if (b3.Text == "X" && b5.Text == "X" && b7.Text == "X")
            {
                winner = true;
                MessageBox.Show(" X wins!");
            }
            else if (b1.Text == "X" && b5.Text == "X" && b9.Text == "X")
            {
                winner = true;
                MessageBox.Show(" X wins!");
            }

            //vertical X
            else if (b1.Text == "X" && b4.Text == "X" && b7.Text == "X")
            {
                winner = true;
                MessageBox.Show(" X wins!");
            }
            else if (b2.Text == "X" && b5.Text == "X" && b8.Text == "X")
            {
                winner = true;
                MessageBox.Show(" X wins!");

            }
            else if (b3.Text == "X" && b6.Text == "X" && b9.Text == "X")
            {
                winner = true;
                MessageBox.Show(" X wins!");
            }

            //horizontal O
            else if (b1.Text == "O" && b2.Text == "O" && b3.Text == "O")
            {
                winner = true;
                MessageBox.Show(" O wins!");
            }
            else if (b4.Text == "O" && b5.Text == "O" && b6.Text == "O")
            {
                winner = true;
                MessageBox.Show(" O wins!");
            }
            else if (b7.Text == "O" && b8.Text == "O" && b9.Text == "O")
            {
                winner = true;
                MessageBox.Show(" O wins!");
            }

            //diagonal O
            else if (b3.Text == "O" && b5.Text == "O" && b7.Text == "O")
            {
                winner = true;
                MessageBox.Show(" O wins!");


            }
            else if (b1.Text == "O" && b5.Text == "O" && b9.Text == "O")
            {
                winner = true;
                MessageBox.Show(" O wins!");
            }

            //vertical O
            else if (b1.Text == "O" && b4.Text == "O" && b7.Text == "O")
            {
                winner = true;
                MessageBox.Show(" O wins!");
            }
            else if (b2.Text == "O" && b5.Text == "O" && b8.Text == "O")
            {
                winner = true;
                MessageBox.Show(" O wins!");
            }
            else if (b3.Text == "O" && b6.Text == "O" && b9.Text == "O")
            {
                winner = true;
                MessageBox.Show(" O wins!");
            }
           
            if (winner)
            {
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                b4.Enabled = false;
                b5.Enabled = false;
                b6.Enabled = false;
                b7.Enabled = false;
                b8.Enabled = false;
                b9.Enabled = false;
            }
            else
            {

            }

        }
                

        }
    }




    
