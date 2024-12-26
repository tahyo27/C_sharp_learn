namespace CleanCodeApp
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            
            // 명명에 있어서 명확함과 정확성
            // bad
            int n = 0;
            string s = "John";

            //good
            int studentCount = 100;
            string studentName = "John";
            
        }

    }
    class CustomerService // 파스칼 케이스 대문자로 시작
    {
        private const int MAX_CUSTOMERS = 100; // 다 대문자
        public int CustomerCount { get; set; } // 파스칼 prop 파스칼로 씀

        private string lastCustomerName = "John"; // 카멜 프라이빗 및 로컬영역

        public string GetCustomerName(int customerId) //파스칼 매개변수 카멜
        {
            string customerName = "John Doe"; // camelCase
            return customerName;
        }
    }
    class CustomerTestSecond
    {
        private string _customerName = "JohnDoe"; // 헷갈려서 언더바도 추가한듯? 근데 안써도 유효

        public CustomerTestSecond(string customerName)
        {
            _customerName = customerName;
        }
    }

}
