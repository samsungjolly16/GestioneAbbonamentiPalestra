using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaAbbonamentiPalestra;

namespace GestionePianiPalestra
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test12mesi()
        {
            double tariffa3 = 79.99;
            int mesi = 12;
            string valoreAspettato= $"tariffa3 {tariffa3 * 12}";
            string valoreRitorno = Gestioneabbonamenti.Scelta(mesi);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }

        [TestMethod]
        public void test13mesi()
        {
            int mesi = 13;
            string valoreAspettato = $"inserire numero mesi valido";
            string valoreRitorno = Gestioneabbonamenti.Scelta(mesi);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
        [TestMethod]
        public void test2mesi()
        {
            double tariffa1 = 115.99;          
            int mesi = 2;
            string valoreAspettato = $"2tariffa1 {tariffa1*2}";
            string valoreRitorno = Gestioneabbonamenti.Scelta(mesi);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
    }
}
