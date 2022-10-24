using System;

namespace SumExampleApp
{
    /// <summary>
    /// This class implements data output functions
    /// </summary>
    public class OutputConsole : IOuput
    {
        ILog _logger;

        public OutputConsole(ILog logger)
        {
            _logger = logger;
        }

        /// <inheritdoc/>
        public void SendData(int result)
        {
            Console.WriteLine("Sum of numbers: " + result);
            _logger.Log("Operation is completed successfully");
        }
    }
}
