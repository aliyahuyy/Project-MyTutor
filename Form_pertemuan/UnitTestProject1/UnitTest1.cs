using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
   
    [TestClass]
    public class UnitTest1
    {
        enum Durasi_pem
        {
            Satu, Dua, Tiga, Empat, Lima
        }
        [TestMethod]
        public void TestMethod1()
        {
            UnitTest1.Durasi_pem Durasi = UnitTest1.Durasi_pem.Lima;
            Assert.Equals(UnitTest1.Durasi_pem.Lima, Durasi);
        }
    }
}
