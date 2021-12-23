using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bruh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if(progressBar1.Value == 100)
            {
                MessageBox.Show("69 nice");
                progressBar1.Value = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            SaveFileDialog save1 = new SaveFileDialog();
            save1.Filter = "Ticklish PeterKart4444 Tickle Torture files (*.PeterKart)|*.PeterKart";
            save1.RestoreDirectory = true;
            save1.ShowDialog();
            MessageBox.Show("it doesn't save");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
