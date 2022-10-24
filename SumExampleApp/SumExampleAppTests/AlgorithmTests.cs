using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumExampleApp;
using Moq;

namespace SumExampleAppTests
{
    [TestClass]
    public class AlgorithmTests
    {
        Mock<ILog> _log = new Mock<ILog>();
        IAlgorithm algorithm;

        [TestInitialize]
        public void Setup()
        {
            algorithm = new SumOfAllAlgo(_log.Object);
        }

        [TestMethod]
        public void SumOfAll_OnlyNumber_ReturnsSum()
        {
            // Arrange
            string[] input = { "5", "10", "15" };

            // Act
            var output = algorithm.RunAlgo(input);

            // Assert
            Assert.AreEqual(30, output);
        }

        [TestMethod]
        public void SumOfAll_OnlyCharacters_ReturnsZero()
        {
            // Arrange
            string[] input = { "A", "B", "C" };

            // Act
            var output = algorithm.RunAlgo(input);

            // Assert
            Assert.AreEqual(0, output);
        }

        [TestMethod]
        public void SumOfAll_CharactersAndNumbers_ReturnsSumOfNumbers()
        {
            // Arrange
            string[] input = { "5", "B", "10" };

            // Act
            var output = algorithm.RunAlgo(input);

            // Assert
            Assert.AreEqual(15, output);
        }

        [TestMethod]
        public void SumOfAll_NoData_ReturnsZero()
        {
            // Arrange
            string[] input = { };

            // Act
            var output = algorithm.RunAlgo(input);

            // Assert
            Assert.AreEqual(0, output);
        }
    }
}
