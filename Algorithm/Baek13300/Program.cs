namespace Baek13300
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1~6학년까지 묵을 방 남은남 여는 여
            // 한 방에는 같은학생 배정 1명도 가능
            // 한 방에 배정할 수 있는 최대 인원 수 K가 주어졌을 때
            // 모든 학생을 배정하기 위해 필요한 방의 최소 개수
            // 성별 s는 0은 여학생 1은 남학생
            string sinput1 = Console.ReadLine();
            int[] nInput1 = Array.ConvertAll(sinput1.Split(" "), int.Parse);
            int nN = nInput1[0];
            int nK = nInput1[1];
            int result = 0;

            int[] nStudents = new int[13];

            for (int i = 0; i < nN; i++)
            {
                char[] input2 = Console.ReadLine().ToCharArray();
                int idx = input2[2] - '0';
                if (input2[0] == '1')
                {

                    nStudents[idx + 6]++;
                }
                else
                {
                    nStudents[idx]++;
                }

            }

            for (int i = 0; i < nStudents.Length; i++)
            {

                if (nStudents[i] > 0)
                {
                    result += (nStudents[i] + nK - 1) / nK;
                }

            }

            Console.WriteLine(result);
        }
    }
}
