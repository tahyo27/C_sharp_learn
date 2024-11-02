namespace ListsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lists App");

            //Declaring a list and initializing
            List<string> colors = new List<string> { "red", "green", "blue", "black" }; // 이런식으로 미리 알때 초기화 가능

            List<int> numbers = new List<int> { 1, 3, 32, 2, 4, 99, 0, -2 };
            //Adding item to the list
            //colors.Add("red");
            //colors.Add("blue");
            //colors.Add("green");

            numbers.Sort(); // 정렬
            List<int> findNumbers = numbers.FindAll(x => x >= 3); //x가 3이상인것 모두 찾음 반환 리스트로

            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

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
