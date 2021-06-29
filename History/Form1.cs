using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using FormPembayaran;
namespace History
{
    public partial class Form1 : Form
    {
        List<History> isiPembayaran;
        public Form1()
        {
            InitializeComponent();
            bayarBtn.Enabled = false;

            
            string json = File.ReadAllText("D:/Aqila/Konstruksi/Project-MyTutor/History/Data History.json");
            isiPembayaran = JsonSerializer.Deserialize<List<History>>(json);
            for (int i = 0; i < isiPembayaran.Count; i++)
            {
                tabelHistory.Rows.Add(
                    isiPembayaran[i].tanggal,
                    isiPembayaran[i].tutor,
                    isiPembayaran[i].mataPelajaran,
                    isiPembayaran[i].tingkatPendidikan,
                    isiPembayaran[i].durasi,
                    isiPembayaran[i].totalBiaya,
                    isiPembayaran[i].status

                );
            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int i = tabelHistory.CurrentRow.Index;
            formPembayaran fp = new formPembayaran(
                    isiPembayaran[i].tanggal,
                    isiPembayaran[i].jam,
                    isiPembayaran[i].mataPelajaran,
                    isiPembayaran[i].tingkatPendidikan,
                    isiPembayaran[i].tutor,
                    isiPembayaran[i].durasi,
                    isiPembayaran[i].biayaPerJam,
                    isiPembayaran[i].totalBiaya
                );
            fp.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabelHistory.CurrentRow.Cells[6].Value.ToString() == "Disetujui")
            {
                bayarBtn.Enabled = true;
            } else
            {
                bayarBtn.Enabled = false;
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
