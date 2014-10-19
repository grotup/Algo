using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Algo.Utils;

namespace AlgoTest
{
    /// <summary>
    /// Méthode de test de la classe Utils
    /// </summary>
    [TestClass]
    public class UtilsTest
    {
        /// <summary>
        /// Vérifie si le nombre d'élements dans la liste renvoyée par la méthode de génération de liste est correct
        /// </summary>
        [TestMethod]
        public void GenerateTableTestNbItems()
        {
            int NbItems = 10;
            List<int> Liste = Utils.GenerateNumbers(NbItems);
            Assert.AreEqual(Liste.Count, NbItems);
        }

        /// <summary>
        /// Vérifie si la méthode de vérification de tri renvoie bien vrai si le tableau est trié
        /// </summary>
        [TestMethod]
        public void IsSortedListTestTrue()
        {
            List<int> Liste = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Liste.Add(i);
            }
            Assert.IsTrue(Utils.IsSorted(Liste));
        }

        /// <summary>
        /// Vérifie si la méthode de vérification de tri renvoie bien faux si le tableau n'est pas trié
        /// </summary>
        [TestMethod]
        public void IsSortedListTestFalse()
        {
            List<int> Liste = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                Liste.Add(i);
            }
            Liste.Add(0);
            Assert.IsFalse(Utils.IsSorted(Liste));
        }

        [TestMethod]
        public void IsSortedListeTestListeVide()
        {
            List<int> Liste = new List<int>();
            Assert.IsFalse(Utils.IsSorted(Liste));
        }

        [TestMethod]
        public void IsSortedListeTestListeNull()
        {
            List<int> Liste = null;
            Assert.IsFalse(Utils.IsSorted(Liste));
        }
    }
}
