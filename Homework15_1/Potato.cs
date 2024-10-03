using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15_1
{
    public class Potato : Product
    {
        public int PotatoCount { get; set; } 

        public Potato(double basePrice, int count) : base(basePrice)
        {
            PotatoCount = count;
        }

        public double GetPotatoPrice()
        {
            return BasePrice * PotatoCount;
        }
    }
}
