using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToIntegerConverterTests
{
    [TestClass]
    public class RomanToIntegerTests
    {
        [TestMethod]
        public void TestRomanToInt_BasicCases()
        {
            // Arrange
            RomanToIntegerConverter converter = new RomanToIntegerConverter();

            // Act & Assert
            Assert.AreEqual(3, converter.RomanToInt("III"));   // Simple addition case
            Assert.AreEqual(4, converter.RomanToInt("IV"));    // Subtraction case
            Assert.AreEqual(9, converter.RomanToInt("IX"));    // Subtraction case
            Assert.AreEqual(58, converter.RomanToInt("LVIII")); // Mixed addition and subtraction
            Assert.AreEqual(1994, converter.RomanToInt("MCMXCIV")); // Complex case with multiple subtractions
        }

        [TestMethod]
        public void TestRomanToInt_EmptyString()
        {
            // Arrange
            RomanToIntegerConverter converter = new RomanToIntegerConverter();

            // Act
            int result = converter.RomanToInt("");

            // Assert
            Assert.AreEqual(0, result); // An empty string should return 0
        }

        [TestMethod]
        public void TestRomanToInt_SingleCharacter()
        {
            // Arrange
            RomanToIntegerConverter converter = new RomanToIntegerConverter();

            // Act & Assert
            Assert.AreEqual(1, converter.RomanToInt("I"));
            Assert.AreEqual(5, converter.RomanToInt("V"));
            Assert.AreEqual(10, converter.RomanToInt("X"));
            Assert.AreEqual(50, converter.RomanToInt("L"));
            Assert.AreEqual(100, converter.RomanToInt("C"));
            Assert.AreEqual(500, converter.RomanToInt("D"));
            Assert.AreEqual(1000, converter.RomanToInt("M"));
        }

        [TestMethod]
        public void TestRomanToInt_MaximumValue()
        {
            // Arrange
            RomanToIntegerConverter converter = new RomanToIntegerConverter();

            // Act
            int result = converter.RomanToInt("MMMCMXCIX");

            // Assert
            Assert.AreEqual(3999, result); // The maximum possible value in Roman numerals
        }

        [TestMethod]
        public void TestRomanToInt_MinimumValue()
        {
            // Arrange
            RomanToIntegerConverter converter = new RomanToIntegerConverter();

            // Act
            int result = converter.RomanToInt("I");

            // Assert
            Assert.AreEqual(1, result); // The minimum possible value in Roman numerals
        }
    }
}