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

            Customer customer = new Customer();
            int id = customer.Id;
            
        }

    }
    // 서머리 쓰면 설명 볼 수 있음
    /// <summary>
    /// Represents a customer with Id and Name 
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets the Id of the customer
        /// </summary>
        public int Id { get; }
        /// <summary>
        /// Gets or sets the name of the customer
        /// </summary>
        public string Name { get; }
    }

    class OrderProcessor // 명사
    {
        // 불형식 보통 앞에 is나 has 사용
        private bool hasError = false;
        private bool isValid = true;

        public void ProcessOrder() // 동사형식
        {

        }

        public void PrintOrder()
        {

        }

        public void DeleteOrder()
        {

        }
    }

    /// <summary>
    /// Provides functionalities for handling customers
    /// </summary>
    class CustomerService // 파스칼 케이스 대문자로 시작
    {
         
        private const int MAX_CUSTOMERS = 100; // 다 대문자
        public int CustomerCount { get; set; } // 파스칼 prop 파스칼로 씀

        private string lastCustomerName = "John"; // 카멜 프라이빗 및 로컬영역

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerId">The id for the customer to retrieve</param>
        /// <returns>Returns the customer found by id</returns>
        public string GetCustomerName(int customerId) //파스칼 매개변수 카멜
        {
            string customerName = "John Doe"; // camelCase
            return customerName;
        }

        //public void save() OK이나 최선의 방법은 아님 bad
        //{

        //
        public void SaveCustomer() // good
        {

        }
        // 메서드 이름에 좋은것 Is, Get, Set, Has, Can
        public bool HasError() { return false; }
        public bool CanReceiveEmails() { return true; }
    }
    class CustomerTestSecond
    {
        private string _customerName = "JohnDoe"; // 헷갈려서 언더바도 추가한듯? 근데 안써도 유효

        public CustomerTestSecond(string customerName)
        {
            _customerName = customerName;
        }
    }
    // 좋은 주석과 나쁜 주석

    public class MathUtils
    {
        // Comment

        // Bad : Calculate the factorial number <- 이미 메서드명으로 있는 정보임
        // Not what but Why 무엇인지 적지말고 무슨 일이 일어나고 왜 주요한지 적으라는듯 
        // ex) 재귀 접근방식이 직관적이기 때문에 재귀 접근을 쓰고 있습니다.
        /*
         * 
         * 
         * 
         * 
         */
        public int CalculateFactorial(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * CalculateFactorial(number - 1);
            }
        }
        // 바이너리 서치를 사용하는 이유는 대규모 데이터에서
        // 퍼포먼스를 향상시키기 위함입니다
        public int BinarySearch(int[] sortedArray, int target)
        {
            int left = 0;
            int right = sortedArray.Length - 1;

            while(left <= right)
            {
                int middle = (left + right) / 2;
                if (sortedArray[middle] == target)
                    return middle;
                else if (sortedArray[middle] < target)
                    left = middle + 1;
                else
                    right = middle - 1;
            }
            return -1;
        }
        // TODO: 형식 보기 작업목록에서 확인 가능 미완료 작업 있을때 쓰면 좋음
    }
}
