namespace BFS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BFS 너비 우선 탐색 기본 형식
            int[,] board = new int[502, 502]; // 보드판
            bool[,] visit = new bool[502, 502]; // 방문한곳 체크
            int n = 7, m = 10; // 행과 열의 개수

            // 상하좌우를 영리하게 쓰기위한 값들
            int[] dx = { 1, 0, -1, 0 };
            int[] dy = { 0, 1, 0, -1 };
            // BFS는 큐를 활용해서 구현함 여기서는 큐와 튜플 사용해 튜플로 좌표값 활용
            Queue<(int X, int Y)> que = new Queue<(int, int)>();
            // 첫스타트 부분 0,0
            visit[0, 0] = true;
            que.Enqueue((0, 0));

            while (que.Count != 0)
            {
                var cur = que.Peek();
                que.Dequeue();
                Console.WriteLine($"({cur.X}, {cur.Y}) ->");
                for (int dir = 0; dir < 4; dir++) // 상하좌우 체크하는 부분인듯
                {
                    int nx = cur.X + dx[dir];
                    int ny = cur.Y + dx[dir];
                    if (nx < 0 || nx >= n || ny < 0 || ny >= m)
                    { // 제한인부분 조건
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
        }
}
