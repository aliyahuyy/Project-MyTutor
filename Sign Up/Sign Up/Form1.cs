using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Sign_Up
{
    public partial class Form1 : Form
    {
        public class Data
        {
            public string nama { get; set; }
            public string username { get; set; }
            public string email { get; set; }
            public string password { get; set; }
           

            public Data(string nama, string username, string email, string password)
            {
                this.nama = nama;
                this.username = username;
                this.email = email;
                this.password = password; 
            }
            public Data()
            {

            }
            
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button_daftar_Click(object sender, EventArgs e)
        {
            string isi = textNama.Text;
            string isi1 = textUsername.Text;
            string isi2 = textEmail.Text;
            string isi3 = textPassword.Text;
            string isi4 = textRePass.Text;
            
            if (isi.Trim() == string.Empty)
            {
                MessageBox.Show("Nama tidak boleh kosong");
            } else if (isi1.Trim() == string.Empty) 
            {
                MessageBox.Show("Username tidak boleh kosong");
            } else if (isi1.Length > 10)
            {
                MessageBox.Show("Username tidak boleh melebihi 10 karakter");
            } else if (isi2.Trim() == string.Empty)
            {
                MessageBox.Show("Email tidak boleh kosong");
            } else if (isi4 != isi3)
            {
                MessageBox.Show("Password harus sama");
            } else
            {
                MessageBox.Show("Pendaftaran Berhasil!");
            }

            Data data = new Data();
            data.nama = textNama.Text;
            data.username = textUsername.Text;
            data.email = textEmail.Text;
            data.password = textPassword.Text;
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);

            File.WriteAllText("C:/Users/computer/Documents/Kuliah Alya/Project-MyTutor/Sign Up/Sign Up/DATA.json", json);
        }
    }
}
