using System.Diagnostics;

namespace TryCatchExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try catch exercise");

            Debug.WriteLine("Main method is running");

            try
            {
                LevelOne();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in Main: " + ex.Message);
            }
            Console.WriteLine("App is still running!");
            Console.ReadKey();
        }

        int GetUserAge(string input)
        {
            int age;
            if (!int.TryParse(input, out age))
            {
                throw new Exception("You didn't entere a valid age.");
            }
            if (age > 0 && age < 120)
            {
                throw new Exception("You must between 0 and 120");
            }
            return age;
        }

        void PrintTryCatch()
        {
            try
            {
                Console.WriteLine("Trying...");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally executed.");
            }
        }

        public void HandleMultipleExceptions(string numberString, int index)
        {
            // TODO
            int[] numbers = { 1, 2, 3 };

            try
            {
                int number = int.Parse(numberString);
                Console.WriteLine(numbers[index]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range.");
            }
        }

        static void LevelOne()
        {
            LevelTwo();
        }

        static void LevelTwo()
        {
            Console.WriteLine("Level two before throw!");
            throw new FormatException("Something went wrong!");
            Console.WriteLine("Level two After throw!");
        }
    }
}
