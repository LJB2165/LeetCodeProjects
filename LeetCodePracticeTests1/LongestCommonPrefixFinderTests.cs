using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefixTests
{
    [TestClass]
    public class LongestCommonPrefixFinderTests
    {
        [TestMethod]
        public void TestLongestCommonPrefix_BasicCase()
        {
            // Arrange
            LongestCommonPrefixFinder finder = new LongestCommonPrefixFinder();
            string[] strs = { "flower", "flow", "flight" };

            // Act
            string result = finder.LongestCommonPrefix(strs);

            // Assert
            Assert.AreEqual("fl", result); // The common prefix is "fl"
        }

        [TestMethod]
        public void TestLongestCommonPrefix_NoCommonPrefix()
        {
            // Arrange
            LongestCommonPrefixFinder finder = new LongestCommonPrefixFinder();
            string[] strs = { "dog", "racecar", "car" };

            // Act
            string result = finder.LongestCommonPrefix(strs);

            // Assert
            Assert.AreEqual("", result); // No common prefix, so return an empty string
        }

        [TestMethod]
        public void TestLongestCommonPrefix_SingleString()
        {
            // Arrange
            LongestCommonPrefixFinder finder = new LongestCommonPrefixFinder();
            string[] strs = { "single" };

            // Act
            string result = finder.LongestCommonPrefix(strs);

            // Assert
            Assert.AreEqual("single", result); // Only one string, so return it as the prefix
        }

        [TestMethod]
        public void TestLongestCommonPrefix_AllStringsSame()
        {
            // Arrange
            LongestCommonPrefixFinder finder = new LongestCommonPrefixFinder();
            string[] strs = { "test", "test", "test" };

            // Act
            string result = finder.LongestCommonPrefix(strs);

            // Assert
            Assert.AreEqual("test", result); // All strings are the same, so the entire string is the prefix
        }

        [TestMethod]
        public void TestLongestCommonPrefix_EmptyArray()
        {
            // Arrange
            LongestCommonPrefixFinder finder = new LongestCommonPrefixFinder();
            string[] strs = { };

            // Act
            string result = finder.LongestCommonPrefix(strs);

            // Assert
            Assert.AreEqual("", result); // The array is empty, so return an empty string
        }

        [TestMethod]
        public void TestLongestCommonPrefix_MixedLengthStrings()
        {
            // Arrange
            LongestCommonPrefixFinder finder = new LongestCommonPrefixFinder();
            string[] strs = { "interview", "internet", "interval" };

            // Act
            string result = finder.LongestCommonPrefix(strs);

            // Assert
            Assert.AreEqual("inte", result); // The common prefix is "inte"
        }

        [TestMethod]
        public void TestLongestCommonPrefix_NoMatchingPrefix()
        {
            // Arrange
            LongestCommonPrefixFinder finder = new LongestCommonPrefixFinder();
            string[] strs = { "abc", "def", "ghi" };

            // Act
            string result = finder.LongestCommonPrefix(strs);

            // Assert
            Assert.AreEqual("", result); // No common prefix, so return an empty string
        }
    }
}