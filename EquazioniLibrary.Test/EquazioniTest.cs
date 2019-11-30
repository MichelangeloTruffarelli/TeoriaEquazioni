using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class EquazioniTest
    {
        [TestMethod]
        public void IsDeterminated()
        {
            double a = 5;
            double b = 6;
            bool Risposta = Equazioni.IsDeterminated(a, b);
            Assert.AreEqual(true, Risposta);
        }
        [TestMethod]
        public void IsInconsisted()
        {
            double a = 0;
            double b = 3;
            bool Risposta = EquazioniLibrary.IsInconsisted(a, b);
            Assert.AreEqual
        }
    }
}
