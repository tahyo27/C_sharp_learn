namespace Baek1475
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int[] nums = new int[10];
            int sixNine = 0;
            int result = 0;

            // 넣고
            while (input > 0)
            {
                int idx = input % 10;
                nums[idx]++;
                input /= 10;
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 6 || i == 9)
                {
                    continue;
                }
                result = Math.Max(result, nums[i]);
            }
            sixNine = (nums[6] + nums[9] + 1) / 2;
            result = Math.Max(result, sixNine);

            Console.WriteLine(result);
        }
    }
}
