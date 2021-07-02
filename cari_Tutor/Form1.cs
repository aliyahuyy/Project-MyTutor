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
                Tb_Daftar_tutor.Rows.Add(name_, Daftar_Tutor.GetMapel(name_), Daftar_Tutor.GetTingPed(name_),
                    Daftar_Tutor.GetHarga(name_), Daftar_Tutor.GetKota(name_));
                
            }
            for (int i = 0; i < Daftar_Tutor.Mapel_List_Public.Count; i++)
            {
                Cbx_Mapel.Items.Add(Daftar_Tutor.Mapel_List_Public[i]);
            }
            
            for (int i = 0; i < Daftar_Tutor.Tingped_List_Public.Count; i++)
            {
                Cbx_Tingped.Items.Add(Daftar_Tutor.Tingped_List_Public[i]);
            }
            
            for (int i = 0; i < Daftar_Tutor.Kota_List_Public.Count; i++)
            {
                Cbx_Kota.Items.Add(Daftar_Tutor.Kota_List_Public[i]);
            }

            Btn_TambahMeet.Enabled = false;
            Btn_Cari_tutor.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maaf tutor tidak tersedia");
        }

        private void tb_daftar_tutor_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Clicks == 1)
            {
                Btn_TambahMeet.Enabled = true;
            }
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1)
            {
                Btn_Cari_tutor.Enabled = true;
            }
        }
    }
}
