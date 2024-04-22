using Microsoft.VisualStudio.TestTools.UnitTesting;
using Majica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majica.Tests
{
    [TestClass()]
    public class MajicaTests
    {
        [TestMethod()]
        public void MajicaTes1()
        {
            int velikost = 5;
            string barva = "modra";
            Boolean rokavi=true;
            string niz = "dolgi";
            Majica prva = new Majica(velikost, barva, rokavi);
            Assert.AreEqual(prva.Rokavi, niz);
        }
        [TestMethod()]
        public void MajicaTest2()
        {
            int velikost = 5;
            string barva = "modra";
            Boolean rokavi = true;
            string niz = "dolgi";
            Majica prva = new Majica(velikost, barva, rokavi);
            Assert.AreEqual(prva.Barva, barva);
        }
        [TestMethod()]
        public void MajicaTest3()
        {
            int velikost = 5;
            string barva = "modra";
            Boolean rokavi = true;
            string niz = "dolgi";
            Majica prva = new Majica(velikost, barva, rokavi);
            prva.Velikost = 3;
            Assert.AreEqual(prva.Velikost, 3);
        }

        [TestMethod()]
        public void MajicaTest4()
        {
            int velikost = 6;
            string barva = "modra";
            Boolean rokavi = true;
            string niz = "dolgi";

            Assert.ThrowsException<Exception>(() =>
            {
                Majica prva = new Majica(velikost, barva, rokavi);
            });

          
        }
        [TestMethod()]
        public void MajicaTest5()
        {
            int velikost = 5;
            string barva = "modra";
            Boolean rokavi = true;
            string niz = "dolgi";
            Majica prva = new Majica(velikost, barva, rokavi);
            Assert.ThrowsException<Exception>(() =>
            {
                prva.Rokavi = "false";
            });


        }
    }
}