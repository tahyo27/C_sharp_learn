namespace IEnumerableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            List<string> bookList = new List<string> { "1984", "To Kill a Monkingbird", "The Geat Gatsby" };
            string[] bookArray = { "1984", "To Kill a Monkingbird", "The Geat Gatsby" };

            Console.WriteLine("Book titles from List:");
            library.PrintBookTitles(bookList);

            Console.WriteLine("Book titles from List:");
            library.PrintBookTitles(bookArray);

            Console.ReadKey();

        }
    }
}
