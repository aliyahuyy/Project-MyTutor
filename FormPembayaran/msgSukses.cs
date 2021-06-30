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
    public partial class msgSukses : Form
    {
        public msgSukses()
        {
            InitializeComponent();
            this.Hide();
        }

        private void msgSukses_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
