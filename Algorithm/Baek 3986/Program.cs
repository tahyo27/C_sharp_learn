namespace Baek_3986
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < N; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                Stack<char> st = new Stack<char>();

                foreach (char c in input)
                {
                    if (st.Count != 0 && st.Peek().Equals(c))
                    {
                        st.Pop();
                    }
                    else
                    {
                        st.Push(c);
                    }
                }
                if (st.Count == 0)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
