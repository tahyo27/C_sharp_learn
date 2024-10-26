namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classes App");

            Car audi = new Car("A3", "Audi");
            Car bmw = new Car("i7", "BMW");

            Console.WriteLine("Please enter the Brand name");
            // "SETTING BRAND"
            audi.Brand = Console.ReadLine();

            // "GETTING BRAND"
            Console.WriteLine($"Brand is {audi.Brand}");

            Console.ReadKey();

        }
    }
}
