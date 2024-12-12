namespace Baek1919
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] sInput1 = Console.ReadLine().ToCharArray();
            char[] sInput2 = Console.ReadLine().ToCharArray();
            int[] nAlpha = new int[26];
            int result = 0;

            foreach (char c in sInput1)
            {
                nAlpha[c - 'a']++;
            }
            foreach (char c in sInput2)
            {
                nAlpha[c - 'a']--;
            }

            foreach (int i in nAlpha)
            {
                if (i != 0)
                {
                    result += Math.Abs(i);
                }
            }
            Console.WriteLine(result);
        }
    }
}
