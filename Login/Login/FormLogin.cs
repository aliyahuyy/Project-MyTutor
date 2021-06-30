using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if(textUName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Username tidak boleh kosong!");
                textUName.Clear();
                textPass.Clear();
            } else if(textPass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("password tidak boleh kosong! ");
                textUName.Clear();
                textPass.Clear();
            }
            else
            {
                MessageBox.Show("Login berhasil!");
                //Next Form.
                /* new form().show();
                 this.hide*/
            }
        }

        private void button_for_SignUp_Click(object sender, EventArgs e)
        {
            //new Form().Show();
            this.Hide();
        }
    }
}
