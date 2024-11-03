namespace ListsApp
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Lists App");

                List<Product> products = new List<Product> {
                    new Product { Name = "Apple", Price = 0.80 },
                    new Product { Name = "Banana", Price = 0.30 },
                    new Product { Name = "Cherry", Price = 3.80 },
                };
                products.Add(new Product { Name = "Berries", Price = 2.99 });

                // 
                List<Product> cheapProducts = products.Where(p => p.Price < 1.0).ToList();

                //Declaring a list and initializing
                List<string> colors = new List<string>();

                List<int> numbers = new List<int> { 1, 2, 3, 10, 20, 40 };

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

                /* delegate is like a pointer or a reference to a method
                 * It allows you to pass methods as arguments to other methods
                 * store them in variables, and call them later.
                 * This is useful when you want your code to be flexible and
                 * able to handle different behaviors that aren't predetermine.

                 */

                // Define the predicate to check if a number is greater than 10
                Predicate<int> isGreaterThanTen = IsGreaterThanTen; //메서드 호출을 안해서 괄호 없음

                bool hasLargeNumbers = numbers.Any(x => x >= 10);

                if (hasLargeNumbers)
                {
                    Console.WriteLine("large numbers");
                }
                else
                {
                    Console.WriteLine("No large numbers");
                }

                foreach (string color in colors)
                {
                    Console.WriteLine(color);
                }

                Console.ReadKey();

            }
            // A lambda expression consists of 2 parts
            // 1. 파라미터
            // 2. Expression or Statement Block

            // 파라미터는 => 왼쪽에 쓰여짐
            // 이 심볼은 "goes to" 또는 "becomes"로 읽혀짐
            // 포현 또는 액션이 오른쪽에 쓰여짐

            // 이것은 이렇게 읽힘 인풋으로 x 넣고 x * x 를 한다
            // x => x * x;
            static int Squaring(int num1)
            {
                return num1 * num1;
            }

            public static bool IsGreaterThanTen(int x)
            {
                return x > 10;
            }
        }


    }
}
