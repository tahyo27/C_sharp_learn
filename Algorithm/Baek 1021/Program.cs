namespace Baek_1021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            string[] input1 = Console.ReadLine().Split();
            int N = int.Parse(input1[0]);
            int M = int.Parse(input1[1]);
            int count = 0;
            int[] input2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            list.AddRange(Enumerable.Range(1, N));

            for (int i = 0; i < M; i++)
            {
                int targetIdx = list.IndexOf(input2[i]);
                int halfIdx;

                if (list.Count % 2 == 0)
                {
                    halfIdx = list.Count / 2 - 1;
                }
                else
                {
                    halfIdx = list.Count / 2;
                }

                if (targetIdx <= halfIdx)
                {
                    for (int j = 0; j < targetIdx; j++)
                    {
                        int tmp = list.First();
                        list.RemoveAt(0);
                        list.Add(tmp);
                        count++;
                    }
                }
                else
                {
                    for (int j = 0; j < list.Count - targetIdx; j++)
                    {
                        int tmp = list.Last();
                        list.RemoveAt(list.Count - 1);
                        list.Insert(0, tmp);
                        count++;
                    }
                }
                list.RemoveAt(0);
            }
            Console.WriteLine(count);
        }
    }
}
