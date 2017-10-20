namespace Fraction_TIE
{
    partial class Frm_TstComp
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Rd_Equal = new System.Windows.Forms.RadioButton();
            this.Rd_Less = new System.Windows.Forms.RadioButton();
            this.Rd_Greater = new System.Windows.Forms.RadioButton();
            this.Lb_Sign = new System.Windows.Forms.Label();
            this.Btt_Done = new System.Windows.Forms.Button();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Lb_Den2 = new System.Windows.Forms.Label();
            this.Lb_Num2 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Lb_Den1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lb_Num1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.Btt_End = new System.Windows.Forms.Button();
            this.Txt_Result = new System.Windows.Forms.TextBox();
            this.Btt_Try = new System.Windows.Forms.Button();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.GroupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.GroupBox1);
            this.GroupBox2.Controls.Add(this.Lb_Sign);
            this.GroupBox2.Controls.Add(this.Btt_Done);
            this.GroupBox2.Controls.Add(this.GroupBox4);
            this.GroupBox2.Controls.Add(this.GroupBox3);
            this.GroupBox2.Location = new System.Drawing.Point(12, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(333, 205);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Examination";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Rd_Equal);
            this.GroupBox1.Controls.Add(this.Rd_Less);
            this.GroupBox1.Controls.Add(this.Rd_Greater);
            this.GroupBox1.Location = new System.Drawing.Point(6, 116);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(321, 51);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Your answer is: ";
            // 
            // Rd_Equal
            // 
            this.Rd_Equal.AutoSize = true;
            this.Rd_Equal.Location = new System.Drawing.Point(252, 19);
            this.Rd_Equal.Name = "Rd_Equal";
            this.Rd_Equal.Size = new System.Drawing.Size(31, 17);
            this.Rd_Equal.TabIndex = 2;
            this.Rd_Equal.TabStop = true;
            this.Rd_Equal.Text = "=";
            this.Rd_Equal.UseVisualStyleBackColor = true;
            this.Rd_Equal.CheckedChanged += new System.EventHandler(this.Rd_Equal_CheckedChanged);
            // 
            // Rd_Less
            // 
            this.Rd_Less.AutoSize = true;
            this.Rd_Less.Location = new System.Drawing.Point(145, 19);
            this.Rd_Less.Name = "Rd_Less";
            this.Rd_Less.Size = new System.Drawing.Size(31, 17);
            this.Rd_Less.TabIndex = 1;
            this.Rd_Less.TabStop = true;
            this.Rd_Less.Text = "<";
            this.Rd_Less.UseVisualStyleBackColor = true;
            this.Rd_Less.CheckedChanged += new System.EventHandler(this.Rd_Less_CheckedChanged);
            // 
            // Rd_Greater
            // 
            this.Rd_Greater.AutoSize = true;
            this.Rd_Greater.Location = new System.Drawing.Point(38, 19);
            this.Rd_Greater.Name = "Rd_Greater";
            this.Rd_Greater.Size = new System.Drawing.Size(31, 17);
            this.Rd_Greater.TabIndex = 0;
            this.Rd_Greater.TabStop = true;
            this.Rd_Greater.Text = ">";
            this.Rd_Greater.UseVisualStyleBackColor = true;
            this.Rd_Greater.CheckedChanged += new System.EventHandler(this.Rd_Greater_CheckedChanged);
            // 
            // Lb_Sign
            // 
            this.Lb_Sign.AutoSize = true;
            this.Lb_Sign.Location = new System.Drawing.Point(160, 65);
            this.Lb_Sign.Name = "Lb_Sign";
            this.Lb_Sign.Size = new System.Drawing.Size(13, 13);
            this.Lb_Sign.TabIndex = 4;
            this.Lb_Sign.Text = "?";
            // 
            // Btt_Done
            // 
            this.Btt_Done.Location = new System.Drawing.Point(252, 173);
            this.Btt_Done.Name = "Btt_Done";
            this.Btt_Done.Size = new System.Drawing.Size(75, 23);
            this.Btt_Done.TabIndex = 3;
            this.Btt_Done.Text = "Done!";
            this.Btt_Done.UseVisualStyleBackColor = true;
            this.Btt_Done.Click += new System.EventHandler(this.Btt_Done_Click);
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.pictureBox2);
            this.GroupBox4.Controls.Add(this.Lb_Den2);
            this.GroupBox4.Controls.Add(this.Lb_Num2);
            this.GroupBox4.Location = new System.Drawing.Point(185, 28);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(48, 82);
            this.GroupBox4.TabIndex = 1;
            this.GroupBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Fraction_TIE.Properties.Resources.Split;
            this.pictureBox2.Location = new System.Drawing.Point(8, 40);
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
            this.Lb_Den2.Location = new System.Drawing.Point(11, 53);
            this.Lb_Den2.Name = "Lb_Den2";
            this.Lb_Den2.Size = new System.Drawing.Size(27, 18);
            this.Lb_Den2.TabIndex = 1;
            this.Lb_Den2.Text = "0";
            this.Lb_Den2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_Num2
            // 
            this.Lb_Num2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Num2.Location = new System.Drawing.Point(11, 16);
            this.Lb_Num2.Name = "Lb_Num2";
            this.Lb_Num2.Size = new System.Drawing.Size(27, 18);
            this.Lb_Num2.TabIndex = 0;
            this.Lb_Num2.Text = "0";
            this.Lb_Num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Lb_Den1);
            this.GroupBox3.Controls.Add(this.PictureBox1);
            this.GroupBox3.Controls.Add(this.Lb_Num1);
            this.GroupBox3.Location = new System.Drawing.Point(100, 28);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(46, 82);
            this.GroupBox3.TabIndex = 0;
            this.GroupBox3.TabStop = false;
            // 
            // Lb_Den1
            // 
            this.Lb_Den1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Den1.Location = new System.Drawing.Point(10, 53);
            this.Lb_Den1.Name = "Lb_Den1";
            this.Lb_Den1.Size = new System.Drawing.Size(27, 18);
            this.Lb_Den1.TabIndex = 1;
            this.Lb_Den1.Text = "0";
            this.Lb_Den1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::Fraction_TIE.Properties.Resources.Split;
            this.PictureBox1.Location = new System.Drawing.Point(7, 40);
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
            this.Lb_Num1.Location = new System.Drawing.Point(10, 16);
            this.Lb_Num1.Name = "Lb_Num1";
            this.Lb_Num1.Size = new System.Drawing.Size(27, 18);
            this.Lb_Num1.TabIndex = 0;
            this.Lb_Num1.Text = "0";
            this.Lb_Num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.Btt_End);
            this.GroupBox6.Controls.Add(this.Txt_Result);
            this.GroupBox6.Controls.Add(this.Btt_Try);
            this.GroupBox6.Location = new System.Drawing.Point(12, 223);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(333, 125);
            this.GroupBox6.TabIndex = 14;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "Result";
            // 
            // Btt_End
            // 
            this.Btt_End.Location = new System.Drawing.Point(251, 96);
            this.Btt_End.Name = "Btt_End";
            this.Btt_End.Size = new System.Drawing.Size(76, 23);
            this.Btt_End.TabIndex = 1;
            this.Btt_End.Text = "End";
            this.Btt_End.UseVisualStyleBackColor = true;
            this.Btt_End.Click += new System.EventHandler(this.Btt_End_Click);
            // 
            // Txt_Result
            // 
            this.Txt_Result.Location = new System.Drawing.Point(6, 19);
            this.Txt_Result.Multiline = true;
            this.Txt_Result.Name = "Txt_Result";
            this.Txt_Result.Size = new System.Drawing.Size(319, 71);
            this.Txt_Result.TabIndex = 10;
            this.Txt_Result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Result_KeyPress);
            // 
            // Btt_Try
            // 
            this.Btt_Try.Location = new System.Drawing.Point(169, 96);
            this.Btt_Try.Name = "Btt_Try";
            this.Btt_Try.Size = new System.Drawing.Size(76, 23);
            this.Btt_Try.TabIndex = 0;
            this.Btt_Try.Text = "Try another!";
            this.Btt_Try.UseVisualStyleBackColor = true;
            this.Btt_Try.Click += new System.EventHandler(this.Btt_Try_Click);
            // 
            // Frm_TstComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 354);
            this.Controls.Add(this.GroupBox6);
            this.Controls.Add(this.GroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_TstComp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test your compararison skill with fractions";
            this.Load += new System.EventHandler(this.Frm_TstComp_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Button Btt_Done;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.Label Lb_Den2;
        internal System.Windows.Forms.Label Lb_Num2;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Lb_Den1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Lb_Num1;
        private System.Windows.Forms.Label Lb_Sign;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.RadioButton Rd_Equal;
        private System.Windows.Forms.RadioButton Rd_Less;
        private System.Windows.Forms.RadioButton Rd_Greater;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.Button Btt_End;
        internal System.Windows.Forms.TextBox Txt_Result;
        internal System.Windows.Forms.Button Btt_Try;
    }
}