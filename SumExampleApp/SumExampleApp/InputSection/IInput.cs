namespace SumExampleApp
{
    /// <summary>
    /// This interface represents data input functions
    /// </summary>
    public interface IInput
    {
        /// <summary>
        /// Get data from the source
        /// </summary>
        /// <returns>Returns the data in the form of array of string</returns>
        string[] GetData();
    }
}
