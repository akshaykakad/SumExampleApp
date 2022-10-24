using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumExampleApp;
using Moq;
using System;
using System.IO;

namespace SumExampleAppTests
{
    [TestClass]
    public class InputTxtFileTests
    {
        Mock<ILog> _log = new Mock<ILog>();
        IInput input;

        [TestMethod]
        public void FilePresent_WithData_ReturnsArrayOfString()
        {
            //Arrange
            input = new InputTxtFile(@"C:\Study\ConsoleApps\SumExampleApp\SumExampleAppTests\Numbers.txt", ',', _log.Object);
            var expected = new string[4] { "1", "2", "3", "A" };

            //Act
            var output = input.GetData();

            //Assert
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], output[i]);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Data not present.")]
        public void FilePresent_NoData_ReturnsException()
        {
            //Arrange
            input = new InputTxtFile(@"C:\Study\ConsoleApps\SumExampleApp\SumExampleAppTests\Numbers_NoData.txt", ',', _log.Object);
            
            //Act
            input.GetData();
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void FileNotPresent_ReturnsException()
        {
            //Arrange
            input = new InputTxtFile(@"C:\Study\ConsoleApps\SumExampleApp\SumExampleAppTests\Numbers1.txt", ',', _log.Object);

            //Act
            input.GetData();
        }
    }
}
