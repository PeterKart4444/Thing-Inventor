using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpperScore.Text = "0";
            LowerScore.Text = "0";
            Score.Text = "0";
        }

        Random random = new Random();

        double rolls = 3;
        double onesDice = 0;
        double twosDice = 0;
        double threesDice = 0;
        double foursDice = 0;
        double fivesDice = 0;
        double sixesDice = 0;
        double upper = 0;
        double lower = 0;
        double score = 0;
        double upperNumbers = 0;
        double lowerNumbers = 0;
        double doubles = 0;
        double ohBabyATriple = 0;
        bool bonusTaken = false;
        bool upperTaken = false;
        bool lowerTaken = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (rolls > 0)
            {
                if (checkBox1.Checked == false || rolls == 3)
                {
                    textBox1.Text = random.Next(1, 7).ToString();
                }
                if (checkBox2.Checked == false || rolls == 3)
                {
                    textBox2.Text = random.Next(1, 7).ToString();
                }
                if (checkBox3.Checked == false || rolls == 3)
                {
                    textBox3.Text = random.Next(1, 7).ToString();
                }
                if (checkBox4.Checked == false || rolls == 3)
                {
                    textBox4.Text = random.Next(1, 7).ToString();
                }
                if (checkBox5.Checked == false || rolls == 3)
                {
                    textBox5.Text = random.Next(1, 7).ToString();
                }

                rolls--;
                Rolls.Text = "Rolls: " + rolls;

                onesDice = 0;
                twosDice = 0;
                threesDice = 0;
                foursDice = 0;
                fivesDice = 0;
                sixesDice = 0;

                doubles = 0;
                ohBabyATriple = 0;

                #region Count roll values
                if (textBox1.Text == "1")
                {
                    onesDice++;
                }
                else if (textBox1.Text == "2")
                {
                    twosDice++;
                }
                else if (textBox1.Text == "3")
                {
                    threesDice++;
                }
                else if (textBox1.Text == "4")
                {
                    foursDice++;
                }
                else if (textBox1.Text == "5")
                {
                    fivesDice++;
                }
                else if (textBox1.Text == "6")
                {
                    sixesDice++;
                }

                if (textBox2.Text == "1")
                {
                    onesDice++;
                }
                else if (textBox2.Text == "2")
                {
                    twosDice++;
                }
                else if (textBox2.Text == "3")
                {
                    threesDice++;
                }
                else if (textBox2.Text == "4")
                {
                    foursDice++;
                }
                else if (textBox2.Text == "5")
                {
                    fivesDice++;
                }
                else if (textBox2.Text == "6")
                {
                    sixesDice++;
                }

                if (textBox3.Text == "1")
                {
                    onesDice++;
                }
                else if (textBox3.Text == "2")
                {                
                    twosDice++;  
                }                
                else if (textBox3.Text == "3")
                {
                    threesDice++;
                }
                else if (textBox3.Text == "4")
                {
                    foursDice++;
                }
                else if (textBox3.Text == "5")
                {
                    fivesDice++;
                }
                else if (textBox3.Text == "6")
                {
                    sixesDice++;
                }

                if (textBox4.Text == "1")
                {
                    onesDice++;
                }
                else if (textBox4.Text == "2")
                {
                    twosDice++;
                }
                else if (textBox4.Text == "3")
                {
                    threesDice++;
                }
                else if (textBox4.Text == "4")
                {
                    foursDice++;
                }
                else if (textBox4.Text == "5")
                {
                    fivesDice++;
                }
                else if (textBox4.Text == "6")
                {
                    sixesDice++;
                }

                if (textBox5.Text == "1")
                {
                    onesDice++;
                }
                else if (textBox5.Text == "2")
                {
                    twosDice++;
                }
                else if (textBox5.Text == "3")
                {
                    threesDice++;
                }
                else if (textBox5.Text == "4")
                {
                    foursDice++;
                }
                else if (textBox5.Text == "5")
                {
                    fivesDice++;
                }
                else if (textBox5.Text == "6")
                {
                    sixesDice++;
                }
                #endregion

                if (onesDice > 2 || twosDice > 2 || threesDice > 2 || foursDice > 2 || fivesDice > 2 || sixesDice > 2)
                {
                    ohBabyATriple++;
                }

                if (onesDice > 1)
                {
                    doubles++;
                }

                if (twosDice > 1)
                {
                    doubles++;
                }

                if (threesDice > 1)
                {
                    doubles++;
                }

                if (foursDice > 1)
                {
                    doubles++;
                }

                if (fivesDice > 1)
                {
                    doubles++;
                }

                if (sixesDice > 1)
                {
                    doubles++;
                }
            }
        }

        private void Yahtzee_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Yahtzee.AutoCheck = false;
                if (onesDice == 5 || twosDice == 5 || threesDice == 5 || foursDice == 5 || fivesDice == 5 || sixesDice == 5)
                {
                    YahtzeeScore.Text = "50";
                    score += 50;
                    lower += 50;
                }
                else
                {
                    YahtzeeScore.Text = "0";
                }
                lowerNumbers++;
                rollReset();
                updateScore();
            }
            else
            {
                Yahtzee.Checked = false;
            }
        }

        private void Chance_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Chance.AutoCheck = false;
                ChanceScore.Text = ((onesDice * 1) + (twosDice * 2) + (threesDice * 3) + (foursDice * 4) + (fivesDice * 5) + (sixesDice * 6)).ToString();
                score += (onesDice * 1) + (twosDice * 2) + (threesDice * 3) + (foursDice * 4) + (fivesDice * 5) + (sixesDice * 6);
                lower += (onesDice * 1) + (twosDice * 2) + (threesDice * 3) + (foursDice * 4) + (fivesDice * 5) + (sixesDice * 6);
                lowerNumbers++;
                rollReset();
                updateScore();
            }
            else
            {
                Chance.Checked = false;
            }
        }

        private void Beeg_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Beeg.AutoCheck = false;
                if (onesDice >= 1 && twosDice >= 1 && threesDice >= 1 && foursDice >= 1 && fivesDice >= 1 || twosDice >= 1 && threesDice >= 1 && foursDice >= 1 && fivesDice >= 1 && sixesDice >= 1)
                {
                    LargeScore.Text = "40";
                    score += 40;
                    lower += 40;
                }
                else
                {
                    LargeScore.Text = "0";
                }
                lowerNumbers++;
                rollReset();
                updateScore();
            }
            else
            {
                Beeg.Checked = false;
            }
        }

        private void Smol_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Smol.AutoCheck = false;
                if (onesDice >= 1 && twosDice >= 1 && threesDice >= 1 && foursDice >= 1 || twosDice >= 1 && threesDice >= 1 && foursDice >= 1 && fivesDice >= 1 || threesDice >= 1 && foursDice >= 1 && fivesDice >= 1 && sixesDice >= 1)
                {
                    SmallScore.Text = "30";
                    score += 30;
                    lower += 30;
                }
                else
                {
                    SmallScore.Text = "0";
                }
                lowerNumbers++;
                rollReset();
                updateScore();
            }
            else
            {
                Smol.Checked = false;
            }
        }

        private void House_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("This isn't working at the moment and might not be for a while. Please try again never.");
            if (textBox1.Text != "")
            {
                House.AutoCheck = false;
                if (ohBabyATriple > 0 && doubles > 1)
                {
                    FullHouseScore.Text = "25";
                    score += 25;
                    lower += 25;
                }
                else
                {
                    FullHouseScore.Text = "0";
                }
                lowerNumbers++;
                rollReset();
                updateScore();
            }
            else
            {
                House.Checked = false;
            }
        }

        private void oak3_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                oak3.AutoCheck = false;
                if (onesDice >= 3 || twosDice >= 3 || threesDice >= 3 || foursDice >= 3 || fivesDice >= 3 || sixesDice >= 3)
                {
                    Score3.Text = ((onesDice * 1) + (twosDice * 2) + (threesDice * 3) + (foursDice * 4) + (fivesDice * 5) + (sixesDice * 6)).ToString();
                    score += (onesDice * 1) + (twosDice * 2) + (threesDice * 3) + (foursDice * 4) + (fivesDice * 5) + (sixesDice * 6);
                    lower += (onesDice * 1) + (twosDice * 2) + (threesDice * 3) + (foursDice * 4) + (fivesDice * 5) + (sixesDice * 6);
                }
                else
                {
                    Score3.Text = "0";
                }
                lowerNumbers++;
                rollReset();
                updateScore();
            }
            else
            {
                oak3.Checked = false;
            }
        }

        private void Sixes_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Sixes.AutoCheck = false;
                SixesScore.Text = ((sixesDice * 6).ToString());
                score += sixesDice * 6;
                upper += sixesDice * 6;
                upperNumbers++;
                rollReset();
                updateScore();
            }
            else
            {
                Sixes.Checked = false;
            }
        }

        private void Fives_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Fives.AutoCheck = false;
                FivesScore.Text = ((fivesDice * 5).ToString());
                score += fivesDice * 5;
                upper += fivesDice * 5;
                upperNumbers++;
                rollReset();
                updateScore();
            }
            else
            {
                Fives.Checked = false;
            }
        }

        private void Threes_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Threes.AutoCheck = false;
                ThreesScore.Text = ((threesDice * 3).ToString());
                score += threesDice * 3;
                upper += threesDice * 3;
                upperNumbers++;
                rollReset();
                updateScore();
            }
            else
            {
                Threes.Checked = false;
            }
        }

        private void Fours_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Fours.AutoCheck = false;
                FoursScore.Text = ((foursDice * 4).ToString());
                score += foursDice * 4;
                upper += foursDice * 4;
                upperNumbers++;
                rollReset();
                updateScore();
            }
            else
            {
                Fours.Checked = false;
            }
        }

        private void Twos_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Twos.AutoCheck = false;
                TwosScore.Text = ((twosDice * 2).ToString());
                score += twosDice * 2;
                upper += twosDice * 2;
                upperNumbers++;
                rollReset();
                updateScore();
            }
            else
            {
                Twos.Checked = false;
            }
        }

        private void Ones_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Ones.AutoCheck = false;
                OnesScore.Text = (onesDice.ToString());
                score += onesDice;
                upper += onesDice;
                upperNumbers++;
                rollReset();
                updateScore();
            }
            else
            {
                Ones.Checked = false;
            }
        }

        private void oak4_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                oak4.AutoCheck = false;
                if (onesDice >= 4 || twosDice >= 4 || threesDice >= 4 || foursDice >= 4 || fivesDice >= 4 || sixesDice >= 4)
                {
                    Score4.Text = ((onesDice * 1) + (twosDice * 2) + (threesDice * 3) + (foursDice * 4) + (fivesDice * 5) + (sixesDice * 6)).ToString();
                    score += (onesDice * 1) + (twosDice * 2) + (threesDice * 3) + (foursDice * 4) + (fivesDice * 5) + (sixesDice * 6);
                    lower += (onesDice * 1) + (twosDice * 2) + (threesDice * 3) + (foursDice * 4) + (fivesDice * 5) + (sixesDice * 6);
                }
                else
                {
                    Score4.Text = "0";
                }
                lowerNumbers++;
                rollReset();
                updateScore();
            }
            else
            {
                oak4.Checked = false;
            }
        }

        public void rollReset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            rolls = 3;
            Rolls.Text = "Rolls: " + rolls;

            if (upperNumbers == 6)
            {
                UpperSection.Checked = true;
                if (bonusTaken == false)
                {
                    if (upper > 62)
                    {
                        BonusScore.Text = "35";
                        upper += 35;
                        score += 35;
                    }
                    else
                    {
                        BonusScore.Text = "0";
                    }
                    bonusTaken = true;
                    upperTaken = true;
                    Bonus.Checked = true;
                    UpperSection.Checked = true;
                }
            }

            if (lowerNumbers == 7)
            {
                lowerTaken = true;
                LowerSection.Checked = true;
            }

            if (lowerTaken == true && upperTaken == true)
            {
                MessageBox.Show("Good game! You scored " + score + " points! You suck!!!");
                Total.Checked = true;
            }

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        public void updateScore()
        {
            LowerScore.Text = lower.ToString();
            UpperScore.Text = upper.ToString();
            Score.Text = (lower + upper).ToString();
        }
    }
}