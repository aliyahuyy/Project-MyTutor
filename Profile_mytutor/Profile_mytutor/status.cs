using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile_mytutor
{
    public class status
    {
        public enum status_profil
        {
            Pengajar, Pelajar
        }
        public static int Getstatus (status_profil stat)
        {
            return (int)stat;
        }
    }
}
