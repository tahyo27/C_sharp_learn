namespace ListsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lists App");

            //Declaring a list and initializing
            List<string> colors = new List<string>();

            //Adding item to the list
            colors.Add("red");
            colors.Add("blue");
            colors.Add("green");
            Console.WriteLine("Current colors in the colors list!");
            foreach (string color in colors)
            {

                Console.WriteLine(color);
            }
            bool isDeletingSuccessful = colors.Remove("Red");
            

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            Console.ReadKey();

        }
    }
}
