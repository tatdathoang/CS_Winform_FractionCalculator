namespace Fraction_TIE
{
    partial class Frm_StdComp
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Rd_Equal = new System.Windows.Forms.RadioButton();
            this.Rd_Less = new System.Windows.Forms.RadioButton();
            this.Rd_Greater = new System.Windows.Forms.RadioButton();
            this.Btt_Show = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Btt_Done = new System.Windows.Forms.Button();
            this.Btt_NewExamp = new System.Windows.Forms.Button();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.Txt_Howto = new System.Windows.Forms.TextBox();
            this.Lb_Sign = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Lb_Den2 = new System.Windows.Forms.Label();
            this.Lb_Num2 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Lb_Den1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lb_Num1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Rd_Equal);
            this.GroupBox1.Controls.Add(this.Rd_Less);
            this.GroupBox1.Controls.Add(this.Rd_Greater);
            this.GroupBox1.Location = new System.Drawing.Point(11, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(334, 51);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Comparison type:";
            // 
            // Rd_Equal
            // 
            this.Rd_Equal.AutoSize = true;
            this.Rd_Equal.Location = new System.Drawing.Point(252, 19);
            this.Rd_Equal.Name = "Rd_Equal";
            this.Rd_Equal.Size = new System.Drawing.Size(31, 17);
            this.Rd_Equal.TabIndex = 3;
            this.Rd_Equal.TabStop = true;
            this.Rd_Equal.Text = "=";
            this.Rd_Equal.UseVisualStyleBackColor = true;
            // 
            // Rd_Less
            // 
            this.Rd_Less.AutoSize = true;
            this.Rd_Less.Location = new System.Drawing.Point(145, 19);
            this.Rd_Less.Name = "Rd_Less";
            this.Rd_Less.Size = new System.Drawing.Size(31, 17);
            this.Rd_Less.TabIndex = 2;
            this.Rd_Less.TabStop = true;
            this.Rd_Less.Text = "<";
            this.Rd_Less.UseVisualStyleBackColor = true;
            // 
            // Rd_Greater
            // 
            this.Rd_Greater.AutoSize = true;
            this.Rd_Greater.Location = new System.Drawing.Point(38, 19);
            this.Rd_Greater.Name = "Rd_Greater";
            this.Rd_Greater.Size = new System.Drawing.Size(31, 17);
            this.Rd_Greater.TabIndex = 1;
            this.Rd_Greater.TabStop = true;
            this.Rd_Greater.Text = ">";
            this.Rd_Greater.UseVisualStyleBackColor = true;
            // 
            // Btt_Show
            // 
            this.Btt_Show.Location = new System.Drawing.Point(259, 69);
            this.Btt_Show.Name = "Btt_Show";
            this.Btt_Show.Size = new System.Drawing.Size(86, 23);
            this.Btt_Show.TabIndex = 12;
            this.Btt_Show.Text = "Show me how!";
            this.Btt_Show.UseVisualStyleBackColor = true;
            this.Btt_Show.Click += new System.EventHandler(this.Btt_Show_Click_1);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Btt_Done);
            this.GroupBox2.Controls.Add(this.Btt_NewExamp);
            this.GroupBox2.Controls.Add(this.GroupBox6);
            this.GroupBox2.Controls.Add(this.Lb_Sign);
            this.GroupBox2.Controls.Add(this.GroupBox4);
            this.GroupBox2.Controls.Add(this.GroupBox3);
            this.GroupBox2.Location = new System.Drawing.Point(12, 98);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(333, 322);
            this.GroupBox2.TabIndex = 11;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Example";
            // 
            // Btt_Done
            // 
            this.Btt_Done.Location = new System.Drawing.Point(251, 293);
            this.Btt_Done.Name = "Btt_Done";
            this.Btt_Done.Size = new System.Drawing.Size(75, 23);
            this.Btt_Done.TabIndex = 9;
            this.Btt_Done.Text = "Ok! I got it";
            this.Btt_Done.UseVisualStyleBackColor = true;
            this.Btt_Done.Click += new System.EventHandler(this.Btt_Done_Click);
            // 
            // Btt_NewExamp
            // 
            this.Btt_NewExamp.Location = new System.Drawing.Point(141, 293);
            this.Btt_NewExamp.Name = "Btt_NewExamp";
            this.Btt_NewExamp.Size = new System.Drawing.Size(105, 23);
            this.Btt_NewExamp.TabIndex = 8;
            this.Btt_NewExamp.Text = "Another Example!";
            this.Btt_NewExamp.UseVisualStyleBackColor = true;
            this.Btt_NewExamp.Click += new System.EventHandler(this.Btt_NewExamp_Click_1);
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.Txt_Howto);
            this.GroupBox6.Location = new System.Drawing.Point(6, 94);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(321, 193);
            this.GroupBox6.TabIndex = 7;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "How to";
            // 
            // Txt_Howto
            // 
            this.Txt_Howto.Location = new System.Drawing.Point(6, 19);
            this.Txt_Howto.Multiline = true;
            this.Txt_Howto.Name = "Txt_Howto";
            this.Txt_Howto.Size = new System.Drawing.Size(307, 168);
            this.Txt_Howto.TabIndex = 0;
            this.Txt_Howto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Howto_KeyPress);
            // 
            // Lb_Sign
            // 
            this.Lb_Sign.AutoSize = true;
            this.Lb_Sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Sign.Location = new System.Drawing.Point(160, 48);
            this.Lb_Sign.Name = "Lb_Sign";
            this.Lb_Sign.Size = new System.Drawing.Size(13, 13);
            this.Lb_Sign.TabIndex = 5;
            this.Lb_Sign.Text = "0";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.pictureBox2);
            this.GroupBox4.Controls.Add(this.Lb_Den2);
            this.GroupBox4.Controls.Add(this.Lb_Num2);
            this.GroupBox4.Location = new System.Drawing.Point(178, 19);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(48, 69);
            this.GroupBox4.TabIndex = 3;
            this.GroupBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Fraction_TIE.Properties.Resources.Split;
            this.pictureBox2.Location = new System.Drawing.Point(6, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 10);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Lb_Den2
            // 
            this.Lb_Den2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Den2.Location = new System.Drawing.Point(11, 45);
            this.Lb_Den2.Name = "Lb_Den2";
            this.Lb_Den2.Size = new System.Drawing.Size(27, 18);
            this.Lb_Den2.TabIndex = 2;
            this.Lb_Den2.Text = "0";
            this.Lb_Den2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_Num2
            // 
            this.Lb_Num2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Num2.Location = new System.Drawing.Point(11, 11);
            this.Lb_Num2.Name = "Lb_Num2";
            this.Lb_Num2.Size = new System.Drawing.Size(27, 18);
            this.Lb_Num2.TabIndex = 1;
            this.Lb_Num2.Text = "0";
            this.Lb_Num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Lb_Den1);
            this.GroupBox3.Controls.Add(this.PictureBox1);
            this.GroupBox3.Controls.Add(this.Lb_Num1);
            this.GroupBox3.Location = new System.Drawing.Point(107, 19);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(46, 69);
            this.GroupBox3.TabIndex = 0;
            this.GroupBox3.TabStop = false;
            // 
            // Lb_Den1
            // 
            this.Lb_Den1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Den1.Location = new System.Drawing.Point(10, 45);
            this.Lb_Den1.Name = "Lb_Den1";
            this.Lb_Den1.Size = new System.Drawing.Size(27, 18);
            this.Lb_Den1.TabIndex = 2;
            this.Lb_Den1.Text = "0";
            this.Lb_Den1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::Fraction_TIE.Properties.Resources.Split;
            this.PictureBox1.Location = new System.Drawing.Point(7, 32);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(32, 10);
            this.PictureBox1.TabIndex = 1;
            this.PictureBox1.TabStop = false;
            // 
            // Lb_Num1
            // 
            this.Lb_Num1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Num1.Location = new System.Drawing.Point(10, 11);
            this.Lb_Num1.Name = "Lb_Num1";
            this.Lb_Num1.Size = new System.Drawing.Size(27, 18);
            this.Lb_Num1.TabIndex = 1;
            this.Lb_Num1.Text = "0";
            this.Lb_Num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Frm_StdComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 427);
            this.Controls.Add(this.Btt_Show);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_StdComp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "How to compare fractions?";
            this.Load += new System.EventHandler(this.Frm_StdComp_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.RadioButton Rd_Equal;
        private System.Windows.Forms.RadioButton Rd_Less;
        private System.Windows.Forms.RadioButton Rd_Greater;
        internal System.Windows.Forms.Button Btt_Show;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button Btt_Done;
        internal System.Windows.Forms.Button Btt_NewExamp;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.TextBox Txt_Howto;
        internal System.Windows.Forms.Label Lb_Sign;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.Label Lb_Den2;
        internal System.Windows.Forms.Label Lb_Num2;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Lb_Den1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Lb_Num1;
        private System.Windows.Forms.Timer timer1;
    }
}