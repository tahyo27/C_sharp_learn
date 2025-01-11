namespace PredicateGenericDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // predicate는 기본적으로 bool 형식을 반환함

            Predicate<int> isEven = (x) =>
            {
                return x % 2 == 0;
            };

            Console.WriteLine(isEven(5));

            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            var evenInts = ints.FindAll(isEven);

            foreach(var i in evenInts)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
