using System;

namespace SumExampleApp
{
    /// <summary>
    /// This class implements the core functions of the application
    /// </summary>
    public class Core : ICore
    {
        IInput _input;
        IOuput _output;
        IAlgorithm _algorithm;
        ILog _logger;

        public Core(IInput input, IOuput output, IAlgorithm algorithm, ILog logger)
        {
            _input = input;
            _output = output;
            _algorithm = algorithm;
            _logger = logger;
        }

        /// <inheritdoc/>
        public void GetResult()
        {
            try
            {
                _output.SendData(_algorithm.RunAlgo(_input.GetData()));
            }
            catch (Exception ex)
            {
                _logger.Log("Exception has occured." + "\n" + ex.Message);
            }
        }
    }
}
