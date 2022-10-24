namespace SumExampleApp
{
    /// <summary>
    /// This class represents the algorithm for sum of all numbers
    /// </summary>
    public class SumOfAllAlgo : IAlgorithm
    {
        /// <summary>
        /// Logger object for logging purpose
        /// </summary>
        ILog _logger;

        public SumOfAllAlgo(ILog logger)
        {
            _logger = logger;
        }

        /// <inheritdoc/>
        public int RunAlgo(string[] inputData)
        {
            int sum = 0;

            // sum of numbers in the array
            foreach (var item in inputData)
            {
                // check if item is a number
                if (int.TryParse(item, out int result))
                {
                    sum += result;
                }
                else
                {
                    _logger.Log("'" + item + "' is not a number");
                }
            }

            return sum;
        }
    }
}
