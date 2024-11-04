namespace Nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nullables");

            int? age = null; // int? is a nullable int
            //자바의 경우 Integer, Long 이런식으로 래퍼클래스 생성해서 널 받았었음

            if (age.HasValue)
            {
                Console.WriteLine($"Age is: {age.Value}");
            }
            else
            {
                Console.WriteLine("Age is not specified");
            }

            Console.ReadKey();
        }
    }
}
