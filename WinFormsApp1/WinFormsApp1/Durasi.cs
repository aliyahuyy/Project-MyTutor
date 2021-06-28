using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Durasi
    {
        public enum Durasi_pem
        {
            Satu  , Dua , Tiga
        }
        public static int Getdurasi(Durasi_pem durasi)
        {
            int[] angka = { 1, 2, 3 };
            return angka[(int)durasi];
        }
    }
}
