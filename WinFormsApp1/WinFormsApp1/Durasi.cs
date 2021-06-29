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
        public static string Getdurasi(Durasi_pem durasi)
        {
            string[] angka = {"satu","dua","tiga"};
            return angka[(int)durasi];
        }
    }
}
