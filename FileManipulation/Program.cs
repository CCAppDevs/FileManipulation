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

            Console.WriteLine("\n\n\nStarting to read");

            // lets read the log file
            string docPath = Path.Combine(Directory.GetCurrentDirectory(), "log.txt");

            string contents = File.ReadAllText(docPath);

            string[] contentArr = File.ReadAllLines(docPath);

            for (int i = 0; i < contentArr.Length; i++)
            {
                Console.WriteLine((i + 1) + contentArr[i]);
            }

            
        }
    }
}
