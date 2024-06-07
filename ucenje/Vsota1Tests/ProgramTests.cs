using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsota1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsota1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SestejTest()
        {
            int[] integerArray = new int[] { 1, 2, 3, 4, 5 };


            // Act
            int result1 = Program.SestejGen(integerArray);


            // Assert
            Assert.AreEqual(15, result1);
        }
    

   
        [TestMethod]
        public void SestejGenTest()
        {
            // Arrange
            int[] integerArray = new int[] { 1, 2, 3, 4, 5 };
            

            // Act
            int result1 = Program.SestejGen(integerArray);
           

            // Assert
            Assert.AreEqual(15, result1);
            
        }
        [TestMethod]
        public void SestejGenTest2()
        {
            // Arrange
            
            double[] doubleArray = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };
           

           
            double result2 = Program.SestejGen(doubleArray);
            
            Assert.AreEqual(16.5, result2);
           
        }
        [TestMethod]
        public void SestejGenTest3()
        {
            // Arrange
            string[] integerArray = new string[] {  "Hello", " ", "World", "!" };
          

            // Act
            string result1 = Program.SestejGen(integerArray);
            

            // Assert
            Assert.AreEqual("Hello World!", result1);
            
        }
    }
}