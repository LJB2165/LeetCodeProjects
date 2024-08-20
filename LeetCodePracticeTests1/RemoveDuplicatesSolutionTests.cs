using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice;

namespace LeetCodePracticeTests
{
    [TestClass]
    public class RemoveDuplicatesSolutionTests
    {
        private readonly RemoveDuplicatesSolution _solution;

        public RemoveDuplicatesSolutionTests()
        {
            _solution = new RemoveDuplicatesSolution();
        }

        [TestMethod]
        public void RemoveDuplicates_AllUniqueElements_ShouldReturnCorrectCount()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4, 5 };
            int expectedCount = 5;
            int[] expectedArray = { 1, 2, 3, 4, 5 };

            // Act
            int actualCount = _solution.RemoveDuplicates(nums);

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
            int actualCount = _solution.RemoveDuplicates(nums);

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
            int actualCount = _solution.RemoveDuplicates(nums);

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
            int actualCount = _solution.RemoveDuplicates(nums);

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
            int actualCount = _solution.RemoveDuplicates(nums);

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
            int actualCount = _solution.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
            CollectionAssert.AreEqual(expectedArray, nums.Take(actualCount).ToArray());
        }
    }
}
