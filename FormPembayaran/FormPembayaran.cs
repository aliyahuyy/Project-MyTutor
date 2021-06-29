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
    public partial class formPembayaran : Form
    {

        public formPembayaran(string inTanggal, string inJam, string inMataPelajaran, string inTingkatPendidikan,
            string inTutor, string inDurasi, string inBiayaPJam, string inTotalPembayaran)
        {
            InitializeComponent();
            tanggal.Text = inTanggal;
            jam.Text = inJam;
            mataPelajaran.Text = inMataPelajaran;
            tingkatPendidikan.Text = inTingkatPendidikan;
            tutor.Text = inTutor;
            durasi.Text = inDurasi;
            biayaPerJam.Text = inBiayaPJam;
            totalPembayaran.Text = inTotalPembayaran;
        }

        private void FormPembayaran_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            msgBayar m = new msgBayar(totalPembayaran.Text);
            this.Hide();
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
