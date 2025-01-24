namespace ClassPresidentHash
{
    internal class Program
    {
        /*
         * 학급 회장을 뽑는데 후보로 기호 A,B,C,D,E 후보가 등록을 했습니다.
         * 투표 용지에는 반 항색들이 자기가 선택한 후보의 기호(알파벳)가 쓰여져 있으며
         * 선생님은 그 기호를 발표하고 있습니다. 선생님의 발표가 끝난 후 어떤 기호의 후보가
         * 학급 회장이 되었는지 출력하는 프로그램을 작성하세요.
         * 반드시 한 명의 학급회장이 선출되도록 투표결과가 나왔다고 가정합니다.
         */


        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string strInput = Console.ReadLine();

            char answer = ' ';

            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char x in strInput.ToCharArray())
            {
                if (dic.TryGetValue(x, out int count))
                {
                    dic[x] = count + 1;
                }
                else
                {
                    dic[x] = 1;

                }
            }
            int max = int.MinValue;
            foreach(char key in dic.Keys)
            {
                if (dic[key] > max)
                {
                    max = dic[key];
                    answer = key;
                }
            }

            Console.WriteLine(answer);
        }
    }
}
