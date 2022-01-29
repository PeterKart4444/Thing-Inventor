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
    public partial class Form3 : Form
    {
        Random rnd = new Random();
        byte player2 = 0;
        double wins = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player2 = (byte)rnd.Next(1, 6);
            if (player2 == 1)
            {
                MessageBox.Show("You picked rock. Computer picked rock. It's a tie.");
            }
            else if (player2 == 2)
            {
                MessageBox.Show("You picked rock. Computer picked paper. Computer wins.");
            }
            else if (player2 == 3)
            {
                MessageBox.Show("You picked rock. Computer picked scissors. YOU WIN!!!");
                wins += 1;
            }
            else if (player2 == 4)
            {
                MessageBox.Show("You picked rock. Computer picked lizard. YOU WIN!!!");
                wins += 1;
            }
            else if (player2 == 5)
            {
                MessageBox.Show("You picked rock. Computer picked spock. Computer wins.");
            }
            else
            {
                MessageBox.Show("You shouldn't see this");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            player2 = (byte)rnd.Next(1, 6);
            if (player2 == 1)
            {
                MessageBox.Show("You picked lizard. Computer picked rock. Computer wins.");
            }
            else if (player2 == 2)
            {
                MessageBox.Show("You picked lizard. Computer picked paper. YOU WIN!!!");
                wins += 1;
            }
            else if (player2 == 3)
            {
                MessageBox.Show("You picked lizard. Computer picked scissors. Computer wins.");
            }
            else if (player2 == 4)
            {
                MessageBox.Show("You picked lizard. Computer picked lizard. It's a tie.");
            }
            else
            {
                MessageBox.Show("You picked lizard. Computer picked spock. YOU WIN!!!");
                wins += 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            player2 = (byte)rnd.Next(1, 6);
            if (player2 == 1)
            {
                MessageBox.Show("You picked spock. Computer picked rock. YOU WIN!!!");
                wins += 1;
            }
            else if (player2 == 2)
            {
                MessageBox.Show("You picked spock. Computer picked paper. Computer wins.");
            }
            else if (player2 == 3)
            {
                MessageBox.Show("You picked spock. Computer picked scissors. YOU WIN!!!");
                wins += 1;
            }
            else if (player2 == 4)
            {
                MessageBox.Show("You picked spock. Computer picked lizard. Computer wins.");
            }
            else
            {
                MessageBox.Show("You picked spock. Computer picked spock. It's a tie.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wins: " + wins);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            player2 = (byte)rnd.Next(1, 6);
            if (player2 == 1)
            {
                MessageBox.Show("You picked paper. Computer picked rock. YOU WIN!!!");
                wins += 1;
            }
            else if (player2 == 2)
            {
                MessageBox.Show("You picked paper. Computer picked paper. It's a tie.");
            }
            else if (player2 == 3)
            {
                MessageBox.Show("You picked paper. Computer picked scissors. Computer wins.");
            }
            else if (player2 == 4)
            {
                MessageBox.Show("You picked paper. Computer picked lizard. Computer wins.");
            }
            else
            {
                MessageBox.Show("You picked paper. Computer picked spock. YOU WIN!!!");
                wins += 1;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            player2 = (byte)rnd.Next(1, 6);
            if (player2 == 1)
            {
                MessageBox.Show("You picked scissors. Computer picked rock. Computer wins.");
            }
            else if (player2 == 2)
            {
                MessageBox.Show("You picked scissors. Computer picked paper. YOU WIN!!!");
                wins += 1;
            }
            else if (player2 == 3)
            {
                MessageBox.Show("You picked scissors. Computer picked scissors. It's a tie.");
            }
            else if (player2 == 4)
            {
                MessageBox.Show("You picked scissors. Computer picked lizard. YOU WIN!!!");
                wins += 1;
            }
            else
            {
                MessageBox.Show("You picked scissors. Computer picked spock. Computer wins.");
            }
        }
    }
}
