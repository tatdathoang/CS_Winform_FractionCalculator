using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fraction_TIE
{
    public partial class Frm_TstComp : Form
    {
        //these methods are grouped by function

        #region Arguments

        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction();
        Fraction fracresult = new Fraction();

        bool showed = true;
        bool covered = true;

        #endregion

        #region Stuff

        public Frm_TstComp()
        {
            InitializeComponent();
        }

        private void Frm_TstComp_Load(object sender, EventArgs e)
        {
            this.Size=new System.Drawing.Size(360,250);
            timer1.Start();
            ShowValue();
        }

        private void Btt_End_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Txt_Result_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

        #region Perform

        private void Btt_Done_Click(object sender, EventArgs e)
        {
            if (Rd_Equal.Checked == false && Rd_Greater.Checked == false && Rd_Less.Checked == false)
                MessageBox.Show("You must enter your answer before see the result!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (DoCheck())
                    ShowRight();
                else
                    ShowWrong();

                GroupBox2.Enabled = false;
                timer1.Start();
            }
        }

        private void Btt_Try_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (showed == false && covered == false)
            {
                this.Size = new Size(360, this.Size.Height + 25);
                if (this.Size.Height > 380)
                {
                    timer1.Stop();
                    this.Size = new Size(360, 380);

                    showed = true;
                }
            }
            else
            {
                if (showed == true && covered == false)
                {
                    this.Size = new Size(360, this.Size.Height - 25);
                    if (this.Size.Height < 40)
                    {
                        ShowValue();

                        showed = false;
                        covered = true;
                    }
                }
                else
                {
                    this.Size = new Size(360, this.Size.Height + 25);
                    if (this.Size.Height > 250)
                    {
                        timer1.Stop();
                        this.Size = new Size(360, 250);
                        Rd_Equal.Checked = false;
                        Rd_Greater.Checked = false;
                        Rd_Less.Checked = false;
                        Lb_Sign.Text = "?";
                        GroupBox2.Enabled = true;

                        showed = false;
                        covered = false;

                    }
                }
            }
        }

        #endregion

        #region Show info

        private void ShowValue()
        {
            Random a = new Random();
            int number;

            number = a.Next(1, 50);
            Lb_Num1.Text = "" + number;
            frac1.numerator = number;

            number = a.Next(2, 50);
            Lb_Den1.Text = "" + number;
            frac1.denominator = number;

            number = a.Next(1, 50);
            Lb_Num2.Text = "" + number;
            frac2.numerator = number;

            number = a.Next(2, 50);
            Lb_Den2.Text = "" + number;
            frac2.denominator = number;

            Rd_Equal.Checked = false;
            Rd_Greater.Checked = false;
            Rd_Less.Checked = false;
        }

        private void Rd_Greater_CheckedChanged(object sender, EventArgs e)
        {
            Lb_Sign.Text = ">";
        }

        private void Rd_Less_CheckedChanged(object sender, EventArgs e)
        {
            Lb_Sign.Text = "<";
        }

        private void Rd_Equal_CheckedChanged(object sender, EventArgs e)
        {
            Lb_Sign.Text = "=";
        }

        #endregion

        #region Check and result

        private bool DoCheck()
        {
            if (frac1 > frac2 && Rd_Greater.Checked == true)
                return true;
            if (frac1 < frac2 && Rd_Less.Checked == true)
                return true;
            if (frac1 == frac2 && Rd_Equal.Checked == true)
                return true;
            return false;
        }

        private void ShowWrong()
        {
            String result = "";

            result += "Unfortunately, your answer is wrong!\r\n The correct anws is: " + frac1.numerator + "/" + frac1.denominator;

            if (frac1 > frac2)
                result += " > ";

            if (frac1 < frac2)
                result += " < ";

            if (frac1 == frac2)
                result += " = ";
            result += frac2.numerator + "/" + frac2.denominator + "\r\n\r\nTry again or get back to study!";

            Txt_Result.Text = result;
        }

        private void ShowRight()
        {
            String result = "";

            result += "Congratulation, your answer is correct!\r\n\r\nTry other exams to improve your skill!";

            Txt_Result.Text = result;
        }

        #endregion

    }
}
