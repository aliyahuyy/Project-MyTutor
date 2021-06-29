
namespace FormPembayaran
{
    partial class formPembayaran
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
            System.Windows.Forms.Label Judul;
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tanggal = new System.Windows.Forms.Label();
            this.jam = new System.Windows.Forms.Label();
            this.mataPelajaran = new System.Windows.Forms.Label();
            this.tingkatPendidikan = new System.Windows.Forms.Label();
            this.tutor = new System.Windows.Forms.Label();
            this.durasi = new System.Windows.Forms.Label();
            this.biayaPerJam = new System.Windows.Forms.Label();
            this.totalPembayaran = new System.Windows.Forms.Label();
            Judul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Judul
            // 
            Judul.AutoSize = true;
            Judul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Judul.Location = new System.Drawing.Point(110, 31);
            Judul.Name = "Judul";
            Judul.Size = new System.Drawing.Size(115, 13);
            Judul.TabIndex = 3;
            Judul.Text = "FORM PEMBAYARAN";
            Judul.Click += new System.EventHandler(this.Judul_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Bayar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detail Pembelajaran:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tanggal";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tutor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mata Pelajaran";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tingkat Pendidikan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Durasi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Biaya per jam";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Total Pembayaran";
            // 
            // tanggal
            // 
            this.tanggal.AutoSize = true;
            this.tanggal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal.Location = new System.Drawing.Point(154, 97);
            this.tanggal.MinimumSize = new System.Drawing.Size(150, 20);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(150, 20);
            this.tanggal.TabIndex = 13;
            this.tanggal.Text = "-";
            this.tanggal.Click += new System.EventHandler(this.button1_Click);
            // 
            // jam
            // 
            this.jam.AutoSize = true;
            this.jam.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.jam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jam.Location = new System.Drawing.Point(154, 128);
            this.jam.MinimumSize = new System.Drawing.Size(150, 20);
            this.jam.Name = "jam";
            this.jam.Size = new System.Drawing.Size(150, 20);
            this.jam.TabIndex = 14;
            this.jam.Text = "-";
            // 
            // mataPelajaran
            // 
            this.mataPelajaran.AutoSize = true;
            this.mataPelajaran.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mataPelajaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mataPelajaran.Location = new System.Drawing.Point(154, 157);
            this.mataPelajaran.MinimumSize = new System.Drawing.Size(150, 20);
            this.mataPelajaran.Name = "mataPelajaran";
            this.mataPelajaran.Size = new System.Drawing.Size(150, 20);
            this.mataPelajaran.TabIndex = 15;
            this.mataPelajaran.Text = "-";
            // 
            // tingkatPendidikan
            // 
            this.tingkatPendidikan.AutoSize = true;
            this.tingkatPendidikan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tingkatPendidikan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tingkatPendidikan.Location = new System.Drawing.Point(154, 186);
            this.tingkatPendidikan.MinimumSize = new System.Drawing.Size(150, 20);
            this.tingkatPendidikan.Name = "tingkatPendidikan";
            this.tingkatPendidikan.Size = new System.Drawing.Size(150, 20);
            this.tingkatPendidikan.TabIndex = 16;
            this.tingkatPendidikan.Text = "-";
            // 
            // tutor
            // 
            this.tutor.AutoSize = true;
            this.tutor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutor.Location = new System.Drawing.Point(154, 215);
            this.tutor.MinimumSize = new System.Drawing.Size(150, 20);
            this.tutor.Name = "tutor";
            this.tutor.Size = new System.Drawing.Size(150, 20);
            this.tutor.TabIndex = 17;
            this.tutor.Text = "-";
            // 
            // durasi
            // 
            this.durasi.AutoSize = true;
            this.durasi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.durasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durasi.Location = new System.Drawing.Point(154, 244);
            this.durasi.MinimumSize = new System.Drawing.Size(150, 20);
            this.durasi.Name = "durasi";
            this.durasi.Size = new System.Drawing.Size(150, 20);
            this.durasi.TabIndex = 18;
            this.durasi.Text = "-";
            // 
            // biayaPerJam
            // 
            this.biayaPerJam.AutoSize = true;
            this.biayaPerJam.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.biayaPerJam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biayaPerJam.Location = new System.Drawing.Point(154, 273);
            this.biayaPerJam.MinimumSize = new System.Drawing.Size(150, 20);
            this.biayaPerJam.Name = "biayaPerJam";
            this.biayaPerJam.Size = new System.Drawing.Size(150, 20);
            this.biayaPerJam.TabIndex = 19;
            this.biayaPerJam.Text = "-";
            // 
            // totalPembayaran
            // 
            this.totalPembayaran.AutoSize = true;
            this.totalPembayaran.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.totalPembayaran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPembayaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPembayaran.Location = new System.Drawing.Point(154, 302);
            this.totalPembayaran.MinimumSize = new System.Drawing.Size(150, 20);
            this.totalPembayaran.Name = "totalPembayaran";
            this.totalPembayaran.Size = new System.Drawing.Size(150, 20);
            this.totalPembayaran.TabIndex = 20;
            this.totalPembayaran.Text = "Rp 0,00";
            // 
            // formPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.totalPembayaran);
            this.Controls.Add(this.biayaPerJam);
            this.Controls.Add(this.durasi);
            this.Controls.Add(this.tutor);
            this.Controls.Add(this.tingkatPendidikan);
            this.Controls.Add(this.mataPelajaran);
            this.Controls.Add(this.jam);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(Judul);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "formPembayaran";
            this.Text = "Form Pembayaran";
            this.Load += new System.EventHandler(this.FormPembayaran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label tanggal;
        private System.Windows.Forms.Label jam;
        private System.Windows.Forms.Label mataPelajaran;
        private System.Windows.Forms.Label tingkatPendidikan;
        private System.Windows.Forms.Label tutor;
        private System.Windows.Forms.Label durasi;
        private System.Windows.Forms.Label biayaPerJam;
        private System.Windows.Forms.Label totalPembayaran;
    }
}

