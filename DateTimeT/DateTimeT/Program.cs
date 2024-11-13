namespace DateTimeT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2018, 5, 31);

            Console.WriteLine("My ~~ is {0}", dateTime);

            // today
            Console.WriteLine(DateTime.Today);

            // current Time
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = GetTomorrow();
            Console.WriteLine($"내일 : {tomorrow}");
            Console.ReadKey();
        }
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
    }
     
}
