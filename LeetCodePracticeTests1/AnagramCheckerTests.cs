using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnagramCheckerTests
{
    [TestClass]
    public class AnagramCheckerTests
    {
        private AnagramChecker _anagramChecker;

        [TestInitialize]
        public void Setup()
        {
            _anagramChecker = new AnagramChecker();
        }

        [TestMethod]
        public void IsAnagram_ValidAnagram_ReturnsTrue()
        {
            // Arrange
            string s = "listen";
            string t = "silent";

            // Act
            bool result = _anagramChecker.IsAnagram(s, t);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsAnagram_InvalidAnagram_ReturnsFalse()
        {
            // Arrange
            string s = "hello";
            string t = "world";

            // Act
            bool result = _anagramChecker.IsAnagram(s, t);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsAnagram_DifferentLengths_ReturnsFalse()
        {
            // Arrange
            string s = "abc";
            string t = "abcd";

            // Act
            bool result = _anagramChecker.IsAnagram(s, t);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsAnagram_EmptyStrings_ReturnsTrue()
        {
            // Arrange
            string s = "";
            string t = "";

            // Act
            bool result = _anagramChecker.IsAnagram(s, t);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsAnagram_SameCharactersDifferentCounts_ReturnsFalse()
        {
            // Arrange
            string s = "aabb";
            string t = "ab";

            // Act
            bool result = _anagramChecker.IsAnagram(s, t);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
