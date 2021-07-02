using Microsoft.VisualStudio.TestTools.UnitTesting;
using cari_Tutor;
namespace UnitTest_cari_Tutor
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_List()
        {
            // Mengecek apakah isi list bertipe string
            CollectionAssert.AllItemsAreInstancesOfType(Daftar_Tutor.Mapel_List_Public, typeof(string));
            CollectionAssert.AllItemsAreInstancesOfType(Daftar_Tutor.Tingped_List_Public, typeof(string));
            CollectionAssert.AllItemsAreInstancesOfType(Daftar_Tutor.Kota_List_Public, typeof(string));

            // Mengecek apakah isi antar list berbeda
            CollectionAssert.DoesNotContain(Daftar_Tutor.Mapel_List_Public, Daftar_Tutor.Tingped_List_Public);
            CollectionAssert.DoesNotContain(Daftar_Tutor.Kota_List_Public, Daftar_Tutor.Mapel_List_Public);
            CollectionAssert.DoesNotContain(Daftar_Tutor.Tingped_List_Public, Daftar_Tutor.Kota_List_Public);
        }

        [TestMethod]
        public void TestMethod_Enum()
        {
            // Mengecek apakah isi enum tidak null
            Assert.IsNotNull(Daftar_Tutor.Nama_tutor.Adam_Husaain);

            // Mengecek apakah isi dari nama tersebut sesuai dengan metodnya
            Assert.AreEqual(Daftar_Tutor.GetMapel("Kinanti_Dewi"), "Bahasa Jerman");
            Assert.AreEqual(Daftar_Tutor.GetTingPed("Tiffany_Scott"), "SMA KELAS 10");
            Assert.AreEqual(Daftar_Tutor.GetHarga("Cindy_Putri"), "35.700/jam");
            Assert.AreEqual(Daftar_Tutor.GetKota("Adam_Husaain"), "Bandung");
        }

    }
}
