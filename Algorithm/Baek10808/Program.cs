namespace Baek10808
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] alpha = new int[26];
            string input = Console.ReadLine();

            char[] cInput = input.ToCharArray();

            for (int i = 0; i < cInput.Length; i++)
            {
                int idx = cInput[i] - 97;
                alpha[idx] += 1;
            }
            foreach (int i in alpha)
            {
                Console.Write(i + " ");
            }

        }
    }
}
