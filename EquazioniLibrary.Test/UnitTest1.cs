using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioneLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EquazionePrimogradoDeterminata()
        {
            double a = 11;
            bool valoreAspettato = true;
            bool valoreRitorno = Equazioni.IsDeterminated(a);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
        [TestMethod]
        public void EquazioneDiPrimoGradoImpossibile()
        {
            double a = 8, b = 14;
            bool valoreAspettato = true;
            bool valoreRitorno = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
        [TestMethod]
        public void EquazioneDiSecondogrado()
        {
            double esponente = 2, a = 4;
            bool valoreAspettato = true;
            bool valoreRitorno = Equazioni.IsInconsisted(esponente, a);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
        [TestMethod]
        public void CalcoloDelta()
        {
            double b = 6, a = 12, c = 7;
            bool valoreAspettato = true;
            double valoreRitorno = Equazioni.Delta(b, a, c);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
    }
}
