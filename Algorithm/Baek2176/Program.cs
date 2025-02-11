namespace Baek2176
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] board = new int[102, 102];
            int[,] distance = new int[102, 102];
            int[] dx = { 0, 1, 0, -1 };
            int[] dy = { 1, 0, -1, 0 };
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int N = input[0];
            int M = input[1];
            Queue<(int X, int Y)> que = new Queue<(int, int)>();

            for (int i = 0; i < distance.GetLength(0); i++)
            {
                for (int j = 0; j < distance.GetLength(1); j++)
                {
                    distance[i, j] = -1;
                }
            }

            for (int i = 0; i < N; i++)
            {
                string rowInput = Console.ReadLine();
                for (int j = 0; j < M; j++)
                {
                    board[i, j] = rowInput[j] - '0';
                }
            }
            que.Enqueue((0, 0));
            distance[0, 0] = 0;
            while (que.Count != 0)
            {
                var current = que.Dequeue();
                for (int dir = 0; dir < 4; dir++)
                {
                    int nx = current.X + dx[dir];
                    int ny = current.Y + dy[dir];
                    if (nx < 0 || nx >= N || ny < 0 || ny >= M)
                    {
                        continue;
                    }
                    if (distance[nx, ny] >= 0 || board[nx, ny] != 1)
                    {
                        continue;
                    }
                    distance[nx, ny] = distance[current.X, current.Y] + 1;
                    que.Enqueue((nx, ny));
                }
            }
            Console.WriteLine(distance[N - 1, M - 1] + 1); ;
        }
    }
}
