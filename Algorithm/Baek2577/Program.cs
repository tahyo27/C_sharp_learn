namespace Baek2577
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nA = int.Parse(Console.ReadLine());
            int nB = int.Parse(Console.ReadLine());
            int nC = int.Parse(Console.ReadLine());
            int[] numCount = new int[10];

            int multiResult = nA * nB * nC;

            while (multiResult > 0)
            {
                int idx = multiResult % 10;
                numCount[idx]++;
                multiResult /= 10;
            }

            foreach (int i in numCount)
            {
                Console.WriteLine(i);
            }
        }
    }
}
