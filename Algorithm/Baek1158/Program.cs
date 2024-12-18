using System.Text;

namespace Baek1158
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sInput = Console.ReadLine().Split(" ");
            int nN = int.Parse(sInput[0]);
            int nK = int.Parse(sInput[1]);
            LinkedList<int> nList = new LinkedList<int>();
            for (int i = 1; i <= nN; i++)
            {
                nList.AddLast(i);
            }

            LinkedListNode<int> cursor = nList.First;

            StringBuilder sb = new StringBuilder();

            sb.Append("<");
            while (nList.Count > 0)
            {
                for (int i = 0; i < nK - 1; i++)
                {
                    cursor = cursor.Next ?? nList.First;
                }

                if (nList.Count == 1)
                {
                    sb.Append(cursor.Value + ">");
                    break;
                }
                else
                {
                    sb.Append(cursor.Value + ", ");
                }


                if (cursor.Next != null)
                {
                    cursor = cursor.Next;
                    nList.Remove(cursor.Previous);
                }
                else
                {
                    cursor = nList.First;
                    nList.RemoveLast();
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
