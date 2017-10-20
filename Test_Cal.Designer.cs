namespace Fraction_TIE
{
    partial class Frm_TstCal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TstCal));
            this.Btt_Generate = new System.Windows.Forms.Button();
            this.Grp_Exm = new System.Windows.Forms.GroupBox();
            this.Btt_Done = new System.Windows.Forms.Button();
            this.Lb_EqlS = new System.Windows.Forms.Label();
            this.Lb_Operator = new System.Windows.Forms.Label();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.Txt_Den3 = new System.Windows.Forms.TextBox();
            this.Txt_Num3 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Lb_Den2 = new System.Windows.Forms.Label();
            this.Lb_Num2 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Lb_Den1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lb_Num1 = new System.Windows.Forms.Label();
            this.Btt_Try = new System.Windows.Forms.Button();
            this.Grp_Result = new System.Windows.Forms.GroupBox();
            this.Btt_End = new System.Windows.Forms.Button();
            this.Txt_Result = new System.Windows.Forms.TextBox();
            this.Grp_Operator = new System.Windows.Forms.GroupBox();
            this.Rd_Random = new System.Windows.Forms.RadioButton();
            this.Rd_Div = new System.Windows.Forms.RadioButton();
            this.Rd_Multi = new System.Windows.Forms.RadioButton();
            this.Rd_Sub = new System.Windows.Forms.RadioButton();
            this.Rd_Add = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Grp_Exm.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Grp_Result.SuspendLayout();
            this.Grp_Operator.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btt_Generate
            // 
            this.Btt_Generate.Location = new System.Drawing.Point(259, 68);
            this.Btt_Generate.Name = "Btt_Generate";
            this.Btt_Generate.Size = new System.Drawing.Size(86, 23);
            this.Btt_Generate.TabIndex = 1;
            this.Btt_Generate.Text = "Generate!";
            this.Btt_Generate.UseVisualStyleBackColor = true;
            this.Btt_Generate.Click += new System.EventHandler(this.Btt_Generate_Click);
            // 
            // Grp_Exm
            // 
            this.Grp_Exm.Controls.Add(this.Btt_Done);
            this.Grp_Exm.Controls.Add(this.Lb_EqlS);
            this.Grp_Exm.Controls.Add(this.Lb_Operator);
            this.Grp_Exm.Controls.Add(this.GroupBox5);
            this.Grp_Exm.Controls.Add(this.GroupBox4);
            this.Grp_Exm.Controls.Add(this.GroupBox3);
            this.Grp_Exm.Location = new System.Drawing.Point(12, 97);
            this.Grp_Exm.Name = "Grp_Exm";
            this.Grp_Exm.Size = new System.Drawing.Size(333, 138);
            this.Grp_Exm.TabIndex = 2;
            this.Grp_Exm.TabStop = false;
            this.Grp_Exm.Text = "Examination";
            // 
            // Btt_Done
            // 
            this.Btt_Done.Location = new System.Drawing.Point(252, 107);
            this.Btt_Done.Name = "Btt_Done";
            this.Btt_Done.Size = new System.Drawing.Size(75, 23);
            this.Btt_Done.TabIndex = 1;
            this.Btt_Done.Text = "Done!";
            this.Btt_Done.UseVisualStyleBackColor = true;
            this.Btt_Done.Click += new System.EventHandler(this.Btt_Done_Click);
            // 
            // Lb_EqlS
            // 
            this.Lb_EqlS.AutoSize = true;
            this.Lb_EqlS.Location = new System.Drawing.Point(195, 56);
            this.Lb_EqlS.Name = "Lb_EqlS";
            this.Lb_EqlS.Size = new System.Drawing.Size(13, 13);
            this.Lb_EqlS.TabIndex = 6;
            this.Lb_EqlS.Text = "=";
            // 
            // Lb_Operator
            // 
            this.Lb_Operator.AutoSize = true;
            this.Lb_Operator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Operator.Location = new System.Drawing.Point(106, 59);
            this.Lb_Operator.Name = "Lb_Operator";
            this.Lb_Operator.Size = new System.Drawing.Size(13, 13);
            this.Lb_Operator.TabIndex = 5;
            this.Lb_Operator.Text = "0";
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.Txt_Den3);
            this.GroupBox5.Controls.Add(this.Txt_Num3);
            this.GroupBox5.Controls.Add(this.pictureBox3);
            this.GroupBox5.Location = new System.Drawing.Point(222, 19);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(48, 82);
            this.GroupBox5.TabIndex = 0;
            this.GroupBox5.TabStop = false;
            // 
            // Txt_Den3
            // 
            this.Txt_Den3.Location = new System.Drawing.Point(6, 55);
            this.Txt_Den3.MaxLength = 3;
            this.Txt_Den3.Name = "Txt_Den3";
            this.Txt_Den3.Size = new System.Drawing.Size(37, 20);
            this.Txt_Den3.TabIndex = 1;
            this.Txt_Den3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_Den3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Den3_KeyPress);
            // 
            // Txt_Num3
            // 
            this.Txt_Num3.Location = new System.Drawing.Point(5, 13);
            this.Txt_Num3.MaxLength = 3;
            this.Txt_Num3.Name = "Txt_Num3";
            this.Txt_Num3.Size = new System.Drawing.Size(37, 20);
            this.Txt_Num3.TabIndex = 0;
            this.Txt_Num3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_Num3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Num3_KeyDown_1);
            this.Txt_Num3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Num3_KeyPress);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 10);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.pictureBox2);
            this.GroupBox4.Controls.Add(this.Lb_Den2);
            this.GroupBox4.Controls.Add(this.Lb_Num2);
            this.GroupBox4.Location = new System.Drawing.Point(132, 19);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(48, 82);
            this.GroupBox4.TabIndex = 3;
            this.GroupBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
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
            this.GroupBox3.Location = new System.Drawing.Point(46, 19);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(46, 82);
            this.GroupBox3.TabIndex = 2;
            this.GroupBox3.TabStop = false;
            // 
            // Lb_Den1
            // 
            this.Lb_Den1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Den1.Location = new System.Drawing.Point(9, 53);
            this.Lb_Den1.Name = "Lb_Den1";
            this.Lb_Den1.Size = new System.Drawing.Size(27, 18);
            this.Lb_Den1.TabIndex = 1;
            this.Lb_Den1.Text = "0";
            this.Lb_Den1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
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
            // Btt_Try
            // 
            this.Btt_Try.Location = new System.Drawing.Point(170, 132);
            this.Btt_Try.Name = "Btt_Try";
            this.Btt_Try.Size = new System.Drawing.Size(76, 23);
            this.Btt_Try.TabIndex = 0;
            this.Btt_Try.Text = "Try another!";
            this.Btt_Try.UseVisualStyleBackColor = true;
            this.Btt_Try.Click += new System.EventHandler(this.Btt_Try_Click);
            // 
            // Grp_Result
            // 
            this.Grp_Result.Controls.Add(this.Btt_End);
            this.Grp_Result.Controls.Add(this.Txt_Result);
            this.Grp_Result.Controls.Add(this.Btt_Try);
            this.Grp_Result.Location = new System.Drawing.Point(12, 241);
            this.Grp_Result.Name = "Grp_Result";
            this.Grp_Result.Size = new System.Drawing.Size(333, 164);
            this.Grp_Result.TabIndex = 3;
            this.Grp_Result.TabStop = false;
            this.Grp_Result.Text = "Result";
            // 
            // Btt_End
            // 
            this.Btt_End.Location = new System.Drawing.Point(252, 132);
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
            this.Txt_Result.Size = new System.Drawing.Size(319, 107);
            this.Txt_Result.TabIndex = 2;
            this.Txt_Result.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Result_KeyDown);
            this.Txt_Result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Result_KeyPress);
            // 
            // Grp_Operator
            // 
            this.Grp_Operator.Controls.Add(this.Rd_Random);
            this.Grp_Operator.Controls.Add(this.Rd_Div);
            this.Grp_Operator.Controls.Add(this.Rd_Multi);
            this.Grp_Operator.Controls.Add(this.Rd_Sub);
            this.Grp_Operator.Controls.Add(this.Rd_Add);
            this.Grp_Operator.Location = new System.Drawing.Point(12, 12);
            this.Grp_Operator.Name = "Grp_Operator";
            this.Grp_Operator.Size = new System.Drawing.Size(333, 50);
            this.Grp_Operator.TabIndex = 0;
            this.Grp_Operator.TabStop = false;
            this.Grp_Operator.Text = "Operator";
            // 
            // Rd_Random
            // 
            this.Rd_Random.AutoSize = true;
            this.Rd_Random.Location = new System.Drawing.Point(265, 19);
            this.Rd_Random.Name = "Rd_Random";
            this.Rd_Random.Size = new System.Drawing.Size(60, 17);
            this.Rd_Random.TabIndex = 4;
            this.Rd_Random.Text = "I\'m Pro!";
            this.Rd_Random.UseVisualStyleBackColor = true;
            this.Rd_Random.Click += new System.EventHandler(this.Rd_Random_Click);
            // 
            // Rd_Div
            // 
            this.Rd_Div.AutoSize = true;
            this.Rd_Div.Location = new System.Drawing.Point(201, 19);
            this.Rd_Div.Name = "Rd_Div";
            this.Rd_Div.Size = new System.Drawing.Size(55, 17);
            this.Rd_Div.TabIndex = 3;
            this.Rd_Div.Text = "Divide";
            this.Rd_Div.UseVisualStyleBackColor = true;
            // 
            // Rd_Multi
            // 
            this.Rd_Multi.AutoSize = true;
            this.Rd_Multi.Location = new System.Drawing.Point(132, 19);
            this.Rd_Multi.Name = "Rd_Multi";
            this.Rd_Multi.Size = new System.Drawing.Size(60, 17);
            this.Rd_Multi.TabIndex = 2;
            this.Rd_Multi.Text = "Multiply";
            this.Rd_Multi.UseVisualStyleBackColor = true;
            // 
            // Rd_Sub
            // 
            this.Rd_Sub.AutoSize = true;
            this.Rd_Sub.Location = new System.Drawing.Point(58, 19);
            this.Rd_Sub.Name = "Rd_Sub";
            this.Rd_Sub.Size = new System.Drawing.Size(65, 17);
            this.Rd_Sub.TabIndex = 1;
            this.Rd_Sub.Text = "Subtract";
            this.Rd_Sub.UseVisualStyleBackColor = true;
            // 
            // Rd_Add
            // 
            this.Rd_Add.AutoSize = true;
            this.Rd_Add.Checked = true;
            this.Rd_Add.Location = new System.Drawing.Point(5, 19);
            this.Rd_Add.Name = "Rd_Add";
            this.Rd_Add.Size = new System.Drawing.Size(44, 17);
            this.Rd_Add.TabIndex = 0;
            this.Rd_Add.TabStop = true;
            this.Rd_Add.Text = "Add";
            this.Rd_Add.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_TstCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 410);
            this.Controls.Add(this.Btt_Generate);
            this.Controls.Add(this.Grp_Exm);
            this.Controls.Add(this.Grp_Result);
            this.Controls.Add(this.Grp_Operator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_TstCal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test your calculation skill with fractions";
            this.Load += new System.EventHandler(this.Frm_TstCal_Load);
            this.Grp_Exm.ResumeLayout(false);
            this.Grp_Exm.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.GroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Grp_Result.ResumeLayout(false);
            this.Grp_Result.PerformLayout();
            this.Grp_Operator.ResumeLayout(false);
            this.Grp_Operator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Btt_Generate;
        internal System.Windows.Forms.GroupBox Grp_Exm;
        private System.Windows.Forms.Button Btt_Done;
        internal System.Windows.Forms.Button Btt_Try;
        internal System.Windows.Forms.GroupBox Grp_Result;
        internal System.Windows.Forms.TextBox Txt_Result;
        internal System.Windows.Forms.Label Lb_EqlS;
        internal System.Windows.Forms.Label Lb_Operator;
        internal System.Windows.Forms.GroupBox GroupBox5;
        private System.Windows.Forms.TextBox Txt_Den3;
        private System.Windows.Forms.TextBox Txt_Num3;
        internal System.Windows.Forms.PictureBox pictureBox3;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Label Lb_Den2;
        internal System.Windows.Forms.Label Lb_Num2;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Lb_Den1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Lb_Num1;
        internal System.Windows.Forms.GroupBox Grp_Operator;
        internal System.Windows.Forms.RadioButton Rd_Div;
        internal System.Windows.Forms.RadioButton Rd_Multi;
        internal System.Windows.Forms.RadioButton Rd_Sub;
        internal System.Windows.Forms.RadioButton Rd_Add;
        internal System.Windows.Forms.Button Btt_End;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.RadioButton Rd_Random;
        internal System.Windows.Forms.PictureBox pictureBox2;
    }
}