namespace Baek1926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] board = new int[502, 502];
            bool[,] visit = new bool[502, 502];
            int[] dx = { 0, 1, 0, -1 };
            int[] dy = { 1, 0, -1, 0 };
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = input[0];
            int m = input[1];

            for (int i = 0; i < n; i++)
            {
                string rowInput = Console.ReadLine();
                int[] row = rowInput.Split().Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    board[i, j] = row[j];
                }
            }
            int drawCount = 0;
            int maxArea = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (board[i, j] == 0 || visit[i, j])
                    {
                        continue;
                    }
                    drawCount++;
                    Queue<(int X, int Y)> que = new Queue<(int, int)>();
                    visit[i, j] = true;
                    que.Enqueue((i, j));
                    int tempArea = 0;

                    while (que.Count != 0)
                    {
                        tempArea++;
                        var cur = que.Dequeue();
                        for (int dir = 0; dir < 4; dir++)
                        {
                            int nx = cur.X + dx[dir];
                            int ny = cur.Y + dy[dir];
                            if (nx < 0 || nx >= n || ny < 0 || ny >= m)
                            {
                                continue;
                            }
                            if (visit[nx, ny] || board[nx, ny] != 1)
                            {
                                continue;
                            }
                            visit[nx, ny] = true;
                            que.Enqueue((nx, ny));
                        }
                    }
                    maxArea = Math.Max(maxArea, tempArea);
                }
            }
            Console.WriteLine($"{drawCount}\n{maxArea}");

        }
    }
}
