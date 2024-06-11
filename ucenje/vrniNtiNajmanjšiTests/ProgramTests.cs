using Microsoft.VisualStudio.TestTools.UnitTesting;
using vrniNtiNajmanjši;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vrniNtiNajmanjši.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void VrniNtiNajmanjsiTest()
        {
            string[] blebet = { "bla", "blo", "bli" };
            string niz1 = Program.VrniNtiNajmanjsi(blebet, 2);
            Assert.AreEqual(niz1, "bli");

        }
    }
}