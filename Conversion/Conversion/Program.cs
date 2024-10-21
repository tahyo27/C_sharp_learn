namespace Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversion");

            Console.WriteLine("Implicit Conversion");

            //묵시적
            int number = 1000000000;
            double number2 = number;
            long number3 = number;

            Console.WriteLine($"{number2} , {number3}");

            //명시적
            Console.WriteLine("Explicit Conversion");

            long exNumber = 10000;
            int number4 = (int)exNumber;

            double exNumber2 = 10.222;
            float exNumber3 = (float)exNumber2;

            Console.WriteLine($"{number4} , {exNumber3}");

            //Conversion Helpers Parse and Convert

            string numberString = "123";
            int result = int.Parse(numberString);

            string myBoolString = "true";
            bool myBool = Convert.ToBoolean(myBoolString);

            Console.WriteLine($"myBool is {myBool}");


            Console.ReadKey();

        }
    }
}
