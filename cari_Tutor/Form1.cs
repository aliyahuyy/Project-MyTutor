using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace cari_Tutor
{

    public partial class Form1 : Form
    {
    public Form1()
        {
            InitializeComponent();
            
            foreach (string name_ in Enum.GetNames(typeof(Daftar_Tutor.Nama_tutor)))
            {
                tb_daftar_tutor.Rows.Add(name_, Daftar_Tutor.GetMapel(name_), Daftar_Tutor.GetTingPed(name_),
                    Daftar_Tutor.GetHarga(name_), Daftar_Tutor.GetKota(name_));
 
            }
            
        }

        private void tb_daftar_tutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tb_daftar_tutor.CurrentRow.Selected == true)
            {
                button1.Enabled = true;
            }
            else { button1.Enabled = false; }
            
        }
    }
}
