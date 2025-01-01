using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSRP
{
    public class OrderService
    {
        private List<Order> orders = new List<Order>();
        private OrderLogger logger = new OrderLogger();
        private OrderNotifier notifier = new OrderNotifier();

        public void AddOrder(Order order)
        {
            orders.Add(order);
            logger.LogOrder(order);
            notifier.NotifyCustomer(order);
        }

        //private void LogOrder(Order order) // Log나 Notify는 Order에 대해 무관함 주문에대한 등록 제거 책임 과는 다름
        //{
        //    Console.WriteLine($"Order {order.Id} logged.");
        //}

        //private void NotifyCustomer(Order order)
        //{
        //    Console.WriteLine($"Customer notified for order {order.Id}.");
        //}
    }
}
