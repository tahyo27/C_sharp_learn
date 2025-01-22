namespace BJ1074
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int N = input[0];
            int r = input[1];
            int c = input[2];

            // int result = Search(N, r, c);
            Console.WriteLine(Search(N, r, c));
        }

        static int Search(int n, int r, int c)
        {
            if (n == 0)
            {
                return 0;
            }
            int half = (int)Math.Pow(2, n - 1);
            if (r < half && c < half)
            {
                return Search(n - 1, r, c);
            }
            if (r < half && c >= half)
            {
                return half * half + Search(n - 1, r, c - half);
            }
            if (r >= half && c < half)
            {
                return 2 * half * half + Search(n - 1, r - half, c);
            }
            return 3 * half * half + Search(n - 1, r - half, c - half);
        }
    }
    
}
