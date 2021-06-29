
namespace History
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
            this.bayarBtn = new System.Windows.Forms.Button();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurasiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TingkatPendidikanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MataPelajaranColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabelHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // bayarBtn
            // 
            this.bayarBtn.Location = new System.Drawing.Point(657, 374);
            this.bayarBtn.Name = "bayarBtn";
            this.bayarBtn.Size = new System.Drawing.Size(75, 23);
            this.bayarBtn.TabIndex = 1;
            this.bayarBtn.Text = "Bayar";
            this.bayarBtn.UseVisualStyleBackColor = true;
            this.bayarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            // 
            // HargaColumn
            // 
            this.HargaColumn.HeaderText = "Harga";
            this.HargaColumn.Name = "HargaColumn";
            // 
            // DurasiColumn
            // 
            this.DurasiColumn.HeaderText = "Durasi";
            this.DurasiColumn.Name = "DurasiColumn";
            // 
            // TingkatPendidikanColumn
            // 
            this.TingkatPendidikanColumn.HeaderText = "Tingkat Pendidikan";
            this.TingkatPendidikanColumn.Name = "TingkatPendidikanColumn";
            // 
            // MataPelajaranColumn
            // 
            this.MataPelajaranColumn.HeaderText = "Mata Pelajaran";
            this.MataPelajaranColumn.Name = "MataPelajaranColumn";
            // 
            // TutorColumn
            // 
            this.TutorColumn.HeaderText = "Tutor";
            this.TutorColumn.Name = "TutorColumn";
            // 
            // TanggalColumn
            // 
            this.TanggalColumn.HeaderText = "Tanggal";
            this.TanggalColumn.Name = "TanggalColumn";
            // 
            // tabelHistory
            // 
            this.tabelHistory.AllowUserToAddRows = false;
            this.tabelHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TanggalColumn,
            this.TutorColumn,
            this.MataPelajaranColumn,
            this.TingkatPendidikanColumn,
            this.DurasiColumn,
            this.HargaColumn,
            this.StatusColumn});
            this.tabelHistory.Location = new System.Drawing.Point(37, 41);
            this.tabelHistory.Name = "tabelHistory";
            this.tabelHistory.ReadOnly = true;
            this.tabelHistory.Size = new System.Drawing.Size(705, 280);
            this.tabelHistory.TabIndex = 0;
            this.tabelHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.tabelHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.bayarBtn);
            this.Controls.Add(this.tabelHistory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bayarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurasiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TingkatPendidikanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MataPelajaranColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalColumn;
        private System.Windows.Forms.DataGridView tabelHistory;
    }
}

