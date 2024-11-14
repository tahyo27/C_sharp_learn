namespace DelegatesAndEvents
{
    internal class Program
    {

        public delegate void Notify(string message);
        static void Main(string[] args)
        {
            Notify notifyDelgate = ShowMessage;

            notifyDelgate("Hello Delegates!");

            Console.ReadKey();
        }
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
    
}
