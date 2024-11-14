namespace FileManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger("Program");

            logger = new FileLogger("Program");

            logger.Log("I did a thing.");

            logger.Error("Something went wrong.");
        }
    }
}
