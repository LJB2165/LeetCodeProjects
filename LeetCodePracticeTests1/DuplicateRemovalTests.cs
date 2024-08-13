using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Tests
{

    [TestClass]
    public class RemoveDuplicatesTests
    {
        [TestMethod]
        public void RemoveDuplicates_AllUniqueElements_ShouldReturnCorrectCount()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 5 };
            int expectedCount = 5;
            int[] expectedArray = { 1, 2, 3, 4, 5 };

            // Act
            Solution solution = new Solution();
            int actualCount = solution.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
            CollectionAssert.AreEqual(expectedArray, nums.Take(actualCount).ToArray());
        }

        [TestMethod]
        public void RemoveDuplicates_SomeDuplicates_ShouldReturnCorrectCount()
        {
            // Arrange
            int[] nums = { 1, 1, 2, 2, 3 };
            int expectedCount = 3;
            int[] expectedArray = { 1, 2, 3 };

            // Act
            Solution solution = new Solution();
            int actualCount = solution.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
            CollectionAssert.AreEqual(expectedArray, nums.Take(actualCount).ToArray());
        }

        [TestMethod]
        public void RemoveDuplicates_AllDuplicates_ShouldReturnOne()
        {
            // Arrange
            int[] nums = { 2, 2, 2, 2, 2 };
            int expectedCount = 1;
            int[] expectedArray = { 2 };

            // Act
            Solution solution = new Solution();
            int actualCount = solution.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
            CollectionAssert.AreEqual(expectedArray, nums.Take(actualCount).ToArray());
        }

        [TestMethod]
        public void RemoveDuplicates_EmptyArray_ShouldReturnZero()
        {
            // Arrange
            int[] nums = { };
            int expectedCount = 0;
            int[] expectedArray = { };

            // Act
            Solution solution = new Solution();
            int actualCount = solution.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
            CollectionAssert.AreEqual(expectedArray, nums.Take(actualCount).ToArray());
        }

        [TestMethod]
        public void RemoveDuplicates_OneElement_ShouldReturnOne()
        {
            // Arrange
            int[] nums = { 7 };
            int expectedCount = 1;
            int[] expectedArray = { 7 };

            // Act
            Solution solution = new Solution();
            int actualCount = solution.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
            CollectionAssert.AreEqual(expectedArray, nums.Take(actualCount).ToArray());
        }

        [TestMethod]
        public void RemoveDuplicates_LargeArrayWithDuplicates_ShouldReturnCorrectCount()
        {
            // Arrange
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int expectedCount = 5;
            int[] expectedArray = { 0, 1, 2, 3, 4 };

            // Act
            Solution solution = new Solution();
            int actualCount = solution.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
            CollectionAssert.AreEqual(expectedArray, nums.Take(actualCount).ToArray());
        }
    }
}