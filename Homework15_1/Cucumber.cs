using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15_1
{
    public class Cucumber : Product
    {
        public int CucumberCount { get; set; } 

        public Cucumber(double basePrice, int count) : base(basePrice)
        {
            CucumberCount = count;
        }

        public double GetCucumberPrice()
        {
            return BasePrice * CucumberCount;
        }
    }
}
