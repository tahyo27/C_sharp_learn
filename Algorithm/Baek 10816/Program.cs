namespace Baek_10816
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int NUM = 10_000_000;
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[NUM * 2 + 1];
            int[] input1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int M = int.Parse(Console.ReadLine());
            int[] input2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                int idx = input1[i];
                if (idx < 0)
                {
                    idx = Math.Abs(idx) + NUM;
                }
                numbers[idx]++;
            }

            for (int i = 0; i < M; i++)
            {
                int idx = input2[i];
                if (idx < 0)
                {
                    idx = Math.Abs(idx) + NUM;
                }
                sb.Append($"{numbers[idx]} ");
            }
            Console.WriteLine(sb.ToString().Trim());

        }
    }
}
