using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile_mytutor
{
    public class akun
    {
        public enum username
        {
            justinbiber, alisya , roberto_frs , reinasr
        }
        public static String Getnama (String user)
        {
            username usr = (username)Enum.Parse(typeof(username), user);
            String[] nama = { "Justin Biber", "Alisya R", "FRansis", "Reina" };

            return nama[(int)usr];
        }
        public static String GetEmail(String user)
        {
            username usr = (username)Enum.Parse(typeof(username), user);
            String[] email = { "justin@gmail.com", "lisa@gmail.com", "roberto@yahoo.com", "Reina@gmail.com" };

            return email[(int)usr];
        }
        public static String GetPass(String user)
        {
            username usr  = (username)Enum.Parse(typeof(username), user);
            String[] password = { "J123@1", "molamola", "heiyuuu1", "reinadisini" };

            return password[(int)usr];
        }
        public static String GetStatus(String user)
        {
            username usr = (username)Enum.Parse(typeof(username), user);
            String[] status = { "Pelajar", "Pengajar", "Pelajar", "Pengajar" };

            return status[(int)usr];
        }
    }
}
