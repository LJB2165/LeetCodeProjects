using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HappiestTests
{
    [TestClass]
    public class HappiestTests
    {
        private Happiest _happiest;

        [TestInitialize]
        public void Setup()
        {
            _happiest = new Happiest();
        }

        [TestMethod]
        public void IsHappy_Number19_ReturnsTrue()
        {
            // Arrange
            int n = 19;

            // Act
            bool result = _happiest.IsHappy(n);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsHappy_Number2_ReturnsFalse()
        {
            // Arrange
            int n = 2;

            // Act
            bool result = _happiest.IsHappy(n);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsHappy_Number1_ReturnsTrue()
        {
            // Arrange
            int n = 1;

            // Act
            bool result = _happiest.IsHappy(n);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsHappy_LargeHappyNumber_ReturnsTrue()
        {
            // Arrange
            int n = 10000; // This is a happy number because it reduces to 1

            // Act
            bool result = _happiest.IsHappy(n);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsHappy_LargeUnhappyNumber_ReturnsFalse()
        {
            // Arrange
            int n = 999; // This is not a happy number

            // Act
            bool result = _happiest.IsHappy(n);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
