using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromSt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromSt.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void PalindromaTest()
        {
            int a = 90;
            int b = 130;
            string odg = "Palindromska števila med 90 in 130 so 99, 101, 111, 121.";
            string odg1 = Program.Palindroma(a, b);

            Assert.AreEqual(odg, odg1);
        }

        [TestMethod()]
        public void PalindromaTest1()
        {
            int a = 12;
            int b = 21;
            string odg = "Med 12 in 21 ni palindromskih števil.";
            string odg1 = Program.Palindroma(a, b);

            Assert.AreEqual(odg, odg1);
        }
    }
}