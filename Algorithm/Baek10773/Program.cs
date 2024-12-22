namespace Baek10773
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nK = int.Parse(Console.ReadLine());
            Stack<int> st = new Stack<int>();
            int sum = 0;

            for (int i = 0; i < nK; i++)
            {
                int nInput = int.Parse(Console.ReadLine());
                if (nInput == 0)
                {
                    st.TryPop(out int result);
                }
                else
                {
                    st.Push(nInput);
                }
            }

            while (st.Count > 0)
            {
                sum += st.Pop();
            }

            Console.WriteLine(sum);
        }
    }
}
