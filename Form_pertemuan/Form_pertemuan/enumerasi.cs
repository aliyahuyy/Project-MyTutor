using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_pertemuan
{
    public class enumerasi
    {
        public enum Metode_bayar
        {
            Cash, Mandiri, BCA, BRI
        }
        public static int GetMetode(Metode_bayar metode)
        {
            int[] urutan = { 1, 2, 3, 4 };
            return urutan[(int)metode];
        }
        public enum Durasi_pem
        {
            Satu , Dua, Tiga , Empat , Lima
        }
        public static int Getdurasi(Durasi_pem durasi)
        {
            int[] angka = { 1, 2, 3 };
            return angka[(int)durasi];
        }
    }
}
