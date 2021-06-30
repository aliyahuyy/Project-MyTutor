using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tes
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa(new DateTime(2020, 12, 27), "Aqila");
            Mahasiswa mhs2 = new Mahasiswa(new DateTime(2020, 12, 28), "Falia");

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            String jsonString = JsonSerializer.Serialize(mhs1, options);
            File.WriteAllText("D:/Aqila/Konstruksi/Project-MyTutor/Tes/Tes.json", jsonString);

        }
    }   
}
