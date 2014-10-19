using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using Algo.Utils;
using Algo.Tri.Bulle;

namespace AlgoTest.Tri.Bulle
{
    [TestClass]
    public class TriBulleTest
    {
        [TestMethod]
        public void TrierTest()
        {
            List<int> ListeTest = Utils.GenerateNumbers(10);
            ListeTest = TriBulle.Trier(ListeTest);
            Assert.IsTrue(Utils.IsSorted(ListeTest));
        }
    }
}
