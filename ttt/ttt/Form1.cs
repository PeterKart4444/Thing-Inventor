using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ttt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool check = false;
        bool start = true;
        int checks;
        Random rnd = new Random();

        private void Check()
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                if (checkBox2.CheckState == CheckState.Checked)
                {
                    if (checkBox3.CheckState == CheckState.Checked)
                    {
                        MessageBox.Show("yay");
                        reset();
                    }
                }
                if (checkBox4.CheckState == CheckState.Checked)
                {
                    if (checkBox7.CheckState == CheckState.Checked)
                    {
                        MessageBox.Show("yay");
                        reset();
                    }
                }
                if (checkBox5.CheckState == CheckState.Checked)
                {
                    if (checkBox9.CheckState == CheckState.Checked)
                    {
                        MessageBox.Show("yay");
                        reset();
                    }
                }
            }
            if (checkBox2.CheckState == CheckState.Checked)
            {
                if (checkBox5.CheckState == CheckState.Checked)
                {
                    if (checkBox8.CheckState == CheckState.Checked)
                    {
                        MessageBox.Show("yay");
                        reset();
                    }
                }
            }
            if (checkBox3.CheckState == CheckState.Checked)
            {
                if (checkBox5.CheckState == CheckState.Checked)
                {
                    if (checkBox7.CheckState == CheckState.Checked)
                    {
                        MessageBox.Show("yay");
                        reset();
                    }
                }
                if (checkBox6.CheckState == CheckState.Checked)
                {
                    if (checkBox9.CheckState == CheckState.Checked)
                    {
                        MessageBox.Show("yay");
                        reset();
                    }
                }
            }
            if (checkBox4.CheckState == CheckState.Checked)
            {
                if (checkBox5.CheckState == CheckState.Checked)
                {
                    if (checkBox6.CheckState == CheckState.Checked)
                    {
                        MessageBox.Show("yay");
                        reset();
                    }
                }
            }
            if (checkBox7.CheckState == CheckState.Checked)
            {
                if (checkBox8.CheckState == CheckState.Checked)
                {
                    if (checkBox9.CheckState == CheckState.Checked)
                    {
                        MessageBox.Show("yay");
                        reset();
                    }
                }
            }
            if (checkBox1.CheckState == CheckState.Indeterminate)
            {
                if (checkBox2.CheckState == CheckState.Indeterminate)
                {
                    if (checkBox3.CheckState == CheckState.Indeterminate)
                    {
                        MessageBox.Show("boo");
                        reset();
                    }
                }
                if (checkBox4.CheckState == CheckState.Indeterminate)
                {
                    if (checkBox7.CheckState == CheckState.Indeterminate)
                    {
                        MessageBox.Show("boo");
                        reset();
                    }
                }
                if (checkBox5.CheckState == CheckState.Indeterminate)
                {
                    if (checkBox9.CheckState == CheckState.Indeterminate)
                    {
                        MessageBox.Show("boo");
                        reset();
                    }
                }
            }
            if (checkBox2.CheckState == CheckState.Indeterminate)
            {
                if (checkBox5.CheckState == CheckState.Indeterminate)
                {
                    if (checkBox8.CheckState == CheckState.Indeterminate)
                    {
                        MessageBox.Show("boo");
                        reset();
                    }
                }
            }
            if (checkBox3.CheckState == CheckState.Indeterminate)
            {
                if (checkBox5.CheckState == CheckState.Indeterminate)
                {
                    if (checkBox7.CheckState == CheckState.Indeterminate)
                    {
                        MessageBox.Show("boo");
                        reset();
                    }
                }
                if (checkBox6.CheckState == CheckState.Indeterminate)
                {
                    if (checkBox9.CheckState == CheckState.Indeterminate)
                    {
                        MessageBox.Show("boo");
                        reset();
                    }
                }
            }
            if (checkBox4.CheckState == CheckState.Indeterminate)
            {
                if (checkBox5.CheckState == CheckState.Indeterminate)
                {
                    if (checkBox6.CheckState == CheckState.Indeterminate)
                    {
                        MessageBox.Show("boo");
                        reset();
                    }
                }
            }
            if (checkBox7.CheckState == CheckState.Indeterminate)
            {
                if (checkBox8.CheckState == CheckState.Indeterminate)
                {
                    if (checkBox9.CheckState == CheckState.Indeterminate)
                    {
                        MessageBox.Show("boo");
                        reset();
                    }
                }
            }
        }
        private void Computer()
        {
            Boxes();
            if (checks == 1)
            {
                if (checkBox1.CheckState == CheckState.Unchecked)
                {
                    checkBox1.CheckState = CheckState.Indeterminate;
                }
                if (checkBox2.CheckState == CheckState.Unchecked)
                {
                    checkBox2.CheckState = CheckState.Indeterminate;
                }
                if (checkBox3.CheckState == CheckState.Unchecked)
                {
                    checkBox3.CheckState = CheckState.Indeterminate;
                }
                if (checkBox4.CheckState == CheckState.Unchecked)
                {
                    checkBox4.CheckState = CheckState.Indeterminate;
                }
                if (checkBox5.CheckState == CheckState.Unchecked)
                {
                    checkBox5.CheckState = CheckState.Indeterminate;
                }
                if (checkBox6.CheckState == CheckState.Unchecked)
                {
                    checkBox6.CheckState = CheckState.Indeterminate;
                }
                if (checkBox7.CheckState == CheckState.Unchecked)
                {
                    checkBox7.CheckState = CheckState.Indeterminate;
                }
                if (checkBox8.CheckState == CheckState.Unchecked)
                {
                    checkBox8.CheckState = CheckState.Indeterminate;
                }
                if (checkBox9.CheckState == CheckState.Unchecked)
                {
                    checkBox9.CheckState = CheckState.Indeterminate;
                }
                Check();
            }
            else if (checks == 0)
            {
                MessageBox.Show("nice");
                reset();
            }
            else
            {
                int cpu = rnd.Next(1, 9);
                if (cpu == 1)
                {
                    if (checkBox1.CheckState == CheckState.Unchecked)
                    {
                        checkBox1.CheckState = CheckState.Indeterminate;
                    }
                    else
                    {
                        Computer();
                    }
                }
                else if (cpu == 2)
                {
                    if (checkBox2.CheckState == CheckState.Unchecked)
                    {
                        checkBox2.CheckState = CheckState.Indeterminate;
                    }
                    else
                    {
                        Computer();
                    }
                }
                else if (cpu == 3)
                {
                    if (checkBox3.CheckState == CheckState.Unchecked)
                    {
                        checkBox3.CheckState = CheckState.Indeterminate;
                    }
                    else
                    {
                        Computer();
                    }
                }
                else if (cpu == 4)
                {
                    if (checkBox4.CheckState == CheckState.Unchecked)
                    {
                        checkBox4.CheckState = CheckState.Indeterminate;
                    }
                    else
                    {
                        Computer();
                    }
                }
                else if (cpu == 5)
                {
                    if (checkBox5.CheckState == CheckState.Unchecked)
                    {
                        checkBox5.CheckState = CheckState.Indeterminate;
                    }
                    else
                    {
                        Computer();
                    }
                }
                else if (cpu == 6)
                {
                    if (checkBox6.CheckState == CheckState.Unchecked)
                    {
                        checkBox6.CheckState = CheckState.Indeterminate;
                    }
                    else
                    {
                        Computer();
                    }
                }
                else if (cpu == 7)
                {
                    if (checkBox7.CheckState == CheckState.Unchecked)
                    {
                        checkBox7.CheckState = CheckState.Indeterminate;
                    }
                    else
                    {
                        Computer();
                    }
                }
                else if (cpu == 8)
                {
                    if (checkBox8.CheckState == CheckState.Unchecked)
                    {
                        checkBox8.CheckState = CheckState.Indeterminate;
                    }
                    else
                    {
                        Computer();
                    }
                }
                else if (cpu == 9)
                {
                    if (checkBox9.CheckState == CheckState.Unchecked)
                    {
                        checkBox9.CheckState = CheckState.Indeterminate;
                    }
                    else
                    {
                        Computer();
                    }
                }
                Check();
            }
        }

        private void reset()
        {
            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Unchecked;
            checkBox3.CheckState = CheckState.Unchecked;
            checkBox4.CheckState = CheckState.Unchecked;
            checkBox5.CheckState = CheckState.Unchecked;
            checkBox6.CheckState = CheckState.Unchecked;
            checkBox7.CheckState = CheckState.Unchecked;
            checkBox8.CheckState = CheckState.Unchecked;
            checkBox9.CheckState = CheckState.Unchecked;
            check = false;
            start = false;
            if (radioButton4.Checked == true)
            {
                Computer();
            }
        }

        private void Boxes()
        {
            checks = 0;
            if (checkBox1.CheckState == CheckState.Unchecked)
            {
                checks++;
            }
            if (checkBox2.CheckState == CheckState.Unchecked)
            {
                checks++;
            }
            if (checkBox3.CheckState == CheckState.Unchecked)
            {
                checks++;
            }
            if (checkBox4.CheckState == CheckState.Unchecked)
            {
                checks++;
            }
            if (checkBox5.CheckState == CheckState.Unchecked)
            {
                checks++;
            }
            if (checkBox6.CheckState == CheckState.Unchecked)
            {
                checks++;
            }
            if (checkBox7.CheckState == CheckState.Unchecked)
            {
                checks++;
            }
            if (checkBox8.CheckState == CheckState.Unchecked)
            {
                checks++;
            }
            if (checkBox9.CheckState == CheckState.Unchecked)
            {
                checks++;
            }
        }

        private void TL_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Unchecked)
            {
                start = true;
                checkBox1.CheckState = CheckState.Checked;
                check = true;
                Check();
                if(start == true)
                {
                Computer();
                }
            }
        }
        private void TM_Click(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Unchecked)
            {
                start = true;
                checkBox2.CheckState = CheckState.Checked;
                check = true;
                Check();
                if(start == true)
                {
                Computer();
                }
            }
        }
        private void TR_Click(object sender, EventArgs e)
        {
            if (checkBox3.CheckState == CheckState.Unchecked)
            {
                start = true;
                checkBox3.CheckState = CheckState.Checked;
                check = true;
                Check();
                if(start == true)
                {
                Computer();
                }
            }
        }
        private void ML_Click(object sender, EventArgs e)
        {
            if (checkBox4.CheckState == CheckState.Unchecked)
            {
                start = true;
                checkBox4.CheckState = CheckState.Checked;
                check = true;
                Check();
                if(start == true)
                {
                Computer();
                }
            }
        }
        private void MM_Click(object sender, EventArgs e)
        {
            if (checkBox5.CheckState == CheckState.Unchecked)
            {
                start = true;
                checkBox5.CheckState = CheckState.Checked;
                check = true;
                Check();
                if (start == true)
                {
                    Computer();
                }
            }
        }
        private void MR_Click(object sender, EventArgs e)
        {
            if (checkBox6.CheckState == CheckState.Unchecked)
            {
                start = true;
                checkBox6.CheckState = CheckState.Checked;
                check = true;
                Check();
                if(start == true)
                {
                Computer();
                }
            }
        }
        private void BR_Click(object sender, EventArgs e)
        {
            if (checkBox7.CheckState == CheckState.Unchecked)
            {
                start = true;
                checkBox7.CheckState = CheckState.Checked;
                check = true;
                Check();
                if(start == true)
                {
                Computer();
                }
            }
        }
        private void BM_Click(object sender, EventArgs e)
        {
            if (checkBox8.CheckState == CheckState.Unchecked)
            {
                start = true;
                checkBox8.CheckState = CheckState.Checked;
                check = true;
                Check();
                if(start == true)
                {
                Computer();
                }
            }
        }
        private void BL_Click(object sender, EventArgs e)
        {
            if (checkBox9.CheckState == CheckState.Unchecked)
            {
                start = true;
                checkBox9.CheckState = CheckState.Checked;
                check = true;
                Check();
                if(start == true)
                {
                Computer();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.CheckState = CheckState.Indeterminate;
            checkBox2.CheckState = CheckState.Indeterminate;
            checkBox3.CheckState = CheckState.Indeterminate;
            Check();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Reset the game");
        }
    }
}