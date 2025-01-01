using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSRP
{
    public class Order
    {
        private int _id;
        private string _productName;
        private int _quantity;
        private double _price;

        public int Id { get { return _id; } }
        public string ProductName { get { return _productName; } }
        public int Quantity { get { return _quantity; } }
        public double Price { get { return _price; } }

        public Order(int id, string productName, int quantity, double price) 
        {
            _id = id;
            _productName = productName;
            _quantity = quantity;
            _price = price;

        }
    }
}
