using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
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
            comboBox2.Items.AddRange(Enum.GetNames(typeof(Metode.Metode_bayar)));
            comboBox2.SelectedIndex = (int)Metode.Metode_bayar.Bank;
        }

        private void InitializeComboBox()
        {
            comboBox1.Items.AddRange(Enum.GetNames(typeof(Durasi.Durasi_pem)));
            comboBox1.SelectedIndex = (int)Durasi.Durasi_pem.Tiga;
        }

        private void label1_Click(object sender, EventArgs e){}

        private void Form1_Load(object sender, EventArgs e){}

        private void label2_Click(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form telah disubmit , silahkan menunggu konfirmasi tutor!","Tunggu" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Total_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
