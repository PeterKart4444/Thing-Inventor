using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form2 RPS1 = new Form2();
                RPS1.ShowDialog();
            }
            else if (radioButton2.Checked)
            {
                Form3 RPSLS1 = new Form3();
                RPSLS1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form4 RPS2 = new Form4();
                RPS2.ShowDialog();
            }
            else if (radioButton2.Checked)
            {
                Form5 RPSLS2 = new Form5();
                RPSLS2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}

/*
1 = rock
2 = paper
3 = scissors
4 = lizard
5 = spock
*/