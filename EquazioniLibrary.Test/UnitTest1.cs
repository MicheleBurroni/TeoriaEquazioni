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
        public void EquazioneDiSecondoGrado()
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
            double valoreAspettato = 300;
            double valoreRitorno = Equazioni.Delta(b, a, c);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
        [TestMethod]
        public void SoluzioniEquazioneDiSecondoGrado()
        {
            double a = 1, b = 5, c = 6;
            string valoreAspettato = $"{2}, {-8}";
            string valoreRitorno = Equazioni.Soluzioni(a, b, c);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
        [TestMethod]
        public void Eq1GradoIndeterminata()
        {
            double a = 0, b = 0;
            string valoreAspettato = "Indeterminato";
            string valoreRitorno = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
        [TestMethod]
        public void Eq1GradoImpossibile()
        {
            double a = 0, b = 11;
            string valoreAspettato = $"Impossibile";
            string valoreRitorno = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
        [TestMethod]
        public void Eq1GradoSoluzione()
        {
            double a = 4, b = 28;
            string valoreAspettato = $"{7}";
            string valoreRitorno = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(valoreAspettato, valoreRitorno);
        }
    }
}
