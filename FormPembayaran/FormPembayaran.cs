using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPembayaran
{
    public partial class FormPembayaran : Form
    {

        public FormPembayaran()
        {
            InitializeComponent();
            tanggal.Text = "isi";
            jam.Text = "isi";
            mataPelajaran.Text = "isi";
            tingkatPendidikan.Text = "isi";
            tutor.Text = "isi";
            durasi.Text = "isi";
            biayaPerJam.Text = "isi";
            totalPembayaran.Text = "isi";
      
        }

        private void FormPembayaran_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            msgBayar m = new msgBayar();
            m.ShowDialog();
            this.Close();   
        }

   

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Judul_Click(object sender, EventArgs e)
        {

        }
    }
}
