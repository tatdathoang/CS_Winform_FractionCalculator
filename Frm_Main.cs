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
    public partial class Frm_Main : Form
    {
        //these methods are grouped by function
       
        #region Arguments

        private bool Checkinout;

        #endregion

        #region Stuff

        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            string wellcome = "";
            wellcome = "Welcome to Fraction - take it easy!\r\n\r\n\r\n" +
                        "This program includes 3 MAIN PARTS with 8 functions:\r\n\r\n" +
                        "  1. Studying about fractions:\r\n" +
                        "\t1.1 Instructions in fraction calculations (+ / - / x / ÷)\r\n" +
                        "\t1.2 Instructions in fraction comparisons (bigger, smaller, equal)\r\n\r\n  " +
                        "2. Auto-bot:\r\n" +
                        "\t2.1 Automatic calculations give out results based on user’s data.\r\n   " +
                        "\t2.2 Automatic comparisons give out results based on user’s data.\r\n\r\n  " +
                        "3. Test:\r\n   " +
                        "\t3.1 Bring out the fractions and comment on the user’s result.\r\n   " +
                        "\t3.2 Bring out the fractions and comment on the user’s result.\r\n\r\n" +
                        "So, enjoy these features!";

            Txt_Wellcome.Text = wellcome;
        }

        private void Txt_Wellcome_Enter(object sender, EventArgs e)
        {
            Control temp = GetNextControl((Control)sender, true);
            temp.Focus();
        }

        private void Mn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Fade in & Out Effect

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignMode)
            {
                Checkinout = true;
                Opacity = 0;
                timer1.Enabled = true;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (e.Cancel == true)
                return;
            if (Opacity > 0)
            {
                Checkinout = false;
                timer1.Enabled = true;
                e.Cancel = true;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (Checkinout == false)
            {
                Opacity -= 0.1;
                if (this.Opacity > 0)
                    timer1.Enabled = true;
                else
                {
                    timer1.Enabled = false;
                    Close();
                }
            }
            else
            {
                Opacity += 0.1;
                timer1.Enabled = (Opacity < 1.0);
                Checkinout = (Opacity < 1.0);
            }
        }

        #endregion

        #region Study

        private void Mn_StdCal_Click(object sender, EventArgs e)
        {
            Frm_StdCal FrmStdCal = new Frm_StdCal();
            FrmStdCal.ShowDialog();
        }

        public void OpenTestCal()
        {
            Frm_TstCal FrmTstCal = new Frm_TstCal();
            FrmTstCal.ShowDialog();
        }

        private void Mn_StdComp_Click(object sender, EventArgs e)
        {
            Frm_StdComp FrmStdComp = new Frm_StdComp();
            FrmStdComp.ShowDialog();
        }
        
        public void OpenTestComp()
        {
            Frm_TstComp FrmTstComp = new Frm_TstComp();
            FrmTstComp.ShowDialog();
        }

        #endregion

        #region Auto-Bot

        private void Mn_AuCal_Click(object sender, EventArgs e)
        {
            Frm_AuCal FrmAuCal = new Frm_AuCal();
            FrmAuCal.ShowDialog();
        }

        private void Mn_AuComp_Click(object sender, EventArgs e)
        {
            Frm_AuComp FrmAuComp = new Frm_AuComp();
            FrmAuComp.ShowDialog();
        }

        #endregion

        #region Test

        private void Mn_TestCal_Click(object sender, EventArgs e)
        {
            Frm_TstCal FrmTstCal = new Frm_TstCal();
            FrmTstCal.ShowDialog();
        }

        private void MnTestComp_Click(object sender, EventArgs e)
        {
            Frm_TstComp FrmTstComp = new Frm_TstComp();
            FrmTstComp.ShowDialog();
        }

        #endregion

    }
}
