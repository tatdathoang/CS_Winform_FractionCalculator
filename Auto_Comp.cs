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
    public partial class Frm_AuComp : Form
    {
        //these methods are grouped by function

        #region Arguments

        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction();

        bool checkkey = false;

        #endregion

        #region Stuff

        public Frm_AuComp()
        {
            InitializeComponent();
        }

        private void Btt_Clear_Click(object sender, EventArgs e)
        {
            Txt_Num1.Text = "";
            Txt_Den1.Text = "";

            Txt_Num2.Text = "";
            Txt_Den2.Text = "";

            Lb_Sign.Text = "";

            Txt_Num1.Focus();
        }

        private void Btt_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Input info Check

        private bool CheckFull()
        {
            if (Txt_Num1.Text != "" && Txt_Den1.Text != "" && Txt_Num2.Text != "" && Txt_Den2.Text != "")
                return true;
            return false;
        }

        private void Txt_Num1_KeyUp_1(object sender, KeyEventArgs e)
         {
             if (CheckFull())
             {
                 if (GetValue())
                     ShowResult();
             }
             else
                 Lb_Sign.Text = "";
        }

        private void Txt_Den1_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (CheckFull())
            {
                if (GetValue())
                    ShowResult();
            }
            else
                Lb_Sign.Text = "";
        }

        private void Txt_Num2_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (CheckFull())
            {
                if (GetValue())
                    ShowResult();
            }
            else
                Lb_Sign.Text = "";
        }

        private void Txt_Den2_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (CheckFull())
            {
                if (GetValue())
                    ShowResult();
            }
            else
                Lb_Sign.Text = "";
        }

        #endregion

        #region Valid key check and block

        private void Txt_Num1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)
            {
                if (Txt_Num1.Text == "")
                    checkkey = true;
                else
                    checkkey = false;
            }
            else
                checkkey = CheckKey(e);
        }

        private void Txt_Num2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)
            {
                if (Txt_Num2.Text == "")
                    checkkey = true;
                else
                    checkkey = false;
            }
            else
                checkkey = CheckKey(e);
        }

        private bool CheckKey(KeyEventArgs e)
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    if (e.KeyCode != Keys.Back)

                        return false;
            return true;
        }

        private void Txt_Num1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (checkkey == false)
                e.Handled = true;
        }

        private void Txt_Num2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (checkkey == false)
                e.Handled = true;
        }

        #endregion

        #region Compare and show result

        private bool GetValue()
        {
            frac1.numerator = int.Parse(Txt_Num1.Text);
            frac1.denominator = int.Parse(Txt_Den1.Text);

            frac2.numerator = int.Parse(Txt_Num2.Text);
            frac2.denominator = int.Parse(Txt_Den2.Text);

            if (frac1.denominator == 0 || frac2.denominator == 0)
            {
                MessageBox.Show("The denominator can't be 0", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (frac1.denominator == 0)
                {
                    Txt_Den1.Focus();
                    Txt_Den1.Select(0, Txt_Den1.Text.Length);
                }
                else
                {
                    Txt_Den2.Focus();
                    Txt_Den2.Select(0, Txt_Den2.Text.Length);
                }
                return false;
            }
            return true;
        }

        private void ShowResult()
        {
            Lb_Sign.Text = "";
            if (frac1 > frac2)
                Lb_Sign.Text += ">";
            if (frac1 < frac2)
                Lb_Sign.Text += "<";
            if (frac1 == frac2)
                Lb_Sign.Text += "=";
        }

        #endregion

       
        

       

        

       

        

       

       

       

       
    }
}
