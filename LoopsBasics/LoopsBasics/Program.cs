namespace LoopsBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops Basics");
            // in string \ ins an "Escape Character"
            // \n stands for "new line"
            // \r - carriage return 커서를 해당 줄의 처음으로 이동

            string rocket = "     |\r\n     |\r\n    / \\\r\n   / _ \\\r\n  |.o '.|\r\n  |'._.'|\r\n  |     |\r\n ,'|  | |`.\r\n/  |  | |  \\\r\n|,-'--|--'-.|";
            string myString = "Hi \r\nHi";

            for(int i = 10; i >= 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"Counter is {i}");
                Console.WriteLine(rocket);
                rocket = "\r\n" + rocket;
                //Thread.Sleep(1000);
            }

            //The While Loop
            int counter = 0;
            while(counter < 10)
            {
                Console.WriteLine($"While Counter is {counter}");
                counter++;
            }

            Console.WriteLine("Enter go or stay");
            string userChoice = Console.ReadLine();

            while(userChoice == "go")
            {
                Console.WriteLine("Go for a mile");
                Console.WriteLine("Wanna keep going? Enter go.");
                userChoice = Console.ReadLine();
            }
            Console.WriteLine("Finally you are staying!");


            Console.ReadKey();
        }

    }
}
