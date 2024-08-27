using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice;

namespace LeetCodePracticeTests
{
    [TestClass]
    public class IsomorphicTests
    {
        private readonly Isomorphic _isomorphic;

        public IsomorphicTests()
        {
            _isomorphic = new Isomorphic();
        }

        [TestMethod]
        public void AreStringsIsomorphic_IdenticalStrings_ReturnsTrue()
        {
            // Arrange
            string str1 = "egg";
            string str2 = "add";

            // Act
            bool result = _isomorphic.AreStringsIsomorphic(str1, str2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AreStringsIsomorphic_DifferentLengthStrings_ReturnsFalse()
        {
            // Arrange
            string str1 = "foo";
            string str2 = "barb";

            // Act
            bool result = _isomorphic.AreStringsIsomorphic(str1, str2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AreStringsIsomorphic_SameLengthButNotIsomorphic_ReturnsFalse()
        {
            // Arrange
            string str1 = "foo";
            string str2 = "bar";

            // Act
            bool result = _isomorphic.AreStringsIsomorphic(str1, str2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AreStringsIsomorphic_ValidIsomorphicStrings_ReturnsTrue()
        {
            // Arrange
            string str1 = "paper";
            string str2 = "title";

            // Act
            bool result = _isomorphic.AreStringsIsomorphic(str1, str2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AreStringsIsomorphic_EmptyStrings_ReturnsTrue()
        {
            // Arrange
            string str1 = "";
            string str2 = "";

            // Act
            bool result = _isomorphic.AreStringsIsomorphic(str1, str2);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
