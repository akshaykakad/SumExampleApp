namespace SumExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //set logs
            ILog logger = new ConsoleLog();

            // set input
            IInput input = new InputTxtFile(@"C:\Study\ConsoleApps\SumExampleApp\SumExampleApp\Files\Numbers.txt", ',', logger);

            //set output
            IOuput output = new OutputConsole(logger);

            //set algo
            IAlgorithm algorithm = new SumOfAllAlgo(logger);
            //IAlgorithm algorithm = new SumOfEvenAlgo(logger);

            // create instance of core functionality
            ICore core = new Core(input, output, algorithm, logger);

            // access core functionalities
            core.GetResult();
        }
    }
}
