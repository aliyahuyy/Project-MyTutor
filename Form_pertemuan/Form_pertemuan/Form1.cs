using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_pertemuan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            InitializeComboBox1();
            
        }

        private void InitializeComboBox1()
        {
            comboBox2.Items.AddRange(Enum.GetNames(typeof(enumerasi.Metode_bayar)));
        }

        private void InitializeComboBox()
        {
            comboBox1.Items.AddRange(Enum.GetNames(typeof(enumerasi.Durasi_pem)));
            comboBox1.SelectedIndex = (int)enumerasi.Durasi_pem.Dua;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox4.Text == "") || (Total.Text == ""))
            {
                MessageBox.Show("maaf data belum lengkap");
            }
            else
            {
                MessageBox.Show("Form telah disubmit , silahkan menunggu konfirmasi tutor!", "Tunggu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e){}

        private void Total_Click(object sender, EventArgs e)
        {
            int Biaya = int.Parse(biaya.Text);
            int durasi = int.Parse(comboBox1.Text);
            int total = int.Parse(Total.Text);
            if (comboBox1.SelectedIndex == (int)enumerasi.Durasi_pem.Dua)
            {
                 total = Biaya * durasi;
                
            }
        }
    }
}
