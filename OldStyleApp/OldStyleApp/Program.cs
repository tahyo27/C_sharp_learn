namespace OldStyleApp
{
    internal class Program
    {
        //Field(or instance variable) - sometimes even called global variable   
        static int myResult;

        static void Main(string[] args)
        {
            Console.WriteLine("Old Style App");



            myResult = AddTwoValues(5, 10);
            Console.WriteLine($"The result is {myResult}");
            Console.ReadKey();

        }

        static int AddTwoValues(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static int SubtractTwoValues(int a, int b) {
            int result = a - b;
            return result;
        }
    }
}
