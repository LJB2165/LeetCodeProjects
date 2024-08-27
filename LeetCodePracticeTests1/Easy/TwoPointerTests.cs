using LeetCodePractice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TwoPointerTests
{
    [TestClass]
    public class TwoPointerTests
    {
        private TwoPointer _twoPointer;

        [TestInitialize]
        public void Setup()
        {
            _twoPointer = new TwoPointer();
        }

        [TestMethod]
        public void IsSubsequence_ValidSubsequence_ReturnsTrue()
        {
            // Arrange
            string s = "abc";
            string t = "ahbgdc";

            // Act
            bool result = _twoPointer.IsSubsequence(s, t);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsSubsequence_InvalidSubsequence_ReturnsFalse()
        {
            // Arrange
            string s = "axc";
            string t = "ahbgdc";

            // Act
            bool result = _twoPointer.IsSubsequence(s, t);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsSubsequence_EmptyS_ReturnsTrue()
        {
            // Arrange
            string s = "";
            string t = "ahbgdc";

            // Act
            bool result = _twoPointer.IsSubsequence(s, t);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsSubsequence_EmptyT_ReturnsFalse()
        {
            // Arrange
            string s = "abc";
            string t = "";

            // Act
            bool result = _twoPointer.IsSubsequence(s, t);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsSubsequence_SameStrings_ReturnsTrue()
        {
            // Arrange
            string s = "abc";
            string t = "abc";

            // Act
            bool result = _twoPointer.IsSubsequence(s, t);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsSubsequence_SingleCharacterS_ReturnsTrue()
        {
            // Arrange
            string s = "a";
            string t = "ahbgdc";

            // Act
            bool result = _twoPointer.IsSubsequence(s, t);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsSubsequence_SingleCharacterT_ReturnsFalse()
        {
            // Arrange
            string s = "a";
            string t = "b";

            // Act
            bool result = _twoPointer.IsSubsequence(s, t);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsSubsequence_SIsLongerThanT_ReturnsFalse()
        {
            // Arrange
            string s = "abcdefgh";
            string t = "abc";

            // Act
            bool result = _twoPointer.IsSubsequence(s, t);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
