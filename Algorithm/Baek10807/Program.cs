namespace Baek10807
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nN = int.Parse(Console.ReadLine());
            string sInput = Console.ReadLine();
            int[] nInputNums = Array.ConvertAll(sInput.Split(" "), int.Parse);
            int nSearch = int.Parse(Console.ReadLine()) + 100;
            int[] nAry = new int[201]; // 음수까지 존재함

            for (int i = 0; i < nN; i++)
            {
                nAry[nInputNums[i] + 100]++;
            }
            Console.WriteLine(nAry[nSearch]);
        }
    }
}
