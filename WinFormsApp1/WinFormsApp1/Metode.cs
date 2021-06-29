using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Metode
    {
        public enum Metode_bayar
        {
            Cash , Mandiri , BCA , BRI
        }
        public static String GetMetode(Metode_bayar metode)
        {
            String[] urutan = {"cash" , "mandiri" , "bca" , "bri"};
            return urutan[(int)metode];
        }
    }
}
