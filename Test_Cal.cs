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
    public partial class Frm_TstCal : Form
    {
        //these methods are grouped by function

        #region Arguments

        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction();
        Fraction fracresult = new Fraction();
        Fraction rightresult = new Fraction();

        bool Showedtest = false;
        bool Showedresult = false; 

        bool checkkey=true;

        int sign;

        #endregion

        #region Stuff

        public Frm_TstCal()
        {
            InitializeComponent();
        }

        private void Frm_TstCal_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(360, 122);
        }

        private void Btt_End_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Txt_Result_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Rd_Random_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This mean computer will automatic generate the sign for you!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Perform

        private void Btt_Generate_Click(object sender, EventArgs e)
        {
            Btt_Generate.Visible = false;
            Grp_Exm.Location = new System.Drawing.Point(12, 68);
            Grp_Operator.Enabled = false;
            Txt_Num3.Focus();
            timer1.Start();

            ShowTest();
        }

        private void Btt_Done_Click(object sender, EventArgs e)
        {
            if (Txt_Num3.Text == "" || Txt_Den3.Text == "")
            {
                MessageBox.Show("You must enter your answer before see the result!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Num3.Focus();
            }
            else
            {
                fracresult.numerator = int.Parse(Txt_Num3.Text);
                fracresult.denominator = int.Parse(Txt_Den3.Text);

                if (!DoCheck())
                    ShowWrong();
                else
                    ShowRight();

                Grp_Result.Location = new System.Drawing.Point(12, 212);
                Btt_Done.Enabled = false;
                Grp_Exm.Enabled = false;
                timer1.Start();
            }

        }

        private void Btt_Try_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Showedtest == false && Showedresult == false)
            {
                this.Size = new Size(360, this.Size.Height + 25);
                if (this.Size.Height > 240)
                {
                    timer1.Stop();
                    this.Size = new Size(360, 240);

                    Showedtest = true;
                }
            }

            else
            {
                if (Showedtest == true && Showedresult == false)
                {
                    this.Size = new Size(360, this.Size.Height + 25);
                    if (this.Size.Height > 410)
                    {
                        timer1.Stop();
                        this.Size = new Size(360, 410);

                        Showedresult = true;
                    }
                }

                else
                {
                    if (Showedtest == true && Showedresult == true)
                    {
                        this.Size = new Size(360, this.Size.Height - 25);
                        if (this.Size.Height < 122)
                        {
                            timer1.Stop();
                            this.Size = new Size(360, 122);

                            Grp_Exm.Location = new System.Drawing.Point(12, 97);
                            Grp_Result.Location = new System.Drawing.Point(12, 241);
                            Btt_Generate.Visible = true;
                            Btt_Done.Enabled = true;
                            Grp_Operator.Enabled = true;
                            Grp_Exm.Enabled = true;

                            Txt_Num3.Text = "";
                            Txt_Den3.Text = "";

                            Showedresult = false;
                            Showedtest = false;
                        }
                    }
                }
            }
        }

        #endregion

        #region Show info

        private void ShowTest()
        {
            ShowValue();
            ShowOperator();
        }

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
        }

        private void ShowOperator()
        {
            if (Rd_Add.Checked == true)
            {
                Lb_Operator.Text = "+";
                sign = 1;
            }

            if (Rd_Sub.Checked == true)
            {
                Lb_Operator.Text = "-";
                sign = 2;
            }

            if (Rd_Multi.Checked == true)
            {
                Lb_Operator.Text = "x";
                sign = 3;
            }

            if (Rd_Div.Checked == true)
            {
                Lb_Operator.Text = "÷";
                sign = 4;
            }

            if (Rd_Random.Checked == true)
            {
                Random a = new Random();
                int i = a.Next(1, 5);
                switch (i)
                {
                    case 1:
                        {
                            Lb_Operator.Text = "+";
                            sign = 1;
                            break;
                        }
                    case 2:
                        {
                            Lb_Operator.Text = "-";
                            sign = 2;
                            break;
                        }
                    case 3:
                        {
                            Lb_Operator.Text = "x";
                            sign = 3;
                            break;
                        }
                    case 4:
                        {
                            Lb_Operator.Text = "÷";
                            sign =4;
                            break;
                        }
                }
            }
        }

        #endregion

        #region Valid key check and block

        private void Txt_Result_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void Txt_Num3_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)
            {
                if (Txt_Num3.Text == "")
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

        private void Txt_Num3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (checkkey == false)
                e.Handled = true;
        }

        private void Txt_Den3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (checkkey == false)
                e.Handled = true;
        }

        #endregion

        #region Check and result

        private bool DoCheck()
        {
            
            if (sign == 1)
                rightresult = frac1 + frac2;

            if (sign == 2)
                rightresult = frac1 - frac2;

            if (sign == 3)
                rightresult = frac1 * frac2;

            if (sign == 4)
                rightresult = frac1 / frac2;

            if (fracresult == rightresult)
                return true;
            return false;
        }

        private void ShowWrong()
        {
            String result="";

            result += "Unfortunately, your answer is wrong!\r\n The correct answer is: " + rightresult.numerator + "/" + rightresult.denominator + ".\r\n\r\nTry again or get back to study!";

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
