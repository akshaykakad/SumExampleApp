namespace SumExampleApp
{
    /// <summary>
    /// This interface represents data output functions
    /// </summary>
    public interface IOuput
    {
        /// <summary>
        /// Send data to the destination
        /// </summary>
        /// <param name="result">Output result to be sent</param>
        void SendData(int result);
    }
}
