using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tes
{
    class Mahasiswa
    {
        public Mahasiswa(DateTime date, string nama)
        {
            this.date = date;
            this.nama = nama;
        }
       
        public DateTime date { get; set; }
        public string nama { get; set; }
    }
    
    
}
