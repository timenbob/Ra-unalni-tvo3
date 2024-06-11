using Microsoft.VisualStudio.TestTools.UnitTesting;
using StevkeSoDelitelhji;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StevkeSoDelitelhji.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void stevkeTest1()
        {
            int a = 10;
            int b = 20;
            int k = 666;
            string odg = Program.stevke(a, b, k);
            Assert.AreEqual(odg, "Cela števila iz intervala[10, 20], v katerih vsaka neničelna štev - ka deli 666, so: 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20.");
        }

        [TestMethod()]
        public void stevkeTest2()
        {
            int a = 20;
            int b = 40;
            int k = 5;
            string odg = Program.stevke(a, b, k);
            Assert.AreEqual(odg, "V intervalu [20, 40] ni celih števil, v katerih vsaka neničelna števka deli 5.");
        }
    }
}