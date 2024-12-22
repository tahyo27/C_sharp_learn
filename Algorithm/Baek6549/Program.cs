namespace Baek6549
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<(int idx, int height)> st = new Stack<(int, int)>();
            long result = 0;

            while (true)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                if (input[0] == 0)
                {
                    break;
                }

                for (int i = 0; i < input[0]; i++)
                {
                    int height = input[i + 1];
                    int idx = i;

                    while (st.Count != 0 && st.Peek().height >= height)
                    {
                        result = Math.Max(result, (i - st.Peek().idx) * st.Peek().height);
                        idx = st.Peek().idx;
                        st.Pop();
                    }
                    st.Push((idx, height));
                }

                while (st.Count != 0)
                {
                    result = Math.Max(result, (input[0] - st.Peek().idx) * st.Peek().height);
                    st.Pop();
                }
                Console.WriteLine(result);
            }
    }
}
