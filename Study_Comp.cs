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
    public partial class Frm_StdComp : Form
    {
        //these methods are grouped by function

        #region Arguments

        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction();

        bool showed = false;

        #endregion

        #region Stuff

        public Frm_StdComp()
        {
            InitializeComponent();
        }

        private void Txt_Howto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Btt_Done_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Do you want to take a test?", "Ready for a test?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    {
                        this.Opacity = 0;
                        this.ShowInTaskbar = false;
                        Frm_Main temp = new Frm_Main();
                        temp.OpenTestComp();
                        break;
                    }
                case DialogResult.No:
                    {
                        this.Close();
                        break;
                    }
            }
        }

        #endregion

        #region Perform

        private void Frm_StdComp_Load(object sender, EventArgs e)
        {
            this.Size = new Size(360, 121);
        }

        private void Btt_Show_Click_1(object sender, EventArgs e)
        {
            Btt_Show.Visible = false;
            GroupBox2.Location = new System.Drawing.Point(12, 68);
            GroupBox1.Enabled = false;
            
            timer1.Start();

            ShowHow();
        }

        private void Btt_NewExamp_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (showed == false)
            {
                this.Size = new Size(360, this.Size.Height + 25);
                if (this.Size.Height > 429)
                {
                    timer1.Stop();
                    this.Size = new Size(360, 429);

                    showed = true;
                }
                
            }
            else
            {
                this.Size = new Size(360, this.Size.Height - 25);
                if (this.Size.Height < 121)
                {
                    timer1.Stop();
                    this.Size = new Size(360, 121);
                    GroupBox2.Location = new System.Drawing.Point(12, 97);
                    Btt_Show.Visible = true;
                    GroupBox1.Enabled = true;

                    showed = false;
                }
                
            }
        }

        #endregion

        #region Show info

        private void ShowHow()
        {
            ShowValue();
            ShowHowToFirst();

            if (Rd_Greater.Checked == true)
            {
                ShowHowToGreater();
            }
            if (Rd_Less.Checked == true)
            {
                ShowHowToLess();
            }
            if (Rd_Equal.Checked == true)
            {
                ShowHowToEqual();
            }
        }

        private void ShowValue()
        {
            Random a = new Random();
            int number;

            if (Rd_Greater.Checked == true)
            {
                number = a.Next(15, 30);
                Lb_Num1.Text = "" + number;
                frac1.numerator = number;

                number = a.Next(2, 15);
                Lb_Den1.Text = "" + number;
                frac1.denominator = number;

                number = a.Next(1, 15);
                Lb_Num2.Text = "" + number;
                frac2.numerator = number;

                number = a.Next(15, 30);
                Lb_Den2.Text = "" + number;
                frac2.denominator = number;

                Lb_Sign.Text = ">";
            }

            if (Rd_Less.Checked == true)
            {
                number = a.Next(1, 15);
                Lb_Num1.Text = "" + number;
                frac1.numerator = number;

                number = a.Next(15, 30);
                Lb_Den1.Text = "" + number;
                frac1.denominator = number;

                number = a.Next(15, 30);
                Lb_Num2.Text = "" + number;
                frac2.numerator = number;

                number = a.Next(1, 15);
                Lb_Den2.Text = "" + number;
                frac2.denominator = number;

                Lb_Sign.Text = "<";
            }

            if (Rd_Equal.Checked == true)
            {
                Random b = new Random();
                int temp;
                temp = b.Next(1, 20);

                number = a.Next(1, 30);
                Lb_Num1.Text = "" + number;
                frac1.numerator = number;

                number = a.Next(1, 30);
                Lb_Den1.Text = "" + number;
                frac1.denominator = number;

                frac2.numerator = frac1.numerator * temp;
                Lb_Num2.Text = "" + frac2.numerator;

                frac2.denominator = frac1.denominator * temp;
                Lb_Den2.Text = "" + frac2.denominator;

                Lb_Sign.Text = "=";
            }


        }

        public void ShowHowToFirst()
        {
            string howto;
            howto = "Step 1: Finding common denominator of " + frac1.denominator + " and " + frac2.denominator;

            howto += "\r\n  - Divisors of " + frac1.denominator + ": ";
            howto += frac1.Divisor (frac1.denominator);

            howto += "\r\n  - Divisors of " + frac2.denominator + ": ";
            howto += frac2.Divisor(frac2.denominator);

            howto += "\r\n\r\n => Greatest common divisor: ";
            int GreatComDiv = frac1.GreatestCommonDivisor(frac1.denominator, frac2.denominator); ;
            howto += GreatComDiv;

            howto += "\r\n => Common denominator: (" + frac1.denominator + " x " + frac2.denominator + ")/" + GreatComDiv + "= ";
            int ComDen;
            ComDen = frac1.CommonDenominator(frac2);
            howto += ComDen;

            howto += "\r\n\r\n  Step 2: Compare the 2 numerators";

            howto += "\r\n - The numerator of fraction number 1 = " + frac1.numerator + " x (" + ComDen + "/" + frac1.denominator + ") = ";
            int Result1, Result2;
            Result1 = frac1.numerator * (ComDen / frac1.denominator);
            howto += Result1;

            howto += "\r\n - The numerator of fraction number 2 = " + frac2.numerator + " x (" + ComDen + "/" + frac2.denominator + ") = ";
            Result2 = frac2.numerator * (ComDen / frac2.denominator);
            howto += Result2;

            howto += "\r\n";

            Txt_Howto.Text = howto;

        }

        public void ShowHowToGreater()
        {
            string howto = "";

            int ComDen;
            ComDen = frac1.CommonDenominator(frac2);

            int Result1, Result2;
            Result1 = frac1.numerator * (ComDen / frac1.denominator);
            Result2 = frac2.numerator * (ComDen / frac2.denominator);

            howto += "\r\n " + Result1 + " > " + Result2 + " => Fraction number 1 is lager than fraction number 2";

            Txt_Howto.Text += howto;
        }

        public void ShowHowToLess()
        {
            string howto = "";

            int ComDen;
            ComDen = frac1.CommonDenominator(frac2);

            int Result1, Result2;
            Result1 = frac1.numerator * (ComDen / frac1.denominator);
            Result2 = frac2.numerator * (ComDen / frac2.denominator);

            howto += "\r\n " + Result1 + " < " + Result2 + " => Fraction number 1 is smaller than fraction number 2";

            Txt_Howto.Text += howto;
        }

        public void ShowHowToEqual()
        {
            string howto = "";

            int ComDen;
            ComDen = frac1.CommonDenominator(frac2);

            int Result1, Result2;
            Result1 = frac1.numerator * (ComDen / frac1.denominator);
            Result2 = frac2.numerator * (ComDen / frac2.denominator);

            howto += "\r\n " + Result1 + " = " + Result2 + " => Fraction number and fraction number 2 are equal";

            Txt_Howto.Text += howto;
        }

        #endregion
    }
}
