using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tax;

namespace UTCalcTax
{
    [TestClass]
    public class UTTax
    {
        [TestMethod]
        public void TestCalcICMS()
        {
            double icms = new CalcTax().Calc("ICMS", 100);
            Assert.AreEqual(10, icms);
        }

        [TestMethod]
        public void TestCalcIPI()
        {
            double ipi = new CalcTax().Calc("IPI", 100);
            Assert.AreEqual(20, ipi);
        }

        [TestMethod]
        public void TestCalcNewTax()
        {
            double newTax = new CalcTax().Calc("NEW_TAX", 100);
            Assert.AreEqual(50, newTax);
        }
    }
}
