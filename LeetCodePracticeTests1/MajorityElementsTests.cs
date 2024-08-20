using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice;

namespace LeetCodePracticeTests
{
    [TestClass]
    public class MajorityElementsTests
    {
        private readonly MajorityElements _majorityElements;

        public MajorityElementsTests()
        {
            _majorityElements = new MajorityElements();
        }

        [TestMethod]
        public void MajorityElement_SimpleCase_ReturnsCorrectElement()
        {
            // Arrange
            int[] nums = { 3, 2, 3 };

            // Act
            int result = _majorityElements.MajorityElement(nums);

            // Assert
            Assert.AreEqual(3, result); // 3 is the majority element
        }

        [TestMethod]
        public void MajorityElement_AllSameElements_ReturnsThatElement()
        {
            // Arrange
            int[] nums = { 2, 2, 2, 2, 2 };

            // Act
            int result = _majorityElements.MajorityElement(nums);

            // Assert
            Assert.AreEqual(2, result); // 2 is the majority element
        }

        [TestMethod]
        public void MajorityElement_NoClearMajority_ReturnsMajority()
        {
            // Arrange
            int[] nums = { 1, 1, 2, 2, 1, 2, 1 };

            // Act
            int result = _majorityElements.MajorityElement(nums);

            // Assert
            Assert.AreEqual(1, result); // 1 is the majority element
        }

        [TestMethod]
        public void MajorityElement_SingleElementArray_ReturnsThatElement()
        {
            // Arrange
            int[] nums = { 5 };

            // Act
            int result = _majorityElements.MajorityElement(nums);

            // Assert
            Assert.AreEqual(5, result); // 5 is the only element, hence the majority
        }

        [TestMethod]
        public void MajorityElement_TwoElementArray_ReturnsAny()
        {
            // Arrange
            int[] nums = { 1, 2 };

            // Act
            int result = _majorityElements.MajorityElement(nums);

            // Assert
            // Since the problem guarantees that a majority element exists, and if there's a mistake and we have a tie, we'll just check if result is one of the elements
            Assert.IsTrue(result == 1 || result == 2);
        }
    }
}
