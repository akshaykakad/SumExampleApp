namespace SumExampleApp
{
    /// <summary>
    /// IAlgorithm is an interface which contains the methods related to sum algorithm
    /// </summary>
    public interface IAlgorithm
    {
        /// <summary>
        /// This method is for main logic of algorithm
        /// </summary>
        /// <param name="inputData">Input data as array of string</param>
        /// <returns>Returns the result of algorithm</returns>
        int RunAlgo(string[] inputData);
    }
}
