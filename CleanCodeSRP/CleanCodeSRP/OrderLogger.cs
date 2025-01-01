using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSRP
{
    public class OrderLogger
    {
        public void LogOrder(Order order)
        {
            Console.WriteLine($"Order {order.Id} logged".);
        }
    }
}
