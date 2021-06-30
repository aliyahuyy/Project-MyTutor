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
        public static int GetMetode(Metode_bayar metode)
        {
            int[] urutan = {1 , 2 ,3 , 4};
            return urutan[(int)metode];
        }
    }
}
