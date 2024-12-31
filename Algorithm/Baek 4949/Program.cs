namespace Baek_4949
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string strInput = Console.ReadLine();
                
                if(strInput.Equals("."))
                {
                    break;
                }
                Stack<char> st = new Stack<char>();
                bool isPaired = true;
                foreach (char c in strInput)
                {
                    if(c.Equals('(') || c.Equals('['))
                    {
                        st.Push(c);
                    }
                    if(c.Equals(')'))
                    {
                        if(st.Count == 0 || !st.Peek().Equals('('))
                        {
                            isPaired = false;
                            break;
                        }
                        else
                        {
                            st.Pop();
                        }
                    }
                    if (c.Equals(']'))
                    {
                        if (st.Count == 0 || !st.Peek().Equals('['))
                        {
                            isPaired = false;
                            break;
                        }
                        else
                        {
                            st.Pop();
                        }
                    }
                }
                if(st.Count == 0 && isPaired)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
