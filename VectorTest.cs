using Vectors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VectorTests
{
    [TestClass]
    public class VectorTest
    {
        [TestMethod]
        public void Equals_EqualsTwoSameVectors_ReturnsBool()
        {
            Vector vector1 = new Vector(25, 32, 15);
            Vector vector2 = new Vector(25, 32, 15);

            bool expected = true;
            bool actual = vector1.Equals(vector2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddTwoVectors_ReturnsCorrectResult()
        {
            Vector vector1 = new Vector(1, 2, 3);
            Vector vector2 = new Vector(4, 5, 6);
            
            Vector expected = new Vector(5, 7, 9);
            Vector actual = vector1 + vector2;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_MnoshTwoVectors_ReturnsCorrectResult()
        {
            Vector vector1 = new Vector(1, 2, 3);
            Vector vector2 = new Vector(4, 5, 6);

            double expected = 32;
            double actual = vector1 * vector2;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Length_CalculateLengthOfVector_ReturnsCorrectValue()
        {
            Vector vector = new Vector(3, 4, 0);
            
            double expected = 5;
            double actual = vector.Length();

            Assert.AreEqual(expected, actual);
        }
    }
}
