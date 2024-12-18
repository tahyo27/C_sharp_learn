using System.Text;

namespace Baek5397
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nN = int.Parse(Console.ReadLine());

            for (int i = 0; i < nN; i++)
            {
                string sInput = Console.ReadLine();
                char[] cInput = sInput.ToCharArray();
                LinkedList<char> cList = new LinkedList<char>();
                LinkedListNode<char> cursor = cList.AddLast(' ');
                foreach (char c in cInput)
                {
                    switch (c)
                    {
                        case '<':
                            if (cursor.Previous != null)
                            {
                                cursor = cursor.Previous;
                            }
                            break;

                        case '>':
                            if (cursor.Next != null)
                            {
                                cursor = cursor.Next;
                            }
                            break;
                        case '-':
                            if (cursor.Previous != null)
                            {
                                cursor = cursor.Previous;
                                cList.Remove(cursor.Next);
                            }
                            break;
                        default:
                            cList.AddAfter(cursor, c);
                            cursor = cursor.Next;
                            break;
                    }
                }
                StringBuilder sb = new StringBuilder();
                foreach (char c in cList)
                {
                    sb.Append(c);
                }

                Console.WriteLine(sb.ToString().Trim());
            }
        }
    }
}
