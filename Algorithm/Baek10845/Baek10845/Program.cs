namespace Baek10845
{
    internal class Program
    {
        private static LinkedList<int> list = new LinkedList<int>();
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string str = Console.ReadLine();
                if(str.Contains("push"))
                {
                    int num = int.Parse(str.Substring(5));
                    push(num);
                }
                else if(str.Contains("front"))
                {
                    front();
                }
                else if (str.Contains("pop"))
                {
                    pop();
                }
                else if (str.Contains("back"))
                {
                    back();
                }
                else if (str.Contains("size"))
                {
                    size();
                }
                else if (str.Contains("empty"))
                {
                    empty();
                }
            }

        }

        public static void push(int x)
        {
            list.AddLast(x);
        }

        public static void pop()
        {
            if(list.First != null)
            {
                Console.WriteLine(list.First.Value);
                list.RemoveFirst();
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
        public static void size()
        {
            Console.WriteLine(list.Count);
        }
        public static void empty()
        {
            if (list.Count == 0)
            { 
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
        public static void front()
        {
            if (list.First != null)
            {
                Console.WriteLine(list.First.Value);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
        public static void back()
        {
            if(list.Last != null)
            {
                Console.WriteLine(list.Last.Value);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }



    }
}
