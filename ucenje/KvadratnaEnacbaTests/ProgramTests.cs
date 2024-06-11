using Microsoft.VisualStudio.TestTools.UnitTesting;
using KvadratnaEnacba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratnaEnacba.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TestNičleKvEnačbe_PozitivniDiskriminant()
        {
            // Arrange
            int a = 1;
            int b = -3;
            int c = 2;
            double[] pričakovaniRezultat = new double[] { 2, 1 };

            // Act
            double[] rezultat = Program.ničleKvEnačbe(a, b, c);

            // Assert
            Assert.AreEqual(pričakovaniRezultat[0], rezultat[0], 0.0001);
            Assert.AreEqual(pričakovaniRezultat[1], rezultat[1], 0.0001);
        }

        [TestMethod]
        public void TestNičleKvEnačbe_NegativniDiskriminant()
        {
            // Arrange
            int a = 1;
            int b = 2;
            int c = 5;

            // Act & Assert
            ArgumentException ex = Assert.ThrowsException<ArgumentException>(() => Program.ničleKvEnačbe(a, b, c));
            Assert.AreEqual("kompleksne nicle", ex.Message);
        }

        
        

        
    }
}