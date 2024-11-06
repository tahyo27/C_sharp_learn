namespace TestApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 1, 2, 2, 2, 8 };
            int a = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(a);
                Console.WriteLine(array[i]);
            }
        }
    }
}
