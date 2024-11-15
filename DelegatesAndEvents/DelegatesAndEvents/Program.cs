namespace DelegatesAndEvents
{

    public delegate void LogHandler(string message);
    internal class Program
    {
        

        public class Logger
        {
            public void LogToConsoe(string message)
            {
                Console.WriteLine($"Console Log : {message}");
            }

            public void LogToFile(string message)
            {
                Console.WriteLine("File Log: " + message);
            }
        }

        public delegate void Notify(string message);
        static void Main(string[] args)
        {
            Notify notifyDelgate = ShowMessage;

            notifyDelgate("Hello Delegates!");

            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsoe;
            logHandler("Logging to console");

            logHandler = logger.LogToFile;
            logHandler("Logging to File");




            Console.ReadKey();
        }
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
    
}
