using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice;

namespace LeetCodePracticeTests
{
    [TestClass]
    public class LengthofLastWordTests
    {
        private readonly LengthofLastWord _lengthOfLastWord;

        public LengthofLastWordTests()
        {
            _lengthOfLastWord = new LengthofLastWord();
        }

        [TestMethod]
        public void LengthOfLastWord_SimpleString_ReturnsCorrectLength()
        {
            // Arrange
            string input = "Hello World";

            // Act
            int result = _lengthOfLastWord.LengthOfLastWord(input);

            // Assert
            Assert.AreEqual(5, result); // "World" has 5 letters
        }

        [TestMethod]
        public void LengthOfLastWord_StringWithTrailingSpaces_ReturnsCorrectLength()
        {
            // Arrange
            string input = "Hello World   ";

            // Act
            int result = _lengthOfLastWord.LengthOfLastWord(input);

            // Assert
            Assert.AreEqual(5, result); // "World" has 5 letters, spaces should be ignored
        }

        [TestMethod]
        public void LengthOfLastWord_SingleWord_ReturnsCorrectLength()
        {
            // Arrange
            string input = "Word";

            // Act
            int result = _lengthOfLastWord.LengthOfLastWord(input);

            // Assert
            Assert.AreEqual(4, result); // "Word" has 4 letters
        }

        [TestMethod]
        public void LengthOfLastWord_EmptyString_ReturnsZero()
        {
            // Arrange
            string input = "";

            // Act
            int result = _lengthOfLastWord.LengthOfLastWord(input);

            // Assert
            Assert.AreEqual(0, result); // No words, so length should be 0
        }

        [TestMethod]
        public void LengthOfLastWord_OnlySpaces_ReturnsZero()
        {
            // Arrange
            string input = "    ";

            // Act
            int result = _lengthOfLastWord.LengthOfLastWord(input);

            // Assert
            Assert.AreEqual(0, result); // No words, so length should be 0
        }
    }
}
