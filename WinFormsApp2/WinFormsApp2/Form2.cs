using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        byte player1 = 0;
        byte player2 = 0;
        double wins = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player1 = 1;
            player2 = (byte)rnd.Next(1,4);
            if (player2 == 1)
            {
                MessageBox.Show("You picked rock. Computer picked rock. It's a tie.");
            }
            else if (player2 == 2)
            {
                MessageBox.Show("You picked rock. Computer picked paper. Computer wins.");
            }
            else
            {
                MessageBox.Show("You picked rock. Computer picked scissors. YOU WIN!!!");
                wins += 1;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            player1 = 2;
            player2 = (byte)rnd.Next(1, 4);
            if (player2 == 1)
            {
                MessageBox.Show("You picked paper. Computer picked rock. YOU WIN!!!");
                wins += 1;
            }
            else if (player2 == 2)
            {
                MessageBox.Show("You picked paper. Computer picked paper. It's a tie.");
            }
            else
            {
                MessageBox.Show("You picked paper. Computer picked scissors. Computer wins.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player1 = 3;
            player2 = (byte)rnd.Next(1, 4);
            if (player2 == 1)
            {
                MessageBox.Show("You picked scissors. Computer picked rock. Computer wins.");
            }
            else if (player2 == 2)
            {
                MessageBox.Show("You picked scissors. Computer picked paper. YOU WIN!!!");
                wins += 1;
            }
            else
            {
                MessageBox.Show("You picked scissors. Computer picked scissors. It's a tie.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wins: " + wins);
        }
    }
}
