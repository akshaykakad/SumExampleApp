using System;
using System.IO;

namespace SumExampleApp
{
    /// <summary>
    /// This class implement data input functions to get data from text file
    /// </summary>
    public class InputTxtFile : IInput
    {
        string _filePath;
        char _separator;
        ILog _logger;

        public InputTxtFile(string filePath, char separator, ILog logger)
        {
            _filePath = filePath;
            _separator = separator;
            _logger = logger;
        }

        /// <inheritdoc/>
        public string[] GetData()
        {
            if (File.Exists(_filePath))
            {
                string result = File.ReadAllText(_filePath);
                _logger.Log("File read operation is successful.");

                if (string.IsNullOrEmpty(result))
                {
                    throw new Exception("Data not present.");
                }

                return result.Split(_separator);
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}
