using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15_1
{
    public class Product
    {
        private double basePrice;

        public string GetProductName()
        {
            return GetType().Name;
        }

        public double BasePrice
        {
            get { return basePrice; }
        }

        public int Count { get; set; } = 1;

        protected Product(double price)
        {
            basePrice = price;
        }

        public double GetPrice()
        {
            return BasePrice;
        }
    }

}