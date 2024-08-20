using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice;

namespace LeetCodePracticeTests
{
    [TestClass]
    public class MagazineRansomNoteTests
    {
        private readonly MagazineRansomNote _magazineRansomNote;

        public MagazineRansomNoteTests()
        {
            _magazineRansomNote = new MagazineRansomNote();
        }

        [TestMethod]
        public void CanConstruct_ValidConstruction_ReturnsTrue()
        {
            // Arrange
            string ransomNote = "a";
            string magazine = "aab";

            // Act
            bool result = _magazineRansomNote.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.IsTrue(result); // "a" can be constructed from "aab"
        }

        [TestMethod]
        public void CanConstruct_MultipleLetters_ReturnsTrue()
        {
            // Arrange
            string ransomNote = "aa";
            string magazine = "aab";

            // Act
            bool result = _magazineRansomNote.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.IsTrue(result); // "aa" can be constructed from "aab"
        }

        [TestMethod]
        public void CanConstruct_NotEnoughLetters_ReturnsFalse()
        {
            // Arrange
            string ransomNote = "aa";
            string magazine = "ab";

            // Act
            bool result = _magazineRansomNote.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.IsFalse(result); // "aa" cannot be constructed from "ab"
        }

        [TestMethod]
        public void CanConstruct_EmptyRansomNote_ReturnsTrue()
        {
            // Arrange
            string ransomNote = "";
            string magazine = "anything";

            // Act
            bool result = _magazineRansomNote.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.IsTrue(result); // An empty ransom note can always be constructed
        }

        [TestMethod]
        public void CanConstruct_EmptyMagazine_ReturnsFalse()
        {
            // Arrange
            string ransomNote = "a";
            string magazine = "";

            // Act
            bool result = _magazineRansomNote.CanConstruct(ransomNote, magazine);

            // Assert
            Assert.IsFalse(result); // "a" cannot be constructed from an empty magazine
        }
    }
}
