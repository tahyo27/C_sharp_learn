using System.Text;

namespace Baek1406
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sInput1 = Console.ReadLine();
            LinkedList<char> sList = new LinkedList<char>(sInput1);
            sList.AddLast(' ');
            LinkedListNode<char> cursor = sList.Last;

            int nN = int.Parse(Console.ReadLine());

            for (int i = 0; i < nN; i++)
            {
                string[] sInput2 = Console.ReadLine().Split();

                switch (sInput2[0])
                {
                    case "L":
                        if (cursor.Previous != null)
                            cursor = cursor.Previous;
                        break;
                    case "D":
                        if (cursor.Next != null)
                            cursor = cursor.Next;
                        break;
                    case "B":
                        if (cursor.Previous != null)
                            sList.Remove(cursor.Previous);
                        break;
                    case "P":
                        sList.AddBefore(cursor, char.Parse(sInput2[1]));
                        break;
                }
            }
            sList.RemoveLast();
            StringBuilder sb = new StringBuilder();
            foreach(char c in sList)
            {
                sb.Append(c);
            }

            Console.WriteLine(sb);
        }
    }
}
