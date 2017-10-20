namespace Fraction_TIE
{
    partial class Frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Mn_Study = new System.Windows.Forms.ToolStripMenuItem();
            this.Mn_StdCal = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Mn_StdComp = new System.Windows.Forms.ToolStripMenuItem();
            this.Mn_AutoBot = new System.Windows.Forms.ToolStripMenuItem();
            this.Mn_AuCal = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.Mn_AuComp = new System.Windows.Forms.ToolStripMenuItem();
            this.Mn_Test = new System.Windows.Forms.ToolStripMenuItem();
            this.Mn_TestCal = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.MnTestComp = new System.Windows.Forms.ToolStripMenuItem();
            this.Mn_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Txt_Wellcome = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mn_Study,
            this.Mn_AutoBot,
            this.Mn_Test,
            this.Mn_Exit});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(384, 24);
            this.MenuStrip1.TabIndex = 1;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // Mn_Study
            // 
            this.Mn_Study.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mn_StdCal,
            this.ToolStripMenuItem1,
            this.Mn_StdComp});
            this.Mn_Study.Name = "Mn_Study";
            this.Mn_Study.Size = new System.Drawing.Size(49, 20);
            this.Mn_Study.Text = "Study";
            // 
            // Mn_StdCal
            // 
            this.Mn_StdCal.Name = "Mn_StdCal";
            this.Mn_StdCal.Size = new System.Drawing.Size(123, 22);
            this.Mn_StdCal.Text = "Calculate";
            this.Mn_StdCal.Click += new System.EventHandler(this.Mn_StdCal_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(120, 6);
            // 
            // Mn_StdComp
            // 
            this.Mn_StdComp.Name = "Mn_StdComp";
            this.Mn_StdComp.Size = new System.Drawing.Size(123, 22);
            this.Mn_StdComp.Text = "Compare";
            this.Mn_StdComp.Click += new System.EventHandler(this.Mn_StdComp_Click);
            // 
            // Mn_AutoBot
            // 
            this.Mn_AutoBot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mn_AuCal,
            this.ToolStripMenuItem2,
            this.Mn_AuComp});
            this.Mn_AutoBot.Name = "Mn_AutoBot";
            this.Mn_AutoBot.Size = new System.Drawing.Size(68, 20);
            this.Mn_AutoBot.Text = "Auto-bot";
            // 
            // Mn_AuCal
            // 
            this.Mn_AuCal.Name = "Mn_AuCal";
            this.Mn_AuCal.Size = new System.Drawing.Size(123, 22);
            this.Mn_AuCal.Text = "Calculate";
            this.Mn_AuCal.Click += new System.EventHandler(this.Mn_AuCal_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(120, 6);
            // 
            // Mn_AuComp
            // 
            this.Mn_AuComp.Name = "Mn_AuComp";
            this.Mn_AuComp.Size = new System.Drawing.Size(123, 22);
            this.Mn_AuComp.Text = "Compare";
            this.Mn_AuComp.Click += new System.EventHandler(this.Mn_AuComp_Click);
            // 
            // Mn_Test
            // 
            this.Mn_Test.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mn_TestCal,
            this.ToolStripMenuItem3,
            this.MnTestComp});
            this.Mn_Test.Name = "Mn_Test";
            this.Mn_Test.Size = new System.Drawing.Size(41, 20);
            this.Mn_Test.Text = "Test";
            // 
            // Mn_TestCal
            // 
            this.Mn_TestCal.Name = "Mn_TestCal";
            this.Mn_TestCal.Size = new System.Drawing.Size(123, 22);
            this.Mn_TestCal.Text = "Calculate";
            this.Mn_TestCal.Click += new System.EventHandler(this.Mn_TestCal_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(120, 6);
            // 
            // MnTestComp
            // 
            this.MnTestComp.Name = "MnTestComp";
            this.MnTestComp.Size = new System.Drawing.Size(123, 22);
            this.MnTestComp.Text = "Compare";
            this.MnTestComp.Click += new System.EventHandler(this.MnTestComp_Click);
            // 
            // Mn_Exit
            // 
            this.Mn_Exit.Name = "Mn_Exit";
            this.Mn_Exit.Size = new System.Drawing.Size(37, 20);
            this.Mn_Exit.Text = "Exit";
            this.Mn_Exit.Click += new System.EventHandler(this.Mn_Exit_Click);
            // 
            // Txt_Wellcome
            // 
            this.Txt_Wellcome.BackColor = System.Drawing.Color.White;
            this.Txt_Wellcome.Cursor = System.Windows.Forms.Cursors.Default;
            this.Txt_Wellcome.Location = new System.Drawing.Point(6, 103);
            this.Txt_Wellcome.Multiline = true;
            this.Txt_Wellcome.Name = "Txt_Wellcome";
            this.Txt_Wellcome.Size = new System.Drawing.Size(372, 254);
            this.Txt_Wellcome.TabIndex = 3;
            this.Txt_Wellcome.Enter += new System.EventHandler(this.Txt_Wellcome_Enter);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 464);
            this.Controls.Add(this.Txt_Wellcome);
            this.Controls.Add(this.MenuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fraction - Take it Easy!";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem Mn_Study;
        internal System.Windows.Forms.ToolStripMenuItem Mn_StdCal;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem Mn_StdComp;
        internal System.Windows.Forms.ToolStripMenuItem Mn_AutoBot;
        internal System.Windows.Forms.ToolStripMenuItem Mn_AuCal;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem2;
        internal System.Windows.Forms.ToolStripMenuItem Mn_AuComp;
        internal System.Windows.Forms.ToolStripMenuItem Mn_Test;
        internal System.Windows.Forms.ToolStripMenuItem Mn_TestCal;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem3;
        internal System.Windows.Forms.ToolStripMenuItem MnTestComp;
        internal System.Windows.Forms.ToolStripMenuItem Mn_Exit;
        private System.Windows.Forms.TextBox Txt_Wellcome;
        private System.Windows.Forms.Timer timer1;
    }
}

