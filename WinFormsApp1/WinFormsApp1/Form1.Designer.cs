﻿
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.biaya = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, -160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detail Pembelajaran";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Tutor : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tingkat Pendidikan : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mata Pelajaran : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tempat Pertemuan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Durasi Pertemuan/Jam";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Metode Pembayaran : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total Biaya : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(315, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightCyan;
            this.textBox1.Location = new System.Drawing.Point(356, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(231, 31);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Falia Alya Qila";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightCyan;
            this.textBox2.Location = new System.Drawing.Point(356, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(231, 31);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "SMA";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightCyan;
            this.textBox3.Location = new System.Drawing.Point(356, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(231, 31);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Matematika";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.LightCyan;
            this.textBox4.Location = new System.Drawing.Point(356, 213);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(231, 31);
            this.textBox4.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(501, 328);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(86, 33);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(477, 388);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(110, 33);
            this.comboBox2.TabIndex = 14;
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.Color.LightCyan;
            this.Total.Location = new System.Drawing.Point(356, 441);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(231, 31);
            this.Total.TabIndex = 15;
            this.Total.TextChanged += new System.EventHandler(this.Total_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 533);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // biaya
            // 
            this.biaya.BackColor = System.Drawing.Color.LightCyan;
            this.biaya.Location = new System.Drawing.Point(356, 272);
            this.biaya.Name = "biaya";
            this.biaya.ReadOnly = true;
            this.biaya.Size = new System.Drawing.Size(231, 31);
            this.biaya.TabIndex = 18;
            this.biaya.Text = "Rp 150.000.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Biaya";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(644, 658);
            this.Controls.Add(this.biaya);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Detail Pembelajaran";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox biaya;
        private System.Windows.Forms.Label label9;
    }
}

