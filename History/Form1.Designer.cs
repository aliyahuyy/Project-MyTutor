
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TanggalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MataPelajaranColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TingkatPendidikanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurasiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bayarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TanggalColumn,
            this.TutorColumn,
            this.MataPelajaranColumn,
            this.TingkatPendidikanColumn,
            this.DurasiColumn,
            this.HargaColumn,
            this.StatusColumn});
            this.dataGridView1.Location = new System.Drawing.Point(48, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // TanggalColumn
            // 
            this.TanggalColumn.HeaderText = "Tanggal";
            this.TanggalColumn.Name = "TanggalColumn";
            // 
            // TutorColumn
            // 
            this.TutorColumn.HeaderText = "Tutor";
            this.TutorColumn.Name = "TutorColumn";
            // 
            // MataPelajaranColumn
            // 
            this.MataPelajaranColumn.HeaderText = "Mata Pelajaran";
            this.MataPelajaranColumn.Name = "MataPelajaranColumn";
            // 
            // TingkatPendidikanColumn
            // 
            this.TingkatPendidikanColumn.HeaderText = "Tingkat Pendidikan";
            this.TingkatPendidikanColumn.Name = "TingkatPendidikanColumn";
            // 
            // DurasiColumn
            // 
            this.DurasiColumn.HeaderText = "Durasi";
            this.DurasiColumn.Name = "DurasiColumn";
            // 
            // HargaColumn
            // 
            this.HargaColumn.HeaderText = "Harga";
            this.HargaColumn.Name = "HargaColumn";
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bayarBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MataPelajaranColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TingkatPendidikanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurasiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.Button bayarBtn;
    }
}

