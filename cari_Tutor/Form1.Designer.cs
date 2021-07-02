
namespace cari_Tutor
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tb_Daftar_tutor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_TambahMeet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Cari_tutor = new System.Windows.Forms.Button();
            this.Cbx_Kota = new System.Windows.Forms.ComboBox();
            this.Cbx_Tingped = new System.Windows.Forms.ComboBox();
            this.Cbx_Mapel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tb_Daftar_tutor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tb_Daftar_tutor
            // 
            this.Tb_Daftar_tutor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tb_Daftar_tutor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tb_Daftar_tutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tb_Daftar_tutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.Tb_Daftar_tutor.GridColor = System.Drawing.SystemColors.Info;
            this.Tb_Daftar_tutor.Location = new System.Drawing.Point(242, 50);
            this.Tb_Daftar_tutor.Name = "Tb_Daftar_tutor";
            this.Tb_Daftar_tutor.RowHeadersWidth = 40;
            this.Tb_Daftar_tutor.RowTemplate.Height = 28;
            this.Tb_Daftar_tutor.Size = new System.Drawing.Size(742, 491);
            this.Tb_Daftar_tutor.TabIndex = 0;
            this.Tb_Daftar_tutor.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tb_daftar_tutor_CellMouseClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Nama Tutor";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Mata_Pelajaran";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Tingkat_Pendidikan";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Harga";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "Kota";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Btn_TambahMeet
            // 
            this.Btn_TambahMeet.Location = new System.Drawing.Point(778, 558);
            this.Btn_TambahMeet.Name = "Btn_TambahMeet";
            this.Btn_TambahMeet.Size = new System.Drawing.Size(206, 34);
            this.Btn_TambahMeet.TabIndex = 1;
            this.Btn_TambahMeet.Text = "Tambah Pertemuan";
            this.Btn_TambahMeet.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.Btn_Cari_tutor);
            this.panel1.Controls.Add(this.Cbx_Kota);
            this.panel1.Controls.Add(this.Cbx_Tingped);
            this.panel1.Controls.Add(this.Cbx_Mapel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 604);
            this.panel1.TabIndex = 2;
            // 
            // Btn_Cari_tutor
            // 
            this.Btn_Cari_tutor.Location = new System.Drawing.Point(49, 354);
            this.Btn_Cari_tutor.Name = "Btn_Cari_tutor";
            this.Btn_Cari_tutor.Size = new System.Drawing.Size(117, 30);
            this.Btn_Cari_tutor.TabIndex = 7;
            this.Btn_Cari_tutor.Text = "Cari Tutor";
            this.Btn_Cari_tutor.UseVisualStyleBackColor = true;
            // 
            // Cbx_Kota
            // 
            this.Cbx_Kota.FormattingEnabled = true;
            this.Cbx_Kota.Location = new System.Drawing.Point(15, 228);
            this.Cbx_Kota.Name = "Cbx_Kota";
            this.Cbx_Kota.Size = new System.Drawing.Size(192, 28);
            this.Cbx_Kota.TabIndex = 6;
            // 
            // Cbx_Tingped
            // 
            this.Cbx_Tingped.FormattingEnabled = true;
            this.Cbx_Tingped.Location = new System.Drawing.Point(16, 169);
            this.Cbx_Tingped.Name = "Cbx_Tingped";
            this.Cbx_Tingped.Size = new System.Drawing.Size(192, 28);
            this.Cbx_Tingped.TabIndex = 5;
            // 
            // Cbx_Mapel
            // 
            this.Cbx_Mapel.FormattingEnabled = true;
            this.Cbx_Mapel.Location = new System.Drawing.Point(16, 109);
            this.Cbx_Mapel.Name = "Cbx_Mapel";
            this.Cbx_Mapel.Size = new System.Drawing.Size(192, 28);
            this.Cbx_Mapel.TabIndex = 4;
            this.Cbx_Mapel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lokasi (Kota)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tingkat Pendidikan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mata Pelajaran";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Tutor";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(546, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Daftar Tutor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(998, 604);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_TambahMeet);
            this.Controls.Add(this.Tb_Daftar_tutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Cari Tutor";
            ((System.ComponentModel.ISupportInitialize)(this.Tb_Daftar_tutor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tb_Daftar_tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button Btn_TambahMeet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Cari_tutor;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox Cbx_Kota;
        public System.Windows.Forms.ComboBox Cbx_Tingped;
        public System.Windows.Forms.ComboBox Cbx_Mapel;
    }
}

