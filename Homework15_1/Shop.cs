using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15_1
{
    public class Shop
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(List<Product> new_products)
        {
            products.AddRange(new_products);
        }

        public void ProductInfo()
        {
            double totalPrice = 0;
            foreach (var item in products)
            {
                Console.Write($"Product: {item.GetProductName()}, Price: {item.BasePrice}");

                if (item is Potato potato)
                {
                    Console.Write($", Count: {potato.PotatoCount}, Total price: {potato.GetPotatoPrice()}");
                    totalPrice += potato.GetPotatoPrice();
                }
                else if (item is Cucumber cucumber)
                {
                    Console.Write($", Count: {cucumber.CucumberCount}, Total price: {cucumber.GetCucumberPrice()}");
                    totalPrice += cucumber.GetCucumberPrice();
                }
                else
                {
                    totalPrice += item.GetPrice();
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Total products price: {totalPrice}");
        }
    }
}
