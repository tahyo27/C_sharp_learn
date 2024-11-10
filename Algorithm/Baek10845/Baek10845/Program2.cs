using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baek10845
{
    internal class Program2
    {

        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); 
            Queue<int> queue = new Queue<int>();
            List<string> results = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "push":
                        int x = int.Parse(command[1]);
                        queue.Enqueue(x);
                        break;

                    case "pop":
                        if (queue.Count > 0)
                            results.Add(queue.Dequeue().ToString());
                        else
                            results.Add("-1");
                        break;

                    case "size":
                        results.Add(queue.Count.ToString());
                        break;

                    case "empty":
                        results.Add(queue.Count == 0 ? "1" : "0");
                        break;

                    case "front":
                        if (queue.Count > 0)
                            results.Add(queue.Peek().ToString());
                        else
                            results.Add("-1");
                        break;

                    case "back":
                        if (queue.Count > 0)
                            results.Add(queue.ToArray()[queue.Count - 1].ToString());
                        else
                            results.Add("-1");
                        break;
                }
            }

            Console.WriteLine(string.Join("\n", results));
        }

    }
}
