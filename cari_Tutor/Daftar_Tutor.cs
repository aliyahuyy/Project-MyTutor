using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cari_Tutor
{
    class Daftar_Tutor
    {
        public enum Nama_tutor
        {
            Adam_Husaain, Mellanie_Rodrico, Siti_Rohimah,
            Kinanti_Dewi, Cindy_Putri, Jiilaan_Hani,
            Nanda_Duta, Salsabila_Khoir, Siti_Rusmanah,
            Masrifah_Husna, Tony_Suherman, Ridwan_Setyawan,
            Malik_Hasan, Tiffany_Scott, Imas_Masrifah
        }
        public static string GetMapel(string name)
        {
            Nama_tutor nama_ = (Nama_tutor)Enum.Parse(typeof(Nama_tutor), name);
            string[] Mapel = {"Matematika", "IPA", "IPS", "Bahasa Jerman", "Bahasa Indonesia",
                              "Bahasa Inggris", "Biologi", "Fisika", "Matematika", "PKN",
                              "Matematika", "IPA", "IPS","Fisika", "Seni",};
            return Mapel[(int)nama_];
        }
        public static string GetTingPed(string name)
        {
            Nama_tutor nama_ = (Nama_tutor)Enum.Parse(typeof(Nama_tutor), name);
            string[] Tingped = {"SD", "SMA", "SMP", "SMA KELAS 10", "SD KELAS 5 & 6",
                                "SMA", "SMP", "SMP KELAS 8", "SD","SMA KELAS 12",
                                "SD", "SMA", "SMP", "SMA KELAS 10","SD",};
            return Tingped[(int)nama_];
        }
        public static string GetHarga(string name)
        {
            Nama_tutor nama_ = (Nama_tutor)Enum.Parse(typeof(Nama_tutor), name);
            string[] Harga = {"43.000/jam", "32.000/jam", "35.900/jam", "38.500/jam", "35.700/jam",
                              "42.000/jam", "50.000/jam", "75.000/jam", "39.000/jam", "37.100/jam",
                              "42.300/jam", "37.000/jam", "35.200/jam", "35.600/jam", "55.000/jam",};
            return Harga[(int)nama_];
        }
        public static string GetKota(string name)
        {
            Nama_tutor nama_ = (Nama_tutor)Enum.Parse(typeof(Nama_tutor), name);
            string[] Kota = { "Bandung", "Jakarta", "Bogor", "Solo", "Jogja",
                              "Bandung", "Jakarta", "Bogor", "Solo", "Jogja",
                              "Bandung", "Jakarta", "Bogor", "Solo", "Jogja"};
            return Kota[(int)nama_];
        }
    }
}
