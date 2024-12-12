namespace Baek11328
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nN = int.Parse(Console.ReadLine());

            for (int i = 0; i < nN; i++)
            {
                string[] sInput = Console.ReadLine().Split(" ");
                char[] cInput1 = sInput[0].ToCharArray();
                char[] cInput2 = sInput[1].ToCharArray();

                bool isPossible = true;

                int[] nAlpha = new int[26];

                foreach (char c in cInput1)
                {
                    nAlpha[c - 'a']++;
                }

                foreach (char c in cInput2)
                {
                    nAlpha[c - 'a']--;
                }

                foreach (int k in nAlpha)
                {
                    if (k != 0)
                    {
                        isPossible = false;
                        break;
                    }
                }

                if (isPossible)
                {
                    Console.WriteLine("Possible");
                }
                else
                {
                    Console.WriteLine("Impossible");
                }

            }
        }
    }
}
