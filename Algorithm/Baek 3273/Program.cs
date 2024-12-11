namespace Baek_3273
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nLength = int.Parse(Console.ReadLine());
            string sInput = Console.ReadLine();
            int nX = int.Parse(Console.ReadLine());
            int[] nInput = Array.ConvertAll(sInput.Split(" "), int.Parse);
            int[] nNums = new int[2000001];
            int result = 0;

            for (int i = 0; i < nLength; i++)
            {
                int idx = nInput[i];
                nNums[idx]++;
            }
            for (int i = 1; i < (nX + 1) / 2; i++)
            {
                if (nNums[i] == 1 && nNums[nX - i] == 1)
                {
                    result++;
                }


            }
            Console.WriteLine(result);

        }
    }
}
