using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice;

namespace LeetCodePracticeTests
{
    [TestClass]
    public class PalindromeTests
    {
        private readonly Palindrome _palindrome;

        public PalindromeTests()
        {
            _palindrome = new Palindrome();
        }

        [TestMethod]
        public void IsPalindrome_SimplePalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "A man a plan a canal Panama";

            // Act
            bool result = _palindrome.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result); // This is a well-known palindrome
        }

        [TestMethod]
        public void IsPalindrome_SimpleNonPalindrome_ReturnsFalse()
        {
            // Arrange
            string input = "Hello, World!";

            // Act
            bool result = _palindrome.IsPalindrome(input);

            // Assert
            Assert.IsFalse(result); // This is clearly not a palindrome
        }

        [TestMethod]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            // Arrange
            string input = "";

            // Act
            bool result = _palindrome.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result); // An empty string is considered a palindrome
        }

        [TestMethod]
        public void IsPalindrome_OnlySpecialCharacters_ReturnsTrue()
        {
            // Arrange
            string input = "!!!###!!!";

            // Act
            bool result = _palindrome.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result); // Special characters should be ignored, effectively making this a palindrome
        }

        [TestMethod]
        public void IsPalindrome_PalindromeWithMixedCases_ReturnsTrue()
        {
            // Arrange
            string input = "No 'x' in Nixon";

            // Act
            bool result = _palindrome.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result); // This is a palindrome despite the mixed cases and spaces
        }

        [TestMethod]
        public void IsPalindrome_PalindromeWithDigits_ReturnsTrue()
        {
            // Arrange
            string input = "12321";

            // Act
            bool result = _palindrome.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result); // This is a numeric palindrome
        }

        [TestMethod]
        public void IsPalindrome_NonPalindromeWithDigits_ReturnsFalse()
        {
            // Arrange
            string input = "12345";

            // Act
            bool result = _palindrome.IsPalindrome(input);

            // Assert
            Assert.IsFalse(result); // This is not a palindrome
        }
    }
}
