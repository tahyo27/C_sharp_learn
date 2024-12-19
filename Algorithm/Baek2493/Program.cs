using System.Text;

namespace Baek2493
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nN = int.Parse(Console.ReadLine());
            Stack<KeyValuePair<int, int>> st = new Stack<KeyValuePair<int, int>>();
            int[] nInput = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= nN; i++)
            {
                int height = nInput[i - 1];
                while (st.Count > 0)
                {
                    var kvp = st.Peek();
                    if (kvp.Value > height)
                    {
                        sb.Append($"{kvp.Key} ");
                        break;
                    }
                    st.Pop();
                }
                if (st.Count == 0)
                {
                    sb.Append("0 ");
                }
                st.Push(new KeyValuePair<int, int>(i, height));
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
