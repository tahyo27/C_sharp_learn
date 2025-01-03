namespace Baek_10799
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> st = new Stack<char>();
            int count = 0;

            for(int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals('('))
                {
                    st.Push(input[i]);
                }
                else
                {
                    if (input[i - 1] == '(')
                    {
                        st.Pop();
                        count += st.Count;
                    }
                    else
                    {
                        st.Pop();
                        count++; // 앞에 레이저 있어서 잘린부분 추가
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
