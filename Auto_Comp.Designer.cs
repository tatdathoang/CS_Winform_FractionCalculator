namespace Fraction_TIE
{
    partial class Frm_AuComp
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
            this.Lb_Sign = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Txt_Den2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Txt_Num2 = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Txt_Den1 = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txt_Num1 = new System.Windows.Forms.TextBox();
            this.Btt_Clear = new System.Windows.Forms.Button();
            this.Btt_Close = new System.Windows.Forms.Button();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_Sign
            // 
            this.Lb_Sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Sign.Location = new System.Drawing.Point(155, 49);
            this.Lb_Sign.Name = "Lb_Sign";
            this.Lb_Sign.Size = new System.Drawing.Size(45, 13);
            this.Lb_Sign.TabIndex = 13;
            this.Lb_Sign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.Txt_Den2);
            this.GroupBox4.Controls.Add(this.pictureBox2);
            this.GroupBox4.Controls.Add(this.Txt_Num2);
            this.GroupBox4.Location = new System.Drawing.Point(205, 12);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(48, 82);
            this.GroupBox4.TabIndex = 12;
            this.GroupBox4.TabStop = false;
            // 
            // Txt_Den2
            // 
            this.Txt_Den2.Location = new System.Drawing.Point(6, 55);
            this.Txt_Den2.MaxLength = 3;
            this.Txt_Den2.Name = "Txt_Den2";
            this.Txt_Den2.Size = new System.Drawing.Size(37, 20);
            this.Txt_Den2.TabIndex = 7;
            this.Txt_Den2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_Den2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Den2_KeyUp_1);
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
            this.Txt_Num2.Location = new System.Drawing.Point(6, 14);
            this.Txt_Num2.MaxLength = 3;
            this.Txt_Num2.Name = "Txt_Num2";
            this.Txt_Num2.Size = new System.Drawing.Size(37, 20);
            this.Txt_Num2.TabIndex = 6;
            this.Txt_Num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_Num2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Num2_KeyDown_1);
            this.Txt_Num2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Num2_KeyUp_1);
            this.Txt_Num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Num2_KeyPress_1);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Txt_Den1);
            this.GroupBox3.Controls.Add(this.PictureBox1);
            this.GroupBox3.Controls.Add(this.Txt_Num1);
            this.GroupBox3.Location = new System.Drawing.Point(102, 12);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(46, 82);
            this.GroupBox3.TabIndex = 11;
            this.GroupBox3.TabStop = false;
            // 
            // Txt_Den1
            // 
            this.Txt_Den1.Location = new System.Drawing.Point(5, 56);
            this.Txt_Den1.MaxLength = 3;
            this.Txt_Den1.Name = "Txt_Den1";
            this.Txt_Den1.Size = new System.Drawing.Size(37, 20);
            this.Txt_Den1.TabIndex = 8;
            this.Txt_Den1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_Den1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Den1_KeyUp_1);
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
            this.Txt_Num1.Location = new System.Drawing.Point(5, 14);
            this.Txt_Num1.MaxLength = 3;
            this.Txt_Num1.Name = "Txt_Num1";
            this.Txt_Num1.Size = new System.Drawing.Size(37, 20);
            this.Txt_Num1.TabIndex = 5;
            this.Txt_Num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_Num1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Num1_KeyDown_1);
            this.Txt_Num1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Num1_KeyUp_1);
            this.Txt_Num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Num1_KeyPress_1);
            // 
            // Btt_Clear
            // 
            this.Btt_Clear.Location = new System.Drawing.Point(186, 109);
            this.Btt_Clear.Name = "Btt_Clear";
            this.Btt_Clear.Size = new System.Drawing.Size(75, 23);
            this.Btt_Clear.TabIndex = 14;
            this.Btt_Clear.Text = "Clear";
            this.Btt_Clear.UseVisualStyleBackColor = true;
            this.Btt_Clear.Click += new System.EventHandler(this.Btt_Clear_Click);
            // 
            // Btt_Close
            // 
            this.Btt_Close.Location = new System.Drawing.Point(267, 109);
            this.Btt_Close.Name = "Btt_Close";
            this.Btt_Close.Size = new System.Drawing.Size(75, 23);
            this.Btt_Close.TabIndex = 15;
            this.Btt_Close.Text = "Close";
            this.Btt_Close.UseVisualStyleBackColor = true;
            this.Btt_Close.Click += new System.EventHandler(this.Btt_Close_Click);
            // 
            // Frm_AuComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 144);
            this.Controls.Add(this.Btt_Close);
            this.Controls.Add(this.Btt_Clear);
            this.Controls.Add(this.Lb_Sign);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_AuComp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fraction Auto Compare";
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Lb_Sign;
        internal System.Windows.Forms.GroupBox GroupBox4;
        private System.Windows.Forms.TextBox Txt_Den2;
        internal System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Txt_Num2;
        internal System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.TextBox Txt_Den1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.TextBox Txt_Num1;
        private System.Windows.Forms.Button Btt_Clear;
        private System.Windows.Forms.Button Btt_Close;

    }
}