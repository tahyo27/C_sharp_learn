namespace FuncGenericDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Func 는 Action과 다르게 값을 반환해야함

            
            Func<string> getName = () =>
            {
                return "Jannick";
            };

            var myName = getName();
            Console.WriteLine(myName);

            // 마지막으로 들어가는 타입이 return 값
            Func<int, int, string> sum = (x, y) =>
            {
                return (x + y).ToString();
            };

            Console.ReadKey();
        }
    }
}
