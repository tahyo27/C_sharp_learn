namespace Baek30802
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 참가자 수 입력
            long N = long.Parse(Console.ReadLine());

            // 각 티셔츠 사이즈별 신청자 수 입력
            long[] shirtCounts = Console.ReadLine().Split().Select(long.Parse).ToArray();

            // 티셔츠와 펜의 묶음 크기 입력
            string input = Console.ReadLine();
            string[] str= input.Split(" ");
            long T = long.Parse(str[0]);
            long P = long.Parse(str[1]);
            // 최소 티셔츠 묶음 수 계산
            long totalShirtBundles = 0;
            foreach (long count in shirtCounts)
            {
                totalShirtBundles += (count + T - 1) / T; // 올림 계산
            }

            // 펜 묶음 수와 잔여 펜 수 계산
            long penBundles = N / P;
            long remainingPens = N % P;

            // 결과 출력
            Console.WriteLine(totalShirtBundles);
            Console.WriteLine($"{penBundles} {remainingPens}");

            Console.ReadKey();

        }
    }
}
