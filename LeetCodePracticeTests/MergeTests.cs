using LeetCodePractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MergeArrayTests
{
    [TestClass]
    public class MergeTests
    {
        [TestMethod]
        public void Merge_BothArraysHaveElements_ShouldMergeCorrectly()
        {
            // Arrange
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;
            int[] expected = { 1, 2, 2, 3, 5, 6 };

            // Act
            var solution = new Solution();
            solution.Merge(nums1, m, nums2, n);

            // Assert
            CollectionAssert.AreEqual(expected, nums1);
        }

        [TestMethod]
        public void Merge_EmptyNums2_ShouldRemainUnchanged()
        {
            // Arrange
            int[] nums1 = { 1, 2, 3 };
            int m = 3;
            int[] nums2 = { };
            int n = 0;
            int[] expected = { 1, 2, 3 };

            // Act
            var solution = new Solution();
            solution.Merge(nums1, m, nums2, n);

            // Assert
            CollectionAssert.AreEqual(expected, nums1);
        }

        [TestMethod]
        public void Merge_EmptyNums1_ShouldCopyNums2()
        {
            // Arrange
            int[] nums1 = { 0, 0, 0 };
            int m = 0;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;
            int[] expected = { 2, 5, 6 };

            // Act
            var solution = new Solution();
            solution.Merge(nums1, m, nums2, n);

            // Assert
            CollectionAssert.AreEqual(expected, nums1);
        }

        [TestMethod]
        public void Merge_Nums1HasLargerElements_ShouldMergeCorrectly()
        {
            // Arrange
            int[] nums1 = { 4, 5, 6, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 1, 2, 3 };
            int n = 3;
            int[] expected = { 1, 2, 3, 4, 5, 6 };

            // Act
            var solution = new Solution();
            solution.Merge(nums1, m, nums2, n);

            // Assert
            CollectionAssert.AreEqual(expected, nums1);
        }

        [TestMethod]
        public void Merge_Nums2HasLargerElements_ShouldMergeCorrectly()
        {
            // Arrange
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 4, 5, 6 };
            int n = 3;
            int[] expected = { 1, 2, 3, 4, 5, 6 };

            // Act
            var solution = new Solution();
            solution.Merge(nums1, m, nums2, n);

            // Assert
            CollectionAssert.AreEqual(expected, nums1);
        }
    }
}