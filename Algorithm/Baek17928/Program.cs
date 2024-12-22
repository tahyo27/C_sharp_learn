using System.Text;

namespace Baek17928
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Stack<int> st = new Stack<int>();
            int[] result = new int[1000000];
            StringBuilder sb = new StringBuilder();

            for (int i = N - 1; i >= 0; i--)
            {
                while (st.Count != 0 && st.Peek() <= input[i])
                {
                    st.Pop();
                }
                if (st.Count == 0)
                {
                    result[i] = -1;
                }
                else
                {
                    result[i] = st.Peek();
                }
                st.Push(input[i]);

            }
            for (int i = 0; i < N; i++)
            {
                sb.Append($"{result[i]} ");
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
