using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSRP
{
    public class OrderNotifier
    {
        public void NotifyCustomer(Order order)
        {
            Console.WriteLine($"Customer notified for order {order.Id}.");
        }
    }
}
