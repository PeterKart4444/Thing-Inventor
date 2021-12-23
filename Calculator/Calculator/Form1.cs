using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        bool decimalPointActive = false; //checks if the decimal point exists
        bool negActive = false; //checks if there is a negative sign
        string input = string.Empty; //input
        string operand1 = string.Empty; //number 1
        string operand2 = string.Empty; //number 2
        char operation; //the operation
        /*
         + is addition
         - is subtraction
         * is multiplication
         / is division
        */
        double result = 0.0; //the result
        double prevResult = 0.0; //idkw
        double variableM = 0.0; //M
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button10_Click(object sender, EventArgs e) //decimal
        {
            if (decimalPointActive == false)
            { 
                this.textBox1.Text = "";
                input += ".";
                this.textBox1.Text += input;
                decimalPointActive = true;
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Sqrt(result);
            textBox1.Text = result.ToString();
        }
        
        private void button0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 0;
            this.textBox1.Text += input;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 1;
            this.textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 2;
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 3;
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 4;
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 5;
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 6;
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 7;
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 8;
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 9;
            this.textBox1.Text += input;
        }

        private void buttonDivison_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
            this.textBox1.Text += (sender as Button).Text;
            decimalPointActive = false;
            negActive = false;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "Invalid";
                }

            }
            input = result.ToString();
            decimalPointActive = false;
            negActive = false;
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
            this.textBox1.Text += (sender as Button).Text;
            decimalPointActive = false;
            negActive = false;
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
            this.textBox1.Text += (sender as Button).Text;
            decimalPointActive = false;
            negActive = false;
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
            this.textBox1.Text += (sender as Button).Text;
            decimalPointActive = false;
            negActive = false;
        }

        private void buttonXroot_Click(object sender, EventArgs e)
        {

        }

        private void buttonCubeRoot_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Cbrt(result);
            textBox1.Text = result.ToString();
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {

        }

        private void buttonXpowerY_Click(object sender, EventArgs e)
        {

        }

        private void buttonCube_Click(object sender, EventArgs e)
        {

        }

        private void buttonAC_Click(object sender, EventArgs e)
        {

        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Pow(result, 2);
            textBox1.Text = result.ToString();
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = result / 100;
            textBox1.Text = result.ToString();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            negActive = false;
            decimalPointActive = false;
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            int index = textBox1.Text.Length;
            index--;
            textBox1.Text = textBox1.Text.Remove(index);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void buttonNegative_Click(object sender, EventArgs e)
        {
            if (negActive == false)
            {
                this.textBox1.Text = "";
                input = "-" + input;
                this.textBox1.Text += input;
                negActive = true;
            }
            else
            {
                this.textBox1.Text = "";
                input = input.Remove(0,1); //removes the negative sign
                this.textBox1.Text += input;
                negActive = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Floor(result);
            textBox1.Text = result.ToString();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void variablesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void valueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void currentValueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changeToToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void makePositiveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void makenegativeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void variablesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculator tutorial");
        }

        private void updateHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added display and made numbers and +, -, * and / add to the input");
        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void buttone_Click(object sender, EventArgs e) // butt on e
        {
            this.textBox1.Text = "";
            input = "";
            input += Math.E;
            this.textBox1.Text += input;
        }

        private void buttonpi_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input = "";
            input += Math.PI;
            this.textBox1.Text += input;
        }

        private void buttontau_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input = "";
            input += Math.Tau;
            this.textBox1.Text += input;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Cos(result);
            textBox1.Text = result.ToString();
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Sin(result);
            textBox1.Text = result.ToString();
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Tan(result);
            textBox1.Text = result.ToString();
        }

        private void buttonCot_Click(object sender, EventArgs e)
        {

        }

        private void buttonCsc_Click(object sender, EventArgs e)
        {

        }

        private void buttonSec_Click(object sender, EventArgs e)
        {

        }

        private void HYPE_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Ceiling(result);
            textBox1.Text = result.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maximum\nMinimum\nDecimals");
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Complex numbers have not yet been implemented yet");
        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            variableM += result;
            result = 0;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            result = double.Parse(textBox1.Text);
            result = Math.Abs(result);
            textBox1.Text = result.ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            variableM -= result;
            result = 0;
        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stored!");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You must press the Clear button first!");
        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void button44_Click(object sender, EventArgs e)
        {

        }

        private void button45_Click(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select base (variables and i can only be used in base 10)\n2-64");
        }

        private void button48_Click(object sender, EventArgs e)
        {

        }

        private void button49_Click(object sender, EventArgs e)
        {

        }

        private void button50_Click(object sender, EventArgs e)
        {

        }

        private void button51_Click(object sender, EventArgs e)
        {

        }

        private void button52_Click(object sender, EventArgs e)
        {

        }

        private void button53_Click(object sender, EventArgs e)
        {

        }

        private void button54_Click(object sender, EventArgs e)
        {

        }

        private void button55_Click(object sender, EventArgs e)
        {

        }

        private void button56_Click(object sender, EventArgs e)
        {

        }

        private void button57_Click(object sender, EventArgs e)
        {

        }

        private void button58_Click(object sender, EventArgs e)
        {

        }

        private void button59_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input = "";
            input += variableM;
            this.textBox1.Text += input;
        }

        private void button60_Click(object sender, EventArgs e)
        {

        }

        private void button61_Click(object sender, EventArgs e)
        {

        }

        private void button62_Click(object sender, EventArgs e)
        {

        }

        private void button63_Click(object sender, EventArgs e)
        {

        }

        private void button64_Click(object sender, EventArgs e)
        {

        }

        private void button65_Click(object sender, EventArgs e)
        {

        }

        private void button66_Click(object sender, EventArgs e)
        {

        }

        private void button67_Click(object sender, EventArgs e)
        {

        }

        private void button68_Click(object sender, EventArgs e)
        {

        }

        private void button69_Click(object sender, EventArgs e)
        {

        }

        private void button70_Click(object sender, EventArgs e)
        {

        }

        private void button71_Click(object sender, EventArgs e)
        {

        }

        private void button72_Click(object sender, EventArgs e)
        {

        }

        private void button73_Click(object sender, EventArgs e)
        {

        }

        private void button74_Click(object sender, EventArgs e)
        {

        }

        private void button75_Click(object sender, EventArgs e)
        {

        }
        #region
        private void prototype2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made the C and . buttons work");
        }

        private void prototype3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Textbox can no longer be edited directly, minor additions (ha get it addition ok kill me)");
        }

        private void prototype4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("More crap added");
        }

        private void prototype5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inserted some placeholder textboxes and changed C to Clear to avoid confusion with the variable C");
        }

        private void button75_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Variables are now lowercase/uppercase");
        }

        private void alpha1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now can do addition, subtraction, multiplication and division operations although only one at a time\nRemoved placeholder message for the equals button");
        }

        private void alpha10R1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added another placeholder");
        }

        private void alpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added pi, tau and e although they add to the current numbers and are buggy to work with");
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void alpha10R31ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made pi, tau and e replace the variable and not add to it");
        }

        private void alpha11R0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Finally got the decimal to work");
        }
        #endregion

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}