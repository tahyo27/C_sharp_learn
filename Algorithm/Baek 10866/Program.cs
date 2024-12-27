namespace Baek_10866
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 10000;
            int[] dat = new int[2 * SIZE + 1];
            int head = SIZE;
            int tail = SIZE;

            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split();

                switch (input[0])
                {
                    case "push_front":
                        dat[--head] = int.Parse(input[1]);
                        break;
                    case "push_back":
                        dat[tail++] = int.Parse(input[1]);
                        break;
                    case "pop_front":
                        if (tail - head == 0)
                        {
                            sb.AppendLine("-1");
                        }
                        else
                        {
                            sb.AppendLine($"{dat[head]}");
                            head++;
                        }
                        break;
                    case "pop_back":
                        if (tail - head == 0)
                        {
                            sb.AppendLine("-1");
                        }
                        else
                        {
                            sb.AppendLine($"{dat[tail - 1]}");
                            tail--;
                        }
                        break;
                    case "size":
                        sb.AppendLine($"{tail - head}");
                        break;
                    case "empty":
                        int tmp = (tail - head) == 0 ? 1 : 0;
                        sb.AppendLine($"{tmp}");
                        break;
                    case "front":
                        sb.AppendLine((tail - head) == 0 ? "-1" : $"{dat[head]}");
                        break;
                    case "back":
                        sb.AppendLine((tail - head) == 0 ? "-1" : $"{dat[tail - 1]}");
                        break;

                }
            }
            Console.WriteLine(sb.ToString());

        }
    }
}
