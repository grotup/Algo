using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using Algo.Utils;
using Algo.Tri.Selection;

namespace AlgoTest.Tri.Selection
{
    [TestClass]
    public class TriSelectionTest
    {
        [TestMethod]
        public void TrierTestSelection()
        {
            List<int> ListeTest = Utils.GenerateNumbers(10);
            ListeTest = TriSelection.Trier(ListeTest);
            Assert.IsTrue(Utils.IsSorted(ListeTest));
        }
    }
}
