using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GaussNumbersLibrary;

namespace GaussNumbersTests
{
    [TestClass]
    public class GaussNumberTests
    {
        [TestMethod]
        public void Constructor_ValidValues_CreatesGaussNumber()
        {
            var g = new GaussNumber(3, 4);
            Assert.AreEqual(3, g.Re);
            Assert.AreEqual(4, g.Im);
            Assert.AreEqual(25, g.Norm, 1e-13);
        }

        [TestMethod]
        public void ToString_ReturnsCorrectString()
        {
            var g1 = new GaussNumber(3, 4);
            var g2 = new GaussNumber(0, 5);
            var g3 = new GaussNumber(0, 0);

            Assert.AreEqual("3+4i", g1.ToString());
            Assert.AreEqual("5i", g2.ToString());
            Assert.AreEqual("0", g3.ToString());
        }

        [TestMethod]
        public void Equals_SameValues_ReturnsTrue()
        {
            var g1 = new GaussNumber(3, 4);
            var g2 = new GaussNumber(3, 4);

            Assert.IsTrue(g1.Equals(g2));
        }

        [TestMethod]
        public void Equals_DifferentValues_ReturnsFalse()
        {
            var g1 = new GaussNumber(3, 4);
            var g2 = new GaussNumber(3, 5);

            Assert.IsFalse(g1.Equals(g2));
        }

        [TestMethod]
        public void GetHashCode_SameValues_ReturnsSameHashCode()
        {
            var g1 = new GaussNumber(3, 4);
            var g2 = new GaussNumber(3, 4);

            Assert.AreEqual(g1.GetHashCode(), g2.GetHashCode());
        }

        [TestMethod]
        public void OperatorPlus_AddsCorrectly()
        {
            var g1 = new GaussNumber(3, 4);
            var g2 = new GaussNumber(1, 2);

            var result = g1 + g2;

            Assert.AreEqual(4, result.Re);
            Assert.AreEqual(6, result.Im);
        }

        [TestMethod]
        public void OperatorConjugate_TakesConjugate()
        {
            var g = new GaussNumber(3, 4);

            var result = ~g;

            Assert.AreEqual(3, result.Re);
            Assert.AreEqual(-4, result.Im);
        }

        [TestMethod]
        public void OperatorMultiply_MultipliesCorrectly()
        {
            var g1 = new GaussNumber(3, 4);
            var g2 = new GaussNumber(1, 2);

            var result = g1 * g2;

            Assert.AreEqual(-5, result.Re);
            Assert.AreEqual(10, result.Im);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_InvalidValues_ThrowsException()
        {
            var _ = new GaussNumber(double.NaN, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_InvalidValues_ThrowsException_Im()
        {
            var _ = new GaussNumber(3, double.NaN);
        }
    }
}
