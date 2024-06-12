using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vektor3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Vektor3.Tests
{
    [TestClass]
    public class Vektor3KTests
    {
        [TestMethod]
        public void Constructor_DefaultValues_Test()
        {
            // Arrange & Act
            Vektor3K vektor = new Vektor3K();

            // Assert
            Assert.AreEqual(-1, vektor.X);
            Assert.AreEqual(-1, vektor.Y);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Constructor_InvalidStringFormat_ThrowsException_Test()
        {
            // Act
            Vektor3K vektor = new Vektor3K("invalid");

            // Assert: Expected exception
        }

        [TestMethod]
        public void Constructor_ValidStringFormat_Test()
        {
            // Arrange & Act
            Vektor3K vektor = new Vektor3K("-3 -4");

            // Assert
            Assert.AreEqual(-3, vektor.X);
            Assert.AreEqual(-4, vektor.Y);
        }

        [TestMethod]
        public void Property_X_SetNegativeValue_Test()
        {
            // Arrange
            Vektor3K vektor = new Vektor3K();

            // Act
            vektor.X = -5;

            // Assert
            Assert.AreEqual(-5, vektor.X);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Property_X_SetPositiveValue_ThrowsException_Test()
        {
            // Arrange
            Vektor3K vektor = new Vektor3K();

            // Act
            vektor.X = 5;

            // Assert: Expected exception
        }

        [TestMethod]
        public void Property_Y_SetNegativeValue_Test()
        {
            // Arrange
            Vektor3K vektor = new Vektor3K();

            // Act
            vektor.Y = -8;

            // Assert
            Assert.AreEqual(-8, vektor.Y);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Property_Y_SetPositiveValue_ThrowsException_Test()
        {
            // Arrange
            Vektor3K vektor = new Vektor3K();

            // Act
            vektor.Y = 2;

            // Assert: Expected exception
        }

        [TestMethod]
        public void Dolzina_Test()
        {
            // Arrange
            Vektor3K vektor = new Vektor3K("-3 -4");

            // Act
            double dolzina = vektor.Dolzina;

            // Assert
            Assert.AreEqual(5.0, dolzina, 0.0001);  // 5.0 je pričakovana dolžina za (-3, -4)
        }

        [TestMethod]
        public void ToString_Test()
        {
            // Arrange
            Vektor3K vektor = new Vektor3K("-3 -4");

            // Act
            string result = vektor.ToString();

            // Assert
            Assert.AreEqual("(-3,-4)", result);
        }

        [TestMethod]
        public void Operator_Multiplication_Test()
        {
            // Arrange
            Vektor3K vektor = new Vektor3K("-2 -3");

            // Act
            Vektor3K result = vektor * 2;

            // Assert
            Assert.AreEqual(-4, result.X);
            Assert.AreEqual(-6, result.Y);
        }

        [TestMethod]
        public void NajskrajsaRaz_Test()
        {
            // Arrange
            Vektor3K[] vektorji = new Vektor3K[]
            {
                new Vektor3K("-1 -2"),
                new Vektor3K("-3 -4"),
                new Vektor3K("-5 -6"),
                new Vektor3K("-0 -1")  // Najkrajša dolžina
            };

            // Act
            Vektor3K najkrajsi = Vektor3K.NajskrajsaRaz(vektorji);

            // Assert
            Assert.AreEqual(0, najkrajsi.X);
            Assert.AreEqual(-1, najkrajsi.Y);
        }
    }
}
