﻿using System;
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
    public partial class msgBayar : Form
    {
        public msgBayar()
        {
            
            InitializeComponent();
            this.Hide();
        }

        private void msgBayar_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            msgSukses m = new msgSukses();
            m.ShowDialog();
            this.Close();
        }
    }
}