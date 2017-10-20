namespace Fraction_TIE
{
    partial class Frm_AuCal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rd_Multi = new System.Windows.Forms.RadioButton();
            this.Rd_Div = new System.Windows.Forms.RadioButton();
            this.Rd_Add = new System.Windows.Forms.RadioButton();
            this.Rd_Sub = new System.Windows.Forms.RadioButton();
            this.Lb_EqlS = new System.Windows.Forms.Label();
            this.Lb_Operator = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Txt_Den2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Txt_Num2 = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Txt_Den1 = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txt_Num1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Lb_Den3 = new System.Windows.Forms.Label();
            this.Lb_Num3 = new System.Windows.Forms.Label();
            this.Btt_Clear = new System.Windows.Forms.Button();
            this.Btt_Close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rd_Multi);
            this.groupBox1.Controls.Add(this.Rd_Div);
            this.groupBox1.Controls.Add(this.Rd_Add);
            this.groupBox1.Controls.Add(this.Rd_Sub);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operator";
            // 
            // Rd_Multi
            // 
            this.Rd_Multi.AutoSize = true;
            this.Rd_Multi.Location = new System.Drawing.Point(190, 25);
            this.Rd_Multi.Name = "Rd_Multi";
            this.Rd_Multi.Size = new System.Drawing.Size(30, 17);
            this.Rd_Multi.TabIndex = 2;
            this.Rd_Multi.TabStop = true;
            this.Rd_Multi.Text = "x";
            this.Rd_Multi.UseVisualStyleBackColor = true;
            this.Rd_Multi.CheckedChanged += new System.EventHandler(this.Rd_Multi_CheckedChanged);
            // 
            // Rd_Div
            // 
            this.Rd_Div.AutoSize = true;
            this.Rd_Div.Location = new System.Drawing.Point(266, 25);
            this.Rd_Div.Name = "Rd_Div";
            this.Rd_Div.Size = new System.Drawing.Size(31, 17);
            this.Rd_Div.TabIndex = 3;
            this.Rd_Div.TabStop = true;
            this.Rd_Div.Text = "÷";
            this.Rd_Div.UseVisualStyleBackColor = true;
            this.Rd_Div.CheckedChanged += new System.EventHandler(this.Rd_Div_CheckedChanged);
            // 
            // Rd_Add
            // 
            this.Rd_Add.AutoSize = true;
            this.Rd_Add.Location = new System.Drawing.Point(33, 25);
            this.Rd_Add.Name = "Rd_Add";
            this.Rd_Add.Size = new System.Drawing.Size(31, 17);
            this.Rd_Add.TabIndex = 0;
            this.Rd_Add.TabStop = true;
            this.Rd_Add.Text = "+";
            this.Rd_Add.UseVisualStyleBackColor = true;
            this.Rd_Add.Click += new System.EventHandler(this.Rd_Add_Click);
            // 
            // Rd_Sub
            // 
            this.Rd_Sub.AutoSize = true;
            this.Rd_Sub.Location = new System.Drawing.Point(110, 25);
            this.Rd_Sub.Name = "Rd_Sub";
            this.Rd_Sub.Size = new System.Drawing.Size(31, 17);
            this.Rd_Sub.TabIndex = 1;
            this.Rd_Sub.TabStop = true;
            this.Rd_Sub.Text = " -";
            this.Rd_Sub.UseVisualStyleBackColor = true;
            this.Rd_Sub.CheckedChanged += new System.EventHandler(this.Rd_Sub_CheckedChanged);
            // 
            // Lb_EqlS
            // 
            this.Lb_EqlS.AutoSize = true;
            this.Lb_EqlS.Location = new System.Drawing.Point(226, 109);
            this.Lb_EqlS.Name = "Lb_EqlS";
            this.Lb_EqlS.Size = new System.Drawing.Size(13, 13);
            this.Lb_EqlS.TabIndex = 11;
            this.Lb_EqlS.Text = "=";
            // 
            // Lb_Operator
            // 
            this.Lb_Operator.AutoSize = true;
            this.Lb_Operator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Operator.Location = new System.Drawing.Point(121, 109);
            this.Lb_Operator.Name = "Lb_Operator";
            this.Lb_Operator.Size = new System.Drawing.Size(13, 13);
            this.Lb_Operator.TabIndex = 10;
            this.Lb_Operator.Text = "+";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.Txt_Den2);
            this.GroupBox4.Controls.Add(this.pictureBox2);
            this.GroupBox4.Controls.Add(this.Txt_Num2);
            this.GroupBox4.Location = new System.Drawing.Point(156, 72);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(48, 82);
            this.GroupBox4.TabIndex = 2;
            this.GroupBox4.TabStop = false;
            // 
            // Txt_Den2
            // 
            this.Txt_Den2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Den2.Location = new System.Drawing.Point(6, 55);
            this.Txt_Den2.MaxLength = 3;
            this.Txt_Den2.Name = "Txt_Den2";
            this.Txt_Den2.Size = new System.Drawing.Size(37, 20);
            this.Txt_Den2.TabIndex = 1;
            this.Txt_Den2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_Den2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Den2_KeyUp);
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
            // Txt_Num2
            // 
            this.Txt_Num2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Num2.Location = new System.Drawing.Point(6, 14);
            this.Txt_Num2.MaxLength = 3;
            this.Txt_Num2.Name = "Txt_Num2";
            this.Txt_Num2.Size = new System.Drawing.Size(37, 20);
            this.Txt_Num2.TabIndex = 0;
            this.Txt_Num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_Num2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Num2_KeyDown);
            this.Txt_Num2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Num2_KeyUp);
            this.Txt_Num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Num2_KeyPress);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Txt_Den1);
            this.GroupBox3.Controls.Add(this.PictureBox1);
            this.GroupBox3.Controls.Add(this.Txt_Num1);
            this.GroupBox3.Location = new System.Drawing.Point(53, 72);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(46, 82);
            this.GroupBox3.TabIndex = 1;
            this.GroupBox3.TabStop = false;
            // 
            // Txt_Den1
            // 
            this.Txt_Den1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Den1.Location = new System.Drawing.Point(5, 56);
            this.Txt_Den1.MaxLength = 3;
            this.Txt_Den1.Name = "Txt_Den1";
            this.Txt_Den1.Size = new System.Drawing.Size(37, 20);
            this.Txt_Den1.TabIndex = 1;
            this.Txt_Den1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_Den1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Den1_KeyUp);
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
            // Txt_Num1
            // 
            this.Txt_Num1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Num1.Location = new System.Drawing.Point(5, 14);
            this.Txt_Num1.MaxLength = 3;
            this.Txt_Num1.Name = "Txt_Num1";
            this.Txt_Num1.Size = new System.Drawing.Size(37, 20);
            this.Txt_Num1.TabIndex = 0;
            this.Txt_Num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_Num1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Num1_KeyDown);
            this.Txt_Num1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Num1_KeyUp);
            this.Txt_Num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Num1_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.Lb_Den3);
            this.groupBox2.Controls.Add(this.Lb_Num3);
            this.groupBox2.Location = new System.Drawing.Point(253, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(56, 82);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Fraction_TIE.Properties.Resources.Split;
            this.pictureBox4.Location = new System.Drawing.Point(12, 40);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 10);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // Lb_Den3
            // 
            this.Lb_Den3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Den3.Location = new System.Drawing.Point(6, 53);
            this.Lb_Den3.Name = "Lb_Den3";
            this.Lb_Den3.Size = new System.Drawing.Size(44, 17);
            this.Lb_Den3.TabIndex = 1;
            this.Lb_Den3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lb_Num3
            // 
            this.Lb_Num3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb_Num3.Location = new System.Drawing.Point(6, 16);
            this.Lb_Num3.Name = "Lb_Num3";
            this.Lb_Num3.Size = new System.Drawing.Size(44, 18);
            this.Lb_Num3.TabIndex = 0;
            this.Lb_Num3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btt_Clear
            // 
            this.Btt_Clear.Location = new System.Drawing.Point(186, 160);
            this.Btt_Clear.Name = "Btt_Clear";
            this.Btt_Clear.Size = new System.Drawing.Size(75, 23);
            this.Btt_Clear.TabIndex = 4;
            this.Btt_Clear.Text = "Clear";
            this.Btt_Clear.UseVisualStyleBackColor = true;
            this.Btt_Clear.Click += new System.EventHandler(this.Btt_Clear_Click);
            // 
            // Btt_Close
            // 
            this.Btt_Close.Location = new System.Drawing.Point(267, 160);
            this.Btt_Close.Name = "Btt_Close";
            this.Btt_Close.Size = new System.Drawing.Size(75, 23);
            this.Btt_Close.TabIndex = 5;
            this.Btt_Close.Text = "Close";
            this.Btt_Close.UseVisualStyleBackColor = true;
            this.Btt_Close.Click += new System.EventHandler(this.Btt_Close_Click);
            // 
            // Frm_AuCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 192);
            this.Controls.Add(this.Btt_Close);
            this.Controls.Add(this.Btt_Clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Lb_EqlS);
            this.Controls.Add(this.Lb_Operator);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_AuCal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fraction Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rd_Add;
        private System.Windows.Forms.RadioButton Rd_Sub;
        private System.Windows.Forms.RadioButton Rd_Multi;
        private System.Windows.Forms.RadioButton Rd_Div;
        internal System.Windows.Forms.Label Lb_EqlS;
        internal System.Windows.Forms.Label Lb_Operator;
        internal System.Windows.Forms.GroupBox GroupBox4;
        private System.Windows.Forms.TextBox Txt_Den2;
        internal System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Txt_Num2;
        internal System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.TextBox Txt_Den1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.TextBox Txt_Num1;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.PictureBox pictureBox4;
        internal System.Windows.Forms.Label Lb_Den3;
        internal System.Windows.Forms.Label Lb_Num3;
        private System.Windows.Forms.Button Btt_Clear;
        private System.Windows.Forms.Button Btt_Close;
    }
}