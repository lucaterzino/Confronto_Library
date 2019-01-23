using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Confronto_Library;

namespace Confronto_Library_Tests
{
    [TestClass]
    public class Confronto_Tests
    {
        [TestMethod]
        public void TestMax()
        {
            int n1 = 0;
            int n2 = 7;
            int max_aspetto = 7;

            int max_calcolato = Confronto_Library.Confronto.Max(n1, n2);
            Assert.AreEqual(max_aspetto, max_calcolato);


        }

        [TestMethod]
        public void TestMax1()
        {
            int n1 = 3;
            int n2 = 12;
            int max_aspetto = 12;

            int max_calcolato = Confronto_Library.Confronto.Max(n1, n2);
            Assert.AreEqual(max_aspetto, max_calcolato);
        }
    }
}
