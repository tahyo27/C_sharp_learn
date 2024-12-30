using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeApp
{
    public enum CustomerType
    {
        Regular,
        Premium,
        Employee
    }
    internal class DiscountCalculator
    {
        private const int DISCOUNT_THRESHOLD = 1000;
        public double CaculateDiscount(CustomerType customerType, double totalAmount)
        {
            double discount = 0;
            switch(customerType)
            {
                case CustomerType.Regular:
                    discount = totalAmount >= DISCOUNT_THRESHOLD ? 0.10 : 0.05;
                    break;
                case CustomerType.Premium:
                    discount = totalAmount >= DISCOUNT_THRESHOLD ? 0.15 : 0.10;
                    break;
                case CustomerType.Employee:
                    discount = totalAmount >= DISCOUNT_THRESHOLD ? 0.20 : 0.15;
                    break;
            }
            return totalAmount * discount;
        }
        //public double CalculateDiscountForRegularCustomer(double totalAmount) 이런형식으로 반복됨
        //{
        //    if(totalAmount > 1000)
        //    {
        //        return totalAmount * 0.1;
        //    }
        //    else
        //    {
        //        return totalAmount * 0.05;
        //    }
        //}
    }
}
