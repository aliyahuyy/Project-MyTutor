using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profile_mytutor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCombobox();
        }

        private void InitializeCombobox()
        {
            comboBox1.Items.AddRange(Enum.GetNames(typeof(status.status_profil)));
            comboBox1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda telah log out");
            Close();
            
        }

        private void edit_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            comboBox1.Enabled = true;
            save.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void save_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text ==  "") || (textBox2.Text == "") || (textBox3.Text == ""))
            {
                MessageBox.Show("Data belum lengkap");
            }
            else {
                var que = MessageBox.Show("Apakah anda yakin?", "Menyimpan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (que == DialogResult.Yes)
                {
                    MessageBox.Show("Data telah disimpan");
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    comboBox1.Enabled = false;
                    save.Enabled = false;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.TextLength > 10)
            {
                label8.Text = ("nama terlalu panjang") ;
            }
        }
    }
}
