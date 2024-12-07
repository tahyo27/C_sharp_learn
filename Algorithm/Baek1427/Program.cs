namespace Baek1427
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a string of digits:");
            string str = Console.ReadLine();

            
            int[] A = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                A[i] = int.Parse(str[i].ToString());
            }

          
            for (int i = 0; i < A.Length; i++)
            {
                int max = i;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] > A[max])
                    {
                        max = j;
                    }
                }

                if (A[i] < A[max])
                {
                    // Swap
                    int tmp = A[i];
                    A[i] = A[max];
                    A[max] = tmp;
                }
            }

           
            foreach (int num in A)
            {
                Console.Write(num);
            }
        }
    }
}
